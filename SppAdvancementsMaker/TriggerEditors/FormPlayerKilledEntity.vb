Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormPlayerKilledEntity
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Reset()
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("entity") IsNot Nothing Then
                ButtonEntity.Tag = ObjJson.Item("entity").ToString
            End If
            If ObjJson.Item("killing_blow") IsNot Nothing Then
                ButtonKillingBlow.Tag = ObjJson.Item("killing_blow").ToString
            End If
        End If
    End Sub
    Private Sub Reset()
        ButtonEntity.Tag = "{}"
        ButtonKillingBlow.Tag = "{}"
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ButtonEntity.Tag <> "{}" Then
            StrResult &= Chr(34) & "entity" & Chr(34) & ":" & ButtonEntity.Tag & ","
        End If
        If ButtonKillingBlow.Tag <> "{}" Then
            StrResult &= Chr(34) & "killing_blow" & Chr(34) & ":" & ButtonKillingBlow.Tag
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

    Private Sub ButtonEntity_Click(sender As Object, e As EventArgs) Handles ButtonEntity.Click
        FormGlobalEntity.Reading(ButtonEntity, {"N/A"})
    End Sub
    Private Sub ButtonKillingBlow_Click(sender As Object, e As EventArgs) Handles ButtonKillingBlow.Click
        FormGlobalKillingBlow.Reading(ButtonKillingBlow)
    End Sub
End Class