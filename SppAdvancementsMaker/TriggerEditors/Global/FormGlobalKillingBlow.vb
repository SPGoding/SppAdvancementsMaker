Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormGlobalKillingBlow
    Private ButtonTarget As Button

    Private Sub Reset()
        CheckBoxBypassesArmor.Checked = False
        CheckBoxBypassesInvulnerability.Checked = False
        CheckBoxBypassesMagic.Checked = False
        CheckBoxIsExplosion.Checked = False
        CheckBoxIsFire.Checked = False
        CheckBoxIsMagic.Checked = False
        CheckBoxIsProjectile.Checked = False
        ButtonDirectEntity.Tag = "{}"
        ButtonSourceEntity.Tag = "{}"
    End Sub

    Public Sub Reading(ByRef ButtonTarget As Button)
        ' 显示本窗体
        Visible = False
        Show()
        ' 读取传送过来的 Json 文本
        Reset()
        Me.ButtonTarget = ButtonTarget
        Dim ObjJson As Object = CType(JsonConvert.DeserializeObject(ButtonTarget.Tag), JObject)
        If ObjJson.ToString <> "{}" Then
            If ObjJson.Item("bypasses_armor") IsNot Nothing Then
                CheckBoxBypassesArmor.Checked = CBool(ObjJson.Item("bypasses_armor").ToString)
            End If
            If ObjJson.Item("bypasses_invulnerability") IsNot Nothing Then
                CheckBoxBypassesInvulnerability.Checked = CBool(ObjJson.Item("bypasses_invulnerability").ToString)
            End If
            If ObjJson.Item("bypasses_magic") IsNot Nothing Then
                CheckBoxBypassesMagic.Checked = CBool(ObjJson.Item("bypasses_magic").ToString)
            End If
            If ObjJson.Item("is_explosion") IsNot Nothing Then
                CheckBoxIsExplosion.Checked = CBool(ObjJson.Item("is_explosion").ToString)
            End If
            If ObjJson.Item("is_fire") IsNot Nothing Then
                CheckBoxIsFire.Checked = CBool(ObjJson.Item("is_fire").ToString)
            End If
            If ObjJson.Item("is_magic") IsNot Nothing Then
                CheckBoxIsMagic.Checked = CBool(ObjJson.Item("is_magic").ToString)
            End If
            If ObjJson.Item("is_projectile") IsNot Nothing Then
                CheckBoxIsProjectile.Checked = CBool(ObjJson.Item("is_projectile").ToString)
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
        If CheckBoxBypassesArmor.Checked.ToString.ToLower <> "false" Then
            StrResult &= Chr(34) & "bypasses_armor" & Chr(34) & ":" & CheckBoxBypassesArmor.Checked.ToString.ToLower & ","
        End If
        If CheckBoxBypassesInvulnerability.Checked.ToString.ToLower <> "false" Then
            StrResult &= Chr(34) & "bypasses_invulnerability" & Chr(34) & ":" & CheckBoxBypassesInvulnerability.Checked.ToString.ToLower & ","
        End If
        If CheckBoxBypassesMagic.Checked.ToString.ToLower <> "false" Then
            StrResult &= Chr(34) & "bypasses_magic" & Chr(34) & ":" & CheckBoxBypassesMagic.Checked.ToString.ToLower & ","
        End If
        If CheckBoxIsExplosion.Checked.ToString.ToLower <> "false" Then
            StrResult &= Chr(34) & "is_explosion" & Chr(34) & ":" & CheckBoxIsExplosion.Checked.ToString.ToLower & ","
        End If
        If CheckBoxIsFire.Checked.ToString.ToLower <> "false" Then
            StrResult &= Chr(34) & "is_fire" & Chr(34) & ":" & CheckBoxIsFire.Checked.ToString.ToLower & ","
        End If
        If CheckBoxIsMagic.Checked.ToString.ToLower <> "false" Then
            StrResult &= Chr(34) & "is_magic" & Chr(34) & ":" & CheckBoxIsMagic.Checked.ToString.ToLower & ","
        End If
        If CheckBoxIsProjectile.Checked.ToString.ToLower <> "false" Then
            StrResult &= Chr(34) & "is_projectile" & Chr(34) & ":" & CheckBoxIsProjectile.Checked.ToString.ToLower & ","
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
        FormGlobalEntity.Reading(ButtonDirectEntity)
    End Sub

    Private Sub ButtonSourceEntity_Click(sender As Object, e As EventArgs) Handles ButtonSourceEntity.Click
        FormGlobalEntity.Reading(ButtonSourceEntity)
    End Sub
End Class