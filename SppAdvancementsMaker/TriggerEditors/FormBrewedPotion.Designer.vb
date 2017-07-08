<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBrewedPotion
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxPotion = New System.Windows.Forms.ComboBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "本触发器在玩家从酿造台中拿出一瓶药水时触发"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "酿造药水："
        '
        'ComboBoxPotion
        '
        Me.ComboBoxPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPotion.FormattingEnabled = True
        Me.ComboBoxPotion.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxPotion.IntegralHeight = False
        Me.ComboBoxPotion.Items.AddRange(New Object() {"", "中毒", "伤害", "再生", "力量", "夜视", "平凡的药水", "幸运", "抗火", "水下呼吸", "水瓶", "治疗", "浑浊的药水", "粗制的药水", "缓慢", "虚弱", "跳跃", "迅捷", "隐身", "II级中毒", "II级伤害", "II级再生", "II级力量", "II级治疗", "II级跳跃", "II级迅捷", "延长版中毒", "延长版再生", "延长版力量", "延长版夜视", "延长版抗火", "延长版水下呼吸", "延长版缓慢", "延长版虚弱", "延长版跳跃", "延长版迅捷", "延长版隐身"})
        Me.ComboBoxPotion.Location = New System.Drawing.Point(105, 41)
        Me.ComboBoxPotion.Name = "ComboBoxPotion"
        Me.ComboBoxPotion.Size = New System.Drawing.Size(214, 28)
        Me.ComboBoxPotion.TabIndex = 44
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(201, 147)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 45
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(16, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "大多数条件是可选的"
        '
        'FormBrewedPotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 204)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.ComboBoxPotion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormBrewedPotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxPotion As ComboBox
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label3 As Label
End Class
