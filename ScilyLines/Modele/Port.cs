using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Port
    {
        private int id;
        private string nom;
         
        public Port (int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom;
        }
    }

}
