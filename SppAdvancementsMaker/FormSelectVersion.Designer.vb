<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectVersion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectVersion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ComboBoxVersion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "请选择游戏版本"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(134, 102)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 55
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ComboBoxVersion
        '
        Me.ComboBoxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVersion.FormattingEnabled = True
        Me.ComboBoxVersion.IntegralHeight = False
        Me.ComboBoxVersion.Items.AddRange(New Object() {"1.12", "1.13"})
        Me.ComboBoxVersion.Location = New System.Drawing.Point(20, 32)
        Me.ComboBoxVersion.MaxDropDownItems = 16
        Me.ComboBoxVersion.Name = "ComboBoxVersion"
        Me.ComboBoxVersion.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxVersion.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(12, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 17)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "*软件引用了James Newton-King制作的Json.Net"
        '
        'FormSelectVersion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 172)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormSelectVersion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ComboBoxVersion As ComboBox
    Friend WithEvents Label5 As Label
End Class
