using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using MySql.Data.MySqlClient;

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
            // abrir la conexión
            MySqlConnection conn = cnconexion.CNOpenConexion();

            // Consulta para obtener los usuarios
            string queryuser = "SELECT * FROM usuarios";
            MySqlDataAdapter adapter_user = new MySqlDataAdapter(queryuser, conn);
            DataTable tabla_user = new DataTable();
            adapter_user.Fill(tabla_user);

            // Asignar el DataTable como origen de datos en el ComboBox para el nombre
            cbx_nombrepropietario.DataSource = tabla_user;
            cbx_nombrepropietario.DisplayMember = "nombre";  // Mostrar el nombre
            cbx_nombrepropietario.ValueMember = "propietarioID"; // Valor será el ID del propietario

            // Asignar el DataTable como origen de datos en el ComboBox para el ID
            cbx_idpropietario.DataSource = tabla_user;
            cbx_idpropietario.DisplayMember = "propietarioID";  // Mostrar el ID del propietario
            cbx_idpropietario.ValueMember = "propietarioID";    // El valor será el mismo (ID)

        }

        private void FormInmueble_Load(object sender, EventArgs e)
        {

            MostrarUsuario();

        }
    }
    }
