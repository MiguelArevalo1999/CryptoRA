﻿using System;
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
    public partial class FormInicioAdmin : Form
    {
        Usuario aUser;
        
        public FormInicioAdmin(Usuario usuario)
        {
            aUser = usuario;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormInicio();
            formulario1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormNuevoUsuario(aUser);
            formulario1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormBaseDatos(aUser);
            formulario1.Show();
            this.Hide();
        }
    }
}
