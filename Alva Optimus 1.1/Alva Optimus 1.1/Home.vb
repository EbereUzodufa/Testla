Public Class Home
    Private Sub coursenamesorter()
        Call f200()
    End Sub
    Private Sub f200()
        Course1ButtonF2.Text = F200ListBoxCourseNameMain.Items(0).ToString + " - " + F200ListBoxCourseCodeMain.Items(0).ToString
        Course2ButtonF2.Text = F200ListBoxCourseNameMain.Items(1).ToString + " - " + F200ListBoxCourseCodeMain.Items(1).ToString
        Course3ButtonF2.Text = F200ListBoxCourseNameMain.Items(2).ToString + " - " + F200ListBoxCourseCodeMain.Items(2).ToString
        Course4ButtonF2.Text = F200ListBoxCourseNameMain.Items(3).ToString + " - " + F200ListBoxCourseCodeMain.Items(3).ToString
        Course5ButtonF2.Text = F200ListBoxCourseNameMain.Items(4).ToString + " - " + F200ListBoxCourseCodeMain.Items(4).ToString
        Course6ButtonF2.Text = F200ListBoxCourseNameMain.Items(5).ToString + " - " + F200ListBoxCourseCodeMain.Items(5).ToString
        Course7ButtonF2.Text = F200ListBoxCourseNameMain.Items(6).ToString + " - " + F200ListBoxCourseCodeMain.Items(6).ToString
        Course8ButtonF2.Text = F200ListBoxCourseNameMain.Items(7).ToString + " - " + F200ListBoxCourseCodeMain.Items(7).ToString
    End Sub
    Private Sub q()
        Subject.Show()
        Me.Hide()
        Subject.labeltimer.Text = ""
        Subject.Timer1.Enabled = True
        Outline.labeltimer2.Text = ""
        Outline.Timer1.Enabled = True
    End Sub
    Private Sub ButtonCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCourse.Click
        TabControlMain.SelectedTab = TabPageCourse
        ButtonCourse.BackColor = Color.WhiteSmoke
        ButtonDYK.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.Transparent
        ' Buttontimetable.BackColor = Color.Transparent
        'Buttonresult.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonDYK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDYK.Click
        TabControlMain.SelectedTab = TabPageDYK

        ButtonCourse.BackColor = Color.Transparent
        ButtonDYK.BackColor = Color.WhiteSmoke
        Buttoncgpa.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.Transparent
        ' Buttontimetable.BackColor = Color.Transparent
        'Buttonresult.BackColor = Color.Transparent

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
        TabControlMain.SelectedTab = TabPageimposchstaff
        ButtonCourse.BackColor = Color.Transparent
        ButtonDYK.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.WhiteSmoke
        Buttonschinfo.BackColor = Color.Transparent
        ' Buttontimetable.BackColor = Color.Transparent
        'Buttonresult.BackColor = Color.Transparent
    End Sub

    Private Sub Buttonschinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonschinfo.Click
        TabControlMain.SelectedTab = TabPageschinfo
        ButtonCourse.BackColor = Color.Transparent
        ButtonDYK.BackColor = Color.Transparent
        Buttoncgpa.BackColor = Color.Transparent
        Buttonimposchstaffs.BackColor = Color.Transparent
        Buttonschinfo.BackColor = Color.WhiteSmoke
        ' Buttontimetable.BackColor = Color.Transparent
        ' Buttonresult.BackColor = Color.Transparent

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
    Private Sub ButtonEXIT_Click(sender As Object, e As EventArgs) Handles ButtonEXIT.Click
        Call klose()
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
    Private Sub Buttonbio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbio.Click
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
    Private Sub Buttonintro_Click(sender As Object, e As EventArgs) Handles Buttonintro.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\seminar topic_Catalytic Reduction of vehicular emission pollution, techinical seminar.pdf"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\seminar topic_Catalytic Reduction of vehicular emission pollution, techinical seminar.pdf"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\IMMO TAL.pdf"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\IMMO TAL.pdf"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        System.Diagnostics.Process.Start("www.tce.com")
    End Sub

    Private Sub ButtonL100_Click(sender As Object, e As EventArgs) Handles ButtonL100.Click
        TabControlCourse.SelectedTab = TabPagelevel100
        ButtonL100.BackColor = Color.WhiteSmoke
        ButtonL200.BackColor = Color.Transparent
        ButtonL300.BackColor = Color.Transparent
        ButtonL400.BackColor = Color.Transparent
        ButtonL500.BackColor = Color.Transparent
        If (ButtonF100.BackColor = Color.Transparent Or ButtonF100.BackColor = Color.WhiteSmoke) And Buttons100.BackColor = Color.Transparent Then
            TabControlL100.SelectedTab = TabPageF100
            ButtonF100.BackColor = Color.WhiteSmoke
            Buttons100.BackColor = Color.Transparent
        ElseIf (ButtonF100.BackColor = Color.Transparent) And Buttons100.BackColor = Color.WhiteSmoke Then
            TabControlL100.SelectedTab = TabPageS100
            ButtonF100.BackColor = Color.Transparent
            Buttons100.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub ButtonL200_Click(sender As Object, e As EventArgs) Handles ButtonL200.Click
        TabControlCourse.SelectedTab = TabPagelevel200
        ButtonL100.BackColor = Color.Transparent
        ButtonL200.BackColor = Color.WhiteSmoke
        ButtonL300.BackColor = Color.Transparent
        ButtonL400.BackColor = Color.Transparent
        ButtonL500.BackColor = Color.Transparent
        If (ButtonF200.BackColor = Color.Transparent Or ButtonF200.BackColor = Color.WhiteSmoke) And ButtonS200.BackColor = Color.Transparent Then
            TabControlL200.SelectedTab = TabPageF200
            ButtonF200.BackColor = Color.WhiteSmoke
            ButtonS200.BackColor = Color.Transparent
        ElseIf (ButtonF200.BackColor = Color.Transparent) And ButtonS200.BackColor = Color.WhiteSmoke Then
            TabControlL200.SelectedTab = TabPageS200
            ButtonF200.BackColor = Color.Transparent
            ButtonS200.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub ButtonL300_Click(sender As Object, e As EventArgs) Handles ButtonL300.Click
        TabControlCourse.SelectedTab = TabPagelevel300
        ButtonL100.BackColor = Color.Transparent
        ButtonL200.BackColor = Color.Transparent
        ButtonL300.BackColor = Color.WhiteSmoke
        ButtonL400.BackColor = Color.Transparent
        ButtonL500.BackColor = Color.Transparent
        If (ButtonF300.BackColor = Color.Transparent Or ButtonF300.BackColor = Color.WhiteSmoke) And ButtonS300.BackColor = Color.Transparent Then
            TabControlL300.SelectedTab = TabPageF300
            ButtonF300.BackColor = Color.WhiteSmoke
            ButtonS300.BackColor = Color.Transparent
        ElseIf (ButtonF300.BackColor = Color.Transparent) And ButtonS300.BackColor = Color.WhiteSmoke Then
            TabControlL300.SelectedTab = TabPageS300
            ButtonF300.BackColor = Color.Transparent
            ButtonS300.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub ButtonL400_Click(sender As Object, e As EventArgs) Handles ButtonL400.Click
        TabControlCourse.SelectedTab = TabPagelevel400
        ButtonL100.BackColor = Color.Transparent
        ButtonL200.BackColor = Color.Transparent
        ButtonL300.BackColor = Color.Transparent
        ButtonL400.BackColor = Color.WhiteSmoke
        ButtonL500.BackColor = Color.Transparent
        If (ButtonF400.BackColor = Color.Transparent Or ButtonF400.BackColor = Color.WhiteSmoke) And ButtonS400.BackColor = Color.Transparent Then
            TabControlL100.SelectedTab = TabPageF400
            ButtonF400.BackColor = Color.WhiteSmoke
            ButtonS400.BackColor = Color.Transparent
        ElseIf (ButtonF400.BackColor = Color.Transparent) And ButtonS400.BackColor = Color.WhiteSmoke Then
            TabControlL400.SelectedTab = TabPageS400
            ButtonF400.BackColor = Color.Transparent
            ButtonS400.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub ButtonL500_Click(sender As Object, e As EventArgs) Handles ButtonL500.Click
        TabControlCourse.SelectedTab = TabPagelevel500
        ButtonL100.BackColor = Color.Transparent
        ButtonL200.BackColor = Color.Transparent
        ButtonL300.BackColor = Color.Transparent
        ButtonL400.BackColor = Color.Transparent
        ButtonL500.BackColor = Color.WhiteSmoke
        If (ButtonF500.BackColor = Color.Transparent Or ButtonF500.BackColor = Color.WhiteSmoke) And ButtonS500.BackColor = Color.Transparent Then
            TabControlL500.SelectedTab = TabPageF500
            ButtonF500.BackColor = Color.WhiteSmoke
            ButtonS500.BackColor = Color.Transparent
        ElseIf (ButtonF500.BackColor = Color.Transparent) And ButtonS500.BackColor = Color.WhiteSmoke Then
            TabControlL500.SelectedTab = TabPageS500
            ButtonF500.BackColor = Color.Transparent
            ButtonS500.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub ButtonF100_Click(sender As Object, e As EventArgs) Handles ButtonF100.Click
        TabControlL100.SelectedTab = TabPageF100
        ButtonF100.BackColor = Color.WhiteSmoke
        Buttons100.BackColor = Color.Transparent
    End Sub

    Private Sub Buttons100_Click(sender As Object, e As EventArgs) Handles Buttons100.Click
        TabControlL100.SelectedTab = TabPageS100
        Buttons100.BackColor = Color.WhiteSmoke
        ButtonF100.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonF200_Click(sender As Object, e As EventArgs) Handles ButtonF200.Click
        TabControlL200.SelectedTab = TabPageF200
        ButtonF200.BackColor = Color.WhiteSmoke
        ButtonS200.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonS200_Click(sender As Object, e As EventArgs) Handles ButtonS200.Click
        TabControlL200.SelectedTab = TabPageS200
        ButtonS200.BackColor = Color.WhiteSmoke
        ButtonF200.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonF300_Click(sender As Object, e As EventArgs) Handles ButtonF300.Click
        TabControlL300.SelectedTab = TabPageF300
        ButtonF300.BackColor = Color.WhiteSmoke
        ButtonS300.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonS300_Click(sender As Object, e As EventArgs) Handles ButtonS300.Click
        TabControlL300.SelectedTab = TabPageS300
        ButtonS300.BackColor = Color.WhiteSmoke
        ButtonF300.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonF400_Click(sender As Object, e As EventArgs) Handles ButtonF400.Click
        TabControlL400.SelectedTab = TabPageF400
        ButtonF400.BackColor = Color.WhiteSmoke
        ButtonS400.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonS400_Click(sender As Object, e As EventArgs) Handles ButtonS400.Click
        TabControlL400.SelectedTab = TabPageS400
        ButtonS400.BackColor = Color.WhiteSmoke
        ButtonF400.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonF500_Click(sender As Object, e As EventArgs) Handles ButtonF500.Click
        TabControlL500.SelectedTab = TabPageF500
        ButtonF500.BackColor = Color.WhiteSmoke
        ButtonS500.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonS500_Click(sender As Object, e As EventArgs) Handles ButtonS500.Click
        TabControlL500.SelectedTab = TabPageS500
        ButtonS500.BackColor = Color.WhiteSmoke
        ButtonF500.BackColor = Color.Transparent

    End Sub
    Private Sub Whiskey()
        coursecode = ""
        coursename = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Course1ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course1ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Course1ButtonF2_Click(sender As Object, e As EventArgs) Handles Course1ButtonF2.Click
        Call Whiskey() 'reset
        Dim test As String = Course1ButtonF2.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call coursenamesorter()
        TabControlMain.SelectedTab = TabPageCourse
        ButtonCourse.BackColor = Color.WhiteSmoke
        ButtonL100.BackColor = Color.WhiteSmoke
        ButtonF100.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Course8ButtonF1_Click(sender As Object, e As EventArgs) Handles Course8ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course8ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Course7ButtonF1_Click(sender As Object, e As EventArgs) Handles Course7ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course7ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Course6ButtonF1_Click(sender As Object, e As EventArgs) Handles Course6ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course6ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Course5ButtonF1_Click(sender As Object, e As EventArgs) Handles Course5ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course5ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Course4ButtonF1_Click(sender As Object, e As EventArgs) Handles Course4ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course4ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Course3ButtonF1_Click(sender As Object, e As EventArgs) Handles Course3ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course3ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Course2ButtonF1_Click(sender As Object, e As EventArgs) Handles Course2ButtonF1.Click
        Call Whiskey() 'reset
        Dim test As String = Course2ButtonF1.Text
        Dim name As String
        Dim code As String
        Dim namecharacter As Char
        Dim codecharacter As Char
        For i = 0 To test.Length - 12
            namecharacter = test.Chars(i)
            name = name + namecharacter
        Next
        For i = test.Length - 9 To test.Length - 1
            codecharacter = test.Chars(i)
            code = code + codecharacter
        Next
        coursecode = code
        coursename = name
        Call thecoursecode()
        Call q()
    End Sub

    Private Sub Buttoncgpa_Click(sender As Object, e As EventArgs) Handles Buttoncgpa.Click
        cgpa.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonEXIT_MouseEnter(sender As Object, e As EventArgs) Handles ButtonEXIT.MouseEnter
        LabelClose.Show()
    End Sub

    Private Sub ButtonEXIT_MouseLeave(sender As Object, e As EventArgs) Handles ButtonEXIT.MouseLeave
        LabelClose.Hide()
    End Sub
    Private Sub PictureBoxHOME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxHOME.Click, Labelusername.Click
        Dim fort As New Smart
        fort.ShowDialog()
    End Sub
    Private Sub Labelusername_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelusername.MouseEnter, PictureBoxHOME.MouseEnter
        Labelchangename.Show()
    End Sub

    Private Sub Labelusername_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelusername.MouseLeave, PictureBoxHOME.MouseLeave
        Labelchangename.Hide()
    End Sub
End Class