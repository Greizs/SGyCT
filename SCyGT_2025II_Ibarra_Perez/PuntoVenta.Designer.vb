﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuntoVenta
    Inherits MetroFramework.Forms.MetroForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PuntoVenta))
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.lblCajero = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombreProducto = New MetroFramework.Controls.MetroTextBox()
        Me.txtCantidadProducto = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dgvCarrito = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregarProducto = New MetroFramework.Controls.MetroButton()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnCombos = New MetroFramework.Controls.MetroButton()
        Me.btnBebidas = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.btnPizzas = New MetroFramework.Controls.MetroButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalneto = New MetroFramework.Controls.MetroLabel()
        Me.lblSubtotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnConfirmarVenta = New MetroFramework.Controls.MetroButton()
        Me.btnLimpiarCarrito = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerTicket = New MetroFramework.Controls.MetroButton()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(164, 466)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Location = New System.Drawing.Point(359, 500)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 35)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Location = New System.Drawing.Point(11, 25)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(0, 0)
        Me.lblCajero.TabIndex = 7
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 74)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 8
        Me.MetroLabel2.Text = "Producto:"
        '
        'txtNombreProducto
        '
        '
        '
        '
        Me.txtNombreProducto.CustomButton.Image = Nothing
        Me.txtNombreProducto.CustomButton.Location = New System.Drawing.Point(160, 1)
        Me.txtNombreProducto.CustomButton.Name = ""
        Me.txtNombreProducto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombreProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombreProducto.CustomButton.TabIndex = 1
        Me.txtNombreProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombreProducto.CustomButton.UseSelectable = True
        Me.txtNombreProducto.CustomButton.Visible = False
        Me.txtNombreProducto.Lines = New String(-1) {}
        Me.txtNombreProducto.Location = New System.Drawing.Point(92, 74)
        Me.txtNombreProducto.MaxLength = 32767
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreProducto.PromptText = "Ingresa nombre del producto"
        Me.txtNombreProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreProducto.SelectedText = ""
        Me.txtNombreProducto.SelectionLength = 0
        Me.txtNombreProducto.SelectionStart = 0
        Me.txtNombreProducto.ShortcutsEnabled = True
        Me.txtNombreProducto.Size = New System.Drawing.Size(182, 23)
        Me.txtNombreProducto.TabIndex = 9
        Me.txtNombreProducto.UseSelectable = True
        Me.txtNombreProducto.WaterMark = "Ingresa nombre del producto"
        Me.txtNombreProducto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombreProducto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCantidadProducto
        '
        '
        '
        '
        Me.txtCantidadProducto.CustomButton.Image = Nothing
        Me.txtCantidadProducto.CustomButton.Location = New System.Drawing.Point(160, 1)
        Me.txtCantidadProducto.CustomButton.Name = ""
        Me.txtCantidadProducto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCantidadProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCantidadProducto.CustomButton.TabIndex = 1
        Me.txtCantidadProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCantidadProducto.CustomButton.UseSelectable = True
        Me.txtCantidadProducto.CustomButton.Visible = False
        Me.txtCantidadProducto.Lines = New String(-1) {}
        Me.txtCantidadProducto.Location = New System.Drawing.Point(92, 114)
        Me.txtCantidadProducto.MaxLength = 32767
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidadProducto.PromptText = "Ingresa la cantidad"
        Me.txtCantidadProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCantidadProducto.SelectedText = ""
        Me.txtCantidadProducto.SelectionLength = 0
        Me.txtCantidadProducto.SelectionStart = 0
        Me.txtCantidadProducto.ShortcutsEnabled = True
        Me.txtCantidadProducto.Size = New System.Drawing.Size(182, 23)
        Me.txtCantidadProducto.TabIndex = 11
        Me.txtCantidadProducto.UseSelectable = True
        Me.txtCantidadProducto.WaterMark = "Ingresa la cantidad"
        Me.txtCantidadProducto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCantidadProducto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 114)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Cantidad:"
        '
        'dgvCarrito
        '
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Location = New System.Drawing.Point(11, 154)
        Me.dgvCarrito.Name = "dgvCarrito"
        Me.dgvCarrito.Size = New System.Drawing.Size(371, 172)
        Me.dgvCarrito.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.MetroButton3)
        Me.Panel1.Controls.Add(Me.btnAgregarProducto)
        Me.Panel1.Controls.Add(Me.dgvProductos)
        Me.Panel1.Controls.Add(Me.btnCombos)
        Me.Panel1.Controls.Add(Me.btnBebidas)
        Me.Panel1.Controls.Add(Me.MetroButton5)
        Me.Panel1.Controls.Add(Me.btnPizzas)
        Me.Panel1.Location = New System.Drawing.Point(404, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 552)
        Me.Panel1.TabIndex = 13
        '
        'MetroButton3
        '
        Me.MetroButton3.BackgroundImage = CType(resources.GetObject("MetroButton3.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton3.Location = New System.Drawing.Point(383, 14)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(28, 27)
        Me.MetroButton3.TabIndex = 20
        Me.MetroButton3.UseSelectable = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(138, 509)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(147, 38)
        Me.btnAgregarProducto.TabIndex = 19
        Me.btnAgregarProducto.Text = "Agregar producto"
        Me.btnAgregarProducto.UseSelectable = True
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(19, 221)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(392, 269)
        Me.dgvProductos.TabIndex = 4
        '
        'btnCombos
        '
        Me.btnCombos.Location = New System.Drawing.Point(226, 158)
        Me.btnCombos.Name = "btnCombos"
        Me.btnCombos.Size = New System.Drawing.Size(165, 47)
        Me.btnCombos.TabIndex = 3
        Me.btnCombos.Text = "Combos"
        Me.btnCombos.UseSelectable = True
        '
        'btnBebidas
        '
        Me.btnBebidas.Location = New System.Drawing.Point(39, 158)
        Me.btnBebidas.Name = "btnBebidas"
        Me.btnBebidas.Size = New System.Drawing.Size(168, 47)
        Me.btnBebidas.TabIndex = 2
        Me.btnBebidas.Text = "Bebidas"
        Me.btnBebidas.UseSelectable = True
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(226, 83)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(165, 47)
        Me.MetroButton5.TabIndex = 1
        Me.MetroButton5.Text = "Especialidades"
        Me.MetroButton5.UseSelectable = True
        '
        'btnPizzas
        '
        Me.btnPizzas.Location = New System.Drawing.Point(39, 83)
        Me.btnPizzas.Name = "btnPizzas"
        Me.btnPizzas.Size = New System.Drawing.Size(168, 47)
        Me.btnPizzas.TabIndex = 0
        Me.btnPizzas.Text = "Pizzas"
        Me.btnPizzas.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTotalneto)
        Me.Panel2.Controls.Add(Me.lblSubtotal)
        Me.Panel2.Controls.Add(Me.MetroLabel6)
        Me.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Panel2.Location = New System.Drawing.Point(11, 332)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 100)
        Me.Panel2.TabIndex = 14
        '
        'lblTotalneto
        '
        Me.lblTotalneto.AutoSize = True
        Me.lblTotalneto.Location = New System.Drawing.Point(204, 56)
        Me.lblTotalneto.Name = "lblTotalneto"
        Me.lblTotalneto.Size = New System.Drawing.Size(83, 19)
        Me.lblTotalneto.TabIndex = 4
        Me.lblTotalneto.Text = "MetroLabel7"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(12, 56)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(81, 19)
        Me.lblSubtotal.TabIndex = 3
        Me.lblSubtotal.Text = "MetroLabel1"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.Location = New System.Drawing.Point(246, 16)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel6.TabIndex = 2
        Me.MetroLabel6.Text = "Neto a pagar"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(30, 16)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Subtotal"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 441)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(147, 38)
        Me.MetroButton1.TabIndex = 15
        Me.MetroButton1.Text = "Eliminar producto"
        Me.MetroButton1.UseSelectable = True
        '
        'btnConfirmarVenta
        '
        Me.btnConfirmarVenta.Location = New System.Drawing.Point(191, 441)
        Me.btnConfirmarVenta.Name = "btnConfirmarVenta"
        Me.btnConfirmarVenta.Size = New System.Drawing.Size(154, 38)
        Me.btnConfirmarVenta.TabIndex = 16
        Me.btnConfirmarVenta.Text = "Aplicar venta"
        Me.btnConfirmarVenta.UseSelectable = True
        '
        'btnLimpiarCarrito
        '
        Me.btnLimpiarCarrito.Location = New System.Drawing.Point(23, 499)
        Me.btnLimpiarCarrito.Name = "btnLimpiarCarrito"
        Me.btnLimpiarCarrito.Size = New System.Drawing.Size(147, 36)
        Me.btnLimpiarCarrito.TabIndex = 18
        Me.btnLimpiarCarrito.Text = "Limpiar"
        Me.btnLimpiarCarrito.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 17
        '
        'btnVerTicket
        '
        Me.btnVerTicket.Location = New System.Drawing.Point(191, 499)
        Me.btnVerTicket.Name = "btnVerTicket"
        Me.btnVerTicket.Size = New System.Drawing.Size(154, 36)
        Me.btnVerTicket.TabIndex = 19
        Me.btnVerTicket.Text = "Consultar Ticket"
        Me.btnVerTicket.UseSelectable = True
        '
        'PuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVerTicket)
        Me.Controls.Add(Me.btnLimpiarCarrito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirmarVenta)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvCarrito)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCantidadProducto)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lblCajero)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PuntoVenta"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents lblCajero As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombreProducto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCantidadProducto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvCarrito As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConfirmarVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnLimpiarCarrito As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCombos As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBebidas As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPizzas As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregarProducto As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents lblTotalneto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSubtotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnVerTicket As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
End Class
