using proyecto_de_buses.Capainterfaz;

namespace proyecto_de_buses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmantenimiento_Click(object sender, EventArgs e)
        {
            Form_rutas rutas = new Form_rutas();
            this.Hide();
            rutas.ShowDialog();
            this.Show();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Form_ventas ventas = new Form_ventas();
            this.Hide();
            ventas.ShowDialog();
            this.Show();
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            Form_historial historial = new Form_historial();
            this.Hide();
            historial.ShowDialog();
            this.Show();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            Form_ayuda ayuda = new Form_ayuda();
            this.Hide();
            ayuda.ShowDialog();
            this.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
