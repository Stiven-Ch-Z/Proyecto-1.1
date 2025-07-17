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
        public Form_rutas()
        {
            InitializeComponent();
        }

        private void Form_rutas_Load(object sender, EventArgs e)
        {

        }

        private void btnanadir_Click(object sender, EventArgs e)
        {     
            string nombreRuta = txtrutas.Text;//para obtener el nombre de las rutas
            string precioBase = txtprecio.Text;//para obtener el precio base
            string horarios = txthorarios.Text;//para obtener los horarios
            
            //esto se asegura que los campos esten llenos
            if (string.IsNullOrWhiteSpace(nombreRuta) || string.IsNullOrWhiteSpace(precioBase) || string.IsNullOrWhiteSpace(horarios))
            {
                MessageBox.Show(" !!LO SIENTO!! Por favor llene los campos"); //muestra este mensaje si hay error
                return;

            }
            if (!decimal.TryParse(precioBase, out decimal precio))// se asegura que el prcio sean solo letras
            {
                MessageBox.Show("!!LO SIENTO!!El precio debe de ser un numero valido");// si hay letras en el precio nos muestra este mensaje
                return;
            }

            MessageBox.Show("La ruta se agrego con exito");//cuando la ruta se agrega nos da este mensaje
            txtrutas.Clear();//limpia el campo de rutas
            txthorarios.Clear();//limpia el campo de horarios
            txtprecio.Clear();//limpia el campo de precio
        }
       

        private void btnvolver_rut_Click(object sender, EventArgs e)
        {
            this.Close();//nos da la opcion de volver 
        }
    }




}           
