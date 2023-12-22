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
        private Secteur secteur;
        private Port portDepart;
        private Port portArrivee;
        private string duree;
        List<Port> ports = new List<Port>();
        List<Secteur> secteurs = new List<Secteur>();

        public Liaison(int id,int idSecteur, int portDepart, int portArrivee, string duree, List<Port> ports, List<Secteur> secteurs)
        {
            this.id = id;
            this.secteur = secteurs.FirstOrDefault(p=>p.Id == idSecteur);
            this.portDepart = ports.FirstOrDefault(p =>p.Id==portDepart);
            this.portArrivee = ports.FirstOrDefault(p=>p.Id==portArrivee);
            this.duree = duree;
        }
         public Liaison(int id, string duree)
        {
            this.id = id;
            this.duree = duree;
        }

        public string Description
        {
            get => "Liaison n° : " + this.id + " " +" Port de Depart :" + portDepart.Nom + " " + " Port d'Arrivee :" + portArrivee.Nom + " " + " Duree :" + this.duree;
        }
        public int Id { get => id; set => id = value; }
        public Port  PortDepart { get => PortDepart; set => PortDepart = value; }
        public Port PortArrivee { get => PortArrivee; set => PortArrivee = value; }
        public string Duree { get => duree; set => duree = value; }
        public Secteur Secteur { get => secteur; }
    }
}
