﻿Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormVillagerTrade
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Reset()
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("item") IsNot Nothing Then
                ButtonItem.Tag = ObjJson.Item("item").ToString
            End If
            If ObjJson.Item("villager") IsNot Nothing Then
                ButtonVillager.Tag = ObjJson.Item("villager").ToString
            End If
        End If
    End Sub
    Private Sub Reset()
        ButtonItem.Tag = "{}"
        ButtonVillager.Tag = "{}"
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ButtonItem.Tag <> "{}" Then
            StrResult &= Chr(34) & "item" & Chr(34) & ":" & ButtonItem.Tag & ","
        End If
        If ButtonVillager.Tag <> "{}" Then
            StrResult &= Chr(34) & "villager" & Chr(34) & ":" & ButtonVillager.Tag
        End If
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub ButtonItem_Click(sender As Object, e As EventArgs) Handles ButtonItem.Click
        FormGlobalItem.Reading(ButtonItem, {"N/A"})
    End Sub
    Private Sub ButtonVillager_Click(sender As Object, e As EventArgs) Handles ButtonVillager.Click
        FormGlobalEntity.Reading(ButtonVillager, {"villager"})
    End Sub
End Class