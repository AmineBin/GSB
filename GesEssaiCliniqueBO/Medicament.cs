using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class Medicament
    {
        private int id;
        private string nom;

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

        public Medicament(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}
