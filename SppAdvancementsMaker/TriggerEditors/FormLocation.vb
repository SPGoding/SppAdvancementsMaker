Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormLocation
    Public Sub Reading(StrJson As String)
        On Error Resume Next
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        Button1.Tag = ObjJson.ToString
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = Button1.Tag
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormGlobalLocation.Reading(Button1)
    End Sub
End Class