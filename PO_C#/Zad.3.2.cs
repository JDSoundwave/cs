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

            int x, y;

            Console.Write("Podaj pierwsza liczbe: ");

            x = int.Parse(Console.ReadLine());

            Console.Write("Podaj druga liczbe: ");

            y = int.Parse(Console.ReadLine());


            while (y == 0)
            {

                Console.WriteLine("NIE DZIEL PRZEZ -->> 0 !!!");

                Console.Write("Podaj ponownie druga liczbe: ");

                y = Convert.ToInt32(Console.ReadLine());

            }

            if (x % y == 0)
            {
                Console.WriteLine(@"Uda³o siê - Druga liczba jest dzielnikiem pierwszej.");
            }
            else
            {
                Console.WriteLine("!!! Druga liczba nie jest dzielnikiem pierwszej. !!!");
            }

            Console.ReadKey();

        }
    }
}
