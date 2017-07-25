<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectDataPack
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonSelectSave = New System.Windows.Forms.Button()
        Me.TextBoxSavePath = New System.Windows.Forms.TextBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ListBoxSaves = New System.Windows.Forms.ListBox()
        Me.PanelOffline = New System.Windows.Forms.Panel()
        Me.PanelOnline = New System.Windows.Forms.Panel()
        Me.LabelOffline = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelOffline.SuspendLayout()
        Me.PanelOnline.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "请选择数据包"
        '
        'ButtonSelectSave
        '
        Me.ButtonSelectSave.Location = New System.Drawing.Point(327, 4)
        Me.ButtonSelectSave.Name = "ButtonSelectSave"
        Me.ButtonSelectSave.Size = New System.Drawing.Size(25, 24)
        Me.ButtonSelectSave.TabIndex = 38
        Me.ButtonSelectSave.Text = "···"
        Me.ButtonSelectSave.UseVisualStyleBackColor = True
        '
        'TextBoxSavePath
        '
        Me.TextBoxSavePath.Location = New System.Drawing.Point(11, 3)
        Me.TextBoxSavePath.Name = "TextBoxSavePath"
        Me.TextBoxSavePath.ReadOnly = True
        Me.TextBoxSavePath.Size = New System.Drawing.Size(315, 26)
        Me.TextBoxSavePath.TabIndex = 34
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Enabled = False
        Me.ButtonEnter.Location = New System.Drawing.Point(263, 164)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 49
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ListBoxSaves
        '
        Me.ListBoxSaves.FormattingEnabled = True
        Me.ListBoxSaves.ItemHeight = 20
        Me.ListBoxSaves.Location = New System.Drawing.Point(11, 0)
        Me.ListBoxSaves.Name = "ListBoxSaves"
        Me.ListBoxSaves.Size = New System.Drawing.Size(341, 84)
        Me.ListBoxSaves.TabIndex = 44
        '
        'PanelOffline
        '
        Me.PanelOffline.Controls.Add(Me.ButtonSelectSave)
        Me.PanelOffline.Controls.Add(Me.TextBoxSavePath)
        Me.PanelOffline.Location = New System.Drawing.Point(29, 56)
        Me.PanelOffline.Name = "PanelOffline"
        Me.PanelOffline.Size = New System.Drawing.Size(352, 31)
        Me.PanelOffline.TabIndex = 51
        '
        'PanelOnline
        '
        Me.PanelOnline.Controls.Add(Me.LabelOffline)
        Me.PanelOnline.Controls.Add(Me.ListBoxSaves)
        Me.PanelOnline.Location = New System.Drawing.Point(29, 56)
        Me.PanelOnline.Name = "PanelOnline"
        Me.PanelOnline.Size = New System.Drawing.Size(352, 110)
        Me.PanelOnline.TabIndex = 52
        Me.PanelOnline.Visible = False
        '
        'LabelOffline
        '
        Me.LabelOffline.AutoSize = True
        Me.LabelOffline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelOffline.Font = New System.Drawing.Font("微软雅黑", 10.5!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelOffline.ForeColor = System.Drawing.Color.Gray
        Me.LabelOffline.Location = New System.Drawing.Point(7, 87)
        Me.LabelOffline.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelOffline.Name = "LabelOffline"
        Me.LabelOffline.Size = New System.Drawing.Size(163, 20)
        Me.LabelOffline.TabIndex = 63
        Me.LabelOffline.Text = "我要选其他位置的数据包"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(36, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "接下来的一切操作都只对该数据包有效"
        '
        'FormSelectDataPack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 244)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.PanelOffline)
        Me.Controls.Add(Me.PanelOnline)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormSelectDataPack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_选择数据包"
        Me.PanelOffline.ResumeLayout(False)
        Me.PanelOffline.PerformLayout()
        Me.PanelOnline.ResumeLayout(False)
        Me.PanelOnline.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ButtonSelectSave As Button
    Friend WithEvents TextBoxSavePath As TextBox
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ListBoxSaves As ListBox
    Friend WithEvents PanelOffline As Panel
    Friend WithEvents PanelOnline As Panel
    Friend WithEvents LabelOffline As Label
    Friend WithEvents Label2 As Label
End Class
