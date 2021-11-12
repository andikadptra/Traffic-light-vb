<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LampKuning = New System.Windows.Forms.PictureBox()
        Me.lampHijau = New System.Windows.Forms.PictureBox()
        Me.lampMerah = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.counter1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.counter2 = New System.Windows.Forms.TextBox()
        Me.lampKuning2 = New System.Windows.Forms.PictureBox()
        Me.lampHijau2 = New System.Windows.Forms.PictureBox()
        Me.lampMerah2 = New System.Windows.Forms.PictureBox()
        Me.lampKuningScnd1 = New System.Windows.Forms.PictureBox()
        Me.lampKuningScnd2 = New System.Windows.Forms.PictureBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LampKuning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampHijau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampMerah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampKuning2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampHijau2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampMerah2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampKuningScnd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampKuningScnd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LampKuning
        '
        Me.LampKuning.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampKuning
        Me.LampKuning.Location = New System.Drawing.Point(112, 83)
        Me.LampKuning.Name = "LampKuning"
        Me.LampKuning.Size = New System.Drawing.Size(242, 267)
        Me.LampKuning.TabIndex = 2
        Me.LampKuning.TabStop = False
        '
        'lampHijau
        '
        Me.lampHijau.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampHijau
        Me.lampHijau.Location = New System.Drawing.Point(112, 84)
        Me.lampHijau.Name = "lampHijau"
        Me.lampHijau.Size = New System.Drawing.Size(242, 268)
        Me.lampHijau.TabIndex = 1
        Me.lampHijau.TabStop = False
        '
        'lampMerah
        '
        Me.lampMerah.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampMerah
        Me.lampMerah.Location = New System.Drawing.Point(112, 84)
        Me.lampMerah.Name = "lampMerah"
        Me.lampMerah.Size = New System.Drawing.Size(242, 257)
        Me.lampMerah.TabIndex = 0
        Me.lampMerah.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'counter1
        '
        Me.counter1.BackColor = System.Drawing.Color.White
        Me.counter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.counter1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.counter1.Location = New System.Drawing.Point(286, 83)
        Me.counter1.Name = "counter1"
        Me.counter1.Size = New System.Drawing.Size(68, 20)
        Me.counter1.TabIndex = 3
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'counter2
        '
        Me.counter2.BackColor = System.Drawing.Color.White
        Me.counter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.counter2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.counter2.Location = New System.Drawing.Point(584, 83)
        Me.counter2.Name = "counter2"
        Me.counter2.Size = New System.Drawing.Size(50, 20)
        Me.counter2.TabIndex = 7
        '
        'lampKuning2
        '
        Me.lampKuning2.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampKuning
        Me.lampKuning2.Location = New System.Drawing.Point(404, 83)
        Me.lampKuning2.Name = "lampKuning2"
        Me.lampKuning2.Size = New System.Drawing.Size(241, 267)
        Me.lampKuning2.TabIndex = 6
        Me.lampKuning2.TabStop = False
        '
        'lampHijau2
        '
        Me.lampHijau2.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampHijau
        Me.lampHijau2.Location = New System.Drawing.Point(404, 83)
        Me.lampHijau2.Name = "lampHijau2"
        Me.lampHijau2.Size = New System.Drawing.Size(254, 268)
        Me.lampHijau2.TabIndex = 5
        Me.lampHijau2.TabStop = False
        '
        'lampMerah2
        '
        Me.lampMerah2.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampMerah
        Me.lampMerah2.Location = New System.Drawing.Point(404, 81)
        Me.lampMerah2.Name = "lampMerah2"
        Me.lampMerah2.Size = New System.Drawing.Size(248, 257)
        Me.lampMerah2.TabIndex = 4
        Me.lampMerah2.TabStop = False
        '
        'lampKuningScnd1
        '
        Me.lampKuningScnd1.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampKuning
        Me.lampKuningScnd1.Location = New System.Drawing.Point(112, 84)
        Me.lampKuningScnd1.Name = "lampKuningScnd1"
        Me.lampKuningScnd1.Size = New System.Drawing.Size(241, 272)
        Me.lampKuningScnd1.TabIndex = 8
        Me.lampKuningScnd1.TabStop = False
        '
        'lampKuningScnd2
        '
        Me.lampKuningScnd2.Image = Global.lampu_lalu_lintas.My.Resources.Resources.lampKuning
        Me.lampKuningScnd2.Location = New System.Drawing.Point(404, 83)
        Me.lampKuningScnd2.Name = "lampKuningScnd2"
        Me.lampKuningScnd2.Size = New System.Drawing.Size(242, 255)
        Me.lampKuningScnd2.TabIndex = 9
        Me.lampKuningScnd2.TabStop = False
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 426)
        Me.Controls.Add(Me.counter1)
        Me.Controls.Add(Me.counter2)
        Me.Controls.Add(Me.lampKuningScnd2)
        Me.Controls.Add(Me.lampKuningScnd1)
        Me.Controls.Add(Me.lampKuning2)
        Me.Controls.Add(Me.lampHijau2)
        Me.Controls.Add(Me.lampMerah2)
        Me.Controls.Add(Me.LampKuning)
        Me.Controls.Add(Me.lampHijau)
        Me.Controls.Add(Me.lampMerah)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LampKuning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampHijau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampMerah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampKuning2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampHijau2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampMerah2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampKuningScnd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampKuningScnd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lampMerah As System.Windows.Forms.PictureBox
    Friend WithEvents lampHijau As System.Windows.Forms.PictureBox
    Friend WithEvents LampKuning As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents counter1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents counter2 As System.Windows.Forms.TextBox
    Friend WithEvents lampKuning2 As System.Windows.Forms.PictureBox
    Friend WithEvents lampHijau2 As System.Windows.Forms.PictureBox
    Friend WithEvents lampMerah2 As System.Windows.Forms.PictureBox
    Friend WithEvents lampKuningScnd1 As System.Windows.Forms.PictureBox
    Friend WithEvents lampKuningScnd2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer5 As System.Windows.Forms.Timer

End Class
