Public Class Courses

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.Black
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Black
    End Sub


    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.ForeColor = Color.Black
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Black
    End Sub
    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Black
    End Sub
    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.Black
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.Black
    End Sub
    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.Black
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Black

    End Sub
    Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseEnter
        Button8.ForeColor = Color.Black
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Button8.ForeColor = Color.Black
    End Sub
    Private Sub Button9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseEnter
        Button9.ForeColor = Color.Black
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseLeave
        Button9.ForeColor = Color.Black
    End Sub
    Private Sub Button10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseEnter
        Button10.ForeColor = Color.Black
    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseLeave
        Button10.ForeColor = Color.Black
    End Sub
    Private Sub Button11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseEnter
        Button11.ForeColor = Color.Black
    End Sub

    Private Sub Button11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseLeave
        Button11.ForeColor = Color.Black
    End Sub
    Private Sub Button12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseEnter, Button20.MouseEnter, Button19.MouseEnter
        Button12.ForeColor = Color.Black
    End Sub

    Private Sub Button12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseLeave, Button20.MouseLeave, Button19.MouseLeave
        Button12.ForeColor = Color.Black
    End Sub
    Private Sub Button13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseEnter
        Button13.ForeColor = Color.Black
    End Sub

    Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseLeave
        Button13.ForeColor = Color.Black
    End Sub
    Private Sub Button14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonChE312.MouseEnter
        ButtonChE312.ForeColor = Color.Black
    End Sub

    Private Sub Button14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonChE312.MouseLeave
        ButtonChE312.ForeColor = Color.Black
    End Sub
    Private Sub Button15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseEnter
        Button15.ForeColor = Color.Black
    End Sub

    Private Sub Button15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseLeave
        Button15.ForeColor = Color.Black
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub page1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Labelusername.Hide()
        TextBoxname.Show()
        Labelentername.Show()
        ButtonOK.Show()
        Labelchangename.Hide()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChE312.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labelusername.Click
        TextBoxname.Show()
        Labelentername.Show()
        ButtonOK.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                    End If
                Next
            End If
            Labelusername.Show()
            Dim personname As String
            personname = "Welcome," & "  ,    ,   ,    ,   " & TextBoxname.Text
            Dim SAPI As Object
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak(personname)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Labelusername_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelusername.MouseEnter
        If TextBoxname.Visible = False And Labelchangename.Visible = False And Labelentername.Visible = False And ButtonOK.Visible = False Then
            Labelchangename.Show()
        Else
            Labelchangename.Hide()
        End If

    End Sub

    Private Sub Labelusername_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelusername.MouseLeave
        Labelchangename.Hide()
    End Sub

    Private Sub Buttonexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonexit.Click
        Me.Close()
        Home.Close()
        Subject.Close()
        topics.Close()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click, Button20.Click, Button19.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()

                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBoxname.Text
            Dim count As Integer = 0

            If Trim(TextBoxname.Text) = "" Then
                MsgBox("Enter Your Name In the Box")
                Exit Sub
            Else
                For i = 0 To name.Length - 1
                    onecharacter = name.Chars(i)
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = "(" Or IsNumeric(onecharacter) Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit For
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Dim ut As String
                        ut = Button9.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                        Me.Hide()
                        Subject.Show()
                        Subject.LabelCOURSENAME.Text = Button9.Text
                    End If
                Next
            End If

            Labelusername.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buttonexit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonexit.MouseEnter
        Buttonexit.BackColor = Color.White
    End Sub

    Private Sub Buttonexit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonexit.MouseLeave
        Buttonexit.BackColor = Color.Transparent
    End Sub
End Class