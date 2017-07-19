Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormEnterBlock
    Dim StrStates(5) As String
    Public Sub Reading(StrJson As String)
        On Error Resume Next
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        ' 读取方块
        If ObjJson.Item("block") IsNot Nothing Then
            ComboBoxBlock.Tag = ObjJson.Item("block").ToString
            ComboBoxBlock.Text = EnToZh(ComboBoxBlock.Tag, ZhBlocks, EnBlocks)
        Else
            ComboBoxBlock.Tag = ""
            ComboBoxBlock.Text = ""
        End If
        ' 读取状态
        TextBoxStateName1.Text = ""
        TextBoxStateValue1.Text = ""
        TextBoxStateName2.Text = ""
        TextBoxStateValue2.Text = ""
        TextBoxStateName3.Text = ""
        TextBoxStateValue3.Text = ""
        TextBoxStateName4.Text = ""
        TextBoxStateValue4.Text = ""
        TextBoxStateName5.Text = ""
        TextBoxStateValue5.Text = ""
        TextBoxStateName6.Text = ""
        TextBoxStateValue6.Text = ""
        If ObjJson.Item("state") IsNot Nothing Then
            StrStates = ObjJson.Item("state").ToString.Split(",")
            ReDim Preserve StrStates(5)
            If StrStates IsNot Nothing Then
                If StrStates(0) IsNot Nothing Then
                    TextBoxStateName1.Text = StrStates(0).Split(":")(0).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                    TextBoxStateValue1.Text = StrStates(0).Split(":")(1).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                End If
                If StrStates(1) IsNot Nothing Then
                    TextBoxStateName2.Text = StrStates(1).Split(":")(0).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                    TextBoxStateValue2.Text = StrStates(1).Split(":")(1).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                End If
                If StrStates(2) IsNot Nothing Then
                    TextBoxStateName3.Text = StrStates(2).Split(":")(0).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                    TextBoxStateValue3.Text = StrStates(2).Split(":")(1).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                End If
                If StrStates(3) IsNot Nothing Then
                    TextBoxStateName4.Text = StrStates(3).Split(":")(0).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                    TextBoxStateValue4.Text = StrStates(3).Split(":")(1).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                End If
                If StrStates(4) IsNot Nothing Then
                    TextBoxStateName5.Text = StrStates(4).Split(":")(0).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                    TextBoxStateValue5.Text = StrStates(4).Split(":")(1).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                End If
                If StrStates(5) IsNot Nothing Then
                    TextBoxStateName6.Text = StrStates(5).Split(":")(0).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                    TextBoxStateValue6.Text = StrStates(5).Split(":")(1).Replace(" ", "").Replace("{", "").Replace("}", "").Replace(Chr(34), "")
                End If
            End If
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If ComboBoxBlock.Tag <> "" Then
            StrResult &= Chr(34) & "block" & Chr(34) & ":" & Chr(34) & ComboBoxBlock.Tag & Chr(34) & ","
        End If
        If (TextBoxStateName1.Text <> "" And TextBoxStateValue1.Text <> "") Or (TextBoxStateName2.Text <> "" And TextBoxStateValue2.Text <> "") Or (TextBoxStateName3.Text <> "" And TextBoxStateValue3.Text <> "") Or (TextBoxStateName4.Text <> "" And TextBoxStateValue4.Text <> "") Or (TextBoxStateName5.Text <> "" And TextBoxStateValue5.Text <> "") Or (TextBoxStateName6.Text <> "" And TextBoxStateValue6.Text <> "") Then
            StrResult &= Chr(34) & "state" & Chr(34) & ":" & "{"
            If TextBoxStateName1.Text <> "" And TextBoxStateValue1.Text <> "" Then
                StrResult &= Chr(34) & TextBoxStateName1.Text & Chr(34) & ":" & Chr(34) & TextBoxStateValue1.Text & Chr(34) & ","
            End If
            If TextBoxStateName2.Text <> "" And TextBoxStateValue2.Text <> "" Then
                StrResult &= Chr(34) & TextBoxStateName2.Text & Chr(34) & ":" & Chr(34) & TextBoxStateValue2.Text & Chr(34) & ","
            End If
            If TextBoxStateName3.Text <> "" And TextBoxStateValue3.Text <> "" Then
                StrResult &= Chr(34) & TextBoxStateName3.Text & Chr(34) & ":" & Chr(34) & TextBoxStateValue3.Text & Chr(34) & ","
            End If
            If TextBoxStateName4.Text <> "" And TextBoxStateValue4.Text <> "" Then
                StrResult &= Chr(34) & TextBoxStateName4.Text & Chr(34) & ":" & Chr(34) & TextBoxStateValue4.Text & Chr(34) & ","
            End If
            If TextBoxStateName5.Text <> "" And TextBoxStateValue5.Text <> "" Then
                StrResult &= Chr(34) & TextBoxStateName5.Text & Chr(34) & ":" & Chr(34) & TextBoxStateValue5.Text & Chr(34) & ","
            End If
            If TextBoxStateName6.Text <> "" And TextBoxStateValue6.Text <> "" Then
                StrResult &= Chr(34) & TextBoxStateName6.Text & Chr(34) & ":" & Chr(34) & TextBoxStateValue6.Text & Chr(34) & ","
            End If
        End If
        StrResult &= "}"
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ' 将处理后的 Json 文本返回条件窗体
        FormCriteria.ButtonCriteria.Tag = StrResult
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub ComboBoxBlock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBlock.SelectedIndexChanged
        ComboBoxBlock.Tag = ZhToEn(ComboBoxBlock.Text, ZhBlocks, EnBlocks)
    End Sub

    Private Sub OpenWiki(sender As Object, e As EventArgs) Handles Label5.Click
        System.Diagnostics.Process.Start("http://minecraft-zh.gamepedia.com/%E6%96%B9%E5%9D%97%E7%8A%B6%E6%80%81")
    End Sub

    Private Sub FormEnterBlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16
        ComboBoxBlock.Items.Add("")
        For i = 0 To UBound(ZhBlocks)
            ComboBoxBlock.Items.Add(ZhBlocks(i))
        Next
    End Sub
End Class