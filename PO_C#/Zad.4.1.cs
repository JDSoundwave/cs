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

            int n, licznik = 0;

                Console.Write(@"Podaj liczbê elementów tablicy: ");

            n = int.Parse(Console.ReadLine());

                Console.WriteLine();

            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                licznik++;
                Console.Write(@"{0} element tablicy ma wartoœæ: ", licznik);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(tab[i] + ", ");
            }

            Console.ReadKey();

        }
    }
}
