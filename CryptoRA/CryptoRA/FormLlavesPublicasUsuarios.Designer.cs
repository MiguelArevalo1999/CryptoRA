namespace CryptoRA
{
    partial class FormLlavesPublicasUsuarios
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
            this.llavesPublicasDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CargarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.llavesPublicasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // llavesPublicasDataGridView
            // 
            this.llavesPublicasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.llavesPublicasDataGridView.Location = new System.Drawing.Point(13, 73);
            this.llavesPublicasDataGridView.Name = "llavesPublicasDataGridView";
            this.llavesPublicasDataGridView.RowHeadersWidth = 51;
            this.llavesPublicasDataGridView.RowTemplate.Height = 24;
            this.llavesPublicasDataGridView.Size = new System.Drawing.Size(308, 396);
            this.llavesPublicasDataGridView.TabIndex = 0;
            this.llavesPublicasDataGridView.SelectionChanged += new System.EventHandler(this.llavesPublicasDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el usuario a \r\ncargar su llave pública";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CargarButton
            // 
            this.CargarButton.Location = new System.Drawing.Point(95, 489);
            this.CargarButton.Name = "CargarButton";
            this.CargarButton.Size = new System.Drawing.Size(143, 34);
            this.CargarButton.TabIndex = 2;
            this.CargarButton.Text = "Cargar llave pública";
            this.CargarButton.UseVisualStyleBackColor = true;
            this.CargarButton.Click += new System.EventHandler(this.CargarButton_Click);
            // 
            // FormLlavesPublicasUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(348, 548);
            this.Controls.Add(this.CargarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llavesPublicasDataGridView);
            this.Name = "FormLlavesPublicasUsuarios";
            this.Text = "LlavesPublicasUsuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLlavesPublicasUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.FormLlavesPublicasUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.llavesPublicasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView llavesPublicasDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CargarButton;
    }
}