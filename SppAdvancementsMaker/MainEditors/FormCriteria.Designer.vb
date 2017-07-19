<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCriteria
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxTrigger = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ComboBoxGroup = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ButtonCriteria = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "触发器"
        '
        'ComboBoxTrigger
        '
        Me.ComboBoxTrigger.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTrigger.FormattingEnabled = True
        Me.ComboBoxTrigger.IntegralHeight = False
        Me.ComboBoxTrigger.Location = New System.Drawing.Point(81, 99)
        Me.ComboBoxTrigger.MaxDropDownItems = 16
        Me.ComboBoxTrigger.Name = "ComboBoxTrigger"
        Me.ComboBoxTrigger.Size = New System.Drawing.Size(249, 28)
        Me.ComboBoxTrigger.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "分　组"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(212, 185)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 34
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ComboBoxGroup
        '
        Me.ComboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGroup.FormattingEnabled = True
        Me.ComboBoxGroup.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxGroup.Location = New System.Drawing.Point(70, 38)
        Me.ComboBoxGroup.Name = "ComboBoxGroup"
        Me.ComboBoxGroup.Size = New System.Drawing.Size(260, 28)
        Me.ComboBoxGroup.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "条件名"
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxName.Location = New System.Drawing.Point(70, 6)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(260, 26)
        Me.TextBoxName.TabIndex = 37
        '
        'ButtonCriteria
        '
        Me.ButtonCriteria.Location = New System.Drawing.Point(81, 133)
        Me.ButtonCriteria.Name = "ButtonCriteria"
        Me.ButtonCriteria.Size = New System.Drawing.Size(249, 32)
        Me.ButtonCriteria.TabIndex = 39
        Me.ButtonCriteria.Text = "编辑"
        Me.ButtonCriteria.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "种类"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "条件"
        '
        'FormCriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 242)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonCriteria)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxGroup)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxTrigger)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormCriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxTrigger As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ComboBoxGroup As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ButtonCriteria As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
