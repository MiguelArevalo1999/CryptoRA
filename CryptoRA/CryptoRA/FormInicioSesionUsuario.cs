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
using CryptoRA.Cryptography;

namespace CryptoRA
{
    public partial class FormInicioSesionUsuario : Form
    {
        private DPFP.Template Template;
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
            Usuario aUser = null;
            string nombreUsuario = null;
            byte[] streamHuella = null;
            byte[] hashHuella = null;
            bool verified = false;

            try
            {
                nombreUsuario = txBoxNombreUsuario.Text;
                aUser = UsuariosDA.RegresaUsuario(nombreUsuario);
                using (VerificarHuella verifica = new VerificarHuella(nombreUsuario))
                {
                    verifica.OnTemplate += this.OnTemplate;
                    verifica.ShowDialog();
                    verified = verifica.ReturnVerification;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (aUser.NombreUsuario.Equals(nombreUsuario) && aUser.isAdmin.Equals(false) && verified)
            {
                Form formulario1 = new FormUsuario(aUser);
                formulario1.Show();
                this.Hide();
            }
            else if (aUser.NombreUsuario.Equals(nombreUsuario) && aUser.isAdmin.Equals(true) && verified)
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
            Template = null;
            //Form formulario2 = new FormInicioAdmin(aUser);
            //formulario2.Show();
            //this.Hide();

        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                if (Template != null)
                {
                    MessageBox.Show("La plantilla de huellas dactilares está lista.", "Verificación de huella dactilar");

                }
                else
                {
                    MessageBox.Show("La plantilla de huella dactilar no es válida. Repita el registro de huellas dactilares.", "Verificación de huella dactilar");
                }
            }));
        }

    }
}
