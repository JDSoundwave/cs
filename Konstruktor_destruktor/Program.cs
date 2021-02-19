using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor_destruktor
{
    class Program
    {
        static void Main(string[] args)
        {

            Czlowiek obj = new Czlowiek("Marek", "Kowal"); // JEDEN Z TRZECH KONSTRUKTORÓW DO WYBORU
            
            obj.PrzedstawSie();

            Console.WriteLine(obj.imie);
            Console.WriteLine(obj.nazwisko);




            Console.ReadKey();
        }
    }

    class Czlowiek
    {

        //public czlowiek() // PIERWSZY KONSTRUKTOR
        //{

        //}

        //public czlowiek(string imieKonstruktora) // DRUGI KONSTRUKTOR
        //{
        //    imie = imieKonstruktora;
        //}

        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora) // TRZECI KONSTRUKTOR
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }


        public string imie = "- BRAK IMIENIA";
        public string nazwisko = "- BRAK NAZWISKA";

        public void PrzedstawSie()
        {
            Console.WriteLine("Cześć mam na imię Stefan");
        }



        ~Czlowiek()
        {
            System.Diagnostics.Trace.WriteLine("Jestem destruktorem");
        }
    }
}
