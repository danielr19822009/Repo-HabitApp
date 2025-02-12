using System;
using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class CDLogin
    {
        private CDConexion cnconexion = new CDConexion();

        // Método para obtener la contraseña del usuario
        public string ObtenerContraseña(string usuario)
        {
            string password = null;

            try
            {

                using (MySqlConnection connection = cnconexion.OpenConexion())  // Usar el método correctamente
                {
                    connection.Open();
                    string query = "SELECT contrasena FROM propietarios WHERE nombre = @usuario";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                password = reader["contrasena"].ToString();  //captura en la variable password la contraseña capturada de la bd
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la contraseña: {ex.Message}");
            }

            return password;
        }
    }
}

