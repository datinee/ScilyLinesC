using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.Modele;

namespace Connecte.DAL
{
    public class LiaisonDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "scilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Récupération de la liste des employés
        public static List<Liaison> getLiaisons()
        {

            List<Liaison> lc = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    int idSecteur = (int)reader.GetValue(1);
                    int idPortDepart = (int)reader.GetValue(2);
                    int idPortArrivee = (int)reader.GetValue(3);
                    int duree = (int)reader.GetValue(4);

                    //Instanciation d'un Emplye
                    l = new Liaison(id, idSecteur, idPortDepart, idPortArrivee, duree);

                    // Ajout de cet employe à la liste 
                    lc.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception sec)
            {

                throw (sec);

            }


        }

    }




}

