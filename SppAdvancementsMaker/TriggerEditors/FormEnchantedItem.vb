Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormEnchantedItem
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
            If ObjJson.Item("levels") IsNot Nothing Then
                If ObjJson.Item("levels").Item("max") IsNot Nothing Then
                    NumericUpDownMax.Value = ObjJson.Item("levels").Item("max").ToString
                End If
                If ObjJson.Item("levels").Item("min") IsNot Nothing Then
                    NumericUpDownMin.Value = ObjJson.Item("levels").Item("min").ToString
                End If
            End If
        End If
    End Sub
    Private Sub Reset()
        ButtonItem.Tag = "{}"
        NumericUpDownMax.Value = 0
        NumericUpDownMin.Value = 0
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ButtonItem.Tag <> "{}" Then
            StrResult &= Chr(34) & "item" & Chr(34) & ":" & ButtonItem.Tag & ","
        End If
        If NumericUpDownMax.Value <> 0 Or NumericUpDownMin.Value <> 0 Then
            StrResult &= Chr(34) & "levels" & Chr(34) & ":{"
            If NumericUpDownMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownMax.Value & ","
            End If
            If NumericUpDownMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownMin.Value
            End If
            StrResult &= "}"
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
End Class