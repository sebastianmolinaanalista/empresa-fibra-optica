Public Class frmPrincipal
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlanes_Click(sender As Object, e As EventArgs) Handles btnPlanes.Click
        frmPlanes.Show()
        Me.Hide()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        frmServicios.Show()
        Me.Hide()
    End Sub

    Private Sub btnInstalaciones_Click(sender As Object, e As EventArgs) Handles btnInstalaciones.Click
        frmInstalaciones.Show()
        Me.Hide()
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        frmFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        frmInformes.Show()
        Me.Hide()
    End Sub

    Private Sub btnParametros_Click(sender As Object, e As EventArgs) Handles btnParametros.Click
        frmParametros.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
