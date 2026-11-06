Public Class frmInstalaciones
    Dim estado As Integer = 0
    Dim colId As DataColumn

    Private Sub frmInstalaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colId = Me._empresa_servicio_internetDataSet.Instalaciones.id_instalacionColumn
        colId.AutoIncrement = False

        Me.InstalacionesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones)
        Me.Instalaciones_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones_estado)
        Me.ServiciosTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios)

        estadoVisor()
        limpiar()
    End Sub

    Private Sub estadoVisor()
        estado = 0
        lblBandera.Text = "VISOR"

        btnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnSalir.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub estadoNuevo()
        estado = 1
        lblBandera.Text = "NUEVO"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub estadoEditar()
        estado = 2
        lblBandera.Text = "EDITAR"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If estado = 0 Then
            Me.Validate()
            Dim siguienteId As Integer = Me._empresa_servicio_internetDataSet.Instalaciones.Rows.Count + 1

            Me.InstalacionesBindingSource.AddNew()
            estadoNuevo()
            Id_instalacionTextBox.Text = siguienteId.ToString()

            cmbServicio.Focus()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If estado = 0 Then
            estadoEditar()
            cmbServicio.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado <> 0 Then
            Me.InstalacionesBindingSource.EndEdit()
            Me.Validate()

            Me.InstalacionesTableAdapter.Update(Me._empresa_servicio_internetDataSet.Instalaciones)
            Me.InstalacionesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualización")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If estado <> 0 Then
            Me.Validate()
            Me.InstalacionesBindingSource.CancelEdit()
            Me.InstalacionesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(Id_instalacionTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.InstalacionesBindingSource.RemoveCurrent()
            Me.InstalacionesTableAdapter.Update(Me._empresa_servicio_internetDataSet.Instalaciones)
            Me.InstalacionesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Seguro que desea salir?", vbOKCancel, "Aceptar") = vbOK Then
            If estado <> 0 Then
                Me.Validate()
                Me.InstalacionesBindingSource.CancelEdit()
                Me.InstalacionesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones)
            End If
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmInstalaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub limpiar()
        If Me.InstalacionesBindingSource.Count > 0 Then
            Me.InstalacionesBindingSource.MoveFirst()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String = txtBuscar.Text.Trim()
        If String.IsNullOrWhiteSpace(valor) Then
            InstalacionesBindingSource.Filter = Nothing
            Exit Sub
        End If

        Dim filtro As String = ""
        Dim texto As String = valor.Replace("'", "''")

        Select Case cmbBuscarPor.Text
            Case "Servicio"
                filtro = "id_servicio LIKE '%" & texto & "%'"
            Case "Fecha programada"
                Dim fecha As DateTime
                If Not DateTime.TryParse(texto, fecha) Then
                    MsgBox("Ingresá una fecha válida para buscar por Fecha programada.", vbExclamation, "Fecha inválida")
                    Exit Sub
                End If
                Dim fechaInicio As DateTime = fecha.Date
                Dim fechaFin As DateTime = fechaInicio.AddDays(1)
                filtro = "fecha_programada >= #" & fechaInicio.ToString("yyyy-MM-dd") & "# AND fecha_programada < #" & fechaFin.ToString("yyyy-MM-dd") & "#"
            Case "Observaciones"
                filtro = "observaciones LIKE '%" & texto & "%'"
            Case Else
                filtro = "id_servicio LIKE '%" & texto & "%'"
        End Select

        InstalacionesBindingSource.Filter = filtro
    End Sub
End Class