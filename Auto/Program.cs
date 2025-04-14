using Autoneu;

public class Program
{
    private static Auto[] autos;
    private static void Main(string[] args)
    {
        autos = new Auto[2];
        //autos[0] = new Auto("grau", 1988, "Trabbi", 180);
        //autos[1] = new Auto("gelb", 1966, "Wartburg", 130);
        //autos[2] = new Auto("blau", 1979, "Lada", 110);

        autoerstellen();
       
        int autonr = 0;

        while((autonr = autowahl()) != -1)
        {
            autobewegen(autos[autonr]);
        }

        //Auto auto = new Auto("grau", 1988, "Trabbi", 180);
    }

    private static void autoerstellen()
    {
        string farbe;
        string marke;
        int baujahr;
        int hg;

        for (int i = 0; i < autos.Length; i++)
        {
            Console.WriteLine("Farbe: ");
            farbe = Console.ReadLine();
            Console.WriteLine("Marke: ");
            marke = Console.ReadLine();
            Console.WriteLine("Baujahr: ");
            int.TryParse(Console.ReadLine(), out baujahr);
            Console.WriteLine("Höchstgeschwindigkeit: ");
            int.TryParse(Console.ReadLine(), out hg);

            autos[i] = new Auto(farbe, baujahr, marke, hg);
        }
        
    }

    // das war vorher in main
    private static void autobewegen(Auto auto)
    {
        string s = "1";

        auto.tacho();

        for (; s != "0";)
        {
            s = menue();

            switch (s)
            {
                case "1":
                    auto.beschleunigen(wieviel());
                    break;
                case "2":
                    auto.bremsen(wieviel());
                    break;
                
            }
        }
    }

    private static int autowahl()
    {
        int which = 0;
        string s;

        for(int i = 0; i < autos.Length; i++)
        {
            Console.WriteLine((i+1).ToString() + " " + autos[i].Marke);
        }

        Console.WriteLine("0 Ende");

        s = Console.ReadLine();
        int.TryParse(s, out which);

        return which - 1;
    }

    // einlesen, um wie viel beschleubigen oder bremsen
    private static int wieviel()
    {
        string s = "";
        int x = 0;

        Console.Write("Um wieviel: ");
        s = Console.ReadLine();

        int.TryParse(s, out x);

        return x;
    }

    private static string menue()
    {

        Console.WriteLine("1 Beschleunigen");
        Console.WriteLine("2 Bremsen");
        Console.WriteLine("0 Ende");

        string s = Console.ReadLine();

        return s;
    }
}