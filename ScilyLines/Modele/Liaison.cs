using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Liaison
    {
        private int idLiaison;
        private Secteur unSecteur;
        private int idPortDepart;
        private int idPortArrivee;
        private int duree;

        public Liaison(int idLiaison, int idPortDepart, int idPortArrivee, int duree)
        {
            this.idLiaison = idLiaison;
            this.idPortDepart = idPortDepart;
            this.idPortArrivee = idPortArrivee;
            this.duree = duree;
        }

        public string Description
        {
            get => "Id : " + this.idLiaison + " " +" IdPortDepart :" + this.idPortDepart + " " + " IdPortArrivee :" + this.idPortArrivee + " " + " Duree :" + this.duree;
        }
        public int Id { get => idLiaison; set => idLiaison = value; }
        public int IdPortDepart { get => idPortDepart; set => idPortDepart = value; }
        public int IdPortArrivee { get => idPortArrivee; set => idPortArrivee = value; }
        public int Duree { get => duree; set => duree = value; }
        public Secteur UnSecteur { get => unSecteur; set => unSecteur = value; }
    }
}
