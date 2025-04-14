using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    // diese Classe erbt Attribute und Methoden von Rechteck
    public class Quadrat : Rechteck
    {
        public Quadrat(int l) : base(l, l)
        {
            
        }
    }
}
