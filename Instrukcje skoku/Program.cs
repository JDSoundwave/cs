using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrukcje_skoku
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-----------------------------INSTRUKCJE SKOKU");  


            // CONTINUE


            for (int i = 0; i < 10; i++)
			{
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
			}


                Console.WriteLine();


            // GOTO


            jeden:
                Console.WriteLine("jeden");
            goto trzy;
            dwa:
               Console.WriteLine("dwa");
            trzy:
                Console.WriteLine("trzy");    



            
            Console.ReadKey();
        }
    }
}
