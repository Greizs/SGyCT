Imports System.Data.SqlClient ' Necesario para trabajar con SQL Server
Imports System.Configuration ' Necesario para ConfigurationManager (aunque usado indirectamente por ConexionBD)
Imports MetroFramework.Forms.MetroForm ' Si usas MetroFramework

Imports SCyGT_2025II_Ibarra_Perez.SCyGT_2025II_Ibarra_Perez ' Asegúrate de que la clase ConexionBD esté en el mismo namespace o ajusta la ruta
' Si tu clase ConexionBD está en un namespace diferente al de LoginForm1,
' deberías importarlo aquí. Por ejemplo:
' Imports TuProyecto.ConexionBD ' Si tu proyecto se llama TuProyecto

Partial Public Class LoginForm1
    Inherits MetroFramework.Forms.MetroForm ' Si usas MetroFramework, de lo contrario, deja Inherits System.Windows.Forms.Form

    ' No necesitas una variable de conexión global aquí, ya que ConexionBD.ObtenerConexion()
    ' creará y cerrará la conexión de forma segura en cada uso.

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUser.Text.Trim()
        Dim contrasena As String = txtPass.Text ' Obtenemos la contraseña del TextBox

        ' --- 1. Validaciones básicas: Campos vacíos ---
        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contrasena) Then
            MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 2. Autenticación contra la base de datos ---
        Try
            ' Utilizamos la clase ConexionBD para obtener una conexión segura.
            ' El bloque Using se asegura de que la conexión se cierre y libere automáticamente.
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open() ' Abre la conexión a la base de datos

                ' Preparamos la consulta SQL para verificar el usuario y la contraseña.
                ' Utilizamos COUNT(*) para saber si existe una fila con esas credenciales.
                Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena"

                Using comando As New SqlCommand(query, conexion)
                    ' Añadimos parámetros para evitar la inyección SQL (¡MUY IMPORTANTE!)
                    comando.Parameters.AddWithValue("@Usuario", usuario)
                    ' ADVERTENCIA: Esta línea asume que tu columna 'Contrasena' en la BD
                    ' almacena las contraseñas en texto plano.
                    ' Si ya has implementado el HASHING de contraseñas en el registro,
                    ' esta lógica de verificación debe cambiar.
                    ' Deberías consultar el hash almacenado en la BD y luego comparar
                    ' con el hash de la contraseña ingresada por el usuario.
                    comando.Parameters.AddWithValue("@Contrasena", contrasena)

                    ' Ejecutamos la consulta. ExecuteScalar() devuelve el primer valor
                    ' de la primera fila del resultado (en este caso, el COUNT).
                    Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar())

                    If resultado > 0 Then
                        ' Si resultado es mayor que 0, significa que se encontró un usuario
                        ' con esas credenciales.
                        MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide() ' Oculta el formulario de login actual
                        Form1.Show() ' Muestra el formulario principal (Form1) de tu aplicación
                    Else
                        ' Si no se encontró ninguna fila, las credenciales son incorrectas.
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtPass.Clear() ' Limpia la caja de texto de la contraseña
                        txtUser.Focus() ' Devuelve el foco al campo de usuario para facilitar un nuevo intento
                    End If
                End Using ' El comando se libera automáticamente aquí
            End Using ' La conexión se cierra automáticamente aquí
        Catch ex As SqlException
            ' Captura errores específicos de SQL (ej. la base de datos no está disponible)
            MessageBox.Show("Error de base de datos al intentar iniciar sesión: " & ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Captura cualquier otro tipo de error inesperado
            MessageBox.Show("Ocurrió un error inesperado durante el inicio de sesión: " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Me.Hide() ' Oculta el formulario de login actual
        Dim registroForm As New Form3()
        registroForm.Show() ' Activa el formulario de registro
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                    "Confirmar salida",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)


        Application.Exit()
    End Sub
End Class