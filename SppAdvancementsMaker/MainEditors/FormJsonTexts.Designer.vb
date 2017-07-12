<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJsonTexts
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.CheckBoxBold = New System.Windows.Forms.CheckBox()
        Me.CheckBoxItalic = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUnderline = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStrikethrough = New System.Windows.Forms.CheckBox()
        Me.CheckBoxObfuscated = New System.Windows.Forms.CheckBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "文本"
        '
        'TextBoxText
        '
        Me.TextBoxText.Location = New System.Drawing.Point(57, 6)
        Me.TextBoxText.Name = "TextBoxText"
        Me.TextBoxText.Size = New System.Drawing.Size(232, 26)
        Me.TextBoxText.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "颜色"
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxColor.Location = New System.Drawing.Point(57, 38)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxColor.TabIndex = 29
        '
        'CheckBoxBold
        '
        Me.CheckBoxBold.AutoSize = True
        Me.CheckBoxBold.Location = New System.Drawing.Point(17, 72)
        Me.CheckBoxBold.Name = "CheckBoxBold"
        Me.CheckBoxBold.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxBold.TabIndex = 30
        Me.CheckBoxBold.Text = "粗体"
        Me.CheckBoxBold.UseVisualStyleBackColor = True
        '
        'CheckBoxItalic
        '
        Me.CheckBoxItalic.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.CheckBoxItalic.AutoSize = True
        Me.CheckBoxItalic.Location = New System.Drawing.Point(79, 72)
        Me.CheckBoxItalic.Name = "CheckBoxItalic"
        Me.CheckBoxItalic.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxItalic.TabIndex = 31
        Me.CheckBoxItalic.Text = "斜体"
        Me.CheckBoxItalic.UseVisualStyleBackColor = True
        '
        'CheckBoxUnderline
        '
        Me.CheckBoxUnderline.AutoSize = True
        Me.CheckBoxUnderline.Location = New System.Drawing.Point(141, 72)
        Me.CheckBoxUnderline.Name = "CheckBoxUnderline"
        Me.CheckBoxUnderline.Size = New System.Drawing.Size(70, 24)
        Me.CheckBoxUnderline.TabIndex = 32
        Me.CheckBoxUnderline.Text = "下划线"
        Me.CheckBoxUnderline.UseVisualStyleBackColor = True
        '
        'CheckBoxStrikethrough
        '
        Me.CheckBoxStrikethrough.AutoSize = True
        Me.CheckBoxStrikethrough.Location = New System.Drawing.Point(79, 102)
        Me.CheckBoxStrikethrough.Name = "CheckBoxStrikethrough"
        Me.CheckBoxStrikethrough.Size = New System.Drawing.Size(70, 24)
        Me.CheckBoxStrikethrough.TabIndex = 33
        Me.CheckBoxStrikethrough.Text = "删除线"
        Me.CheckBoxStrikethrough.UseVisualStyleBackColor = True
        '
        'CheckBoxObfuscated
        '
        Me.CheckBoxObfuscated.AutoSize = True
        Me.CheckBoxObfuscated.Location = New System.Drawing.Point(17, 102)
        Me.CheckBoxObfuscated.Name = "CheckBoxObfuscated"
        Me.CheckBoxObfuscated.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxObfuscated.TabIndex = 34
        Me.CheckBoxObfuscated.Text = "模糊"
        Me.CheckBoxObfuscated.UseVisualStyleBackColor = True
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(171, 129)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 46)
        Me.ButtonEnter.TabIndex = 35
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'FormJsonTexts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 187)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.CheckBoxObfuscated)
        Me.Controls.Add(Me.CheckBoxStrikethrough)
        Me.Controls.Add(Me.CheckBoxUnderline)
        Me.Controls.Add(Me.CheckBoxItalic)
        Me.Controls.Add(Me.CheckBoxBold)
        Me.Controls.Add(Me.ComboBoxColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxText)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormJsonTexts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "#2进度修改者_简易Json文本编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxColor As ComboBox
    Friend WithEvents CheckBoxBold As CheckBox
    Friend WithEvents CheckBoxItalic As CheckBox
    Friend WithEvents CheckBoxUnderline As CheckBox
    Friend WithEvents CheckBoxStrikethrough As CheckBox
    Friend WithEvents CheckBoxObfuscated As CheckBox
    Friend WithEvents ButtonEnter As Button
End Class
