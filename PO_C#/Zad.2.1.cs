using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel, stopnie;

            Console.WriteLine("Ile stopni Celsjusza powinienem zamienic na stopnie Fahrenheita: ");

            cel = double.Parse(Console.ReadLine());

            stopnie = 32 + (9 / 5) * cel;

            Console.WriteLine(stopnie);

            Console.ReadKey();
        }
    }
}
