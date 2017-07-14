<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEnchantedItem
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDownMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMax = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonItem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 86)
        Me.Label10.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 20)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "附魔花费的经验等级"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(16, 176)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "填零代表不限制"
        '
        'NumericUpDownMin
        '
        Me.NumericUpDownMin.Location = New System.Drawing.Point(119, 141)
        Me.NumericUpDownMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownMin.Name = "NumericUpDownMin"
        Me.NumericUpDownMin.Size = New System.Drawing.Size(203, 26)
        Me.NumericUpDownMin.TabIndex = 123
        '
        'NumericUpDownMax
        '
        Me.NumericUpDownMax.Location = New System.Drawing.Point(119, 109)
        Me.NumericUpDownMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownMax.Name = "NumericUpDownMax"
        Me.NumericUpDownMax.Size = New System.Drawing.Size(203, 26)
        Me.NumericUpDownMax.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "最小值"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(205, 176)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 120
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "最大值"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 19)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "本触发器在玩家通过附魔台附魔物品时触发"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 19)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "使用铁砧或命令时不触发"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "附魔后的物品"
        '
        'ButtonItem
        '
        Me.ButtonItem.Location = New System.Drawing.Point(119, 52)
        Me.ButtonItem.Name = "ButtonItem"
        Me.ButtonItem.Size = New System.Drawing.Size(204, 30)
        Me.ButtonItem.TabIndex = 128
        Me.ButtonItem.Tag = ""
        Me.ButtonItem.Text = "物品共通标签"
        Me.ButtonItem.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(16, 196)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "大多数条件是可选的"
        '
        'FormEnchantedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 237)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NumericUpDownMin)
        Me.Controls.Add(Me.NumericUpDownMax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormEnchantedItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        CType(Me.NumericUpDownMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUpDownMin As NumericUpDown
    Friend WithEvents NumericUpDownMax As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonItem As Button
    Friend WithEvents Label6 As Label
End Class
