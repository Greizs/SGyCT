Imports System.Configuration
Imports System.Data.SqlClient

Public Class PuntoVenta
    ' Clase para los items del carrito
    Public Class ItemCarrito
        Public Property Cantidad As Integer
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Precio As Decimal
        Public ReadOnly Property Total As Decimal
            Get
                Return Cantidad * Precio
            End Get
        End Property
    End Class

    Dim carrito As New List(Of ItemCarrito)
    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ConexionBD").ConnectionString)

    ' Botón agregar producto al carrito
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim nombreBuscado As String = txtNombreProducto.Text.Trim()
        Dim cantidadIngresada As Integer

        ' Validar cantidad ingresada
        If Not Integer.TryParse(txtCantidadProducto.Text.Trim(), cantidadIngresada) OrElse cantidadIngresada <= 0 Then
            MessageBox.Show("Por favor ingresa una cantidad válida.")
            Return
        End If

        ' Si se seleccionó una fila, usar esa
        If dgvProductos.SelectedRows.Count > 0 Then
            ' Código existente...
            Dim fila = dgvProductos.SelectedRows(0)
            Dim idProducto As Integer = Convert.ToInt32(fila.Cells("Id").Value)
            Dim nombre As String = fila.Cells("Nombre").Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(fila.Cells("Precio").Value)
            Dim stock As Integer = Convert.ToInt32(fila.Cells("Stock").Value)

            If stock < cantidadIngresada Then
                MessageBox.Show("Stock insuficiente.")
                Return
            End If

            Dim itemExistente = carrito.FirstOrDefault(Function(i) i.Nombre = nombre)
            If itemExistente IsNot Nothing Then
                If itemExistente.Cantidad + cantidadIngresada > stock Then
                    MessageBox.Show("Cantidad supera el stock disponible.")
                    Return
                End If
                itemExistente.Cantidad += cantidadIngresada
            Else
                carrito.Add(New ItemCarrito With {
                .Id = idProducto,
                .Nombre = nombre,
                .Cantidad = cantidadIngresada,
                .Precio = precio
            })
            End If

            RefrescarCarrito()
            Return
        End If

        ' Si no se seleccionó fila, buscar por nombre del textbox
        If nombreBuscado = "" Then
            MessageBox.Show("Ingresa un nombre de producto válido o selecciona uno de la tabla.")
            Return
        End If

        ' Buscar producto en la base de datos
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("SELECT TOP 1 * FROM Productos WHERE Nombre = @nombre", conexion)
            cmd.Parameters.AddWithValue("@nombre", nombreBuscado)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim id As Integer = reader("Id")
                    Dim nombre As String = reader("Nombre").ToString()
                    Dim precio As Decimal = Convert.ToDecimal(reader("Precio"))
                    Dim stock As Integer = Convert.ToInt32(reader("Stock"))

                    If stock < cantidadIngresada Then
                        MessageBox.Show("Stock insuficiente.")
                        Return
                    End If

                    Dim itemExistente = carrito.FirstOrDefault(Function(i) i.Nombre = nombre)
                    If itemExistente IsNot Nothing Then
                        If itemExistente.Cantidad + cantidadIngresada > stock Then
                            MessageBox.Show("Cantidad supera el stock disponible.")
                            Return
                        End If
                        itemExistente.Cantidad += cantidadIngresada
                    Else
                        carrito.Add(New ItemCarrito With {
                        .Id = id,
                        .Nombre = nombre,
                        .Cantidad = cantidadIngresada,
                        .Precio = precio
                    })
                    End If

                    RefrescarCarrito()
                Else
                    MessageBox.Show("Producto no encontrado.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar producto: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnBebidas.Click
        CargarProductos("Bebida")
    End Sub

    Private Sub btnCombos_Click(sender As Object, e As EventArgs) Handles btnCombos.Click
        CargarProductos("Combo")
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

                cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad)
                cmdDetalle.Parameters.AddWithValue("@precio", item.Precio)
                cmdDetalle.Parameters.AddWithValue("@productoId", item.Id)
                cmdDetalle.Parameters.AddWithValue("@subtotal", item.Total)
                cmdDetalle.Parameters.AddWithValue("@ticketId", ticketId)
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

    ' Botón para limpiar carrito (opcional)
    Private Sub btnLimpiarCarrito_Click(sender As Object, e As EventArgs) Handles btnLimpiarCarrito.Click
        carrito.Clear()
        RefrescarCarrito()
        txtCantidadProducto.Clear()
        txtNombreProducto.Clear()
    End Sub

    Private Sub btnPizzas_Click(sender As Object, e As EventArgs) Handles btnPizzas.Click
        CargarProductos("Pizza")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Dim menuForm As New Menu()
        menuForm.Show()
    End Sub

    Private Sub btnVerTicket_Click(sender As Object, e As EventArgs) Handles btnVerTicket.Click
        Dim verTicketForm As New FormVerTicket()
        verTicketForm.ShowDialog()
    End Sub

    ' Carga productos según categoría (o todos si categoría es vacía)
    Private Sub CargarProductos(Optional categoria As String = "")
        Try
            Dim adaptador As SqlDataAdapter
            Dim tabla As New DataTable()

            If String.IsNullOrEmpty(categoria) Then
                ' Usa la VISTA para obtener todos los productos disponibles
                Dim query As String = "SELECT * FROM Vista_ProductosDisponibles"
                adaptador = New SqlDataAdapter(query, conexion)
            Else
                ' Usa el PROCEDIMIENTO ALMACENADO para filtrar por categoría
                Dim cmd As New SqlCommand("sp_ObtenerProductosPorCategoria", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Categoria", categoria)

                adaptador = New SqlDataAdapter(cmd)
            End If

            adaptador.Fill(tabla)
            dgvProductos.DataSource = tabla
            dgvProductos.Columns("Id").Visible = False
            dgvProductos.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establece el texto del Label con el mensaje de bienvenida
        lblCajero.Text = "Cajero: " & SesionActual.Nombre
        CargarProductos() ' Carga todos los productos al iniciar
        RefrescarCarrito() ' carrito vacío
    End Sub

    ' Refresca el carrito en el DataGridView y actualiza labels
    Private Sub RefrescarCarrito()
        dgvCarrito.DataSource = Nothing
        dgvCarrito.DataSource = carrito.Select(Function(i) New With {
                                                .Cantidad = i.Cantidad,
                                                .Nombre = i.Nombre,
                                                .PrecioUnitario = i.Precio,
                                                .Total = i.Total
                                                }).ToList()

        Dim subtotal = carrito.Sum(Function(i) i.Total)
        lblSubtotal.Text = "Subtotal: $" & subtotal.ToString("F2")
        lblTotalneto.Text = "Total Neto a Pagar: $" & subtotal.ToString("F2")
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                        "Confirmar salida",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MetroLabel6_Click(sender As Object, e As EventArgs) Handles MetroLabel6.Click

    End Sub
End Class
