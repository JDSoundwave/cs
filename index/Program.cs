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

            double wzrost, waga, BMI;

                Console.Write(@"Podaj wzrost(w metrach): ");

            wzrost = int.Parse(Console.ReadLine());

                Console.Write(@"Podaj wagę(w kg): ");

            waga = int.Parse(Console.ReadLine());

                Console.WriteLine();

            BMI = waga / (wzrost * wzrost);
                
                Console.WriteLine(BMI);

                Console.WriteLine();

            if (BMI < 18.0)
            {
                Console.WriteLine(@"Masz niedowagę.");
            }
            else if (BMI >= 18.5 && BMI <= 24.99)
            {
                Console.WriteLine(@"Twoja waga jest odpowiednia.");
            }    
            else
            {
                Console.WriteLine(@"Masz nadwagę.");
            }               

            Console.ReadKey();

        }
    }
}
