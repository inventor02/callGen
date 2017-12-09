<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SchemeGroupBox = New System.Windows.Forms.GroupBox()
        Me.SchemeLabel = New System.Windows.Forms.Label()
        Me.GACheckBox = New System.Windows.Forms.CheckBox()
        Me.SchemeComboBox4 = New System.Windows.Forms.ComboBox()
        Me.SchemeComboBox3 = New System.Windows.Forms.ComboBox()
        Me.SchemeComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SchemeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PrefixTextBox = New System.Windows.Forms.TextBox()
        Me.PrefixLabel = New System.Windows.Forms.Label()
        Me.CountryGroupBox = New System.Windows.Forms.GroupBox()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.ResultGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.InstructionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InstructionsLabel3 = New System.Windows.Forms.Label()
        Me.InstructionsLabel2 = New System.Windows.Forms.Label()
        Me.InstructionsLabel1 = New System.Windows.Forms.Label()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.AttributionLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.VersionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchemeGroupBox.SuspendLayout()
        Me.CountryGroupBox.SuspendLayout()
        Me.ResultGroupBox.SuspendLayout()
        Me.InstructionsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.callGen.My.Resources.Resources.Text
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SchemeGroupBox
        '
        Me.SchemeGroupBox.Controls.Add(Me.SchemeLabel)
        Me.SchemeGroupBox.Controls.Add(Me.GACheckBox)
        Me.SchemeGroupBox.Controls.Add(Me.SchemeComboBox4)
        Me.SchemeGroupBox.Controls.Add(Me.SchemeComboBox3)
        Me.SchemeGroupBox.Controls.Add(Me.SchemeComboBox2)
        Me.SchemeGroupBox.Controls.Add(Me.SchemeComboBox1)
        Me.SchemeGroupBox.Controls.Add(Me.PrefixTextBox)
        Me.SchemeGroupBox.Controls.Add(Me.PrefixLabel)
        Me.SchemeGroupBox.Location = New System.Drawing.Point(12, 68)
        Me.SchemeGroupBox.Name = "SchemeGroupBox"
        Me.SchemeGroupBox.Size = New System.Drawing.Size(260, 66)
        Me.SchemeGroupBox.TabIndex = 1
        Me.SchemeGroupBox.TabStop = False
        Me.SchemeGroupBox.Text = "Scheme"
        '
        'SchemeLabel
        '
        Me.SchemeLabel.AutoSize = True
        Me.SchemeLabel.Location = New System.Drawing.Point(56, 20)
        Me.SchemeLabel.Name = "SchemeLabel"
        Me.SchemeLabel.Size = New System.Drawing.Size(46, 13)
        Me.SchemeLabel.TabIndex = 7
        Me.SchemeLabel.Text = "Scheme"
        '
        'GACheckBox
        '
        Me.GACheckBox.AutoSize = True
        Me.GACheckBox.Location = New System.Drawing.Point(213, 37)
        Me.GACheckBox.Name = "GACheckBox"
        Me.GACheckBox.Size = New System.Drawing.Size(41, 17)
        Me.GACheckBox.TabIndex = 6
        Me.GACheckBox.Text = "GA"
        Me.GACheckBox.UseVisualStyleBackColor = True
        '
        'SchemeComboBox4
        '
        Me.SchemeComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SchemeComboBox4.FormattingEnabled = True
        Me.SchemeComboBox4.Items.AddRange(New Object() {"D", "L", "N"})
        Me.SchemeComboBox4.Location = New System.Drawing.Point(174, 35)
        Me.SchemeComboBox4.Name = "SchemeComboBox4"
        Me.SchemeComboBox4.Size = New System.Drawing.Size(32, 21)
        Me.SchemeComboBox4.TabIndex = 5
        '
        'SchemeComboBox3
        '
        Me.SchemeComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SchemeComboBox3.FormattingEnabled = True
        Me.SchemeComboBox3.Items.AddRange(New Object() {"D", "L", "N"})
        Me.SchemeComboBox3.Location = New System.Drawing.Point(136, 35)
        Me.SchemeComboBox3.Name = "SchemeComboBox3"
        Me.SchemeComboBox3.Size = New System.Drawing.Size(32, 21)
        Me.SchemeComboBox3.TabIndex = 4
        '
        'SchemeComboBox2
        '
        Me.SchemeComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SchemeComboBox2.FormattingEnabled = True
        Me.SchemeComboBox2.Items.AddRange(New Object() {"D", "L", "N"})
        Me.SchemeComboBox2.Location = New System.Drawing.Point(98, 35)
        Me.SchemeComboBox2.Name = "SchemeComboBox2"
        Me.SchemeComboBox2.Size = New System.Drawing.Size(32, 21)
        Me.SchemeComboBox2.TabIndex = 3
        '
        'SchemeComboBox1
        '
        Me.SchemeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SchemeComboBox1.FormattingEnabled = True
        Me.SchemeComboBox1.Items.AddRange(New Object() {"D", "L", "N"})
        Me.SchemeComboBox1.Location = New System.Drawing.Point(60, 35)
        Me.SchemeComboBox1.Name = "SchemeComboBox1"
        Me.SchemeComboBox1.Size = New System.Drawing.Size(32, 21)
        Me.SchemeComboBox1.TabIndex = 2
        '
        'PrefixTextBox
        '
        Me.PrefixTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PrefixTextBox.Location = New System.Drawing.Point(10, 36)
        Me.PrefixTextBox.MaxLength = 3
        Me.PrefixTextBox.Name = "PrefixTextBox"
        Me.PrefixTextBox.Size = New System.Drawing.Size(39, 20)
        Me.PrefixTextBox.TabIndex = 1
        '
        'PrefixLabel
        '
        Me.PrefixLabel.AutoSize = True
        Me.PrefixLabel.Location = New System.Drawing.Point(7, 20)
        Me.PrefixLabel.Name = "PrefixLabel"
        Me.PrefixLabel.Size = New System.Drawing.Size(33, 13)
        Me.PrefixLabel.TabIndex = 0
        Me.PrefixLabel.Text = "Prefix"
        '
        'CountryGroupBox
        '
        Me.CountryGroupBox.Controls.Add(Me.CountryComboBox)
        Me.CountryGroupBox.Location = New System.Drawing.Point(13, 141)
        Me.CountryGroupBox.Name = "CountryGroupBox"
        Me.CountryGroupBox.Size = New System.Drawing.Size(140, 47)
        Me.CountryGroupBox.TabIndex = 2
        Me.CountryGroupBox.TabStop = False
        Me.CountryGroupBox.Text = "Country"
        '
        'CountryComboBox
        '
        Me.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Items.AddRange(New Object() {"Europe", "America"})
        Me.CountryComboBox.Location = New System.Drawing.Point(9, 16)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CountryComboBox.TabIndex = 0
        '
        'ResultGroupBox
        '
        Me.ResultGroupBox.Controls.Add(Me.ResultTextBox)
        Me.ResultGroupBox.Location = New System.Drawing.Point(159, 141)
        Me.ResultGroupBox.Name = "ResultGroupBox"
        Me.ResultGroupBox.Size = New System.Drawing.Size(113, 47)
        Me.ResultGroupBox.TabIndex = 3
        Me.ResultGroupBox.TabStop = False
        Me.ResultGroupBox.Text = "Result"
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Enabled = False
        Me.ResultTextBox.Location = New System.Drawing.Point(7, 16)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResultTextBox.TabIndex = 0
        '
        'InstructionsGroupBox
        '
        Me.InstructionsGroupBox.Controls.Add(Me.Label3)
        Me.InstructionsGroupBox.Controls.Add(Me.Label2)
        Me.InstructionsGroupBox.Controls.Add(Me.Label1)
        Me.InstructionsGroupBox.Controls.Add(Me.InstructionsLabel3)
        Me.InstructionsGroupBox.Controls.Add(Me.InstructionsLabel2)
        Me.InstructionsGroupBox.Controls.Add(Me.InstructionsLabel1)
        Me.InstructionsGroupBox.Location = New System.Drawing.Point(13, 195)
        Me.InstructionsGroupBox.Name = "InstructionsGroupBox"
        Me.InstructionsGroupBox.Size = New System.Drawing.Size(140, 115)
        Me.InstructionsGroupBox.TabIndex = 4
        Me.InstructionsGroupBox.TabStop = False
        Me.InstructionsGroupBox.Text = "Instructions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "N = Nothing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "L = Letter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "D = Digit"
        '
        'InstructionsLabel3
        '
        Me.InstructionsLabel3.AutoSize = True
        Me.InstructionsLabel3.Location = New System.Drawing.Point(5, 46)
        Me.InstructionsLabel3.Name = "InstructionsLabel3"
        Me.InstructionsLabel3.Size = New System.Drawing.Size(108, 13)
        Me.InstructionsLabel3.TabIndex = 2
        Me.InstructionsLabel3.Text = "need to include a ""-""."
        '
        'InstructionsLabel2
        '
        Me.InstructionsLabel2.AutoSize = True
        Me.InstructionsLabel2.Location = New System.Drawing.Point(4, 33)
        Me.InstructionsLabel2.Name = "InstructionsLabel2"
        Me.InstructionsLabel2.Size = New System.Drawing.Size(126, 13)
        Me.InstructionsLabel2.TabIndex = 1
        Me.InstructionsLabel2.Text = "callsign is GA, you do not"
        '
        'InstructionsLabel1
        '
        Me.InstructionsLabel1.AutoSize = True
        Me.InstructionsLabel1.Location = New System.Drawing.Point(3, 20)
        Me.InstructionsLabel1.Name = "InstructionsLabel1"
        Me.InstructionsLabel1.Size = New System.Drawing.Size(128, 13)
        Me.InstructionsLabel1.TabIndex = 0
        Me.InstructionsLabel1.Text = "Setup the scheme. If your"
        '
        'GenerateButton
        '
        Me.GenerateButton.Enabled = False
        Me.GenerateButton.Location = New System.Drawing.Point(159, 195)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(113, 88)
        Me.GenerateButton.TabIndex = 5
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.BackgroundImage = Global.callGen.My.Resources.Resources.Copy
        Me.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CopyButton.Enabled = False
        Me.CopyButton.Location = New System.Drawing.Point(159, 284)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(26, 26)
        Me.CopyButton.TabIndex = 6
        Me.CopyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'AttributionLinkLabel
        '
        Me.AttributionLinkLabel.AutoSize = True
        Me.AttributionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AttributionLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.AttributionLinkLabel.Location = New System.Drawing.Point(210, 291)
        Me.AttributionLinkLabel.Name = "AttributionLinkLabel"
        Me.AttributionLinkLabel.Size = New System.Drawing.Size(56, 13)
        Me.AttributionLinkLabel.TabIndex = 7
        Me.AttributionLinkLabel.TabStop = True
        Me.AttributionLinkLabel.Text = "by George"
        Me.AttributionLinkLabel.VisitedLinkColor = System.Drawing.Color.Black
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(201, 52)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(40, 13)
        Me.VersionLabel.TabIndex = 8
        Me.VersionLabel.Text = "1.0.0.0"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 319)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.AttributionLinkLabel)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.InstructionsGroupBox)
        Me.Controls.Add(Me.ResultGroupBox)
        Me.Controls.Add(Me.CountryGroupBox)
        Me.Controls.Add(Me.SchemeGroupBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "callGen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchemeGroupBox.ResumeLayout(False)
        Me.SchemeGroupBox.PerformLayout()
        Me.CountryGroupBox.ResumeLayout(False)
        Me.ResultGroupBox.ResumeLayout(False)
        Me.ResultGroupBox.PerformLayout()
        Me.InstructionsGroupBox.ResumeLayout(False)
        Me.InstructionsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SchemeGroupBox As GroupBox
    Friend WithEvents PrefixTextBox As TextBox
    Friend WithEvents PrefixLabel As Label
    Friend WithEvents SchemeLabel As Label
    Friend WithEvents GACheckBox As CheckBox
    Friend WithEvents SchemeComboBox4 As ComboBox
    Friend WithEvents SchemeComboBox3 As ComboBox
    Friend WithEvents SchemeComboBox2 As ComboBox
    Friend WithEvents SchemeComboBox1 As ComboBox
    Friend WithEvents CountryGroupBox As GroupBox
    Friend WithEvents CountryComboBox As ComboBox
    Friend WithEvents ResultGroupBox As GroupBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents InstructionsGroupBox As GroupBox
    Friend WithEvents InstructionsLabel3 As Label
    Friend WithEvents InstructionsLabel2 As Label
    Friend WithEvents InstructionsLabel1 As Label
    Friend WithEvents GenerateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CopyButton As Button
    Friend WithEvents AttributionLinkLabel As LinkLabel
    Friend WithEvents VersionLabel As Label
End Class
