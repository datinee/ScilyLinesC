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


        public static List<Liaison> getLiaisons(Secteur unSec)
        {

            List<Liaison> lc = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                ;
                Ocom = maConnexionSql.reqExec("SELECT * FROM liaison join secteur on secteur.idSecteur = liaison.idSecteur where liaison.idSecteur= " + unSec.IdSecteur);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;



                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    int idPortDepart = (int)reader.GetValue(1);
                    int idPortArrivee = (int)reader.GetValue(2);
                    string duree = (string)reader.GetValue(3);

                    l = new Liaison(id, idPortDepart, idPortArrivee, duree);

                    lc.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }




}

