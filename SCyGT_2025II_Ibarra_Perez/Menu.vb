Public Class Menu
    Public NombreCompleto As String
    Public NombreUsuario As String

    Private Sub Form2a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenido.Text = "¡Bienvenido, " & SesionActual.Nombre & "!"

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Hide()
        Dim form1 As New PuntoVenta()
        form1.Show()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Hide()
        Dim formInventario As New FormInventario()
        formInventario.Show()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                        "Confirmar salida",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.Hide()
        Dim loginForm As New LoginForm1()
        LoginForm1.Show()
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Me.Hide()
        Dim formUsuarios As New Usuarios()
        formUsuarios.Show()
    End Sub
End Class
