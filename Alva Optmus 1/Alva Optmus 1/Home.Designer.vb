<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.PictureBoxHOME = New System.Windows.Forms.PictureBox()
        Me.Labelchangename = New System.Windows.Forms.Label()
        Me.Labelusername = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonEXIT = New System.Windows.Forms.Button()
        CType(Me.PictureBoxHOME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxHOME
        '
        Me.PictureBoxHOME.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBoxHOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxHOME.Location = New System.Drawing.Point(26, 117)
        Me.PictureBoxHOME.Name = "PictureBoxHOME"
        Me.PictureBoxHOME.Size = New System.Drawing.Size(100, 90)
        Me.PictureBoxHOME.TabIndex = 66
        Me.PictureBoxHOME.TabStop = False
        '
        'Labelchangename
        '
        Me.Labelchangename.AutoSize = True
        Me.Labelchangename.BackColor = System.Drawing.Color.Transparent
        Me.Labelchangename.ForeColor = System.Drawing.Color.Red
        Me.Labelchangename.Location = New System.Drawing.Point(238, 204)
        Me.Labelchangename.Name = "Labelchangename"
        Me.Labelchangename.Size = New System.Drawing.Size(133, 13)
        Me.Labelchangename.TabIndex = 65
        Me.Labelchangename.Text = "Click to Enter Profile Name"
        Me.Labelchangename.Visible = False
        '
        'Labelusername
        '
        Me.Labelusername.AutoSize = True
        Me.Labelusername.BackColor = System.Drawing.Color.Transparent
        Me.Labelusername.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelusername.ForeColor = System.Drawing.Color.Black
        Me.Labelusername.Location = New System.Drawing.Point(132, 170)
        Me.Labelusername.Name = "Labelusername"
        Me.Labelusername.Size = New System.Drawing.Size(128, 27)
        Me.Labelusername.TabIndex = 64
        Me.Labelusername.Text = "YOUR NAME"
        Me.Labelusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonEXIT
        '
        Me.ButtonEXIT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonEXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEXIT.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEXIT.ForeColor = System.Drawing.Color.Red
        Me.ButtonEXIT.Location = New System.Drawing.Point(342, 12)
        Me.ButtonEXIT.Name = "ButtonEXIT"
        Me.ButtonEXIT.Size = New System.Drawing.Size(43, 38)
        Me.ButtonEXIT.TabIndex = 68
        Me.ButtonEXIT.Tag = "Close"
        Me.ButtonEXIT.Text = "X"
        Me.ButtonEXIT.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 335)
        Me.Controls.Add(Me.ButtonEXIT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBoxHOME)
        Me.Controls.Add(Me.Labelchangename)
        Me.Controls.Add(Me.Labelusername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "1"
        CType(Me.PictureBoxHOME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxHOME As System.Windows.Forms.PictureBox
    Friend WithEvents Labelchangename As System.Windows.Forms.Label
    Friend WithEvents Labelusername As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonEXIT As System.Windows.Forms.Button
End Class
