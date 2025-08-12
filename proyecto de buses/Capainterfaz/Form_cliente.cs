using proyecto_de_buses.Capadatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_buses
{
    public partial class Form_cliente : Form
    {
        public Cliente Cliente { get; private set; }
        public Form_cliente()
        {
            InitializeComponent();
        }


        private void btncomprar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))// si el campo queda vacio, o es nulo
            {
                MessageBox.Show("No se puede dejar el nombre vacio", "Problema con el nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);//nos da este mensaje, para saaber y volver a insertar el dato que nos estan pidiendo
                return;//retorna
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtnombre.Text, @"^[a-zA-Z\s]+$"))//no va a permitir ingresar numeros en el nombre
            {
                MessageBox.Show("No se pueden ingresar numeros en el nombre", "Problema con el nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);//si se inserta algo no valido nos va a mostrar este mensaje para saber que hay que escribir datos validos
                return;//retorna
            }
            if (!int.TryParse(txtcedula.Text, out int cedula) || txtcedula.Text.Length != 9)//en la cedula solo 9 numeros como maximo pueden haber al igual que no se puede dejar en blanco
            {
                MessageBox.Show("la cedula no se puede dejar vacia y tiene que tener 9 digitos", "Problema con la cedula", MessageBoxButtons.OK, MessageBoxIcon.Warning);// si se ingresan mas numeros nos da este mensaje de advertensia
                return;//retorna
            }

            Cliente = new Cliente//se crea una nueva instancia de la clase cliente y se inician sus propiedades
            {
                Nombre = txtnombre.Text,// se le asigna valor al txt osea se ingresa el nombre
                Cedula = int.Parse(txtcedula.Text)//se le asigna una propiedad a cedula del cliente
            };
            this.DialogResult = DialogResult.OK;//se establece el resultado de ello como un OK para indicar que se tuvo exito al ingresar esos datos
            this.Close();// cierra esta ventana

        }

        private void btnvolver_clien_Click(object sender, EventArgs e)// boton volver
        {
            this.Close();//para regresar al menu sin salir por completo 
        }
    }
}
