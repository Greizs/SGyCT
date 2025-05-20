<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInventario))
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtCategoria = New MetroFramework.Controls.MetroTextBox()
        Me.txtStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecio = New MetroFramework.Controls.MetroTextBox()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.btnEditar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnLimpiar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblCajero = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(12, 364)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(500, 188)
        Me.dgvProductos.TabIndex = 0
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(194, 87)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(162, 23)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCategoria
        '
        '
        '
        '
        Me.txtCategoria.CustomButton.Image = Nothing
        Me.txtCategoria.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtCategoria.CustomButton.Name = ""
        Me.txtCategoria.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCategoria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCategoria.CustomButton.TabIndex = 1
        Me.txtCategoria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCategoria.CustomButton.UseSelectable = True
        Me.txtCategoria.CustomButton.Visible = False
        Me.txtCategoria.Lines = New String(-1) {}
        Me.txtCategoria.Location = New System.Drawing.Point(194, 131)
        Me.txtCategoria.MaxLength = 32767
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCategoria.SelectedText = ""
        Me.txtCategoria.SelectionLength = 0
        Me.txtCategoria.SelectionStart = 0
        Me.txtCategoria.ShortcutsEnabled = True
        Me.txtCategoria.Size = New System.Drawing.Size(162, 23)
        Me.txtCategoria.TabIndex = 2
        Me.txtCategoria.UseSelectable = True
        Me.txtCategoria.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCategoria.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStock
        '
        '
        '
        '
        Me.txtStock.CustomButton.Image = Nothing
        Me.txtStock.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtStock.CustomButton.Name = ""
        Me.txtStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStock.CustomButton.TabIndex = 1
        Me.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStock.CustomButton.UseSelectable = True
        Me.txtStock.CustomButton.Visible = False
        Me.txtStock.Lines = New String(-1) {}
        Me.txtStock.Location = New System.Drawing.Point(194, 226)
        Me.txtStock.MaxLength = 32767
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStock.SelectedText = ""
        Me.txtStock.SelectionLength = 0
        Me.txtStock.SelectionStart = 0
        Me.txtStock.ShortcutsEnabled = True
        Me.txtStock.Size = New System.Drawing.Size(162, 23)
        Me.txtStock.TabIndex = 4
        Me.txtStock.UseSelectable = True
        Me.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecio
        '
        '
        '
        '
        Me.txtPrecio.CustomButton.Image = Nothing
        Me.txtPrecio.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtPrecio.CustomButton.Name = ""
        Me.txtPrecio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecio.CustomButton.TabIndex = 1
        Me.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecio.CustomButton.UseSelectable = True
        Me.txtPrecio.CustomButton.Visible = False
        Me.txtPrecio.Lines = New String(-1) {}
        Me.txtPrecio.Location = New System.Drawing.Point(194, 178)
        Me.txtPrecio.MaxLength = 32767
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecio.SelectedText = ""
        Me.txtPrecio.SelectionLength = 0
        Me.txtPrecio.SelectionStart = 0
        Me.txtPrecio.ShortcutsEnabled = True
        Me.txtPrecio.Size = New System.Drawing.Size(162, 23)
        Me.txtPrecio.TabIndex = 3
        Me.txtPrecio.UseSelectable = True
        Me.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(104, 271)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseSelectable = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(259, 271)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(116, 23)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseSelectable = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(104, 313)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(116, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseSelectable = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(259, 313)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(116, 23)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(115, 91)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "Nombre:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(115, 135)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel2.TabIndex = 10
        Me.MetroLabel2.Text = "Categoria:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(115, 182)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Precio:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(115, 230)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel4.TabIndex = 12
        Me.MetroLabel4.Text = "Stock:"
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.BackColor = System.Drawing.Color.Transparent
        Me.lblCajero.Location = New System.Drawing.Point(25, 21)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(0, 0)
        Me.lblCajero.TabIndex = 13
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(417, 313)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 14
        Me.MetroButton1.Text = "Menu"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton2.Location = New System.Drawing.Point(491, 12)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(28, 27)
        Me.MetroButton2.TabIndex = 15
        Me.MetroButton2.UseSelectable = True
        '
        'FormInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(531, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.lblCajero)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "FormInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCategoria As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrecio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEditar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLimpiar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCajero As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
