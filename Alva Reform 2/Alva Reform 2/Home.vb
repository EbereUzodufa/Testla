Public Class Home

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ButtonCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCourse.Click
        TabControl1.SelectedTab = TabPageCourse
        ButtonCourse.BackColor = Color.WhiteSmoke
        ButtonDYK.BackColor = Color.Transparent
        Buttongames.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonDYK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDYK.Click
        TabControl1.SelectedTab = TabPageDYK

        ButtonCourse.BackColor = Color.Transparent
        ButtonDYK.BackColor = Color.WhiteSmoke
        Buttongames.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent

        'open other tab first page
        If (ButtonLateDisc.BackColor = Color.Transparent Or ButtonLateDisc.BackColor = Color.WhiteSmoke) And ButtonSchEthics.BackColor = Color.Transparent And ButtonStudRight.BackColor = Color.Transparent And ButtonRule.BackColor = Color.Transparent Then

            TabControlDYKsuB.SelectedTab = TabPageLateDisc
            ButtonLateDisc.BackColor = Color.WhiteSmoke
            ButtonSchEthics.BackColor = Color.Transparent
            ButtonStudRight.BackColor = Color.Transparent
            ButtonRule.BackColor = Color.Transparent

        ElseIf ButtonLateDisc.BackColor = Color.Transparent And ButtonSchEthics.BackColor = Color.WhiteSmoke And ButtonStudRight.BackColor = Color.Transparent And ButtonRule.BackColor = Color.Transparent Then

            TabControlDYKsuB.SelectedTab = TabPageSchEth
            ButtonLateDisc.BackColor = Color.Transparent
            ButtonSchEthics.BackColor = Color.WhiteSmoke
            ButtonStudRight.BackColor = Color.Transparent
            ButtonRule.BackColor = Color.Transparent

        ElseIf ButtonLateDisc.BackColor = Color.Transparent And ButtonSchEthics.BackColor = Color.Transparent And ButtonStudRight.BackColor = Color.WhiteSmoke And ButtonRule.BackColor = Color.Transparent Then

            TabControlDYKsuB.SelectedTab = TabPageStudRight
            ButtonLateDisc.BackColor = Color.Transparent
            ButtonSchEthics.BackColor = Color.Transparent
            ButtonStudRight.BackColor = Color.WhiteSmoke
            ButtonRule.BackColor = Color.Transparent

        ElseIf ButtonLateDisc.BackColor = Color.Transparent And ButtonSchEthics.BackColor = Color.Transparent And ButtonStudRight.BackColor = Color.Transparent And ButtonRule.BackColor = Color.WhiteSmoke Then

            TabControlDYKsuB.SelectedTab = TabPageRule
            ButtonLateDisc.BackColor = Color.Transparent
            ButtonSchEthics.BackColor = Color.Transparent
            ButtonStudRight.BackColor = Color.Transparent
            ButtonRule.BackColor = Color.WhiteSmoke

        End If

    End Sub

    Private Sub Buttonimposchstaffs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonimposchstaffs.Click
        TabControl1.SelectedTab = TabPageimposchstaff

        ButtonCourse.BackColor = Color.Transparent
        ButtonDYK.BackColor = Color.Transparent
        Buttongames.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.WhiteSmoke
        Buttonschinfo.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent
    End Sub

    Private Sub Buttonschinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonschinfo.Click
        TabControl1.SelectedTab = TabPageschinfo
        ButtonCourse.BackColor = Color.Transparent
        ButtonDYK.BackColor = Color.Transparent
        Buttongames.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.WhiteSmoke
        Buttoncgpa.BackColor = Color.Transparent

        If (ButtonAcvt.BackColor = Color.Transparent Or ButtonAcvt.BackColor = Color.WhiteSmoke) And Buttonbio.BackColor = Color.Transparent And Buttoncontact.BackColor = Color.Transparent Then

            TabControlinfo.SelectedTab = TabPageschAct
            ButtonAcvt.BackColor = Color.WhiteSmoke
            Buttonbio.BackColor = Color.Transparent
            Buttoncontact.BackColor = Color.Transparent

        ElseIf ButtonAcvt.BackColor = Color.Transparent And Buttonbio.BackColor = Color.WhiteSmoke And Buttoncontact.BackColor = Color.Transparent Then

            TabControlinfo.SelectedTab = TabPagehistory
            ButtonAcvt.BackColor = Color.Transparent
            Buttonbio.BackColor = Color.WhiteSmoke
            Buttoncontact.BackColor = Color.Transparent

        ElseIf ButtonAcvt.BackColor = Color.Transparent And Buttonbio.BackColor = Color.Transparent And Buttoncontact.BackColor = Color.WhiteSmoke Then

            TabControlinfo.SelectedTab = TabPageschcontacts
            ButtonAcvt.BackColor = Color.Transparent
            Buttonbio.BackColor = Color.Transparent
            Buttoncontact.BackColor = Color.WhiteSmoke
        End If


    End Sub

    Private Sub Buttongames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttongames.Click
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
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = ")" Or IsNumeric(onecharacter) Or onecharacter = "-" Or onecharacter = "_" Or onecharacter = "=" Or onecharacter = "+" Or onecharacter = "[" Or onecharacter = "{" Or onecharacter = "}" Or onecharacter = "]" Or onecharacter = "\" Or onecharacter = "|" Or onecharacter = ";" Or onecharacter = ":" Or onecharacter = "'" Or onecharacter = "," Or onecharacter = "<" Or onecharacter = "." Or onecharacter = ">" Or onecharacter = "/" Or onecharacter = "?" Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit Sub
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text.ToUpper
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                    End If
                Next
            End If

            'other forms
            Call vanessa()

            ' SPEAK CODE WHICH WILL BE LEFT FOR THE NEXT VERSION
            'Dim personname As String
            ' personname = "Welcome," & "  ,    ,   ,    ,   " & TextBoxname.Text
            '  Dim SAPI As Object
            ' SAPI = CreateObject("SAPI.spvoice")
            ' SAPI.speak(personname)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        TabControl1.SelectedTab = TabPageGames

        ButtonCourse.BackColor = Color.Transparent
        ButtonDYK.BackColor = Color.Transparent
        Buttongames.BackColor = Color.WhiteSmoke
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent
    End Sub

    Private Sub Buttoncgpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncgpa.Click
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
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = ")" Or IsNumeric(onecharacter) Or onecharacter = "-" Or onecharacter = "_" Or onecharacter = "=" Or onecharacter = "+" Or onecharacter = "[" Or onecharacter = "{" Or onecharacter = "}" Or onecharacter = "]" Or onecharacter = "\" Or onecharacter = "|" Or onecharacter = ";" Or onecharacter = ":" Or onecharacter = "'" Or onecharacter = "," Or onecharacter = "<" Or onecharacter = "." Or onecharacter = ">" Or onecharacter = "/" Or onecharacter = "?" Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit Sub
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text.ToUpper
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                    End If
                Next
            End If
            Call vanessa()
            Me.Hide()
            CGPA.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


       


        ' SPEAK CODE WHICH WILL BE LEFT FOR THE NEXT VERSION
        'Dim personname As String
        ' personname = "Welcome," & "  ,    ,   ,    ,   " & TextBoxname.Text
        '  Dim SAPI As Object
        ' SAPI = CreateObject("SAPI.spvoice")
        ' SAPI.speak(personname)


    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Labelusername.Hide()
        TextBoxname.Show()
        Labelentername.Show()
        ButtonOK.Show()
        Labelchangename.Hide()

        TabControl1.SelectedTab = TabPageCourse
        ButtonCourse.BackColor = Color.WhiteSmoke
        ButtonDYK.BackColor = Color.Transparent
        Buttongames.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent
        TabControlSEmS.SelectedTab = TabPagefirSeme
        ButtonFirst.BackColor = Color.WhiteSmoke

        'other Forms
        Subject.Labelusername.Text = Me.Labelusername.Text
        Game1.Labelusername.Text = Me.Labelusername.Text

    End Sub

    Private Sub ButtonFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFirst.Click
        TabControlSEmS.SelectedTab = TabPagefirSeme
        ButtonFirst.BackColor = Color.WhiteSmoke
        Buttonsecond.BackColor = Color.Transparent

    End Sub

    Private Sub Buttonsecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsecond.Click
        TabControlSEmS.SelectedTab = TabPageSecSeme
        ButtonFirst.BackColor = Color.Transparent
        Buttonsecond.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

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
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = ")" Or IsNumeric(onecharacter) Or onecharacter = "-" Or onecharacter = "_" Or onecharacter = "=" Or onecharacter = "+" Or onecharacter = "[" Or onecharacter = "{" Or onecharacter = "}" Or onecharacter = "]" Or onecharacter = "\" Or onecharacter = "|" Or onecharacter = ";" Or onecharacter = ":" Or onecharacter = "'" Or onecharacter = "," Or onecharacter = "<" Or onecharacter = "." Or onecharacter = ">" Or onecharacter = "/" Or onecharacter = "?" Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit Sub
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                    End If
                Next
            End If

            'other forms
            Call vanessa()

            ' SPEAK CODE WHICH WILL BE LEFT FOR THE NEXT VERSION
            'Dim personname As String
            ' personname = "Welcome," & "  ,    ,   ,    ,   " & TextBoxname.Text
            '  Dim SAPI As Object
            ' SAPI = CreateObject("SAPI.spvoice")
            ' SAPI.speak(personname)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()
        Subject.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbio.Click
        TabControlinfo.SelectedTab = TabPagehistory
        ButtonAcvt.BackColor = Color.Transparent
        Buttonbio.BackColor = Color.WhiteSmoke
        Buttoncontact.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonSchAcvt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAcvt.Click
        TabControlinfo.SelectedTab = TabPageschAct
        ButtonAcvt.BackColor = Color.WhiteSmoke
        Buttonbio.BackColor = Color.Transparent
        Buttoncontact.BackColor = Color.Transparent
    End Sub

    Private Sub Buttoncontact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncontact.Click
        TabControlinfo.SelectedTab = TabPageschcontacts
        ButtonAcvt.BackColor = Color.Transparent
        Buttonbio.BackColor = Color.Transparent
        Buttoncontact.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click

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
                    If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = ")" Or IsNumeric(onecharacter) Or onecharacter = "-" Or onecharacter = "_" Or onecharacter = "=" Or onecharacter = "+" Or onecharacter = "[" Or onecharacter = "{" Or onecharacter = "}" Or onecharacter = "]" Or onecharacter = "\" Or onecharacter = "|" Or onecharacter = ";" Or onecharacter = ":" Or onecharacter = "'" Or onecharacter = "," Or onecharacter = "<" Or onecharacter = "." Or onecharacter = ">" Or onecharacter = "/" Or onecharacter = "?" Then
                        MsgBox(" Remove the Non Alphabet")
                        Exit Sub
                    ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then
                        Labelusername.Text = TextBoxname.Text.ToUpper
                        Labelentername.Hide()
                        TextBoxname.Hide()
                        ButtonOK.Hide()
                    End If
                Next
            End If
            Call vanessa()
            'other forms
           

            ' SPEAK CODE WHICH WILL BE LEFT FOR THE NEXT VERSION
            'Dim personname As String
            ' personname = "Welcome," & "  ,    ,   ,    ,   " & TextBoxname.Text
            '  Dim SAPI As Object
            ' SAPI = CreateObject("SAPI.spvoice")
            ' SAPI.speak(personname)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub vanessa()
        Subject.Labelusername.Text = Labelusername.Text
        Game1.Labelusername.Text = Labelusername.Text
        CGPA.Labeltitle.Text = Labelusername.Text
        Labelusername.Show()
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

    Private Sub Labelusername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labelusername.Click
        TextBoxname.Show()
        Labelentername.Show()
        ButtonOK.Show()
    End Sub


    Private Sub ButtonLateDisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLateDisc.Click

        TabControlDYKsuB.SelectedTab = TabPageLateDisc
        ButtonLateDisc.BackColor = Color.WhiteSmoke
        ButtonSchEthics.BackColor = Color.Transparent
        ButtonStudRight.BackColor = Color.Transparent
        ButtonRule.BackColor = Color.Transparent


    End Sub

    Private Sub ButtonSchEthics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSchEthics.Click
        TabControlDYKsuB.SelectedTab = TabPageSchEth
        ButtonLateDisc.BackColor = Color.Transparent
        ButtonSchEthics.BackColor = Color.WhiteSmoke
        ButtonStudRight.BackColor = Color.Transparent
        ButtonRule.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonStudRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStudRight.Click
        TabControlDYKsuB.SelectedTab = TabPageStudRight
        ButtonLateDisc.BackColor = Color.Transparent
        ButtonSchEthics.BackColor = Color.Transparent
        ButtonStudRight.BackColor = Color.WhiteSmoke
        ButtonRule.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonRule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRule.Click
        TabControlDYKsuB.SelectedTab = TabPageRule
        ButtonLateDisc.BackColor = Color.Transparent
        ButtonSchEthics.BackColor = Color.Transparent
        ButtonStudRight.BackColor = Color.Transparent
        ButtonRule.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ButtonEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXIT.Click
        Me.Close()
        Subject.Close()
        Splash.Close()
        CGPA.Close()
        Game1.Close()

    End Sub


    Private Sub ButtonEXIT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEXIT.MouseEnter
        LabelClose.Show()

    End Sub

    Private Sub ButtonEXIT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEXIT.MouseLeave
        LabelClose.Hide()
    End Sub


    Private Sub Buttonintro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonintro.Click
        System.Diagnostics.Process.Start("C:\Users\Ebere\Documents\Visual Studio 2010\Projects\Alva Reform 2\Alva Reform 2\bin\Debug\Resources\seminar topic_Catalytic Reduction of vehicular emission pollution, techinical seminar.pdf")
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        System.Diagnostics.Process.Start("C:\Users\Ebere\Documents\Visual Studio 2010\Projects\Alva Reform 2\Alva Reform 2\bin\Debug\Resources\IMMO TAL.pdf")
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        System.Diagnostics.Process.Start("www.tce.com")
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Game1rectangle.Click
        Me.Hide()
        Game1.Show()

    End Sub

    Private Sub Game1rectangle_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Game1rectangle.MouseEnter
        Game1rectangle.BorderStyle = Drawing2D.DashStyle.Dot
        Game1rectangle.BackgroundImage = My.Resources.light_blue
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        game1labelcaption.ForeColor = Color.WhiteSmoke
        game1labelsub.ForeColor = Color.WhiteSmoke
        game1labelcaption.BackgroundImage = My.Resources.light_blue
        game1labelsub.BackgroundImage = My.Resources.light_blue
        game1labelcaption.FlatAppearance.BorderColor = Color.Red
        game1labelsub.FlatAppearance.BorderColor = Color.Red

    End Sub

    Private Sub Game1rectangle_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Game1rectangle.MouseLeave

        Game1rectangle.BorderStyle = Drawing2D.DashStyle.Solid
        Game1rectangle.BackgroundImage = My.Resources.control
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        game1labelcaption.ForeColor = Color.Black
        game1labelsub.ForeColor = Color.Black
        game1labelcaption.BackgroundImage = My.Resources.control
        game1labelsub.BackgroundImage = My.Resources.control
        game1labelcaption.FlatAppearance.BorderColor = Color.WhiteSmoke
        game1labelsub.FlatAppearance.BorderColor = Color.WhiteSmoke

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Call RectangleShape3_Click(sender, e)

    End Sub

    Private Sub game1labelcaption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles game1labelcaption.Click, game1labelsub.Click
        Call RectangleShape3_Click(sender, e)
    End Sub

    Private Sub TextBoxname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonOK.PerformClick()
        End If
    End Sub


    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class