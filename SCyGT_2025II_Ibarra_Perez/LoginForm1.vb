Public Class LoginForm1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "admin" And txtPass.Text = "1234" Then
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
