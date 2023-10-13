using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Connecte.Modele;
using System.Security.Principal;
using System.Diagnostics.Eventing.Reader;

namespace Connecte.DAL
{
    public class SecteurDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "scilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;
    
    public static List<Secteur>getSecteurs()
    {

        List<Secteur> lc = new List<Secteur>();
        try
        {
            maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


            maConnexionSql.openConnection();

            Ocom = maConnexionSql.reqExec("Select * from secteur");


            MySqlDataReader reader = Ocom.ExecuteReader();

            Secteur e;




            while (reader.Read())
            {

                int id = (int)reader.GetValue(0);
                string libelle = (string)reader.GetValue(1);

                //Instanciation d'un Emplye
                e = new Secteur(id, libelle);

                // Ajout de cet employe à la liste 
                lc.Add(e);


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
