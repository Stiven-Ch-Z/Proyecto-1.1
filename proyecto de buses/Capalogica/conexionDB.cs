using proyecto_de_buses.Capadatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_buses.Capalogica
{
    using MySql.Data.MySqlClient;

    public class ConexionBD
    {
        private MySqlConnection conexion;

        public ConexionBD()
        {
            string cadena = "Server=localhost;Database=TransporteDB;Uid=root;Pwd=;";
            conexion = new MySqlConnection(cadena);
        }

        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }
        public void RegistrarVenta(int idRuta, int idHorario, DateTime fechaViaje, string nombreCliente, string cedulaCliente, List<(int numeroAsiento, bool preferencial)> asientos)
        {
            ConexionBD conexionBD = new ConexionBD();
            using (var con = conexionBD.ObtenerConexion())
            {
                con.Open();

                // 1. Insertar venta
                string sqlVenta = "INSERT INTO Ventas (IdRuta, IdHorario, FechaViaje, FechaHoraEmision, NombreCliente, CedulaCliente) " +
                                  "VALUES (@IdRuta, @IdHorario, @FechaViaje, NOW(), @NombreCliente, @CedulaCliente)";
                MySqlCommand cmdVenta = new MySqlCommand(sqlVenta, con);
                cmdVenta.Parameters.AddWithValue("@IdRuta", idRuta);
                cmdVenta.Parameters.AddWithValue("@IdHorario", idHorario);
                cmdVenta.Parameters.AddWithValue("@FechaViaje", fechaViaje);
                cmdVenta.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                cmdVenta.Parameters.AddWithValue("@CedulaCliente", cedulaCliente);
                cmdVenta.ExecuteNonQuery();

                // Obtener el ID de la venta recién insertada
                long idVenta = cmdVenta.LastInsertedId;

                // 2. Insertar asientos
                foreach (var asiento in asientos)
                {
                    string sqlAsiento = "INSERT INTO AsientosVendidos (IdVenta, NumeroAsiento, Preferencial) VALUES (@IdVenta, @NumeroAsiento, @Preferencial)";
                    MySqlCommand cmdAsiento = new MySqlCommand(sqlAsiento, con);
                    cmdAsiento.Parameters.AddWithValue("@IdVenta", idVenta);
                    cmdAsiento.Parameters.AddWithValue("@NumeroAsiento", asiento.numeroAsiento);
                    cmdAsiento.Parameters.AddWithValue("@Preferencial", asiento.preferencial);
                    cmdAsiento.ExecuteNonQuery();
                }

                MessageBox.Show("Venta registrada correctamente.");
            }
        }
    }
}
