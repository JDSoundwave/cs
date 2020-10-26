using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._9.a
{
    class Program
    {
        static void Main(string[] args)
        {
            // wynik = False x = 2 y = 4 z = 2

            int x = 1, y = 4, z = 2;

            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);

            Console.WriteLine("wynik = {0} x = {1} y = {2} z = {3}", wynik, x, y, z);

            Console.ReadKey();

        }
    }
}
