﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectSave
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBoxSavePath = New System.Windows.Forms.TextBox()
        Me.ButtonSelectSave = New System.Windows.Forms.Button()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "请选择存档"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(37, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "接下来的一切操作都只对该存档有效"
        '
        'TextBoxSavePath
        '
        Me.TextBoxSavePath.Location = New System.Drawing.Point(41, 52)
        Me.TextBoxSavePath.Name = "TextBoxSavePath"
        Me.TextBoxSavePath.ReadOnly = True
        Me.TextBoxSavePath.Size = New System.Drawing.Size(315, 26)
        Me.TextBoxSavePath.TabIndex = 34
        '
        'ButtonSelectSave
        '
        Me.ButtonSelectSave.Location = New System.Drawing.Point(356, 53)
        Me.ButtonSelectSave.Name = "ButtonSelectSave"
        Me.ButtonSelectSave.Size = New System.Drawing.Size(25, 24)
        Me.ButtonSelectSave.TabIndex = 38
        Me.ButtonSelectSave.Text = "···"
        Me.ButtonSelectSave.UseVisualStyleBackColor = True
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Enabled = False
        Me.ButtonEnter.Location = New System.Drawing.Point(263, 164)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 39
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(12, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "*软件引用了James Newton-King制作的Json.Net"
        '
        'FormSelectSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 238)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.ButtonSelectSave)
        Me.Controls.Add(Me.TextBoxSavePath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormSelectSave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_选择存档位置"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBoxSavePath As TextBox
    Friend WithEvents ButtonSelectSave As Button
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label5 As Label
End Class
