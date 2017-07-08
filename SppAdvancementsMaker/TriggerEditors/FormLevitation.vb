Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormLevitation
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            Try
                If ObjJson.Item("disatance").Item("absolute").Item("max").ToString <> "" Then
                    NumericUpDownAbsoluteMax.Value = ObjJson.Item("disatance").Item("absolute").Item("max").ToString
                End If
                If ObjJson.Item("disatance").Item("absolute").Item("min") <> Nothing Then
                    NumericUpDownAbsoluteMin.Value = ObjJson.Item("disatance").Item("absolute").Item("min").ToString
                End If
                If ObjJson.Item("disatance").Item("horizontal").Item("max") <> Nothing Then
                    NumericUpDownHorizontalMax.Value = ObjJson.Item("disatance").Item("horizontal").Item("max").ToString
                End If
                If ObjJson.Item("disatance").Item("horizontal").Item("min") <> Nothing Then
                    NumericUpDownHorizontalMin.Value = ObjJson.Item("disatance").Item("horizontal").Item("min").ToString
                End If
                If ObjJson.Item("disatance").Item("x").Item("max") <> Nothing Then
                    NumericUpDownXMax.Value = ObjJson.Item("disatance").Item("x").Item("max").ToString
                End If
                If ObjJson.Item("disatance").Item("x").Item("min") <> Nothing Then
                    NumericUpDownXMin.Value = ObjJson.Item("disatance").Item("x").Item("min").ToString
                End If
                If ObjJson.Item("disatance").Item("y").Item("max") <> Nothing Then
                    NumericUpDownYMax.Value = ObjJson.Item("disatance").Item("y").Item("max").ToString
                End If
                If ObjJson.Item("disatance").Item("y").Item("min") <> Nothing Then
                    NumericUpDownYMin.Value = ObjJson.Item("disatance").Item("y").Item("min").ToString
                End If
                If ObjJson.Item("disatance").Item("z").Item("max") <> Nothing Then
                    NumericUpDownZMax.Value = ObjJson.Item("disatance").Item("z").Item("max").ToString
                End If
                If ObjJson.Item("disatance").Item("z").Item("min") <> Nothing Then
                    NumericUpDownZMin.Value = ObjJson.Item("disatance").Item("z").Item("min").ToString
                End If
                If ObjJson.Item("duration").Item("max") <> Nothing Then
                    NumericUpDownDurationMax.Value = ObjJson.Item("duration").Item("max").ToString
                End If
                If ObjJson.Item("duration").Item("min") <> Nothing Then
                    NumericUpDownDurationMin.Value = ObjJson.Item("duration").Item("min").ToString
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{" & Chr(34) & "distance" & Chr(34) & ":{"
        StrResult &= Chr(34) & "absolute" & Chr(34) & ":{"
        If NumericUpDownAbsoluteMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownAbsoluteMax.Value
        End If
        If NumericUpDownAbsoluteMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownAbsoluteMin.Value
        End If
        StrResult &= "},"
        StrResult &= Chr(34) & "horizontal" & Chr(34) & ":{"
        If NumericUpDownHorizontalMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownHorizontalMax.Value
        End If
        If NumericUpDownHorizontalMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownHorizontalMin.Value
        End If
        StrResult &= "},"
        StrResult &= Chr(34) & "x" & Chr(34) & ":{"
        If NumericUpDownXMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownXMax.Value
        End If
        If NumericUpDownXMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownXMin.Value
        End If
        StrResult &= "},"
        StrResult &= Chr(34) & "y" & Chr(34) & ":{"
        If NumericUpDownYMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownYMax.Value
        End If
        If NumericUpDownYMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownYMin.Value
        End If
        StrResult &= "},"
        StrResult &= Chr(34) & "z" & Chr(34) & ":{"
        If NumericUpDownZMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownZMax.Value
        End If
        If NumericUpDownZMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownZMin.Value
        End If
        StrResult &= "}"
        StrResult &= "},"
        StrResult &= Chr(34) & "duration" & Chr(34) & ":{"
        If NumericUpDownDurationMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownDurationMax.Value
        End If
        If NumericUpDownDurationMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownDurationMin.Value
        End If
        StrResult &= "}"
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show()
    End Sub
End Class