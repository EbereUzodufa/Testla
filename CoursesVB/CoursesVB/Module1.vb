Imports System.Data.OleDb
Imports System.IO
Module Module1

    Public conntext As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Ebere\Documents\Ms Database\ALVA practice.accdb"
    Public conn As New OleDbConnection(conntext)
    Public cmd As New OleDbCommand
    Public cmd1, cmd2, cmd3 As New OleDbCommand
    Public adapter, adapterLect, adapterCourse, adaptersession As New OleDbDataAdapter ' array doesn't work
    Public DBTable, DBTableLect, DBTableCourse, DBTableSession As New DataTable
   
    ' My other components
    Public LstLectName, LstLectID, LstCourseID, LstCourseName, LstSessID, LstSession As New ListBox 'Listbox from my DB


    Public Sub GetLectName() 'Get Lectures name and ID

        Dim sql As String = "SELECT * FROM tblLecturers"
        cmd = New OleDbCommand(sql, conn)

        Try
            conn.Open()
            'Using adapter to get values at table
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(DBTable)
            For Each item In DBTable.Rows
                LstLectID.Items.Add(item(1)) 'Note that rows in DB starts counting from 0
                LstLectName.Items.Add(item(7))
            Next

            DBTable.Rows.Clear()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
    Public Sub GetCourse() 'Get Lectures name and ID

        Dim sql As String = "SELECT * FROM tblCourses"
        cmd = New OleDbCommand(sql, conn)

        Try
            conn.Open()
            'Using adapter to get values at table
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(DBTable)
            For Each item In DBTable.Rows
                LstCourseID.Items.Add(item(0)) 'Note that rows in DB starts counting from 0
                LstCourseName.Items.Add(item(1))
            Next

            DBTable.Rows.Clear()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
    Public Sub GetSession() 'Get Lectures name and ID

        Dim sql As String = "SELECT * FROM tblSession"
        cmd = New OleDbCommand(sql, conn)

        Try
            conn.Open()
            'Using adapter to get values at table
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(DBTable)
            For Each item In DBTable.Rows
                LstSessID.Items.Add(item(0)) 'Note that rows in DB starts counting from 0
                LstSession.Items.Add(item(1))
            Next

            DBTable.Rows.Clear()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
    Public Sub GoGetter()
        Dim sql1 As String = "SELECT * FROM tblLecturers"
        Dim sql2 As String = "SELECT * FROM tblCourses"
        Dim sql3 As String = "SELECT * FROM tblSession"

        cmd1 = New OleDbCommand(sql1, conn)
        cmd2 = New OleDbCommand(sql2, conn)
        cmd3 = New OleDbCommand(sql3, conn)

        Try
            conn.Open()
            'Using adapter to get values at table
            adapterLect = New OleDbDataAdapter(cmd1)
            adapterCourse = New OleDbDataAdapter(cmd2)
            adaptersession = New OleDbDataAdapter(cmd3)
            adapterLect.Fill(DBTableLect)
            adapterCourse.Fill(DBTableCourse)
            adaptersession.Fill(DBTableSession)
           
            For Each item In DBTableLect.Rows
                LstLectID.Items.Add(item(0)) 'Note that rows in DB starts counting from 0
                LstLectName.Items.Add(item(7))
            Next
            For Each item In DBTableCourse.Rows
                LstCourseID.Items.Add(item(0)) 'Note that rows in DB starts counting from 0
                LstCourseName.Items.Add(item(1))
            Next
            For Each item In DBTableSession.Rows
                LstSessID.Items.Add(item(0)) 'Note that rows in DB starts counting from 0
                LstSession.Items.Add(item(1))
            Next
            DBTableLect.Rows.Clear()
            DBTableCourse.Rows.Clear()
            DBTableSession.Rows.Clear()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

End Module
