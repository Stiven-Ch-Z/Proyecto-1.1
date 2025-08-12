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
    public partial class Form_rutas : Form
    {
        private LogicaRuta logica;
        public Form_rutas(LogicaRuta logicaRuta)
        {
            InitializeComponent();
            cbohorasalida.DropDownStyle = ComboBoxStyle.DropDownList; // esto hace que solo se puedan elegir las opciones del combobox
            logica = logicaRuta;
        }

        private void Form_rutas_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()//metodo para limpiar campos
        {
            txtrutas.Clear();
            txtprecio.Clear();
            cbohorasalida.SelectedIndex = -1;
            cbohorallegada.SelectedIndex = -1;
        }
        private bool ValidarCampos()
        {
            bool esvalido = true;
            errorProviderRutas.Clear();

            if (string.IsNullOrWhiteSpace(txtrutas.Text)) //valida si el nombre esta vacio o no
            {
                errorProviderRutas.SetError(txtrutas, "El nombre no puede quedar vacio");// si esta vacio el errorProvider da este mensaje 
                esvalido = false;
            }
            if (!decimal.TryParse(txtprecio.Text, out decimal precio) || precio <= 0)
            {
                errorProviderRutas.SetError(txtprecio, "La cantidad debe de ser un numero entero");// si se escribe una cantidad incorrecta muestra este mensaje de advertencia
                esvalido = false;
            }

            if (cbohorasalida.SelectedIndex == -1) // si el combobox esta vacio 
            {
                errorProviderRutas.SetError(cbohorasalida, "Elija una hora para la ruta");//da este mensaje
                esvalido = false;
            }
            if (cbohorallegada.SelectedIndex == -1) // si el combobox esta vacio 
            {
                errorProviderRutas.SetError(cbohorasalida, "Elija una hora para la ruta");//nos da este mensaje
                esvalido = false;
            }
          
            return esvalido;
        }
        private void btnanadir_Click(object sender, EventArgs e)//boton anadir
        {
            if (!ValidarCampos())//valida que los campos de entrada esten correctos
            {
                return;
            }
            Rutas ruta = new Rutas//  donde vamos a crear una nueva ruta
            {
                Destino = txtrutas.Text,//el nombre de la ruta
                Precio = decimal.Parse(txtprecio.Text),//el precio de ella
                Horasalida = cbohorasalida.SelectedItem.ToString(),//la hora de salida
                Horallegada = cbohorallegada.SelectedItem.ToString()//hora de llegada
            };
            logica.AgregarRuta(ruta);//se llama al metodo agregar ruta para agregarla
            MessageBox.Show("La ruta ha sido agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);//cuando la ruta se agrega nos da este mensaje, haciendonos ver que la ruta se agrego con exito
            Limpiar();//metodo que limpia los campos una vez se haya agregado una ruta
        }


        private void btnvolver_rut_Click(object sender, EventArgs e)//boton volver
        {
            this.Close();//nos da la opcion de volver al menu principal sin salirnos por completo.
        }

    }
}           
