using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class Participation
    {
        private int id;
        private DateTime dateSignatureAccord;
        private decimal montantIndemnisation;
        private EssaiClinique essaiClinique;
        private Patient patient;
        private Evenement evenement;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DateSignatureAccord
        {
            get { return dateSignatureAccord; }
            set { dateSignatureAccord = value; }
        }

        public decimal MontantIndemnisation
        {
            get { return montantIndemnisation; }
            set { montantIndemnisation = value; }
        }

        public EssaiClinique EssaiClinique
        {
            get { return essaiClinique; }
            set { essaiClinique = value; }
        }

        public Patient Patient
        {
            get { return patient; }
            set { patient = value; }
        }

        public Evenement Evenement
        {
            get { return evenement; }
            set { evenement = value; }
        }

        public Participation(int id, DateTime dateSignatureAccord, decimal montantIndemnisation, EssaiClinique essaiClinique, Patient patient, Evenement evenement)
        {
            Id = id;
            DateSignatureAccord = dateSignatureAccord;
            MontantIndemnisation = montantIndemnisation;
            EssaiClinique = essaiClinique;
            Patient = patient;
            Evenement = evenement;
        }

		public Participation(DateTime dateSignatureAccord, decimal montantIndemnisation, EssaiClinique essaiClinique, Patient patient, Evenement evenement)
		{
			this.dateSignatureAccord = dateSignatureAccord;
			this.montantIndemnisation = montantIndemnisation;
			this.essaiClinique = essaiClinique;
			this.patient = patient;
			this.evenement = evenement;
		}

        public string InfoEssaiClinique
        {
            get => EssaiClinique.NumEudract;
		}

        public string InfoPatient
        {
            get => " "+Patient.Nom+" "+Patient.Prenom;
        }

        public string InfoEvenement
        {
            get => "Date : "+Evenement.DateEven+
                " Etat : "+ Evenement.Etat.Libelle+
                " Catégorie : "+Evenement.CategEvenement.Libelle;
        }

    }
}
