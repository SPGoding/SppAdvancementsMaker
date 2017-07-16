<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJsonTextIDE
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
        Me.TextBoxText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ButtonThrow = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TextBoxText
        '
        Me.TextBoxText.Location = New System.Drawing.Point(16, 72)
        Me.TextBoxText.Multiline = True
        Me.TextBoxText.Name = "TextBoxText"
        Me.TextBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxText.Size = New System.Drawing.Size(519, 211)
        Me.TextBoxText.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(403, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "当前正在编辑的进度中有过于复杂的Json文本，本软件不能解析"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 20)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "你可以点击[丢弃]按钮进入简易Json文本编辑器，但复杂部分的内容会被丢弃"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(413, 289)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 46)
        Me.ButtonEnter.TabIndex = 62
        Me.ButtonEnter.Text = "更改完成"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ButtonThrow
        '
        Me.ButtonThrow.Location = New System.Drawing.Point(289, 289)
        Me.ButtonThrow.Name = "ButtonThrow"
        Me.ButtonThrow.Size = New System.Drawing.Size(118, 46)
        Me.ButtonThrow.TabIndex = 63
        Me.ButtonThrow.Text = "丢弃"
        Me.ButtonThrow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 20)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "或者你也可以在本窗口直接更改Json文本"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(285, 49)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(95, 20)
        Me.LinkLabel1.TabIndex = 65
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "校验Json文本"
        '
        'FormJsonTextIDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 354)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonThrow)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxText)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormJsonTextIDE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_复杂Json文本编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ButtonThrow As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
