using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wynik wynosi 7

            int x, y = 5;

            x = ++y * 2;

            x = y++;

            x = y--;

            Console.WriteLine(++y);

            Console.ReadKey();
        }
    }
}
