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

        Mgr monMgr;

        List<Secteur> lSec = new List<Secteur>();



        public Form1()
        {
            InitializeComponent();

            monMgr = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            lSec = monMgr.chargementSecBD();


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
            Secteur s = (Secteur)listBoxSecteur.SelectedItem;
            Form2 Form2 = new Form2(s);
            Form2.ShowDialog();
            

        }

    }


}










