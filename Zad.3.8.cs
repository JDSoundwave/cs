using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    class Program
    {
        static void Main(string[] args)
        {

            double srednia;

                Console.Write(@"Podaj swoj� �redni�: ");

            srednia = Convert.ToDouble(Console.ReadLine());

            if (srednia > 4.80 && srednia < 5.00)

                Console.WriteLine(@"Przys�uguje tobie stypendium w wysoko�ci - 550 z�.");

            else if (srednia > 4.00 && srednia < 4.79)

                Console.WriteLine(@"Przys�uguje tobie stypendium w wysoko�ci - 350 z�.");

            else

                Console.WriteLine(@"Nie przys�uguje tobie stypendium.");

            Console.ReadKey();

        }
    }
}
