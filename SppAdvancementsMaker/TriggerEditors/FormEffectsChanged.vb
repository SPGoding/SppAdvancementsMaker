Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormEffectsChanged
    ' 状态效果ZhToEn
    ' http://minecraft-zh.gamepedia.com/%E6%95%B0%E6%8D%AE%E5%80%BC#.E7.8A.B6.E6.80.81.E6.95.88.E6.9E.9C
    Private IntEffects As Int16
    Private OldSelectedIndex As Int32 = -1
    Private StrEachEffectJson(127) As String

    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim i As Int16
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        IntEffects = 0
        OldSelectedIndex = -1
        ReDim StrEachEffectJson(127)
        ListBoxEffects.Items.Clear()
        ComboBoxEffectName.Text = ""
        NumericUpDownAmplifier.Value = 0
        NumericUpDownMax.Value = 0
        NumericUpDownMin.Value = 0
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("effects").ToString <> "" Then
                For i = 0 To ObjJson.Item("effects").Count - 1
                    ListBoxEffects.Items.Add("效果" & IntEffects)
                    IntEffects += 1
                    Dim StrTemp(ObjJson.Item("effects").Count - 1) As String
                    StrTemp = Split(Mid(ObjJson.Item("effects").ToString, 2, ObjJson.Item("effects").ToString.Length - 2), "},")
                    StrTemp(i) = StrTemp(i).Replace(vbNewLine, "")
                    StrTemp(i) = StrTemp(i).Replace(" ", "")
                    If i < ObjJson.Item("effects").Count - 1 Then
                        StrEachEffectJson(i) = StrTemp(i) & "}"
                    Else
                        StrEachEffectJson(i) = StrTemp(i)
                    End If
                Next
                ListBoxEffects.SelectedIndex = ListBoxEffects.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim i As Int16
        Dim StrResult As String
        ' 先保存
        SaveCurrentEffect(OldSelectedIndex)
        StrResult = "{" & Chr(34) & "effects" & Chr(34) & ":" & "{"
        For i = 0 To ListBoxEffects.Items.Count - 1
            StrResult &= StrEachEffectJson(i) & ","
        Next
        StrResult &= "}}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ListBoxEffects.SelectedIndex = ListBoxEffects.Items.Add("效果" & IntEffects)
        ComboBoxEffectName.Text = ""
        NumericUpDownAmplifier.Value = 0
        NumericUpDownMax.Value = 0
        NumericUpDownMin.Value = 0
        IntEffects += 1
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        StrEachEffectJson(ListBoxEffects.SelectedIndex) = ""
        ListBoxEffects.Items.Remove(ListBoxEffects.SelectedItem)
    End Sub

    Private Sub ListBoxEffects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEffects.SelectedIndexChanged
        ' 保存旧的Effect
        SaveCurrentEffect(OldSelectedIndex)
        OldSelectedIndex = ListBoxEffects.SelectedIndex
        If ListBoxEffects.SelectedIndex >= 0 Then
            ButtonDel.Enabled = True
        End If
        ' 读取新选中的编辑
        Dim ObjJson As Object
        If ListBoxEffects.SelectedIndex >= 0 Then
            If StrEachEffectJson(ListBoxEffects.SelectedIndex) <> "" Then
                ObjJson = CType(JsonConvert.DeserializeObject("{" & StrEachEffectJson(ListBoxEffects.SelectedIndex) & "}"), JObject)
                If ObjJson.ToString <> "{}" Then
                    Dim StrTemp As String = StrEachEffectJson(ListBoxEffects.SelectedIndex)
                    StrTemp = Microsoft.VisualBasic.Left(StrTemp, StrTemp.IndexOf(":", 12))
                    StrTemp = StrTemp.Replace(Chr(34), "")
                    ComboBoxEffectName.Text = StrTemp
                    If ObjJson.Item(ComboBoxEffectName.Text) IsNot Nothing Then
                        If ObjJson.Item(ComboBoxEffectName.Text).Item("amplifier") IsNot Nothing Then
                            NumericUpDownAmplifier.Value = ObjJson.Item(ComboBoxEffectName.Text).Item("amplifier").ToString
                        Else
                            NumericUpDownAmplifier.Value = 0
                        End If
                        If ObjJson.Item(ComboBoxEffectName.Text).Item("duration") IsNot Nothing Then
                            If ObjJson.Item(ComboBoxEffectName.Text).Item("duration").Item("min") IsNot Nothing Then
                                NumericUpDownMin.Value = ObjJson.Item(ComboBoxEffectName.Text).Item("duration").Item("min").ToString
                            Else
                                NumericUpDownMin.Value = 0
                            End If
                            If ObjJson.Item(ComboBoxEffectName.Text).Item("duration").Item("max") IsNot Nothing Then
                                NumericUpDownMax.Value = ObjJson.Item(ComboBoxEffectName.Text).Item("duration").Item("max").ToString
                            Else
                                NumericUpDownMax.Value = 0
                            End If
                        End If
                    End If
                Else
                    ComboBoxEffectName.ResetText()
                    NumericUpDownAmplifier.Value = 0
                    NumericUpDownMax.Value = 0
                    NumericUpDownMin.Value = 0
                End If
            End If
        End If
    End Sub

    Private Sub SaveCurrentEffect(OldSelectedIndex As Int32)
        ' 保存当前的编辑
        If OldSelectedIndex >= 0 Then
            Dim StrResult As String = Chr(34) & ComboBoxEffectName.Text & Chr(34) & ":" & "{"
            If NumericUpDownAmplifier.Value <> 0 Then
                StrResult &= Chr(34) & "amplifier" & Chr(34) & ":" & NumericUpDownAmplifier.Value & ","
            End If
            StrResult &= Chr(34) & "duration" & Chr(34) & ":{"
            If NumericUpDownMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownMin.Value & ","
            End If
            If NumericUpDownMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownMax.Value
            End If
            StrResult &= "}}"
            StrResult = StrResult.Replace(",}", "}")
            StrResult = StrResult.Replace(",]", "]")
            StrEachEffectJson(OldSelectedIndex) = StrResult
        End If
    End Sub
End Class