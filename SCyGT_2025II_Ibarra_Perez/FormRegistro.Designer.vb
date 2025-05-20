<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegistrar = New MetroFramework.Controls.MetroButton()
        Me.txtConfirmarContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.txtContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(114, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(159, 443)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(62, 23)
        Me.MetroLink1.TabIndex = 31
        Me.MetroLink1.Text = "logueate"
        Me.MetroLink1.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(57, 443)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel7.TabIndex = 30
        Me.MetroLabel7.Text = "Ya tienes cuenta?"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(68, 23)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(133, 25)
        Me.MetroLabel6.TabIndex = 29
        Me.MetroLabel6.Text = "Inicia tu registro"
        Me.MetroLabel6.UseMnemonic = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(270, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 571)
        Me.Panel1.TabIndex = 28
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(91, 400)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(92, 23)
        Me.btnRegistrar.TabIndex = 27
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseSelectable = True
        '
        'txtConfirmarContrasena
        '
        '
        '
        '
        Me.txtConfirmarContrasena.CustomButton.Image = Nothing
        Me.txtConfirmarContrasena.CustomButton.Location = New System.Drawing.Point(180, 1)
        Me.txtConfirmarContrasena.CustomButton.Name = ""
        Me.txtConfirmarContrasena.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtConfirmarContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConfirmarContrasena.CustomButton.TabIndex = 1
        Me.txtConfirmarContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConfirmarContrasena.CustomButton.UseSelectable = True
        Me.txtConfirmarContrasena.CustomButton.Visible = False
        Me.txtConfirmarContrasena.Lines = New String(-1) {}
        Me.txtConfirmarContrasena.Location = New System.Drawing.Point(37, 353)
        Me.txtConfirmarContrasena.MaxLength = 32767
        Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        Me.txtConfirmarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmarContrasena.PromptText = "Confirma tu contrasena"
        Me.txtConfirmarContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmarContrasena.SelectedText = ""
        Me.txtConfirmarContrasena.SelectionLength = 0
        Me.txtConfirmarContrasena.SelectionStart = 0
        Me.txtConfirmarContrasena.ShortcutsEnabled = True
        Me.txtConfirmarContrasena.Size = New System.Drawing.Size(202, 23)
        Me.txtConfirmarContrasena.TabIndex = 26
        Me.txtConfirmarContrasena.UseSelectable = True
        Me.txtConfirmarContrasena.UseSystemPasswordChar = True
        Me.txtConfirmarContrasena.WaterMark = "Confirma tu contrasena"
        Me.txtConfirmarContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirmarContrasena.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtContrasena
        '
        '
        '
        '
        Me.txtContrasena.CustomButton.Image = Nothing
        Me.txtContrasena.CustomButton.Location = New System.Drawing.Point(180, 1)
        Me.txtContrasena.CustomButton.Name = ""
        Me.txtContrasena.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContrasena.CustomButton.TabIndex = 1
        Me.txtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContrasena.CustomButton.UseSelectable = True
        Me.txtContrasena.CustomButton.Visible = False
        Me.txtContrasena.Lines = New String(-1) {}
        Me.txtContrasena.Location = New System.Drawing.Point(37, 284)
        Me.txtContrasena.MaxLength = 32767
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContrasena.PromptText = "Ingresa una contrasena"
        Me.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContrasena.SelectedText = ""
        Me.txtContrasena.SelectionLength = 0
        Me.txtContrasena.SelectionStart = 0
        Me.txtContrasena.ShortcutsEnabled = True
        Me.txtContrasena.Size = New System.Drawing.Size(202, 23)
        Me.txtContrasena.TabIndex = 25
        Me.txtContrasena.UseSelectable = True
        Me.txtContrasena.UseSystemPasswordChar = True
        Me.txtContrasena.WaterMark = "Ingresa una contrasena"
        Me.txtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContrasena.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(180, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(37, 158)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "Ingresa tu correo electronico"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(202, 23)
        Me.txtEmail.TabIndex = 24
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMark = "Ingresa tu correo electronico"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.CustomButton.Image = Nothing
        Me.txtUsuario.CustomButton.Location = New System.Drawing.Point(180, 1)
        Me.txtUsuario.CustomButton.Name = ""
        Me.txtUsuario.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsuario.CustomButton.TabIndex = 1
        Me.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.CustomButton.UseSelectable = True
        Me.txtUsuario.CustomButton.Visible = False
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(37, 220)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.PromptText = "Ingresa un nombre de usuario"
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.ShortcutsEnabled = True
        Me.txtUsuario.Size = New System.Drawing.Size(202, 23)
        Me.txtUsuario.TabIndex = 23
        Me.txtUsuario.UseSelectable = True
        Me.txtUsuario.WaterMark = "Ingresa un nombre de usuario"
        Me.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(180, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(37, 94)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PromptText = "Ingresa tu nombre completo"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(202, 23)
        Me.txtNombre.TabIndex = 22
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMark = "Ingresa tu nombre completo"
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(37, 331)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel5.TabIndex = 21
        Me.MetroLabel5.Text = "Confirmar contrasena"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(37, 262)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel4.TabIndex = 20
        Me.MetroLabel4.Text = "Contrasena"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(37, 198)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel3.TabIndex = 19
        Me.MetroLabel3.Text = "Nombre de usuario"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(37, 136)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Correo electronico"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(34, 72)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Nombre completo"
        '
        'FormRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(827, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtConfirmarContrasena)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegistrar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtConfirmarContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
