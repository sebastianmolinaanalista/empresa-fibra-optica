Public Class frmFacturas

    Dim estado As Integer = 0 '0=visor, 1=nuevo, 2=editar
    Dim colId As DataColumn

    Private Sub frmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colId = Me._empresa_servicio_internetDataSet.Facturas.id_facturaColumn
        colId.AutoIncrement = False

        Me.FacturasTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas)
        Me.Facturas_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas_estado)
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
            Dim siguienteId As Integer = 1
            Dim resultado As Object = Me.FacturasTableAdapter.getCantidad()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                Dim cantidadFilas As Integer = Convert.ToInt32(resultado)
                siguienteId = cantidadFilas + 1
            Else
                siguienteId = 1
            End If

            Me.FacturasBindingSource.AddNew()
            estadoNuevo()
            Id_facturaTextBox.Text = siguienteId.ToString()

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
            Me.FacturasBindingSource.EndEdit()
            Me.Validate()

            Me.FacturasTableAdapter.Update(Me._empresa_servicio_internetDataSet.Facturas)
            Me.FacturasTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualizacion")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If estado <> 0 Then
            Me.Validate()
            Me.FacturasBindingSource.CancelEdit()
            Me.FacturasTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(Id_facturaTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.FacturasTableAdapter.eliminar(Convert.ToInt32(Id_facturaTextBox.Text))
            Me.FacturasTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Seguro que desea salir?", vbOKCancel, "Aceptar") = vbOK Then
            If estado <> 0 Then
                Me.Validate()
                Me.FacturasBindingSource.CancelEdit()
                Me.FacturasTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas)
            End If
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub limpiar()
        Me.FacturasBindingSource.MoveFirst()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String = txtBuscar.Text.Trim()
        If String.IsNullOrWhiteSpace(valor) Then
            FacturasBindingSource.Filter = Nothing
            Exit Sub
        End If

        Dim filtro As String = ""
        Dim texto As String = valor.Replace("'", "''")

        Select Case cmbBuscarPor.Text
            Case "Importe"
                filtro = "importe LIKE '%" & texto & "%'"
            Case "Periodo"
                filtro = "periodo LIKE '%" & texto & "%'"
            Case "Estado"
                filtro = "estado LIKE '%" & texto & "%'"
            Case "FechaVencimiento"
                Dim fechaVencimiento As DateTime
                If Not DateTime.TryParse(texto, fechaVencimiento) Then
                    MsgBox("Ingresá una fecha válida para buscar por Fecha vencimiento.", vbExclamation, "Fecha inválida")
                    Exit Sub
                End If
                Dim fechaVencimientoInicio As DateTime = fechaVencimiento.Date
                Dim fechaVencimientoFin As DateTime = fechaVencimientoInicio.AddDays(1)
                filtro = "fecha_vencimiento >= #" & fechaVencimientoInicio.ToString("yyyy-MM-dd") & "# AND fecha_vencimiento < #" & fechaVencimientoFin.ToString("yyyy-MM-dd") & "#"
            Case Else
                filtro = "dni LIKE '%" & texto & "%'"
        End Select

        FacturasBindingSource.Filter = filtro
    End Sub
End Class