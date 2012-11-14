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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PaintRadius = New System.Windows.Forms.HScrollBar()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ModeBtn = New System.Windows.Forms.Button()
        Me.SprayDensity = New System.Windows.Forms.HScrollBar()
        Me.SprayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColourButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(561, 397)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PaintRadius
        '
        Me.PaintRadius.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PaintRadius.Location = New System.Drawing.Point(171, 12)
        Me.PaintRadius.Minimum = 1
        Me.PaintRadius.Name = "PaintRadius"
        Me.PaintRadius.Size = New System.Drawing.Size(325, 23)
        Me.PaintRadius.TabIndex = 5
        Me.PaintRadius.Value = 1
        '
        'ClearBtn
        '
        Me.ClearBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearBtn.BackColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(499, 12)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(74, 23)
        Me.ClearBtn.TabIndex = 6
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'LoadBtn
        '
        Me.LoadBtn.Location = New System.Drawing.Point(12, 12)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoadBtn.TabIndex = 7
        Me.LoadBtn.Text = "Load"
        Me.LoadBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(93, 12)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 8
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'PrintBtn
        '
        Me.PrintBtn.Location = New System.Drawing.Point(12, 41)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(51, 23)
        Me.PrintBtn.TabIndex = 9
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'ModeBtn
        '
        Me.ModeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeBtn.Location = New System.Drawing.Point(499, 41)
        Me.ModeBtn.Name = "ModeBtn"
        Me.ModeBtn.Size = New System.Drawing.Size(74, 23)
        Me.ModeBtn.TabIndex = 10
        Me.ModeBtn.Text = "Spray"
        Me.ModeBtn.UseVisualStyleBackColor = True
        '
        'SprayDensity
        '
        Me.SprayDensity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SprayDensity.Location = New System.Drawing.Point(171, 41)
        Me.SprayDensity.Maximum = 150
        Me.SprayDensity.Minimum = 1
        Me.SprayDensity.Name = "SprayDensity"
        Me.SprayDensity.Size = New System.Drawing.Size(325, 23)
        Me.SprayDensity.TabIndex = 12
        Me.SprayDensity.Value = 1
        '
        'SprayTimer
        '
        '
        'ColourButton
        '
        Me.ColourButton.BackColor = System.Drawing.Color.Black
        Me.ColourButton.ForeColor = System.Drawing.Color.White
        Me.ColourButton.Location = New System.Drawing.Point(145, 41)
        Me.ColourButton.Name = "ColourButton"
        Me.ColourButton.Size = New System.Drawing.Size(23, 23)
        Me.ColourButton.TabIndex = 13
        Me.ColourButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Colour Picker"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 479)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ColourButton)
        Me.Controls.Add(Me.SprayDensity)
        Me.Controls.Add(Me.ModeBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.PaintRadius)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "PINP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PaintRadius As System.Windows.Forms.HScrollBar
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents LoadBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
    Friend WithEvents ModeBtn As System.Windows.Forms.Button
    Friend WithEvents SprayDensity As System.Windows.Forms.HScrollBar
    Friend WithEvents SprayTimer As System.Windows.Forms.Timer
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColourButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
