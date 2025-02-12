using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CDConexion
    {
        private string connectionString = "Server=localhost;Database=habitapp;Uid=root;Pwd=;Port=3306;";
        private MySqlConnection connection;

        // Constructor
        public CDConexion()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Método para probar la conexión
        // Método para probar la conexión
        public void TestConexion()
        {
            try
            {
                // Crear la conexión usando la cadena de conexión
                using (connection = new MySqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Verificar el estado de la conexión
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Conexión EXITOSA!!!", "CONECTANDO CON EL SERVIDOR XAMP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, mostrar el mensaje de error
                MessageBox.Show("Error al conectarse al servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para abrir la conexión y devolver el objeto MySqlConnection
        public MySqlConnection OpenConexion()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                // Abrir la conexión
                connection.Open();
            }
            catch (Exception ex)
            {
                // Si hay un error, mostrar el mensaje de error y devolver null
                MessageBox.Show("Error de conexión al servidor, revise los servicios de XAMPP: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            return connection;
        }

        // Método para cerrar la conexión
        public void CloseConexion()
        {
            try
            {
                // Verificar si la conexión está abierta
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    MessageBox.Show("Conexión cerrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La conexión ya estaba cerrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Mostrar error si ocurre al cerrar la conexión
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
