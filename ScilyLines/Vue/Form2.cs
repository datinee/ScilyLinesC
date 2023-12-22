using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using MySql.Data.MySqlClient;
using Connecte.Controleur;
using Connecte.Modele;


namespace Connecte
{
    public partial class Form2 : Form
    {
        Secteur unSec;
        Mgr monMgr;
        List<Port> listePort ;
        List<Liaison> listeLiaison;


        public Form2(Secteur s)
        {
            InitializeComponent();
            monMgr = new Mgr();

            unSec =  s;
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;

            txtbIdSecteur.Text = Convert.ToString(unSec.Id);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            listeLiaison = monMgr.chargementLiaisonBySecteur(unSec);
            listePort = monMgr.chargementPorts();

            afficherLiaison();
            afficherPort();
        }

        public void afficherLiaison()

        {

            try
            {


                    listBoxLiaison.DataSource = null;
                    listBoxLiaison.DataSource = listeLiaison;
                    listBoxLiaison.DisplayMember = "Description";


                
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void afficherPort()

        {

            try
            {


                listBoxPort.DataSource = null;
                listBoxPort.DataSource = listePort;
                listBoxPort.DisplayMember = "Description";



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnMaj_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
            l.Duree = txtbMajDuree.Text;
            monMgr.updateLiaison(l);
            listeLiaison = monMgr.chargementLiaisonBySecteur(unSec);
            afficherLiaison();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
            monMgr.deleteLiaison(l);
            listeLiaison = monMgr.chargementLiaisonBySecteur(unSec);
            afficherLiaison();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
           
            l.Duree= txtbDuree.Text;
            monMgr.insertLiaison(l);
            listeLiaison = monMgr.chargementLiaisonBySecteur(unSec);
            afficherLiaison();

        }
    }
}
