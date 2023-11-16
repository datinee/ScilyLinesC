﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Liaison
    {
        private int idLiaison;
        private int idSecteur;
        private string idPortDepart;
        private string idPortArrivee;
        private string duree;

        public Liaison(int idLiaison,int idSecteur, string idPortDepart, string idPortArrivee, string duree)
        {
            this.idLiaison = idLiaison;
            this.idSecteur = idSecteur;
            this.idPortDepart = idPortDepart;
            this.idPortArrivee = idPortArrivee;
            this.duree = duree;
        }

        public string Description
        {
            get => "Liaison n° : " + this.idLiaison + " " +" Port de Depart :" + this.idPortDepart + " " + " Port d'Arrivee :" + this.idPortArrivee + " " + " Duree :" + this.duree;
        }
        public int Id { get => idLiaison; set => idLiaison = value; }
        public string IdPortDepart { get => idPortDepart; set => idPortDepart = value; }
        public string IdPortArrivee { get => idPortArrivee; set => idPortArrivee = value; }
        public string Duree { get => duree; set => duree = value; }
        public int IdSecteur { get => idSecteur; set => idSecteur = value; }
    }
}
