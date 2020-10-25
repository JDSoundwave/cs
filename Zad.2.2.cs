using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, DELTA;

                Console.WriteLine("Podaj wartosc A:");

            A = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj wartosc B:");

            B = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj wartosc C:");

            C = double.Parse(Console.ReadLine());

                DELTA = ((B * B) - (4 * A * C));

                Console.WriteLine("DELTA = " + DELTA);

            Console.ReadKey();
        }
    }
}
