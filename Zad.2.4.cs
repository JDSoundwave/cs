using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wynikiem bedzie liczba 202, pre-inkrementacja najpierw zwiekszy wartosc do 101 a dopiero pozniej ja pomnozy przez 2

            int x = 100;

            Console.WriteLine(++x * 2);

            Console.ReadKey();
        }
    }
}
