Public Class Home

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Labelalva.Hide()
        Label2.Hide()
        Timercount.Enabled = True
        Labelwelcome.Hide()
        My.Computer.Audio.Play(My.Resources.My_Movie, AudioPlayMode.Background)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timercount.Tick

        Try
            Dim a As Integer
            a = Val(Label2.Text)
            a = a + 1
            Label2.Text = a
            If Label2.Text = 2 Then
                Labelwelcome.Show()
                My.Computer.Audio.Stop()
            End If

            If Label2.Text = 4 Then
                Labelalva.Show()
            End If
            If Label2.Text > 4 Then
                Dim SAPI As Object
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.speak("Welcome to Alva")
            End If
            If Label2.Text = 5 Then
                Timercount.Enabled = False

                Me.Hide()
                Courses.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class