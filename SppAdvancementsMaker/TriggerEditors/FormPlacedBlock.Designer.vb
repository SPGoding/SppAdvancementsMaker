<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlacedBlock
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonLocation = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonItem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxStateValue6 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateValue5 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateValue4 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateValue3 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateValue2 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateValue1 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateName6 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateName5 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateName4 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateName3 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateName2 = New System.Windows.Forms.TextBox()
        Me.TextBoxStateName1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelStateName6 = New System.Windows.Forms.Label()
        Me.LabelStateName5 = New System.Windows.Forms.Label()
        Me.LabelStateName4 = New System.Windows.Forms.Label()
        Me.LabelStateName3 = New System.Windows.Forms.Label()
        Me.LabelStateName2 = New System.Windows.Forms.Label()
        Me.LabelStateName1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxBlock = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonLocation
        '
        Me.ButtonLocation.Location = New System.Drawing.Point(119, 68)
        Me.ButtonLocation.Name = "ButtonLocation"
        Me.ButtonLocation.Size = New System.Drawing.Size(212, 30)
        Me.ButtonLocation.TabIndex = 86
        Me.ButtonLocation.Tag = ""
        Me.ButtonLocation.Text = "位置信息共通标签"
        Me.ButtonLocation.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "放置的位置"
        '
        'ButtonItem
        '
        Me.ButtonItem.Location = New System.Drawing.Point(119, 32)
        Me.ButtonItem.Name = "ButtonItem"
        Me.ButtonItem.Size = New System.Drawing.Size(212, 30)
        Me.ButtonItem.TabIndex = 84
        Me.ButtonItem.Tag = ""
        Me.ButtonItem.Text = "物品共通标签"
        Me.ButtonItem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(15, 379)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(213, 379)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 82
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "使用的物品"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 19)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "本触发器在玩家放置方块时触发"
        '
        'TextBoxStateValue6
        '
        Me.TextBoxStateValue6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateValue6.Location = New System.Drawing.Point(161, 319)
        Me.TextBoxStateValue6.Name = "TextBoxStateValue6"
        Me.TextBoxStateValue6.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxStateValue6.TabIndex = 108
        '
        'TextBoxStateValue5
        '
        Me.TextBoxStateValue5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateValue5.Location = New System.Drawing.Point(161, 287)
        Me.TextBoxStateValue5.Name = "TextBoxStateValue5"
        Me.TextBoxStateValue5.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxStateValue5.TabIndex = 107
        '
        'TextBoxStateValue4
        '
        Me.TextBoxStateValue4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateValue4.Location = New System.Drawing.Point(160, 255)
        Me.TextBoxStateValue4.Name = "TextBoxStateValue4"
        Me.TextBoxStateValue4.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxStateValue4.TabIndex = 106
        '
        'TextBoxStateValue3
        '
        Me.TextBoxStateValue3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateValue3.Location = New System.Drawing.Point(161, 223)
        Me.TextBoxStateValue3.Name = "TextBoxStateValue3"
        Me.TextBoxStateValue3.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxStateValue3.TabIndex = 105
        '
        'TextBoxStateValue2
        '
        Me.TextBoxStateValue2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateValue2.Location = New System.Drawing.Point(161, 191)
        Me.TextBoxStateValue2.Name = "TextBoxStateValue2"
        Me.TextBoxStateValue2.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxStateValue2.TabIndex = 104
        '
        'TextBoxStateValue1
        '
        Me.TextBoxStateValue1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateValue1.Location = New System.Drawing.Point(161, 159)
        Me.TextBoxStateValue1.Name = "TextBoxStateValue1"
        Me.TextBoxStateValue1.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxStateValue1.TabIndex = 103
        '
        'TextBoxStateName6
        '
        Me.TextBoxStateName6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateName6.Location = New System.Drawing.Point(20, 319)
        Me.TextBoxStateName6.Name = "TextBoxStateName6"
        Me.TextBoxStateName6.Size = New System.Drawing.Size(106, 26)
        Me.TextBoxStateName6.TabIndex = 102
        '
        'TextBoxStateName5
        '
        Me.TextBoxStateName5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateName5.Location = New System.Drawing.Point(21, 287)
        Me.TextBoxStateName5.Name = "TextBoxStateName5"
        Me.TextBoxStateName5.Size = New System.Drawing.Size(106, 26)
        Me.TextBoxStateName5.TabIndex = 101
        '
        'TextBoxStateName4
        '
        Me.TextBoxStateName4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateName4.Location = New System.Drawing.Point(21, 255)
        Me.TextBoxStateName4.Name = "TextBoxStateName4"
        Me.TextBoxStateName4.Size = New System.Drawing.Size(106, 26)
        Me.TextBoxStateName4.TabIndex = 100
        '
        'TextBoxStateName3
        '
        Me.TextBoxStateName3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateName3.Location = New System.Drawing.Point(21, 223)
        Me.TextBoxStateName3.Name = "TextBoxStateName3"
        Me.TextBoxStateName3.Size = New System.Drawing.Size(106, 26)
        Me.TextBoxStateName3.TabIndex = 99
        '
        'TextBoxStateName2
        '
        Me.TextBoxStateName2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateName2.Location = New System.Drawing.Point(21, 191)
        Me.TextBoxStateName2.Name = "TextBoxStateName2"
        Me.TextBoxStateName2.Size = New System.Drawing.Size(106, 26)
        Me.TextBoxStateName2.TabIndex = 98
        '
        'TextBoxStateName1
        '
        Me.TextBoxStateName1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxStateName1.Location = New System.Drawing.Point(21, 159)
        Me.TextBoxStateName1.Name = "TextBoxStateName1"
        Me.TextBoxStateName1.Size = New System.Drawing.Size(106, 26)
        Me.TextBoxStateName1.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.5!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(110, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "点击查看状态列表"
        '
        'LabelStateName6
        '
        Me.LabelStateName6.AutoSize = True
        Me.LabelStateName6.Location = New System.Drawing.Point(128, 322)
        Me.LabelStateName6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelStateName6.Name = "LabelStateName6"
        Me.LabelStateName6.Size = New System.Drawing.Size(23, 20)
        Me.LabelStateName6.TabIndex = 95
        Me.LabelStateName6.Text = "："
        Me.LabelStateName6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStateName5
        '
        Me.LabelStateName5.AutoSize = True
        Me.LabelStateName5.Location = New System.Drawing.Point(128, 290)
        Me.LabelStateName5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelStateName5.Name = "LabelStateName5"
        Me.LabelStateName5.Size = New System.Drawing.Size(23, 20)
        Me.LabelStateName5.TabIndex = 94
        Me.LabelStateName5.Text = "："
        Me.LabelStateName5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStateName4
        '
        Me.LabelStateName4.AutoSize = True
        Me.LabelStateName4.Location = New System.Drawing.Point(128, 258)
        Me.LabelStateName4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelStateName4.Name = "LabelStateName4"
        Me.LabelStateName4.Size = New System.Drawing.Size(23, 20)
        Me.LabelStateName4.TabIndex = 93
        Me.LabelStateName4.Text = "："
        Me.LabelStateName4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStateName3
        '
        Me.LabelStateName3.AutoSize = True
        Me.LabelStateName3.Location = New System.Drawing.Point(128, 226)
        Me.LabelStateName3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelStateName3.Name = "LabelStateName3"
        Me.LabelStateName3.Size = New System.Drawing.Size(23, 20)
        Me.LabelStateName3.TabIndex = 92
        Me.LabelStateName3.Text = "："
        Me.LabelStateName3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStateName2
        '
        Me.LabelStateName2.AutoSize = True
        Me.LabelStateName2.Location = New System.Drawing.Point(128, 194)
        Me.LabelStateName2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelStateName2.Name = "LabelStateName2"
        Me.LabelStateName2.Size = New System.Drawing.Size(23, 20)
        Me.LabelStateName2.TabIndex = 91
        Me.LabelStateName2.Text = "："
        Me.LabelStateName2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStateName1
        '
        Me.LabelStateName1.AutoSize = True
        Me.LabelStateName1.Location = New System.Drawing.Point(128, 162)
        Me.LabelStateName1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelStateName1.Name = "LabelStateName1"
        Me.LabelStateName1.Size = New System.Drawing.Size(23, 20)
        Me.LabelStateName1.TabIndex = 90
        Me.LabelStateName1.Text = "："
        Me.LabelStateName1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "方块的状态"
        '
        'ComboBoxBlock
        '
        Me.ComboBoxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBlock.FormattingEnabled = True
        Me.ComboBoxBlock.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxBlock.IntegralHeight = False
        Me.ComboBoxBlock.Location = New System.Drawing.Point(119, 104)
        Me.ComboBoxBlock.MaxDropDownItems = 16
        Me.ComboBoxBlock.Name = "ComboBoxBlock"
        Me.ComboBoxBlock.Size = New System.Drawing.Size(212, 28)
        Me.ComboBoxBlock.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 107)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "放置的方块"
        '
        'FormPlacedBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 447)
        Me.Controls.Add(Me.TextBoxStateValue6)
        Me.Controls.Add(Me.TextBoxStateValue5)
        Me.Controls.Add(Me.TextBoxStateValue4)
        Me.Controls.Add(Me.TextBoxStateValue3)
        Me.Controls.Add(Me.TextBoxStateValue2)
        Me.Controls.Add(Me.TextBoxStateValue1)
        Me.Controls.Add(Me.TextBoxStateName6)
        Me.Controls.Add(Me.TextBoxStateName5)
        Me.Controls.Add(Me.TextBoxStateName4)
        Me.Controls.Add(Me.TextBoxStateName3)
        Me.Controls.Add(Me.TextBoxStateName2)
        Me.Controls.Add(Me.TextBoxStateName1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelStateName6)
        Me.Controls.Add(Me.LabelStateName5)
        Me.Controls.Add(Me.LabelStateName4)
        Me.Controls.Add(Me.LabelStateName3)
        Me.Controls.Add(Me.LabelStateName2)
        Me.Controls.Add(Me.LabelStateName1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxBlock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPlacedBlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLocation As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonItem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxStateValue6 As TextBox
    Friend WithEvents TextBoxStateValue5 As TextBox
    Friend WithEvents TextBoxStateValue4 As TextBox
    Friend WithEvents TextBoxStateValue3 As TextBox
    Friend WithEvents TextBoxStateValue2 As TextBox
    Friend WithEvents TextBoxStateValue1 As TextBox
    Friend WithEvents TextBoxStateName6 As TextBox
    Friend WithEvents TextBoxStateName5 As TextBox
    Friend WithEvents TextBoxStateName4 As TextBox
    Friend WithEvents TextBoxStateName3 As TextBox
    Friend WithEvents TextBoxStateName2 As TextBox
    Friend WithEvents TextBoxStateName1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelStateName6 As Label
    Friend WithEvents LabelStateName5 As Label
    Friend WithEvents LabelStateName4 As Label
    Friend WithEvents LabelStateName3 As Label
    Friend WithEvents LabelStateName2 As Label
    Friend WithEvents LabelStateName1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxBlock As ComboBox
    Friend WithEvents Label7 As Label
End Class
