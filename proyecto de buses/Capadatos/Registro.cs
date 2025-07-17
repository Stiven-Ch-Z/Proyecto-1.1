using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capadatos
{
    using System;
    public class Registro: proyecto_de_buses.Capadatos.Cliente
    {
        public int Asiento {  get; set; } 

        public string Fecha { get; set; }
        
        public DateTime Horaderegistro { get; set; }

        public Registro(string nombre, int cedula, int asiento, string fecha)
        {
            Nombre = nombre;
            Cedula = cedula;
            Asiento = asiento;
            Fecha = fecha;  
            Horaderegistro = DateTime.Now;
        }
    }
}
