using System.Drawing;
using System.Linq;
using System;
using System.Windows.Forms;
using CapaDatos;
using static System.Net.Mime.MediaTypeNames;

namespace CapaNegocio
{
    public class CNValidaciones
    {

        //Instancio la conexion
        CDConexion cnconexion = new CDConexion();


        //Validar solo letras
        //public bool SoloLetras(string input)
        //{ 
        //    foreach (char c in input)
        //    {
        //        if (!char.IsLetter(c) && c != ' ') // Permite letras y espacios
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        public  bool SoloLetras(TextBox txt)
        {
            string input = txt.Text;

            // Comprobar si el texto contiene solo letras y espacios
            if (string.IsNullOrWhiteSpace(input) || !input.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                txt.BackColor = Color.Red;  // Cambiar el color de fondo
                MessageBox.Show("Solo se permiten letras y espacios.");
                txt.Text = string.Empty;  // Limpiar el texto
                txt.BackColor = Color.White;  // Restaurar el color del fondo
                return false;  // Retorna false si no es válido
            }
            return true;  // Si es válido, retorna true
        }

        public  bool SoloNumeros(TextBox txt)
        {
            string input = txt.Text;
            // Comprobar si el texto contiene solo números
            if (string.IsNullOrWhiteSpace(input) || !input.All(Char.IsDigit))
            { 
                MessageBox.Show("Solo se permiten números.");
                return false;  // Retorna false si no es válido
            }
            return true;  // Si es válido, retorna true
        }



    }
}
