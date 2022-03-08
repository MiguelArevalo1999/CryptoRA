using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CryptoRA.Helper;
using CryptoRA.Cryptography;

namespace CryptoRA
{
    public partial class FormNuevoUsuario : Form
    {
        private DPFP.Template Template;
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

       
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicio();
            formulario1.Show();
            this.Hide();
        }

        private void InscribirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] streamHuella = Template.Bytes;
                byte[] hashHuella = CryptoHelper.ComputeHash512(streamHuella);

                Console.WriteLine("Huella: " + ByteArrayToString(streamHuella));
                Console.WriteLine("Hash: " + ByteArrayToString(hashHuella));
                Console.WriteLine(hashHuella.Length);
                
                CryptoHelper.getPublicKey(hashHuella);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            MessageBox.Show("Usuario inscrito correctamente");
        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            DBHelper.EstablishConnection();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ValidarBtn_Click(object sender, EventArgs e)
        {
           CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                InscribirBtn.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("La plantilla de huellas dactilares está lista.", "Inscripción de huellas dactilares");
                    
                }
                else
                {
                    MessageBox.Show("La plantilla de huella dactilar no es válida. Repita el registro de huellas dactilares.", "Inscripción de huellas dactilares");
                }
            }));
        }
    }
}
