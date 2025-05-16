Public Class Form2
    ' Declara una variable pública para almacenar el nombre de usuario
    Public NombreUsuario As String
    Public NombreCompleto As String

    Private Sub Form2a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establece el texto del Label con el mensaje de bienvenida
        lblBienvenido.Text = "¡Bienvenido, " & SesionActual.Nombre & "!"
    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                  "Confirmar salida",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question)


        Application.Exit()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Hide()
        Dim form1 As New Form1()
        form1.Show()
    End Sub
End Class
