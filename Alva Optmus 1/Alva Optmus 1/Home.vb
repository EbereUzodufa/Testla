Public Class Home
   
    Private Sub Labelusername_Click(sender As Object, e As EventArgs) Handles Labelusername.Click, PictureBoxHOME.Click
        Dim fort As New Smart
        fort.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call smartstylez()
        MsgBox(strfilename)
        PictureBoxHOME.BackgroundImage = Image.FromFile(strfilename)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '   Call saveereload()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonEXIT_Click(sender As Object, e As EventArgs) Handles ButtonEXIT.Click
        Call savee()
        Call klose()
    End Sub
End Class