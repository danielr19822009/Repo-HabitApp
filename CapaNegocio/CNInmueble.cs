using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class CNInmueble
    {

        //Instancio la conexion
        CDConexion cnconexion = new CDConexion();

        public ComboBox cbx_idpropietario { get; set; }
        public ComboBox cbx_nombrepropietario { get; set; }

        public void AddInmueble(int propietarioid, string nombpropietario, string descrinmueble, string tipoinmueble, string direinmueble, string ciudad)
        {
            try
            {
                // Establecemos la conexión con la base de datos
                using (MySqlConnection conexion = cnconexion.OpenConexion())
                {
                    conexion.Open();

                    // Consultar la consulta de inserción SQL
                    string query = "INSERT INTO inmueble(Tipo_Inmueble, Direccion, Ciudad, Descripcion, Propietarioid) VALUES ('@Tipo_Inmueble','@Direccion','@Ciudad','@Descripcion','@Propietarioid')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        // Agregar parámetros a la consulta para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@Tipo_Inmueble", tipoinmueble);
                        cmd.Parameters.AddWithValue("@Direccion", direinmueble);
                        cmd.Parameters.AddWithValue("@Ciudad", ciudad);
                        cmd.Parameters.AddWithValue("@Descripcion", descrinmueble);
                        cmd.Parameters.AddWithValue("@Propietarioid", propietarioid);


                        cmd.ExecuteNonQuery();

                        // Confirmar que los datos fueron insertados
                        MessageBox.Show("Inmueble Cargado correctamente.", "Registro Inmueble - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                Console.WriteLine("Error al Cargar el Inmueble: " + ex.Message);

            }
        }


      


    }
}
