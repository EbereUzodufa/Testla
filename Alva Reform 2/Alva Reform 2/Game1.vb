Public Class Game1
    Dim answer As String
    Dim haha As Integer
    Dim hint As String
    Dim index As Integer = 1

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click

        Me.Close()
        Home.Close()
        Splash.Close()
        CGPA.Close()
        Subject.Close()

    End Sub

    Private Sub ButtonClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClose.MouseEnter
        LabelClose.Show()
    End Sub

    Private Sub ButtonClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClose.MouseLeave
        LabelClose.Hide()
    End Sub


    Private Sub Buttonclear_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonclear.MouseEnter
        Buttonclear.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQ.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonQ.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub Buttonclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonclear.Click
        Label1.Hide()
        Labelanswer.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Buttondone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondone.Click
        Dim score As Integer = Val(LabelSCORE.Text)
        Dim aha As Integer = ListBoxhint.Items.Count
        Dim chacha As Integer = Val(ListBoxques.SelectedIndex)


        If Labelanswer.Text = "" Then
            MsgBox("YOU DIDN'T ENTER ANYTHING")

        ElseIf answer.ToUpper <> Labelanswer.Text.ToUpper Then
            Label1.Text = "WRONG"
            Label1.ForeColor = Color.Red
            Label1.Show()

        ElseIf (answer.ToUpper = Labelanswer.Text.ToUpper) And LabelFQ.BackColor = Color.Red And (ListBoxques.Items.Count <> ListBoxans.Items.Count) And ((Val(ListBoxques.Items.Count) = (Val(ListBoxques.SelectedIndex) + 1))) Then
            Label1.Text = "CORRECT"
            Label1.ForeColor = Color.Lime
            Label1.Show()
            LabelSCORE.Text = Val(LabelSCORE.Text) + 1
            ' to switch questions
            ListBoxques.Items.Add(chacha + 2)
            PictureBox1.ImageLocation = ListBoxpict.Items(chacha).ToString
            answer = ListBoxans.Items(chacha).ToString
            haha = answer.Length
            hint = "HINT: " & ListBoxhint.Items(chacha).ToString
            Labelhint.Text = hint.ToUpper

            'to highlight question answer
            ListBoxques.SelectedIndex = ListBoxques.SelectedIndex + 1
        ElseIf (answer.ToUpper = Labelanswer.Text.ToUpper) And LabelFQ.BackColor = Color.AliceBlue And ((Val(ListBoxques.Items.Count) <> score)) Then
            Label1.Text = "CORRECT"
            Label1.ForeColor = Color.Lime
            Label1.Show()
            LabelSCORE.Text = Val(LabelSCORE.Text) + 1
            Label4.Show()
            Panel1.Enabled = False
            TextBox1.Enabled = False
       
        ElseIf (answer.ToUpper = Labelanswer.Text.ToUpper) And LabelFQ.BackColor = Color.AliceBlue And ((Val(ListBoxques.Items.Count) = score)) Then
            Label1.Text = "CORRECT"
            Label1.ForeColor = Color.Lime
            Label1.Show()
            Label4.Show()
            Panel1.Enabled = False
            TextBox1.Enabled = False
        ElseIf (answer.ToUpper = Labelanswer.Text.ToUpper) And LabelFQ.BackColor = Color.Red And ListBoxques.Items.Count = ListBoxans.Items.Count And ((Val(ListBoxques.Items.Count) <> (Val(ListBoxques.SelectedIndex) + 1))) Then
            Label1.Text = "CORRECT"
            Label1.ForeColor = Color.Lime
            Label1.Show()
            ' to switch questions
            ListBoxques.SelectedIndex = ListBoxques.SelectedIndex + 1
            PictureBox1.ImageLocation = ListBoxpict.Items(chacha + 1).ToString
            answer = ListBoxans.Items(chacha + 1).ToString
            haha = answer.Length
            hint = "HINT: " & ListBoxhint.Items(chacha + 1).ToString
            Labelhint.Text = hint.ToUpper
        ElseIf (answer.ToUpper = Labelanswer.Text.ToUpper) And LabelFQ.BackColor = Color.Red And ((Val(ListBoxques.Items.Count) <> (Val(ListBoxques.SelectedIndex) + 1))) Then
            Label1.Text = "CORRECT"
            Label1.ForeColor = Color.Lime
            Label1.Show()
            ' to switch questions
            ListBoxques.SelectedIndex = ListBoxques.SelectedIndex + 1
            PictureBox1.ImageLocation = ListBoxpict.Items(chacha + 1).ToString
            answer = ListBoxans.Items(chacha + 1).ToString
            haha = answer.Length
            hint = "HINT: " & ListBoxhint.Items(chacha + 1).ToString
            Labelhint.Text = hint.ToUpper
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
        TextBox1.Text = Trim(finaltext)
    End Sub

    Private Sub ButtonW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonW.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonW.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonE.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonE.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonR.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonR.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonT.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonT.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonY.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonY.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonU.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonU.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonI.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonI.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonO.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonO.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonP.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonP.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonA.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonA.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonS.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonS.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonD.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonD.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonF.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonF.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonG.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonG.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonH.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonH.Text

        End If
    End Sub

    Private Sub ButtonJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJ.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonJ.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonK.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonK.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonL.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonL.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonZ.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonZ.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonX.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonC.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonC.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonV.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonV.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonB.Click
        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonB.Text

        End If
        Label1.Hide()
    End Sub

    Private Sub ButtonN_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonN.Click

        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonN.Text

        End If
        Label1.Hide()

    End Sub

    Private Sub ButtonM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonM.Click

        If Labelanswer.Text.Length = haha Then
            Exit Sub
        Else
            TextBox1.Text = TextBox1.Text & ButtonM.Text
        End If
        Label1.Hide()

    End Sub

    Private Sub Game1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBoxpict.Items.Clear()
        '  Label4.Text = ListBoxhint.Items.Count
        Dim excdir As New IO.FileInfo(Reflection.Assembly.GetExecutingAssembly.FullName)
        Dim xpath = IO.Path.Combine(excdir.DirectoryName)
        Dim chi, chingy, chineye As String
        chi = xpath & "\Resources\G1.png"
        chingy = xpath & "\Resources\G2.png"
        chineye = xpath & "\Resources\G3.png"
        ListBoxpict.Items.Add(chi)
        ListBoxpict.Items.Add(chingy)
        ListBoxpict.Items.Add(chineye)


        TextBox1.MaxLength = haha
        Label1.Hide()
        ListBoxques.Items.Add(index)
        Labelanswer.Text = ""
        PictureBox1.ImageLocation = ListBoxpict.Items(index - 1).ToString
        answer = ListBoxans.Items(index - 1).ToString
        haha = answer.Length
        hint = "HINT: " & ListBoxhint.Items(index - 1).ToString
        Labelhint.Text = hint.ToUpper

        ListBoxques.SelectedIndex = ListBoxques.SelectedIndex + 1

    End Sub

    Private Sub Buttonbackspace_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonbackspace.MouseEnter
        Buttonbackspace.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub Buttondone_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttondone.MouseEnter
        Buttondone.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonH_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonH.MouseEnter
        ButtonH.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonV_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonV.MouseEnter
        ButtonV.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonB_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonB.MouseEnter
        ButtonB.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonC_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonC.MouseEnter
        ButtonC.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonN_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonN.MouseEnter
        ButtonN.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX.MouseEnter
        ButtonX.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonM_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonM.MouseEnter
        ButtonM.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonZ_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonZ.MouseEnter
        ButtonZ.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonG_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonG.MouseEnter
        ButtonG.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonJ_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonJ.MouseEnter
        ButtonJ.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonJ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonJ.MouseLeave
        ButtonJ.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonF_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonF.MouseEnter
        ButtonF.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonD_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonD.MouseEnter
        ButtonD.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonK.MouseEnter
        ButtonK.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonS.MouseEnter
        ButtonS.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonL_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonL.MouseEnter
        ButtonL.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonA_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonA.MouseEnter
        ButtonA.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonQ_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonQ.MouseEnter
        ButtonQ.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonW_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonW.MouseEnter
        ButtonW.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonE_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonE.MouseEnter
        ButtonE.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonR.MouseEnter
        ButtonR.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonP_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonP.MouseEnter
        ButtonP.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonT.MouseEnter
        ButtonT.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonY_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonY.MouseEnter
        ButtonY.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonU_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonU.MouseEnter
        ButtonU.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonO_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonO.MouseEnter
        ButtonO.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub ButtonI_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonI.MouseEnter
        ButtonI.BackgroundImage = My.Resources.yellow
    End Sub

    Private Sub Buttondone_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttondone.MouseLeave
        Buttondone.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub Buttonbackspace_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonbackspace.MouseLeave
        Buttonbackspace.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub Buttonclear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonclear.MouseLeave
        Buttonclear.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonQ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonQ.MouseLeave

        ButtonQ.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonW_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonW.MouseLeave
        ButtonW.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonE.MouseLeave
        ButtonE.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonR.MouseLeave
        ButtonR.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonP_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonP.MouseLeave
        ButtonP.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonT.MouseLeave
        ButtonT.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonY_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonY.MouseLeave
        ButtonY.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonU_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonU.MouseLeave
        ButtonU.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonO_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonO.MouseLeave
        ButtonO.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonI_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonI.MouseLeave
        ButtonI.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonA_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonA.MouseLeave
        ButtonA.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonL_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonL.MouseLeave
        ButtonL.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonS.MouseLeave
        ButtonS.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonK.MouseLeave
        ButtonK.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonD_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonD.MouseLeave
        ButtonD.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonF_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonF.MouseLeave
        ButtonF.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonG_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonG.MouseLeave
        ButtonG.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonH_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonH.MouseLeave
        ButtonH.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonZ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonZ.MouseLeave
        ButtonZ.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonM_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonM.MouseLeave
        ButtonM.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX.MouseLeave
        ButtonX.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonN_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonN.MouseLeave
        ButtonN.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonC.MouseLeave
        ButtonC.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonB_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonB.MouseLeave
        ButtonB.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub ButtonV_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonV.MouseLeave
        ButtonV.BackgroundImage = Me.BackgroundImage
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click, TextBox2.Click

        If Label1.Visible = True Then
            Labelanswer.Text = Trim(TextBox1.Text).ToUpper
            Label1.Hide()
        End If

        If Label1.Text = "CORRECT" Then
            TextBox1.Clear()
            Label1.Hide()
        End If

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        'to use ENTER KEY
        If e.KeyCode = Keys.Enter Then
            Buttondone.PerformClick()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        TextBox1.MaxLength = haha
        Try
            Dim onecharacter As Char
            Dim name As String
            name = TextBox1.Text
            Dim count As Integer = 0

            'to check for symbols
            For i = 0 To name.Length - 1
                onecharacter = name.Chars(i)
                If onecharacter = "!" Or onecharacter = "@" Or onecharacter = "#" Or onecharacter = "$" Or onecharacter = "%" Or onecharacter = "^" Or onecharacter = "&" Or onecharacter = "*" Or onecharacter = "(" Or onecharacter = ")" Or IsNumeric(onecharacter) Or onecharacter = "-" Or onecharacter = "_" Or onecharacter = "=" Or onecharacter = "+" Or onecharacter = "[" Or onecharacter = "{" Or onecharacter = "}" Or onecharacter = "]" Or onecharacter = "\" Or onecharacter = "|" Or onecharacter = ";" Or onecharacter = ":" Or onecharacter = "'" Or onecharacter = "," Or onecharacter = "<" Or onecharacter = "." Or onecharacter = ">" Or onecharacter = "/" Or onecharacter = " " Or onecharacter = "`" Or onecharacter = "~" Or onecharacter = "?" Then
                    Dim nu As Integer = Labelanswer.Text.Length - 1
                    Dim textofAnswer(nu) As String
                    Dim finaltext As String

                    For j = 0 To nu - 1
                        textofAnswer(j) = Labelanswer.Text(j)
                        finaltext = finaltext & textofAnswer(j)
                    Next
                    Labelanswer.Text = Trim(finaltext)
                    TextBox1.Text = Trim(finaltext)
                    Exit Sub
                ElseIf i = name.Length - 1 And IsNumeric(onecharacter) = False Then

                    Labelanswer.Text = Trim(TextBox1.Text).ToUpper
                End If
            Next


            ' to make sure label is clear when textbox is clear
            Labelanswer.Text = Trim(TextBox1.Text).ToUpper


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    
    Private Sub ListBoxques_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxques.SelectedIndexChanged

        Dim ha As Integer
        ha = ListBoxques.SelectedIndex
        PictureBox1.ImageLocation = ListBoxpict.Items(ha).ToString
        answer = ListBoxans.Items(ha).ToString
        hint = "HINTS: " & ListBoxhint.Items(ha).ToString
        Labelhint.Text = hint.ToUpper
        haha = answer.Length
        ' in case you through with question
        If Panel1.Enabled = False Then
            Panel1.Enabled = True
            TextBox1.Enabled = True
            Label4.Hide()
        End If
        ' Label5.Text = Val(ListBoxques.SelectedIndex)
        'to regulate last question

        If Val(ListBoxques.SelectedIndex) + 1 = ListBoxans.Items.Count Then
            LabelFQ.BackColor = Color.AliceBlue
        Else
            LabelFQ.BackColor = Color.Red
        End If

    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click

        Me.Hide()
        Home.Show()

    End Sub

    
End Class