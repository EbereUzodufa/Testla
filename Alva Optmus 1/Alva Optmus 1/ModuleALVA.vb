Module ModuleALVA
    Public settings As New My.MySettings
    Public strfilename As String
    Public Sub klose()
        Home.Close()
        ' Subject.Close()
        Splash.Close()
        '  cgpa.Close()
        '   Game1.Close()
        Smart.Close()
        AfterSplash.Close()
    End Sub
    Public Sub smartstylez()
        Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
        Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
        strfilename = xlpath + "\Resources\icon.png"
    End Sub
    Public Sub vanessa()
        Home.Labelusername.Text = settings.labelname
        Smart.TextBoxname.Text = settings.labelname
        strfilename = settings.picture
        ' Subject.Labelusername.Text = TextBoxname.Text
        ' Game1.Labelusername.Text = TextBoxname.Text
        'cgpa.Labeltitle.Text = TextBoxname.Text
    End Sub
    Public Sub picz()
        Try
            Home.PictureBoxHOME.BackgroundImage = Image.FromFile(strfilename)
            Home.PictureBoxHOME.BackgroundImageLayout = ImageLayout.Stretch
            Smart.PictureBox5.BackgroundImage = Image.FromFile(strfilename)
            Smart.PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
            ' Subject.PictureBoxCHM130.BackgroundImage = Image.FromFile(strFileName)
            '  Subject.PictureBoxCHM130.BackgroundImageLayout = ImageLayout.Stretch
            '  cgpa.PictureBoxCGPA.BackgroundImage = Image.FromFile(strFileName)
            '  cgpa.PictureBoxCGPA.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception
            Call smartstylez()
        End Try

    End Sub
    Public Sub savee()
        settings.labelname = Home.Labelusername.Text
        settings.cheat = strfilename
        settings.Save()
    End Sub
    Public Sub saveereload()
        Call vanessa()
        Call picz()
    End Sub
End Module
