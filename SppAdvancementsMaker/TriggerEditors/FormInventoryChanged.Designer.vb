<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventoryChanged
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDownOccupiedMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownFullMax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownEmptyMax = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownOccupiedMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownFullMin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownEmptyMin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonItem = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ListBoxItems = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownOccupiedMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFullMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownEmptyMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOccupiedMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFullMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownEmptyMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(19, 440)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "大多数条件是可选的"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(19, 420)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "填零代表不限制"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(302, 420)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 132
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
        Me.Label1.Size = New System.Drawing.Size(219, 19)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "本触发器在玩家物品栏变化时触发"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownOccupiedMax)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownFullMax)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownEmptyMax)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownOccupiedMin)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownFullMin)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownEmptyMin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 146)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "物品栏改变后的一些数据"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 110)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "已使用槽位数量"
        '
        'NumericUpDownOccupiedMax
        '
        Me.NumericUpDownOccupiedMax.Location = New System.Drawing.Point(265, 108)
        Me.NumericUpDownOccupiedMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownOccupiedMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownOccupiedMax.Name = "NumericUpDownOccupiedMax"
        Me.NumericUpDownOccupiedMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownOccupiedMax.TabIndex = 85
        '
        'NumericUpDownFullMax
        '
        Me.NumericUpDownFullMax.Location = New System.Drawing.Point(265, 76)
        Me.NumericUpDownFullMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownFullMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownFullMax.Name = "NumericUpDownFullMax"
        Me.NumericUpDownFullMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownFullMax.TabIndex = 84
        '
        'NumericUpDownEmptyMax
        '
        Me.NumericUpDownEmptyMax.Location = New System.Drawing.Point(265, 44)
        Me.NumericUpDownEmptyMax.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownEmptyMax.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownEmptyMax.Name = "NumericUpDownEmptyMax"
        Me.NumericUpDownEmptyMax.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownEmptyMax.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "最大值"
        '
        'NumericUpDownOccupiedMin
        '
        Me.NumericUpDownOccupiedMin.Location = New System.Drawing.Point(158, 108)
        Me.NumericUpDownOccupiedMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownOccupiedMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownOccupiedMin.Name = "NumericUpDownOccupiedMin"
        Me.NumericUpDownOccupiedMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownOccupiedMin.TabIndex = 81
        '
        'NumericUpDownFullMin
        '
        Me.NumericUpDownFullMin.Location = New System.Drawing.Point(158, 76)
        Me.NumericUpDownFullMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownFullMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownFullMin.Name = "NumericUpDownFullMin"
        Me.NumericUpDownFullMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownFullMin.TabIndex = 80
        '
        'NumericUpDownEmptyMin
        '
        Me.NumericUpDownEmptyMin.Location = New System.Drawing.Point(158, 44)
        Me.NumericUpDownEmptyMin.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownEmptyMin.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.NumericUpDownEmptyMin.Name = "NumericUpDownEmptyMin"
        Me.NumericUpDownEmptyMin.Size = New System.Drawing.Size(75, 26)
        Me.NumericUpDownEmptyMin.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "已填满槽位数量"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "空槽位数量"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "最小值"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonItem)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ButtonDel)
        Me.GroupBox2.Controls.Add(Me.ButtonAdd)
        Me.GroupBox2.Controls.Add(Me.ListBoxItems)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 231)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "物品列表"
        '
        'ButtonItem
        '
        Me.ButtonItem.Enabled = False
        Me.ButtonItem.Location = New System.Drawing.Point(158, 194)
        Me.ButtonItem.Name = "ButtonItem"
        Me.ButtonItem.Size = New System.Drawing.Size(182, 30)
        Me.ButtonItem.TabIndex = 142
        Me.ButtonItem.Tag = "{}"
        Me.ButtonItem.Text = "物品共通标签"
        Me.ButtonItem.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "物品设置"
        '
        'ButtonDel
        '
        Me.ButtonDel.Enabled = False
        Me.ButtonDel.Location = New System.Drawing.Point(346, 109)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(42, 79)
        Me.ButtonDel.TabIndex = 129
        Me.ButtonDel.Text = "删除"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(346, 24)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(42, 79)
        Me.ButtonAdd.TabIndex = 128
        Me.ButtonAdd.Text = "添加"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ListBoxItems
        '
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.ItemHeight = 20
        Me.ListBoxItems.Location = New System.Drawing.Point(19, 24)
        Me.ListBoxItems.Name = "ListBoxItems"
        Me.ListBoxItems.Size = New System.Drawing.Size(321, 164)
        Me.ListBoxItems.TabIndex = 127
        '
        'FormInventoryChanged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 481)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormInventoryChanged"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownOccupiedMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFullMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownEmptyMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOccupiedMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFullMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownEmptyMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericUpDownOccupiedMax As NumericUpDown
    Friend WithEvents NumericUpDownFullMax As NumericUpDown
    Friend WithEvents NumericUpDownEmptyMax As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownOccupiedMin As NumericUpDown
    Friend WithEvents NumericUpDownFullMin As NumericUpDown
    Friend WithEvents NumericUpDownEmptyMin As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonItem As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ListBoxItems As ListBox
End Class
