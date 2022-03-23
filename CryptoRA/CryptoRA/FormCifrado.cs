using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace CryptoRA
{
    public partial class FormCifrado : Form
    {
        // Declare CspParmeters and RsaCryptoServiceProvider
        // objects with global scope of your Form class.
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;
        RSAParameters rsaParameters;
        string fName;
        OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog();

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        const string EncrFolder = @"c:\Users\mival\source\repos\MiguelArevalo1999\CryptoRA\CryptoRA\CryptoRA\Cifrado\";
        const string SrcFolder = @"c:\Users\mival\source\repos\MiguelArevalo1999\CryptoRA\CryptoRA\CryptoRA\Docs\";

        public Usuario aUser1 = null;
        public FormCifrado(Usuario aUser)
        {
            InitializeComponent();
            aUser1 = aUser;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormCifrado_Load(object sender, EventArgs e)
        {
            cifrarButton.Enabled = false;
                        
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form formulario4 = new FormUsuario(a);
            //formulario4.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            if (_rsa is null)
            {
                MessageBox.Show("Llave pública no configurada.");
            }
            else
            {
                // Display a dialog box to select a file to encrypt.
                _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fName = _encryptOpenFileDialog.FileName;
                    if (fName != null)
                    {
                        cifrarButton.Enabled = true;
                    
                        
                    }
                }
            }
        }

        private void CifrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Pass the file name without the path.
                EncryptFile(new FileInfo(fName));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cifrar: "+ ex.Message);
            }
        }

        public void generateRSAParameters()
        {
            rsaParameters = new RSAParameters();
            try
            { 
                rsaParameters.D = aUser1.D;
                rsaParameters.P = aUser1.P;
                rsaParameters.Q = aUser1.Q;
                rsaParameters.Exponent = aUser1.llavePublica;
                rsaParameters.DP = aUser1.DP;
                rsaParameters.DQ = aUser1.DQ;
                rsaParameters.InverseQ = aUser1.InverseQ;
                rsaParameters.P = aUser1.P;
                rsaParameters.Q = aUser1.Q;
                rsaParameters.Modulus = aUser1.N;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }


        private void EncryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric encryption of the data.
            Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            ICryptoTransform transform = aes.CreateEncryptor();

            // Use RSACryptoServiceProvider to
            // encrypt the AES key.
            // rsa is previously instantiated:
            //    rsa = new RSACryptoServiceProvider(cspp);
            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

            // Create byte arrays to contain
            // the length values of the key and IV.
            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);
            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - ecrypted key
            // - the IV
            // - the encrypted cipher content

            // Change the file's extension to ".enc"
            string outFile =
                Path.Combine(EncrFolder, Path.ChangeExtension(file.Name, ".enc"));

            using (var outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes.IV, 0, lIV);

                // Now write the cipher text using
                // a CryptoStream for encrypting.
                using (var outStreamEncrypted =
                    new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    // By encrypting a chunk at
                    // a time, you can save memory
                    // and accommodate large files.
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(file.FullName, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock(); MessageBox.Show("Documento cifrado");
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {   
             using (FormLlavesPublicasUsuarios formllavesPublicas = new FormLlavesPublicasUsuarios())
                {
                    formllavesPublicas.ShowDialog();
                    aUser1 = formllavesPublicas.llavePublicaUsuario;
                try
                {
                    _rsa = new RSACryptoServiceProvider();
                    generateRSAParameters();
                    _rsa.ImportParameters(rsaParameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Text, ex.Message);
                }
            }
        }
           
        
    }
}
