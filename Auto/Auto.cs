using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoneu
{
    public class Auto
    {
        private string farbe;
        private int baujahr;
        private string marke;
        private int hoechstgeschwindigkeit;
        private int aktGeschw;
        //private bool gestartet;


        // Variablen markieren, rechte Taste -> Schnellaktionen -> Feld kapseln(weiterhin verwenden)
        public string Farbe { get => farbe; set => farbe = value; }
        public int Baujahr { get => baujahr; set => baujahr = value; }
        public string Marke { get => marke; set => marke = value; }

        public Auto(string Farbe, int bj, string Marke, int hg)
        {
            farbe = Farbe;
            baujahr = bj;
            marke = Marke;
            hoechstgeschwindigkeit = hg;
            aktGeschw = 0;
            //gestartet = false;
        }
        public void tacho()
        {
            Console.WriteLine("Der " + farbe + "e " + marke + " fährt " + aktGeschw.ToString() + "kmh");
        }

        public void bremsen(int um)
        {
            aktGeschw -= um;

            if (aktGeschw < 0)
                aktGeschw = 0;
            tacho();
        }

        public void beschleunigen(int um)
        {
            aktGeschw += um;
            tacho();
        }
    }
}
