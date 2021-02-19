using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Postac obiekt_1 = new Postac("Lancelot", 100);

            Console.WriteLine(obiekt_1.imie + " " + obiekt_1.punktyHP);


            Console.ReadKey();
        }
    }

    class Postac
    {
        public Postac()
        {

        }
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }


        public string imie;
        public int punktyHP;


    }
}
