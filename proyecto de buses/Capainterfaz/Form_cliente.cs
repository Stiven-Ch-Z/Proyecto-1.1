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
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("No se puede dejar el nombre vacio", "Problema con el nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtnombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("No se pueden ingresar numeros en el nombre", "Problema con el nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtcedula.Text, out int cedula) || txtcedula.Text.Length != 9)
            {
                MessageBox.Show("la cedula no se puede dejar vacia y tiene que tener 9 digitos", "Problema con la cedula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente = new Cliente
            {
                Nombre = txtnombre.Text,
                Cedula = int.Parse(txtcedula.Text)
            };
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnvolver_clien_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
