Imports System.Data.SqlClient
Imports System.Configuration

Public Class FormVerTicket
    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ConexionBD").ConnectionString)

    Private Sub btnBuscarTicket_Click(sender As Object, e As EventArgs) Handles btnBuscarTicket.Click
        If String.IsNullOrWhiteSpace(txtTicketId.Text) Then
            MessageBox.Show("Ingresa el ID del ticket.")
            Return
        End If

        Dim ticketId As Integer
        If Not Integer.TryParse(txtTicketId.Text, ticketId) Then
            MessageBox.Show("El ID debe ser un número entero.")
            Return
        End If

        Try
            conexion.Open()

            ' Consultar el ticket
            Dim cmdTicket As New SqlCommand("SELECT Total, Fecha FROM Tickets WHERE Id = @id", conexion)
            cmdTicket.Parameters.AddWithValue("@id", ticketId)
            Dim reader As SqlDataReader = cmdTicket.ExecuteReader()

            If reader.Read() Then
                lblTotal.Text = "Total: $" & Convert.ToDecimal(reader("Total")).ToString("F2") & vbCrLf &
                                "Fecha: " & Convert.ToDateTime(reader("Fecha")).ToString("g")
            Else
                MessageBox.Show("Ticket no encontrado.")
                conexion.Close()
                Return
            End If
            reader.Close()

            ' Consultar detalle del ticket
            Dim cmdDetalle As New SqlCommand("
                SELECT P.Nombre, DT.Cantidad, DT.PrecioUnitario, DT.Subtotal
                FROM DetalleTicket DT
                INNER JOIN Productos P ON P.Id = DT.ProductoId
                WHERE DT.TicketId = @id", conexion)
            cmdDetalle.Parameters.AddWithValue("@id", ticketId)

            Dim adaptador As New SqlDataAdapter(cmdDetalle)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            dgvDetalleTicket.DataSource = tabla
            dgvDetalleTicket.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error al buscar ticket: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de querer salir del programa?",
                                                        "Confirmar salida",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim pdv As New PuntoVenta()
        pdv.Show()
    End Sub

    Private Sub FormVerTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
