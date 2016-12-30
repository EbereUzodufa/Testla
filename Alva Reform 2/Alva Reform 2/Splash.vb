Public Class Splash

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        

            Label6.Text = Val(Label6.Text) + 10

        If Val(Label6.Text) = 20 Then
            Timer2.Start()
            ProgressBar1.Show()
        End If

        If Val(Label6.Text) = 130 Then
            Timer1.Stop()
            Timer2.Stop()
            Me.Hide()
            Home.Show()
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(10)
    End Sub
End Class