Public Class FormSelectSave
    Private Bool1 As Boolean
    Private Bool2 As Boolean

    Private Sub ButtonSelectSave_Click(sender As Object, e As EventArgs) Handles ButtonSelectSave.Click
        '//DELETE
        ' 获取正版 Minecraft 的默认路径
        Dim StrPath As String = Environment.GetEnvironmentVariable("APPDATA") & "\.minecraft\saves\"
        If Dir(StrPath, vbDirectory) <> "" Then
            ' 如果有正版默认路径 就定位到该路径
            FolderBrowserDialog1.SelectedPath = StrPath
        End If
        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.ShowDialog()
        TextBoxSavePath.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        ' 保存存档路径 打开主窗体
        StrSavePath = TextBoxSavePath.Text
        StrProjectAdvancementName = TextBoxName.Text
        FormMain.Show()
        Hide()
    End Sub

    Private Sub TextBoxSavePath_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSavePath.TextChanged
        Bool1 = True
        If Bool1 And Bool2 Then
            ButtonEnter.Enabled = True
        End If
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged
        Bool2 = True
        If Bool1 And Bool2 Then
            ButtonEnter.Enabled = True
        End If
    End Sub
End Class