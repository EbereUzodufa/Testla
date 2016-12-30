Imports System.UInt32
Public Class Form1
    Dim file, path As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As Integer = Val(TextBox1.Text)
        Dim f As Integer = Math.Floor(h / 60)
        Dim ff As Integer = h Mod 60
        Dim jj As String = f.ToString + ":" + ff.ToString
        MsgBox(jj)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        RichTextBox1.Text = ""
        Using OFD As New OpenFileDialog
            OFD.Multiselect = False
            If OFD.ShowDialog = DialogResult.OK Then
                Dim FolderPath As String = IO.Path.GetDirectoryName(OFD.FileName)
                Dim FileName As String = IO.Path.GetFileName(OFD.FileName)
                Dim objShell As Shell32.Shell = CType(CreateObject("Shell.Application"), Shell32.Shell)
                Dim objFolder As Shell32.Folder = CType(objShell.NameSpace(FolderPath.ToString), Shell32.Folder)

                Try
                    For i = 0 To 1000
                        RichTextBox1.AppendText(i.ToString & " .. " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), i) & vbCrLf)
                    Next
                Catch ex As Exception
                End Try

                'These are for mp3 files only
                Label1.Text = "File Name: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 0)
                Label2.Text = "File Size: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 1)
                Label3.Text = "Duration: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 27)
                Label4.Text = "Sample Rate: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 33)
                Label5.Text = "Bitrate: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 22)
                Label6.Text = "Channels: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 34)
                Label7.Text = "Modified Date: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 3)
                Label8.Text = "Created Date: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 4)
                Label9.Text = "Accessed Date: " & objFolder.GetDetailsOf(objFolder.ParseName(FileName), 5)
            End If
        End Using
    End Sub
    'Function GetDuration(ByVal MovieFullPath As String) As String
    '    If File.Exists(MovieFullPath) Then
    '        Dim objShell As Object = CreateObject("Shell.Application")
    '        Dim objFolder As Object = _
    '           objShell.Namespace(Path.GetDirectoryName(MovieFullPath))
    '        For Each strFileName In objFolder.Items
    '            If strFileName.Name = Path.GetFileName(MovieFullPath) Then
    '                Return objFolder.GetDetailsOf(strFileName, 21).ToString
    '                Exit For
    '                Exit Function
    '            End If
    '        Next
    '        Return ""
    '    Else
    '        Return ""
    '    End If
    'End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
