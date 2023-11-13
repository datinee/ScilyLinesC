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

        LiaisonDAO liaDao = new LiaisonDAO();

        List<Liaison> maListeLiason;


        public Mgr()
        {

           
            maListeLiason = new List<Liaison>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Secteur> chargementSecBD()
        {

            maListeSecteur = SecteurDAO.getSecteurs();

            return (maListeSecteur);
        }

        public List<Liaison> chargementLiaBD(Secteur unSec)
        {
            maListeLiason = LiaisonDAO.getLiaisons(unSec);
            return (maListeLiason);
        }

    }
}
