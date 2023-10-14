using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Connecte.Modele;


namespace Connecte.Controleur
{
    public class MgrLiaison
    {

        LiaisonDAO liaDAO = new LiaisonDAO();

        List<Liaison> maListeLiaison;

        public MgrLiaison()
        {

            maListeLiaison = new List<Liaison>();
        }



        // Récupération de la liste des employés à partir de la DAL
       
        public List<Liaison> chargementLiaBD()
        {

            maListeLiaison = LiaisonDAO.getLiaisons();

            return (maListeLiaison);
        }

    }
}
