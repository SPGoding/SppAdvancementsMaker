<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnterBlock
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
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxBlock = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(16, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "大多数条件是可选的"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(212, 150)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(118, 45)
        Me.ButtonEnter.TabIndex = 54
        Me.ButtonEnter.Text = "确定"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "方块ID："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "本触发器在玩家进入方块时触发(需将身子卡进去)"
        '
        'ComboBoxBlock
        '
        Me.ComboBoxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBlock.FormattingEnabled = True
        Me.ComboBoxBlock.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxBlock.IntegralHeight = False
        Me.ComboBoxBlock.Items.AddRange(New Object() {"", "基岩", "骨块", "书架", "brewing stand base", "brick", "chorus flower", "chorus flower dead", "chorus plant", "clay", "煤炭块", "煤矿", "coarse dirt", "cobblestone", "混凝土 black", "混凝土 blue", "混凝土 brown", "混凝土 cyan", "混凝土 gray", "混凝土 green", "混凝土 light blue", "混凝土 lime", "混凝土 magenta", "混凝土 orange", "混凝土 pink", "混凝土粉末 black", "混凝土粉末 blue", "混凝土粉末 brown", "混凝土粉末 cyan", "混凝土粉末 gray", "混凝土粉末 green", "混凝土粉末 light blue", "混凝土粉末 lime", "混凝土粉末 magenta", "混凝土粉末 orange", "混凝土粉末 pink", "混凝土粉末 purple", "混凝土粉末 red", "混凝土粉末 silver", "混凝土粉末 white", "混凝土粉末 yellow", "混凝土 purple", "混凝土 red", "混凝土 silver", "混凝土 white", "混凝土 yellow", "crafting table front", "crafting table side", "diamond block", "diamond ore", "dirt", "dirt podzol side", "dirt podzol top", "dragon egg", "dropper front horizontal", "dropper front vertical", "emerald block", "emerald ore", "enchanting table bottom", "end bricks", "end stone", "farmland dry", "farmland wet", "frosted ice 0", "frosted ice 1", "frosted ice 2", "frosted ice 3", "furnace front off", "furnace front on", "furnace side", "玻璃", "玻璃 black", "玻璃 blue", "玻璃 brown", "玻璃 cyan", "玻璃 gray", "玻璃 green", "玻璃 light blue", "玻璃 lime", "玻璃 magenta", "玻璃 orange", "玻璃 pink", "玻璃 purple", "玻璃 red", "玻璃 silver", "玻璃 white", "玻璃 yellow", "带釉陶瓦 black", "带釉陶瓦 blue", "带釉陶瓦 brown", "带釉陶瓦 cyan", "带釉陶瓦 gray", "带釉陶瓦 green", "带釉陶瓦 light blue", "带釉陶瓦 lime", "带釉陶瓦 magenta", "带釉陶瓦 orange", "带釉陶瓦 pink", "带釉陶瓦 purple", "带釉陶瓦 red", "带釉陶瓦 silver", "带釉陶瓦 white", "带釉陶瓦 yellow", "glowstone", "gold block", "gold ore", "grass path side", "grass path top", "grass side", "grass side snowed", "grass top", "gravel", "硬化粘土", "硬化染色粘土 black", "硬化染色粘土 blue", "硬化染色粘土 brown", "硬化染色粘土 cyan", "硬化染色粘土 gray", "硬化染色粘土 green", "硬化染色粘土 light blue", "硬化染色粘土 lime", "硬化染色粘土 magenta", "硬化染色粘土 orange", "硬化染色粘土 pink", "硬化染色粘土 purple", "硬化染色粘土 red", "硬化染色粘土 silver", "硬化染色粘土 white", "硬化染色粘土 yellow", "hay block side", "hay block top", "hopper inside", "hopper outside", "ice", "ice packed", "iron block", "iron ore", "jukebox side", "lapis block", "lapis ore", "log acacia", "log acacia top", "log big oak", "log big oak top", "log birch", "log birch top", "log jungle", "log jungle top", "log oak", "log oak top", "log spruce", "log spruce top", "melon side", "mob spawner", "mushroom block inside", "mushroom block skin brown", "mushroom block skin red", "mushroom block skin stem", "mycelium side", "mycelium top", "nether brick", "nether wart block", "netherrack", "noteblock", "observer front", "output.bat", "piston side", "planks acacia", "planks big oak", "planks birch", "planks jungle", "planks oak", "planks spruce", "prismarine bricks", "prismarine dark", "pumpkin face off", "pumpkin face on", "pumpkin side", "pumpkin top", "purpur block", "purpur pillar", "purpur pillar top", "quartz block bottom", "quartz block chiseled", "quartz block chiseled top", "quartz block lines", "quartz block lines top", "quartz block side", "quartz block top", "red nether brick", "red sand", "red sandstone bottom", "red sandstone carved", "red sandstone normal", "red sandstone smooth", "red sandstone top", "redstone block", "redstone dust overlay", "redstone lamp off", "redstone lamp on", "redstone ore", "sand", "sandstone bottom", "sandstone carved", "sandstone normal", "sandstone smooth", "sandstone top", "潜影盒 black", "潜影盒 blue", "潜影盒 brown", "潜影盒 cyan", "潜影盒 gray", "潜影盒 green", "潜影盒 light blue", "潜影盒 lime", "潜影盒 magenta", "潜影盒 orange", "潜影盒 pink", "潜影盒 purple", "潜影盒 red", "潜影盒 silver", "潜影盒 white", "潜影盒 yellow", "slime", "snow", "soul sand", "sponge", "sponge wet", "stone", "stone andesite", "stone andesite smooth", "stone diorite", "stone diorite smooth", "stone granite", "stone granite smooth", "stone slab side", "stone slab top", "stonebrick", "stonebrick carved", "stonebrick cracked", "stonebrick mossy", "tnt side", "染色羊毛 black", "染色羊毛 blue", "染色羊毛 brown", "染色羊毛 cyan", "染色羊毛 gray", "染色羊毛 green", "染色羊毛 light blue", "染色羊毛 lime", "染色羊毛 magenta", "染色羊毛 orange", "染色羊毛 pink", "染色羊毛 purple", "染色羊毛 red", "染色羊毛 silver", "染色羊毛 white", "染色羊毛 yellow"})
        Me.ComboBoxBlock.Location = New System.Drawing.Point(92, 41)
        Me.ComboBoxBlock.MaxDropDownItems = 16
        Me.ComboBoxBlock.Name = "ComboBoxBlock"
        Me.ComboBoxBlock.Size = New System.Drawing.Size(238, 28)
        Me.ComboBoxBlock.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "方块状态："
        '
        'FormEnterBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 207)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxBlock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormEnterBlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#2进度修改者_条件编辑器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxBlock As ComboBox
    Friend WithEvents Label4 As Label
End Class
