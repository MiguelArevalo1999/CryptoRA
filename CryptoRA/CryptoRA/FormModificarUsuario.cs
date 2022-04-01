using CryptoRA.DA_Layer;
using CryptoRA.Helper;
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
    public partial class FormModificarUsuario : Form
    {
        Usuario aUser;
        private string unombreUsuario;
        private string ucorreo;
        private string unombre;
        private string uapellidos;
        private string uesAdmin;
        private DPFP.Template Template;
        bool verified = false;

        public FormModificarUsuario(Usuario useradmin,string nombreUsuario,string correo,string nombre,string apellidos,string esAdmin)
        {
            this.unombreUsuario = nombreUsuario;
            this.ucorreo = correo;
            this.unombre = nombre;
            this.uapellidos = apellidos;
            this.uesAdmin = esAdmin;
            aUser = useradmin;
            DBHelper.EstablishConnection();
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            usuarioTbox.Text = unombreUsuario;
            usuarioTbox.ReadOnly = true;
            correoTbox.Text = ucorreo;
            nombreTbox.Text = unombre;
            apellidosTbox.Text = uapellidos;
            
        }

        private void ValidarBtn_Click(object sender, EventArgs e)
        {
            using (VerificarHuella verifica = new VerificarHuella(aUser.NombreUsuario))
            {
                verifica.OnTemplate += this.OnTemplate;
                verifica.ShowDialog();
                verified = verifica.ReturnVerification;
                ModificarBtn.Enabled = verified;
            }
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

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
           
            string correo = Convert.ToString(correoTbox.Text);
            string nombre = Convert.ToString(nombreTbox.Text);
            string apellidos = Convert.ToString(apellidosTbox.Text);
            string esAdmin = Convert.ToString(isAdminCb.SelectedItem);
            UsuariosDA.ModificaUsuario(unombreUsuario, correo, nombre, apellidos, esAdmin);
            if (esAdmin.Equals("False")) 
            { 
                Form inicio = new FormInicio();
                inicio.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form baseDatos = new FormBaseDatos(aUser);
            baseDatos.Show();
            this.Hide();
        }
    }
}
