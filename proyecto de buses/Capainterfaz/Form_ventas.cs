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
using static proyecto_de_buses.Capadatos.Venta;

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
            PintarAsientos();
        }
        private void cborutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            asientosSeleccionados.Clear();
            PintarAsientos();
        }

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            asientosSeleccionados.Clear();
            PintarAsientos();
        }
        private void PintarAsientos()
        {
            // Pintar todos como disponibles
            foreach (Control control in tlpasientos.Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("btnsiento"))
                {
                    btn.BackColor = Color.LightGreen;
                    btn.Enabled = true;
                }
            }

            // Pintar como vendidos los asientos para la ruta y fecha actual
            if (cborutas.SelectedItem is Rutas rutaSeleccionada)
            {
                var vendidos = LogicaAsiento.ObtenerVendidos()
                    .Where(a => a.Ruta == rutaSeleccionada.Destino && a.Fecha == dtfecha.Value.ToShortDateString()).ToList();

                foreach (var asiento in vendidos)
                {
                    var btn = tlpasientos.Controls.OfType<Button>().FirstOrDefault(b => b.Text == asiento.NumAsiento.ToString());

                    if (btn != null)
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                }
            }
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

            MessageBox.Show("ahora para continuar escriba el nombre y cedula del cliente.", "Asientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form_cliente formcliente = new Form_cliente();
            if (formcliente.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = formcliente.Cliente;
                Rutas ruta=(Rutas)cborutas.SelectedItem;
                
                
                Venta venta = new Venta
                {
                    Cliente = cliente,
                    Ruta = ruta.Destino,
                    Hora_Salida = ruta.Horasalida ,
                    Hora_Llegada=ruta.Horallegada,
                    Asientos = new List<int>(asientosSeleccionados),
                    Total = asientosSeleccionados.Count * ruta.Precio,
                    Fecha = dtfecha.Value.Date
                };
                LogicaAgregarVenta.AgregarVenta(venta);

                foreach (Control c in tlpasientos.Controls)
                {
                    if (c is Button b && b.BackColor ==Color.DarkGreen)
                    {
                        b.BackColor = Color.Red;
                    }
                }
                foreach (int num in asientosSeleccionados)
                {
                    LogicaAsiento.MarcarVendidos(new Asientos
                    {
                        NumAsiento = num,
                        Ruta = ruta.Destino,
                        Fecha = dtfecha.Value.ToShortDateString()
                    });

                }
                asientosSeleccionados.Clear();
                PintarAsientos();
                MessageBox.Show(
                               $"Compra realizada con éxito.\n\n" +
                               $"Cliente: {cliente.Nombre}\n" +
                               $"Cédula: {cliente.Cedula}\n" +
                               $"Total pagado: ₡{venta.Total:N0}",
                               "Venta terminada",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
                               );

            }

        }

        private void tlpasientos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
