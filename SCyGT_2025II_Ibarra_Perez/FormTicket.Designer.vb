<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTicket
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
        Me.rtbTicket = New System.Windows.Forms.RichTextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbTicket
        '
        Me.rtbTicket.Location = New System.Drawing.Point(12, 12)
        Me.rtbTicket.Name = "rtbTicket"
        Me.rtbTicket.ReadOnly = True
        Me.rtbTicket.Size = New System.Drawing.Size(345, 426)
        Me.rtbTicket.TabIndex = 0
        Me.rtbTicket.Text = ""
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(151, 444)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 484)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.rtbTicket)
        Me.Name = "FormTicket"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbTicket As RichTextBox
    Friend WithEvents btnCerrar As Button
End Class
