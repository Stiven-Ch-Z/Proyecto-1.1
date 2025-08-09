using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capadatos
{
    using System;
    public class Venta
    {
        
        
            public Cliente Cliente { get; set; }
            public string Ruta { get; set; }
            public string Hora_Salida { get; set; }
            public string Hora_Llegada { get; set; }
            public List<int> Asientos { get; set; }
            public decimal Total { get; set; }
            public DateTime Fecha { get; set; }
        public string NombreCliente => Cliente?.Nombre ?? "";
        public string CedulaCliente => Cliente != null ? Cliente.Cedula.ToString() : "";
        public string AsientosTexto => Asientos != null ? string.Join(", ", Asientos) : "";
        public int CantidadAsientos => Asientos?.Count ?? 0;
    }
}
