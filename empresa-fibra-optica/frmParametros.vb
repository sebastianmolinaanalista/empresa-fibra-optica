Public Class frmParametros

    Dim estado As Integer = 0 '0=visor, 1=nuevo, 2=editar

    Dim colId1 As DataColumn
    Dim colId2 As DataColumn
    Dim colId3 As DataColumn

    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Instalaciones_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones_estado)
        Me.Servicios_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios_estado)
        Me.Facturas_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas_estado)

    End Sub


    Private Sub estadoVisor()
        estado = 0
        lblBandera1.Text = "VISOR"
        lblBandera2.Text = "VISOR"
        lblBandera3.Text = "VISOR"

        btnNuevo1.Enabled = True
        btnNuevo2.Enabled = True
        btnNuevo3.Enabled = True
        btnEditar1.Enabled = True
        btnEditar2.Enabled = True
        btnEditar3.Enabled = True
        btnEliminar1.Enabled = True
        btnEliminar2.Enabled = True
        btnEliminar3.Enabled = True
        btnGuardar1.Enabled = False
        btnGuardar2.Enabled = False
        btnGuardar3.Enabled = False
        btnCancelar1.Enabled = False
        btnCancelar2.Enabled = False
        btnCancelar3.Enabled = False
    End Sub

    Private Sub estadoNuevo()
        estado = 1
        lblBandera1.Text = "NUEVO"
        lblBandera2.Text = "NUEVO"
        lblBandera3.Text = "NUEVO"
        btnGuardar1.Enabled = True
        btnGuardar2.Enabled = True
        btnGuardar3.Enabled = True
        btnCancelar1.Enabled = True
        btnCancelar2.Enabled = True
        btnCancelar3.Enabled = True
        btnNuevo1.Enabled = False
        btnNuevo2.Enabled = False
        btnNuevo3.Enabled = False
        btnEditar1.Enabled = False
        btnEditar2.Enabled = False
        btnEditar3.Enabled = False
        btnEliminar1.Enabled = False
        btnEliminar2.Enabled = False
        btnEliminar3.Enabled = False
    End Sub

    Private Sub estadoEditar()
        estado = 2
        lblBandera1.Text = "EDITAR"
        lblBandera2.Text = "EDITAR"
        lblBandera3.Text = "EDITAR"
        btnGuardar1.Enabled = True
        btnGuardar2.Enabled = True
        btnGuardar3.Enabled = True
        btnCancelar1.Enabled = True
        btnCancelar2.Enabled = True
        btnCancelar3.Enabled = True
        btnNuevo1.Enabled = False
        btnNuevo2.Enabled = False
        btnNuevo3.Enabled = False
        btnEditar1.Enabled = False
        btnEditar2.Enabled = False
        btnEditar3.Enabled = False
        btnEliminar1.Enabled = False
        btnEliminar2.Enabled = False
        btnEliminar3.Enabled = False
    End Sub

    Private Sub frmParametros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub btnNuevo1_Click(sender As Object, e As EventArgs) Handles btnNuevo1.Click
        If estado = 0 Then
            Me.Validate()
            Dim siguienteId As Integer = 1
            Dim resultado As Object = Me.Instalaciones_estadoTableAdapter.getCantidad()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                Dim cantidadFilas As Integer = Convert.ToInt32(resultado)
                siguienteId = cantidadFilas + 1
            Else
                siguienteId = 1
            End If

            Me.Instalaciones_estadoBindingSource.AddNew()
            estadoNuevo()
            Id_instalacion_estadoTextBox.Text = siguienteId.ToString()
        End If
    End Sub

    Private Sub btnEditar1_Click(sender As Object, e As EventArgs) Handles btnEditar1.Click
        If estado = 0 Then
            estadoEditar()
            NombreTextBox.Focus()
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        If estado <> 0 Then
            Me.Instalaciones_estadoBindingSource.EndEdit()
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me._empresa_servicio_internetDataSet)
            Me.Instalaciones_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones_estado)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualizacion")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar1_Click(sender As Object, e As EventArgs) Handles btnCancelar1.Click
        If estado <> 0 Then
            Me.Validate()
            Me.Instalaciones_estadoBindingSource.CancelEdit()
            Me.Instalaciones_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones_estado)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        If String.IsNullOrWhiteSpace(Id_factura_estadoTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.Instalaciones_estadoTableAdapter.eliminar(Convert.ToInt32(Id_instalacion_estadoTextBox.Text))
            Me.Instalaciones_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Instalaciones_estado)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub


    Private Sub btnNuevo2_Click(sender As Object, e As EventArgs) Handles btnNuevo2.Click
        If estado = 0 Then
            Me.Validate()
            Dim siguienteId As Integer = 1
            Dim resultado As Object = Me.Servicios_estadoTableAdapter.getCantidad()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                Dim cantidadFilas As Integer = Convert.ToInt32(resultado)
                siguienteId = cantidadFilas + 1
            Else
                siguienteId = 1
            End If

            Me.Servicios_estadoBindingSource.AddNew()
            estadoNuevo()
            Id_servicio_estadoTextBox.Text = siguienteId.ToString()
        End If
    End Sub

    Private Sub btnEditar2_Click(sender As Object, e As EventArgs) Handles btnEditar2.Click
        If estado = 0 Then
            estadoEditar()
            NombreTextBox1.Focus()
        End If
    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        If estado <> 0 Then
            Me.Servicios_estadoBindingSource.EndEdit()
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me._empresa_servicio_internetDataSet)
            Me.Servicios_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios_estado)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualizacion")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar2_Click(sender As Object, e As EventArgs) Handles btnCancelar2.Click
        If estado <> 0 Then
            Me.Validate()
            Me.Servicios_estadoBindingSource.CancelEdit()
            Me.Servicios_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios_estado)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        If String.IsNullOrWhiteSpace(Id_factura_estadoTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.Servicios_estadoTableAdapter.eliminar(Convert.ToInt32(Id_servicio_estadoTextBox.Text))
            Me.Servicios_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Servicios_estado)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnNuevo3_Click(sender As Object, e As EventArgs) Handles btnNuevo3.Click
        If estado = 0 Then
            Me.Validate()
            Dim siguienteId As Integer = 1
            Dim resultado As Object = Me.Facturas_estadoTableAdapter.getCantidad()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                Dim cantidadFilas As Integer = Convert.ToInt32(resultado)
                siguienteId = cantidadFilas + 1
            Else
                siguienteId = 1
            End If

            Me.Facturas_estadoBindingSource.AddNew()
            estadoNuevo()
            Id_factura_estadoTextBox.Text = siguienteId.ToString()
        End If
    End Sub

    Private Sub btnEditar3_Click(sender As Object, e As EventArgs) Handles btnEditar3.Click
        If estado = 0 Then
            estadoEditar()
            NombreTextBox2.Focus()
        End If
    End Sub

    Private Sub btnGuardar3_Click(sender As Object, e As EventArgs) Handles btnGuardar3.Click
        If estado <> 0 Then
            Me.Facturas_estadoBindingSource.EndEdit()
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me._empresa_servicio_internetDataSet)
            Me.Facturas_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas_estado)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualizacion")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar3_Click(sender As Object, e As EventArgs) Handles btnCancelar3.Click
        If estado <> 0 Then
            Me.Validate()
            Me.Facturas_estadoBindingSource.CancelEdit()
            Me.Facturas_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas_estado)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar3_Click(sender As Object, e As EventArgs) Handles btnEliminar3.Click
        If String.IsNullOrWhiteSpace(Id_factura_estadoTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.Facturas_estadoTableAdapter.eliminar(Convert.ToInt32(Id_factura_estadoTextBox.Text))
            Me.Facturas_estadoTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Facturas_estado)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub limpiar()
        Me.Instalaciones_estadoBindingSource.MoveFirst()
        Me.Servicios_estadoBindingSource.MoveFirst()
        Me.Facturas_estadoBindingSource.MoveFirst()
    End Sub
End Class