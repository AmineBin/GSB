using GesEssaiCliniqueBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueDAL
{
    public class EssaiCliniqueDAO
    {
        private static EssaiCliniqueDAO uneInstance;

        // Cette méthode crée un obj de la classe ClientDAO s'il n'existe pas déja un, puis retourne la ref à cet obj
        public static EssaiCliniqueDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EssaiCliniqueDAO();
            }
            return uneInstance;
        }

        // Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
        private EssaiCliniqueDAO()
        {
        }

        public int AjoutEssaiClinique(EssaiClinique unEssaiClinique)
        {
            // On se connecte à la base de données
            SqlConnection maConnexion = Connexion.GetObjConnexion();

            // On applle la precédure stockée
            SqlCommand maCommand;
            maCommand = new SqlCommand("spEssaiCliniqueAjt", maConnexion);
            maCommand.CommandType = CommandType.StoredProcedure;

            // On prépare les attributs dans la requête
            maCommand.Parameters.Add("numEudract", System.Data.SqlDbType.Int);
            maCommand.Parameters[0].Value = unEssaiClinique.NumEudract;

            maCommand.Parameters.Add("dateDebut", System.Data.SqlDbType.DateTime);
            maCommand.Parameters[1].Value = unEssaiClinique.DateDebut;

            maCommand.Parameters.Add("dateArret", System.Data.SqlDbType.DateTime);
            maCommand.Parameters[2].Value = unEssaiClinique.DateArret;

            maCommand.Parameters.Add("causeArret", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[3].Value = unEssaiClinique.CauseArret;

            maCommand.Parameters.Add("dateAccordAFSSAPS", System.Data.SqlDbType.DateTime);
            maCommand.Parameters[4].Value = unEssaiClinique.DateAccordAFSSAPS;

            maCommand.Parameters.Add("dateAccordCPP", System.Data.SqlDbType.DateTime);
            maCommand.Parameters[5].Value = unEssaiClinique.DateAccordCPP;

            maCommand.Parameters.Add("dateFin", System.Data.SqlDbType.DateTime);
            maCommand.Parameters[6].Value = unEssaiClinique.DateFin;

            maCommand.Parameters.Add("idCategEssai", System.Data.SqlDbType.Int);
            maCommand.Parameters[7].Value = unEssaiClinique.CategEssai.Id;

            maCommand.Parameters.Add("idMedicament", System.Data.SqlDbType.Int);
            maCommand.Parameters[8].Value = unEssaiClinique.Medicament.Id;

            maCommand.Parameters.Add("idCentreHospitalier", System.Data.SqlDbType.Int);
            maCommand.Parameters[9].Value = unEssaiClinique.CentreHospitalier.Id;

            maCommand.Parameters.Add("idGenre", System.Data.SqlDbType.Int);
            maCommand.Parameters[10].Value = unEssaiClinique.Genre.Id;

            maCommand.Parameters.Add("idMedecin", System.Data.SqlDbType.Int);
            maCommand.Parameters[11].Value = unEssaiClinique.Medecin.NumRPPS;

            maCommand.Parameters.Add("idGroupeAge", System.Data.SqlDbType.Int);
            maCommand.Parameters[12].Value = unEssaiClinique.GroupeAge.Id;

            int nbEnregs = maCommand.ExecuteNonQuery();

            maConnexion.Close();
            return nbEnregs;
        }

        public List<EssaiClinique> GetEssaiClinique()
        {
            //declaration des variables de travail
            EssaiClinique unEssaiClinique;
            string numEudract;
            DateTime dateDebut;
            DateTime dateArret;
            string causeArret;
            DateTime dateAccordAFSSAPS;
            DateTime dateAccordCPP;
            DateTime dateFin;
            int idCategEssai;
            int idMedicament;
            int idCentreHospitalier;
            int idGenre;
            int idMedecin;
            int idGroupeAge;

            //on crée la collection lesClients de type Liste<Client> qui va contenir les caract des clients enregistrés dans la base de donnes
            List<EssaiClinique> lesEssaisCliniques = new List<EssaiClinique>();

            // on crée l'objet de type SqlCommand qui va contenir la requête SQL permettant d'obtenir toutes les caracteristiques de tous les clients
            SqlDataReader reader;

            SqlCommand maCommand;

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand = new SqlCommand("", Connexion.GetObjConnexion());

            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = "spEssaiCliniqueObt";

            reader = maCommand.ExecuteReader();

            // Pour chaque enregistremens du DataReader on crée un objet instance de Client que l'on ajoute dans la collection lesClients
            while (reader.Read())
            {
                numEudract = reader["numEudract"].ToString();

                if (reader["dateDebut"] == DBNull.Value)
                {
                    dateDebut = default(DateTime);
                }
                else
                {
                    dateDebut = (DateTime)reader["dateDebut"];
                }
                if (reader["dateArret"] == DBNull.Value)
                {
                    dateArret = default(DateTime);
                }
                else
                {
                    dateArret = (DateTime)reader["dateArret"];
                }
                if (reader["causeArret"] == DBNull.Value)
                {
                    causeArret = default(string);
                }
                else
                {
                    causeArret = reader["causeArret"].ToString();
                }
                if (reader["dateAccordAFSSAPS"] == DBNull.Value)
                {
                    dateAccordAFSSAPS = default(DateTime);
                }

                else
                {
                    dateAccordAFSSAPS = (DateTime)reader["dateAccordAFSSAPS"];
                }
                if (reader["dateAccordCPP"] == DBNull.Value)
                {
                    dateAccordCPP = default(DateTime);
                }
                else
                {
                    dateAccordCPP = (DateTime)reader["dateAccordCPP"];
                }
                if (reader["dateFin"] == DBNull.Value)
                {
                    dateFin = default(DateTime);
                }
                else
                {
                    dateFin = (DateTime)reader["dateFin"];
                }

                idCategEssai = (int)reader["idCategEssai"];
                idMedicament = (int)reader["idMedicament"];
                idCentreHospitalier = (int)reader["idCentreHospitalier"];
                idGenre = (int)reader["idGenre"];
                idMedecin = (int)reader["idMedecin"];
                idGroupeAge = (int)reader["idGroupeAge"];


                unEssaiClinique = new EssaiClinique(numEudract, 
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
                    new Medecin(idMedecin), 
                    new GroupeAge(idGroupeAge, null));

                lesEssaisCliniques.Add(unEssaiClinique);

            }
            // On ferme le DataReader
            reader.Close();

            // On ferme la connexion
            maCommand.Connection.Close();

            // On retourne la commection
            return lesEssaisCliniques;
        }
    }
}
