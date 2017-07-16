Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormJsonTexts
    Private ButtonTarget As Button

    Private Sub FormJsonTexts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        For i = 0 To UBound(ZhJsonColors)
            ComboBoxColor.Items.Add(ZhJsonColors(i))
        Next
    End Sub

    Private Sub Reset()
        TextBoxText.Text = ""
        ComboBoxColor.SelectedIndex = 0
        CheckBoxBold.Checked = False
        CheckBoxItalic.Checked = False
        CheckBoxObfuscated.Checked = False
        CheckBoxStrikethrough.Checked = False
        CheckBoxUnderline.Checked = False
    End Sub

    Public Sub Reading(ByRef ButtonTarget As Button, Optional ByVal FromIDE As Boolean = False)
        ' 显示本窗体
        Visible = False
        Show(FormMain)
        ' 读取传送过来的 Json 文本
        Reset()
        Me.ButtonTarget = ButtonTarget
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(ButtonTarget.Tag), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("text") IsNot Nothing Then
                TextBoxText.Text = ObjJson.Item("text").ToString
            End If
            If ObjJson.Item("color") IsNot Nothing Then
                ComboBoxColor.Text = EnToZh(ObjJson.Item("color").ToString, ZhJsonColors, EnJsonColors)
            End If
            If ObjJson.Item("bold") IsNot Nothing Then
                CheckBoxBold.Checked = CBool(ObjJson.Item("bold").ToString)
            End If
            If ObjJson.Item("italic") IsNot Nothing Then
                CheckBoxItalic.Checked = CBool(ObjJson.Item("italic").ToString)
            End If
            If ObjJson.Item("obfuscated") IsNot Nothing Then
                CheckBoxObfuscated.Checked = CBool(ObjJson.Item("obfuscated").ToString)
            End If
            If ObjJson.Item("strikethrough") IsNot Nothing Then
                CheckBoxStrikethrough.Checked = CBool(ObjJson.Item("strikethrough").ToString)
            End If
            If ObjJson.Item("underlined") IsNot Nothing Then
                CheckBoxUnderline.Checked = CBool(ObjJson.Item("underlined").ToString)
            End If
            ' 有复杂的Json文本
            If ObjJson.Item("keybind") IsNot Nothing Or
               ObjJson.Item("extra") IsNot Nothing Or
               ObjJson.Item("clickEvent") IsNot Nothing Or
               ObjJson.Item("hoverEvent") IsNot Nothing Or
               ObjJson.Item("translate") IsNot Nothing Or
               ObjJson.Item("with") IsNot Nothing Or
               ObjJson.Item("score") IsNot Nothing Or
               ObjJson.Item("selector") IsNot Nothing Or
               ObjJson.Item("insertion") IsNot Nothing Then
                If Not FromIDE Then
                    Hide()
                    FormJsonTextIDE.Reading(ButtonTarget)
                End If
            End If
            End If
    End Sub

    Private Sub Wirting(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String = ""
        StrResult &= "{"
        StrResult &= Chr(34) & "text" & Chr(34) & ":" & Chr(34) & TextBoxText.Text & Chr(34) & ","
        StrResult &= """color"":""" & ZhToEn(ComboBoxColor.Text, ZhJsonColors, EnJsonColors) & ""","
        StrResult &= """bold"":" & CheckBoxBold.Checked.ToString.ToLower & ","
        StrResult &= """underline"":" & CheckBoxUnderline.Checked.ToString.ToLower & ","
        StrResult &= """italic"":" & CheckBoxItalic.Checked.ToString.ToLower & ","
        StrResult &= """strikethrough"":" & CheckBoxStrikethrough.Checked.ToString.ToLower & ","
        StrResult &= """obfuscated"":" & CheckBoxObfuscated.Checked.ToString.ToLower
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        ButtonTarget.Tag = StrResult
        Hide()
        FormMain.Hide()
        FormMain.Show()
    End Sub
End Class