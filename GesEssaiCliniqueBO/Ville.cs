using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesEssaiCliniqueBO
{
    public class Ville
    {
        private int numInsee;
        private string nomVille;
        private string codePostal;

        public int NumInsee
        {
            get { return numInsee; }
            set { numInsee = value; }
        }

        public string NomVille
        {
            get { return nomVille; }
            set { nomVille = value; }
        }

        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        public Ville(int numInsee, string nomVille, string codePostal)
        {
            NumInsee = numInsee;
            NomVille = nomVille;
            CodePostal = codePostal;
        }
    }
}
