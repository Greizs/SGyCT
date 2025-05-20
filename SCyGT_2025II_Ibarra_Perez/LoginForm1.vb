Imports System.Configuration
Imports System.Data.SqlClient
Imports MetroFramework.Forms.MetroForm
Imports SCyGT_2025II_Ibarra_Perez.SCyGT_2025II_Ibarra_Perez

Partial Public Class LoginForm1
    Inherits MetroFramework.Forms.MetroForm

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim contrasena As String = txtPass.Text
        Dim usuario As String = txtUser.Text.Trim()

        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contrasena) Then
            MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()

                Dim query As String = "SELECT Nombre, Rol FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena"

                Using comando As New SqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@Contrasena", contrasena)
                    comando.Parameters.AddWithValue("@Usuario", usuario)

                    Using lector As SqlDataReader = comando.ExecuteReader()
                        If lector.Read() Then
                            SesionActual.Nombre = lector("Nombre").ToString()
                            SesionActual.Usuario = usuario
                            SesionActual.Rol = lector("Rol").ToString()


                            MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Hide()
                            Dim menu As New Menu()
                            menu.Show()
                        Else
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPass.Clear()
                            txtUser.Focus()
                        End If
                    End Using
                End Using

            End Using
        Catch ex As SqlException
            MessageBox.Show("Error de base de datos al intentar iniciar sesión: " & ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado durante el inicio de sesión: " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                        "Confirmar salida",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.Clear()
        txtUser.Clear()
        txtUser.Focus()

    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Me.Hide()
        Dim registroForm As New FormRegistro()
        registroForm.Show()
    End Sub
End Class
