using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoRA.DA_Layer;

namespace CryptoRA
{
    public partial class VerificarHuella : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private string nombreusuario;
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de huella dactilar";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                try
                {
                    // Compare the feature set with our template
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                    DPFP.Template template = new DPFP.Template();
                    Stream stream;
                    Usuario user =  UsuariosDA.RegresaUsuario(nombreusuario);
                    byte[] streamHuella = user.Template;
                    Console.WriteLine(ByteArrayToString(streamHuella));
                    stream = new MemoryStream(streamHuella);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        MakeReport("La huella dactilar fue verificada " + nombreusuario);
                        ReturnVerification = result.Verified;
                    }
                    else
                    {
                        MakeReport("Huella dactilar no verificada,intente nuevamente." + nombreusuario);
                        ReturnVerification = result.Verified;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }

        }
        public VerificarHuella(string nombreUsuario)
        {
            nombreusuario = nombreUsuario;
            InitializeComponent();

        }

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        public bool ReturnVerification { get; set; }
    }
}
