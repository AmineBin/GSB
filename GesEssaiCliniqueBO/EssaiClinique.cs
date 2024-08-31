using GesEssaiCliniqueBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class EssaiClinique
    {
        private string numEudract;
        private DateTime dateDebut;
        private DateTime dateArret;
        private string causeArret;
        private DateTime dateAccordAFSSAPS;
        private DateTime dateAccordCPP;
        private DateTime dateFin;
        private CategEssai categEssai;
        private Medicament medicament;
        private CentreHospitalier centreHospitalier;
        private Genre genre;
        private Medecin medecin;
        private GroupeAge groupeAge;

        public string NumEudract
        {
            get { return numEudract; }
            set { numEudract = value; }
        }

        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        public DateTime DateArret
        {
            get { return dateArret; }
            set { dateArret = value; }
        }

        public string CauseArret
        {
            get { return causeArret; }
            set { causeArret = value; }
        }

        public DateTime DateAccordAFSSAPS
        {
            get { return dateAccordAFSSAPS; }
            set { dateAccordAFSSAPS = value; }
        }

        public DateTime DateAccordCPP
        {
            get { return dateAccordCPP; }
            set { dateAccordCPP = value; }
        }

        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }

        public CategEssai CategEssai
        {
            get { return categEssai; }
            set { categEssai = value; }
        }

        public Medicament Medicament
        {
            get { return medicament; }
            set { medicament = value; }
        }

        public CentreHospitalier CentreHospitalier
        {
            get { return centreHospitalier; }
            set { centreHospitalier = value; }
        }

        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public Medecin Medecin
        {
            get { return medecin; }
            set { medecin = value; }
        }

        public GroupeAge GroupeAge
        {
            get { return groupeAge; }
            set { groupeAge = value; }
        }

        public EssaiClinique(string numEudract, DateTime dateDebut, DateTime dateArret, string causeArret, DateTime dateAccordAFSSAPS, DateTime dateAccordCPP, DateTime dateFin, CategEssai categEssai, Medicament medicament, CentreHospitalier centreHospitalier, Genre genre, Medecin medecin, GroupeAge groupeAge)
        {
            NumEudract = numEudract;
            DateDebut = dateDebut;
            DateArret = dateArret;
            CauseArret = causeArret;
            DateAccordAFSSAPS = dateAccordAFSSAPS;
            DateAccordCPP = dateAccordCPP;
            DateFin = dateFin;
            CategEssai = categEssai;
            Medicament = medicament;
            CentreHospitalier = centreHospitalier;
            Genre = genre;
            Medecin = medecin;
            GroupeAge = groupeAge;
        }

        public EssaiClinique(string numEudract)
        {
            NumEudract = numEudract;
        }

        public string DateCategMedicament
        {
            get { return "Date de debut : "+dateDebut+" Date d'arrêt : "+ dateArret+ " Nom de medicament : "+ medicament.Nom; }
        }
    }
}
