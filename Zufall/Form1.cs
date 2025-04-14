namespace Zufall
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        int zufall;
        int versuche = 0;
        public Form1()
        {
            InitializeComponent();
            zufall = rd.Next(0, 20);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // zuf‰llige Zahl erzeugen
            //int zufall = rd.Next(1, 20);
            //label1.Text = zufall.ToString();
            int geraten = int.Parse(textBoxZahlRaten.Text);
            versuche++;
            if (geraten == zufall)
            {
                label1.Text = "Sie haben die Zahl erraten! Anzahl der Versuche: " + versuche;
            }
            else if (geraten > zufall)
            {
                label1.Text = "Zahl ist zu groﬂ! Versuchen Sie noch mal!";
            }
            else
            {
                label1.Text = "Zahl ist zu klein! Versuchen Sie noch mal!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            versuche = 0;
            zufall = rd.Next(0, 20);
        }
    }
}
