Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormEnterBlock
    '//TODO http://minecraft-zh.gamepedia.com/%E6%96%B9%E5%9D%97%E7%8A%B6%E6%80%81
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("block") IsNot Nothing Then
                ComboBoxBlock.Tag = ObjJson.Item("block").ToString
                ComboBoxBlock.Text = EnToZh(ComboBoxBlock.Tag, ZhBlocks, EnBlocks)
            Else
                ComboBoxBlock.Text = ""
            End If
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ComboBoxBlock.Tag <> "" Then
            StrResult &= Chr(34) & "block" & Chr(34) & ":" & Chr(34) & ComboBoxBlock.Tag & Chr(34) & ","
        End If
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show()
    End Sub

    Private Sub ComboBoxBlock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBlock.SelectedIndexChanged
        ComboBoxBlock.Tag = ZhToEn(ComboBoxBlock.Text, ZhBlocks, EnBlocks)
    End Sub
End Class