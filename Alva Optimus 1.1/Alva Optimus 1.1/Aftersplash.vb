﻿Public Class Aftersplash
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Try
            Dim open As New OpenFileDialog
            open.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            open.ShowDialog()
            strifile = open.FileName
            Call pictures()
        Catch ex As Exception
            Call ALvaicon()
        End Try
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
                        settings.labelname = TextBoxname.Text
                        settings.Lacheat = "DONE"
                        settings.pictureloKat = strifile
                        settings.Save()
                        Call aftersplashnames()
                        Call pictures()
                        Home.Show()
                        Me.Hide()
                    End If
                Next
            End If

        Catch ex As Exception
            Call ALvaicon()
            settings.labelname = TextBoxname.Text
            settings.Lacheat = "DONE"
            settings.pictureloKat = strifile
            settings.Save()
            Call aftersplashnames()
            Call pictures()
            Home.Show()
            Me.Hide()
            ' MsgBox("you have to select a picture to proceed")
        End Try

    End Sub
    Private Sub ButtonEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXIT.Click
        Call klose()
    End Sub
End Class