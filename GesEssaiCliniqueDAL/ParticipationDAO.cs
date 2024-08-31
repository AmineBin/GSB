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
	public class ParticipationDAO
	{
		private static ParticipationDAO uneInstance;

		//cette methode crée un objet de la lcasse ClientDAO s'il n'éxiste pas déjà un puis retourne la référence à cet objet
		public static ParticipationDAO GetInstance()
		{
			if (uneInstance == null)
			{
				uneInstance = new ParticipationDAO();
			}
			return uneInstance;
		}
		// le conctructeur par défaut est privé : il ne sera donc pas possible de créer un objet à l'extérieur de la classe avec l'instruction new ...
		private ParticipationDAO()
		{

		}

		public int AjoutParticipation(Participation uneParticipation)
		{
			SqlCommand maCommand;

			// on exécute la requête et on récupère dans un DataReader les enregistrements
			maCommand = new SqlCommand("", Connexion.GetObjConnexion());

			// on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
			maCommand.CommandType = CommandType.StoredProcedure;
			maCommand.CommandText = "spParticipationAjt";

			//Les parametres
			maCommand.Parameters.Add("dateSignatureAccord", System.Data.SqlDbType.Date);
			maCommand.Parameters[0].Value = uneParticipation.DateSignatureAccord;

			maCommand.Parameters.Add("montantIndemnisation", System.Data.SqlDbType.Decimal);
			maCommand.Parameters[1].Value = uneParticipation.MontantIndemnisation;

			maCommand.Parameters.Add("idEssaiClinique", System.Data.SqlDbType.Int);
			maCommand.Parameters[2].Value = uneParticipation.EssaiClinique.NumEudract;

			maCommand.Parameters.Add("idPatient", System.Data.SqlDbType.Int);
			maCommand.Parameters[3].Value = uneParticipation.Patient.Id;

			maCommand.Parameters.Add("idEvenement", System.Data.SqlDbType.Int);
			maCommand.Parameters[4].Value = uneParticipation.Evenement.Id;
			// on exécute la requête
			int nb = maCommand.ExecuteNonQuery();

			// on retourne le nombre d'enregistrements ajoutés
			return nb;
		}

		public int SupprParticipation(Participation uneParticipation)
		{
			SqlCommand maCommand;

			// on exécute la requête et on récupère dans un DataReader les enregistrements
			maCommand = new SqlCommand("", Connexion.GetObjConnexion());

			// on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée
			maCommand.CommandType = CommandType.StoredProcedure;
			maCommand.CommandText = "spParticipationSuppr";

			//Les parametres
			maCommand.Parameters.Add("id", System.Data.SqlDbType.Int);
			maCommand.Parameters[0].Value = uneParticipation.Id;

			maCommand.ExecuteNonQuery();

			return 1;
		}

		public List<Participation> GetParticipations()
		{
			//declaration des variables de travail
			Participation uneParticipation;
			int id;
			DateTime dateSignatureAccord;
			decimal montantIndemnisation;
			string nom;
			string prenom;
			DateTime dateEven;
			string libelleEtat;
			string libelleCategEvenement;
			string idEssaiClinique;
			int idPatient;
			int idEvenement;
			int idEtat;
			int idCategEvenement;


			//on crée la collection lesClients de type Liste<Client> qui va contenir les caract des clients enregistrés dans la base de donnes
			List<Participation> lesParticipations = new List<Participation>();

			// on crée l'objet de type SqlCommand qui va contenir la requête SQL permettant d'obtenir toutes les caracteristiques de tous les clients
			SqlDataReader reader;

			SqlCommand maCommand;

			// on exécute la requête et on récupère dans un DataReader les enregistrements
			maCommand = new SqlCommand("", Connexion.GetObjConnexion());

			maCommand.CommandType = CommandType.StoredProcedure;
			maCommand.CommandText = "spParticipationObt";

			reader = maCommand.ExecuteReader();

			// Pour chaque enregistremens du DataReader on crée un objet instance de Client que l'on ajoute dans la collection lesClients
			while (reader.Read())
			{
				id = (int)reader["id"];

				if (reader["dateSignatureAccord"] == DBNull.Value)
				{
					dateSignatureAccord = default(DateTime);
				}
				else
				{
					dateSignatureAccord = (DateTime)reader["dateSignatureAccord"];
				}

				if (reader["montantIndemnisation"] == DBNull.Value)
				{
					montantIndemnisation = default(decimal);
				}
				else
				{
					montantIndemnisation = (decimal)reader["montantIndemnisation"];
				}
				if (reader["nom"] == DBNull.Value)
				{
					nom = default(string);
				}
				else
				{
					nom = reader["nom"].ToString();
				}
				if (reader["prenom"] == DBNull.Value)
				{
					prenom = default(string);
				}
				else
				{
					prenom = reader["prenom"].ToString();
				}
				if (reader["dateEven"] == DBNull.Value)
				{
					dateEven = default(DateTime);
				}
				else
				{
					dateEven = (DateTime)reader["dateEven"];
				}
				if (reader["libelleEtat"] == DBNull.Value)
				{
					libelleEtat = default(string);
				}
				else
				{
					libelleEtat = reader["libelleEtat"].ToString();
				}

				if (reader["libelleCategEvenement"] == DBNull.Value)
				{
					libelleCategEvenement = default(string);
				}
				else
				{
					libelleCategEvenement = reader["libelleCategEvenement"].ToString();
				}

				idEssaiClinique = reader["idEssaiClinique"].ToString();

				idPatient = (int)reader["idPatient"];

				idEvenement = (int)reader["idEvenement"];

				idEtat = (int)reader["idEtat"];

				idCategEvenement = (int)reader["idCategEvenement"];


				uneParticipation = new Participation(id, dateSignatureAccord, montantIndemnisation, new EssaiClinique(idEssaiClinique), new Patient(idPatient, nom, prenom), new Evenement(idEvenement, dateEven, null, new Etat(idEtat, libelleEtat), new CategEvenement(idCategEvenement, libelleCategEvenement)));
				lesParticipations.Add(uneParticipation);
			}



			// On ferme le DataReader
			reader.Close();

			// On ferme la connexion
			maCommand.Connection.Close();

			// On retourne la commection
			return lesParticipations;
		}
	}
}
