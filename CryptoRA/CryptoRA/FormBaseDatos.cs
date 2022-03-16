using CryptoRA.Helper;
using CryptoRA.DA_Layer;
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
    public partial class FormBaseDatos : Form
    {
        public FormBaseDatos()
        {
            DBHelper.EstablishConnection();
            InitializeComponent();

        }

      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicioAdmin();
            formulario1.Show();
            this.Hide();
        }

        private void FormBaseDatos_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = UsuariosDA.RegresaTabla();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message); 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
