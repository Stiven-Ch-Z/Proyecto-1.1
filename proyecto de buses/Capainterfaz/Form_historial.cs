using proyecto_de_buses.Capadatos;
using proyecto_de_buses.Capalogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_buses.Capainterfaz
{
    public partial class Form_historial : Form
    {
        public Form_historial()
        {
            InitializeComponent();
        }

        private void Form_historial_Load(object sender, EventArgs e)
        {
            ActualizarHistorial();
        }

        private void ActualizarHistorial()
        {
            var lista = LogicaAgregarVenta.ObtenerVentas()
                .Select(v => new
                {
                    Cliente = v.NombreCliente,
                    Cedula = v.CedulaCliente,
                    Ruta = v.Ruta,
                    Hora_Salida = v.Hora_Salida,
                    Hora_Llegada = v.Hora_Llegada,
                    Asientos = v.AsientosTexto,
                    Cantidad = v.CantidadAsientos,
                    Total = $"₡{v.Total:N0}",
                    Fecha = v.Fecha.ToShortDateString()
                })
                .ToList();

            dgvhistorial.DataSource = null;
            dgvhistorial.DataSource = lista;

        }

        private void btnvolver_hist_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
