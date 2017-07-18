Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormInventoryChanged
    Private IntItems As Int16
    Private OldSelectedIndex As Int32 = -1
    Private StrEachItemJson(127) As String

    Public Sub Reading(StrJson As String)
        ' 显示本窗体
        Visible = False
        Show(FormCriteria)
        ' 读取传送过来的 Json 文本
        Dim i As Int16
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrJson), JObject)
        IntItems = 0
        OldSelectedIndex = -1
        ReDim StrEachItemJson(127)
        ListBoxItems.Items.Clear()
        NumericUpDownEmptyMax.Value = 0
        NumericUpDownEmptyMin.Value = 0
        NumericUpDownFullMax.Value = 0
        NumericUpDownFullMin.Value = 0
        NumericUpDownOccupiedMax.Value = 0
        NumericUpDownOccupiedMin.Value = 0
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("items") IsNot Nothing Then
                For i = 0 To ObjJson.Item("items").Count - 1
                    ListBoxItems.Items.Add("物品" & IntItems)
                    IntItems += 1
                Next
                ListBoxItems.SelectedIndex = ListBoxItems.Items.Count - 1
            End If
            If ObjJson.Item("empty") IsNot Nothing Then
                If ObjJson.Item("empty").Item("max") IsNot Nothing Then
                    NumericUpDownEmptyMax.Value = ObjJson.Item("empty").Item("max").ToString
                End If
                If ObjJson.Item("empty").Item("min") IsNot Nothing Then
                    NumericUpDownEmptyMin.Value = ObjJson.Item("empty").Item("min").ToString
                End If
            End If
            If ObjJson.Item("full") IsNot Nothing Then
                If ObjJson.Item("full").Item("max") IsNot Nothing Then
                    NumericUpDownFullMax.Value = ObjJson.Item("full").Item("max").ToString
                End If
                If ObjJson.Item("full").Item("min") IsNot Nothing Then
                    NumericUpDownFullMin.Value = ObjJson.Item("full").Item("min").ToString
                End If
            End If
            If ObjJson.Item("occupied") IsNot Nothing Then
                If ObjJson.Item("occupied").Item("max") IsNot Nothing Then
                    NumericUpDownOccupiedMax.Value = ObjJson.Item("occupied").Item("max").ToString
                End If
                If ObjJson.Item("occupied").Item("min") IsNot Nothing Then
                    NumericUpDownOccupiedMin.Value = ObjJson.Item("occupied").Item("min").ToString
                End If
            End If
        End If
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim i As Int16
        Dim StrResult As String
        ' 先保存
        SaveCurrentEffect(OldSelectedIndex)
        StrResult = "{"
        If ListBoxItems.Items.Count >= 1 Then
            StrResult &= Chr(34) & "items" & Chr(34) & ":" & "["
            For i = 0 To ListBoxItems.Items.Count - 1
                StrResult &= StrEachItemJson(i) & ","
            Next
            StrResult &= "],"
        End If
        If NumericUpDownEmptyMax.Value <> 0 Or NumericUpDownEmptyMin.Value <> 0 Then
            StrResult &= Chr(34) & "empty" & Chr(34) & ":" & "{"
            If NumericUpDownEmptyMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownEmptyMax.Value & ","
            End If
            If NumericUpDownEmptyMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownEmptyMin.Value
            End If
            StrResult &= "},"
        End If
        If NumericUpDownFullMax.Value <> 0 Or NumericUpDownFullMin.Value <> 0 Then
            StrResult &= Chr(34) & "full" & Chr(34) & ":" & "{"
            If NumericUpDownFullMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownFullMax.Value & ","
            End If
            If NumericUpDownFullMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownFullMin.Value
            End If
            StrResult &= "},"
        End If
        If NumericUpDownOccupiedMax.Value <> 0 Or NumericUpDownOccupiedMin.Value <> 0 Then
            StrResult &= Chr(34) & "occupied" & Chr(34) & ":" & "{"
            If NumericUpDownOccupiedMax.Value <> 0 Then
                StrResult &= Chr(34) & "max" & Chr(34) & ":" & NumericUpDownOccupiedMax.Value & ","
            End If
            If NumericUpDownOccupiedMin.Value <> 0 Then
                StrResult &= Chr(34) & "min" & Chr(34) & ":" & NumericUpDownOccupiedMin.Value
            End If
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
        ButtonItem.Enabled = True
        ListBoxItems.SelectedIndex = ListBoxItems.Items.Add("物品" & IntItems)
        IntItems += 1
        ButtonItem.Tag = "{}"
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        StrEachItemJson(Microsoft.VisualBasic.Right(ListBoxItems.SelectedItem.ToString, ListBoxItems.SelectedItem.ToString.Length - 2)) = ""
        ListBoxItems.Items.RemoveAt(ListBoxItems.SelectedIndex)
    End Sub

    Private Sub ListBoxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxItems.SelectedIndexChanged
        ' 保存旧的物品
        SaveCurrentEffect(OldSelectedIndex)
        If ListBoxItems.SelectedIndex >= 0 Then
            OldSelectedIndex = Microsoft.VisualBasic.Right(ListBoxItems.SelectedItem.ToString, ListBoxItems.SelectedItem.ToString.Length - 2)
            ButtonDel.Enabled = True
        End If
        ' 读取新选中的编辑
        Dim ObjJson As JObject
        If ListBoxItems.SelectedIndex >= 0 Then
            If StrEachItemJson(Microsoft.VisualBasic.Right(ListBoxItems.SelectedItem.ToString, ListBoxItems.SelectedItem.ToString.Length - 2)) <> "" Then
                ObjJson = CType(JsonConvert.DeserializeObject(StrEachItemJson(Microsoft.VisualBasic.Right(ListBoxItems.SelectedItem.ToString, ListBoxItems.SelectedItem.ToString.Length - 2))), JObject)
                If ObjJson.ToString <> "{}" Then
                    ButtonItem.Tag = ObjJson.ToString
                Else
                    ButtonItem.Tag = "{}"
                End If
            End If
        End If
    End Sub

    Private Sub SaveCurrentEffect(OldSelectedIndex As Int32)
        ' 保存当前的编辑
        If OldSelectedIndex >= 0 Then
            Dim StrResult As String = ButtonItem.Tag
            StrResult = StrResult.Replace(",}", "}")
            StrResult = StrResult.Replace(",]", "]")
            StrEachItemJson(OldSelectedIndex) = StrResult
        End If
    End Sub

    Private Sub ButtonItem_Click(sender As Object, e As EventArgs) Handles ButtonItem.Click
        FormGlobalItem.Reading(ButtonItem, {"N/A"})
    End Sub
End Class