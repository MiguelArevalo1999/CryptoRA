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
    public partial class FormUsuario : Form
    {
        public Usuario aUser1 = null;

        public FormUsuario(Usuario aUser)
        {
            InitializeComponent();
            aUser1 = aUser;
            
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicio();
            formulario1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cifrado = new FormCifrado(aUser1);
            AbrirFormularios(cifrado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form descifrado = new FormDescifrado(aUser1);
            AbrirFormularios(descifrado);
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

            imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgProfile.Load(@"C:\Users\mival\source\repos\MiguelArevalo1999\CryptoRA\CryptoRA\CryptoRA\Resources\me_cobrakai.jpg");
            
        }

        private void AbrirFormularios(Form subform) 
        {

            //    formularios = new FormCifrado()
            //    {
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            subform.TopLevel = false;
            panel5.Controls.Add(subform);
            subform.Dock = DockStyle.Fill;
            subform.Show();
            subform.BringToFront();
            //    panel5.Tag = formularios;
            //    formularios.Show();
            //    formularios.BringToFront();
            //}
            //else
            //{
            //    formularios.BringToFront();
            //}
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    AbrirFormularios<FormFirma>();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    AbrirFormularios<FormVerificacion>();
        //}
    }
}
