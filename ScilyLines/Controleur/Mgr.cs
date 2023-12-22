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
        LiaisonDAO liaisonDao = new LiaisonDAO();
        PortDAO portDAO = new PortDAO();


        List<Secteur> listeSecteur;
        List<Liaison> listeLiaison;
        List<Port> listePort;


        public Mgr()
        {

            listeSecteur = new List<Secteur>();
            listeLiaison = new List<Liaison>();
            listePort = new List<Port>();
        }
        public List<Port> chargementPorts()
        {

            listePort = PortDAO.getPorts();

            return (listePort);
        }


        public List<Secteur> chargementSecteurs()
        {

            listeSecteur = SecteurDAO.getSecteurs();

            return (listeSecteur);
        }

        public List<Liaison> chargementLiaisons()
        {
            listeLiaison = LiaisonDAO.getLiaisons(listePort, listeSecteur);
            return (listeLiaison);
        }

        public List<Liaison> chargementLiaisonBySecteur(Secteur sec)
        {
            listeSecteur = SecteurDAO.getSecteurs();
            listePort = PortDAO.getPorts();
            listeLiaison= LiaisonDAO.getLiaisonBySecteur(listePort, listeSecteur, sec);
            return (listeLiaison);
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
