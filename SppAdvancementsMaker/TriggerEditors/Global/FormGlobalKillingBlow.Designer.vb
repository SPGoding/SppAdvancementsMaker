<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGlobalKillingBlow
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ButtonSourceEntity = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDirectEntity = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BypassesArmorNull = New System.Windows.Forms.RadioButton()
        Me.BypassesArmorFalse = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BypassesArmorTrue = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BypassesInvulnerabilityNull = New System.Windows.Forms.RadioButton()
        Me.BypassesInvulnerabilityFalse = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BypassesInvulnerabilityTrue = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BypassesMagicNull = New System.Windows.Forms.RadioButton()
        Me.BypassesMagicFalse = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BypassesMagicTrue = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.IsExplosionNull = New System.Windows.Forms.RadioButton()
        Me.IsExplosionFalse = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IsExplosionTrue = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IsFireNull = New System.Windows.Forms.RadioButton()
        Me.IsFireFalse = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IsFireTrue = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.IsMagicNull = New System.Windows.Forms.RadioButton()
        Me.IsMagicFalse = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.IsMagicTrue = New System.Windows.Forms.RadioButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.IsProjectileNull = New System.Windows.Forms.RadioButton()
        Me.IsProjectileFalse = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IsProjectileTrue = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 19)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "本共通条件限定伤害类型"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(23, 299)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(291, 299)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 112
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ButtonSourceEntity
        '
        Me.ButtonSourceEntity.Location = New System.Drawing.Point(190, 263)
        Me.ButtonSourceEntity.Name = "ButtonSourceEntity"
        Me.ButtonSourceEntity.Size = New System.Drawing.Size(212, 30)
        Me.ButtonSourceEntity.TabIndex = 126
        Me.ButtonSourceEntity.Tag = ""
        Me.ButtonSourceEntity.Text = "实体共通标签"
        Me.ButtonSourceEntity.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 268)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "根本来源(如僵尸、骷髅)"
        '
        'ButtonDirectEntity
        '
        Me.ButtonDirectEntity.Location = New System.Drawing.Point(190, 227)
        Me.ButtonDirectEntity.Name = "ButtonDirectEntity"
        Me.ButtonDirectEntity.Size = New System.Drawing.Size(212, 30)
        Me.ButtonDirectEntity.TabIndex = 124
        Me.ButtonDirectEntity.Tag = ""
        Me.ButtonDirectEntity.Text = "实体共通标签"
        Me.ButtonDirectEntity.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 232)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "伤害直接来源(如箭)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(23, 319)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 19)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "如果本页面某内容与上一页重复，可不填"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(163, 299)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 20)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "不勾选代表不限制"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BypassesArmorNull)
        Me.Panel1.Controls.Add(Me.BypassesArmorFalse)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.BypassesArmorTrue)
        Me.Panel1.Location = New System.Drawing.Point(31, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 22)
        Me.Panel1.TabIndex = 145
        '
        'BypassesArmorNull
        '
        Me.BypassesArmorNull.AutoSize = True
        Me.BypassesArmorNull.Checked = True
        Me.BypassesArmorNull.Location = New System.Drawing.Point(304, -2)
        Me.BypassesArmorNull.Name = "BypassesArmorNull"
        Me.BypassesArmorNull.Size = New System.Drawing.Size(69, 24)
        Me.BypassesArmorNull.TabIndex = 173
        Me.BypassesArmorNull.TabStop = True
        Me.BypassesArmorNull.Text = "不限制"
        Me.BypassesArmorNull.UseVisualStyleBackColor = True
        '
        'BypassesArmorFalse
        '
        Me.BypassesArmorFalse.AutoSize = True
        Me.BypassesArmorFalse.Location = New System.Drawing.Point(236, -2)
        Me.BypassesArmorFalse.Name = "BypassesArmorFalse"
        Me.BypassesArmorFalse.Size = New System.Drawing.Size(41, 24)
        Me.BypassesArmorFalse.TabIndex = 172
        Me.BypassesArmorFalse.Text = "否"
        Me.BypassesArmorFalse.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "忽视玩家装甲"
        '
        'BypassesArmorTrue
        '
        Me.BypassesArmorTrue.AutoSize = True
        Me.BypassesArmorTrue.Location = New System.Drawing.Point(161, -2)
        Me.BypassesArmorTrue.Name = "BypassesArmorTrue"
        Me.BypassesArmorTrue.Size = New System.Drawing.Size(41, 24)
        Me.BypassesArmorTrue.TabIndex = 170
        Me.BypassesArmorTrue.TabStop = True
        Me.BypassesArmorTrue.Text = "是"
        Me.BypassesArmorTrue.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BypassesInvulnerabilityNull)
        Me.Panel2.Controls.Add(Me.BypassesInvulnerabilityFalse)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.BypassesInvulnerabilityTrue)
        Me.Panel2.Location = New System.Drawing.Point(31, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 22)
        Me.Panel2.TabIndex = 146
        '
        'BypassesInvulnerabilityNull
        '
        Me.BypassesInvulnerabilityNull.AutoSize = True
        Me.BypassesInvulnerabilityNull.Checked = True
        Me.BypassesInvulnerabilityNull.Location = New System.Drawing.Point(304, -2)
        Me.BypassesInvulnerabilityNull.Name = "BypassesInvulnerabilityNull"
        Me.BypassesInvulnerabilityNull.Size = New System.Drawing.Size(69, 24)
        Me.BypassesInvulnerabilityNull.TabIndex = 173
        Me.BypassesInvulnerabilityNull.TabStop = True
        Me.BypassesInvulnerabilityNull.Text = "不限制"
        Me.BypassesInvulnerabilityNull.UseVisualStyleBackColor = True
        '
        'BypassesInvulnerabilityFalse
        '
        Me.BypassesInvulnerabilityFalse.AutoSize = True
        Me.BypassesInvulnerabilityFalse.Location = New System.Drawing.Point(236, -2)
        Me.BypassesInvulnerabilityFalse.Name = "BypassesInvulnerabilityFalse"
        Me.BypassesInvulnerabilityFalse.Size = New System.Drawing.Size(41, 24)
        Me.BypassesInvulnerabilityFalse.TabIndex = 172
        Me.BypassesInvulnerabilityFalse.Text = "否"
        Me.BypassesInvulnerabilityFalse.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "忽视无敌模式"
        '
        'BypassesInvulnerabilityTrue
        '
        Me.BypassesInvulnerabilityTrue.AutoSize = True
        Me.BypassesInvulnerabilityTrue.Location = New System.Drawing.Point(161, -2)
        Me.BypassesInvulnerabilityTrue.Name = "BypassesInvulnerabilityTrue"
        Me.BypassesInvulnerabilityTrue.Size = New System.Drawing.Size(41, 24)
        Me.BypassesInvulnerabilityTrue.TabIndex = 170
        Me.BypassesInvulnerabilityTrue.TabStop = True
        Me.BypassesInvulnerabilityTrue.Text = "是"
        Me.BypassesInvulnerabilityTrue.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BypassesMagicNull)
        Me.Panel3.Controls.Add(Me.BypassesMagicFalse)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.BypassesMagicTrue)
        Me.Panel3.Location = New System.Drawing.Point(31, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(371, 22)
        Me.Panel3.TabIndex = 147
        '
        'BypassesMagicNull
        '
        Me.BypassesMagicNull.AutoSize = True
        Me.BypassesMagicNull.Checked = True
        Me.BypassesMagicNull.Location = New System.Drawing.Point(304, -2)
        Me.BypassesMagicNull.Name = "BypassesMagicNull"
        Me.BypassesMagicNull.Size = New System.Drawing.Size(69, 24)
        Me.BypassesMagicNull.TabIndex = 173
        Me.BypassesMagicNull.TabStop = True
        Me.BypassesMagicNull.Text = "不限制"
        Me.BypassesMagicNull.UseVisualStyleBackColor = True
        '
        'BypassesMagicFalse
        '
        Me.BypassesMagicFalse.AutoSize = True
        Me.BypassesMagicFalse.Location = New System.Drawing.Point(236, -2)
        Me.BypassesMagicFalse.Name = "BypassesMagicFalse"
        Me.BypassesMagicFalse.Size = New System.Drawing.Size(41, 24)
        Me.BypassesMagicFalse.TabIndex = 172
        Me.BypassesMagicFalse.Text = "否"
        Me.BypassesMagicFalse.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "由饥饿引起"
        '
        'BypassesMagicTrue
        '
        Me.BypassesMagicTrue.AutoSize = True
        Me.BypassesMagicTrue.Location = New System.Drawing.Point(161, -2)
        Me.BypassesMagicTrue.Name = "BypassesMagicTrue"
        Me.BypassesMagicTrue.Size = New System.Drawing.Size(41, 24)
        Me.BypassesMagicTrue.TabIndex = 170
        Me.BypassesMagicTrue.TabStop = True
        Me.BypassesMagicTrue.Text = "是"
        Me.BypassesMagicTrue.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.IsExplosionNull)
        Me.Panel4.Controls.Add(Me.IsExplosionFalse)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.IsExplosionTrue)
        Me.Panel4.Location = New System.Drawing.Point(31, 115)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(371, 22)
        Me.Panel4.TabIndex = 148
        '
        'IsExplosionNull
        '
        Me.IsExplosionNull.AutoSize = True
        Me.IsExplosionNull.Checked = True
        Me.IsExplosionNull.Location = New System.Drawing.Point(304, -2)
        Me.IsExplosionNull.Name = "IsExplosionNull"
        Me.IsExplosionNull.Size = New System.Drawing.Size(69, 24)
        Me.IsExplosionNull.TabIndex = 173
        Me.IsExplosionNull.TabStop = True
        Me.IsExplosionNull.Text = "不限制"
        Me.IsExplosionNull.UseVisualStyleBackColor = True
        '
        'IsExplosionFalse
        '
        Me.IsExplosionFalse.AutoSize = True
        Me.IsExplosionFalse.Location = New System.Drawing.Point(236, -2)
        Me.IsExplosionFalse.Name = "IsExplosionFalse"
        Me.IsExplosionFalse.Size = New System.Drawing.Size(41, 24)
        Me.IsExplosionFalse.TabIndex = 172
        Me.IsExplosionFalse.Text = "否"
        Me.IsExplosionFalse.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "由爆炸引起"
        '
        'IsExplosionTrue
        '
        Me.IsExplosionTrue.AutoSize = True
        Me.IsExplosionTrue.Location = New System.Drawing.Point(161, -2)
        Me.IsExplosionTrue.Name = "IsExplosionTrue"
        Me.IsExplosionTrue.Size = New System.Drawing.Size(41, 24)
        Me.IsExplosionTrue.TabIndex = 170
        Me.IsExplosionTrue.TabStop = True
        Me.IsExplosionTrue.Text = "是"
        Me.IsExplosionTrue.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.IsFireNull)
        Me.Panel5.Controls.Add(Me.IsFireFalse)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.IsFireTrue)
        Me.Panel5.Location = New System.Drawing.Point(31, 143)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(371, 22)
        Me.Panel5.TabIndex = 149
        '
        'IsFireNull
        '
        Me.IsFireNull.AutoSize = True
        Me.IsFireNull.Checked = True
        Me.IsFireNull.Location = New System.Drawing.Point(304, -2)
        Me.IsFireNull.Name = "IsFireNull"
        Me.IsFireNull.Size = New System.Drawing.Size(69, 24)
        Me.IsFireNull.TabIndex = 173
        Me.IsFireNull.TabStop = True
        Me.IsFireNull.Text = "不限制"
        Me.IsFireNull.UseVisualStyleBackColor = True
        '
        'IsFireFalse
        '
        Me.IsFireFalse.AutoSize = True
        Me.IsFireFalse.Location = New System.Drawing.Point(236, -2)
        Me.IsFireFalse.Name = "IsFireFalse"
        Me.IsFireFalse.Size = New System.Drawing.Size(41, 24)
        Me.IsFireFalse.TabIndex = 172
        Me.IsFireFalse.Text = "否"
        Me.IsFireFalse.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "由火引起"
        '
        'IsFireTrue
        '
        Me.IsFireTrue.AutoSize = True
        Me.IsFireTrue.Location = New System.Drawing.Point(161, -2)
        Me.IsFireTrue.Name = "IsFireTrue"
        Me.IsFireTrue.Size = New System.Drawing.Size(41, 24)
        Me.IsFireTrue.TabIndex = 170
        Me.IsFireTrue.TabStop = True
        Me.IsFireTrue.Text = "是"
        Me.IsFireTrue.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.IsMagicNull)
        Me.Panel6.Controls.Add(Me.IsMagicFalse)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.IsMagicTrue)
        Me.Panel6.Location = New System.Drawing.Point(31, 171)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(371, 22)
        Me.Panel6.TabIndex = 150
        '
        'IsMagicNull
        '
        Me.IsMagicNull.AutoSize = True
        Me.IsMagicNull.Checked = True
        Me.IsMagicNull.Location = New System.Drawing.Point(304, -2)
        Me.IsMagicNull.Name = "IsMagicNull"
        Me.IsMagicNull.Size = New System.Drawing.Size(69, 24)
        Me.IsMagicNull.TabIndex = 173
        Me.IsMagicNull.TabStop = True
        Me.IsMagicNull.Text = "不限制"
        Me.IsMagicNull.UseVisualStyleBackColor = True
        '
        'IsMagicFalse
        '
        Me.IsMagicFalse.AutoSize = True
        Me.IsMagicFalse.Location = New System.Drawing.Point(236, -2)
        Me.IsMagicFalse.Name = "IsMagicFalse"
        Me.IsMagicFalse.Size = New System.Drawing.Size(41, 24)
        Me.IsMagicFalse.TabIndex = 172
        Me.IsMagicFalse.Text = "否"
        Me.IsMagicFalse.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 20)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "由膜法引起"
        '
        'IsMagicTrue
        '
        Me.IsMagicTrue.AutoSize = True
        Me.IsMagicTrue.Location = New System.Drawing.Point(161, -2)
        Me.IsMagicTrue.Name = "IsMagicTrue"
        Me.IsMagicTrue.Size = New System.Drawing.Size(41, 24)
        Me.IsMagicTrue.TabIndex = 170
        Me.IsMagicTrue.TabStop = True
        Me.IsMagicTrue.Text = "是"
        Me.IsMagicTrue.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.IsProjectileNull)
        Me.Panel7.Controls.Add(Me.IsProjectileFalse)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.IsProjectileTrue)
        Me.Panel7.Location = New System.Drawing.Point(31, 199)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(371, 22)
        Me.Panel7.TabIndex = 151
        '
        'IsProjectileNull
        '
        Me.IsProjectileNull.AutoSize = True
        Me.IsProjectileNull.Checked = True
        Me.IsProjectileNull.Location = New System.Drawing.Point(304, -2)
        Me.IsProjectileNull.Name = "IsProjectileNull"
        Me.IsProjectileNull.Size = New System.Drawing.Size(69, 24)
        Me.IsProjectileNull.TabIndex = 173
        Me.IsProjectileNull.TabStop = True
        Me.IsProjectileNull.Text = "不限制"
        Me.IsProjectileNull.UseVisualStyleBackColor = True
        '
        'IsProjectileFalse
        '
        Me.IsProjectileFalse.AutoSize = True
        Me.IsProjectileFalse.Location = New System.Drawing.Point(236, -2)
        Me.IsProjectileFalse.Name = "IsProjectileFalse"
        Me.IsProjectileFalse.Size = New System.Drawing.Size(41, 24)
        Me.IsProjectileFalse.TabIndex = 172
        Me.IsProjectileFalse.Text = "否"
        Me.IsProjectileFalse.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 171
        Me.Label13.Text = "由弹射物引起"
        '
        'IsProjectileTrue
        '
        Me.IsProjectileTrue.AutoSize = True
        Me.IsProjectileTrue.Location = New System.Drawing.Point(161, -2)
        Me.IsProjectileTrue.Name = "IsProjectileTrue"
        Me.IsProjectileTrue.Size = New System.Drawing.Size(41, 24)
        Me.IsProjectileTrue.TabIndex = 170
        Me.IsProjectileTrue.TabStop = True
        Me.IsProjectileTrue.Text = "是"
        Me.IsProjectileTrue.UseVisualStyleBackColor = True
        '
        'FormGlobalKillingBlow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 362)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonSourceEntity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonDirectEntity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormGlobalKillingBlow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ButtonSourceEntity As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDirectEntity As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BypassesArmorNull As RadioButton
    Friend WithEvents BypassesArmorFalse As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents BypassesArmorTrue As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BypassesInvulnerabilityNull As RadioButton
    Friend WithEvents BypassesInvulnerabilityFalse As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents BypassesInvulnerabilityTrue As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BypassesMagicNull As RadioButton
    Friend WithEvents BypassesMagicFalse As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents BypassesMagicTrue As RadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IsExplosionNull As RadioButton
    Friend WithEvents IsExplosionFalse As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents IsExplosionTrue As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents IsFireNull As RadioButton
    Friend WithEvents IsFireFalse As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents IsFireTrue As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents IsMagicNull As RadioButton
    Friend WithEvents IsMagicFalse As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents IsMagicTrue As RadioButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents IsProjectileNull As RadioButton
    Friend WithEvents IsProjectileFalse As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents IsProjectileTrue As RadioButton
End Class
