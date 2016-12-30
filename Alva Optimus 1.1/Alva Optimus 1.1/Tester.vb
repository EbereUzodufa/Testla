Public Class Tester

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Resources\Chydum.ppsx"
            System.Diagnostics.Process.Start(cha)
            Label1.Text = cha
        Catch ex As Exception
            Dim exedir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
            Dim xlpath = IO.Path.Combine(exedir.DirectoryName)
            Dim cha As String = xlpath + "\Debug\Resources\Chydum.ppsx"
            System.Diagnostics.Process.Start(cha)
            Label1.Text = cha
        End Try
    End Sub
End Class
