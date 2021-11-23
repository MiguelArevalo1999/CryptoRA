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
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicio();
            formulario1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormCifrado>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormDescifrado>();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularios<FormCifrado>() where FormCifrado:Form, new()
        {
            Form formularios;
            formularios = panel5.Controls.OfType<FormCifrado>().FirstOrDefault();
            if (formularios == null)
            {
                formularios = new FormCifrado
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                panel5.Controls.Add(formularios);
                panel5.Tag = formularios;
                formularios.Show();
                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormFirma>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormVerificacion>();
        }
    }
}
