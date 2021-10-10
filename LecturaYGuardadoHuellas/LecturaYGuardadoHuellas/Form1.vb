Imports System.Text
Imports DPFP
Imports DPFP.Capture

Public Class Form1
    Implements DPFP.Capture.EventHandler

    Private captura As DPFP.Capture.Capture
    Private enroller As DPFP.Processing.Enrollment
    Private Delegate Sub _delegadoMuestra(ByVal text As String)
    Private Delegate Sub _delegadoControl()
    Private template As DPFP.Template

    Private Sub mostrarVeces(ByVal texto As String)
        If vecesDedo.InvokeRequired Then
            Dim deleg As New _delegadoMuestra(AddressOf mostrarVeces)
            Me.Invoke(deleg, New Object() {texto})
        Else
            vecesDedo.Text = texto
        End If
    End Sub

    Private Sub modificarControles()
        If (btnGuardar.InvokeRequired) Then
            Dim deleg As New _delegadoControl(AddressOf modificarControles)
            Me.Invoke(deleg, New Object() {})
        Else
            btnGuardar.Enabled = True
        End If
    End Sub
    Protected Overridable Sub Init()
        Try
            captura = New Capture()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                enroller = New DPFP.Processing.Enrollment()
                Dim Text As New StringBuilder()
                Text.AppendFormat("Necesitas pasar el dedo {0} veces", enroller.FeaturesNeeded)
                vecesDedo.Text = Text.ToString()
            Else
                MessageBox.Show("No se pudo instanciar la captura")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo inicializar la captura")
        End Try
    End Sub

    Protected Sub IniciarCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StartCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la captura")
            End Try
        End If

    End Sub

    Protected Sub PararCaptura()
        If Not captura Is Nothing Then
            Try
                captura.StopCapture()
            Catch ex As Exception
                MessageBox.Show("No se pudo detener la captura")
            End Try
        End If
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        ponerImagen(ConvertirSampleAMapaDeBits(Sample))
        Procesar(Sample)
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        'MessageBox.Show("Se ha tocado el aparato")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        IniciarCaptura()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PararCaptura()
    End Sub

    Protected Function ConvertirSampleAMapaDeBits(ByVal sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion() 'variable tipo conversor de DPFP.Sample
        Dim mapaBits As Bitmap = Nothing
        convertidor.ConvertToPicture(sample, mapaBits)
        Return mapaBits
    End Function

    Private Sub ponerImagen(ByVal bmp)
        imagenHuella.Image = bmp
    End Sub

    Protected Function extrarCaracteristicas(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim alimentacion As New DPFP.Capture.CaptureFeedback
        alimentacion = DPFP.Capture.CaptureFeedback.None
        Dim caracteristicas As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, alimentacion, caracteristicas)
        If (alimentacion = DPFP.Capture.CaptureFeedback.Good) Then
            Return caracteristicas
        Else
            Return Nothing
        End If
    End Function

    Protected Sub Procesar(ByVal Sample As DPFP.Sample)
        Dim caracteristicas As DPFP.FeatureSet = extrarCaracteristicas(Sample, DPFP.Processing.DataPurpose.Enrollment)
        If (Not caracteristicas Is Nothing) Then
            Try
                enroller.AddFeatures(caracteristicas)
            Finally
                Dim Text As New StringBuilder()
                Text.AppendFormat("Necesitas pasar el dedo {0} veces", enroller.FeaturesNeeded)
                mostrarVeces(Text.ToString())
                Select Case enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready
                        template = enroller.Template
                        PararCaptura()
                        modificarControles()
                    Case DPFP.Processing.Enrollment.Status.Failed
                        enroller.Clear()
                        PararCaptura()
                        IniciarCaptura()
                End Select
            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim imagen As Bitmap
        Dim guardar As SaveFileDialog = New SaveFileDialog()
        guardar.Filter = "Bitmap|*.bmp|PNG|*.png"
        If guardar.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            imagen = imagenHuella.Image
            imagen.Save(guardar.FileName)
        End If
    End Sub
End Class
