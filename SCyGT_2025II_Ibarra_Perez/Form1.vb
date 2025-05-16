Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections.Generic
Imports MetroFramework.Forms.MetroForm


Partial Public Class Form1
    Inherits MetroFramework.Forms.MetroForm

    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar tema Metro
        Me.StyleManager = MetroStyleManager1
        MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light
        MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue ' Color principal

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
            dgvProductos.Columns("Id").Visible = False ' Ocultar columna ID
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

    Private Sub InicializarCarrito()
        dgvCarrito.Columns.Clear()
        dgvCarrito.Columns.Add("Id", "Id")
        dgvCarrito.Columns("Id").Visible = False ' Opcional: Ocultar Id también en carrito si no es necesario para el usuario
        dgvCarrito.Columns.Add("Nombre", "Nombre")
        dgvCarrito.Columns.Add("Categoria", "Categoría")
        dgvCarrito.Columns.Add("Precio", "Precio")
        dgvCarrito.AllowUserToAddRows = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If dgvProductos.SelectedRows.Count > 0 Then
                Dim fila As DataGridViewRow = dgvProductos.SelectedRows(0)
                Dim productoId As Integer = CInt(fila.Cells("Id").Value)
                Dim nombreProducto As String = fila.Cells("Nombre").Value.ToString()

                dgvCarrito.Rows.Add(
                    productoId,
                    nombreProducto,
                    fila.Cells("Categoria").Value,
                    fila.Cells("Precio").Value
                )
                CalcularTotal()
            Else
                MessageBox.Show("Selecciona un producto.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al agregar producto: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvCarrito.SelectedRows.Count > 0 Then
                Dim fila As DataGridViewRow = dgvCarrito.SelectedRows(0)
                ' Dim productoId As Integer = CInt(fila.Cells("Id").Value) ' Ya no se usa para depuración

                dgvCarrito.Rows.RemoveAt(fila.Index)
                CalcularTotal()
            Else
                MessageBox.Show("Selecciona un producto del carrito para eliminar.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al eliminar producto: {ex.Message}")
        End Try
    End Sub

    Private Sub CalcularTotal()
        Try
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In dgvCarrito.Rows
                If Not row.IsNewRow AndAlso row.Cells("Precio").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Precio").Value) Then
                    total += Convert.ToDecimal(row.Cells("Precio").Value)
                End If
            Next
            lblTotal.Text = "Total: $" & total.ToString("0.00")
        Catch ex As Exception
            MessageBox.Show($"Error al calcular total: {ex.Message}")
        End Try
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Try
            If dgvCarrito.Rows.Count = 0 Or (dgvCarrito.Rows.Count = 1 AndAlso dgvCarrito.Rows(0).IsNewRow) Then
                MessageBox.Show("El carrito está vacío.")
                Return
            End If

            For Each row As DataGridViewRow In dgvCarrito.Rows
                If row.IsNewRow Then Continue For ' Saltar la fila nueva si existe
                If row.Cells("Id").Value Is Nothing OrElse String.IsNullOrEmpty(row.Cells("Id").Value.ToString()) OrElse CInt(row.Cells("Id").Value) <= 0 Then
                    MessageBox.Show("Error: Existen productos no válidos en el carrito. Verifique que todos los productos tengan un ID válido.")
                    Return
                End If
            Next

            Dim transaccion As SqlTransaction = Nothing
            Dim ticketId As Integer = 0
            Dim totalCompra As Decimal = 0
            Dim productosCompradosParaTicket As New List(Of Tuple(Of String, Decimal, Integer))() ' Nombre, Precio, Cantidad (siempre 1 en este caso)
            Dim fechaCompra As DateTime = DateTime.Now


            Using connLocal As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
                connLocal.Open()
                transaccion = connLocal.BeginTransaction()

                Try
                    ' Calcular total y recopilar productos para el ticket
                    For Each row As DataGridViewRow In dgvCarrito.Rows
                        If row.IsNewRow Then Continue For
                        totalCompra += Convert.ToDecimal(row.Cells("Precio").Value)
                        productosCompradosParaTicket.Add(Tuple.Create(row.Cells("Nombre").Value.ToString(), Convert.ToDecimal(row.Cells("Precio").Value), 1))
                    Next

                    ' Insertar ticket
                    Dim cmdTicket As New SqlCommand(
                        "INSERT INTO Tickets (Fecha, Total) VALUES (@Fecha, @Total);
                         SELECT SCOPE_IDENTITY();",
                        connLocal,
                        transaccion
                    )
                    cmdTicket.Parameters.AddWithValue("@Fecha", fechaCompra)
                    cmdTicket.Parameters.AddWithValue("@Total", totalCompra)
                    ticketId = Convert.ToInt32(cmdTicket.ExecuteScalar())

                    ' Procesar productos
                    For Each row As DataGridViewRow In dgvCarrito.Rows
                        If row.IsNewRow Then Continue For
                        Dim productoId As Integer = CInt(row.Cells("Id").Value)
                        Dim precio As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)

                        ' Validar existencia (opcionalmente podrías confiar en FK constraints o validaciones previas)
                        Dim cmdVerificar As New SqlCommand(
                            "SELECT COUNT(*) FROM Productos WHERE Id = @id",
                            connLocal,
                            transaccion
                        )
                        cmdVerificar.Parameters.AddWithValue("@id", productoId)
                        If Convert.ToInt32(cmdVerificar.ExecuteScalar()) = 0 Then
                            Throw New Exception($"Producto ID {productoId} no encontrado en la base de datos. La transacción será revertida.")
                        End If

                        ' Actualizar stock
                        Dim cmdStock As New SqlCommand(
                            "UPDATE Productos SET Stock = Stock - 1 WHERE Id = @id",
                            connLocal,
                            transaccion
                        )
                        cmdStock.Parameters.AddWithValue("@id", productoId)
                        cmdStock.ExecuteNonQuery()

                        ' Insertar detalle
                        Dim cmdDetalle As New SqlCommand(
                            "INSERT INTO DetalleTicket (TicketId, ProductoId, Cantidad, PrecioUnitario, Subtotal)
                             VALUES (@TicketId, @ProductoId, 1, @Precio, @Subtotal)",
                            connLocal,
                            transaccion
                        )
                        cmdDetalle.Parameters.AddWithValue("@TicketId", ticketId)
                        cmdDetalle.Parameters.AddWithValue("@ProductoId", productoId)
                        cmdDetalle.Parameters.AddWithValue("@Precio", precio)
                        cmdDetalle.Parameters.AddWithValue("@Subtotal", precio) ' Cantidad es 1
                        cmdDetalle.ExecuteNonQuery()
                    Next

                    transaccion.Commit()
                    ' MessageBox.Show($"Compra exitosa! Ticket No: {ticketId}", "Éxito",
                    '                 MessageBoxButtons.OK, MessageBoxIcon.Information) ' Mensaje original eliminado

                    ' Mostrar Ticket
                    Using formTicket As New FormTicket(ticketId, fechaCompra, productosCompradosParaTicket, totalCompra)
                        formTicket.ShowDialog()
                    End Using

                    dgvCarrito.Rows.Clear()
                    InicializarCarrito() ' Reinicializa las columnas también por si acaso
                    CalcularTotal()
                    CargarProductos()

                Catch ex As Exception
                    MessageBox.Show($"Error durante la compra: {ex.Message}")
                    If transaccion IsNot Nothing Then
                        transaccion.Rollback()
                    End If
                Finally
                    If connLocal.State = ConnectionState.Open Then
                        connLocal.Close()
                    End If
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error general en el proceso de compra: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                      "Confirmar salida",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
            Application.Exit()
        End If
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        ' Puedes agregar lógica aquí si es necesario, por ejemplo, para agregar al carrito con doble clic.
    End Sub
End Class