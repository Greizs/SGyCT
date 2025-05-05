Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SplashScreen1
    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Hide()
        LoginForm1.Show()
    End Sub
End Class
