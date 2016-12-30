Public Class Kara100
    Dim JFK As Integer
    Dim stringReader As New RichTextBox
    Dim labelKi, labelKK As New Label
    Dim ghi As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using OFD As New OpenFileDialog
                OFD.Multiselect = False
                If OFD.ShowDialog = DialogResult.OK Then
                    Dim FolderPath As String = IO.Path.GetDirectoryName(OFD.FileName)
                    Dim FileName As String = IO.Path.GetFileName(OFD.FileName)
                    Dim objShell As Shell32.Shell = CType(CreateObject("Shell.Application"), Shell32.Shell)
                    Dim objFolder As Shell32.Folder = CType(objShell.NameSpace(FolderPath.ToString), Shell32.Folder)

                    'These are for mp3 files only

                    Label1.Text = "Duration: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 27)
                    Dim zz As String = objFolder.GetDetailsOf(objFolder.ParseName(FileName), 27)
                    Dim TotalS As Integer = (Val(zz(6)) * 10) + Val(zz(7)) + (((Val(zz(4))) + (Val(zz(3)) * 10)) * 60) + (((Val(zz(1))) + (Val(zz(0)) * 10)) * 60 * 60)
                    Dim TotalM As Integer = (Val(zz(3)) * 10) + Val(zz(4)) + (((Val(zz(1))) + (Val(zz(0)) * 10)) * 60)
                    Label2.Text = "Duration in Seconds: " + TotalS.ToString
                    Label3.Text = "Duration in minutes: " + TotalM.ToString + ":" + zz(6) + zz(7)
                    JFK = TotalS
                    Label4.ForeColor = Color.SeaGreen
                    Label4.Text = JFK.ToString
                    Timer1.Enabled = True
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Users\Ebere\documents\visual studio 2013\Projects\Testla\Testla\gg\j.txt")
        Dim stringReader As New RichTextBox
        stringReader.Text = fileReader.ReadToEnd()
        ghi = stringReader.Lines.Count - 1
        ' MsgBox(ghi)
        Dim SP(ghi) As Integer 'Start Point
        Dim EP(ghi) As Integer 'End point
    End Sub

    Private Sub Kara100_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim j, k As Integer
        j = LblLine1.Location.X
        k = LblLine1.Location.Y
        Label6.Text = j.ToString + vbNewLine + k.ToString

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a As Integer = Val(Label4.Text)
        a = a - 1
        If a > 9 Then
            Label4.Text = a
        ElseIf a < 10 Then
            Label4.Text = "0" + a.ToString
        ElseIf a = 0 Then
            Timer1.Enabled = False
            Label4.ForeColor = Color.Red
        End If


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles LblLine1.Click, LblLine4.Click, LblLine3.Click, LblLine2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Try
            Dim fileReader As System.IO.StreamReader
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim PathFinder As String = xlpath + "\Lyrics\JustTheWayYouAre.txt"
            fileReader =
                My.Computer.FileSystem.OpenTextFileReader(PathFinder)
            stringReader.Text = fileReader.ReadToEnd()
            ghi = stringReader.Lines.Count - 1
            MsgBox(ghi.ToString + "G")
        Catch ex As Exception
            Dim fileReader As System.IO.StreamReader
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim PathFinder As String = xlpath + "\Debug\Lyrics\JustTheWayYouAre.txt"
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader(PathFinder)
            stringReader.Text = fileReader.ReadToEnd()
            ghi = stringReader.Lines.Count - 1
            MsgBox(ghi.ToString + "GG")
        End Try


        'Dim j As Integer = Val(TextBox1.Text)
        'Dim hola As String = stringReader.Lines(j)
        'Dim zed As Integer = hola.Length
        'LblLine1.Text = hola
        'LblLine4.Text = hola
        'central()
        'Dim o, k, ze As Integer
        'o = LblLine1.Location.X
        'k = LblLine1.Location.Y
        'ze = LblLine1.Parent.Width
        'Label6.Text = o.ToString + vbNewLine + k.ToString + vbNewLine + zed.ToString
        ' Timer2.Enabled = True
    End Sub

    Private Sub central()

        LblLine1.Left = (((LblLine1.Parent.Width) / 2) - ((LblLine1.Width) / 2))
        LblLine2.Left = (((LblLine2.Parent.Width) / 2) - ((LblLine2.Width) / 2))
        LblLine3.Left = (((LblLine3.Parent.Width) / 2) - ((LblLine3.Width) / 2))
        LblLine4.Left = (((LblLine4.Parent.Width) / 2) - ((LblLine4.Width) / 2))

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim a As Integer = Val(Labelk.Text)
        a = a + 1
        Labelk.Text = a

        If a - 1 = ghi + 1 Then
            Timer2.Enabled = False
        Else
            LblLine1.Text = stringReader.Lines(a - 1)
            central()
        End If

    End Sub

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        RichTextBox1.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim fileReader As System.IO.StreamReader

        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim PathFinder As String = xlpath + "\Lyrics\JustTheWayYouAre.txt"
            fileReader =
                My.Computer.FileSystem.OpenTextFileReader(PathFinder)
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim PathFinder As String = xlpath + "\Debug\Lyrics\JustTheWayYouAre.txt"
            fileReader =
                My.Computer.FileSystem.OpenTextFileReader(PathFinder)
        End Try

        RichTextBox1.Text = fileReader.ReadToEnd()
        Dim thot As Integer

        For i = 0 To RichTextBox1.Lines.Count - 1
            thot = thot + 1
            If thot < 3 Then
                'ListBox1.Items.Add(RichTextBox1.Lines(i))
            ElseIf (thot = 3) Then
                ListBox2.Items.Add(RichTextBox1.Lines(i))
            ElseIf thot = 4 Then
                ListBox2.Items.Add(RichTextBox1.Lines(i))
                thot = 0 'Oh my gosh! Who does more than 3 thots?
            End If
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button4_Click(sender, e)
        LblLine1.Text = RichTextBox1.Lines(0)
        LblLine2.Text = RichTextBox1.Lines(1)
        LblLine3.Text = RichTextBox1.Lines(2)
        LblLine4.Text = RichTextBox1.Lines(3)
        Labelk.Text = 4
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim b As Integer = Val(labelKi.Text) 'lineNo
        Dim a As Integer = Val(Labelk.Text) 'counter

        a = a + 2
        Labelk.Text = a
        b = a - 1
        LabelKKi.Text = b.ToString
        Labelk.Text = a.ToString
        Dim counts As Integer = Val(RichTextBox1.Lines.Count) - a 'keep if weshouldcont.

        'If a - 1 = ghi + 1 Then
        '    Timer2.Enabled = False
        'Else
        '    LblLine1.Text = stringReader.Lines(a - 1)
        '    central()
        'End If


        'Switch
        If Labelk.ForeColor = Color.Black Then

            If counts = 0 Then
                LblLine1.Text = RichTextBox1.Lines(b - 1)
                LblLine2.Text = RichTextBox1.Lines(b)
                Labelk.ForeColor = Color.Red
                Timer3.Enabled = False
                LblLine1.ForeColor = Color.Red
                LblLine2.ForeColor = Color.Red
                LblLine3.ForeColor = Color.Black
                LblLine4.ForeColor = Color.Black
            ElseIf counts = -1 Then
                LblLine1.Text = RichTextBox1.Lines(b - 1)
                LblLine2.Text = "<last>"
                Labelk.ForeColor = Color.Red
                Timer3.Enabled = False
                LblLine1.ForeColor = Color.Red
                LblLine2.ForeColor = Color.Red
                LblLine3.ForeColor = Color.Black
                LblLine4.ForeColor = Color.Black
            ElseIf counts > 0 Then
                LblLine1.Text = RichTextBox1.Lines(b - 1)
                LblLine2.Text = RichTextBox1.Lines(b)
                Labelk.ForeColor = Color.Red
                LblLine1.ForeColor = Color.Red
                LblLine2.ForeColor = Color.Red
                LblLine3.ForeColor = Color.Black
                LblLine4.ForeColor = Color.Black
            End If

        ElseIf Labelk.ForeColor = Color.Red Then
            
            If counts = 0 Then
                LblLine3.Text = RichTextBox1.Lines(b - 1)
                LblLine4.Text = RichTextBox1.Lines(b)
                Labelk.ForeColor = Color.Black
                Timer3.Enabled = False
                LblLine1.ForeColor = Color.Black
                LblLine2.ForeColor = Color.Black
                LblLine3.ForeColor = Color.Red
                LblLine4.ForeColor = Color.Red
            ElseIf counts = -1 Then
                LblLine3.Text = RichTextBox1.Lines(b - 1)
                LblLine4.Text = "<last>"
                Labelk.ForeColor = Color.Black
                Timer3.Enabled = False
                LblLine1.ForeColor = Color.Black
                LblLine2.ForeColor = Color.Black
                LblLine3.ForeColor = Color.Red
                LblLine4.ForeColor = Color.Red
            ElseIf counts > 0 Then
                LblLine3.Text = RichTextBox1.Lines(b - 1)
                LblLine4.Text = RichTextBox1.Lines(b)
                Labelk.ForeColor = Color.Black
                LblLine1.ForeColor = Color.Black
                LblLine2.ForeColor = Color.Black
                LblLine3.ForeColor = Color.Red
                LblLine4.ForeColor = Color.Red
            End If

        End If

    End Sub
End Class