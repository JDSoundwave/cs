using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {

            Czlowiek obiekt_1 = new Czlowiek();
            Console.WriteLine(obiekt_1.imie);

            Czlowiek obiekt_2 = new Czlowiek();
            Console.WriteLine(obiekt_2.nazwisko);

            obiekt_1.PrzedstawSie();

            Console.ReadKey();
        }
    }  
}
