using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormMenu : Form
    {
        //instanciamos
        // Instanciamos la capa de negocio
        CNValidaciones cnvalidaciones = new CNValidaciones();
        CNUsuario cnusuario = new CNUsuario();
        CNConexion cnconexion = new CNConexion();

        // Crear una instancia de la clase de negocio
        CNArriendo cnarriendo = new CNArriendo();

        // Crear una instancia de la clase de negocio
        CNInmueble cninmueble = new CNInmueble();

        // Propiedades para almacenar los valores
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string TipoUsuario { get; set; }

        // Constructor
        public FormMenu(string nombre, string apellido, string tipoUsuario)
        {
            InitializeComponent();

            // Asignar los valores a las propiedades
            NombreUsuario = nombre;
            ApellidoUsuario = apellido;
            TipoUsuario = tipoUsuario;
            
        }



        public void AbrirFormInPanel(Form Formhijo)
        {
            // Verifica si el panel tiene controles agregados
            if (this.splitContainer1.Panel2.Controls.Count > 0)
            {
                // Elimina el primer control agregado en Panel2
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }

            // Configura las propiedades del formulario hijo
            Formhijo.TopLevel = false; // El formulario no será de nivel superior
            Formhijo.Dock = DockStyle.Fill; // El formulario se ajustará al tamaño del panel

            // Agrega el formulario hijo al Panel2 del SplitContainer
            this.splitContainer1.Panel2.Controls.Add(Formhijo);

            // Muestra el formulario dentro del panel
            Formhijo.Show();
        }


        private void FormMenu2_Load(object sender, EventArgs e)
        {
            // Mostrar los valores en las etiquetas correspondientes
            lblgetusuario.Text = NombreUsuario + " " + ApellidoUsuario;
            MessageBox.Show(NombreUsuario);
            lbltipousuario.Text = TipoUsuario;

            // Validar si el tipo de usuario es diferente de "Administrador"
            if (TipoUsuario != "Administrador")
            {
                btnUsuario.Enabled = false;

            }

        }


        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            // Llama a AbrirFormInPanel y pasa un nuevo formulario FormUsuario
            AbrirFormInPanel(new FormUsuario());
        }

        private void btnInmueble_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormInmueble());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInquilino_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormInquilino());
        }

        private void btnArriendo_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormArriendo());
        }

        private void btnverArriendos_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormMisArriendo());
        }

        private void btnVerInmuebles_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormMisInmuebles());
        }
    }
}
