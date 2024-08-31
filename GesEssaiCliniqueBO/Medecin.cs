using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class Medecin
    {
        private int numRPPS;
        private string nom;
        private string prenom;
        private string mel;
        private Specialite specialite;
        private CentreHospitalier centreHospitalier;

        public int NumRPPS
        {
            get { return numRPPS; }
            set { numRPPS = value; }
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

        public string Mel
        {
            get { return mel; }
            set { mel = value; }
        }

        public Specialite Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }

        public CentreHospitalier CentreHospitalier
        {
            get { return centreHospitalier; }
            set { centreHospitalier = value; }
        }

        public Medecin(int numRPPS, string nom, string prenom, string mel, Specialite specialite, CentreHospitalier centreHospitalier)
        {
            NumRPPS = numRPPS;
            Nom = nom;
            Prenom = prenom;
            Mel = mel;
            Specialite = specialite;
            CentreHospitalier = centreHospitalier;
        }

		public Medecin(int numRPPS)
		{
			this.numRPPS = numRPPS;
		}
	}
}
