Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormJsonTextIDE
    Private ButtonTarget As Button

    Private Sub Reset()
        TextBoxText.Text = ""
    End Sub

    Public Sub Reading(ByRef ButtonTarget As Button)
        ' 显示本窗体
        Visible = False
        Show(FormMain)
        ' 读取传送过来的 Json 文本
        Reset()
        Me.ButtonTarget = ButtonTarget
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(ButtonTarget.Tag), JObject)
        TextBoxText.Text = ObjJson.ToString
    End Sub

    Private Sub Wirting(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Try
            Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(TextBoxText.Text), JObject)
            TextBoxText.Text = ObjJson.ToString
            TextBoxText.Text = TextBoxText.Text.Replace(",}", "}")
            ButtonTarget.Tag = TextBoxText.Text
            Hide()
            FormMain.Hide()
            FormMain.Show()
        Catch ex As Exception
            MessageBox.Show("Json文本不规范: " & ex.Message.Replace("line", "行数").Replace("position", "位置").Replace("Path", "字符"))
        End Try
    End Sub

    Private Sub ButtonThrow_Click(sender As Object, e As EventArgs) Handles ButtonThrow.Click
        Hide()
        FormJsonTexts.Reading(ButtonTarget, True)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(TextBoxText.Text), JObject)
            TextBoxText.Text = ObjJson.ToString
        Catch ex As Exception
            MessageBox.Show("Json文本不规范: " & ex.Message.Replace("line", "行数").Replace("position", "位置").Replace("Path", "字符"))
        End Try
    End Sub
End Class