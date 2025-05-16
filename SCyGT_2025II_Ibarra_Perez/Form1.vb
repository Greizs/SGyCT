Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections.Generic
Imports MetroFramework.Forms.MetroForm


Partial Public Class Form1
    Inherits MetroFramework.Forms.MetroForm

    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ConexionBD").ConnectionString)
    ' Lista general de productos (podría venir de base de datos más adelante)
    Dim productosDisponibles As New List(Of Producto)
    Dim carrito As New List(Of ItemCarrito)

    ' Clases básicas
    Public Class Producto
        Public Property Nombre As String
        Public Property Categoria As String
        Public Property Precio As Decimal
    End Class

    Public Class ItemCarrito
        Public Property Nombre As String
        Public Property Categoria As String
        Public Property Precio As Decimal
        Public Property Cantidad As Integer
        Public ReadOnly Property Total As Decimal
            Get
                Return Precio * Cantidad
            End Get
        End Property
    End Class

    Public NombreCompleto As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCajero.Text = "Nombre: " & SesionActual.Nombre ' Mostrar el nombre

        ' Configurar tema Metro
        Me.StyleManager = MetroStyleManager1
        MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light
        MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue ' Color principal

        CargarProductos()

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

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Puedes agregar lógica aquí si es necesario, por ejemplo, para agregar al carrito con doble clic.
    End Sub
End Class