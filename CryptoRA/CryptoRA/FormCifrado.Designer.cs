
namespace CryptoRA
{
    partial class FormCifrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCifrado));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.abrirCifradoDir = new System.Windows.Forms.PictureBox();
            this.cifrarButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abrirCifradoDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.abrirCifradoDir);
            this.panel5.Controls.Add(this.cifrarButton);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(985, 550);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Abrir carpeta de cifrado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // abrirCifradoDir
            // 
            this.abrirCifradoDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.abrirCifradoDir.ErrorImage = ((System.Drawing.Image)(resources.GetObject("abrirCifradoDir.ErrorImage")));
            this.abrirCifradoDir.Image = ((System.Drawing.Image)(resources.GetObject("abrirCifradoDir.Image")));
            this.abrirCifradoDir.InitialImage = ((System.Drawing.Image)(resources.GetObject("abrirCifradoDir.InitialImage")));
            this.abrirCifradoDir.Location = new System.Drawing.Point(873, 435);
            this.abrirCifradoDir.Name = "abrirCifradoDir";
            this.abrirCifradoDir.Size = new System.Drawing.Size(50, 50);
            this.abrirCifradoDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.abrirCifradoDir.TabIndex = 14;
            this.abrirCifradoDir.TabStop = false;
            this.abrirCifradoDir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cifrarButton
            // 
            this.cifrarButton.Location = new System.Drawing.Point(395, 288);
            this.cifrarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cifrarButton.Name = "cifrarButton";
            this.cifrarButton.Size = new System.Drawing.Size(196, 52);
            this.cifrarButton.TabIndex = 13;
            this.cifrarButton.Text = "CIFRAR ARCHIVO";
            this.cifrarButton.UseVisualStyleBackColor = true;
            this.cifrarButton.Click += new System.EventHandler(this.CifrarButton_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(688, 217);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "SELECCIONAR LLAVE PÚBLICA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CryptoRA.Properties.Resources.pubkey;
            this.pictureBox3.Location = new System.Drawing.Point(612, 48);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CryptoRA.Properties.Resources.file;
            this.pictureBox4.Location = new System.Drawing.Point(51, 48);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(320, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(115, 217);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "SELECCIONAR ARCHIVO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormCifrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(985, 550);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCifrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoRA";
            this.Load += new System.EventHandler(this.FormCifrado_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abrirCifradoDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cifrarButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox abrirCifradoDir;
        private System.Windows.Forms.Label label1;
    }
}