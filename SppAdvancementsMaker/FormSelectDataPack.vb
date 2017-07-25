Imports System.IO

Public Class FormSelectDataPack
    Private Bool1 As Boolean

    Private Sub ButtonSelectSave_Click(sender As Object, e As EventArgs) Handles ButtonSelectSave.Click
        FolderBrowserDialog1.ShowNewFolderButton = False
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxSavePath.Text = FolderBrowserDialog1.SelectedPath
        End If
        TextBoxSavePath.SelectionStart = TextBoxSavePath.TextLength
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        ' 保存路径 打开主窗体
        If PanelOffline.Visible Then
            StrSavePath = TextBoxSavePath.Text
            StrNamespace = TextBoxSavePath.Text.Split("\")(UBound(TextBoxSavePath.Text.Split("\")))
        Else
            If ListBoxSaves.SelectedItem IsNot Nothing Then
                StrSavePath = Environment.GetEnvironmentVariable("APPDATA") & "\.minecraft\data\" & ListBoxSaves.SelectedItem.ToString
                StrNamespace = ListBoxSaves.SelectedItem.ToString
            Else
                ButtonEnter.Enabled = False
                Exit Sub
            End If
        End If
        FormSelectAdvancement.Show()
        Hide()
    End Sub

    Private Sub TextBoxSavePath_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSavePath.TextChanged
        If TextBoxSavePath.Text <> "" Then
            Bool1 = True
        Else
            Bool1 = False
        End If
        If Bool1 Then
            ButtonEnter.Enabled = True
        Else
            ButtonEnter.Enabled = False
        End If
    End Sub
    Private Sub FormSelectSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 获取正版 Minecraft 的默认路径
        Dim StrPath As String = Environment.GetEnvironmentVariable("APPDATA") & "\.minecraft\data\"
        If Dir(StrPath, vbDirectory) <> "" Then
            ' 如果有正版默认路径 就显示正版的数据包列表
            PanelOffline.Visible = False
            PanelOnline.Visible = True
        Else
            PanelOffline.Visible = True
            PanelOnline.Visible = False
        End If
    End Sub
    Private Sub FormSelectSave_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim StrPath As String = Environment.GetEnvironmentVariable("APPDATA") & "\.minecraft\data\"
        If Dir(StrPath, vbDirectory) <> "" Then
            ListBoxSaves.Items.Clear()
            Dim StrSaveNames As String()
            ' 获取所有存档
            StrSaveNames = Directory.GetDirectories(StrPath, "*", SearchOption.TopDirectoryOnly)
            ' 取存档名
            For Each StrSaveName As String In StrSaveNames
                StrSaveName = StrSaveName.Split("\")(UBound(StrSaveName.Split("\")))
                ListBoxSaves.Items.Add(StrSaveName)
            Next
        End If
    End Sub
    Private Sub LabelOffline_Click(sender As Object, e As EventArgs) Handles LabelOffline.Click
        PanelOffline.Visible = True
        PanelOnline.Visible = False
    End Sub

    Private Sub ListBoxSaves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSaves.SelectedIndexChanged
        If ListBoxSaves.SelectedIndex >= 0 Then
            ButtonEnter.Enabled = True
        Else
            ButtonEnter.Enabled = False
        End If
    End Sub

    Private Sub FormSelectDataPack_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class