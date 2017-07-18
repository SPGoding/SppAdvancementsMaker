Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormRecipeUnlocked
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim StrTemp As String
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("recipe") IsNot Nothing Then
                StrTemp = ObjJson.Item("recipe").ToString
                ComboBoxRecipes.Tag = StrTemp
                ComboBoxRecipes.Text = EnToZh(StrTemp, ZhRecipes, EnRecipes)
            End If
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject("{}"), JObject)
        Dim StrResult As String
        If ComboBoxRecipes.Text <> "" Then
            ObjJson.Add("recipe", ZhToEn(ComboBoxRecipes.Text, ZhRecipes, EnRecipes))
        End If
        StrResult = ObjJson.ToString
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub FormRecipeUnlocked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        ComboBoxRecipes.Items.Add("")
        For i = 0 To UBound(ZhRecipes)
            ComboBoxRecipes.Items.Add(ZhRecipes(i))
        Next
    End Sub
End Class