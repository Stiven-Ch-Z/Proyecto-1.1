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
        private static List<Venta> ventas = new List<Venta>();//lista que almacena las ventas

        public static void AgregarVenta(Venta venta)//metodo para agregar una nueva venta a la lista
        {
            ventas.Add(venta);// se agrega la venta a la lista de ventas
        }
        public static List<Venta> ObtenerVentas()//metodo para obtener la lista de todas las ventas
        {
            return ventas;
        }
        public static void EliminarVenta(Venta venta)//metodo para eliminar una venta de la lista
        {
            ventas.Remove(venta);//se elimina la venta 
        }
    }
}
