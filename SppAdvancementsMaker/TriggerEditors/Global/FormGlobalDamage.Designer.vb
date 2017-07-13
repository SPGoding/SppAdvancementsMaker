<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGlobalDamage
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
        Me.ButtonSourceEntity = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDirectEntity = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxBlocked = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonType = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDownTakenMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDealtMax = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericUpDownTakenMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDealtMin = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownTakenMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDealtMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTakenMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDealtMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSourceEntity
        '
        Me.ButtonSourceEntity.Location = New System.Drawing.Point(190, 149)
        Me.ButtonSourceEntity.Name = "ButtonSourceEntity"
        Me.ButtonSourceEntity.Size = New System.Drawing.Size(212, 30)
        Me.ButtonSourceEntity.TabIndex = 141
        Me.ButtonSourceEntity.Tag = ""
        Me.ButtonSourceEntity.Text = "实体共通标签"
        Me.ButtonSourceEntity.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "根本来源(如僵尸、骷髅)"
        '
        'ButtonDirectEntity
        '
        Me.ButtonDirectEntity.Location = New System.Drawing.Point(190, 113)
        Me.ButtonDirectEntity.Name = "ButtonDirectEntity"
        Me.ButtonDirectEntity.Size = New System.Drawing.Size(212, 30)
        Me.ButtonDirectEntity.TabIndex = 139
        Me.ButtonDirectEntity.Tag = ""
        Me.ButtonDirectEntity.Text = "实体共通标签"
        Me.ButtonDirectEntity.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "伤害直接来源(如箭)"
        '
        'CheckBoxBlocked
        '
        Me.CheckBoxBlocked.AutoSize = True
        Me.CheckBoxBlocked.Location = New System.Drawing.Point(39, 225)
        Me.CheckBoxBlocked.Name = "CheckBoxBlocked"
        Me.CheckBoxBlocked.Size = New System.Drawing.Size(98, 24)
        Me.CheckBoxBlocked.TabIndex = 131
        Me.CheckBoxBlocked.Text = "被成功阻挡"
        Me.CheckBoxBlocked.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 19)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "本共通条件限定伤害"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(16, 281)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(284, 261)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 128
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(16, 261)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 20)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "填零、不勾选代表不限制"
        '
        'ButtonType
        '
        Me.ButtonType.Location = New System.Drawing.Point(190, 185)
        Me.ButtonType.Name = "ButtonType"
        Me.ButtonType.Size = New System.Drawing.Size(212, 30)
        Me.ButtonType.TabIndex = 157
        Me.ButtonType.Tag = ""
        Me.ButtonType.Text = "伤害类型共通标签"
        Me.ButtonType.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "伤害的类型"
        '
        'NumericUpDownTakenMax
        '
        Me.NumericUpDownTakenMax.DecimalPlaces = 2
        Me.NumericUpDownTakenMax.Location = New System.Drawing.Point(310, 81)
        Me.NumericUpDownTakenMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownTakenMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownTakenMax.Name = "NumericUpDownTakenMax"
        Me.NumericUpDownTakenMax.Size = New System.Drawing.Size(92, 26)
        Me.NumericUpDownTakenMax.TabIndex = 165
        '
        'NumericUpDownDealtMax
        '
        Me.NumericUpDownDealtMax.DecimalPlaces = 2
        Me.NumericUpDownDealtMax.Location = New System.Drawing.Point(310, 49)
        Me.NumericUpDownDealtMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDealtMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownDealtMax.Name = "NumericUpDownDealtMax"
        Me.NumericUpDownDealtMax.Size = New System.Drawing.Size(92, 26)
        Me.NumericUpDownDealtMax.TabIndex = 164
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(329, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 163
        Me.Label12.Text = "最大值"
        '
        'NumericUpDownTakenMin
        '
        Me.NumericUpDownTakenMin.DecimalPlaces = 2
        Me.NumericUpDownTakenMin.Location = New System.Drawing.Point(190, 81)
        Me.NumericUpDownTakenMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownTakenMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownTakenMin.Name = "NumericUpDownTakenMin"
        Me.NumericUpDownTakenMin.Size = New System.Drawing.Size(92, 26)
        Me.NumericUpDownTakenMin.TabIndex = 162
        '
        'NumericUpDownDealtMin
        '
        Me.NumericUpDownDealtMin.DecimalPlaces = 2
        Me.NumericUpDownDealtMin.Location = New System.Drawing.Point(190, 49)
        Me.NumericUpDownDealtMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDealtMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownDealtMin.Name = "NumericUpDownDealtMin"
        Me.NumericUpDownDealtMin.Size = New System.Drawing.Size(92, 26)
        Me.NumericUpDownDealtMin.TabIndex = 161
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 83)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 20)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "减少伤害后的伤害"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 20)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "减少伤害前的伤害"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "最小值"
        '
        'FormGlobalDamage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 325)
        Me.Controls.Add(Me.NumericUpDownTakenMax)
        Me.Controls.Add(Me.NumericUpDownDealtMax)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NumericUpDownTakenMin)
        Me.Controls.Add(Me.NumericUpDownDealtMin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ButtonSourceEntity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonDirectEntity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBoxBlocked)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormGlobalDamage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        CType(Me.NumericUpDownTakenMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDealtMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTakenMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDealtMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSourceEntity As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDirectEntity As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxBlocked As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonType As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDownTakenMax As NumericUpDown
    Friend WithEvents NumericUpDownDealtMax As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDownTakenMin As NumericUpDown
    Friend WithEvents NumericUpDownDealtMin As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
End Class
