using GesEssaiCliniqueBO;
using GesEssaiCliniqueDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBLL
{
    public class EssaiCliniqueManager
    {
        private static EssaiCliniqueManager uneInstance;

        // Cette méthode crée un obj de la classe ClientManager, s'il n'existe pas déja un, puis retourne la ref à cet obj
        public static EssaiCliniqueManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EssaiCliniqueManager();
            }
            return uneInstance;
        }

        // Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
        private EssaiCliniqueManager()
        {
        }

        // Apl de la couche DAL pour créer un nvo client
        public int CreerEssaiClinique(
            string numEudract,
            DateTime dateDebut,
            DateTime dateArret,
            string causeArret,
            DateTime dateAccordAFSSAPS,
            DateTime dateAccordCPP,
            DateTime dateFin,
            int idCategEssai,
            int idMedicament,
            int idCentreHospitalier,
            int idGenre,
            int idMedecin,
            int idGroupeAge
         )
        {
            EssaiClinique lEssaiClinique;
            lEssaiClinique = new EssaiClinique(
                numEudract,
                dateDebut,
                dateArret,
                causeArret,
                dateAccordAFSSAPS,
                dateAccordCPP,
                dateFin,
                new CategEssai(idCategEssai, null),
                new Medicament(idMedicament, null),
                new CentreHospitalier(idCentreHospitalier, null, null, null),
                new Genre(idGenre, null),
                new Medecin(idMedecin, null, null, null, null, null),
                new GroupeAge(idGroupeAge, null)
         );
            return EssaiCliniqueDAO.GetInstance().AjoutEssaiClinique(lEssaiClinique);
        }

        public List<EssaiClinique> GetEssaiclinique()
        {
            // Ici, on peut appliquer des règles métier
            return EssaiCliniqueDAO.GetInstance().GetEssaiClinique();
        }
    }
}
