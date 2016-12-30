Public Class Subject
    Public labeltimer As New Label
    Private Sub Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call colors()
        Call levels()
        Call center()
        'Labelcoursecode.Left = (Labelcoursecode.Parent.Width / 2) - (Labelcoursecode.Width / 2)
        'Labelcoursename.Left = (Labelcoursename.Parent.Width / 2) - (Labelcoursename.Width / 2)
        TabControlMain.SelectedTab = TabPageUpdate
        Timer1.Enabled = True
        ButtonNews.BackColor = Color.White
        ButtonOutline.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.Transparent
        ButtonAssignment.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Call klose()
    End Sub

    Private Sub ButtonNews_Click(sender As Object, e As EventArgs) Handles ButtonNews.Click
        TabControlMain.SelectedTab = TabPageUpdate
        ButtonNews.BackColor = Color.White
        ButtonOutline.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.Transparent
        ButtonAssignment.BackColor = Color.Transparent
    End Sub

    Private Sub Buttonprofile_Click(sender As Object, e As EventArgs) Handles Buttonprofile.Click
        TabControlMain.SelectedTab = TabPageProfile
        ButtonNews.BackColor = Color.Transparent
        ButtonOutline.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.White
        ButtonAssignment.BackColor = Color.Transparent
        TabControlProfile.SelectedTab = TabPageSchemeOfWork
        ButtonScheme.BackColor = Color.White
        ButtonEXPECT.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.Transparent
        ButtonCA.BackColor = Color.Transparent
        ButtonLect.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonAssignment_Click(sender As Object, e As EventArgs) Handles ButtonAssignment.Click
        TabControlMain.SelectedTab = TabPageAssignment
        ButtonNews.BackColor = Color.Transparent
        ButtonOutline.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.Transparent
        ButtonAssignment.BackColor = Color.White
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub levels()
        Call level100()
        Call level200()
        Call level300()
        Call level400()
        Call level500()
        Call level600()
    End Sub
    Private Sub level100()
        If coursecode = "CHM 130.1" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageCHM1301
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageCHM1301
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageCHM1301
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageCHM1301
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageCHM1301
            '  MsgBox("chm")
        End If
        If coursecode = "CHM 131.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageCHM1312
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageCHM1312
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageCHM1312
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageCHM1312
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageCHM1312
        End If
        If coursecode = "CHM 132.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageCHM1322
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageCHM1322
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageCHM1322
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageCHM1322
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageCHM1322
        End If
        If coursecode = "ENG 102.1" Then
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageENG1021
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageENG1021
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageENG1021
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageENG1021
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageENG1021
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            ' MsgBox("eng")
        End If
        If coursecode = "ENG 102.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageENG1022
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageENG1022
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageENG1022
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageENG1022
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageENG1022
        End If
        If coursecode = "PHY 102.1" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPagePHY1021
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPagePHY1021
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPagePHY1021
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPagePHY1021
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPagePHY1021
            '     MsgBox("phyl")
        End If
        If coursecode = "PHY 102.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPagePHY1022
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPagePHY1022
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPagePHY1022
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPagePHY1022
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPagePHY1022
        End If
        If coursecode = "PHY 101.1" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPagePHY1011
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPagePHY1011
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPagePHY1011
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPagePHY1011
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPagePHY1011
            '   MsgBox("phyT")
        End If
        If coursecode = "PHY 112.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPagePHY1122
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPagePHY1122
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPagePHY1122
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPagePHY1122
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPagePHY1122
        End If
        If coursecode = "ENG 103.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageENG1032
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageENG1032
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageENG1032
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageENG1032
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageENG1032

        End If
        If coursecode = "ENG 104.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageENG1042
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageENG1042
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageENG1042
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageENG1042
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageENG1042

        End If
        If coursecode = "GES 103.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageGES1032
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageGES1032
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageGES1032
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageGES1032
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageGES1032
        End If
        If coursecode = "GES 101.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageGES1012
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageGES1012
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageGES1012
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageGES1012
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageGES1012
        End If
        If coursecode = "GES 100.1" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageGES1001
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageGES1001
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageGES1001
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageGES1001
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageGES1001
            '    MsgBox("ges10")
        End If
        If coursecode = "GES 102.1" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageGES1021
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageGES1021
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageGES1021
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageGES1021
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageGES1021
            '   MsgBox("ges34")
        End If
        If coursecode = "MTH 124.2" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageMTH1201
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageMTH1201
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageMTH1201
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageMTH1201
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageMTH1201
        End If
        If coursecode = "MTH 120.1" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageMTH1242
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageMTH1242
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageMTH1242
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageMTH1242
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageMTH1242
            ' MsgBox("math")
        End If
        If coursecode = "MTH 110.1" Then
            CATabControl.SelectedTab = CATabPageL100
            ExpectationTabControl.SelectedTab = ExpectationTabpageL100
            SCHEMEOFWORKTabControl.SelectedTab = SCHEMETabPageL100
            LecturerTabControl.SelectedTab = LecturerTabPageL100
            MaterialTabControl.SelectedTab = MaterialTabPageL100
            CAL100TabControlCOURSES.SelectedTab = CAL100TabPageMTH1101
            SchemeL100TabControlCOURSES.SelectedTab = SchemeL100TabPageMTH1101
            LECTL100TabControlCOURSES.SelectedTab = LECTL100TabPageMTH1101
            ExpectL100TabControlCOURSES.SelectedTab = ExpectL100TabPageMTH1101
            MaterialL100TabControlCOURSES.SelectedTab = MaterialL100TabPageMTH1101
            ' MsgBox("mat")
        End If

    End Sub
    Private Sub level200()
      

    End Sub
    Private Sub level300()
      

    End Sub
    Private Sub level400()
      

    End Sub
    Private Sub level500()
       
    End Sub
    Private Sub level600()

    End Sub

    Private Sub ButtonLect_Click(sender As Object, e As EventArgs) Handles ButtonLect.Click
        TabControlProfile.SelectedTab = TabPageLecturer
        ButtonScheme.BackColor = Color.Transparent
        ButtonEXPECT.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.Transparent
        ButtonCA.BackColor = Color.Transparent
        ButtonLect.BackColor = Color.White
    End Sub

    Private Sub ButtonMaterial_Click(sender As Object, e As EventArgs) Handles ButtonMaterial.Click
        TabControlProfile.SelectedTab = TabPageMaterial
        ButtonScheme.BackColor = Color.Transparent
        ButtonEXPECT.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.White
        ButtonCA.BackColor = Color.Transparent
        ButtonLect.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonEXPECT_Click(sender As Object, e As EventArgs) Handles ButtonEXPECT.Click
        TabControlProfile.SelectedTab = TabPageExpectation
        ButtonScheme.BackColor = Color.Transparent
        ButtonEXPECT.BackColor = Color.White
        ButtonMaterial.BackColor = Color.Transparent
        ButtonCA.BackColor = Color.Transparent
        ButtonLect.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonCA_Click(sender As Object, e As EventArgs) Handles ButtonCA.Click
        TabControlProfile.SelectedTab = TabPageCA
        ButtonScheme.BackColor = Color.Transparent
        ButtonEXPECT.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.Transparent
        ButtonCA.BackColor = Color.White
        ButtonLect.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonScheme_Click(sender As Object, e As EventArgs) Handles ButtonScheme.Click
        TabControlProfile.SelectedTab = TabPageSchemeOfWork
        ButtonScheme.BackColor = Color.White
        ButtonEXPECT.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.Transparent
        ButtonCA.BackColor = Color.Transparent
        ButtonLect.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call center()
        Dim a As Integer = Val(labeltimer.Text)
        a = a + 1
        ButtonNews.BackColor = Color.White
        ButtonOutline.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.Transparent
        ButtonAssignment.BackColor = Color.Transparent
        TabControlMain.SelectedTab = TabPageUpdate
        Call levels()
        If a = 1 Then
            Timer1.Enabled = False
            'MsgBox(a):- my helper
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCHM13011.LinkClicked
        System.Diagnostics.Process.Start("https://www.google.com/search?newwindow=1&client=opera&hs=yQe&q=equation+in+technical+presentation&oq=equation+in+technical+presentat&gs_l=serp.3.0.33i21.75771.91493.0.94771.37.33.0.2.2.0.512.4832.3-9j3j1.13.0....0...1c.1.64.serp..25.12.3836.i8ml-_7ekG8")
    End Sub

    Private Sub ButtonMaterial1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCHM1301Mat1.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\ACID.pdf"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\ACID.pdf"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub

    Private Sub ButtonOutline_Click(sender As Object, e As EventArgs) Handles ButtonOutline.Click
        Outline.Show()
        Me.Hide()
    End Sub
    Private Sub Labelusername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labelusername.Click
        Dim fort As New Smart
        fort.ShowDialog()
    End Sub

    Private Sub PictureBoxCHM130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxCHM130.Click
        Call Labelusername_Click(sender, e)
    End Sub

    Private Sub PictureBoxCHM130_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxCHM130.MouseEnter, Labelusername.MouseEnter
        Labelchangename.Show()
    End Sub

    Private Sub PictureBoxCHM130_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxCHM130.MouseLeave, Labelusername.MouseLeave
        Labelchangename.Hide()
    End Sub

End Class