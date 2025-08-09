using proyecto_de_buses.Capadatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capalogica
{
    public static class LogicaAgregarVenta
    {
        private static List<Venta> ventas = new List<Venta>();

        public static void AgregarVenta(Venta venta)
        {
            ventas.Add(venta);
        }
        public static List<Venta> ObtenerVentas()
        {
            return ventas;
        }
        public static void EliminarVenta(Venta venta)
        {
            ventas.Remove(venta);
        }
    }
}
