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
            string tipousu = cbxtipousuario.SelectedItem.ToString();
            DateTime fecha = dtfechanacprop.Value;

            // Verificar si las contraseñas coinciden
            if (contra1 == contra2)
            {
                // Llamar a la función de inserción
                cnusuario.AddUsuario(nombre, apellido, docPropi, correprop, celprop, contra1, tipousu, fecha);
            }
            else
            {
                txtcontra1.BackColor = Color.Red;
                txtcontra2.BackColor = Color.Red;
                MessageBox.Show("¡Las contraseñas no coinciden!", "Validación de Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcontra1.Text = "";
                txtcontra2.Text = "";
                txtcontra1.BackColor = Color.White;
                txtcontra2.BackColor = Color.White;
            }
        }

     
    }
}
