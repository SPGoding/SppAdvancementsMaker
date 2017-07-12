<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNetherTravel
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDownZMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownYMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownXMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownHorizontalMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownAbsoluteMin = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDownZMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownYMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownXMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownHorizontalMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownAbsoluteMax = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownZMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownYMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownXMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHorizontalMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownAbsoluteMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownZMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownYMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownXMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHorizontalMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownAbsoluteMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(18, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "填零代表不限制"
        '
        'NumericUpDownZMin
        '
        Me.NumericUpDownZMin.Location = New System.Drawing.Point(151, 191)
        Me.NumericUpDownZMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownZMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownZMin.Name = "NumericUpDownZMin"
        Me.NumericUpDownZMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownZMin.TabIndex = 92
        '
        'NumericUpDownYMin
        '
        Me.NumericUpDownYMin.Location = New System.Drawing.Point(151, 159)
        Me.NumericUpDownYMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownYMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownYMin.Name = "NumericUpDownYMin"
        Me.NumericUpDownYMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownYMin.TabIndex = 90
        '
        'NumericUpDownXMin
        '
        Me.NumericUpDownXMin.Location = New System.Drawing.Point(151, 127)
        Me.NumericUpDownXMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownXMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownXMin.Name = "NumericUpDownXMin"
        Me.NumericUpDownXMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownXMin.TabIndex = 88
        '
        'NumericUpDownHorizontalMin
        '
        Me.NumericUpDownHorizontalMin.Location = New System.Drawing.Point(151, 95)
        Me.NumericUpDownHorizontalMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownHorizontalMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownHorizontalMin.Name = "NumericUpDownHorizontalMin"
        Me.NumericUpDownHorizontalMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownHorizontalMin.TabIndex = 86
        '
        'NumericUpDownAbsoluteMin
        '
        Me.NumericUpDownAbsoluteMin.Location = New System.Drawing.Point(151, 63)
        Me.NumericUpDownAbsoluteMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownAbsoluteMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownAbsoluteMin.Name = "NumericUpDownAbsoluteMin"
        Me.NumericUpDownAbsoluteMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownAbsoluteMin.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 193)
        Me.Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Z"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 161)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Y(垂直距离)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "水平距离"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "绝对距离"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "最小值"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(18, 249)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(220, 223)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 74
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "本触发器在玩家进入下界，然后返回主世界时触发"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 20)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "在主世界的移动"
        '
        'NumericUpDownZMax
        '
        Me.NumericUpDownZMax.Location = New System.Drawing.Point(263, 191)
        Me.NumericUpDownZMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownZMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownZMax.Name = "NumericUpDownZMax"
        Me.NumericUpDownZMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownZMax.TabIndex = 102
        '
        'NumericUpDownYMax
        '
        Me.NumericUpDownYMax.Location = New System.Drawing.Point(263, 159)
        Me.NumericUpDownYMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownYMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownYMax.Name = "NumericUpDownYMax"
        Me.NumericUpDownYMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownYMax.TabIndex = 101
        '
        'NumericUpDownXMax
        '
        Me.NumericUpDownXMax.Location = New System.Drawing.Point(263, 127)
        Me.NumericUpDownXMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownXMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownXMax.Name = "NumericUpDownXMax"
        Me.NumericUpDownXMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownXMax.TabIndex = 100
        '
        'NumericUpDownHorizontalMax
        '
        Me.NumericUpDownHorizontalMax.Location = New System.Drawing.Point(263, 95)
        Me.NumericUpDownHorizontalMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownHorizontalMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownHorizontalMax.Name = "NumericUpDownHorizontalMax"
        Me.NumericUpDownHorizontalMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownHorizontalMax.TabIndex = 99
        '
        'NumericUpDownAbsoluteMax
        '
        Me.NumericUpDownAbsoluteMax.Location = New System.Drawing.Point(263, 63)
        Me.NumericUpDownAbsoluteMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownAbsoluteMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownAbsoluteMax.Name = "NumericUpDownAbsoluteMax"
        Me.NumericUpDownAbsoluteMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownAbsoluteMax.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "最大值"
        '
        'FormNetherTravel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 277)
        Me.Controls.Add(Me.NumericUpDownZMax)
        Me.Controls.Add(Me.NumericUpDownYMax)
        Me.Controls.Add(Me.NumericUpDownXMax)
        Me.Controls.Add(Me.NumericUpDownHorizontalMax)
        Me.Controls.Add(Me.NumericUpDownAbsoluteMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NumericUpDownZMin)
        Me.Controls.Add(Me.NumericUpDownYMin)
        Me.Controls.Add(Me.NumericUpDownXMin)
        Me.Controls.Add(Me.NumericUpDownHorizontalMin)
        Me.Controls.Add(Me.NumericUpDownAbsoluteMin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormNetherTravel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        CType(Me.NumericUpDownZMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownYMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownXMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHorizontalMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownAbsoluteMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownZMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownYMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownXMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHorizontalMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownAbsoluteMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUpDownZMin As NumericUpDown
    Friend WithEvents NumericUpDownYMin As NumericUpDown
    Friend WithEvents NumericUpDownXMin As NumericUpDown
    Friend WithEvents NumericUpDownHorizontalMin As NumericUpDown
    Friend WithEvents NumericUpDownAbsoluteMin As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDownZMax As NumericUpDown
    Friend WithEvents NumericUpDownYMax As NumericUpDown
    Friend WithEvents NumericUpDownXMax As NumericUpDown
    Friend WithEvents NumericUpDownHorizontalMax As NumericUpDown
    Friend WithEvents NumericUpDownAbsoluteMax As NumericUpDown
    Friend WithEvents Label2 As Label
End Class
