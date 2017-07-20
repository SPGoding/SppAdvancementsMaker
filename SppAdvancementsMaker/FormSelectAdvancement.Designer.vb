<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectAdvancement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectAdvancement))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxAdvancements = New System.Windows.Forms.ListBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonChangedSave = New System.Windows.Forms.Button()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(621, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "以下是你选择的存档中已有的全部进度，这部分包括了原版进度与你自己增加的进度(如果有的话)。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "你可以选中任一进度直接开始编辑，或点击[删除]按钮将其删除。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "或者" &
    "，你也可以　　　　　  　。"
        '
        'ListBoxAdvancements
        '
        Me.ListBoxAdvancements.FormattingEnabled = True
        Me.ListBoxAdvancements.ItemHeight = 20
        Me.ListBoxAdvancements.Location = New System.Drawing.Point(12, 75)
        Me.ListBoxAdvancements.Name = "ListBoxAdvancements"
        Me.ListBoxAdvancements.Size = New System.Drawing.Size(557, 244)
        Me.ListBoxAdvancements.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(115, 49)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 20)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "新建一个进度"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Enabled = False
        Me.ButtonEdit.Location = New System.Drawing.Point(575, 75)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(59, 120)
        Me.ButtonEdit.TabIndex = 42
        Me.ButtonEdit.Text = "编辑"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDel
        '
        Me.ButtonDel.Enabled = False
        Me.ButtonDel.Location = New System.Drawing.Point(575, 199)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(59, 120)
        Me.ButtonDel.TabIndex = 43
        Me.ButtonDel.Text = "删除"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'ButtonChangedSave
        '
        Me.ButtonChangedSave.Location = New System.Drawing.Point(12, 361)
        Me.ButtonChangedSave.Name = "ButtonChangedSave"
        Me.ButtonChangedSave.Size = New System.Drawing.Size(132, 47)
        Me.ButtonChangedSave.TabIndex = 44
        Me.ButtonChangedSave.Text = "更换存档"
        Me.ButtonChangedSave.UseVisualStyleBackColor = True
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Location = New System.Drawing.Point(13, 322)
        Me.LabelInfo.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 20)
        Me.LabelInfo.TabIndex = 45
        '
        'FormSelectAdvancement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 420)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.ButtonChangedSave)
        Me.Controls.Add(Me.ButtonDel)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ListBoxAdvancements)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormSelectAdvancement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_选择进度"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxAdvancements As ListBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonChangedSave As Button
    Friend WithEvents LabelInfo As Label
End Class
