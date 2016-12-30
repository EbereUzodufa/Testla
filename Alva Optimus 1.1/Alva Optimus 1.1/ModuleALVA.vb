Module ModuleALVA
    ' publicly declaring some terms
    Public coursename As String
    Public coursecode As String
    Public onecharacter As Char
    Public colorz As Color
    Public settings As New My.MySettings
    Public strifile As String
    Public Sub pictures()
        Home.PictureBoxHOME.BackgroundImage = Image.FromFile(strifile)
        Home.PictureBoxHOME.BackgroundImageLayout = ImageLayout.Stretch
        Subject.PictureBoxCHM130.BackgroundImage = Image.FromFile(strifile)
        Subject.PictureBoxCHM130.BackgroundImageLayout = ImageLayout.Stretch
        cgpa.PictureBoxCGPA.BackgroundImage = Image.FromFile(strifile)
        cgpa.PictureBoxCGPA.BackgroundImageLayout = ImageLayout.Stretch
        Outline.PictureBoxOutline.BackgroundImage = Image.FromFile(strifile)
        Outline.PictureBoxOutline.BackgroundImageLayout = ImageLayout.Stretch
        Aftersplash.PictureBox5.BackgroundImage = Image.FromFile(strifile)
        Aftersplash.PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        Smart.PictureBox5.BackgroundImage = Image.FromFile(strifile)
        Smart.PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Public Sub colors()
        ' back color of tabpage for year 1
        colorz = Subject.BackColor
        Subject.CAL100TabPageGES1001.BackColor = colorz
        Subject.CAL100TabPageGES1021.BackColor = colorz
        Subject.CAL100TabPageCHM1301.BackColor = colorz
        Subject.CAL100TabPagePHY1011.BackColor = colorz
        Subject.CAL100TabPagePHY1021.BackColor = colorz
        Subject.CAL100TabPageMTH1101.BackColor = colorz
        Subject.CAL100TabPageMTH1201.BackColor = colorz
        Subject.CAL100TabPageENG1021.BackColor = colorz
        Subject.CAL100TabPageGES1012.BackColor = colorz
        Subject.CAL100TabPageGES1032.BackColor = colorz
        Subject.CAL100TabPageCHM1312.BackColor = colorz
        Subject.CAL100TabPageCHM1322.BackColor = colorz
        Subject.CAL100TabPagePHY1122.BackColor = colorz
        Subject.CAL100TabPagePHY1022.BackColor = colorz
        Subject.CAL100TabPageMTH1242.BackColor = colorz
        Subject.CAL100TabPageENG1022.BackColor = colorz
        Subject.CAL100TabPageENG1032.BackColor = colorz
        Subject.CAL100TabPageENG1042.BackColor = colorz
        Subject.SchemeL100TabPageGES1001.BackColor = colorz
        Subject.SchemeL100TabPageGES1021.BackColor = colorz
        Subject.SchemeL100TabPageCHM1301.BackColor = colorz
        Subject.SchemeL100TabPagePHY1011.BackColor = colorz
        Subject.SchemeL100TabPagePHY1021.BackColor = colorz
        Subject.SchemeL100TabPageMTH1101.BackColor = colorz
        Subject.SchemeL100TabPageMTH1201.BackColor = colorz
        Subject.SchemeL100TabPageENG1021.BackColor = colorz
        Subject.SchemeL100TabPageGES1012.BackColor = colorz
        Subject.SchemeL100TabPageGES1032.BackColor = colorz
        Subject.SchemeL100TabPageCHM1312.BackColor = colorz
        Subject.SchemeL100TabPageCHM1322.BackColor = colorz
        Subject.SchemeL100TabPagePHY1122.BackColor = colorz
        Subject.SchemeL100TabPagePHY1022.BackColor = colorz
        Subject.SchemeL100TabPageMTH1242.BackColor = colorz
        Subject.SchemeL100TabPageENG1022.BackColor = colorz
        Subject.SchemeL100TabPageENG1032.BackColor = colorz
        Subject.SchemeL100TabPageENG1042.BackColor = colorz
        Subject.LECTL100TabPageGES1001.BackColor = colorz
        Subject.LECTL100TabPageGES1021.BackColor = colorz
        Subject.LECTL100TabPageCHM1301.BackColor = colorz
        Subject.LECTL100TabPagePHY1011.BackColor = colorz
        Subject.LECTL100TabPagePHY1021.BackColor = colorz
        Subject.LECTL100TabPageMTH1101.BackColor = colorz
        Subject.LECTL100TabPageMTH1201.BackColor = colorz
        Subject.LECTL100TabPageENG1021.BackColor = colorz
        Subject.LECTL100TabPageGES1012.BackColor = colorz
        Subject.LECTL100TabPageGES1032.BackColor = colorz
        Subject.LECTL100TabPageCHM1312.BackColor = colorz
        Subject.LECTL100TabPageCHM1322.BackColor = colorz
        Subject.LECTL100TabPagePHY1122.BackColor = colorz
        Subject.LECTL100TabPagePHY1022.BackColor = colorz
        Subject.LECTL100TabPageMTH1242.BackColor = colorz
        Subject.LECTL100TabPageENG1022.BackColor = colorz
        Subject.LECTL100TabPageENG1032.BackColor = colorz
        Subject.LECTL100TabPageENG1042.BackColor = colorz
        Subject.MaterialL100TabPageGES1001.BackColor = colorz
        Subject.MaterialL100TabPageGES1021.BackColor = colorz
        Subject.MaterialL100TabPageCHM1301.BackColor = colorz
        Subject.MaterialL100TabPagePHY1011.BackColor = colorz
        Subject.MaterialL100TabPagePHY1021.BackColor = colorz
        Subject.MaterialL100TabPageMTH1101.BackColor = colorz
        Subject.MaterialL100TabPageMTH1201.BackColor = colorz
        Subject.MaterialL100TabPageENG1021.BackColor = colorz
        Subject.MaterialL100TabPageGES1012.BackColor = colorz
        Subject.MaterialL100TabPageGES1032.BackColor = colorz
        Subject.MaterialL100TabPageCHM1312.BackColor = colorz
        Subject.MaterialL100TabPageCHM1322.BackColor = colorz
        Subject.MaterialL100TabPagePHY1122.BackColor = colorz
        Subject.MaterialL100TabPagePHY1022.BackColor = colorz
        Subject.MaterialL100TabPageMTH1242.BackColor = colorz
        Subject.MaterialL100TabPageENG1022.BackColor = colorz
        Subject.MaterialL100TabPageENG1032.BackColor = colorz
        Subject.MaterialL100TabPageENG1042.BackColor = colorz
        Subject.ExpectL100TabPageGES1001.BackColor = colorz
        Subject.ExpectL100TabPageGES1021.BackColor = colorz
        Subject.ExpectL100TabPageCHM1301.BackColor = colorz
        Subject.ExpectL100TabPagePHY1011.BackColor = colorz
        Subject.ExpectL100TabPagePHY1021.BackColor = colorz
        Subject.ExpectL100TabPageMTH1101.BackColor = colorz
        Subject.ExpectL100TabPageMTH1201.BackColor = colorz
        Subject.ExpectL100TabPageENG1021.BackColor = colorz
        Subject.ExpectL100TabPageGES1012.BackColor = colorz
        Subject.ExpectL100TabPageGES1032.BackColor = colorz
        Subject.ExpectL100TabPageCHM1312.BackColor = colorz
        Subject.ExpectL100TabPageCHM1322.BackColor = colorz
        Subject.ExpectL100TabPagePHY1122.BackColor = colorz
        Subject.ExpectL100TabPagePHY1022.BackColor = colorz
        Subject.ExpectL100TabPageMTH1242.BackColor = colorz
        Subject.ExpectL100TabPageENG1022.BackColor = colorz
        Subject.ExpectL100TabPageENG1032.BackColor = colorz
        Subject.ExpectL100TabPageENG1042.BackColor = colorz

    End Sub
    Public Sub klose()  ' closes all form in the list 
        Tester.Close()
        hider.Close()
        Home.Close()
        Subject.Close()
        Smart.Close()
        Splash.Close()
        Aftersplash.Close()
        cgpa.Close()
    End Sub
    Public Sub thecoursecode()
        Subject.Labelcoursecode.Text = coursecode
        Subject.Labelcoursename.Text = coursename
        ' onecharacter = coursecode.Chars(4)
        'MsgBox(coursecode & vbNewLine & coursename)
    End Sub
    Public Sub center()
        Outline.Labelcoursecode.Text = coursecode
        Outline.Labelcoursename.Text = coursename
        Subject.Labelcoursecode.Left = (Subject.Labelcoursecode.Parent.Width / 2) - (Subject.Labelcoursecode.Width / 2)
        Subject.Labelcoursename.Left = (Subject.Labelcoursename.Parent.Width / 2) - (Subject.Labelcoursename.Width / 2)
        Outline.Labelcoursecode.Left = (Outline.Labelcoursecode.Parent.Width / 2) - (Outline.Labelcoursecode.Width / 2)
        Outline.Labelcoursename.Left = (Outline.Labelcoursename.Parent.Width / 2) - (Outline.Labelcoursename.Width / 2)
        Outline.Labeloutline.Left = (Outline.Labeloutline.Parent.Width / 2) - (Outline.Labeloutline.Width / 2)
    End Sub
    Public Sub thenames()
        Home.Labelusername.Text = settings.labelname
        Subject.Labelusername.Text = settings.labelname
        cgpa.Labelusername.Text = settings.labelname
        Outline.Labelusername.Text = settings.labelname
        Smart.TextBoxname.Text = settings.labelname
        strifile = settings.pictureloKat
    End Sub
    Public Sub smartnames()
        Home.Labelusername.Text = Smart.TextBoxname.Text
        Subject.Labelusername.Text = Smart.TextBoxname.Text
        cgpa.Labelusername.Text = Smart.TextBoxname.Text
        Outline.Labelusername.Text = Smart.TextBoxname.Text
    End Sub
    Public Sub aftersplashnames()
        Home.Labelusername.Text = Aftersplash.TextBoxname.Text
        Subject.Labelusername.Text = Aftersplash.TextBoxname.Text
        cgpa.Labelusername.Text = Aftersplash.TextBoxname.Text
        Outline.Labelusername.Text = Aftersplash.TextBoxname.Text
        Smart.TextBoxname.Text = Aftersplash.TextBoxname.Text
    End Sub
    Public Sub ALvaicon()
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\icon.png"
            strifile = cha
            Call pictures()
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\icon.png"
            strifile = cha
            Call pictures()
        End Try
    End Sub
End Module
