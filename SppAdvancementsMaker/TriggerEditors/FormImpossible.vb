Public Class FormImpossible
    Public Sub Reading(StrJson As String)
        On Error Resume Next
        Visible = False
        Show(FormCriteria)
    End Sub

    Private Sub Writing(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Hide()
        FormCriteria.Hide()
        FormCriteria.Show(FormMain)
    End Sub

    Private Sub FormImpossible_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class