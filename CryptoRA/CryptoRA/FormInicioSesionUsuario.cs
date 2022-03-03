using CryptoRA.DA_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoRA
{
    public partial class FormInicioSesionUsuario : Form
    {
        public FormInicioSesionUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicio();
            formulario1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txBoxNombreUsuario.Text;

            Usuario aUser = UsuariosDA.RegresaUsuario(nombreUsuario);

            if (aUser.NombreUsuario.Equals(nombreUsuario) && aUser.isAdmin.Equals(false))
            {
                Form formulario1 = new FormUsuario(aUser);
                formulario1.Show();
                this.Hide();
            }
            else if (aUser.NombreUsuario.Equals(nombreUsuario) && aUser.isAdmin.Equals(true))
            {
                Form formulario2 = new FormInicioAdmin(aUser);
                formulario2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido, intente de nuevo");
                txBoxNombreUsuario.Text = "";
            }
        }
    }
}
