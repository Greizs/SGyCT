Imports System.Data.SqlClient
Imports SCyGT_2025II_Ibarra_Perez.SCyGT_2025II_Ibarra_Perez

Public Class FormInventario
    Dim conexion As SqlConnection = ConexionBD.ObtenerConexion()
    Dim idProducto As Integer = -1

    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCajero.Text = "Administrador: " & SesionActual.Nombre

        If SesionActual.Rol <> "Admin" Then
            btnAgregar.Enabled = False
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
        End If

        CargarProductos()
    End Sub

    Sub CargarProductos()
        Try
            Dim da As New SqlDataAdapter("sp_ObtenerProductosInventario", conexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvProductos.DataSource = Nothing
            dgvProductos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

    Sub LimpiarCampos()
        txtNombre.Clear()
        txtCategoria.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
        idProducto = -1
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
            idProducto = Convert.ToInt32(fila.Cells("Id").Value)
            txtNombre.Text = fila.Cells("Nombre").Value.ToString()
            txtCategoria.Text = fila.Cells("Categoria").Value.ToString()
            txtPrecio.Text = fila.Cells("Precio").Value.ToString()
            txtStock.Text = fila.Cells("Stock").Value.ToString()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("sp_AgregarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Categoria", txtCategoria.Text)
            cmd.Parameters.AddWithValue("@Precio", Decimal.Parse(txtPrecio.Text))
            cmd.Parameters.AddWithValue("@Stock", Integer.Parse(txtStock.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Producto agregado correctamente")
            CargarProductos()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al agregar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If idProducto = -1 Then
            MessageBox.Show("Selecciona un producto para editar")
            Return
        End If

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("sp_ActualizarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Id", idProducto)
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Categoria", txtCategoria.Text)
            cmd.Parameters.AddWithValue("@Precio", Decimal.Parse(txtPrecio.Text))
            cmd.Parameters.AddWithValue("@Stock", Integer.Parse(txtStock.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Producto actualizado correctamente")
            CargarProductos()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idProducto = -1 Then
            MessageBox.Show("Selecciona un producto para eliminar")
            Return
        End If

        Dim confirm = MessageBox.Show("¿Estás seguro que deseas eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo)
        If confirm = DialogResult.No Then Return

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("sp_EliminarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Id", idProducto)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Producto eliminado correctamente")
            CargarProductos()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
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
End Class
