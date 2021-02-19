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

            int rok;

            Console.Write("Podaj rok: ");

            rok = int.Parse(Console.ReadLine());

            if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))

                Console.WriteLine(@"Podany rok jest rokiem przestêpnym.");

            else

                Console.WriteLine(@"Podany rok nie jest rokiem przestêpnym.");

            Console.ReadKey();

        }
    }
}
