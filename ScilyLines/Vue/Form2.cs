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
        Secteur unSecteur;
        Mgr monMgr;


        List<Liaison> lLia = new List<Liaison>();

        public Form2(Secteur s)
        {
            InitializeComponent();
            monMgr = new Mgr();

            unSecteur =  s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            lLia = monMgr.chargementLiaBD(unSecteur);

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

    }
}