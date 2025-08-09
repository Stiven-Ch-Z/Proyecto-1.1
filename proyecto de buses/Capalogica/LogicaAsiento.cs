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
        private static List<Asientos> asientosVendidos = new List<Asientos>();

        public static void MarcarVendidos(Asientos asiento)
        {
            asientosVendidos.Add(asiento);
        }
        public static List<Asientos> ObtenerVendidos()
        {
            return asientosVendidos;
        }
    }
}
