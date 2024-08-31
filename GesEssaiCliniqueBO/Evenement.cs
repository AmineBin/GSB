using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class Evenement
    {
        private int id;
        private DateTime dateEven;
        private string description;
        private Etat etat;
        private CategEvenement categEvenement;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DateEven
        {
            get { return dateEven; }
            set { dateEven = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Etat Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        public CategEvenement CategEvenement
        {
            get { return categEvenement; }
            set { categEvenement = value; }
        }

        public Evenement(int id, DateTime dateEven, string description, Etat etat, CategEvenement categEvenement)
        {
            Id = id;
            DateEven = dateEven;
            Description = description;
            Etat = etat;
            CategEvenement = categEvenement;
        }

        public Evenement(int id)
        {
            Id = id;

        }

        public string DateCategorie
        {
            get { return dateEven+ "" + categEvenement.Libelle; }
        }
    }
}
