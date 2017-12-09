Imports Squirrel

Public Class MainForm
    Dim generalAviationMode As Boolean

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDefaults()
        UpdateApp()

        VersionLabel.Text = My.Application.Info.Version.ToString()
    End Sub

    Async Sub UpdateApp()
        Dim mgr As UpdateManager = New UpdateManager("https://cdn.georgepeppard.me/callGen/Squirrel")
        Await mgr.UpdateApp()
    End Sub

    Sub SetupDefaults()
        SchemeComboBox1.SelectedIndex = 0
        SchemeComboBox2.SelectedIndex = 0
        SchemeComboBox3.SelectedIndex = 0
        SchemeComboBox4.SelectedIndex = 0
        CountryComboBox.SelectedIndex = 0
    End Sub

    Sub EnableGAMode()
        PrefixTextBox.Text = ""
        PrefixTextBox.MaxLength = 2

        SchemeComboBox1.Enabled = False
        SchemeComboBox2.Enabled = False
        SchemeComboBox3.Enabled = False
        SchemeComboBox4.Enabled = False

        generalAviationMode = True
    End Sub

    Sub DisableGAMode()
        PrefixTextBox.Text = ""
        PrefixTextBox.MaxLength = 3

        SchemeComboBox1.Enabled = True
        SchemeComboBox2.Enabled = True
        SchemeComboBox3.Enabled = True
        SchemeComboBox4.Enabled = True

        generalAviationMode = False
    End Sub

    Private Sub GACheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles GACheckBox.CheckedChanged
        If GACheckBox.Checked Then
            EnableGAMode()
        Else
            DisableGAMode()
        End If
    End Sub

    Function GenerateCharacter() As Char
        Dim validCharacters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim random As Integer = Int(Rnd() * validCharacters.Length)
        Dim randomChar As Char = validCharacters(random)

        GenerateCharacter = randomChar
    End Function

    Function GenerateNumber() As Char
        Dim validCharacters As String = "0123456789"
        Dim random As Integer = Int(Rnd() * validCharacters.Length)
        Dim randomChar As Char = validCharacters(random)

        GenerateNumber = randomChar
    End Function

    Sub GenerateCallsign()
        If GACheckBox.Checked Then
            GenerateGACallsign()
        Else
            GenerateCommercialCallsign()
        End If

        CopyButton.Enabled = True
    End Sub

    Sub GenerateGACallsign()
        Select Case CountryComboBox.SelectedIndex
            Case 0
                GenerateEuropeGACallsign()
            Case Else
                GenerateAmericaGACallsign()
        End Select
    End Sub

    Sub GenerateEuropeGACallsign()
        Dim str As String = ""

        str = str & PrefixTextBox.Text & "-"

        For count = 1 To 4
            str = str & GenerateCharacter()
        Next

        ResultTextBox.Text = str
    End Sub

    Sub GenerateAmericaGACallsign()
        Dim str As String = ""

        str = str & PrefixTextBox.Text

        For count = 1 To 3
            str = str & GenerateNumber()
        Next

        For count = 1 To 2
            str = str & GenerateCharacter()
        Next

        ResultTextBox.Text = str
    End Sub

    Sub GenerateCommercialCallsign()
        Dim str As String = ""

        str = str & PrefixTextBox.Text

        Select Case SchemeComboBox1.SelectedIndex
            Case 0
                str = str & GenerateNumber()
            Case 1
                str = str & GenerateCharacter()
            Case Else
                str = str
        End Select

        Select Case SchemeComboBox2.SelectedIndex
            Case 0
                str = str & GenerateNumber()
            Case 1
                str = str & GenerateCharacter()
            Case Else
                str = str
        End Select

        Select Case SchemeComboBox3.SelectedIndex
            Case 0
                str = str & GenerateNumber()
            Case 1
                str = str & GenerateCharacter()
            Case Else
                str = str
        End Select

        Select Case SchemeComboBox4.SelectedIndex
            Case 0
                str = str & GenerateNumber()
            Case 1
                str = str & GenerateCharacter()
            Case Else
                str = str
        End Select

        ResultTextBox.Text = str
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        GenerateCallsign()
    End Sub

    Private Sub AttributionLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AttributionLinkLabel.LinkClicked
        Process.Start("https://georgepeppard.me/")
    End Sub

    Sub CopyCallsign()
        Clipboard.SetText(ResultTextBox.Text)
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        CopyCallsign()
    End Sub

    Private Sub PrefixTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrefixTextBox.TextChanged
        If Not PrefixTextBox.Text = "" Then
            GenerateButton.Enabled = True
        Else
            GenerateButton.Enabled = False
        End If
    End Sub
End Class
