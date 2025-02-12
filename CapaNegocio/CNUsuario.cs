using System.Drawing;
using System.Windows.Forms;
using System;
using CapaDatos;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Data;

namespace CapaNegocio
{
    public class CNUsuario
    {
        //Instancio la conexion
        CDConexion cnconexion = new CDConexion();


        public void AddUsuario(string nombre, string apellido, string docPropi, string correprop, string celprop, string contra1, string tipousu, DateTime fecha)
        {
            try
            {
                // Seguridad: Cifrar la contraseña antes de insertarla
                string contraveri = HashPassword(contra1);

                // Abrir la conexión
                MySqlConnection conn = cnconexion.OpenConexion();

                // Query de inserción
                string qinsertusuario = "INSERT INTO usuarios(nombre, apellido, documentoIdentidad, fechaNacimiento, correo, telefono, contrasena, tipoUsuario) " +
                                         "VALUES (@nombre, @apellido, @docidentidad, @fechanac, @correo, @telefono, @contrasena, @tipousuario)";

                MySqlCommand cmd = new MySqlCommand(qinsertusuario, conn);

                // Asignar los valores de los parámetros
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@docidentidad", docPropi);
                cmd.Parameters.AddWithValue("@fechanac", fecha);
                cmd.Parameters.AddWithValue("@correo", correprop);
                cmd.Parameters.AddWithValue("@telefono", celprop);
                cmd.Parameters.AddWithValue("@contrasena", contraveri);
                cmd.Parameters.AddWithValue("@tipousuario", tipousu);

                // Ejecutar la consulta de inserción
                cmd.ExecuteNonQuery();

                // Confirmar que los datos fueron insertados
                MessageBox.Show("Usuario insertado correctamente.", "Registro Usuario - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Registro Usuario - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Método para cifrar la contraseña
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }




       



    }
}
