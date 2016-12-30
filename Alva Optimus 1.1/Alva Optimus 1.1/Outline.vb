Public Class Outline
    Public labeltimer2 As New Label
    Dim Chm1301topic1check1, Chm1301topic1check2, Chm1301topic1check3, Chm1301topic1check4, Chm1301topic1check5, Chm1301topic1check6, Chm1301topic1check7, Chm1301topic1check8 As Integer
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
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageCHM1301
            TabControlCHM1301.SelectedTab = TabPageCHM1301Outline
        End If
        If coursecode = "CHM 131.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageCHM1312
        End If
        If coursecode = "CHM 132.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageCHM1322
        End If
        If coursecode = "ENG 102.1" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageENG1021
        End If
        If coursecode = "ENG 102.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageENG1022
        End If
        If coursecode = "PHY 102.1" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPagePHY1021
        End If
        If coursecode = "PHY 102.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPagePHY1022
        End If
        If coursecode = "PHY 101.1" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPagePHY1011
        End If
        If coursecode = "PHY 112.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPagePHY1122
        End If
        If coursecode = "ENG 103.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageENG1032
        End If
        If coursecode = "ENG 104.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageENG1042
        End If
        If coursecode = "GES 103.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageGES1032
        End If
        If coursecode = "GES 101.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageGES1012
        End If
        If coursecode = "GES 100.1" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageGES1001
        End If
        If coursecode = "GES 102.1" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageGES1021
        End If
        If coursecode = "MTH 124.2" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageMTH1242
        End If
        If coursecode = "MTH 120.1" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageMTH1201
        End If
        If coursecode = "MTH 110.1" Then
            TabControllevels.SelectedTab = TabPagelevel100
            Level100TabControlCOURSES.SelectedTab = TabPageMTH1101
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
    Private Sub checkmate()
        If CheckBoxCHM1301topic1NOTE1.Checked = True Then
            CheckBoxCHM1301topic1NOTE1.Text = "READ"
            Chm1301topic1check1 = 1
        Else
            CheckBoxCHM1301topic1NOTE1.Text = "UNREAD"
            Chm1301topic1check1 = 0
        End If
        If CheckBoxCHM1301topic1NOTE2.Checked = True Then
            CheckBoxCHM1301topic1NOTE2.Text = "READ"
            Chm1301topic1check2 = 1
        Else
            CheckBoxCHM1301topic1NOTE2.Text = "UNREAD"
            Chm1301topic1check2 = 0
        End If
        If CheckBoxCHM1301topic1NOTE3.Checked = True Then
            CheckBoxCHM1301topic1NOTE3.Text = "READ"
            Chm1301topic1check3 = 1
        Else
            CheckBoxCHM1301topic1NOTE3.Text = "UNREAD"
            Chm1301topic1check3 = 0
        End If
        If CheckBoxCHM1301topic1NOTE4.Checked = True Then
            CheckBoxCHM1301topic1NOTE4.Text = "READ"
            Chm1301topic1check4 = 1
        Else
            CheckBoxCHM1301topic1NOTE4.Text = "UNREAD"
            Chm1301topic1check4 = 0
        End If
        If CheckBoxCHM1301topic1NOTE5.Checked = True Then
            CheckBoxCHM1301topic1NOTE5.Text = "READ"
            Chm1301topic1check5 = 1
        Else
            CheckBoxCHM1301topic1NOTE5.Text = "UNREAD"
            Chm1301topic1check5 = 0
        End If
        If CheckBoxCHM1301topic1NOTE6.Checked = True Then
            CheckBoxCHM1301topic1NOTE6.Text = "READ"
            Chm1301topic1check6 = 1
        Else
            CheckBoxCHM1301topic1NOTE6.Text = "UNREAD"
            Chm1301topic1check6 = 0
        End If
        If CheckBoxCHM1301topic1NOTE7.Checked = True Then
            CheckBoxCHM1301topic1NOTE7.Text = "READ"
            Chm1301topic1check7 = 1
        Else
            CheckBoxCHM1301topic1NOTE7.Text = "UNREAD"
            Chm1301topic1check7 = 0
        End If
        If CheckBoxCHM1301topic1NOTE8.Checked = True Then
            CheckBoxCHM1301topic1NOTE8.Text = "READ"
            Chm1301topic1check8 = 1
        Else
            CheckBoxCHM1301topic1NOTE8.Text = "UNREAD"
            Chm1301topic1check8 = 0
        End If
        'progress thus far
        Dim checkmate As Integer
        checkmate = Chm1301topic1check1 + Chm1301topic1check2 + Chm1301topic1check3 + Chm1301topic1check4 + Chm1301topic1check5 + Chm1301topic1check6 + Chm1301topic1check7 + Chm1301topic1check8
        LabelCHM1301READ.Text = checkmate
        Dim ha As Double
        Dim ja As Integer = Val(LabelCHM1301topic1TotalNote.Text)
        ha = (checkmate / ja) * 100
        ProgressBarCHMtopic1.Value = ha
    End Sub
    Private Sub LabelOutlineCHM1301Course1_Click(sender As Object, e As EventArgs) Handles LabelOutlineCHM1301Course1.Click, LabelOutlineCHM1301Course2.Click, LabelOutlineCHM1301Course3.Click, LabelOutlineCHM1301Course4.Click, LabelOutlineCHM1301Course5.Click, LabelOutlineCHM1301Course6.Click, LabelOutlineCHM1301Course7.Click, LabelOutlineCHM1301Course8.Click, LabelOutlineCHM1301Course9.Click, LabelOutlineCHM1301Course10.Click, LabelOutlineCHM1301Course11.Click, LabelOutlineCHM1301Course12.Click, LabelOutlineCHM1301Course13.Click, LabelOutlineCHM1301Course14.Click, LabelOutlineCHM1301Course15.Click, LabelOutlineCHM1301Course16.Click, LabelOutlineCHM1301Course17.Click, LabelOutlineCHM1301Course18.Click, LabelOutlineCHM1301Course19.Click, LabelOutlineCHM1301Course20.Click
        TabControlCHM1301.SelectedTab = TabPageCHM1301Outline
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Subject.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Call klose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call center()
        Dim a As Integer = Val(labeltimer2.Text)
        a = a + 1
        Call levels()
        If a = 1 Then
            Timer1.Enabled = False
            'MsgBox(a):- my helper
        End If
    End Sub

    Private Sub CheckBoxCHMtopic1NOTE1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCHM1301topic1NOTE1.CheckedChanged, CheckBoxCHM1301topic1NOTE2.CheckedChanged, CheckBoxCHM1301topic1NOTE3.CheckedChanged, CheckBoxCHM1301topic1NOTE4.CheckedChanged, CheckBoxCHM1301topic1NOTE5.CheckedChanged, CheckBoxCHM1301topic1NOTE6.CheckedChanged, CheckBoxCHM1301topic1NOTE7.CheckedChanged, CheckBoxCHM1301topic1NOTE8.CheckedChanged
        Call checkmate()
    End Sub

    Private Sub ButtonCHM1301topic6_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic6.Click
        TabControlCHM1301.SelectedTab = TabPageCHM1301Course6
    End Sub

    Private Sub ButtonCHM1301topic5_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic5.Click
        TabControlCHM1301.SelectedTab = TabPageCHM1301Course5
    End Sub

    Private Sub ButtonCHM1301topic4_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic4.Click
        TabControlCHM1301.SelectedTab = TabPageCHM1301Course4
    End Sub

    Private Sub ButtonCHM1301topic3_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic3.Click
        TabControlCHM1301.SelectedTab = TabPageCHM1301Course3
    End Sub

    Private Sub ButtonCHM1301topic2_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic2.Click
        TabControlCHM1301.SelectedTab = TabPageCHM1301Course2
    End Sub

    Private Sub ButtonCHM1301topic1_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic1.Click
        TabControlCHM1301.SelectedTab = TabPageCHM1301Course1
    End Sub

    Private Sub ButtonCHM1301topic1PPT_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic1PPT.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\Introduction to chemistry.ppsx"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\Introduction to chemistry.ppsx"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub

    Private Sub ButtonCHM1301topic2ppt_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic2ppt.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\Chydum.ppsx"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\Chydum.ppsx"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub

    Private Sub ButtonCHM1301topic3ppt_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic3ppt.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\Chydum.pptx"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\Chydum.pptx"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub

    Private Sub ButtonCHM1301topic4ppt_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic4ppt.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\Defense slide_U2010_3030010.ppsx"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\Defense slide_U2010_3030010.ppsx"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub

    Private Sub ButtonCHM1301topic5ppt_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic5ppt.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\Chydum.pdf"
            System.Diagnostics.Process.Start(cha)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\Chydum.pdf"
            System.Diagnostics.Process.Start(cha)
        End Try
    End Sub

    Private Sub ButtonCHM1301topic6ppt_Click(sender As Object, e As EventArgs) Handles ButtonCHM1301topic6ppt.Click
       
    End Sub
End Class