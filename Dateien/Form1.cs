namespace Dateien
{
    public partial class Form1 : Form
    {
        private List<Person> list;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 0 männlich
            // 1 weiblich
            // 2 divers
            try
            {
                int gesch = radioButton1.Checked ? 0 :
                    radioButton2.Checked ? 1 : 2;
                Person person = new Person(
                    tbNachname.Text,
                    tbVorname.Text,
                    tbEmail.Text,
                    gesch);

                label4.Text = person.toCSV();

                Datei datei = new Datei("C:\\Mist\\Person.csv");
                datei.schreibeDatei(person.toCSV());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datei datei = new Datei("C:\\Mist\\Person.csv");
            list = datei.liesDatei();
            lbNamen.Items.Clear();
            foreach (Person person in list)
            {
                lbNamen.Items.Add(person.NachName);
            }
        }

        private void lbNamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNamen.SelectedIndex != -1)
            {
                pictureBox1.Image = null;

                tbNachname.Text = list[lbNamen.SelectedIndex].NachName;
                tbVorname.Text = list[lbNamen.SelectedIndex].VorName;
                tbEmail.Text = list[lbNamen.SelectedIndex].EMail;
                switch(list[lbNamen.SelectedIndex].Geschlecht)
                {
                    case 0: radioButton1.Checked = true; 
                        break;
                    case 1:
                        radioButton2.Checked = true;
                        break;
                    default: radioButton3.Checked = true; 
                        break;   
                }

                string fn = "C:\\Mist\\" + tbNachname.Text + ".png";
                if ( File.Exists( fn))
                {
                    pictureBox1.Image = Image.FromFile( fn );
                }
            }
        }
    }
}
