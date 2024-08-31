using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueDAL
{
    public class Connexion
    {
        static private SqlConnection objConnex;

        // Le constructeur statique (apl une seule fois)
        // crée un objet instance de la classe SqlConnection
        static Connexion()
        {
            objConnex = new SqlConnection();
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["EssaisCliniques"].ConnectionString;
        }

        // La méthode GetObjConnexion fournit l'objet instance de la classe SqlConnection dans un état "connexion ouverte"
        public static SqlConnection GetObjConnexion()
        {
            // On ouvre la co si elle est fermée
            if (objConnex.State == System.Data.ConnectionState.Closed)
            {
                objConnex.Open();
            }
            // On retourne l'objet de la connexion
            return objConnex;
        }

        // La méthode CloseConnexion met l'objet instance de la classe SqlConnection dans un état "connexion fermée"
        public static void CloseConnexion()
        {
            // On ferme si la co est ouverte
            if (objConnex != null && objConnex.State != System.Data.ConnectionState.Closed)
            {
                objConnex.Close();
            }
        }
    }
}
