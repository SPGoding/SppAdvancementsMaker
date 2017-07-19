<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemDurabilityChanged
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownDurabilityMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDeltaMax = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownDurabilityMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDeltaMin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonItem = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownDurabilityMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDeltaMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDurabilityMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDeltaMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(20, 189)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "大多数条件是可选的"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(20, 169)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "填零代表不限制"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(223, 169)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 154
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 19)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "本触发器在物品栏中任何物品以任何形式损害时触发"
        '
        'NumericUpDownDurabilityMax
        '
        Me.NumericUpDownDurabilityMax.Location = New System.Drawing.Point(266, 85)
        Me.NumericUpDownDurabilityMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDurabilityMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownDurabilityMax.Name = "NumericUpDownDurabilityMax"
        Me.NumericUpDownDurabilityMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownDurabilityMax.TabIndex = 150
        '
        'NumericUpDownDeltaMax
        '
        Me.NumericUpDownDeltaMax.Location = New System.Drawing.Point(266, 53)
        Me.NumericUpDownDeltaMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDeltaMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownDeltaMax.Name = "NumericUpDownDeltaMax"
        Me.NumericUpDownDeltaMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownDeltaMax.TabIndex = 149
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "最大值"
        '
        'NumericUpDownDurabilityMin
        '
        Me.NumericUpDownDurabilityMin.Location = New System.Drawing.Point(159, 85)
        Me.NumericUpDownDurabilityMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDurabilityMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownDurabilityMin.Name = "NumericUpDownDurabilityMin"
        Me.NumericUpDownDurabilityMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownDurabilityMin.TabIndex = 146
        '
        'NumericUpDownDeltaMin
        '
        Me.NumericUpDownDeltaMin.Location = New System.Drawing.Point(159, 53)
        Me.NumericUpDownDeltaMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownDeltaMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownDeltaMin.Name = "NumericUpDownDeltaMin"
        Me.NumericUpDownDeltaMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownDeltaMin.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "物品剩余耐久度"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "耐久度差值"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "最小值"
        '
        'ButtonItem
        '
        Me.ButtonItem.Location = New System.Drawing.Point(159, 117)
        Me.ButtonItem.Name = "ButtonItem"
        Me.ButtonItem.Size = New System.Drawing.Size(182, 30)
        Me.ButtonItem.TabIndex = 158
        Me.ButtonItem.Tag = "{}"
        Me.ButtonItem.Text = "物品共通标签"
        Me.ButtonItem.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "损害前的物品"
        '
        'FormItemDurabilityChanged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 226)
        Me.Controls.Add(Me.ButtonItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownDurabilityMax)
        Me.Controls.Add(Me.NumericUpDownDeltaMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownDurabilityMin)
        Me.Controls.Add(Me.NumericUpDownDeltaMin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormItemDurabilityChanged"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        CType(Me.NumericUpDownDurabilityMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDeltaMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDurabilityMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDeltaMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDownDurabilityMax As NumericUpDown
    Friend WithEvents NumericUpDownDeltaMax As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownDurabilityMin As NumericUpDown
    Friend WithEvents NumericUpDownDeltaMin As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonItem As Button
    Friend WithEvents Label5 As Label
End Class
