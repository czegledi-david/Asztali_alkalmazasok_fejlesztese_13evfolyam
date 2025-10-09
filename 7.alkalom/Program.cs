using System;
using myclasses;
using myclasses.products;


namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Áru és Kenyér létrehozása
            Product product1 = new Product("Tej", 350, 27);
            Bread b1 = new Bread("Kenyér", 600, 27, 0.75);

            Console.WriteLine("Áru és a Kenyér adatai");
            Console.WriteLine(product1.ToString());
            Console.WriteLine(b1.ToString());

            int cmp = product1.CompareTo(b1);
            if (cmp > 0)
                Console.WriteLine("Az áru drágább mint a kenyér");
            else if (cmp < 0)
                Console.WriteLine("A kenyér drágább mint az Áru");
            else
                Console.WriteLine("Megegyezik az áruk");

            //Polimorfizmus
            Product p2 = new Bread("Rozskenyér", 400, 10, 1.0);

            Console.WriteLine(p2.ToString());

        }
    }

}

