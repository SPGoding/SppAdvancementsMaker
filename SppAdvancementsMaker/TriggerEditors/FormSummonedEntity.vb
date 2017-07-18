Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormSummonedEntity
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Reset()
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("entity") IsNot Nothing Then
                Button1.Tag = ObjJson.Item("entity").ToString
            End If
        End If
    End Sub
    Private Sub Reset()
        Button1.Tag = "{}"
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If Button1.Tag <> "{}" Then
            StrResult &= Chr(34) & "entity" & Chr(34) & ":" & Button1.Tag
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormGlobalEntity.Reading(Button1, {"villager_golem", "snowman", "ender_gragon", "wither"})
    End Sub
End Class