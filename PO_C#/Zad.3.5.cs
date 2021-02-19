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

            double a, b, c, x1, x2, x0, delta, pd;

                Console.Write(@"Podaj wartoœæ a: ");

            a = double.Parse(Console.ReadLine());

                Console.Write(@"Podaj wartoœæ b: ");

            b = double.Parse(Console.ReadLine());

                Console.Write(@"Podaj wartoœæ c: ");

            c = double.Parse(Console.ReadLine());


            delta = b * b - 4 * a * c;

                Console.WriteLine("Delta wynosi: " + delta);

            pd = Math.Sqrt(delta);

                Console.WriteLine("Pierwiastek z delty wynosi: " + pd);


            if (delta > 0)
            {

                x1 = (-b - pd) / (2 * a);
                x2 = (-b + pd) / (2 * a);

                Console.WriteLine(@"S¹ dwa rozwi¹zania: x1 - " + x1 + " ,oraz: x2 - " + x2);

            }
            else if (delta == 0)
            {

                x0 = -b / (2 * a);

                Console.WriteLine(@"Istnieje tylko jedno rozwi¹zanie: x0 - " + x0);

            }
            else

                Console.WriteLine(@"Brak rozwi¹zañ.");

            Console.ReadKey();

        }
    }
}
