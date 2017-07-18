Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormItemDurabilityChanged
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Reset()
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("item") IsNot Nothing Then
                ButtonItem.Tag = ObjJson.Item("item").ToString
            End If
            If ObjJson.Item("delta") IsNot Nothing Then
                If ObjJson.Item("delta").Item("max") IsNot Nothing Then
                    NumericUpDownDeltaMax.Value = ObjJson.Item("delta").Item("max").ToString
                End If
                If ObjJson.Item("delta").Item("min") IsNot Nothing Then
                    NumericUpDownDeltaMin.Value = ObjJson.Item("delta").Item("min").ToString
                End If
            End If
            If ObjJson.Item("durability") IsNot Nothing Then
                If ObjJson.Item("durability").Item("max") IsNot Nothing Then
                    NumericUpDownDurabilityMax.Value = ObjJson.Item("durability").Item("max").ToString
                End If
                If ObjJson.Item("durability").Item("min") IsNot Nothing Then
                    NumericUpDownDurabilityMin.Value = ObjJson.Item("durability").Item("min").ToString
                End If
            End If
        End If
    End Sub
    Private Sub Reset()
        ButtonItem.Tag = "{}"
        NumericUpDownDeltaMax.Value = 0
        NumericUpDownDeltaMin.Value = 0
        NumericUpDownDurabilityMax.Value = 0
        NumericUpDownDurabilityMin.Value = 0
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ButtonItem.Tag <> "{}" Then
            StrResult &= Chr(34) & "item" & Chr(34) & ":" & ButtonItem.Tag & ","
        End If
        If NumericUpDownDeltaMax.Value <> 0 Or NumericUpDownDeltaMin.Value <> 0 Then
            StrResult &= Chr(34) & "delta" & Chr(34) & ":{"
            If NumericUpDownDeltaMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownDeltaMax.Value & ","
            End If
            If NumericUpDownDeltaMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownDeltaMin.Value
            End If
            StrResult &= "},"
        End If
        If NumericUpDownDurabilityMax.Value <> 0 Or NumericUpDownDurabilityMin.Value <> 0 Then
            StrResult &= Chr(34) & "durability" & Chr(34) & ":{"
            If NumericUpDownDurabilityMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownDurabilityMax.Value & ","
            End If
            If NumericUpDownDurabilityMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownDurabilityMin.Value
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