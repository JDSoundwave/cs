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

            Console.Write(@"Podaj pierwszπ zmiennπ x: ");

                x = double.Parse(Console.ReadLine());

            Console.Write(@"Podaj drugπ zmiennπ y: ");

                y = double.Parse(Console.ReadLine());

            Console.Write(@"Podaj znak dzia≥ania: ");

                z = char.Parse(Console.ReadLine());

            switch (z)

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

                        Console.WriteLine(@"!!! Podano nieprawid≥owy symbol. Wprowadü poprawny. !!!");

                    }

                break;

            }

            Console.WriteLine(@"Wynik wynosi: " + wynik);

            Console.ReadKey();

        }
    }
}
