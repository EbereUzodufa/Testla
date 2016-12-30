Public Class GAme1
    Private Sub GAme1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Hide()
        Labelanswer.Text = ""

    End Sub

    Private Sub ButtonQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQ.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonQ.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub Buttonclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonclear.Click
        Label1.Hide()
        Labelanswer.Text = ""
    End Sub

    Private Sub Buttondone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondone.Click
        Dim answer As String = "distillation"
        If answer.ToUpper = Labelanswer.Text.ToUpper Then
            Label1.Text = "CORRECT"
            Label1.ForeColor = Color.Lime
            Label1.Show()
        Else
            Label1.Text = "WRONG"
            Label1.ForeColor = Color.Red
            Label1.Show()
        End If
        If Labelanswer.Text = "" Then
            MsgBox("YOU DIDN'T ENTER ANYTHING")
        End If
    End Sub

    Private Sub Buttonbackspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbackspace.Click
        'i, bevtino did this on 2/1/2016 by 1:15 AM, all from my head. thank you God for the brains

        Label1.Hide()
        Dim nu As Integer = Labelanswer.Text.Length - 1
        Dim textofAnswer(nu) As String
        Dim finaltext As String
        ' Dim OneCharacter As Char = textofAnswer.Chars(nu)
        'OneCharacter = " "
        ' Label2.Text = textofAnswer
        'Labelanswer.Text.Remove(nu)
        For i = 0 To nu - 1
            textofAnswer(i) = Labelanswer.Text(i)
            finaltext = finaltext & textofAnswer(i)
        Next
        Labelanswer.Text = Trim(finaltext)
    End Sub

    Private Sub ButtonW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonW.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonW.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonE.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonE.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonR.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonR.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonT.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonT.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonY.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonY.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonU.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonU.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonI.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonI.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonO.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonO.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonP.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonP.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonA.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonA.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonS.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonS.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonD.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonD.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonF.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonF.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonG.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonG.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonH.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonH.Text

        End If
    End Sub

    Private Sub ButtonJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJ.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonJ.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonK.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonK.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonL.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonL.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonZ.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonZ.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonX.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonC.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonC.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonV.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonV.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonB.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonB.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonN_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonN.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonN.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonM.Click
        If Labelanswer.Text.Length = 12 Then
            Exit Sub
        Else
            Labelanswer.Text = Labelanswer.Text & ButtonM.Text
        End If
        Label1.Hide()
    End Sub
End Class