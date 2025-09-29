using  System;
using System.Globalization;

namespace Alkalmazott_ns
{
    public class Alkalmazott
    {
        private string nev;
        private int kor;
        private int fizetes;

        private static int nyugdijKorhatar = 65;
        
        //Konstruktor 1 - minden adat megadva
        public Alkalmazott(string nev, int kor, int fizetes)
        {
            this.nev = nev;
            this.kor = kor;
            this.fizetes = fizetes;
        }
        
        //Konstruktor 2 - csak név és kor, fizetes = 10000 * kor
        public Alkalmazott(string nev, int kor) : this(nev, kor, 10000 * kor)
        {
            
        }

        public string setNev(string nev)
        {
            return this.nev = nev;
        }

        public int setFizetes(int fizetes)
        {
            return this.fizetes = fizetes;
        }

        public int setKor(int kor)
        {
            return this.kor = kor;
        }

        public string getNev()
        {
            return nev;
        }

        public int getKor()
        {
            return kor;
        }

        public int getFizetes()
        {
            return fizetes;
        }

        public static int getNyugdijKorhatar()
        {
            return nyugdijKorhatar;
        }

        public int HatralevoEvNyugdijig()
        {
            return nyugdijKorhatar - kor;
        }

        public override string ToString()
        {
            return $"Név: {nev},  Kor: {kor}, Fizetes: {fizetes}, +" +
                   $"Hátralévő évek nyugdíjig: {HatralevoEvNyugdijig()}";
        }

        public static Alkalmazott TobbetDolgozo(Alkalmazott a1, Alkalmazott a2)
        {
            return a1.HatralevoEvNyugdijig() > a2.HatralevoEvNyugdijig() ? a1 : a2;
        }

        public static void setNyugdijKorhatar(int ujKorhatar)
        {
            nyugdijKorhatar = ujKorhatar;
        }



    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hány alkalmazott adatait szeretné megadni? ");
            int n = int.Parse(Console.ReadLine());
            
            Alkalmazott[] alkalmazottak = new Alkalmazott[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n{i + 1}. alkalmazott adati:");
                Console.Write("Név: ");
                string nev = Console.ReadLine();

                Console.Write("Kor: ");
                int kor = int.Parse(Console.ReadLine());

                Console.Write("Fizetés (Enter, ha automatikusan számolódjon");
                string fizStr = Console.ReadLine();

                if (string.IsNullOrWhiteSpace((fizStr)))
                {
                    alkalmazottak[i] = new Alkalmazott(nev, kor);
                }
                else
                {
                    int fizetes = int.Parse(fizStr);
                    alkalmazottak[i] = new Alkalmazott(nev, kor, fizetes);
                }
                
                
                
            }

            Console.WriteLine("\n--- Alkalmazottak eredeti adati ---");
            foreach (var a in alkalmazottak)
            {
                Console.WriteLine(a);
            }

            Console.Write("Adj meg egy új nyugdíjkorhatárt: ");
            int ujKorhatar = int.Parse(Console.ReadLine());
            Alkalmazott.setNyugdijKorhatar(ujKorhatar);


        }
    }
    
    
}