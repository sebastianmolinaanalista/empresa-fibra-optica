Public Class frmInformes


    Private Sub frmInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbInforme.SelectedIndex = 0
        Me.dtpDesde.Value = Date.Today.AddMonths(-1)

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Select Case Me.cmbInforme.Text
            Case "Clientes activos"
                MostrarMensajeSimple("Informe de clientes activos")
            Case "Planes contratados"
                MostrarMensajeSimple("Informe de planes contratados")
            Case "Instalaciones pendientes"
                MostrarMensajeSimple("Informe de instalaciones pendientes")
            Case "Pagos por período"
                MostrarMensajeSimple("Informe de pagos por período")
        End Select
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Seguro que desea salir?", vbOKCancel, "Aceptar") = vbOK Then
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmInformes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub MostrarMensajeSimple(ByVal titulo As String)
        MsgBox(titulo & vbCrLf & "Desde: " & Me.dtpDesde.Value.ToShortDateString() & vbCrLf & "Hasta: " & Me.dtpHasta.Value.ToShortDateString(), vbInformation, "Reporte")
    End Sub

End Class