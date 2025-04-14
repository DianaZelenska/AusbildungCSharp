using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateien
{
    public class Person
    {
        private string nachName;
        private string vorName;
        private string eMail;
        private int geschlecht;
        public Person( string nn, string vn, string em, int gs) 
        {
            nachName = nn;
            vorName = vn;   
            eMail = em;
            geschlecht = gs;
        }

        public string NachName { get => nachName; set => nachName = value; }
        public string VorName { get => vorName; set => vorName = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public int Geschlecht { get => geschlecht; set => geschlecht = value; }

        public string toCSV()
        {
            return nachName + ";" + vorName + ";" + eMail + ";" + geschlecht.ToString() + ";";
        }
    }
}
