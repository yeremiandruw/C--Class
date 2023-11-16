namespace appFP.secuenciales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void _02_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(txtmetros.Text);

            double centimetros = metros * 100;
            double pulgadas = centimetros * 100;
            double pies = pulgadas * 100;
            double yardas = pies * 100;

            txtcentimetros.Text = centimetros.ToString("##.00");
            txtpulgadas.Text = pulgadas.ToString("##.00");
            txtpies.Text = pies.ToString("##.00");
            txtyardas.Text = yardas.ToString("##.00");

        }

        private void txtmetros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
