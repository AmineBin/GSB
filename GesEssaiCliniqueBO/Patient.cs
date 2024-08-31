using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class Patient
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string numeroSecu;
        private string sexe;
        private string dateNaissance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string NumeroSecu
        {
            get { return numeroSecu; }
            set { numeroSecu = value; }
        }

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public string DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public Patient(int id, string nom, string prenom, string telephone, string numeroSecu, string sexe, string dateNaissance)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            NumeroSecu = numeroSecu;
            Sexe = sexe;
            DateNaissance = dateNaissance;
        }
        public Patient(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom= prenom;
        }

        public string InfoPatient
        {
            get { return nom+" "+prenom+" "+numeroSecu; }
        }
    }
}
