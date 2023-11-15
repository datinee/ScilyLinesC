﻿using System;
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


        public static List<Liaison> getLiaisons(Secteur idSec)
        {

            List<Liaison> lc = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                ;
                Ocom = maConnexionSql.reqExec("SELECT * FROM liaison  where liaison.idSecteur= " + idSec.IdSecteur);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;



                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    int idSecteur =(int)reader.GetValue(1);
                    int idPortDepart = (int)reader.GetValue(2);
                    int idPortArrivee = (int)reader.GetValue(3);
                    string duree = (string)reader.GetValue(4);

                    l = new Liaison(id,idSecteur, idPortDepart, idPortArrivee, duree);

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
        public static void updateLiaison(Liaison l)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                string req = "UPDATE liaison set duree = '" + l.Duree + "'Where idLiaison = " + l.Id;
                Ocom = maConnexionSql.reqExec(req);


                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }
            catch (Exception emp) { throw (emp);}
         }

        public static void deleteLiaison(Liaison l)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                ;
                Ocom = maConnexionSql.reqExec("delete from liaison where idLiaison = " + l.Id);


                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp) { throw (emp); }
        }
        public static void insertLiaison(Liaison l)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                ;
                Ocom = maConnexionSql.reqExec("insert into Liaison(duree, idSecteur, idPortDepart, idPortArrivee) values ('"+ l.Duree + "'," + l.IdSecteur +" ," + l.IdPortDepart + "," + l.IdPortArrivee + ");");

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp) { throw (emp); }
        }



    }




}

