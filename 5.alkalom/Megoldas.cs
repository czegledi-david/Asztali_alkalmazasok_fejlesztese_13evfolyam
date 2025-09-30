using System;


namespace Dolgozat
{
    class Konyv
    {
        private string cim { get; set; }
        private string szerzo { get; set; }
        private int kiadasiEv { get; set; }
        private int oldalszam { get; set; }

        public Konyv(string cim, string szerzo, int kiadasiEv, int oldalszam)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasiEv = kiadasiEv;
            this.oldalszam = oldalszam;
        }

        public string Cim
        {
            get { return cim; }
            set { cim = value; }
        }

        public string Szerzo
        {
            get { return szerzo; }
            set { szerzo = value; }
        }

        public int KiadasiEv
        {
            get { return kiadasiEv; }
            set { kiadasiEv = value; }
        }

        public int Oldalszam
        {
            get { return oldalszam; }
            set { oldalszam = value; }
        }

        public int Kor()
        {
            return 2025 - kiadasiEv;
        }

        public string Kategoria()
        {
            int k = Kor();
            if (k > 50)
            {
                return "Régi";
            }
            else if (k >= 50 && k >= 10)
            {
                return "Közepes";
            }
            else
            {
                return "Új";
            }
        }

        public override string ToString()
        {
            return $"Cím: {cim}, Szerző: {szerzo}, Kiadás éve: {kiadasiEv}, Oldalszám: {oldalszam} " +
                   $"Kor: {Kor()}, Kategória: {Kategoria()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Konyv> konyvek = new List<Konyv>();
            Console.Write("\nHány darab könyvet szeretne feltölteni?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. könyv adatai:");
                Console.Write("Könyv neve:");
                string nev = Console.ReadLine();
                Console.Write("Szerző:");
                string szerzo = Console.ReadLine();
                Console.Write("Kiadás éve:");
                int kiadasiEv = int.Parse(Console.ReadLine());
                Console.Write("Oldalszám:");
                int  oldalszam = int.Parse(Console.ReadLine());
                
                konyvek.Add(new Konyv(nev, szerzo, kiadasiEv, oldalszam));
                
            }

            foreach (var i in konyvek)
            {
                Console.WriteLine(i);
            }
            
            

        }
    }
    
    
    
}

