using GesEssaiCliniqueBO;
using System;
using GesEssaiCliniqueDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBLL
{
	public class EvenementManager
	{
		private static EvenementManager uneInstance;

		// Cette méthode crée un obj de la classe CategSocioManager, s'il n'existe pas déja un, puis retourne la ref à cet obj
		public static EvenementManager GetInstance()
		{
			if (uneInstance == null)
			{
				uneInstance = new EvenementManager();
			}
			return uneInstance;
		}

		// Le constructeur par défaut est privé : il ne sera donc pas possible de créer un obj à l'extérieur de la classe avec l'instruction new...
		private EvenementManager()
		{
		}

		// Appel de la couche DAL pour récupérer une collection de ctagories
		public List<Evenement> GetEvenements()
		{
			// Ici, on peut appliquer des règles métier
			return EvenementDAO.GetInstance().GetEvenements();
		}

	}
}
