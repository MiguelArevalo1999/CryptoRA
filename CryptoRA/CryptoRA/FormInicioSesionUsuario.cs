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
    public partial class FormInicioSesionUsuario : Form
    {
        public FormInicioSesionUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicio();
            formulario1.Show();
            this.Hide();
        }
    }
}
