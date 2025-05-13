Imports System.Data.SqlClient
Imports System.Configuration

Public Class Form1

    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
        InicializarCarrito()
        CalcularTotal()
    End Sub

    Private Sub CargarProductos()
        Try
            Dim query As String = "SELECT Id, Nombre, Categoria, Precio FROM Productos WHERE Stock > 0"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            dgvProductos.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

    Private Sub InicializarCarrito()
        dgvCarrito.Columns.Clear()
        dgvCarrito.Columns.Add("Id", "Id")
        dgvCarrito.Columns.Add("Nombre", "Nombre")
        dgvCarrito.Columns.Add("Categoria", "Categoría")
        dgvCarrito.Columns.Add("Precio", "Precio")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            Dim fila As DataGridViewRow = dgvProductos.SelectedRows(0)
            dgvCarrito.Rows.Add(
                fila.Cells("Id").Value,
                fila.Cells("Nombre").Value,
                fila.Cells("Categoria").Value,
                fila.Cells("Precio").Value
            )
            CalcularTotal()
        Else
            MessageBox.Show("Selecciona un producto.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCarrito.SelectedRows.Count > 0 Then
            dgvCarrito.Rows.RemoveAt(dgvCarrito.SelectedRows(0).Index)
            CalcularTotal()
        Else
            MessageBox.Show("Selecciona un producto del carrito para eliminar.")
        End If
    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvCarrito.Rows
            If Not IsDBNull(row.Cells("Precio").Value) Then
                total += Convert.ToDecimal(row.Cells("Precio").Value)
            End If
        Next
        lblTotal.Text = "Total: $" & total.ToString("0.00")
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        If dgvCarrito.Rows.Count = 0 Then
            MessageBox.Show("El carrito está vacío.")
            Return
        End If

        Dim transaccion As SqlTransaction = Nothing
        Dim ticketId As Integer = 0

        Try
            conexion.Open()
            transaccion = conexion.BeginTransaction()

            ' Calcular total de la compra
            Dim totalCompra As Decimal = 0
            For Each row As DataGridViewRow In dgvCarrito.Rows
                totalCompra += Convert.ToDecimal(row.Cells("Precio").Value)
            Next

            ' Insertar ticket principal
            Dim cmdTicket As New SqlCommand(
                "INSERT INTO Tickets (Fecha, Total) VALUES (GETDATE(), @Total); 
                 SELECT SCOPE_IDENTITY();",
                conexion,
                transaccion
            )
            cmdTicket.Parameters.AddWithValue("@Total", totalCompra)
            ticketId = Convert.ToInt32(cmdTicket.ExecuteScalar())

            ' Procesar cada producto del carrito
            For Each row As DataGridViewRow In dgvCarrito.Rows
                Dim productoId As Integer = CInt(row.Cells("Id").Value)
                Dim precio As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)

                ' Validar existencia del producto
                Dim cmdVerificar As New SqlCommand(
                    "SELECT COUNT(*) FROM Productos WHERE Id = @id",
                    conexion,
                    transaccion
                )
                cmdVerificar.Parameters.AddWithValue("@id", productoId)
                Dim existe As Integer = Convert.ToInt32(cmdVerificar.ExecuteScalar())

                If existe = 0 Then
                    Throw New Exception($"El producto con ID {productoId} no existe.")
                End If

                ' Actualizar stock
                Dim cmdStock As New SqlCommand(
                    "UPDATE Productos SET Stock = Stock - 1 WHERE Id = @id",
                    conexion,
                    transaccion
                )
                cmdStock.Parameters.AddWithValue("@id", productoId)
                cmdStock.ExecuteNonQuery()

                ' Insertar detalle del ticket
                Dim cmdDetalle As New SqlCommand(
                    "INSERT INTO DetalleTicket 
                    (TicketId, ProductoId, Cantidad, PrecioUnitario, Subtotal)
                    VALUES (@TicketId, @ProductoId, 1, @Precio, @Subtotal)",
                    conexion,
                    transaccion
                )
                cmdDetalle.Parameters.AddWithValue("@TicketId", ticketId)
                cmdDetalle.Parameters.AddWithValue("@ProductoId", productoId)
                cmdDetalle.Parameters.AddWithValue("@Precio", precio)
                cmdDetalle.Parameters.AddWithValue("@Subtotal", precio)
                cmdDetalle.ExecuteNonQuery()
            Next

            transaccion.Commit()
            MessageBox.Show($"Compra exitosa! Ticket No: {ticketId}", "Éxito",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar carrito y actualizar
            dgvCarrito.Rows.Clear()
            CalcularTotal()
            CargarProductos()

        Catch ex As Exception
            MessageBox.Show("Error al procesar compra: " & ex.Message)
            If transaccion IsNot Nothing Then
                transaccion.Rollback()
            End If
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
End Class