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

        SecteurDAO empDAO = new SecteurDAO();

        List<Secteur> maListeEmploye;

        public Mgr()
        {

            maListeEmploye = new List<Secteur>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Secteur> chargementEmpBD()
        {

            maListeEmploye = SecteurDAO.getEmployes();

            return (maListeEmploye);
        }


        // Mise à jour d'un employé  dans la DAL
        public void updateEmploye(Secteur e)
        {

            SecteurDAO.updateEmploye(e);

        }

    }
}
