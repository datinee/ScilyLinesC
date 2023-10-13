using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using MySql.Data.MySqlClient;
using ScilyLines.Controleur;
using ScilyLines.Modele;

namespace ScilyLines
{
    public partial class Form1 : Form
    {
        Mgr monManager;
        List<Secteur> lSec = new List<Secteur>();

        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr();
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

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
