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
    public partial class Form_ayuda : Form
    {
        public Form_ayuda()
        {
            InitializeComponent();
        }

        private void btnverayuda_Click(object sender, EventArgs e)
        {    //nos da informaciongeneral  de la plataforma en mensaje
            MessageBox.Show(
                            "Mantenimiento: Aqui se puede editar y crear rutas con sus horarios, solo llene los espacios solicitados y agreguelos con el boton.\n" +

                            "Ventas: para realizar ventas de tiquetes, seleccione los asientos deseados y llene los datos del clientes para agregarlo\n" +

                            "Historial: Ver el total de ventas realizadas y la informacion de cada una.\n" +

                            "Ayuda: Muestra una breve explicacion de cada boton.\n" +

                            "Salir: Cierra el sistema.","Informacion del programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnacerca_Click(object sender, EventArgs e)
        {   //nos da el mensaje de quienes hicieron la plataforma
            MessageBox.Show("Esta plataforma fue creada por Stiven Chinchilla Zamora y Josue Navarro Monge. ¡Gracias por su apoyo!", "Creditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnvolver_ayu_Click(object sender, EventArgs e)
        {
            this.Close();//nos da la opcion de volver
        }

        
        

        
    }
}
