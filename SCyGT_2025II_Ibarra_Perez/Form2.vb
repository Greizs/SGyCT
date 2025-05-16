Imports System.Data.SqlClient
Imports System.Net.Mail

Namespace SCyGT_2025II_Ibarra_Perez

    Partial Public Class Form2
        Inherits MetroFramework.Forms.MetroForm

        Private Sub Form2_Load(sender As Object, e As EventArgs)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Size = New Size(500, 600)
        End Sub

        Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
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

        Private Sub InitializeComponent()
            Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
            Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
            Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
            Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
            Me.txtContrasena = New MetroFramework.Controls.MetroTextBox()
            Me.txtConfirmarContrasena = New MetroFramework.Controls.MetroTextBox()
            Me.btnRegistrar = New MetroFramework.Controls.MetroButton()
            Me.SuspendLayout()
            '
            'MetroLabel1
            '
            Me.MetroLabel1.AutoSize = True
            Me.MetroLabel1.Location = New System.Drawing.Point(102, 73)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(81, 19)
            Me.MetroLabel1.TabIndex = 0
            Me.MetroLabel1.Text = "MetroLabel1"
            '
            'MetroLabel2
            '
            Me.MetroLabel2.AutoSize = True
            Me.MetroLabel2.Location = New System.Drawing.Point(83, 125)
            Me.MetroLabel2.Name = "MetroLabel2"
            Me.MetroLabel2.Size = New System.Drawing.Size(83, 19)
            Me.MetroLabel2.TabIndex = 1
            Me.MetroLabel2.Text = "MetroLabel2"
            '
            'MetroLabel3
            '
            Me.MetroLabel3.AutoSize = True
            Me.MetroLabel3.Location = New System.Drawing.Point(118, 176)
            Me.MetroLabel3.Name = "MetroLabel3"
            Me.MetroLabel3.Size = New System.Drawing.Size(83, 19)
            Me.MetroLabel3.TabIndex = 2
            Me.MetroLabel3.Text = "MetroLabel3"
            '
            'MetroLabel4
            '
            Me.MetroLabel4.AutoSize = True
            Me.MetroLabel4.Location = New System.Drawing.Point(95, 229)
            Me.MetroLabel4.Name = "MetroLabel4"
            Me.MetroLabel4.Size = New System.Drawing.Size(83, 19)
            Me.MetroLabel4.TabIndex = 3
            Me.MetroLabel4.Text = "MetroLabel4"
            '
            'MetroLabel5
            '
            Me.MetroLabel5.AutoSize = True
            Me.MetroLabel5.Location = New System.Drawing.Point(103, 293)
            Me.MetroLabel5.Name = "MetroLabel5"
            Me.MetroLabel5.Size = New System.Drawing.Size(83, 19)
            Me.MetroLabel5.TabIndex = 4
            Me.MetroLabel5.Text = "MetroLabel5"
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(279, 97)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(75, 23)
            Me.txtNombre.TabIndex = 5
            Me.txtNombre.Text = "MetroTextBox1"
            '
            'txtUsuario
            '
            Me.txtUsuario.Location = New System.Drawing.Point(312, 174)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.Size = New System.Drawing.Size(103, 23)
            Me.txtUsuario.TabIndex = 7
            Me.txtUsuario.Text = "MetroTextBox3"
            '
            'txtEmail
            '
            Me.txtEmail.Location = New System.Drawing.Point(303, 135)
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(112, 23)
            Me.txtEmail.TabIndex = 8
            Me.txtEmail.Text = "MetroTextBox2"
            '
            'txtContrasena
            '
            Me.txtContrasena.Location = New System.Drawing.Point(327, 231)
            Me.txtContrasena.Name = "txtContrasena"
            Me.txtContrasena.Size = New System.Drawing.Size(75, 23)
            Me.txtContrasena.TabIndex = 9
            Me.txtContrasena.Text = "MetroTextBox4"
            '
            'txtConfirmarContrasena
            '
            Me.txtConfirmarContrasena.Location = New System.Drawing.Point(326, 294)
            Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
            Me.txtConfirmarContrasena.Size = New System.Drawing.Size(75, 23)
            Me.txtConfirmarContrasena.TabIndex = 10
            Me.txtConfirmarContrasena.Text = "MetroTextBox5"
            '
            'btnRegistrar
            '
            Me.btnRegistrar.Location = New System.Drawing.Point(212, 352)
            Me.btnRegistrar.Name = "btnRegistrar"
            Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
            Me.btnRegistrar.TabIndex = 11
            Me.btnRegistrar.Text = "Registrar"
            '
            'Form2
            '
            Me.ClientSize = New System.Drawing.Size(536, 480)
            Me.Controls.Add(Me.btnRegistrar)
            Me.Controls.Add(Me.txtConfirmarContrasena)
            Me.Controls.Add(Me.txtContrasena)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(Me.MetroLabel5)
            Me.Controls.Add(Me.MetroLabel4)
            Me.Controls.Add(Me.MetroLabel3)
            Me.Controls.Add(Me.MetroLabel2)
            Me.Controls.Add(Me.MetroLabel1)
            Me.Name = "Form2"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
        Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtContrasena As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtConfirmarContrasena As MetroFramework.Controls.MetroTextBox
        Friend WithEvents btnRegistrar As MetroFramework.Controls.MetroButton
    End Class
End Namespace
