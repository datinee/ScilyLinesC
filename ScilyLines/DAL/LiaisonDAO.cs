using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.Modele;
using Org.BouncyCastle.Ocsp;

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


        public static List<Liaison> getLiaisons(List<Port> ports, List<Secteur> secteurs)
        {

            List<Liaison> lc = new List<Liaison>();
            Liaison liaison;

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * from liaison");


                MySqlDataReader reader = Ocom.ExecuteReader();




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    int secteur =(int)reader.GetValue(1);
                    int portDepart = (int)reader.GetValue(2);
                    int portArrivee = (int)reader.GetValue(3);
                    string duree = (string)reader.GetValue(4);

                    liaison = new Liaison(id,secteur, portDepart, portArrivee, duree, ports, secteurs );

                    lc.Add(liaison);


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
        public static void updateLiaison(Liaison liaison)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                string req = "UPDATE liaison set duree = '" + liaison.Duree + "'Where idLiaison = " + liaison.Id;
                Ocom = maConnexionSql.reqExec(req);


                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }
            catch (Exception emp) { throw (emp);}
         }

        public static void deleteLiaison(Liaison liaison)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                ;
                Ocom = maConnexionSql.reqExec("delete from liaison where idLiaison = " + liaison.Id);


                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp) { throw (emp); }
        }
        public static void insertLiaison(Liaison liaison)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                ;
                Ocom = maConnexionSql.reqExec("insert into Liaison(duree, idSecteur, idPortDepart, idPortArrivee) values ('"+ liaison.Secteur.Id + "'," + liaison.  PortDepart.Id +" ," + liaison.PortArrivee.Id + "," + liaison.Duree + ");");

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp) { throw (emp); }
        }
      public static List<Liaison> getLiaisonBySecteur(List<Port> ports, List<Secteur> secteurs, Secteur sec)
        {
            List<Liaison> listeLiaison = new List<Liaison>();
            Liaison liaison;
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("SELECT * FROM liaison where idSecteur = "+ sec.Id );
                MySqlDataReader reader = Ocom.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    int secteur = (int)reader.GetValue(1);
                    int depart = (int)reader.GetValue(2);
                    int arrivee = (int)reader.GetValue(3);
                    string duree = (string)reader.GetValue(4);
                    liaison = new Liaison(id, secteur, depart, arrivee, duree, ports, secteurs);
                    listeLiaison.Add(liaison);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return listeLiaison;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }




}

