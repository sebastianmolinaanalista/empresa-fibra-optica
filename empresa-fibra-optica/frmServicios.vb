Imports System.Security.Cryptography

Public Class frmServicios

    Dim estado As Integer = 0 '0=visor, 1=nuevo, 2=editar
    Dim colId As DataColumn

    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colId = Me._empresa_servicio_internetDataSet.Servicios.id_servicioColumn
        colId.AutoIncrement = False

        Me.Servicios_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios_estado)
        Me.PlanesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Planes)
        Me.ClientesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Clientes)
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
            Dim resultado As Object = Me.ServiciosTableAdapter.getCantidad()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                Dim cantidadFilas As Integer = Convert.ToInt32(resultado)
                siguienteId = cantidadFilas + 1
            Else
                siguienteId = 1
            End If

            Me.ServiciosBindingSource.AddNew()
            estadoNuevo()
            Id_servicioTextBox.Text = siguienteId.ToString()

            cmbCliente.Focus()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If estado = 0 Then
            estadoEditar()
            cmbCliente.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado <> 0 Then
            Me.ServiciosBindingSource.EndEdit()
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me._empresa_servicio_internetDataSet)
            Me.ServiciosTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualizacion")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If estado <> 0 Then
            Me.Validate()
            Me.ServiciosBindingSource.CancelEdit()
            Me.ServiciosTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(Id_servicioTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.ServiciosTableAdapter.eliminar(Convert.ToInt32(Id_servicioTextBox.Text))
            Me.ServiciosTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Seguro que desea salir?", vbOKCancel, "Aceptar") = vbOK Then
            If estado <> 0 Then
                Me.Validate()
                Me.ServiciosBindingSource.CancelEdit()
                Me.ServiciosTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios)
            End If
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmServicios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frmPrincipal.Show()
        End If
    End Sub
    Private Sub limpiar()
        Me.ServiciosBindingSource.MoveFirst()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String = txtBuscar.Text.Trim()
        If String.IsNullOrWhiteSpace(valor) Then
            ServiciosBindingSource.Filter = Nothing
            Exit Sub
        End If

        Dim filtro As String = ""
        Dim texto As String = valor.Replace("'", "''")

        Select Case cmbBuscarPor.Text
            Case "Cliente"
                filtro = "id_cliente LIKE '%" & texto & "%')"
            Case "Plan"
                filtro = "id_plan LIKE '%" & texto & "%')"
            Case "Dirección"
                filtro = "direccion LIKE '%" & texto & "%')"
            Case "Fecha alta"
                Dim fechaAlta As DateTime
                If Not DateTime.TryParse(texto, fechaAlta) Then
                    MsgBox("Ingresá una fecha válida para buscar por Fecha alta.", vbExclamation, "Fecha inválida")
                    Exit Sub
                End If
                Dim fechaAltaInicio As DateTime = fechaAlta.Date
                Dim fechaAltaFin As DateTime = fechaAltaInicio.AddDays(1)
                filtro = "fecha_alta >= #" & fechaAltaInicio.ToString("yyyy-MM-dd") & "# AND fecha_alta < #" & fechaAltaFin.ToString("yyyy-MM-dd") & "#"
            Case "Fecha baja"
                Dim fechaBaja As DateTime
                If Not DateTime.TryParse(texto, fechaBaja) Then
                    MsgBox("Ingresá una fecha válida para buscar por Fecha baja.", vbExclamation, "Fecha inválida")
                    Exit Sub
                End If
                Dim fechaBajaInicio As DateTime = fechaBaja.Date
                Dim fechaBajaFin As DateTime = fechaBajaInicio.AddDays(1)
                filtro = "fecha_baja >= #" & fechaBajaInicio.ToString("yyyy-MM-dd") & "# AND fecha_baja < #" & fechaBajaFin.ToString("yyyy-MM-dd") & "#"
            Case Else
                filtro = "direccion LIKE '%" & texto & "%'"
        End Select

        ServiciosBindingSource.Filter = filtro
    End Sub
End Class
