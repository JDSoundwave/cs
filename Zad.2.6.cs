using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wynik wynosi 3

            int x, y = 4;

            x = (y -= 2);

            x = y++;

            x = y--;

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
