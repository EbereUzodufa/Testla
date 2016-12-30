<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aftersplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aftersplash))
        Me.ButtonEXIT = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Labelentername = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextBoxname = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEXIT
        '
        Me.ButtonEXIT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonEXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEXIT.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEXIT.ForeColor = System.Drawing.Color.Red
        Me.ButtonEXIT.Location = New System.Drawing.Point(357, 1)
        Me.ButtonEXIT.Name = "ButtonEXIT"
        Me.ButtonEXIT.Size = New System.Drawing.Size(43, 38)
        Me.ButtonEXIT.TabIndex = 81
        Me.ButtonEXIT.Tag = "Close"
        Me.ButtonEXIT.Text = "X"
        Me.ButtonEXIT.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(23, 129)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(129, 116)
        Me.PictureBox5.TabIndex = 80
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(150, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "PROFILE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 20)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Click on Box to select Picture"
        '
        'Labelentername
        '
        Me.Labelentername.AutoSize = True
        Me.Labelentername.BackColor = System.Drawing.Color.Transparent
        Me.Labelentername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelentername.ForeColor = System.Drawing.Color.Black
        Me.Labelentername.Location = New System.Drawing.Point(8, 74)
        Me.Labelentername.Name = "Labelentername"
        Me.Labelentername.Size = New System.Drawing.Size(136, 20)
        Me.Labelentername.TabIndex = 79
        Me.Labelentername.Text = "Enter Your Name:"
        '
        'ButtonOK
        '
        Me.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonOK.FlatAppearance.BorderSize = 2
        Me.ButtonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.Location = New System.Drawing.Point(290, 243)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(76, 37)
        Me.ButtonOK.TabIndex = 76
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextBoxname
        '
        Me.TextBoxname.BackColor = System.Drawing.Color.White
        Me.TextBoxname.Location = New System.Drawing.Point(164, 74)
        Me.TextBoxname.MaxLength = 20
        Me.TextBoxname.Name = "TextBoxname"
        Me.TextBoxname.Size = New System.Drawing.Size(202, 20)
        Me.TextBoxname.TabIndex = 75
        Me.TextBoxname.Text = "YOUR NAME"
        '
        'Aftersplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 293)
        Me.Controls.Add(Me.ButtonEXIT)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Labelentername)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBoxname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aftersplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aftersplash"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEXIT As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Labelentername As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents TextBoxname As System.Windows.Forms.TextBox
End Class
