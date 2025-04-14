using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Quader : Rechteck
    {
        private int tiefe;

        public Quader(int l, int b, int t) : base(l, b)
        {
            tiefe = t;
        }

        public int volumen()
        {
            return tiefe * flaeche();
        }

        public int oberflaeche()
        {
            return 2 * flaeche() + 2 * (Breite * tiefe) + 2 * (Laenge * tiefe);
        }
    }
}
