using System;
using GesEssaiCliniqueBO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GesEssaiCliniqueDAL
{
	public class PatientDAO
	{
		private static PatientDAO uneInstance;

		// Cette méthode crée un obj de la classe ClientDAO s'il n'existe pas déja un, puis retourne la ref à cet obj
		public static PatientDAO GetInstance()
		{
			if (uneInstance == null)
			{
				uneInstance = new PatientDAO();
			}
			return uneInstance;
		}

		// Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
		private PatientDAO()
		{

		}
		public List<Patient> GetPatient()
		{
			//declaration des variables de travail
			Patient unePatient;
			int id;
			string nom;
			string prenom;
			string telephone;
			string numeroSecu;
			string sexe;
			string dateNaissance;


			//on crée la collection lesClients de type Liste<Client> qui va contenir les caract des clients enregistrés dans la base de donnes
			List<Patient> lesPatients = new List<Patient>();

			// on crée l'objet de type SqlCommand qui va contenir la requête SQL permettant d'obtenir toutes les caracteristiques de tous les clients
			SqlDataReader reader;

			SqlCommand maCommand;

			// on exécute la requête et on récupère dans un DataReader les enregistrements
			maCommand = new SqlCommand("", Connexion.GetObjConnexion());

			maCommand.CommandType = CommandType.StoredProcedure;
			maCommand.CommandText = "spPatientsObt";

			reader = maCommand.ExecuteReader();

			// Pour chaque enregistremens du DataReader on crée un objet instance de Client que l'on ajoute dans la collection lesClients
			while (reader.Read())
			{
				id = (int)reader["id"];

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

				if (reader["telephone"] == DBNull.Value)
				{
					telephone = default(string);
				}
				else
				{
					telephone = reader["telephone"].ToString();
				}
				if (reader["numeroSecu"] == DBNull.Value)
				{
					numeroSecu = default(string);
				}
				else
				{
					numeroSecu = reader["numeroSecu"].ToString();
				}
				if (reader["sexe"] == DBNull.Value)
				{
					sexe = default(string);
				}
				else
				{
					sexe = reader["sexe"].ToString();
				}

				if (reader["dateNaissance"] == DBNull.Value)
				{
					dateNaissance = default(string);
				}
				else
				{
					dateNaissance = reader["dateNaissance"].ToString();
				}

				unePatient = new Patient(id, nom, prenom, telephone, numeroSecu, sexe, dateNaissance);
				lesPatients.Add(unePatient);
			}

			// On ferme le DataReader
			reader.Close();

			// On ferme la connexion
			maCommand.Connection.Close();

			// On retourne la commection
			return lesPatients;

		}
	}
}
