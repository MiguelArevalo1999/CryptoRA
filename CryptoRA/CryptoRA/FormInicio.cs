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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicioSesionUsuario();
            formulario1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicioAdmin();
            formulario1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormNuevoUsuario();
            formulario1.Show();
            this.Hide();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
