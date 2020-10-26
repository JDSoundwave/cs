using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int powierzchnia = 100, osoby = 10;

            double gestoscZaludnienia = osoby / (double)powierzchnia; // dodajemy double przed jedna ze zmiennych

            Console.WriteLine(gestoscZaludnienia);

            Console.ReadKey();
        }
    }
}
