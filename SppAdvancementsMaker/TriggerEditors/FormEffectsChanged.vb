Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormEffectsChanged
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
        ComboBoxEffectName.Tag = ""
        NumericUpDownAmplifierMax.Value = 0
        NumericUpDownAmplifierMin.Value = 0
        NumericUpDownDurationMax.Value = 0
        NumericUpDownDurationMin.Value = 0
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("effects") IsNot Nothing Then
                For i = 0 To ObjJson.Item("effects").Count - 1
                    ListBoxEffects.Items.Add("效果" & IntEffects)
                    IntEffects += 1
                    Dim StrTemp As String = Mid(ObjJson.Item("effects").ToString, 2, ObjJson.Item("effects").ToString.Length - 2).Replace(vbNewLine, "").Replace(" ", "")
                    Dim StrTemps(ObjJson.Item("effects").Count - 1) As String
                    StrTemps = Split(StrTemp, "}," & Chr(34) & "minecraft:")
                    If i <> 0 Then
                        StrEachEffectJson(i) = Chr(34) & "minecraft:"
                    Else
                        StrEachEffectJson(i) = ""
                    End If
                    If i < ObjJson.Item("effects").Count - 1 Then
                        StrEachEffectJson(i) &= StrTemps(i) & "}"
                    Else
                        StrEachEffectJson(i) &= StrTemps(i)
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
        StrResult = "{"
        If ListBoxEffects.Items.Count >= 1 Then
            StrResult &= Chr(34) & "effects" & Chr(34) & ":" & "{"
            For i = 0 To ListBoxEffects.Items.Count - 1
                StrResult &= StrEachEffectJson(i) & ","
            Next
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

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ComboBoxEffectName.Enabled = True
        NumericUpDownAmplifierMax.Enabled = True
        NumericUpDownAmplifierMin.Enabled = True
        NumericUpDownDurationMax.Enabled = True
        NumericUpDownDurationMin.Enabled = True
        ListBoxEffects.SelectedIndex = ListBoxEffects.Items.Add("效果" & IntEffects)
        ComboBoxEffectName.Text = ""
        ComboBoxEffectName.Tag = ""
        NumericUpDownAmplifierMax.Value = 0
        NumericUpDownAmplifierMin.Value = 0
        NumericUpDownDurationMax.Value = 0
        NumericUpDownDurationMin.Value = 0
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
                    ComboBoxEffectName.Tag = StrTemp
                    ComboBoxEffectName.Text = EnToZh(ComboBoxEffectName.Tag, ZhEffects, EnEffects)
                    If ObjJson.Item(ComboBoxEffectName.Tag) IsNot Nothing Then
                        If ObjJson.Item(ComboBoxEffectName.Tag).Item("amplifier") IsNot Nothing Then
                            If ObjJson.Item(ComboBoxEffectName.Tag).Item("amplifier").Item("min") IsNot Nothing Then
                                NumericUpDownAmplifierMin.Value = ObjJson.Item(ComboBoxEffectName.Tag).Item("amplifier").Item("min").ToString
                            Else
                                NumericUpDownAmplifierMin.Value = 0
                            End If
                            If ObjJson.Item(ComboBoxEffectName.Tag).Item("amplifier").Item("max") IsNot Nothing Then
                                NumericUpDownAmplifierMax.Value = ObjJson.Item(ComboBoxEffectName.Tag).Item("amplifier").Item("max").ToString
                            Else
                                NumericUpDownAmplifierMax.Value = 0
                            End If
                        Else
                            NumericUpDownAmplifierMax.Value = 0
                            NumericUpDownAmplifierMin.Value = 0
                        End If
                        If ObjJson.Item(ComboBoxEffectName.Tag).Item("duration") IsNot Nothing Then
                            If ObjJson.Item(ComboBoxEffectName.Tag).Item("duration").Item("min") IsNot Nothing Then
                                NumericUpDownDurationMin.Value = ObjJson.Item(ComboBoxEffectName.Tag).Item("duration").Item("min").ToString
                            Else
                                NumericUpDownDurationMin.Value = 0
                            End If
                            If ObjJson.Item(ComboBoxEffectName.Tag).Item("duration").Item("max") IsNot Nothing Then
                                NumericUpDownDurationMax.Value = ObjJson.Item(ComboBoxEffectName.Tag).Item("duration").Item("max").ToString
                            Else
                                NumericUpDownDurationMax.Value = 0
                            End If
                        Else
                            NumericUpDownDurationMax.Value = 0
                            NumericUpDownDurationMin.Value = 0
                        End If
                    Else
                        ComboBoxEffectName.Text = ""
                        ComboBoxEffectName.Tag = ""
                        NumericUpDownAmplifierMax.Value = 0
                        NumericUpDownAmplifierMin.Value = 0
                        NumericUpDownDurationMax.Value = 0
                        NumericUpDownDurationMin.Value = 0
                    End If
                Else
                    ComboBoxEffectName.Text = ""
                    ComboBoxEffectName.Tag = ""
                    NumericUpDownAmplifierMax.Value = 0
                    NumericUpDownAmplifierMin.Value = 0
                    NumericUpDownDurationMax.Value = 0
                    NumericUpDownDurationMin.Value = 0
                End If
            End If
        End If
    End Sub

    Private Sub SaveCurrentEffect(OldSelectedIndex As Int32)
        ' 保存当前的编辑
        If OldSelectedIndex >= 0 Then
            Dim StrResult As String = Chr(34) & ComboBoxEffectName.Tag & Chr(34) & ":" & "{"
            StrResult &= Chr(34) & "amplifier" & Chr(34) & ":{"
            If NumericUpDownAmplifierMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownAmplifierMin.Value & ","
            End If
            If NumericUpDownAmplifierMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownAmplifierMax.Value
            End If
            StrResult &= "},"
            StrResult &= Chr(34) & "duration" & Chr(34) & ":{"
            If NumericUpDownDurationMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownDurationMin.Value & ","
            End If
            If NumericUpDownDurationMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownDurationMax.Value
            End If
            StrResult &= "}}"
            StrResult = StrResult.Replace(",}", "}")
            StrResult = StrResult.Replace(",]", "]")
            StrEachEffectJson(OldSelectedIndex) = StrResult
        End If
    End Sub

    Private Sub ComboBoxEffectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEffectName.SelectedIndexChanged
        ComboBoxEffectName.Tag = ZhToEn(ComboBoxEffectName.Text, ZhEffects, EnEffects)
    End Sub

    Private Sub FormEffectsChanged_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        ComboBoxEffectName.Items.Add("")
        For i = 0 To UBound(ZhEffects)
            ComboBoxEffectName.Items.Add(ZhEffects(i))
        Next
    End Sub
End Class