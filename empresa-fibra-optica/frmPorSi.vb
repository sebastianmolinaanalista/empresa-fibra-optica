Public Class frmPorSi


    Private Sub frmColegio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frmPrincipal.Show()
        End If
    End Sub
End Class