using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Liaison
    {
        private int id;
        private int idSecteur;
        private int idPortDepart;
        private int idPortArrivee;
        private int duree;

public Liaison(int unId, int unIdSecteur, int unIdPortDepart, int unIdPortArrivee, int uneDuree)
        {
            this.Id = unId;
            this.IdSecteur = unIdSecteur;
            this.IdPortDepart = unIdPortDepart;
            this.IdPortArrivee = unIdPortArrivee;
            this.Duree = uneDuree;
        }

        public string Description
        {
            get => "Id : " + this.Id + " IdSecteur :" + this.idSecteur + " IdPortDepart :" + this.idPortDepart + " IdPortArrivee :" + this.idPortArrivee + " Duree :" + this.duree;
        }
        public int Id { get => id; set => id = value; }
        public int IdSecteur { get => idSecteur; set => idSecteur = value; }
        public int IdPortDepart { get => idPortDepart; set => idPortDepart = value; }
        public int IdPortArrivee { get => idPortArrivee; set => idPortArrivee = value; }
        public int Duree { get => duree; set => duree = value; }
    }
}
