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

namespace CapaPresentacion
{
    public partial class FormUsuario : Form
    {

        //instanciamos
        CNUsuario cnusuario = new CNUsuario();

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnAddpropietario_Click(object sender, EventArgs e)
        {
            // Captura los valores de los TextBox
            string nombre = txtnombprop.Text;
            string apellido = txtapellprop.Text;
            string docPropi = txtdocprop.Text;
            string correprop = txtcorreoprop.Text;
            string celprop = txtcelularprop.Text;
            string contra1 = txtcontra1.Text;
            string contra2 = txtcontra2.Text;
            string tipousu = Convert.ToString(cbxtipousuario.SelectedItem);
            DateTime fecha = dtfechanacprop.Value;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(docPropi) ||
                string.IsNullOrWhiteSpace(correprop) ||
                string.IsNullOrWhiteSpace(contra1) ||
                string.IsNullOrWhiteSpace(contra2) ||
                string.IsNullOrWhiteSpace(tipousu))  // Verificar si se seleccionó un tipo de usuario
            {
                MessageBox.Show("¡Por favor, complete todos los campos!", "Validación de CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin hacer nada si hay campos vacíos
            }

            // Verificar si las contraseñas coinciden
            if (contra1 != contra2)
            {
                // Cambiar el color de fondo de los campos de contraseña si no coinciden
                txtcontra1.BackColor = Color.Red;
                txtcontra2.BackColor = Color.Red;
                MessageBox.Show("¡Las contraseñas no coinciden!", "Validación de Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpiar y restaurar colores después de la validación
                txtcontra1.Text = "";
                txtcontra2.Text = "";
                txtcontra1.BackColor = Color.White;
                txtcontra2.BackColor = Color.White;

                return; // Salir sin continuar con la inserción si las contraseñas no coinciden
            }

            // Si pasa la validación, proceder a insertar el usuario
            cnusuario.AddUsuario(nombre, apellido, docPropi, correprop, celprop, contra1, tipousu, fecha);

            // Limpiar los campos después de agregar el propietario
            cnusuario.Limpiar(txtnombprop, txtapellprop, txtdocprop, txtcorreoprop, txtcelularprop, txtcontra1, txtcontra2, cbxtipousuario, dtfechanacprop);
        }



    }
}
