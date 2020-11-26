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

                Console.Write(@"Podaj swoj¹ œredni¹: ");

            srednia = Convert.ToDouble(Console.ReadLine());

            if (srednia > 4.80 && srednia < 5.00)

                Console.WriteLine(@"Przys³uguje tobie stypendium w wysokoœci - 550 z³.");

            else if (srednia > 4.00 && srednia < 4.79)

                Console.WriteLine(@"Przys³uguje tobie stypendium w wysokoœci - 350 z³.");

            else

                Console.WriteLine(@"Nie przys³uguje tobie stypendium.");

            Console.ReadKey();

        }
    }
}
