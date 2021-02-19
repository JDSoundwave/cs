using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-----------------------------TABLICE JEDNOWYMIAROWE");  


            int [] tab = new int [100];

            string [] dni_tyg = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

                Console.WriteLine();

            for (int i = 0; i < dni_tyg.Length; i++)
			{
                Console.WriteLine(dni_tyg[i]);
			}
 

            Console.WriteLine("-----------------------------TABLICE DWUWYMIAROWE"); 


            int [,] tab2 = new int[2,3];

            tab2 [0, 0] = 9;
            tab2 [0, 1] = 7;
            tab2 [0, 2] = 4;
            tab2 [1, 0] = 11;
            tab2 [1, 1] = 33;
            tab2 [1, 2] = 24;

            for (int i = 0; i < tab2.GetLength(0); i++)
			{
                for (int j = 0; j < tab2.GetLength(1); j++)
			    {
                    Console.Write(tab2[i, j] + " ");        
			    }
                Console.WriteLine();
			}


            Console.WriteLine("-----------------------------TABLICE TABLIC"); 


            int [][] tab3 = new int [2][];

            tab3[0] = new int[3];
            tab3[1] = new int[2];

            tab3[0][0] = 5;
            tab3[0][1] = 6;
            tab3[0][2] = 7;
            tab3[1][0] = 55;
            tab3[1][1] = 65;

            for (int i = 0; i < tab3.Length; i++)
			{
                for (int j = 0; j < tab3[i].Length; j++)
			    {
                    Console.Write(tab3[i][j] + " ");
			    }
                Console.WriteLine();
			}



            Console.ReadKey();
        }
    }
}
