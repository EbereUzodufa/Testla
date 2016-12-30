Public Class Smart

    Private Sub ButtonEXIT_Click(sender As Object, e As EventArgs) Handles ButtonEXIT.Click
        Call Close()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
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
                        settings.labelname = TextBoxname.Text
                        settings.pictureloKat = strifile
                        settings.Lacheat = "DONE"
                        settings.Save()
                        Call smartnames()
                        Call pictures()
                    End If
                Next
            End If
            Me.Hide()
        Catch ex As Exception
            Call ALvaicon()
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Try
            Dim open As New OpenFileDialog
            open.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            open.ShowDialog()
            strifile = open.FileName
            Call pictures()
        Catch ex As Exception
            Call ALvaicon()
            settings.labelname = TextBoxname.Text
            settings.Lacheat = "DONE"
            settings.pictureloKat = strifile
            settings.Save()
            Call smartnames()
            Call pictures()
            Me.Close()
        End Try
    End Sub

    Private Sub Smart_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call thenames()
        Call pictures()
    End Sub
End Class