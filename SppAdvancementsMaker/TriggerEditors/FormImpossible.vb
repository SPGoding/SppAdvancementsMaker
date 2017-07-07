Public Class FormImpossible
    Public Sub Reading(StrJson As String)
        Visible = False
        Show(FormCriteria)
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Hide()
    End Sub
End Class