using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class CentreHospitalier
    {
        private int id;
        private string nom;
        private string rue;
        private Ville ville;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Rue
        {
            get { return rue; }
            set { rue = value; }
        }

        public Ville Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public CentreHospitalier(int id, string nom, string rue, Ville ville)
        {
            Id = id;
            Nom = nom;
            Rue = rue;
            Ville = ville;
        }
    }
}
