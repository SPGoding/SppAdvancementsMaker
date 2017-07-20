Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormMain
    '条件列表 一些数据
    Private IntGroupCount As Int16 = 0
    Private IntCriteriaCount As Int32 = 0
    Private BoolEditing As Boolean
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
    Private Sub Reset(BoolEditing As Boolean)
        ' 读取上一个进度ComboBox
        ComboBoxParent.Items.Clear()
        ComboBoxParent.Items.Add("")
        GetAdvancementsInSave()
        For i = 0 To UBound(ZhAdvancements)
            If Not IsReplacedByUser(ZhAdvancements(i)) Then
                ComboBoxParent.Items.Add(ZhAdvancements(i))
            End If
        Next
        ' 初始化其他
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
        LabelResult.Text = "等待生成..."
        LabelResult.ForeColor = Color.Black
        LabelHelper.Visible = False
        LabelOpenJson.Visible = False
        GroupBoxCommands.Visible = False
        CheckBoxOnlyCommand.Checked = False
    End Sub

    ' 读取
    Public Sub Reading(StrJson As String, BoolEditing As Boolean)
        Show()
        Me.BoolEditing = BoolEditing
        Reset(BoolEditing)
        Try
            StrJson = StrJson.Replace(vbNewLine, "").Replace("  ", "")
            Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(StrJson), JObject)
            If ObjJson IsNot Nothing And ObjJson.ToString <> "{}" Then
                If ObjJson.Item("display") IsNot Nothing Then
                    If ObjJson.Item("display").Item("icon") IsNot Nothing Then
                        If ObjJson.Item("display").Item("icon").Item("item") IsNot Nothing Then
                            ComboBoxItem.Text = EnToZh(ObjJson.Item("display").Item("icon").Item("item").ToString, ZhBlocks, EnBlocks)
                            If ComboBoxItem.Text = ObjJson.Item("display").Item("icon").Item("item").ToString Then
                                ComboBoxItem.Text = EnToZh(ObjJson.Item("display").Item("icon").Item("item").ToString, ZhItems, EnItems)
                            End If
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
                End If
                If ObjJson.Item("criteria") IsNot Nothing Then
                    Dim StrTemp As String = ObjJson.Item("criteria").ToString
                    Dim ObjTempJson As JObject = CType(JsonConvert.DeserializeObject(StrTemp), JObject)
                    ' 遍历所有的条件
                    For Each ObjJP As JProperty In ObjTempJson.Children
                        ' 分离出当前条件的名称
                        ' Mid的起始位置是1, IndexOf的起始位置是0
                        ' 淦他妈的巨硬
                        Dim StrCritariaName As String = Mid(ObjJP.ToString, 2, ObjJP.ToString.IndexOf(Chr(34), 2) + 1 - 2)
                        If HaveRequirements Then
                            ' 循环找到此条件的 Node ，并把 Json 写入
                            For Each Group As TreeNode In TreeViewCriterias.Nodes
                                For Each Criteria As TreeNode In Group.Nodes
                                    If Criteria.Text = StrCritariaName Then
                                        Criteria.Tag = ObjJP.ToString
                                    End If
                                Next
                            Next
                        Else
                            ' 为每个 Node 创建一个组
                            Dim NodeGroup As TreeNode = TreeViewCriterias.Nodes.Add("组" & IntGroupCount)
                            NodeGroup.Name = "组"
                            IntGroupCount += 1
                            Dim NodeCriteria As TreeNode = NodeGroup.Nodes.Add(StrCritariaName)
                            NodeCriteria.Name = "条"
                            NodeCriteria.Tag = ObjJP.ToString
                        End If
                    Next
                End If
                SaveGroupJson()
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

    ' 生成
    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        Dim StrCriteria As String = ""
        Dim StrRewards As String = ""
        Dim i As Int16
        Dim j As Int16
        If Not BoolEditing Then
            ' 不在编辑
            If File.Exists(GetAdvancementPath(StrEditingAdvancementName)) Then
                ' 内部ID重复
                Dim TempDialogResult As DialogResult = MessageBox.Show(Me, "内部ID为'" & StrEditingAdvancementName & "'的进度已经存在，是否覆盖？", "覆盖提示", MessageBoxButtons.YesNo)
                If TempDialogResult = DialogResult.No Then
                    Exit Sub
                End If
            End If
        End If
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
            ' UI
            LabelResult.Text = "已生成"
            LabelResult.ForeColor = Color.Green
            LabelHelper.Visible = True
            LabelOpenJson.Visible = True
            GroupBoxCommands.Visible = True
            TextBoxCommandGrant.Text = "/advancement grant @p only " & StrEditingAdvancementName
            TextBoxCommandRevoke.Text = "/advancement revoke @p only " & StrEditingAdvancementName
            ' 把当前进度改成正在编辑
            TextBoxId.Text = StrEditingAdvancementName
            TextBoxId.ReadOnly = True
            BoolEditing = True
        Catch ex As Exception
            LabelResult.Text = "生成不能: " & ex.Message
            LabelResult.ForeColor = Color.Red
            LabelHelper.Visible = False
            LabelOpenJson.Visible = False
            GroupBoxCommands.Visible = False
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
        Else
            ComboBoxBackground.Tag = ""
        End If
    End Sub
    Private Sub ComboBoxItem_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxItem.TextChanged
        If ZhToEn(ComboBoxItem.Text, ZhBlocks, EnBlocks) <> ComboBoxItem.Text Then
            ComboBoxItem.Tag = ZhToEn(ComboBoxItem.Text, ZhBlocks, EnBlocks)
        Else
            ComboBoxItem.Tag = ZhToEn(ComboBoxItem.Text, ZhItems, EnItems)
        End If
    End Sub
    Private Sub TextBoxId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxId.TextChanged
        Dim TempStart As Int16 = TextBoxId.SelectionStart
        TextBoxId.Text = TextBoxId.Text.ToLower
        TextBoxId.SelectionStart = TempStart
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
        If TreeViewCriterias.SelectedNode IsNot Nothing Then
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
        End If
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

    ' 细节
    Private Sub TextBoxId_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case "?", "|", "*", Chr(34), "<", ">"
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
    Private Sub ComboBoxBackground_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxBackground.TextChanged
        If ComboBoxBackground.Text <> "" Then
            ComboBoxParent.Enabled = False
        Else
            ComboBoxParent.Enabled = True
        End If
    End Sub
    Private Sub ComboBoxParent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxParent.SelectedIndexChanged
        If ComboBoxParent.Text <> "" Then
            ComboBoxBackground.Enabled = False
        Else
            ComboBoxBackground.Enabled = True
        End If
    End Sub
    Private Sub FormMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSelectAdvancement.Hide()
        FormSelectAdvancement.Show()
    End Sub
    Private Sub LabelHelper_Click(sender As Object, e As EventArgs) Handles LabelHelper.Click
        FormHelper.Reading()
    End Sub
    Private Sub LabelOpenJson_Click(sender As Object, e As EventArgs) Handles LabelOpenJson.Click
        If Directory.Exists(GetParentPath(StrEditingAdvancementName)) Then
            Process.Start(GetParentPath(StrEditingAdvancementName))
        End If
    End Sub

    'Private Sub ButtonCopyGrant_Click(sender As Object, e As EventArgs) Handles ButtonCopyGrant.Click
    '    Clipboard.Clear()
    '    Clipboard.SetText(TextBoxCommandGrant.Text)
    '    MessageBox.Show("已复制")
    'End Sub
    'Private Sub ButtonCopyRevoke_Click(sender As Object, e As EventArgs) Handles ButtonCopyRevoke.Click
    '    Clipboard.Clear()
    '    Clipboard.SetText(TextBoxCommandRevoke.Text)
    '    MessageBox.Show("已复制")
    'End Sub

    'Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    '    MessageBox.Show("内部ID用于让Minecraft识别这个进度，组成格式为'命名空间:进度名称'，" & vbNewLine &
    '                    "'命名空间'部分你可以用自己名字或是该进度所属进度树的名称(例如'story')" & vbNewLine &
    '                    "'进度名称'部分你可以用任何自己喜欢的名字命名，如果是根进度则建议使用root" & vbNewLine &
    '                    "'food:root'就是一个合格的内部ID" & vbNewLine &
    '                    "'进度名称'部分可以有多层嵌套，例如'food:animals/beef'、'food:animals/chicken'等")
    'End Sub
    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    '    MessageBox.Show("Minecraft的进度拥有一个图标，在这里选择的物品就将作为这个图标" & vbNewLine &
    '                    "在游戏中按 F3+H 后，把鼠标挥到物品上可以看到它的ID。利用这一点你可以在这里设置Mod物品作为图标")
    'End Sub
    'Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    '    MessageBox.Show("该值是给上一空的物品作补充用的，例如'地毯'等物品拥有多种颜色，这些颜色就是由该值决定的")
    'End Sub
    'Private Sub LabelBackground_Click(sender As Object, e As EventArgs) Handles LabelBackground.Click
    '    MessageBox.Show("在Minecraft的进度界面(默认按L打开)中不同页签有不同的背景，这些背景是由根进度(每页第一个进度)所设置的" & vbNewLine &
    '                    "如果设置了该值，将不能够设定'上一个进度'，因为根进度没有上一个进度")
    'End Sub
    'Private Sub LabelParent_Click(sender As Object, e As EventArgs) Handles LabelParent.Click
    '    MessageBox.Show("Minecraft不会知道你所制作的进度应该放到进度界面的哪个位置，设置该值就可以让Minecraft把你的进度固定连接在某个进度后面" & vbNewLine &
    '                    "如果设置了该值，将不能够设定'根进度图片'，因为有上一个进度的进度不是根进度")
    'End Sub
    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    '    MessageBox.Show("进度拥有三种边框: 普通进度、目标进度和挑战进度" & vbNewLine &
    '                    "该值决定进度使用哪种边框")
    'End Sub
    'Private Sub CheckBoxShow_Toast_DoubleClick(sender As Object, e As EventArgs) Handles CheckBoxShow_Toast.DoubleClick
    '    MessageBox.Show("该值决定进度完成后是否在右上角提示")
    'End Sub
    'Private Sub CheckBoxAnnounce_To_Chat_DoubleClick(sender As Object, e As EventArgs) Handles CheckBoxAnnounce_To_Chat.DoubleClick
    '    MessageBox.Show("该值决定进度在完成后是否在左下角的聊天栏广播" & vbNewLine &
    '                    "该值的优先级低于/gamerule announceAdvancements的设定")
    'End Sub
    'Private Sub CheckBoxHidden_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHidden.DoubleClick
    '    MessageBox.Show("该值使得进度在完成前不能在进度界面中查看到，完成后才会出现" & vbNewLine &
    '                    "该值对根进度(每页第一个进度)无效，但是会影响根进度后的所有子进度")
    'End Sub
    'Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
    '    MessageBox.Show("进度完成后，玩家将会解锁这些配方" & vbNewLine &
    '                    "这个奖励结合命令/gamerule doLimitedCrafting true (玩家需要解锁合成配方才能使用)效果出奇")
    'End Sub
    'Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
    '    MessageBox.Show("进度完成后，玩家将会获得这些战利品" & vbNewLine &
    '                    "如果你会制作战利品表，将战利品表放到当前存档的./data/loot_tables路径后软件会自动读取")
    'End Sub
    'Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
    '    MessageBox.Show("进度完成后，玩家将获得这些经验" & vbNewLine &
    '                    "事实上，这里可以设置为负值，但没有实际效果")
    'End Sub
    'Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
    '    MessageBox.Show("进度完成后，玩家将会执行以下这些命令，并忽略权限" & vbNewLine &
    '                    "请注意，实际上游戏并不能设置奖励命令，只是本软件为方便考虑，江这些命令自动写成函数")
    'End Sub
    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    '    MessageBox.Show("这里设置的是要完成该进度需要达成的条件，每一组各达成一个条件就可以完成进度" & vbNewLine &
    '                    "例如在'组0'内设置'杀死爬行者''杀死僵尸'两个条件，只要达成一个就会完成进度" & vbNewLine &
    '                    "但在'组0'设置'杀死爬行者'，'组1'设置'杀死僵尸'，就要求必须达成这两个条件才能完成进度")
    'End Sub

    Private Sub CheckBoxOnlyCommand_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOnlyCommand.CheckedChanged
        TreeViewCriterias.Nodes.Clear()
        Select Case CheckBoxOnlyCommand.Checked
            Case True
                TreeViewCriterias.Visible = False
                ButtonAddCriteria.Visible = False
                ButtonAddGroup.Visible = False
                ButtonRemove.Visible = False
                PictureBoxOnlyCommand.Visible = True
                Dim NodeGroup As TreeNode = TreeViewCriterias.Nodes.Add("组0")
                NodeGroup.Name = "组"
                Dim NodeCritaria As TreeNode = NodeGroup.Nodes.Add("喵帕斯")
                NodeCritaria.Name = "条"
                Dim StrResult As String
                StrResult = Chr(34) & "喵帕斯" & Chr(34) & ":{"
                StrResult &= Chr(34) & "trigger" & Chr(34) & ":" & Chr(34) & "minecraft:impossible" & Chr(34)
                StrResult &= "}"
                NodeCritaria.Tag = StrResult
            Case False
                IntGroupCount = 0
                IntCriteriaCount = 0
                TreeViewCriterias.Visible = True
                ButtonAddCriteria.Visible = True
                ButtonAddGroup.Visible = True
                ButtonRemove.Visible = True
                PictureBoxOnlyCommand.Visible = False
                ButtonAddCriteria.Enabled = False
                ButtonRemove.Enabled = False
        End Select
        SaveGroupJson()
    End Sub
End Class