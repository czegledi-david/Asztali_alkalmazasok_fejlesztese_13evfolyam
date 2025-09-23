using System;


public class Teglalap
{
    private int aOldal;
    private int bOldal;
    //Konstruktor 2 paraméterrel
    public Teglalap(int a, int b)
    {
        aOldal = a;
        bOldal = b;
    }
    //Konstruktor 1 paraméterrel
    public Teglalap(int oldal)
    {
        aOldal = oldal;
        bOldal = oldal;
    }
    //Terület kiszámítása
    public int Terulet()
    {
        return aOldal * bOldal;
    }
    //Adatok stringben
    public override string ToString()
    {
        return aOldal + ", " + bOldal + ": " + Terulet();
    }
    // Setter 2 paraméterrel
    public void setOldalak(int a, int b)
    {
        aOldal = a;
        bOldal = b;
    }
    //Setter 1 paraméterrel
    public void setOldalak(int oldal)
    {
        aOldal = oldal;
        bOldal = oldal;
    }
    
    //Nagyobb-e
    public bool NagyobbTeruletMint(Teglalap masik)
    {
        return this.Terulet()>masik.Terulet();
    }
    
    //Oldalak megegyeznek
    public bool OldalakMegegyeznek(Teglalap masik)
    {
        return this.aOldal == masik.aOldal && this.bOldal == masik.bOldal;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //1.Létrehozás
        Teglalap a = new Teglalap(2, 3); //Téglalap
        Teglalap b = new Teglalap(4); //Négyzet
        Teglalap c = a; //Referencia másolás
        
        //2. Kiírás
        Console.WriteLine("a: " + a); //a: 2, 3: 6
        Console.WriteLine("b: " + b); //b: 4, 4: 16
        Console.WriteLine("c: " + c); //c: 2, 3: 6
        
        //3. "a" oldalainak változtatása
        a.setOldalak(5, 6);
        Console.WriteLine("\nVáltoztatás után:");
        Console.WriteLine("a: " + a); //a: 5, 6: 30
        Console.WriteLine("b: " + b); //b: 4, 4: 16
        Console.WriteLine("c: " + c); //c: 5, 6: 30
        
        //4. "a" oldalait "b-hez" igazítjuk
        a.setOldalak(4);
        Console.WriteLine("\n'a' beállítva 'b'-hez");
        Console.WriteLine("a == b ? " + (a == b));
        Console.WriteLine("a == c ? " + (a == c));

        Console.WriteLine("a.OldalakMegegyeznek(b)" + a.OldalakMegegyeznek(b));
        
        
        
    }
}