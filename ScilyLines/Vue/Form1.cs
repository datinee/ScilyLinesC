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
    public partial class Form1 : Form
    {

        Mgr monManager;
        MgrLiaison manager;

        List<Secteur> lSec = new List<Secteur>();
        List<Liaison> lLia = new List<Liaison>();



        public Form1()
        {
            InitializeComponent();

            monManager = new Mgr();
            manager = new MgrLiaison();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            lSec = monManager.chargementSecBD();


            affiche();
        }

        public void affiche()

        {


            try
            {


                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = lSec;
                listBoxSecteur.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            listBoxSecteur.Visible = false;
            listBoxLiaison.Visible = true;

        }

        private void listBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            lLia = manager.chargementLiaBD();
            affiche();
        }
    }


}










