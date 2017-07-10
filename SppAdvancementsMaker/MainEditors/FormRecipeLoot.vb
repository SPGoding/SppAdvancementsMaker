Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormRecipeLoot
    Private IntRewardType As Int16

    Public Sub Reading(StrJson As String, IntRewardType As Int16)
        ' 显示本窗体
        Visible = False
        Show(FormMain)
        ' 初始化
        Dim i As Int16
        Me.IntRewardType = IntRewardType
        ListBox1.Items.Clear()
        Select Case IntRewardType
            Case RewardType.Recipe
                Label1.Text = "配方列表(多选, 已选中0个)"
                For i = 0 To UBound(ZhRecipes)
                    ListBox1.Items.Add(ZhRecipes(i))
                Next
            Case RewardType.Loot
                Label1.Text = "战利品列表(多选, 已选中0个)"
                ' 读取存档中已有战利品表到ListBox
                GetLootTablesInSave()
                For i = 0 To UBound(ZhLootTables)
                    ' 读取原版战利品表
                    ListBox1.Items.Add(ZhLootTables(i))
                Next
        End Select
        ' 读取传送过来的 Json 文本
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JArray)
        If ObjJson.ToString <> "[]" Then
            For i = 0 To ObjJson.Count - 1
                Select Case IntRewardType
                    Case RewardType.Recipe
                        ListBox1.SelectedItem = EnToZh(ObjJson.Item(i).ToString(), ZhRecipes, EnRecipes)
                    Case RewardType.Loot
                        ListBox1.SelectedItem = EnToZh(ObjJson.Item(i).ToString(), ZhLootTables, EnLootTables)
                End Select
            Next
        End If
    End Sub
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim i As Int16
        Dim StrResult As String
        StrResult = "["
        For i = 0 To ListBox1.SelectedItems.Count - 1
            If ListBox1.SelectedItems.Item(i).ToString <> "" Then
                Select Case IntRewardType
                    Case RewardType.Recipe
                        StrResult &= Chr(34) & ZhToEn(ListBox1.SelectedItems.Item(i), ZhRecipes, EnRecipes) & Chr(34) & ","
                    Case RewardType.Loot
                        StrResult &= Chr(34) & ZhToEn(ListBox1.SelectedItems.Item(i), ZhLootTables, EnLootTables) & Chr(34) & ","
                End Select
            End If
        Next
        StrResult &= "]"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ' 将处理后的 Json 文本返回条件窗体
        Select Case IntRewardType
            Case RewardType.Recipe
                FormMain.ButtonRecipes.Tag = StrResult
            Case RewardType.Loot
                FormMain.ButtonLoot.Tag = StrResult
        End Select
        Hide()
        FormMain.Hide()
        FormMain.Show()
    End Sub

    Private Sub GetLootTablesInSave()
        Dim StrFileNames As String()
        Dim StrTempPath As String = StrSavePath & "\data\loot_tables"
        ' 获取存档目录下所有战利品表
        StrFileNames = IO.Directory.GetFileSystemEntries(StrTempPath, "*.json", System.IO.SearchOption.AllDirectories)
        ' 格式化路径
        For Each StrFileName As String In StrFileNames
            ' 把前面一大串删掉
            StrFileName = StrFileName.Replace(StrTempPath & "\", "")
            ' 换斜杠
            StrFileName = StrFileName.Replace("\", "/")
            ' 改冒号
            If StrFileName.IndexOf("/") <> -1 Then
                StrFileName = Microsoft.VisualBasic.Left(StrFileName, StrFileName.IndexOf("/")) & ":" & Microsoft.VisualBasic.Right(StrFileName, StrFileName.Length - StrFileName.IndexOf("/") - 1)
            End If
            ' 去.json
            StrFileName = Microsoft.VisualBasic.Left(StrFileName, StrFileName.Length - 5)
            ListBox1.Items.Add(StrFileName)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case IntRewardType
            Case RewardType.Recipe
                Label1.Text = "配方列表(多选, 已选中" & ListBox1.SelectedItems.Count & "个)"
            Case RewardType.Loot
                Label1.Text = "战利品列表(多选, 已选中" & ListBox1.SelectedItems.Count & "个)"
        End Select
    End Sub
End Class