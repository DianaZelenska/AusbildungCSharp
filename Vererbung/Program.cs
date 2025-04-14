using System;
using Vererbung;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rechteck");
        Rechteck re = new Rechteck(5, 3);
        Console.WriteLine("Fläche: " + re.flaeche().ToString());
        Console.WriteLine("Umfang: " + re.umfang().ToString());

        Console.WriteLine("Quadrat");
        Quadrat qr = new Quadrat(3);
        Console.WriteLine("Fläche: " + qr.flaeche().ToString());
        Console.WriteLine("Umfang: " + qr.umfang().ToString());

        Console.WriteLine("Quader");
        Quader qd = new Quader(5, 3, 2);
        Console.WriteLine("Volumen: " + qd.volumen().ToString());
        Console.WriteLine("Oberfläche: " + qd.oberflaeche().ToString());

        Console.WriteLine("Würfel");
        Wuerfel wu = new Wuerfel(5);
        Console.WriteLine("Volumen: " + wu.volumen().ToString());
        Console.WriteLine("Oberfläche: " + wu.oberflaeche().ToString());
    }
}