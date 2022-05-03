using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Security.Cryptography;

namespace CryptoRA
{
    public partial class FormDescifrado : Form
    {
        // Declare CspParmeters and RsaCryptoServiceProvider
        // objects with global scope of your Form class.
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;
        RSAParameters rsaParameters;
        string fName;
        OpenFileDialog _decryptOpenFileDialog = new OpenFileDialog();
        private DPFP.Template Template;
        bool verified = false;

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        const string EncrFolder = @"c:\Users\mival\source\repos\MiguelArevalo1999\CryptoRA\CryptoRA\CryptoRA\Cifrado\";
        const string DecrFolder = @"c:\Users\mival\source\repos\MiguelArevalo1999\CryptoRA\CryptoRA\CryptoRA\Descifrado\";
        

        public Usuario aUser1 = null;
        public FormDescifrado(Usuario aUser)
        {
            InitializeComponent();
            aUser1 = aUser;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form formulario4 = new FormUsuario();
            //formulario4.Show();
            this.Hide();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void FormDescifrado_Load(object sender, EventArgs e)
        {
            descifrarButton.Enabled = false;
           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (_rsa is null)
            {
                MessageBox.Show("Llave privada no configurada.");
            }
            else
            {
                // Display a dialog box to select the encrypted file.
                _decryptOpenFileDialog.InitialDirectory = EncrFolder;
                if (_decryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fName = _decryptOpenFileDialog.FileName;
                    if (fName != null && verified)
                    {
                        descifrarButton.Enabled=true;
                    }
                }
            }
        }

        private void DecryptFile(FileInfo file)
        {
            // Create instance of Aes for
            // symmetric decryption of the data.
            Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.KeySize = 128;

            // Create byte arrays to get the length of
            // the encrypted key and IV.
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];
            Console.WriteLine(file);
            // Construct the file name for the decrypted file.
            string outFile =
                Path.ChangeExtension(file.FullName.Replace("Cifrado", "Descifrado"),"." + extTxBox.Text);

            // Use FileStream objects to read the encrypted
            // file (inFs) and save the decrypted file (outFs).
            using (var inFs = new FileStream(file.FullName, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start postition of
                // the ciphter text (startC)
                // and its length(lenC).
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for
                // the encrypted Aes key,
                // the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV
                // starting from index 8
                // after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);

                Directory.CreateDirectory(DecrFolder);
                // Use RSACryptoServiceProvider
                // to decrypt the AES key.
                byte[] KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false);

                // Decrypt the key.
                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                // Decrypt the cipher text from
                // from the FileSteam of the encrypted
                // file (inFs) into the FileStream
                // for the decrypted file (outFs).
                using (var outFs = new FileStream(outFile, FileMode.Create))
                {
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    // By decrypting a chunk a time,
                    // you can save memory and
                    // accommodate large files.

                    // Start at the beginning
                    // of the cipher text.
                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (var outStreamDecrypted =
                        new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        } while (count > 0);

                        outStreamDecrypted.FlushFinalBlock(); MessageBox.Show("Archivo descifrado correctamente.");
                    }
                }
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
                rsaParameters.Modulus = aUser1.N;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            using (VerificarHuella verifica = new VerificarHuella(aUser1.NombreUsuario))
            {
                verifica.OnTemplate += this.OnTemplate;
                verifica.ShowDialog();
                verified = verifica.ReturnVerification;
                descifrarButton.Enabled = verified;
                if (verified)
                {
                    try
                    {
                        _rsa = new RSACryptoServiceProvider();
                        generateRSAParameters();
                        _rsa.ImportParameters(rsaParameters);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void descifrarButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(extTxBox.Text))
            {
                MessageBox.Show("Extensión no válida, escriba la extensión del archivo. Ejemplo: txt, mp4, png");
            }
            else
            {
                try
                {
                    DecryptFile(new FileInfo(fName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al descifrar: " + ex.Message);
                }
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

        private void extTxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void abrirCifradoDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", DecrFolder);
        }
    }
}
