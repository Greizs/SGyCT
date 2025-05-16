Imports SCyGT_2025II_Ibarra_Perez.SCyGT_2025II_Ibarra_Perez
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                   "Confirmar salida",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)


        Application.Exit()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim nombre As String = txtNombre.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contrasena As String = txtContrasena.Text
        Dim confirmarContrasena As String = txtConfirmarContrasena.Text

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(email) OrElse
           String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contrasena) OrElse
           String.IsNullOrEmpty(confirmarContrasena) Then

            MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If contrasena <> confirmarContrasena Then
            MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Formato de correo inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "INSERT INTO Usuarios (Nombre, Email, Usuario, Contrasena) VALUES (@Nombre, @Email, @Usuario, @Contrasena)"
                Using comando As New SqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@Nombre", nombre)
                    comando.Parameters.AddWithValue("@Email", email)
                    comando.Parameters.AddWithValue("@Usuario", usuario)
                    comando.Parameters.AddWithValue("@Contrasena", contrasena)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarCampos()
                    Me.Hide()
                    Form1.Show() ' Muestra el formulario principal (Form1) de tu aplicación
                End Using
            End Using
        Catch ex As SqlException
            If ex.Number = 2627 Then
                MessageBox.Show("Correo o usuario duplicado.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Error de base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtEmail.Clear()
        txtUsuario.Clear()
        txtContrasena.Clear()
        txtConfirmarContrasena.Clear()
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Me.Hide()
        Dim loginform As New LoginForm1
        LoginForm1.Show()
    End Sub
End Class