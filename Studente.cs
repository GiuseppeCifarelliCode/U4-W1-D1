using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Studente
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int[] voti { get; set; }
        private int avg = 0;

        public int media()
        {
            for (int i = 0; i < voti.Length; i++)
            {
                avg += voti[i];
            }
            return avg/voti.Length;
        }
    }
}
