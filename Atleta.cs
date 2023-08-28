using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Atleta
    {
        public string nome { get; set; }
        public double velocita;

        public void accelera() {
            velocita += 2;
            Console.WriteLine("Velocita attuale = "+velocita);
        }

        public void stop()
        {
            velocita = 0;
        }
    }
}
