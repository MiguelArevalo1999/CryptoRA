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

namespace CryptoRA
{
    public partial class FormNuevoUsuario : Form
    {
        // Declare CspParmeters and RsaCryptoServiceProvider
        // objects with global scope of your Form class.
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        const string EncrFolder = @"C:\Users\mival\source\repos\CryptoRA\CryptoRA\CryptoRA\Resources\Cifrado\";
        const string DecrFolder = @"C:\Users\mival\source\repos\CryptoRA\CryptoRA\CryptoRA\Resources\Descifrado\";
        const string SrcFolder = @"C:\Users\mival\source\repos\CryptoRA\CryptoRA\CryptoRA\Resources\Docs\";

        // Public key file
        const string PubKeyFile = @"c:\encrypt\rsaPublicKey.txt";

        // Key container name for
        // private/public key value pair.
        const string KeyName = "Key01";

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
            //Usuario u = new Usuario()
            //{
            //    NombreUsuario = usuarioTbox.Text,
            //    Correo = correoTbox.Text,
            //    Nombre = nombreTbox.Text,
            //    Apellidos = apellidosTbox.Text,
            //    isAdmin = Convert.ToBoolean(isAdminCb.SelectedItem),

            //};
           

            // Stores a key pair in the key container.
            _cspp.KeyContainerName = KeyName;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };

            label1.Text = _rsa.PublicOnly
                ? $"Key: {_cspp.KeyContainerName} - Public Only"
                : $"Key: {_cspp.KeyContainerName} - Full Key Pair";

            MessageBox.Show("Usuario inscrito correctamente");
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch
            {
                
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
