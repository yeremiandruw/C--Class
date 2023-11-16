namespace appFP.secuenciales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _01_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtvarones.Text);
            int mujeres = int.Parse(txtmujeres.Text);

            int total = varones + mujeres;
            double pvarones = varones * 100 / total;
            double pvmujeres = mujeres * 100 / total;

            lblPVarones.Text = pvarones.ToString("##.00")+"%";
            lblPMujeres.Text = pvmujeres.ToString("##.00") + "%";
        }
    }
}
