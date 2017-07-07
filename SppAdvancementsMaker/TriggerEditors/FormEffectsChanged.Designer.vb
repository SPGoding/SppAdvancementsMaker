<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEffectsChanged
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
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEffectName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownAmplifier = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDuration = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxEffects = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownAmplifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(285, 329)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 49
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "状态效果名称："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "本触发器在玩家获得/消除状态效果时触发"
        '
        'ComboBoxEffectName
        '
        Me.ComboBoxEffectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEffectName.FormattingEnabled = True
        Me.ComboBoxEffectName.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxEffectName.IntegralHeight = False
        Me.ComboBoxEffectName.Items.AddRange(New Object() {"中毒", "伤害", "再生", "力量", "夜视", "平凡的药水", "幸运", "抗火", "水下呼吸", "水瓶", "治疗", "浑浊的药水", "粗制的药水", "缓慢", "虚弱", "跳跃", "迅捷", "隐身", "II级中毒", "II级伤害", "II级再生", "II级力量", "II级治疗", "II级跳跃", "II级迅捷", "延长版中毒", "延长版再生", "延长版力量", "延长版夜视", "延长版抗火", "延长版水下呼吸", "延长版缓慢", "延长版虚弱", "延长版跳跃", "延长版迅捷", "延长版隐身"})
        Me.ComboBoxEffectName.Location = New System.Drawing.Point(171, 202)
        Me.ComboBoxEffectName.Name = "ComboBoxEffectName"
        Me.ComboBoxEffectName.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxEffectName.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "效果放大器："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 270)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "持续时间(刻为单位)："
        '
        'NumericUpDownAmplifier
        '
        Me.NumericUpDownAmplifier.Location = New System.Drawing.Point(171, 236)
        Me.NumericUpDownAmplifier.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownAmplifier.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownAmplifier.Name = "NumericUpDownAmplifier"
        Me.NumericUpDownAmplifier.Size = New System.Drawing.Size(232, 26)
        Me.NumericUpDownAmplifier.TabIndex = 52
        Me.NumericUpDownAmplifier.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDownDuration
        '
        Me.NumericUpDownDuration.Location = New System.Drawing.Point(171, 268)
        Me.NumericUpDownDuration.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDuration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownDuration.Name = "NumericUpDownDuration"
        Me.NumericUpDownDuration.Size = New System.Drawing.Size(232, 26)
        Me.NumericUpDownDuration.TabIndex = 53
        Me.NumericUpDownDuration.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(167, 297)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "*一秒中有20刻"
        '
        'ListBoxEffects
        '
        Me.ListBoxEffects.FormattingEnabled = True
        Me.ListBoxEffects.ItemHeight = 20
        Me.ListBoxEffects.Location = New System.Drawing.Point(20, 32)
        Me.ListBoxEffects.Name = "ListBoxEffects"
        Me.ListBoxEffects.Size = New System.Drawing.Size(335, 164)
        Me.ListBoxEffects.TabIndex = 55
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 81)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "＋"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(361, 119)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 77)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "－"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormEffectsChanged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 386)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBoxEffects)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDownDuration)
        Me.Controls.Add(Me.NumericUpDownAmplifier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.ComboBoxEffectName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormEffectsChanged"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        CType(Me.NumericUpDownAmplifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEffectName As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownAmplifier As NumericUpDown
    Friend WithEvents NumericUpDownDuration As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxEffects As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
