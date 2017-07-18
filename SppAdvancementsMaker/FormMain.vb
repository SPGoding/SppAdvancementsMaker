Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormMain
    '条件列表 一些数据
    Private IntGroupCount As Int16 = 0
    Private IntCriteriaCount As Int32 = 0
    ' 窗体拖动
    Private bFormDragging As Boolean = False
    Private oPointClicked As Point
    Private Sub FormMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        bFormDragging = True
        oPointClicked = New Point(e.X, e.Y)
    End Sub
    Private Sub FormMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If bFormDragging Then
            Dim oMoveToPoint As Point
            ' 以当前鼠标位置为基础，找出目标位置
            oMoveToPoint = PointToScreen(New Point(e.X, e.Y))
            ' 根据开始位置作出调整
            oMoveToPoint.Offset(oPointClicked.X * -1, (oPointClicked.Y + SystemInformation.CaptionHeight + SystemInformation.BorderSize.Height) * -1)
            ' 移动窗体
            Location = oMoveToPoint
        End If
    End Sub
    Private Sub FormMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        bFormDragging = False
    End Sub

    ' 初始化界面
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBoxFrame.SelectedIndex = 0
        Dim i As Int16
        Dim j As Int16
        Dim IntTemp As Int16 = 0
        ' 背景图片
        ComboBoxBackground.Items.Add("")
        For i = 0 To UBound(ZhBackgrounds)
            ComboBoxBackground.Items.Add(ZhBackgrounds(i))
        Next
        ' 上一个进度
        ComboBoxParent.Items.Add("")
        GetAdvancementsInSave()
        For i = 0 To UBound(ZhAdvancements)
            If Not IsReplacedByUser(ZhAdvancements(i)) Then
                ComboBoxParent.Items.Add(ZhAdvancements(i))
            End If
        Next
        ' 物品ID
        '   加载方块
        For i = 0 To UBound(ZhBlocks)
            ComboBoxItem.Items.Add(ZhBlocks(i))
            ' 删掉技术性方块
            For j = 0 To UBound(EnTechnologhBlocks)
                If EnBlocks(i) = EnTechnologhBlocks(j) Then
                    ComboBoxItem.Items.RemoveAt(i - IntTemp)
                    IntTemp += 1
                End If
            Next
        Next
        '   加载物品
        For i = 0 To UBound(ZhItems)
            ComboBoxItem.Items.Add(ZhItems(i))
        Next
        ComboBoxItem.SelectedIndex = 0
    End Sub
    Private Sub GetAdvancementsInSave()
        Dim StrFileNames As String()
        Dim StrTempPath As String = StrSavePath & "\data\advancements"
        ' 获取存档目录下所有进度
        StrFileNames = IO.Directory.GetFileSystemEntries(StrTempPath, "*.json", System.IO.SearchOption.AllDirectories)
        ' 格式化路径
        For Each StrFileName As String In StrFileNames
            StrFileName = GetAdvancementName(StrFileName)
            ComboBoxParent.Items.Add(StrFileName)
        Next
    End Sub

    ' 读取
    Public Sub Reading(StrJson As String, BoolEditing As Boolean)
        Show()
        Reset(BoolEditing)
        Try
            StrJson = StrJson.Replace(vbNewLine, "").Replace("  ", "")
            Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
            If ObjJson IsNot Nothing And ObjJson.ToString <> "{}" Then
                If ObjJson.Item("display") IsNot Nothing Then
                    If ObjJson.Item("display").Item("icon") IsNot Nothing Then
                        If ObjJson.Item("display").Item("icon").Item("item") IsNot Nothing Then
                            ComboBoxItem.Text = EnToZh(ObjJson.Item("display").Item("icon").Item("item").ToString, ZhBlocks, EnBlocks)
                            ComboBoxItem.Text = EnToZh(ObjJson.Item("display").Item("icon").Item("item").ToString, ZhItems, EnItems)
                        End If
                        If ObjJson.Item("display").Item("icon").Item("data") IsNot Nothing Then
                            NumericUpDownData.Value = ObjJson.Item("display").Item("icon").Item("data").ToString
                        End If
                    End If
                    If ObjJson.Item("display").Item("title") IsNot Nothing Then
                        If Microsoft.VisualBasic.Left(ObjJson.Item("display").Item("title").ToString, 1) = "{" Then
                            ' 是Json文本
                            ButtonTitle.Tag = ObjJson.Item("display").Item("title").ToString
                        Else
                            ' 是普通文本
                            ButtonTitle.Tag = "{" & Chr(34) & "text" & Chr(34) & ":" & Chr(34) & ObjJson.Item("display").Item("title").ToString & Chr(34) & "}"
                        End If
                    End If
                    If ObjJson.Item("display").Item("frame") IsNot Nothing Then
                        ComboBoxFrame.Text = EnToZh(ObjJson.Item("display").Item("frame").ToString, ZhFrames, EnFrames)
                    End If
                    If ObjJson.Item("display").Item("background") IsNot Nothing Then
                        ComboBoxBackground.Text = EnToZh(ObjJson.Item("display").Item("background").ToString, ZhBackgrounds, EnBackgrounds)
                    End If
                    If ObjJson.Item("display").Item("description") IsNot Nothing Then
                        If Microsoft.VisualBasic.Left(ObjJson.Item("display").Item("description").ToString, 1) = "{" Then
                            ' 是Json文本
                            ButtonDescription.Tag = ObjJson.Item("display").Item("description").ToString
                        Else
                            ' 是普通文本
                            ButtonDescription.Tag = "{" & Chr(34) & "description" & Chr(34) & ":" & Chr(34) & ObjJson.Item("display").Item("description").ToString & Chr(34) & "}"
                        End If
                    End If
                    If ObjJson.Item("display").Item("show_toast") IsNot Nothing Then
                        CheckBoxShow_Toast.Checked = ObjJson.Item("display").Item("show_toast").ToString
                    End If
                    If ObjJson.Item("display").Item("announce_to_chat") IsNot Nothing Then
                        CheckBoxAnnounce_To_Chat.Checked = ObjJson.Item("display").Item("announce_to_chat").ToString
                    End If
                    If ObjJson.Item("display").Item("hidden") IsNot Nothing Then
                        CheckBoxHidden.Checked = ObjJson.Item("display").Item("hidden").ToString
                    End If
                End If
                If ObjJson.Item("parent") IsNot Nothing Then
                    ComboBoxParent.Text = EnToZh(ObjJson.Item("parent").ToString, ZhAdvancements, EnAdvancements)
                End If
                Dim HaveRequirements As Boolean
                If ObjJson.Item("requirements") IsNot Nothing Then
                    HaveRequirements = True
                    TreeViewCriterias.Tag = ObjJson.Item("requirements").ToString
                    For i As Int16 = 0 To ObjJson.Item("requirements").Count - 1
                        Dim NodeGroup As TreeNode
                        IntGroupCount += 1
                        NodeGroup = TreeViewCriterias.Nodes.Add("组" & IntGroupCount)
                        NodeGroup.Name = "组"
                        For j As Int16 = 0 To ObjJson.Item("requirements").Item(i).Count - 1
                            Dim NodeCriteria As TreeNode
                            NodeCriteria = NodeGroup.Nodes.Add(ObjJson.Item("requirements").Item(i).Item(j).ToString)
                            NodeCriteria.Name = "条"
                            IntCriteriaCount += 1
                        Next
                    Next
                    SaveGroupJson()
                End If
                If ObjJson.Item("criteria") IsNot Nothing Then
                    Dim StrTemp As String = ObjJson.Item("criteria").ToString
                    Dim ObjTempJson As JObject = CType(JsonConvert.DeserializeObject(StrTemp), JObject)
                    ' 遍历所有的条件
                    For Each ObjJP As JProperty In ObjTempJson.Children
                        ' 分离出当前条件的名称
                        ' Mid的起始位置是1, IndexOf的起始位置是0
                        ' 淦他妈的巨硬
                        Debug.Print(ObjJP.ToString)
                        Debug.Print(ObjJP.ToString.IndexOf(Chr(34)))
                        Debug.Print(ObjJP.ToString.IndexOf(Chr(34)))
                        Dim StrCritariaName As String = Mid(ObjJP.ToString, 2, ObjJP.ToString.IndexOf(Chr(34), 2) + 1 - 2)
                        If HaveRequirements Then
                            ' 循环找到各个条件的 Node ，并把 Json 写入
                            For Each Group As TreeNode In TreeViewCriterias.Nodes
                                For Each Criteria As TreeNode In Group.Nodes
                                    Criteria.Tag = ObjJP.ToString
                                Next
                            Next
                        Else
                            ' 为每个 Node 创建一个组
                            Dim Group As TreeNode = TreeViewCriterias.Nodes.Add("组" & IntGroupCount)
                            Dim Criteria As TreeNode = Group.Nodes.Add(StrCritariaName)
                            Criteria.Name = "条"
                            Criteria.Tag = ObjJP.ToString
                        End If
                    Next
                End If
                If ObjJson.Item("rewards") IsNot Nothing Then
                    If ObjJson.Item("rewards").Item("recipes") IsNot Nothing Then
                        ButtonRecipes.Tag = ObjJson.Item("rewards").Item("recipes").ToString
                    End If
                    If ObjJson.Item("rewards").Item("loot") IsNot Nothing Then
                        ButtonLoot.Tag = ObjJson.Item("rewards").Item("loot").ToString
                    End If
                    If ObjJson.Item("rewards").Item("experience") IsNot Nothing Then
                        NumericUpDownExperience.Value = ObjJson.Item("rewards").Item("experience").ToString
                    End If
                    ' 函数
                    If ObjJson.Item("rewards").Item("function") IsNot Nothing Then
                        TextBoxFunction.Text = File.ReadAllText(GetFunctionPath(ObjJson.Item("rewards").Item("function").ToString)).Replace("#Created By SppAdvancementsMaker" & vbNewLine, "")
                        TextBoxFunction.Tag = ObjJson.Item("rewards").Item("function").ToString
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("该进度加载不能: " & ex.Message)
        End Try
    End Sub
    Private Sub Reset(BoolEditing As Boolean)
        If BoolEditing Then
            TextBoxId.Text = StrEditingAdvancementName
            TextBoxId.ReadOnly = True
        Else
            StrEditingAdvancementName = "sppadvancementsmaker:newadvancement"
            TextBoxId.Text = StrEditingAdvancementName
            TextBoxId.ReadOnly = False
        End If
        ComboBoxItem.SelectedIndex = 0
        ComboBoxItem.Tag = ""
        NumericUpDownData.Value = 0
        ComboBoxBackground.SelectedIndex = 0
        ComboBoxBackground.Tag = ""
        ComboBoxParent.SelectedIndex = 0
        ButtonTitle.Tag = "{}"
        ButtonDescription.Tag = "{}"
        ComboBoxFrame.SelectedIndex = 0
        ComboBoxFrame.Tag = ""
        CheckBoxAnnounce_To_Chat.Checked = True
        CheckBoxHidden.Checked = False
        CheckBoxShow_Toast.Checked = True
        ButtonRecipes.Tag = "[]"
        ButtonLoot.Tag = "[]"
        NumericUpDownExperience.Value = 0
        TextBoxFunction.Text = ""
        TextBoxFunction.Tag = TextBoxId.Text
        TreeViewCriterias.Nodes.Clear()
        SaveGroupJson()
        IntGroupCount = 0
        IntCriteriaCount = 0
    End Sub

    ' 生成
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        Dim StrCriteria As String = ""
        Dim StrRewards As String = ""
        Dim i As Int16
        Dim j As Int16
        ' 把条件并列起来
        For i = 0 To TreeViewCriterias.GetNodeCount(False) - 1
            For j = 0 To TreeViewCriterias.Nodes.Item(i).GetNodeCount(False) - 1
                StrCriteria &= TreeViewCriterias.Nodes.Item(i).Nodes.Item(j).Tag
                StrCriteria &= ","
            Next
        Next
        Try
            ' 把奖励 rewards 并列起来
            If ButtonRecipes.Tag <> "[]" Then
                StrRewards &= Chr(34) & "recipes" & Chr(34) & ":" & ButtonRecipes.Tag & ","
            End If
            If ButtonLoot.Tag <> "[]" Then
                StrRewards &= Chr(34) & "loot" & Chr(34) & ":" & ButtonLoot.Tag & ","
            End If
            If NumericUpDownExperience.Value <> 0 Then
                StrRewards &= Chr(34) & "experience" & Chr(34) & ":" & NumericUpDownExperience.Value & ","
            End If
            If TextBoxFunction.Text <> "" Then
                Dim StrFunctionPath As String = GetFunctionPath(TextBoxFunction.Tag)
                CreateFile(StrFunctionPath, GetParentPath(StrFunctionPath), TextBoxFunction.Text)
                ' 把函数名写入 StrRewards
                StrRewards &= Chr(34) & "function" & Chr(34) & ":" & Chr(34) & TextBoxFunction.Tag & Chr(34)
            End If
            ' 调用函數
            ComboBoxFrame_SelectedIndexChanged()
            Dim StrResult As String = GenerateAdvancement(ComboBoxItem.Tag, NumericUpDownData.Value, ButtonTitle.Tag,
                                                     ComboBoxFrame.Tag,
                                                     ZhToEn(ComboBoxBackground.Text, ZhBackgrounds, EnBackgrounds),
                                                     ButtonDescription.Tag,
                                                     CheckBoxShow_Toast.Checked, CheckBoxAnnounce_To_Chat.Checked,
                                                     CheckBoxHidden.Checked,
                                                     ZhToEn(ComboBoxParent.Text, ZhAdvancements, EnAdvancements),
                                                     StrCriteria, TreeViewCriterias.Tag, StrRewards)
            ' 格式化 Json
            Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(StrResult), JObject)
            StrResult = ObjJson.ToString
            ' 将进度写入文件
            Dim StrAdvancementsPath As String = GetAdvancementPath(StrEditingAdvancementName)
            CreateFile(StrAdvancementsPath, GetParentPath(StrAdvancementsPath), StrResult)
            LabelResult.Text = "已生成"
            LabelResult.ForeColor = Color.Green
            LabelHelper.Visible = True
        Catch ex As Exception
            LabelResult.Text = "生成不能: " & ex.Message
            LabelResult.ForeColor = Color.Red
            LabelHelper.Visible = False
        End Try
    End Sub

    ' 生成临时tag
    ' 为函数加注释的 Sub 删除了， 并且在下一次读取进度后会自动清除注释
    ' 注释指的是 #Created By SppAdvancementsMaker 这条注释
    Private Sub ComboBoxFrame_SelectedIndexChanged() Handles ComboBoxFrame.SelectedIndexChanged
        ' 不恰当的方式
        ' 已经堵了各种漏洞
        Select Case ComboBoxFrame.SelectedIndex
            Case 0
                ComboBoxFrame.Tag = "task"
            Case 1
                ComboBoxFrame.Tag = "challenge"
            Case 2
                ComboBoxFrame.Tag = "goal"
        End Select
    End Sub
    Private Sub ComboBoxBackground_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBackground.SelectedIndexChanged
        Dim StrTemp As String = ZhToEn(ComboBoxBackground.Text, ZhBackgrounds, EnBackgrounds)
        If ComboBoxBackground.Text <> "" Then
            ComboBoxBackground.Tag = "minecraft:textures/blocks/" & StrTemp & ".png"
            ComboBoxParent.Enabled = False
        Else
            ComboBoxBackground.Tag = ""
            ComboBoxParent.Enabled = True
        End If
    End Sub
    Private Sub ComboBoxItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxItem.SelectedIndexChanged
        If ZhToEn(ComboBoxItem.Text, ZhBlocks, EnBlocks) <> ComboBoxItem.Text Then
            ComboBoxItem.Tag = ZhToEn(ComboBoxItem.Text, ZhBlocks, EnBlocks)
        Else
            ComboBoxItem.Tag = ZhToEn(ComboBoxItem.Text, ZhItems, EnItems)
        End If
    End Sub
    Private Sub TextBoxId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxId.TextChanged
        TextBoxFunction.Tag = TextBoxId.Text
        StrEditingAdvancementName = TextBoxId.Text
    End Sub

    ' Json文本
    Private Sub ButtonTitle_Click(sender As Object, e As EventArgs) Handles ButtonTitle.Click
        FormJsonTexts.Reading(ButtonTitle)
    End Sub
    Private Sub ButtonDescription_Click(sender As Object, e As EventArgs) Handles ButtonDescription.Click
        FormJsonTexts.Reading(ButtonDescription)
    End Sub

    '条件、分组相关
    Public Sub SaveGroupJson()
        '编辑分组的 Json
        '    不包含 requirements 层级的中括号
        Dim i As Int16
        Dim j As Int16
        Dim StrTemp As String = ""
        For i = 0 To TreeViewCriterias.GetNodeCount(False) - 1
            StrTemp &= "["
            For j = 0 To TreeViewCriterias.Nodes.Item(i).GetNodeCount(False) - 1
                If j <> TreeViewCriterias.Nodes.Item(i).GetNodeCount(False) - 1 Then
                    StrTemp &= Chr(34) & TreeViewCriterias.Nodes.Item(i).Nodes.Item(j).Text & Chr(34) & ","
                Else
                    StrTemp &= Chr(34) & TreeViewCriterias.Nodes.Item(i).Nodes.Item(j).Text & Chr(34)
                End If
            Next
            If i <> TreeViewCriterias.GetNodeCount(False) - 1 Then
                StrTemp &= "],"
            Else
                StrTemp &= "]"
            End If
        Next
        TreeViewCriterias.Tag = StrTemp
    End Sub
    Private Sub TreeViewCriterias_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewCriterias.NodeMouseDoubleClick
        If e.Node.Name = "条" Then
            FormCriteria.Visible = False
            FormCriteria.Show(Me)
            FormCriteria.Reading(e.Node.Text, e.Node.Tag, TreeViewCriterias.Tag.ToString) '告诉窗体: 所编辑的条件 Json 和分组 Group
        End If
    End Sub
    Private Sub ButtonAddGroup_Click(sender As Object, e As EventArgs) Handles ButtonAddGroup.Click
        Dim Node As TreeNode = TreeViewCriterias.Nodes.Add("组" & IntGroupCount)
        Node.Name = "组"
        SaveGroupJson()
        IntGroupCount += 1
    End Sub
    Private Sub ButtonAddCriteria_Click(sender As Object, e As EventArgs) Handles ButtonAddCriteria.Click
        Dim Node As TreeNode
        Select Case TreeViewCriterias.SelectedNode.Name
            Case "组"
                Node = TreeViewCriterias.SelectedNode.Nodes.Add("条件" & IntCriteriaCount)
                Node.Name = "条"
            Case Else
                Node = TreeViewCriterias.SelectedNode.Parent.Nodes.Add("条件" & IntCriteriaCount)
                Node.Name = "条"
        End Select
        ' 编辑条件的 Json
        '    不包含 criteria 层级的大括号
        Node.Tag = Chr(34) & Node.Text & Chr(34) & ":{"
        Node.Tag &= Chr(34) & "trigger" & Chr(34) & ":" & Chr(34) & "minecraft:bred_animals" & Chr(34) & ","
        Node.Tag &= Chr(34) & "conditions" & Chr(34) & ":{}"
        Node.Tag &= "}"
        SaveGroupJson()
        IntCriteriaCount += 1
    End Sub
    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Select Case TreeViewCriterias.SelectedNode.Name
            Case "条"
                TreeViewCriterias.Nodes.Remove(TreeViewCriterias.SelectedNode)
        End Select
        SaveGroupJson()
    End Sub
    Private Sub TreeViewCriterias_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewCriterias.AfterSelect
        Select Case e.Node.Name
            Case "组"
                ButtonAddCriteria.Enabled = True
                ButtonRemove.Enabled = False
            Case "条"
                ButtonAddCriteria.Enabled = True
                ButtonRemove.Enabled = True
        End Select
    End Sub

    ' 奖励相关
    Private Sub ButtonRecipes_Click(sender As Object, e As EventArgs) Handles ButtonRecipes.Click
        FormRecipeLoot.Reading(ButtonRecipes.Tag, RewardType.Recipe)
    End Sub
    Private Sub ButtonLoot_Click(sender As Object, e As EventArgs) Handles ButtonLoot.Click
        FormRecipeLoot.Reading(ButtonLoot.Tag, RewardType.Loot)
    End Sub
    Private Sub LabelHelper_Click(sender As Object, e As EventArgs) Handles LabelHelper.Click
        FormHelper.Reading()
    End Sub

    ' 细节
    Private Sub TextBoxId_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case ":", "?", "|", "*", Chr(34), "<", ">"
                e.KeyChar = ""
            Case "\"
                e.KeyChar = "/"
        End Select
    End Sub
    Private Function IsReplacedByUser(StrZh As String) As Boolean
        For i As Int16 = 0 To ComboBoxParent.Items.Count - 1
            If StrZh = ComboBoxParent.Items.Item(i).ToString Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
    Private Sub ComboBoxParent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxParent.SelectedIndexChanged
        If ComboBoxParent.Text <> "" Then
            ComboBoxBackground.Enabled = False
        Else
            ComboBoxBackground.Enabled = True
        End If
    End Sub
End Class