<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGlobalLocation
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxBiome = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxDimension = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxFeature = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDownZMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownYMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownXMin = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownZMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownYMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownXMax = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownZMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownYMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownXMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownZMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownYMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownXMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "所在维度："
        '
        'ComboBoxBiome
        '
        Me.ComboBoxBiome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBiome.FormattingEnabled = True
        Me.ComboBoxBiome.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxBiome.IntegralHeight = False
        Me.ComboBoxBiome.Location = New System.Drawing.Point(133, 32)
        Me.ComboBoxBiome.MaxDropDownItems = 16
        Me.ComboBoxBiome.Name = "ComboBoxBiome"
        Me.ComboBoxBiome.Size = New System.Drawing.Size(270, 28)
        Me.ComboBoxBiome.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "所在生物群系："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(16, 270)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "填零代表不限制"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(16, 290)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(285, 278)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 73
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
        Me.Label1.Size = New System.Drawing.Size(205, 19)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "本共通条件限定实体的位置信息"
        '
        'ComboBoxDimension
        '
        Me.ComboBoxDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDimension.FormattingEnabled = True
        Me.ComboBoxDimension.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxDimension.IntegralHeight = False
        Me.ComboBoxDimension.Location = New System.Drawing.Point(133, 66)
        Me.ComboBoxDimension.MaxDropDownItems = 16
        Me.ComboBoxDimension.Name = "ComboBoxDimension"
        Me.ComboBoxDimension.Size = New System.Drawing.Size(270, 28)
        Me.ComboBoxDimension.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "所在结构："
        '
        'ComboBoxFeature
        '
        Me.ComboBoxFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFeature.FormattingEnabled = True
        Me.ComboBoxFeature.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxFeature.IntegralHeight = False
        Me.ComboBoxFeature.Location = New System.Drawing.Point(133, 99)
        Me.ComboBoxFeature.MaxDropDownItems = 16
        Me.ComboBoxFeature.Name = "ComboBoxFeature"
        Me.ComboBoxFeature.Size = New System.Drawing.Size(270, 28)
        Me.ComboBoxFeature.TabIndex = 79
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 131)
        Me.Label10.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 20)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "坐标"
        '
        'NumericUpDownZMin
        '
        Me.NumericUpDownZMin.DecimalPlaces = 2
        Me.NumericUpDownZMin.Location = New System.Drawing.Point(133, 218)
        Me.NumericUpDownZMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownZMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownZMin.Name = "NumericUpDownZMin"
        Me.NumericUpDownZMin.Size = New System.Drawing.Size(133, 26)
        Me.NumericUpDownZMin.TabIndex = 107
        '
        'NumericUpDownYMin
        '
        Me.NumericUpDownYMin.DecimalPlaces = 2
        Me.NumericUpDownYMin.Location = New System.Drawing.Point(133, 186)
        Me.NumericUpDownYMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownYMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownYMin.Name = "NumericUpDownYMin"
        Me.NumericUpDownYMin.Size = New System.Drawing.Size(133, 26)
        Me.NumericUpDownYMin.TabIndex = 105
        '
        'NumericUpDownXMin
        '
        Me.NumericUpDownXMin.DecimalPlaces = 2
        Me.NumericUpDownXMin.Location = New System.Drawing.Point(133, 154)
        Me.NumericUpDownXMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownXMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownXMin.Name = "NumericUpDownXMin"
        Me.NumericUpDownXMin.Size = New System.Drawing.Size(133, 26)
        Me.NumericUpDownXMin.TabIndex = 103
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 220)
        Me.Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Z"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 188)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 20)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Y"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "最小值"
        '
        'NumericUpDownZMax
        '
        Me.NumericUpDownZMax.DecimalPlaces = 2
        Me.NumericUpDownZMax.Location = New System.Drawing.Point(272, 218)
        Me.NumericUpDownZMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownZMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownZMax.Name = "NumericUpDownZMax"
        Me.NumericUpDownZMax.Size = New System.Drawing.Size(131, 26)
        Me.NumericUpDownZMax.TabIndex = 112
        '
        'NumericUpDownYMax
        '
        Me.NumericUpDownYMax.DecimalPlaces = 2
        Me.NumericUpDownYMax.Location = New System.Drawing.Point(272, 186)
        Me.NumericUpDownYMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownYMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownYMax.Name = "NumericUpDownYMax"
        Me.NumericUpDownYMax.Size = New System.Drawing.Size(131, 26)
        Me.NumericUpDownYMax.TabIndex = 111
        '
        'NumericUpDownXMax
        '
        Me.NumericUpDownXMax.DecimalPlaces = 2
        Me.NumericUpDownXMax.Location = New System.Drawing.Point(272, 154)
        Me.NumericUpDownXMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownXMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownXMax.Name = "NumericUpDownXMax"
        Me.NumericUpDownXMax.Size = New System.Drawing.Size(131, 26)
        Me.NumericUpDownXMax.TabIndex = 110
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(309, 131)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "最大值"
        '
        'FormGlobalLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 335)
        Me.Controls.Add(Me.NumericUpDownZMax)
        Me.Controls.Add(Me.NumericUpDownYMax)
        Me.Controls.Add(Me.NumericUpDownXMax)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NumericUpDownZMin)
        Me.Controls.Add(Me.NumericUpDownYMin)
        Me.Controls.Add(Me.NumericUpDownXMin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxFeature)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxDimension)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxBiome)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormGlobalLocation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        CType(Me.NumericUpDownZMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownYMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownXMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownZMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownYMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownXMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxBiome As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxDimension As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxFeature As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDownZMin As NumericUpDown
    Friend WithEvents NumericUpDownYMin As NumericUpDown
    Friend WithEvents NumericUpDownXMin As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownZMax As NumericUpDown
    Friend WithEvents NumericUpDownYMax As NumericUpDown
    Friend WithEvents NumericUpDownXMax As NumericUpDown
    Friend WithEvents Label12 As Label
End Class
