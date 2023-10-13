using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Secteur
    {
        private int id;
        private string libelle;

        public int Id { get => id;}
        public string Libelle { get => libelle;}

        public Secteur (int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public string Description
        {
         get=>"Id : " + this.id + "Libelle : "+ this.libelle;
        }
    }
}
