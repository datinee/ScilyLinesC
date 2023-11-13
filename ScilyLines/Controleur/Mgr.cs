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

            maListeSecteur = new List<Secteur>();
            maListeLiason = new List<Liaison>();
        }



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

        public void updateLiaison(Liaison l)
        {
            LiaisonDAO.updateLiaison(l);
        }

        public void insertLiaison(Liaison l)
        {
            LiaisonDAO.insertLiaison(l);
        }

        // Appel à la fonction qui supprime une liaiso
        public void deleteLiaison(Liaison l)
        {
            LiaisonDAO.deleteLiaison(l);
        }
    }
}
