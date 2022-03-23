
using System;

namespace CryptoRA
{
    partial class FormDescifrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescifrado));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.extTxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descifrarButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.abrirCifradoDir = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrirCifradoDir)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            this.openFileDialog1.Title = "Seleccionar archivo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.abrirCifradoDir);
            this.panel5.Controls.Add(this.extTxBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.descifrarButton);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(985, 550);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // extTxBox
            // 
            this.extTxBox.Location = new System.Drawing.Point(151, 402);
            this.extTxBox.Name = "extTxBox";
            this.extTxBox.Size = new System.Drawing.Size(100, 26);
            this.extTxBox.TabIndex = 15;
            this.extTxBox.TextChanged += new System.EventHandler(this.extTxBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 57);
            this.label1.TabIndex = 14;
            this.label1.Text = "Escribe la extensión a intercambiar del archivo a descifrar:\r\ntxt, mp4, png, docx" +
    ", pdf.\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // descifrarButton
            // 
            this.descifrarButton.Location = new System.Drawing.Point(395, 288);
            this.descifrarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descifrarButton.Name = "descifrarButton";
            this.descifrarButton.Size = new System.Drawing.Size(196, 52);
            this.descifrarButton.TabIndex = 13;
            this.descifrarButton.Text = "DESCIFRAR ARCHIVO";
            this.descifrarButton.UseVisualStyleBackColor = true;
            this.descifrarButton.Click += new System.EventHandler(this.descifrarButton_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(688, 217);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "VALIDAR LLAVE PRIVADA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CryptoRA.Properties.Resources.fingerprint;
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
            this.button5.Location = new System.Drawing.Point(117, 217);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "SELECCIONAR ARCHIVO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Abrir carpeta de descifrado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // abrirCifradoDir
            // 
            this.abrirCifradoDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.abrirCifradoDir.ErrorImage = ((System.Drawing.Image)(resources.GetObject("abrirCifradoDir.ErrorImage")));
            this.abrirCifradoDir.Image = ((System.Drawing.Image)(resources.GetObject("abrirCifradoDir.Image")));
            this.abrirCifradoDir.InitialImage = ((System.Drawing.Image)(resources.GetObject("abrirCifradoDir.InitialImage")));
            this.abrirCifradoDir.Location = new System.Drawing.Point(873, 355);
            this.abrirCifradoDir.Name = "abrirCifradoDir";
            this.abrirCifradoDir.Size = new System.Drawing.Size(50, 50);
            this.abrirCifradoDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.abrirCifradoDir.TabIndex = 16;
            this.abrirCifradoDir.TabStop = false;
            this.abrirCifradoDir.Click += new System.EventHandler(this.abrirCifradoDir_Click);
            // 
            // FormDescifrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(985, 550);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDescifrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoRA";
            this.Load += new System.EventHandler(this.FormDescifrado_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrirCifradoDir)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button descifrarButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox extTxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox abrirCifradoDir;
    }
}