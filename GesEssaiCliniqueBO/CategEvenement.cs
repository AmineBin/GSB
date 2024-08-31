using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class CategEvenement
    {
        private int id;
        private string libelle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public CategEvenement(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
    }
}
