using System.Globalization;

class Auto
{
    private string rendszam;
    private int ev;
    private double terfogat;

    public Auto(string rendszam, int ev, double terfogat)
    {
        this.rendszam = rendszam;
        this.ev = ev;
        this.terfogat = terfogat;
    }

    public void setRendszam(string value) => rendszam = value;
    public string getRendszam() => rendszam;

    public void setEv(int value) => ev = value;
    public int getEv() => ev;
    
    public void setTerfogat(double value) => terfogat = value;
    public double getTerfogat() => terfogat;

    public int getKor()
    {
        return 2025 - ev;
    }

    public string getBesorolas()
    {
        int kor = getKor();
        if (kor > 20) return "Régi";
        else if (kor >= 10) return "Átlagos";
        else return "Modern";
    }

    public string GetAdatok()
    {
        return $"Rendszám: {rendszam}, Gyártási év: {ev}, Motor: {terfogat}L, " +
               $"Kor: {getKor()} év, Besorolás: {getBesorolas()}";
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Auto> autok = new List<Auto>();

        Console.WriteLine("Hány autó adatait szeretné bevinni: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n{i+1}. autó adatai:");

            Console.WriteLine("Rendszám: ");
            string rendszam = Console.ReadLine();
            Console.WriteLine("Gyártási év: ");
            int ev = int.Parse(Console.ReadLine());
            Console.WriteLine("Motor térfogata (literben): ");
            double terfogat = double.Parse(Console.ReadLine());

            Auto auto = new Auto(rendszam, ev, terfogat);
            autok.Add(auto);
        }

        Console.WriteLine("\nAutók adati:");
        foreach (var auto in autok)
        {
            Console.WriteLine(auto.GetAdatok());
        }
        
        
    }
}
 