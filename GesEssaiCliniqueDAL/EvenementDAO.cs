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
	public class EvenementDAO
	{
        private static EvenementDAO uneInstance;

        // Cette méthode crée un obj de la classe ClientDAO s'il n'existe pas déja un, puis retourne la ref à cet obj
        public static EvenementDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new EvenementDAO();
            }
            return uneInstance;
        }

        // Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
        private EvenementDAO()
        {

        }
		public List<Evenement> GetEvenements()
		{
			//declaration des variables de travail
			Evenement uneEven;
			int id;
			DateTime dateEven;
			string description;
			int idEtat;
			int idCategEvenement;


			//on crée la collection lesClients de type Liste<Client> qui va contenir les caract des clients enregistrés dans la base de donnes
			List<Evenement> lesEvens = new List<Evenement>();

			// on crée l'objet de type SqlCommand qui va contenir la requête SQL permettant d'obtenir toutes les caracteristiques de tous les clients
			SqlDataReader reader;

			SqlCommand maCommand;

			// on exécute la requête et on récupère dans un DataReader les enregistrements
			maCommand = new SqlCommand("", Connexion.GetObjConnexion());

			maCommand.CommandType = CommandType.StoredProcedure;
			maCommand.CommandText = "spEvenementObt";

			reader = maCommand.ExecuteReader();

			// Pour chaque enregistremens du DataReader on crée un objet instance de Client que l'on ajoute dans la collection lesClients
			while (reader.Read())
			{
				id = (int)reader["id"];

				if (reader["dateEven"] == DBNull.Value)
				{
					dateEven = default(DateTime);
				}
				else
				{
					dateEven = (DateTime)reader["dateEven"];
				}
				if (reader["description"] == DBNull.Value)
				{
					description = default(string);
				}
				else
				{
					description = reader["description"].ToString();
				}

				idEtat = (int)reader["idEtat"];

				idCategEvenement = (int)reader["idCategEvenement"];


				uneEven = new Evenement(id, dateEven, description, new Etat(idEtat, null), new CategEvenement(idCategEvenement, null));
				lesEvens.Add(uneEven);
			}

			// On ferme le DataReader
			reader.Close();

			// On ferme la connexion
			maCommand.Connection.Close();

			// On retourne la commection
			return lesEvens;

		}

	}
}
