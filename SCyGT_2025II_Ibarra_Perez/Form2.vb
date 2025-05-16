' FormRegistroUsuario.vb
Imports System.Data.SqlClient ' Necesario para trabajar con SQL Server
Imports System.Net.Mail     ' Necesario para validar el formato del email
Imports MetroFramework.Components
Imports MetroFramework.Forms.MetroForm ' Si usas MetroFramework, de lo contrario, quita esta línea y 'Inherits MetroForm'

Namespace TuProyecto ' Asegúrate de que este Namespace sea el mismo que el de tu Form1.vb

    Partial Public Class Form2
        Inherits MetroFramework.Forms.MetroForm ' Cambia a 'Inherits System.Windows.Forms.Form' si no usas MetroFramework



        Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
            Dim nombre As String = txtNombre.Text.Trim()
            Dim email As String = txtEmail.Text.Trim()
            Dim usuario As String = txtUsuario.Text.Trim()
            Dim contrasena As String = txtContrasena.Text ' Contraseña sin hash
            Dim confirmarContrasena As String = txtConfirmarContrasena.Text

            ' --- 1. Validaciones de entrada ---
            If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(email) OrElse
               String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contrasena) OrElse
               String.IsNullOrEmpty(confirmarContrasena) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If contrasena <> confirmarContrasena Then
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not IsValidEmail(email) Then
                MessageBox.Show("Por favor, ingrese un formato de email válido.", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Aquí podrías añadir más validaciones, como la complejidad de la contraseña (mínimo de caracteres, mayúsculas, números, etc.)

            ' --- 2. Hashing de la contraseña (¡RECOMENDADO PARA SEGURIDAD!) ---
            ' Para hashing robusto en VB.NET, también puedes usar BCrypt.Net.
            ' Primero, instala el paquete NuGet "BCrypt.Net-Next" en tu proyecto.
            ' Luego, descomenta las siguientes líneas y añade 'Imports BCrypt.Net.BCrypt'
            ' Dim contrasenaHash As String = BCrypt.Net.BCrypt.HashPassword(contrasena)
            ' Reemplaza 'contrasena' por 'contrasenaHash' en el comando SQL

            ' --- 3. Intento de registro en la base de datos ---
            Try
                ' Abre la conexión usando tu clase auxiliar ConexionBD
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    conexion.Open()

                    ' Query SQL para insertar un nuevo usuario
                    Dim query As String = "INSERT INTO Usuarios (Nombre, Email, Usuario, Contrasena) VALUES (@Nombre, @Email, @Usuario, @Contrasena)"

                    Using comando As New SqlCommand(query, conexion)
                        ' Añade los parámetros para evitar la inyección SQL y manejar los valores correctamente
                        comando.Parameters.AddWithValue("@Nombre", nombre)
                        comando.Parameters.AddWithValue("@Email", email)
                        comando.Parameters.AddWithValue("@Usuario", usuario)
                        comando.Parameters.AddWithValue("@Contrasena", contrasena) ' Si no usas hash, usa 'contrasena'. Si usas hash, usa 'contrasenaHash'.

                        comando.ExecuteNonQuery() ' Ejecuta la consulta (INSERT)

                        MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Limpiar los campos después de un registro exitoso
                        LimpiarCampos()
                    End Using
                End Using ' La conexión se cierra automáticamente aquí gracias al 'Using'

            Catch ex As SqlException
                ' Manejo de errores específicos de SQL Server
                If ex.Number = 2627 Then ' Error de violación de clave única (UNIQUE CONSTRAINT)
                    If ex.Message.Contains("Email") Then
                        MessageBox.Show("El email ingresado ya está registrado. Por favor, use otro.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf ex.Message.Contains("Usuario") Then
                        MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Error al registrar el usuario debido a un valor duplicado: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Error de base de datos al registrar el usuario: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                ' Manejo de cualquier otro error inesperado
                MessageBox.Show("Ocurrió un error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Valida el formato de una dirección de correo electrónico.
        ''' </summary>
        ''' <param name="email">La cadena de texto a validar.</param>
        ''' <returns>True si el email tiene un formato válido, False en caso contrario.</returns>
        Private Function IsValidEmail(email As String) As Boolean
            Try
                Dim addr As New MailAddress(email)
                Return addr.Address = email
            Catch
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Limpia todos los campos del formulario.
        ''' </summary>
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
            Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
            Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
            Me.txtContrasena = New MetroFramework.Controls.MetroTextBox()
            Me.txtConfirmarContrasena = New MetroFramework.Controls.MetroTextBox()
            Me.btnRegistrar = New MetroFramework.Controls.MetroButton()
            Me.SuspendLayout()
            '
            'MetroLabel1
            '
            Me.MetroLabel1.AutoSize = True
            Me.MetroLabel1.Location = New System.Drawing.Point(119, 89)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(59, 19)
            Me.MetroLabel1.TabIndex = 0
            Me.MetroLabel1.Text = "Nombre"
            '
            'MetroLabel2
            '
            Me.MetroLabel2.AutoSize = True
            Me.MetroLabel2.Location = New System.Drawing.Point(133, 149)
            Me.MetroLabel2.Name = "MetroLabel2"
            Me.MetroLabel2.Size = New System.Drawing.Size(51, 19)
            Me.MetroLabel2.TabIndex = 1
            Me.MetroLabel2.Text = "Correo"
            '
            'MetroLabel3
            '
            Me.MetroLabel3.AutoSize = True
            Me.MetroLabel3.Location = New System.Drawing.Point(160, 211)
            Me.MetroLabel3.Name = "MetroLabel3"
            Me.MetroLabel3.Size = New System.Drawing.Size(53, 19)
            Me.MetroLabel3.TabIndex = 2
            Me.MetroLabel3.Text = "Usuario"
            '
            'MetroLabel4
            '
            Me.MetroLabel4.AutoSize = True
            Me.MetroLabel4.Location = New System.Drawing.Point(135, 282)
            Me.MetroLabel4.Name = "MetroLabel4"
            Me.MetroLabel4.Size = New System.Drawing.Size(75, 19)
            Me.MetroLabel4.TabIndex = 3
            Me.MetroLabel4.Text = "Contrasena"
            '
            'MetroLabel5
            '
            Me.MetroLabel5.AutoSize = True
            Me.MetroLabel5.Location = New System.Drawing.Point(119, 335)
            Me.MetroLabel5.Name = "MetroLabel5"
            Me.MetroLabel5.Size = New System.Drawing.Size(136, 19)
            Me.MetroLabel5.TabIndex = 4
            Me.MetroLabel5.Text = "Confirmar contrasena"
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(278, 89)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(75, 23)
            Me.txtNombre.TabIndex = 5
            Me.txtNombre.Text = "MetroTextBox1"
            '
            'txtEmail
            '
            Me.txtEmail.Location = New System.Drawing.Point(309, 159)
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(75, 23)
            Me.txtEmail.TabIndex = 6
            Me.txtEmail.Text = "MetroTextBox2"
            '
            'txtUsuario
            '
            Me.txtUsuario.Location = New System.Drawing.Point(321, 223)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.Size = New System.Drawing.Size(75, 23)
            Me.txtUsuario.TabIndex = 7
            Me.txtUsuario.Text = "MetroTextBox3"
            '
            'txtContrasena
            '
            Me.txtContrasena.Location = New System.Drawing.Point(321, 282)
            Me.txtContrasena.Name = "txtContrasena"
            Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
            Me.txtContrasena.Size = New System.Drawing.Size(75, 23)
            Me.txtContrasena.TabIndex = 8
            Me.txtContrasena.Text = "MetroTextBox4"
            Me.txtContrasena.UseSystemPasswordChar = True
            '
            'txtConfirmarContrasena
            '
            Me.txtConfirmarContrasena.Location = New System.Drawing.Point(311, 331)
            Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
            Me.txtConfirmarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
            Me.txtConfirmarContrasena.Size = New System.Drawing.Size(75, 23)
            Me.txtConfirmarContrasena.TabIndex = 9
            Me.txtConfirmarContrasena.Text = "MetroTextBox5"
            Me.txtConfirmarContrasena.UseSystemPasswordChar = True
            '
            'btnRegistrar
            '
            Me.btnRegistrar.Location = New System.Drawing.Point(223, 408)
            Me.btnRegistrar.Name = "btnRegistrar"
            Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
            Me.btnRegistrar.TabIndex = 10
            Me.btnRegistrar.Text = "Registrar"
            '
            'Form2
            '
            Me.ClientSize = New System.Drawing.Size(641, 516)
            Me.Controls.Add(Me.btnRegistrar)
            Me.Controls.Add(Me.txtConfirmarContrasena)
            Me.Controls.Add(Me.txtContrasena)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.txtEmail)
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
        Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtContrasena As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtConfirmarContrasena As MetroFramework.Controls.MetroTextBox
        Friend WithEvents btnRegistrar As MetroFramework.Controls.MetroButton

        Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class

End Namespace