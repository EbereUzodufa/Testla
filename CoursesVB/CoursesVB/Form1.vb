Imports System.IO
Imports System.Data.OleDb
Public Class Form1
    Dim LstCrazy, LstCourN As New ListBox
    Dim lstChCourse, LstChSessID, LstChLectID As New ListBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabControl1.SelectedTab = TabPageAddCou
        GoGetter()
        transfer()
        Label5.Text = ""
        checker()
    End Sub
    Private Sub trans()
        ' transfer
        For Each item In LstCourseID.Items
            ListBoxCourses.Items.Add(item)
        Next
        For Each item In LstCourseName.Items
            LstCourN.Items.Add(item)
        Next

    End Sub
    Private Sub fer()
        For Each hiz In LstLectName.Items
            ComboBoxLect.Items.Add(hiz)
        Next
        For Each iz In LstSession.Items
            ComboBoxsession.Items.Add(iz)
        Next
    End Sub
    Private Sub transfer()
        trans()
        fer()
    End Sub
    Private Sub AddButton()
       
        ListBoxLectCourses.Items.Add(ListBoxCourses.SelectedItem)
        Dim k As Integer = ListBoxCourses.SelectedIndex
        LstCourN.SelectedIndex = k
        LstCrazy.Items.Add(LstCourN.SelectedItem)
        ListBoxLectCourses.SelectedIndex = ListBoxLectCourses.Items.Count - 1
        Dim z As Integer = ListBoxCourses.SelectedIndex
        ListBoxCourses.Items.RemoveAt(z)
        LstCourN.Items.RemoveAt(z)
        ButtonAdd.Enabled = False
        ButtonDelete.Enabled = True

    End Sub
    Private Sub DeleteButton()
        
            ListBoxCourses.Items.Add(ListBoxLectCourses.SelectedItem)
            Dim k As Integer = ListBoxLectCourses.SelectedIndex
            LstCrazy.SelectedIndex = k
            LstCourN.Items.Add(LstCrazy.SelectedItem)
            ListBoxCourses.SelectedIndex = ListBoxCourses.Items.Count - 1
            Dim z As Integer = ListBoxLectCourses.SelectedIndex
            ListBoxLectCourses.Items.RemoveAt(z)
            LstCrazy.Items.RemoveAt(z)
        ButtonAdd.Enabled = True
        ButtonDelete.Enabled = False
    End Sub
    Private Sub ValidatorText()
        Dim viki As String = ComboBoxLect.Text
        Dim fuji As String = ComboBoxsession.Text
        Dim k1, k2 As String
        k1 = "FALSE"
        k2 = "FALSE"
        For Each item In ComboBoxLect.Items
            If viki = item.ToString Then
                k1 = "TRUE"
            Else
                k1 = "FALSE"
                ComboBoxsession.Items.Clear()
                reset()
            End If
        Next

        For Each item In ComboBoxsession.Items
            If fuji = item.ToString Then
                k2 = "TRUE"
            Else
                k2 = "FALSE"
                ComboBoxsession.Items.Clear()
                reset()
            End If
        Next
    End Sub
    Private Sub reset()
        ComboBoxLect.Text = ""
        ListBoxLectCourses.Items.Clear()
        LstCrazy.Items.Clear()
        ListBoxCourses.Items.Clear()
        LstCourN.Items.Clear()
        ButtonAdd.Enabled = False
        ButtonDelete.Enabled = False
        ButtonOK.Enabled = False
        trans()
    End Sub
    Private Sub checker()
        If Trim(ComboBoxLect.Text) = "" Or Trim(ComboBoxsession.Text) = "" Or ListBoxLectCourses.Items.Count = 0 Then
            ButtonOK.Enabled = False
        Else
            ButtonOK.Enabled = True
        End If
        Dim y As Integer = DGV1.Rows.Count
        If DGV1.RowCount < 2 Then
            ButtonUp2DB.Enabled = False
        Else
            ButtonUp2DB.Enabled = True
        End If
    End Sub
    Private Sub ToGDV()

        Dim k As Integer = ComboBoxLect.SelectedIndex
        'Dim i1, i2, i3, i4, i5, i6, i7 As Integer
        'i1 = SN.Index
        'i2 = LectN.Index
        'i3 = CourseCode.Index
        'i4 = CourseName.Index
        'i5 = SessionName.Index
        'i6 = LectID.Index
        'i7 = SessionID.Index

        LstLectID.SelectedIndex = k
        Dim hitz As String = LstLectID.SelectedItem
        Dim kiss As String = ComboBoxLect.SelectedItem
        Dim w As Integer = ComboBoxsession.SelectedIndex
        Dim str As String = ComboBoxsession.SelectedItem
        LstSessID.SelectedIndex = w
        Dim home As String = LstSessID.SelectedItem

        For i = 0 To ListBoxLectCourses.Items.Count - 1
            Dim tape As String = DGV1.Rows.Count.ToString
            ListBoxLectCourses.SelectedIndex = i
            LstCrazy.SelectedIndex = i
            Dim xxx As String = ListBoxLectCourses.SelectedItem
            Dim fck As String = LstCrazy.SelectedItem
            Dim item As String() = New String() {tape, kiss, xxx, fck, str, hitz, home}
            DGV1.Rows.Add(item)

            'DGV1.Rows(i).Cells(i1).Value = tape
            'DGV1.Rows(i).Cells(i2).Value = kiss
            'DGV1.Rows(i).Cells(i3).Value = xxx
            'DGV1.Rows(i).Cells(i4).Value = fck
            'DGV1.Rows(i).Cells(i5).Value = str
            'DGV1.Rows(i).Cells(i6).Value = hitz
            'DGV1.Rows(i).Cells(i7).Value = home

        Next
        reset()

    End Sub

    Private Sub Button3_Click_1()
        Dim y As Integer = DGV1.Rows.Count
        MsgBox(y)
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click 'course
        ' for course
        Try
            If conn.State = ConnectionState.Open Then

            ElseIf conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim hh As String
            cmd.Connection = conn
            For i = 0 To F100ListBoxCourseCode.Items.Count - 1
                Dim coursecode As String = F100ListBoxCourseCode.Items(i).ToString
                Dim coursename As String = F100ListBoxCourseName.Items(i).ToString
                Dim creditunit As String = F100ListBoxCreditUnit.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To S100ListBoxCourseCode.Items.Count - 1
                Dim coursecode As String = S100ListBoxCourseCode.Items(i).ToString
                Dim coursename As String = S100ListBoxCourseName.Items(i).ToString
                Dim creditunit As String = S100ListBoxCreditCode.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To F200ListBoxCourseCode.Items.Count - 1
                Dim coursecode As String = F200ListBoxCourseCode.Items(i).ToString
                Dim coursename As String = F200ListBoxCourseName.Items(i).ToString
                Dim creditunit As String = F200ListBoxCreditUnit.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To S200ListboxCourseCode.Items.Count - 1
                Dim coursecode As String = S200ListboxCourseCode.Items(i).ToString
                Dim coursename As String = S200ListboxCoursenAME.Items(i).ToString
                Dim creditunit As String = S200ListboxCREDITuNIT.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To F300ListBoxCourseCode.Items.Count - 1
                Dim coursecode As String = F300ListBoxCourseCode.Items(i).ToString
                Dim coursename As String = F300ListBoxCourseName.Items(i).ToString
                Dim creditunit As String = F300ListBoxCreditUnit.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To S300ListboxCourseCode.Items.Count - 1
                Dim coursecode As String = S300ListboxCourseCode.Items(i).ToString
                Dim coursename As String = S300ListboxCoursenAMe.Items(i).ToString
                Dim creditunit As String = S300ListboxCREDITUNIT.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To F400ListBoxCourseCode.Items.Count - 1
                Dim coursecode As String = F400ListBoxCourseCode.Items(i).ToString
                Dim coursename As String = F400ListBoxCourseName.Items(i).ToString
                Dim creditunit As String = F400ListBoxCreditUnit.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To S400ListboxCourseCode.Items.Count - 1
                Dim coursecode As String = S400ListboxCourseCode.Items(i).ToString
                Dim coursename As String = S400ListboxCoursenAME.Items(i).ToString
                Dim creditunit As String = S400ListboxCREDITUNIT.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To F500ListboxCourseCode.Items.Count - 1
                Dim coursecode As String = F500ListboxCourseCode.Items(i).ToString
                Dim coursename As String = F500ListboxCourseNAME.Items(i).ToString
                Dim creditunit As String = F500ListboxCREDITuNIT.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            For i = 0 To S500ListboxCourseCode.Items.Count - 1
                Dim coursecode As String = S500ListboxCourseCode.Items(i).ToString
                Dim coursename As String = S500ListboxCoursenAME.Items(i).ToString
                Dim creditunit As String = S500ListboxCREDITUNIT.Items(i).ToString
                Dim gg As String = coursecode
                Dim hz As Integer = gg.Length
                Dim semester As String = gg(hz - 1)
                hh = "'" + coursecode + "','" + coursename + "','" + creditunit + "','" + semester + "'"
                cmd.CommandText = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next

            conn.Close()
            'For Each item As String In F100ListBoxCourseCode.Items
            '    Dim sql As String = 
            '   
            '    cmd.Parameters.AddWithValue("@CourseCode", item)
            '    conn.Open()
            '    cmd.ExecuteNonQueryAsync()
            'Next

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try


        '        Dim CourseCode As String = F100ListBoxCourseCode.Items(i).ToString
        '        Dim CourseName As String = F100ListBoxCourseName.Items(i).ToString
        '        Dim creditunit As Integer = Val(F100ListBoxCreditUnit.Items(i))
        '        Dim gg As String = CourseCode
        '        Dim hz As Integer = gg.Length
        '        Dim semester As String = gg(hz - 1)

        '        'Dim kk As String
        '        'kk = CourseCode + "," + CourseName + "," + creditunit.ToString + "," + semester
        '        'suntext = suntext + vbNewLine + kk
        '        Dim sql As String = "INSERT INTO TblCourses(CourseID,CourseName,CreditUnit,Semester) VALUES(@CourseCode,@CourseName,@creditunit,@semester)"
        '        cmd = New OleDbCommand(sql, conn)
        '        cmd.Parameters.AddWithValue("@CourseCode", CourseCode)
        '        cmd.Parameters.AddWithValue("@CourseName", CourseName)
        '        cmd.Parameters.AddWithValue("@creditunit", creditunit)
        '        cmd.Parameters.AddWithValue("@semester", semester)
        '        conn.Open()
        '        cmd.ExecuteNonQuery()

        '    Next
        '    If cmd.ExecuteNonQuery() > 0 Then
        '        MsgBox("Successful Connection")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    conn.Close()
        'End Try

        'For i = 0 To S100ListBoxCourseCode.Items.Count - 1
        '    Dim hh As String = S100ListBoxCourseCode.Items(i).ToString
        '    comboBox1.Items.Add(hh)
        'Next
        'RichTextBox1.Text = suntext

    End Sub

    Private Sub AddToDB()


        'open connection
        Try


            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub teast()
        Dim h, h1, h2 As String
        h = ListBoxLastName.Parent.Text
        h1 = ((ListBoxLastName.Parent).Parent).Parent.Text 'tabpages are children of tabcontrol
        h2 = ((((ListBoxLastName.Parent).Parent).Parent).Parent).Parent.Text
        MsgBox(h & vbNewLine & h1 & vbNewLine & h2)
    End Sub
    Private Sub testla()
        Try
            Dim puss As Integer = LectID.Index
            Dim dke As Integer = CourseCode.Index
            Dim dck As Integer = SessionID.Index
            Dim haz, ard As Integer
            Dim kar As Integer = DGV1.Rows.Count
            Dim counter As Integer = 0
            ' Dim zz As String = DGV1.Rows(0).Cells(2).Value
            'MsgBox(kar)
            Dim i As Integer
            Dim k As Integer
            'For i = 0 To kar - 2
            '    Dim zz As String = DGV1.Rows(i).Cells(puss).Value
            '    Dim zz1 As String = DGV1.Rows(i).Cells(dke).Value
            '    Dim zz2 As String = DGV1.Rows(i).Cells(dck).Value
            '    ha = zz + " " + zz1 + " " + zz2
            '    ks = ha + vbNewLine + ks
            'Next
            For haz = 0 To kar - 2
                Dim United As String = DGV1.Rows(haz).Cells(dck).Value
                For ard = haz + 1 To kar - 2
                    Dim city As String = DGV1.Rows(ard).Cells(dck).Value
                    If United = city Then
                        For i = 0 To kar - 2
                            Dim zz As String = DGV1.Rows(i).Cells(puss).Value '.ToString
                            Dim hi As String = DGV1.Rows(i).Cells(dke).Value
                            For k = (i + 1) To kar - 2
                                Dim ha As String = DGV1.Rows(k).Cells(dke).Value
                                Dim zz1 As String = DGV1.Rows(k).Cells(puss).Value '.ToString
                                If (zz = zz1) Then
                                    ' MsgBox(zz + " = " + zz1)
                                    If ha = hi Then
                                        'MsgBox(ha + " = " + hi)
                                        MsgBox(("Repete @ S/N " + (i + 1).ToString + "  &  " + (k + 1).ToString), MsgBoxStyle.Information, "REPETATION")
                                        Exit Sub
                                    End If
                                End If
                            Next
                            'ha = zz + " " + zz1 + " " + zz2
                            'ks = ha + vbNewLine + ks
                        Next
                    End If
                Next
            Next

            ' MsgBox(counter)
            ' MsgBox(ks)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
                cmd.Connection = conn
                For i = 0 To kar - 2
                    Dim messi As String = DGV1.Rows(i).Cells(puss).Value
                    Dim suarez As String = DGV1.Rows(i).Cells(dke).Value
                    Dim neymar As String = DGV1.Rows(i).Cells(dck).Value
                    cmd.CommandText = "INSERT INTO tblCourseLecturer(LecturerID,CourseID,SessionID) Values('" + messi + "','" + suarez + "','" + neymar + "')"
                    cmd.ExecuteNonQuery()
                Next
                MsgBox("Successful Executed")
                conn.Close()
                DGV1.Rows.Clear()
            Else
                cmd.Connection = conn
                For i = 0 To kar - 2
                    Dim messi As String = DGV1.Rows(i).Cells(puss).Value
                    Dim suarez As String = DGV1.Rows(i).Cells(dke).Value
                    Dim neymar As String = DGV1.Rows(i).Cells(dck).Value
                    cmd.CommandText = "INSERT INTO tblCourseLecturer(LecturerID,CourseID,SessionID) Values('" + messi + "','" + suarez + "','" + neymar + "')"
                    cmd.ExecuteNonQuery()
                Next
                MsgBox("Successful Executed")
                conn.Close()
                DGV1.Rows.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub SNChecka()
        Dim cj As Integer = DGV1.Rows.Count - 2
        Dim kc As Integer = Val(DGV1.Rows(cj).Cells(0).Value)
        If kc > DGV1.Rows.Count - 1 Then
            For i = 0 To cj
                DGV1.Rows(i).Cells(0).Value = (i + 1).ToString
            Next
        End If
    End Sub
    Private Sub contentchecka()

        lstChCourse.Items.Clear()
        LstChLectID.Items.Clear()
        LstChSessID.Items.Clear()
        Dim beke As Integer = LectID.Index
        Dim bash As Integer = CourseCode.Index
        Dim chydum As Integer = SessionID.Index
        Dim sql As String = "SELECT * FROM tblCourseLecturer"
        cmd = New OleDbCommand(sql, conn)

        Try
            conn.Open()
            'Using adapter to get values at table
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(DBTable)
            For Each item In DBTable.Rows
                LstChLectID.Items.Add(item(1)) 'Note that rows in DB starts counting from 0
                lstChCourse.Items.Add(item(2))
                LstChSessID.Items.Add(item(3))
            Next

            For i = 0 To lstChCourse.Items.Count - 1
                Dim steph As String = LstChLectID.Items(i).ToString
                Dim dozie As String = lstChCourse.Items(i).ToString
                Dim ebere As String = LstChSessID.Items(i).ToString

                For k = 0 To DGV1.Rows.Count - 2
                    Dim the As String = DGV1.Rows(k).Cells(beke).Value
                    Dim incubation As String = DGV1.Rows(k).Cells(bash).Value
                    Dim project As String = DGV1.Rows(k).Cells(chydum).Value
                    Dim xcx As String = DGV1.Rows(k).Cells(0).Value
                    If (steph = the) And (dozie = incubation) And (ebere = project) Then
                        MsgBox("S/N " + xcx + " is already in DB.", MsgBoxStyle.Information, "NOT IN THE PIPELINE")
                        conn.Close()
                        Exit Sub

                    End If
                Next

            Next
            testla()
            DBTable.Rows.Clear()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'lecturers
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            ElseIf conn.State = ConnectionState.Open Then

            End If

            cmd.Connection = conn
            Dim hh As String
            For i = 0 To ListBoxLastName.Items.Count - 1
                Dim j As Integer = i + 1
                Dim LecturerID As String
                If j < 10 Then
                    LecturerID = "ChE-00" + j.ToString
                Else
                    LecturerID = "ChE-0" + j.ToString
                End If
                Dim Lastname As String = ListBoxLastName.Items(i).ToString
                Dim firstname As String = ListBoxFirstName.Items(i).ToString
                Dim Middlename As String = ListBoxMiddleName.Items(i).ToString
                Dim LectHighestHonor As String = ListBoxHH.Items(i).ToString
                Dim dept As String = ListBoxLastName.Parent.Text
                Dim faculty As String = ((ListBoxLastName.Parent).Parent).Parent.Text
                Dim LectUsername As String = LectHighestHonor + " " + Lastname + " " + firstname + "." + Middlename

                hh = "'" + LecturerID + "','" + Lastname + "','" + firstname + "','" + Middlename + "','" + LectHighestHonor + "','" + dept +
                    "','" + faculty + "','" + LectUsername + "'"
                cmd.CommandText = "INSERT INTO tblLecturers(LecturerID,LastName,FirstName,MiddleName,LectHighestHonor,Department,Faculty,LectUserName) VALUES(" + hh + ")"
                cmd.ExecuteNonQuery()
            Next
            MessageBox.Show("Successful")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ListBoxCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCourses.SelectedIndexChanged
        Dim k As Integer = ListBoxCourses.SelectedIndex
        LstCourN.SelectedIndex = k
        Label5.Text = LstCourN.SelectedItem
        ButtonAdd.Enabled = True
        ButtonDelete.Enabled = False
        checker()
    End Sub

    Private Sub ListBoxLectCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLectCourses.SelectedIndexChanged
        Dim k As Integer = ListBoxLectCourses.SelectedIndex
        LstCrazy.SelectedIndex = k
        Label5.Text = LstCrazy.SelectedItem
        ButtonDelete.Enabled = True
        ButtonAdd.Enabled = False
        checker()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AddButton()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        DeleteButton()
    End Sub

    Private Sub ComboBoxLect_Click(sender As Object, e As EventArgs) Handles ComboBoxLect.Click
        'Safety
        If ComboBoxLect.Items.Count = 0 Then
            GoGetter()
        End If
    End Sub

    Private Sub ComboBoxLect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLect.SelectedIndexChanged
        checker()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        '  SNChecka()
        ToGDV()
        checker()
    End Sub

    Private Sub ComboBoxsession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxsession.SelectedIndexChanged
        checker()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonUp2DB.Click
        Try

            If DGV1.Rows.Count < 2 Then
                ButtonUp2DB.Enabled = False
                Exit Sub
            Else
                SNChecka()
                contentchecka()
                ' conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

End Class
