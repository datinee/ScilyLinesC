using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.Modele;

namespace Connecte.DAL
{
    public class SecteurDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "scilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Récupération de la liste des employés
        public static List<Secteur> getSecteurs()
        {

            List<Secteur> listeSecteurs = new List<Secteur>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur secteur;




                while (reader.Read())
                {

                    int idSecteur = (int)reader.GetValue(0);
                    string libelle = (string)reader.GetValue(1);
                    secteur = new Secteur(idSecteur, libelle);

                    listeSecteurs.Add(secteur);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (listeSecteurs);


            }

            catch (Exception sec)
            {

                throw (sec);

            }


        }
       


    }




}

