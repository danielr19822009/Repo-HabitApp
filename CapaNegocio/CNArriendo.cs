using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public  class CNArriendo
    {

        //Instancio la conexion
        CDConexion cnconexion = new CDConexion();

        public void AddArriendo(int inmuebleId, int inquilinoId, DateTime fechaInicio, DateTime fechaFin, decimal precio)
        {
            try
            {
                // Establecemos la conexión con la base de datos
                using (MySqlConnection conexion = cnconexion.OpenConexion())
                {
                    conexion.Open();

                    // Consultar la consulta de inserción SQL
                    string query = "INSERT INTO Arriendos (InmuebleID, InquilinoID, FechaInicio, FechaFin, Precio) VALUES (@InmuebleID, @InquilinoID, @FechaInicio, @FechaFin, @Precio)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        // Agregar parámetros a la consulta para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@InmuebleID", inmuebleId);
                        cmd.Parameters.AddWithValue("@InquilinoID", inquilinoId);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                        cmd.Parameters.AddWithValue("@Precio", precio);

                        
                        cmd.ExecuteNonQuery();

                        // Confirmar que los datos fueron insertados
                        MessageBox.Show("Arriendo Cargado correctamente.", "Registro Arriendo - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                Console.WriteLine("Error al agregar el arriendo: " + ex.Message);
              
            }
        }


    }
}
