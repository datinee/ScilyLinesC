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
        SecteurDAO esecDAO = new SecteurDAO();

        List<Secteur> maListeSecteur;

        public Mgr() {
            maListeSecteur = new List<Secteur>();
                }

        public List<Secteur> chargementSecBD()
        {
            maListeSecteur = SecteurDAO.;
            return (maListeSecteur);
        }
    }
}
