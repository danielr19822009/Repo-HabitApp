using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using MySql.Data.MySqlClient;
using static Mysqlx.Crud.Order.Types;

namespace CapaNegocio
{
    public class CNInmueble
    {

        //Instancio la conexion
        CDConexion cnconexion = new CDConexion();


        public void AddInmueble(int arriendoID, string descripcion, string tipo_Inmueble, string direccion, string ciudad)
        {

            
            try
            {
                // Establecemos la conexión con la base de datos
                using (MySqlConnection conexion = cnconexion.OpenConexion())
                {
                   

                    // Consultar la consulta de inserción SQL
                    string query = "INSERT INTO inmueble(Tipo_Inmueble, Direccion, Ciudad, Descripcion, arriendoID) VALUES (@tipo_Inmueble,@Direccion,@Ciudad,@Descripcion,@usuarioid)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {

                       
                        // Agregar parámetros a la consulta para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@tipo_Inmueble", tipo_Inmueble);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@ciudad", ciudad);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@usuarioid", arriendoID);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hola si entre 3");
                        // Confirmar que los datos fueron insertados
                        MessageBox.Show("Inmueble Cargado correctamente.", "Registro Inmueble - Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                       
                    }
                    
                }
            }
            catch (MySqlException ex)
            {
               
                MessageBox.Show("Error al registrar Inmueble: " + ex.Message, "Registro Usuario - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                Console.WriteLine("Error al Cargar el Inmueble: " + ex.Message);

            }
           
        }


        public DataTable MostrarArriendo()
        {
            DataTable tabla_arriendo = new DataTable(); // Asegurarse de que el DataTable esté inicializado.

            try
            {
                // abrir la conexión
                MySqlConnection conn = cnconexion.OpenConexion();

                // Consulta para obtener los usuarios
                string queryariendo = "SELECT * FROM arriendos";
                MySqlDataAdapter adapter_arri = new MySqlDataAdapter(queryariendo, conn);

                adapter_arri.Fill(tabla_arriendo); // Llenar el DataTable

                conn.Close();  // No olvides cerrar la conexión después de usarla.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

            return tabla_arriendo; // Devolver el DataTable correctamente.
        }



    }
}
