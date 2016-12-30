Public Class AfterSplash

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Try
            Dim open As New OpenFileDialog
            open.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            open.ShowDialog()
            strFileName = open.FileName
            PictureBox5.BackgroundImage = Image.FromFile(strFileName)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            strFileName = xlpath + "\Resources\icon.png"
        End Try
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        Label2.Show()
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        Label2.Hide()
    End Sub
    Private Sub savee()
        settings.labelname = TextBoxname.Text
        settings.picture = strFileName
        settings.cheat = "DONE"
        settings.Save()
    End Sub
   
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Or TextBoxname.Text.ToUpper = "YOUR NAME" Then
                MsgBox("Enter Your Name In the Box")
                TextBoxname.Clear()
                Exit Sub

            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = ")" Or IsNumeric(onecharacter) Or onecharacter = "-" Or onecharacter = "_" Or onecharacter = "=" Or onecharacter = "+" Or onecharacter = "[" Or onecharacter = "{" Or onecharacter = "}" Or onecharacter = "]" Or onecharacter = "\" Or onecharacter = "|" Or onecharacter = ";" Or onecharacter = ":" Or onecharacter = "'" Or onecharacter = "," Or onecharacter = "<" Or onecharacter = "." Or onecharacter = ">" Or onecharacter = "/" Or onecharacter = "?" Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit Sub
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Call vanessa()
                        Call picz()
                        Call savee()
                    End If
                Next
            End If
            Home.Show()
            Me.Hide()
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            strFileName = xlpath + "\Resources\icon.png"
            Call picz()
            Call vanessa()
            Call savee()
            Home.Show()
            Me.Hide()
            ' MsgBox("you have to select a picture to proceed")
        End Try

    End Sub
    Private Sub ButtonEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXIT.Click
        Call klose()
    End Sub
End Class