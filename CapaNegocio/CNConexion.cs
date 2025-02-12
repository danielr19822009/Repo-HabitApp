using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class CNConexion
    {
        //Instancio la conexion
        CDConexion cnconexion = new CDConexion();

        // Método para probar la conexión
        public void TestConexion()
        {
            cnconexion.TestConexion(); // Test the connection in CDConexion
        }

        // Método para abrir la conexión
        public MySqlConnection CNOpenConexion()
        {
            return cnconexion.OpenConexion();
        }

        // Método para cerrar la conexión
        public void CloseConexion()
        {
            cnconexion.CloseConexion();
        }

        // Método para obtener la conexión
        public MySqlConnection GetConexion()
        {
            return cnconexion.OpenConexion(); // Return the MySQL connection
        }
    }
}
