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

            int x, y, z;

            Console.WriteLine("Podaj trzy liczby:");

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            int m;
            m = x;

            if (y > m) m = y;
            if (z > m) m = z;

            Console.WriteLine(@"Najwiêksza liczba to: " + m);

            Console.ReadKey();

        }
    }
}
