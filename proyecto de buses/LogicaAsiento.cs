using proyecto_de_buses.Capadatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses
{
    public class LogicaAsiento
    {
        private List<Asientos> asientos = new List<Asientos>();

        public void AgregarAsientos(Asientos asiento)
        {
            asientos.Add(asiento);
        }
        public List<Asientos> Obtener()
        {
            return asientos;
        }
    }
}
