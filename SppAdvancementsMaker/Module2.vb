Module Module2
    Public Function ZhToEn(StrZh As String, ZH As String(), EN As String()) As String
        Dim i As Int16
        For i = 0 To ZH.Count - 1
            If ZH(i) = StrZh Then
                Return EN(i)
                Exit Function
            End If
        Next
        Return ""
    End Function
    Public Function EnToZh(StrEn As String, ZH As String(), EN As String()) As String
        Dim i As Int16
        For i = 0 To EN.Count - 1
            If EN(i) = StrEn Then
                Return ZH(i)
                Exit Function
            End If
        Next
        Return ""
    End Function

    ' 触发器
    Public EnTrigger As String() = {
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
    Public ZhTrigger As String() = {
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

    ' 药水ID
    Public EnPotion As String() = {
        "poison",
        "harming",
        "regeneration",
        "strength",
        "night_vision",
        "mundane",
        "luck",
        "fire_resistance",
        "water_breathing",
        "water",
        "healing",
        "thick",
        "awkward",
        "slowness",
        "weakness",
        "leaping",
        "swiftness",
        "invisibility",
        "strong_poison",
        "strong_harming",
        "strong_regeneration",
        "strong_strength",
        "strong_healing",
        "strong_leaping",
        "strong_swiftness",
        "long_poison",
        "long_regeneration",
        "long_strength",
        "long_night_vision",
        "long_fire_resistance",
        "long_water_breathing",
        "long_slowness",
        "long_weakness",
        "long_leaping",
        "long_swiftness",
        "long_invisibility"
        }
    Public ZhPotion As String() = {
        "中毒",
        "伤害",
        "再生",
        "力量",
        "夜视",
        "平凡的药水",
        "幸运",
        "抗火",
        "水下呼吸",
        "水瓶",
        "治疗",
        "浑浊的药水",
        "粗制的药水",
        "缓慢",
        "虚弱",
        "跳跃",
        "迅捷",
        "隐身",
        "II级中毒",
        "II级伤害",
        "II级再生",
        "II级力量",
        "II级治疗",
        "II级跳跃",
        "II级迅捷",
        "延长版中毒",
        "延长版再生",
        "延长版力量",
        "延长版夜视",
        "延长版抗火",
        "延长版水下呼吸",
        "延长版缓慢",
        "延长版虚弱",
        "延长版跳跃",
        "延长版迅捷",
        "延长版隐身"
        }

    ' 维度
    Public EnDimension As String() = {
        "overworld",
        "the_nether",
        "the_end"
    }
    Public ZhDimension As String() = {
        "主世界",
        "地狱",
        "末地"
    }
End Module
