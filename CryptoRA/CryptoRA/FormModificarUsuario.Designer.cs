namespace CryptoRA
{
    partial class FormModificarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isAdminCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.apellidosTbox = new System.Windows.Forms.TextBox();
            this.nombreTbox = new System.Windows.Forms.TextBox();
            this.correoTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ValidarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 513);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CryptoRA.Properties.Resources.pulgar4;
            this.pictureBox1.Location = new System.Drawing.Point(22, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // isAdminCb
            // 
            this.isAdminCb.FormattingEnabled = true;
            this.isAdminCb.Items.AddRange(new object[] {
            "True",
            "False"});
            this.isAdminCb.Location = new System.Drawing.Point(131, 134);
            this.isAdminCb.Name = "isAdminCb";
            this.isAdminCb.Size = new System.Drawing.Size(121, 24);
            this.isAdminCb.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(51, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 34;
            this.label12.Text = "ADMIN:";
            // 
            // apellidosTbox
            // 
            this.apellidosTbox.Location = new System.Drawing.Point(132, 100);
            this.apellidosTbox.Name = "apellidosTbox";
            this.apellidosTbox.Size = new System.Drawing.Size(401, 22);
            this.apellidosTbox.TabIndex = 21;
            // 
            // nombreTbox
            // 
            this.nombreTbox.Location = new System.Drawing.Point(132, 71);
            this.nombreTbox.Name = "nombreTbox";
            this.nombreTbox.Size = new System.Drawing.Size(401, 22);
            this.nombreTbox.TabIndex = 20;
            // 
            // correoTbox
            // 
            this.correoTbox.Location = new System.Drawing.Point(132, 41);
            this.correoTbox.Name = "correoTbox";
            this.correoTbox.Size = new System.Drawing.Size(401, 22);
            this.correoTbox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "APELLIDOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "NOMBRE(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "CORREO-e:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "USUARIO:";
            // 
            // usuarioTbox
            // 
            this.usuarioTbox.Location = new System.Drawing.Point(132, 12);
            this.usuarioTbox.Name = "usuarioTbox";
            this.usuarioTbox.Size = new System.Drawing.Size(401, 22);
            this.usuarioTbox.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(394, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 537);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.isAdminCb);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.apellidosTbox);
            this.panel5.Controls.Add(this.nombreTbox);
            this.panel5.Controls.Add(this.correoTbox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.usuarioTbox);
            this.panel5.Controls.Add(this.ValidarBtn);
            this.panel5.Controls.Add(this.ModificarBtn);
            this.panel5.Controls.Add(this.buttonRegresar);
            this.panel5.Location = new System.Drawing.Point(3, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 384);
            this.panel5.TabIndex = 4;
            // 
            // ValidarBtn
            // 
            this.ValidarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ValidarBtn.Location = new System.Drawing.Point(243, 202);
            this.ValidarBtn.Name = "ValidarBtn";
            this.ValidarBtn.Size = new System.Drawing.Size(143, 38);
            this.ValidarBtn.TabIndex = 10;
            this.ValidarBtn.Text = "VALIDAR HUELLA DACTILAR";
            this.ValidarBtn.UseVisualStyleBackColor = true;
            this.ValidarBtn.Click += new System.EventHandler(this.ValidarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarBtn.Enabled = false;
            this.ModificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ModificarBtn.Location = new System.Drawing.Point(390, 270);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(143, 34);
            this.ModificarBtn.TabIndex = 9;
            this.ModificarBtn.Text = "MODIFICAR";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegresar.Location = new System.Drawing.Point(24, 270);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(143, 34);
            this.buttonRegresar.TabIndex = 8;
            this.buttonRegresar.Text = "REGRESAR";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(567, 141);
            this.panel6.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CryptoRA.Properties.Resources.Titulo_CrytoRA;
            this.pictureBox3.Location = new System.Drawing.Point(33, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(500, 90);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(104)))), ((int)(((byte)(230)))));
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(33, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(500, 42);
            this.panel7.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(191, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "MODIFICAR USUARIO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarUsuario";
            this.Text = "FormModificarUsuario";
            this.Load += new System.EventHandler(this.FormModificarUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox isAdminCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox apellidosTbox;
        private System.Windows.Forms.TextBox nombreTbox;
        private System.Windows.Forms.TextBox correoTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioTbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ValidarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
    }
}