Public Class FormHelper
    Public Sub Reading()
        Show(FormMain)
        SubA()
    End Sub

    Private Sub Writing()
        Hide()
        FormMain.Hide()
        FormMain.Show()
    End Sub

    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(TextBoxCommand.Text)
    End Sub

    Private Sub SubA()
        LabelInfo.Text = "请首先在游戏中执行以下命令"
        TextBoxCommand.Text = "/reload"
        LabelInfo2.Visible = False
        LabelChoice1.Visible = True
        LabelChoice2.Visible = False
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "A"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelChoice1.Text = "执行完了"
    End Sub
    Private Sub SubB()
        LabelInfo.Text = "请继续在游戏中执行以下命令"
        TextBoxCommand.Text = "/advancement test @p sppadvancementsmaker:" & StrProjectAdvancementName
        LabelInfo2.Visible = True
        LabelChoice1.Visible = True
        LabelChoice2.Visible = True
        LabelChoice3.Visible = True
        LabelChoice1.Tag = "B"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelInfo2.Text = "游戏返回内容为"
        LabelChoice1.Text = "没有找到名为'" & "sppadvancementsmaker:" & StrProjectAdvancementName & "'的进度"
        LabelChoice2.Text = "玩家xxx尚未完成进度'" & "sppadvancementsmaker:" & StrProjectAdvancementName & "'"
        LabelChoice3.Text = "玩家xxx已达成了'" & "sppadvancementsmaker:" & StrProjectAdvancementName & "'进度"
    End Sub
    Private Sub SubB1()
        LabelInfo.Text = "你进的是'" & StrSavePath.Split("\")(UBound(StrSavePath.Split("\"))) & "'这个存档吗？"
        TextBoxCommand.Text = ""
        LabelInfo2.Visible = False
        LabelChoice1.Visible = True
        LabelChoice2.Visible = True
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "B1"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelChoice1.Text = "是"
        LabelChoice2.Text = "不是"
    End Sub
    Private Sub SubB11()
        If Dir(StrSavePath & "\data\advancements\sppadvancementsmaker\" & StrProjectAdvancementName & ".json") <> "" Then
            TextBoxCommand.Text = IO.File.ReadAllText(StrSavePath & "\data\advancements\sppadvancementsmaker\" & StrProjectAdvancementName & ".json")
        Else
            SubB11Throw()
        End If
        LabelInfo.Text = "好像很复杂…你把以下内容发到作者的发布贴好了=w=我不管啦"
        LabelInfo2.Visible = True
        LabelChoice1.Visible = True
        LabelChoice2.Visible = False
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "B11"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelInfo2.Text = "对了，有可能是你条件里有逻辑错误哦"
        LabelChoice1.Text = "返回"
    End Sub
    Private Sub SubB11Throw()
        LabelInfo.Text = "这个进度未被生成，请尝试重新生成"
        LabelInfo2.Visible = False
        LabelChoice1.Visible = True
        LabelChoice2.Visible = False
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "B11Throw"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelInfo2.Text = ""
        LabelChoice1.Text = "返回"
    End Sub
    Private Sub SubB12()
        LabelInfo.Text = "退出当前存档，到'" & StrSavePath.Split("\")(UBound(StrSavePath.Split("\"))) & "'存档后，问题将解决~"
        TextBoxCommand.Text = "喵喵喵"
        LabelInfo2.Visible = True
        LabelChoice1.Visible = True
        LabelChoice2.Visible = False
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "B12"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelInfo2.Text = "仍有问题可向作者咨询，或再次运行本疑难解答"
        LabelChoice1.Text = "返回"
    End Sub
    Private Sub SubB2()
        LabelInfo.Text = "看起来似乎没什么问题...你把条件都做一遍试试可不可以完成进度"
        TextBoxCommand.Text = ""
        LabelInfo2.Visible = False
        LabelChoice1.Visible = True
        LabelChoice2.Visible = True
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "B2"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelChoice1.Text = "完成了"
        LabelChoice2.Text = "没反应"
    End Sub
    Private Sub SubB21()
        LabelInfo.Text = "那就完全没问题啊，你点我干嘛！输入以下命令使该进度未完成"
        TextBoxCommand.Text = "/advancement revoke @p only sppadvancementsmaker:" & StrProjectAdvancementName
        LabelInfo2.Visible = False
        LabelChoice1.Visible = True
        LabelChoice2.Visible = False
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "B21"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelChoice1.Text = "返回"
    End Sub
    Private Sub SubB22()
        SubB11()
    End Sub
    Private Sub SubB3()
        LabelInfo.Text = "在游戏中执行以下命令后，问题将解决~"
        TextBoxCommand.Text = "/advancement revoke @p only sppadvancementsmaker:" & StrProjectAdvancementName
        LabelInfo2.Visible = True
        LabelChoice1.Visible = True
        LabelChoice2.Visible = False
        LabelChoice3.Visible = False
        LabelChoice1.Tag = "B3"
        LabelChoice2.Tag = LabelChoice1.Tag
        LabelChoice3.Tag = LabelChoice1.Tag
        LabelInfo2.Text = "仍有问题可向作者咨询，或再次运行本疑难解答"
        LabelChoice1.Text = "返回"
    End Sub

    Private Sub LabelChoice1_Click(sender As Object, e As EventArgs) Handles LabelChoice1.Click
        Select Case LabelChoice1.Tag
            Case "A"
                SubB()
            Case "B"
                SubB1()
            Case "B1"
                SubB11()
            Case "B11"
                Writing()
            Case "SubB11Throw"
                Writing()
            Case "B12"
                Writing()
            Case "B2"
                SubB21()
            Case "B21"
                Writing()
            Case "B3"
                Writing()
        End Select
    End Sub

    Private Sub LabelChoice2_Click(sender As Object, e As EventArgs) Handles LabelChoice2.Click
        Select Case LabelChoice1.Tag
            Case "B"
                SubB2()
            Case "B1"
                SubB12()
            Case "B2"
                SubB22
        End Select
    End Sub

    Private Sub LabelChoice3_Click(sender As Object, e As EventArgs) Handles LabelChoice3.Click
        Select Case LabelChoice1.Tag
            Case "B"
                SubB3()
        End Select
    End Sub
End Class