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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.rbtnMB = New System.Windows.Forms.RadioButton()
        Me.rbtnGB = New System.Windows.Forms.RadioButton()
        Me.rbtnTB = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(8, 81)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(296, 20)
        Me.txtInput.TabIndex = 0
        '
        'rbtnMB
        '
        Me.rbtnMB.AutoSize = True
        Me.rbtnMB.Location = New System.Drawing.Point(8, 32)
        Me.rbtnMB.Name = "rbtnMB"
        Me.rbtnMB.Size = New System.Drawing.Size(100, 17)
        Me.rbtnMB.TabIndex = 1
        Me.rbtnMB.TabStop = True
        Me.rbtnMB.Text = "Megabyte (MB):"
        Me.rbtnMB.UseVisualStyleBackColor = True
        '
        'rbtnGB
        '
        Me.rbtnGB.AutoSize = True
        Me.rbtnGB.Location = New System.Drawing.Point(113, 32)
        Me.rbtnGB.Name = "rbtnGB"
        Me.rbtnGB.Size = New System.Drawing.Size(94, 17)
        Me.rbtnGB.TabIndex = 2
        Me.rbtnGB.TabStop = True
        Me.rbtnGB.Text = "Gigabyte (GB):"
        Me.rbtnGB.UseVisualStyleBackColor = True
        '
        'rbtnTB
        '
        Me.rbtnTB.AutoSize = True
        Me.rbtnTB.Location = New System.Drawing.Point(213, 32)
        Me.rbtnTB.Name = "rbtnTB"
        Me.rbtnTB.Size = New System.Drawing.Size(93, 17)
        Me.rbtnTB.TabIndex = 3
        Me.rbtnTB.TabStop = True
        Me.rbtnTB.Text = "Terabyte (TB):"
        Me.rbtnTB.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(8, 107)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(296, 32)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Dönüştür"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstResults)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Controls.Add(Me.rbtnMB)
        Me.GroupBox1.Controls.Add(Me.btnConvert)
        Me.GroupBox1.Controls.Add(Me.rbtnGB)
        Me.GroupBox1.Controls.Add(Me.rbtnTB)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 287)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 20
        Me.lstResults.Location = New System.Drawing.Point(8, 145)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(296, 124)
        Me.lstResults.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Değer Girin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Birim Seçin:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mb_gb_tb_converter.My.Resources.Resources.sd_320px
        Me.PictureBox2.Location = New System.Drawing.Point(168, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 143)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mb_gb_tb_converter.My.Resources.Resources.hdd_400px
        Me.PictureBox1.Location = New System.Drawing.Point(-25, -38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(112, 438)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ALG Yazılım Inc.©"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 458)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MB-GB-TB Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents rbtnMB As RadioButton
    Friend WithEvents rbtnGB As RadioButton
    Friend WithEvents rbtnTB As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
