using proyecto_de_buses.Capadatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capalogica
{
    public class LogicaAsiento
    {
        private static List<Asientos> asientosVendidos = new List<Asientos>();//lista que almacena todos los asientos que se vendieron

        public static void MarcarVendidos(Asientos asiento)//metodo que marca los asientos que han sido vendidos
        {
            asientosVendidos.Add(asiento);//agrega el asiento selecionado a los asientos vendidos
        }
        public static List<Asientos> ObtenerVendidos()//metodo para obtener la lista de los asientos vendidos
        {
            return asientosVendidos;//se devuelve a la lista de los asientos vendidos
        }
    }
}
