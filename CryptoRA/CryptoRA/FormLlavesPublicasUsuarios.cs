using CryptoRA.DA_Layer;
using System;
using System.Windows.Forms;

namespace CryptoRA
{
    public partial class FormLlavesPublicasUsuarios : Form
    {
        public FormLlavesPublicasUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLlavesPublicasUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                llavesPublicasDataGridView.DataSource = UsuariosDA.TablaLlavePublica();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llavesPublicasDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in llavesPublicasDataGridView.SelectedRows)
            {
                string nombreUsuario = row.Cells[0].Value.ToString();
                Usuario usuarioLlavePublica = UsuariosDA.RegresaUsuario(nombreUsuario);
                llavePublicaUsuario = usuarioLlavePublica;
                break;
            }
        }

        public Usuario llavePublicaUsuario { get; set; }

        private void CargarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormLlavesPublicasUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
