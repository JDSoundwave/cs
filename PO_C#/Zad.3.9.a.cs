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

            int rozmiar;

            string x = "*";

                Console.Write(@"Podaj rozmiar trójk¹ta: ");

            rozmiar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(x);

                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
