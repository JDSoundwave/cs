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

            double x, y, wynik = 0;

            char z;

            Console.Write(@"Podaj pierwszą zmienną x: ");

                x = double.Parse(Console.ReadLine());

            Console.Write(@"Podaj drugą zmienną y: ");

                y = double.Parse(Console.ReadLine());

            Console.Write(@"Podaj znak działania: ");

                z = char.Parse(Console.ReadLine());

            switch(z)

                {

                case '+':
                    wynik = x + y;
                break;


                case '-':
                    wynik = x - y;
                break;


                case '*':
                    wynik = x * y;
                break;


                case '/':
                    wynik = x / y;
                break;


                default:
                    {

                    Console.WriteLine(@"!!! Podano nieprawidłowy symbol. Wprowadź poprawny. !!!");
                                                            
                    }                  
                    
                break;                    

                }

            Console.WriteLine(@"Wynik wynosi: " + wynik);
       
            Console.ReadKey();
        
        }
    }
}
