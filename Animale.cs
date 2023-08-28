using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Animale
    {
        public string nome { get; set; }
        public int age { get; set; }

        public int zampe { get; set; }

        public int teste { get; set; }

        public void printAnimale()
        {
            Console.WriteLine("nome=" + nome);
            Console.WriteLine("eta=" + age);
            Console.WriteLine("zampe=" + zampe);
            Console.WriteLine("teste=" + teste);
        }
    }
}
