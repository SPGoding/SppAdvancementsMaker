<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBredAnimals
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
        Me.ButtonChild = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonParent = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonPartner = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonChild
        '
        Me.ButtonChild.Location = New System.Drawing.Point(119, 32)
        Me.ButtonChild.Name = "ButtonChild"
        Me.ButtonChild.Size = New System.Drawing.Size(212, 30)
        Me.ButtonChild.TabIndex = 68
        Me.ButtonChild.Tag = ""
        Me.ButtonChild.Text = "实体共通标签"
        Me.ButtonChild.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(16, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(214, 157)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 66
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "繁殖出的孩子"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 20)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "本触发器在玩家繁殖两个动物时触发"
        '
        'ButtonParent
        '
        Me.ButtonParent.Location = New System.Drawing.Point(119, 68)
        Me.ButtonParent.Name = "ButtonParent"
        Me.ButtonParent.Size = New System.Drawing.Size(212, 30)
        Me.ButtonParent.TabIndex = 70
        Me.ButtonParent.Tag = ""
        Me.ButtonParent.Text = "实体共通标签"
        Me.ButtonParent.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "父或母"
        '
        'ButtonPartner
        '
        Me.ButtonPartner.Location = New System.Drawing.Point(119, 104)
        Me.ButtonPartner.Name = "ButtonPartner"
        Me.ButtonPartner.Size = New System.Drawing.Size(212, 30)
        Me.ButtonPartner.TabIndex = 72
        Me.ButtonPartner.Tag = ""
        Me.ButtonPartner.Text = "实体共通标签"
        Me.ButtonPartner.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "配偶"
        '
        'FormBredAnimals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 214)
        Me.Controls.Add(Me.ButtonPartner)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonParent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonChild)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormBredAnimals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonChild As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonParent As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonPartner As Button
    Friend WithEvents Label5 As Label
End Class
