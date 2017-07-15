Imports System.Threading
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormCriteria
    Private Sub FormCriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        For i = 0 To UBound(ZhTriggers)
            ComboBoxTrigger.Items.Add(ZhTriggers(i))
        Next
        ComboBoxTrigger.SelectedIndex = 0
    End Sub

    Public Sub Reading(StrCriteriaName As String, StrCriteriaJson As String, StrGroupJson As String)
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject("{" & StrCriteriaJson & "}"), JObject)
        '读取条件名
        TextBoxName.Tag = StrCriteriaName
        TextBoxName.Text = StrCriteriaName
        '读取触发器-种类
        Dim StrTriggerName As String = ObjJson.Item(StrCriteriaName).Item("trigger").ToString()
        ComboBoxTrigger.Text = EnToZh(StrTriggerName, ZhTriggers, EnTriggers)
        '读取触发器-条件Json
        ButtonCriteria.Tag = ObjJson.Item(StrCriteriaName).Item("conditions").ToString()
        '读取分组
        Dim j As Int16
        ComboBoxGroup.Items.Clear()
        ObjJson = CType(JsonConvert.DeserializeObject("[" & StrGroupJson & "]"), JArray)
        For i = 0 To ObjJson.Count - 1
            ComboBoxGroup.Items.Add("组" & i)
            For j = 0 To ObjJson.Item(i).Count - 1
                If ObjJson.Item(i).Item(j).ToString = StrCriteriaName Then
                    ComboBoxGroup.Text = "组" & i
                    ComboBoxGroup.Tag = "组" & i
                End If
            Next
        Next
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        Dim StrTemp As String = ""
        Dim i As Int16
        StrResult = Chr(34) & TextBoxName.Text & Chr(34) & ":{"
        StrTemp = ZhToEn(ComboBoxTrigger.Text, ZhTriggers, EnTriggers)
        StrResult &= Chr(34) & "trigger" & Chr(34) & ":" & Chr(34) & StrTemp & Chr(34) & ","
        StrResult &= Chr(34) & "conditions" & Chr(34) & ":" & ButtonCriteria.Tag
        StrResult &= "}"
        ' 找到正在编辑的条件所在 Node
        Dim j As Int16
        Dim k As Int16
        For i = 0 To FormMain.TreeViewCriterias.GetNodeCount(False) - 1
            For j = 0 To FormMain.TreeViewCriterias.Nodes.Item(i).GetNodeCount(False) - 1
                With FormMain.TreeViewCriterias.Nodes.Item(i).Nodes.Item(j)
                    If .Text = TextBoxName.Tag Then
                        ' 找到啦
                        If ComboBoxGroup.Text = ComboBoxGroup.Tag Then
                            ' 没更换分组
                            ' 直接更改 Tag(存储Json) 属性和 Text 属性
                            .Text = TextBoxName.Text
                            .Tag = StrResult
                            Exit For
                        Else
                            ' 更换了分组
                            ' 先删掉旧的这个
                            If .Text = TextBoxName.Tag Then
                                .Remove()
                            End If
                            ' 然后在更换后的组建一个新的
                            For k = 0 To FormMain.TreeViewCriterias.Nodes.Count - 1
                                If FormMain.TreeViewCriterias.Nodes.Item(k).Text = ComboBoxGroup.Text Then
                                    Dim Node As TreeNode = FormMain.TreeViewCriterias.Nodes.Item(k).Nodes.Add(TextBoxName.Text)
                                    Node.Name = "条"
                                    Node.Tag = StrResult
                                End If
                            Next k
                        End If
                    End If
                End With
            Next j
        Next i
        FormMain.SaveGroupJson()
        Hide()
        FormMain.Hide()
        FormMain.Show()
    End Sub

    Private Sub ButtonCriteria_Click(sender As Object, e As EventArgs) Handles ButtonCriteria.Click
        Dim StrTemp As String
        ' 找到当前触发器种类的英文
        StrTemp = ZhToEn(ComboBoxTrigger.Text， ZhTriggers, EnTriggers)
        ' 找到此触发器对应的窗体
        Select Case StrTemp
            Case "minecraft:bred_animals"
                FormBredAnimals.Reading(ButtonCriteria.Tag)
            Case "minecraft:brewed_potion"
                FormBrewedPotion.Reading(ButtonCriteria.Tag)
            Case "minecraft:changed_dimension"
                FormChangedDimension.Reading(ButtonCriteria.Tag)
            Case "minecraft:construct_beacon"
                FormConstruckBeacon.Reading(ButtonCriteria.Tag)
            Case "minecraft:consume_item"
                FormConsumeItem.Reading(ButtonCriteria.Tag)
            Case "minecraft:cured_zombie_villager"
                FormCuredZombieVillager.Reading(ButtonCriteria.Tag)
            Case "minecraft:effects_changed"
                FormEffectsChanged.Reading(ButtonCriteria.Tag)
            Case "minecraft:enchanted_item"
                FormEnchantedItem.Reading(ButtonCriteria.Tag)
            Case "minecraft:enter_block"
                FormEnterBlock.Reading(ButtonCriteria.Tag)
            Case "minecraft:entity_hurt_player"
                FormEntityHurtPlayer.Reading(ButtonCriteria.Tag)
            Case "minecraft:entity_killed_player"
                FormEntityKilledPlayer.Reading(ButtonCriteria.Tag)
            Case "minecraft:impossible"
                FormImpossible.Reading(ButtonCriteria.Tag)
            Case "minecraft:inventory_changed"
                FormInventoryChanged.Reading(ButtonCriteria.Tag)
            Case "minecraft:item_durability_changed"
                FormItemDurabilityChanged.Reading(ButtonCriteria.Tag)
            Case "minecraft:levitation"
                FormLevitation.Reading(ButtonCriteria.Tag)
            Case "minecraft:location"
                FormLocation.Reading(ButtonCriteria.Tag)
            Case "minecraft:nether_travel"
                FormNetherTravel.Reading(ButtonCriteria.Tag)
            Case "minecraft:placed_block"
                FormPlacedBlock.Reading(ButtonCriteria.Tag)
            Case "minecraft:player_hurt_entity"
                FormPlayerHurtEntity.Reading(ButtonCriteria.Tag)
            Case "minecraft:player_killed_entity"
                FormPlayerKilledEntity.Reading(ButtonCriteria.Tag)
            Case "minecraft:recipe_unlocked"
                FormRecipeUnlocked.Reading(ButtonCriteria.Tag)
            Case "minecraft:slept_in_bed"
                FormSleptInBed.Reading(ButtonCriteria.Tag)
            Case "minecraft:summoned_entity"
                FormSummonedEntity.Reading(ButtonCriteria.Tag)
            Case "minecraft:tame_animal"
                FormTameAnimal.Reading(ButtonCriteria.Tag)
            Case "minecraft:tick"
                FormTick.Reading(ButtonCriteria.Tag)
            Case "minecraft:used_ender_eye"
                FormUsedEnderEye.Reading(ButtonCriteria.Tag)
            Case "minecraft:used_totem"
                FormUsedTotem.Reading(ButtonCriteria.Tag)
            Case "minecraft:villager_trade"
                FormVillagerTrade.Reading(ButtonCriteria.Tag)
        End Select
    End Sub
End Class