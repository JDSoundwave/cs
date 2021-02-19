using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------------------INSTRUKCJE SWITCH");  
            
            int znak  = int.Parse(Console.ReadLine());

            switch(znak)
            {
                case 1:
                    Console.WriteLine("jeden");
                break;
            
                case 2:
                    Console.WriteLine("dwa");
                break;

                case 3:
                    Console.WriteLine("trzy");
                break;

                case 4:
                    Console.WriteLine("cztery");
                break;

            }

            Console.ReadKey();
        }
    }
}
