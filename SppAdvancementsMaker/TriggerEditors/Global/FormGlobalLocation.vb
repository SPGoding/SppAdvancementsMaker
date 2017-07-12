Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormGlobalLocation
    Private ButtonTarget As Button

    Private Sub FormGlobalLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        ' 读取 Combobox 们
        ComboBoxBiome.Items.Add("")
        For i = 0 To UBound(ZhBiomes)
            ComboBoxBiome.Items.Add(ZhBiomes(i))
        Next
        ComboBoxDimension.Items.Add("")
        For i = 0 To UBound(ZhDimensions)
            ComboBoxDimension.Items.Add(ZhDimensions(i))
        Next
        ComboBoxFeature.Items.Add("")
        For i = 0 To UBound(ZhFeatures)
            ComboBoxFeature.Items.Add(ZhFeatures(i))
        Next
    End Sub

    Private Sub Reset()
        ComboBoxBiome.SelectedIndex = 0
        ComboBoxDimension.SelectedIndex = 0
        ComboBoxFeature.SelectedIndex = 0
        NumericUpDownXMax.Value = 0
        NumericUpDownXMin.Value = 0
        NumericUpDownYMax.Value = 0
        NumericUpDownYMin.Value = 0
        NumericUpDownZMax.Value = 0
        NumericUpDownZMin.Value = 0
    End Sub

    Public Sub Reading(ByRef ButtonTarget As Button)
        ' 显示本窗体
        Visible = False
        Show()
        ' 读取传送过来的 Json 文本
        Reset()
        Me.ButtonTarget = ButtonTarget
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(ButtonTarget.Tag), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("biome") IsNot Nothing Then
                ComboBoxBiome.Text = EnToZh(ObjJson.Item("biome").ToString, ZhBiomes, EnBiomes)
            End If
            If ObjJson.Item("dimension") IsNot Nothing Then
                ComboBoxDimension.Text = EnToZh(ObjJson.Item("dimension").ToString, ZhDimensions, EnDimensions)
            End If
            If ObjJson.Item("feature") IsNot Nothing Then
                ComboBoxFeature.Text = EnToZh(ObjJson.Item("feature").ToString, ZhFeatures, EnFeatures)
            End If
            If ObjJson.Item("position") IsNot Nothing Then
                If ObjJson.Item("position").Item("x") IsNot Nothing Then
                    If ObjJson.Item("position").Item("x").Item("max") IsNot Nothing Then
                        NumericUpDownXMax.Value = ObjJson.Item("position").Item("x").Item("max").ToString
                    End If
                    If ObjJson.Item("position").Item("x").Item("min") IsNot Nothing Then
                        NumericUpDownXMin.Value = ObjJson.Item("position").Item("x").Item("min").ToString
                    End If
                End If
                If ObjJson.Item("position").Item("y") IsNot Nothing Then
                    If ObjJson.Item("position").Item("y").Item("max") IsNot Nothing Then
                        NumericUpDownYMax.Value = ObjJson.Item("position").Item("y").Item("max").ToString
                    End If
                    If ObjJson.Item("position").Item("y").Item("min") IsNot Nothing Then
                        NumericUpDownYMin.Value = ObjJson.Item("position").Item("y").Item("min").ToString
                    End If
                End If
                If ObjJson.Item("position").Item("z") IsNot Nothing Then
                    If ObjJson.Item("position").Item("z").Item("max") IsNot Nothing Then
                        NumericUpDownZMax.Value = ObjJson.Item("position").Item("z").Item("max").ToString
                    End If
                    If ObjJson.Item("position").Item("z").Item("min") IsNot Nothing Then
                        NumericUpDownZMin.Value = ObjJson.Item("position").Item("z").Item("min").ToString
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Wirting(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ComboBoxBiome.Text <> "" Then
            StrResult &= Chr(34) & "biome" & Chr(34) & ":" & Chr(34) & ZhToEn(ComboBoxBiome.Text, ZhBiomes, EnBiomes) & Chr(34) & ","
        End If
        If ComboBoxDimension.Text <> "" Then
            StrResult &= Chr(34) & "dimension" & Chr(34) & ":" & Chr(34) & ZhToEn(ComboBoxDimension.Text, ZhDimensions, EnDimensions) & Chr(34) & ","
        End If
        If ComboBoxFeature.Text <> "" Then
            StrResult &= Chr(34) & "feature" & Chr(34) & ":" & Chr(34) & ZhToEn(ComboBoxFeature.Text, ZhFeatures, EnFeatures) & Chr(34) & ","
        End If
        StrResult &= Chr(34) & "position" & Chr(34) & ":{"
        StrResult &= Chr(34) & "x" & Chr(34) & ":{"
        If NumericUpDownXMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownXMax.Value & ","
        End If
        If NumericUpDownXMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownXMin.Value & ","
        End If
        StrResult &= "},"
        StrResult &= Chr(34) & "y" & Chr(34) & ":{"
        If NumericUpDownYMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownYMax.Value & ","
        End If
        If NumericUpDownYMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownYMin.Value & ","
        End If
        StrResult &= "},"
        StrResult &= Chr(34) & "z" & Chr(34) & ":{"
        If NumericUpDownZMax.Value <> 0 Then
            StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownZMax.Value & ","
        End If
        If NumericUpDownZMin.Value <> 0 Then
            StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownZMin.Value & ","
        End If
        StrResult &= "}"
        StrResult &= "}"
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ButtonTarget.Tag = StrResult
        Hide()
        ButtonTarget.Parent.Hide()
        ButtonTarget.Parent.Show()
    End Sub
End Class