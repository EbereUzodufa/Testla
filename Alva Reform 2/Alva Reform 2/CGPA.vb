Public Class CGPA

    Dim maxim As Integer = 24 'this the maximum number of total credit unit
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

    'motherboard
    Private Sub hope()
        Call f100hope()
    End Sub
    Private Sub oleku()
        Call F100oleku()
    End Sub
    Private Sub totalcreditunit()
        Call F100TOtalcreditunit()
    End Sub
    Private Sub totalqp()
        Call F100TOtalqp()
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
        F100ListBoxF.Items.Clear()
        F100ListBoxFC.Items.Clear()
        F100ListBoxFN.Items.Clear()
        For i = 0 To F100ListBoxCourseCode.Items.Count - 1
            Dim morgan As String = F100ListBoxCourseCode.Items(i).ToString
            Dim merlin As String = "F"
            Dim arthur As String = F100ListBoxCourseName.Items(i).ToString
            Dim gwen As String = F100ListBoxCreditUnit.Items(i).ToString
            If (F100ButtonCn1.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN2.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN3.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN4.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN5.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN6.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN7.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN8.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN9.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN10.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN11.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN12.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN13.Text = F100ListBoxCourseCode.Items(i).ToString) Or (F100ButtonCN14.Text = F100ListBoxCourseCode.Items(i).ToString) Then
                F100ListBoxHopecode.Items.Remove(i)
            Else
                F100ListBoxHopecode.Items.Add(morgan)

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
    End Sub
    Private Sub F100TOtalcreditunit()
        Dim f100totalcu As Integer
        f100totalcu = Val(F100LabelCU1.Text) + Val(F100LabelCU2.Text) + Val(F100LabelCU3.Text) + Val(F100LabelCU4.Text) + Val(F100LabelCU5.Text) + Val(F100LabelCU6.Text) + Val(F100LabelCU7.Text) + Val(F100LabelCU8.Text) + Val(F100LabelCU9.Text) + Val(F100LabelCU10.Text) + Val(F100LabelCU11.Text) + Val(F100LabelCU12.Text) + Val(F100LabelCU13.Text) + Val(F100LabelCU14.Text)
        F100TOTALCUlabel.Text = f100totalcu
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
        F100TOTALQPlabel.Text = F100totalqp
        Dim cg As Double
        cg = Val(F100TOTALQPlabel.Text) / Val(F100TOTALCUlabel.Text)
        cg = Math.Round(cg, 2)
        Label100GPA.Text = cg
    End Sub
  
    'f100 comboxes and textboxexs
    Private Sub F100ComboBoxCN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN1.Click
        F100ComboBoxCN1.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU1.Text = "-"
            F100LabelCN1.Text = "-"
            F100LabelQP1.Text = "-"
            F100TextBoxCN1.Enabled = False
            F100LabelG1.Text = "-"
            F100ButtonCn1.Text = "-"
        Else

            F100TextBoxCN1.Enabled = True
            Call oleku()
        End If
        'to make sure is the maximum number of space required
        Dim alako As Integer = Val(F100ListBoxHopecode.Items.Count)
        If alako > 1 Then
            Call F100level1()
        Else

        End If
        Call F100TextBoxCN1_TextChanged(sender, e)

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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN2.Click
        F100ComboBoxCN2.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU2.Text = "-"
            F100LabelCN2.Text = "-"
            F100LabelQP2.Text = "-"
            F100TextBoxCN2.Enabled = False
            F100LabelG2.Text = "-"
            F100ButtonCN2.Text = "-"
        Else

            F100TextBoxCN2.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN3.Click
        F100ComboBoxCN3.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU3.Text = "-"
            F100LabelCN3.Text = "-"
            F100LabelQP3.Text = "-"
            F100TextBoxCN3.Enabled = False
            F100LabelG3.Text = "-"
            F100ButtonCN3.Text = "-"
        Else

            F100TextBoxCN3.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN4.Click
        F100ComboBoxCN4.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU4.Text = "-"
            F100LabelCN4.Text = "-"
            F100LabelQP4.Text = "-"
            F100TextBoxCN4.Enabled = False
            F100LabelG4.Text = "-"
            F100ButtonCN4.Text = "-"
        Else

            F100TextBoxCN4.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN5.Click
        F100ComboBoxCN5.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU5.Text = "-"
            F100LabelCN5.Text = "-"
            F100LabelQP5.Text = "-"
            F100TextBoxCN5.Enabled = False
            F100LabelG5.Text = "-"
            F100ButtonCN5.Text = "-"
        Else

            F100TextBoxCN5.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN6.Click
        F100ComboBoxCN6.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU6.Text = "-"
            F100LabelCN6.Text = "-"
            F100LabelQP6.Text = "-"
            F100TextBoxCN6.Enabled = False
            F100LabelG6.Text = "-"
            F100ButtonCN6.Text = "-"
        Else

            F100TextBoxCN6.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN7.Click
        F100ComboBoxCN7.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU7.Text = "-"
            F100LabelCN7.Text = "-"
            F100LabelQP7.Text = "-"
            F100TextBoxCN7.Enabled = False
            F100LabelG7.Text = "-"
            F100ButtonCN7.Text = "-"
        Else

            F100TextBoxCN7.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN8.Click
        F100ComboBoxCN8.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU8.Text = "-"
            F100LabelCN8.Text = "-"
            F100LabelQP8.Text = "-"
            F100TextBoxCN8.Enabled = False
            F100LabelG8.Text = "-"
            F100ButtonCN8.Text = "-"
        Else
            F100TextBoxCN8.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN9.Click
        F100ComboBoxCN9.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU9.Text = "-"
            F100LabelCN9.Text = "-"
            F100LabelQP9.Text = "-"
            F100TextBoxCN9.Enabled = False
            F100LabelG9.Text = "-"
            F100ButtonCN9.Text = "-"
        Else

            F100TextBoxCN9.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN10.Click
        F100ComboBoxCN10.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU10.Text = "-"
            F100LabelCN10.Text = "-"
            F100LabelQP10.Text = "-"
            F100TextBoxCN10.Enabled = False
            F100LabelG10.Text = "-"
            F100ButtonCN10.Text = "-"
        Else

            F100TextBoxCN1.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN11.Click
        F100ComboBoxCN11.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU11.Text = "-"
            F100LabelCN11.Text = "-"
            F100LabelQP11.Text = "-"
            F100TextBoxCN11.Enabled = False
            F100LabelG11.Text = "-"
            F100ButtonCN11.Text = "-"
        Else

            F100TextBoxCN11.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN12.Click
        F100ComboBoxCN12.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU12.Text = "-"
            F100LabelCN12.Text = "-"
            F100LabelQP12.Text = "-"
            F100TextBoxCN12.Enabled = False
            F100LabelG12.Text = "-"
            F100ButtonCN12.Text = "-"
        Else

            F100TextBoxCN12.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN13.Click
        F100ComboBoxCN13.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU13.Text = "-"
            F100LabelCN13.Text = "-"
            F100LabelQP13.Text = "-"
            F100TextBoxCN13.Enabled = False
            F100LabelG13.Text = "-"
            F100ButtonCN13.Text = "-"
        Else

            F100TextBoxCN13.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub
    Private Sub F100ComboBoxCN14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F100ComboBoxCN14.Click
        F100ComboBoxCN14.Items.Clear()
        Call hope()
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
        Call totalcreditunit()
        Call totalqp()

        If Val(F100TOTALCUlabel.Text) > maxim Then
            MsgBox("THE MAXIMUM TOTAL CREDIT UNIT IS " & maxim, MsgBoxStyle.Information)
            F100LabelCU14.Text = "-"
            F100LabelCN14.Text = "-"
            F100LabelQP14.Text = "-"
            F100TextBoxCN14.Enabled = False
            F100LabelG14.Text = "-"
            F100ButtonCN14.Text = "-"
        Else
            F100TextBoxCN14.Enabled = True
            Call oleku()
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
        Call totalcreditunit()
        Call totalqp()
        Call hope()
    End Sub


    Private Sub ButtonEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Home.Close()
        Subject.Close()
        Splash.Close()
        Me.Close()
        Game1.Close()
    End Sub
    Private Sub ButtonEXIT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.MouseEnter
        LabelClose.Show()
    End Sub
    Private Sub ButtonEXIT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.MouseLeave
        LabelClose.Hide()
    End Sub
    Private Sub Buttonback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonback.Click
        Me.Hide()
        Home.Show()
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

    End Sub
    Private Sub year3Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year3Button.Click
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
    End Sub
    Private Sub year4Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year4Button.Click
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

    End Sub
    Private Sub year5Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year5Button.Click
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

    End Sub
    Private Sub year6Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year6Button.Click
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

    End Sub
    Private Sub year7Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year7Button.Click
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

    End Sub
    Private Sub ButtonFirst100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFirst100.Click
        ButtonFirst100.BackColor = Color.WhiteSmoke
        Buttonsecond100.BackColor = Color.IndianRed
        TabControl100.SelectedTab = TabPagefirst100
    End Sub
    Private Sub Buttonsecond100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsecond100.Click
        Buttonsecond100.BackColor = Color.WhiteSmoke
        ButtonFirst100.BackColor = Color.IndianRed
        TabControl100.SelectedTab = TabPagesecond100
    End Sub
    Private Sub first200Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first200Button.Click
        first200Button.BackColor = Color.WhiteSmoke
        second200Button2.BackColor = Color.IndianRed
        TabControl200.SelectedTab = TabPagefirst200
    End Sub
    Private Sub second200Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second200Button2.Click
        first200Button.BackColor = Color.IndianRed
        second200Button2.BackColor = Color.WhiteSmoke
        TabControl200.SelectedTab = TabPagesecond200
    End Sub
    Private Sub first300Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first300Button.Click
        first300Button.BackColor = Color.WhiteSmoke
        second300Button.BackColor = Color.IndianRed
        TabControl300.SelectedTab = TabPagefirst300
    End Sub
    Private Sub second300Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second300Button.Click
        first300Button.BackColor = Color.IndianRed
        second300Button.BackColor = Color.WhiteSmoke
        TabControl300.SelectedTab = TabPagesecond300
    End Sub
    Private Sub first400Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first400Button.Click
        first400Button.BackColor = Color.WhiteSmoke
        second400Button.BackColor = Color.IndianRed
        TabControl400.SelectedTab = TabPagefirst400
    End Sub
    Private Sub second400Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second400Button.Click
        first400Button.BackColor = Color.IndianRed
        second400Button.BackColor = Color.WhiteSmoke
        TabControl400.SelectedTab = TabPagesecond400
    End Sub
    Private Sub first500Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first500Button.Click
        first500Button.BackColor = Color.WhiteSmoke
        second500Button.BackColor = Color.IndianRed
        TabControl500.SelectedTab = TabPagefirst500
    End Sub
    Private Sub second500Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second500Button.Click
        first500Button.BackColor = Color.IndianRed
        second500Button.BackColor = Color.WhiteSmoke
        TabControl500.SelectedTab = TabPagesecond500
    End Sub
    Private Sub first600Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first600Button.Click
        first600Button.BackColor = Color.WhiteSmoke
        second600Button.BackColor = Color.IndianRed
        TabControl600.SelectedTab = TabPagefirst600
    End Sub
    Private Sub second600Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second600Button.Click
        first600Button.BackColor = Color.IndianRed
        second600Button.BackColor = Color.WhiteSmoke
        TabControl600.SelectedTab = TabPagesecond600
    End Sub
    Private Sub first700Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first700Button.Click
        first700Button.BackColor = Color.WhiteSmoke
        second700Button.BackColor = Color.IndianRed
        TabControl700.SelectedTab = TabPagefirst700
    End Sub
    Private Sub second700Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second700Button.Click
        first700Button.BackColor = Color.IndianRed
        second700Button.BackColor = Color.WhiteSmoke
        TabControl700.SelectedTab = TabPagesecond700
    End Sub


End Class