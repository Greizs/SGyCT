Imports System.Text

Public Class FormTicket

    Private ReadOnly _ticketId As Integer
    Private ReadOnly _fechaCompra As DateTime
    Private ReadOnly _productosComprados As List(Of Tuple(Of String, Decimal, Integer)) ' Nombre, PrecioUnitario, Cantidad
    Private ReadOnly _totalCompra As Decimal

    Public Sub New(ticketId As Integer, fechaCompra As DateTime, productosComprados As List(Of Tuple(Of String, Decimal, Integer)), totalCompra As Decimal)
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _ticketId = ticketId
        _fechaCompra = fechaCompra
        _productosComprados = productosComprados
        _totalCompra = totalCompra

        GenerarYMostrarTicket()
    End Sub

    Private Sub GenerarYMostrarTicket()
        Dim sb As New StringBuilder()
        Dim separador As String = New String("-"c, 40) ' Línea separadora

        ' Encabezado del Ticket
        sb.AppendLine("      *** TICKET DE COMPRA ***")
        sb.AppendLine() ' Línea en blanco
        sb.AppendLine($"Ticket No: {_ticketId}")
        sb.AppendLine($"Fecha: {_fechaCompra.ToShortDateString()}")
        sb.AppendLine($"Hora: {_fechaCompra.ToLongTimeString()}")
        sb.AppendLine(separador)

        ' Cabecera de productos
        sb.AppendLine(String.Format("{0,-20} {1,8} {2,8}", "Producto", "Cant.", "Precio"))
        sb.AppendLine(separador)

        ' Listado de Productos
        For Each item In _productosComprados
            Dim nombreProducto As String = item.Item1
            Dim precioUnitario As Decimal = item.Item2
            Dim cantidad As Integer = item.Item3 ' Siempre es 1 en tu lógica actual
            Dim subtotalProducto As Decimal = precioUnitario * cantidad

            ' Truncar nombre si es muy largo para que quepa
            If nombreProducto.Length > 19 Then
                nombreProducto = nombreProducto.Substring(0, 16) & "..."
            End If

            sb.AppendLine(String.Format("{0,-20} {1,8} {2,8:C2}", nombreProducto, cantidad, subtotalProducto))
        Next

        ' Pie del Ticket
        sb.AppendLine(separador)
        sb.AppendLine(String.Format("{0,29} {1,8:C2}", "TOTAL:", _totalCompra))
        sb.AppendLine(separador)
        sb.AppendLine()
        sb.AppendLine("      ¡Gracias por su compra!")
        sb.AppendLine("   Vuelva pronto")

        ' Asignar texto al RichTextBox y usar fuente monoespaciada para mejor alineación
        rtbTicket.Font = New Font("Courier New", 10, FontStyle.Regular)
        rtbTicket.Text = sb.ToString()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub rtbTicket_TextChanged(sender As Object, e As EventArgs) Handles rtbTicket.TextChanged

    End Sub

    Private Sub FormTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class