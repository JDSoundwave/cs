using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Typy_danych
{
    class Program
    {
        static void Main(string[] args)
        {

            // CAŁKOWITE

            byte zmienna_1;
            short zmienna_2 = -2; // typ short domyślnie jest określony (może przechowywać wartości ujemne) z kolei ushort przyjmuje tylko wartości dodatnie !!!         
            long zmienna_3;

            Console.WriteLine("-----------------------------ZMIENNE");

            int zmienna_4 = int.MaxValue;
            sbyte zmienna_5 = sbyte.MinValue; // (typ signed) byte - przechowuje wartości ujemne od -128 do 127

            Console.WriteLine(@"int.MaxValue = " + zmienna_4);
            Console.WriteLine(@"sbyte.MinValue = " + zmienna_5);


            // ZMIENNOPRZECINKOWE


            float zmienna_6 = 2.234567f; // f lub F sufix
            double zmienna_7 = 1063.70;
            decimal zmienna_8 = 10.6667m; // m lub M sufix


            // TEKSTOWE


            string zmienna_9 = "TEKST";


            // ZNAKOWE


            char zmienna_10 = 'M';


            // LOGICZNE


            bool zmienna_11 = 5 > 2; // true or false
            var zmienna_12 = zmienna_11; // zmienna inteligentna


            // STAŁA


            const float PI = 3.14F; // stała




            Console.ReadKey();
        }
    }
}
