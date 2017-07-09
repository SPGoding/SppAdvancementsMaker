Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormBrewedPotion
    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim StrTemp As String
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        If ObjJson.Item("potion") IsNot Nothing Then
            StrTemp = ObjJson.Item("potion").ToString
            ComboBoxPotion.Text = EnToZh(StrTemp, ZhPotions, EnPotions)
        Else
            ComboBoxPotion.Text = ""
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject("{}"), JObject)
        Dim StrResult As String
        If ComboBoxPotion.Text <> "" Then
            ObjJson.Add("potion", ZhToEn(ComboBoxPotion.Text, ZhPotions, EnPotions))
        End If
        StrResult = ObjJson.ToString
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub FormBrewedPotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        ComboBoxPotion.Items.Add("")
        For i = 0 To UBound(ZhPotions)
            ComboBoxPotion.Items.Add(ZhPotions(i))
        Next
    End Sub
End Class