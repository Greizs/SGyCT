Imports System.Data.SqlClient ' Necesario para trabajar con SQL Server
Imports System.Configuration ' Necesario para ConfigurationManager (aunque usado indirectamente por ConexionBD)
Imports MetroFramework.Forms.MetroForm ' Si usas MetroFramework

Imports SCyGT_2025II_Ibarra_Perez.SCyGT_2025II_Ibarra_Perez ' Aseg�rate de que la clase ConexionBD est� en el mismo namespace o ajusta la ruta
' Si tu clase ConexionBD est� en un namespace diferente al de LoginForm1,
' deber�as importarlo aqu�. Por ejemplo:
' Imports TuProyecto.ConexionBD ' Si tu proyecto se llama TuProyecto

Partial Public Class LoginForm1
    Inherits MetroFramework.Forms.MetroForm ' Si usas MetroFramework, de lo contrario, deja Inherits System.Windows.Forms.Form

    ' No necesitas una variable de conexi�n global aqu�, ya que ConexionBD.ObtenerConexion()
    ' crear� y cerrar� la conexi�n de forma segura en cada uso.

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUser.Text.Trim()
        Dim contrasena As String = txtPass.Text ' Obtenemos la contrase�a del TextBox

        ' --- 1. Validaciones b�sicas: Campos vac�os ---
        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contrasena) Then
            MessageBox.Show("Por favor, ingrese su usuario y contrase�a.", "Campos Vac�os", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 2. Autenticaci�n contra la base de datos ---
        Try
            ' Utilizamos la clase ConexionBD para obtener una conexi�n segura.
            ' El bloque Using se asegura de que la conexi�n se cierre y libere autom�ticamente.
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open() ' Abre la conexi�n a la base de datos

                ' Preparamos la consulta SQL para verificar el usuario y la contrase�a.
                ' Utilizamos COUNT(*) para saber si existe una fila con esas credenciales.
                Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena"

                Using comando As New SqlCommand(query, conexion)
                    ' A�adimos par�metros para evitar la inyecci�n SQL (�MUY IMPORTANTE!)
                    comando.Parameters.AddWithValue("@Usuario", usuario)
                    ' ADVERTENCIA: Esta l�nea asume que tu columna 'Contrasena' en la BD
                    ' almacena las contrase�as en texto plano.
                    ' Si ya has implementado el HASHING de contrase�as en el registro,
                    ' esta l�gica de verificaci�n debe cambiar.
                    ' Deber�as consultar el hash almacenado en la BD y luego comparar
                    ' con el hash de la contrase�a ingresada por el usuario.
                    comando.Parameters.AddWithValue("@Contrasena", contrasena)

                    ' Ejecutamos la consulta. ExecuteScalar() devuelve el primer valor
                    ' de la primera fila del resultado (en este caso, el COUNT).
                    Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar())

                    If resultado > 0 Then
                        ' Si resultado es mayor que 0, significa que se encontr� un usuario
                        ' con esas credenciales.
                        MessageBox.Show("�Inicio de sesi�n exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide() ' Oculta el formulario de login actual
                        Form1.Show() ' Muestra el formulario principal (Form1) de tu aplicaci�n
                    Else
                        ' Si no se encontr� ninguna fila, las credenciales son incorrectas.
                        MessageBox.Show("Usuario o contrase�a incorrectos.", "Error de Inicio de Sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtPass.Clear() ' Limpia la caja de texto de la contrase�a
                        txtUser.Focus() ' Devuelve el foco al campo de usuario para facilitar un nuevo intento
                    End If
                End Using ' El comando se libera autom�ticamente aqu�
            End Using ' La conexi�n se cierra autom�ticamente aqu�
        Catch ex As SqlException
            ' Captura errores espec�ficos de SQL (ej. la base de datos no est� disponible)
            MessageBox.Show("Error de base de datos al intentar iniciar sesi�n: " & ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Captura cualquier otro tipo de error inesperado
            MessageBox.Show("Ocurri� un error inesperado durante el inicio de sesi�n: " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim respuesta As DialogResult = MessageBox.Show("�Est�s seguro de querer salir del programa?",
                                                    "Confirmar salida",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)


        Application.Exit()
    End Sub
End Class