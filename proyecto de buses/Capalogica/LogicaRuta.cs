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
        private List<Rutas> rutas = new List<Rutas>();//lista que almacena las rutas

        public void AgregarRuta(Rutas ruta)//metodo para agregar una nueva ruta a la lista
        {
            rutas.Add(ruta);//agrega la ruta que se creo a la lista de rutas
        }
        public List<Rutas> Obtener() //metodo para obtener la lista de rutas
        {
            return rutas;//devuelve a las rutas almecenadas
        }
    }
    
}
