using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Właściwości_klas
{
    class Czlowiek
    {

        public string imie;
        private int wiek;



        public int Wiek
        {
            get { return wiek; }
            set
            {

                if (value >= 0 && value <= 100)

                    wiek = value; // value przyjmuje wartość przypisaną do wiek

                else

                    wiek = 0;

            } 
        }



        public int getWiek()
        {

            return wiek;

        }

        public void setWiek(int w)
        {
            if (w >= 0 && w <= 100)

                wiek = w;

            else

                wiek = 0;

        }

    }
}
