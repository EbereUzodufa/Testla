Public Class Splash
    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Timer1.Start()
            If settings.cheat = "" Or settings.cheat = "UNDONE" Then

            Else
                LabelCheat.Text = "DONE"
            End If
        Catch ex As Exception
            LabelCheat.Text = "UNDONE"
        End Try

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Label6.Text = Val(Label6.Text) + 10
            If Val(Label6.Text) = 20 Then
                Timer2.Start()
                ProgressBar1.Show()
            End If
            If Val(Label6.Text) = 130 Then
                Timer1.Stop()
                Timer2.Stop()
                If LabelCheat.Text = "DONE" Then
                    Home.Show()
                    Me.Hide()
                Else
                    Aftersplash.Show()
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            Call smartstylez()
            Home.Show()
            Me.Hide()
        End Try

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(10)
    End Sub

End Class
