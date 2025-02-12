using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FormInmueble : Form
    {

        //instanciar
       CNInmueble cninmueble = new CNInmueble();
        CNConexion cnconexion = new CNConexion();
        public FormInmueble()
        {
            InitializeComponent();
         
        }

        private void MostrarUsuario()
        {

            //Manera directa
            //try
            //{

            //    // abrir la conexión
            //    MySqlConnection conn = cnconexion.CNOpenConexion();

            //    // Consulta para obtener los usuarios
            //    string queryuser = "SELECT * FROM usuarios";
            //    MySqlDataAdapter adapter_user = new MySqlDataAdapter(queryuser, conn);
            //    DataTable tabla_user = new DataTable();
            //    adapter_user.Fill(tabla_user);

            //    // Asignar el DataTable como origen de datos en el ComboBox para el nombre
            //    cbx_nombrepropietario.DataSource = tabla_user;
            //    cbx_nombrepropietario.DisplayMember = "nombre";  // Mostrar el nombre
            //    cbx_nombrepropietario.ValueMember = "propietarioID"; // Valor será el ID del propietario

            //    // Asignar el DataTable como origen de datos en el ComboBox para el ID
            //    cbx_idpropietario.DataSource = tabla_user;
            //    cbx_idpropietario.DisplayMember = "propietarioID";  // Mostrar el ID del propietario
            //    cbx_idpropietario.ValueMember = "propietarioID";    // El valor será el mismo (ID)

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al cargar datos: " + ex.Message);
            //}


            // Obtener los datos de los usuarios
            DataTable tabla_user = cninmueble.MostrarUsers();

            // Asignar el DataTable como origen de datos en el ComboBox para el nombre

            cbx_idpropietario.DataSource = tabla_user;
             // listaUsuarios is a List<Usuario> or a similar collection
            cbx_idpropietario.ValueMember = "UsuarioID";  // Property used for the value
           


            cbx_nombrepropietario.DataSource = tabla_user;
            cbx_nombrepropietario.DisplayMember = "nombre";  // Mostrar el nombre
            cbx_nombrepropietario.ValueMember = "nombre"; // Valor será el ID del propietario

        }

        private void FormInmueble_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }

        private void btnAddinmueble_Click(object sender, EventArgs e)
        {
            // Captura los valores de los TextBox
            int idusuario = Convert.ToInt16(cbx_idpropietario.SelectedValue);
            string descripcion = txt_DescripcionInmueble.Text;
            string tipoinmueble = Convert.ToString(cbx_nombrepropietario.SelectedValue);
            string direccion = txt_direccion.Text;
            string ciudad = txt_ciudad.Text;

            // Validar que los campos no estén vacíos
            if (
                string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(tipoinmueble) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(ciudad))
            {
                MessageBox.Show("¡Por favor, complete todos los campos!", "Validación de CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin hacer nada si hay campos vacíos
            }

            // Llamar a la función de inserción y enviar los parametros(variables que capturan los textbox)
            cninmueble.AddInmueble(idusuario, descripcion, tipoinmueble, direccion, ciudad);
        }
    }
    }
