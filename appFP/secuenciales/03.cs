namespace appFP.secuenciales
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _03_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int Kilometros = int.Parse(txtkilometro.Text);
            int Pies = int.Parse(txtpies.Text);
            int Millas = int.Parse(txtmillas.Text);

            double Primertramo = Kilometros * 1000;
            double Segundotramo = Pies / 3.2808;
            double Tercertramo = Millas * 1609;
            double Totalmetro = Primertramo + Segundotramo + Tercertramo;
            double Totalyarda = (Totalmetro * 3.2808) / 3;

            txtprimertramo.Text = Primertramo.ToString("##.00");
            txtsegundotramo.Text = Segundotramo.ToString("##.00");
            txttercertramo.Text = Tercertramo.ToString("##.00");
            txttotalmetro.Text = Totalmetro.ToString("##.00") + " mt";
            txttotalyarda.Text = Totalyarda.ToString("##.00") + "yrd";
        }
    }
}
