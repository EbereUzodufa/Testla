Public Class topics

    Private Sub Buttonintro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonintro.Click

        Me.Hide()
        topic_intro1.Show()

    End Sub

    Private Sub Labelback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labelback.Click
        Me.Hide()
        Subject.Show()
    End Sub

    Private Sub Labelback_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelback.MouseEnter
        Labelback.ForeColor = Color.Red
    End Sub

    Private Sub Labelback_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelback.MouseLeave
        Labelback.ForeColor = Color.White
    End Sub

    Private Sub topics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Labelname.Text = Courses.Labelusername.Text
    End Sub
End Class