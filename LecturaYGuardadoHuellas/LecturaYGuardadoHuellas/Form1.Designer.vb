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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.vecesDedo = New System.Windows.Forms.Label()
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagenHuella
        '
        Me.imagenHuella.Location = New System.Drawing.Point(33, 25)
        Me.imagenHuella.Name = "imagenHuella"
        Me.imagenHuella.Size = New System.Drawing.Size(266, 338)
        Me.imagenHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenHuella.TabIndex = 0
        Me.imagenHuella.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(224, 392)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'vecesDedo
        '
        Me.vecesDedo.AutoSize = True
        Me.vecesDedo.Location = New System.Drawing.Point(33, 370)
        Me.vecesDedo.Name = "vecesDedo"
        Me.vecesDedo.Size = New System.Drawing.Size(130, 15)
        Me.vecesDedo.TabIndex = 2
        Me.vecesDedo.Text = "Necesitas pasar el dedo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 450)
        Me.Controls.Add(Me.vecesDedo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.imagenHuella)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imagenHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imagenHuella As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents vecesDedo As Label
End Class
