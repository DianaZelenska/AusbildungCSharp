using System.Drawing.Imaging;

namespace Rechner
{
    public partial class Form1 : Form
    {
        private double zahl1;
        private double zahl2;
        private int wie = 0;
        private const int plus = 1;
        private const int minus = 2;
        private const int mal = 3;
        private const int durch = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void alleBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


        // Gleich gedrückt
        private void button13_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out zahl2);
            lbBerechnung.Text += zahl2.ToString();
            switch (wie)
            {
                case plus:
                    textBox1.Text = (zahl1 + zahl2).ToString();
                    break;
                case minus:
                    textBox1.Text = (zahl1 - zahl2).ToString();
                    break;
                case mal:
                    textBox1.Text = (zahl1 * zahl2).ToString();
                    break;
                case durch: 
                    textBox1.Text = (zahl1 / zahl2).ToString();
                    break ;
            }
            lbBerechnung.Text += (" = " + textBox1.Text);
            libBisher.Items.Add(lbBerechnung.Text);

        }

        // Plus gedrückt
        private void button12_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out zahl1);
            textBox1.Text = "";
            wie = plus;
            lbBerechnung.Text = zahl1.ToString() + " + ";
        }

        // Minus gedrückt
        private void button15_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out zahl1);
            textBox1.Text = "";
            wie = minus;
            lbBerechnung.Text = zahl1.ToString() + " - ";
        }

        // multiplizieren
        private void button16_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out zahl1);
            textBox1.Text = "";
            wie = mal;
            lbBerechnung.Text = zahl1.ToString() + " * ";
        }

        // teilen
        private void button17_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out zahl1);
            textBox1.Text = "";
            wie = durch;
            lbBerechnung.Text = zahl1.ToString() + " / ";
        }
    }
}
