<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtMail = New MetroFramework.Controls.MetroTextBox()
        Me.txtContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.txtConfirmarContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.btnRegistrar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(42, 57)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nombre"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(42, 96)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Correo"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(42, 140)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Usuario"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(42, 186)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Contrasena"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(42, 231)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Confirmar contrasena"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(184, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(75, 23)
        Me.txtNombre.TabIndex = 5
        Me.txtNombre.Text = "MetroTextBox1"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(174, 96)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(117, 23)
        Me.txtMail.TabIndex = 6
        Me.txtMail.Text = "MetroTextBox2"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(184, 182)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContrasena.Size = New System.Drawing.Size(117, 23)
        Me.txtContrasena.TabIndex = 8
        Me.txtContrasena.Text = "MetroTextBox4"
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(193, 136)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(116, 23)
        Me.txtUsuario.TabIndex = 9
        Me.txtUsuario.Text = "MetroTextBox3"
        '
        'txtConfirmarContrasena
        '
        Me.txtConfirmarContrasena.Location = New System.Drawing.Point(193, 231)
        Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        Me.txtConfirmarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmarContrasena.Size = New System.Drawing.Size(129, 23)
        Me.txtConfirmarContrasena.TabIndex = 10
        Me.txtConfirmarContrasena.Text = "MetroTextBox5"
        Me.txtConfirmarContrasena.UseSystemPasswordChar = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(179, 311)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(122, 23)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Registrar"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtConfirmarContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtConfirmarContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnRegistrar As MetroFramework.Controls.MetroButton
End Class
