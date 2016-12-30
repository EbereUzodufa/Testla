Public Class cgpa
    Dim settings As New My.MySettings
    Dim maxim As Integer = 24 'this the maximum number of total credit unit per semester
    'minimum total credit per first semester from 1-5
    Dim maximf1 As Integer = 20
    Dim maximf2 As Integer = 21
    Dim maximf3 As Integer = 21
    Dim maximf4 As Integer = 21
    Dim maximf5 As Integer = 18
    'minimum total credit per second semester from 1-5
    Dim maxims1 As Integer = 22
    Dim maxims2 As Integer = 19
    Dim maxims3 As Integer = 19
    Dim maxims4 As Integer = 11
    Dim maxims5 As Integer = 19
    Dim maximcreditunit As Integer = 191 'total cu for the course of study 
    Dim totalsemester As Integer = 10 'total number of semesters
    Dim f100listboxhopename, f200listboxhopename, f300listboxhopename, f400listboxhopename, f500listboxhopename, f600listboxhopename, f700listboxhopename As New ListBox
    Dim f100listboxhopeunit, f200listboxhopeunit, f300listboxhopeunit, f400listboxhopeunit, f500listboxhopeunit, f600listboxhopeunit, f700listboxhopeunit As New ListBox
    Dim s100listboxhopename, s200listboxhopename, s300listboxhopename, s400listboxhopename, s500listboxhopename, s600listboxhopename, s700listboxhopename As New ListBox
    Dim s100listboxhopeunit, s200listboxhopeunit, s300listboxhopeunit, s400listboxhopeunit, s500listboxhopeunit, s600listboxhopeunit, s700listboxhopeunit As New ListBox
    Dim F100labelpt1, F100labelpt2, F100labelpt3, F100labelpt4, F100labelpt5, F100labelpt6, F100labelpt7, F100labelpt8, F100labelpt9, F100labelpt10, F100labelpt11, F100labelpt12, F100labelpt13, F100labelpt14 As New Label
    Dim F200labelpt1, F200labelpt2, F200labelpt3, F200labelpt4, F200labelpt5, F200labelpt6, F200labelpt7, F200labelpt8, F200labelpt9, F200labelpt10, F200labelpt11, F200labelpt12, F200labelpt13, F200labelpt14 As New Label
    Dim F300labelpt1, F300labelpt2, F300labelpt3, F300labelpt4, F300labelpt5, F300labelpt6, F300labelpt7, F300labelpt8, F300labelpt9, F300labelpt10, F300labelpt11, F300labelpt12, F300labelpt13, F300labelpt14 As New Label
    Dim F400labelpt1, F400labelpt2, F400labelpt3, F400labelpt4, F400labelpt5, F400labelpt6, F400labelpt7, F400labelpt8, F400labelpt9, F400labelpt10, F400labelpt11, F400labelpt12, F400labelpt13, F400labelpt14 As New Label
    Dim F500labelpt1, F500labelpt2, F500labelpt3, F500labelpt4, F500labelpt5, F500labelpt6, F500labelpt7, F500labelpt8, F500labelpt9, F500labelpt10, F500labelpt11, F500labelpt12, F500labelpt13, F500labelpt14 As New Label
    Dim F600labelpt1, F600labelpt2, F600labelpt3, F600labelpt4, F600labelpt5, F600labelpt6, F600labelpt7, F600labelpt8, F600labelpt9, F600labelpt10, F600labelpt11, F600labelpt12, F600labelpt13, F600labelpt14 As New Label
    Dim F700labelpt1, F700labelpt2, F700labelpt3, F700labelpt4, F700labelpt5, F700labelpt6, F700labelpt7, F700labelpt8, F700labelpt9, F700labelpt10, F700labelpt11, F700labelpt12, F700labelpt13, F700labelpt14 As New Label
    Dim S100labelpt1, S100labelpt2, S100labelpt3, S100labelpt4, S100labelpt5, S100labelpt6, S100labelpt7, S100labelpt8, S100labelpt9, S100labelpt10, S100labelpt11, S100labelpt12, S100labelpt13, S100labelpt14 As New Label
    Dim S200labelpt1, S200labelpt2, S200labelpt3, S200labelpt4, S200labelpt5, S200labelpt6, S200labelpt7, S200labelpt8, S200labelpt9, S200labelpt10, S200labelpt11, S200labelpt12, S200labelpt13, S200labelpt14 As New Label
    Dim S300labelpt1, S300labelpt2, S300labelpt3, S300labelpt4, S300labelpt5, S300labelpt6, S300labelpt7, S300labelpt8, S300labelpt9, S300labelpt10, S300labelpt11, S300labelpt12, S300labelpt13, S300labelpt14 As New Label
    Dim S400labelpt1, S400labelpt2, S400labelpt3, S400labelpt4, S400labelpt5, S400labelpt6, S400labelpt7, S400labelpt8, S400labelpt9, S400labelpt10, S400labelpt11, S400labelpt12, S400labelpt13, S400labelpt14 As New Label
    Dim S500labelpt1, S500labelpt2, S500labelpt3, S500labelpt4, S500labelpt5, S500labelpt6, S500labelpt7, S500labelpt8, S500labelpt9, S500labelpt10, S500labelpt11, S500labelpt12, S500labelpt13, S500labelpt14 As New Label
    Dim S600labelpt1, S600labelpt2, S600labelpt3, S600labelpt4, S600labelpt5, S600labelpt6, S600labelpt7, S600labelpt8, S600labelpt9, S600labelpt10, S600labelpt11, S600labelpt12, S600labelpt13, S600labelpt14 As New Label
    Dim S700labelpt1, S700labelpt2, S700labelpt3, S700labelpt4, S700labelpt5, S700labelpt6, S700labelpt7, S700labelpt8, S700labelpt9, S700labelpt10, S700labelpt11, S700labelpt12, S700labelpt13, S700labelpt14 As New Label
    Dim f100cu, f200cu, f300cu, f400cu, f500cu, f600cu, f700cu, s100cu, s200cu, s300cu, s400cu, s500cu, s600cu, s700cu As Integer
    Dim f100qp, f200qp, f300qp, f400qp, f500qp, f600qp, f700qp, s100qp, s200qp, s300qp, s400qp, s500qp, s600qp, s700qp As Integer

    Dim cgpa As Double

    'other controls
    Private Sub ButtonEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Call klose()
    End Sub
    Private Sub ButtonEXIT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.MouseEnter
        LabelClose.Show()
    End Sub
    Private Sub ButtonEXIT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.MouseLeave
        LabelClose.Hide()
    End Sub
    Private Sub Buttonback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonback.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub CGPA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A And Labelhello.BackColor = Color.White Then
            TabControlMain.SelectedTab = Tabreal
        End If
    End Sub
    Private Sub CGPA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TabControlMain.SelectedTab = TabPage100
        year1Button.BackColor = Color.WhiteSmoke
        year2Button.BackColor = Color.Transparent
        year3Button.BackColor = Color.Transparent
        year4Button.BackColor = Color.Transparent
        year5Button.BackColor = Color.Transparent
        year6Button.BackColor = Color.Transparent
        year7Button.BackColor = Color.Transparent
        TabControl100.SelectedTab = TabPagefirst100
        ButtonFirst100.BackColor = Color.WhiteSmoke
        '  Call hope()
    End Sub
    Private Sub year1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year1Button.Click
        year1Button.BackColor = Color.WhiteSmoke
        year2Button.BackColor = Color.Transparent
        year3Button.BackColor = Color.Transparent
        year4Button.BackColor = Color.Transparent
        year5Button.BackColor = Color.Transparent
        year6Button.BackColor = Color.Transparent
        year7Button.BackColor = Color.Transparent
        TabControlMain.SelectedTab = TabPage100
        If (ButtonFirst100.BackColor = Color.WhiteSmoke Or ButtonFirst100.BackColor = Color.IndianRed) And Buttonsecond100.BackColor = Color.IndianRed Then
            TabControl100.SelectedTab = TabPagefirst100
            ButtonFirst100.BackColor = Color.WhiteSmoke
            Buttonsecond100.BackColor = Color.IndianRed
        ElseIf ButtonFirst100.BackColor = Color.IndianRed And Buttonsecond100.BackColor = Color.WhiteSmoke Then
            TabControl100.SelectedTab = TabPagesecond100
            ButtonFirst100.BackColor = Color.IndianRed
            Buttonsecond100.BackColor = Color.WhiteSmoke

        End If

    End Sub
    Private Sub year2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year2Button.Click
        If (f100cu > (maximf1 - 1)) And (s100cu > (maxims1 - 1)) Then
            year1Button.BackColor = Color.Transparent
            year2Button.BackColor = Color.WhiteSmoke
            year3Button.BackColor = Color.Transparent
            year4Button.BackColor = Color.Transparent
            year5Button.BackColor = Color.Transparent
            year6Button.BackColor = Color.Transparent
            year7Button.BackColor = Color.Transparent
            TabControlMain.SelectedTab = TabPage200

            If (first200Button.BackColor = Color.WhiteSmoke Or first200Button.BackColor = Color.IndianRed) And second200Button2.BackColor = Color.IndianRed Then
                TabControl200.SelectedTab = TabPagefirst200
                first200Button.BackColor = Color.WhiteSmoke
                second200Button2.BackColor = Color.IndianRed
            ElseIf first200Button.BackColor = Color.IndianRed And second200Button2.BackColor = Color.WhiteSmoke Then
                TabControl200.SelectedTab = TabPagesecond200
                first200Button.BackColor = Color.IndianRed
                second200Button2.BackColor = Color.WhiteSmoke

            End If
            'Call Zeus_Dinero()
        Else
            MsgBox("YOUR 100 LEVEL COURSES ARE NOT COMPLETE", MsgBoxStyle.Information)
        End If


    End Sub
    Private Sub year3Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year3Button.Click

        If (f200cu > (maximf2 - 1)) And (s200cu > (maxims2 - 1)) Then
            year1Button.BackColor = Color.Transparent
            year2Button.BackColor = Color.Transparent
            year3Button.BackColor = Color.WhiteSmoke
            year4Button.BackColor = Color.Transparent
            year5Button.BackColor = Color.Transparent
            year6Button.BackColor = Color.Transparent
            year7Button.BackColor = Color.Transparent
            TabControlMain.SelectedTab = TabPage300

            If (first300Button.BackColor = Color.WhiteSmoke Or first300Button.BackColor = Color.IndianRed) And second300Button.BackColor = Color.IndianRed Then
                TabControl300.SelectedTab = TabPagefirst300
                first300Button.BackColor = Color.WhiteSmoke
                second300Button.BackColor = Color.IndianRed
            ElseIf first300Button.BackColor = Color.IndianRed And second300Button.BackColor = Color.WhiteSmoke Then
                TabControl300.SelectedTab = TabPagesecond300
                first300Button.BackColor = Color.IndianRed
                second300Button.BackColor = Color.WhiteSmoke

            End If
            'Call Zeus_Dinero()
        Else
            MsgBox("YOUR 200 LEVEL COURSES ARE NOT COMPLETE", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub year4Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year4Button.Click

        If (f300cu > (maximf3 - 1)) And (s300cu > (maxims3 - 1)) Then
            year1Button.BackColor = Color.Transparent
            year2Button.BackColor = Color.Transparent
            year3Button.BackColor = Color.Transparent
            year4Button.BackColor = Color.WhiteSmoke
            year5Button.BackColor = Color.Transparent
            year6Button.BackColor = Color.Transparent
            year7Button.BackColor = Color.Transparent
            TabControlMain.SelectedTab = TabPage400

            If (first400Button.BackColor = Color.WhiteSmoke Or first400Button.BackColor = Color.IndianRed) And second400Button.BackColor = Color.IndianRed Then
                TabControl400.SelectedTab = TabPagefirst400
                first400Button.BackColor = Color.WhiteSmoke
                second400Button.BackColor = Color.IndianRed
            ElseIf first400Button.BackColor = Color.IndianRed And second400Button.BackColor = Color.WhiteSmoke Then
                TabControl400.SelectedTab = TabPagesecond400
                first400Button.BackColor = Color.IndianRed
                second400Button.BackColor = Color.WhiteSmoke

            End If
            '   Call Zeus_Dinero()
        Else
            MsgBox("YOUR 300 LEVEL COURSES ARE NOT COMPLETE", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub year5Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year5Button.Click

        If (f400cu > (maximf4 - 1)) And (s400cu > (maxims4 - 1)) Then
            year1Button.BackColor = Color.Transparent
            year2Button.BackColor = Color.Transparent
            year3Button.BackColor = Color.Transparent
            year4Button.BackColor = Color.Transparent
            year5Button.BackColor = Color.WhiteSmoke
            year6Button.BackColor = Color.Transparent
            year7Button.BackColor = Color.Transparent
            TabControlMain.SelectedTab = TabPage500

            If (first500Button.BackColor = Color.WhiteSmoke Or first500Button.BackColor = Color.IndianRed) And second500Button.BackColor = Color.IndianRed Then
                TabControl500.SelectedTab = TabPagefirst500
                first500Button.BackColor = Color.WhiteSmoke
                second500Button.BackColor = Color.IndianRed
            ElseIf first500Button.BackColor = Color.IndianRed And second500Button.BackColor = Color.WhiteSmoke Then
                TabControl500.SelectedTab = TabPagesecond500
                first500Button.BackColor = Color.IndianRed
                second500Button.BackColor = Color.WhiteSmoke

            End If
            ' Call Zeus_Dinero()
        Else
            MsgBox("YOUR 400 LEVEL COURSES ARE NOT COMPLETE", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub year6Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year6Button.Click
        If (f100cu > (maximf1 - 1)) And (s100cu > (maxims1 - 1)) Then
            year1Button.BackColor = Color.Transparent
            year2Button.BackColor = Color.Transparent
            year3Button.BackColor = Color.Transparent
            year4Button.BackColor = Color.Transparent
            year5Button.BackColor = Color.Transparent
            year6Button.BackColor = Color.WhiteSmoke
            year7Button.BackColor = Color.Transparent
            TabControlMain.SelectedTab = TabPage600
            If (first600Button.BackColor = Color.WhiteSmoke Or first600Button.BackColor = Color.IndianRed) And second600Button.BackColor = Color.IndianRed Then
                TabControl600.SelectedTab = TabPagefirst600
                first600Button.BackColor = Color.WhiteSmoke
                second600Button.BackColor = Color.IndianRed
            ElseIf first600Button.BackColor = Color.IndianRed And second600Button.BackColor = Color.WhiteSmoke Then
                TabControl600.SelectedTab = TabPagesecond600
                first600Button.BackColor = Color.IndianRed
                second600Button.BackColor = Color.WhiteSmoke
            End If
        Else
            MsgBox("YOUR 500 LEVEL COURSES ARE NOT COMPLETE", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub year7Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year7Button.Click
        If (f200cu > (maximf2 - 1)) And (s200cu > (maxims2 - 1)) Then
            year1Button.BackColor = Color.Transparent
            year2Button.BackColor = Color.Transparent
            year3Button.BackColor = Color.Transparent
            year4Button.BackColor = Color.Transparent
            year5Button.BackColor = Color.Transparent
            year6Button.BackColor = Color.Transparent
            year7Button.BackColor = Color.WhiteSmoke
            TabControlMain.SelectedTab = TabPage700

            If (first700Button.BackColor = Color.WhiteSmoke Or first700Button.BackColor = Color.IndianRed) And second700Button.BackColor = Color.IndianRed Then
                TabControl700.SelectedTab = TabPagefirst700
                first700Button.BackColor = Color.WhiteSmoke
                second700Button.BackColor = Color.IndianRed
            ElseIf first700Button.BackColor = Color.IndianRed And second700Button.BackColor = Color.WhiteSmoke Then
                TabControl700.SelectedTab = TabPagesecond700
                first700Button.BackColor = Color.IndianRed
                second700Button.BackColor = Color.WhiteSmoke

            End If
        Else
            MsgBox("YOUR 500 LEVEL COURSES ARE NOT COMPLETE", MsgBoxStyle.Information)
        End If


    End Sub
    Private Sub ButtonFirst100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFirst100.Click
        ButtonFirst100.BackColor = Color.WhiteSmoke
        Buttonsecond100.BackColor = Color.IndianRed
        TabControl100.SelectedTab = TabPagefirst100
        YEAR1SEMESTERLabel.Text = "FIRST SEMESTER CGPA IS"
        y100TOTALCUlabel.Text = f100cu
        y100TOTALQPlabel.Text = f100qp
        Label100GPA.Text = Math.Round(f100qp / f100cu, 2)
    End Sub
    Private Sub Buttonsecond100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsecond100.Click
        Buttonsecond100.BackColor = Color.WhiteSmoke
        ButtonFirst100.BackColor = Color.IndianRed
        TabControl100.SelectedTab = TabPagesecond100
        YEAR1SEMESTERLabel.Text = "SECOND SEMESTER CGPA IS"
        y100TOTALCUlabel.Text = s100cu
        y100TOTALQPlabel.Text = s100qp
        Label100GPA.Text = Math.Round(s100qp / s100cu, 2)
        'Call Zeus_Dinero()
    End Sub
    Private Sub first200Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first200Button.Click
        first200Button.BackColor = Color.WhiteSmoke
        second200Button2.BackColor = Color.IndianRed
        TabControl200.SelectedTab = TabPagefirst200
        YEAR2SEMESTERLabel.Text = "FIRST SEMESTER CGPA IS"
        y200TOTALCUlabel.Text = f200cu
        y200TOTALQPlabel.Text = f200qp
        Label200GPA.Text = Math.Round(f200qp / f200cu, 2)
        ' Call Zeus_Dinero()
    End Sub
    Private Sub second200Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second200Button2.Click
        first200Button.BackColor = Color.IndianRed
        second200Button2.BackColor = Color.WhiteSmoke
        TabControl200.SelectedTab = TabPagesecond200
        YEAR2SEMESTERLabel.Text = "SECOND SEMESTER CGPA IS"
        y200TOTALCUlabel.Text = s200cu
        y200TOTALQPlabel.Text = s200qp
        Label200GPA.Text = Math.Round(s200qp / s200cu, 2)
        '  Call Zeus_Dinero()
    End Sub
    Private Sub first300Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first300Button.Click
        first300Button.BackColor = Color.WhiteSmoke
        second300Button.BackColor = Color.IndianRed
        TabControl300.SelectedTab = TabPagefirst300
        F300TOTALCUlabel.Show()
        F300TOTALQPlabel.Show()
        Label300GPA.Show()
        s300TOTALCUlabel.Hide()
        s300TOTALQPlabel.Hide()
        Label300GPAs.Hide()
        YEAR3SEMESTERLabel.Text = "FIRST SEMESTER CGPA IS"
        F300TOTALCUlabel.Text = f300cu
        F300TOTALQPlabel.Text = f300qp
        Label300GPA.Text = Math.Round(f300qp / f300cu, 2)
        ' Call Zeus_Dinero()
    End Sub
    Private Sub second300Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second300Button.Click
        first300Button.BackColor = Color.IndianRed
        second300Button.BackColor = Color.WhiteSmoke
        TabControl300.SelectedTab = TabPagesecond300
        F300TOTALCUlabel.Hide()
        F300TOTALQPlabel.Hide()
        Label300GPA.Hide()
        s300TOTALCUlabel.Show()
        s300TOTALQPlabel.Show()
        Label300GPAs.Show()
        YEAR3SEMESTERLabel.Text = "SECOND SEMESTER CGPA IS"
        F300TOTALCUlabel.Text = s300cu
        F300TOTALQPlabel.Text = s300qp
        Label300GPAs.Text = Math.Round(s300qp / s300cu, 2)
        ' Call Zeus_Dinero()
    End Sub
    Private Sub first400Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first400Button.Click
        first400Button.BackColor = Color.WhiteSmoke
        second400Button.BackColor = Color.IndianRed
        TabControl400.SelectedTab = TabPagefirst400
        F400TOTALCUlabel.Show()
        F400TOTALQPlabel.Show()
        Label400GPA.Show()
        s400TOTALCUlabel.Hide()
        s400TOTALQPlabel.Hide()
        Label400GPAs.Hide()
        YEAR4SEMESTERLabel.Text = "FIRST SEMESTER CGPA IS"
        F400TOTALCUlabel.Text = f400cu
        F400TOTALQPlabel.Text = f400qp
        Label400GPA.Text = Math.Round(f400qp / f400cu, 2)
        'Call Zeus_Dinero()
    End Sub
    Private Sub second400Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second400Button.Click
        first400Button.BackColor = Color.IndianRed
        second400Button.BackColor = Color.WhiteSmoke
        TabControl400.SelectedTab = TabPagesecond400
        F400TOTALCUlabel.Hide()
        F400TOTALQPlabel.Hide()
        Label400GPA.Hide()
        s400TOTALCUlabel.Show()
        s400TOTALQPlabel.Show()
        Label400GPAs.Show()
        YEAR4SEMESTERLabel.Text = "SECOND SEMESTER CGPA IS"
        F400TOTALCUlabel.Text = s400cu
        F400TOTALQPlabel.Text = s400qp
        Label400GPAs.Text = Math.Round(s400qp / s400cu, 2)
        '  Call Zeus_Dinero()
    End Sub
    Private Sub first500Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first500Button.Click
        first500Button.BackColor = Color.WhiteSmoke
        second500Button.BackColor = Color.IndianRed
        TabControl500.SelectedTab = TabPagefirst500
        F500TOTALCUlabel.Show()
        F500TOTALQPlabel.Show()
        Label500GPA.Show()
        s500TOTALCUlabel.Hide()
        s500TOTALQPlabel.Hide()
        Label500GPAs.Hide()
        YEAR5SEMESTERLabel.Text = "FIRST SEMESTER CGPA IS"
        F500TOTALCUlabel.Text = f500cu
        F500TOTALQPlabel.Text = f500qp
        Label500GPA.Text = Math.Round(f500qp / f500cu, 2)
        '  Call Zeus_Dinero()
    End Sub
    Private Sub second500Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second500Button.Click
        first500Button.BackColor = Color.IndianRed
        second500Button.BackColor = Color.WhiteSmoke
        TabControl500.SelectedTab = TabPagesecond500
        F500TOTALCUlabel.Hide()
        F500TOTALQPlabel.Hide()
        Label500GPA.Hide()
        s500TOTALCUlabel.Show()
        s500TOTALQPlabel.Show()
        Label500GPAs.Show()
        YEAR5SEMESTERLabel.Text = "SECOND SEMESTER CGPA IS"
        F500TOTALCUlabel.Text = s500cu
        F500TOTALQPlabel.Text = s500qp
        Label500GPAs.Text = s500qp / s500cu
    End Sub
    Private Sub first600Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first600Button.Click
        first600Button.BackColor = Color.WhiteSmoke
        second600Button.BackColor = Color.IndianRed
        TabControl600.SelectedTab = TabPagefirst600
        F600TOTALCUlabel.Show()
        F600TOTALQPlabel.Show()
        Label600GPA.Show()
        s600TOTALCUlabel.Hide()
        s600TOTALQPlabel.Hide()
        Label600GPAs.Hide()
        YEAR6SEMESTERLabel.Text = "FIRST SEMESTER CGPA IS"
        F600TOTALCUlabel.Text = f600cu
        F600TOTALQPlabel.Text = f600qp
        Label600GPA.Text = f600qp / f600cu
    End Sub
    Private Sub second600Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second600Button.Click
        first600Button.BackColor = Color.IndianRed
        second600Button.BackColor = Color.WhiteSmoke
        TabControl600.SelectedTab = TabPagesecond600
        F600TOTALCUlabel.Hide()
        F600TOTALQPlabel.Hide()
        Label600GPA.Hide()
        s600TOTALCUlabel.Show()
        s600TOTALQPlabel.Show()
        Label600GPAs.Show()
        YEAR6SEMESTERLabel.Text = "SECOND SEMESTER CGPA IS"
        F600TOTALCUlabel.Text = s600cu
        F600TOTALQPlabel.Text = s600qp
        Label600GPAs.Text = s600qp / s600cu
    End Sub
    Private Sub first700Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first700Button.Click
        first700Button.BackColor = Color.WhiteSmoke
        second700Button.BackColor = Color.IndianRed
        TabControl700.SelectedTab = TabPagefirst700
        F700TOTALCUlabel.Show()
        F700TOTALQPlabel.Show()
        Label700GPA.Show()
        s700TOTALCUlabel.Hide()
        s700TOTALQPlabel.Hide()
        Label700GPAs.Hide()
        YEAR7SEMESTERLabel.Text = "FIRST SEMESTER CGPA IS"
        F700TOTALCUlabel.Text = f700cu
        F700TOTALQPlabel.Text = f700qp
        Label700GPA.Text = f700qp / f700cu
    End Sub
    Private Sub second700Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second700Button.Click
        first700Button.BackColor = Color.IndianRed
        second700Button.BackColor = Color.WhiteSmoke
        TabControl700.SelectedTab = TabPagesecond700
        F700TOTALCUlabel.Hide()
        F700TOTALQPlabel.Hide()
        Label700GPA.Hide()
        s700TOTALCUlabel.Show()
        s700TOTALQPlabel.Show()
        Label700GPAs.Show()
        YEAR7SEMESTERLabel.Text = "SECOND SEMESTER CGPA IS"
        F700TOTALCUlabel.Text = s700cu
        F700TOTALQPlabel.Text = s700qp
        Label700GPAs.Text = s700qp / s700cu
    End Sub

    'motherboard
    Private Sub coursera()
        'for F
        F200ListBoxCourseCode.Items.Clear()
        F200ListBoxCourseName.Items.Clear()
        F200ListBoxCreditUnit.Items.Clear()
        F300ListBoxCourseCode.Items.Clear()
        F300ListBoxCourseName.Items.Clear()
        F300ListBoxCreditUnit.Items.Clear()
        F400ListBoxCourseCode.Items.Clear()
        F400ListBoxCourseName.Items.Clear()
        F400ListBoxCreditUnit.Items.Clear()
        F500ListboxCourseCode.Items.Clear()
        F500ListboxCourseName.Items.Clear()
        F500ListboxCreditUnit.Items.Clear()
        F600ListboxCourseCode.Items.Clear()
        F600ListboxCourseName.Items.Clear()
        F600Listboxcreditunit.Items.Clear()
        F700ListBoxCourseCode.Items.Clear()
        F700ListBoxCourseName.Items.Clear()
        F700ListBoxCreditunit.Items.Clear()
        Call nigga()
        'F200
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim jaja As String = F100ListBoxHopecode.Items(i).ToString
            Dim jaha As String = f100listboxhopename.Items(i).ToString
            Dim jahi As String = f100listboxhopeunit.Items(i).ToString
            F200ListBoxCourseCode.Items.Add(jaja)
            F200ListBoxCourseName.Items.Add(jaha)
            F200ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F100ListBoxF.Items.Count - 1
            Dim jaja As String = F100ListBoxF.Items(i).ToString
            Dim jaha As String = F100ListBoxFN.Items(i).ToString
            Dim jahi As String = F100ListBoxFC.Items(i).ToString
            F200ListBoxCourseCode.Items.Add(jaja)
            F200ListBoxCourseName.Items.Add(jaha)
            F200ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F200ListBoxCourseCodeMain.Items.Count - 1
            Dim jaja As String = F200ListBoxCourseCodeMain.Items(i).ToString
            Dim jaha As String = F200ListBoxCourseNameMain.Items(i).ToString
            Dim jahi As String = F200ListBoxCreditmain.Items(i).ToString
            F200ListBoxCourseCode.Items.Add(jaja)
            F200ListBoxCourseName.Items.Add(jaha)
            F200ListBoxCreditUnit.Items.Add(jaha)
        Next

        'F300
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim jaja As String = F200ListBoxhopeCode.Items(i).ToString
            Dim jaha As String = f200listboxhopename.Items(i).ToString
            Dim jahi As String = f200listboxhopeunit.Items(i).ToString
            F300ListBoxCourseCode.Items.Add(jaja)
            F300ListBoxCourseName.Items.Add(jaha)
            F300ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F200ListBoxF.Items.Count - 1
            Dim jaja As String = F200ListBoxF.Items(i).ToString
            Dim jaha As String = F200ListBoxFN.Items(i).ToString
            Dim jahi As String = F200ListBoxFC.Items(i).ToString
            F300ListBoxCourseCode.Items.Add(jaja)
            F300ListBoxCourseName.Items.Add(jaha)
            F300ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F300ListBoxCourseCodemAIN.Items.Count - 1
            Dim jaja As String = F300ListBoxCourseCodemAIN.Items(i).ToString
            Dim jaha As String = F300ListBoxCourseNameMain.Items(i).ToString
            Dim jahi As String = F300ListBoxCreditUnitMain.Items(i).ToString
            F300ListBoxCourseCode.Items.Add(jaja)
            F300ListBoxCourseName.Items.Add(jaha)
            F300ListBoxCreditUnit.Items.Add(jaha)
        Next

        'F400
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim jaja As String = F300ListBoxhopecode.Items(i).ToString
            Dim jaha As String = f300listboxhopename.Items(i).ToString
            Dim jahi As String = f300listboxhopeunit.Items(i).ToString
            F400ListBoxCourseCode.Items.Add(jaja)
            F400ListBoxCourseName.Items.Add(jaha)
            F400ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F300ListBoxF.Items.Count - 1
            Dim jaja As String = F300ListBoxF.Items(i).ToString
            Dim jaha As String = F300ListBoxFN.Items(i).ToString
            Dim jahi As String = F300ListBoxFC.Items(i).ToString
            F400ListBoxCourseCode.Items.Add(jaja)
            F400ListBoxCourseName.Items.Add(jaha)
            F400ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F400ListBoxCourseCodeMain.Items.Count - 1
            Dim jaja As String = F400ListBoxCourseCodeMain.Items(i).ToString
            Dim jaha As String = F400ListBoxCourseNameMain.Items(i).ToString
            Dim jahi As String = F400ListBoxCreditUnitMain.Items(i).ToString
            F400ListBoxCourseCode.Items.Add(jaja)
            F400ListBoxCourseName.Items.Add(jaha)
            F400ListBoxCreditUnit.Items.Add(jaha)
        Next

        'F500
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim jaja As String = F400ListBoxhopecode.Items(i).ToString
            Dim jaha As String = f400listboxhopename.Items(i).ToString
            Dim jahi As String = f400listboxhopeunit.Items(i).ToString
            F500ListboxCourseCode.Items.Add(jaja)
            F500ListboxCourseName.Items.Add(jaha)
            F500ListboxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F400ListBoxF.Items.Count - 1
            Dim jaja As String = F400ListBoxF.Items(i).ToString
            Dim jaha As String = F400ListBoxFN.Items(i).ToString
            Dim jahi As String = F400ListBoxFC.Items(i).ToString
            F500ListboxCourseCode.Items.Add(jaja)
            F500ListboxCourseName.Items.Add(jaha)
            F500ListboxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To F500ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = F500ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = F500ListboxCourseNAMEMAIN.Items(i).ToString
            Dim jahi As String = F500ListboxCREDITuNITMAIN.Items(i).ToString
            F500ListboxCourseCode.Items.Add(jaja)
            F500ListboxCourseName.Items.Add(jaha)
            F500ListboxCreditUnit.Items.Add(jaha)
        Next

        'F600
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim jaja As String = F500Listboxhopecode.Items(i).ToString
            Dim jaha As String = f500listboxhopename.Items(i).ToString
            Dim jahi As String = f500listboxhopeunit.Items(i).ToString
            F600ListboxCourseCode.Items.Add(jaja)
            F600ListboxCourseName.Items.Add(jaha)
            F600Listboxcreditunit.Items.Add(jaha)
        Next
        For i = 0 To F500ListboxF.Items.Count - 1
            Dim jaja As String = F500ListboxF.Items(i).ToString
            Dim jaha As String = F500ListboxFN.Items(i).ToString
            Dim jahi As String = F500ListboxFC.Items(i).ToString
            F600ListboxCourseCode.Items.Add(jaja)
            F600ListboxCourseName.Items.Add(jaha)
            F600Listboxcreditunit.Items.Add(jaha)
        Next
        'F700
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim jaja As String = F600ListboxhopeCode.Items(i).ToString
            Dim jaha As String = f600listboxhopename.Items(i).ToString
            Dim jahi As String = f600listboxhopeunit.Items(i).ToString
            F700ListBoxCourseCode.Items.Add(jaja)
            F700ListBoxCourseName.Items.Add(jaha)
            F700ListBoxCreditunit.Items.Add(jaha)
        Next
        For i = 0 To F600ListboxF.Items.Count - 1
            Dim jaja As String = F600ListboxF.Items(i).ToString
            Dim jaha As String = F600ListboxFN.Items(i).ToString
            Dim jahi As String = F600ListboxFC.Items(i).ToString
            F700ListBoxCourseCode.Items.Add(jaja)
            F700ListBoxCourseName.Items.Add(jaha)
            F700ListBoxCreditunit.Items.Add(jaha)
        Next

        'for S
        S200ListboxCourseCode.Items.Clear()
        S200ListboxCourseName.Items.Clear()
        S200ListboxCreditunit.Items.Clear()
        S300ListboxCourseCode.Items.Clear()
        S300ListboxCourseName.Items.Clear()
        S300ListboxCreditUnit.Items.Clear()
        S400ListBoxCOURSEcode.Items.Clear()
        S400ListBoxCOURSEname.Items.Clear()
        S400ListBoxcreditunit.Items.Clear()
        S500ListBoxCourseCode.Items.Clear()
        S500ListBoxCourseName.Items.Clear()
        S500ListBoxCreditUnit.Items.Clear()
        S600ListBoxCourseCode.Items.Clear()
        S600ListBoxCoursename.Items.Clear()
        S600ListBoxCreditunit.Items.Clear()
        S700ListBoxCourseCode.Items.Clear()
        S700ListBoxCourseName.Items.Clear()
        S700ListBoxCreditUnit.Items.Clear()

        'S200
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim jaja As String = S100ListBoxhopecode.Items(i).ToString
            Dim jaha As String = s100listboxhopename.Items(i).ToString
            Dim jahi As String = s100listboxhopeunit.Items(i).ToString
            S200ListboxCourseCode.Items.Add(jaja)
            S200ListboxCourseName.Items.Add(jaha)
            S200ListboxCreditunit.Items.Add(jaha)
        Next
        For i = 0 To S100ListBoxF.Items.Count - 1
            Dim jaja As String = S100ListBoxF.Items(i).ToString
            Dim jaha As String = S100ListBoxFN.Items(i).ToString
            Dim jahi As String = S100ListBoxFC.Items(i).ToString
            S200ListboxCourseCode.Items.Add(jaja)
            S200ListboxCourseName.Items.Add(jaha)
            S200ListboxCreditunit.Items.Add(jaha)
        Next
        For i = 0 To S200ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S200ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S200ListboxCoursenAMEMAIN.Items(i).ToString
            Dim jahi As String = S200ListboxCREDITuNITMAIN.Items(i).ToString
            S200ListboxCourseCode.Items.Add(jaja)
            S200ListboxCourseName.Items.Add(jaha)
            S200ListboxCreditunit.Items.Add(jaha)
        Next

        'S300
        For i = 0 To S200ListboxhopeCode.Items.Count - 1
            Dim jaja As String = S200ListboxhopeCode.Items(i).ToString
            Dim jaha As String = s200listboxhopename.Items(i).ToString
            Dim jahi As String = s200listboxhopeunit.Items(i).ToString
            S300ListboxCourseCode.Items.Add(jaja)
            S300ListboxCourseName.Items.Add(jaha)
            S300ListboxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To S200ListboxF.Items.Count - 1
            Dim jaja As String = S200ListboxF.Items(i).ToString
            Dim jaha As String = S200ListboxFN.Items(i).ToString
            Dim jahi As String = S200ListboxFC.Items(i).ToString
            S300ListboxCourseCode.Items.Add(jaja)
            S300ListboxCourseName.Items.Add(jaha)
            S300ListboxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To S300ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S300ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S300ListboxCoursenAMeMAIN.Items(i).ToString
            Dim jahi As String = S300ListboxCREDITUNITMAIN.Items(i).ToString
            S300ListboxCourseCode.Items.Add(jaja)
            S300ListboxCourseName.Items.Add(jaha)
            S300ListboxCreditUnit.Items.Add(jaha)
        Next

        'S400
        For i = 0 To S300ListboxhopeCode.Items.Count - 1
            Dim jaja As String = S300ListboxhopeCode.Items(i).ToString
            Dim jaha As String = s300listboxhopename.Items(i).ToString
            Dim jahi As String = s300listboxhopeunit.Items(i).ToString
            S400ListBoxCOURSEcode.Items.Add(jaja)
            S400ListBoxCOURSEname.Items.Add(jaha)
            S400ListBoxcreditunit.Items.Add(jaha)
        Next
        For i = 0 To S300ListboxF.Items.Count - 1
            Dim jaja As String = S300ListboxF.Items(i).ToString
            Dim jaha As String = S300ListboxFN.Items(i).ToString
            Dim jahi As String = S300ListboxFC.Items(i).ToString
            S400ListBoxCOURSEcode.Items.Add(jaja)
            S400ListBoxCOURSEname.Items.Add(jaha)
            S400ListBoxcreditunit.Items.Add(jaha)
        Next
        For i = 0 To S400ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S400ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S400ListboxCoursenAMEMAIN.Items(i).ToString
            Dim jahi As String = S400ListboxCREDITUNITMAIN.Items(i).ToString
            S400ListBoxCOURSEcode.Items.Add(jaja)
            S400ListBoxCOURSEname.Items.Add(jaha)
            S400ListBoxcreditunit.Items.Add(jaha)
        Next

        'S500
        For i = 0 To S400ListBoxhopecode.Items.Count - 1
            Dim jaja As String = S400ListBoxhopecode.Items(i).ToString
            Dim jaha As String = s400listboxhopename.Items(i).ToString
            Dim jahi As String = s400listboxhopeunit.Items(i).ToString
            S500ListBoxCourseCode.Items.Add(jaja)
            S500ListBoxCourseName.Items.Add(jaha)
            S500ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To S400ListBoxF.Items.Count - 1
            Dim jaja As String = S400ListBoxF.Items(i).ToString
            Dim jaha As String = S400ListBoxFN.Items(i).ToString
            Dim jahi As String = S400ListBoxFC.Items(i).ToString
            S500ListBoxCourseCode.Items.Add(jaja)
            S500ListBoxCourseName.Items.Add(jaha)
            S500ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To S500ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S500ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S500ListboxCoursenAMEMAIN.Items(i).ToString
            Dim jahi As String = S500ListboxCREDITUNITMAIN.Items(i).ToString
            S500ListBoxCourseCode.Items.Add(jaja)
            S500ListBoxCourseName.Items.Add(jaha)
            S500ListBoxCreditUnit.Items.Add(jaha)
        Next

        'S600
        For i = 0 To S500ListBoxhopecode.Items.Count - 1
            Dim jaja As String = S500ListBoxhopecode.Items(i).ToString
            Dim jaha As String = s500listboxhopename.Items(i).ToString
            Dim jahi As String = s500listboxhopeunit.Items(i).ToString
            S600ListBoxCourseCode.Items.Add(jaja)
            S600ListBoxCoursename.Items.Add(jaha)
            S600ListBoxCreditunit.Items.Add(jaha)
        Next
        For i = 0 To S500ListBoxF.Items.Count - 1
            Dim jaja As String = S500ListBoxF.Items(i).ToString
            Dim jaha As String = S500ListBoxFN.Items(i).ToString
            Dim jahi As String = S500ListBoxFC.Items(i).ToString
            S600ListBoxCourseCode.Items.Add(jaja)
            S600ListBoxCoursename.Items.Add(jaha)
            S600ListBoxCreditunit.Items.Add(jaha)
        Next
        'S700
        For i = 0 To S600ListBoxHopeCode.Items.Count - 1
            Dim jaja As String = S600ListBoxHopeCode.Items(i).ToString
            Dim jaha As String = s600listboxhopename.Items(i).ToString
            Dim jahi As String = s600listboxhopeunit.Items(i).ToString
            S700ListBoxCourseCode.Items.Add(jaja)
            S700ListBoxCourseName.Items.Add(jaha)
            S700ListBoxCreditUnit.Items.Add(jaha)
        Next
        For i = 0 To S600ListBoxF.Items.Count - 1
            Dim jaja As String = S600ListBoxF.Items(i).ToString
            Dim jaha As String = S600ListBoxFN.Items(i).ToString
            Dim jahi As String = S600ListBoxFC.Items(i).ToString
            S700ListBoxCourseCode.Items.Add(jaja)
            S700ListBoxCourseName.Items.Add(jaha)
            S700ListBoxCreditUnit.Items.Add(jaha)
        Next
    End Sub
    Private Sub f200coursera()
        'for F
        'F200
        F200ListBoxCourseCode.Items.Clear()
        F200ListBoxCourseName.Items.Clear()
        F200ListBoxCreditUnit.Items.Clear()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim jaja As String = F100ListBoxHopecode.Items(i).ToString
            Dim jaha As String = f100listboxhopename.Items(i).ToString
            Dim jahi As String = f100listboxhopeunit.Items(i).ToString
            F200ListBoxCourseCode.Items.Add(jaja)
            F200ListBoxCourseName.Items.Add(jaha)
            F200ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F100ListBoxF.Items.Count - 1
            Dim jaja As String = F100ListBoxF.Items(i).ToString
            Dim jaha As String = F100ListBoxFN.Items(i).ToString
            Dim jahi As String = F100ListBoxFC.Items(i).ToString
            F200ListBoxCourseCode.Items.Add(jaja)
            F200ListBoxCourseName.Items.Add(jaha)
            F200ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F200ListBoxCourseCodeMain.Items.Count - 1
            Dim jaja As String = F200ListBoxCourseCodeMain.Items(i).ToString
            Dim jaha As String = F200ListBoxCourseNameMain.Items(i).ToString
            Dim jahi As String = F200ListBoxCreditmain.Items(i).ToString
            F200ListBoxCourseCode.Items.Add(jaja)
            F200ListBoxCourseName.Items.Add(jaha)
            F200ListBoxCreditUnit.Items.Add(jahi)
        Next
    End Sub
    Private Sub f300coursera()
        'F300
        F300ListBoxCourseCode.Items.Clear()
        F300ListBoxCourseName.Items.Clear()
        F300ListBoxCreditUnit.Items.Clear()

        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim jaja As String = F200ListBoxhopeCode.Items(i).ToString
            Dim jaha As String = f200listboxhopename.Items(i).ToString
            Dim jahi As String = f200listboxhopeunit.Items(i).ToString
            F300ListBoxCourseCode.Items.Add(jaja)
            F300ListBoxCourseName.Items.Add(jaha)
            F300ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F200ListBoxF.Items.Count - 1
            Dim jaja As String = F200ListBoxF.Items(i).ToString
            Dim jaha As String = F200ListBoxFN.Items(i).ToString
            Dim jahi As String = F200ListBoxFC.Items(i).ToString
            F300ListBoxCourseCode.Items.Add(jaja)
            F300ListBoxCourseName.Items.Add(jaha)
            F300ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F300ListBoxCourseCodemAIN.Items.Count - 1
            Dim jaja As String = F300ListBoxCourseCodemAIN.Items(i).ToString
            Dim jaha As String = F300ListBoxCourseNameMain.Items(i).ToString
            Dim jahi As String = F300ListBoxCreditUnitMain.Items(i).ToString
            F300ListBoxCourseCode.Items.Add(jaja)
            F300ListBoxCourseName.Items.Add(jaha)
            F300ListBoxCreditUnit.Items.Add(jahi)
        Next

    End Sub
    Private Sub f400coursera()
        'F400
        F400ListBoxCourseCode.Items.Clear()
        F400ListBoxCourseName.Items.Clear()
        F400ListBoxCreditUnit.Items.Clear()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim jaja As String = F300ListBoxhopecode.Items(i).ToString
            Dim jaha As String = f300listboxhopename.Items(i).ToString
            Dim jahi As String = f300listboxhopeunit.Items(i).ToString
            F400ListBoxCourseCode.Items.Add(jaja)
            F400ListBoxCourseName.Items.Add(jaha)
            F400ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F300ListBoxF.Items.Count - 1
            Dim jaja As String = F300ListBoxF.Items(i).ToString
            Dim jaha As String = F300ListBoxFN.Items(i).ToString
            Dim jahi As String = F300ListBoxFC.Items(i).ToString
            F400ListBoxCourseCode.Items.Add(jaja)
            F400ListBoxCourseName.Items.Add(jaha)
            F400ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F400ListBoxCourseCodeMain.Items.Count - 1
            Dim jaja As String = F400ListBoxCourseCodeMain.Items(i).ToString
            Dim jaha As String = F400ListBoxCourseNameMain.Items(i).ToString
            Dim jahi As String = F400ListBoxCreditUnitMain.Items(i).ToString
            F400ListBoxCourseCode.Items.Add(jaja)
            F400ListBoxCourseName.Items.Add(jaha)
            F400ListBoxCreditUnit.Items.Add(jahi)
        Next
    End Sub
    Private Sub f500coursera()
        F500ListboxCourseCode.Items.Clear()
        F500ListboxCourseName.Items.Clear()
        F500ListboxCreditUnit.Items.Clear()
        'F500
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim jaja As String = F400ListBoxhopecode.Items(i).ToString
            Dim jaha As String = f400listboxhopename.Items(i).ToString
            Dim jahi As String = f400listboxhopeunit.Items(i).ToString
            F500ListboxCourseCode.Items.Add(jaja)
            F500ListboxCourseName.Items.Add(jaha)
            F500ListboxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F400ListBoxF.Items.Count - 1
            Dim jaja As String = F400ListBoxF.Items(i).ToString
            Dim jaha As String = F400ListBoxFN.Items(i).ToString
            Dim jahi As String = F400ListBoxFC.Items(i).ToString
            F500ListboxCourseCode.Items.Add(jaja)
            F500ListboxCourseName.Items.Add(jaha)
            F500ListboxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To F500ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = F500ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = F500ListboxCourseNAMEMAIN.Items(i).ToString
            Dim jahi As String = F500ListboxCREDITuNITMAIN.Items(i).ToString
            F500ListboxCourseCode.Items.Add(jaja)
            F500ListboxCourseName.Items.Add(jaha)
            F500ListboxCreditUnit.Items.Add(jahi)
        Next
    End Sub
    Private Sub f600coursera()
        'F600
        F600ListboxCourseCode.Items.Clear()
        F600ListboxCourseName.Items.Clear()
        F600Listboxcreditunit.Items.Clear()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim jaja As String = F500Listboxhopecode.Items(i).ToString
            Dim jaha As String = f500listboxhopename.Items(i).ToString
            Dim jahi As String = f500listboxhopeunit.Items(i).ToString
            F600ListboxCourseCode.Items.Add(jaja)
            F600ListboxCourseName.Items.Add(jaha)
            F600Listboxcreditunit.Items.Add(jahi)
        Next
        For i = 0 To F500ListboxF.Items.Count - 1
            Dim jaja As String = F500ListboxF.Items(i).ToString
            Dim jaha As String = F500ListboxFN.Items(i).ToString
            Dim jahi As String = F500ListboxFC.Items(i).ToString
            F600ListboxCourseCode.Items.Add(jaja)
            F600ListboxCourseName.Items.Add(jaha)
            F600Listboxcreditunit.Items.Add(jahi)
        Next
    End Sub
    Private Sub f700coursera()
        'F700
        F700ListBoxCourseCode.Items.Clear()
        F700ListBoxCourseName.Items.Clear()
        F700ListBoxCreditunit.Items.Clear()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim jaja As String = F600ListboxhopeCode.Items(i).ToString
            Dim jaha As String = f600listboxhopename.Items(i).ToString
            Dim jahi As String = f600listboxhopeunit.Items(i).ToString
            F700ListBoxCourseCode.Items.Add(jaja)
            F700ListBoxCourseName.Items.Add(jaha)
            F700ListBoxCreditunit.Items.Add(jahi)
        Next
        For i = 0 To F600ListboxF.Items.Count - 1
            Dim jaja As String = F600ListboxF.Items(i).ToString
            Dim jaha As String = F600ListboxFN.Items(i).ToString
            Dim jahi As String = F600ListboxFC.Items(i).ToString
            F700ListBoxCourseCode.Items.Add(jaja)
            F700ListBoxCourseName.Items.Add(jaha)
            F700ListBoxCreditunit.Items.Add(jahi)
        Next
    End Sub
    Private Sub hope()
        Call coursera()
        Call f100hope()
        Call f200hope()
        Call f300hope()
        Call f400hope()
        Call f500hope()
        Call f600hope()
        Call f700hope()
        Call s100hope()
        Call s200hope()
        Call s300hope()
        Call s400hope()
        Call s500hope()
        Call s600hope()
        Call s700hope()
        Call nigga()
    End Sub
    Private Sub oleku()
        Call F100oleku()
        Call F200oleku()
        Call F300oleku()
        Call F400oleku()
        Call F500oleku()
        Call F600oleku()
        Call F700oleku()
        Call S100oleku()
        Call S200oleku()
        Call S300oleku()
        Call S400oleku()
        Call S500oleku()
        Call S600oleku()
        Call S700oleku()
        Call nigga()
    End Sub
    Private Sub totalcreditunit()
        Call F100TOtalcreditunit()
        Call F200TOtalcreditunit()
        Call F300TOtalcreditunit()
        Call F400TOtalcreditunit()
        Call F500TOtalcreditunit()
        Call F600TOtalcreditunit()
        Call F700TOtalcreditunit()
        Call S100TOtalcreditunit()
        Call S200TOtalcreditunit()
        Call S300TOtalcreditunit()
        Call S400TOtalcreditunit()
        Call S500TOtalcreditunit()
        Call S600TOtalcreditunit()
        Call S700TOtalcreditunit()
        Call nigga()
    End Sub
    Private Sub totalqp()
        Call F100TOtalqp()
        Call F200TOtalqp()
        Call F300TOtalqp()
        Call F400TOtalqp()
        Call F500TOtalqp()
        Call F600TOtalqp()
        Call F700TOtalqp()
        Call S100TOtalqp()
        Call S200TOtalqp()
        Call S300TOtalqp()
        Call S400TOtalqp()
        Call S500TOtalqp()
        Call S600TOtalqp()
        Call S700TOtalqp()
        Call nigga()
    End Sub
    Private Sub nigga()
        Dim mosthigh As Double 'tcu
        Dim nnunu As Double 'tqu
        mosthigh = f100cu + f200cu + f300cu + f400cu + f500cu + f600cu + f700cu + s100cu + s200cu + s300cu + s400cu + s500cu + s600cu + s700cu
        nnunu = f100qp + f200qp + f300qp + f400qp + f500qp + f600qp + f700qp + s100qp + s200qp + s300qp + s400qp + s500qp + s600qp + s700qp
        LabelCUMMCREDUNIT.Text = mosthigh
        LabelCUMMQUALPT.Text = nnunu
        cgpa = Math.Round((nnunu / mosthigh), 3)
        If cgpa < 1 Then
            LabelHonours.Text = "-----"
        ElseIf (cgpa > 0.99) And (cgpa < 2.0) Then
            LabelHonours.Text = "PASS"
        ElseIf (cgpa > 1.99) And (cgpa < 2.5) Then
            LabelHonours.Text = "THIRD CLASS"
        ElseIf (cgpa > 2.49) And (cgpa < 3.5) Then
            LabelHonours.Text = "SECOND CLASS LOWER"
        ElseIf (cgpa > 3.49) And (cgpa < 4.5) Then
            LabelHonours.Text = "SECOND CLASS UPPER"
        ElseIf cgpa > 4.49 Then
            LabelHonours.Text = "FIRST CLASS"
        End If
        LabelCGPA.Text = cgpa
    End Sub

    Private Sub s200coursera()
        'for F
        'S200
        S200ListboxCourseCode.Items.Clear()
        S200ListboxCourseName.Items.Clear()
        S200ListboxCreditunit.Items.Clear()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim jaja As String = S100ListBoxhopecode.Items(i).ToString
            Dim jaha As String = s100listboxhopename.Items(i).ToString
            Dim jahi As String = s100listboxhopeunit.Items(i).ToString
            S200ListboxCourseCode.Items.Add(jaja)
            S200ListboxCourseName.Items.Add(jaha)
            S200ListboxCreditunit.Items.Add(jahi)
        Next
        For i = 0 To S100ListBoxF.Items.Count - 1
            Dim jaja As String = S100ListBoxF.Items(i).ToString
            Dim jaha As String = S100ListBoxFN.Items(i).ToString
            Dim jahi As String = S100ListBoxFC.Items(i).ToString
            S200ListboxCourseCode.Items.Add(jaja)
            S200ListboxCourseName.Items.Add(jaha)
            S200ListboxCreditunit.Items.Add(jahi)
        Next
        For i = 0 To S200ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S200ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S200ListboxCoursenAMEMAIN.Items(i).ToString
            Dim jahi As String = S200ListboxCREDITuNITMAIN.Items(i).ToString
            S200ListboxCourseCode.Items.Add(jaja)
            S200ListboxCourseName.Items.Add(jaha)
            S200ListboxCreditunit.Items.Add(jahi)
        Next
    End Sub
    Private Sub s300coursera()
        'S300
        S300ListboxCourseCode.Items.Clear()
        S300ListboxCourseName.Items.Clear()
        S300ListboxCreditUnit.Items.Clear()

        For i = 0 To S200ListboxhopeCode.Items.Count - 1
            Dim jaja As String = S200ListboxhopeCode.Items(i).ToString
            Dim jaha As String = s200listboxhopename.Items(i).ToString
            Dim jahi As String = s200listboxhopeunit.Items(i).ToString
            S300ListboxCourseCode.Items.Add(jaja)
            S300ListboxCourseName.Items.Add(jaha)
            S300ListboxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To S200ListboxF.Items.Count - 1
            Dim jaja As String = S200ListboxF.Items(i).ToString
            Dim jaha As String = S200ListboxFN.Items(i).ToString
            Dim jahi As String = S200ListboxFC.Items(i).ToString
            S300ListboxCourseCode.Items.Add(jaja)
            S300ListboxCourseName.Items.Add(jaha)
            S300ListboxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To S300ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S300ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S300ListboxCoursenAMeMAIN.Items(i).ToString
            Dim jahi As String = S300ListboxCREDITUNITMAIN.Items(i).ToString
            S300ListboxCourseCode.Items.Add(jaja)
            S300ListboxCourseName.Items.Add(jaha)
            S300ListboxCreditUnit.Items.Add(jahi)
        Next

    End Sub
    Private Sub s400coursera()
        'S400
        S400ListBoxCOURSEcode.Items.Clear()
        S400ListBoxCOURSEname.Items.Clear()
        S400ListBoxcreditunit.Items.Clear()
        For i = 0 To S300ListboxhopeCode.Items.Count - 1
            Dim jaja As String = S300ListboxhopeCode.Items(i).ToString
            Dim jaha As String = s300listboxhopename.Items(i).ToString
            Dim jahi As String = s300listboxhopeunit.Items(i).ToString
            S400ListBoxCOURSEcode.Items.Add(jaja)
            S400ListBoxCOURSEname.Items.Add(jaha)
            S400ListBoxcreditunit.Items.Add(jahi)
        Next
        For i = 0 To S300ListboxF.Items.Count - 1
            Dim jaja As String = S300ListboxF.Items(i).ToString
            Dim jaha As String = S300ListboxFN.Items(i).ToString
            Dim jahi As String = S300ListboxFC.Items(i).ToString
            S400ListBoxCOURSEcode.Items.Add(jaja)
            S400ListBoxCOURSEname.Items.Add(jaha)
            S400ListBoxcreditunit.Items.Add(jahi)
        Next
        For i = 0 To S400ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S400ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S400ListboxCoursenAMEMAIN.Items(i).ToString
            Dim jahi As String = S400ListboxCREDITUNITMAIN.Items(i).ToString
            S400ListBoxCOURSEcode.Items.Add(jaja)
            S400ListBoxCOURSEname.Items.Add(jaha)
            S400ListBoxcreditunit.Items.Add(jahi)
        Next
    End Sub
    Private Sub s500coursera()
        S500ListBoxCourseCode.Items.Clear()
        S500ListBoxCourseName.Items.Clear()
        S500ListBoxCreditUnit.Items.Clear()
        'S500
        For i = 0 To S400ListBoxhopecode.Items.Count - 1
            Dim jaja As String = S400ListBoxhopecode.Items(i).ToString
            Dim jaha As String = s400listboxhopename.Items(i).ToString
            Dim jahi As String = s400listboxhopeunit.Items(i).ToString
            S500ListBoxCourseCode.Items.Add(jaja)
            S500ListBoxCourseName.Items.Add(jaha)
            S500ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To S400ListBoxF.Items.Count - 1
            Dim jaja As String = S400ListBoxF.Items(i).ToString
            Dim jaha As String = S400ListBoxFN.Items(i).ToString
            Dim jahi As String = S400ListBoxFC.Items(i).ToString
            S500ListBoxCourseCode.Items.Add(jaja)
            S500ListBoxCourseName.Items.Add(jaha)
            S500ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To S500ListboxCourseCodeMAIN.Items.Count - 1
            Dim jaja As String = S500ListboxCourseCodeMAIN.Items(i).ToString
            Dim jaha As String = S500ListboxCoursenAMEMAIN.Items(i).ToString
            Dim jahi As String = S500ListboxCREDITUNITMAIN.Items(i).ToString
            S500ListBoxCourseCode.Items.Add(jaja)
            S500ListBoxCourseName.Items.Add(jaha)
            S500ListBoxCreditUnit.Items.Add(jahi)
        Next
    End Sub
    Private Sub s600coursera()
        'S600
        S600ListBoxCourseCode.Items.Clear()
        S600ListBoxCoursename.Items.Clear()
        S600ListBoxCreditunit.Items.Clear()
        For i = 0 To S500ListBoxhopecode.Items.Count - 1
            Dim jaja As String = S500ListBoxhopecode.Items(i).ToString
            Dim jaha As String = s500listboxhopename.Items(i).ToString
            Dim jahi As String = s500listboxhopeunit.Items(i).ToString
            S600ListBoxCourseCode.Items.Add(jaja)
            S600ListBoxCoursename.Items.Add(jaha)
            S600ListBoxCreditunit.Items.Add(jahi)
        Next
        For i = 0 To S500ListBoxF.Items.Count - 1
            Dim jaja As String = S500ListBoxF.Items(i).ToString
            Dim jaha As String = S500ListBoxFN.Items(i).ToString
            Dim jahi As String = S500ListBoxFC.Items(i).ToString
            S600ListBoxCourseCode.Items.Add(jaja)
            S600ListBoxCoursename.Items.Add(jaha)
            S600ListBoxCreditunit.Items.Add(jahi)
        Next
    End Sub
    Private Sub s700coursera()
        'S700
        S700ListBoxCourseCode.Items.Clear()
        S700ListBoxCourseName.Items.Clear()
        S700ListBoxCreditUnit.Items.Clear()
        For i = 0 To S600ListBoxHopeCode.Items.Count - 1
            Dim jaja As String = S600ListBoxHopeCode.Items(i).ToString
            Dim jaha As String = s600listboxhopename.Items(i).ToString
            Dim jahi As String = s600listboxhopeunit.Items(i).ToString
            S700ListBoxCourseCode.Items.Add(jaja)
            S700ListBoxCourseName.Items.Add(jaha)
            S700ListBoxCreditUnit.Items.Add(jahi)
        Next
        For i = 0 To S600ListBoxF.Items.Count - 1
            Dim jaja As String = S600ListBoxF.Items(i).ToString
            Dim jaha As String = S600ListBoxFN.Items(i).ToString
            Dim jahi As String = S600ListBoxFC.Items(i).ToString
            S700ListBoxCourseCode.Items.Add(jaja)
            S700ListBoxCourseName.Items.Add(jaha)
            S700ListBoxCreditUnit.Items.Add(jahi)
        Next
    End Sub

    'f100
    ' USED TO HIDE SOME CONTROLS
    Private Sub F100level1()
        F100ComboBoxCN2.Show()
        F100LabelCN2.Show()
        F100LabelG2.Show()
        F100LabelCU2.Show()
        F100LabelQP2.Show()
        F100TextBoxCN2.Show()
        F100ButtonCN2.Show()
    End Sub
    Private Sub F100level2()
        F100ComboBoxCN3.Show()
        F100LabelCN3.Show()
        F100LabelG3.Show()
        F100LabelCU3.Show()
        F100LabelQP3.Show()
        F100TextBoxCN3.Show()
        F100ButtonCN3.Show()
    End Sub
    Private Sub F100level3()
        F100ComboBoxCN4.Show()
        F100LabelCN4.Show()
        F100LabelG4.Show()
        F100LabelCU4.Show()
        F100LabelQP4.Show()
        F100TextBoxCN4.Show()
        F100ButtonCN4.Show()
    End Sub
    Private Sub F100level4()
        F100ComboBoxCN5.Show()
        F100LabelCN5.Show()
        F100LabelG5.Show()
        F100LabelCU5.Show()
        F100LabelQP5.Show()
        F100TextBoxCN5.Show()
        F100ButtonCN5.Show()
    End Sub
    Private Sub F100level5()
        F100ComboBoxCN6.Show()
        F100LabelCN6.Show()
        F100LabelG6.Show()
        F100LabelCU6.Show()
        F100LabelQP6.Show()
        F100TextBoxCN6.Show()
        F100ButtonCN6.Show()
    End Sub
    Private Sub F100level6()
        F100ComboBoxCN7.Show()
        F100LabelCN7.Show()
        F100LabelG7.Show()
        F100LabelCU7.Show()
        F100LabelQP7.Show()
        F100TextBoxCN7.Show()
        F100ButtonCN7.Show()
    End Sub
    Private Sub F100level7()
        F100ComboBoxCN8.Show()
        F100LabelCN8.Show()
        F100LabelG8.Show()
        F100LabelCU8.Show()
        F100LabelQP8.Show()
        F100TextBoxCN8.Show()
        F100ButtonCN8.Show()
    End Sub
    Private Sub F100level8()
        F100ComboBoxCN9.Show()
        F100LabelCN9.Show()
        F100LabelG9.Show()
        F100LabelCU9.Show()
        F100LabelQP9.Show()
        F100TextBoxCN9.Show()
        F100ButtonCN9.Show()
    End Sub
    Private Sub F100level9()
        F100ComboBoxCN10.Show()
        F100LabelCN10.Show()
        F100LabelG10.Show()
        F100LabelCU10.Show()
        F100LabelQP10.Show()
        F100TextBoxCN10.Show()
        F100ButtonCN10.Show()
    End Sub
    Private Sub F100level10()
        F100ComboBoxCN11.Show()
        F100LabelCN11.Show()
        F100LabelG11.Show()
        F100LabelCU11.Show()
        F100LabelQP11.Show()
        F100TextBoxCN11.Show()
        F100ButtonCN11.Show()
    End Sub
    Private Sub F100level11()
        F100ComboBoxCN12.Show()
        F100LabelCN12.Show()
        F100LabelG12.Show()
        F100LabelCU12.Show()
        F100LabelQP12.Show()
        F100TextBoxCN12.Show()
        F100ButtonCN12.Show()
    End Sub
    Private Sub F100level12()
        F100ComboBoxCN13.Show()
        F100LabelCN13.Show()
        F100LabelG13.Show()
        F100LabelCU13.Show()
        F100LabelQP13.Show()
        F100TextBoxCN13.Show()
        F100ButtonCN13.Show()
    End Sub
    Private Sub F100level13()
        F100ComboBoxCN14.Show()
        F100LabelCN14.Show()
        F100LabelG14.Show()
        F100LabelCU14.Show()
        F100LabelQP14.Show()
        F100TextBoxCN14.Show()
        F100ButtonCN14.Show()
    End Sub
    'sub-mother board
    Private Sub f100hope()
        F100ListBoxHopecode.Items.Clear()
        f100listboxhopename.Items.Clear()
        f100listboxhopeunit.Items.Clear()
        F100ListBoxF.Items.Clear()
        F100ListBoxFC.Items.Clear()
        F100ListBoxFN.Items.Clear()
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = F100ListBoxCourseCode.Items(i).ToString
            Dim morga As String = F100ListBoxCourseName.Items(i).ToString
            Dim morg As String = F100ListBoxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F100ListBoxCourseName.Items(i).ToString
            Dim gwen As String = F100ListBoxCreditUnit.Items(i).ToString
            If (F100ButtonCn1.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN2.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN3.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN4.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN5.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN6.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN7.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN8.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN9.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN10.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN11.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN12.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN13.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN14.Text = F100ListBoxCourseCode.Items(i).ToString) Then
                F100ListBoxHopecode.Items.Remove(i)
                f100listboxhopename.Items.Remove(i)
                f100listboxhopeunit.Items.Remove(i)
            Else
                F100ListBoxHopecode.Items.Add(morgan)
                f100listboxhopename.Items.Add(morga)
                f100listboxhopeunit.Items.Add(morg)
            End If
            If (F100ButtonCn1.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG1.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN2.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG2.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN3.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG3.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN4.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG4.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN5.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG5.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN6.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG6.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN7.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG7.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN8.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG8.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN9.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG9.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN10.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG10.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN11.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG11.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN12.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG12.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN13.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG13.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
            If (F100ButtonCN14.Text = F100ListBoxCourseCode.Items(i).ToString) And F100LabelG14.Text = merlin Then
                F100ListBoxF.Items.Add(morgan)
                F100ListBoxFN.Items.Add(arthur)
                F100ListBoxFC.Items.Add(gwen)
            Else
                F100ListBoxF.Items.Remove(i)
            End If
        Next
        Call nigga()
    End Sub
    Private Sub F100oleku()
        If F100ButtonCn1.Text = "-" Then
            F100TextBoxCN1.Enabled = False
        Else
            F100TextBoxCN1.Enabled = True
        End If
        If F100ButtonCN2.Text = "-" Then
            F100TextBoxCN2.Enabled = False
        Else
            F100TextBoxCN2.Enabled = True
        End If
        If F100ButtonCN3.Text = "-" Then
            F100TextBoxCN3.Enabled = False
        Else
            F100TextBoxCN3.Enabled = True
        End If
        If F100ButtonCN4.Text = "-" Then
            F100TextBoxCN4.Enabled = False
        Else
            F100TextBoxCN4.Enabled = True
        End If
        If F100ButtonCN5.Text = "-" Then
            F100TextBoxCN5.Enabled = False
        Else
            F100TextBoxCN5.Enabled = True
        End If
        If F100ButtonCN6.Text = "-" Then
            F100TextBoxCN6.Enabled = False
        Else
            F100TextBoxCN6.Enabled = True
        End If
        If F100ButtonCN7.Text = "-" Then
            F100TextBoxCN7.Enabled = False
        Else
            F100TextBoxCN7.Enabled = True
        End If
        If F100ButtonCN8.Text = "-" Then
            F100TextBoxCN8.Enabled = False
        Else
            F100TextBoxCN8.Enabled = True
        End If
        If F100ButtonCN9.Text = "-" Then
            F100TextBoxCN9.Enabled = False
        Else
            F100TextBoxCN9.Enabled = True
        End If
        If F100ButtonCN10.Text = "-" Then
            F100TextBoxCN10.Enabled = False
        Else
            F100TextBoxCN10.Enabled = True
        End If
        If F100ButtonCN11.Text = "-" Then
            F100TextBoxCN11.Enabled = False
        Else
            F100TextBoxCN11.Enabled = True
        End If
        If F100ButtonCN12.Text = "-" Then
            F100TextBoxCN12.Enabled = False
        Else
            F100TextBoxCN12.Enabled = True
        End If
        If F100ButtonCN13.Text = "-" Then
            F100TextBoxCN13.Enabled = False
        Else
            F100TextBoxCN13.Enabled = True
        End If
        If F100ButtonCN14.Text = "-" Then
            F100TextBoxCN14.Enabled = False
        Else
            F100TextBoxCN14.Enabled = True
        End If
        Call nigga()
    End Sub
    Private Sub F100TOtalcreditunit()
        Dim f100totalcu As Integer
        f100totalcu = Val(F100LabelCU1.Text) + Val(F100LabelCU2.Text) + Val(F100LabelCU3.Text) + Val(F100LabelCU4.Text) + Val(F100LabelCU5.Text) + Val(F100LabelCU6.Text) + Val(F100LabelCU7.Text) + Val(F100LabelCU8.Text) + Val(F100LabelCU9.Text) + Val(F100LabelCU10.Text) + Val(F100LabelCU11.Text) + Val(F100LabelCU12.Text) + Val(F100LabelCU13.Text) + Val(F100LabelCU14.Text)
        f100cu = f100totalcu
        y100TOTALCUlabel.Text = f100totalcu
        Call nigga()
    End Sub
    Private Sub F100TOtalqp()
        Dim F100totalqp As Integer
        F100LabelQP1.Text = Val(F100labelpt1.Text) * Val(F100LabelCU1.Text)
        F100LabelQP2.Text = Val(F100labelpt2.Text) * Val(F100LabelCU2.Text)
        F100LabelQP3.Text = Val(F100labelpt3.Text) * Val(F100LabelCU3.Text)
        F100LabelQP4.Text = Val(F100labelpt4.Text) * Val(F100LabelCU4.Text)
        F100LabelQP5.Text = Val(F100labelpt5.Text) * Val(F100LabelCU5.Text)
        F100LabelQP6.Text = Val(F100labelpt6.Text) * Val(F100LabelCU6.Text)
        F100LabelQP7.Text = Val(F100labelpt7.Text) * Val(F100LabelCU7.Text)
        F100LabelQP8.Text = Val(F100labelpt8.Text) * Val(F100LabelCU8.Text)
        F100LabelQP9.Text = Val(F100labelpt9.Text) * Val(F100LabelCU9.Text)
        F100LabelQP10.Text = Val(F100labelpt10.Text) * Val(F100LabelCU10.Text)
        F100LabelQP11.Text = Val(F100labelpt11.Text) * Val(F100LabelCU11.Text)
        F100LabelQP12.Text = Val(F100labelpt12.Text) * Val(F100LabelCU12.Text)
        F100LabelQP13.Text = Val(F100labelpt13.Text) * Val(F100LabelCU13.Text)
        F100LabelQP14.Text = Val(F100labelpt14.Text) * Val(F100LabelCU14.Text)
        F100totalqp = Val(F100LabelQP1.Text) + Val(F100LabelQP2.Text) + Val(F100LabelQP3.Text) + Val(F100LabelQP4.Text) + Val(F100LabelQP5.Text) + Val(F100LabelQP6.Text) + Val(F100LabelQP7.Text) + Val(F100LabelQP8.Text) + Val(F100LabelQP9.Text) + Val(F100LabelQP10.Text) + Val(F100LabelQP11.Text) + Val(F100LabelQP12.Text) + Val(F100LabelQP13.Text) + Val(F100LabelQP14.Text)
        f100qp = F100totalqp
        y100TOTALQPlabel.Text = F100totalqp
        Dim cg As Double
        cg = Val(y100TOTALQPlabel.Text) / Val(y100TOTALCUlabel.Text)
        cg = Math.Round(cg, 2)
        Label100GPA.Text = cg
        Call nigga()
    End Sub

    'f200
    ' USED TO HIDE SOME CONTROLS
    Private Sub F200level1()
        F200ComboBoxCN2.Show()
        F200LabelCN2.Show()
        F200LabelG2.Show()
        F200LabelCU2.Show()
        F200LabelQP2.Show()
        F200TextBoxCN2.Show()
        F200ButtonCN2.Show()
    End Sub
    Private Sub F200level2()
        F200ComboBoxCN3.Show()
        F200LabelCN3.Show()
        F200LabelG3.Show()
        F200LabelCU3.Show()
        F200LabelQP3.Show()
        F200TextBoxCN3.Show()
        F200ButtonCN3.Show()
    End Sub
    Private Sub F200level3()
        F200ComboBoxCN4.Show()
        F200LabelCN4.Show()
        F200LabelG4.Show()
        F200LabelCU4.Show()
        F200LabelQP4.Show()
        F200TextBoxCN4.Show()
        F200ButtonCN4.Show()
    End Sub
    Private Sub F200level4()
        F200ComboBoxCN5.Show()
        F200LabelCN5.Show()
        F200LabelG5.Show()
        F200LabelCU5.Show()
        F200LabelQP5.Show()
        F200TextBoxCN5.Show()
        F200ButtonCN5.Show()
    End Sub
    Private Sub F200level5()
        F200ComboBoxCN6.Show()
        F200LabelCN6.Show()
        F200LabelG6.Show()
        F200LabelCU6.Show()
        F200LabelQP6.Show()
        F200TextBoxCN6.Show()
        F200ButtonCN6.Show()
    End Sub
    Private Sub F200level6()
        F200ComboBoxCN7.Show()
        F200LabelCN7.Show()
        F200LabelG7.Show()
        F200LabelCU7.Show()
        F200LabelQP7.Show()
        F200TextBoxCN7.Show()
        F200ButtonCN7.Show()
    End Sub
    Private Sub F200level7()
        F200ComboBoxCN8.Show()
        F200LabelCN8.Show()
        F200LabelG8.Show()
        F200LabelCU8.Show()
        F200LabelQP8.Show()
        F200TextBoxCN8.Show()
        F200ButtonCN8.Show()
    End Sub
    Private Sub F200level8()
        F200ComboBoxCN9.Show()
        F200LabelCN9.Show()
        F200LabelG9.Show()
        F200LabelCU9.Show()
        F200LabelQP9.Show()
        F200TextBoxCN9.Show()
        F200ButtonCN9.Show()
    End Sub
    Private Sub F200level9()
        F200ComboBoxCN10.Show()
        F200LabelCN10.Show()
        F200LabelG10.Show()
        F200LabelCU10.Show()
        F200LabelQP10.Show()
        F200TextBoxCN10.Show()
        F200ButtonCN10.Show()
    End Sub
    Private Sub F200level10()
        F200ComboBoxCN11.Show()
        F200LabelCN11.Show()
        F200LabelG11.Show()
        F200LabelCU11.Show()
        F200LabelQP11.Show()
        F200TextBoxCN11.Show()
        F200ButtonCN11.Show()
    End Sub
    Private Sub F200level11()
        F200ComboBoxCN12.Show()
        F200LabelCN12.Show()
        F200LabelG12.Show()
        F200LabelCU12.Show()
        F200LabelQP12.Show()
        F200TextBoxCN12.Show()
        F200ButtonCN12.Show()
    End Sub
    Private Sub F200level12()
        F200ComboBoxCN13.Show()
        F200LabelCN13.Show()
        F200LabelG13.Show()
        F200LabelCU13.Show()
        F200LabelQP13.Show()
        F200TextBoxCN13.Show()
        F200ButtonCN13.Show()
    End Sub
    Private Sub F200level13()
        F200ComboBoxCN14.Show()
        F200LabelCN14.Show()
        F200LabelG14.Show()
        F200LabelCU14.Show()
        F200LabelQP14.Show()
        F200TextBoxCN14.Show()
        F200ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub f200hope()
        Call f200coursera()
        F200ListBoxhopeCode.Items.Clear()
        f200listboxhopename.Items.Clear()
        f200listboxhopeunit.Items.Clear()
        F200ListBoxF.Items.Clear()
        F200ListBoxFC.Items.Clear()
        F200ListBoxFN.Items.Clear()
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = F200ListBoxCourseCode.Items(i).ToString
            Dim morga As String = F200ListBoxCourseName.Items(i).ToString
            Dim morg As String = F200ListBoxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F200ListBoxCourseName.Items(i).ToString
            Dim gwen As String = F200ListBoxCreditUnit.Items(i).ToString
            If (F200ButtonCN1.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN2.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN3.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN4.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN5.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN6.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN7.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN8.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN9.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN10.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN11.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN12.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN13.Text = F200ListBoxCourseCode.Items(i).ToString) Or (F200ButtonCN14.Text = F200ListBoxCourseCode.Items(i).ToString) Then
                F200ListBoxhopeCode.Items.Remove(i)
                f200listboxhopename.Items.Remove(i)
                f200listboxhopeunit.Items.Remove(i)
            Else
                F200ListBoxhopeCode.Items.Add(morgan)
                f200listboxhopename.Items.Add(morga)
                f200listboxhopeunit.Items.Add(morg)
            End If
            If (F200ButtonCN1.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG1.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN2.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG2.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN3.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG3.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN4.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG4.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN5.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG5.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN6.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG6.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN7.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG7.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN8.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG8.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN9.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG9.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN10.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG10.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN11.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG11.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN12.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG12.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN13.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG13.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
            If (F200ButtonCN14.Text = F200ListBoxCourseCode.Items(i).ToString) And F200LabelG14.Text = merlin Then
                F200ListBoxF.Items.Add(morgan)
                F200ListBoxFN.Items.Add(arthur)
                F200ListBoxFC.Items.Add(gwen)
            Else
                F200ListBoxF.Items.Remove(i)
            End If
        Next
        Call nigga()
    End Sub
    Private Sub F200oleku()
        If F200ButtonCN1.Text = "-" Then
            F200TextBoxCN1.Enabled = False
        Else
            F200TextBoxCN1.Enabled = True
        End If
        If F200ButtonCN2.Text = "-" Then
            F200TextBoxCN2.Enabled = False
        Else
            F200TextBoxCN2.Enabled = True
        End If
        If F200ButtonCN3.Text = "-" Then
            F200TextBoxCN3.Enabled = False
        Else
            F200TextBoxCN3.Enabled = True
        End If
        If F200ButtonCN4.Text = "-" Then
            F200TextBoxCN4.Enabled = False
        Else
            F200TextBoxCN4.Enabled = True
        End If
        If F200ButtonCN5.Text = "-" Then
            F200TextBoxCN5.Enabled = False
        Else
            F200TextBoxCN5.Enabled = True
        End If
        If F200ButtonCN6.Text = "-" Then
            F200TextBoxCN6.Enabled = False
        Else
            F200TextBoxCN6.Enabled = True
        End If
        If F200ButtonCN7.Text = "-" Then
            F200TextBoxCN7.Enabled = False
        Else
            F200TextBoxCN7.Enabled = True
        End If
        If F200ButtonCN8.Text = "-" Then
            F200TextBoxCN8.Enabled = False
        Else
            F200TextBoxCN8.Enabled = True
        End If
        If F200ButtonCN9.Text = "-" Then
            F200TextBoxCN9.Enabled = False
        Else
            F200TextBoxCN9.Enabled = True
        End If
        If F200ButtonCN10.Text = "-" Then
            F200TextBoxCN10.Enabled = False
        Else
            F200TextBoxCN10.Enabled = True
        End If
        If F200ButtonCN11.Text = "-" Then
            F200TextBoxCN11.Enabled = False
        Else
            F200TextBoxCN11.Enabled = True
        End If
        If F200ButtonCN12.Text = "-" Then
            F200TextBoxCN12.Enabled = False
        Else
            F200TextBoxCN12.Enabled = True
        End If
        If F200ButtonCN13.Text = "-" Then
            F200TextBoxCN13.Enabled = False
        Else
            F200TextBoxCN13.Enabled = True
        End If
        If F200ButtonCN14.Text = "-" Then
            F200TextBoxCN14.Enabled = False
        Else
            F200TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub F200TOtalcreditunit()
        Dim f200totalcu As Integer
        f200totalcu = Val(F200LabelCU1.Text) + Val(F200LabelCU2.Text) + Val(F200LabelCU3.Text) + Val(F200LabelCU4.Text) + Val(F200LabelCU5.Text) + Val(F200LabelCU6.Text) + Val(F200LabelCU7.Text) + Val(F200LabelCU8.Text) + Val(F200LabelCU9.Text) + Val(F200LabelCU10.Text) + Val(F200LabelCU11.Text) + Val(F200LabelCU12.Text) + Val(F200LabelCU13.Text) + Val(F200LabelCU14.Text)
        f200cu = f200totalcu
        y200TOTALCUlabel.Text = f200totalcu
        Call nigga()
    End Sub
    Private Sub F200TOtalqp()
        Dim F200totalqp As Integer
        F200LabelQP1.Text = Val(F200labelpt1.Text) * Val(F200LabelCU1.Text)
        F200LabelQP2.Text = Val(F200labelpt2.Text) * Val(F200LabelCU2.Text)
        F200LabelQP3.Text = Val(F200labelpt3.Text) * Val(F200LabelCU3.Text)
        F200LabelQP4.Text = Val(F200labelpt4.Text) * Val(F200LabelCU4.Text)
        F200LabelQP5.Text = Val(F200labelpt5.Text) * Val(F200LabelCU5.Text)
        F200LabelQP6.Text = Val(F200labelpt6.Text) * Val(F200LabelCU6.Text)
        F200LabelQP7.Text = Val(F200labelpt7.Text) * Val(F200LabelCU7.Text)
        F200LabelQP8.Text = Val(F200labelpt8.Text) * Val(F200LabelCU8.Text)
        F200LabelQP9.Text = Val(F200labelpt9.Text) * Val(F200LabelCU9.Text)
        F200LabelQP10.Text = Val(F200labelpt10.Text) * Val(F200LabelCU10.Text)
        F200LabelQP11.Text = Val(F200labelpt11.Text) * Val(F200LabelCU11.Text)
        F200LabelQP12.Text = Val(F200labelpt12.Text) * Val(F200LabelCU12.Text)
        F200LabelQP13.Text = Val(F200labelpt13.Text) * Val(F200LabelCU13.Text)
        F200LabelQP14.Text = Val(F200labelpt14.Text) * Val(F200LabelCU14.Text)
        F200totalqp = Val(F200LabelQP1.Text) + Val(F200LabelQP2.Text) + Val(F200LabelQP3.Text) + Val(F200LabelQP4.Text) + Val(F200LabelQP5.Text) + Val(F200LabelQP6.Text) + Val(F200LabelQP7.Text) + Val(F200LabelQP8.Text) + Val(F200LabelQP9.Text) + Val(F200LabelQP10.Text) + Val(F200LabelQP11.Text) + Val(F200LabelQP12.Text) + Val(F200LabelQP13.Text) + Val(F200LabelQP14.Text)
        f200qp = F200totalqp
        y200TOTALQPlabel.Text = F200totalqp
        Dim cg As Double
        cg = Val(y200TOTALQPlabel.Text) / Val(y200TOTALCUlabel.Text)
        cg = Math.Round(cg, 2)
        Label200GPA.Text = cg
        Call nigga()
    End Sub
    'f300
    ' USED TO HIDE SOME CONTROLS
    Private Sub F300level1()
        F300ComboBoxCN2.Show()
        F300LabelCN2.Show()
        F300LabelG2.Show()
        F300LabelCU2.Show()
        F300LabelQP2.Show()
        F300TextBoxCN2.Show()
        F300ButtonCN2.Show()
    End Sub
    Private Sub F300level2()
        F300ComboBoxCN3.Show()
        F300LabelCN3.Show()
        F300LabelG3.Show()
        F300LabelCU3.Show()
        F300LabelQP3.Show()
        F300TextBoxCN3.Show()
        F300ButtonCN3.Show()
    End Sub
    Private Sub F300level3()
        F300ComboBoxCN4.Show()
        F300LabelCN4.Show()
        F300LabelG4.Show()
        F300LabelCU4.Show()
        F300LabelQP4.Show()
        F300TextBoxCN4.Show()
        F300ButtonCN4.Show()
    End Sub
    Private Sub F300level4()
        F300ComboBoxCN5.Show()
        F300LabelCN5.Show()
        F300LabelG5.Show()
        F300LabelCU5.Show()
        F300LabelQP5.Show()
        F300TextBoxCN5.Show()
        F300ButtonCN5.Show()
    End Sub
    Private Sub F300level5()
        F300ComboBoxCN6.Show()
        F300LabelCN6.Show()
        F300LabelG6.Show()
        F300LabelCU6.Show()
        F300LabelQP6.Show()
        F300TextBoxCN6.Show()
        F300ButtonCN6.Show()
    End Sub
    Private Sub F300level6()
        F300ComboBoxCN7.Show()
        F300LabelCN7.Show()
        F300LabelG7.Show()
        F300LabelCU7.Show()
        F300LabelQP7.Show()
        F300TextBoxCN7.Show()
        F300ButtonCN7.Show()
    End Sub
    Private Sub F300level7()
        F300ComboBoxCN8.Show()
        F300LabelCN8.Show()
        F300LabelG8.Show()
        F300LabelCU8.Show()
        F300LabelQP8.Show()
        F300TextBoxCN8.Show()
        F300ButtonCN8.Show()
    End Sub
    Private Sub F300level8()
        F300ComboBoxCN9.Show()
        F300LabelCN9.Show()
        F300LabelG9.Show()
        F300LabelCU9.Show()
        F300LabelQP9.Show()
        F300TextBoxCN9.Show()
        F300ButtonCN9.Show()
    End Sub
    Private Sub F300level9()
        F300ComboBoxCN10.Show()
        F300LabelCN10.Show()
        F300LabelG10.Show()
        F300LabelCU10.Show()
        F300LabelQP10.Show()
        F300TextBoxCN10.Show()
        F300ButtonCN10.Show()
    End Sub
    Private Sub F300level10()
        F300ComboBoxCN11.Show()
        F300LabelCN11.Show()
        F300LabelG11.Show()
        F300LabelCU11.Show()
        F300LabelQP11.Show()
        F300TextBoxCN11.Show()
        F300ButtonCN11.Show()
    End Sub
    Private Sub F300level11()
        F300ComboBoxCN12.Show()
        F300LabelCN12.Show()
        F300LabelG12.Show()
        F300LabelCU12.Show()
        F300LabelQP12.Show()
        F300TextBoxCN12.Show()
        F300ButtonCN12.Show()
    End Sub
    Private Sub F300level12()
        F300ComboBoxCN13.Show()
        F300LabelCN13.Show()
        F300LabelG13.Show()
        F300LabelCU13.Show()
        F300LabelQP13.Show()
        F300TextBoxCN13.Show()
        F300ButtonCN13.Show()
    End Sub
    Private Sub F300level13()
        F300ComboBoxCN14.Show()
        F300LabelCN14.Show()
        F300LabelG14.Show()
        F300LabelCU14.Show()
        F300LabelQP14.Show()
        F300TextBoxCN14.Show()
        F300ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub f300hope()
        Call f300coursera()
        F300ListBoxhopecode.Items.Clear()
        f300listboxhopename.Items.Clear()
        f300listboxhopeunit.Items.Clear()
        F300ListBoxF.Items.Clear()
        F300ListBoxFC.Items.Clear()
        F300ListBoxFN.Items.Clear()
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = F300ListBoxCourseCode.Items(i).ToString
            Dim morga As String = F300ListBoxCourseName.Items(i).ToString
            Dim morg As String = F300ListBoxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F300ListBoxCourseName.Items(i).ToString
            Dim gwen As String = F300ListBoxCreditUnit.Items(i).ToString
            If (F300ButtonCN1.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN2.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN3.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN4.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN5.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN6.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN7.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN8.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN9.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN10.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN11.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN12.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN13.Text = F300ListBoxCourseCode.Items(i).ToString) Or (F300ButtonCN14.Text = F300ListBoxCourseCode.Items(i).ToString) Then
                F300ListBoxhopecode.Items.Remove(i)
                f300listboxhopename.Items.Remove(i)
                f300listboxhopeunit.Items.Remove(i)
            Else
                F300ListBoxhopecode.Items.Add(morgan)
                f300listboxhopename.Items.Add(morga)
                f300listboxhopeunit.Items.Add(morg)
            End If
            If (F300ButtonCN1.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG1.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN2.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG2.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN3.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG3.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN4.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG4.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN5.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG5.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN6.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG6.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN7.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG7.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN8.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG8.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN9.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG9.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN10.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG10.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN11.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG11.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN12.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG12.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN13.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG13.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
            If (F300ButtonCN14.Text = F300ListBoxCourseCode.Items(i).ToString) And F300LabelG14.Text = merlin Then
                F300ListBoxF.Items.Add(morgan)
                F300ListBoxFN.Items.Add(arthur)
                F300ListBoxFC.Items.Add(gwen)
            Else
                F300ListBoxF.Items.Remove(i)
            End If
        Next
        Call nigga()
    End Sub
    Private Sub F300oleku()
        If F300ButtonCN1.Text = "-" Then
            F300TextBoxCN1.Enabled = False
        Else
            F300TextBoxCN1.Enabled = True
        End If
        If F300ButtonCN2.Text = "-" Then
            F300TextBoxCN2.Enabled = False
        Else
            F300TextBoxCN2.Enabled = True
        End If
        If F300ButtonCN3.Text = "-" Then
            F300TextBoxCN3.Enabled = False
        Else
            F300TextBoxCN3.Enabled = True
        End If
        If F300ButtonCN4.Text = "-" Then
            F300TextBoxCN4.Enabled = False
        Else
            F300TextBoxCN4.Enabled = True
        End If
        If F300ButtonCN5.Text = "-" Then
            F300TextBoxCN5.Enabled = False
        Else
            F300TextBoxCN5.Enabled = True
        End If
        If F300ButtonCN6.Text = "-" Then
            F300TextBoxCN6.Enabled = False
        Else
            F300TextBoxCN6.Enabled = True
        End If
        If F300ButtonCN7.Text = "-" Then
            F300TextBoxCN7.Enabled = False
        Else
            F300TextBoxCN7.Enabled = True
        End If
        If F300ButtonCN8.Text = "-" Then
            F300TextBoxCN8.Enabled = False
        Else
            F300TextBoxCN8.Enabled = True
        End If
        If F300ButtonCN9.Text = "-" Then
            F300TextBoxCN9.Enabled = False
        Else
            F300TextBoxCN9.Enabled = True
        End If
        If F300ButtonCN10.Text = "-" Then
            F300TextBoxCN10.Enabled = False
        Else
            F300TextBoxCN10.Enabled = True
        End If
        If F300ButtonCN11.Text = "-" Then
            F300TextBoxCN11.Enabled = False
        Else
            F300TextBoxCN11.Enabled = True
        End If
        If F300ButtonCN12.Text = "-" Then
            F300TextBoxCN12.Enabled = False
        Else
            F300TextBoxCN12.Enabled = True
        End If
        If F300ButtonCN13.Text = "-" Then
            F300TextBoxCN13.Enabled = False
        Else
            F300TextBoxCN13.Enabled = True
        End If
        If F300ButtonCN14.Text = "-" Then
            F300TextBoxCN14.Enabled = False
        Else
            F300TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub F300TOtalcreditunit()
        Dim f300totalcu As Integer
        f300totalcu = Val(F300LabelCU1.Text) + Val(F300LabelCU2.Text) + Val(F300LabelCU3.Text) + Val(F300LabelCU4.Text) + Val(F300LabelCU5.Text) + Val(F300LabelCU6.Text) + Val(F300LabelCU7.Text) + Val(F300LabelCU8.Text) + Val(F300LabelCU9.Text) + Val(F300LabelCU10.Text) + Val(F300LabelCU11.Text) + Val(F300LabelCU12.Text) + Val(F300LabelCU13.Text) + Val(F300LabelCU14.Text)
        f300cu = f300totalcu
        F300TOTALCUlabel.Text = f300cu
        Call nigga()
    End Sub
    Private Sub F300TOtalqp()
        Dim F300totalqp As Integer
        F300LabelQP1.Text = Val(F300labelpt1.Text) * Val(F300LabelCU1.Text)
        F300LabelQP2.Text = Val(F300labelpt2.Text) * Val(F300LabelCU2.Text)
        F300LabelQP3.Text = Val(F300labelpt3.Text) * Val(F300LabelCU3.Text)
        F300LabelQP4.Text = Val(F300labelpt4.Text) * Val(F300LabelCU4.Text)
        F300LabelQP5.Text = Val(F300labelpt5.Text) * Val(F300LabelCU5.Text)
        F300LabelQP6.Text = Val(F300labelpt6.Text) * Val(F300LabelCU6.Text)
        F300LabelQP7.Text = Val(F300labelpt7.Text) * Val(F300LabelCU7.Text)
        F300LabelQP8.Text = Val(F300labelpt8.Text) * Val(F300LabelCU8.Text)
        F300LabelQP9.Text = Val(F300labelpt9.Text) * Val(F300LabelCU9.Text)
        F300LabelQP10.Text = Val(F300labelpt10.Text) * Val(F300LabelCU10.Text)
        F300LabelQP11.Text = Val(F300labelpt11.Text) * Val(F300LabelCU11.Text)
        F300LabelQP12.Text = Val(F300labelpt12.Text) * Val(F300LabelCU12.Text)
        F300LabelQP13.Text = Val(F300labelpt13.Text) * Val(F300LabelCU13.Text)
        F300LabelQP14.Text = Val(F300labelpt14.Text) * Val(F300LabelCU14.Text)
        F300totalqp = Val(F300LabelQP1.Text) + Val(F300LabelQP2.Text) + Val(F300LabelQP3.Text) + Val(F300LabelQP4.Text) + Val(F300LabelQP5.Text) + Val(F300LabelQP6.Text) + Val(F300LabelQP7.Text) + Val(F300LabelQP8.Text) + Val(F300LabelQP9.Text) + Val(F300LabelQP10.Text) + Val(F300LabelQP11.Text) + Val(F300LabelQP12.Text) + Val(F300LabelQP13.Text) + Val(F300LabelQP14.Text)
        f300qp = F300totalqp
        F300TOTALCUlabel.Text = f300cu
        F300TOTALQPlabel.Text = f300qp
        Label300GPA.Text = Math.Round(f300qp / f300cu, 2)
        Call nigga()
    End Sub
    'f400
    ' USED TO HIDE SOME CONTROLS
    Private Sub F400level1()
        F400ComboBoxCN2.Show()
        F400LabelCN2.Show()
        F400LabelG2.Show()
        F400LabelCU2.Show()
        F400LabelQP2.Show()
        F400TextBoxCN2.Show()
        F400ButtonCN2.Show()
    End Sub
    Private Sub F400level2()
        F400ComboBoxCN3.Show()
        F400LabelCN3.Show()
        F400LabelG3.Show()
        F400LabelCU3.Show()
        F400LabelQP3.Show()
        F400TextBoxCN3.Show()
        F400ButtonCN3.Show()
    End Sub
    Private Sub F400level3()
        F400ComboBoxCN4.Show()
        F400LabelCN4.Show()
        F400LabelG4.Show()
        F400LabelCU4.Show()
        F400LabelQP4.Show()
        F400TextBoxCN4.Show()
        F400ButtonCN4.Show()
    End Sub
    Private Sub F400level4()
        F400ComboBoxCN5.Show()
        F400LabelCN5.Show()
        F400LabelG5.Show()
        F400LabelCU5.Show()
        F400LabelQP5.Show()
        F400TextBoxCN5.Show()
        F400ButtonCN5.Show()
    End Sub
    Private Sub F400level5()
        F400ComboBoxCN6.Show()
        F400LabelCN6.Show()
        F400LabelG6.Show()
        F400LabelCU6.Show()
        F400LabelQP6.Show()
        F400TextBoxCN6.Show()
        F400ButtonCN6.Show()
    End Sub
    Private Sub F400level6()
        F400ComboBoxCN7.Show()
        F400LabelCN7.Show()
        F400LabelG7.Show()
        F400LabelCU7.Show()
        F400LabelQP7.Show()
        F400TextBoxCN7.Show()
        F400ButtonCN7.Show()
    End Sub
    Private Sub F400level7()
        F400ComboBoxCN8.Show()
        F400LabelCN8.Show()
        F400LabelG8.Show()
        F400LabelCU8.Show()
        F400LabelQP8.Show()
        F400TextBoxCN8.Show()
        F400ButtonCN8.Show()
    End Sub
    Private Sub F400level8()
        F400ComboBoxCN9.Show()
        F400LabelCN9.Show()
        F400LabelG9.Show()
        F400LabelCU9.Show()
        F400LabelQP9.Show()
        F400TextBoxCN9.Show()
        F400ButtonCN9.Show()
    End Sub
    Private Sub F400level9()
        F400ComboBoxCN10.Show()
        F400LabelCN10.Show()
        F400LabelG10.Show()
        F400LabelCU10.Show()
        F400LabelQP10.Show()
        F400TextBoxCN10.Show()
        F400ButtonCN10.Show()
    End Sub
    Private Sub F400level10()
        F400ComboBoxCN11.Show()
        F400LabelCN11.Show()
        F400LabelG11.Show()
        F400LabelCU11.Show()
        F400LabelQP11.Show()
        F400TextBoxCN11.Show()
        F400ButtonCN11.Show()
    End Sub
    Private Sub F400level11()
        F400ComboBoxCN12.Show()
        F400LabelCN12.Show()
        F400LabelG12.Show()
        F400LabelCU12.Show()
        F400LabelQP12.Show()
        F400TextBoxCN12.Show()
        F400ButtonCN12.Show()
    End Sub
    Private Sub F400level12()
        F400ComboBoxCN13.Show()
        F400LabelCN13.Show()
        F400LabelG13.Show()
        F400LabelCU13.Show()
        F400LabelQP13.Show()
        F400TextBoxCN13.Show()
        F400ButtonCN13.Show()
    End Sub
    Private Sub F400level13()
        F400ComboBoxCN14.Show()
        F400LabelCN14.Show()
        F400LabelG14.Show()
        F400LabelCU14.Show()
        F400LabelQP14.Show()
        F400TextBoxCN14.Show()
        F400ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub f400hope()
        Call f400coursera()
        F400ListBoxhopecode.Items.Clear()
        f400listboxhopename.Items.Clear()
        f400listboxhopeunit.Items.Clear()
        F400ListBoxF.Items.Clear()
        F400ListBoxFC.Items.Clear()
        F400ListBoxFN.Items.Clear()
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = F400ListBoxCourseCode.Items(i).ToString
            Dim morga As String = F400ListBoxCourseName.Items(i).ToString
            Dim morg As String = F400ListBoxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F400ListBoxCourseName.Items(i).ToString
            Dim gwen As String = F400ListBoxCreditUnit.Items(i).ToString
            If (F400ButtonCN1.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN2.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN3.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN4.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN5.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN6.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN7.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN8.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN9.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN10.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN11.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN12.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN13.Text = F400ListBoxCourseCode.Items(i).ToString) Or (F400ButtonCN14.Text = F400ListBoxCourseCode.Items(i).ToString) Then
                F400ListBoxhopecode.Items.Remove(i)
                f400listboxhopename.Items.Remove(i)
                f400listboxhopeunit.Items.Remove(i)
            Else
                F400ListBoxhopecode.Items.Add(morgan)
                f400listboxhopename.Items.Add(morga)
                f400listboxhopeunit.Items.Add(morg)
            End If
            If (F400ButtonCN1.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG1.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN2.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG2.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN3.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG3.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN4.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG4.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN5.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG5.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN6.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG6.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN7.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG7.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN8.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG8.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN9.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG9.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN10.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG10.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN11.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG11.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN12.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG12.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN13.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG13.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
            If (F400ButtonCN14.Text = F400ListBoxCourseCode.Items(i).ToString) And F400LabelG14.Text = merlin Then
                F400ListBoxF.Items.Add(morgan)
                F400ListBoxFN.Items.Add(arthur)
                F400ListBoxFC.Items.Add(gwen)
            Else
                F400ListBoxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub F400oleku()
        If F400ButtonCN1.Text = "-" Then
            F400TextBoxCN1.Enabled = False
        Else
            F400TextBoxCN1.Enabled = True
        End If
        If F400ButtonCN2.Text = "-" Then
            F400TextBoxCN2.Enabled = False
        Else
            F400TextBoxCN2.Enabled = True
        End If
        If F400ButtonCN3.Text = "-" Then
            F400TextBoxCN3.Enabled = False
        Else
            F400TextBoxCN3.Enabled = True
        End If
        If F400ButtonCN4.Text = "-" Then
            F400TextBoxCN4.Enabled = False
        Else
            F400TextBoxCN4.Enabled = True
        End If
        If F400ButtonCN5.Text = "-" Then
            F400TextBoxCN5.Enabled = False
        Else
            F400TextBoxCN5.Enabled = True
        End If
        If F400ButtonCN6.Text = "-" Then
            F400TextBoxCN6.Enabled = False
        Else
            F400TextBoxCN6.Enabled = True
        End If
        If F400ButtonCN7.Text = "-" Then
            F400TextBoxCN7.Enabled = False
        Else
            F400TextBoxCN7.Enabled = True
        End If
        If F400ButtonCN8.Text = "-" Then
            F400TextBoxCN8.Enabled = False
        Else
            F400TextBoxCN8.Enabled = True
        End If
        If F400ButtonCN9.Text = "-" Then
            F400TextBoxCN9.Enabled = False
        Else
            F400TextBoxCN9.Enabled = True
        End If
        If F400ButtonCN10.Text = "-" Then
            F400TextBoxCN10.Enabled = False
        Else
            F400TextBoxCN10.Enabled = True
        End If
        If F400ButtonCN11.Text = "-" Then
            F400TextBoxCN11.Enabled = False
        Else
            F400TextBoxCN11.Enabled = True
        End If
        If F400ButtonCN12.Text = "-" Then
            F400TextBoxCN12.Enabled = False
        Else
            F400TextBoxCN12.Enabled = True
        End If
        If F400ButtonCN13.Text = "-" Then
            F400TextBoxCN13.Enabled = False
        Else
            F400TextBoxCN13.Enabled = True
        End If
        If F400ButtonCN14.Text = "-" Then
            F400TextBoxCN14.Enabled = False
        Else
            F400TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub F400TOtalcreditunit()
        Dim f400totalcu As Integer
        f400totalcu = Val(F400LabelCU1.Text) + Val(F400LabelCU2.Text) + Val(F400LabelCU3.Text) + Val(F400LabelCU4.Text) + Val(F400LabelCU5.Text) + Val(F400LabelCU6.Text) + Val(F400LabelCU7.Text) + Val(F400LabelCU8.Text) + Val(F400LabelCU9.Text) + Val(F400LabelCU10.Text) + Val(F400LabelCU11.Text) + Val(F400LabelCU12.Text) + Val(F400LabelCU13.Text) + Val(F400LabelCU14.Text)
        f400cu = f400totalcu
        F400TOTALCUlabel.Text = f400cu
        Call nigga()
    End Sub
    Private Sub F400TOtalqp()
        Dim F400totalqp As Integer
        F400LabelQP1.Text = Val(F400labelpt1.Text) * Val(F400LabelCU1.Text)
        F400LabelQP2.Text = Val(F400labelpt2.Text) * Val(F400LabelCU2.Text)
        F400LabelQP3.Text = Val(F400labelpt3.Text) * Val(F400LabelCU3.Text)
        F400LabelQP4.Text = Val(F400labelpt4.Text) * Val(F400LabelCU4.Text)
        F400LabelQP5.Text = Val(F400labelpt5.Text) * Val(F400LabelCU5.Text)
        F400LabelQP6.Text = Val(F400labelpt6.Text) * Val(F400LabelCU6.Text)
        F400LabelQP7.Text = Val(F400labelpt7.Text) * Val(F400LabelCU7.Text)
        F400LabelQP8.Text = Val(F400labelpt8.Text) * Val(F400LabelCU8.Text)
        F400LabelQP9.Text = Val(F400labelpt9.Text) * Val(F400LabelCU9.Text)
        F400LabelQP10.Text = Val(F400labelpt10.Text) * Val(F400LabelCU10.Text)
        F400LabelQP11.Text = Val(F400labelpt11.Text) * Val(F400LabelCU11.Text)
        F400LabelQP12.Text = Val(F400labelpt12.Text) * Val(F400LabelCU12.Text)
        F400LabelQP13.Text = Val(F400labelpt13.Text) * Val(F400LabelCU13.Text)
        F400LabelQP14.Text = Val(F400labelpt14.Text) * Val(F400LabelCU14.Text)
        F400totalqp = Val(F400LabelQP1.Text) + Val(F400LabelQP2.Text) + Val(F400LabelQP3.Text) + Val(F400LabelQP4.Text) + Val(F400LabelQP5.Text) + Val(F400LabelQP6.Text) + Val(F400LabelQP7.Text) + Val(F400LabelQP8.Text) + Val(F400LabelQP9.Text) + Val(F400LabelQP10.Text) + Val(F400LabelQP11.Text) + Val(F400LabelQP12.Text) + Val(F400LabelQP13.Text) + Val(F400LabelQP14.Text)
        f400qp = F400totalqp
        F400TOTALQPlabel.Text = f400qp
        F400TOTALCUlabel.Text = f400cu
        Label400GPA.Text = Math.Round(f400qp / f400cu, 2)
        Call nigga()
    End Sub

    'f500
    ' USED TO HIDE SOME CONTROLS
    Private Sub F500level1()
        F500ComboBoxCN2.Show()
        F500LabelCN2.Show()
        F500LabeG2.Show()
        F500LabelCU2.Show()
        F500LabelQP2.Show()
        F500TextBoxCN2.Show()
        F500ButtonCN2.Show()
    End Sub
    Private Sub F500level2()
        F500ComboBoxCN3.Show()
        F500LabelCN3.Show()
        F500LabeG3.Show()
        F500LabelCU3.Show()
        F500LabelQP3.Show()
        F500TextBoxCN3.Show()
        F500ButtonCN3.Show()
    End Sub
    Private Sub F500level3()
        F500ComboBoxCN4.Show()
        F500LabelCN4.Show()
        F500LabeG4.Show()
        F500LabelCU4.Show()
        F500LabelQP4.Show()
        F500TextBoxCN4.Show()
        F500ButtonCN4.Show()
    End Sub
    Private Sub F500level4()
        F500ComboBoxCN5.Show()
        F500LabelCN5.Show()
        F500LabeG5.Show()
        F500LabelCU5.Show()
        F500LabelQP5.Show()
        F500TextBoxCN5.Show()
        F500ButtonCN5.Show()
    End Sub
    Private Sub F500level5()
        F500ComboBoxCN6.Show()
        F500LabelCN6.Show()
        F500LabeG6.Show()
        F500LabelCU6.Show()
        F500LabelQP6.Show()
        F500TextBoxCN6.Show()
        F500ButtonCN6.Show()
    End Sub
    Private Sub F500level6()
        F500ComboBoxCN7.Show()
        F500LabelCN7.Show()
        F500LabeG7.Show()
        F500LabelCU7.Show()
        F500LabelQP7.Show()
        F500TextBoxCN7.Show()
        F500ButtonCN7.Show()
    End Sub
    Private Sub F500level7()
        F500ComboBoxCN8.Show()
        F500LabelCN8.Show()
        F500LabeG8.Show()
        F500LabelCU8.Show()
        F500LabelQP8.Show()
        F500TextBoxCN8.Show()
        F500ButtonCN8.Show()
    End Sub
    Private Sub F500level8()
        F500ComboBoxCN9.Show()
        F500LabelCN9.Show()
        F500LabeG9.Show()
        F500LabelCU9.Show()
        F500LabelQP9.Show()
        F500TextBoxCN9.Show()
        F500ButtonCN9.Show()
    End Sub
    Private Sub F500level9()
        F500ComboBoxCN10.Show()
        F500LabelCN10.Show()
        F500LabeG10.Show()
        F500LabelCU10.Show()
        F500LabelQP10.Show()
        F500TextBoxCN10.Show()
        F500ButtonCN10.Show()
    End Sub
    Private Sub F500level10()
        F500ComboBoxCN11.Show()
        F500LabelCN11.Show()
        F500LabeG11.Show()
        F500LabelCU11.Show()
        F500LabelQP11.Show()
        F500TextBoxCN11.Show()
        F500ButtonCN11.Show()
    End Sub
    Private Sub F500level11()
        F500ComboBoxCN12.Show()
        F500LabelCN12.Show()
        F500LabeG12.Show()
        F500LabelCU12.Show()
        F500LabelQP12.Show()
        F500TextBoxCN12.Show()
        F500ButtonCN12.Show()
    End Sub
    Private Sub F500level12()
        F500ComboBoxCN13.Show()
        F500LabelCN13.Show()
        F500LabeG13.Show()
        F500LabelCU13.Show()
        F500LabelQP13.Show()
        F500TextBoxCN13.Show()
        F500ButtonCN13.Show()
    End Sub
    Private Sub F500level13()
        F500ComboBoxCN14.Show()
        F500LabelCN14.Show()
        F500LabeG14.Show()
        F500LabelCU14.Show()
        F500LabelQP14.Show()
        F500TextBoxCN14.Show()
        F500ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub f500hope()
        Call f500coursera()
        F500Listboxhopecode.Items.Clear()
        f500listboxhopename.Items.Clear()
        f500listboxhopeunit.Items.Clear()
        F500ListboxF.Items.Clear()
        F500ListboxFC.Items.Clear()
        F500ListboxFN.Items.Clear()
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            Dim morgan As String = F500ListboxCourseCode.Items(i).ToString
            Dim morga As String = F500ListboxCourseName.Items(i).ToString
            Dim morg As String = F500ListboxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F500ListboxCourseName.Items(i).ToString
            Dim gwen As String = F500ListboxCreditUnit.Items(i).ToString
            If (F500ButtonCN1.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN2.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN3.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN4.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN5.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN6.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN7.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN8.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN9.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN10.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN11.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN12.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN13.Text = F500ListboxCourseCode.Items(i).ToString) Or (F500ButtonCN14.Text = F500ListboxCourseCode.Items(i).ToString) Then
                F500Listboxhopecode.Items.Remove(i)
                f500listboxhopename.Items.Remove(i)
                f500listboxhopeunit.Items.Remove(i)
            Else
                F500Listboxhopecode.Items.Add(morgan)
                f500listboxhopename.Items.Add(morga)
                f500listboxhopeunit.Items.Add(morg)
            End If
            If (F500ButtonCN1.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG1.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN2.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG2.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN3.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG3.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN4.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG4.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN5.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG5.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN6.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG6.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN7.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG7.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN8.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG8.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN9.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG9.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN10.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG10.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN11.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG11.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN12.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG12.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN13.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG13.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
            If (F500ButtonCN14.Text = F500ListboxCourseCode.Items(i).ToString) And F500LabeG14.Text = merlin Then
                F500ListboxF.Items.Add(morgan)
                F500ListboxFN.Items.Add(arthur)
                F500ListboxFC.Items.Add(gwen)
            Else
                F500ListboxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub F500oleku()
        If F500ButtonCN1.Text = "-" Then
            F500TextBoxCN1.Enabled = False
        Else
            F500TextBoxCN1.Enabled = True
        End If
        If F500ButtonCN2.Text = "-" Then
            F500TextBoxCN2.Enabled = False
        Else
            F500TextBoxCN2.Enabled = True
        End If
        If F500ButtonCN3.Text = "-" Then
            F500TextBoxCN3.Enabled = False
        Else
            F500TextBoxCN3.Enabled = True
        End If
        If F500ButtonCN4.Text = "-" Then
            F500TextBoxCN4.Enabled = False
        Else
            F500TextBoxCN4.Enabled = True
        End If
        If F500ButtonCN5.Text = "-" Then
            F500TextBoxCN5.Enabled = False
        Else
            F500TextBoxCN5.Enabled = True
        End If
        If F500ButtonCN6.Text = "-" Then
            F500TextBoxCN6.Enabled = False
        Else
            F500TextBoxCN6.Enabled = True
        End If
        If F500ButtonCN7.Text = "-" Then
            F500TextBoxCN7.Enabled = False
        Else
            F500TextBoxCN7.Enabled = True
        End If
        If F500ButtonCN8.Text = "-" Then
            F500TextBoxCN8.Enabled = False
        Else
            F500TextBoxCN8.Enabled = True
        End If
        If F500ButtonCN9.Text = "-" Then
            F500TextBoxCN9.Enabled = False
        Else
            F500TextBoxCN9.Enabled = True
        End If
        If F500ButtonCN10.Text = "-" Then
            F500TextBoxCN10.Enabled = False
        Else
            F500TextBoxCN10.Enabled = True
        End If
        If F500ButtonCN11.Text = "-" Then
            F500TextBoxCN11.Enabled = False
        Else
            F500TextBoxCN11.Enabled = True
        End If
        If F500ButtonCN12.Text = "-" Then
            F500TextBoxCN12.Enabled = False
        Else
            F500TextBoxCN12.Enabled = True
        End If
        If F500ButtonCN13.Text = "-" Then
            F500TextBoxCN13.Enabled = False
        Else
            F500TextBoxCN13.Enabled = True
        End If
        If F500ButtonCN14.Text = "-" Then
            F500TextBoxCN14.Enabled = False
        Else
            F500TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub F500TOtalcreditunit()
        Dim f500totalcu As Integer
        f500totalcu = Val(F500LabelCU1.Text) + Val(F500LabelCU2.Text) + Val(F500LabelCU3.Text) + Val(F500LabelCU4.Text) + Val(F500LabelCU5.Text) + Val(F500LabelCU6.Text) + Val(F500LabelCU7.Text) + Val(F500LabelCU8.Text) + Val(F500LabelCU9.Text) + Val(F500LabelCU10.Text) + Val(F500LabelCU11.Text) + Val(F500LabelCU12.Text) + Val(F500LabelCU13.Text) + Val(F500LabelCU14.Text)
        f500cu = f500totalcu
        F500TOTALCUlabel.Text = f500cu
        Call nigga()
    End Sub
    Private Sub F500TOtalqp()
        Dim F500totalqp As Integer
        F500LabelQP1.Text = Val(F500labelpt1.Text) * Val(F500LabelCU1.Text)
        F500LabelQP2.Text = Val(F500labelpt2.Text) * Val(F500LabelCU2.Text)
        F500LabelQP3.Text = Val(F500labelpt3.Text) * Val(F500LabelCU3.Text)
        F500LabelQP4.Text = Val(F500labelpt4.Text) * Val(F500LabelCU4.Text)
        F500LabelQP5.Text = Val(F500labelpt5.Text) * Val(F500LabelCU5.Text)
        F500LabelQP6.Text = Val(F500labelpt6.Text) * Val(F500LabelCU6.Text)
        F500LabelQP7.Text = Val(F500labelpt7.Text) * Val(F500LabelCU7.Text)
        F500LabelQP8.Text = Val(F500labelpt8.Text) * Val(F500LabelCU8.Text)
        F500LabelQP9.Text = Val(F500labelpt9.Text) * Val(F500LabelCU9.Text)
        F500LabelQP10.Text = Val(F500labelpt10.Text) * Val(F500LabelCU10.Text)
        F500LabelQP11.Text = Val(F500labelpt11.Text) * Val(F500LabelCU11.Text)
        F500LabelQP12.Text = Val(F500labelpt12.Text) * Val(F500LabelCU12.Text)
        F500LabelQP13.Text = Val(F500labelpt13.Text) * Val(F500LabelCU13.Text)
        F500LabelQP14.Text = Val(F500labelpt14.Text) * Val(F500LabelCU14.Text)
        F500totalqp = Val(F500LabelQP1.Text) + Val(F500LabelQP2.Text) + Val(F500LabelQP3.Text) + Val(F500LabelQP4.Text) + Val(F500LabelQP5.Text) + Val(F500LabelQP6.Text) + Val(F500LabelQP7.Text) + Val(F500LabelQP8.Text) + Val(F500LabelQP9.Text) + Val(F500LabelQP10.Text) + Val(F500LabelQP11.Text) + Val(F500LabelQP12.Text) + Val(F500LabelQP13.Text) + Val(F500LabelQP14.Text)
        f500qp = F500totalqp
        F500TOTALCUlabel.Text = f500cu
        F500TOTALQPlabel.Text = f500qp
        Label500GPA.Text = Math.Round(f500qp / f500cu, 2)
        Call nigga()
    End Sub
    'f600
    ' USED TO HIDE SOME CONTROLS
    Private Sub F600level1()
        F600ComboboxCN2.Show()
        F600LabelCN2.Show()
        F600LabelG2.Show()
        F600LabelCU2.Show()
        F600LabelQP2.Show()
        F600TextboxCN2.Show()
        F600ButtonCN2.Show()
    End Sub
    Private Sub F600level2()
        F600ComboboxCN3.Show()
        F600LabelCN3.Show()
        F600LabelG3.Show()
        F600LabelCU3.Show()
        F600LabelQP3.Show()
        F600TextboxCN3.Show()
        F600ButtonCN3.Show()
    End Sub
    Private Sub F600level3()
        F600ComboboxCN4.Show()
        F600LabelCN4.Show()
        F600LabelG4.Show()
        F600LabelCU4.Show()
        F600LabelQP4.Show()
        F600TextboxCN4.Show()
        F600ButtonCN4.Show()
    End Sub
    Private Sub F600level4()
        F600ComboboxCN5.Show()
        F600LabelCN5.Show()
        F600LabelG5.Show()
        F600LabelCU5.Show()
        F600LabelQP5.Show()
        F600TextboxCN5.Show()
        F600ButtonCN5.Show()
    End Sub
    Private Sub F600level5()
        F600ComboboxCN6.Show()
        F600LabelCN6.Show()
        F600LabelG6.Show()
        F600LabelCU6.Show()
        F600LabelQP6.Show()
        F600TextboxCN6.Show()
        F600ButtonCN6.Show()
    End Sub
    Private Sub F600level6()
        F600ComboboxCN7.Show()
        F600LabelCN7.Show()
        F600LabelG7.Show()
        F600LabelCU7.Show()
        F600LabelQP7.Show()
        F600TextboxCN7.Show()
        F600ButtonCN7.Show()
    End Sub
    Private Sub F600level7()
        F600ComboboxCN8.Show()
        F600LabelCN8.Show()
        F600LabelG8.Show()
        F600LabelCU8.Show()
        F600LabelQP8.Show()
        F600TextboxCN8.Show()
        F600ButtonCN8.Show()
    End Sub
    Private Sub F600level8()
        F600ComboboxCN9.Show()
        F600LabelCN9.Show()
        F600LabelG9.Show()
        F600LabelCU9.Show()
        F600LabelQP9.Show()
        F600TextboxCN9.Show()
        F600ButtonCN9.Show()
    End Sub
    Private Sub F600level9()
        F600ComboboxCN10.Show()
        F600LabelCN10.Show()
        F600LabelG10.Show()
        F600LabelCU10.Show()
        F600LabelQP10.Show()
        F600TextboxCN10.Show()
        F600ButtonCN10.Show()
    End Sub
    Private Sub F600level10()
        F600ComboboxCN11.Show()
        F600LabelCN11.Show()
        F600LabelG11.Show()
        F600LabelCU11.Show()
        F600LabelQP11.Show()
        F600TextboxCN11.Show()
        F600ButtonCN11.Show()
    End Sub
    Private Sub F600level11()
        F600ComboboxCN12.Show()
        F600LabelCN12.Show()
        F600LabelG12.Show()
        F600LabelCU12.Show()
        F600LabelQP12.Show()
        F600TextboxCN12.Show()
        F600ButtonCN12.Show()
    End Sub
    Private Sub F600level12()
        F600ComboboxCN13.Show()
        F600LabelCN13.Show()
        F600LabelG13.Show()
        F600LabelCU13.Show()
        F600LabelQP13.Show()
        F600TextboxCN13.Show()
        F600ButtonCN13.Show()
    End Sub
    Private Sub F600level13()
        F600ComboboxCN14.Show()
        F600LabelCN14.Show()
        F600LabelG14.Show()
        F600LabelCU14.Show()
        F600LabelQP14.Show()
        F600TextboxCN14.Show()
        F600ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub f600hope()
        Call f600coursera()
        F600ListboxhopeCode.Items.Clear()
        f600listboxhopename.Items.Clear()
        f600listboxhopeunit.Items.Clear()
        F600ListboxF.Items.Clear()
        F600ListboxFC.Items.Clear()
        F600ListboxFN.Items.Clear()
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            Dim morgan As String = F600ListboxCourseCode.Items(i).ToString
            Dim morga As String = F600ListboxCourseName.Items(i).ToString
            Dim morg As String = F600Listboxcreditunit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F600ListboxCourseName.Items(i).ToString
            Dim gwen As String = F600Listboxcreditunit.Items(i).ToString
            If (F600ButtonCN1.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN2.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN3.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN4.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN5.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN6.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN7.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN8.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN9.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN10.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN11.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN12.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN13.Text = F600ListboxCourseCode.Items(i).ToString) Or (F600ButtonCN14.Text = F600ListboxCourseCode.Items(i).ToString) Then
                F600ListboxhopeCode.Items.Remove(i)
                f600listboxhopename.Items.Remove(i)
                f600listboxhopeunit.Items.Remove(i)
            Else
                F600ListboxhopeCode.Items.Add(morgan)
                f600listboxhopename.Items.Add(morga)
                f600listboxhopeunit.Items.Add(morg)
            End If
            If (F600ButtonCN1.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG1.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN2.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG2.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN3.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG3.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN4.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG4.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN5.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG5.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN6.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG6.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN7.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG7.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN8.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG8.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN9.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG9.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN10.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG10.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN11.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG11.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN12.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG12.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN13.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG13.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
            If (F600ButtonCN14.Text = F600ListboxCourseCode.Items(i).ToString) And F600LabelG14.Text = merlin Then
                F600ListboxF.Items.Add(morgan)
                F600ListboxFN.Items.Add(arthur)
                F600ListboxFC.Items.Add(gwen)
            Else
                F600ListboxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub F600oleku()
        If F600ButtonCN1.Text = "-" Then
            F600TextboxCN1.Enabled = False
        Else
            F600TextboxCN1.Enabled = True
        End If
        If F600ButtonCN2.Text = "-" Then
            F600TextboxCN2.Enabled = False
        Else
            F600TextboxCN2.Enabled = True
        End If
        If F600ButtonCN3.Text = "-" Then
            F600TextboxCN3.Enabled = False
        Else
            F600TextboxCN3.Enabled = True
        End If
        If F600ButtonCN4.Text = "-" Then
            F600TextboxCN4.Enabled = False
        Else
            F600TextboxCN4.Enabled = True
        End If
        If F600ButtonCN5.Text = "-" Then
            F600TextboxCN5.Enabled = False
        Else
            F600TextboxCN5.Enabled = True
        End If
        If F600ButtonCN6.Text = "-" Then
            F600TextboxCN6.Enabled = False
        Else
            F600TextboxCN6.Enabled = True
        End If
        If F600ButtonCN7.Text = "-" Then
            F600TextboxCN7.Enabled = False
        Else
            F600TextboxCN7.Enabled = True
        End If
        If F600ButtonCN8.Text = "-" Then
            F600TextboxCN8.Enabled = False
        Else
            F600TextboxCN8.Enabled = True
        End If
        If F600ButtonCN9.Text = "-" Then
            F600TextboxCN9.Enabled = False
        Else
            F600TextboxCN9.Enabled = True
        End If
        If F600ButtonCN10.Text = "-" Then
            F600TextboxCN10.Enabled = False
        Else
            F600TextboxCN10.Enabled = True
        End If
        If F600ButtonCN11.Text = "-" Then
            F600TextboxCN11.Enabled = False
        Else
            F600TextboxCN11.Enabled = True
        End If
        If F600ButtonCN12.Text = "-" Then
            F600TextboxCN12.Enabled = False
        Else
            F600TextboxCN12.Enabled = True
        End If
        If F600ButtonCN13.Text = "-" Then
            F600TextboxCN13.Enabled = False
        Else
            F600TextboxCN13.Enabled = True
        End If
        If F600ButtonCN14.Text = "-" Then
            F600TextboxCN14.Enabled = False
        Else
            F600TextboxCN14.Enabled = True
        End If
    End Sub
    Private Sub F600TOtalcreditunit()
        Dim f600totalcu As Integer
        f600totalcu = Val(F600LabelCU1.Text) + Val(F600LabelCU2.Text) + Val(F600LabelCU3.Text) + Val(F600LabelCU4.Text) + Val(F600LabelCU5.Text) + Val(F600LabelCU6.Text) + Val(F600LabelCU7.Text) + Val(F600LabelCU8.Text) + Val(F600LabelCU9.Text) + Val(F600LabelCU10.Text) + Val(F600LabelCU11.Text) + Val(F600LabelCU12.Text) + Val(F600LabelCU13.Text) + Val(F600LabelCU14.Text)
        f600cu = f600totalcu
        F600TOTALCUlabel.Text = f600cu
        Call nigga()
    End Sub
    Private Sub F600TOtalqp()
        Dim F600totalqp As Integer
        F600LabelQP1.Text = Val(F600labelpt1.Text) * Val(F600LabelCU1.Text)
        F600LabelQP2.Text = Val(F600labelpt2.Text) * Val(F600LabelCU2.Text)
        F600LabelQP3.Text = Val(F600labelpt3.Text) * Val(F600LabelCU3.Text)
        F600LabelQP4.Text = Val(F600labelpt4.Text) * Val(F600LabelCU4.Text)
        F600LabelQP5.Text = Val(F600labelpt5.Text) * Val(F600LabelCU5.Text)
        F600LabelQP6.Text = Val(F600labelpt6.Text) * Val(F600LabelCU6.Text)
        F600LabelQP7.Text = Val(F600labelpt7.Text) * Val(F600LabelCU7.Text)
        F600LabelQP8.Text = Val(F600labelpt8.Text) * Val(F600LabelCU8.Text)
        F600LabelQP9.Text = Val(F600labelpt9.Text) * Val(F600LabelCU9.Text)
        F600LabelQP10.Text = Val(F600labelpt10.Text) * Val(F600LabelCU10.Text)
        F600LabelQP11.Text = Val(F600labelpt11.Text) * Val(F600LabelCU11.Text)
        F600LabelQP12.Text = Val(F600labelpt12.Text) * Val(F600LabelCU12.Text)
        F600LabelQP13.Text = Val(F600labelpt13.Text) * Val(F600LabelCU13.Text)
        F600LabelQP14.Text = Val(F600labelpt14.Text) * Val(F600LabelCU14.Text)
        F600totalqp = Val(F600LabelQP1.Text) + Val(F600LabelQP2.Text) + Val(F600LabelQP3.Text) + Val(F600LabelQP4.Text) + Val(F600LabelQP5.Text) + Val(F600LabelQP6.Text) + Val(F600LabelQP7.Text) + Val(F600LabelQP8.Text) + Val(F600LabelQP9.Text) + Val(F600LabelQP10.Text) + Val(F600LabelQP11.Text) + Val(F600LabelQP12.Text) + Val(F600LabelQP13.Text) + Val(F600LabelQP14.Text)
        f600qp = F600totalqp
        F600TOTALCUlabel.Text = f600cu
        F600TOTALQPlabel.Text = f600qp
        Label600GPA.Text = Math.Round(f600qp / f600cu, 2)
        Call nigga()
    End Sub
    'f700
    ' USED TO HIDE SOME CONTROLS
    Private Sub F700level1()
        F700ComboBoxCN2.Show()
        F700LabelCN2.Show()
        F700LabelG2.Show()
        F700LabelCU2.Show()
        F700LabelQP2.Show()
        F700TextBoxCN2.Show()
        F700ButtonCN2.Show()
    End Sub
    Private Sub F700level2()
        F700ComboBoxCN3.Show()
        F700LabelCN3.Show()
        F700LabelG3.Show()
        F700LabelCU3.Show()
        F700LabelQP3.Show()
        F700TextBoxCN3.Show()
        F700ButtonCN3.Show()
    End Sub
    Private Sub F700level3()
        F700ComboBoxCN4.Show()
        F700LabelCN4.Show()
        F700LabelG4.Show()
        F700LabelCU4.Show()
        F700LabelQP4.Show()
        F700TextBoxCN4.Show()
        F700ButtonCN4.Show()
    End Sub
    Private Sub F700level4()
        F700ComboBoxCN5.Show()
        F700LabelCN5.Show()
        F700LabelG5.Show()
        F700LabelCU5.Show()
        F700LabelQP5.Show()
        F700TextBoxCN5.Show()
        F700ButtonCN5.Show()
    End Sub
    Private Sub F700level5()
        F700ComboBoxCN6.Show()
        F700LabelCN6.Show()
        F700LabelG6.Show()
        F700LabelCU6.Show()
        F700LabelQP6.Show()
        F700TextBoxCN6.Show()
        F700ButtonCN6.Show()
    End Sub
    Private Sub F700level6()
        F700ComboBoxCN7.Show()
        F700LabelCN7.Show()
        F700LabelG7.Show()
        F700LabelCU7.Show()
        F700LabelQP7.Show()
        F700TextBoxCN7.Show()
        F700ButtonCN7.Show()
    End Sub
    Private Sub F700level7()
        F700ComboBoxCN8.Show()
        F700LabelCN8.Show()
        F700LabelG8.Show()
        F700LabelCU8.Show()
        F700LabelQP8.Show()
        F700TextBoxCN8.Show()
        F700ButtonCN8.Show()
    End Sub
    Private Sub F700level8()
        F700ComboBoxCN9.Show()
        F700LabelCN9.Show()
        F700LabelG9.Show()
        F700LabelCU9.Show()
        F700LabelQP9.Show()
        F700TextBoxCN9.Show()
        F700ButtonCN9.Show()
    End Sub
    Private Sub F700level9()
        F700ComboBoxCN10.Show()
        F700LabelCN10.Show()
        F700LabelG10.Show()
        F700LabelCU10.Show()
        F700LabelQP10.Show()
        F700TextBoxCN10.Show()
        F700ButtonCN10.Show()
    End Sub
    Private Sub F700level10()
        F700ComboBoxCN11.Show()
        F700LabelCN11.Show()
        F700LabelG11.Show()
        F700LabelCU11.Show()
        F700LabelQP11.Show()
        F700TextBoxCN11.Show()
        F700ButtonCN11.Show()
    End Sub
    Private Sub F700level11()
        F700ComboBoxCN12.Show()
        F700LabelCN12.Show()
        F700LabelG12.Show()
        F700LabelCU12.Show()
        F700LabelQP12.Show()
        F700TextBoxCN12.Show()
        F700ButtonCN12.Show()
    End Sub
    Private Sub F700level12()
        F700ComboBoxCN13.Show()
        F700LabelCN13.Show()
        F700LabelG13.Show()
        F700LabelCU13.Show()
        F700LabelQP13.Show()
        F700TextBoxCN13.Show()
        F700ButtonCN13.Show()
    End Sub
    Private Sub F700level13()
        F700ComboBoxCN14.Show()
        F700LabelCN14.Show()
        F700LabelG14.Show()
        F700LabelCU14.Show()
        F700LabelQP14.Show()
        F700TextBoxCN14.Show()
        F700ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub f700hope()
        Call f700coursera()
        F700ListBoxHopeCode.Items.Clear()
        f700listboxhopename.Items.Clear()
        f700listboxhopeunit.Items.Clear()
        F700ListBoxF.Items.Clear()
        F700ListBoxFC.Items.Clear()
        F700ListBoxFN.Items.Clear()
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = F700ListBoxCourseCode.Items(i).ToString
            Dim morga As String = F700ListBoxCourseName.Items(i).ToString
            Dim morg As String = F700ListBoxCreditunit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F700ListBoxCourseName.Items(i).ToString
            Dim gwen As String = F700ListBoxCreditunit.Items(i).ToString
            If (F700ButtonCN1.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN2.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN3.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN4.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN5.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN6.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN7.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN8.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN9.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN10.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN11.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN12.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN13.Text = F700ListBoxCourseCode.Items(i).ToString) Or (F700ButtonCN14.Text = F700ListBoxCourseCode.Items(i).ToString) Then
                F700ListBoxHopeCode.Items.Remove(i)
                f700listboxhopename.Items.Remove(i)
                f700listboxhopeunit.Items.Remove(i)
            Else
                F700ListBoxHopeCode.Items.Add(morgan)
                f700listboxhopename.Items.Add(morga)
                f700listboxhopeunit.Items.Add(morg)
            End If
            If (F700ButtonCN1.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG1.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN2.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG2.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN3.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG3.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN4.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG4.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN5.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG5.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN6.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG6.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN7.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG7.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN8.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG8.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN9.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG9.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN10.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG10.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN11.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG11.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN12.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG12.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN13.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG13.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
            If (F700ButtonCN14.Text = F700ListBoxCourseCode.Items(i).ToString) And F700LabelG14.Text = merlin Then
                F700ListBoxF.Items.Add(morgan)
                F700ListBoxFN.Items.Add(arthur)
                F700ListBoxFC.Items.Add(gwen)
            Else
                F700ListBoxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub F700oleku()
        If F700ButtonCN1.Text = "-" Then
            F700TextBoxCN1.Enabled = False
        Else
            F700TextBoxCN1.Enabled = True
        End If
        If F700ButtonCN2.Text = "-" Then
            F700TextBoxCN2.Enabled = False
        Else
            F700TextBoxCN2.Enabled = True
        End If
        If F700ButtonCN3.Text = "-" Then
            F700TextBoxCN3.Enabled = False
        Else
            F700TextBoxCN3.Enabled = True
        End If
        If F700ButtonCN4.Text = "-" Then
            F700TextBoxCN4.Enabled = False
        Else
            F700TextBoxCN4.Enabled = True
        End If
        If F700ButtonCN5.Text = "-" Then
            F700TextBoxCN5.Enabled = False
        Else
            F700TextBoxCN5.Enabled = True
        End If
        If F700ButtonCN6.Text = "-" Then
            F700TextBoxCN6.Enabled = False
        Else
            F700TextBoxCN6.Enabled = True
        End If
        If F700ButtonCN7.Text = "-" Then
            F700TextBoxCN7.Enabled = False
        Else
            F700TextBoxCN7.Enabled = True
        End If
        If F700ButtonCN8.Text = "-" Then
            F700TextBoxCN8.Enabled = False
        Else
            F700TextBoxCN8.Enabled = True
        End If
        If F700ButtonCN9.Text = "-" Then
            F700TextBoxCN9.Enabled = False
        Else
            F700TextBoxCN9.Enabled = True
        End If
        If F700ButtonCN10.Text = "-" Then
            F700TextBoxCN10.Enabled = False
        Else
            F700TextBoxCN10.Enabled = True
        End If
        If F700ButtonCN11.Text = "-" Then
            F700TextBoxCN11.Enabled = False
        Else
            F700TextBoxCN11.Enabled = True
        End If
        If F700ButtonCN12.Text = "-" Then
            F700TextBoxCN12.Enabled = False
        Else
            F700TextBoxCN12.Enabled = True
        End If
        If F700ButtonCN13.Text = "-" Then
            F700TextBoxCN13.Enabled = False
        Else
            F700TextBoxCN13.Enabled = True
        End If
        If F700ButtonCN14.Text = "-" Then
            F700TextBoxCN14.Enabled = False
        Else
            F700TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub F700TOtalcreditunit()
        Dim f700totalcu As Integer
        f700totalcu = Val(F700LabelCU1.Text) + Val(F700LabelCU2.Text) + Val(F700LabelCU3.Text) + Val(F700LabelCU4.Text) + Val(F700LabelCU5.Text) + Val(F700LabelCU6.Text) + Val(F700LabelCU7.Text) + Val(F700LabelCU8.Text) + Val(F700LabelCU9.Text) + Val(F700LabelCU10.Text) + Val(F700LabelCU11.Text) + Val(F700LabelCU12.Text) + Val(F700LabelCU13.Text) + Val(F700LabelCU14.Text)
        f700cu = f700totalcu
        F700TOTALCUlabel.Text = f700cu
        Call nigga()
    End Sub
    Private Sub F700TOtalqp()
        Dim F700totalqp As Integer
        F700LabelQP1.Text = Val(F700labelpt1.Text) * Val(F700LabelCU1.Text)
        F700LabelQP2.Text = Val(F700labelpt2.Text) * Val(F700LabelCU2.Text)
        F700LabelQP3.Text = Val(F700labelpt3.Text) * Val(F700LabelCU3.Text)
        F700LabelQP4.Text = Val(F700labelpt4.Text) * Val(F700LabelCU4.Text)
        F700LabelQP5.Text = Val(F700labelpt5.Text) * Val(F700LabelCU5.Text)
        F700LabelQP6.Text = Val(F700labelpt6.Text) * Val(F700LabelCU6.Text)
        F700LabelQP7.Text = Val(F700labelpt7.Text) * Val(F700LabelCU7.Text)
        F700LabelQP8.Text = Val(F700labelpt8.Text) * Val(F700LabelCU8.Text)
        F700LabelQP9.Text = Val(F700labelpt9.Text) * Val(F700LabelCU9.Text)
        F700LabelQP10.Text = Val(F700labelpt10.Text) * Val(F700LabelCU10.Text)
        F700LabelQP11.Text = Val(F700labelpt11.Text) * Val(F700LabelCU11.Text)
        F700LabelQP12.Text = Val(F700labelpt12.Text) * Val(F700LabelCU12.Text)
        F700LabelQP13.Text = Val(F700labelpt13.Text) * Val(F700LabelCU13.Text)
        F700LabelQP14.Text = Val(F700labelpt14.Text) * Val(F700LabelCU14.Text)
        F700totalqp = Val(F700LabelQP1.Text) + Val(F700LabelQP2.Text) + Val(F700LabelQP3.Text) + Val(F700LabelQP4.Text) + Val(F700LabelQP5.Text) + Val(F700LabelQP6.Text) + Val(F700LabelQP7.Text) + Val(F700LabelQP8.Text) + Val(F700LabelQP9.Text) + Val(F700LabelQP10.Text) + Val(F700LabelQP11.Text) + Val(F700LabelQP12.Text) + Val(F700LabelQP13.Text) + Val(F700LabelQP14.Text)
        f700qp = F700totalqp
        F700TOTALCUlabel.Text = f700cu
        F700TOTALQPlabel.Text = f700qp
        Label700GPA.Text = Math.Round(f700qp / f700cu, 2)
        Call nigga()
    End Sub

    'SECOND SEMESTER
    's100
    ' USED TO HIDE SOME CONTROLS
    Private Sub S100level1()
        S100ComboBoxCN2.Show()
        S100LabelCN2.Show()
        S100LabelG2.Show()
        S100LabelCU2.Show()
        S100LabelQP2.Show()
        S100TextboxCN2.Show()
        S100ButtonCN2.Show()
    End Sub
    Private Sub S100level2()
        S100ComboBoxCN3.Show()
        S100LabelCN3.Show()
        S100LabelG3.Show()
        S100LabelCU3.Show()
        S100LabelQP3.Show()
        S100TextboxCN3.Show()
        S100ButtonCN3.Show()
    End Sub
    Private Sub S100level3()
        S100ComboBoxCN4.Show()
        S100LabelCN4.Show()
        S100LabelG4.Show()
        S100LabelCU4.Show()
        S100LabelQP4.Show()
        S100TextboxCN4.Show()
        S100ButtonCN4.Show()
    End Sub
    Private Sub S100level4()
        S100ComboBoxCN5.Show()
        S100LabelCN5.Show()
        S100LabelG5.Show()
        S100LabelCU5.Show()
        S100LabelQP5.Show()
        S100TextboxCN5.Show()
        S100ButtonCN5.Show()
    End Sub
    Private Sub S100level5()
        S100ComboBoxCN6.Show()
        S100LabelCN6.Show()
        S100LabelG6.Show()
        S100LabelCU6.Show()
        S100LabelQP6.Show()
        S100TextboxCN6.Show()
        S100ButtonCN6.Show()
    End Sub
    Private Sub S100level6()
        S100ComboBoxCN7.Show()
        S100LabelCN7.Show()
        S100LabelG7.Show()
        S100LabelCU7.Show()
        S100LabelQP7.Show()
        S100TextboxCN7.Show()
        S100ButtonCN7.Show()
    End Sub
    Private Sub S100level7()
        S100ComboBoxCN8.Show()
        S100LabelCN8.Show()
        S100LabelG8.Show()
        S100LabelCU8.Show()
        S100LabelQP8.Show()
        S100TextboxCN8.Show()
        S100ButtonCN8.Show()
    End Sub
    Private Sub S100level8()
        S100ComboBoxCN9.Show()
        S100LabelCN9.Show()
        S100LabelG9.Show()
        S100LabelCU9.Show()
        S100LabelQP9.Show()
        S100TextboxCN9.Show()
        S100ButtonCN9.Show()
    End Sub
    Private Sub S100level9()
        S100ComboBoxCN10.Show()
        S100LabelCN10.Show()
        S100LabelG10.Show()
        S100LabelCU10.Show()
        S100LabelQP10.Show()
        S100TextboxCN10.Show()
        S100ButtonCN10.Show()
    End Sub
    Private Sub S100level10()
        S100ComboBoxCN11.Show()
        S100LabelCN11.Show()
        S100LabelG11.Show()
        S100LabelCU11.Show()
        S100LabelQP11.Show()
        S100TextboxCN11.Show()
        S100ButtonCN11.Show()
    End Sub
    Private Sub S100level11()
        S100ComboBoxCN12.Show()
        S100LabelCN12.Show()
        S100LabelG12.Show()
        S100LabelCU12.Show()
        S100LabelQP12.Show()
        S100TextboxCN12.Show()
        S100ButtonCN12.Show()
    End Sub
    Private Sub S100level12()
        S100ComboBoxCN13.Show()
        S100LabelCN13.Show()
        S100LabelG13.Show()
        S100LabelCU13.Show()
        S100LabelQP13.Show()
        S100TextboxCN13.Show()
        S100ButtonCN13.Show()
    End Sub
    Private Sub S100level13()
        S100ComboBoxCN14.Show()
        S100LabelCN14.Show()
        S100LabelG14.Show()
        S100LabelCU14.Show()
        S100LabelQP14.Show()
        S100TextboxCN14.Show()
        S100ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub s100hope()
        S100ListBoxhopecode.Items.Clear()
        s100listboxhopename.Items.Clear()
        s100listboxhopeunit.Items.Clear()
        S100ListBoxF.Items.Clear()
        S100ListBoxFC.Items.Clear()
        S100ListBoxFN.Items.Clear()
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = S100ListBoxCourseCode.Items(i).ToString
            Dim morga As String = S100ListBoxCourseName.Items(i).ToString
            Dim morg As String = S100ListBoxCreditCode.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = S100ListBoxCourseName.Items(i).ToString
            Dim gwen As String = S100ListBoxCreditCode.Items(i).ToString
            If (S100ButtonCN1.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN2.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN3.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN4.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN5.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN6.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN7.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN8.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN9.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN10.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN11.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN12.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN13.Text = S100ListBoxCourseCode.Items(i).ToString) Or (S100ButtonCN14.Text = S100ListBoxCourseCode.Items(i).ToString) Then
                S100ListBoxhopecode.Items.Remove(i)
                s100listboxhopename.Items.Remove(i)
                s100listboxhopeunit.Items.Remove(i)
            Else
                S100ListBoxhopecode.Items.Add(morgan)
                s100listboxhopename.Items.Add(morga)
                s100listboxhopeunit.Items.Add(morg)
            End If
            If (S100ButtonCN1.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG1.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN2.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG2.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN3.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG3.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN4.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG4.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN5.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG5.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN6.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG6.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN7.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG7.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN8.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG8.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN9.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG9.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN10.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG10.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN11.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG11.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN12.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG12.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN13.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG13.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
            If (S100ButtonCN14.Text = S100ListBoxCourseCode.Items(i).ToString) And S100LabelG14.Text = merlin Then
                S100ListBoxF.Items.Add(morgan)
                S100ListBoxFN.Items.Add(arthur)
                S100ListBoxFC.Items.Add(gwen)
            Else
                S100ListBoxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub S100oleku()
        If S100ButtonCN1.Text = "-" Then
            S100TextboxCN1.Enabled = False
        Else
            S100TextboxCN1.Enabled = True
        End If
        If S100ButtonCN2.Text = "-" Then
            S100TextboxCN2.Enabled = False
        Else
            S100TextboxCN2.Enabled = True
        End If
        If S100ButtonCN3.Text = "-" Then
            S100TextboxCN3.Enabled = False
        Else
            S100TextboxCN3.Enabled = True
        End If
        If S100ButtonCN4.Text = "-" Then
            S100TextboxCN4.Enabled = False
        Else
            S100TextboxCN4.Enabled = True
        End If
        If S100ButtonCN5.Text = "-" Then
            S100TextboxCN5.Enabled = False
        Else
            S100TextboxCN5.Enabled = True
        End If
        If S100ButtonCN6.Text = "-" Then
            S100TextboxCN6.Enabled = False
        Else
            S100TextboxCN6.Enabled = True
        End If
        If S100ButtonCN7.Text = "-" Then
            S100TextboxCN7.Enabled = False
        Else
            S100TextboxCN7.Enabled = True
        End If
        If S100ButtonCN8.Text = "-" Then
            S100TextboxCN8.Enabled = False
        Else
            S100TextboxCN8.Enabled = True
        End If
        If S100ButtonCN9.Text = "-" Then
            S100TextboxCN9.Enabled = False
        Else
            S100TextboxCN9.Enabled = True
        End If
        If S100ButtonCN10.Text = "-" Then
            S100TextboxCN10.Enabled = False
        Else
            S100TextboxCN10.Enabled = True
        End If
        If S100ButtonCN11.Text = "-" Then
            S100TextboxCN11.Enabled = False
        Else
            S100TextboxCN11.Enabled = True
        End If
        If S100ButtonCN12.Text = "-" Then
            S100TextboxCN12.Enabled = False
        Else
            S100TextboxCN12.Enabled = True
        End If
        If S100ButtonCN13.Text = "-" Then
            S100TextboxCN13.Enabled = False
        Else
            S100TextboxCN13.Enabled = True
        End If
        If S100ButtonCN14.Text = "-" Then
            S100TextboxCN14.Enabled = False
        Else
            S100TextboxCN14.Enabled = True
        End If
    End Sub
    Private Sub S100TOtalcreditunit()
        Dim s100totalcu As Integer
        s100totalcu = Val(S100LabelCU1.Text) + Val(S100LabelCU2.Text) + Val(S100LabelCU3.Text) + Val(S100LabelCU4.Text) + Val(S100LabelCU5.Text) + Val(S100LabelCU6.Text) + Val(S100LabelCU7.Text) + Val(S100LabelCU8.Text) + Val(S100LabelCU9.Text) + Val(S100LabelCU10.Text) + Val(S100LabelCU11.Text) + Val(S100LabelCU12.Text) + Val(S100LabelCU13.Text) + Val(S100LabelCU14.Text)
        s100cu = s100totalcu
        y100TOTALCUlabel.Text = s100totalcu
    End Sub
    Private Sub S100TOtalqp()
        Dim S100totalqp As Integer
        S100LabelQP1.Text = Val(S100labelpt1.Text) * Val(S100LabelCU1.Text)
        S100LabelQP2.Text = Val(S100labelpt2.Text) * Val(S100LabelCU2.Text)
        S100LabelQP3.Text = Val(S100labelpt3.Text) * Val(S100LabelCU3.Text)
        S100LabelQP4.Text = Val(S100labelpt4.Text) * Val(S100LabelCU4.Text)
        S100LabelQP5.Text = Val(S100labelpt5.Text) * Val(S100LabelCU5.Text)
        S100LabelQP6.Text = Val(S100labelpt6.Text) * Val(S100LabelCU6.Text)
        S100LabelQP7.Text = Val(S100labelpt7.Text) * Val(S100LabelCU7.Text)
        S100LabelQP8.Text = Val(S100labelpt8.Text) * Val(S100LabelCU8.Text)
        S100LabelQP9.Text = Val(S100labelpt9.Text) * Val(S100LabelCU9.Text)
        S100LabelQP10.Text = Val(S100labelpt10.Text) * Val(S100LabelCU10.Text)
        S100LabelQP11.Text = Val(S100labelpt11.Text) * Val(S100LabelCU11.Text)
        S100LabelQP12.Text = Val(S100labelpt12.Text) * Val(S100LabelCU12.Text)
        S100LabelQP13.Text = Val(S100labelpt13.Text) * Val(S100LabelCU13.Text)
        S100LabelQP14.Text = Val(S100labelpt14.Text) * Val(S100LabelCU14.Text)
        S100totalqp = Val(S100LabelQP1.Text) + Val(S100LabelQP2.Text) + Val(S100LabelQP3.Text) + Val(S100LabelQP4.Text) + Val(S100LabelQP5.Text) + Val(S100LabelQP6.Text) + Val(S100LabelQP7.Text) + Val(S100LabelQP8.Text) + Val(S100LabelQP9.Text) + Val(S100LabelQP10.Text) + Val(S100LabelQP11.Text) + Val(S100LabelQP12.Text) + Val(S100LabelQP13.Text) + Val(S100LabelQP14.Text)
        s100qp = S100totalqp
        y100TOTALQPlabel.Text = S100totalqp
        Dim cg As Double
        cg = Val(y100TOTALQPlabel.Text) / Val(y100TOTALCUlabel.Text)
        cg = Math.Round(cg, 2)
        Label100GPA.Text = cg
        Call nigga()
    End Sub
    's200
    ' USED TO HIDE SOME CONTROLS
    Private Sub S200level1()
        S200ComboboxCN2.Show()
        S200LabelCN2.Show()
        S200LabelG2.Show()
        S200LabelCU2.Show()
        S200LabelQP2.Show()
        S200TextBoxCN2.Show()
        S200buttonCN2.Show()
    End Sub
    Private Sub S200level2()
        S200ComboboxCN3.Show()
        S200LabelCN3.Show()
        S200LabelG3.Show()
        S200LabelCU3.Show()
        S200LabelQP3.Show()
        S200TextBoxCN3.Show()
        S200buttonCN3.Show()
    End Sub
    Private Sub S200level3()
        S200ComboboxCN4.Show()
        S200LabelCN4.Show()
        S200LabelG4.Show()
        S200LabelCU4.Show()
        S200LabelQP4.Show()
        S200TextBoxCN4.Show()
        S200buttonCN4.Show()
    End Sub
    Private Sub S200level4()
        S200ComboboxCN5.Show()
        S200LabelCN5.Show()
        S200LabelG5.Show()
        S200LabelCU5.Show()
        S200LabelQP5.Show()
        S200TextBoxCN5.Show()
        S200buttonCN5.Show()
    End Sub
    Private Sub S200level5()
        S200ComboboxCN6.Show()
        S200LabelCN6.Show()
        S200LabelG6.Show()
        S200LabelCU6.Show()
        S200LabelQP6.Show()
        S200TextBoxCN6.Show()
        S200buttonCN6.Show()
    End Sub
    Private Sub S200level6()
        S200ComboboxCN7.Show()
        S200LabelCN7.Show()
        S200LabelG7.Show()
        S200LabelCU7.Show()
        S200LabelQP7.Show()
        S200TextBoxCN7.Show()
        S200buttonCN7.Show()
    End Sub
    Private Sub S200level7()
        S200ComboboxCN8.Show()
        S200LabelCN8.Show()
        S200LabelG8.Show()
        S200LabelCU8.Show()
        S200LabelQP8.Show()
        S200TextBoxCN8.Show()
        S200buttonCN8.Show()
    End Sub
    Private Sub S200level8()
        S200ComboboxCN9.Show()
        S200LabelCN9.Show()
        S200LabelG9.Show()
        S200LabelCU9.Show()
        S200LabelQP9.Show()
        S200TextBoxCN9.Show()
        S200buttonCN9.Show()
    End Sub
    Private Sub S200level9()
        S200ComboboxCN10.Show()
        S200LabelCN10.Show()
        S200LabelG10.Show()
        S200LabelCU10.Show()
        S200LabelQP10.Show()
        S200TextBoxCN10.Show()
        S200buttonC10.Show()
    End Sub
    Private Sub S200level10()
        S200ComboboxCN11.Show()
        S200LabelCN11.Show()
        S200LabelG11.Show()
        S200LabelCU11.Show()
        S200LabelQP11.Show()
        S200TextBoxCN11.Show()
        S200buttonCN11.Show()
    End Sub
    Private Sub S200level11()
        S200ComboboxCN12.Show()
        S200LabelCN12.Show()
        S200LabelG12.Show()
        S200LabelCU12.Show()
        S200LabelQP12.Show()
        S200TextBoxCN12.Show()
        S200buttonCN12.Show()
    End Sub
    Private Sub S200level12()
        S200ComboboxCN13.Show()
        S200LabelCN13.Show()
        S200LabelG13.Show()
        S200LabelCU13.Show()
        S200LabelQP13.Show()
        S200TextBoxCN13.Show()
        S200buttonCN13.Show()
    End Sub
    Private Sub S200level13()
        S200ComboboxCN14.Show()
        S200LabelCN14.Show()
        S200LabelG14.Show()
        S200LabelCU14.Show()
        S200LabelQP14.Show()
        S200TextBoxCN14.Show()
        S200buttonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub s200hope()
        Call s200coursera()
        S200ListboxhopeCode.Items.Clear()
        s200listboxhopename.Items.Clear()
        s200listboxhopeunit.Items.Clear()
        S200ListboxF.Items.Clear()
        S200ListboxFC.Items.Clear()
        S200ListboxFN.Items.Clear()
        For i = 0 To S200ListboxCourseCode.Items.Count - 1
            Dim morgan As String = S200ListboxCourseCode.Items(i).ToString
            Dim morga As String = S200ListboxCourseName.Items(i).ToString
            Dim morg As String = S200ListboxCreditunit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = S200ListboxCourseName.Items(i).ToString
            Dim gwen As String = S200ListboxCreditunit.Items(i).ToString
            If (S200buttonCN1.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN2.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN3.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN4.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN5.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN6.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN7.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN8.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN9.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonC10.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN11.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN12.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN13.Text = S200ListboxCourseCode.Items(i).ToString) Or (S200buttonCN14.Text = S200ListboxCourseCode.Items(i).ToString) Then
                S200ListboxhopeCode.Items.Remove(i)
                s200listboxhopename.Items.Remove(i)
                s200listboxhopeunit.Items.Remove(i)
            Else
                S200ListboxhopeCode.Items.Add(morgan)
                s200listboxhopename.Items.Add(morga)
                s200listboxhopeunit.Items.Add(morg)
            End If
            If (S200buttonCN1.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG1.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN2.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG2.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN3.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG3.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN4.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG4.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN5.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG5.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN6.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG6.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN7.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG7.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN8.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG8.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN9.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG9.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonC10.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG10.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN11.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG11.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN12.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG12.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN13.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG13.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
            If (S200buttonCN14.Text = S200ListboxCourseCode.Items(i).ToString) And S200LabelG14.Text = merlin Then
                S200ListboxF.Items.Add(morgan)
                S200ListboxFN.Items.Add(arthur)
                S200ListboxFC.Items.Add(gwen)
            Else
                S200ListboxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub S200oleku()
        If S200buttonCN1.Text = "-" Then
            S200TextBoxCN1.Enabled = False
        Else
            S200TextBoxCN1.Enabled = True
        End If
        If S200buttonCN2.Text = "-" Then
            S200TextBoxCN2.Enabled = False
        Else
            S200TextBoxCN2.Enabled = True
        End If
        If S200buttonCN3.Text = "-" Then
            S200TextBoxCN3.Enabled = False
        Else
            S200TextBoxCN3.Enabled = True
        End If
        If S200buttonCN4.Text = "-" Then
            S200TextBoxCN4.Enabled = False
        Else
            S200TextBoxCN4.Enabled = True
        End If
        If S200buttonCN5.Text = "-" Then
            S200TextBoxCN5.Enabled = False
        Else
            S200TextBoxCN5.Enabled = True
        End If
        If S200buttonCN6.Text = "-" Then
            S200TextBoxCN6.Enabled = False
        Else
            S200TextBoxCN6.Enabled = True
        End If
        If S200buttonCN7.Text = "-" Then
            S200TextBoxCN7.Enabled = False
        Else
            S200TextBoxCN7.Enabled = True
        End If
        If S200buttonCN8.Text = "-" Then
            S200TextBoxCN8.Enabled = False
        Else
            S200TextBoxCN8.Enabled = True
        End If
        If S200buttonCN9.Text = "-" Then
            S200TextBoxCN9.Enabled = False
        Else
            S200TextBoxCN9.Enabled = True
        End If
        If S200buttonC10.Text = "-" Then
            S200TextBoxCN10.Enabled = False
        Else
            S200TextBoxCN10.Enabled = True
        End If
        If S200buttonCN11.Text = "-" Then
            S200TextBoxCN11.Enabled = False
        Else
            S200TextBoxCN11.Enabled = True
        End If
        If S200buttonCN12.Text = "-" Then
            S200TextBoxCN12.Enabled = False
        Else
            S200TextBoxCN12.Enabled = True
        End If
        If S200buttonCN13.Text = "-" Then
            S200TextBoxCN13.Enabled = False
        Else
            S200TextBoxCN13.Enabled = True
        End If
        If S200buttonCN14.Text = "-" Then
            S200TextBoxCN14.Enabled = False
        Else
            S200TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub S200TOtalcreditunit()
        Dim s200totalcu As Integer
        s200totalcu = Val(S200LabelCU1.Text) + Val(S200LabelCU2.Text) + Val(S200LabelCU3.Text) + Val(S200LabelCU4.Text) + Val(S200LabelCU5.Text) + Val(S200LabelCU6.Text) + Val(S200LabelCU7.Text) + Val(S200LabelCU8.Text) + Val(S200LabelCU9.Text) + Val(S200LabelCU10.Text) + Val(S200LabelCU11.Text) + Val(S200LabelCU12.Text) + Val(S200LabelCU13.Text) + Val(S200LabelCU14.Text)
        s200cu = s200totalcu
        y200TOTALCUlabel.Text = s200totalcu
    End Sub
    Private Sub S200TOtalqp()
        Dim S200totalqp As Integer
        S200LabelQP1.Text = Val(S200labelpt1.Text) * Val(S200LabelCU1.Text)
        S200LabelQP2.Text = Val(S200labelpt2.Text) * Val(S200LabelCU2.Text)
        S200LabelQP3.Text = Val(S200labelpt3.Text) * Val(S200LabelCU3.Text)
        S200LabelQP4.Text = Val(S200labelpt4.Text) * Val(S200LabelCU4.Text)
        S200LabelQP5.Text = Val(S200labelpt5.Text) * Val(S200LabelCU5.Text)
        S200LabelQP6.Text = Val(S200labelpt6.Text) * Val(S200LabelCU6.Text)
        S200LabelQP7.Text = Val(S200labelpt7.Text) * Val(S200LabelCU7.Text)
        S200LabelQP8.Text = Val(S200labelpt8.Text) * Val(S200LabelCU8.Text)
        S200LabelQP9.Text = Val(S200labelpt9.Text) * Val(S200LabelCU9.Text)
        S200LabelQP10.Text = Val(S200labelpt10.Text) * Val(S200LabelCU10.Text)
        S200LabelQP11.Text = Val(S200labelpt11.Text) * Val(S200LabelCU11.Text)
        S200LabelQP12.Text = Val(S200labelpt12.Text) * Val(S200LabelCU12.Text)
        S200LabelQP13.Text = Val(S200labelpt13.Text) * Val(S200LabelCU13.Text)
        S200LabelQP14.Text = Val(S200labelpt14.Text) * Val(S200LabelCU14.Text)
        S200totalqp = Val(S200LabelQP1.Text) + Val(S200LabelQP2.Text) + Val(S200LabelQP3.Text) + Val(S200LabelQP4.Text) + Val(S200LabelQP5.Text) + Val(S200LabelQP6.Text) + Val(S200LabelQP7.Text) + Val(S200LabelQP8.Text) + Val(S200LabelQP9.Text) + Val(S200LabelQP10.Text) + Val(S200LabelQP11.Text) + Val(S200LabelQP12.Text) + Val(S200LabelQP13.Text) + Val(S200LabelQP14.Text)
        s200qp = S200totalqp
        y200TOTALQPlabel.Text = S200totalqp
        Dim cg As Double
        cg = Val(y200TOTALQPlabel.Text) / Val(y200TOTALCUlabel.Text)
        cg = Math.Round(cg, 2)
        Label200GPA.Text = cg
        Call nigga()
    End Sub

    's300
    ' USED TO HIDE SOME CONTROLS
    Private Sub S300level1()
        S300ComboboxCN2.Show()
        S300LabelCN2.Show()
        S300LabelG2.Show()
        S300LabelCU2.Show()
        S300LabelQP2.Show()
        S300TextboxCN2.Show()
        S300ButtonCN2.Show()
    End Sub
    Private Sub S300level2()
        S300ComboboxCN3.Show()
        S300LabelCN3.Show()
        S300LabelG3.Show()
        S300LabelCU3.Show()
        S300LabelQP3.Show()
        S300TextboxCN3.Show()
        S300ButtonCN3.Show()
    End Sub
    Private Sub S300level3()
        S300ComboboxCN4.Show()
        S300LabelCN4.Show()
        S300LabelG4.Show()
        S300LabelCU4.Show()
        S300LabelQP4.Show()
        S300TextboxCN4.Show()
        S300ButtonCN4.Show()
    End Sub
    Private Sub S300level4()
        S300ComboboxCN5.Show()
        S300LabelCN5.Show()
        S300LabelG5.Show()
        S300LabelCU5.Show()
        S300LabelQP5.Show()
        S300TextboxCN5.Show()
        S300ButtonCN5.Show()
    End Sub
    Private Sub S300level5()
        S300ComboboxCN6.Show()
        S300LabelCN6.Show()
        S300LabelG6.Show()
        S300LabelCU6.Show()
        S300LabelQP6.Show()
        S300TextboxCN6.Show()
        S300ButtonCN6.Show()
    End Sub
    Private Sub S300level6()
        S300ComboboxCN7.Show()
        S300LabelCN7.Show()
        S300LabelG7.Show()
        S300LabelCU7.Show()
        S300LabelQP7.Show()
        S300TextboxCN7.Show()
        S300ButtonCN7.Show()
    End Sub
    Private Sub S300level7()
        S300ComboboxCN8.Show()
        S300LabelCN8.Show()
        S300LabelG8.Show()
        S300LabelCU8.Show()
        S300LabelQP8.Show()
        S300TextboxCN8.Show()
        S300ButtonCN8.Show()
    End Sub
    Private Sub S300level8()
        S300ComboboxCN9.Show()
        S300LabelCN9.Show()
        S300LabelG9.Show()
        S300LabelCU9.Show()
        S300LabelQP9.Show()
        S300TextboxCN9.Show()
        S300ButtonCN9.Show()
    End Sub
    Private Sub S300level9()
        S300ComboboxCN10.Show()
        S300LabelCN10.Show()
        S300LabelG10.Show()
        S300LabelCU10.Show()
        S300LabelQP10.Show()
        S300TextboxCN10.Show()
        S300ButtonCN10.Show()
    End Sub
    Private Sub S300level10()
        S300ComboboxCN11.Show()
        S300LabelCN11.Show()
        S300LabelG11.Show()
        S300LabelCU11.Show()
        S300LabelQP11.Show()
        S300TextboxCN11.Show()
        S300ButtonCN11.Show()
    End Sub
    Private Sub S300level11()
        S300ComboboxCN12.Show()
        S300LabelCN12.Show()
        S300LabelG12.Show()
        S300LabelCU12.Show()
        S300LabelQP12.Show()
        S300TextboxCN12.Show()
        S300ButtonCN12.Show()
    End Sub
    Private Sub S300level12()
        S300ComboboxCN13.Show()
        S300LabelCN13.Show()
        S300LabelG13.Show()
        S300LabelCU13.Show()
        S300LabelQP13.Show()
        S300TextboxCN13.Show()
        S300ButtonCN13.Show()
    End Sub
    Private Sub S300level13()
        S300ComboboxCN14.Show()
        S300LabelCN14.Show()
        S300LabelG14.Show()
        S300LabelCU14.Show()
        S300LabelQP14.Show()
        S300TextboxCN14.Show()
        S300ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub s300hope()
        Call s300coursera()
        S300ListboxhopeCode.Items.Clear()
        s300listboxhopename.Items.Clear()
        s300listboxhopeunit.Items.Clear()
        S300ListboxF.Items.Clear()
        S300ListboxFC.Items.Clear()
        S300ListboxFN.Items.Clear()
        For i = 0 To S300ListboxCourseCode.Items.Count - 1
            Dim morgan As String = S300ListboxCourseCode.Items(i).ToString
            Dim morga As String = S300ListboxCourseName.Items(i).ToString
            Dim morg As String = S300ListboxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = S300ListboxCourseName.Items(i).ToString
            Dim gwen As String = S300ListboxCreditUnit.Items(i).ToString
            If (S300ButtonCN1.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN2.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN3.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN4.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN5.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN6.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN7.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN8.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN9.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN10.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN11.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN12.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN13.Text = S300ListboxCourseCode.Items(i).ToString) Or (S300ButtonCN14.Text = S300ListboxCourseCode.Items(i).ToString) Then
                S300ListboxhopeCode.Items.Remove(i)
                s300listboxhopename.Items.Remove(i)
                s300listboxhopeunit.Items.Remove(i)
            Else
                S300ListboxhopeCode.Items.Add(morgan)
                s300listboxhopename.Items.Add(morga)
                s300listboxhopeunit.Items.Add(morg)
            End If
            If (S300ButtonCN1.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG1.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN2.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG2.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN3.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG3.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN4.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG4.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN5.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG5.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN6.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG6.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN7.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG7.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN8.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG8.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN9.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG9.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN10.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG10.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN11.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG11.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN12.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG12.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN13.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG13.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
            If (S300ButtonCN14.Text = S300ListboxCourseCode.Items(i).ToString) And S300LabelG14.Text = merlin Then
                S300ListboxF.Items.Add(morgan)
                S300ListboxFN.Items.Add(arthur)
                S300ListboxFC.Items.Add(gwen)
            Else
                S300ListboxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub S300oleku()
        If S300ButtonCN1.Text = "-" Then
            S300TextboxCN1.Enabled = False
        Else
            S300TextboxCN1.Enabled = True
        End If
        If S300ButtonCN2.Text = "-" Then
            S300TextboxCN2.Enabled = False
        Else
            S300TextboxCN2.Enabled = True
        End If
        If S300ButtonCN3.Text = "-" Then
            S300TextboxCN3.Enabled = False
        Else
            S300TextboxCN3.Enabled = True
        End If
        If S300ButtonCN4.Text = "-" Then
            S300TextboxCN4.Enabled = False
        Else
            S300TextboxCN4.Enabled = True
        End If
        If S300ButtonCN5.Text = "-" Then
            S300TextboxCN5.Enabled = False
        Else
            S300TextboxCN5.Enabled = True
        End If
        If S300ButtonCN6.Text = "-" Then
            S300TextboxCN6.Enabled = False
        Else
            S300TextboxCN6.Enabled = True
        End If
        If S300ButtonCN7.Text = "-" Then
            S300TextboxCN7.Enabled = False
        Else
            S300TextboxCN7.Enabled = True
        End If
        If S300ButtonCN8.Text = "-" Then
            S300TextboxCN8.Enabled = False
        Else
            S300TextboxCN8.Enabled = True
        End If
        If S300ButtonCN9.Text = "-" Then
            S300TextboxCN9.Enabled = False
        Else
            S300TextboxCN9.Enabled = True
        End If
        If S300ButtonCN10.Text = "-" Then
            S300TextboxCN10.Enabled = False
        Else
            S300TextboxCN10.Enabled = True
        End If
        If S300ButtonCN11.Text = "-" Then
            S300TextboxCN11.Enabled = False
        Else
            S300TextboxCN11.Enabled = True
        End If
        If S300ButtonCN12.Text = "-" Then
            S300TextboxCN12.Enabled = False
        Else
            S300TextboxCN12.Enabled = True
        End If
        If S300ButtonCN13.Text = "-" Then
            S300TextboxCN13.Enabled = False
        Else
            S300TextboxCN13.Enabled = True
        End If
        If S300ButtonCN14.Text = "-" Then
            S300TextboxCN14.Enabled = False
        Else
            S300TextboxCN14.Enabled = True
        End If
    End Sub
    Private Sub S300TOtalcreditunit()
        Dim s300totalcu As Integer
        s300totalcu = Val(S300LabelCU1.Text) + Val(S300LabelCU2.Text) + Val(S300LabelCU3.Text) + Val(S300LabelCU4.Text) + Val(S300LabelCU5.Text) + Val(S300LabelCU6.Text) + Val(S300LabelCU7.Text) + Val(S300LabelCU8.Text) + Val(S300LabelCU9.Text) + Val(S300LabelCU10.Text) + Val(S300LabelCU11.Text) + Val(S300LabelCU12.Text) + Val(S300LabelCU13.Text) + Val(S300LabelCU14.Text)
        s300cu = s300totalcu
        s300TOTALCUlabel.Text = s300cu
    End Sub
    Private Sub S300TOtalqp()
        Dim S300totalqp As Integer
        S300LabelQP1.Text = Val(S300labelpt1.Text) * Val(S300LabelCU1.Text)
        S300LabelQP2.Text = Val(S300labelpt2.Text) * Val(S300LabelCU2.Text)
        S300LabelQP3.Text = Val(S300labelpt3.Text) * Val(S300LabelCU3.Text)
        S300LabelQP4.Text = Val(S300labelpt4.Text) * Val(S300LabelCU4.Text)
        S300LabelQP5.Text = Val(S300labelpt5.Text) * Val(S300LabelCU5.Text)
        S300LabelQP6.Text = Val(S300labelpt6.Text) * Val(S300LabelCU6.Text)
        S300LabelQP7.Text = Val(S300labelpt7.Text) * Val(S300LabelCU7.Text)
        S300LabelQP8.Text = Val(S300labelpt8.Text) * Val(S300LabelCU8.Text)
        S300LabelQP9.Text = Val(S300labelpt9.Text) * Val(S300LabelCU9.Text)
        S300LabelQP10.Text = Val(S300labelpt10.Text) * Val(S300LabelCU10.Text)
        S300LabelQP11.Text = Val(S300labelpt11.Text) * Val(S300LabelCU11.Text)
        S300LabelQP12.Text = Val(S300labelpt12.Text) * Val(S300LabelCU12.Text)
        S300LabelQP13.Text = Val(S300labelpt13.Text) * Val(S300LabelCU13.Text)
        S300LabelQP14.Text = Val(S300labelpt14.Text) * Val(S300LabelCU14.Text)
        S300totalqp = Val(S300LabelQP1.Text) + Val(S300LabelQP2.Text) + Val(S300LabelQP3.Text) + Val(S300LabelQP4.Text) + Val(S300LabelQP5.Text) + Val(S300LabelQP6.Text) + Val(S300LabelQP7.Text) + Val(S300LabelQP8.Text) + Val(S300LabelQP9.Text) + Val(S300LabelQP10.Text) + Val(S300LabelQP11.Text) + Val(S300LabelQP12.Text) + Val(S300LabelQP13.Text) + Val(S300LabelQP14.Text)
        s300qp = S300totalqp
        s300TOTALCUlabel.Text = s300cu
        s300TOTALQPlabel.Text = s300qp
        Label300GPAs.Text = Math.Round(s300qp / s300cu, 2)
        Call nigga()
    End Sub

    's400
    ' USED TO HIDE SOME CONTROLS
    Private Sub S400level1()
        S400ComboBoxCN2.Show()
        S400LabelCN2.Show()
        S400LabelG2.Show()
        S400LabelCU2.Show()
        S400LabelQP2.Show()
        S400TextBoxCN2.Show()
        S400ButtonCN2.Show()
    End Sub
    Private Sub S400level2()
        S400ComboBoxCN3.Show()
        S400LabelCN3.Show()
        S400LabelG3.Show()
        S400LabelCU3.Show()
        S400LabelQP3.Show()
        S400TextBoxCN3.Show()
        S400ButtonCN3.Show()
    End Sub
    Private Sub S400level3()
        S400ComboBoxCN4.Show()
        S400LabelCN4.Show()
        S400LabelG4.Show()
        S400LabelCU4.Show()
        S400LabelQP4.Show()
        S400TextBoxCN4.Show()
        S400ButtonCN4.Show()
    End Sub
    Private Sub S400level4()
        S400ComboBoxCN5.Show()
        S400LabelCN5.Show()
        S400LabelG5.Show()
        S400LabelCU5.Show()
        S400LabelQP5.Show()
        S400TextBoxCN5.Show()
        S400ButtonCN5.Show()
    End Sub
    Private Sub S400level5()
        S400ComboBoxCN6.Show()
        S400LabelCN6.Show()
        S400LabelG6.Show()
        S400LabelCU6.Show()
        S400LabelQP6.Show()
        S400TextBoxCN6.Show()
        S400ButtonCN6.Show()
    End Sub
    Private Sub S400level6()
        S400ComboBoxCN7.Show()
        S400LabelCN7.Show()
        S400LabelG7.Show()
        S400LabelCU7.Show()
        S400LabelQP7.Show()
        S400TextBoxCN7.Show()
        S400ButtonCN7.Show()
    End Sub
    Private Sub S400level7()
        S400ComboBoxCN8.Show()
        S400LabelCN8.Show()
        S400LabelG8.Show()
        S400LabelCU8.Show()
        S400LabelQP8.Show()
        S400TextBoxCN8.Show()
        S400ButtonCN8.Show()
    End Sub
    Private Sub S400level8()
        S400ComboBoxCN9.Show()
        S400LabelCN9.Show()
        S400LabelG9.Show()
        S400LabelCU9.Show()
        S400LabelQP9.Show()
        S400TextBoxCN9.Show()
        S400ButtonCN9.Show()
    End Sub
    Private Sub S400level9()
        S400ComboBoxCN10.Show()
        S400LabelCN10.Show()
        S400LabelG10.Show()
        S400LabelCU10.Show()
        S400LabelQP10.Show()
        S400TextBoxCN10.Show()
        S400ButtonCN10.Show()
    End Sub
    Private Sub S400level10()
        S400ComboBoxCN11.Show()
        S400LabelCN11.Show()
        S400LabelG11.Show()
        S400LabelCU11.Show()
        S400LabelQP11.Show()
        S400TextBoxCN11.Show()
        S400ButtonCN11.Show()
    End Sub
    Private Sub S400level11()
        S400ComboBoxCN12.Show()
        S400LabelCN12.Show()
        S400LabelG12.Show()
        S400LabelCU12.Show()
        S400LabelQP12.Show()
        S400TextBoxCN12.Show()
        S400ButtonCN12.Show()
    End Sub
    Private Sub S400level12()
        S400ComboBoxCN13.Show()
        S400LabelCN13.Show()
        S400LabelG13.Show()
        S400LabelCU13.Show()
        S400LabelQP13.Show()
        S400TextBoxCN13.Show()
        S400ButtonCN13.Show()
    End Sub
    Private Sub S400level13()
        S400ComboBoxCN14.Show()
        S400LabelCN14.Show()
        S400LabelG14.Show()
        S400LabelCU14.Show()
        S400LabelQP14.Show()
        S400TextBoxCN14.Show()
        S400ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub s400hope()
        Call s400coursera()
        S400ListBoxhopecode.Items.Clear()
        s400listboxhopename.Items.Clear()
        s400listboxhopeunit.Items.Clear()
        S400ListBoxF.Items.Clear()
        S400ListBoxFC.Items.Clear()
        S400ListBoxFN.Items.Clear()
        For i = 0 To S400ListBoxCOURSEcode.Items.Count - 1
            Dim morgan As String = S400ListBoxCOURSEcode.Items(i).ToString
            Dim morga As String = S400ListBoxCOURSEname.Items(i).ToString
            Dim morg As String = S400ListBoxcreditunit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = S400ListBoxCOURSEname.Items(i).ToString
            Dim gwen As String = S400ListBoxcreditunit.Items(i).ToString
            If (S400ButtonCN1.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN2.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN3.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN4.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN5.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN6.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN7.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN8.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN9.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN10.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN11.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN12.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN13.Text = S400ListBoxCOURSEcode.Items(i).ToString) Or (S400ButtonCN14.Text = S400ListBoxCOURSEcode.Items(i).ToString) Then
                S400ListBoxhopecode.Items.Remove(i)
                s400listboxhopename.Items.Remove(i)
                s400listboxhopeunit.Items.Remove(i)
            Else
                S400ListBoxhopecode.Items.Add(morgan)
                s400listboxhopename.Items.Add(morga)
                s400listboxhopeunit.Items.Add(morg)
            End If
            If (S400ButtonCN1.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG1.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN2.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG2.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN3.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG3.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN4.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG4.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN5.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG5.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN6.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG6.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN7.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG7.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN8.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG8.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN9.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG9.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN10.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG10.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN11.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG11.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN12.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG12.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN13.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG13.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
            If (S400ButtonCN14.Text = S400ListBoxCOURSEcode.Items(i).ToString) And S400LabelG14.Text = merlin Then
                S400ListBoxF.Items.Add(morgan)
                S400ListBoxFN.Items.Add(arthur)
                S400ListBoxFC.Items.Add(gwen)
            Else
                S400ListBoxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub S400oleku()
        If S400ButtonCN1.Text = "-" Then
            S400TextBoxCN1.Enabled = False
        Else
            S400TextBoxCN1.Enabled = True
        End If
        If S400ButtonCN2.Text = "-" Then
            S400TextBoxCN2.Enabled = False
        Else
            S400TextBoxCN2.Enabled = True
        End If
        If S400ButtonCN3.Text = "-" Then
            S400TextBoxCN3.Enabled = False
        Else
            S400TextBoxCN3.Enabled = True
        End If
        If S400ButtonCN4.Text = "-" Then
            S400TextBoxCN4.Enabled = False
        Else
            S400TextBoxCN4.Enabled = True
        End If
        If S400ButtonCN5.Text = "-" Then
            S400TextBoxCN5.Enabled = False
        Else
            S400TextBoxCN5.Enabled = True
        End If
        If S400ButtonCN6.Text = "-" Then
            S400TextBoxCN6.Enabled = False
        Else
            S400TextBoxCN6.Enabled = True
        End If
        If S400ButtonCN7.Text = "-" Then
            S400TextBoxCN7.Enabled = False
        Else
            S400TextBoxCN7.Enabled = True
        End If
        If S400ButtonCN8.Text = "-" Then
            S400TextBoxCN8.Enabled = False
        Else
            S400TextBoxCN8.Enabled = True
        End If
        If S400ButtonCN9.Text = "-" Then
            S400TextBoxCN9.Enabled = False
        Else
            S400TextBoxCN9.Enabled = True
        End If
        If S400ButtonCN10.Text = "-" Then
            S400TextBoxCN10.Enabled = False
        Else
            S400TextBoxCN10.Enabled = True
        End If
        If S400ButtonCN11.Text = "-" Then
            S400TextBoxCN11.Enabled = False
        Else
            S400TextBoxCN11.Enabled = True
        End If
        If S400ButtonCN12.Text = "-" Then
            S400TextBoxCN12.Enabled = False
        Else
            S400TextBoxCN12.Enabled = True
        End If
        If S400ButtonCN13.Text = "-" Then
            S400TextBoxCN13.Enabled = False
        Else
            S400TextBoxCN13.Enabled = True
        End If
        If S400ButtonCN14.Text = "-" Then
            S400TextBoxCN14.Enabled = False
        Else
            S400TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub S400TOtalcreditunit()
        Dim s400totalcu As Integer
        s400totalcu = Val(S400LabelCU1.Text) + Val(S400LabelCU2.Text) + Val(S400LabelCU3.Text) + Val(S400LabelCU4.Text) + Val(S400LabelCU5.Text) + Val(S400LabelCU6.Text) + Val(S400LabelCU7.Text) + Val(S400LabelCU8.Text) + Val(S400LabelCU9.Text) + Val(S400LabelCU10.Text) + Val(S400LabelCU11.Text) + Val(S400LabelCU12.Text) + Val(S400LabelCU13.Text) + Val(S400LabelCU14.Text)
        s400cu = s400totalcu
        s400TOTALCUlabel.Text = s400cu
    End Sub
    Private Sub S400TOtalqp()
        Dim S400totalqp As Integer
        S400LabelQP1.Text = Val(S400labelpt1.Text) * Val(S400LabelCU1.Text)
        S400LabelQP2.Text = Val(S400labelpt2.Text) * Val(S400LabelCU2.Text)
        S400LabelQP3.Text = Val(S400labelpt3.Text) * Val(S400LabelCU3.Text)
        S400LabelQP4.Text = Val(S400labelpt4.Text) * Val(S400LabelCU4.Text)
        S400LabelQP5.Text = Val(S400labelpt5.Text) * Val(S400LabelCU5.Text)
        S400LabelQP6.Text = Val(S400labelpt6.Text) * Val(S400LabelCU6.Text)
        S400LabelQP7.Text = Val(S400labelpt7.Text) * Val(S400LabelCU7.Text)
        S400LabelQP8.Text = Val(S400labelpt8.Text) * Val(S400LabelCU8.Text)
        S400LabelQP9.Text = Val(S400labelpt9.Text) * Val(S400LabelCU9.Text)
        S400LabelQP10.Text = Val(S400labelpt10.Text) * Val(S400LabelCU10.Text)
        S400LabelQP11.Text = Val(S400labelpt11.Text) * Val(S400LabelCU11.Text)
        S400LabelQP12.Text = Val(S400labelpt12.Text) * Val(S400LabelCU12.Text)
        S400LabelQP13.Text = Val(S400labelpt13.Text) * Val(S400LabelCU13.Text)
        S400LabelQP14.Text = Val(S400labelpt14.Text) * Val(S400LabelCU14.Text)
        S400totalqp = Val(S400LabelQP1.Text) + Val(S400LabelQP2.Text) + Val(S400LabelQP3.Text) + Val(S400LabelQP4.Text) + Val(S400LabelQP5.Text) + Val(S400LabelQP6.Text) + Val(S400LabelQP7.Text) + Val(S400LabelQP8.Text) + Val(S400LabelQP9.Text) + Val(S400LabelQP10.Text) + Val(S400LabelQP11.Text) + Val(S400LabelQP12.Text) + Val(S400LabelQP13.Text) + Val(S400LabelQP14.Text)
        s400qp = S400totalqp
        s400TOTALCUlabel.Text = s400cu
        s400TOTALQPlabel.Text = s400qp
        Label400GPAs.Text = Math.Round(s400qp / s400cu, 2)
        Call nigga()
    End Sub
    's500
    ' USED TO HIDE SOME CONTROLS
    Private Sub S500level1()
        S500ComboBoxCN2.Show()
        S500LabelCN2.Show()
        S500LabelG2.Show()
        S500LabelCU2.Show()
        S500LabelQP2.Show()
        S500TextBoxCN2.Show()
        S500ButtonCN2.Show()
    End Sub
    Private Sub S500level2()
        S500ComboBoxCN3.Show()
        S500LabelCN3.Show()
        S500LabelG3.Show()
        S500LabelCU3.Show()
        S500LabelQP3.Show()
        S500TextBoxCN3.Show()
        S500ButtonCN3.Show()
    End Sub
    Private Sub S500level3()
        S500ComboBoxCN4.Show()
        S500LabelCN4.Show()
        S500LabelG4.Show()
        S500LabelCU4.Show()
        S500LabelQP4.Show()
        S500TextBoxCN4.Show()
        S500ButtonCN4.Show()
    End Sub
    Private Sub S500level4()
        S500ComboBoxCN5.Show()
        S500LabelCN5.Show()
        S500LabelG5.Show()
        S500LabelCU5.Show()
        S500LabelQP5.Show()
        S500TextBoxCN5.Show()
        S500ButtonCN5.Show()
    End Sub
    Private Sub S500level5()
        S500ComboBoxCN6.Show()
        S500LabelCN6.Show()
        S500LabelG6.Show()
        S500LabelCU6.Show()
        S500LabelQP6.Show()
        S500TextBoxCN6.Show()
        S500ButtonCN6.Show()
    End Sub
    Private Sub S500level6()
        S500ComboBoxCN7.Show()
        S500LabelCN7.Show()
        S500LabelG7.Show()
        S500LabelCU7.Show()
        S500LabelQP7.Show()
        S500TextBoxCN7.Show()
        S500ButtonCN7.Show()
    End Sub
    Private Sub S500level7()
        S500ComboBoxCN8.Show()
        S500LabelCN8.Show()
        S500LabelG8.Show()
        S500LabelCU8.Show()
        S500LabelQP8.Show()
        S500TextBoxCN8.Show()
        S500ButtonCN8.Show()
    End Sub
    Private Sub S500level8()
        S500ComboBoxCN9.Show()
        S500LabelCN9.Show()
        S500LabelG9.Show()
        S500LabelCU9.Show()
        S500LabelQP9.Show()
        S500TextBoxCN9.Show()
        S500ButtonCN9.Show()
    End Sub
    Private Sub S500level9()
        S500ComboBoxCN10.Show()
        S500LabelCN10.Show()
        S500LabelG10.Show()
        S500LabelCU10.Show()
        S500LabelQP10.Show()
        S500TextBoxCN10.Show()
        S500ButtonCN10.Show()
    End Sub
    Private Sub S500level10()
        S500ComboBoxCN11.Show()
        S500LabelCN11.Show()
        S500LabelG11.Show()
        S500LabelCU11.Show()
        S500LabelQP11.Show()
        S500TextBoxCN11.Show()
        S500ButtonCN11.Show()
    End Sub
    Private Sub S500level11()
        S500ComboBoxCN12.Show()
        S500LabelCN12.Show()
        S500LabelG12.Show()
        S500LabelCU12.Show()
        S500LabelQP12.Show()
        S500TextBoxCN12.Show()
        S500ButtonCN12.Show()
    End Sub
    Private Sub S500level12()
        S500ComboBoxCN13.Show()
        S500LabelCN13.Show()
        S500LabelG13.Show()
        S500LabelCU13.Show()
        S500LabelQP13.Show()
        S500TextBoxCN13.Show()
        S500ButtonCN13.Show()
    End Sub
    Private Sub S500level13()
        S500ComboBoxCN14.Show()
        S500LabelCN14.Show()
        S500LabelG14.Show()
        S500LabelCU14.Show()
        S500LabelQP14.Show()
        S500TextBoxCN14.Show()
        S500ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub s500hope()
        Call s500coursera()
        S500ListBoxhopecode.Items.Clear()
        s500listboxhopename.Items.Clear()
        s500listboxhopeunit.Items.Clear()
        S500ListBoxF.Items.Clear()
        S500ListBoxFC.Items.Clear()
        S500ListBoxFN.Items.Clear()
        For i = 0 To S500ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = S500ListBoxCourseCode.Items(i).ToString
            Dim morga As String = S500ListBoxCourseName.Items(i).ToString
            Dim morg As String = S500ListBoxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = S500ListBoxCourseName.Items(i).ToString
            Dim gwen As String = S500ListBoxCreditUnit.Items(i).ToString
            If (S500ButtonCN1.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN2.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN3.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN4.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN5.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN6.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN7.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN8.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN9.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN10.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN11.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN12.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN13.Text = S500ListBoxCourseCode.Items(i).ToString) Or (S500ButtonCN14.Text = S500ListBoxCourseCode.Items(i).ToString) Then
                S500ListBoxhopecode.Items.Remove(i)
                s500listboxhopename.Items.Remove(i)
                s500listboxhopeunit.Items.Remove(i)
            Else
                S500ListBoxhopecode.Items.Add(morgan)
                s500listboxhopename.Items.Add(morga)
                s500listboxhopeunit.Items.Add(morg)
            End If
            If (S500ButtonCN1.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG1.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN2.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG2.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN3.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG3.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN4.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG4.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN5.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG5.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN6.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG6.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN7.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG7.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN8.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG8.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN9.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG9.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN10.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG10.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN11.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG11.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN12.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG12.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN13.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG13.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
            If (S500ButtonCN14.Text = S500ListBoxCourseCode.Items(i).ToString) And S500LabelG14.Text = merlin Then
                S500ListBoxF.Items.Add(morgan)
                S500ListBoxFN.Items.Add(arthur)
                S500ListBoxFC.Items.Add(gwen)
            Else
                S500ListBoxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub S500oleku()
        If S500ButtonCN1.Text = "-" Then
            S500TextBoxCN1.Enabled = False
        Else
            S500TextBoxCN1.Enabled = True
        End If
        If S500ButtonCN2.Text = "-" Then
            S500TextBoxCN2.Enabled = False
        Else
            S500TextBoxCN2.Enabled = True
        End If
        If S500ButtonCN3.Text = "-" Then
            S500TextBoxCN3.Enabled = False
        Else
            S500TextBoxCN3.Enabled = True
        End If
        If S500ButtonCN4.Text = "-" Then
            S500TextBoxCN4.Enabled = False
        Else
            S500TextBoxCN4.Enabled = True
        End If
        If S500ButtonCN5.Text = "-" Then
            S500TextBoxCN5.Enabled = False
        Else
            S500TextBoxCN5.Enabled = True
        End If
        If S500ButtonCN6.Text = "-" Then
            S500TextBoxCN6.Enabled = False
        Else
            S500TextBoxCN6.Enabled = True
        End If
        If S500ButtonCN7.Text = "-" Then
            S500TextBoxCN7.Enabled = False
        Else
            S500TextBoxCN7.Enabled = True
        End If
        If S500ButtonCN8.Text = "-" Then
            S500TextBoxCN8.Enabled = False
        Else
            S500TextBoxCN8.Enabled = True
        End If
        If S500ButtonCN9.Text = "-" Then
            S500TextBoxCN9.Enabled = False
        Else
            S500TextBoxCN9.Enabled = True
        End If
        If S500ButtonCN10.Text = "-" Then
            S500TextBoxCN10.Enabled = False
        Else
            S500TextBoxCN10.Enabled = True
        End If
        If S500ButtonCN11.Text = "-" Then
            S500TextBoxCN11.Enabled = False
        Else
            S500TextBoxCN11.Enabled = True
        End If
        If S500ButtonCN12.Text = "-" Then
            S500TextBoxCN12.Enabled = False
        Else
            S500TextBoxCN12.Enabled = True
        End If
        If S500ButtonCN13.Text = "-" Then
            S500TextBoxCN13.Enabled = False
        Else
            S500TextBoxCN13.Enabled = True
        End If
        If S500ButtonCN14.Text = "-" Then
            S500TextBoxCN14.Enabled = False
        Else
            S500TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub S500TOtalcreditunit()
        Dim s500totalcu As Integer
        s500totalcu = Val(S500LabelCU1.Text) + Val(S500LabelCU2.Text) + Val(S500LabelCU3.Text) + Val(S500LabelCU4.Text) + Val(S500LabelCU5.Text) + Val(S500LabelCU6.Text) + Val(S500LabelCU7.Text) + Val(S500LabelCU8.Text) + Val(S500LabelCU9.Text) + Val(S500LabelCU10.Text) + Val(S500LabelCU11.Text) + Val(S500LabelCU12.Text) + Val(S500LabelCU13.Text) + Val(S500LabelCU14.Text)
        s500cu = s500totalcu
        s500TOTALCUlabel.Text = s500cu
    End Sub
    Private Sub S500TOtalqp()
        Dim S500totalqp As Integer
        S500LabelQP1.Text = Val(S500labelpt1.Text) * Val(S500LabelCU1.Text)
        S500LabelQP2.Text = Val(S500labelpt2.Text) * Val(S500LabelCU2.Text)
        S500LabelQP3.Text = Val(S500labelpt3.Text) * Val(S500LabelCU3.Text)
        S500LabelQP4.Text = Val(S500labelpt4.Text) * Val(S500LabelCU4.Text)
        S500LabelQP5.Text = Val(S500labelpt5.Text) * Val(S500LabelCU5.Text)
        S500LabelQP6.Text = Val(S500labelpt6.Text) * Val(S500LabelCU6.Text)
        S500LabelQP7.Text = Val(S500labelpt7.Text) * Val(S500LabelCU7.Text)
        S500LabelQP8.Text = Val(S500labelpt8.Text) * Val(S500LabelCU8.Text)
        S500LabelQP9.Text = Val(S500labelpt9.Text) * Val(S500LabelCU9.Text)
        S500LabelQP10.Text = Val(S500labelpt10.Text) * Val(S500LabelCU10.Text)
        S500LabelQP11.Text = Val(S500labelpt11.Text) * Val(S500LabelCU11.Text)
        S500LabelQP12.Text = Val(S500labelpt12.Text) * Val(S500LabelCU12.Text)
        S500LabelQP13.Text = Val(S500labelpt13.Text) * Val(S500LabelCU13.Text)
        S500LabelQP14.Text = Val(S500labelpt14.Text) * Val(S500LabelCU14.Text)
        S500totalqp = Val(S500LabelQP1.Text) + Val(S500LabelQP2.Text) + Val(S500LabelQP3.Text) + Val(S500LabelQP4.Text) + Val(S500LabelQP5.Text) + Val(S500LabelQP6.Text) + Val(S500LabelQP7.Text) + Val(S500LabelQP8.Text) + Val(S500LabelQP9.Text) + Val(S500LabelQP10.Text) + Val(S500LabelQP11.Text) + Val(S500LabelQP12.Text) + Val(S500LabelQP13.Text) + Val(S500LabelQP14.Text)
        s500qp = S500totalqp
        s500TOTALCUlabel.Text = s500cu
        s500TOTALQPlabel.Text = s500qp
        Label500GPAs.Text = Math.Round(s500qp / s500cu, 2)
        Call nigga()
    End Sub
    's600
    ' USED TO HIDE SOME CONTROLS
    Private Sub S600level1()
        S600ComboboxCN2.Show()
        S600LabelCN2.Show()
        S600LabelG2.Show()
        S600LabelCU2.Show()
        S600LabelQP2.Show()
        S600TextBoxCN2.Show()
        S600ButtonCN2.Show()
    End Sub
    Private Sub S600level2()
        S600ComboboxCN3.Show()
        S600LabelCN3.Show()
        S600LabelG3.Show()
        S600LabelCU3.Show()
        S600LabelQP3.Show()
        S600TextBoxCN3.Show()
        S600ButtonCN3.Show()
    End Sub
    Private Sub S600level3()
        S600ComboboxCN4.Show()
        S600LabelCN4.Show()
        S600LabelG4.Show()
        S600LabelCU4.Show()
        S600LabelQP4.Show()
        S600TextBoxCN4.Show()
        S600ButtonCN4.Show()
    End Sub
    Private Sub S600level4()
        S600ComboboxCN5.Show()
        S600LabelCN5.Show()
        S600LabelG5.Show()
        S600LabelCU5.Show()
        S600LabelQP5.Show()
        S600TextBoxCN5.Show()
        S600ButtonCN5.Show()
    End Sub
    Private Sub S600level5()
        S600ComboboxCN6.Show()
        S600LabelCN6.Show()
        S600LabelG6.Show()
        S600LabelCU6.Show()
        S600LabelQP6.Show()
        S600TextBoxCN6.Show()
        S600ButtonCN6.Show()
    End Sub
    Private Sub S600level6()
        S600ComboboxCN7.Show()
        S600LabelCN7.Show()
        S600LabelG7.Show()
        S600LabelCU7.Show()
        S600LabelQP7.Show()
        S600TextBoxCN7.Show()
        S600ButtonCN7.Show()
    End Sub
    Private Sub S600level7()
        S600ComboboxCN8.Show()
        S600LabelCN8.Show()
        S600LabelG8.Show()
        S600LabelCU8.Show()
        S600LabelQP8.Show()
        S600TextBoxCN8.Show()
        S600ButtonCN8.Show()
    End Sub
    Private Sub S600level8()
        S600ComboboxCN9.Show()
        S600LabelCN9.Show()
        S600LabelG9.Show()
        S600LabelCU9.Show()
        S600LabelQP9.Show()
        S600TextBoxCN9.Show()
        S600ButtonCN9.Show()
    End Sub
    Private Sub S600level9()
        S600ComboboxCN10.Show()
        S600LabelCN10.Show()
        S600LabelG10.Show()
        S600LabelCU10.Show()
        S600LabelQP10.Show()
        S600TextBoxCN10.Show()
        S600ButtonCN10.Show()
    End Sub
    Private Sub S600level10()
        S600ComboboxCN11.Show()
        S600LabelCN11.Show()
        S600LabelG11.Show()
        S600LabelCU11.Show()
        S600LabelQP11.Show()
        S600TextBoxCN11.Show()
        S600ButtonCN11.Show()
    End Sub
    Private Sub S600level11()
        S600ComboboxCN12.Show()
        S600LabelCN12.Show()
        S600LabelG12.Show()
        S600LabelCU12.Show()
        S600LabelQP12.Show()
        S600TextBoxCN12.Show()
        S600ButtonCN12.Show()
    End Sub
    Private Sub S600level12()
        S600ComboboxCN13.Show()
        S600LabelCN13.Show()
        S600LabelG13.Show()
        S600LabelCU13.Show()
        S600LabelQP13.Show()
        S600TextBoxCN13.Show()
        S600ButtonCN13.Show()
    End Sub
    Private Sub S600level13()
        S600ComboboxCN14.Show()
        S600LabelCN14.Show()
        S600LabelG14.Show()
        S600LabelCU14.Show()
        S600LabelQP14.Show()
        S600TextBoxCN14.Show()
        S600ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub s600hope()
        Call s600coursera()
        S600ListBoxHopeCode.Items.Clear()
        s600listboxhopename.Items.Clear()
        s600listboxhopeunit.Items.Clear()
        S600ListBoxF.Items.Clear()
        S600ListBoxFC.Items.Clear()
        S600ListBoxFN.Items.Clear()
        For i = 0 To S600ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = S600ListBoxCourseCode.Items(i).ToString
            Dim morga As String = S600ListBoxCoursename.Items(i).ToString
            Dim morg As String = S600ListBoxCreditunit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = S600ListBoxCoursename.Items(i).ToString
            Dim gwen As String = S600ListBoxCreditunit.Items(i).ToString
            If (S600ButtonCN1.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN2.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN3.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN4.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN5.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN6.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN7.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN8.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN9.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN10.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN11.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN12.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN13.Text = S600ListBoxCourseCode.Items(i).ToString) Or (S600ButtonCN14.Text = S600ListBoxCourseCode.Items(i).ToString) Then
                S600ListBoxHopeCode.Items.Remove(i)
                s600listboxhopename.Items.Remove(i)
                s600listboxhopeunit.Items.Remove(i)
            Else
                S600ListBoxHopeCode.Items.Add(morgan)
                s600listboxhopename.Items.Add(morga)
                s600listboxhopeunit.Items.Add(morg)
            End If
            If (S600ButtonCN1.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG1.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN2.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG2.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN3.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG3.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN4.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG4.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN5.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG5.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN6.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG6.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN7.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG7.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN8.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG8.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN9.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG9.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN10.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG10.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN11.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG11.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN12.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG12.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN13.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG13.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
            If (S600ButtonCN14.Text = S600ListBoxCourseCode.Items(i).ToString) And S600LabelG14.Text = merlin Then
                S600ListBoxF.Items.Add(morgan)
                S600ListBoxFN.Items.Add(arthur)
                S600ListBoxFC.Items.Add(gwen)
            Else
                S600ListBoxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub S600oleku()
        If S600ButtonCN1.Text = "-" Then
            S600TextBoxCN1.Enabled = False
        Else
            S600TextBoxCN1.Enabled = True
        End If
        If S600ButtonCN2.Text = "-" Then
            S600TextBoxCN2.Enabled = False
        Else
            S600TextBoxCN2.Enabled = True
        End If
        If S600ButtonCN3.Text = "-" Then
            S600TextBoxCN3.Enabled = False
        Else
            S600TextBoxCN3.Enabled = True
        End If
        If S600ButtonCN4.Text = "-" Then
            S600TextBoxCN4.Enabled = False
        Else
            S600TextBoxCN4.Enabled = True
        End If
        If S600ButtonCN5.Text = "-" Then
            S600TextBoxCN5.Enabled = False
        Else
            S600TextBoxCN5.Enabled = True
        End If
        If S600ButtonCN6.Text = "-" Then
            S600TextBoxCN6.Enabled = False
        Else
            S600TextBoxCN6.Enabled = True
        End If
        If S600ButtonCN7.Text = "-" Then
            S600TextBoxCN7.Enabled = False
        Else
            S600TextBoxCN7.Enabled = True
        End If
        If S600ButtonCN8.Text = "-" Then
            S600TextBoxCN8.Enabled = False
        Else
            S600TextBoxCN8.Enabled = True
        End If
        If S600ButtonCN9.Text = "-" Then
            S600TextBoxCN9.Enabled = False
        Else
            S600TextBoxCN9.Enabled = True
        End If
        If S600ButtonCN10.Text = "-" Then
            S600TextBoxCN10.Enabled = False
        Else
            S600TextBoxCN10.Enabled = True
        End If
        If S600ButtonCN11.Text = "-" Then
            S600TextBoxCN11.Enabled = False
        Else
            S600TextBoxCN11.Enabled = True
        End If
        If S600ButtonCN12.Text = "-" Then
            S600TextBoxCN12.Enabled = False
        Else
            S600TextBoxCN12.Enabled = True
        End If
        If S600ButtonCN13.Text = "-" Then
            S600TextBoxCN13.Enabled = False
        Else
            S600TextBoxCN13.Enabled = True
        End If
        If S600ButtonCN14.Text = "-" Then
            S600TextBoxCN14.Enabled = False
        Else
            S600TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub S600TOtalcreditunit()
        Dim s600totalcu As Integer
        s600totalcu = Val(S600LabelCU1.Text) + Val(S600LabelCU2.Text) + Val(S600LabelCU3.Text) + Val(S600LabelCU4.Text) + Val(S600LabelCU5.Text) + Val(S600LabelCU6.Text) + Val(S600LabelCU7.Text) + Val(S600LabelCU8.Text) + Val(S600LabelCU9.Text) + Val(S600LabelCU10.Text) + Val(S600LabelCU11.Text) + Val(S600LabelCU12.Text) + Val(S600LabelCU13.Text) + Val(S600LabelCU14.Text)
        s600cu = s600totalcu
        s600TOTALCUlabel.Text = s600cu
    End Sub
    Private Sub S600TOtalqp()
        Dim S600totalqp As Integer
        S600LabelQP1.Text = Val(S600labelpt1.Text) * Val(S600LabelCU1.Text)
        S600LabelQP2.Text = Val(S600labelpt2.Text) * Val(S600LabelCU2.Text)
        S600LabelQP3.Text = Val(S600labelpt3.Text) * Val(S600LabelCU3.Text)
        S600LabelQP4.Text = Val(S600labelpt4.Text) * Val(S600LabelCU4.Text)
        S600LabelQP5.Text = Val(S600labelpt5.Text) * Val(S600LabelCU5.Text)
        S600LabelQP6.Text = Val(S600labelpt6.Text) * Val(S600LabelCU6.Text)
        S600LabelQP7.Text = Val(S600labelpt7.Text) * Val(S600LabelCU7.Text)
        S600LabelQP8.Text = Val(S600labelpt8.Text) * Val(S600LabelCU8.Text)
        S600LabelQP9.Text = Val(S600labelpt9.Text) * Val(S600LabelCU9.Text)
        S600LabelQP10.Text = Val(S600labelpt10.Text) * Val(S600LabelCU10.Text)
        S600LabelQP11.Text = Val(S600labelpt11.Text) * Val(S600LabelCU11.Text)
        S600LabelQP12.Text = Val(S600labelpt12.Text) * Val(S600LabelCU12.Text)
        S600LabelQP13.Text = Val(S600labelpt13.Text) * Val(S600LabelCU13.Text)
        S600LabelQP14.Text = Val(S600labelpt14.Text) * Val(S600LabelCU14.Text)
        S600totalqp = Val(S600LabelQP1.Text) + Val(S600LabelQP2.Text) + Val(S600LabelQP3.Text) + Val(S600LabelQP4.Text) + Val(S600LabelQP5.Text) + Val(S600LabelQP6.Text) + Val(S600LabelQP7.Text) + Val(S600LabelQP8.Text) + Val(S600LabelQP9.Text) + Val(S600LabelQP10.Text) + Val(S600LabelQP11.Text) + Val(S600LabelQP12.Text) + Val(S600LabelQP13.Text) + Val(S600LabelQP14.Text)
        s600qp = S600totalqp
        s600TOTALCUlabel.Text = s600cu
        s600TOTALQPlabel.Text = s600qp
        Label600GPAs.Text = Math.Round(s600qp / s600cu, 2)
        Call nigga()
    End Sub
    's700
    ' USED TO HIDE SOME CONTROLS
    Private Sub S700level1()
        S700ComboboxCN2.Show()
        S700LabelCN2.Show()
        S700LabelG2.Show()
        S700LabelCU2.Show()
        S700LabelQP2.Show()
        S700TextBoxCN2.Show()
        S700ButtonCN2.Show()
    End Sub
    Private Sub S700level2()
        S700ComboboxCN3.Show()
        S700LabelCN3.Show()
        S700LabelG3.Show()
        S700LabelCU3.Show()
        S700LabelQP3.Show()
        S700TextBoxCN3.Show()
        S700ButtonCN3.Show()
    End Sub
    Private Sub S700level3()
        S700ComboboxCN4.Show()
        S700LabelCN4.Show()
        S700LabelG4.Show()
        S700LabelCU4.Show()
        S700LabelQP4.Show()
        S700TextBoxCN4.Show()
        S700ButtonCN4.Show()
    End Sub
    Private Sub S700level4()
        S700ComboboxCN5.Show()
        S700LabelCN5.Show()
        S700LabelG5.Show()
        S700LabelCU5.Show()
        S700LabelQP5.Show()
        S700TextBoxCN5.Show()
        S700ButtonCN5.Show()
    End Sub
    Private Sub S700level5()
        S700ComboboxCN6.Show()
        S700LabelCN6.Show()
        S700LabelG6.Show()
        S700LabelCU6.Show()
        S700LabelQP6.Show()
        S700TextBoxCN6.Show()
        S700ButtonCN6.Show()
    End Sub
    Private Sub S700level6()
        S700ComboboxCN7.Show()
        S700LabelCN7.Show()
        S700LabelG7.Show()
        S700LabelCU7.Show()
        S700LabelQP7.Show()
        S700TextBoxCN7.Show()
        S700ButtonCN7.Show()
    End Sub
    Private Sub S700level7()
        S700ComboboxCN8.Show()
        S700LabelCN8.Show()
        S700LabelG8.Show()
        S700LabelCU8.Show()
        S700LabelQP8.Show()
        S700TextBoxCN8.Show()
        S700ButtonCN8.Show()
    End Sub
    Private Sub S700level8()
        S700ComboboxCN9.Show()
        S700LabelCN9.Show()
        S700LabelG9.Show()
        S700LabelCU9.Show()
        S700LabelQP9.Show()
        S700TextBoxCN9.Show()
        S700ButtonCN9.Show()
    End Sub
    Private Sub S700level9()
        S700ComboboxCN10.Show()
        S700LabelCN10.Show()
        S700LabelG10.Show()
        S700LabelCU10.Show()
        S700LabelQP10.Show()
        S700TextBoxCN10.Show()
        S700ButtonCN10.Show()
    End Sub
    Private Sub S700level10()
        S700ComboboxCN11.Show()
        S700LabelCN11.Show()
        S700LabelG11.Show()
        S700LabelCU11.Show()
        S700LabelQP11.Show()
        S700TextBoxCN11.Show()
        S700ButtonCN11.Show()
    End Sub
    Private Sub S700level11()
        S700ComboboxCN12.Show()
        S700LabelCN12.Show()
        S700LabelG12.Show()
        S700LabelCU12.Show()
        S700LabelQP12.Show()
        S700TextBoxCN12.Show()
        S700ButtonCN12.Show()
    End Sub
    Private Sub S700level12()
        S700ComboboxCN13.Show()
        S700LabelCN13.Show()
        S700LabelG13.Show()
        S700LabelCU13.Show()
        S700LabelQP13.Show()
        S700TextBoxCN13.Show()
        S700ButtonCN13.Show()
    End Sub
    Private Sub S700level13()
        S700ComboboxCN14.Show()
        S700LabelCN14.Show()
        S700LabelG14.Show()
        S700LabelCU14.Show()
        S700LabelQP14.Show()
        S700TextBoxCN14.Show()
        S700ButtonCN14.Show()
    End Sub

    'sub-mother board
    Private Sub s700hope()
        Call s700coursera()
        S700ListBoxhopecode.Items.Clear()
        s700listboxhopename.Items.Clear()
        s700listboxhopeunit.Items.Clear()
        S700ListBoxF.Items.Clear()
        S700ListBoxFC.Items.Clear()
        S700ListBoxFN.Items.Clear()
        For i = 0 To S700ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = S700ListBoxCourseCode.Items(i).ToString
            Dim morga As String = S700ListBoxCourseName.Items(i).ToString
            Dim morg As String = S700ListBoxCreditUnit.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = S700ListBoxCourseName.Items(i).ToString
            Dim gwen As String = S700ListBoxCreditUnit.Items(i).ToString
            If (S700ButtonCN1.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN2.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN3.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN4.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN5.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN6.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN7.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN8.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN9.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN10.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN11.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN12.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN13.Text = S700ListBoxCourseCode.Items(i).ToString) Or (S700ButtonCN14.Text = S700ListBoxCourseCode.Items(i).ToString) Then
                S700ListBoxhopecode.Items.Remove(i)
                s700listboxhopename.Items.Remove(i)
                s700listboxhopeunit.Items.Remove(i)
            Else
                S700ListBoxhopecode.Items.Add(morgan)
                s700listboxhopename.Items.Add(morga)
                s700listboxhopeunit.Items.Add(morg)
            End If
            If (S700ButtonCN1.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG1.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN2.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG2.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN3.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG3.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN4.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG4.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN5.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG5.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN6.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG6.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN7.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG7.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN8.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG8.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN9.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG9.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN10.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG10.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN11.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG11.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN12.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG12.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN13.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG13.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
            If (S700ButtonCN14.Text = S700ListBoxCourseCode.Items(i).ToString) And S700LabelG14.Text = merlin Then
                S700ListBoxF.Items.Add(morgan)
                S700ListBoxFN.Items.Add(arthur)
                S700ListBoxFC.Items.Add(gwen)
            Else
                S700ListBoxF.Items.Remove(i)
            End If
        Next
    End Sub
    Private Sub S700oleku()
        If S700ButtonCN1.Text = "-" Then
            S700TextBoxCN1.Enabled = False
        Else
            S700TextBoxCN1.Enabled = True
        End If
        If S700ButtonCN2.Text = "-" Then
            S700TextBoxCN2.Enabled = False
        Else
            S700TextBoxCN2.Enabled = True
        End If
        If S700ButtonCN3.Text = "-" Then
            S700TextBoxCN3.Enabled = False
        Else
            S700TextBoxCN3.Enabled = True
        End If
        If S700ButtonCN4.Text = "-" Then
            S700TextBoxCN4.Enabled = False
        Else
            S700TextBoxCN4.Enabled = True
        End If
        If S700ButtonCN5.Text = "-" Then
            S700TextBoxCN5.Enabled = False
        Else
            S700TextBoxCN5.Enabled = True
        End If
        If S700ButtonCN6.Text = "-" Then
            S700TextBoxCN6.Enabled = False
        Else
            S700TextBoxCN6.Enabled = True
        End If
        If S700ButtonCN7.Text = "-" Then
            S700TextBoxCN7.Enabled = False
        Else
            S700TextBoxCN7.Enabled = True
        End If
        If S700ButtonCN8.Text = "-" Then
            S700TextBoxCN8.Enabled = False
        Else
            S700TextBoxCN8.Enabled = True
        End If
        If S700ButtonCN9.Text = "-" Then
            S700TextBoxCN9.Enabled = False
        Else
            S700TextBoxCN9.Enabled = True
        End If
        If S700ButtonCN10.Text = "-" Then
            S700TextBoxCN10.Enabled = False
        Else
            S700TextBoxCN10.Enabled = True
        End If
        If S700ButtonCN11.Text = "-" Then
            S700TextBoxCN11.Enabled = False
        Else
            S700TextBoxCN11.Enabled = True
        End If
        If S700ButtonCN12.Text = "-" Then
            S700TextBoxCN12.Enabled = False
        Else
            S700TextBoxCN12.Enabled = True
        End If
        If S700ButtonCN13.Text = "-" Then
            S700TextBoxCN13.Enabled = False
        Else
            S700TextBoxCN13.Enabled = True
        End If
        If S700ButtonCN14.Text = "-" Then
            S700TextBoxCN14.Enabled = False
        Else
            S700TextBoxCN14.Enabled = True
        End If
    End Sub
    Private Sub S700TOtalcreditunit()
        Dim s700totalcu As Integer
        s700totalcu = Val(S700LabelCU1.Text) + Val(S700LabelCU2.Text) + Val(S700LabelCU3.Text) + Val(S700LabelCU4.Text) + Val(S700LabelCU5.Text) + Val(S700LabelCU6.Text) + Val(S700LabelCU7.Text) + Val(S700LabelCU8.Text) + Val(S700LabelCU9.Text) + Val(S700LabelCU10.Text) + Val(S700LabelCU11.Text) + Val(S700LabelCU12.Text) + Val(S700LabelCU13.Text) + Val(S700LabelCU14.Text)
        s700cu = s700totalcu
        s700TOTALCUlabel.Text = s700cu
    End Sub
    Private Sub S700TOtalqp()
        Dim S700totalqp As Integer
        S700LabelQP1.Text = Val(S700labelpt1.Text) * Val(S700LabelCU1.Text)
        S700LabelQP2.Text = Val(S700labelpt2.Text) * Val(S700LabelCU2.Text)
        S700LabelQP3.Text = Val(S700labelpt3.Text) * Val(S700LabelCU3.Text)
        S700LabelQP4.Text = Val(S700labelpt4.Text) * Val(S700LabelCU4.Text)
        S700LabelQP5.Text = Val(S700labelpt5.Text) * Val(S700LabelCU5.Text)
        S700LabelQP6.Text = Val(S700labelpt6.Text) * Val(S700LabelCU6.Text)
        S700LabelQP7.Text = Val(S700labelpt7.Text) * Val(S700LabelCU7.Text)
        S700LabelQP8.Text = Val(S700labelpt8.Text) * Val(S700LabelCU8.Text)
        S700LabelQP9.Text = Val(S700labelpt9.Text) * Val(S700LabelCU9.Text)
        S700LabelQP10.Text = Val(S700labelpt10.Text) * Val(S700LabelCU10.Text)
        S700LabelQP11.Text = Val(S700labelpt11.Text) * Val(S700LabelCU11.Text)
        S700LabelQP12.Text = Val(S700labelpt12.Text) * Val(S700LabelCU12.Text)
        S700LabelQP13.Text = Val(S700labelpt13.Text) * Val(S700LabelCU13.Text)
        S700LabelQP14.Text = Val(S700labelpt14.Text) * Val(S700LabelCU14.Text)
        S700totalqp = Val(S700LabelQP1.Text) + Val(S700LabelQP2.Text) + Val(S700LabelQP3.Text) + Val(S700LabelQP4.Text) + Val(S700LabelQP5.Text) + Val(S700LabelQP6.Text) + Val(S700LabelQP7.Text) + Val(S700LabelQP8.Text) + Val(S700LabelQP9.Text) + Val(S700LabelQP10.Text) + Val(S700LabelQP11.Text) + Val(S700LabelQP12.Text) + Val(S700LabelQP13.Text) + Val(S700LabelQP14.Text)
        s700qp = S700totalqp
        s700TOTALCUlabel.Text = s700cu
        s700TOTALQPlabel.Text = s700qp
        Label700GPAs.Text = Math.Round(s700qp / s700cu, 2)
        Call nigga()
    End Sub
    'f100 comboxes and textboxexs
    Private Sub F100ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN1.Click
        F100ComboBoxCN1.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN1.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN1.SelectedItem.ToString
        F100ButtonCn1.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN1.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU1.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU1.Text = "-"
            F100LabelCN1.Text = "-"
            F100LabelQP1.Text = "-"
            F100TextBoxCN1.Enabled = False
            F100LabelG1.Text = "-"
            F100ButtonCn1.Text = "-"
        Else
            F100TextBoxCN1.Enabled = True
            Call F100oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level1()
        Else
        End If
        Call F100TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG1.Text = "F"
            F100LabelG1.ForeColor = Color.Red
            F100labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG1.Text = "E"
            F100LabelG1.ForeColor = Color.Black
            F100labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG1.Text = "D"
            F100LabelG1.ForeColor = Color.Black
            F100labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG1.Text = "C"
            F100LabelG1.ForeColor = Color.Black
            F100labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG1.Text = "B"
            F100LabelG1.ForeColor = Color.Black
            F100labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG1.Text = "A"
            F100LabelG1.ForeColor = Color.Black
            F100labelpt1.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN2.Click
        F100ComboBoxCN2.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN2.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN2.SelectedItem.ToString
        F100ButtonCN2.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN2.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU2.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU2.Text = "-"
            F100LabelCN2.Text = "-"
            F100LabelQP2.Text = "-"
            F100TextBoxCN2.Enabled = False
            F100LabelG2.Text = "-"
            F100ButtonCN2.Text = "-"
        Else
            F100TextBoxCN2.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level2()
        Else
        End If
        Call F100TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG2.Text = "F"
            F100LabelG2.ForeColor = Color.Red
            F100labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG2.Text = "E"
            F100LabelG2.ForeColor = Color.Black
            F100labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG2.Text = "D"
            F100LabelG2.ForeColor = Color.Black
            F100labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG2.Text = "C"
            F100LabelG2.ForeColor = Color.Black
            F100labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG2.Text = "B"
            F100LabelG2.ForeColor = Color.Black
            F100labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG2.Text = "A"
            F100LabelG2.ForeColor = Color.Black
            F100labelpt2.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN3.Click
        F100ComboBoxCN3.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN3.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN3.SelectedItem.ToString
        F100ButtonCN3.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN3.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU3.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU3.Text = "-"
            F100LabelCN3.Text = "-"
            F100LabelQP3.Text = "-"
            F100TextBoxCN3.Enabled = False
            F100LabelG3.Text = "-"
            F100ButtonCN3.Text = "-"
        Else
            F100TextBoxCN3.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level3()
        Else
        End If
        Call F100TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG3.Text = "F"
            F100LabelG3.ForeColor = Color.Red
            F100labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG3.Text = "E"
            F100LabelG3.ForeColor = Color.Black
            F100labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG3.Text = "D"
            F100LabelG3.ForeColor = Color.Black
            F100labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG3.Text = "C"
            F100LabelG3.ForeColor = Color.Black
            F100labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG3.Text = "B"
            F100LabelG3.ForeColor = Color.Black
            F100labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG3.Text = "A"
            F100LabelG3.ForeColor = Color.Black
            F100labelpt3.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN4.Click
        F100ComboBoxCN4.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN4.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN4.SelectedItem.ToString
        F100ButtonCN4.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN4.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU4.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU4.Text = "-"
            F100LabelCN4.Text = "-"
            F100LabelQP4.Text = "-"
            F100TextBoxCN4.Enabled = False
            F100LabelG4.Text = "-"
            F100ButtonCN4.Text = "-"
        Else
            F100TextBoxCN4.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level4()
        Else
        End If
        Call F100TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG4.Text = "F"
            F100LabelG4.ForeColor = Color.Red
            F100labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG4.Text = "E"
            F100LabelG4.ForeColor = Color.Black
            F100labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG4.Text = "D"
            F100LabelG4.ForeColor = Color.Black
            F100labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG4.Text = "C"
            F100LabelG4.ForeColor = Color.Black
            F100labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG4.Text = "B"
            F100LabelG4.ForeColor = Color.Black
            F100labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG4.Text = "A"
            F100LabelG4.ForeColor = Color.Black
            F100labelpt4.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN5.Click
        F100ComboBoxCN5.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN5.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN5.SelectedItem.ToString
        F100ButtonCN5.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN5.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU5.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU5.Text = "-"
            F100LabelCN5.Text = "-"
            F100LabelQP5.Text = "-"
            F100TextBoxCN5.Enabled = False
            F100LabelG5.Text = "-"
            F100ButtonCN5.Text = "-"
        Else
            F100TextBoxCN5.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level5()
        Else
        End If
        Call F100TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG5.Text = "F"
            F100LabelG5.ForeColor = Color.Red
            F100labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG5.Text = "E"
            F100LabelG5.ForeColor = Color.Black
            F100labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG5.Text = "D"
            F100LabelG5.ForeColor = Color.Black
            F100labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG5.Text = "C"
            F100LabelG5.ForeColor = Color.Black
            F100labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG5.Text = "B"
            F100LabelG5.ForeColor = Color.Black
            F100labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG5.Text = "A"
            F100LabelG5.ForeColor = Color.Black
            F100labelpt5.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN6.Click
        F100ComboBoxCN6.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN6.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN6.SelectedItem.ToString
        F100ButtonCN6.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN6.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU6.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU6.Text = "-"
            F100LabelCN6.Text = "-"
            F100LabelQP6.Text = "-"
            F100TextBoxCN6.Enabled = False
            F100LabelG6.Text = "-"
            F100ButtonCN6.Text = "-"
        Else
            F100TextBoxCN6.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level6()
        Else
        End If
        Call F100TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG6.Text = "F"
            F100LabelG6.ForeColor = Color.Red
            F100labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG6.Text = "E"
            F100LabelG6.ForeColor = Color.Black
            F100labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG6.Text = "D"
            F100LabelG6.ForeColor = Color.Black
            F100labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG6.Text = "C"
            F100LabelG6.ForeColor = Color.Black
            F100labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG6.Text = "B"
            F100LabelG6.ForeColor = Color.Black
            F100labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG6.Text = "A"
            F100LabelG6.ForeColor = Color.Black
            F100labelpt6.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN7.Click
        F100ComboBoxCN7.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN7.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN7.SelectedItem.ToString
        F100ButtonCN7.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN7.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU7.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU7.Text = "-"
            F100LabelCN7.Text = "-"
            F100LabelQP7.Text = "-"
            F100TextBoxCN7.Enabled = False
            F100LabelG7.Text = "-"
            F100ButtonCN7.Text = "-"
        Else
            F100TextBoxCN7.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level7()
        Else
        End If
        Call F100TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG7.Text = "F"
            F100LabelG7.ForeColor = Color.Red
            F100labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG7.Text = "E"
            F100LabelG7.ForeColor = Color.Black
            F100labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG7.Text = "D"
            F100LabelG7.ForeColor = Color.Black
            F100labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG7.Text = "C"
            F100LabelG7.ForeColor = Color.Black
            F100labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG7.Text = "B"
            F100LabelG7.ForeColor = Color.Black
            F100labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG7.Text = "A"
            F100LabelG7.ForeColor = Color.Black
            F100labelpt7.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN8.Click
        F100ComboBoxCN8.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN8.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN8.SelectedItem.ToString
        F100ButtonCN8.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN8.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU8.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU8.Text = "-"
            F100LabelCN8.Text = "-"
            F100LabelQP8.Text = "-"
            F100TextBoxCN8.Enabled = False
            F100LabelG8.Text = "-"
            F100ButtonCN8.Text = "-"
        Else
            F100TextBoxCN8.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level8()
        Else
        End If
        Call F100TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG8.Text = "F"
            F100LabelG8.ForeColor = Color.Red
            F100labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG8.Text = "E"
            F100LabelG8.ForeColor = Color.Black
            F100labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG8.Text = "D"
            F100LabelG8.ForeColor = Color.Black
            F100labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG8.Text = "C"
            F100LabelG8.ForeColor = Color.Black
            F100labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG8.Text = "B"
            F100LabelG8.ForeColor = Color.Black
            F100labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG8.Text = "A"
            F100LabelG8.ForeColor = Color.Black
            F100labelpt8.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN9.Click
        F100ComboBoxCN9.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN9.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN9.SelectedItem.ToString
        F100ButtonCN9.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN9.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU9.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU9.Text = "-"
            F100LabelCN9.Text = "-"
            F100LabelQP9.Text = "-"
            F100TextBoxCN9.Enabled = False
            F100LabelG9.Text = "-"
            F100ButtonCN9.Text = "-"
        Else
            F100TextBoxCN9.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level9()
        Else
        End If
        Call F100TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG9.Text = "F"
            F100LabelG9.ForeColor = Color.Red
            F100labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG9.Text = "E"
            F100LabelG9.ForeColor = Color.Black
            F100labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG9.Text = "D"
            F100LabelG9.ForeColor = Color.Black
            F100labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG9.Text = "C"
            F100LabelG9.ForeColor = Color.Black
            F100labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG9.Text = "B"
            F100LabelG9.ForeColor = Color.Black
            F100labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG9.Text = "A"
            F100LabelG9.ForeColor = Color.Black
            F100labelpt9.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN10.Click
        F100ComboBoxCN10.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN10.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN10.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN10.SelectedItem.ToString
        F100ButtonCN10.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN10.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU10.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU10.Text = "-"
            F100LabelCN10.Text = "-"
            F100LabelQP10.Text = "-"
            F100TextBoxCN10.Enabled = False
            F100LabelG10.Text = "-"
            F100ButtonCN10.Text = "-"
        Else
            F100TextBoxCN1.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level10()
        Else
        End If
        Call F100TextBoxcn10_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN10.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN10.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN10.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN10.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG10.Text = "F"
            F100LabelG10.ForeColor = Color.Red
            F100labelpt10.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG10.Text = "E"
            F100LabelG10.ForeColor = Color.Black
            F100labelpt10.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG10.Text = "D"
            F100LabelG10.ForeColor = Color.Black
            F100labelpt10.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG10.Text = "C"
            F100LabelG10.ForeColor = Color.Black
            F100labelpt10.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG10.Text = "B"
            F100LabelG10.ForeColor = Color.Black
            F100labelpt10.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG10.Text = "A"
            F100LabelG10.ForeColor = Color.Black
            F100labelpt10.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN11.Click
        F100ComboBoxCN11.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN11.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN11.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN11.SelectedItem.ToString
        F100ButtonCN11.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN11.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU11.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU11.Text = "-"
            F100LabelCN11.Text = "-"
            F100LabelQP11.Text = "-"
            F100TextBoxCN11.Enabled = False
            F100LabelG11.Text = "-"
            F100ButtonCN11.Text = "-"
        Else
            F100TextBoxCN11.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level11()
        Else
        End If
        Call F100TextBoxcn11_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN11.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN11.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN11.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN11.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG11.Text = "F"
            F100LabelG11.ForeColor = Color.Red
            F100labelpt11.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG11.Text = "E"
            F100LabelG11.ForeColor = Color.Black
            F100labelpt11.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG11.Text = "D"
            F100LabelG11.ForeColor = Color.Black
            F100labelpt11.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG11.Text = "C"
            F100LabelG11.ForeColor = Color.Black
            F100labelpt11.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG11.Text = "B"
            F100LabelG11.ForeColor = Color.Black
            F100labelpt11.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG11.Text = "A"
            F100LabelG11.ForeColor = Color.Black
            F100labelpt11.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN12.Click
        F100ComboBoxCN12.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN12.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN12.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN12.SelectedItem.ToString
        F100ButtonCN12.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN12.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU12.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU12.Text = "-"
            F100LabelCN12.Text = "-"
            F100LabelQP12.Text = "-"
            F100TextBoxCN12.Enabled = False
            F100LabelG12.Text = "-"
            F100ButtonCN12.Text = "-"
        Else
            F100TextBoxCN12.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level12()
        Else
        End If
        Call F100TextBoxcn12_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN12.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN12.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN12.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN12.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG12.Text = "F"
            F100LabelG12.ForeColor = Color.Red
            F100labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG12.Text = "E"
            F100LabelG12.ForeColor = Color.Black
            F100labelpt12.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG12.Text = "D"
            F100LabelG12.ForeColor = Color.Black
            F100labelpt12.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG12.Text = "C"
            F100LabelG12.ForeColor = Color.Black
            F100labelpt12.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG12.Text = "B"
            F100LabelG12.ForeColor = Color.Black
            F100labelpt12.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG12.Text = "A"
            F100LabelG12.ForeColor = Color.Black
            F100labelpt12.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN13.Click
        F100ComboBoxCN13.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN13.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN13.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN13.SelectedItem.ToString
        F100ButtonCN13.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN13.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU13.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU13.Text = "-"
            F100LabelCN13.Text = "-"
            F100LabelQP13.Text = "-"
            F100TextBoxCN13.Enabled = False
            F100LabelG13.Text = "-"
            F100ButtonCN13.Text = "-"
        Else
            F100TextBoxCN13.Enabled = True
            Call F100oleku()
        End If
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level13()
        Else
        End If
        Call F100TextBoxcn13_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN13.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN13.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN13.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN13.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG13.Text = "F"
            F100LabelG13.ForeColor = Color.Red
            F100labelpt13.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG13.Text = "E"
            F100LabelG13.ForeColor = Color.Black
            F100labelpt13.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG13.Text = "D"
            F100LabelG13.ForeColor = Color.Black
            F100labelpt13.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG13.Text = "C"
            F100LabelG13.ForeColor = Color.Black
            F100labelpt13.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG13.Text = "B"
            F100LabelG13.ForeColor = Color.Black
            F100labelpt13.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG13.Text = "A"
            F100LabelG13.ForeColor = Color.Black
            F100labelpt13.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
    Private Sub F100ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN14.Click
        F100ComboBoxCN14.Items.Clear()
        Call f100hope()
        For i = 0 To F100ListBoxHopecode.Items.Count - 1
            Dim onyii As String
            onyii = F100ListBoxHopecode.Items(i).ToString
            F100ComboBoxCN14.Items.Add(onyii)
        Next
    End Sub
    Private Sub F100ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN14.SelectedIndexChanged
        Dim course As String
        course = F100ComboBoxCN14.SelectedItem.ToString
        F100ButtonCN14.Text = course
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            If course = F100ListBoxCourseCode.Items(i).ToString Then
                F100LabelCN14.Text = F100ListBoxCourseName.Items(i).ToString
                F100LabelCU14.Text = F100ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU14.Text = "-"
            F100LabelCN14.Text = "-"
            F100LabelQP14.Text = "-"
            F100TextBoxCN14.Enabled = False
            F100LabelG14.Text = "-"
            F100ButtonCN14.Text = "-"
        Else
            F100TextBoxCN14.Enabled = True
            Call F100oleku()
        End If
        Call F100TextBoxcn14_TextChanged(sender, e)
    End Sub
    Private Sub F100TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F100TextBoxCN14.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F100TextBoxCN14.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F100TextBoxCN14.Clear()
            End If
        Next
        Dim grade As Integer = Val(F100TextBoxCN14.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F100LabelG14.Text = "F"
            F100LabelG14.ForeColor = Color.Red
            F100labelpt14.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F100LabelG14.Text = "E"
            F100LabelG14.ForeColor = Color.Black
            F100labelpt14.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F100LabelG14.Text = "D"
            F100LabelG14.ForeColor = Color.Black
            F100labelpt14.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F100LabelG14.Text = "C"
            F100LabelG14.ForeColor = Color.Black
            F100labelpt14.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F100LabelG14.Text = "B"
            F100LabelG14.ForeColor = Color.Black
            F100labelpt14.Text = "4"
        ElseIf (grade > 69) Then
            F100LabelG14.Text = "A"
            F100LabelG14.ForeColor = Color.Black
            F100labelpt14.Text = "5"
        End If
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        Call f100hope()
    End Sub
'f200 comboxes and textboxexs
    Private Sub F200ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN1.Click
        F200ComboBoxCN1.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN1.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN1.SelectedItem.ToString
        F200ButtonCN1.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN1.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU1.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU1.Text = "-"
            F200LabelCN1.Text = "-"
            F200LabelQP1.Text = "-"
            F200TextBoxCN1.Enabled = False
            F200LabelG1.Text = "-"
            F200ButtonCN1.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level1()
        Else
        End If
        Call F200TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG1.Text = "F"
            F200LabelG1.ForeColor = Color.Red
            F200labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG1.Text = "E"
            F200LabelG1.ForeColor = Color.Black
            F200labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG1.Text = "D"
            F200LabelG1.ForeColor = Color.Black
            F200labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG1.Text = "C"
            F200LabelG1.ForeColor = Color.Black
            F200labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG1.Text = "B"
            F200LabelG1.ForeColor = Color.Black
            F200labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG1.Text = "A"
            F200LabelG1.ForeColor = Color.Black
            F200labelpt1.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN2.Click
        F200ComboBoxCN2.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN2.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN2.SelectedItem.ToString
        F200ButtonCN2.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN2.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU2.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU2.Text = "-"
            F200LabelCN2.Text = "-"
            F200LabelQP2.Text = "-"
            F200TextBoxCN2.Enabled = False
            F200LabelG2.Text = "-"
            F200ButtonCN2.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN2.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level2()
        Else
        End If
        Call F200TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG2.Text = "F"
            F200LabelG2.ForeColor = Color.Red
            F200labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG2.Text = "E"
            F200LabelG2.ForeColor = Color.Black
            F200labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG2.Text = "D"
            F200LabelG2.ForeColor = Color.Black
            F200labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG2.Text = "C"
            F200LabelG2.ForeColor = Color.Black
            F200labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG2.Text = "B"
            F200LabelG2.ForeColor = Color.Black
            F200labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG2.Text = "A"
            F200LabelG2.ForeColor = Color.Black
            F200labelpt2.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN3.Click
        F200ComboBoxCN3.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN3.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN3.SelectedItem.ToString
        F200ButtonCN3.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN3.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU3.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU3.Text = "-"
            F200LabelCN3.Text = "-"
            F200LabelQP3.Text = "-"
            F200TextBoxCN3.Enabled = False
            F200LabelG3.Text = "-"
            F200ButtonCN3.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN3.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level3()
        Else
        End If
        Call F200TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG3.Text = "F"
            F200LabelG3.ForeColor = Color.Red
            F200labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG3.Text = "E"
            F200LabelG3.ForeColor = Color.Black
            F200labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG3.Text = "D"
            F200LabelG3.ForeColor = Color.Black
            F200labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG3.Text = "C"
            F200LabelG3.ForeColor = Color.Black
            F200labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG3.Text = "B"
            F200LabelG3.ForeColor = Color.Black
            F200labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG3.Text = "A"
            F200LabelG3.ForeColor = Color.Black
            F200labelpt3.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN4.Click
        F200ComboBoxCN4.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN4.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN4.SelectedItem.ToString
        F200ButtonCN4.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN4.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU4.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU4.Text = "-"
            F200LabelCN4.Text = "-"
            F200LabelQP4.Text = "-"
            F200TextBoxCN4.Enabled = False
            F200LabelG4.Text = "-"
            F200ButtonCN4.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN4.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level4()
        Else
        End If
        Call F200TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG4.Text = "F"
            F200LabelG4.ForeColor = Color.Red
            F200labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG4.Text = "E"
            F200LabelG4.ForeColor = Color.Black
            F200labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG4.Text = "D"
            F200LabelG4.ForeColor = Color.Black
            F200labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG4.Text = "C"
            F200LabelG4.ForeColor = Color.Black
            F200labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG4.Text = "B"
            F200LabelG4.ForeColor = Color.Black
            F200labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG4.Text = "A"
            F200LabelG4.ForeColor = Color.Black
            F200labelpt4.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN5.Click
        F200ComboBoxCN5.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN5.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN5.SelectedItem.ToString
        F200ButtonCN5.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN5.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU5.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU5.Text = "-"
            F200LabelCN5.Text = "-"
            F200LabelQP5.Text = "-"
            F200TextBoxCN5.Enabled = False
            F200LabelG5.Text = "-"
            F200ButtonCN5.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN5.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level5()
        Else
        End If
        Call F200TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG5.Text = "F"
            F200LabelG5.ForeColor = Color.Red
            F200labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG5.Text = "E"
            F200LabelG5.ForeColor = Color.Black
            F200labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG5.Text = "D"
            F200LabelG5.ForeColor = Color.Black
            F200labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG5.Text = "C"
            F200LabelG5.ForeColor = Color.Black
            F200labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG5.Text = "B"
            F200LabelG5.ForeColor = Color.Black
            F200labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG5.Text = "A"
            F200LabelG5.ForeColor = Color.Black
            F200labelpt5.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN6.Click
        F200ComboBoxCN6.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN6.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN6.SelectedItem.ToString
        F200ButtonCN6.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN6.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU6.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU6.Text = "-"
            F200LabelCN6.Text = "-"
            F200LabelQP6.Text = "-"
            F200TextBoxCN6.Enabled = False
            F200LabelG6.Text = "-"
            F200ButtonCN6.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN6.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level6()
        Else
        End If
        Call F200TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG6.Text = "F"
            F200LabelG6.ForeColor = Color.Red
            F200labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG6.Text = "E"
            F200LabelG6.ForeColor = Color.Black
            F200labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG6.Text = "D"
            F200LabelG6.ForeColor = Color.Black
            F200labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG6.Text = "C"
            F200LabelG6.ForeColor = Color.Black
            F200labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG6.Text = "B"
            F200LabelG6.ForeColor = Color.Black
            F200labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG6.Text = "A"
            F200LabelG6.ForeColor = Color.Black
            F200labelpt6.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN7.Click
        F200ComboBoxCN7.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN7.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN7.SelectedItem.ToString
        F200ButtonCN7.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN7.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU7.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU7.Text = "-"
            F200LabelCN7.Text = "-"
            F200LabelQP7.Text = "-"
            F200TextBoxCN7.Enabled = False
            F200LabelG7.Text = "-"
            F200ButtonCN7.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN7.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level7()
        Else
        End If
        Call F200TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG7.Text = "F"
            F200LabelG7.ForeColor = Color.Red
            F200labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG7.Text = "E"
            F200LabelG7.ForeColor = Color.Black
            F200labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG7.Text = "D"
            F200LabelG7.ForeColor = Color.Black
            F200labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG7.Text = "C"
            F200LabelG7.ForeColor = Color.Black
            F200labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG7.Text = "B"
            F200LabelG7.ForeColor = Color.Black
            F200labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG7.Text = "A"
            F200LabelG7.ForeColor = Color.Black
            F200labelpt7.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN8.Click
        F200ComboBoxCN8.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN8.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN8.SelectedItem.ToString
        F200ButtonCN8.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN8.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU8.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU8.Text = "-"
            F200LabelCN8.Text = "-"
            F200LabelQP8.Text = "-"
            F200TextBoxCN8.Enabled = False
            F200LabelG8.Text = "-"
            F200ButtonCN8.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN8.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level8()
        Else
        End If
        Call F200TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG8.Text = "F"
            F200LabelG8.ForeColor = Color.Red
            F200labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG8.Text = "E"
            F200LabelG8.ForeColor = Color.Black
            F200labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG8.Text = "D"
            F200LabelG8.ForeColor = Color.Black
            F200labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG8.Text = "C"
            F200LabelG8.ForeColor = Color.Black
            F200labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG8.Text = "B"
            F200LabelG8.ForeColor = Color.Black
            F200labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG8.Text = "A"
            F200LabelG8.ForeColor = Color.Black
            F200labelpt8.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN9.Click
        F200ComboBoxCN9.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN9.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN9.SelectedItem.ToString
        F200ButtonCN9.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN9.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU9.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU9.Text = "-"
            F200LabelCN9.Text = "-"
            F200LabelQP9.Text = "-"
            F200TextBoxCN9.Enabled = False
            F200LabelG9.Text = "-"
            F200ButtonCN9.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN9.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level9()
        Else
        End If
        Call F200TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG9.Text = "F"
            F200LabelG9.ForeColor = Color.Red
            F200labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG9.Text = "E"
            F200LabelG9.ForeColor = Color.Black
            F200labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG9.Text = "D"
            F200LabelG9.ForeColor = Color.Black
            F200labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG9.Text = "C"
            F200LabelG9.ForeColor = Color.Black
            F200labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG9.Text = "B"
            F200LabelG9.ForeColor = Color.Black
            F200labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG9.Text = "A"
            F200LabelG9.ForeColor = Color.Black
            F200labelpt9.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN10.Click
        F200ComboBoxCN10.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN10.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN10.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN10.SelectedItem.ToString
        F200ButtonCN10.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN10.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU10.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU10.Text = "-"
            F200LabelCN10.Text = "-"
            F200LabelQP10.Text = "-"
            F200TextBoxCN10.Enabled = False
            F200LabelG10.Text = "-"
            F200ButtonCN10.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN1.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level10()
        Else
        End If
        Call F200TextBoxcn10_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN10.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN10.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN10.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN10.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG10.Text = "F"
            F200LabelG10.ForeColor = Color.Red
            F200labelpt10.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG10.Text = "E"
            F200LabelG10.ForeColor = Color.Black
            F200labelpt10.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG10.Text = "D"
            F200LabelG10.ForeColor = Color.Black
            F200labelpt10.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG10.Text = "C"
            F200LabelG10.ForeColor = Color.Black
            F200labelpt10.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG10.Text = "B"
            F200LabelG10.ForeColor = Color.Black
            F200labelpt10.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG10.Text = "A"
            F200LabelG10.ForeColor = Color.Black
            F200labelpt10.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN11.Click
        F200ComboBoxCN11.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN11.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN11.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN11.SelectedItem.ToString
        F200ButtonCN11.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN11.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU11.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU11.Text = "-"
            F200LabelCN11.Text = "-"
            F200LabelQP11.Text = "-"
            F200TextBoxCN11.Enabled = False
            F200LabelG11.Text = "-"
            F200ButtonCN11.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN11.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level11()
        Else
        End If
        Call F200TextBoxcn11_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN11.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN11.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN11.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN11.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG11.Text = "F"
            F200LabelG11.ForeColor = Color.Red
            F200labelpt11.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG11.Text = "E"
            F200LabelG11.ForeColor = Color.Black
            F200labelpt11.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG11.Text = "D"
            F200LabelG11.ForeColor = Color.Black
            F200labelpt11.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG11.Text = "C"
            F200LabelG11.ForeColor = Color.Black
            F200labelpt11.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG11.Text = "B"
            F200LabelG11.ForeColor = Color.Black
            F200labelpt11.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG11.Text = "A"
            F200LabelG11.ForeColor = Color.Black
            F200labelpt11.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN12.Click
        F200ComboBoxCN12.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN12.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN12.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN12.SelectedItem.ToString
        F200ButtonCN12.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN12.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU12.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU12.Text = "-"
            F200LabelCN12.Text = "-"
            F200LabelQP12.Text = "-"
            F200TextBoxCN12.Enabled = False
            F200LabelG12.Text = "-"
            F200ButtonCN12.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN12.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level12()
        Else
        End If
        Call F200TextBoxcn12_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN12.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN12.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN12.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN12.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG12.Text = "F"
            F200LabelG12.ForeColor = Color.Red
            F200labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG12.Text = "E"
            F200LabelG12.ForeColor = Color.Black
            F200labelpt12.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG12.Text = "D"
            F200LabelG12.ForeColor = Color.Black
            F200labelpt12.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG12.Text = "C"
            F200LabelG12.ForeColor = Color.Black
            F200labelpt12.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG12.Text = "B"
            F200LabelG12.ForeColor = Color.Black
            F200labelpt12.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG12.Text = "A"
            F200LabelG12.ForeColor = Color.Black
            F200labelpt12.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN13.Click
        F200ComboBoxCN13.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN13.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN13.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN13.SelectedItem.ToString
        F200ButtonCN13.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN13.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU13.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU13.Text = "-"
            F200LabelCN13.Text = "-"
            F200LabelQP13.Text = "-"
            F200TextBoxCN13.Enabled = False
            F200LabelG13.Text = "-"
            F200ButtonCN13.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN13.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F200ListBoxhopeCode.Items.Count)
        If alako > 1 Then
            Call F200level13()
        Else
        End If
        Call F200TextBoxcn13_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN13.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN13.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN13.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN13.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG13.Text = "F"
            F200LabelG13.ForeColor = Color.Red
            F200labelpt13.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG13.Text = "E"
            F200LabelG13.ForeColor = Color.Black
            F200labelpt13.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG13.Text = "D"
            F200LabelG13.ForeColor = Color.Black
            F200labelpt13.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG13.Text = "C"
            F200LabelG13.ForeColor = Color.Black
            F200labelpt13.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG13.Text = "B"
            F200LabelG13.ForeColor = Color.Black
            F200labelpt13.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG13.Text = "A"
            F200LabelG13.ForeColor = Color.Black
            F200labelpt13.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
    Private Sub F200ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN14.Click
        F200ComboBoxCN14.Items.Clear()
        Call f200hope()
        For i = 0 To F200ListBoxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F200ListBoxhopeCode.Items(i).ToString
            F200ComboBoxCN14.Items.Add(onyii)
        Next
    End Sub
    Private Sub F200ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200ComboBoxCN14.SelectedIndexChanged
        Dim course As String
        course = F200ComboBoxCN14.SelectedItem.ToString
        F200ButtonCN14.Text = course
        For i = 0 To F200ListBoxCourseCode.Items.Count - 1
            If course = F200ListBoxCourseCode.Items(i).ToString Then
                F200LabelCN14.Text = F200ListBoxCourseName.Items(i).ToString
                F200LabelCU14.Text = F200ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F200LabelCU14.Text = "-"
            F200LabelCN14.Text = "-"
            F200LabelQP14.Text = "-"
            F200TextBoxCN14.Enabled = False
            F200LabelG14.Text = "-"
            F200ButtonCN14.Text = "-"
            Call F200TOtalcreditunit()
            Call F200TOtalqp()
            Exit Sub
        Else
            F200TextBoxCN14.Enabled = True
            Call oleku()
        End If
        Call F200TextBoxcn14_TextChanged(sender, e)
    End Sub
    Private Sub F200TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F200TextBoxCN14.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F200TextBoxCN14.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F200TextBoxCN14.Clear()
            End If
        Next
        Dim grade As Integer = Val(F200TextBoxCN14.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F200LabelG14.Text = "F"
            F200LabelG14.ForeColor = Color.Red
            F200labelpt14.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F200LabelG14.Text = "E"
            F200LabelG14.ForeColor = Color.Black
            F200labelpt14.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F200LabelG14.Text = "D"
            F200LabelG14.ForeColor = Color.Black
            F200labelpt14.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F200LabelG14.Text = "C"
            F200LabelG14.ForeColor = Color.Black
            F200labelpt14.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F200LabelG14.Text = "B"
            F200LabelG14.ForeColor = Color.Black
            F200labelpt14.Text = "4"
        ElseIf (grade > 69) Then
            F200LabelG14.Text = "A"
            F200LabelG14.ForeColor = Color.Black
            F200labelpt14.Text = "5"
        End If
        Call F200TOtalcreditunit()
        Call F200TOtalqp()
        Call f200hope()
    End Sub
'f300 comboxes and textboxexs
    Private Sub F300ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN1.Click
        F300ComboBoxCN1.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN1.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN1.SelectedItem.ToString
        F300ButtonCN1.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN1.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU1.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F100TOtalcreditunit()
        Call F100TOtalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU1.Text = "-"
            F300LabelCN1.Text = "-"
            F300LabelQP1.Text = "-"
            F300TextBoxCN1.Enabled = False
            F300LabelG1.Text = "-"
            F300ButtonCN1.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level1()
        Else
        End If
        Call F300TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG1.Text = "F"
            F300LabelG1.ForeColor = Color.Red
            F300labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG1.Text = "E"
            F300LabelG1.ForeColor = Color.Black
            F300labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG1.Text = "D"
            F300LabelG1.ForeColor = Color.Black
            F300labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG1.Text = "C"
            F300LabelG1.ForeColor = Color.Black
            F300labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG1.Text = "B"
            F300LabelG1.ForeColor = Color.Black
            F300labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG1.Text = "A"
            F300LabelG1.ForeColor = Color.Black
            F300labelpt1.Text = "5"
        End If
        Call F300TOtalcreditunit()
        Call F300TOtalqp()
        Call f300hope()
    End Sub
    Private Sub F300ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN2.Click
        F300ComboBoxCN2.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN2.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN2.SelectedItem.ToString
        F300ButtonCN2.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN2.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU2.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU2.Text = "-"
            F300LabelCN2.Text = "-"
            F300LabelQP2.Text = "-"
            F300TextBoxCN2.Enabled = False
            F300LabelG2.Text = "-"
            F300ButtonCN2.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN2.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level2()
        Else
        End If
        Call F300TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG2.Text = "F"
            F300LabelG2.ForeColor = Color.Red
            F300labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG2.Text = "E"
            F300LabelG2.ForeColor = Color.Black
            F300labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG2.Text = "D"
            F300LabelG2.ForeColor = Color.Black
            F300labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG2.Text = "C"
            F300LabelG2.ForeColor = Color.Black
            F300labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG2.Text = "B"
            F300LabelG2.ForeColor = Color.Black
            F300labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG2.Text = "A"
            F300LabelG2.ForeColor = Color.Black
            F300labelpt2.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN3.Click
        F300ComboBoxCN3.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN3.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN3.SelectedItem.ToString
        F300ButtonCN3.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN3.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU3.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU3.Text = "-"
            F300LabelCN3.Text = "-"
            F300LabelQP3.Text = "-"
            F300TextBoxCN3.Enabled = False
            F300LabelG3.Text = "-"
            F300ButtonCN3.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN3.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level3()
        Else
        End If
        Call F300TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG3.Text = "F"
            F300LabelG3.ForeColor = Color.Red
            F300labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG3.Text = "E"
            F300LabelG3.ForeColor = Color.Black
            F300labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG3.Text = "D"
            F300LabelG3.ForeColor = Color.Black
            F300labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG3.Text = "C"
            F300LabelG3.ForeColor = Color.Black
            F300labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG3.Text = "B"
            F300LabelG3.ForeColor = Color.Black
            F300labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG3.Text = "A"
            F300LabelG3.ForeColor = Color.Black
            F300labelpt3.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN4.Click
        F300ComboBoxCN4.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN4.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN4.SelectedItem.ToString
        F300ButtonCN4.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN4.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU4.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU4.Text = "-"
            F300LabelCN4.Text = "-"
            F300LabelQP4.Text = "-"
            F300TextBoxCN4.Enabled = False
            F300LabelG4.Text = "-"
            F300ButtonCN4.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN4.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level4()
        Else
        End If
        Call F300TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG4.Text = "F"
            F300LabelG4.ForeColor = Color.Red
            F300labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG4.Text = "E"
            F300LabelG4.ForeColor = Color.Black
            F300labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG4.Text = "D"
            F300LabelG4.ForeColor = Color.Black
            F300labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG4.Text = "C"
            F300LabelG4.ForeColor = Color.Black
            F300labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG4.Text = "B"
            F300LabelG4.ForeColor = Color.Black
            F300labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG4.Text = "A"
            F300LabelG4.ForeColor = Color.Black
            F300labelpt4.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN5.Click
        F300ComboBoxCN5.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN5.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN5.SelectedItem.ToString
        F300ButtonCN5.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN5.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU5.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU5.Text = "-"
            F300LabelCN5.Text = "-"
            F300LabelQP5.Text = "-"
            F300TextBoxCN5.Enabled = False
            F300LabelG5.Text = "-"
            F300ButtonCN5.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN5.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level5()
        Else
        End If
        Call F300TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG5.Text = "F"
            F300LabelG5.ForeColor = Color.Red
            F300labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG5.Text = "E"
            F300LabelG5.ForeColor = Color.Black
            F300labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG5.Text = "D"
            F300LabelG5.ForeColor = Color.Black
            F300labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG5.Text = "C"
            F300LabelG5.ForeColor = Color.Black
            F300labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG5.Text = "B"
            F300LabelG5.ForeColor = Color.Black
            F300labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG5.Text = "A"
            F300LabelG5.ForeColor = Color.Black
            F300labelpt5.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN6.Click
        F300ComboBoxCN6.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN6.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN6.SelectedItem.ToString
        F300ButtonCN6.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN6.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU6.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU6.Text = "-"
            F300LabelCN6.Text = "-"
            F300LabelQP6.Text = "-"
            F300TextBoxCN6.Enabled = False
            F300LabelG6.Text = "-"
            F300ButtonCN6.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN6.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level6()
        Else
        End If
        Call F300TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG6.Text = "F"
            F300LabelG6.ForeColor = Color.Red
            F300labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG6.Text = "E"
            F300LabelG6.ForeColor = Color.Black
            F300labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG6.Text = "D"
            F300LabelG6.ForeColor = Color.Black
            F300labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG6.Text = "C"
            F300LabelG6.ForeColor = Color.Black
            F300labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG6.Text = "B"
            F300LabelG6.ForeColor = Color.Black
            F300labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG6.Text = "A"
            F300LabelG6.ForeColor = Color.Black
            F300labelpt6.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN7.Click
        F300ComboBoxCN7.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN7.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN7.SelectedItem.ToString
        F300ButtonCN7.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN7.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU7.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU7.Text = "-"
            F300LabelCN7.Text = "-"
            F300LabelQP7.Text = "-"
            F300TextBoxCN7.Enabled = False
            F300LabelG7.Text = "-"
            F300ButtonCN7.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN7.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level7()
        Else
        End If
        Call F300TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG7.Text = "F"
            F300LabelG7.ForeColor = Color.Red
            F300labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG7.Text = "E"
            F300LabelG7.ForeColor = Color.Black
            F300labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG7.Text = "D"
            F300LabelG7.ForeColor = Color.Black
            F300labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG7.Text = "C"
            F300LabelG7.ForeColor = Color.Black
            F300labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG7.Text = "B"
            F300LabelG7.ForeColor = Color.Black
            F300labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG7.Text = "A"
            F300LabelG7.ForeColor = Color.Black
            F300labelpt7.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN8.Click
        F300ComboBoxCN8.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN8.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN8.SelectedItem.ToString
        F300ButtonCN8.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN8.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU8.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU8.Text = "-"
            F300LabelCN8.Text = "-"
            F300LabelQP8.Text = "-"
            F300TextBoxCN8.Enabled = False
            F300LabelG8.Text = "-"
            F300ButtonCN8.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN8.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level8()
        Else
        End If
        Call F300TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG8.Text = "F"
            F300LabelG8.ForeColor = Color.Red
            F300labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG8.Text = "E"
            F300LabelG8.ForeColor = Color.Black
            F300labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG8.Text = "D"
            F300LabelG8.ForeColor = Color.Black
            F300labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG8.Text = "C"
            F300LabelG8.ForeColor = Color.Black
            F300labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG8.Text = "B"
            F300LabelG8.ForeColor = Color.Black
            F300labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG8.Text = "A"
            F300LabelG8.ForeColor = Color.Black
            F300labelpt8.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN9.Click
        F300ComboBoxCN9.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN9.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN9.SelectedItem.ToString
        F300ButtonCN9.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN9.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU9.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU9.Text = "-"
            F300LabelCN9.Text = "-"
            F300LabelQP9.Text = "-"
            F300TextBoxCN9.Enabled = False
            F300LabelG9.Text = "-"
            F300ButtonCN9.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN9.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level9()
        Else
        End If
        Call F300TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG9.Text = "F"
            F300LabelG9.ForeColor = Color.Red
            F300labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG9.Text = "E"
            F300LabelG9.ForeColor = Color.Black
            F300labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG9.Text = "D"
            F300LabelG9.ForeColor = Color.Black
            F300labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG9.Text = "C"
            F300LabelG9.ForeColor = Color.Black
            F300labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG9.Text = "B"
            F300LabelG9.ForeColor = Color.Black
            F300labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG9.Text = "A"
            F300LabelG9.ForeColor = Color.Black
            F300labelpt9.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN10.Click
        F300ComboBoxCN10.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN10.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN10.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN10.SelectedItem.ToString
        F300ButtonCN10.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN10.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU10.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU10.Text = "-"
            F300LabelCN10.Text = "-"
            F300LabelQP10.Text = "-"
            F300TextBoxCN10.Enabled = False
            F300LabelG10.Text = "-"
            F300ButtonCN10.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN1.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level10()
        Else
        End If
        Call F300TextBoxcn10_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN10.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN10.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN10.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN10.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG10.Text = "F"
            F300LabelG10.ForeColor = Color.Red
            F300labelpt10.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG10.Text = "E"
            F300LabelG10.ForeColor = Color.Black
            F300labelpt10.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG10.Text = "D"
            F300LabelG10.ForeColor = Color.Black
            F300labelpt10.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG10.Text = "C"
            F300LabelG10.ForeColor = Color.Black
            F300labelpt10.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG10.Text = "B"
            F300LabelG10.ForeColor = Color.Black
            F300labelpt10.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG10.Text = "A"
            F300LabelG10.ForeColor = Color.Black
            F300labelpt10.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN11.Click
        F300ComboBoxCN11.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN11.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN11.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN11.SelectedItem.ToString
        F300ButtonCN11.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN11.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU11.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU11.Text = "-"
            F300LabelCN11.Text = "-"
            F300LabelQP11.Text = "-"
            F300TextBoxCN11.Enabled = False
            F300LabelG11.Text = "-"
            F300ButtonCN11.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN11.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level11()
        Else
        End If
        Call F300TextBoxcn11_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN11.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN11.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN11.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN11.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG11.Text = "F"
            F300LabelG11.ForeColor = Color.Red
            F300labelpt11.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG11.Text = "E"
            F300LabelG11.ForeColor = Color.Black
            F300labelpt11.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG11.Text = "D"
            F300LabelG11.ForeColor = Color.Black
            F300labelpt11.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG11.Text = "C"
            F300LabelG11.ForeColor = Color.Black
            F300labelpt11.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG11.Text = "B"
            F300LabelG11.ForeColor = Color.Black
            F300labelpt11.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG11.Text = "A"
            F300LabelG11.ForeColor = Color.Black
            F300labelpt11.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN12.Click
        F300ComboBoxCN12.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN12.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN12.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN12.SelectedItem.ToString
        F300ButtonCN12.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN12.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU12.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU12.Text = "-"
            F300LabelCN12.Text = "-"
            F300LabelQP12.Text = "-"
            F300TextBoxCN12.Enabled = False
            F300LabelG12.Text = "-"
            F300ButtonCN12.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN12.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level12()
        Else
        End If
        Call F300TextBoxcn12_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN12.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN12.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN12.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN12.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG12.Text = "F"
            F300LabelG12.ForeColor = Color.Red
            F300labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG12.Text = "E"
            F300LabelG12.ForeColor = Color.Black
            F300labelpt12.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG12.Text = "D"
            F300LabelG12.ForeColor = Color.Black
            F300labelpt12.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG12.Text = "C"
            F300LabelG12.ForeColor = Color.Black
            F300labelpt12.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG12.Text = "B"
            F300LabelG12.ForeColor = Color.Black
            F300labelpt12.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG12.Text = "A"
            F300LabelG12.ForeColor = Color.Black
            F300labelpt12.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN13.Click
        F300ComboBoxCN13.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN13.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN13.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN13.SelectedItem.ToString
        F300ButtonCN13.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN13.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU13.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU13.Text = "-"
            F300LabelCN13.Text = "-"
            F300LabelQP13.Text = "-"
            F300TextBoxCN13.Enabled = False
            F300LabelG13.Text = "-"
            F300ButtonCN13.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN13.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F300ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F300level13()
        Else
        End If
        Call F300TextBoxcn13_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN13.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN13.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN13.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN13.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG13.Text = "F"
            F300LabelG13.ForeColor = Color.Red
            F300labelpt13.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG13.Text = "E"
            F300LabelG13.ForeColor = Color.Black
            F300labelpt13.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG13.Text = "D"
            F300LabelG13.ForeColor = Color.Black
            F300labelpt13.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG13.Text = "C"
            F300LabelG13.ForeColor = Color.Black
            F300labelpt13.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG13.Text = "B"
            F300LabelG13.ForeColor = Color.Black
            F300labelpt13.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG13.Text = "A"
            F300LabelG13.ForeColor = Color.Black
            F300labelpt13.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F300ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN14.Click
        F300ComboBoxCN14.Items.Clear()
        Call hope()
        For i = 0 To F300ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F300ListBoxhopecode.Items(i).ToString
            F300ComboBoxCN14.Items.Add(onyii)
        Next
    End Sub
    Private Sub F300ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300ComboBoxCN14.SelectedIndexChanged
        Dim course As String
        course = F300ComboBoxCN14.SelectedItem.ToString
        F300ButtonCN14.Text = course
        For i = 0 To F300ListBoxCourseCode.Items.Count - 1
            If course = F300ListBoxCourseCode.Items(i).ToString Then
                F300LabelCN14.Text = F300ListBoxCourseName.Items(i).ToString
                F300LabelCU14.Text = F300ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F300LabelCU14.Text = "-"
            F300LabelCN14.Text = "-"
            F300LabelQP14.Text = "-"
            F300TextBoxCN14.Enabled = False
            F300LabelG14.Text = "-"
            F300ButtonCN14.Text = "-"
            Call F300TOtalcreditunit()
            Call F300TOtalqp()
            Exit Sub
        Else
            F300TextBoxCN14.Enabled = True
            Call oleku()
        End If
        Call F300TextBoxcn14_TextChanged(sender, e)
    End Sub
    Private Sub F300TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F300TextBoxCN14.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F300TextBoxCN14.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F300TextBoxCN14.Clear()
            End If
        Next
        Dim grade As Integer = Val(F300TextBoxCN14.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F300LabelG14.Text = "F"
            F300LabelG14.ForeColor = Color.Red
            F300labelpt14.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F300LabelG14.Text = "E"
            F300LabelG14.ForeColor = Color.Black
            F300labelpt14.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F300LabelG14.Text = "D"
            F300LabelG14.ForeColor = Color.Black
            F300labelpt14.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F300LabelG14.Text = "C"
            F300LabelG14.ForeColor = Color.Black
            F300labelpt14.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F300LabelG14.Text = "B"
            F300LabelG14.ForeColor = Color.Black
            F300labelpt14.Text = "4"
        ElseIf (grade > 69) Then
            F300LabelG14.Text = "A"
            F300LabelG14.ForeColor = Color.Black
            F300labelpt14.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
'f400 comboxes and textboxexs
    Private Sub F400ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN1.Click
        F400ComboBoxCN1.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN1.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN1.SelectedItem.ToString
        F400ButtonCN1.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN1.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU1.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F400TOtalcreditunit()
        Call F400TOtalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU1.Text = "-"
            F400LabelCN1.Text = "-"
            F400LabelQP1.Text = "-"
            F400TextBoxCN1.Enabled = False
            F400LabelG1.Text = "-"
            F400ButtonCN1.Text = "-"
            Call F400TOtalcreditunit()
            Call F400TOtalqp()
            Exit Sub
        Else
            F400TextBoxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level1()
        Else
        End If
        Call F400TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG1.Text = "F"
            F400LabelG1.ForeColor = Color.Red
            F400labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG1.Text = "E"
            F400LabelG1.ForeColor = Color.Black
            F400labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG1.Text = "D"
            F400LabelG1.ForeColor = Color.Black
            F400labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG1.Text = "C"
            F400LabelG1.ForeColor = Color.Black
            F400labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG1.Text = "B"
            F400LabelG1.ForeColor = Color.Black
            F400labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG1.Text = "A"
            F400LabelG1.ForeColor = Color.Black
            F400labelpt1.Text = "5"
        End If
        Call F400TOtalcreditunit()
        Call F400TOtalqp()
        Call f400hope()
    End Sub
    Private Sub F400ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN2.Click
        F400ComboBoxCN2.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN2.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN2.SelectedItem.ToString
        F400ButtonCN2.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN2.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU2.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call F400TOtalcreditunit()
        Call F400TOtalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU2.Text = "-"
            F400LabelCN2.Text = "-"
            F400LabelQP2.Text = "-"
            F400TextBoxCN2.Enabled = False
            F400LabelG2.Text = "-"
            F400ButtonCN2.Text = "-"
            Call F400TOtalcreditunit()
            Call F400TOtalqp()
            Exit Sub
        Else
            F400TextBoxCN2.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level2()
        Else
        End If
        Call F400TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG2.Text = "F"
            F400LabelG2.ForeColor = Color.Red
            F400labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG2.Text = "E"
            F400LabelG2.ForeColor = Color.Black
            F400labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG2.Text = "D"
            F400LabelG2.ForeColor = Color.Black
            F400labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG2.Text = "C"
            F400LabelG2.ForeColor = Color.Black
            F400labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG2.Text = "B"
            F400LabelG2.ForeColor = Color.Black
            F400labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG2.Text = "A"
            F400LabelG2.ForeColor = Color.Black
            F400labelpt2.Text = "5"
        End If
        Call F400TOtalcreditunit()
        Call F400TOtalqp()
        Call f400hope()
    End Sub
    Private Sub F400ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN3.Click
        F400ComboBoxCN3.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN3.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN3.SelectedItem.ToString
        F400ButtonCN3.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN3.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU3.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU3.Text = "-"
            F400LabelCN3.Text = "-"
            F400LabelQP3.Text = "-"
            F400TextBoxCN3.Enabled = False
            F400LabelG3.Text = "-"
            F400ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN3.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level3()
        Else
        End If
        Call F400TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG3.Text = "F"
            F400LabelG3.ForeColor = Color.Red
            F400labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG3.Text = "E"
            F400LabelG3.ForeColor = Color.Black
            F400labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG3.Text = "D"
            F400LabelG3.ForeColor = Color.Black
            F400labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG3.Text = "C"
            F400LabelG3.ForeColor = Color.Black
            F400labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG3.Text = "B"
            F400LabelG3.ForeColor = Color.Black
            F400labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG3.Text = "A"
            F400LabelG3.ForeColor = Color.Black
            F400labelpt3.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN4.Click
        F400ComboBoxCN4.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN4.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN4.SelectedItem.ToString
        F400ButtonCN4.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN4.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU4.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU4.Text = "-"
            F400LabelCN4.Text = "-"
            F400LabelQP4.Text = "-"
            F400TextBoxCN4.Enabled = False
            F400LabelG4.Text = "-"
            F400ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN4.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level4()
        Else
        End If
        Call F400TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG4.Text = "F"
            F400LabelG4.ForeColor = Color.Red
            F400labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG4.Text = "E"
            F400LabelG4.ForeColor = Color.Black
            F400labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG4.Text = "D"
            F400LabelG4.ForeColor = Color.Black
            F400labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG4.Text = "C"
            F400LabelG4.ForeColor = Color.Black
            F400labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG4.Text = "B"
            F400LabelG4.ForeColor = Color.Black
            F400labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG4.Text = "A"
            F400LabelG4.ForeColor = Color.Black
            F400labelpt4.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN5.Click
        F400ComboBoxCN5.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN5.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN5.SelectedItem.ToString
        F400ButtonCN5.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN5.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU5.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU5.Text = "-"
            F400LabelCN5.Text = "-"
            F400LabelQP5.Text = "-"
            F400TextBoxCN5.Enabled = False
            F400LabelG5.Text = "-"
            F400ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN5.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level5()
        Else
        End If
        Call F400TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG5.Text = "F"
            F400LabelG5.ForeColor = Color.Red
            F400labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG5.Text = "E"
            F400LabelG5.ForeColor = Color.Black
            F400labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG5.Text = "D"
            F400LabelG5.ForeColor = Color.Black
            F400labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG5.Text = "C"
            F400LabelG5.ForeColor = Color.Black
            F400labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG5.Text = "B"
            F400LabelG5.ForeColor = Color.Black
            F400labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG5.Text = "A"
            F400LabelG5.ForeColor = Color.Black
            F400labelpt5.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN6.Click
        F400ComboBoxCN6.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN6.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN6.SelectedItem.ToString
        F400ButtonCN6.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN6.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU6.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU6.Text = "-"
            F400LabelCN6.Text = "-"
            F400LabelQP6.Text = "-"
            F400TextBoxCN6.Enabled = False
            F400LabelG6.Text = "-"
            F400ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN6.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level6()
        Else
        End If
        Call F400TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG6.Text = "F"
            F400LabelG6.ForeColor = Color.Red
            F400labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG6.Text = "E"
            F400LabelG6.ForeColor = Color.Black
            F400labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG6.Text = "D"
            F400LabelG6.ForeColor = Color.Black
            F400labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG6.Text = "C"
            F400LabelG6.ForeColor = Color.Black
            F400labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG6.Text = "B"
            F400LabelG6.ForeColor = Color.Black
            F400labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG6.Text = "A"
            F400LabelG6.ForeColor = Color.Black
            F400labelpt6.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN7.Click
        F400ComboBoxCN7.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN7.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN7.SelectedItem.ToString
        F400ButtonCN7.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN7.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU7.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU7.Text = "-"
            F400LabelCN7.Text = "-"
            F400LabelQP7.Text = "-"
            F400TextBoxCN7.Enabled = False
            F400LabelG7.Text = "-"
            F400ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN7.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level7()
        Else
        End If
        Call F400TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG7.Text = "F"
            F400LabelG7.ForeColor = Color.Red
            F400labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG7.Text = "E"
            F400LabelG7.ForeColor = Color.Black
            F400labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG7.Text = "D"
            F400LabelG7.ForeColor = Color.Black
            F400labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG7.Text = "C"
            F400LabelG7.ForeColor = Color.Black
            F400labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG7.Text = "B"
            F400LabelG7.ForeColor = Color.Black
            F400labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG7.Text = "A"
            F400LabelG7.ForeColor = Color.Black
            F400labelpt7.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN8.Click
        F400ComboBoxCN8.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN8.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN8.SelectedItem.ToString
        F400ButtonCN8.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN8.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU8.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU8.Text = "-"
            F400LabelCN8.Text = "-"
            F400LabelQP8.Text = "-"
            F400TextBoxCN8.Enabled = False
            F400LabelG8.Text = "-"
            F400ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN8.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level8()
        Else
        End If
        Call F400TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG8.Text = "F"
            F400LabelG8.ForeColor = Color.Red
            F400labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG8.Text = "E"
            F400LabelG8.ForeColor = Color.Black
            F400labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG8.Text = "D"
            F400LabelG8.ForeColor = Color.Black
            F400labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG8.Text = "C"
            F400LabelG8.ForeColor = Color.Black
            F400labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG8.Text = "B"
            F400LabelG8.ForeColor = Color.Black
            F400labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG8.Text = "A"
            F400LabelG8.ForeColor = Color.Black
            F400labelpt8.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN9.Click
        F400ComboBoxCN9.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN9.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN9.SelectedItem.ToString
        F400ButtonCN9.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN9.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU9.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU9.Text = "-"
            F400LabelCN9.Text = "-"
            F400LabelQP9.Text = "-"
            F400TextBoxCN9.Enabled = False
            F400LabelG9.Text = "-"
            F400ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN9.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level9()
        Else
        End If
        Call F400TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG9.Text = "F"
            F400LabelG9.ForeColor = Color.Red
            F400labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG9.Text = "E"
            F400LabelG9.ForeColor = Color.Black
            F400labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG9.Text = "D"
            F400LabelG9.ForeColor = Color.Black
            F400labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG9.Text = "C"
            F400LabelG9.ForeColor = Color.Black
            F400labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG9.Text = "B"
            F400LabelG9.ForeColor = Color.Black
            F400labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG9.Text = "A"
            F400LabelG9.ForeColor = Color.Black
            F400labelpt9.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN10.Click
        F400ComboBoxCN10.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN10.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN10.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN10.SelectedItem.ToString
        F400ButtonCN10.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN10.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU10.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU10.Text = "-"
            F400LabelCN10.Text = "-"
            F400LabelQP10.Text = "-"
            F400TextBoxCN10.Enabled = False
            F400LabelG10.Text = "-"
            F400ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN1.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level10()
        Else
        End If
        Call F400TextBoxcn10_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN10.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN10.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN10.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN10.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG10.Text = "F"
            F400LabelG10.ForeColor = Color.Red
            F400labelpt10.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG10.Text = "E"
            F400LabelG10.ForeColor = Color.Black
            F400labelpt10.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG10.Text = "D"
            F400LabelG10.ForeColor = Color.Black
            F400labelpt10.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG10.Text = "C"
            F400LabelG10.ForeColor = Color.Black
            F400labelpt10.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG10.Text = "B"
            F400LabelG10.ForeColor = Color.Black
            F400labelpt10.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG10.Text = "A"
            F400LabelG10.ForeColor = Color.Black
            F400labelpt10.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN11.Click
        F400ComboBoxCN11.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN11.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN11.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN11.SelectedItem.ToString
        F400ButtonCN11.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN11.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU11.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU11.Text = "-"
            F400LabelCN11.Text = "-"
            F400LabelQP11.Text = "-"
            F400TextBoxCN11.Enabled = False
            F400LabelG11.Text = "-"
            F400ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN11.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level11()
        Else
        End If
        Call F400TextBoxcn11_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN11.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN11.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN11.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN11.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG11.Text = "F"
            F400LabelG11.ForeColor = Color.Red
            F400labelpt11.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG11.Text = "E"
            F400LabelG11.ForeColor = Color.Black
            F400labelpt11.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG11.Text = "D"
            F400LabelG11.ForeColor = Color.Black
            F400labelpt11.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG11.Text = "C"
            F400LabelG11.ForeColor = Color.Black
            F400labelpt11.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG11.Text = "B"
            F400LabelG11.ForeColor = Color.Black
            F400labelpt11.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG11.Text = "A"
            F400LabelG11.ForeColor = Color.Black
            F400labelpt11.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN12.Click
        F400ComboBoxCN12.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN12.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN12.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN12.SelectedItem.ToString
        F400ButtonCN12.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN12.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU12.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU12.Text = "-"
            F400LabelCN12.Text = "-"
            F400LabelQP12.Text = "-"
            F400TextBoxCN12.Enabled = False
            F400LabelG12.Text = "-"
            F400ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN12.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level12()
        Else
        End If
        Call F400TextBoxcn12_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN12.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN12.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN12.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN12.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG12.Text = "F"
            F400LabelG12.ForeColor = Color.Red
            F400labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG12.Text = "E"
            F400LabelG12.ForeColor = Color.Black
            F400labelpt12.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG12.Text = "D"
            F400LabelG12.ForeColor = Color.Black
            F400labelpt12.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG12.Text = "C"
            F400LabelG12.ForeColor = Color.Black
            F400labelpt12.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG12.Text = "B"
            F400LabelG12.ForeColor = Color.Black
            F400labelpt12.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG12.Text = "A"
            F400LabelG12.ForeColor = Color.Black
            F400labelpt12.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN13.Click
        F400ComboBoxCN13.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN13.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN13.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN13.SelectedItem.ToString
        F400ButtonCN13.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN13.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU13.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU13.Text = "-"
            F400LabelCN13.Text = "-"
            F400LabelQP13.Text = "-"
            F400TextBoxCN13.Enabled = False
            F400LabelG13.Text = "-"
            F400ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN13.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F400ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call F400level13()
        Else
        End If
        Call F400TextBoxcn13_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN13.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN13.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN13.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN13.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG13.Text = "F"
            F400LabelG13.ForeColor = Color.Red
            F400labelpt13.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG13.Text = "E"
            F400LabelG13.ForeColor = Color.Black
            F400labelpt13.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG13.Text = "D"
            F400LabelG13.ForeColor = Color.Black
            F400labelpt13.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG13.Text = "C"
            F400LabelG13.ForeColor = Color.Black
            F400labelpt13.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG13.Text = "B"
            F400LabelG13.ForeColor = Color.Black
            F400labelpt13.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG13.Text = "A"
            F400LabelG13.ForeColor = Color.Black
            F400labelpt13.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F400ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN14.Click
        F400ComboBoxCN14.Items.Clear()
        Call hope()
        For i = 0 To F400ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F400ListBoxhopecode.Items(i).ToString
            F400ComboBoxCN14.Items.Add(onyii)
        Next
    End Sub
    Private Sub F400ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400ComboBoxCN14.SelectedIndexChanged
        Dim course As String
        course = F400ComboBoxCN14.SelectedItem.ToString
        F400ButtonCN14.Text = course
        For i = 0 To F400ListBoxCourseCode.Items.Count - 1
            If course = F400ListBoxCourseCode.Items(i).ToString Then
                F400LabelCN14.Text = F400ListBoxCourseName.Items(i).ToString
                F400LabelCU14.Text = F400ListBoxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F400LabelCU14.Text = "-"
            F400LabelCN14.Text = "-"
            F400LabelQP14.Text = "-"
            F400TextBoxCN14.Enabled = False
            F400LabelG14.Text = "-"
            F400ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F400TextBoxCN14.Enabled = True
            Call oleku()
        End If
        Call F400TextBoxcn14_TextChanged(sender, e)
    End Sub
    Private Sub F400TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F400TextBoxCN14.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F400TextBoxCN14.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F400TextBoxCN14.Clear()
            End If
        Next
        Dim grade As Integer = Val(F400TextBoxCN14.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F400LabelG14.Text = "F"
            F400LabelG14.ForeColor = Color.Red
            F400labelpt14.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F400LabelG14.Text = "E"
            F400LabelG14.ForeColor = Color.Black
            F400labelpt14.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F400LabelG14.Text = "D"
            F400LabelG14.ForeColor = Color.Black
            F400labelpt14.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F400LabelG14.Text = "C"
            F400LabelG14.ForeColor = Color.Black
            F400labelpt14.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F400LabelG14.Text = "B"
            F400LabelG14.ForeColor = Color.Black
            F400labelpt14.Text = "4"
        ElseIf (grade > 69) Then
            F400LabelG14.Text = "A"
            F400LabelG14.ForeColor = Color.Black
            F400labelpt14.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
'f500 comboxes and textboxexs
    Private Sub F500ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN1.Click
        F500ComboBoxCN1.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN1.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN1.SelectedItem.ToString
        F500ButtonCN1.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN1.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU1.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU1.Text = "-"
            F500LabelCN1.Text = "-"
            F500LabelQP1.Text = "-"
            F500TextBoxCN1.Enabled = False
            F500LabeG1.Text = "-"
            F500ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level1()
        Else
        End If
        Call F500TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG1.Text = "F"
            F500LabeG1.ForeColor = Color.Red
            F500labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG1.Text = "E"
            F500LabeG1.ForeColor = Color.Black
            F500labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG1.Text = "D"
            F500LabeG1.ForeColor = Color.Black
            F500labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG1.Text = "C"
            F500LabeG1.ForeColor = Color.Black
            F500labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG1.Text = "B"
            F500LabeG1.ForeColor = Color.Black
            F500labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG1.Text = "A"
            F500LabeG1.ForeColor = Color.Black
            F500labelpt1.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN2.Click
        F500ComboBoxCN2.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN2.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN2.SelectedItem.ToString
        F500ButtonCN2.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN2.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU2.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU2.Text = "-"
            F500LabelCN2.Text = "-"
            F500LabelQP2.Text = "-"
            F500TextBoxCN2.Enabled = False
            F500LabeG2.Text = "-"
            F500ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN2.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level2()
        Else
        End If
        Call F500TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG2.Text = "F"
            F500LabeG2.ForeColor = Color.Red
            F500labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG2.Text = "E"
            F500LabeG2.ForeColor = Color.Black
            F500labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG2.Text = "D"
            F500LabeG2.ForeColor = Color.Black
            F500labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG2.Text = "C"
            F500LabeG2.ForeColor = Color.Black
            F500labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG2.Text = "B"
            F500LabeG2.ForeColor = Color.Black
            F500labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG2.Text = "A"
            F500LabeG2.ForeColor = Color.Black
            F500labelpt2.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN3.Click
        F500ComboBoxCN3.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN3.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN3.SelectedItem.ToString
        F500ButtonCN3.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN3.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU3.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU3.Text = "-"
            F500LabelCN3.Text = "-"
            F500LabelQP3.Text = "-"
            F500TextBoxCN3.Enabled = False
            F500LabeG3.Text = "-"
            F500ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN3.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level3()
        Else
        End If
        Call F500TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG3.Text = "F"
            F500LabeG3.ForeColor = Color.Red
            F500labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG3.Text = "E"
            F500LabeG3.ForeColor = Color.Black
            F500labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG3.Text = "D"
            F500LabeG3.ForeColor = Color.Black
            F500labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG3.Text = "C"
            F500LabeG3.ForeColor = Color.Black
            F500labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG3.Text = "B"
            F500LabeG3.ForeColor = Color.Black
            F500labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG3.Text = "A"
            F500LabeG3.ForeColor = Color.Black
            F500labelpt3.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN4.Click
        F500ComboBoxCN4.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN4.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN4.SelectedItem.ToString
        F500ButtonCN4.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN4.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU4.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU4.Text = "-"
            F500LabelCN4.Text = "-"
            F500LabelQP4.Text = "-"
            F500TextBoxCN4.Enabled = False
            F500LabeG4.Text = "-"
            F500ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN4.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level4()
        Else
        End If
        Call F500TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG4.Text = "F"
            F500LabeG4.ForeColor = Color.Red
            F500labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG4.Text = "E"
            F500LabeG4.ForeColor = Color.Black
            F500labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG4.Text = "D"
            F500LabeG4.ForeColor = Color.Black
            F500labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG4.Text = "C"
            F500LabeG4.ForeColor = Color.Black
            F500labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG4.Text = "B"
            F500LabeG4.ForeColor = Color.Black
            F500labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG4.Text = "A"
            F500LabeG4.ForeColor = Color.Black
            F500labelpt4.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN5.Click
        F500ComboBoxCN5.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN5.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN5.SelectedItem.ToString
        F500ButtonCN5.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN5.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU5.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU5.Text = "-"
            F500LabelCN5.Text = "-"
            F500LabelQP5.Text = "-"
            F500TextBoxCN5.Enabled = False
            F500LabeG5.Text = "-"
            F500ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN5.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level5()
        Else
        End If
        Call F500TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG5.Text = "F"
            F500LabeG5.ForeColor = Color.Red
            F500labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG5.Text = "E"
            F500LabeG5.ForeColor = Color.Black
            F500labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG5.Text = "D"
            F500LabeG5.ForeColor = Color.Black
            F500labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG5.Text = "C"
            F500LabeG5.ForeColor = Color.Black
            F500labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG5.Text = "B"
            F500LabeG5.ForeColor = Color.Black
            F500labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG5.Text = "A"
            F500LabeG5.ForeColor = Color.Black
            F500labelpt5.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN6.Click
        F500ComboBoxCN6.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN6.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN6.SelectedItem.ToString
        F500ButtonCN6.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN6.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU6.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU6.Text = "-"
            F500LabelCN6.Text = "-"
            F500LabelQP6.Text = "-"
            F500TextBoxCN6.Enabled = False
            F500LabeG6.Text = "-"
            F500ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN6.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level6()
        Else
        End If
        Call F500TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG6.Text = "F"
            F500LabeG6.ForeColor = Color.Red
            F500labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG6.Text = "E"
            F500LabeG6.ForeColor = Color.Black
            F500labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG6.Text = "D"
            F500LabeG6.ForeColor = Color.Black
            F500labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG6.Text = "C"
            F500LabeG6.ForeColor = Color.Black
            F500labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG6.Text = "B"
            F500LabeG6.ForeColor = Color.Black
            F500labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG6.Text = "A"
            F500LabeG6.ForeColor = Color.Black
            F500labelpt6.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN7.Click
        F500ComboBoxCN7.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN7.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN7.SelectedItem.ToString
        F500ButtonCN7.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN7.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU7.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU7.Text = "-"
            F500LabelCN7.Text = "-"
            F500LabelQP7.Text = "-"
            F500TextBoxCN7.Enabled = False
            F500LabeG7.Text = "-"
            F500ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN7.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level7()
        Else
        End If
        Call F500TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG7.Text = "F"
            F500LabeG7.ForeColor = Color.Red
            F500labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG7.Text = "E"
            F500LabeG7.ForeColor = Color.Black
            F500labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG7.Text = "D"
            F500LabeG7.ForeColor = Color.Black
            F500labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG7.Text = "C"
            F500LabeG7.ForeColor = Color.Black
            F500labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG7.Text = "B"
            F500LabeG7.ForeColor = Color.Black
            F500labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG7.Text = "A"
            F500LabeG7.ForeColor = Color.Black
            F500labelpt7.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN8.Click
        F500ComboBoxCN8.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN8.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN8.SelectedItem.ToString
        F500ButtonCN8.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN8.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU8.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU8.Text = "-"
            F500LabelCN8.Text = "-"
            F500LabelQP8.Text = "-"
            F500TextBoxCN8.Enabled = False
            F500LabeG8.Text = "-"
            F500ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN8.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level8()
        Else
        End If
        Call F500TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG8.Text = "F"
            F500LabeG8.ForeColor = Color.Red
            F500labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG8.Text = "E"
            F500LabeG8.ForeColor = Color.Black
            F500labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG8.Text = "D"
            F500LabeG8.ForeColor = Color.Black
            F500labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG8.Text = "C"
            F500LabeG8.ForeColor = Color.Black
            F500labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG8.Text = "B"
            F500LabeG8.ForeColor = Color.Black
            F500labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG8.Text = "A"
            F500LabeG8.ForeColor = Color.Black
            F500labelpt8.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN9.Click
        F500ComboBoxCN9.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN9.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN9.SelectedItem.ToString
        F500ButtonCN9.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN9.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU9.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU9.Text = "-"
            F500LabelCN9.Text = "-"
            F500LabelQP9.Text = "-"
            F500TextBoxCN9.Enabled = False
            F500LabeG9.Text = "-"
            F500ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN9.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level9()
        Else
        End If
        Call F500TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG9.Text = "F"
            F500LabeG9.ForeColor = Color.Red
            F500labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG9.Text = "E"
            F500LabeG9.ForeColor = Color.Black
            F500labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG9.Text = "D"
            F500LabeG9.ForeColor = Color.Black
            F500labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG9.Text = "C"
            F500LabeG9.ForeColor = Color.Black
            F500labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG9.Text = "B"
            F500LabeG9.ForeColor = Color.Black
            F500labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG9.Text = "A"
            F500LabeG9.ForeColor = Color.Black
            F500labelpt9.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN10.Click
        F500ComboBoxCN10.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN10.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN10.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN10.SelectedItem.ToString
        F500ButtonCN10.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN10.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU10.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU10.Text = "-"
            F500LabelCN10.Text = "-"
            F500LabelQP10.Text = "-"
            F500TextBoxCN10.Enabled = False
            F500LabeG10.Text = "-"
            F500ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN1.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level10()
        Else
        End If
        Call F500TextBoxcn10_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN10.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN10.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN10.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN10.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG10.Text = "F"
            F500LabeG10.ForeColor = Color.Red
            F500labelpt10.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG10.Text = "E"
            F500LabeG10.ForeColor = Color.Black
            F500labelpt10.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG10.Text = "D"
            F500LabeG10.ForeColor = Color.Black
            F500labelpt10.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG10.Text = "C"
            F500LabeG10.ForeColor = Color.Black
            F500labelpt10.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG10.Text = "B"
            F500LabeG10.ForeColor = Color.Black
            F500labelpt10.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG10.Text = "A"
            F500LabeG10.ForeColor = Color.Black
            F500labelpt10.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN11.Click
        F500ComboBoxCN11.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN11.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN11.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN11.SelectedItem.ToString
        F500ButtonCN11.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN11.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU11.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU11.Text = "-"
            F500LabelCN11.Text = "-"
            F500LabelQP11.Text = "-"
            F500TextBoxCN11.Enabled = False
            F500LabeG11.Text = "-"
            F500ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN11.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level11()
        Else
        End If
        Call F500TextBoxcn11_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN11.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN11.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN11.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN11.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG11.Text = "F"
            F500LabeG11.ForeColor = Color.Red
            F500labelpt11.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG11.Text = "E"
            F500LabeG11.ForeColor = Color.Black
            F500labelpt11.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG11.Text = "D"
            F500LabeG11.ForeColor = Color.Black
            F500labelpt11.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG11.Text = "C"
            F500LabeG11.ForeColor = Color.Black
            F500labelpt11.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG11.Text = "B"
            F500LabeG11.ForeColor = Color.Black
            F500labelpt11.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG11.Text = "A"
            F500LabeG11.ForeColor = Color.Black
            F500labelpt11.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN12.Click
        F500ComboBoxCN12.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN12.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN12.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN12.SelectedItem.ToString
        F500ButtonCN12.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN12.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU12.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU12.Text = "-"
            F500LabelCN12.Text = "-"
            F500LabelQP12.Text = "-"
            F500TextBoxCN12.Enabled = False
            F500LabeG12.Text = "-"
            F500ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN12.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level12()
        Else
        End If
        Call F500TextBoxcn12_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN12.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN12.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN12.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN12.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG12.Text = "F"
            F500LabeG12.ForeColor = Color.Red
            F500labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG12.Text = "E"
            F500LabeG12.ForeColor = Color.Black
            F500labelpt12.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG12.Text = "D"
            F500LabeG12.ForeColor = Color.Black
            F500labelpt12.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG12.Text = "C"
            F500LabeG12.ForeColor = Color.Black
            F500labelpt12.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG12.Text = "B"
            F500LabeG12.ForeColor = Color.Black
            F500labelpt12.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG12.Text = "A"
            F500LabeG12.ForeColor = Color.Black
            F500labelpt12.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN13.Click
        F500ComboBoxCN13.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN13.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN13.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN13.SelectedItem.ToString
        F500ButtonCN13.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN13.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU13.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU13.Text = "-"
            F500LabelCN13.Text = "-"
            F500LabelQP13.Text = "-"
            F500TextBoxCN13.Enabled = False
            F500LabeG13.Text = "-"
            F500ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN13.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F500Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call F500level13()
        Else
        End If
        Call F500TextBoxcn13_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN13.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN13.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN13.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN13.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG13.Text = "F"
            F500LabeG13.ForeColor = Color.Red
            F500labelpt13.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG13.Text = "E"
            F500LabeG13.ForeColor = Color.Black
            F500labelpt13.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG13.Text = "D"
            F500LabeG13.ForeColor = Color.Black
            F500labelpt13.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG13.Text = "C"
            F500LabeG13.ForeColor = Color.Black
            F500labelpt13.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG13.Text = "B"
            F500LabeG13.ForeColor = Color.Black
            F500labelpt13.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG13.Text = "A"
            F500LabeG13.ForeColor = Color.Black
            F500labelpt13.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F500ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN14.Click
        F500ComboBoxCN14.Items.Clear()
        Call hope()
        For i = 0 To F500Listboxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = F500Listboxhopecode.Items(i).ToString
            F500ComboBoxCN14.Items.Add(onyii)
        Next
    End Sub
    Private Sub F500ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500ComboBoxCN14.SelectedIndexChanged
        Dim course As String
        course = F500ComboBoxCN14.SelectedItem.ToString
        F500ButtonCN14.Text = course
        For i = 0 To F500ListboxCourseCode.Items.Count - 1
            If course = F500ListboxCourseCode.Items(i).ToString Then
                F500LabelCN14.Text = F500ListboxCourseName.Items(i).ToString
                F500LabelCU14.Text = F500ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F500LabelCU14.Text = "-"
            F500LabelCN14.Text = "-"
            F500LabelQP14.Text = "-"
            F500TextBoxCN14.Enabled = False
            F500LabeG14.Text = "-"
            F500ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F500TextBoxCN14.Enabled = True
            Call oleku()
        End If
        Call F500TextBoxcn14_TextChanged(sender, e)
    End Sub
    Private Sub F500TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F500TextBoxCN14.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F500TextBoxCN14.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F500TextBoxCN14.Clear()
            End If
        Next
        Dim grade As Integer = Val(F500TextBoxCN14.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F500LabeG14.Text = "F"
            F500LabeG14.ForeColor = Color.Red
            F500labelpt14.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F500LabeG14.Text = "E"
            F500LabeG14.ForeColor = Color.Black
            F500labelpt14.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F500LabeG14.Text = "D"
            F500LabeG14.ForeColor = Color.Black
            F500labelpt14.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F500LabeG14.Text = "C"
            F500LabeG14.ForeColor = Color.Black
            F500labelpt14.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F500LabeG14.Text = "B"
            F500LabeG14.ForeColor = Color.Black
            F500labelpt14.Text = "4"
        ElseIf (grade > 69) Then
            F500LabeG14.Text = "A"
            F500LabeG14.ForeColor = Color.Black
            F500labelpt14.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
'f600 comboxes and textboxexs
    Private Sub F600ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN1.Click
        F600ComboboxCN1.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN1.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN1.SelectedItem.ToString
        F600ButtonCN1.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN1.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU1.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU1.Text = "-"
            F600LabelCN1.Text = "-"
            F600LabelQP1.Text = "-"
            F600TextboxCN1.Enabled = False
            F600LabelG1.Text = "-"
            F600ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level1()
        Else
        End If
        Call F600TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG1.Text = "F"
            F600LabelG1.ForeColor = Color.Red
            F600labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG1.Text = "E"
            F600LabelG1.ForeColor = Color.Black
            F600labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG1.Text = "D"
            F600LabelG1.ForeColor = Color.Black
            F600labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG1.Text = "C"
            F600LabelG1.ForeColor = Color.Black
            F600labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG1.Text = "B"
            F600LabelG1.ForeColor = Color.Black
            F600labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG1.Text = "A"
            F600LabelG1.ForeColor = Color.Black
            F600labelpt1.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN2.Click
        F600ComboboxCN2.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN2.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN2.SelectedItem.ToString
        F600ButtonCN2.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN2.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU2.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU2.Text = "-"
            F600LabelCN2.Text = "-"
            F600LabelQP2.Text = "-"
            F600TextboxCN2.Enabled = False
            F600LabelG2.Text = "-"
            F600ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN2.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level2()
        Else
        End If
        Call F600TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG2.Text = "F"
            F600LabelG2.ForeColor = Color.Red
            F600labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG2.Text = "E"
            F600LabelG2.ForeColor = Color.Black
            F600labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG2.Text = "D"
            F600LabelG2.ForeColor = Color.Black
            F600labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG2.Text = "C"
            F600LabelG2.ForeColor = Color.Black
            F600labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG2.Text = "B"
            F600LabelG2.ForeColor = Color.Black
            F600labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG2.Text = "A"
            F600LabelG2.ForeColor = Color.Black
            F600labelpt2.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN3.Click
        F600ComboboxCN3.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN3.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN3.SelectedItem.ToString
        F600ButtonCN3.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN3.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU3.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU3.Text = "-"
            F600LabelCN3.Text = "-"
            F600LabelQP3.Text = "-"
            F600TextboxCN3.Enabled = False
            F600LabelG3.Text = "-"
            F600ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN3.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level3()
        Else
        End If
        Call F600TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG3.Text = "F"
            F600LabelG3.ForeColor = Color.Red
            F600labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG3.Text = "E"
            F600LabelG3.ForeColor = Color.Black
            F600labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG3.Text = "D"
            F600LabelG3.ForeColor = Color.Black
            F600labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG3.Text = "C"
            F600LabelG3.ForeColor = Color.Black
            F600labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG3.Text = "B"
            F600LabelG3.ForeColor = Color.Black
            F600labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG3.Text = "A"
            F600LabelG3.ForeColor = Color.Black
            F600labelpt3.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN4.Click
        F600ComboboxCN4.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN4.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN4.SelectedItem.ToString
        F600ButtonCN4.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN4.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU4.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU4.Text = "-"
            F600LabelCN4.Text = "-"
            F600LabelQP4.Text = "-"
            F600TextboxCN4.Enabled = False
            F600LabelG4.Text = "-"
            F600ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN4.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level4()
        Else
        End If
        Call F600TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG4.Text = "F"
            F600LabelG4.ForeColor = Color.Red
            F600labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG4.Text = "E"
            F600LabelG4.ForeColor = Color.Black
            F600labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG4.Text = "D"
            F600LabelG4.ForeColor = Color.Black
            F600labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG4.Text = "C"
            F600LabelG4.ForeColor = Color.Black
            F600labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG4.Text = "B"
            F600LabelG4.ForeColor = Color.Black
            F600labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG4.Text = "A"
            F600LabelG4.ForeColor = Color.Black
            F600labelpt4.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN5.Click
        F600ComboboxCN5.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN5.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN5.SelectedItem.ToString
        F600ButtonCN5.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN5.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU5.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU5.Text = "-"
            F600LabelCN5.Text = "-"
            F600LabelQP5.Text = "-"
            F600TextboxCN5.Enabled = False
            F600LabelG5.Text = "-"
            F600ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN5.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level5()
        Else
        End If
        Call F600TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG5.Text = "F"
            F600LabelG5.ForeColor = Color.Red
            F600labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG5.Text = "E"
            F600LabelG5.ForeColor = Color.Black
            F600labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG5.Text = "D"
            F600LabelG5.ForeColor = Color.Black
            F600labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG5.Text = "C"
            F600LabelG5.ForeColor = Color.Black
            F600labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG5.Text = "B"
            F600LabelG5.ForeColor = Color.Black
            F600labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG5.Text = "A"
            F600LabelG5.ForeColor = Color.Black
            F600labelpt5.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN6.Click
        F600ComboboxCN6.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN6.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN6.SelectedItem.ToString
        F600ButtonCN6.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN6.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU6.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU6.Text = "-"
            F600LabelCN6.Text = "-"
            F600LabelQP6.Text = "-"
            F600TextboxCN6.Enabled = False
            F600LabelG6.Text = "-"
            F600ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN6.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level6()
        Else
        End If
        Call F600TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG6.Text = "F"
            F600LabelG6.ForeColor = Color.Red
            F600labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG6.Text = "E"
            F600LabelG6.ForeColor = Color.Black
            F600labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG6.Text = "D"
            F600LabelG6.ForeColor = Color.Black
            F600labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG6.Text = "C"
            F600LabelG6.ForeColor = Color.Black
            F600labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG6.Text = "B"
            F600LabelG6.ForeColor = Color.Black
            F600labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG6.Text = "A"
            F600LabelG6.ForeColor = Color.Black
            F600labelpt6.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN7.Click
        F600ComboboxCN7.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN7.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN7.SelectedItem.ToString
        F600ButtonCN7.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN7.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU7.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU7.Text = "-"
            F600LabelCN7.Text = "-"
            F600LabelQP7.Text = "-"
            F600TextboxCN7.Enabled = False
            F600LabelG7.Text = "-"
            F600ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN7.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level7()
        Else
        End If
        Call F600TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG7.Text = "F"
            F600LabelG7.ForeColor = Color.Red
            F600labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG7.Text = "E"
            F600LabelG7.ForeColor = Color.Black
            F600labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG7.Text = "D"
            F600LabelG7.ForeColor = Color.Black
            F600labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG7.Text = "C"
            F600LabelG7.ForeColor = Color.Black
            F600labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG7.Text = "B"
            F600LabelG7.ForeColor = Color.Black
            F600labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG7.Text = "A"
            F600LabelG7.ForeColor = Color.Black
            F600labelpt7.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN8.Click
        F600ComboboxCN8.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN8.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN8.SelectedItem.ToString
        F600ButtonCN8.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN8.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU8.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU8.Text = "-"
            F600LabelCN8.Text = "-"
            F600LabelQP8.Text = "-"
            F600TextboxCN8.Enabled = False
            F600LabelG8.Text = "-"
            F600ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN8.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level8()
        Else
        End If
        Call F600TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG8.Text = "F"
            F600LabelG8.ForeColor = Color.Red
            F600labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG8.Text = "E"
            F600LabelG8.ForeColor = Color.Black
            F600labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG8.Text = "D"
            F600LabelG8.ForeColor = Color.Black
            F600labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG8.Text = "C"
            F600LabelG8.ForeColor = Color.Black
            F600labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG8.Text = "B"
            F600LabelG8.ForeColor = Color.Black
            F600labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG8.Text = "A"
            F600LabelG8.ForeColor = Color.Black
            F600labelpt8.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN9.Click
        F600ComboboxCN9.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN9.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN9.SelectedItem.ToString
        F600ButtonCN9.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN9.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU9.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU9.Text = "-"
            F600LabelCN9.Text = "-"
            F600LabelQP9.Text = "-"
            F600TextboxCN9.Enabled = False
            F600LabelG9.Text = "-"
            F600ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN9.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level9()
        Else
        End If
        Call F600TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG9.Text = "F"
            F600LabelG9.ForeColor = Color.Red
            F600labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG9.Text = "E"
            F600LabelG9.ForeColor = Color.Black
            F600labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG9.Text = "D"
            F600LabelG9.ForeColor = Color.Black
            F600labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG9.Text = "C"
            F600LabelG9.ForeColor = Color.Black
            F600labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG9.Text = "B"
            F600LabelG9.ForeColor = Color.Black
            F600labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG9.Text = "A"
            F600LabelG9.ForeColor = Color.Black
            F600labelpt9.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN10.Click
        F600ComboboxCN10.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN10.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN10.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN10.SelectedItem.ToString
        F600ButtonCN10.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN10.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU10.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU10.Text = "-"
            F600LabelCN10.Text = "-"
            F600LabelQP10.Text = "-"
            F600TextboxCN10.Enabled = False
            F600LabelG10.Text = "-"
            F600ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN1.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level10()
        Else
        End If
        Call F600TextBoxcn10_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN10.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN10.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN10.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN10.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG10.Text = "F"
            F600LabelG10.ForeColor = Color.Red
            F600labelpt10.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG10.Text = "E"
            F600LabelG10.ForeColor = Color.Black
            F600labelpt10.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG10.Text = "D"
            F600LabelG10.ForeColor = Color.Black
            F600labelpt10.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG10.Text = "C"
            F600LabelG10.ForeColor = Color.Black
            F600labelpt10.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG10.Text = "B"
            F600LabelG10.ForeColor = Color.Black
            F600labelpt10.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG10.Text = "A"
            F600LabelG10.ForeColor = Color.Black
            F600labelpt10.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN11.Click
        F600ComboboxCN11.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN11.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN11.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN11.SelectedItem.ToString
        F600ButtonCN11.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN11.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU11.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU11.Text = "-"
            F600LabelCN11.Text = "-"
            F600LabelQP11.Text = "-"
            F600TextboxCN11.Enabled = False
            F600LabelG11.Text = "-"
            F600ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN11.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level11()
        Else
        End If
        Call F600TextBoxcn11_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN11.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN11.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN11.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN11.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG11.Text = "F"
            F600LabelG11.ForeColor = Color.Red
            F600labelpt11.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG11.Text = "E"
            F600LabelG11.ForeColor = Color.Black
            F600labelpt11.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG11.Text = "D"
            F600LabelG11.ForeColor = Color.Black
            F600labelpt11.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG11.Text = "C"
            F600LabelG11.ForeColor = Color.Black
            F600labelpt11.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG11.Text = "B"
            F600LabelG11.ForeColor = Color.Black
            F600labelpt11.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG11.Text = "A"
            F600LabelG11.ForeColor = Color.Black
            F600labelpt11.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN12.Click
        F600ComboboxCN12.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN12.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN12.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN12.SelectedItem.ToString
        F600ButtonCN12.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN12.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU12.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU12.Text = "-"
            F600LabelCN12.Text = "-"
            F600LabelQP12.Text = "-"
            F600TextboxCN12.Enabled = False
            F600LabelG12.Text = "-"
            F600ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN12.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level12()
        Else
        End If
        Call F600TextBoxcn12_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN12.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN12.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN12.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN12.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG12.Text = "F"
            F600LabelG12.ForeColor = Color.Red
            F600labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG12.Text = "E"
            F600LabelG12.ForeColor = Color.Black
            F600labelpt12.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG12.Text = "D"
            F600LabelG12.ForeColor = Color.Black
            F600labelpt12.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG12.Text = "C"
            F600LabelG12.ForeColor = Color.Black
            F600labelpt12.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG12.Text = "B"
            F600LabelG12.ForeColor = Color.Black
            F600labelpt12.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG12.Text = "A"
            F600LabelG12.ForeColor = Color.Black
            F600labelpt12.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN13.Click
        F600ComboboxCN13.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN13.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN13.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN13.SelectedItem.ToString
        F600ButtonCN13.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN13.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU13.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU13.Text = "-"
            F600LabelCN13.Text = "-"
            F600LabelQP13.Text = "-"
            F600TextboxCN13.Enabled = False
            F600LabelG13.Text = "-"
            F600ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN13.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F600ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call F600level13()
        Else
        End If
        Call F600TextBoxcn13_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN13.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN13.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN13.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN13.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG13.Text = "F"
            F600LabelG13.ForeColor = Color.Red
            F600labelpt13.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG13.Text = "E"
            F600LabelG13.ForeColor = Color.Black
            F600labelpt13.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG13.Text = "D"
            F600LabelG13.ForeColor = Color.Black
            F600labelpt13.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG13.Text = "C"
            F600LabelG13.ForeColor = Color.Black
            F600labelpt13.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG13.Text = "B"
            F600LabelG13.ForeColor = Color.Black
            F600labelpt13.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG13.Text = "A"
            F600LabelG13.ForeColor = Color.Black
            F600labelpt13.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F600ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F600ComboboxCN14.Click
        F600ComboboxCN14.Items.Clear()
        Call hope()
        For i = 0 To F600ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F600ListboxhopeCode.Items(i).ToString
            F600ComboboxCN14.Items.Add(onyii)
        Next
    End Sub
    Private Sub F600ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600ComboboxCN14.SelectedIndexChanged
        Dim course As String
        course = F600ComboboxCN14.SelectedItem.ToString
        F600ButtonCN14.Text = course
        For i = 0 To F600ListboxCourseCode.Items.Count - 1
            If course = F600ListboxCourseCode.Items(i).ToString Then
                F600LabelCN14.Text = F600ListboxCourseName.Items(i).ToString
                F600LabelCU14.Text = F600Listboxcreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F600LabelCU14.Text = "-"
            F600LabelCN14.Text = "-"
            F600LabelQP14.Text = "-"
            F600TextboxCN14.Enabled = False
            F600LabelG14.Text = "-"
            F600ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F600TextboxCN14.Enabled = True
            Call oleku()
        End If
        Call F600TextBoxcn14_TextChanged(sender, e)
    End Sub
    Private Sub F600TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F600TextboxCN14.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F600TextboxCN14.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F600TextboxCN14.Clear()
            End If
        Next
        Dim grade As Integer = Val(F600TextboxCN14.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F600LabelG14.Text = "F"
            F600LabelG14.ForeColor = Color.Red
            F600labelpt14.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F600LabelG14.Text = "E"
            F600LabelG14.ForeColor = Color.Black
            F600labelpt14.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F600LabelG14.Text = "D"
            F600LabelG14.ForeColor = Color.Black
            F600labelpt14.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F600LabelG14.Text = "C"
            F600LabelG14.ForeColor = Color.Black
            F600labelpt14.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F600LabelG14.Text = "B"
            F600LabelG14.ForeColor = Color.Black
            F600labelpt14.Text = "4"
        ElseIf (grade > 69) Then
            F600LabelG14.Text = "A"
            F600LabelG14.ForeColor = Color.Black
            F600labelpt14.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
'f700 comboxes and textboxexs
    Private Sub F700ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN1.Click
        F700ComboBoxCN1.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN1.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN1.SelectedItem.ToString
        F700ButtonCN1.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN1.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU1.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU1.Text = "-"
            F700LabelCN1.Text = "-"
            F700LabelQP1.Text = "-"
            F700TextBoxCN1.Enabled = False
            F700LabelG1.Text = "-"
            F700ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level1()
        Else
        End If
        Call F700TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG1.Text = "F"
            F700LabelG1.ForeColor = Color.Red
            F700labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG1.Text = "E"
            F700LabelG1.ForeColor = Color.Black
            F700labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG1.Text = "D"
            F700LabelG1.ForeColor = Color.Black
            F700labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG1.Text = "C"
            F700LabelG1.ForeColor = Color.Black
            F700labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG1.Text = "B"
            F700LabelG1.ForeColor = Color.Black
            F700labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG1.Text = "A"
            F700LabelG1.ForeColor = Color.Black
            F700labelpt1.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN2.Click
        F700ComboBoxCN2.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN2.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN2.SelectedItem.ToString
        F700ButtonCN2.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN2.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU2.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU2.Text = "-"
            F700LabelCN2.Text = "-"
            F700LabelQP2.Text = "-"
            F700TextBoxCN2.Enabled = False
            F700LabelG2.Text = "-"
            F700ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN2.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level2()
        Else
        End If
        Call F700TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG2.Text = "F"
            F700LabelG2.ForeColor = Color.Red
            F700labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG2.Text = "E"
            F700LabelG2.ForeColor = Color.Black
            F700labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG2.Text = "D"
            F700LabelG2.ForeColor = Color.Black
            F700labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG2.Text = "C"
            F700LabelG2.ForeColor = Color.Black
            F700labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG2.Text = "B"
            F700LabelG2.ForeColor = Color.Black
            F700labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG2.Text = "A"
            F700LabelG2.ForeColor = Color.Black
            F700labelpt2.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN3.Click
        F700ComboBoxCN3.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN3.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN3.SelectedItem.ToString
        F700ButtonCN3.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN3.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU3.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU3.Text = "-"
            F700LabelCN3.Text = "-"
            F700LabelQP3.Text = "-"
            F700TextBoxCN3.Enabled = False
            F700LabelG3.Text = "-"
            F700ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN3.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level3()
        Else
        End If
        Call F700TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG3.Text = "F"
            F700LabelG3.ForeColor = Color.Red
            F700labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG3.Text = "E"
            F700LabelG3.ForeColor = Color.Black
            F700labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG3.Text = "D"
            F700LabelG3.ForeColor = Color.Black
            F700labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG3.Text = "C"
            F700LabelG3.ForeColor = Color.Black
            F700labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG3.Text = "B"
            F700LabelG3.ForeColor = Color.Black
            F700labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG3.Text = "A"
            F700LabelG3.ForeColor = Color.Black
            F700labelpt3.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN4.Click
        F700ComboBoxCN4.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN4.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN4.SelectedItem.ToString
        F700ButtonCN4.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN4.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU4.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU4.Text = "-"
            F700LabelCN4.Text = "-"
            F700LabelQP4.Text = "-"
            F700TextBoxCN4.Enabled = False
            F700LabelG4.Text = "-"
            F700ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN4.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level4()
        Else
        End If
        Call F700TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG4.Text = "F"
            F700LabelG4.ForeColor = Color.Red
            F700labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG4.Text = "E"
            F700LabelG4.ForeColor = Color.Black
            F700labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG4.Text = "D"
            F700LabelG4.ForeColor = Color.Black
            F700labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG4.Text = "C"
            F700LabelG4.ForeColor = Color.Black
            F700labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG4.Text = "B"
            F700LabelG4.ForeColor = Color.Black
            F700labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG4.Text = "A"
            F700LabelG4.ForeColor = Color.Black
            F700labelpt4.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN5.Click
        F700ComboBoxCN5.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN5.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN5.SelectedItem.ToString
        F700ButtonCN5.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN5.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU5.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU5.Text = "-"
            F700LabelCN5.Text = "-"
            F700LabelQP5.Text = "-"
            F700TextBoxCN5.Enabled = False
            F700LabelG5.Text = "-"
            F700ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN5.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level5()
        Else
        End If
        Call F700TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG5.Text = "F"
            F700LabelG5.ForeColor = Color.Red
            F700labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG5.Text = "E"
            F700LabelG5.ForeColor = Color.Black
            F700labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG5.Text = "D"
            F700LabelG5.ForeColor = Color.Black
            F700labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG5.Text = "C"
            F700LabelG5.ForeColor = Color.Black
            F700labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG5.Text = "B"
            F700LabelG5.ForeColor = Color.Black
            F700labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG5.Text = "A"
            F700LabelG5.ForeColor = Color.Black
            F700labelpt5.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN6.Click
        F700ComboBoxCN6.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN6.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN6.SelectedItem.ToString
        F700ButtonCN6.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN6.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU6.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU6.Text = "-"
            F700LabelCN6.Text = "-"
            F700LabelQP6.Text = "-"
            F700TextBoxCN6.Enabled = False
            F700LabelG6.Text = "-"
            F700ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN6.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level6()
        Else
        End If
        Call F700TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG6.Text = "F"
            F700LabelG6.ForeColor = Color.Red
            F700labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG6.Text = "E"
            F700LabelG6.ForeColor = Color.Black
            F700labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG6.Text = "D"
            F700LabelG6.ForeColor = Color.Black
            F700labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG6.Text = "C"
            F700LabelG6.ForeColor = Color.Black
            F700labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG6.Text = "B"
            F700LabelG6.ForeColor = Color.Black
            F700labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG6.Text = "A"
            F700LabelG6.ForeColor = Color.Black
            F700labelpt6.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN7.Click
        F700ComboBoxCN7.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN7.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN7.SelectedItem.ToString
        F700ButtonCN7.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN7.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU7.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU7.Text = "-"
            F700LabelCN7.Text = "-"
            F700LabelQP7.Text = "-"
            F700TextBoxCN7.Enabled = False
            F700LabelG7.Text = "-"
            F700ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN7.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level7()
        Else
        End If
        Call F700TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG7.Text = "F"
            F700LabelG7.ForeColor = Color.Red
            F700labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG7.Text = "E"
            F700LabelG7.ForeColor = Color.Black
            F700labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG7.Text = "D"
            F700LabelG7.ForeColor = Color.Black
            F700labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG7.Text = "C"
            F700LabelG7.ForeColor = Color.Black
            F700labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG7.Text = "B"
            F700LabelG7.ForeColor = Color.Black
            F700labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG7.Text = "A"
            F700LabelG7.ForeColor = Color.Black
            F700labelpt7.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN8.Click
        F700ComboBoxCN8.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN8.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN8.SelectedItem.ToString
        F700ButtonCN8.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN8.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU8.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU8.Text = "-"
            F700LabelCN8.Text = "-"
            F700LabelQP8.Text = "-"
            F700TextBoxCN8.Enabled = False
            F700LabelG8.Text = "-"
            F700ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN8.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level8()
        Else
        End If
        Call F700TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG8.Text = "F"
            F700LabelG8.ForeColor = Color.Red
            F700labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG8.Text = "E"
            F700LabelG8.ForeColor = Color.Black
            F700labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG8.Text = "D"
            F700LabelG8.ForeColor = Color.Black
            F700labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG8.Text = "C"
            F700LabelG8.ForeColor = Color.Black
            F700labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG8.Text = "B"
            F700LabelG8.ForeColor = Color.Black
            F700labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG8.Text = "A"
            F700LabelG8.ForeColor = Color.Black
            F700labelpt8.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN9.Click
        F700ComboBoxCN9.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN9.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN9.SelectedItem.ToString
        F700ButtonCN9.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN9.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU9.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU9.Text = "-"
            F700LabelCN9.Text = "-"
            F700LabelQP9.Text = "-"
            F700TextBoxCN9.Enabled = False
            F700LabelG9.Text = "-"
            F700ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN9.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level9()
        Else
        End If
        Call F700TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG9.Text = "F"
            F700LabelG9.ForeColor = Color.Red
            F700labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG9.Text = "E"
            F700LabelG9.ForeColor = Color.Black
            F700labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG9.Text = "D"
            F700LabelG9.ForeColor = Color.Black
            F700labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG9.Text = "C"
            F700LabelG9.ForeColor = Color.Black
            F700labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG9.Text = "B"
            F700LabelG9.ForeColor = Color.Black
            F700labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG9.Text = "A"
            F700LabelG9.ForeColor = Color.Black
            F700labelpt9.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN10.Click
        F700ComboBoxCN10.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN10.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN10.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN10.SelectedItem.ToString
        F700ButtonCN10.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN10.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU10.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU10.Text = "-"
            F700LabelCN10.Text = "-"
            F700LabelQP10.Text = "-"
            F700TextBoxCN10.Enabled = False
            F700LabelG10.Text = "-"
            F700ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN1.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level10()
        Else
        End If
        Call F700TextBoxcn10_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN10.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN10.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN10.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN10.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG10.Text = "F"
            F700LabelG10.ForeColor = Color.Red
            F700labelpt10.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG10.Text = "E"
            F700LabelG10.ForeColor = Color.Black
            F700labelpt10.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG10.Text = "D"
            F700LabelG10.ForeColor = Color.Black
            F700labelpt10.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG10.Text = "C"
            F700LabelG10.ForeColor = Color.Black
            F700labelpt10.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG10.Text = "B"
            F700LabelG10.ForeColor = Color.Black
            F700labelpt10.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG10.Text = "A"
            F700LabelG10.ForeColor = Color.Black
            F700labelpt10.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN11.Click
        F700ComboBoxCN11.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN11.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN11.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN11.SelectedItem.ToString
        F700ButtonCN11.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN11.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU11.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU11.Text = "-"
            F700LabelCN11.Text = "-"
            F700LabelQP11.Text = "-"
            F700TextBoxCN11.Enabled = False
            F700LabelG11.Text = "-"
            F700ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN11.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level11()
        Else
        End If
        Call F700TextBoxcn11_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN11.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN11.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN11.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN11.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG11.Text = "F"
            F700LabelG11.ForeColor = Color.Red
            F700labelpt11.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG11.Text = "E"
            F700LabelG11.ForeColor = Color.Black
            F700labelpt11.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG11.Text = "D"
            F700LabelG11.ForeColor = Color.Black
            F700labelpt11.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG11.Text = "C"
            F700LabelG11.ForeColor = Color.Black
            F700labelpt11.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG11.Text = "B"
            F700LabelG11.ForeColor = Color.Black
            F700labelpt11.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG11.Text = "A"
            F700LabelG11.ForeColor = Color.Black
            F700labelpt11.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN12.Click
        F700ComboBoxCN12.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN12.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN12.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN12.SelectedItem.ToString
        F700ButtonCN12.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN12.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU12.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU12.Text = "-"
            F700LabelCN12.Text = "-"
            F700LabelQP12.Text = "-"
            F700TextBoxCN12.Enabled = False
            F700LabelG12.Text = "-"
            F700ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN12.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level12()
        Else
        End If
        Call F700TextBoxcn12_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN12.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN12.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN12.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN12.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG12.Text = "F"
            F700LabelG12.ForeColor = Color.Red
            F700labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG12.Text = "E"
            F700LabelG12.ForeColor = Color.Black
            F700labelpt12.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG12.Text = "D"
            F700LabelG12.ForeColor = Color.Black
            F700labelpt12.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG12.Text = "C"
            F700LabelG12.ForeColor = Color.Black
            F700labelpt12.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG12.Text = "B"
            F700LabelG12.ForeColor = Color.Black
            F700labelpt12.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG12.Text = "A"
            F700LabelG12.ForeColor = Color.Black
            F700labelpt12.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN13.Click
        F700ComboBoxCN13.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN13.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN13.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN13.SelectedItem.ToString
        F700ButtonCN13.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN13.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU13.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU13.Text = "-"
            F700LabelCN13.Text = "-"
            F700LabelQP13.Text = "-"
            F700TextBoxCN13.Enabled = False
            F700LabelG13.Text = "-"
            F700ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN13.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(F700ListBoxHopeCode.Items.Count)
        If alako > 1 Then
            Call F700level13()
        Else
        End If
        Call F700TextBoxcn13_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN13.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN13.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN13.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN13.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG13.Text = "F"
            F700LabelG13.ForeColor = Color.Red
            F700labelpt13.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG13.Text = "E"
            F700LabelG13.ForeColor = Color.Black
            F700labelpt13.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG13.Text = "D"
            F700LabelG13.ForeColor = Color.Black
            F700labelpt13.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG13.Text = "C"
            F700LabelG13.ForeColor = Color.Black
            F700labelpt13.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG13.Text = "B"
            F700LabelG13.ForeColor = Color.Black
            F700labelpt13.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG13.Text = "A"
            F700LabelG13.ForeColor = Color.Black
            F700labelpt13.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F700ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN14.Click
        F700ComboBoxCN14.Items.Clear()
        Call hope()
        For i = 0 To F700ListBoxHopeCode.Items.Count - 1
            Dim onyii As String
            onyii = F700ListBoxHopeCode.Items(i).ToString
            F700ComboBoxCN14.Items.Add(onyii)
        Next
    End Sub
    Private Sub F700ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700ComboBoxCN14.SelectedIndexChanged
        Dim course As String
        course = F700ComboBoxCN14.SelectedItem.ToString
        F700ButtonCN14.Text = course
        For i = 0 To F700ListBoxCourseCode.Items.Count - 1
            If course = F700ListBoxCourseCode.Items(i).ToString Then
                F700LabelCN14.Text = F700ListBoxCourseName.Items(i).ToString
                F700LabelCU14.Text = F700ListBoxCreditunit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(F700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F700LabelCU14.Text = "-"
            F700LabelCN14.Text = "-"
            F700LabelQP14.Text = "-"
            F700TextBoxCN14.Enabled = False
            F700LabelG14.Text = "-"
            F700ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            F700TextBoxCN14.Enabled = True
            Call oleku()
        End If
        Call F700TextBoxcn14_TextChanged(sender, e)
    End Sub
    Private Sub F700TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F700TextBoxCN14.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = F700TextBoxCN14.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                F700TextBoxCN14.Clear()
            End If
        Next
        Dim grade As Integer = Val(F700TextBoxCN14.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            F700LabelG14.Text = "F"
            F700LabelG14.ForeColor = Color.Red
            F700labelpt14.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            F700LabelG14.Text = "E"
            F700LabelG14.ForeColor = Color.Black
            F700labelpt14.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            F700LabelG14.Text = "D"
            F700LabelG14.ForeColor = Color.Black
            F700labelpt14.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            F700LabelG14.Text = "C"
            F700LabelG14.ForeColor = Color.Black
            F700labelpt14.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            F700LabelG14.Text = "B"
            F700LabelG14.ForeColor = Color.Black
            F700labelpt14.Text = "4"
        ElseIf (grade > 69) Then
            F700LabelG14.Text = "A"
            F700LabelG14.ForeColor = Color.Black
            F700labelpt14.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub

    's100 comboxes and textboxexs
    Private Sub S100ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN1.Click
        S100ComboBoxCN1.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN1.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN1.SelectedItem.ToString
        S100ButtonCN1.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN1.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU1.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU1.Text = "-"
            S100LabelCN1.Text = "-"
            S100LabelQP1.Text = "-"
            S100TextboxCN1.Enabled = False
            S100LabelG1.Text = "-"
            S100ButtonCN1.Text = "-"
            Exit Sub
        Else
            S100TextboxCN1.Enabled = True
            Call S100oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level1()
        Else
        End If
        Call S100TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG1.Text = "F"
            S100LabelG1.ForeColor = Color.Red
            S100labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG1.Text = "E"
            S100LabelG1.ForeColor = Color.Black
            S100labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG1.Text = "D"
            S100LabelG1.ForeColor = Color.Black
            S100labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG1.Text = "C"
            S100LabelG1.ForeColor = Color.Black
            S100labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG1.Text = "B"
            S100LabelG1.ForeColor = Color.Black
            S100labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG1.Text = "A"
            S100LabelG1.ForeColor = Color.Black
            S100labelpt1.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN2.Click
        S100ComboBoxCN2.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN2.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN2.SelectedItem.ToString
        S100ButtonCN2.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN2.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU2.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU2.Text = "-"
            S100LabelCN2.Text = "-"
            S100LabelQP2.Text = "-"
            S100TextboxCN2.Enabled = False
            S100LabelG2.Text = "-"
            S100ButtonCN2.Text = "-"
        Else
            S100TextboxCN2.Enabled = True
            Call S100oleku()
        End If
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level2()
        Else
        End If
        Call S100TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG2.Text = "F"
            S100LabelG2.ForeColor = Color.Red
            S100labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG2.Text = "E"
            S100LabelG2.ForeColor = Color.Black
            S100labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG2.Text = "D"
            S100LabelG2.ForeColor = Color.Black
            S100labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG2.Text = "C"
            S100LabelG2.ForeColor = Color.Black
            S100labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG2.Text = "B"
            S100LabelG2.ForeColor = Color.Black
            S100labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG2.Text = "A"
            S100LabelG2.ForeColor = Color.Black
            S100labelpt2.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN3.Click
        S100ComboBoxCN3.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN3.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN3.SelectedItem.ToString
        S100ButtonCN3.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN3.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU3.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU3.Text = "-"
            S100LabelCN3.Text = "-"
            S100LabelQP3.Text = "-"
            S100TextboxCN3.Enabled = False
            S100LabelG3.Text = "-"
            S100ButtonCN3.Text = "-"
        Else
            S100TextboxCN3.Enabled = True
            Call S100oleku()
        End If
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level3()
        Else
        End If
        Call S100TextBoxcn3_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN3.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN3.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN3.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN3.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG3.Text = "F"
            S100LabelG3.ForeColor = Color.Red
            S100labelpt3.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG3.Text = "E"
            S100LabelG3.ForeColor = Color.Black
            S100labelpt3.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG3.Text = "D"
            S100LabelG3.ForeColor = Color.Black
            S100labelpt3.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG3.Text = "C"
            S100LabelG3.ForeColor = Color.Black
            S100labelpt3.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG3.Text = "B"
            S100LabelG3.ForeColor = Color.Black
            S100labelpt3.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG3.Text = "A"
            S100LabelG3.ForeColor = Color.Black
            S100labelpt3.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN4.Click
        S100ComboBoxCN4.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN4.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN4.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN4.SelectedItem.ToString
        S100ButtonCN4.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN4.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU4.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU4.Text = "-"
            S100LabelCN4.Text = "-"
            S100LabelQP4.Text = "-"
            S100TextboxCN4.Enabled = False
            S100LabelG4.Text = "-"
            S100ButtonCN4.Text = "-"
        Else
            S100TextboxCN4.Enabled = True
            Call S100oleku()
        End If
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level4()
        Else
        End If
        Call S100TextBoxcn4_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN4.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN4.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN4.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN4.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG4.Text = "F"
            S100LabelG4.ForeColor = Color.Red
            S100labelpt4.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG4.Text = "E"
            S100LabelG4.ForeColor = Color.Black
            S100labelpt4.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG4.Text = "D"
            S100LabelG4.ForeColor = Color.Black
            S100labelpt4.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG4.Text = "C"
            S100LabelG4.ForeColor = Color.Black
            S100labelpt4.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG4.Text = "B"
            S100LabelG4.ForeColor = Color.Black
            S100labelpt4.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG4.Text = "A"
            S100LabelG4.ForeColor = Color.Black
            S100labelpt4.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN5.Click
        S100ComboBoxCN5.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN5.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN5.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN5.SelectedItem.ToString
        S100ButtonCN5.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN5.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU5.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU5.Text = "-"
            S100LabelCN5.Text = "-"
            S100LabelQP5.Text = "-"
            S100TextboxCN5.Enabled = False
            S100LabelG5.Text = "-"
            S100ButtonCN5.Text = "-"
        Else
            S100TextboxCN5.Enabled = True
            Call S100oleku()
        End If
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level5()
        Else
        End If
        Call S100TextBoxcn5_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN5.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN5.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN5.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN5.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG5.Text = "F"
            S100LabelG5.ForeColor = Color.Red
            S100labelpt5.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG5.Text = "E"
            S100LabelG5.ForeColor = Color.Black
            S100labelpt5.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG5.Text = "D"
            S100LabelG5.ForeColor = Color.Black
            S100labelpt5.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG5.Text = "C"
            S100LabelG5.ForeColor = Color.Black
            S100labelpt5.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG5.Text = "B"
            S100LabelG5.ForeColor = Color.Black
            S100labelpt5.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG5.Text = "A"
            S100LabelG5.ForeColor = Color.Black
            S100labelpt5.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN6.Click
        S100ComboBoxCN6.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN6.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN6.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN6.SelectedItem.ToString
        S100ButtonCN6.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN6.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU6.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU6.Text = "-"
            S100LabelCN6.Text = "-"
            S100LabelQP6.Text = "-"
            S100TextboxCN6.Enabled = False
            S100LabelG6.Text = "-"
            S100ButtonCN6.Text = "-"
        Else
            S100TextboxCN6.Enabled = True
            Call S100oleku()
        End If
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level6()
        Else
        End If
        Call S100TextBoxcn6_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN6.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN6.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN6.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN6.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG6.Text = "F"
            S100LabelG6.ForeColor = Color.Red
            S100labelpt6.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG6.Text = "E"
            S100LabelG6.ForeColor = Color.Black
            S100labelpt6.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG6.Text = "D"
            S100LabelG6.ForeColor = Color.Black
            S100labelpt6.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG6.Text = "C"
            S100LabelG6.ForeColor = Color.Black
            S100labelpt6.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG6.Text = "B"
            S100LabelG6.ForeColor = Color.Black
            S100labelpt6.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG6.Text = "A"
            S100LabelG6.ForeColor = Color.Black
            S100labelpt6.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN7.Click
        S100ComboBoxCN7.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN7.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN7.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN7.SelectedItem.ToString
        S100ButtonCN7.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN7.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU7.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU7.Text = "-"
            S100LabelCN7.Text = "-"
            S100LabelQP7.Text = "-"
            S100TextboxCN7.Enabled = False
            S100LabelG7.Text = "-"
            S100ButtonCN7.Text = "-"
        Else
            S100TextboxCN7.Enabled = True
            Call S100oleku()
        End If
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level7()
        Else
        End If
        Call S100TextBoxcn7_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN7.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN7.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN7.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN7.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG7.Text = "F"
            S100LabelG7.ForeColor = Color.Red
            S100labelpt7.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG7.Text = "E"
            S100LabelG7.ForeColor = Color.Black
            S100labelpt7.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG7.Text = "D"
            S100LabelG7.ForeColor = Color.Black
            S100labelpt7.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG7.Text = "C"
            S100LabelG7.ForeColor = Color.Black
            S100labelpt7.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG7.Text = "B"
            S100LabelG7.ForeColor = Color.Black
            S100labelpt7.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG7.Text = "A"
            S100LabelG7.ForeColor = Color.Black
            S100labelpt7.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN8.Click
        S100ComboBoxCN8.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN8.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN8.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN8.SelectedItem.ToString
        S100ButtonCN8.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN8.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU8.Text = S100LISTBOXCREDITCODE.Items(i).ToString
            End If
        Next
        Call s100totalcreditunit()
        Call s100totalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU8.Text = "-"
            S100LabelCN8.Text = "-"
            S100LabelQP8.Text = "-"
            S100TextBoxCN8.Enabled = False
            S100LabelG8.Text = "-"
            S100ButtonCN8.Text = "-"
        Else
            S100TextBoxCN8.Enabled = True
            Call s100oleku()
        End If
        Dim alako As Integer = Val(S100Listboxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level8()
        Else
        End If
        Call S100TextBoxcn8_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN8.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN8.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN8.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN8.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG8.Text = "F"
            S100LabelG8.ForeColor = Color.Red
            S100labelpt8.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG8.Text = "E"
            S100LabelG8.ForeColor = Color.Black
            S100labelpt8.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG8.Text = "D"
            S100LabelG8.ForeColor = Color.Black
            S100labelpt8.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG8.Text = "C"
            S100LabelG8.ForeColor = Color.Black
            S100labelpt8.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG8.Text = "B"
            S100LabelG8.ForeColor = Color.Black
            S100labelpt8.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG8.Text = "A"
            S100LabelG8.ForeColor = Color.Black
            S100labelpt8.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
    Private Sub S100ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN9.Click
        S100ComboBoxCN9.Items.Clear()
        Call s100hope()
        For i = 0 To S100ListBoxhopecode.Items.Count - 1
            Dim onyii As String
            onyii = S100ListBoxhopecode.Items(i).ToString
            S100ComboBoxCN9.Items.Add(onyii)
        Next
    End Sub
    Private Sub S100ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN9.SelectedIndexChanged
        Dim course As String
        course = S100ComboBoxCN9.SelectedItem.ToString
        S100ButtonCN9.Text = course
        For i = 0 To S100ListBoxCourseCode.Items.Count - 1
            If course = S100ListBoxCourseCode.Items(i).ToString Then
                S100LabelCN9.Text = S100ListBoxCourseName.Items(i).ToString
                S100LabelCU9.Text = S100ListBoxCreditCode.Items(i).ToString
            End If
        Next
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        If Val(y100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S100LabelCU9.Text = "-"
            S100LabelCN9.Text = "-"
            S100LabelQP9.Text = "-"
            S100TextboxCN9.Enabled = False
            S100LabelG9.Text = "-"
            S100ButtonCN9.Text = "-"
        Else
            S100TextboxCN9.Enabled = True
            Call S100oleku()
        End If
        Dim alako As Integer = Val(S100ListBoxhopecode.Items.Count)
        If alako > 1 Then
            Call S100level9()
        Else
        End If
        Call S100TextBoxcn9_TextChanged(sender, e)
    End Sub
    Private Sub S100TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextboxCN9.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S100TextboxCN9.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S100TextboxCN9.Clear()
            End If
        Next
        Dim grade As Integer = Val(S100TextboxCN9.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S100LabelG9.Text = "F"
            S100LabelG9.ForeColor = Color.Red
            S100labelpt9.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S100LabelG9.Text = "E"
            S100LabelG9.ForeColor = Color.Black
            S100labelpt9.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S100LabelG9.Text = "D"
            S100LabelG9.ForeColor = Color.Black
            S100labelpt9.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S100LabelG9.Text = "C"
            S100LabelG9.ForeColor = Color.Black
            S100labelpt9.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S100LabelG9.Text = "B"
            S100LabelG9.ForeColor = Color.Black
            S100labelpt9.Text = "4"
        ElseIf (grade > 69) Then
            S100LabelG9.Text = "A"
            S100LabelG9.ForeColor = Color.Black
            S100labelpt9.Text = "5"
        End If
        Call S100TOtalcreditunit()
        Call S100TOtalqp()
        Call s100hope()
    End Sub
Private Sub S100ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN10.Click
S100ComboBoxCN10.Items.Clear()
Call s100hope()
For i = 0 To S100Listboxhopecode.Items.Count - 1
Dim onyii As String
onyii = S100Listboxhopecode.Items(i).ToString
S100ComboBoxCN10.Items.Add(onyii)
Next
End Sub
Private Sub S100ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN10.SelectedIndexChanged
Dim course As String
course = S100ComboBoxCN10.SelectedItem.ToString
S100ButtonCN10.Text = course
For i = 0 To S100ListBoxCourseCode.Items.Count - 1
If course = S100ListBoxCourseCode.Items(i).ToString Then
S100LabelCN10.Text = S100ListBoxCourseName.Items(i).ToString
S100LabelCU10.Text = S100LISTBOXCREDITCODE.Items(i).ToString
End If
Next
Call s100totalcreditunit()
Call s100totalqp()
If Val(y100TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S100LabelCU10.Text = "-"
S100LabelCN10.Text = "-"
S100LabelQP10.Text = "-"
S100TextBoxCN10.Enabled = False
S100LabelG10.Text = "-"
S100ButtonCN10.Text = "-"
Else
S100TextBoxCN1.Enabled = True
Call s100oleku()
End If
Dim alako As Integer = Val(S100Listboxhopecode.Items.Count)
If alako > 1 Then
Call S100level10()
Else
End If
Call S100TextBoxcn10_TextChanged(sender, e)
End Sub
Private Sub S100TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextBoxCN10.TextChanged
Dim onecharacter As Char
Dim name As String
name = S100TextBoxCN10.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S100TextBoxCN10.Clear()
End If
Next
Dim grade As Integer = Val(S100TextBoxCN10.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S100LabelG10.Text = "F"
S100LabelG10.ForeColor = Color.Red
S100labelpt10.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S100LabelG10.Text = "E"
S100LabelG10.ForeColor = Color.Black
S100labelpt10.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S100LabelG10.Text = "D"
S100LabelG10.ForeColor = Color.Black
S100labelpt10.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S100LabelG10.Text = "C"
S100LabelG10.ForeColor = Color.Black
S100labelpt10.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S100LabelG10.Text = "B"
S100LabelG10.ForeColor = Color.Black
S100labelpt10.Text = "4"
ElseIf (grade > 69) Then
S100LabelG10.Text = "A"
S100LabelG10.ForeColor = Color.Black
S100labelpt10.Text = "5"
End If
Call s100totalcreditunit()
Call s100totalqp()
Call s100hope()
End Sub
Private Sub S100ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN11.Click
S100ComboBoxCN11.Items.Clear()
Call s100hope()
For i = 0 To S100Listboxhopecode.Items.Count - 1
Dim onyii As String
onyii = S100Listboxhopecode.Items(i).ToString
S100ComboBoxCN11.Items.Add(onyii)
Next
End Sub
Private Sub S100ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN11.SelectedIndexChanged
Dim course As String
course = S100ComboBoxCN11.SelectedItem.ToString
S100ButtonCN11.Text = course
For i = 0 To S100ListBoxCourseCode.Items.Count - 1
If course = S100ListBoxCourseCode.Items(i).ToString Then
S100LabelCN11.Text = S100ListBoxCourseName.Items(i).ToString
S100LabelCU11.Text = S100LISTBOXCREDITCODE.Items(i).ToString
End If
Next
Call s100totalcreditunit()
Call s100totalqp()
If Val(y100TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S100LabelCU11.Text = "-"
S100LabelCN11.Text = "-"
S100LabelQP11.Text = "-"
S100TextBoxCN11.Enabled = False
S100LabelG11.Text = "-"
S100ButtonCN11.Text = "-"
Else
S100TextBoxCN11.Enabled = True
Call s100oleku()
End If
Dim alako As Integer = Val(S100Listboxhopecode.Items.Count)
If alako > 1 Then
Call S100level11()
Else
End If
Call S100TextBoxcn11_TextChanged(sender, e)
End Sub
Private Sub S100TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextBoxCN11.TextChanged
Dim onecharacter As Char
Dim name As String
name = S100TextBoxCN11.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S100TextBoxCN11.Clear()
End If
Next
Dim grade As Integer = Val(S100TextBoxCN11.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S100LabelG11.Text = "F"
S100LabelG11.ForeColor = Color.Red
S100labelpt11.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S100LabelG11.Text = "E"
S100LabelG11.ForeColor = Color.Black
S100labelpt11.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S100LabelG11.Text = "D"
S100LabelG11.ForeColor = Color.Black
S100labelpt11.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S100LabelG11.Text = "C"
S100LabelG11.ForeColor = Color.Black
S100labelpt11.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S100LabelG11.Text = "B"
S100LabelG11.ForeColor = Color.Black
S100labelpt11.Text = "4"
ElseIf (grade > 69) Then
S100LabelG11.Text = "A"
S100LabelG11.ForeColor = Color.Black
S100labelpt11.Text = "5"
End If
Call s100totalcreditunit()
Call s100totalqp()
Call s100hope()
End Sub
Private Sub S100ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN12.Click
S100ComboBoxCN12.Items.Clear()
Call s100hope()
For i = 0 To S100Listboxhopecode.Items.Count - 1
Dim onyii As String
onyii = S100Listboxhopecode.Items(i).ToString
S100ComboBoxCN12.Items.Add(onyii)
Next
End Sub
Private Sub S100ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN12.SelectedIndexChanged
Dim course As String
course = S100ComboBoxCN12.SelectedItem.ToString
S100ButtonCN12.Text = course
For i = 0 To S100ListBoxCourseCode.Items.Count - 1
If course = S100ListBoxCourseCode.Items(i).ToString Then
S100LabelCN12.Text = S100ListBoxCourseName.Items(i).ToString
S100LabelCU12.Text = S100LISTBOXCREDITCODE.Items(i).ToString
End If
Next
Call s100totalcreditunit()
Call s100totalqp()
If Val(y100TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S100LabelCU12.Text = "-"
S100LabelCN12.Text = "-"
S100LabelQP12.Text = "-"
S100TextBoxCN12.Enabled = False
S100LabelG12.Text = "-"
S100ButtonCN12.Text = "-"
Else
S100TextBoxCN12.Enabled = True
Call s100oleku()
End If
Dim alako As Integer = Val(S100Listboxhopecode.Items.Count)
If alako > 1 Then
Call S100level12()
Else
End If
Call S100TextBoxcn12_TextChanged(sender, e)
End Sub
Private Sub S100TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextBoxCN12.TextChanged
Dim onecharacter As Char
Dim name As String
name = S100TextBoxCN12.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S100TextBoxCN12.Clear()
End If
Next
Dim grade As Integer = Val(S100TextBoxCN12.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S100LabelG12.Text = "F"
S100LabelG12.ForeColor = Color.Red
S100labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S100LabelG12.Text = "E"
S100LabelG12.ForeColor = Color.Black
S100labelpt12.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S100LabelG12.Text = "D"
S100LabelG12.ForeColor = Color.Black
S100labelpt12.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S100LabelG12.Text = "C"
S100LabelG12.ForeColor = Color.Black
S100labelpt12.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S100LabelG12.Text = "B"
S100LabelG12.ForeColor = Color.Black
S100labelpt12.Text = "4"
ElseIf (grade > 69) Then
S100LabelG12.Text = "A"
S100LabelG12.ForeColor = Color.Black
S100labelpt12.Text = "5"
End If
Call s100totalcreditunit()
Call s100totalqp()
Call s100hope()
End Sub
Private Sub S100ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN13.Click
S100ComboBoxCN13.Items.Clear()
Call s100hope()
For i = 0 To S100Listboxhopecode.Items.Count - 1
Dim onyii As String
onyii = S100Listboxhopecode.Items(i).ToString
S100ComboBoxCN13.Items.Add(onyii)
Next
End Sub
Private Sub S100ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN13.SelectedIndexChanged
Dim course As String
course = S100ComboBoxCN13.SelectedItem.ToString
S100ButtonCN13.Text = course
For i = 0 To S100ListBoxCourseCode.Items.Count - 1
If course = S100ListBoxCourseCode.Items(i).ToString Then
S100LabelCN13.Text = S100ListBoxCourseName.Items(i).ToString
S100LabelCU13.Text = S100LISTBOXCREDITCODE.Items(i).ToString
End If
Next
Call s100totalcreditunit()
Call s100totalqp()
If Val(y100TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S100LabelCU13.Text = "-"
S100LabelCN13.Text = "-"
S100LabelQP13.Text = "-"
S100TextBoxCN13.Enabled = False
S100LabelG13.Text = "-"
S100ButtonCN13.Text = "-"
Else
S100TextBoxCN13.Enabled = True
Call s100oleku()
End If
Dim alako As Integer = Val(S100Listboxhopecode.Items.Count)
If alako > 1 Then
Call S100level13()
Else
End If
Call S100TextBoxcn13_TextChanged(sender, e)
End Sub
Private Sub S100TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextBoxCN13.TextChanged
Dim onecharacter As Char
Dim name As String
name = S100TextBoxCN13.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S100TextBoxCN13.Clear()
End If
Next
Dim grade As Integer = Val(S100TextBoxCN13.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S100LabelG13.Text = "F"
S100LabelG13.ForeColor = Color.Red
S100labelpt13.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S100LabelG13.Text = "E"
S100LabelG13.ForeColor = Color.Black
S100labelpt13.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S100LabelG13.Text = "D"
S100LabelG13.ForeColor = Color.Black
S100labelpt13.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S100LabelG13.Text = "C"
S100LabelG13.ForeColor = Color.Black
S100labelpt13.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S100LabelG13.Text = "B"
S100LabelG13.ForeColor = Color.Black
S100labelpt13.Text = "4"
ElseIf (grade > 69) Then
S100LabelG13.Text = "A"
S100LabelG13.ForeColor = Color.Black
S100labelpt13.Text = "5"
End If
Call s100totalcreditunit()
Call s100totalqp()
Call s100hope()
End Sub
Private Sub S100ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN14.Click
S100ComboBoxCN14.Items.Clear()
Call s100hope()
For i = 0 To S100Listboxhopecode.Items.Count - 1
Dim onyii As String
onyii = S100Listboxhopecode.Items(i).ToString
S100ComboBoxCN14.Items.Add(onyii)
Next
End Sub
Private Sub S100ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100ComboBoxCN14.SelectedIndexChanged
Dim course As String
course = S100ComboBoxCN14.SelectedItem.ToString
S100ButtonCN14.Text = course
For i = 0 To S100ListBoxCourseCode.Items.Count - 1
If course = S100ListBoxCourseCode.Items(i).ToString Then
S100LabelCN14.Text = S100ListBoxCourseName.Items(i).ToString
S100LabelCU14.Text = S100LISTBOXCREDITCODE.Items(i).ToString
End If
Next
Call s100totalcreditunit()
Call s100totalqp()
If Val(y100TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S100LabelCU14.Text = "-"
S100LabelCN14.Text = "-"
S100LabelQP14.Text = "-"
S100TextBoxCN14.Enabled = False
S100LabelG14.Text = "-"
S100ButtonCN14.Text = "-"
Else
S100TextBoxCN14.Enabled = True
Call s100oleku()
End If
Call S100TextBoxcn14_TextChanged(sender, e)
End Sub
Private Sub S100TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S100TextBoxCN14.TextChanged
Dim onecharacter As Char
Dim name As String
name = S100TextBoxCN14.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S100TextBoxCN14.Clear()
End If
Next
Dim grade As Integer = Val(S100TextBoxCN14.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S100LabelG14.Text = "F"
S100LabelG14.ForeColor = Color.Red
S100labelpt14.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S100LabelG14.Text = "E"
S100LabelG14.ForeColor = Color.Black
S100labelpt14.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S100LabelG14.Text = "D"
S100LabelG14.ForeColor = Color.Black
S100labelpt14.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S100LabelG14.Text = "C"
S100LabelG14.ForeColor = Color.Black
S100labelpt14.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S100LabelG14.Text = "B"
S100LabelG14.ForeColor = Color.Black
S100labelpt14.Text = "4"
ElseIf (grade > 69) Then
S100LabelG14.Text = "A"
S100LabelG14.ForeColor = Color.Black
S100labelpt14.Text = "5"
End If
Call s100totalcreditunit()
Call s100totalqp()
Call s100hope()
End Sub
's200 comboxes and textboxexs
    Private Sub S200ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboboxCN1.Click
        S200ComboboxCN1.Items.Clear()
        Call s200hope()
        For i = 0 To S200ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = S200ListboxhopeCode.Items(i).ToString
            S200ComboboxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub S200ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboboxCN1.SelectedIndexChanged
        Dim course As String
        course = S200ComboboxCN1.SelectedItem.ToString
        S200buttonCN1.Text = course
        For i = 0 To S200ListboxCourseCode.Items.Count - 1
            If course = S200ListboxCourseCode.Items(i).ToString Then
                S200LabelCN1.Text = S200ListboxCourseName.Items(i).ToString
                S200LabelCU1.Text = S200ListboxCreditunit.Items(i).ToString
            End If
        Next
        Call S200TOtalcreditunit()
        Call S200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S200LabelCU1.Text = "-"
            S200LabelCN1.Text = "-"
            S200LabelQP1.Text = "-"
            S200TextBoxCN1.Enabled = False
            S200LabelG1.Text = "-"
            S200buttonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S200TextBoxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(S200ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call S200level1()
        Else
        End If
        Call S200TextBoxcn1_TextChanged(sender, e)
    End Sub
    Private Sub S200TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S200TextBoxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S200TextBoxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(S200TextBoxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S200LabelG1.Text = "F"
            S200LabelG1.ForeColor = Color.Red
            S200labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S200LabelG1.Text = "E"
            S200LabelG1.ForeColor = Color.Black
            S200labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S200LabelG1.Text = "D"
            S200LabelG1.ForeColor = Color.Black
            S200labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S200LabelG1.Text = "C"
            S200LabelG1.ForeColor = Color.Black
            S200labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S200LabelG1.Text = "B"
            S200LabelG1.ForeColor = Color.Black
            S200labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            S200LabelG1.Text = "A"
            S200LabelG1.ForeColor = Color.Black
            S200labelpt1.Text = "5"
        End If
        Call S200TOtalcreditunit()
        Call S200TOtalqp()
        Call s200hope()
    End Sub
    Private Sub S200ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboboxCN2.Click
        S200ComboboxCN2.Items.Clear()
        Call s200hope()
        For i = 0 To S200ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = S200ListboxhopeCode.Items(i).ToString
            S200ComboboxCN2.Items.Add(onyii)
        Next
    End Sub
    Private Sub S200ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboboxCN2.SelectedIndexChanged
        Dim course As String
        course = S200ComboboxCN2.SelectedItem.ToString
        S200buttonCN2.Text = course
        For i = 0 To S200ListboxCourseCode.Items.Count - 1
            If course = S200ListboxCourseCode.Items(i).ToString Then
                S200LabelCN2.Text = S200ListboxCourseName.Items(i).ToString
                S200LabelCU2.Text = S200ListboxCreditunit.Items(i).ToString
            End If
        Next
        Call S200TOtalcreditunit()
        Call S200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S200LabelCU2.Text = "-"
            S200LabelCN2.Text = "-"
            S200LabelQP2.Text = "-"
            S200TextBoxCN2.Enabled = False
            S200LabelG2.Text = "-"
            S200buttonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S200TextBoxCN2.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(S200ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call S200level2()
        Else
        End If
        Call S200TextBoxcn2_TextChanged(sender, e)
    End Sub
    Private Sub S200TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN2.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S200TextBoxCN2.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S200TextBoxCN2.Clear()
            End If
        Next
        Dim grade As Integer = Val(S200TextBoxCN2.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S200LabelG2.Text = "F"
            S200LabelG2.ForeColor = Color.Red
            S200labelpt2.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S200LabelG2.Text = "E"
            S200LabelG2.ForeColor = Color.Black
            S200labelpt2.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S200LabelG2.Text = "D"
            S200LabelG2.ForeColor = Color.Black
            S200labelpt2.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S200LabelG2.Text = "C"
            S200LabelG2.ForeColor = Color.Black
            S200labelpt2.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S200LabelG2.Text = "B"
            S200LabelG2.ForeColor = Color.Black
            S200labelpt2.Text = "4"
        ElseIf (grade > 69) Then
            S200LabelG2.Text = "A"
            S200LabelG2.ForeColor = Color.Black
            S200labelpt2.Text = "5"
        End If
        Call S200TOtalcreditunit()
        Call S200TOtalqp()
        Call s200hope()
    End Sub
    Private Sub S200ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboboxCN3.Click
        S200ComboboxCN3.Items.Clear()
        Call s200hope()
        For i = 0 To S200ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = S200ListboxhopeCode.Items(i).ToString
            S200ComboboxCN3.Items.Add(onyii)
        Next
    End Sub
    Private Sub S200ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboboxCN3.SelectedIndexChanged
        Dim course As String
        course = S200ComboboxCN3.SelectedItem.ToString
        S200buttonCN3.Text = course
        For i = 0 To S200ListboxCourseCode.Items.Count - 1
            If course = S200ListboxCourseCode.Items(i).ToString Then
                S200LabelCN3.Text = S200ListboxCourseName.Items(i).ToString
                S200LabelCU3.Text = S200ListboxCreditunit.Items(i).ToString
            End If
        Next
        Call S200TOtalcreditunit()
        Call S200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S200LabelCU3.Text = "-"
            S200LabelCN3.Text = "-"
            S200LabelQP3.Text = "-"
            S200TextBoxCN3.Enabled = False
            S200LabelG3.Text = "-"
            S200buttonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S200TextBoxCN3.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(S200ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call S200level3()
        Else
        End If
        Call S200TextBoxcn3_TextChanged(sender, e)
    End Sub
Private Sub S200TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN3.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN3.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN3.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN3.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG3.Text = "F"
S200LabelG3.ForeColor = Color.Red
S200labelpt3.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG3.Text = "E"
S200LabelG3.ForeColor = Color.Black
S200labelpt3.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG3.Text = "D"
S200LabelG3.ForeColor = Color.Black
S200labelpt3.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG3.Text = "C"
S200LabelG3.ForeColor = Color.Black
S200labelpt3.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG3.Text = "B"
S200LabelG3.ForeColor = Color.Black
S200labelpt3.Text = "4"
ElseIf (grade > 69) Then
S200LabelG3.Text = "A"
S200LabelG3.ForeColor = Color.Black
S200labelpt3.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN4.Click
S200ComboBoxCN4.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN4.Items.Add(onyii)
Next
End Sub
    Private Sub S200ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboboxCN4.SelectedIndexChanged
        Dim course As String
        course = S200ComboboxCN4.SelectedItem.ToString
        S200buttonCN4.Text = course
        For i = 0 To S200ListboxCourseCode.Items.Count - 1
            If course = S200ListboxCourseCode.Items(i).ToString Then
                S200LabelCN4.Text = S200ListboxCourseName.Items(i).ToString
                S200LabelCU4.Text = S200ListboxCreditunit.Items(i).ToString
            End If
        Next
        Call S200TOtalcreditunit()
        Call S200TOtalqp()
        If Val(y200TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S200LabelCU4.Text = "-"
            S200LabelCN4.Text = "-"
            S200LabelQP4.Text = "-"
            S200TextBoxCN4.Enabled = False
            S200LabelG4.Text = "-"
            S200buttonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S200TextBoxCN4.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(S200ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call S200level4()
        Else
        End If
        Call S200TextBoxcn4_TextChanged(sender, e)
    End Sub
Private Sub S200TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN4.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN4.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN4.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN4.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG4.Text = "F"
S200LabelG4.ForeColor = Color.Red
S200labelpt4.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG4.Text = "E"
S200LabelG4.ForeColor = Color.Black
S200labelpt4.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG4.Text = "D"
S200LabelG4.ForeColor = Color.Black
S200labelpt4.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG4.Text = "C"
S200LabelG4.ForeColor = Color.Black
S200labelpt4.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG4.Text = "B"
S200LabelG4.ForeColor = Color.Black
S200labelpt4.Text = "4"
ElseIf (grade > 69) Then
S200LabelG4.Text = "A"
S200LabelG4.ForeColor = Color.Black
S200labelpt4.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN5.Click
S200ComboBoxCN5.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN5.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN5.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN5.SelectedItem.ToString
S200ButtonCN5.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN5.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU5.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU5.Text = "-"
S200LabelCN5.Text = "-"
S200LabelQP5.Text = "-"
S200TextBoxCN5.Enabled = False
S200LabelG5.Text = "-"
            S200buttonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN5.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level5()
Else
End If
Call S200TextBoxcn5_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN5.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN5.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN5.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN5.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG5.Text = "F"
S200LabelG5.ForeColor = Color.Red
S200labelpt5.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG5.Text = "E"
S200LabelG5.ForeColor = Color.Black
S200labelpt5.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG5.Text = "D"
S200LabelG5.ForeColor = Color.Black
S200labelpt5.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG5.Text = "C"
S200LabelG5.ForeColor = Color.Black
S200labelpt5.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG5.Text = "B"
S200LabelG5.ForeColor = Color.Black
S200labelpt5.Text = "4"
ElseIf (grade > 69) Then
S200LabelG5.Text = "A"
S200LabelG5.ForeColor = Color.Black
S200labelpt5.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN6.Click
S200ComboBoxCN6.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN6.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN6.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN6.SelectedItem.ToString
S200ButtonCN6.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN6.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU6.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU6.Text = "-"
S200LabelCN6.Text = "-"
S200LabelQP6.Text = "-"
S200TextBoxCN6.Enabled = False
S200LabelG6.Text = "-"
            S200buttonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN6.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level6()
Else
End If
Call S200TextBoxcn6_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN6.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN6.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN6.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN6.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG6.Text = "F"
S200LabelG6.ForeColor = Color.Red
S200labelpt6.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG6.Text = "E"
S200LabelG6.ForeColor = Color.Black
S200labelpt6.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG6.Text = "D"
S200LabelG6.ForeColor = Color.Black
S200labelpt6.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG6.Text = "C"
S200LabelG6.ForeColor = Color.Black
S200labelpt6.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG6.Text = "B"
S200LabelG6.ForeColor = Color.Black
S200labelpt6.Text = "4"
ElseIf (grade > 69) Then
S200LabelG6.Text = "A"
S200LabelG6.ForeColor = Color.Black
S200labelpt6.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN7.Click
S200ComboBoxCN7.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN7.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN7.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN7.SelectedItem.ToString
S200ButtonCN7.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN7.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU7.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU7.Text = "-"
S200LabelCN7.Text = "-"
S200LabelQP7.Text = "-"
S200TextBoxCN7.Enabled = False
S200LabelG7.Text = "-"
            S200buttonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN7.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level7()
Else
End If
Call S200TextBoxcn7_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN7.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN7.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN7.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN7.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG7.Text = "F"
S200LabelG7.ForeColor = Color.Red
S200labelpt7.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG7.Text = "E"
S200LabelG7.ForeColor = Color.Black
S200labelpt7.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG7.Text = "D"
S200LabelG7.ForeColor = Color.Black
S200labelpt7.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG7.Text = "C"
S200LabelG7.ForeColor = Color.Black
S200labelpt7.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG7.Text = "B"
S200LabelG7.ForeColor = Color.Black
S200labelpt7.Text = "4"
ElseIf (grade > 69) Then
S200LabelG7.Text = "A"
S200LabelG7.ForeColor = Color.Black
S200labelpt7.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN8.Click
S200ComboBoxCN8.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN8.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN8.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN8.SelectedItem.ToString
S200ButtonCN8.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN8.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU8.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU8.Text = "-"
S200LabelCN8.Text = "-"
S200LabelQP8.Text = "-"
S200TextBoxCN8.Enabled = False
S200LabelG8.Text = "-"
            S200buttonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN8.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level8()
Else
End If
Call S200TextBoxcn8_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN8.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN8.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN8.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN8.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG8.Text = "F"
S200LabelG8.ForeColor = Color.Red
S200labelpt8.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG8.Text = "E"
S200LabelG8.ForeColor = Color.Black
S200labelpt8.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG8.Text = "D"
S200LabelG8.ForeColor = Color.Black
S200labelpt8.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG8.Text = "C"
S200LabelG8.ForeColor = Color.Black
S200labelpt8.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG8.Text = "B"
S200LabelG8.ForeColor = Color.Black
S200labelpt8.Text = "4"
ElseIf (grade > 69) Then
S200LabelG8.Text = "A"
S200LabelG8.ForeColor = Color.Black
S200labelpt8.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN9.Click
S200ComboBoxCN9.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN9.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN9.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN9.SelectedItem.ToString
S200ButtonCN9.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN9.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU9.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU9.Text = "-"
S200LabelCN9.Text = "-"
S200LabelQP9.Text = "-"
S200TextBoxCN9.Enabled = False
S200LabelG9.Text = "-"
            S200buttonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN9.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level9()
Else
End If
Call S200TextBoxcn9_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN9.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN9.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN9.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN9.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG9.Text = "F"
S200LabelG9.ForeColor = Color.Red
S200labelpt9.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG9.Text = "E"
S200LabelG9.ForeColor = Color.Black
S200labelpt9.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG9.Text = "D"
S200LabelG9.ForeColor = Color.Black
S200labelpt9.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG9.Text = "C"
S200LabelG9.ForeColor = Color.Black
S200labelpt9.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG9.Text = "B"
S200LabelG9.ForeColor = Color.Black
S200labelpt9.Text = "4"
ElseIf (grade > 69) Then
S200LabelG9.Text = "A"
S200LabelG9.ForeColor = Color.Black
S200labelpt9.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN10.Click
S200ComboBoxCN10.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN10.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN10.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN10.SelectedItem.ToString
S200buttonc10.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN10.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU10.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU10.Text = "-"
S200LabelCN10.Text = "-"
S200LabelQP10.Text = "-"
S200TextBoxCN10.Enabled = False
S200LabelG10.Text = "-"
            S200buttonC10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN1.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level10()
Else
End If
Call S200TextBoxcn10_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN10.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN10.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN10.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN10.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG10.Text = "F"
S200LabelG10.ForeColor = Color.Red
S200labelpt10.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG10.Text = "E"
S200LabelG10.ForeColor = Color.Black
S200labelpt10.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG10.Text = "D"
S200LabelG10.ForeColor = Color.Black
S200labelpt10.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG10.Text = "C"
S200LabelG10.ForeColor = Color.Black
S200labelpt10.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG10.Text = "B"
S200LabelG10.ForeColor = Color.Black
S200labelpt10.Text = "4"
ElseIf (grade > 69) Then
S200LabelG10.Text = "A"
S200LabelG10.ForeColor = Color.Black
S200labelpt10.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN11.Click
S200ComboBoxCN11.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN11.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN11.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN11.SelectedItem.ToString
S200ButtonCN11.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN11.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU11.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU11.Text = "-"
S200LabelCN11.Text = "-"
S200LabelQP11.Text = "-"
S200TextBoxCN11.Enabled = False
S200LabelG11.Text = "-"
            S200buttonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN11.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level11()
Else
End If
Call S200TextBoxcn11_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN11.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN11.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN11.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN11.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG11.Text = "F"
S200LabelG11.ForeColor = Color.Red
S200labelpt11.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG11.Text = "E"
S200LabelG11.ForeColor = Color.Black
S200labelpt11.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG11.Text = "D"
S200LabelG11.ForeColor = Color.Black
S200labelpt11.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG11.Text = "C"
S200LabelG11.ForeColor = Color.Black
S200labelpt11.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG11.Text = "B"
S200LabelG11.ForeColor = Color.Black
S200labelpt11.Text = "4"
ElseIf (grade > 69) Then
S200LabelG11.Text = "A"
S200LabelG11.ForeColor = Color.Black
S200labelpt11.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN12.Click
S200ComboBoxCN12.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN12.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN12.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN12.SelectedItem.ToString
S200ButtonCN12.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN12.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU12.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU12.Text = "-"
S200LabelCN12.Text = "-"
S200LabelQP12.Text = "-"
S200TextBoxCN12.Enabled = False
S200LabelG12.Text = "-"
            S200buttonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN12.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level12()
Else
End If
Call S200TextBoxcn12_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN12.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN12.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN12.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN12.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG12.Text = "F"
S200LabelG12.ForeColor = Color.Red
S200labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG12.Text = "E"
S200LabelG12.ForeColor = Color.Black
S200labelpt12.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG12.Text = "D"
S200LabelG12.ForeColor = Color.Black
S200labelpt12.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG12.Text = "C"
S200LabelG12.ForeColor = Color.Black
S200labelpt12.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG12.Text = "B"
S200LabelG12.ForeColor = Color.Black
S200labelpt12.Text = "4"
ElseIf (grade > 69) Then
S200LabelG12.Text = "A"
S200LabelG12.ForeColor = Color.Black
S200labelpt12.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN13.Click
S200ComboBoxCN13.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN13.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN13.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN13.SelectedItem.ToString
S200ButtonCN13.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN13.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU13.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU13.Text = "-"
S200LabelCN13.Text = "-"
S200LabelQP13.Text = "-"
S200TextBoxCN13.Enabled = False
S200LabelG13.Text = "-"
            S200buttonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN13.Enabled = True
Call oleku()
End If
Dim alako As Integer = Val(S200ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S200level13()
Else
End If
Call S200TextBoxcn13_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN13.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN13.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN13.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN13.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG13.Text = "F"
S200LabelG13.ForeColor = Color.Red
S200labelpt13.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG13.Text = "E"
S200LabelG13.ForeColor = Color.Black
S200labelpt13.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG13.Text = "D"
S200LabelG13.ForeColor = Color.Black
S200labelpt13.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG13.Text = "C"
S200LabelG13.ForeColor = Color.Black
S200labelpt13.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG13.Text = "B"
S200LabelG13.ForeColor = Color.Black
S200labelpt13.Text = "4"
ElseIf (grade > 69) Then
S200LabelG13.Text = "A"
S200LabelG13.ForeColor = Color.Black
S200labelpt13.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
Private Sub S200ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN14.Click
S200ComboBoxCN14.Items.Clear()
Call s200hope()
For i = 0 To S200ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S200ListBoxHopecode.Items(i).ToString
S200ComboBoxCN14.Items.Add(onyii)
Next
End Sub
Private Sub S200ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200ComboBoxCN14.SelectedIndexChanged
Dim course As String
course = S200ComboBoxCN14.SelectedItem.ToString
S200ButtonCN14.Text = course
For i = 0 To S200ListBoxCourseCode.Items.Count - 1
If course = S200ListBoxCourseCode.Items(i).ToString Then
S200LabelCN14.Text = S200ListBoxCourseName.Items(i).ToString
S200LabelCU14.Text = S200ListBoxCreditUnit.Items(i).ToString
End If
Next
Call s200totalcreditunit()
Call s200totalqp()
If Val(y200TOTALCUlabel.Text) > maxim Then
MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
S200LabelCU14.Text = "-"
S200LabelCN14.Text = "-"
S200LabelQP14.Text = "-"
S200TextBoxCN14.Enabled = False
S200LabelG14.Text = "-"
            S200buttonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
Else
S200TextBoxCN14.Enabled = True
Call oleku()
End If
Call S200TextBoxcn14_TextChanged(sender, e)
End Sub
Private Sub S200TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S200TextBoxCN14.TextChanged
Dim onecharacter As Char
Dim name As String
name = S200TextBoxCN14.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S200TextBoxCN14.Clear()
End If
Next
Dim grade As Integer = Val(S200TextBoxCN14.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S200LabelG14.Text = "F"
S200LabelG14.ForeColor = Color.Red
S200labelpt14.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S200LabelG14.Text = "E"
S200LabelG14.ForeColor = Color.Black
S200labelpt14.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S200LabelG14.Text = "D"
S200LabelG14.ForeColor = Color.Black
S200labelpt14.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S200LabelG14.Text = "C"
S200LabelG14.ForeColor = Color.Black
S200labelpt14.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S200LabelG14.Text = "B"
S200LabelG14.ForeColor = Color.Black
S200labelpt14.Text = "4"
ElseIf (grade > 69) Then
S200LabelG14.Text = "A"
S200LabelG14.ForeColor = Color.Black
S200labelpt14.Text = "5"
End If
Call s200totalcreditunit()
Call s200totalqp()
Call s200hope()
End Sub
's300 comboxes and textboxexs
    Private Sub S300ComboboxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboboxCN1.Click
        S300ComboboxCN1.Items.Clear()
        Call hope()
        For i = 0 To S300ListboxhopeCode.Items.Count - 1
            Dim onyii As String
            onyii = S300ListboxhopeCode.Items(i).ToString
            S300ComboboxCN1.Items.Add(onyii)
        Next
    End Sub
    Private Sub S300TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextboxCN1.TextChanged
        Dim onecharacter As Char
        Dim name As String
        name = S300TextboxCN1.Text
        For i = 0 To name.Length - 1
            onecharacter = name.Chars(i)
            If IsNumeric(onecharacter) = False Then
                S300TextboxCN1.Clear()
            End If
        Next
        Dim grade As Integer = Val(S300TextboxCN1.Text)
        If grade < 0 Then
            MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
        ElseIf (grade > -1) And (grade < 40) Then
            S300LabelG1.Text = "F"
            S300LabelG1.ForeColor = Color.Red
            S300labelpt1.Text = "0"
        ElseIf (grade > 39) And (grade < 45) Then
            S300LabelG1.Text = "E"
            S300LabelG1.ForeColor = Color.Black
            S300labelpt1.Text = "1"
        ElseIf (grade > 44) And (grade < 50) Then
            S300LabelG1.Text = "D"
            S300LabelG1.ForeColor = Color.Black
            S300labelpt1.Text = "2"
        ElseIf (grade > 49) And (grade < 60) Then
            S300LabelG1.Text = "C"
            S300LabelG1.ForeColor = Color.Black
            S300labelpt1.Text = "3"
        ElseIf (grade > 59) And (grade < 70) Then
            S300LabelG1.Text = "B"
            S300LabelG1.ForeColor = Color.Black
            S300labelpt1.Text = "4"
        ElseIf (grade > 69) Then
            S300LabelG1.Text = "A"
            S300LabelG1.ForeColor = Color.Black
            S300labelpt1.Text = "5"
        End If
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
Private Sub S300ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN2.Click
S300ComboBoxCN2.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN2.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN2.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN2.SelectedItem.ToString
S300ButtonCN2.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN2.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU2.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU2.Text = "-"
            S300LabelCN2.Text = "-"
            S300LabelQP2.Text = "-"
            S300TextboxCN2.Enabled = False
            S300LabelG2.Text = "-"
            S300ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN2.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level2()
Else
End If
Call S300TextBoxcn2_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN2.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN2.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN2.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN2.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG2.Text = "F"
S300LabelG2.ForeColor = Color.Red
S300labelpt2.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG2.Text = "E"
S300LabelG2.ForeColor = Color.Black
S300labelpt2.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG2.Text = "D"
S300LabelG2.ForeColor = Color.Black
S300labelpt2.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG2.Text = "C"
S300LabelG2.ForeColor = Color.Black
S300labelpt2.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG2.Text = "B"
S300LabelG2.ForeColor = Color.Black
S300labelpt2.Text = "4"
ElseIf (grade > 69) Then
S300LabelG2.Text = "A"
S300LabelG2.ForeColor = Color.Black
S300labelpt2.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN3.Click
S300ComboBoxCN3.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN3.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN3.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN3.SelectedItem.ToString
S300ButtonCN3.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN3.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU3.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU3.Text = "-"
            S300LabelCN3.Text = "-"
            S300LabelQP3.Text = "-"
            S300TextboxCN3.Enabled = False
            S300LabelG3.Text = "-"
            S300ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN3.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level3()
Else
End If
Call S300TextBoxcn3_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN3.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN3.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN3.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN3.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG3.Text = "F"
S300LabelG3.ForeColor = Color.Red
S300labelpt3.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG3.Text = "E"
S300LabelG3.ForeColor = Color.Black
S300labelpt3.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG3.Text = "D"
S300LabelG3.ForeColor = Color.Black
S300labelpt3.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG3.Text = "C"
S300LabelG3.ForeColor = Color.Black
S300labelpt3.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG3.Text = "B"
S300LabelG3.ForeColor = Color.Black
S300labelpt3.Text = "4"
ElseIf (grade > 69) Then
S300LabelG3.Text = "A"
S300LabelG3.ForeColor = Color.Black
S300labelpt3.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN4.Click
S300ComboBoxCN4.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN4.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN4.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN4.SelectedItem.ToString
S300ButtonCN4.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN4.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU4.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU4.Text = "-"
            S300LabelCN4.Text = "-"
            S300LabelQP4.Text = "-"
            S300TextboxCN4.Enabled = False
            S300LabelG4.Text = "-"
            S300ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN4.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level4()
Else
End If
Call S300TextBoxcn4_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN4.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN4.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN4.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN4.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG4.Text = "F"
S300LabelG4.ForeColor = Color.Red
S300labelpt4.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG4.Text = "E"
S300LabelG4.ForeColor = Color.Black
S300labelpt4.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG4.Text = "D"
S300LabelG4.ForeColor = Color.Black
S300labelpt4.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG4.Text = "C"
S300LabelG4.ForeColor = Color.Black
S300labelpt4.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG4.Text = "B"
S300LabelG4.ForeColor = Color.Black
S300labelpt4.Text = "4"
ElseIf (grade > 69) Then
S300LabelG4.Text = "A"
S300LabelG4.ForeColor = Color.Black
S300labelpt4.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN5.Click
S300ComboBoxCN5.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN5.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN5.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN5.SelectedItem.ToString
S300ButtonCN5.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN5.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU5.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU5.Text = "-"
            S300LabelCN5.Text = "-"
            S300LabelQP5.Text = "-"
            S300TextboxCN5.Enabled = False
            S300LabelG5.Text = "-"
            S300ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN5.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level5()
Else
End If
Call S300TextBoxcn5_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN5.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN5.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN5.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN5.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG5.Text = "F"
S300LabelG5.ForeColor = Color.Red
S300labelpt5.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG5.Text = "E"
S300LabelG5.ForeColor = Color.Black
S300labelpt5.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG5.Text = "D"
S300LabelG5.ForeColor = Color.Black
S300labelpt5.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG5.Text = "C"
S300LabelG5.ForeColor = Color.Black
S300labelpt5.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG5.Text = "B"
S300LabelG5.ForeColor = Color.Black
S300labelpt5.Text = "4"
ElseIf (grade > 69) Then
S300LabelG5.Text = "A"
S300LabelG5.ForeColor = Color.Black
S300labelpt5.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN6.Click
S300ComboBoxCN6.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN6.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN6.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN6.SelectedItem.ToString
S300ButtonCN6.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN6.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU6.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU6.Text = "-"
            S300LabelCN6.Text = "-"
            S300LabelQP6.Text = "-"
            S300TextboxCN6.Enabled = False
            S300LabelG6.Text = "-"
            S300ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN6.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level6()
Else
End If
Call S300TextBoxcn6_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN6.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN6.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN6.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN6.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG6.Text = "F"
S300LabelG6.ForeColor = Color.Red
S300labelpt6.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG6.Text = "E"
S300LabelG6.ForeColor = Color.Black
S300labelpt6.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG6.Text = "D"
S300LabelG6.ForeColor = Color.Black
S300labelpt6.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG6.Text = "C"
S300LabelG6.ForeColor = Color.Black
S300labelpt6.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG6.Text = "B"
S300LabelG6.ForeColor = Color.Black
S300labelpt6.Text = "4"
ElseIf (grade > 69) Then
S300LabelG6.Text = "A"
S300LabelG6.ForeColor = Color.Black
S300labelpt6.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN7.Click
S300ComboBoxCN7.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN7.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN7.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN7.SelectedItem.ToString
S300ButtonCN7.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN7.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU7.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU7.Text = "-"
            S300LabelCN7.Text = "-"
            S300LabelQP7.Text = "-"
            S300TextboxCN7.Enabled = False
            S300LabelG7.Text = "-"
            S300ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN7.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level7()
Else
End If
Call S300TextBoxcn7_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN7.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN7.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN7.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN7.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG7.Text = "F"
S300LabelG7.ForeColor = Color.Red
S300labelpt7.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG7.Text = "E"
S300LabelG7.ForeColor = Color.Black
S300labelpt7.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG7.Text = "D"
S300LabelG7.ForeColor = Color.Black
S300labelpt7.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG7.Text = "C"
S300LabelG7.ForeColor = Color.Black
S300labelpt7.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG7.Text = "B"
S300LabelG7.ForeColor = Color.Black
S300labelpt7.Text = "4"
ElseIf (grade > 69) Then
S300LabelG7.Text = "A"
S300LabelG7.ForeColor = Color.Black
S300labelpt7.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN8.Click
S300ComboBoxCN8.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN8.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN8.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN8.SelectedItem.ToString
S300ButtonCN8.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN8.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU8.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU8.Text = "-"
            S300LabelCN8.Text = "-"
            S300LabelQP8.Text = "-"
            S300TextboxCN8.Enabled = False
            S300LabelG8.Text = "-"
            S300ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN8.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level8()
Else
End If
Call S300TextBoxcn8_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN8.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN8.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN8.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN8.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG8.Text = "F"
S300LabelG8.ForeColor = Color.Red
S300labelpt8.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG8.Text = "E"
S300LabelG8.ForeColor = Color.Black
S300labelpt8.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG8.Text = "D"
S300LabelG8.ForeColor = Color.Black
S300labelpt8.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG8.Text = "C"
S300LabelG8.ForeColor = Color.Black
S300labelpt8.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG8.Text = "B"
S300LabelG8.ForeColor = Color.Black
S300labelpt8.Text = "4"
ElseIf (grade > 69) Then
S300LabelG8.Text = "A"
S300LabelG8.ForeColor = Color.Black
S300labelpt8.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN9.Click
S300ComboBoxCN9.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN9.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN9.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN9.SelectedItem.ToString
S300ButtonCN9.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN9.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU9.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU9.Text = "-"
            S300LabelCN9.Text = "-"
            S300LabelQP9.Text = "-"
            S300TextboxCN9.Enabled = False
            S300LabelG9.Text = "-"
            S300ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN9.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level9()
Else
End If
Call S300TextBoxcn9_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN9.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN9.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN9.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN9.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG9.Text = "F"
S300LabelG9.ForeColor = Color.Red
S300labelpt9.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG9.Text = "E"
S300LabelG9.ForeColor = Color.Black
S300labelpt9.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG9.Text = "D"
S300LabelG9.ForeColor = Color.Black
S300labelpt9.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG9.Text = "C"
S300LabelG9.ForeColor = Color.Black
S300labelpt9.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG9.Text = "B"
S300LabelG9.ForeColor = Color.Black
S300labelpt9.Text = "4"
ElseIf (grade > 69) Then
S300LabelG9.Text = "A"
S300LabelG9.ForeColor = Color.Black
S300labelpt9.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN10.Click
S300ComboBoxCN10.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN10.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN10.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN10.SelectedItem.ToString
S300ButtonCN10.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN10.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU10.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU10.Text = "-"
            S300LabelCN10.Text = "-"
            S300LabelQP10.Text = "-"
            S300TextboxCN10.Enabled = False
            S300LabelG10.Text = "-"
            S300ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN1.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level10()
Else
End If
Call S300TextBoxcn10_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN10.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN10.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN10.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN10.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG10.Text = "F"
S300LabelG10.ForeColor = Color.Red
S300labelpt10.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG10.Text = "E"
S300LabelG10.ForeColor = Color.Black
S300labelpt10.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG10.Text = "D"
S300LabelG10.ForeColor = Color.Black
S300labelpt10.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG10.Text = "C"
S300LabelG10.ForeColor = Color.Black
S300labelpt10.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG10.Text = "B"
S300LabelG10.ForeColor = Color.Black
S300labelpt10.Text = "4"
ElseIf (grade > 69) Then
S300LabelG10.Text = "A"
S300LabelG10.ForeColor = Color.Black
S300labelpt10.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN11.Click
S300ComboBoxCN11.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN11.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN11.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN11.SelectedItem.ToString
S300ButtonCN11.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN11.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU11.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU11.Text = "-"
            S300LabelCN11.Text = "-"
            S300LabelQP11.Text = "-"
            S300TextboxCN11.Enabled = False
            S300LabelG11.Text = "-"
            S300ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN11.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level11()
Else
End If
Call S300TextBoxcn11_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN11.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN11.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN11.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN11.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG11.Text = "F"
S300LabelG11.ForeColor = Color.Red
S300labelpt11.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG11.Text = "E"
S300LabelG11.ForeColor = Color.Black
S300labelpt11.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG11.Text = "D"
S300LabelG11.ForeColor = Color.Black
S300labelpt11.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG11.Text = "C"
S300LabelG11.ForeColor = Color.Black
S300labelpt11.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG11.Text = "B"
S300LabelG11.ForeColor = Color.Black
S300labelpt11.Text = "4"
ElseIf (grade > 69) Then
S300LabelG11.Text = "A"
S300LabelG11.ForeColor = Color.Black
S300labelpt11.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN12.Click
S300ComboBoxCN12.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN12.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN12.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN12.SelectedItem.ToString
S300ButtonCN12.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN12.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU12.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU12.Text = "-"
            S300LabelCN12.Text = "-"
            S300LabelQP12.Text = "-"
            S300TextboxCN12.Enabled = False
            S300LabelG12.Text = "-"
            S300ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN12.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level12()
Else
End If
Call S300TextBoxcn12_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN12.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN12.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN12.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN12.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG12.Text = "F"
S300LabelG12.ForeColor = Color.Red
S300labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG12.Text = "E"
S300LabelG12.ForeColor = Color.Black
S300labelpt12.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG12.Text = "D"
S300LabelG12.ForeColor = Color.Black
S300labelpt12.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG12.Text = "C"
S300LabelG12.ForeColor = Color.Black
S300labelpt12.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG12.Text = "B"
S300LabelG12.ForeColor = Color.Black
S300labelpt12.Text = "4"
ElseIf (grade > 69) Then
S300LabelG12.Text = "A"
S300LabelG12.ForeColor = Color.Black
S300labelpt12.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN13.Click
S300ComboBoxCN13.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN13.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN13.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN13.SelectedItem.ToString
S300ButtonCN13.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN13.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU13.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU13.Text = "-"
            S300LabelCN13.Text = "-"
            S300LabelQP13.Text = "-"
            S300TextboxCN13.Enabled = False
            S300LabelG13.Text = "-"
            S300ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN13.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S300ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S300level13()
Else
End If
Call S300TextBoxcn13_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN13.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN13.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN13.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN13.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG13.Text = "F"
S300LabelG13.ForeColor = Color.Red
S300labelpt13.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG13.Text = "E"
S300LabelG13.ForeColor = Color.Black
S300labelpt13.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG13.Text = "D"
S300LabelG13.ForeColor = Color.Black
S300labelpt13.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG13.Text = "C"
S300LabelG13.ForeColor = Color.Black
S300labelpt13.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG13.Text = "B"
S300LabelG13.ForeColor = Color.Black
S300labelpt13.Text = "4"
ElseIf (grade > 69) Then
S300LabelG13.Text = "A"
S300LabelG13.ForeColor = Color.Black
S300labelpt13.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S300ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN14.Click
S300ComboBoxCN14.Items.Clear()
Call hope()
For i = 0 To S300ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S300ListBoxHopecode.Items(i).ToString
S300ComboBoxCN14.Items.Add(onyii)
Next
End Sub
Private Sub S300ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300ComboBoxCN14.SelectedIndexChanged
Dim course As String
course = S300ComboBoxCN14.SelectedItem.ToString
S300ButtonCN14.Text = course
For i = 0 To S300ListBoxCourseCode.Items.Count - 1
If course = S300ListBoxCourseCode.Items(i).ToString Then
S300LabelCN14.Text = S300ListBoxCourseName.Items(i).ToString
S300LabelCU14.Text = S300ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU14.Text = "-"
            S300LabelCN14.Text = "-"
            S300LabelQP14.Text = "-"
            S300TextboxCN14.Enabled = False
            S300LabelG14.Text = "-"
            S300ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN14.Enabled = True
            Call oleku()
        End If
Call S300TextBoxcn14_TextChanged(sender, e)
End Sub
Private Sub S300TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S300TextBoxCN14.TextChanged
Dim onecharacter As Char
Dim name As String
name = S300TextBoxCN14.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S300TextBoxCN14.Clear()
End If
Next
Dim grade As Integer = Val(S300TextBoxCN14.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S300LabelG14.Text = "F"
S300LabelG14.ForeColor = Color.Red
S300labelpt14.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S300LabelG14.Text = "E"
S300LabelG14.ForeColor = Color.Black
S300labelpt14.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S300LabelG14.Text = "D"
S300LabelG14.ForeColor = Color.Black
S300labelpt14.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S300LabelG14.Text = "C"
S300LabelG14.ForeColor = Color.Black
S300labelpt14.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S300LabelG14.Text = "B"
S300LabelG14.ForeColor = Color.Black
S300labelpt14.Text = "4"
ElseIf (grade > 69) Then
S300LabelG14.Text = "A"
S300LabelG14.ForeColor = Color.Black
S300labelpt14.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
's400 comboxes and textboxexs
Private Sub S400ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN1.Click
S400ComboBoxCN1.Items.Clear()
Call hope()
For i = 0 To S400ListBoxhopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxhopecode.Items(i).ToString
S400ComboBoxCN1.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN1.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN1.SelectedItem.ToString
S400ButtonCn1.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN1.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU1.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU1.Text = "-"
            S400LabelCN1.Text = "-"
            S400LabelQP1.Text = "-"
            S400TextBoxCN1.Enabled = False
            S400LabelG1.Text = "-"
            S400ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN1.Enabled = True
            Call oleku()
        End If
'to make sure is the maximum number of space required
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level1()
Else
End If
Call S400TextBoxCN1_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN1.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN1.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN1.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN1.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG1.Text = "F"
S400LabelG1.ForeColor = Color.Red
S400labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG1.Text = "E"
S400LabelG1.ForeColor = Color.Black
S400labelpt1.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG1.Text = "D"
S400LabelG1.ForeColor = Color.Black
S400labelpt1.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG1.Text = "C"
S400LabelG1.ForeColor = Color.Black
S400labelpt1.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG1.Text = "B"
S400LabelG1.ForeColor = Color.Black
S400labelpt1.Text = "4"
ElseIf (grade > 69) Then
S400LabelG1.Text = "A"
S400LabelG1.ForeColor = Color.Black
S400labelpt1.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN2.Click
S400ComboBoxCN2.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN2.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN2.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN2.SelectedItem.ToString
S400ButtonCN2.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN2.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU2.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU2.Text = "-"
            S400LabelCN2.Text = "-"
            S400LabelQP2.Text = "-"
            S400TextBoxCN2.Enabled = False
            S400LabelG2.Text = "-"
            S400ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN2.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level2()
Else
End If
Call S400TextBoxcn2_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN2.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN2.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN2.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN2.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG2.Text = "F"
S400LabelG2.ForeColor = Color.Red
S400labelpt2.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG2.Text = "E"
S400LabelG2.ForeColor = Color.Black
S400labelpt2.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG2.Text = "D"
S400LabelG2.ForeColor = Color.Black
S400labelpt2.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG2.Text = "C"
S400LabelG2.ForeColor = Color.Black
S400labelpt2.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG2.Text = "B"
S400LabelG2.ForeColor = Color.Black
S400labelpt2.Text = "4"
ElseIf (grade > 69) Then
S400LabelG2.Text = "A"
S400LabelG2.ForeColor = Color.Black
S400labelpt2.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN3.Click
S400ComboBoxCN3.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN3.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN3.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN3.SelectedItem.ToString
S400ButtonCN3.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN3.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU3.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU3.Text = "-"
            S400LabelCN3.Text = "-"
            S400LabelQP3.Text = "-"
            S400TextBoxCN3.Enabled = False
            S400LabelG3.Text = "-"
            S400ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN3.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level3()
Else
End If
Call S400TextBoxcn3_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN3.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN3.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN3.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN3.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG3.Text = "F"
S400LabelG3.ForeColor = Color.Red
S400labelpt3.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG3.Text = "E"
S400LabelG3.ForeColor = Color.Black
S400labelpt3.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG3.Text = "D"
S400LabelG3.ForeColor = Color.Black
S400labelpt3.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG3.Text = "C"
S400LabelG3.ForeColor = Color.Black
S400labelpt3.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG3.Text = "B"
S400LabelG3.ForeColor = Color.Black
S400labelpt3.Text = "4"
ElseIf (grade > 69) Then
S400LabelG3.Text = "A"
S400LabelG3.ForeColor = Color.Black
S400labelpt3.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN4.Click
S400ComboBoxCN4.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN4.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN4.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN4.SelectedItem.ToString
S400ButtonCN4.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN4.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU4.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU4.Text = "-"
            S400LabelCN4.Text = "-"
            S400LabelQP4.Text = "-"
            S400TextBoxCN4.Enabled = False
            S400LabelG4.Text = "-"
            S400ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN4.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level4()
Else
End If
Call S400TextBoxcn4_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN4.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN4.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN4.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN4.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG4.Text = "F"
S400LabelG4.ForeColor = Color.Red
S400labelpt4.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG4.Text = "E"
S400LabelG4.ForeColor = Color.Black
S400labelpt4.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG4.Text = "D"
S400LabelG4.ForeColor = Color.Black
S400labelpt4.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG4.Text = "C"
S400LabelG4.ForeColor = Color.Black
S400labelpt4.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG4.Text = "B"
S400LabelG4.ForeColor = Color.Black
S400labelpt4.Text = "4"
ElseIf (grade > 69) Then
S400LabelG4.Text = "A"
S400LabelG4.ForeColor = Color.Black
S400labelpt4.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN5.Click
S400ComboBoxCN5.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN5.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN5.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN5.SelectedItem.ToString
S400ButtonCN5.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN5.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU5.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU5.Text = "-"
            S400LabelCN5.Text = "-"
            S400LabelQP5.Text = "-"
            S400TextBoxCN5.Enabled = False
            S400LabelG5.Text = "-"
            S400ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN5.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level5()
Else
End If
Call S400TextBoxcn5_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN5.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN5.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN5.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN5.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG5.Text = "F"
S400LabelG5.ForeColor = Color.Red
S400labelpt5.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG5.Text = "E"
S400LabelG5.ForeColor = Color.Black
S400labelpt5.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG5.Text = "D"
S400LabelG5.ForeColor = Color.Black
S400labelpt5.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG5.Text = "C"
S400LabelG5.ForeColor = Color.Black
S400labelpt5.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG5.Text = "B"
S400LabelG5.ForeColor = Color.Black
S400labelpt5.Text = "4"
ElseIf (grade > 69) Then
S400LabelG5.Text = "A"
S400LabelG5.ForeColor = Color.Black
S400labelpt5.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN6.Click
S400ComboBoxCN6.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN6.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN6.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN6.SelectedItem.ToString
S400ButtonCN6.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN6.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU6.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU6.Text = "-"
            S400LabelCN6.Text = "-"
            S400LabelQP6.Text = "-"
            S400TextBoxCN6.Enabled = False
            S400LabelG6.Text = "-"
            S400ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN6.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level6()
Else
End If
Call S400TextBoxcn6_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN6.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN6.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN6.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN6.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG6.Text = "F"
S400LabelG6.ForeColor = Color.Red
S400labelpt6.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG6.Text = "E"
S400LabelG6.ForeColor = Color.Black
S400labelpt6.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG6.Text = "D"
S400LabelG6.ForeColor = Color.Black
S400labelpt6.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG6.Text = "C"
S400LabelG6.ForeColor = Color.Black
S400labelpt6.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG6.Text = "B"
S400LabelG6.ForeColor = Color.Black
S400labelpt6.Text = "4"
ElseIf (grade > 69) Then
S400LabelG6.Text = "A"
S400LabelG6.ForeColor = Color.Black
S400labelpt6.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN7.Click
S400ComboBoxCN7.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN7.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN7.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN7.SelectedItem.ToString
S400ButtonCN7.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN7.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU7.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU7.Text = "-"
            S400LabelCN7.Text = "-"
            S400LabelQP7.Text = "-"
            S400TextBoxCN7.Enabled = False
            S400LabelG7.Text = "-"
            S400ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN7.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level7()
Else
End If
Call S400TextBoxcn7_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN7.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN7.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN7.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN7.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG7.Text = "F"
S400LabelG7.ForeColor = Color.Red
S400labelpt7.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG7.Text = "E"
S400LabelG7.ForeColor = Color.Black
S400labelpt7.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG7.Text = "D"
S400LabelG7.ForeColor = Color.Black
S400labelpt7.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG7.Text = "C"
S400LabelG7.ForeColor = Color.Black
S400labelpt7.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG7.Text = "B"
S400LabelG7.ForeColor = Color.Black
S400labelpt7.Text = "4"
ElseIf (grade > 69) Then
S400LabelG7.Text = "A"
S400LabelG7.ForeColor = Color.Black
S400labelpt7.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN8.Click
S400ComboBoxCN8.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN8.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN8.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN8.SelectedItem.ToString
S400ButtonCN8.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN8.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU8.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU8.Text = "-"
            S400LabelCN8.Text = "-"
            S400LabelQP8.Text = "-"
            S400TextBoxCN8.Enabled = False
            S400LabelG8.Text = "-"
            S400ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN8.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level8()
Else
End If
Call S400TextBoxcn8_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN8.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN8.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN8.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN8.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG8.Text = "F"
S400LabelG8.ForeColor = Color.Red
S400labelpt8.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG8.Text = "E"
S400LabelG8.ForeColor = Color.Black
S400labelpt8.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG8.Text = "D"
S400LabelG8.ForeColor = Color.Black
S400labelpt8.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG8.Text = "C"
S400LabelG8.ForeColor = Color.Black
S400labelpt8.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG8.Text = "B"
S400LabelG8.ForeColor = Color.Black
S400labelpt8.Text = "4"
ElseIf (grade > 69) Then
S400LabelG8.Text = "A"
S400LabelG8.ForeColor = Color.Black
S400labelpt8.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN9.Click
S400ComboBoxCN9.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN9.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN9.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN9.SelectedItem.ToString
S400ButtonCN9.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN9.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU9.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU9.Text = "-"
            S400LabelCN9.Text = "-"
            S400LabelQP9.Text = "-"
            S400TextBoxCN9.Enabled = False
            S400LabelG9.Text = "-"
            S400ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN9.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level9()
Else
End If
Call S400TextBoxcn9_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN9.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN9.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN9.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN9.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG9.Text = "F"
S400LabelG9.ForeColor = Color.Red
S400labelpt9.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG9.Text = "E"
S400LabelG9.ForeColor = Color.Black
S400labelpt9.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG9.Text = "D"
S400LabelG9.ForeColor = Color.Black
S400labelpt9.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG9.Text = "C"
S400LabelG9.ForeColor = Color.Black
S400labelpt9.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG9.Text = "B"
S400LabelG9.ForeColor = Color.Black
S400labelpt9.Text = "4"
ElseIf (grade > 69) Then
S400LabelG9.Text = "A"
S400LabelG9.ForeColor = Color.Black
S400labelpt9.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN10.Click
S400ComboBoxCN10.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN10.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN10.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN10.SelectedItem.ToString
S400ButtonCN10.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN10.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU10.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU10.Text = "-"
            S400LabelCN10.Text = "-"
            S400LabelQP10.Text = "-"
            S400TextBoxCN10.Enabled = False
            S400LabelG10.Text = "-"
            S400ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN1.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level10()
Else
End If
Call S400TextBoxcn10_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN10.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN10.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN10.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN10.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG10.Text = "F"
S400LabelG10.ForeColor = Color.Red
S400labelpt10.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG10.Text = "E"
S400LabelG10.ForeColor = Color.Black
S400labelpt10.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG10.Text = "D"
S400LabelG10.ForeColor = Color.Black
S400labelpt10.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG10.Text = "C"
S400LabelG10.ForeColor = Color.Black
S400labelpt10.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG10.Text = "B"
S400LabelG10.ForeColor = Color.Black
S400labelpt10.Text = "4"
ElseIf (grade > 69) Then
S400LabelG10.Text = "A"
S400LabelG10.ForeColor = Color.Black
S400labelpt10.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN11.Click
S400ComboBoxCN11.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN11.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN11.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN11.SelectedItem.ToString
S400ButtonCN11.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN11.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU11.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU11.Text = "-"
            S400LabelCN11.Text = "-"
            S400LabelQP11.Text = "-"
            S400TextBoxCN11.Enabled = False
            S400LabelG11.Text = "-"
            S400ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN11.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level11()
Else
End If
Call S400TextBoxcn11_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN11.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN11.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN11.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN11.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG11.Text = "F"
S400LabelG11.ForeColor = Color.Red
S400labelpt11.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG11.Text = "E"
S400LabelG11.ForeColor = Color.Black
S400labelpt11.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG11.Text = "D"
S400LabelG11.ForeColor = Color.Black
S400labelpt11.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG11.Text = "C"
S400LabelG11.ForeColor = Color.Black
S400labelpt11.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG11.Text = "B"
S400LabelG11.ForeColor = Color.Black
S400labelpt11.Text = "4"
ElseIf (grade > 69) Then
S400LabelG11.Text = "A"
S400LabelG11.ForeColor = Color.Black
S400labelpt11.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN12.Click
S400ComboBoxCN12.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN12.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN12.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN12.SelectedItem.ToString
S400ButtonCN12.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN12.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU12.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU12.Text = "-"
            S400LabelCN12.Text = "-"
            S400LabelQP12.Text = "-"
            S400TextBoxCN12.Enabled = False
            S400LabelG12.Text = "-"
            S400ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN12.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level12()
Else
End If
Call S400TextBoxcn12_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN12.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN12.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN12.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN12.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG12.Text = "F"
S400LabelG12.ForeColor = Color.Red
S400labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG12.Text = "E"
S400LabelG12.ForeColor = Color.Black
S400labelpt12.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG12.Text = "D"
S400LabelG12.ForeColor = Color.Black
S400labelpt12.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG12.Text = "C"
S400LabelG12.ForeColor = Color.Black
S400labelpt12.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG12.Text = "B"
S400LabelG12.ForeColor = Color.Black
S400labelpt12.Text = "4"
ElseIf (grade > 69) Then
S400LabelG12.Text = "A"
S400LabelG12.ForeColor = Color.Black
S400labelpt12.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN13.Click
S400ComboBoxCN13.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN13.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN13.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN13.SelectedItem.ToString
S400ButtonCN13.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN13.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU13.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU13.Text = "-"
            S400LabelCN13.Text = "-"
            S400LabelQP13.Text = "-"
            S400TextBoxCN13.Enabled = False
            S400LabelG13.Text = "-"
            S400ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN13.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S400ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S400level13()
Else
End If
Call S400TextBoxcn13_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN13.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN13.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN13.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN13.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG13.Text = "F"
S400LabelG13.ForeColor = Color.Red
S400labelpt13.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG13.Text = "E"
S400LabelG13.ForeColor = Color.Black
S400labelpt13.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG13.Text = "D"
S400LabelG13.ForeColor = Color.Black
S400labelpt13.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG13.Text = "C"
S400LabelG13.ForeColor = Color.Black
S400labelpt13.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG13.Text = "B"
S400LabelG13.ForeColor = Color.Black
S400labelpt13.Text = "4"
ElseIf (grade > 69) Then
S400LabelG13.Text = "A"
S400LabelG13.ForeColor = Color.Black
S400labelpt13.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S400ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN14.Click
S400ComboBoxCN14.Items.Clear()
Call hope()
For i = 0 To S400ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S400ListBoxHopecode.Items(i).ToString
S400ComboBoxCN14.Items.Add(onyii)
Next
End Sub
Private Sub S400ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400ComboBoxCN14.SelectedIndexChanged
Dim course As String
course = S400ComboBoxCN14.SelectedItem.ToString
S400ButtonCN14.Text = course
For i = 0 To S400ListBoxCourseCode.Items.Count - 1
If course = S400ListBoxCourseCode.Items(i).ToString Then
S400LabelCN14.Text = S400ListBoxCourseName.Items(i).ToString
S400LabelCU14.Text = S400ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s400TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S400LabelCU14.Text = "-"
            S400LabelCN14.Text = "-"
            S400LabelQP14.Text = "-"
            S400TextBoxCN14.Enabled = False
            S400LabelG14.Text = "-"
            S400ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S400TextBoxCN14.Enabled = True
            Call oleku()
        End If
Call S400TextBoxcn14_TextChanged(sender, e)
End Sub
Private Sub S400TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S400TextBoxCN14.TextChanged
Dim onecharacter As Char
Dim name As String
name = S400TextBoxCN14.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S400TextBoxCN14.Clear()
End If
Next
Dim grade As Integer = Val(S400TextBoxCN14.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S400LabelG14.Text = "F"
S400LabelG14.ForeColor = Color.Red
S400labelpt14.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S400LabelG14.Text = "E"
S400LabelG14.ForeColor = Color.Black
S400labelpt14.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S400LabelG14.Text = "D"
S400LabelG14.ForeColor = Color.Black
S400labelpt14.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S400LabelG14.Text = "C"
S400LabelG14.ForeColor = Color.Black
S400labelpt14.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S400LabelG14.Text = "B"
S400LabelG14.ForeColor = Color.Black
S400labelpt14.Text = "4"
ElseIf (grade > 69) Then
S400LabelG14.Text = "A"
S400LabelG14.ForeColor = Color.Black
S400labelpt14.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
's500 comboxes and textboxexs
Private Sub S500ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN1.Click
S500ComboBoxCN1.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN1.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN1.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN1.SelectedItem.ToString
S500ButtonCn1.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN1.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU1.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU1.Text = "-"
            S500LabelCN1.Text = "-"
            S500LabelQP1.Text = "-"
            S500TextBoxCN1.Enabled = False
            S500LabelG1.Text = "-"
            S500ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN1.Enabled = True
            Call oleku()
        End If
'to make sure is the maximum number of space required
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level1()
Else
End If
Call S500TextBoxCN1_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN1.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN1.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN1.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN1.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg1.Text = "F"
S500labelg1.ForeColor = Color.Red
S500labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg1.Text = "E"
S500labelg1.ForeColor = Color.Black
S500labelpt1.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg1.Text = "D"
S500labelg1.ForeColor = Color.Black
S500labelpt1.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg1.Text = "C"
S500labelg1.ForeColor = Color.Black
S500labelpt1.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg1.Text = "B"
S500labelg1.ForeColor = Color.Black
S500labelpt1.Text = "4"
ElseIf (grade > 69) Then
S500labelg1.Text = "A"
S500labelg1.ForeColor = Color.Black
S500labelpt1.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN2.Click
S500ComboBoxCN2.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN2.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN2.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN2.SelectedItem.ToString
S500ButtonCN2.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN2.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU2.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU2.Text = "-"
            S500LabelCN2.Text = "-"
            S500LabelQP2.Text = "-"
            S500TextBoxCN2.Enabled = False
            S500LabelG2.Text = "-"
            S500ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN2.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level2()
Else
End If
Call S500TextBoxcn2_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN2.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN2.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN2.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN2.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg2.Text = "F"
S500labelg2.ForeColor = Color.Red
S500labelpt2.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg2.Text = "E"
S500labelg2.ForeColor = Color.Black
S500labelpt2.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg2.Text = "D"
S500labelg2.ForeColor = Color.Black
S500labelpt2.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg2.Text = "C"
S500labelg2.ForeColor = Color.Black
S500labelpt2.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg2.Text = "B"
S500labelg2.ForeColor = Color.Black
S500labelpt2.Text = "4"
ElseIf (grade > 69) Then
S500labelg2.Text = "A"
S500labelg2.ForeColor = Color.Black
S500labelpt2.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN3.Click
S500ComboBoxCN3.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN3.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN3.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN3.SelectedItem.ToString
S500ButtonCN3.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN3.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU3.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU3.Text = "-"
            S500LabelCN3.Text = "-"
            S500LabelQP3.Text = "-"
            S500TextBoxCN3.Enabled = False
            S500LabelG3.Text = "-"
            S500ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN3.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level3()
Else
End If
Call S500TextBoxcn3_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN3.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN3.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN3.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN3.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg3.Text = "F"
S500labelg3.ForeColor = Color.Red
S500labelpt3.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg3.Text = "E"
S500labelg3.ForeColor = Color.Black
S500labelpt3.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg3.Text = "D"
S500labelg3.ForeColor = Color.Black
S500labelpt3.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg3.Text = "C"
S500labelg3.ForeColor = Color.Black
S500labelpt3.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg3.Text = "B"
S500labelg3.ForeColor = Color.Black
S500labelpt3.Text = "4"
ElseIf (grade > 69) Then
S500labelg3.Text = "A"
S500labelg3.ForeColor = Color.Black
S500labelpt3.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN4.Click
S500ComboBoxCN4.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN4.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN4.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN4.SelectedItem.ToString
S500ButtonCN4.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN4.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU4.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU4.Text = "-"
            S500LabelCN4.Text = "-"
            S500LabelQP4.Text = "-"
            S500TextBoxCN4.Enabled = False
            S500LabelG4.Text = "-"
            S500ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN4.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level4()
Else
End If
Call S500TextBoxcn4_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN4.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN4.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN4.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN4.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg4.Text = "F"
S500labelg4.ForeColor = Color.Red
S500labelpt4.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg4.Text = "E"
S500labelg4.ForeColor = Color.Black
S500labelpt4.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg4.Text = "D"
S500labelg4.ForeColor = Color.Black
S500labelpt4.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg4.Text = "C"
S500labelg4.ForeColor = Color.Black
S500labelpt4.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg4.Text = "B"
S500labelg4.ForeColor = Color.Black
S500labelpt4.Text = "4"
ElseIf (grade > 69) Then
S500labelg4.Text = "A"
S500labelg4.ForeColor = Color.Black
S500labelpt4.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN5.Click
S500ComboBoxCN5.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN5.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN5.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN5.SelectedItem.ToString
S500ButtonCN5.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN5.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU5.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU5.Text = "-"
            S500LabelCN5.Text = "-"
            S500LabelQP5.Text = "-"
            S500TextBoxCN5.Enabled = False
            S500LabelG5.Text = "-"
            S500ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN5.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level5()
Else
End If
Call S500TextBoxcn5_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN5.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN5.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN5.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN5.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg5.Text = "F"
S500labelg5.ForeColor = Color.Red
S500labelpt5.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg5.Text = "E"
S500labelg5.ForeColor = Color.Black
S500labelpt5.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg5.Text = "D"
S500labelg5.ForeColor = Color.Black
S500labelpt5.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg5.Text = "C"
S500labelg5.ForeColor = Color.Black
S500labelpt5.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg5.Text = "B"
S500labelg5.ForeColor = Color.Black
S500labelpt5.Text = "4"
ElseIf (grade > 69) Then
S500labelg5.Text = "A"
S500labelg5.ForeColor = Color.Black
S500labelpt5.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN6.Click
S500ComboBoxCN6.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN6.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN6.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN6.SelectedItem.ToString
S500ButtonCN6.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN6.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU6.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU6.Text = "-"
            S500LabelCN6.Text = "-"
            S500LabelQP6.Text = "-"
            S500TextBoxCN6.Enabled = False
            S500LabelG6.Text = "-"
            S500ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN6.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level6()
Else
End If
Call S500TextBoxcn6_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN6.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN6.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN6.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN6.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg6.Text = "F"
S500labelg6.ForeColor = Color.Red
S500labelpt6.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg6.Text = "E"
S500labelg6.ForeColor = Color.Black
S500labelpt6.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg6.Text = "D"
S500labelg6.ForeColor = Color.Black
S500labelpt6.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg6.Text = "C"
S500labelg6.ForeColor = Color.Black
S500labelpt6.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg6.Text = "B"
S500labelg6.ForeColor = Color.Black
S500labelpt6.Text = "4"
ElseIf (grade > 69) Then
S500labelg6.Text = "A"
S500labelg6.ForeColor = Color.Black
S500labelpt6.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN7.Click
S500ComboBoxCN7.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN7.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN7.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN7.SelectedItem.ToString
S500ButtonCN7.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN7.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU7.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU7.Text = "-"
            S500LabelCN7.Text = "-"
            S500LabelQP7.Text = "-"
            S500TextBoxCN7.Enabled = False
            S500LabelG7.Text = "-"
            S500ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN7.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level7()
Else
End If
Call S500TextBoxcn7_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN7.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN7.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN7.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN7.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg7.Text = "F"
S500labelg7.ForeColor = Color.Red
S500labelpt7.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg7.Text = "E"
S500labelg7.ForeColor = Color.Black
S500labelpt7.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg7.Text = "D"
S500labelg7.ForeColor = Color.Black
S500labelpt7.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg7.Text = "C"
S500labelg7.ForeColor = Color.Black
S500labelpt7.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg7.Text = "B"
S500labelg7.ForeColor = Color.Black
S500labelpt7.Text = "4"
ElseIf (grade > 69) Then
S500labelg7.Text = "A"
S500labelg7.ForeColor = Color.Black
S500labelpt7.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN8.Click
S500ComboBoxCN8.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN8.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN8.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN8.SelectedItem.ToString
S500ButtonCN8.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN8.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU8.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU8.Text = "-"
            S500LabelCN8.Text = "-"
            S500LabelQP8.Text = "-"
            S500TextBoxCN8.Enabled = False
            S500LabelG8.Text = "-"
            S500ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN8.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level8()
Else
End If
Call S500TextBoxcn8_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN8.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN8.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN8.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN8.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg8.Text = "F"
S500labelg8.ForeColor = Color.Red
S500labelpt8.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg8.Text = "E"
S500labelg8.ForeColor = Color.Black
S500labelpt8.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg8.Text = "D"
S500labelg8.ForeColor = Color.Black
S500labelpt8.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg8.Text = "C"
S500labelg8.ForeColor = Color.Black
S500labelpt8.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg8.Text = "B"
S500labelg8.ForeColor = Color.Black
S500labelpt8.Text = "4"
ElseIf (grade > 69) Then
S500labelg8.Text = "A"
S500labelg8.ForeColor = Color.Black
S500labelpt8.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN9.Click
S500ComboBoxCN9.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN9.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN9.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN9.SelectedItem.ToString
S500ButtonCN9.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN9.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU9.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU9.Text = "-"
            S500LabelCN9.Text = "-"
            S500LabelQP9.Text = "-"
            S500TextBoxCN9.Enabled = False
            S500LabelG9.Text = "-"
            S500ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN9.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level9()
Else
End If
Call S500TextBoxcn9_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN9.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN9.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN9.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN9.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg9.Text = "F"
S500labelg9.ForeColor = Color.Red
S500labelpt9.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg9.Text = "E"
S500labelg9.ForeColor = Color.Black
S500labelpt9.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg9.Text = "D"
S500labelg9.ForeColor = Color.Black
S500labelpt9.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg9.Text = "C"
S500labelg9.ForeColor = Color.Black
S500labelpt9.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg9.Text = "B"
S500labelg9.ForeColor = Color.Black
S500labelpt9.Text = "4"
ElseIf (grade > 69) Then
S500labelg9.Text = "A"
S500labelg9.ForeColor = Color.Black
S500labelpt9.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN10.Click
S500ComboBoxCN10.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN10.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN10.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN10.SelectedItem.ToString
S500ButtonCN10.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN10.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU10.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU10.Text = "-"
            S500LabelCN10.Text = "-"
            S500LabelQP10.Text = "-"
            S500TextBoxCN10.Enabled = False
            S500LabelG10.Text = "-"
            S500ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN1.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level10()
Else
End If
Call S500TextBoxcn10_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN10.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN10.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN10.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN10.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg10.Text = "F"
S500labelg10.ForeColor = Color.Red
S500labelpt10.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg10.Text = "E"
S500labelg10.ForeColor = Color.Black
S500labelpt10.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg10.Text = "D"
S500labelg10.ForeColor = Color.Black
S500labelpt10.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg10.Text = "C"
S500labelg10.ForeColor = Color.Black
S500labelpt10.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg10.Text = "B"
S500labelg10.ForeColor = Color.Black
S500labelpt10.Text = "4"
ElseIf (grade > 69) Then
S500labelg10.Text = "A"
S500labelg10.ForeColor = Color.Black
S500labelpt10.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN11.Click
S500ComboBoxCN11.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN11.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN11.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN11.SelectedItem.ToString
S500ButtonCN11.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN11.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU11.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU11.Text = "-"
            S500LabelCN11.Text = "-"
            S500LabelQP11.Text = "-"
            S500TextBoxCN11.Enabled = False
            S500LabelG11.Text = "-"
            S500ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN11.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level11()
Else
End If
Call S500TextBoxcn11_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN11.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN11.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN11.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN11.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg11.Text = "F"
S500labelg11.ForeColor = Color.Red
S500labelpt11.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg11.Text = "E"
S500labelg11.ForeColor = Color.Black
S500labelpt11.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg11.Text = "D"
S500labelg11.ForeColor = Color.Black
S500labelpt11.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg11.Text = "C"
S500labelg11.ForeColor = Color.Black
S500labelpt11.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg11.Text = "B"
S500labelg11.ForeColor = Color.Black
S500labelpt11.Text = "4"
ElseIf (grade > 69) Then
S500labelg11.Text = "A"
S500labelg11.ForeColor = Color.Black
S500labelpt11.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN12.Click
S500ComboBoxCN12.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN12.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN12.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN12.SelectedItem.ToString
S500ButtonCN12.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN12.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU12.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU12.Text = "-"
            S500LabelCN12.Text = "-"
            S500LabelQP12.Text = "-"
            S500TextBoxCN12.Enabled = False
            S500LabelG12.Text = "-"
            S500ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN12.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level12()
Else
End If
Call S500TextBoxcn12_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN12.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN12.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN12.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN12.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg12.Text = "F"
S500labelg12.ForeColor = Color.Red
S500labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg12.Text = "E"
S500labelg12.ForeColor = Color.Black
S500labelpt12.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg12.Text = "D"
S500labelg12.ForeColor = Color.Black
S500labelpt12.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg12.Text = "C"
S500labelg12.ForeColor = Color.Black
S500labelpt12.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg12.Text = "B"
S500labelg12.ForeColor = Color.Black
S500labelpt12.Text = "4"
ElseIf (grade > 69) Then
S500labelg12.Text = "A"
S500labelg12.ForeColor = Color.Black
S500labelpt12.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN13.Click
S500ComboBoxCN13.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN13.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN13.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN13.SelectedItem.ToString
S500ButtonCN13.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN13.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU13.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU13.Text = "-"
            S500LabelCN13.Text = "-"
            S500LabelQP13.Text = "-"
            S500TextBoxCN13.Enabled = False
            S500LabelG13.Text = "-"
            S500ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN13.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S500ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S500level13()
Else
End If
Call S500TextBoxcn13_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN13.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN13.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN13.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN13.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg13.Text = "F"
S500labelg13.ForeColor = Color.Red
S500labelpt13.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg13.Text = "E"
S500labelg13.ForeColor = Color.Black
S500labelpt13.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg13.Text = "D"
S500labelg13.ForeColor = Color.Black
S500labelpt13.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg13.Text = "C"
S500labelg13.ForeColor = Color.Black
S500labelpt13.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg13.Text = "B"
S500labelg13.ForeColor = Color.Black
S500labelpt13.Text = "4"
ElseIf (grade > 69) Then
S500labelg13.Text = "A"
S500labelg13.ForeColor = Color.Black
S500labelpt13.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S500ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN14.Click
S500ComboBoxCN14.Items.Clear()
Call hope()
For i = 0 To S500ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S500ListBoxHopecode.Items(i).ToString
S500ComboBoxCN14.Items.Add(onyii)
Next
End Sub
Private Sub S500ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500ComboBoxCN14.SelectedIndexChanged
Dim course As String
course = S500ComboBoxCN14.SelectedItem.ToString
S500ButtonCN14.Text = course
For i = 0 To S500ListBoxCourseCode.Items.Count - 1
If course = S500ListBoxCourseCode.Items(i).ToString Then
S500LabelCN14.Text = S500ListBoxCourseName.Items(i).ToString
S500LabelCU14.Text = S500ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s500TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S500LabelCU14.Text = "-"
            S500LabelCN14.Text = "-"
            S500LabelQP14.Text = "-"
            S500TextBoxCN14.Enabled = False
            S500LabelG14.Text = "-"
            S500ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S500TextBoxCN14.Enabled = True
            Call oleku()
        End If
Call S500TextBoxcn14_TextChanged(sender, e)
End Sub
Private Sub S500TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S500TextBoxCN14.TextChanged
Dim onecharacter As Char
Dim name As String
name = S500TextBoxCN14.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S500TextBoxCN14.Clear()
End If
Next
Dim grade As Integer = Val(S500TextBoxCN14.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S500labelg14.Text = "F"
S500labelg14.ForeColor = Color.Red
S500labelpt14.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S500labelg14.Text = "E"
S500labelg14.ForeColor = Color.Black
S500labelpt14.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S500labelg14.Text = "D"
S500labelg14.ForeColor = Color.Black
S500labelpt14.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S500labelg14.Text = "C"
S500labelg14.ForeColor = Color.Black
S500labelpt14.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S500labelg14.Text = "B"
S500labelg14.ForeColor = Color.Black
S500labelpt14.Text = "4"
ElseIf (grade > 69) Then
S500labelg14.Text = "A"
S500labelg14.ForeColor = Color.Black
S500labelpt14.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
's600 comboxes and textboxexs
Private Sub S600ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN1.Click
S600ComboBoxCN1.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN1.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN1.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN1.SelectedItem.ToString
S600ButtonCn1.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN1.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU1.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU1.Text = "-"
            S600LabelCN1.Text = "-"
            S600LabelQP1.Text = "-"
            S600TextBoxCN1.Enabled = False
            S600LabelG1.Text = "-"
            S600ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN1.Enabled = True
            Call oleku()
        End If
'to make sure is the maximum number of space required
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level1()
Else
End If
Call S600TextBoxCN1_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN1.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN1.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN1.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN1.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG1.Text = "F"
S600LabelG1.ForeColor = Color.Red
S600labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG1.Text = "E"
S600LabelG1.ForeColor = Color.Black
S600labelpt1.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG1.Text = "D"
S600LabelG1.ForeColor = Color.Black
S600labelpt1.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG1.Text = "C"
S600LabelG1.ForeColor = Color.Black
S600labelpt1.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG1.Text = "B"
S600LabelG1.ForeColor = Color.Black
S600labelpt1.Text = "4"
ElseIf (grade > 69) Then
S600LabelG1.Text = "A"
S600LabelG1.ForeColor = Color.Black
S600labelpt1.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN2.Click
S600ComboBoxCN2.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN2.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN2.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN2.SelectedItem.ToString
S600ButtonCN2.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN2.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU2.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU2.Text = "-"
            S600LabelCN2.Text = "-"
            S600LabelQP2.Text = "-"
            S600TextBoxCN2.Enabled = False
            S600LabelG2.Text = "-"
            S600ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN2.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level2()
Else
End If
Call S600TextBoxcn2_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN2.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN2.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN2.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN2.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG2.Text = "F"
S600LabelG2.ForeColor = Color.Red
S600labelpt2.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG2.Text = "E"
S600LabelG2.ForeColor = Color.Black
S600labelpt2.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG2.Text = "D"
S600LabelG2.ForeColor = Color.Black
S600labelpt2.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG2.Text = "C"
S600LabelG2.ForeColor = Color.Black
S600labelpt2.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG2.Text = "B"
S600LabelG2.ForeColor = Color.Black
S600labelpt2.Text = "4"
ElseIf (grade > 69) Then
S600LabelG2.Text = "A"
S600LabelG2.ForeColor = Color.Black
S600labelpt2.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN3.Click
S600ComboBoxCN3.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN3.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN3.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN3.SelectedItem.ToString
S600ButtonCN3.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN3.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU3.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU3.Text = "-"
            S600LabelCN3.Text = "-"
            S600LabelQP3.Text = "-"
            S600TextBoxCN3.Enabled = False
            S600LabelG3.Text = "-"
            S600ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN3.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level3()
Else
End If
Call S600TextBoxcn3_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN3.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN3.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN3.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN3.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG3.Text = "F"
S600LabelG3.ForeColor = Color.Red
S600labelpt3.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG3.Text = "E"
S600LabelG3.ForeColor = Color.Black
S600labelpt3.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG3.Text = "D"
S600LabelG3.ForeColor = Color.Black
S600labelpt3.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG3.Text = "C"
S600LabelG3.ForeColor = Color.Black
S600labelpt3.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG3.Text = "B"
S600LabelG3.ForeColor = Color.Black
S600labelpt3.Text = "4"
ElseIf (grade > 69) Then
S600LabelG3.Text = "A"
S600LabelG3.ForeColor = Color.Black
S600labelpt3.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN4.Click
S600ComboBoxCN4.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN4.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN4.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN4.SelectedItem.ToString
S600ButtonCN4.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN4.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU4.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU4.Text = "-"
            S600LabelCN4.Text = "-"
            S600LabelQP4.Text = "-"
            S600TextBoxCN4.Enabled = False
            S600LabelG4.Text = "-"
            S600ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN4.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level4()
Else
End If
Call S600TextBoxcn4_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN4.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN4.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN4.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN4.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG4.Text = "F"
S600LabelG4.ForeColor = Color.Red
S600labelpt4.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG4.Text = "E"
S600LabelG4.ForeColor = Color.Black
S600labelpt4.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG4.Text = "D"
S600LabelG4.ForeColor = Color.Black
S600labelpt4.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG4.Text = "C"
S600LabelG4.ForeColor = Color.Black
S600labelpt4.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG4.Text = "B"
S600LabelG4.ForeColor = Color.Black
S600labelpt4.Text = "4"
ElseIf (grade > 69) Then
S600LabelG4.Text = "A"
S600LabelG4.ForeColor = Color.Black
S600labelpt4.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN5.Click
S600ComboBoxCN5.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN5.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN5.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN5.SelectedItem.ToString
S600ButtonCN5.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN5.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU5.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU5.Text = "-"
            S600LabelCN5.Text = "-"
            S600LabelQP5.Text = "-"
            S600TextBoxCN5.Enabled = False
            S600LabelG5.Text = "-"
            S600ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN5.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level5()
Else
End If
Call S600TextBoxcn5_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN5.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN5.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN5.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN5.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG5.Text = "F"
S600LabelG5.ForeColor = Color.Red
S600labelpt5.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG5.Text = "E"
S600LabelG5.ForeColor = Color.Black
S600labelpt5.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG5.Text = "D"
S600LabelG5.ForeColor = Color.Black
S600labelpt5.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG5.Text = "C"
S600LabelG5.ForeColor = Color.Black
S600labelpt5.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG5.Text = "B"
S600LabelG5.ForeColor = Color.Black
S600labelpt5.Text = "4"
ElseIf (grade > 69) Then
S600LabelG5.Text = "A"
S600LabelG5.ForeColor = Color.Black
S600labelpt5.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN6.Click
S600ComboBoxCN6.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN6.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN6.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN6.SelectedItem.ToString
S600ButtonCN6.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN6.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU6.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU6.Text = "-"
            S600LabelCN6.Text = "-"
            S600LabelQP6.Text = "-"
            S600TextBoxCN6.Enabled = False
            S600LabelG6.Text = "-"
            S600ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN6.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level6()
Else
End If
Call S600TextBoxcn6_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN6.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN6.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN6.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN6.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG6.Text = "F"
S600LabelG6.ForeColor = Color.Red
S600labelpt6.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG6.Text = "E"
S600LabelG6.ForeColor = Color.Black
S600labelpt6.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG6.Text = "D"
S600LabelG6.ForeColor = Color.Black
S600labelpt6.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG6.Text = "C"
S600LabelG6.ForeColor = Color.Black
S600labelpt6.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG6.Text = "B"
S600LabelG6.ForeColor = Color.Black
S600labelpt6.Text = "4"
ElseIf (grade > 69) Then
S600LabelG6.Text = "A"
S600LabelG6.ForeColor = Color.Black
S600labelpt6.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN7.Click
S600ComboBoxCN7.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN7.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN7.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN7.SelectedItem.ToString
S600ButtonCN7.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN7.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU7.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU7.Text = "-"
            S600LabelCN7.Text = "-"
            S600LabelQP7.Text = "-"
            S600TextBoxCN7.Enabled = False
            S600LabelG7.Text = "-"
            S600ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN7.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level7()
Else
End If
Call S600TextBoxcn7_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN7.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN7.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN7.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN7.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG7.Text = "F"
S600LabelG7.ForeColor = Color.Red
S600labelpt7.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG7.Text = "E"
S600LabelG7.ForeColor = Color.Black
S600labelpt7.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG7.Text = "D"
S600LabelG7.ForeColor = Color.Black
S600labelpt7.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG7.Text = "C"
S600LabelG7.ForeColor = Color.Black
S600labelpt7.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG7.Text = "B"
S600LabelG7.ForeColor = Color.Black
S600labelpt7.Text = "4"
ElseIf (grade > 69) Then
S600LabelG7.Text = "A"
S600LabelG7.ForeColor = Color.Black
S600labelpt7.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN8.Click
S600ComboBoxCN8.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN8.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN8.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN8.SelectedItem.ToString
S600ButtonCN8.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN8.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU8.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU8.Text = "-"
            S600LabelCN8.Text = "-"
            S600LabelQP8.Text = "-"
            S600TextBoxCN8.Enabled = False
            S600LabelG8.Text = "-"
            S600ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN8.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level8()
Else
End If
Call S600TextBoxcn8_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN8.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN8.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN8.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN8.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG8.Text = "F"
S600LabelG8.ForeColor = Color.Red
S600labelpt8.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG8.Text = "E"
S600LabelG8.ForeColor = Color.Black
S600labelpt8.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG8.Text = "D"
S600LabelG8.ForeColor = Color.Black
S600labelpt8.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG8.Text = "C"
S600LabelG8.ForeColor = Color.Black
S600labelpt8.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG8.Text = "B"
S600LabelG8.ForeColor = Color.Black
S600labelpt8.Text = "4"
ElseIf (grade > 69) Then
S600LabelG8.Text = "A"
S600LabelG8.ForeColor = Color.Black
S600labelpt8.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN9.Click
S600ComboBoxCN9.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN9.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN9.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN9.SelectedItem.ToString
S600ButtonCN9.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN9.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU9.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU9.Text = "-"
            S600LabelCN9.Text = "-"
            S600LabelQP9.Text = "-"
            S600TextBoxCN9.Enabled = False
            S600LabelG9.Text = "-"
            S600ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN9.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level9()
Else
End If
Call S600TextBoxcn9_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN9.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN9.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN9.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN9.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG9.Text = "F"
S600LabelG9.ForeColor = Color.Red
S600labelpt9.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG9.Text = "E"
S600LabelG9.ForeColor = Color.Black
S600labelpt9.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG9.Text = "D"
S600LabelG9.ForeColor = Color.Black
S600labelpt9.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG9.Text = "C"
S600LabelG9.ForeColor = Color.Black
S600labelpt9.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG9.Text = "B"
S600LabelG9.ForeColor = Color.Black
S600labelpt9.Text = "4"
ElseIf (grade > 69) Then
S600LabelG9.Text = "A"
S600LabelG9.ForeColor = Color.Black
S600labelpt9.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN10.Click
S600ComboBoxCN10.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN10.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN10.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN10.SelectedItem.ToString
S600ButtonCN10.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN10.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU10.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU10.Text = "-"
            S600LabelCN10.Text = "-"
            S600LabelQP10.Text = "-"
            S600TextBoxCN10.Enabled = False
            S600LabelG10.Text = "-"
            S600ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN1.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level10()
Else
End If
Call S600TextBoxcn10_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN10.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN10.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN10.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN10.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG10.Text = "F"
S600LabelG10.ForeColor = Color.Red
S600labelpt10.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG10.Text = "E"
S600LabelG10.ForeColor = Color.Black
S600labelpt10.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG10.Text = "D"
S600LabelG10.ForeColor = Color.Black
S600labelpt10.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG10.Text = "C"
S600LabelG10.ForeColor = Color.Black
S600labelpt10.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG10.Text = "B"
S600LabelG10.ForeColor = Color.Black
S600labelpt10.Text = "4"
ElseIf (grade > 69) Then
S600LabelG10.Text = "A"
S600LabelG10.ForeColor = Color.Black
S600labelpt10.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN11.Click
S600ComboBoxCN11.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN11.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN11.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN11.SelectedItem.ToString
S600ButtonCN11.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN11.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU11.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU11.Text = "-"
            S600LabelCN11.Text = "-"
            S600LabelQP11.Text = "-"
            S600TextBoxCN11.Enabled = False
            S600LabelG11.Text = "-"
            S600ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN11.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level11()
Else
End If
Call S600TextBoxcn11_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN11.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN11.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN11.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN11.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG11.Text = "F"
S600LabelG11.ForeColor = Color.Red
S600labelpt11.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG11.Text = "E"
S600LabelG11.ForeColor = Color.Black
S600labelpt11.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG11.Text = "D"
S600LabelG11.ForeColor = Color.Black
S600labelpt11.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG11.Text = "C"
S600LabelG11.ForeColor = Color.Black
S600labelpt11.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG11.Text = "B"
S600LabelG11.ForeColor = Color.Black
S600labelpt11.Text = "4"
ElseIf (grade > 69) Then
S600LabelG11.Text = "A"
S600LabelG11.ForeColor = Color.Black
S600labelpt11.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN12.Click
S600ComboBoxCN12.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN12.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN12.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN12.SelectedItem.ToString
S600ButtonCN12.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN12.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU12.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU12.Text = "-"
            S600LabelCN12.Text = "-"
            S600LabelQP12.Text = "-"
            S600TextBoxCN12.Enabled = False
            S600LabelG12.Text = "-"
            S600ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN12.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level12()
Else
End If
Call S600TextBoxcn12_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN12.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN12.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN12.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN12.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG12.Text = "F"
S600LabelG12.ForeColor = Color.Red
S600labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG12.Text = "E"
S600LabelG12.ForeColor = Color.Black
S600labelpt12.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG12.Text = "D"
S600LabelG12.ForeColor = Color.Black
S600labelpt12.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG12.Text = "C"
S600LabelG12.ForeColor = Color.Black
S600labelpt12.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG12.Text = "B"
S600LabelG12.ForeColor = Color.Black
S600labelpt12.Text = "4"
ElseIf (grade > 69) Then
S600LabelG12.Text = "A"
S600LabelG12.ForeColor = Color.Black
S600labelpt12.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN13.Click
S600ComboBoxCN13.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN13.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN13.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN13.SelectedItem.ToString
S600ButtonCN13.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN13.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU13.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU13.Text = "-"
            S600LabelCN13.Text = "-"
            S600LabelQP13.Text = "-"
            S600TextBoxCN13.Enabled = False
            S600LabelG13.Text = "-"
            S600ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN13.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S600ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S600level13()
Else
End If
Call S600TextBoxcn13_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN13.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN13.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN13.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN13.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG13.Text = "F"
S600LabelG13.ForeColor = Color.Red
S600labelpt13.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG13.Text = "E"
S600LabelG13.ForeColor = Color.Black
S600labelpt13.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG13.Text = "D"
S600LabelG13.ForeColor = Color.Black
S600labelpt13.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG13.Text = "C"
S600LabelG13.ForeColor = Color.Black
S600labelpt13.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG13.Text = "B"
S600LabelG13.ForeColor = Color.Black
S600labelpt13.Text = "4"
ElseIf (grade > 69) Then
S600LabelG13.Text = "A"
S600LabelG13.ForeColor = Color.Black
S600labelpt13.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S600ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S600ComboboxCN14.Click
S600ComboBoxCN14.Items.Clear()
Call hope()
For i = 0 To S600ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S600ListBoxHopecode.Items(i).ToString
S600ComboBoxCN14.Items.Add(onyii)
Next
End Sub
Private Sub S600ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600ComboboxCN14.SelectedIndexChanged
Dim course As String
course = S600ComboBoxCN14.SelectedItem.ToString
S600ButtonCN14.Text = course
For i = 0 To S600ListBoxCourseCode.Items.Count - 1
If course = S600ListBoxCourseCode.Items(i).ToString Then
S600LabelCN14.Text = S600ListBoxCourseName.Items(i).ToString
S600LabelCU14.Text = S600ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s600TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S600LabelCU14.Text = "-"
            S600LabelCN14.Text = "-"
            S600LabelQP14.Text = "-"
            S600TextBoxCN14.Enabled = False
            S600LabelG14.Text = "-"
            S600ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S600TextBoxCN14.Enabled = True
            Call oleku()
        End If
Call S600TextBoxcn14_TextChanged(sender, e)
End Sub
Private Sub S600TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S600TextboxCN14.TextChanged
Dim onecharacter As Char
Dim name As String
name = S600TextBoxCN14.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S600TextBoxCN14.Clear()
End If
Next
Dim grade As Integer = Val(S600TextBoxCN14.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S600LabelG14.Text = "F"
S600LabelG14.ForeColor = Color.Red
S600labelpt14.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S600LabelG14.Text = "E"
S600LabelG14.ForeColor = Color.Black
S600labelpt14.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S600LabelG14.Text = "D"
S600LabelG14.ForeColor = Color.Black
S600labelpt14.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S600LabelG14.Text = "C"
S600LabelG14.ForeColor = Color.Black
S600labelpt14.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S600LabelG14.Text = "B"
S600LabelG14.ForeColor = Color.Black
S600labelpt14.Text = "4"
ElseIf (grade > 69) Then
S600LabelG14.Text = "A"
S600LabelG14.ForeColor = Color.Black
S600labelpt14.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
's700 comboxes and textboxexs
Private Sub S700ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN1.Click
S700ComboBoxCN1.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN1.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN1.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN1.SelectedItem.ToString
S700ButtonCn1.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN1.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU1.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU1.Text = "-"
            S700LabelCN1.Text = "-"
            S700LabelQP1.Text = "-"
            S700TextBoxCN1.Enabled = False
            S700LabelG1.Text = "-"
            S700ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN1.Enabled = True
            Call oleku()
        End If
'to make sure is the maximum number of space required
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level1()
Else
End If
Call S700TextBoxCN1_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN1.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN1.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN1.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN1.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG1.Text = "F"
S700LabelG1.ForeColor = Color.Red
S700labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG1.Text = "E"
S700LabelG1.ForeColor = Color.Black
S700labelpt1.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG1.Text = "D"
S700LabelG1.ForeColor = Color.Black
S700labelpt1.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG1.Text = "C"
S700LabelG1.ForeColor = Color.Black
S700labelpt1.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG1.Text = "B"
S700LabelG1.ForeColor = Color.Black
S700labelpt1.Text = "4"
ElseIf (grade > 69) Then
S700LabelG1.Text = "A"
S700LabelG1.ForeColor = Color.Black
S700labelpt1.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN2.Click
S700ComboBoxCN2.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN2.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN2.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN2.SelectedItem.ToString
S700ButtonCN2.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN2.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU2.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU2.Text = "-"
            S700LabelCN2.Text = "-"
            S700LabelQP2.Text = "-"
            S700TextBoxCN2.Enabled = False
            S700LabelG2.Text = "-"
            S700ButtonCN2.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN2.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level2()
Else
End If
Call S700TextBoxcn2_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN2.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN2.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN2.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN2.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG2.Text = "F"
S700LabelG2.ForeColor = Color.Red
S700labelpt2.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG2.Text = "E"
S700LabelG2.ForeColor = Color.Black
S700labelpt2.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG2.Text = "D"
S700LabelG2.ForeColor = Color.Black
S700labelpt2.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG2.Text = "C"
S700LabelG2.ForeColor = Color.Black
S700labelpt2.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG2.Text = "B"
S700LabelG2.ForeColor = Color.Black
S700labelpt2.Text = "4"
ElseIf (grade > 69) Then
S700LabelG2.Text = "A"
S700LabelG2.ForeColor = Color.Black
S700labelpt2.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN3.Click
S700ComboBoxCN3.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN3.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN3.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN3.SelectedItem.ToString
S700ButtonCN3.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN3.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU3.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU3.Text = "-"
            S700LabelCN3.Text = "-"
            S700LabelQP3.Text = "-"
            S700TextBoxCN3.Enabled = False
            S700LabelG3.Text = "-"
            S700ButtonCN3.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN3.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level3()
Else
End If
Call S700TextBoxcn3_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN3.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN3.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN3.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN3.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG3.Text = "F"
S700LabelG3.ForeColor = Color.Red
S700labelpt3.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG3.Text = "E"
S700LabelG3.ForeColor = Color.Black
S700labelpt3.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG3.Text = "D"
S700LabelG3.ForeColor = Color.Black
S700labelpt3.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG3.Text = "C"
S700LabelG3.ForeColor = Color.Black
S700labelpt3.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG3.Text = "B"
S700LabelG3.ForeColor = Color.Black
S700labelpt3.Text = "4"
ElseIf (grade > 69) Then
S700LabelG3.Text = "A"
S700LabelG3.ForeColor = Color.Black
S700labelpt3.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN4.Click
S700ComboBoxCN4.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN4.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN4.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN4.SelectedItem.ToString
S700ButtonCN4.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN4.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU4.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU4.Text = "-"
            S700LabelCN4.Text = "-"
            S700LabelQP4.Text = "-"
            S700TextBoxCN4.Enabled = False
            S700LabelG4.Text = "-"
            S700ButtonCN4.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN4.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level4()
Else
End If
Call S700TextBoxcn4_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN4.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN4.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN4.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN4.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG4.Text = "F"
S700LabelG4.ForeColor = Color.Red
S700labelpt4.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG4.Text = "E"
S700LabelG4.ForeColor = Color.Black
S700labelpt4.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG4.Text = "D"
S700LabelG4.ForeColor = Color.Black
S700labelpt4.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG4.Text = "C"
S700LabelG4.ForeColor = Color.Black
S700labelpt4.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG4.Text = "B"
S700LabelG4.ForeColor = Color.Black
S700labelpt4.Text = "4"
ElseIf (grade > 69) Then
S700LabelG4.Text = "A"
S700LabelG4.ForeColor = Color.Black
S700labelpt4.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN5.Click
S700ComboBoxCN5.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN5.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN5.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN5.SelectedItem.ToString
S700ButtonCN5.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN5.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU5.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU5.Text = "-"
            S700LabelCN5.Text = "-"
            S700LabelQP5.Text = "-"
            S700TextBoxCN5.Enabled = False
            S700LabelG5.Text = "-"
            S700ButtonCN5.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN5.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level5()
Else
End If
Call S700TextBoxcn5_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN5.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN5.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN5.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN5.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG5.Text = "F"
S700LabelG5.ForeColor = Color.Red
S700labelpt5.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG5.Text = "E"
S700LabelG5.ForeColor = Color.Black
S700labelpt5.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG5.Text = "D"
S700LabelG5.ForeColor = Color.Black
S700labelpt5.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG5.Text = "C"
S700LabelG5.ForeColor = Color.Black
S700labelpt5.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG5.Text = "B"
S700LabelG5.ForeColor = Color.Black
S700labelpt5.Text = "4"
ElseIf (grade > 69) Then
S700LabelG5.Text = "A"
S700LabelG5.ForeColor = Color.Black
S700labelpt5.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN6.Click
S700ComboBoxCN6.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN6.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN6.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN6.SelectedItem.ToString
S700ButtonCN6.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN6.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU6.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU6.Text = "-"
            S700LabelCN6.Text = "-"
            S700LabelQP6.Text = "-"
            S700TextBoxCN6.Enabled = False
            S700LabelG6.Text = "-"
            S700ButtonCN6.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN6.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level6()
Else
End If
Call S700TextBoxcn6_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN6.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN6.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN6.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN6.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG6.Text = "F"
S700LabelG6.ForeColor = Color.Red
S700labelpt6.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG6.Text = "E"
S700LabelG6.ForeColor = Color.Black
S700labelpt6.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG6.Text = "D"
S700LabelG6.ForeColor = Color.Black
S700labelpt6.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG6.Text = "C"
S700LabelG6.ForeColor = Color.Black
S700labelpt6.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG6.Text = "B"
S700LabelG6.ForeColor = Color.Black
S700labelpt6.Text = "4"
ElseIf (grade > 69) Then
S700LabelG6.Text = "A"
S700LabelG6.ForeColor = Color.Black
S700labelpt6.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN7.Click
S700ComboBoxCN7.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN7.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN7.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN7.SelectedItem.ToString
S700ButtonCN7.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN7.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU7.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU7.Text = "-"
            S700LabelCN7.Text = "-"
            S700LabelQP7.Text = "-"
            S700TextBoxCN7.Enabled = False
            S700LabelG7.Text = "-"
            S700ButtonCN7.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN7.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level7()
Else
End If
Call S700TextBoxcn7_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN7.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN7.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN7.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN7.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG7.Text = "F"
S700LabelG7.ForeColor = Color.Red
S700labelpt7.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG7.Text = "E"
S700LabelG7.ForeColor = Color.Black
S700labelpt7.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG7.Text = "D"
S700LabelG7.ForeColor = Color.Black
S700labelpt7.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG7.Text = "C"
S700LabelG7.ForeColor = Color.Black
S700labelpt7.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG7.Text = "B"
S700LabelG7.ForeColor = Color.Black
S700labelpt7.Text = "4"
ElseIf (grade > 69) Then
S700LabelG7.Text = "A"
S700LabelG7.ForeColor = Color.Black
S700labelpt7.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN8.Click
S700ComboBoxCN8.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN8.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN8.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN8.SelectedItem.ToString
S700ButtonCN8.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN8.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU8.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU8.Text = "-"
            S700LabelCN8.Text = "-"
            S700LabelQP8.Text = "-"
            S700TextBoxCN8.Enabled = False
            S700LabelG8.Text = "-"
            S700ButtonCN8.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN8.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level8()
Else
End If
Call S700TextBoxcn8_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN8.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN8.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN8.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN8.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG8.Text = "F"
S700LabelG8.ForeColor = Color.Red
S700labelpt8.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG8.Text = "E"
S700LabelG8.ForeColor = Color.Black
S700labelpt8.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG8.Text = "D"
S700LabelG8.ForeColor = Color.Black
S700labelpt8.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG8.Text = "C"
S700LabelG8.ForeColor = Color.Black
S700labelpt8.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG8.Text = "B"
S700LabelG8.ForeColor = Color.Black
S700labelpt8.Text = "4"
ElseIf (grade > 69) Then
S700LabelG8.Text = "A"
S700LabelG8.ForeColor = Color.Black
S700labelpt8.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN9.Click
S700ComboBoxCN9.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN9.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN9.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN9.SelectedItem.ToString
S700ButtonCN9.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN9.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU9.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU9.Text = "-"
            S700LabelCN9.Text = "-"
            S700LabelQP9.Text = "-"
            S700TextBoxCN9.Enabled = False
            S700LabelG9.Text = "-"
            S700ButtonCN9.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN9.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level9()
Else
End If
Call S700TextBoxcn9_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN9.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN9.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN9.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN9.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG9.Text = "F"
S700LabelG9.ForeColor = Color.Red
S700labelpt9.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG9.Text = "E"
S700LabelG9.ForeColor = Color.Black
S700labelpt9.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG9.Text = "D"
S700LabelG9.ForeColor = Color.Black
S700labelpt9.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG9.Text = "C"
S700LabelG9.ForeColor = Color.Black
S700labelpt9.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG9.Text = "B"
S700LabelG9.ForeColor = Color.Black
S700labelpt9.Text = "4"
ElseIf (grade > 69) Then
S700LabelG9.Text = "A"
S700LabelG9.ForeColor = Color.Black
S700labelpt9.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN10.Click
S700ComboBoxCN10.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN10.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN10.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN10.SelectedItem.ToString
S700ButtonCN10.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN10.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU10.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU10.Text = "-"
            S700LabelCN10.Text = "-"
            S700LabelQP10.Text = "-"
            S700TextBoxCN10.Enabled = False
            S700LabelG10.Text = "-"
            S700ButtonCN10.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN1.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level10()
Else
End If
Call S700TextBoxcn10_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN10.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN10.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN10.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN10.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG10.Text = "F"
S700LabelG10.ForeColor = Color.Red
S700labelpt10.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG10.Text = "E"
S700LabelG10.ForeColor = Color.Black
S700labelpt10.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG10.Text = "D"
S700LabelG10.ForeColor = Color.Black
S700labelpt10.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG10.Text = "C"
S700LabelG10.ForeColor = Color.Black
S700labelpt10.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG10.Text = "B"
S700LabelG10.ForeColor = Color.Black
S700labelpt10.Text = "4"
ElseIf (grade > 69) Then
S700LabelG10.Text = "A"
S700LabelG10.ForeColor = Color.Black
S700labelpt10.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN11.Click
S700ComboBoxCN11.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN11.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN11.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN11.SelectedItem.ToString
S700ButtonCN11.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN11.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU11.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU11.Text = "-"
            S700LabelCN11.Text = "-"
            S700LabelQP11.Text = "-"
            S700TextBoxCN11.Enabled = False
            S700LabelG11.Text = "-"
            S700ButtonCN11.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN11.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level11()
Else
End If
Call S700TextBoxcn11_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN11.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN11.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN11.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN11.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG11.Text = "F"
S700LabelG11.ForeColor = Color.Red
S700labelpt11.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG11.Text = "E"
S700LabelG11.ForeColor = Color.Black
S700labelpt11.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG11.Text = "D"
S700LabelG11.ForeColor = Color.Black
S700labelpt11.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG11.Text = "C"
S700LabelG11.ForeColor = Color.Black
S700labelpt11.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG11.Text = "B"
S700LabelG11.ForeColor = Color.Black
S700labelpt11.Text = "4"
ElseIf (grade > 69) Then
S700LabelG11.Text = "A"
S700LabelG11.ForeColor = Color.Black
S700labelpt11.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN12.Click
S700ComboBoxCN12.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN12.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN12.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN12.SelectedItem.ToString
S700ButtonCN12.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN12.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU12.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU12.Text = "-"
            S700LabelCN12.Text = "-"
            S700LabelQP12.Text = "-"
            S700TextBoxCN12.Enabled = False
            S700LabelG12.Text = "-"
            S700ButtonCN12.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN12.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level12()
Else
End If
Call S700TextBoxcn12_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN12.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN12.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN12.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN12.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG12.Text = "F"
S700LabelG12.ForeColor = Color.Red
S700labelpt1.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG12.Text = "E"
S700LabelG12.ForeColor = Color.Black
S700labelpt12.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG12.Text = "D"
S700LabelG12.ForeColor = Color.Black
S700labelpt12.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG12.Text = "C"
S700LabelG12.ForeColor = Color.Black
S700labelpt12.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG12.Text = "B"
S700LabelG12.ForeColor = Color.Black
S700labelpt12.Text = "4"
ElseIf (grade > 69) Then
S700LabelG12.Text = "A"
S700LabelG12.ForeColor = Color.Black
S700labelpt12.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN13.Click
S700ComboBoxCN13.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN13.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN13.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN13.SelectedItem.ToString
S700ButtonCN13.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN13.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU13.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU13.Text = "-"
            S700LabelCN13.Text = "-"
            S700LabelQP13.Text = "-"
            S700TextBoxCN13.Enabled = False
            S700LabelG13.Text = "-"
            S700ButtonCN13.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN13.Enabled = True
            Call oleku()
        End If
Dim alako As Integer = Val(S700ListBoxHopecode.Items.Count)
If alako > 1 Then
Call S700level13()
Else
End If
Call S700TextBoxcn13_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN13.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN13.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN13.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN13.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG13.Text = "F"
S700LabelG13.ForeColor = Color.Red
S700labelpt13.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG13.Text = "E"
S700LabelG13.ForeColor = Color.Black
S700labelpt13.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG13.Text = "D"
S700LabelG13.ForeColor = Color.Black
S700labelpt13.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG13.Text = "C"
S700LabelG13.ForeColor = Color.Black
S700labelpt13.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG13.Text = "B"
S700LabelG13.ForeColor = Color.Black
S700labelpt13.Text = "4"
ElseIf (grade > 69) Then
S700LabelG13.Text = "A"
S700LabelG13.ForeColor = Color.Black
S700labelpt13.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub
Private Sub S700ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN14.Click
S700ComboBoxCN14.Items.Clear()
Call hope()
For i = 0 To S700ListBoxHopecode.Items.Count - 1
Dim onyii As String
onyii = S700ListBoxHopecode.Items(i).ToString
S700ComboBoxCN14.Items.Add(onyii)
Next
End Sub
Private Sub S700ComboBoxCN14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700ComboBoxCN14.SelectedIndexChanged
Dim course As String
course = S700ComboBoxCN14.SelectedItem.ToString
S700ButtonCN14.Text = course
For i = 0 To S700ListBoxCourseCode.Items.Count - 1
If course = S700ListBoxCourseCode.Items(i).ToString Then
S700LabelCN14.Text = S700ListBoxCourseName.Items(i).ToString
S700LabelCU14.Text = S700ListBoxCreditUnit.Items(i).ToString
End If
Next
Call totalcreditunit()
Call totalqp()
        If Val(s700TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S700LabelCU14.Text = "-"
            S700LabelCN14.Text = "-"
            S700LabelQP14.Text = "-"
            S700TextBoxCN14.Enabled = False
            S700LabelG14.Text = "-"
            S700ButtonCN14.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S700TextBoxCN14.Enabled = True
            Call oleku()
        End If
Call S700TextBoxcn14_TextChanged(sender, e)
End Sub
Private Sub S700TextBoxcn14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S700TextBoxCN14.TextChanged
Dim onecharacter As Char
Dim name As String
name = S700TextBoxCN14.Text
For i = 0 To name.Length - 1
onecharacter = name.Chars(i)
If IsNumeric(onecharacter) = False Then
S700TextBoxCN14.Clear()
End If
Next
Dim grade As Integer = Val(S700TextBoxCN14.Text)
If grade < 0 Then
MsgBox("YOUR SCORE CAN'T BE NEGATIVE")
ElseIf (grade > -1) And (grade < 40) Then
S700LabelG14.Text = "F"
S700LabelG14.ForeColor = Color.Red
S700labelpt14.Text = "0"
ElseIf (grade > 39) And (grade < 45) Then
S700LabelG14.Text = "E"
S700LabelG14.ForeColor = Color.Black
S700labelpt14.Text = "1"
ElseIf (grade > 44) And (grade < 50) Then
S700LabelG14.Text = "D"
S700LabelG14.ForeColor = Color.Black
S700labelpt14.Text = "2"
ElseIf (grade > 49) And (grade < 60) Then
S700LabelG14.Text = "C"
S700LabelG14.ForeColor = Color.Black
S700labelpt14.Text = "3"
ElseIf (grade > 59) And (grade < 70) Then
S700LabelG14.Text = "B"
S700LabelG14.ForeColor = Color.Black
S700labelpt14.Text = "4"
ElseIf (grade > 69) Then
S700LabelG14.Text = "A"
S700LabelG14.ForeColor = Color.Black
S700labelpt14.Text = "5"
End If
Call totalcreditunit()
Call totalqp()
Call hope()
End Sub

    Private Sub S300ComboboxCN1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles S300ComboboxCN1.SelectedIndexChanged
        Dim course As String
        course = S300ComboboxCN1.SelectedItem.ToString
        S300ButtonCN1.Text = course
        For i = 0 To S300ListboxCourseCode.Items.Count - 1
            If course = S300ListboxCourseCode.Items(i).ToString Then
                S300LabelCN1.Text = S300ListboxCourseName.Items(i).ToString
                S300LabelCU1.Text = S300ListboxCreditUnit.Items(i).ToString
            End If
        Next
        Call totalcreditunit()
        Call totalqp()
        If Val(s300TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            S300LabelCU1.Text = "-"
            S300LabelCN1.Text = "-"
            S300LabelQP1.Text = "-"
            S300TextboxCN1.Enabled = False
            S300LabelG1.Text = "-"
            S300ButtonCN1.Text = "-"
            Call totalcreditunit()
            Call totalqp()
            Exit Sub
        Else
            S300TextboxCN1.Enabled = True
            Call oleku()
        End If
        Dim alako As Integer = Val(S300ListboxhopeCode.Items.Count)
        If alako > 1 Then
            Call S300level1()
        Else
        End If
        Call S300TextBoxcn1_TextChanged(sender, e)
    End Sub
End Class