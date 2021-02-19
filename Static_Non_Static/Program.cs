using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Non_Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CzlowiekStatic.ludnosc); // do klasy statycznej można się odwołać od razu

            CzlowiekStatic.ludnosc = 10000;

            Console.WriteLine(CzlowiekStatic.ludnosc);




            Czlowiek obiekt_1 = new Czlowiek(); // do klasy niestatycznej wymagany jest obiekt
            Console.WriteLine(obiekt_1.populacja);

            obiekt_1.populacja = "SPOŁECZNOŚĆ";
            Console.WriteLine(obiekt_1.populacja);

            Czlowiek obiekt_2 = new Czlowiek();
            Console.WriteLine(obiekt_2.populacja);


            Console.WriteLine(Czlowiek.liczba); 


            Console.ReadKey();

        }
    }
}
