using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capadatos
{
    public class Rutas//encapsulamiento de rutaas
    {
        public string Destino { get; set; }//encapsulamiento de destino
        public decimal Precio { get; set; }//encapsulamiento del precio
        public string Horasalida { get; set; }//encapsulamiento de la hora de salida
        public string Horallegada {  get; set; }//encapsulamiento de la hora de llegada

        public override string ToString()
        {
            return $"{Destino}-{Horasalida}-{Horallegada}-₡{Precio}";//devuelve esos datos en forma de cadena 
        }
    }
    

    
}
