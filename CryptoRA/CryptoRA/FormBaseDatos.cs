using CryptoRA.Helper;
using CryptoRA.DA_Layer;
using System;
using System.Collections.Generic;
using System.Numerics;
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
        Usuario aUser;
        string nombreUsuario;
        string correo;
        string nombre;
        string apellidos;
        string esAdmin;
       
        public FormBaseDatos(Usuario usuario)
        {
            aUser = usuario;
            DBHelper.EstablishConnection();
            InitializeComponent();

        }

      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicioAdmin(aUser);
            formulario1.Show();
            this.Hide();
        }

        private void FormBaseDatos_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDB.DataSource = UsuariosDA.RegresaTabla();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message); 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDB.SelectedRows)
            {
                nombreUsuario = row.Cells[0].Value.ToString();
                correo = row.Cells[1].Value.ToString();
                nombre = row.Cells[2].Value.ToString();
                apellidos = row.Cells[3].Value.ToString();
                esAdmin = row.Cells[4].Value.ToString();
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form modificarUsuario = new FormModificarUsuario(aUser,nombreUsuario, correo, nombre, apellidos, esAdmin);
            modificarUsuario.Show();
            this.Hide();
        }
    }
}
