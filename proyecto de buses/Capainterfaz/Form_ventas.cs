using proyecto_de_buses.Capadatos;
using proyecto_de_buses.Capalogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_buses.Capainterfaz
{
    public partial class Form_ventas : Form
    {
        private List<int> asientosSeleccionados = new List<int>();
        private LogicaRuta logica = new LogicaRuta();
        public Form_ventas(LogicaRuta logicaRuta)
        {
            InitializeComponent();
            logica = logicaRuta;
        }

        private void Form_ventas_Load(object sender, EventArgs e)
        {
            cborutas.DropDownStyle = ComboBoxStyle.DropDownList;
            cborutas.DataSource = null;
            cborutas.DataSource = logica.Obtener();

        }

        private void btnvolver_ventas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Asiento_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int numeroasiento = int.Parse(btn.Name.Replace("btnasiento", ""));

            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("El asiento seleccionado no esta disponible, Porfavor elija otro.", "Asiento no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btn.BackColor == Color.DarkGreen)
            {
                btn.BackColor = Color.LightGreen;
                asientosSeleccionados.Remove(numeroasiento);
            }
            else
            {
                btn.BackColor = Color.DarkGreen;
                asientosSeleccionados.Add(numeroasiento);
            }
        }

        private void Asiento_prefe_click(object sender, EventArgs e)
        {
            Button btnpr = (Button)sender;
            int numeroasiento = int.Parse(btnpr.Name.Replace("btnasiento", ""));

            if (btnpr.BackColor == Color.Red)
            {
                MessageBox.Show("El asiento seleccionado no esta disponible, Porfavor elija otro.", "Asiento no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnpr.BackColor == Color.DarkBlue)
            {
                btnpr.BackColor = Color.Aqua;
                asientosSeleccionados.Remove(numeroasiento);
            }
            else
            {
                btnpr.BackColor = Color.DarkBlue;
                asientosSeleccionados.Add(numeroasiento);
            }
        }
        private bool ValidarCampos()
        {
            bool esvalido = true;
            DateTime fechaSeleccionada = dtfecha.Value.Date;
            DateTime hoy = DateTime.Today;
            if (asientosSeleccionados.Count == 0) //valida si el nombre esta vacio o no
            {
                MessageBox.Show("Para continuar con la compra debe seleccionar al menos un asiento", "No hay asientos seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esvalido = false;
            }
            if (fechaSeleccionada < hoy)
            {
                MessageBox.Show("Para continuar elije una fecha valida", "Fecha Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esvalido = false;
            }

            if (cborutas.SelectedIndex == -1) // si el combobox esta vacio 
            {
                MessageBox.Show("Para continuar con la compra debe seleccionar una ruta", "No hay ruta seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esvalido = false;
            }
            return esvalido;
        }

        private void btnconfirmar_ventas_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            Asientos asinto = new Asientos();

            MessageBox.Show("La ruta ha sido agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlpasientos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
