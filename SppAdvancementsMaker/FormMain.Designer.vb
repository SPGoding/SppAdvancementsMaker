﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("组0")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDownData = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxFrame = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelParent = New System.Windows.Forms.Label()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.LabelBackground = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NumericUpDownExperience = New System.Windows.Forms.NumericUpDown()
        Me.ButtonTitle = New System.Windows.Forms.Button()
        Me.ButtonDescription = New System.Windows.Forms.Button()
        Me.ComboBoxBackground = New System.Windows.Forms.ComboBox()
        Me.TreeViewCriterias = New System.Windows.Forms.TreeView()
        Me.ButtonAddGroup = New System.Windows.Forms.Button()
        Me.ButtonAddCriteria = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxParent = New System.Windows.Forms.ComboBox()
        Me.ComboBoxItem = New System.Windows.Forms.ComboBox()
        Me.ButtonRecipes = New System.Windows.Forms.Button()
        Me.ButtonLoot = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxHidden = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAnnounce_To_Chat = New System.Windows.Forms.CheckBox()
        Me.CheckBoxShow_Toast = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxFunction = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxOnlyCommand = New System.Windows.Forms.CheckBox()
        Me.PictureBoxOnlyCommand = New System.Windows.Forms.PictureBox()
        Me.LabelHelper = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBoxCommands = New System.Windows.Forms.GroupBox()
        Me.ButtonCopyRevoke = New System.Windows.Forms.Button()
        Me.ButtonCopyGrant = New System.Windows.Forms.Button()
        Me.TextBoxCommandRevoke = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxCommandGrant = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelOpenJson = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownExperience, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxOnlyCommand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxCommands.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "作为图标的物品种类"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "作为图标的物品的数据值"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "进度标题"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "边框种类"
        '
        'NumericUpDownData
        '
        Me.NumericUpDownData.Location = New System.Drawing.Point(173, 59)
        Me.NumericUpDownData.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDownData.Name = "NumericUpDownData"
        Me.NumericUpDownData.Size = New System.Drawing.Size(232, 26)
        Me.NumericUpDownData.TabIndex = 10
        '
        'ComboBoxFrame
        '
        Me.ComboBoxFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFrame.FormattingEnabled = True
        Me.ComboBoxFrame.IntegralHeight = False
        Me.ComboBoxFrame.Items.AddRange(New Object() {"默认的普通进度", "有穗的挑战进度", "更圆的目标进度"})
        Me.ComboBoxFrame.Location = New System.Drawing.Point(173, 228)
        Me.ComboBoxFrame.MaxDropDownItems = 16
        Me.ComboBoxFrame.Name = "ComboBoxFrame"
        Me.ComboBoxFrame.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxFrame.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "进度描述"
        '
        'LabelParent
        '
        Me.LabelParent.AutoSize = True
        Me.LabelParent.Location = New System.Drawing.Point(0, 128)
        Me.LabelParent.Name = "LabelParent"
        Me.LabelParent.Size = New System.Drawing.Size(131, 20)
        Me.LabelParent.TabIndex = 17
        Me.LabelParent.Text = "上个进度(仅子进度)"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(12, 589)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(132, 47)
        Me.ButtonGenerate.TabIndex = 19
        Me.ButtonGenerate.Text = "生成"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'LabelBackground
        '
        Me.LabelBackground.AutoSize = True
        Me.LabelBackground.Location = New System.Drawing.Point(1, 94)
        Me.LabelBackground.Name = "LabelBackground"
        Me.LabelBackground.Size = New System.Drawing.Size(159, 20)
        Me.LabelBackground.TabIndex = 25
        Me.LabelBackground.Text = "背景方块材质(仅根进度)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "配方列表"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "战利品列表"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "经验值总数"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(249, 20)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "批量执行命令(一行一个，不输入斜杠/)"
        '
        'NumericUpDownExperience
        '
        Me.NumericUpDownExperience.Location = New System.Drawing.Point(173, 87)
        Me.NumericUpDownExperience.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownExperience.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumericUpDownExperience.Name = "NumericUpDownExperience"
        Me.NumericUpDownExperience.Size = New System.Drawing.Size(239, 26)
        Me.NumericUpDownExperience.TabIndex = 33
        '
        'ButtonTitle
        '
        Me.ButtonTitle.Location = New System.Drawing.Point(173, 159)
        Me.ButtonTitle.Name = "ButtonTitle"
        Me.ButtonTitle.Size = New System.Drawing.Size(232, 29)
        Me.ButtonTitle.TabIndex = 37
        Me.ButtonTitle.Tag = "{}"
        Me.ButtonTitle.Text = "编辑"
        Me.ButtonTitle.UseVisualStyleBackColor = True
        '
        'ButtonDescription
        '
        Me.ButtonDescription.Location = New System.Drawing.Point(173, 194)
        Me.ButtonDescription.Name = "ButtonDescription"
        Me.ButtonDescription.Size = New System.Drawing.Size(232, 28)
        Me.ButtonDescription.TabIndex = 38
        Me.ButtonDescription.Tag = "{}"
        Me.ButtonDescription.Text = "编辑"
        Me.ButtonDescription.UseVisualStyleBackColor = True
        '
        'ComboBoxBackground
        '
        Me.ComboBoxBackground.FormattingEnabled = True
        Me.ComboBoxBackground.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxBackground.IntegralHeight = False
        Me.ComboBoxBackground.Location = New System.Drawing.Point(173, 91)
        Me.ComboBoxBackground.MaxDropDownItems = 16
        Me.ComboBoxBackground.Name = "ComboBoxBackground"
        Me.ComboBoxBackground.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxBackground.TabIndex = 39
        '
        'TreeViewCriterias
        '
        Me.TreeViewCriterias.HideSelection = False
        Me.TreeViewCriterias.Location = New System.Drawing.Point(11, 46)
        Me.TreeViewCriterias.Name = "TreeViewCriterias"
        TreeNode1.Name = "组"
        TreeNode1.Text = "组0"
        Me.TreeViewCriterias.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewCriterias.Size = New System.Drawing.Size(400, 443)
        Me.TreeViewCriterias.TabIndex = 40
        '
        'ButtonAddGroup
        '
        Me.ButtonAddGroup.Location = New System.Drawing.Point(11, 495)
        Me.ButtonAddGroup.Name = "ButtonAddGroup"
        Me.ButtonAddGroup.Size = New System.Drawing.Size(129, 47)
        Me.ButtonAddGroup.TabIndex = 41
        Me.ButtonAddGroup.Text = "新建组"
        Me.ButtonAddGroup.UseVisualStyleBackColor = True
        '
        'ButtonAddCriteria
        '
        Me.ButtonAddCriteria.Enabled = False
        Me.ButtonAddCriteria.Location = New System.Drawing.Point(146, 495)
        Me.ButtonAddCriteria.Name = "ButtonAddCriteria"
        Me.ButtonAddCriteria.Size = New System.Drawing.Size(129, 47)
        Me.ButtonAddCriteria.TabIndex = 42
        Me.ButtonAddCriteria.Text = "添加条件"
        Me.ButtonAddCriteria.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Enabled = False
        Me.ButtonRemove.Location = New System.Drawing.Point(281, 495)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(130, 47)
        Me.ButtonRemove.TabIndex = 43
        Me.ButtonRemove.Text = "删除条件"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(154, 582)
        Me.LabelResult.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(74, 20)
        Me.LabelResult.TabIndex = 44
        Me.LabelResult.Text = "等待生成..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "【每组各达成一个条件】即可完成进度"
        '
        'ComboBoxParent
        '
        Me.ComboBoxParent.FormattingEnabled = True
        Me.ComboBoxParent.IntegralHeight = False
        Me.ComboBoxParent.Location = New System.Drawing.Point(173, 125)
        Me.ComboBoxParent.MaxDropDownItems = 16
        Me.ComboBoxParent.Name = "ComboBoxParent"
        Me.ComboBoxParent.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxParent.TabIndex = 48
        '
        'ComboBoxItem
        '
        Me.ComboBoxItem.FormattingEnabled = True
        Me.ComboBoxItem.IntegralHeight = False
        Me.ComboBoxItem.Location = New System.Drawing.Point(173, 25)
        Me.ComboBoxItem.MaxDropDownItems = 16
        Me.ComboBoxItem.Name = "ComboBoxItem"
        Me.ComboBoxItem.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxItem.TabIndex = 50
        '
        'ButtonRecipes
        '
        Me.ButtonRecipes.Location = New System.Drawing.Point(173, 19)
        Me.ButtonRecipes.Name = "ButtonRecipes"
        Me.ButtonRecipes.Size = New System.Drawing.Size(239, 28)
        Me.ButtonRecipes.TabIndex = 51
        Me.ButtonRecipes.Tag = "[]"
        Me.ButtonRecipes.Text = "编辑"
        Me.ButtonRecipes.UseVisualStyleBackColor = True
        '
        'ButtonLoot
        '
        Me.ButtonLoot.Location = New System.Drawing.Point(173, 53)
        Me.ButtonLoot.Name = "ButtonLoot"
        Me.ButtonLoot.Size = New System.Drawing.Size(239, 28)
        Me.ButtonLoot.TabIndex = 52
        Me.ButtonLoot.Tag = "[]"
        Me.ButtonLoot.Text = "编辑"
        Me.ButtonLoot.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxHidden)
        Me.GroupBox1.Controls.Add(Me.CheckBoxAnnounce_To_Chat)
        Me.GroupBox1.Controls.Add(Me.CheckBoxShow_Toast)
        Me.GroupBox1.Controls.Add(Me.ComboBoxItem)
        Me.GroupBox1.Controls.Add(Me.ComboBoxParent)
        Me.GroupBox1.Controls.Add(Me.LabelParent)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBackground)
        Me.GroupBox1.Controls.Add(Me.ButtonDescription)
        Me.GroupBox1.Controls.Add(Me.ButtonTitle)
        Me.GroupBox1.Controls.Add(Me.LabelBackground)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBoxFrame)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownData)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 294)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "进度的显示设置"
        '
        'CheckBoxHidden
        '
        Me.CheckBoxHidden.AutoSize = True
        Me.CheckBoxHidden.Location = New System.Drawing.Point(232, 262)
        Me.CheckBoxHidden.Name = "CheckBoxHidden"
        Me.CheckBoxHidden.Size = New System.Drawing.Size(192, 24)
        Me.CheckBoxHidden.TabIndex = 53
        Me.CheckBoxHidden.Text = "完成前隐藏(对子进度生效)"
        Me.CheckBoxHidden.UseVisualStyleBackColor = True
        '
        'CheckBoxAnnounce_To_Chat
        '
        Me.CheckBoxAnnounce_To_Chat.AutoSize = True
        Me.CheckBoxAnnounce_To_Chat.Checked = True
        Me.CheckBoxAnnounce_To_Chat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAnnounce_To_Chat.Location = New System.Drawing.Point(114, 262)
        Me.CheckBoxAnnounce_To_Chat.Name = "CheckBoxAnnounce_To_Chat"
        Me.CheckBoxAnnounce_To_Chat.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxAnnounce_To_Chat.TabIndex = 52
        Me.CheckBoxAnnounce_To_Chat.Text = "广播到聊天栏"
        Me.CheckBoxAnnounce_To_Chat.UseVisualStyleBackColor = True
        '
        'CheckBoxShow_Toast
        '
        Me.CheckBoxShow_Toast.AutoSize = True
        Me.CheckBoxShow_Toast.Checked = True
        Me.CheckBoxShow_Toast.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxShow_Toast.Location = New System.Drawing.Point(10, 262)
        Me.CheckBoxShow_Toast.Name = "CheckBoxShow_Toast"
        Me.CheckBoxShow_Toast.Size = New System.Drawing.Size(98, 24)
        Me.CheckBoxShow_Toast.TabIndex = 51
        Me.CheckBoxShow_Toast.Text = "完成后提示"
        Me.CheckBoxShow_Toast.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxFunction)
        Me.GroupBox2.Controls.Add(Me.ButtonLoot)
        Me.GroupBox2.Controls.Add(Me.ButtonRecipes)
        Me.GroupBox2.Controls.Add(Me.NumericUpDownExperience)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 344)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 216)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "完成进度后的奖励(可选)"
        '
        'TextBoxFunction
        '
        Me.TextBoxFunction.Location = New System.Drawing.Point(13, 139)
        Me.TextBoxFunction.Multiline = True
        Me.TextBoxFunction.Name = "TextBoxFunction"
        Me.TextBoxFunction.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxFunction.Size = New System.Drawing.Size(399, 67)
        Me.TextBoxFunction.TabIndex = 53
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBoxOnlyCommand)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ButtonRemove)
        Me.GroupBox3.Controls.Add(Me.ButtonAddCriteria)
        Me.GroupBox3.Controls.Add(Me.ButtonAddGroup)
        Me.GroupBox3.Controls.Add(Me.TreeViewCriterias)
        Me.GroupBox3.Controls.Add(Me.PictureBoxOnlyCommand)
        Me.GroupBox3.Location = New System.Drawing.Point(448, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 548)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "条件列表(双击条件进行编辑)"
        '
        'CheckBoxOnlyCommand
        '
        Me.CheckBoxOnlyCommand.AutoSize = True
        Me.CheckBoxOnlyCommand.Location = New System.Drawing.Point(253, 22)
        Me.CheckBoxOnlyCommand.Name = "CheckBoxOnlyCommand"
        Me.CheckBoxOnlyCommand.Size = New System.Drawing.Size(168, 24)
        Me.CheckBoxOnlyCommand.TabIndex = 46
        Me.CheckBoxOnlyCommand.Text = "只能用命令获得此进度"
        Me.CheckBoxOnlyCommand.UseVisualStyleBackColor = True
        '
        'PictureBoxOnlyCommand
        '
        Me.PictureBoxOnlyCommand.Image = CType(resources.GetObject("PictureBoxOnlyCommand.Image"), System.Drawing.Image)
        Me.PictureBoxOnlyCommand.Location = New System.Drawing.Point(11, 93)
        Me.PictureBoxOnlyCommand.Name = "PictureBoxOnlyCommand"
        Me.PictureBoxOnlyCommand.Size = New System.Drawing.Size(400, 348)
        Me.PictureBoxOnlyCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxOnlyCommand.TabIndex = 48
        Me.PictureBoxOnlyCommand.TabStop = False
        Me.PictureBoxOnlyCommand.Visible = False
        '
        'LabelHelper
        '
        Me.LabelHelper.AutoSize = True
        Me.LabelHelper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelHelper.Font = New System.Drawing.Font("微软雅黑", 10.5!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelHelper.ForeColor = System.Drawing.Color.Gray
        Me.LabelHelper.Location = New System.Drawing.Point(154, 602)
        Me.LabelHelper.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelHelper.Name = "LabelHelper"
        Me.LabelHelper.Size = New System.Drawing.Size(191, 20)
        Me.LabelHelper.TabIndex = 56
        Me.LabelHelper.Text = "遇到问题？点我打开疑难解答"
        Me.LabelHelper.Visible = False
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(185, 12)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(232, 26)
        Me.TextBoxId.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "内部ID"
        '
        'GroupBoxCommands
        '
        Me.GroupBoxCommands.Controls.Add(Me.ButtonCopyRevoke)
        Me.GroupBoxCommands.Controls.Add(Me.ButtonCopyGrant)
        Me.GroupBoxCommands.Controls.Add(Me.TextBoxCommandRevoke)
        Me.GroupBoxCommands.Controls.Add(Me.Label9)
        Me.GroupBoxCommands.Controls.Add(Me.TextBoxCommandGrant)
        Me.GroupBoxCommands.Controls.Add(Me.Label8)
        Me.GroupBoxCommands.Location = New System.Drawing.Point(448, 560)
        Me.GroupBoxCommands.Name = "GroupBoxCommands"
        Me.GroupBoxCommands.Size = New System.Drawing.Size(419, 82)
        Me.GroupBoxCommands.TabIndex = 61
        Me.GroupBoxCommands.TabStop = False
        Me.GroupBoxCommands.Text = "相关命令"
        Me.GroupBoxCommands.Visible = False
        '
        'ButtonCopyRevoke
        '
        Me.ButtonCopyRevoke.Location = New System.Drawing.Point(364, 50)
        Me.ButtonCopyRevoke.Name = "ButtonCopyRevoke"
        Me.ButtonCopyRevoke.Size = New System.Drawing.Size(47, 26)
        Me.ButtonCopyRevoke.TabIndex = 65
        Me.ButtonCopyRevoke.Text = "复制"
        Me.ButtonCopyRevoke.UseVisualStyleBackColor = True
        '
        'ButtonCopyGrant
        '
        Me.ButtonCopyGrant.Location = New System.Drawing.Point(364, 19)
        Me.ButtonCopyGrant.Name = "ButtonCopyGrant"
        Me.ButtonCopyGrant.Size = New System.Drawing.Size(47, 26)
        Me.ButtonCopyGrant.TabIndex = 64
        Me.ButtonCopyGrant.Text = "复制"
        Me.ButtonCopyGrant.UseVisualStyleBackColor = True
        '
        'TextBoxCommandRevoke
        '
        Me.TextBoxCommandRevoke.Location = New System.Drawing.Point(106, 50)
        Me.TextBoxCommandRevoke.Name = "TextBoxCommandRevoke"
        Me.TextBoxCommandRevoke.ReadOnly = True
        Me.TextBoxCommandRevoke.Size = New System.Drawing.Size(254, 26)
        Me.TextBoxCommandRevoke.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "移除该进度"
        '
        'TextBoxCommandGrant
        '
        Me.TextBoxCommandGrant.Location = New System.Drawing.Point(106, 19)
        Me.TextBoxCommandGrant.Name = "TextBoxCommandGrant"
        Me.TextBoxCommandGrant.ReadOnly = True
        Me.TextBoxCommandGrant.Size = New System.Drawing.Size(254, 26)
        Me.TextBoxCommandGrant.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "获得该进度"
        '
        'LabelOpenJson
        '
        Me.LabelOpenJson.AutoSize = True
        Me.LabelOpenJson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelOpenJson.Font = New System.Drawing.Font("微软雅黑", 10.5!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelOpenJson.ForeColor = System.Drawing.Color.Gray
        Me.LabelOpenJson.Location = New System.Drawing.Point(154, 622)
        Me.LabelOpenJson.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelOpenJson.Name = "LabelOpenJson"
        Me.LabelOpenJson.Size = New System.Drawing.Size(121, 20)
        Me.LabelOpenJson.TabIndex = 62
        Me.LabelOpenJson.Text = "打开json文件路径"
        Me.LabelOpenJson.Visible = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 648)
        Me.Controls.Add(Me.LabelOpenJson)
        Me.Controls.Add(Me.GroupBoxCommands)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelHelper)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "FormMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_编辑进度"
        CType(Me.NumericUpDownData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownExperience, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxOnlyCommand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxCommands.ResumeLayout(False)
        Me.GroupBoxCommands.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDownData As NumericUpDown
    Friend WithEvents ComboBoxFrame As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelParent As Label
    Friend WithEvents ButtonGenerate As Button
    Friend WithEvents LabelBackground As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NumericUpDownExperience As NumericUpDown
    Friend WithEvents ButtonTitle As Button
    Friend WithEvents ButtonDescription As Button
    Friend WithEvents ComboBoxBackground As ComboBox
    Friend WithEvents TreeViewCriterias As TreeView
    Friend WithEvents ButtonAddGroup As Button
    Friend WithEvents ButtonAddCriteria As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents LabelResult As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxParent As ComboBox
    Friend WithEvents ComboBoxItem As ComboBox
    Friend WithEvents ButtonRecipes As Button
    Friend WithEvents ButtonLoot As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxHidden As CheckBox
    Friend WithEvents CheckBoxAnnounce_To_Chat As CheckBox
    Friend WithEvents CheckBoxShow_Toast As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxFunction As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelHelper As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBoxCommands As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCommandGrant As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxCommandRevoke As TextBox
    Friend WithEvents ButtonCopyRevoke As Button
    Friend WithEvents ButtonCopyGrant As Button
    Friend WithEvents CheckBoxOnlyCommand As CheckBox
    Friend WithEvents PictureBoxOnlyCommand As PictureBox
    Friend WithEvents LabelOpenJson As Label
End Class
