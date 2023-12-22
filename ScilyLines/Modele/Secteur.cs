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


        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)
        public string Libelle { get => libelle; set => libelle = value; }

        // remplace getId()
        public int Id { get => id; }


        public Secteur(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }



        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.libelle;
        }
    }
}
