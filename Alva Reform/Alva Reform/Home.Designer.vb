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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Labelwelcome = New System.Windows.Forms.Label()
        Me.Timercount = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Labelalva = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Labelwelcome
        '
        Me.Labelwelcome.AutoSize = True
        Me.Labelwelcome.BackColor = System.Drawing.Color.Transparent
        Me.Labelwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelwelcome.ForeColor = System.Drawing.Color.White
        Me.Labelwelcome.Location = New System.Drawing.Point(74, 40)
        Me.Labelwelcome.Name = "Labelwelcome"
        Me.Labelwelcome.Size = New System.Drawing.Size(197, 37)
        Me.Labelwelcome.TabIndex = 5
        Me.Labelwelcome.Text = "Welcome To"
        '
        'Timercount
        '
        Me.Timercount.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Labelalva
        '
        Me.Labelalva.AutoSize = True
        Me.Labelalva.BackColor = System.Drawing.Color.Transparent
        Me.Labelalva.Font = New System.Drawing.Font("LCD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelalva.ForeColor = System.Drawing.Color.Lime
        Me.Labelalva.Location = New System.Drawing.Point(129, 243)
        Me.Labelalva.Name = "Labelalva"
        Me.Labelalva.Size = New System.Drawing.Size(78, 31)
        Me.Labelalva.TabIndex = 3
        Me.Labelalva.Text = "ALVA"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(345, 355)
        Me.Controls.Add(Me.Labelwelcome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Labelalva)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(345, 355)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(345, 355)
        Me.Name = "Home"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labelwelcome As System.Windows.Forms.Label
    Friend WithEvents Timercount As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Labelalva As System.Windows.Forms.Label
End Class
