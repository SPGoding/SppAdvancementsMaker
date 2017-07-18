Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormPlayerHurtEntity
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Reset()
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("damage") IsNot Nothing Then
                ButtonDamage.Tag = ObjJson.Item("damage").ToString
            End If
        End If
    End Sub
    Private Sub Reset()
        ButtonDamage.Tag = "{}"
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ButtonDamage.Tag <> "{}" Then
            StrResult &= Chr(34) & "damage" & Chr(34) & ":" & ButtonDamage.Tag
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

    Private Sub ButtonDamage_Click(sender As Object, e As EventArgs) Handles ButtonDamage.Click
        FormGlobalDamage.Reading(ButtonDamage)
    End Sub
End Class