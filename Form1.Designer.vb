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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextWith = New System.Windows.Forms.TextBox()
        Me.ReplaceText = New System.Windows.Forms.TextBox()
        Me.Before = New System.Windows.Forms.TextBox()
        Me.After = New System.Windows.Forms.TextBox()
        Me.InFile = New System.Windows.Forms.TextBox()
        Me.CountWith = New System.Windows.Forms.TextBox()
        Me.ReplaceCount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(47, 151)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 11)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Replace ↓"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(173, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 11)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "With ↓(Count)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(64, 233)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Process File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 189)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 11)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "In File"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(172, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 11)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Add ↓ After"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label5.Location = New System.Drawing.Point(38, 76)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 11)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Add ↓ Before"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 11)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "in lines"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBox1.Checked = Global.FileMod.My.MySettings.Default.Count
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.FileMod.My.MySettings.Default, "Count", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(100, 113)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 37)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "  Increment/Count ->" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Enter Start Number)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                   v"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Enter the Starting count in the with box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter the signal to be replaced with th" &
        "e count.")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 11)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "in lines"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(188, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 11)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "With ↓"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Firebrick
        Me.Label9.Location = New System.Drawing.Point(44, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 11)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Replace ↓"
        '
        'TextWith
        '
        Me.TextWith.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileMod.My.MySettings.Default, "with1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextWith.ForeColor = System.Drawing.Color.DarkGreen
        Me.TextWith.Location = New System.Drawing.Point(154, 39)
        Me.TextWith.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextWith.Name = "TextWith"
        Me.TextWith.Size = New System.Drawing.Size(116, 18)
        Me.TextWith.TabIndex = 14
        Me.TextWith.Text = Global.FileMod.My.MySettings.Default.with1
        Me.TextWith.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReplaceText
        '
        Me.ReplaceText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileMod.My.MySettings.Default, "Replace1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ReplaceText.ForeColor = System.Drawing.Color.Firebrick
        Me.ReplaceText.Location = New System.Drawing.Point(21, 39)
        Me.ReplaceText.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ReplaceText.Name = "ReplaceText"
        Me.ReplaceText.Size = New System.Drawing.Size(116, 18)
        Me.ReplaceText.TabIndex = 13
        Me.ReplaceText.Text = Global.FileMod.My.MySettings.Default.Replace1
        Me.ReplaceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Before
        '
        Me.Before.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileMod.My.MySettings.Default, "addBefore", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Before.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Before.Location = New System.Drawing.Point(19, 89)
        Me.Before.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Before.Name = "Before"
        Me.Before.Size = New System.Drawing.Size(116, 18)
        Me.Before.TabIndex = 9
        Me.Before.Text = Global.FileMod.My.MySettings.Default.addBefore
        Me.Before.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'After
        '
        Me.After.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileMod.My.MySettings.Default, "addAfter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.After.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.After.Location = New System.Drawing.Point(155, 89)
        Me.After.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.After.Name = "After"
        Me.After.Size = New System.Drawing.Size(116, 18)
        Me.After.TabIndex = 7
        Me.After.Text = Global.FileMod.My.MySettings.Default.addAfter
        Me.After.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InFile
        '
        Me.InFile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileMod.My.MySettings.Default, "lastfile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InFile.Location = New System.Drawing.Point(41, 204)
        Me.InFile.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.InFile.Name = "InFile"
        Me.InFile.Size = New System.Drawing.Size(208, 18)
        Me.InFile.TabIndex = 5
        Me.InFile.Text = Global.FileMod.My.MySettings.Default.lastfile
        Me.InFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CountWith
        '
        Me.CountWith.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileMod.My.MySettings.Default, "withcount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CountWith.ForeColor = System.Drawing.Color.DarkGreen
        Me.CountWith.Location = New System.Drawing.Point(152, 165)
        Me.CountWith.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CountWith.Name = "CountWith"
        Me.CountWith.Size = New System.Drawing.Size(116, 18)
        Me.CountWith.TabIndex = 1
        Me.CountWith.Text = Global.FileMod.My.MySettings.Default.withcount
        Me.CountWith.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReplaceCount
        '
        Me.ReplaceCount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileMod.My.MySettings.Default, "Replace2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ReplaceCount.ForeColor = System.Drawing.Color.Firebrick
        Me.ReplaceCount.Location = New System.Drawing.Point(28, 165)
        Me.ReplaceCount.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ReplaceCount.Name = "ReplaceCount"
        Me.ReplaceCount.Size = New System.Drawing.Size(116, 18)
        Me.ReplaceCount.TabIndex = 0
        Me.ReplaceCount.Text = Global.FileMod.My.MySettings.Default.Replace2
        Me.ReplaceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(1, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 11)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "[Order of operations]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(1, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 11)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "[1st]"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(1, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 11)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "[2nd]"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(1, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 11)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "[3rd]"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(115, 65)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 11)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "each line"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 281)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextWith)
        Me.Controls.Add(Me.ReplaceText)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Before)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.After)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InFile)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CountWith)
        Me.Controls.Add(Me.ReplaceCount)
        Me.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "FileMod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReplaceCount As TextBox
    Friend WithEvents CountWith As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents InFile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents After As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Before As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextWith As TextBox
    Friend WithEvents ReplaceText As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
