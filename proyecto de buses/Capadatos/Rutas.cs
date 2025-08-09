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
        public decimal Precio { get; set; }
        public string Horasalida { get; set; }
        public string Horallegada {  get; set; }

        public override string ToString()
        {
            return $"{Destino}-{Horasalida}-{Horallegada}-₡{Precio}";
        }
    }
    

    
}
