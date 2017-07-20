Imports System.IO

Public Class FormSelectAdvancement

    Private Sub FormSelectAdvancement_Activated() Handles Me.Activated
        ' 读取原版进度和现有进度
        ListBoxAdvancements.Items.Clear()
        GetAdvancementsInSave()
        For i As Int16 = 0 To UBound(ZhAdvancements)
            If Not IsReplacedByUser(ZhAdvancements(i)) Then
                ListBoxAdvancements.Items.Add("[原版]" & ZhAdvancements(i))
            End If
        Next
    End Sub
    Private Sub GetAdvancementsInSave()
        Dim StrFileNames As String()
        Dim StrTempPath As String = StrSavePath & "\data\advancements"
        ' 获取存档目录下所有进度
        If Directory.Exists(StrTempPath) Then
            StrFileNames = Directory.GetFileSystemEntries(StrTempPath, "*.json", SearchOption.AllDirectories)
            ' 格式化路径
            For Each StrFileName As String In StrFileNames
                StrFileName = GetAdvancementName(StrFileName)
                ListBoxAdvancements.Items.Add("[自制]" & StrFileName)
            Next
        End If
    End Sub
    Private Function IsReplacedByUser(StrZh As String) As Boolean
        For i As Int16 = 0 To ListBoxAdvancements.Items.Count - 1
            If StrZh = Microsoft.VisualBasic.Right(ListBoxAdvancements.Items.Item(i).ToString, ListBoxAdvancements.Items.Item(i).ToString.Length - 4) Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
    Private Sub ListBoxAdvancements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAdvancements.SelectedIndexChanged
        If ListBoxAdvancements.SelectedIndex >= 0 Then
            ButtonEdit.Enabled = True
            If Microsoft.VisualBasic.Left(ListBoxAdvancements.SelectedItem.ToString, 4) = "[自制]" Then
                ButtonDel.Enabled = True
            Else
                ButtonDel.Enabled = False
            End If
        End If
    End Sub
    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If ListBoxAdvancements.SelectedIndex >= 0 Then
            Dim StrTempPath As String = GetAdvancementPath(ZhToEn(Microsoft.VisualBasic.Right(ListBoxAdvancements.SelectedItem.ToString, ListBoxAdvancements.SelectedItem.ToString.Length - 4), ZhAdvancements, EnAdvancements))
            Dim StrTempJson As String
            Try
                If Not File.Exists(StrTempPath) Then
                    If Not Directory.Exists(GetParentPath(StrTempPath)) Then
                        MkDir(GetParentPath(StrTempPath))
                    End If
                    File.Copy(StrTempPath.Replace(StrSavePath & "\data\advancements\minecraft", Application.StartupPath & "\advancements"), StrTempPath)
                End If
                StrEditingAdvancementName = ZhToEn(Microsoft.VisualBasic.Right(ListBoxAdvancements.SelectedItem.ToString, ListBoxAdvancements.SelectedItem.ToString.Length - 4), ZhAdvancements, EnAdvancements)
                StrTempJson = File.ReadAllText(StrTempPath)
                FormMain.Reading(StrTempJson, True)
            Catch ex As Exception
                LabelInfo.ForeColor = Color.Red
                LabelInfo.Text = "编辑不能: " & ex.Message
            End Try
        End If
    End Sub
    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If ListBoxAdvancements.SelectedIndex >= 0 Then
            Try
                File.Delete(GetAdvancementPath(ZhToEn(Microsoft.VisualBasic.Right(ListBoxAdvancements.SelectedItem.ToString, ListBoxAdvancements.SelectedItem.ToString.Length - 4), ZhAdvancements, EnAdvancements)))
                LabelInfo.ForeColor = Color.Green
                LabelInfo.Text = "删除成功"
            Catch ex As Exception
                LabelInfo.ForeColor = Color.Red
                LabelInfo.Text = "删除不能: " & ex.Message
            End Try
            Dim TempIndex As Int32 = ListBoxAdvancements.SelectedIndex
            FormSelectAdvancement_Activated()
            ListBoxAdvancements.SelectedIndex = TempIndex
        End If
    End Sub

    Private Sub ButtonChangedSave_Click(sender As Object, e As EventArgs) Handles ButtonChangedSave.Click
        FormSelectSave.Show()
        Hide()
    End Sub

    Private Sub FormSelectAdvancement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormMain.Reading("{}", False)
    End Sub
End Class