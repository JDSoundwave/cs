using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Właściwości_klas
{
    class Program
    {
        static void Main(string[] args)
        {

            Czlowiek obiekt_1 = new Czlowiek();

            obiekt_1.imie = "HENIEK";

            obiekt_1.Wiek = 46;
            //obiekt_1.Wiek = -146;

            Console.WriteLine($"Jestem {obiekt_1.imie} i mam {obiekt_1.Wiek} lat.");


            Console.WriteLine("---------------------------");


            obiekt_1.imie = "JUREK";

            obiekt_1.setWiek(26);
            //obiekt_1.Wiek = -6;

            Console.WriteLine($"Jestem {obiekt_1.imie} i mam {obiekt_1.getWiek()} lat.");



            Console.ReadKey();
        }
    }
}
