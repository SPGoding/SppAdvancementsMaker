Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormCuredZombieVillager
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Reset()
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("villager") IsNot Nothing Then
                ButtonVillager.Tag = ObjJson.Item("villager").ToString
            End If
            If ObjJson.Item("zombie") IsNot Nothing Then
                ButtonZombie.Tag = ObjJson.Item("zombie").ToString
            End If
        End If
    End Sub
    Private Sub Reset()
        ButtonVillager.Tag = "{}"
        ButtonZombie.Tag = "{}"
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ButtonVillager.Tag <> "{}" Then
            StrResult &= Chr(34) & "villager" & Chr(34) & ":" & ButtonVillager.Tag & ","
        End If
        If ButtonZombie.Tag <> "{}" Then
            StrResult &= Chr(34) & "zombie" & Chr(34) & ":" & ButtonZombie.Tag
        End If
        StrResult &= "}"
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub ButtonVillager_Click(sender As Object, e As EventArgs) Handles ButtonVillager.Click
        FormGlobalEntity.Reading(ButtonVillager)
    End Sub
    Private Sub ButtonZombie_Click(sender As Object, e As EventArgs) Handles ButtonZombie.Click
        FormGlobalEntity.Reading(ButtonZombie)
    End Sub
End Class