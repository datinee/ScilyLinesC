using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Port
    {
        private int idPort;
        private string nom;
         
        public Port (int idPort, string nom)
        {
            this.IdPort = idPort;
            this.Nom = nom;
        }

        public int IdPort { get => idPort; set => idPort = value; }
        public string Nom { get => nom; set => nom = value; }

        public string Description
        {
            get => "Id : " + this.idPort + " Nom :" + this.nom;
        }
    }

}
