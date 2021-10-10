<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.imagenHuella = New System.Windows.Forms.PictureBox()
        Me.vecesDedo = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagenHuella
        '
        Me.imagenHuella.Location = New System.Drawing.Point(25, 12)
        Me.imagenHuella.Name = "imagenHuella"
        Me.imagenHuella.Size = New System.Drawing.Size(287, 382)
        Me.imagenHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenHuella.TabIndex = 0
        Me.imagenHuella.TabStop = False
        '
        'vecesDedo
        '
        Me.vecesDedo.AutoSize = True
        Me.vecesDedo.Location = New System.Drawing.Point(25, 397)
        Me.vecesDedo.Name = "vecesDedo"
        Me.vecesDedo.Size = New System.Drawing.Size(130, 15)
        Me.vecesDedo.TabIndex = 1
        Me.vecesDedo.Text = "Necesitas pasar el dedo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(418, 98)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(377, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 418)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.vecesDedo)
        Me.Controls.Add(Me.imagenHuella)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imagenHuella As PictureBox
    Friend WithEvents vecesDedo As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
End Class
