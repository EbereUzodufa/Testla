Public Class Subject

    Private Sub Subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelCOURSENAME.Text = "CHM 130.1"
      
            Label1.Text = Courses.Labelusername.Text
            Label1.Show()


    End Sub

    Private Sub Labelback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labelback.Click
        Me.Hide()
        Courses.Show()
    End Sub

    Private Sub Labelback_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelback.MouseEnter
        Labelback.BackColor = Color.Red
        Labelback.ForeColor = Color.Black
    End Sub

    Private Sub Labelback_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelback.MouseLeave
        Labelback.BackColor = Color.Black
        Labelback.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOUTSLIDE.Click
        Me.Hide()
        topics.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Buttonexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonexit.Click
        Me.Close()
        Courses.Close()
        topics.Close()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class