
namespace CryptoRA
{
    partial class FormNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.ValidarBtn = new System.Windows.Forms.Button();
            this.InscribirBtn = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(26, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 513);
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(399, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 537);
            this.panel2.TabIndex = 3;
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
            this.panel5.Controls.Add(this.InscribirBtn);
            this.panel5.Controls.Add(this.buttonRegresar);
            this.panel5.Location = new System.Drawing.Point(3, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 384);
            this.panel5.TabIndex = 4;
            // 
            // isAdminCb
            // 
            this.isAdminCb.FormattingEnabled = true;
            this.isAdminCb.Items.AddRange(new object[] {
            "True",
            "False"});
            this.isAdminCb.Location = new System.Drawing.Point(131, 134);
            this.isAdminCb.Name = "isAdminCb";
            this.isAdminCb.Size = new System.Drawing.Size(121, 27);
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
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // apellidosTbox
            // 
            this.apellidosTbox.Location = new System.Drawing.Point(132, 100);
            this.apellidosTbox.Name = "apellidosTbox";
            this.apellidosTbox.Size = new System.Drawing.Size(401, 26);
            this.apellidosTbox.TabIndex = 21;
            // 
            // nombreTbox
            // 
            this.nombreTbox.Location = new System.Drawing.Point(132, 71);
            this.nombreTbox.Name = "nombreTbox";
            this.nombreTbox.Size = new System.Drawing.Size(401, 26);
            this.nombreTbox.TabIndex = 20;
            // 
            // correoTbox
            // 
            this.correoTbox.Location = new System.Drawing.Point(132, 41);
            this.correoTbox.Name = "correoTbox";
            this.correoTbox.Size = new System.Drawing.Size(401, 26);
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
            this.usuarioTbox.Size = new System.Drawing.Size(401, 26);
            this.usuarioTbox.TabIndex = 11;
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
            // InscribirBtn
            // 
            this.InscribirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InscribirBtn.Enabled = false;
            this.InscribirBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InscribirBtn.Location = new System.Drawing.Point(390, 270);
            this.InscribirBtn.Name = "InscribirBtn";
            this.InscribirBtn.Size = new System.Drawing.Size(143, 34);
            this.InscribirBtn.TabIndex = 9;
            this.InscribirBtn.Text = "INSCRIBIR";
            this.InscribirBtn.UseVisualStyleBackColor = true;
            this.InscribirBtn.Click += new System.EventHandler(this.InscribirBtn_Click);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 141);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CryptoRA.Properties.Resources.Titulo_CrytoRA;
            this.pictureBox2.Location = new System.Drawing.Point(33, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 75);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(104)))), ((int)(((byte)(230)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(33, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 42);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(191, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "NUEVO USUARIO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.FormNuevoUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
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
        private System.Windows.Forms.Button ValidarBtn;
        private System.Windows.Forms.Button InscribirBtn;
        private System.Windows.Forms.Button buttonRegresar;
    }
}