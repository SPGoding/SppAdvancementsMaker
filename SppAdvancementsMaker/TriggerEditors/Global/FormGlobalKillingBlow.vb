Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormGlobalKillingBlow
    Private ButtonTarget As Button

    Private Sub Reset()
        BypassesArmorNull.Checked = True
        BypassesInvulnerabilityNull.Checked = True
        BypassesMagicNull.Checked = True
        IsExplosionNull.Checked = True
        IsFireNull.Checked = True
        IsMagicNull.Checked = True
        IsProjectileNull.Checked = True
        ButtonDirectEntity.Tag = "{}"
        ButtonSourceEntity.Tag = "{}"
    End Sub

    Public Sub Reading(ByRef ButtonTarget As Button)
        On Error Resume Next
        ' 显示本窗体
        Visible = False
        Show()
        ' 读取传送过来的 Json 文本
        Reset()
        Me.ButtonTarget = ButtonTarget
        Dim ObjJson As JObject = CType(JsonConvert.DeserializeObject(ButtonTarget.Tag), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("bypasses_armor") IsNot Nothing Then
                Select Case ObjJson.Item("bypasses_armor").ToString.ToLower
                    Case "true"
                        BypassesArmorTrue.Checked = True
                    Case "false"
                        BypassesArmorFalse.Checked = True
                End Select
            End If
            If ObjJson.Item("bypasses_invulnerability") IsNot Nothing Then
                Select Case ObjJson.Item("bypasses_invulnerability").ToString.ToLower
                    Case "true"
                        BypassesInvulnerabilityTrue.Checked = True
                    Case "false"
                        BypassesInvulnerabilityFalse.Checked = True
                End Select
            End If
            If ObjJson.Item("bypasses_magic") IsNot Nothing Then
                Select Case ObjJson.Item("bypasses_magic").ToString.ToLower
                    Case "true"
                        BypassesMagicTrue.Checked = True
                    Case "false"
                        BypassesMagicFalse.Checked = True
                End Select
            End If
            If ObjJson.Item("is_explosion") IsNot Nothing Then
                Select Case ObjJson.Item("is_explosion").ToString.ToLower
                    Case "true"
                        IsExplosionTrue.Checked = True
                    Case "false"
                        IsExplosionFalse.Checked = True
                End Select
            End If
            If ObjJson.Item("is_fire") IsNot Nothing Then
                Select Case ObjJson.Item("is_fire").ToString.ToLower
                    Case "true"
                        IsFireTrue.Checked = True
                    Case "false"
                        IsFireFalse.Checked = True
                End Select
            End If
            If ObjJson.Item("is_magic") IsNot Nothing Then
                Select Case ObjJson.Item("is_magic").ToString.ToLower
                    Case "true"
                        IsMagicTrue.Checked = True
                    Case "false"
                        IsMagicFalse.Checked = True
                End Select
            End If
            If ObjJson.Item("is_projectile") IsNot Nothing Then
                Select Case ObjJson.Item("is_projectile").ToString.ToLower
                    Case "true"
                        IsProjectileTrue.Checked = True
                    Case "false"
                        IsProjectileFalse.Checked = True
                End Select
            End If
            If ObjJson.Item("direct_entity") IsNot Nothing Then
                ButtonDirectEntity.Tag = ObjJson.Item("direct_entity").ToString
            End If
            If ObjJson.Item("source_entity") IsNot Nothing Then
                ButtonSourceEntity.Tag = ObjJson.Item("source_entity").ToString
            End If
        End If
    End Sub

    Private Sub Wirting(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim StrResult As String
        StrResult = "{"
        If BypassesArmorTrue.Checked Then
            StrResult &= Chr(34) & "bypasses_armor" & Chr(34) & ":true,"
        ElseIf BypassesArmorFalse.Checked Then
            StrResult &= Chr(34) & "bypasses_armor" & Chr(34) & ":false,"
        End If
        If BypassesInvulnerabilityTrue.Checked Then
            StrResult &= Chr(34) & "bypasses_invulnerability" & Chr(34) & ":true,"
        ElseIf BypassesInvulnerabilityFalse.Checked Then
            StrResult &= Chr(34) & "bypasses_invulnerability" & Chr(34) & ":false,"
        End If
        If BypassesMagicTrue.Checked Then
            StrResult &= Chr(34) & "bypasses_magic" & Chr(34) & ":true,"
        ElseIf BypassesMagicFalse.Checked Then
            StrResult &= Chr(34) & "bypasses_magic" & Chr(34) & ":false,"
        End If
        If IsExplosionTrue.Checked Then
            StrResult &= Chr(34) & "is_explosion" & Chr(34) & ":true,"
        ElseIf IsExplosionFalse.Checked Then
            StrResult &= Chr(34) & "is_explosion" & Chr(34) & ":false,"
        End If
        If IsFireTrue.Checked Then
            StrResult &= Chr(34) & "is_fire" & Chr(34) & ":true,"
        ElseIf IsFireFalse.Checked Then
            StrResult &= Chr(34) & "is_fire" & Chr(34) & ":false,"
        End If
        If IsMagicTrue.Checked Then
            StrResult &= Chr(34) & "is_magic" & Chr(34) & ":true,"
        ElseIf IsMagicFalse.Checked Then
            StrResult &= Chr(34) & "is_magic" & Chr(34) & ":false,"
        End If
        If IsProjectileTrue.Checked Then
            StrResult &= Chr(34) & "is_projectile" & Chr(34) & ":true,"
        ElseIf IsProjectileFalse.Checked Then
            StrResult &= Chr(34) & "is_projectile" & Chr(34) & ":false,"
        End If
        If ButtonDirectEntity.Tag <> "{}" Then
            StrResult &= Chr(34) & "direct_entity" & Chr(34) & ":" & ButtonDirectEntity.Tag & ","
        End If
        If ButtonSourceEntity.Tag <> "{}" Then
            StrResult &= Chr(34) & "source_entity" & Chr(34) & ":" & ButtonSourceEntity.Tag
        End If
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        ButtonTarget.Tag = StrResult
        Hide()
        ButtonTarget.Parent.Hide()
        ButtonTarget.Parent.Show()
    End Sub

    Private Sub ButtonDirectEntity_Click(sender As Object, e As EventArgs) Handles ButtonDirectEntity.Click
        FormGlobalEntity.Reading(ButtonDirectEntity, {"N/A"})
    End Sub

    Private Sub ButtonSourceEntity_Click(sender As Object, e As EventArgs) Handles ButtonSourceEntity.Click
        FormGlobalEntity.Reading(ButtonSourceEntity, {"N/A"})
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MessageBox.Show("伤害直接来源只有在骷髅的箭、恶魂的火球、烈焰人的火球等情况下才有必要设置，其余情况都设置到根本伤害来源")
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MessageBox.Show("绝大多数伤害来源都设置在这里，如僵尸打、爬行者爆炸等")
    End Sub
End Class