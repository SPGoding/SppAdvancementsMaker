﻿Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormBredAnimals
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Reset()
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("child") IsNot Nothing Then
                ButtonChild.Tag = ObjJson.Item("child").ToString
            End If
            If ObjJson.Item("parent") IsNot Nothing Then
                ButtonParent.Tag = ObjJson.Item("parent").ToString
            End If
            If ObjJson.Item("partner") IsNot Nothing Then
                ButtonPartner.Tag = ObjJson.Item("partner").ToString
            End If
        End If
    End Sub
    Private Sub Reset()
        ButtonChild.Tag = "{}"
        ButtonParent.Tag = "{}"
        ButtonPartner.Tag = "{}"
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        StrResult &= Chr(34) & "child" & Chr(34) & ":" & ButtonChild.Tag & ","
        StrResult &= Chr(34) & "parent" & Chr(34) & ":" & ButtonParent.Tag & ","
        StrResult &= Chr(34) & "partner" & Chr(34) & ":" & ButtonPartner.Tag
        StrResult &= "}"
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub ButtonChild_Click(sender As Object, e As EventArgs) Handles ButtonChild.Click
        FormGlobalEntity.Reading(ButtonChild)
    End Sub
    Private Sub ButtonParent_Click(sender As Object, e As EventArgs) Handles ButtonParent.Click
        FormGlobalEntity.Reading(ButtonParent)
    End Sub
    Private Sub ButtonPartner_Click(sender As Object, e As EventArgs) Handles ButtonPartner.Click
        FormGlobalEntity.Reading(ButtonPartner)
    End Sub
End Class