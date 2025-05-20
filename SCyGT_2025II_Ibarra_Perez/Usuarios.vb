Imports SCyGT_2025II_Ibarra_Perez.SCyGT_2025II_Ibarra_Perez
Imports System.Data.SqlClient

Public Class Usuarios
    Dim conexion As SqlConnection = ConexionBD.ObtenerConexion()
    Dim idUsuarioSeleccionado As Integer = -1
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCajero.Text = "Cajero: " & SesionActual.Nombre & " | Rol: " & SesionActual.Rol

        cbRol.Items.Clear()
        cbRol.Items.Add("Admin")
        cbRol.Items.Add("Usuario")
        cbRol.SelectedIndex = 0

        ' Seguridad: Desactiva botones si no es admin
        If SesionActual.Rol <> "Admin" Then
            btnAgregar.Enabled = False
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
        Else
            btnAgregar.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        End If

        CargarUsuarios()
    End Sub

    Sub CargarUsuarios()
        Try
            Dim da As New SqlDataAdapter("sp_ObtenerUsuarios", conexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvUsuarios.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
            idUsuarioSeleccionado = Convert.ToInt32(row.Cells("Id").Value)
            txtNombre.Text = row.Cells("Nombre").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtUsuario.Text = row.Cells("Usuario").Value.ToString()
            cbRol.SelectedItem = row.Cells("Rol").Value.ToString()
        End If
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim menu As New Menu()
        menu.Show()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                       "Confirmar salida",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRol.SelectedIndexChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cmd As New SqlCommand("sp_AgregarUsuario", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text)
        cmd.Parameters.AddWithValue("@Rol", cbRol.SelectedItem.ToString())

        conexion.Open()
        cmd.ExecuteNonQuery()
        conexion.Close()

        MessageBox.Show("Usuario agregado correctamente.")
        CargarUsuarios()
        LimpiarCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If idUsuarioSeleccionado = -1 Then
            MessageBox.Show("Selecciona un usuario primero.")
            Return
        End If

        Dim cmd As New SqlCommand("sp_ActualizarUsuario", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id", idUsuarioSeleccionado)
        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text)
        cmd.Parameters.AddWithValue("@Rol", cbRol.SelectedItem.ToString())

        conexion.Open()
        cmd.ExecuteNonQuery()
        conexion.Close()

        MessageBox.Show("Usuario actualizado correctamente.")
        CargarUsuarios()
        LimpiarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idUsuarioSeleccionado = -1 Then
            MessageBox.Show("Selecciona un usuario primero.")
            Return
        End If

        Dim cmd As New SqlCommand("sp_EliminarUsuario", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id", idUsuarioSeleccionado)

        conexion.Open()
        cmd.ExecuteNonQuery()
        conexion.Close()

        MessageBox.Show("Usuario eliminado.")
        CargarUsuarios()
        LimpiarCampos()
    End Sub

    Sub LimpiarCampos()
        txtNombre.Clear()
        txtEmail.Clear()
        txtUsuario.Clear()
        txtContrasena.Clear()
        cbRol.SelectedIndex = 1
        idUsuarioSeleccionado = -1
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Hide()
        Dim menu As New Menu()
        menu.Show()
    End Sub
End Class