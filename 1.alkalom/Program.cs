using System;


namespace program
{

    class Alkalmazott
    {
        
        private string nev;
        private int fizetes;

        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public void setFizetes(int fizetes)
        {
            this.fizetes = fizetes;
        }

        public string getNev()
        {
            return nev;
        }

        public int getFizetes()
        {
            return fizetes;
        }

        public bool FizetesHatarokKozott(int alsoHatar, int felsoHatar)
        {
            //              1                       1
            return fizetes >= alsoHatar && fizetes <= felsoHatar;
        }

        public double Ado()
        {
            return fizetes * 0.16;
        }

        public bool NagyobbMint(Alkalmazott masik)
        {
            return this.fizetes > masik.fizetes;
        }

        //Metódus a fizetés növelésére
        public void FizetesEmeles(int osszeg)
        {
            // fizetes = fizetes + osszeg
            fizetes += osszeg;
        }

        // Metódus az adatok sztringe összefűzésére
        public string Adatok()
        {
            return $"Név: {nev}, Fizetés: {fizetes} Ft";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Alkalmazott alkalmazott1 = new Alkalmazott();
            Alkalmazott a2 = new Alkalmazott();
            a2.setNev("József");
            a2.setFizetes(100000);
            alkalmazott1.setNev("Kiss Róbert");
            alkalmazott1.setFizetes(200000);

            Console.WriteLine($"{a2.getNev()} fizetése 200000 és 400000 Ft között van? {a2.FizetesHatarokKozott(200000, 400000)}");
            double ado = a2.Ado();
            Console.WriteLine(ado);

            //Adatok kiírása
            Console.WriteLine(alkalmazott1.Adatok());

            alkalmazott1.FizetesEmeles(5000);
            Console.WriteLine(alkalmazott1.Adatok());


            Console.WriteLine($"{a2.getNev()} fizetése nagyobb mint {alkalmazott1.getNev()}?");
            Console.WriteLine($"{a2.NagyobbMint(alkalmazott1)}");

        }
    }

}
