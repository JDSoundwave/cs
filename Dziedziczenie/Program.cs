using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {

            Ziemia obiekt_1 = new Ziemia();

            obiekt_1.RuchObrotowy();
            obiekt_1.PoraDniaINocy();
            obiekt_1.Atmosfera();



            Console.ReadKey();
        }
    }

    abstract class CialoNiebieskie
    {

        public string Nazwa { get; set; }
        public void RuchObrotowy()
        {
            Console.WriteLine("Każde ciało niebieskie posiada ruch obrotowy");
        }

    }

    abstract class Planeta : CialoNiebieskie
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pory dnia i nocy.");
        }
    }

    class Ziemia : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera");
        }
    }
}
