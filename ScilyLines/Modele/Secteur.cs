using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Secteur
    {
        private int idSecteur;
        private string libelle;


        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)
        public string Libelle { get => libelle; set => libelle = value; }

        // remplace getId()
        public int IdSecteur { get => idSecteur; }


        public Secteur(int unId, string unLibelle)
        {
            this.idSecteur = unId;
            this.libelle = unLibelle;
        }

        // Constructeur vide
        public Secteur()
        {


        }


        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.idSecteur + " Nom :" + this.libelle;
        }
    }
}
