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
        Me.CheckBoxBypassesArmor = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBypassesInvulnerability = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBypassesMagic = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIsFire = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIsExplosion = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIsMagic = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIsProjectile = New System.Windows.Forms.CheckBox()
        Me.ButtonSourceEntity = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDirectEntity = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Label6.Location = New System.Drawing.Point(16, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(284, 229)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 112
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'CheckBoxBypassesArmor
        '
        Me.CheckBoxBypassesArmor.AutoSize = True
        Me.CheckBoxBypassesArmor.Location = New System.Drawing.Point(38, 32)
        Me.CheckBoxBypassesArmor.Name = "CheckBoxBypassesArmor"
        Me.CheckBoxBypassesArmor.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxBypassesArmor.TabIndex = 116
        Me.CheckBoxBypassesArmor.Text = "忽视玩家装甲"
        Me.CheckBoxBypassesArmor.UseVisualStyleBackColor = True
        '
        'CheckBoxBypassesInvulnerability
        '
        Me.CheckBoxBypassesInvulnerability.AutoSize = True
        Me.CheckBoxBypassesInvulnerability.Location = New System.Drawing.Point(156, 32)
        Me.CheckBoxBypassesInvulnerability.Name = "CheckBoxBypassesInvulnerability"
        Me.CheckBoxBypassesInvulnerability.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxBypassesInvulnerability.TabIndex = 117
        Me.CheckBoxBypassesInvulnerability.Text = "忽视无敌模式"
        Me.CheckBoxBypassesInvulnerability.UseVisualStyleBackColor = True
        '
        'CheckBoxBypassesMagic
        '
        Me.CheckBoxBypassesMagic.AutoSize = True
        Me.CheckBoxBypassesMagic.Location = New System.Drawing.Point(38, 62)
        Me.CheckBoxBypassesMagic.Name = "CheckBoxBypassesMagic"
        Me.CheckBoxBypassesMagic.Size = New System.Drawing.Size(98, 24)
        Me.CheckBoxBypassesMagic.TabIndex = 118
        Me.CheckBoxBypassesMagic.Text = "由饥饿引起"
        Me.CheckBoxBypassesMagic.UseVisualStyleBackColor = True
        '
        'CheckBoxIsFire
        '
        Me.CheckBoxIsFire.AutoSize = True
        Me.CheckBoxIsFire.Location = New System.Drawing.Point(276, 62)
        Me.CheckBoxIsFire.Name = "CheckBoxIsFire"
        Me.CheckBoxIsFire.Size = New System.Drawing.Size(84, 24)
        Me.CheckBoxIsFire.TabIndex = 119
        Me.CheckBoxIsFire.Text = "由火引起"
        Me.CheckBoxIsFire.UseVisualStyleBackColor = True
        '
        'CheckBoxIsExplosion
        '
        Me.CheckBoxIsExplosion.AutoSize = True
        Me.CheckBoxIsExplosion.Location = New System.Drawing.Point(156, 62)
        Me.CheckBoxIsExplosion.Name = "CheckBoxIsExplosion"
        Me.CheckBoxIsExplosion.Size = New System.Drawing.Size(98, 24)
        Me.CheckBoxIsExplosion.TabIndex = 120
        Me.CheckBoxIsExplosion.Text = "由爆炸引起"
        Me.CheckBoxIsExplosion.UseVisualStyleBackColor = True
        '
        'CheckBoxIsMagic
        '
        Me.CheckBoxIsMagic.AutoSize = True
        Me.CheckBoxIsMagic.Location = New System.Drawing.Point(38, 92)
        Me.CheckBoxIsMagic.Name = "CheckBoxIsMagic"
        Me.CheckBoxIsMagic.Size = New System.Drawing.Size(98, 24)
        Me.CheckBoxIsMagic.TabIndex = 121
        Me.CheckBoxIsMagic.Text = "由膜法引起"
        Me.CheckBoxIsMagic.UseVisualStyleBackColor = True
        '
        'CheckBoxIsProjectile
        '
        Me.CheckBoxIsProjectile.AutoSize = True
        Me.CheckBoxIsProjectile.Location = New System.Drawing.Point(156, 92)
        Me.CheckBoxIsProjectile.Name = "CheckBoxIsProjectile"
        Me.CheckBoxIsProjectile.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxIsProjectile.TabIndex = 122
        Me.CheckBoxIsProjectile.Text = "由弹射物引起"
        Me.CheckBoxIsProjectile.UseVisualStyleBackColor = True
        '
        'ButtonSourceEntity
        '
        Me.ButtonSourceEntity.Location = New System.Drawing.Point(190, 158)
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
        Me.Label4.Location = New System.Drawing.Point(35, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "根本来源(如僵尸、骷髅)"
        '
        'ButtonDirectEntity
        '
        Me.ButtonDirectEntity.Location = New System.Drawing.Point(190, 122)
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
        Me.Label2.Location = New System.Drawing.Point(35, 127)
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
        Me.Label3.Location = New System.Drawing.Point(16, 249)
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
        Me.Label11.Location = New System.Drawing.Point(156, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 20)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "不勾选代表不限制"
        '
        'FormGlobalKillingBlow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 289)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonSourceEntity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonDirectEntity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBoxIsProjectile)
        Me.Controls.Add(Me.CheckBoxIsMagic)
        Me.Controls.Add(Me.CheckBoxIsExplosion)
        Me.Controls.Add(Me.CheckBoxIsFire)
        Me.Controls.Add(Me.CheckBoxBypassesMagic)
        Me.Controls.Add(Me.CheckBoxBypassesInvulnerability)
        Me.Controls.Add(Me.CheckBoxBypassesArmor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormGlobalKillingBlow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents CheckBoxBypassesArmor As CheckBox
    Friend WithEvents CheckBoxBypassesInvulnerability As CheckBox
    Friend WithEvents CheckBoxBypassesMagic As CheckBox
    Friend WithEvents CheckBoxIsFire As CheckBox
    Friend WithEvents CheckBoxIsExplosion As CheckBox
    Friend WithEvents CheckBoxIsMagic As CheckBox
    Friend WithEvents CheckBoxIsProjectile As CheckBox
    Friend WithEvents ButtonSourceEntity As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDirectEntity As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
End Class
