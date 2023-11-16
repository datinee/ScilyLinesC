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

        List<Port> lPort = new List<Port>();
        List<Liaison> lLia = new List<Liaison>();

        public Form2(Secteur s)
        {
            InitializeComponent();
            monMgr = new Mgr();

            unSec =  s;
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;

            txtbIdSecteur.Text = Convert.ToString(unSec.IdSecteur);

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            lLia = monMgr.chargementLiaBD(unSec);
            lPort = monMgr.chargementPortBD();

            afficherLiaison();
            afficherPort();
        }

        public void afficherLiaison()

        {

            try
            {


                    listBoxLiaison.DataSource = null;
                    listBoxLiaison.DataSource = lLia;
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
                listBoxPort.DataSource = lPort;
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
            lLia = monMgr.chargementLiaBD(unSec);
            afficherLiaison();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
            monMgr.deleteLiaison(l);
            lLia = monMgr.chargementLiaBD(unSec);
            afficherLiaison();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
            l.IdPortDepart = txtbPortD.Text;
            l.IdPortArrivee = txtbPortA.Text;
            l.Duree= txtbDuree.Text;
            monMgr.insertLiaison(l);
            lLia = monMgr.chargementLiaBD(unSec);
            afficherLiaison();

        }
    }
}
