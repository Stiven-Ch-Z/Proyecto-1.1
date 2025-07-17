using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capadatos
{
    public class Rutas
    {
        public string Destino { get; set; }
        public int Precio { get; set; }
        public string Salida { get; set; }

        public Rutas(string destino, int precio, string salida)
        {
            Destino = destino;
            Precio = precio;
            Salida = salida;
        }
    }
    
    
}
