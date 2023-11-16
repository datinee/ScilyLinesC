using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.Modele;

namespace Connecte.DAL
{
    public class PortDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "scilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        public static List<Port> getPorts()
        {

            List<Port> lp = new List<Port>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from port");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Port p;




                while (reader.Read())
                {

                    int idPort = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    p = new Port(idPort, nom);

                    lp.Add(p);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lp);


            }

            catch (Exception sec)
            {

                throw (sec);

            }


        }



    }




}

