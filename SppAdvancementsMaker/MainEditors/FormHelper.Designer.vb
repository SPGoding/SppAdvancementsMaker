<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHelper
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
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.TextBoxCommand = New System.Windows.Forms.TextBox()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.LabelChoice1 = New System.Windows.Forms.Label()
        Me.LabelChoice2 = New System.Windows.Forms.Label()
        Me.LabelChoice3 = New System.Windows.Forms.Label()
        Me.LabelInfo2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Location = New System.Drawing.Point(12, 9)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(45, 20)
        Me.LabelInfo.TabIndex = 0
        Me.LabelInfo.Text = "信息1"
        '
        'TextBoxCommand
        '
        Me.TextBoxCommand.Location = New System.Drawing.Point(16, 32)
        Me.TextBoxCommand.Name = "TextBoxCommand"
        Me.TextBoxCommand.Size = New System.Drawing.Size(338, 26)
        Me.TextBoxCommand.TabIndex = 1
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Location = New System.Drawing.Point(360, 32)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(70, 26)
        Me.ButtonCopy.TabIndex = 2
        Me.ButtonCopy.Text = "复制"
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'LabelChoice1
        '
        Me.LabelChoice1.AutoSize = True
        Me.LabelChoice1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelChoice1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelChoice1.ForeColor = System.Drawing.Color.Black
        Me.LabelChoice1.Location = New System.Drawing.Point(12, 97)
        Me.LabelChoice1.Name = "LabelChoice1"
        Me.LabelChoice1.Size = New System.Drawing.Size(45, 20)
        Me.LabelChoice1.TabIndex = 3
        Me.LabelChoice1.Text = "选项1"
        '
        'LabelChoice2
        '
        Me.LabelChoice2.AutoSize = True
        Me.LabelChoice2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelChoice2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelChoice2.ForeColor = System.Drawing.Color.Black
        Me.LabelChoice2.Location = New System.Drawing.Point(12, 126)
        Me.LabelChoice2.Name = "LabelChoice2"
        Me.LabelChoice2.Size = New System.Drawing.Size(45, 20)
        Me.LabelChoice2.TabIndex = 4
        Me.LabelChoice2.Text = "选项2"
        '
        'LabelChoice3
        '
        Me.LabelChoice3.AutoSize = True
        Me.LabelChoice3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelChoice3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelChoice3.ForeColor = System.Drawing.Color.Black
        Me.LabelChoice3.Location = New System.Drawing.Point(12, 156)
        Me.LabelChoice3.Name = "LabelChoice3"
        Me.LabelChoice3.Size = New System.Drawing.Size(45, 20)
        Me.LabelChoice3.TabIndex = 5
        Me.LabelChoice3.Text = "选项3"
        '
        'LabelInfo2
        '
        Me.LabelInfo2.AutoSize = True
        Me.LabelInfo2.Location = New System.Drawing.Point(12, 72)
        Me.LabelInfo2.Name = "LabelInfo2"
        Me.LabelInfo2.Size = New System.Drawing.Size(45, 20)
        Me.LabelInfo2.TabIndex = 6
        Me.LabelInfo2.Text = "信息2"
        '
        'FormHelper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 271)
        Me.Controls.Add(Me.LabelInfo2)
        Me.Controls.Add(Me.LabelChoice3)
        Me.Controls.Add(Me.LabelChoice2)
        Me.Controls.Add(Me.LabelChoice1)
        Me.Controls.Add(Me.ButtonCopy)
        Me.Controls.Add(Me.TextBoxCommand)
        Me.Controls.Add(Me.LabelInfo)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormHelper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_疑难解答"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInfo As Label
    Friend WithEvents TextBoxCommand As TextBox
    Friend WithEvents ButtonCopy As Button
    Friend WithEvents LabelChoice1 As Label
    Friend WithEvents LabelChoice2 As Label
    Friend WithEvents LabelChoice3 As Label
    Friend WithEvents LabelInfo2 As Label
End Class
