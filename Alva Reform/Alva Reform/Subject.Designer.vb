<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subject))
        Me.Buttonexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Labelback = New System.Windows.Forms.Label()
        Me.LabelCOURSENAME = New System.Windows.Forms.Label()
        Me.ButtonLET = New System.Windows.Forms.Button()
        Me.ButtonREF = New System.Windows.Forms.Button()
        Me.ButtonBASOLT = New System.Windows.Forms.Button()
        Me.ButtonOUTSLIDE = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Buttonexit
        '
        Me.Buttonexit.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonexit.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonexit.ForeColor = System.Drawing.Color.Red
        Me.Buttonexit.Location = New System.Drawing.Point(858, 456)
        Me.Buttonexit.Margin = New System.Windows.Forms.Padding(4)
        Me.Buttonexit.Name = "Buttonexit"
        Me.Buttonexit.Size = New System.Drawing.Size(106, 60)
        Me.Buttonexit.TabIndex = 34
        Me.Buttonexit.Text = "EXIT"
        Me.Buttonexit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Labelback
        '
        Me.Labelback.AutoSize = True
        Me.Labelback.BackColor = System.Drawing.Color.Transparent
        Me.Labelback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Labelback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Labelback.ForeColor = System.Drawing.Color.White
        Me.Labelback.Location = New System.Drawing.Point(874, 32)
        Me.Labelback.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelback.Name = "Labelback"
        Me.Labelback.Size = New System.Drawing.Size(60, 24)
        Me.Labelback.TabIndex = 32
        Me.Labelback.Text = "BACK"
        '
        'LabelCOURSENAME
        '
        Me.LabelCOURSENAME.AutoSize = True
        Me.LabelCOURSENAME.BackColor = System.Drawing.Color.Transparent
        Me.LabelCOURSENAME.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelCOURSENAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCOURSENAME.ForeColor = System.Drawing.Color.Black
        Me.LabelCOURSENAME.Location = New System.Drawing.Point(0, 113)
        Me.LabelCOURSENAME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCOURSENAME.Name = "LabelCOURSENAME"
        Me.LabelCOURSENAME.Size = New System.Drawing.Size(168, 25)
        Me.LabelCOURSENAME.TabIndex = 31
        Me.LabelCOURSENAME.Text = "COURSE NAME"
        Me.LabelCOURSENAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonLET
        '
        Me.ButtonLET.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonLET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLET.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ButtonLET.Location = New System.Drawing.Point(24, 213)
        Me.ButtonLET.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLET.Name = "ButtonLET"
        Me.ButtonLET.Size = New System.Drawing.Size(915, 48)
        Me.ButtonLET.TabIndex = 30
        Me.ButtonLET.Text = "LECTURERS"
        Me.ButtonLET.UseVisualStyleBackColor = True
        '
        'ButtonREF
        '
        Me.ButtonREF.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonREF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonREF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ButtonREF.Location = New System.Drawing.Point(24, 115)
        Me.ButtonREF.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonREF.Name = "ButtonREF"
        Me.ButtonREF.Size = New System.Drawing.Size(915, 48)
        Me.ButtonREF.TabIndex = 29
        Me.ButtonREF.Text = "REFERRALS"
        Me.ButtonREF.UseVisualStyleBackColor = True
        '
        'ButtonBASOLT
        '
        Me.ButtonBASOLT.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonBASOLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBASOLT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ButtonBASOLT.Location = New System.Drawing.Point(24, 312)
        Me.ButtonBASOLT.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBASOLT.Name = "ButtonBASOLT"
        Me.ButtonBASOLT.Size = New System.Drawing.Size(915, 48)
        Me.ButtonBASOLT.TabIndex = 28
        Me.ButtonBASOLT.Text = "BASIC PROBLEMS AND SOLUTION"
        Me.ButtonBASOLT.UseVisualStyleBackColor = True
        '
        'ButtonOUTSLIDE
        '
        Me.ButtonOUTSLIDE.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonOUTSLIDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOUTSLIDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ButtonOUTSLIDE.Location = New System.Drawing.Point(24, 17)
        Me.ButtonOUTSLIDE.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOUTSLIDE.Name = "ButtonOUTSLIDE"
        Me.ButtonOUTSLIDE.Size = New System.Drawing.Size(915, 48)
        Me.ButtonOUTSLIDE.TabIndex = 27
        Me.ButtonOUTSLIDE.Text = "OUTLINES AND SLIDE NOTE"
        Me.ButtonOUTSLIDE.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Labelback)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelCOURSENAME)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonOUTSLIDE)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Buttonexit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonBASOLT)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonLET)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonREF)
        Me.SplitContainer1.Size = New System.Drawing.Size(982, 676)
        Me.SplitContainer1.SplitterDistance = 138
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 35
        '
        'Subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 676)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Subject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALVA"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buttonexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Labelback As System.Windows.Forms.Label
    Friend WithEvents LabelCOURSENAME As System.Windows.Forms.Label
    Friend WithEvents ButtonLET As System.Windows.Forms.Button
    Friend WithEvents ButtonREF As System.Windows.Forms.Button
    Friend WithEvents ButtonBASOLT As System.Windows.Forms.Button
    Friend WithEvents ButtonOUTSLIDE As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
