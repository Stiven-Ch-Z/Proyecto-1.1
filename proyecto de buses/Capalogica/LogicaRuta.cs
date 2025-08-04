using proyecto_de_buses.Capadatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capalogica
{
    public class LogicaRuta
    {
        private List<Rutas> rutas = new List<Rutas>();

        public void AgregarRuta(Rutas ruta)
        {
            rutas.Add(ruta);
        }
        public List<Rutas> Obtener() 
        {
            return rutas;
        }
    }
    
}
