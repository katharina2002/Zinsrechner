using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Zinsrechner
{
    public partial class frmZinsen : Form
    {
        public frmZinsen()
        {
            InitializeComponent();
        }

        //Erstelle ein Objekt oZins von der KLasse Zinsen
        Zinsen oZins = new Zinsen(1000, 3.5f);
        Zinsen oZinsB = new Zinsen(1000, 3.5f);

        private void Zinsen_Load(object sender, EventArgs e)
        {
            textBox1.Text = oZins.Kapital.ToString();
            textBox2.Text = oZins.Zinssatz.ToString();
            textBox4.Text = oZinsB.Kapital.ToString();
            textBox5.Text = oZinsB.Zinssatz.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = oZins.Zinsberechnung().ToString();
        }

        private void txtKapital_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float value))
            {
                oZins.Kapital = value;
            }
            else
            {
                textBox1.Text = oZins.Kapital.ToString();
            }
            //btnRechne_Click(this, null);
        }

        private void txtZinssatz_TextChanged(object sender, EventArgs e)
        {
            oZins.Zinssatz = Convert.ToSingle(textBox2.Text);
            //btnRechne_Click(this, null);
        }

        private void txtZinsen_TextChanged(object sender, EventArgs e)
        {
            oZins.Zins = Convert.ToSingle(textBox3.Text);
            //btnRechne_Click(this, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float umbuchung = Convert.ToSingle(txtUmbuchung.Text);
            oZins.Kapital = oZins.Kapital - umbuchung;
            oZinsB.Kapital = oZinsB.Kapital + umbuchung;
            textBox1 = oZins.Kapital;
            textBox4 = oZinsB.Kapital;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = oZinsB.Zinsberechnung().ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox4.Text, out float value))
            {
                oZinsB.Kapital = value;
            }
            else
            {
                textBox4.Text = oZinsB.Kapital.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            oZinsB.Zinssatz = Convert.ToSingle(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            oZinsB.Zins = Convert.ToSingle(textBox6.Text);
        }
    }
}