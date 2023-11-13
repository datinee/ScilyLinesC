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

            afficher();
        }

        public void afficher()

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

        private void btnMaj_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
            l.Duree = txtbMajDuree.Text;
            monMgr.updateLiaison(l);
            lLia = monMgr.chargementLiaBD(unSec);
            afficher();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
            monMgr.deleteLiaison(l);
            lLia = monMgr.chargementLiaBD(unSec);
            afficher();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            Liaison l = (Liaison)listBoxLiaison.SelectedItem;
            l.IdPortDepart = Convert.ToInt32(txtbPortD.Text);
            l.IdPortArrivee = Convert.ToInt32(txtbPortA.Text);
            l.Duree= txtbDuree.Text;
            monMgr.insertLiaison(l);
            lLia = monMgr.chargementLiaBD(unSec);
            afficher();

        }
    }
}
