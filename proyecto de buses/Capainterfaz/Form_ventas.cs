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
        private List<int> asientosSeleccionados = new List<int>(); //aqui se guarda los asientos seleccionados por el user
        private LogicaRuta logica = new LogicaRuta();//se llama la logica para que se pueda aplicar

        public Form_ventas(LogicaRuta logicaRuta)
        {
            InitializeComponent();
            logica = logicaRuta; //se llama la logica de la ruta para traer las rutas creadas en matenimiento
        }

        private void Form_ventas_Load(object sender, EventArgs e)
        {
            cborutas.DataSource = null;
            cborutas.DataSource = logica.Obtener(); //aqui se agregan las rutas
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
            
            if (cborutas.SelectedItem is Rutas rutaSeleccionada)
            {
                var vendidos = LogicaAsiento.ObtenerVendidos() //utilizando la logica de los vendidos 
                    .Where(a => a.Ruta == rutaSeleccionada.Destino && a.Fecha == dtfecha.Value.ToShortDateString()).ToList();
                //dependiendo de la ruta seleccionada se filtran los asientos,para que sean independientes
                foreach (var asiento in vendidos)
                {
                    var btn = tlpasientos.Controls.OfType<Button>().FirstOrDefault(b => b.Text == asiento.NumAsiento.ToString());
                    //se busca el asiento vendido y cuando lo encuentra
                    if (btn != null)
                    {
                        btn.BackColor = Color.Red; //pasa a estar en rojo 
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
            int numeroasiento = int.Parse(btn.Name.Replace("btnasiento", ""));//aqui el numero del asiento se convierte en entero 
            //y remplaza el btnasiento a "" (osea nada)

            if (btn.BackColor == Color.Red) //si se presiona un boton con y el color es rojo
            {
                MessageBox.Show("El asiento seleccionado no esta disponible, Porfavor seleccione otro.", "Asiento no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;//dice esti
            }
            if (btn.BackColor == Color.DarkGreen)//si el boton esta seleccionado y se vuelve a tocar
            {
                btn.BackColor = Color.LightGreen; //lo cambia a deseleccionado
                asientosSeleccionados.Remove(numeroasiento);//y quita ese asiento de la clase
            }
            else
            {
                btn.BackColor = Color.DarkGreen;//se cambia a seleccionado 
                asientosSeleccionados.Add(numeroasiento);// y se agrega a la clase
            }
        }

        private void Asiento_prefe_click(object sender, EventArgs e)
        {
            Button btnpr = (Button)sender;
            int numeroasiento = int.Parse(btnpr.Name.Replace("btnasiento", ""));

            if (btnpr.BackColor == Color.Red)
            {
                MessageBox.Show("El asiento seleccionado no esta disponible, Porfavor seleccione otro.", "Asiento no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bool esvalido = true; //validaciones
            DateTime fechaSeleccionada = dtfecha.Value.Date;
            DateTime hoy = DateTime.Today;
            if (asientosSeleccionados.Count == 0) //valida si el nombre esta vacio o no
            {
                MessageBox.Show("Para continuar con la compra debe seleccionar al menos un asiento", "No hay asientos seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                esvalido = false;
            }
            if (fechaSeleccionada < hoy) //valida si la fecha es menor a la fecha de hoy (no se puede seleccionar ayer por ejemplo)
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
            //si todo esta bien da un mensaje y abre el form de cliente 
            MessageBox.Show("Para continuar escriba el nombre y cedula del cliente.", "Asientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
