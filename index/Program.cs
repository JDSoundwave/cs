using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    public abstract class RodzajUslugi
    {
        public RodzajUslugi(DateTime t)
        {
            this.czas = t;
        }   

        protected DateTime czas;
        protected double cena;

        public abstract void ObliczCene();               
        
    }


    public class Polaczenie : RodzajUslugi
    {
        private string numer;
        private int czasP;

        public Polaczenie(DateTime t) : base(t) => this.czas = t;

        public override void ObliczCene() => this.cena = czasP * 0.28;
        
        public Polaczenie(DateTime t, string n, int c) : base(t)
        {
            this.czas = t;
            this.numer = n;
            this.czasP = c;
            ObliczCene();
        }

        public override string ToString()
        {
            return this.czas + " POŁĄCZENIE: " + this.numer +  " CZAS ROZMOWY: " + this. czasP+ " , KOSZT:" + this.cena;
        }


    }
    public class Sms : RodzajUslugi
    {
        private string numer;

        public override void ObliczCene() => this.cena = 0.08;

        public Sms(DateTime t, string n) : base(t)
        {
            this.czas = t;
            this.numer = n;
            ObliczCene();
        }

        public override string ToString()
        {
            return this.czas + " SMS: " + this.numer + " KOSZT: " + this.cena;
        }
    }

    public class Internet : RodzajUslugi
    {
        private int iloscMb;

        public override void ObliczCene()
        {
            this.cena = Math.Round(iloscMb / 734.0, 2);
        }
        public Internet(DateTime t, int n) : base(t)
        {
            this.czas = t;
            this.iloscMb = n;
            ObliczCene();
        }
        public override string ToString()
        {
            return this.czas + " ILOŚĆ MB: " + this.iloscMb + " KOSZT: " + this.cena;
        }

    }
    public interface IBilling 
    {
        void ZapiszBiling();
    }
    public interface IDodaj 
    {
        void DodajPolaczenie(string numer, int czasP);
        void DodajSms(string numer);
        void DodajInternet(int iloscMb);
    }

    public class Telefon : IDodaj
    {
        private List<RodzajUslugi> biling = new List<RodzajUslugi>();



        public void DodajPolaczenie(string numer, int czasP)
        { 
            biling.Add(new Polaczenie(DateTime.Now, numer, czasP));
        }

        public void DodajSms(string numer)
        {
            biling.Add(new Sms(DateTime.Now, numer));
        }

        public void DodajInternet(int iloscMb)
        {
            biling.Add(new Internet(DateTime.Now, iloscMb));
        }

        

        public override string ToString()
        {
            string pole_biling = string.Join(Environment.NewLine, biling);

            return pole_biling;
        }



        public void ZapiszBiling()
        {
            string sciezka = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string wynik = this.ToString();

            System.IO.File.WriteAllText(sciezka + "\\biling.txt", wynik);
        }
    }
}