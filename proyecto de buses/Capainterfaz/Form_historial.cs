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

        private void Form_historial_Load(object sender, EventArgs e)//metodo que se ejecuta cuando queremos cargar el form historial
        {
            ActualizarHistorial();//llama el metodo "ActualizarHistorial" para cargar y mostrar el historial de ventas
        }

        private void ActualizarHistorial()//metodo para actualizar el historial de ventas 
        {
            var lista = LogicaAgregarVenta.ObtenerVentas()//consigue los datos atravez de LogicaAgregarVenta.
                .Select(v => new
                { //propiedades de ventas que se hicieron
                    Cliente = v.NombreCliente,//nombre del cliente
                    Cedula = v.CedulaCliente,//cedula del cliente
                    Ruta = v.Ruta, //ruta que fue vendida
                    Hora_Salida = v.Hora_Salida,//hora de salida
                    Hora_Llegada = v.Hora_Llegada,//hota de llegada
                    Asientos = v.AsientosTexto,//los asientos que se seleccionaron
                    Cantidad = v.CantidadAsientos,//la cantidad de asientos
                    Total = $"₡{v.Total:N0}",//el total monetario
                    Fecha = v.Fecha.ToShortDateString()//la fecha que se selecciono
                })
                .ToList();// convierte todo eso en una lista

            dgvhistorial.DataSource = null;//cuando el data esta vacio
            dgvhistorial.DataSource = lista;//se refresca y queda en forma de lista con esos datos de la venta

        }

        private void btnvolver_hist_Click(object sender, EventArgs e)//boton volver
        {
            this.Close();   //cierra pero sin salirce del todo y lleva a la persona al menu principal
        }
    }
}
