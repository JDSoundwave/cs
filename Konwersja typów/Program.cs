using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwersja_typów
{
    class Program
    {
        static void Main(string[] args)
        {


            // RZUTOWANIE


                Console.WriteLine("-----------------------------RZUTOWANIE TYPÓW");

            int a = int.MaxValue;
            double b = 5.1;

            a = (int) b;

                Console.WriteLine(a);


            // WCZYTYWANIE DANYCH Z KONSOLI


            Console.WriteLine("-----------------------------WCZYTYWANIE DANYCH Z KONSOLI");


            string s = Console.ReadLine();
            
                Console.WriteLine(s);


            Console.WriteLine("-----------------------------JAKI KLAWISZ");


            if(Console.ReadKey().Key == ConsoleKey.D1)
                Console.WriteLine(" Prawda");
            else
                Console.WriteLine(" Inny klawisz");


            Console.WriteLine("-----------------------------KONWERSJA TYPÓW");


            string x = Console.ReadLine();


            int y = int.Parse(x) + 2; // Parse konwertuje tylko liczby
                Console.WriteLine(y);


            string z = y.ToString();
                Console.WriteLine(z);


            int w = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < w; i++)
			{
                Console.Write("*");
			}

            Console.WriteLine();  


            Console.WriteLine("-----------------------------KONKATENACJA");  


            string k = "Cześć", l = " Jurek", m = "Czarek";

            string powitanie = k + l;
                Console.WriteLine(powitanie + " i {0}" + " !!!", m);




            Console.ReadKey();

        }
    }
}
