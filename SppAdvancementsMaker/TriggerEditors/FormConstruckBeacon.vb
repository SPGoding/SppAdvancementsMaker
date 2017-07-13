Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormConstruckBeacon
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("level") IsNot Nothing Then
                If ObjJson.Item("level").Item("max") IsNot Nothing Then
                    NumericUpDownMax.Value = ObjJson.Item("level").Item("max").ToString
                Else
                    NumericUpDownMax.Value = 0
                End If
                If ObjJson.Item("level").Item("min") IsNot Nothing Then
                    NumericUpDownMin.Value = ObjJson.Item("level").Item("min").ToString
                Else
                    NumericUpDownMin.Value = 0
                End If
            Else

                NumericUpDownMax.Value = 0
                NumericUpDownMin.Value = 0
            End If
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If NumericUpDownMax.Value <> 0 Or NumericUpDownMin.Value <> 0 Then
            StrResult &= Chr(34) & "level" & Chr(34) & ":{"
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
End Class