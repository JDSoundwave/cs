using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI, WAGA, WZROST;

            Console.Write("Wyznaczamy wskaznik BMI\n\n");

            Console.Write("Podaj wzrost w cm: ");

                WZROST = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj wage w kg: ");

                WAGA = double.Parse(Console.ReadLine());

                BMI = WAGA / WZROST;

            Console.WriteLine("Wskaznik BMI wynosi: " + BMI);

            Console.ReadKey();
        }
    }
}
