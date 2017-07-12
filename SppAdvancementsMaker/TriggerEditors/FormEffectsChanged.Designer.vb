<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEffectsChanged
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
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEffectName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownAmplifierMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDurationMin = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxEffects = New System.Windows.Forms.ListBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDownAmplifierMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDurationMax = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownAmplifierMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDurationMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownAmplifierMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDurationMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(285, 344)
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
        Me.ComboBoxEffectName.Enabled = False
        Me.ComboBoxEffectName.FormattingEnabled = True
        Me.ComboBoxEffectName.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxEffectName.IntegralHeight = False
        Me.ComboBoxEffectName.Location = New System.Drawing.Point(133, 200)
        Me.ComboBoxEffectName.Name = "ComboBoxEffectName"
        Me.ComboBoxEffectName.Size = New System.Drawing.Size(270, 28)
        Me.ComboBoxEffectName.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 256)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "效果放大器"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "持续时间(刻)"
        '
        'NumericUpDownAmplifierMin
        '
        Me.NumericUpDownAmplifierMin.Enabled = False
        Me.NumericUpDownAmplifierMin.Location = New System.Drawing.Point(133, 254)
        Me.NumericUpDownAmplifierMin.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownAmplifierMin.Name = "NumericUpDownAmplifierMin"
        Me.NumericUpDownAmplifierMin.Size = New System.Drawing.Size(130, 26)
        Me.NumericUpDownAmplifierMin.TabIndex = 52
        '
        'NumericUpDownDurationMin
        '
        Me.NumericUpDownDurationMin.Enabled = False
        Me.NumericUpDownDurationMin.Location = New System.Drawing.Point(133, 286)
        Me.NumericUpDownDurationMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDurationMin.Name = "NumericUpDownDurationMin"
        Me.NumericUpDownDurationMin.Size = New System.Drawing.Size(130, 26)
        Me.NumericUpDownDurationMin.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(16, 308)
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
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(361, 32)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(42, 79)
        Me.ButtonAdd.TabIndex = 56
        Me.ButtonAdd.Text = "添加"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDel
        '
        Me.ButtonDel.Enabled = False
        Me.ButtonDel.Location = New System.Drawing.Point(361, 117)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(42, 79)
        Me.ButtonDel.TabIndex = 57
        Me.ButtonDel.Text = "删除"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(16, 364)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "大多数条件是可选的"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 231)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "最小值"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(16, 344)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "填零代表不限制"
        '
        'NumericUpDownAmplifierMax
        '
        Me.NumericUpDownAmplifierMax.Enabled = False
        Me.NumericUpDownAmplifierMax.Location = New System.Drawing.Point(273, 254)
        Me.NumericUpDownAmplifierMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownAmplifierMax.Name = "NumericUpDownAmplifierMax"
        Me.NumericUpDownAmplifierMax.Size = New System.Drawing.Size(130, 26)
        Me.NumericUpDownAmplifierMax.TabIndex = 76
        '
        'NumericUpDownDurationMax
        '
        Me.NumericUpDownDurationMax.Enabled = False
        Me.NumericUpDownDurationMax.Location = New System.Drawing.Point(273, 286)
        Me.NumericUpDownDurationMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDurationMax.Name = "NumericUpDownDurationMax"
        Me.NumericUpDownDurationMax.Size = New System.Drawing.Size(130, 26)
        Me.NumericUpDownDurationMax.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(314, 231)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "最大值"
        '
        'FormEffectsChanged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 400)
        Me.Controls.Add(Me.NumericUpDownAmplifierMax)
        Me.Controls.Add(Me.NumericUpDownDurationMax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonDel)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ListBoxEffects)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDownDurationMin)
        Me.Controls.Add(Me.NumericUpDownAmplifierMin)
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
        CType(Me.NumericUpDownAmplifierMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDurationMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownAmplifierMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDurationMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEffectName As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownAmplifierMin As NumericUpDown
    Friend WithEvents NumericUpDownDurationMin As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxEffects As ListBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonDel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUpDownAmplifierMax As NumericUpDown
    Friend WithEvents NumericUpDownDurationMax As NumericUpDown
    Friend WithEvents Label8 As Label
End Class
