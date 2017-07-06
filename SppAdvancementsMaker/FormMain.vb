Imports System.IO
Imports System.Text

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

    '生成
    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        Dim StrCriteria As String = ""
        Dim StrRewards As String = ""
        Dim i As Int16
        Dim j As Int16
        ' 把条件并列起来
        For i = 0 To TreeViewCriterias.GetNodeCount(False) - 1
            For j = 0 To TreeViewCriterias.Nodes.Item(i).GetNodeCount(False) - 1
                StrCriteria &= TreeViewCriterias.Nodes.Item(i).Nodes.Item(j).Tag
                'If i <= TreeViewCriterias.GetNodeCount(False) - 1 And j < TreeViewCriterias.Nodes.Item(i).GetNodeCount(False) - 1 Then
                '    ' 目前这个不是最后一个条件
                StrCriteria &= ","
                'End If
            Next
        Next
        Try
            ' 把奖励 rewards 并列起来
            If TextBoxRecipes.Text <> "" Then
                StrRewards &= Chr(34) & "recipes" & Chr(34) & ":" & TextBoxRecipes.Text & ","
            End If
            If TextBoxLoot.Text <> "" Then
                StrRewards &= Chr(34) & "loot" & Chr(34) & ":" & TextBoxLoot.Text & ","
            End If
            StrRewards &= Chr(34) & "experience" & Chr(34) & ":" & NumericUpDownExperience.Value & ","
            If TextBoxFunction.Text <> "" Then
                Dim StrFunctionPath As String = StrSavePath & "\data\functions\sppadvancementsmaker\" & StrProjectAdvancementName & ".mcfunction"
                Dim StrFunctionName As String = "sppadvancementsmaker:" & StrProjectAdvancementName
                CreateFile(StrFunctionPath, StrSavePath & "\data\functions\sppadvancementsmaker\", TextBoxFunction.Tag)
                ' 把函数名写入 StrRewards
                StrRewards &= Chr(34) & "function" & Chr(34) & ":" & Chr(34) & StrFunctionName & Chr(34)
            End If
            ' 调用函數
            Dim StrResult As String = GenerateAdvancement(TextBoxItem.Tag, NumericUpDownData.Value, TextBoxTitle.Text,
                                                     ComboBoxFrame.Tag, ComboBoxBackground.Tag, TextBoxDescription.Text,
                                                     CheckBoxShow_Toast.Checked, CheckBoxAnnounce_To_Chat.Checked,
                                                     CheckBoxHidden.Checked, TextBoxParent.Text, StrCriteria,
                                                     TreeViewCriterias.Tag, StrRewards)
            ' 将进度写入文件
            Dim StrAdvancementsParentPath As String = StrSavePath & "\data\advancements\sppadvancementsmaker\"
            Dim StrAdvancementsPath As String = StrAdvancementsParentPath & StrProjectAdvancementName & ".json"
            CreateFile(StrAdvancementsPath, StrAdvancementsParentPath, StrResult)
            LabelResult.Text = "已生成"
            LabelResult.ForeColor = Color.Green
        Catch ex As Exception
            LabelResult.Text = "错误: " & ex.Message
            LabelResult.ForeColor = Color.Red
        End Try
    End Sub

    ' 生成临时tag
    Private Sub ComboBoxFrame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFrame.SelectedIndexChanged
        Select Case ComboBoxFrame.SelectedIndex
            Case 0
                ComboBoxFrame.Tag = "task"
            Case 1
                ComboBoxFrame.Tag = "challenge"
            Case 2
                ComboBoxFrame.Tag = "goal"
        End Select
    End Sub

    Private Sub TextBoxItem_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItem.TextChanged
        If Microsoft.VisualBasic.Left(TextBoxItem.Text, 10) = "minecraft:" Then
            TextBoxItem.Tag = TextBoxItem.Text
        Else
            TextBoxItem.Tag = "minecraft:" & TextBoxItem.Text
        End If
    End Sub

    Private Sub TextBoxFunction_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFunction.TextChanged
        TextBoxFunction.Tag = "#Created By SppAdvancementsMaker" & vbNewLine & TextBoxFunction.Text
    End Sub

    Private Sub ComboBoxBackground_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBackground.SelectedIndexChanged
        ComboBoxBackground.Tag = "minecraft:textures/blocks/" & ComboBoxBackground.Text & ".png"
    End Sub

    Private Sub ButtonTitle_Click(sender As Object, e As EventArgs) Handles ButtonTitle.Click
        FormJsonTexts.Visible = False
        FormJsonTexts.Show(Me)
        FormJsonTexts.Tag = "Title"
        FormJsonTexts.Reset()
    End Sub
    Private Sub ButtonDescription_Click(sender As Object, e As EventArgs) Handles ButtonDescription.Click
        FormJsonTexts.Visible = False
        FormJsonTexts.Show(Me)
        FormJsonTexts.Tag = "Description"
        FormJsonTexts.Reset()
    End Sub

    '组的 Text 是组X
    '条件的 Text 是条件X
    '组和条件的 Name 分别为组、条
    ' TreeView 的 Tag 储存分组的 Json
    ' Node 的 Tag 储存每个条件的 Json
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
        IntGroupCount += 1
        Dim Node As TreeNode = TreeViewCriterias.Nodes.Add("组" & IntGroupCount)
        Node.Name = "组"
        SaveGroupJson()
    End Sub
    Private Sub ButtonAddCriteria_Click(sender As Object, e As EventArgs) Handles ButtonAddCriteria.Click
        Dim Node As TreeNode
        Select Case TreeViewCriterias.SelectedNode.Name
            Case "组"
                Node = TreeViewCriterias.SelectedNode.Nodes.Add("条件" & IntCriteriaCount)
                Node.Name = "条"
            Case "条"
                Node = TreeViewCriterias.SelectedNode.Parent.Nodes.Add("条件" & IntCriteriaCount)
                Node.Name = "条"
        End Select
        ' 编辑条件的 Json
        '    不包含 criteria 层级的大括号
#Disable Warning BC42104 ' 在为变量赋值之前，变量已被使用
        Node.Tag = Chr(34) & Node.Text & Chr(34) & ":{"
#Enable Warning BC42104 ' 在为变量赋值之前，变量已被使用
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
End Class
