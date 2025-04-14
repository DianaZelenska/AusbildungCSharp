using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Rechteck
    {
        private int laenge;
        private int breite;

        public int Laenge { get => laenge; set => laenge = value; }
        public int Breite { get => breite; set => breite = value; }


        public Rechteck(int l, int b)
        {
            laenge = l;
            breite = b;
        }

        public int flaeche()
        {
            return laenge * breite;
        }

        public int umfang()
        {
            return 2 * (breite + laenge);
        }
    }
}
