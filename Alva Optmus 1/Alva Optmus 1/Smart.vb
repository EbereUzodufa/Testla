Public Class Smart

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        Label2.Show()
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        Label2.Hide()
    End Sub
   
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Or Trim(TextBoxname.Text.ToUpper) = "YOURNAME" Then
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
                        Call savee()
                        Call vanessa()
                        Call picz()
                    End If
                Next
            End If
            Me.Hide()
        Catch ex As Exception
            Call smartstylez()
            Call picz()
            Call vanessa()
            Call savee()
            Me.Hide()
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Smart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call saveereload()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Try
            Dim open As New OpenFileDialog
            open.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            open.ShowDialog()
            strFileName = open.FileName
            PictureBox5.BackgroundImage = Image.FromFile(strFileName)
        Catch ex As Exception
            Call smartstylez()
        End Try
    End Sub
    Private Sub ButtonEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXIT.Click
        Me.Close()
    End Sub
End Class