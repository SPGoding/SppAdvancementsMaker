Imports System.IO

Public Class FormSelectVersion
    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        StrVersion = ComboBoxVersion.Text
        If StrVersion = "1.12" Then
            FormSelectSave.Show()
        Else
            FormSelectDataPack.Show()
        End If
        Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MessageBox.Show("Copyright (c) 2007 James Newton-King

Permission is hereby granted, free of charge, to any person obtaining a copy of this
software and associated documentation files (the ""Software""), to deal in the Software
without restriction, including without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be included in all copies
or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""As Is"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.")
    End Sub

    Private Sub FormSelectVersion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(Application.StartupPath & "\Newtonsoft.Json.dll") Then
            MessageBox.Show("你为什么要删掉'Newtonsoft.Json.dll'QwQ 软件打不开了啦！")
            End
        End If
        If Not Directory.Exists(Application.StartupPath & "\advancements") Then
            MessageBox.Show("你为什么要删掉'advancements'文件夹QwQ 软件打不开了啦！")
            End
        End If
        ComboBoxVersion.SelectedIndex = 0
    End Sub

    Private Sub FormSelectVersion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class