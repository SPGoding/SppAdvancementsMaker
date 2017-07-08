<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("组0")
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDownData = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxFrame = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.CheckBoxShow_Toast = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAnnounce_To_Chat = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHidden = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxParent = New System.Windows.Forms.TextBox()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxLoot = New System.Windows.Forms.TextBox()
        Me.NumericUpDownExperience = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxItem = New System.Windows.Forms.TextBox()
        Me.TextBoxFunction = New System.Windows.Forms.TextBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.ButtonTitle = New System.Windows.Forms.Button()
        Me.ButtonDescription = New System.Windows.Forms.Button()
        Me.ComboBoxBackground = New System.Windows.Forms.ComboBox()
        Me.TreeViewCriterias = New System.Windows.Forms.TreeView()
        Me.ButtonAddGroup = New System.Windows.Forms.Button()
        Me.ButtonAddCriteria = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonLoot = New System.Windows.Forms.Button()
        Me.OpenFileDialogLoot = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBoxRecipes = New System.Windows.Forms.ComboBox()
        CType(Me.NumericUpDownData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownExperience, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "作为图标的物品的字母ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "作为图标的物品的数据值"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "进度名称"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Location = New System.Drawing.Point(184, 104)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.ReadOnly = True
        Me.TextBoxTitle.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxTitle.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "边框种类"
        '
        'NumericUpDownData
        '
        Me.NumericUpDownData.Location = New System.Drawing.Point(184, 38)
        Me.NumericUpDownData.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDownData.Name = "NumericUpDownData"
        Me.NumericUpDownData.Size = New System.Drawing.Size(232, 26)
        Me.NumericUpDownData.TabIndex = 10
        '
        'ComboBoxFrame
        '
        Me.ComboBoxFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFrame.FormattingEnabled = True
        Me.ComboBoxFrame.Items.AddRange(New Object() {"普通的默认进度", "有穗的挑战进度", "更圆的目标进度"})
        Me.ComboBoxFrame.Location = New System.Drawing.Point(184, 135)
        Me.ComboBoxFrame.Name = "ComboBoxFrame"
        Me.ComboBoxFrame.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxFrame.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "描述"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(184, 169)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxDescription.TabIndex = 13
        '
        'CheckBoxShow_Toast
        '
        Me.CheckBoxShow_Toast.AutoSize = True
        Me.CheckBoxShow_Toast.Checked = True
        Me.CheckBoxShow_Toast.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxShow_Toast.Location = New System.Drawing.Point(16, 233)
        Me.CheckBoxShow_Toast.Name = "CheckBoxShow_Toast"
        Me.CheckBoxShow_Toast.Size = New System.Drawing.Size(98, 24)
        Me.CheckBoxShow_Toast.TabIndex = 14
        Me.CheckBoxShow_Toast.Text = "完成后提示"
        Me.CheckBoxShow_Toast.UseVisualStyleBackColor = True
        '
        'CheckBoxAnnounce_To_Chat
        '
        Me.CheckBoxAnnounce_To_Chat.AutoSize = True
        Me.CheckBoxAnnounce_To_Chat.Checked = True
        Me.CheckBoxAnnounce_To_Chat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAnnounce_To_Chat.Location = New System.Drawing.Point(120, 233)
        Me.CheckBoxAnnounce_To_Chat.Name = "CheckBoxAnnounce_To_Chat"
        Me.CheckBoxAnnounce_To_Chat.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxAnnounce_To_Chat.TabIndex = 15
        Me.CheckBoxAnnounce_To_Chat.Text = "广播到聊天栏"
        Me.CheckBoxAnnounce_To_Chat.UseVisualStyleBackColor = True
        '
        'CheckBoxHidden
        '
        Me.CheckBoxHidden.AutoSize = True
        Me.CheckBoxHidden.Location = New System.Drawing.Point(238, 233)
        Me.CheckBoxHidden.Name = "CheckBoxHidden"
        Me.CheckBoxHidden.Size = New System.Drawing.Size(98, 24)
        Me.CheckBoxHidden.TabIndex = 16
        Me.CheckBoxHidden.Text = "完成前隐藏"
        Me.CheckBoxHidden.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "上个进度(仅子进度)"
        '
        'TextBoxParent
        '
        Me.TextBoxParent.Location = New System.Drawing.Point(184, 201)
        Me.TextBoxParent.Name = "TextBoxParent"
        Me.TextBoxParent.Size = New System.Drawing.Size(232, 26)
        Me.TextBoxParent.TabIndex = 18
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(16, 484)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(132, 47)
        Me.ButtonGenerate.TabIndex = 19
        Me.ButtonGenerate.Text = "生成"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(435, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "条件"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "完成进度的奖励(可选)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "背景方块材质(仅根进度)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 298)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "配方列表"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(34, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "战利品列表"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 361)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "经验值总数"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 388)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(249, 20)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "批量执行命令(一行一个，不输入斜杠/)"
        '
        'TextBoxLoot
        '
        Me.TextBoxLoot.Location = New System.Drawing.Point(184, 327)
        Me.TextBoxLoot.Name = "TextBoxLoot"
        Me.TextBoxLoot.ReadOnly = True
        Me.TextBoxLoot.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxLoot.TabIndex = 32
        '
        'NumericUpDownExperience
        '
        Me.NumericUpDownExperience.Location = New System.Drawing.Point(184, 359)
        Me.NumericUpDownExperience.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDownExperience.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumericUpDownExperience.Name = "NumericUpDownExperience"
        Me.NumericUpDownExperience.Size = New System.Drawing.Size(232, 26)
        Me.NumericUpDownExperience.TabIndex = 33
        '
        'TextBoxItem
        '
        Me.TextBoxItem.Location = New System.Drawing.Point(184, 6)
        Me.TextBoxItem.Name = "TextBoxItem"
        Me.TextBoxItem.Size = New System.Drawing.Size(232, 26)
        Me.TextBoxItem.TabIndex = 34
        '
        'TextBoxFunction
        '
        Me.TextBoxFunction.Location = New System.Drawing.Point(39, 411)
        Me.TextBoxFunction.Multiline = True
        Me.TextBoxFunction.Name = "TextBoxFunction"
        Me.TextBoxFunction.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxFunction.Size = New System.Drawing.Size(377, 67)
        Me.TextBoxFunction.TabIndex = 35
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(16, 637)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(401, 26)
        Me.TextBoxResult.TabIndex = 36
        '
        'ButtonTitle
        '
        Me.ButtonTitle.Location = New System.Drawing.Point(391, 105)
        Me.ButtonTitle.Name = "ButtonTitle"
        Me.ButtonTitle.Size = New System.Drawing.Size(25, 24)
        Me.ButtonTitle.TabIndex = 37
        Me.ButtonTitle.Text = "···"
        Me.ButtonTitle.UseVisualStyleBackColor = True
        '
        'ButtonDescription
        '
        Me.ButtonDescription.Location = New System.Drawing.Point(391, 170)
        Me.ButtonDescription.Name = "ButtonDescription"
        Me.ButtonDescription.Size = New System.Drawing.Size(25, 24)
        Me.ButtonDescription.TabIndex = 38
        Me.ButtonDescription.Text = "···"
        Me.ButtonDescription.UseVisualStyleBackColor = True
        '
        'ComboBoxBackground
        '
        Me.ComboBoxBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBackground.FormattingEnabled = True
        Me.ComboBoxBackground.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxBackground.IntegralHeight = False
        Me.ComboBoxBackground.Items.AddRange(New Object() {"", "bedrock", "bone_block_side", "bookshelf", "brewing_stand_base", "brick", "chorus_flower", "chorus_flower_dead", "chorus_plant", "clay", "coal_block", "coal_ore", "coarse_dirt", "cobblestone", "concrete_black", "concrete_blue", "concrete_brown", "concrete_cyan", "concrete_gray", "concrete_green", "concrete_light_blue", "concrete_lime", "concrete_magenta", "concrete_orange", "concrete_pink", "concrete_powder_black", "concrete_powder_blue", "concrete_powder_brown", "concrete_powder_cyan", "concrete_powder_gray", "concrete_powder_green", "concrete_powder_light_blue", "concrete_powder_lime", "concrete_powder_magenta", "concrete_powder_orange", "concrete_powder_pink", "concrete_powder_purple", "concrete_powder_red", "concrete_powder_silver", "concrete_powder_white", "concrete_powder_yellow", "concrete_purple", "concrete_red", "concrete_silver", "concrete_white", "concrete_yellow", "crafting_table_front", "crafting_table_side", "diamond_block", "diamond_ore", "dirt", "dirt_podzol_side", "dirt_podzol_top", "dragon_egg", "dropper_front_horizontal", "dropper_front_vertical", "emerald_block", "emerald_ore", "enchanting_table_bottom", "end_bricks", "end_stone", "farmland_dry", "farmland_wet", "frosted_ice_0", "frosted_ice_1", "frosted_ice_2", "frosted_ice_3", "furnace_front_off", "furnace_front_on", "furnace_side", "glass", "glass_black", "glass_blue", "glass_brown", "glass_cyan", "glass_gray", "glass_green", "glass_light_blue", "glass_lime", "glass_magenta", "glass_orange", "glass_pink", "glass_purple", "glass_red", "glass_silver", "glass_white", "glass_yellow", "glazed_terracotta_black", "glazed_terracotta_blue", "glazed_terracotta_brown", "glazed_terracotta_cyan", "glazed_terracotta_gray", "glazed_terracotta_green", "glazed_terracotta_light_blue", "glazed_terracotta_lime", "glazed_terracotta_magenta", "glazed_terracotta_orange", "glazed_terracotta_pink", "glazed_terracotta_purple", "glazed_terracotta_red", "glazed_terracotta_silver", "glazed_terracotta_white", "glazed_terracotta_yellow", "glowstone", "gold_block", "gold_ore", "grass_path_side", "grass_path_top", "grass_side", "grass_side_snowed", "grass_top", "gravel", "hardened_clay", "hardened_clay_stained_black", "hardened_clay_stained_blue", "hardened_clay_stained_brown", "hardened_clay_stained_cyan", "hardened_clay_stained_gray", "hardened_clay_stained_green", "hardened_clay_stained_light_blue", "hardened_clay_stained_lime", "hardened_clay_stained_magenta", "hardened_clay_stained_orange", "hardened_clay_stained_pink", "hardened_clay_stained_purple", "hardened_clay_stained_red", "hardened_clay_stained_silver", "hardened_clay_stained_white", "hardened_clay_stained_yellow", "hay_block_side", "hay_block_top", "hopper_inside", "hopper_outside", "ice", "ice_packed", "iron_block", "iron_ore", "jukebox_side", "lapis_block", "lapis_ore", "log_acacia", "log_acacia_top", "log_big_oak", "log_big_oak_top", "log_birch", "log_birch_top", "log_jungle", "log_jungle_top", "log_oak", "log_oak_top", "log_spruce", "log_spruce_top", "melon_side", "mob_spawner", "mushroom_block_inside", "mushroom_block_skin_brown", "mushroom_block_skin_red", "mushroom_block_skin_stem", "mycelium_side", "mycelium_top", "nether_brick", "nether_wart_block", "netherrack", "noteblock", "observer_front", "output.bat", "piston_side", "planks_acacia", "planks_big_oak", "planks_birch", "planks_jungle", "planks_oak", "planks_spruce", "prismarine_bricks", "prismarine_dark", "pumpkin_face_off", "pumpkin_face_on", "pumpkin_side", "pumpkin_top", "purpur_block", "purpur_pillar", "purpur_pillar_top", "quartz_block_bottom", "quartz_block_chiseled", "quartz_block_chiseled_top", "quartz_block_lines", "quartz_block_lines_top", "quartz_block_side", "quartz_block_top", "red_nether_brick", "red_sand", "red_sandstone_bottom", "red_sandstone_carved", "red_sandstone_normal", "red_sandstone_smooth", "red_sandstone_top", "redstone_block", "redstone_dust_overlay", "redstone_lamp_off", "redstone_lamp_on", "redstone_ore", "sand", "sandstone_bottom", "sandstone_carved", "sandstone_normal", "sandstone_smooth", "sandstone_top", "shulker_top_black", "shulker_top_blue", "shulker_top_brown", "shulker_top_cyan", "shulker_top_gray", "shulker_top_green", "shulker_top_light_blue", "shulker_top_lime", "shulker_top_magenta", "shulker_top_orange", "shulker_top_pink", "shulker_top_purple", "shulker_top_red", "shulker_top_silver", "shulker_top_white", "shulker_top_yellow", "slime", "snow", "soul_sand", "sponge", "sponge_wet", "stone", "stone_andesite", "stone_andesite_smooth", "stone_diorite", "stone_diorite_smooth", "stone_granite", "stone_granite_smooth", "stone_slab_side", "stone_slab_top", "stonebrick", "stonebrick_carved", "stonebrick_cracked", "stonebrick_mossy", "tnt_side", "wool_colored_black", "wool_colored_blue", "wool_colored_brown", "wool_colored_cyan", "wool_colored_gray", "wool_colored_green", "wool_colored_light_blue", "wool_colored_lime", "wool_colored_magenta", "wool_colored_orange", "wool_colored_pink", "wool_colored_purple", "wool_colored_red", "wool_colored_silver", "wool_colored_white", "wool_colored_yellow"})
        Me.ComboBoxBackground.Location = New System.Drawing.Point(184, 70)
        Me.ComboBoxBackground.MaxDropDownItems = 16
        Me.ComboBoxBackground.Name = "ComboBoxBackground"
        Me.ComboBoxBackground.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxBackground.TabIndex = 39
        '
        'TreeViewCriterias
        '
        Me.TreeViewCriterias.HideSelection = False
        Me.TreeViewCriterias.Location = New System.Drawing.Point(439, 32)
        Me.TreeViewCriterias.Name = "TreeViewCriterias"
        TreeNode1.Name = "组"
        TreeNode1.Text = "组0"
        Me.TreeViewCriterias.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewCriterias.Size = New System.Drawing.Size(400, 393)
        Me.TreeViewCriterias.TabIndex = 40
        '
        'ButtonAddGroup
        '
        Me.ButtonAddGroup.Location = New System.Drawing.Point(439, 431)
        Me.ButtonAddGroup.Name = "ButtonAddGroup"
        Me.ButtonAddGroup.Size = New System.Drawing.Size(129, 47)
        Me.ButtonAddGroup.TabIndex = 41
        Me.ButtonAddGroup.Text = "新建组"
        Me.ButtonAddGroup.UseVisualStyleBackColor = True
        '
        'ButtonAddCriteria
        '
        Me.ButtonAddCriteria.Enabled = False
        Me.ButtonAddCriteria.Location = New System.Drawing.Point(574, 431)
        Me.ButtonAddCriteria.Name = "ButtonAddCriteria"
        Me.ButtonAddCriteria.Size = New System.Drawing.Size(129, 47)
        Me.ButtonAddCriteria.TabIndex = 42
        Me.ButtonAddCriteria.Text = "添加条件"
        Me.ButtonAddCriteria.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Enabled = False
        Me.ButtonRemove.Location = New System.Drawing.Point(709, 431)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(130, 47)
        Me.ButtonRemove.TabIndex = 43
        Me.ButtonRemove.Text = "删除条件"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(158, 497)
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
        Me.Label1.Location = New System.Drawing.Point(470, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "【每组各达成一个条件】即可完成进度"
        '
        'ButtonLoot
        '
        Me.ButtonLoot.Location = New System.Drawing.Point(391, 328)
        Me.ButtonLoot.Name = "ButtonLoot"
        Me.ButtonLoot.Size = New System.Drawing.Size(25, 24)
        Me.ButtonLoot.TabIndex = 46
        Me.ButtonLoot.Text = "···"
        Me.ButtonLoot.UseVisualStyleBackColor = True
        '
        'OpenFileDialogLoot
        '
        Me.OpenFileDialogLoot.FileName = "OpenFileDialog1"
        '
        'ComboBoxRecipes
        '
        Me.ComboBoxRecipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRecipes.FormattingEnabled = True
        Me.ComboBoxRecipes.Items.AddRange(New Object() {"普通的默认进度", "有穗的挑战进度", "更圆的目标进度"})
        Me.ComboBoxRecipes.Location = New System.Drawing.Point(184, 295)
        Me.ComboBoxRecipes.Name = "ComboBoxRecipes"
        Me.ComboBoxRecipes.Size = New System.Drawing.Size(232, 28)
        Me.ComboBoxRecipes.TabIndex = 47
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 543)
        Me.Controls.Add(Me.ComboBoxRecipes)
        Me.Controls.Add(Me.ButtonLoot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonAddCriteria)
        Me.Controls.Add(Me.ButtonAddGroup)
        Me.Controls.Add(Me.TextBoxParent)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TreeViewCriterias)
        Me.Controls.Add(Me.ComboBoxBackground)
        Me.Controls.Add(Me.ButtonDescription)
        Me.Controls.Add(Me.ButtonTitle)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.TextBoxFunction)
        Me.Controls.Add(Me.TextBoxItem)
        Me.Controls.Add(Me.NumericUpDownExperience)
        Me.Controls.Add(Me.TextBoxLoot)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.CheckBoxHidden)
        Me.Controls.Add(Me.CheckBoxAnnounce_To_Chat)
        Me.Controls.Add(Me.CheckBoxShow_Toast)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxFrame)
        Me.Controls.Add(Me.NumericUpDownData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者"
        CType(Me.NumericUpDownData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownExperience, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDownData As NumericUpDown
    Friend WithEvents ComboBoxFrame As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents CheckBoxShow_Toast As CheckBox
    Friend WithEvents CheckBoxAnnounce_To_Chat As CheckBox
    Friend WithEvents CheckBoxHidden As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxParent As TextBox
    Friend WithEvents ButtonGenerate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxLoot As TextBox
    Friend WithEvents NumericUpDownExperience As NumericUpDown
    Friend WithEvents TextBoxItem As TextBox
    Friend WithEvents TextBoxFunction As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents ButtonTitle As Button
    Friend WithEvents ButtonDescription As Button
    Friend WithEvents ComboBoxBackground As ComboBox
    Friend WithEvents TreeViewCriterias As TreeView
    Friend WithEvents ButtonAddGroup As Button
    Friend WithEvents ButtonAddCriteria As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents LabelResult As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLoot As Button
    Friend WithEvents OpenFileDialogLoot As OpenFileDialog
    Friend WithEvents ComboBoxRecipes As ComboBox
End Class
