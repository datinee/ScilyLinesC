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


        PortDAO portDAO = new PortDAO();
        List<Port> maListePort;


        public Mgr()
        {

            maListeSecteur = new List<Secteur>();
            maListeLiason = new List<Liaison>();
            maListePort = new List<Port>();
        }



        public List<Secteur> chargementSecBD()
        {

            maListeSecteur = SecteurDAO.getSecteurs();

            return (maListeSecteur);
        }

        public List<Liaison> chargementLiaBD(Secteur idSec)
        {
            maListeLiason = LiaisonDAO.getLiaisons(idSec);
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

        public List<Port> chargementPortBD()
        {

            maListePort = PortDAO.getPorts() ;

            return (maListePort);
        }
    }
}
