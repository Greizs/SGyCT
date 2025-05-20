<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVerTicket))
        Me.btnBuscarTicket = New System.Windows.Forms.Button()
        Me.txtTicketId = New MetroFramework.Controls.MetroTextBox()
        Me.lblTotal = New MetroFramework.Controls.MetroLabel()
        Me.dgvDetalleTicket = New System.Windows.Forms.DataGridView()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvDetalleTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarTicket
        '
        Me.btnBuscarTicket.Location = New System.Drawing.Point(85, 83)
        Me.btnBuscarTicket.Name = "btnBuscarTicket"
        Me.btnBuscarTicket.Size = New System.Drawing.Size(103, 29)
        Me.btnBuscarTicket.TabIndex = 1
        Me.btnBuscarTicket.Text = "Buscar ticket"
        Me.btnBuscarTicket.UseVisualStyleBackColor = True
        '
        'txtTicketId
        '
        '
        '
        '
        Me.txtTicketId.CustomButton.Image = Nothing
        Me.txtTicketId.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtTicketId.CustomButton.Name = ""
        Me.txtTicketId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTicketId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTicketId.CustomButton.TabIndex = 1
        Me.txtTicketId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTicketId.CustomButton.UseSelectable = True
        Me.txtTicketId.CustomButton.Visible = False
        Me.txtTicketId.Lines = New String(-1) {}
        Me.txtTicketId.Location = New System.Drawing.Point(132, 43)
        Me.txtTicketId.MaxLength = 32767
        Me.txtTicketId.Name = "txtTicketId"
        Me.txtTicketId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTicketId.PromptText = "Ingresa el id de la compra"
        Me.txtTicketId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTicketId.SelectedText = ""
        Me.txtTicketId.SelectionLength = 0
        Me.txtTicketId.SelectionStart = 0
        Me.txtTicketId.ShortcutsEnabled = True
        Me.txtTicketId.Size = New System.Drawing.Size(156, 23)
        Me.txtTicketId.TabIndex = 2
        Me.txtTicketId.UseSelectable = True
        Me.txtTicketId.WaterMark = "Ingresa el id de la compra"
        Me.txtTicketId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTicketId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 138)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 0)
        Me.lblTotal.TabIndex = 3
        '
        'dgvDetalleTicket
        '
        Me.dgvDetalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleTicket.Location = New System.Drawing.Point(12, 204)
        Me.dgvDetalleTicket.Name = "dgvDetalleTicket"
        Me.dgvDetalleTicket.Size = New System.Drawing.Size(399, 146)
        Me.dgvDetalleTicket.TabIndex = 4
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton1.Location = New System.Drawing.Point(383, 12)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(28, 27)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(56, 43)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "# de ticket:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormVerTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.dgvDetalleTicket)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTicketId)
        Me.Controls.Add(Me.btnBuscarTicket)
        Me.Name = "FormVerTicket"
        Me.Text = "Consultar ticket"
        CType(Me.dgvDetalleTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarTicket As Button
    Friend WithEvents txtTicketId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvDetalleTicket As DataGridView
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As Button
End Class
