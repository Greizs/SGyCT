Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SplashScreen1
    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 5
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            LoginForm1.Show()
        End If
    End Sub
End Class
