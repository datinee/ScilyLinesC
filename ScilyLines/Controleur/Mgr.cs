using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Connecte.Modele;


namespace Connecte.Controleur
{
    public class Mgr
    {

        SecteurDAO secDAO = new SecteurDAO();

        List<Secteur> maListeSecteur;


        public Mgr()
        {

            maListeSecteur = new List<Secteur>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Secteur> chargementSecBD()
        {

            maListeSecteur = SecteurDAO.getSecteurs();

            return (maListeSecteur);
        }

    }
}
