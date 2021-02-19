using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._9.d
{
    class Program
    {
        static void Main(string[] args)
        {
            // wynik = True, x = 1, y = 3, z = 4

            int x = 1, y = 3, z = 4;

            bool wynik = (x == 1 || y++ > 2 || ++z > 0);

            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.ReadKey();
        }
    }
}
