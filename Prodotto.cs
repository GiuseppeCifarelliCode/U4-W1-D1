using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Prodotto
    {
        public string nome { get; set; }
        public double prezzo { get; set; }
        public int quantita { get; set; }

        public double calcolaTotale()
        {
            return prezzo * quantita;
        }
    }
}
