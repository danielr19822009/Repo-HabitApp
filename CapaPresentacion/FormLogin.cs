using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        // Instanciamos la capa de negocio
        CNValidaciones cnvalidaciones = new CNValidaciones();
        CNLogin cnlogin = new CNLogin();
        CNConexion cnconexion = new CNConexion();

        public FormLogin()
        {
            InitializeComponent();
        }

        // Método para generar el hash SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black; // Color original
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            IniciarSession();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cnconexion.TestConexion();
        }


        private void IniciarSession()
        {
            string contrasena = textBoxContrasena.Text.Trim();
            string usuario = textBoxUsuario.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return;
            }
            else if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, ingrese usuario.");
                return;
            }
            else if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese contraseña.");
                return;
            }

            // Encriptar la contraseña ingresada por el usuario
            string contrasenaHash = HashPassword(contrasena);

            string querylogin = "SELECT * FROM usuarios WHERE nombre = @usuario AND contrasena = @contrasena";

            try
            {
                // Usar la conexión abierta previamente
                using (MySqlConnection conexion = cnconexion.CNOpenConexion())
                {
                    if (conexion == null) return; // Si la conexión no se pudo abrir, no continuar

                    using (MySqlCommand cm = new MySqlCommand(querylogin, conexion))
                    {
                        // Agregar parámetros para evitar inyección SQL
                        cm.Parameters.AddWithValue("@usuario", usuario);
                        cm.Parameters.AddWithValue("@contrasena", contrasenaHash);

                        // Validar que el usuario sea propietario o administrador para dejarlo ingresar al sistema
                        using (MySqlDataReader lector = cm.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                // Obtener el tipo de usuario desde la base de datos
                                string tipousuario = lector["tipoUsuario"].ToString();

                                // Validar si el tipo de usuario es "propietario" o "administrador"
                                //if (tipousuario == "propietario" || tipousuario == "administrador")
                                //{
                                    // Concatenar el nombre y apellido correctamente
                                    string nombreCompleto = lector["nombre"].ToString() + " " + lector["apellido"].ToString();

                                    // Alerta mostrando el usuario
                                    MessageBox.Show("Bienvenido, " + nombreCompleto);

                                    // Crear variables para enviarlas al formulario de menú
                                    string nombre = lector["nombre"].ToString();
                                    string apellido = lector["apellido"].ToString();

                                    // Crear el formulario de menú y pasar los datos
                                    FormMenu formmenu = new FormMenu(nombre, apellido, tipousuario);
                                    formmenu.Show();

                                    // Cerramos el formulario login
                                    this.Hide();
                                //}
                                //else
                                //{
                                //    // Si el tipo de usuario no es permitido, mostrar un mensaje
                                //    MessageBox.Show("Acceso Denegado: Usuario no autorizado", "ERROR DE ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                //}
                            }
                            else
                            {
                                MessageBox.Show("Credenciales Incorrectas", "USUARIO SIN ACCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Mostrar el mensaje de error de la base de datos
                MessageBox.Show("Error en la BD: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar excepciones generales (como problemas en el formulario)
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            // Si quieres hacer alguna validación adicional al cambiar el texto
            if (!cnvalidaciones.SoloLetras(textBoxUsuario.Text))
            {
                textBoxUsuario.BackColor = Color.Red;

                // Mostrar un mensaje
                MessageBox.Show("Solo se permiten letras y espacios.");

                textBoxUsuario.Text = string.Empty;
                textBoxUsuario.BackColor = Color.White;
            }
        }




    }
}
