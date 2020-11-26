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

            const int stala = 10;

            int[] tab1 = { 3, 4, 7, -8, 12, 20, -9, 17, 2, -11 };
            int[] tab2 = new int[stala];

            foreach (int x in tab1)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine();

            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] < 0)
                {
                    tab2[i] = tab1[i];
                }

                Console.Write(tab2[i] + ", ");

            }

            Console.ReadKey();

        }
    }
}
