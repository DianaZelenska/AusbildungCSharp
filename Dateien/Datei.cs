using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateien
{
    public class Datei
    {
        private string dateiName;

        public Datei(string dn)
        {
            dateiName = dn;
        }
        public void schreibeDatei(string was)
        {
            FileStream fs = new FileStream(
                dateiName,
                FileMode.Append,
                FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(was);

            sw.Close();
            fs.Close();

        }
        public List<Person> liesDatei()
        { 
            List<Person> list = new List<Person>();
            FileStream fs = new FileStream(
                dateiName,
                FileMode.Open,
                FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            string[] arrstr;

            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                arrstr = s.Split(';');
                list.Add(
                    new Person(
                        arrstr[0], arrstr[1], arrstr[2], Convert.ToInt32(arrstr[3])
                        )
                    );
            }

            sr.Close();
            fs.Close();

            return list;
        }
    }
}
