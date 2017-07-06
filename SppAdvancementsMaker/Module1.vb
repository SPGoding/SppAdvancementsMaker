Imports System.IO
Imports System.Text

Module Module1
    Public StrSavePath As String
    Public StrProjectAdvancementName As String

    Public StrTriggerNames As String() = {
        "minecraft:bred_animals",
        "minecraft:brewed_potion",
        "minecraft:changed_dimension",
        "minecraft:construct_beacon",
        "minecraft:consume_item",
        "minecraft:cured_zombie_villager",
        "minecraft:effects_changed",
        "minecraft:enchanted_item",
        "minecraft:enter_block",
        "minecraft:entity_hurt_player",
        "minecraft:entity_killed_player",
        "minecraft:impossible",
        "minecraft:inventory_changed",
        "minecraft:item_durability_changed",
        "minecraft:levitation",
        "minecraft:location",
        "minecraft:nether_travel",
        "minecraft:placed_block",
        "minecraft:player_hurt_entity",
        "minecraft:player_killed_entity",
        "minecraft:recipe_unlocked",
        "minecraft:slept_in_bed",
        "minecraft:summoned_entity",
        "minecraft:tame_animal",
        "minecraft:tick",
        "minecraft:used_ender_eye",
        "minecraft:used_totem",
        "minecraft:villager_trade"
    }

    Public StrTriggerDescriptions As String() = {
        "繁殖动物",
        "从酿造台取出药水",
        "在两个维度间旅行",
        "更改信标结构",
        "损耗物品",
        "治愈僵尸村民",
        "获得 / 消除状态效果",
        "通过附魔台附魔物品",
        "进入方块",
        "实体伤害玩家",
        "实体杀死玩家",
        "不可能触发",
        "物品栏变化",
        "物品栏中任何物品以任何形式损耗",
        "获得漂浮状态效果",
        "玩家的位置",
        "进入下界， 然后返回主世界",
        "放置方块",
        "伤害实体",
        "杀死实体",
        "解锁配方",
        "上床睡觉",
        "召唤实体",
        "驯服动物",
        "每个游戏刻",
        "使用末影之眼",
        "使用图腾",
        "与村民交易"
    }

    Public Sub CreateFile(StrFilePath As String, StrFileParentPath As String, StrFileText As String)
        ' 检测路径是否存在
        If Dir(StrFileParentPath, vbDirectory) = "" Then
            My.Computer.FileSystem.CreateDirectory(StrFileParentPath)
        End If
        ' 创建函数文件
        Dim FS As FileStream = File.Create(StrFilePath)
        Dim Info As Byte() = New UTF8Encoding(True).GetBytes(StrFileText)
        FS.Write(Info, 0, Info.Length)
        FS.Close()
    End Sub

    Public Function GenerateAdvancement(StrItem As String, IntData As Int16, StrTitle As String, StrFrame As String,
                                        StrBackground As String, StrDescription As String, BoolShowToast As Boolean,
                                        BoolAnnounceToChat As Boolean, BoolHidden As Boolean, StrParent As String,
                                        StrCriteria As String, StrRequirements As String, StrRewards As String)
        Dim StrResult As String
        Dim BooRoot As Boolean = False
        Dim BooNotRoot As Boolean = False
        StrResult = "{"
        StrResult &= Chr(34) & "display" & Chr(34) & ":{"
        StrResult &= """icon"":{"
        If StrItem <> "" Then
            StrResult &= """item"":""" & StrItem & ""","
        Else
            Throw New Exception("未输入物品ID")
        End If
        StrResult &= """data"":" & IntData
        StrResult &= "},"
        If StrTitle <> "" Then
            StrResult &= """title"":" & StrTitle & ","
        Else
            Throw New Exception("未输入进度名称")
        End If
        If StrFrame <> "" Then
            StrResult &= """frame"":""" & StrFrame & ""","
        Else
            Throw New Exception("未输入边框种类")
        End If
        If StrBackground <> "" Then
            StrResult &= """background"":""" & StrBackground & ""","
            BooRoot = True
        Else
            BooRoot = False
        End If
        If StrDescription <> "" Then
            StrResult &= """description"":" & StrDescription & ","
        Else
            Throw New Exception("未输入进度描述")
        End If
        StrResult &= """show_toast"":" & BoolShowToast.ToString.ToLower & ","
        StrResult &= """announce_to_chat"":" & BoolAnnounceToChat.ToString.ToLower & ","
        StrResult &= """hidden"":" & BoolHidden.ToString.ToLower
        StrResult &= "},"
        If StrParent <> "" Then
            StrResult &= """parent"":""" & StrParent & ""","
            BooNotRoot = True
        Else
            BooNotRoot = False
        End If
        If (BooRoot And BooNotRoot) Or ((Not BooRoot) And (Not BooNotRoot)) Then
            Throw New Exception("根进度与子进度不明确")
        End If
        If StrCriteria <> "" Then
            StrResult &= Chr(34) & "criteria" & Chr(34) & ":{" & StrCriteria & "},"
        Else
            Throw New Exception("未设置条件")
        End If
        If StrRequirements <> "" Then
            StrResult &= Chr(34) & "requirements" & Chr(34) & ":[" & StrRequirements & "],"
        Else
            Throw New Exception("未设置条件")
        End If
        If StrRewards <> "" Then
            StrResult &= Chr(34) & "rewards" & Chr(34) & ":{" & StrRewards & "}"
        End If
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        Return StrResult
    End Function
End Module
