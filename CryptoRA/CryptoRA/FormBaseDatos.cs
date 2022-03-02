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
               
            }
            catch
            {
               
            }
        }

        void PopulateDataGrid(Dictionary<string, Usuario> record)
        {
            //dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();

            //dataGridView1.Columns.Add("NombreUsuario", "Nombre de usuario");
            //dataGridView1.Columns.Add("nombre", "Nombre");
            //dataGridView1.Columns.Add("apellidos", "Apellidos");
            //dataGridView1.Columns.Add("correo", "Correo");
            //dataGridView1.Columns.Add("isAdmin", "Admin");

            //foreach (var item in record)
            //{
            //    dataGridView1.Rows.Add(item.Key, item.Value.Nombre, item.Value.Apellidos, item.Value.Correo,item.Value.isAdmin);
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
