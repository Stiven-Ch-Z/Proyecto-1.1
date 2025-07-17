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
                            "MANTENIMIENTO: Editar rutas y horarios.\n" +

                            "VENTAS: Ver tiquetes vendidos, seleccionar acientos\n" +

                            "HISTORIAL: Ver historial de ventas.\n" +

                            "AYUDA: Ver informacion general del sistema.\n" +

                            "SALIR: Salir del sistema.");
        }
        private void btnacerca_Click(object sender, EventArgs e)
        {   //nos da el mensaje de quienes hicieron la plataforma
            MessageBox.Show("Esta plataforma fue creada por Steven Chinchilla y Josue Navarro Monge. ¡¡MUCHAS GRACIAS!!");
        }

        private void btnvolver_ayu_Click(object sender, EventArgs e)
        {
            this.Close();//nos da la opcion de volver
        }

        
        

        
    }
}
