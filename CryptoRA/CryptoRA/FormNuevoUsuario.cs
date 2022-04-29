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
using System.Numerics;
using CryptoRA.DA_Layer;
using System.IO;

namespace CryptoRA
{
    public partial class FormNuevoUsuario : Form
    {
        Usuario aUser;
        private DPFP.Template Template;
        public FormNuevoUsuario(Usuario useradmin)
        {
            aUser = useradmin;
            InitializeComponent();
        }

       
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicioAdmin(aUser);
            formulario1.Show();
            this.Hide();
        }

        private void InscribirBtn_Click(object sender, EventArgs e)
        {
            string nombreUsuario,correo, nombre, apellidos, esAdmin;
            bool tryAgain = true;
            while(tryAgain)
            {
                try
                {
                    byte[] streamHuella = Template.Bytes;
                    byte[] hashHuella = CryptoHelper.ComputeHash512(streamHuella);

                    Console.WriteLine("Huella: " + ByteArrayToString(streamHuella));
                    Console.WriteLine("Hash SHA-512: " + ByteArrayToString(hashHuella));

                    RSAParameters rsaParameters = CryptoHelper.getAsymmetricParameters(hashHuella);
                    Console.WriteLine(rsaParameters.Exponent.Length);
                    if (rsaParameters.Exponent.Length>1) 
                    {
                        Console.WriteLine("Números primos válidos...");
                        tryAgain = false;
                        byte[] pubkey_bytes = rsaParameters.Exponent;
                        byte[] DPbytes = rsaParameters.DP;
                        byte[] DQbytes = rsaParameters.DQ;
                        byte[] inverseQbytes = rsaParameters.InverseQ;
                        byte[] Pbytes = rsaParameters.P;
                        byte[] Qbytes = rsaParameters.Q;
                        byte[] Dbytes = rsaParameters.D;
                        byte[] Nbytes = rsaParameters.Modulus;

                        nombreUsuario = Convert.ToString(usuarioTbox.Text);
                        correo = Convert.ToString(correoTbox.Text);
                        nombre = Convert.ToString(nombreTbox.Text);
                        apellidos = Convert.ToString(apellidosTbox.Text);
                        esAdmin = Convert.ToString(isAdminCb.SelectedItem);


                        UsuariosDA.InsertaUsuario(nombreUsuario, correo, nombre, apellidos, streamHuella, hashHuella, pubkey_bytes,
                                                    esAdmin, DPbytes, DQbytes, inverseQbytes, Pbytes, Qbytes, Dbytes, Nbytes);
                    }
                    else
                    {
                        Console.WriteLine("Números primos inválidos... Generando otros.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
           
           
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

        private void isAdminCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
