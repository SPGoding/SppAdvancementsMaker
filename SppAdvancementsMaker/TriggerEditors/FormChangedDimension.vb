Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormChangedDimension
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim StrTemp As String
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.Item("from") IsNot Nothing Then
            StrTemp = ObjJson.Item("from").ToString
            ComboBoxFrom.Text = EnToZh(StrTemp, ZhDimensions, EnDimensions)
        Else
            ComboBoxFrom.Text = ""
        End If
        If ObjJson.Item("to") IsNot Nothing Then
            StrTemp = ObjJson.Item("to").ToString
            ComboBoxTo.Text = EnToZh(StrTemp, ZhDimensions, EnDimensions)
        Else
            ComboBoxTo.Text = ""
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject("{}"), JObject)
        Dim StrResult As String
        If ComboBoxFrom.Text <> "" Then
            ObjJson.Add("from", ZhToEn(ComboBoxFrom.Text, ZhDimensions, EnDimensions))
        End If
        If ComboBoxTo.Text <> "" Then
            ObjJson.Add("to", ZhToEn(ComboBoxTo.Text, ZhDimensions, EnDimensions))
        End If
        StrResult = ObjJson.ToString
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub FormChangedDimension_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        ComboBoxFrom.Items.Add("")
        ComboBoxTo.Items.Add("")
        For i = 0 To UBound(ZhDimensions)
            ComboBoxFrom.Items.Add(ZhDimensions(i))
            ComboBoxTo.Items.Add(ZhDimensions(i))
        Next
    End Sub
End Class