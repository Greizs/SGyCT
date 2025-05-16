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
        Me.btnBuscarTicket = New System.Windows.Forms.Button()
        Me.txtTicketId = New MetroFramework.Controls.MetroTextBox()
        Me.lblTotal = New MetroFramework.Controls.MetroLabel()
        Me.dgvDetalleTicket = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDetalleTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarTicket
        '
        Me.btnBuscarTicket.Location = New System.Drawing.Point(84, 108)
        Me.btnBuscarTicket.Name = "btnBuscarTicket"
        Me.btnBuscarTicket.Size = New System.Drawing.Size(75, 23)
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
        Me.txtTicketId.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtTicketId.CustomButton.Name = ""
        Me.txtTicketId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTicketId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTicketId.CustomButton.TabIndex = 1
        Me.txtTicketId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTicketId.CustomButton.UseSelectable = True
        Me.txtTicketId.CustomButton.Visible = False
        Me.txtTicketId.Lines = New String() {"MetroTextBox1"}
        Me.txtTicketId.Location = New System.Drawing.Point(84, 63)
        Me.txtTicketId.MaxLength = 32767
        Me.txtTicketId.Name = "txtTicketId"
        Me.txtTicketId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTicketId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTicketId.SelectedText = ""
        Me.txtTicketId.SelectionLength = 0
        Me.txtTicketId.SelectionStart = 0
        Me.txtTicketId.ShortcutsEnabled = True
        Me.txtTicketId.Size = New System.Drawing.Size(75, 23)
        Me.txtTicketId.TabIndex = 2
        Me.txtTicketId.Text = "MetroTextBox1"
        Me.txtTicketId.UseSelectable = True
        Me.txtTicketId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTicketId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(78, 145)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(81, 19)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "MetroLabel1"
        '
        'dgvDetalleTicket
        '
        Me.dgvDetalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleTicket.Location = New System.Drawing.Point(12, 200)
        Me.dgvDetalleTicket.Name = "dgvDetalleTicket"
        Me.dgvDetalleTicket.Size = New System.Drawing.Size(335, 252)
        Me.dgvDetalleTicket.TabIndex = 4
        '
        'FormVerTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 484)
        Me.Controls.Add(Me.dgvDetalleTicket)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTicketId)
        Me.Controls.Add(Me.btnBuscarTicket)
        Me.Name = "FormVerTicket"
        Me.Text = "Form2"
        CType(Me.dgvDetalleTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarTicket As Button
    Friend WithEvents txtTicketId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvDetalleTicket As DataGridView
End Class
