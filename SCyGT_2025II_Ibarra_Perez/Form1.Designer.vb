<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvCarrito = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(12, 38)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(494, 163)
        Me.dgvProductos.TabIndex = 0
        '
        'dgvCarrito
        '
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Location = New System.Drawing.Point(12, 233)
        Me.dgvCarrito.Name = "dgvCarrito"
        Me.dgvCarrito.Size = New System.Drawing.Size(494, 103)
        Me.dgvCarrito.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(28, 371)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(128, 371)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(231, 371)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(441, 371)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 434)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvCarrito)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents dgvCarrito As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnComprar As Button
    Friend WithEvents lblTotal As Label
End Class
