using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 4;
            int b = 3;

            int e;
            int f;

            // ZWYKŁA

            //Console.WriteLine("FUNKCJA: " + funkcja_1(a, b, 0, d:6));

            // VOID

            //funkcja_2(a, b);

            // REF

            // Console.WriteLine("PRZED: " + a + ", " + b);
            // Console.WriteLine("FUNKCJA_REF: " + funkcja_3(ref a, ref b)); 
            // Console.WriteLine("PO: " + a + ", " + b); // ZWRACAMY ORGINAŁ

            // OUT

            // Console.WriteLine("PRZED: " + e + " " + f);
            Console.WriteLine("FUNKCJA_OUT: " + funkcja_4(out e, out f)); 
            Console.WriteLine("PO: " + e + " " + f); // ZWRACAMY ORGINAŁ, NIE MUSI MIEĆ PRZYPISANEJ WARTOŚCI


            Console.ReadKey();
        }


        // FUNKCJA ZWYKŁA

        static int funkcja_1(int a, int b, int c, int d)
        {
            int wynik = a * b + c + d;
            return wynik;
        }

        // FUNKCJA VOID

        static void funkcja_2(int a, int b)
        {
            int wynik = a * b;
            Console.WriteLine("VOID: " + wynik);
        }

        // FUNKCJA REF

        static int funkcja_3(ref int a, ref int b) 
        {
            a += 2;
            b += 2;

            int wynik = a * b;
            return wynik;
        }

        // FUNKCJA OUT

        static int funkcja_4(out int a, out int b)
        {
            a = 5;
            b = 6;
        
            int wynik = a * b;
            return wynik;
        }
    }
}
