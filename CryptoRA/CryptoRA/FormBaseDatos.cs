using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace CryptoRA
{
    public partial class FormBaseDatos : Form
    {
        public FormBaseDatos()
        {
            InitializeComponent();

        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ZkLlTzxNuSCCHTaaP4orjzLhww0YSpYaNcrp5VK4",
            BasePath = "https://cryptora-5859e-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

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
                client = new FireSharp.FirebaseClient(fcon);
                FirebaseResponse res = client.Get(@"usuarios");
                Dictionary<string, Usuario> data = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(res.Body.ToString());
                PopulateDataGrid(data);
            }
            catch
            {
                MessageBox.Show("Ha habido un problema en el internet");
            }
        }

        void PopulateDataGrid(Dictionary<string, Usuario> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("NombreUsuario", "Nombre de usuario");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellidos", "Apellidos");
            dataGridView1.Columns.Add("correo", "Correo");
            dataGridView1.Columns.Add("edad", "Edad");
            dataGridView1.Columns.Add("sexo", "Sexo");
            dataGridView1.Columns.Add("pais", "País");
            dataGridView1.Columns.Add("ciudad", "Ciudad");
            dataGridView1.Columns.Add("municipio", "Municipio");

            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Key, item.Value.Nombre, item.Value.Apellidos, item.Value.Correo, item.Value.Edad, item.Value.Sexo, item.Value.Pais, item.Value.Ciudad, item.Value.Municipio);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
