Public Class FormJsonTexts
    Public Sub Reset()
        ComboBoxColor.Text = "白色"
        ComboBoxColor.Tag = "white"
        TextBoxText.Text = ""
        CheckBoxBold.Checked = False
        CheckBoxItalic.Checked = False
        CheckBoxObfuscated.Checked = False
        CheckBoxStrikethrough.Checked = False
        CheckBoxUnderline.Checked = False
    End Sub

    Private Sub ComboBoxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxColor.SelectedIndexChanged
        With ComboBoxColor
            Select Case .Text
                Case "白色"
                    .Tag = "white"
                Case "黑色"
                    .Tag = "black"
                Case "金色"
                    .Tag = "gold"
                Case "黄色"
                    .Tag = "yelow"
                Case "浅湖蓝色"
                    .Tag = "aqua"
                Case "深湖蓝色"
                    .Tag = "dark_aqua"
                Case "浅蓝色"
                    .Tag = "blue"
                Case "深蓝色"
                    .Tag = "dark_blue"
                Case "浅绿色"
                    .Tag = "green"
                Case "深绿色“
                    .Tag = "dark_green"
                Case "亮红色"
                    .Tag = "red"
                Case "深红色"
                    .Tag = "dark_red"
                Case "亮紫色"
                    .Tag = "light_purple"
                Case "深紫色"
                    .Tag = "dark_purple"
                Case "浅灰色"
                    .Tag = "gray"
                Case "深灰色"
                    .Tag = "dark_gray"
            End Select
        End With
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String = ""
        StrResult &= "{"
        StrResult &= Chr(34) & "text" & Chr(34) & ":" & Chr(34) & TextBoxText.Text & Chr(34) & ","
        StrResult &= """color"":""" & ComboBoxColor.Tag & ""","
        StrResult &= """bold"":" & CheckBoxBold.Checked.ToString.ToLower & ","
        StrResult &= """underline"":" & CheckBoxUnderline.Checked.ToString.ToLower & ","
        StrResult &= """italic"":" & CheckBoxItalic.Checked.ToString.ToLower & ","
        StrResult &= """strikethrough"":" & CheckBoxStrikethrough.Checked.ToString.ToLower & ","
        StrResult &= """obfuscated"":" & CheckBoxObfuscated.Checked.ToString.ToLower
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        Select Case Tag
            Case "Title"
                FormMain.TextBoxTitle.Text = StrResult
            Case "Description"
                FormMain.TextBoxDescription.Text = StrResult
        End Select
        Hide()
    End Sub
End Class