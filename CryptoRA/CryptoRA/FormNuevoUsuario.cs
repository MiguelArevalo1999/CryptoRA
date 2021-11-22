using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace CryptoRA
{
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ZkLlTzxNuSCCHTaaP4orjzLhww0YSpYaNcrp5VK4",
            BasePath = "https://cryptora-5859e-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicio();
            formulario1.Show();
            this.Hide();
        }

        private void InscribirBtn_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario()
            {
                NombreUsuario = usuarioTbox.Text,
                Correo = correoTbox.Text,
                Nombre = nombreTbox.Text,
                Apellidos = apellidosTbox.Text,
                isAdmin = Convert.ToBoolean(isAdminCb.SelectedItem),

            };
            var setter = client.Set("usuarios/"+usuarioTbox.Text,u);
            MessageBox.Show("Usuario inscrito correctamente");
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Ha habido un problema en el internet");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
