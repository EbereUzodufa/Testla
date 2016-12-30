Public Class Subject

    Private Sub Subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        

        If (ButtonOutline.BackColor = Color.Transparent Or ButtonOutline.BackColor = Color.WhiteSmoke) And ButtonMaterial.BackColor = Color.Transparent And Buttonprofile.BackColor = Color.Transparent And Buttonlecturers.BackColor = Color.Transparent Then
            TabControl1.SelectedTab = TabPageOutline
            ButtonOutline.BackColor = Color.WhiteSmoke
            ButtonMaterial.BackColor = Color.Transparent
            Buttonprofile.BackColor = Color.Transparent
            Buttonlecturers.BackColor = Color.Transparent

        ElseIf ButtonOutline.BackColor = Color.Transparent And ButtonMaterial.BackColor = Color.WhiteSmoke And Buttonprofile.BackColor = Color.Transparent And Buttonlecturers.BackColor = Color.Transparent Then

            TabControl1.SelectedTab = TabPagemATERIAL
            ButtonOutline.BackColor = Color.Transparent
            ButtonMaterial.BackColor = Color.WhiteSmoke
            Buttonprofile.BackColor = Color.Transparent
            Buttonlecturers.BackColor = Color.Transparent

        ElseIf ButtonOutline.BackColor = Color.Transparent And ButtonMaterial.BackColor = Color.Transparent And Buttonprofile.BackColor = Color.WhiteSmoke And Buttonlecturers.BackColor = Color.Transparent Then

            TabControl1.SelectedTab = TabPageProfile
            ButtonOutline.BackColor = Color.Transparent
            ButtonMaterial.BackColor = Color.Transparent
            Buttonprofile.BackColor = Color.WhiteSmoke
            Buttonlecturers.BackColor = Color.Transparent

        ElseIf ButtonOutline.BackColor = Color.Transparent And ButtonMaterial.BackColor = Color.Transparent And Buttonprofile.BackColor = Color.Transparent And Buttonlecturers.BackColor = Color.WhiteSmoke Then

            TabControl1.SelectedTab = TabPageLecturer
            ButtonOutline.BackColor = Color.Transparent
            ButtonMaterial.BackColor = Color.Transparent
            Buttonprofile.BackColor = Color.Transparent
            Buttonlecturers.BackColor = Color.WhiteSmoke

        End If



    End Sub

    Private Sub Buttonexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
        Home.Close()
        Splash.Close()
        CGPA.Close()
        Game1.Close()

    End Sub

    Private Sub Buttonexpect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMaterial.Click
        TabControl1.SelectedTab = TabPagemATERIAL
        ButtonOutline.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.WhiteSmoke
        Buttonprofile.BackColor = Color.Transparent
        Buttonlecturers.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonOutline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOutline.Click
        TabControl1.SelectedTab = TabPageOutline
        ButtonOutline.BackColor = Color.WhiteSmoke
        ButtonMaterial.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.Transparent
        Buttonlecturers.BackColor = Color.Transparent
    End Sub

    Private Sub Buttonprofile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonprofile.Click
        TabControl1.SelectedTab = TabPageProfile
        ButtonOutline.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.WhiteSmoke
        Buttonlecturers.BackColor = Color.Transparent

        ' SUB TAB FUNCTION
        If (ButtonScheme.BackColor = Color.Transparent Or ButtonScheme.BackColor = Color.WhiteSmoke) And ButtonCA.BackColor = Color.Transparent And ButtonEXPECT.BackColor = Color.Transparent Then

            TabControlPROFILE.SelectedTab = TabPageSCHEME
            ButtonScheme.BackColor = Color.WhiteSmoke
            ButtonCA.BackColor = Color.Transparent
            ButtonEXPECT.BackColor = Color.Transparent

        ElseIf ButtonScheme.BackColor = Color.Transparent And ButtonCA.BackColor = Color.WhiteSmoke And ButtonEXPECT.BackColor = Color.Transparent Then

            TabControlPROFILE.SelectedTab = TabPageCA
            ButtonScheme.BackColor = Color.Transparent
            ButtonCA.BackColor = Color.WhiteSmoke
            ButtonEXPECT.BackColor = Color.Transparent

        ElseIf ButtonScheme.BackColor = Color.Transparent And ButtonCA.BackColor = Color.Transparent And ButtonEXPECT.BackColor = Color.WhiteSmoke Then

            TabControlPROFILE.SelectedTab = TabPageEXPECT
            ButtonScheme.BackColor = Color.Transparent
            ButtonCA.BackColor = Color.Transparent
            ButtonEXPECT.BackColor = Color.WhiteSmoke

        End If

    End Sub

    Private Sub Buttonlecturers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonlecturers.Click

        TabControl1.SelectedTab = TabPageLecturer
        ButtonOutline.BackColor = Color.Transparent
        ButtonMaterial.BackColor = Color.Transparent
        Buttonprofile.BackColor = Color.Transparent
        Buttonlecturers.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub ButtonScheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonScheme.Click

        TabControlPROFILE.SelectedTab = TabPageSCHEME
        ButtonScheme.BackColor = Color.WhiteSmoke
        ButtonCA.BackColor = Color.Transparent
        ButtonEXPECT.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCA.Click

        TabControlPROFILE.SelectedTab = TabPageCA
        ButtonScheme.BackColor = Color.Transparent
        ButtonCA.BackColor = Color.WhiteSmoke
        ButtonEXPECT.BackColor = Color.Transparent
    End Sub

    Private Sub ButtonEXPECT_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXPECT.Click

        TabControlPROFILE.SelectedTab = TabPageEXPECT
        ButtonScheme.BackColor = Color.Transparent
        ButtonCA.BackColor = Color.Transparent
        ButtonEXPECT.BackColor = Color.WhiteSmoke

    End Sub

   
    Private Sub ButtonClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClose.MouseEnter
        LabelClose.Show()
    End Sub

    Private Sub ButtonClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClose.MouseLeave
        LabelClose.Hide()
    End Sub

    Private Sub Buttonintro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonintro.Click
        Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
        Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
        Dim cha As String = xlpath + "\Resources\Introduction to chemistry.pptx"
        System.Diagnostics.Process.Start(cha)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.google.com/search?newwindow=1&client=opera&hs=yQe&q=equation+in+technical+presentation&oq=equation+in+technical+presentat&gs_l=serp.3.0.33i21.75771.91493.0.94771.37.33.0.2.2.0.512.4832.3-9j3j1.13.0....0...1c.1.64.serp..25.12.3836.i8ml-_7ekG8")
    End Sub

    Private Sub ButtonMaterial1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMaterial1.Click
        Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
        Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
        Dim cha As String = xlpath + "\Resources\ACID.pdf"
        System.Diagnostics.Process.Start(cha)
    End Sub

    Private Sub ButtonINTERMASSTRANS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonINTERMASSTRANS.Click
        Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
        Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
        Dim cha As String = xlpath + "\Resources\Defense slide_U2010_3030010.pptx"
        System.Diagnostics.Process.Start(cha)
    End Sub

    Private Sub Buttongasliquidopertn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttongasliquidopertn.Click
        Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
        Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
        Dim cha As String = xlpath + "\Resources\Chydum Project.pptx"
        System.Diagnostics.Process.Start(cha)
    End Sub
End Class