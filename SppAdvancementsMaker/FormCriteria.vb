Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormCriteria
    Public StrEditingJson As String

    Public Sub Reading(StrCriteriaName As String, StrCriteriaJson As String, StrGroupJson As String)
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject("{" & StrCriteriaJson & "}"), JObject)
        '读取条件名
        TextBoxName.Tag = StrCriteriaName
        TextBoxName.Text = StrCriteriaName
        '读取触发器
        Dim StrTriggerName As String = ObjJson.Item(StrCriteriaName).Item("trigger").ToString()
        Dim i As Int16
        For i = 0 To StrTriggerNames.Count - 1
            If StrTriggerNames(i) = StrTriggerName Then
                ComboBoxTrigger.Text = StrTriggerDescriptions(i)
                Exit For
            End If
        Next
        '读取分组
        Dim j As Int16
        ComboBoxGroup.Items.Clear()
        ObjJson = CType(JsonConvert.DeserializeObject("[" & StrGroupJson & "]"), JArray)
        For i = 0 To ObjJson.Count - 1
            ComboBoxGroup.Items.Add("组" & i)
            For j = 0 To ObjJson.Item(i).Count - 1
                If ObjJson.Item(i).Item(j).ToString = StrCriteriaName Then
                    ComboBoxGroup.Text = "组" & i
                    ComboBoxGroup.Tag = "组" & i
                End If
            Next
        Next
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        Dim StrTemp As String = ""
        Dim i As Int16
        StrResult = Chr(34) & TextBoxName.Text & Chr(34) & ":{"
        For i = 0 To StrTriggerDescriptions.Count - 1
            If StrTriggerDescriptions(i) = ComboBoxTrigger.Text Then
                StrTemp = StrTriggerNames(i)
                Exit For
            End If
        Next
        StrResult &= Chr(34) & "trigger" & Chr(34) & ":" & Chr(34) & StrTemp & Chr(34) & ","
        StrResult &= Chr(34) & "conditions" & Chr(34) & ":{}"
        StrResult &= "}"
        ' 找到正在编辑的条件所在 Node
        Dim j As Int16
        Dim k As Int16
        For i = 0 To FormMain.TreeViewCriterias.GetNodeCount(False) - 1
            For j = 0 To FormMain.TreeViewCriterias.Nodes.Item(i).GetNodeCount(False) - 1
                With FormMain.TreeViewCriterias.Nodes.Item(i).Nodes.Item(j)
                    If .Text = TextBoxName.Tag Then
                        ' 找到啦
                        If ComboBoxGroup.Text = ComboBoxGroup.Tag Then
                            ' 没更换分组
                            ' 直接更改 Tag(存储Json) 属性和 Text 属性
                            .Text = TextBoxName.Text
                            .Tag = StrResult
                            Exit For
                        Else
                            ' 更换了分组
                            ' 先删掉旧的这个
                            If .Text = TextBoxName.Tag Then
                                .Remove()
                            End If
                            ' 然后在更换后的组建一个新的
                            For k = 0 To FormMain.TreeViewCriterias.Nodes.Count - 1
                                If FormMain.TreeViewCriterias.Nodes.Item(k).Text = ComboBoxGroup.Text Then
                                    Dim Node As TreeNode = FormMain.TreeViewCriterias.Nodes.Item(k).Nodes.Add(TextBoxName.Text)
                                    Node.Name = "条"
                                    Node.Tag = StrResult
                                End If
                            Next k
                        End If
                    End If
                End With
            Next j
        Next i
        FormMain.SaveGroupJson()
        Hide()
    End Sub

    Private Sub ButtonCriteria_Click(sender As Object, e As EventArgs) Handles ButtonCriteria.Click

    End Sub
End Class