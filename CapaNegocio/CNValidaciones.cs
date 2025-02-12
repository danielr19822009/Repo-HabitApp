using CapaDatos;

namespace CapaNegocio
{
    public class CNValidaciones
    {

        //Instancio la conexion
        CDConexion cnconexion = new CDConexion();


        //Validar solo letras
        public bool SoloLetras(string input)
        {
            // Verifica que toda la entrada sean letras o espacios
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ') // Permite letras y espacios
                {
                    return false;
                }
            }
            return true;
        }


    }
}
