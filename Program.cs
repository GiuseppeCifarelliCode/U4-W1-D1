using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendente = new Dipendente();
            dipendente.Nome = "Giuseppe";
            dipendente.Cognome = "Cifarelli";
            dipendente.Stipendio = 1000;
            dipendente.Bonus = 0.1;
            

            dipendente.GetFullNameProc();
            Console.WriteLine(dipendente.StipendioPiuBonus);

            Animale animale = new Animale();
            animale.nome = "Fuffy";
            animale.age = 100;
            animale.zampe = 4;
            animale.teste = 3;
            animale.printAnimale();

            Studente studente = new Studente();
            studente.nome = "Giuseppe";
            studente.cognome = "Cifarelli";
            studente.voti = [28, 27, 30, 22];
            Console.WriteLine("Media voti=" + studente.media());

            Atleta atleta = new Atleta();
            atleta.nome = "Sebastiano";
            atleta.accelera();
            atleta.accelera();
            atleta.accelera();
            atleta.accelera();
            atleta.accelera();
            atleta.stop();

            Prodotto prodotto = new Prodotto();
            prodotto.nome = "Bugatti";
            prodotto.prezzo = 29999.9;
            prodotto.quantita = 2;
            Console.WriteLine("Prezzo Totale=" + prodotto.calcolaTotale());
            Console.ReadLine() ;

        }
    }
}
