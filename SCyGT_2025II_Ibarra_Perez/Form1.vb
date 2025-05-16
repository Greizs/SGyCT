Imports System.Data.SqlClient
Imports System.Configuration

Public Class Form1
    ' Clase para los items del carrito
    Public Class ItemCarrito
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Cantidad As Integer
        Public Property Precio As Decimal
        Public ReadOnly Property Total As Decimal
            Get
                Return Cantidad * Precio
            End Get
        End Property
    End Class

    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ConexionBD").ConnectionString)
    Dim carrito As New List(Of ItemCarrito)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos() ' Carga todos los productos al iniciar
        RefrescarCarrito() ' carrito vacío
    End Sub

    ' Carga productos según categoría (o todos si categoría es vacía)
    Private Sub CargarProductos(Optional categoria As String = "")
        Try
            Dim query As String
            If String.IsNullOrEmpty(categoria) Then
                query = "SELECT Id, Nombre, Categoria, Precio, Stock FROM Productos WHERE Stock > 0"
            Else
                query = "SELECT Id, Nombre, Categoria, Precio, Stock FROM Productos WHERE Stock > 0 AND Categoria = @categoria"
            End If

            Dim cmd As New SqlCommand(query, conexion)
            If Not String.IsNullOrEmpty(categoria) Then
                cmd.Parameters.AddWithValue("@categoria", categoria)
            End If

            Dim adaptador As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            dgvProductos.DataSource = tabla
            dgvProductos.Columns("Id").Visible = False
            dgvProductos.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

    ' Refresca el carrito en el DataGridView y actualiza labels
    Private Sub RefrescarCarrito()
        dgvCarrito.DataSource = Nothing
        dgvCarrito.DataSource = carrito.Select(Function(i) New With {
                                             .Nombre = i.Nombre,
                                             .Cantidad = i.Cantidad,
                                             .PrecioUnitario = i.Precio,
                                             .Total = i.Total
                                         }).ToList()

        Dim subtotal = carrito.Sum(Function(i) i.Total)
        lblSubtotal.Text = "Subtotal: $" & subtotal.ToString("F2")
        lblTotalneto.Text = "Total Neto a Pagar: $" & subtotal.ToString("F2")
    End Sub

    ' Botón agregar producto al carrito
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

        If dgvProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor selecciona un producto para agregar.")
            Return
        End If

        Dim fila = dgvProductos.SelectedRows(0)
        Dim idProducto As Integer = Convert.ToInt32(fila.Cells("Id").Value)
        Dim nombre As String = fila.Cells("Nombre").Value.ToString()
        Dim precio As Decimal = Convert.ToDecimal(fila.Cells("Precio").Value)

        Dim stock As Integer = Convert.ToInt32(fila.Cells("Stock").Value)
        If stock <= 0 Then
            MessageBox.Show("Este producto ya no tiene stock disponible.")
            Return
        End If

        ' Verificar si ya está en el carrito
        Dim itemExistente = carrito.FirstOrDefault(Function(i) i.Nombre = nombre)
        If itemExistente IsNot Nothing Then
            itemExistente.Cantidad += 1
        Else
            carrito.Add(New ItemCarrito With {
            .Id = idProducto,
            .Nombre = nombre,
            .Cantidad = 1,
            .Precio = precio
        })
        End If

        RefrescarCarrito()
    End Sub


    ' Botones para filtrar productos por categoría
    Private Sub btnPizzas_Click(sender As Object, e As EventArgs) Handles btnPizzas.Click
        CargarProductos("Pizza")
    End Sub

    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnBebidas.Click
        CargarProductos("Bebida")
    End Sub

    Private Sub btnCombos_Click(sender As Object, e As EventArgs) Handles btnCombos.Click
        CargarProductos("Combo")
    End Sub

    ' Botón para limpiar carrito (opcional)
    Private Sub btnLimpiarCarrito_Click(sender As Object, e As EventArgs) Handles btnLimpiarCarrito.Click
        carrito.Clear()
        RefrescarCarrito()
    End Sub

    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        If carrito.Count = 0 Then
            MessageBox.Show("El carrito está vacío. Agrega productos antes de generar el ticket.")
            Return
        End If

        Try
            conexion.Open()
            Dim trans As SqlTransaction = conexion.BeginTransaction()

            ' 1. Insertar en Tickets
            Dim totalVenta As Decimal = carrito.Sum(Function(p) p.Total)
            Dim cmdTicket As New SqlCommand("INSERT INTO Tickets (Total) OUTPUT INSERTED.Id VALUES (@total)", conexion, trans)
            cmdTicket.Parameters.AddWithValue("@total", totalVenta)
            Dim ticketId As Integer = Convert.ToInt32(cmdTicket.ExecuteScalar())

            ' 2. Insertar productos en DetalleTicket
            For Each item In carrito
                Dim cmdDetalle As New SqlCommand("
                INSERT INTO DetalleTicket (TicketId, ProductoId, Cantidad, PrecioUnitario, Subtotal)
                VALUES (@ticketId, @productoId, @cantidad, @precio, @subtotal)", conexion, trans)

                cmdDetalle.Parameters.AddWithValue("@ticketId", ticketId)
                cmdDetalle.Parameters.AddWithValue("@productoId", item.Id)
                cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad)
                cmdDetalle.Parameters.AddWithValue("@precio", item.Precio)
                cmdDetalle.Parameters.AddWithValue("@subtotal", item.Total)
                cmdDetalle.ExecuteNonQuery()

                ' 3. Actualizar stock
                Dim cmdStock As New SqlCommand("
                UPDATE Productos SET Stock = Stock - @cantidad WHERE Id = @id", conexion, trans)
                cmdStock.Parameters.AddWithValue("@cantidad", item.Cantidad)
                cmdStock.Parameters.AddWithValue("@id", item.Id)
                cmdStock.ExecuteNonQuery()
            Next

            trans.Commit()
            MessageBox.Show("¡Ticket generado correctamente! ID: " & ticketId)

            ' 4. Limpiar carrito e interfaz
            carrito.Clear()
            RefrescarCarrito()
            CargarProductos()

        Catch ex As Exception
            MessageBox.Show("Error al generar ticket: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnVerTicket_Click(sender As Object, e As EventArgs) Handles btnVerTicket.Click
        Dim verTicketForm As New FormVerTicket()
        verTicketForm.ShowDialog()
    End Sub

End Class
