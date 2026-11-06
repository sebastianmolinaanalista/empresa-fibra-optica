Public Class frmPlanes

    Dim estado As Integer = 0 '0=visor, 1=nuevo, 2=editar
    Dim colId As DataColumn

    Private Sub frmPlanes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colId = Me._empresa_servicio_internetDataSet.Planes.id_planColumn
        colId.AutoIncrement = False

        Me.PlanesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Planes)

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
            Dim resultado As Object = Me.PlanesTableAdapter.getCantidad()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                Dim cantidadFilas As Integer = Convert.ToInt32(resultado)
                siguienteId = cantidadFilas + 1
            Else
                siguienteId = 1
            End If

            Me.PlanesBindingSource.AddNew()
            estadoNuevo()
            Id_planTextBox.Text = siguienteId.ToString()

            NombreTextBox.Focus()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If estado = 0 Then
            estadoEditar()
            NombreTextBox.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado <> 0 Then
            Me.PlanesBindingSource.EndEdit()
            Me.Validate()

            Me.PlanesTableAdapter.Update(Me._empresa_servicio_internetDataSet.Planes)
            Me.PlanesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Planes)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualizacion")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If estado <> 0 Then
            Me.Validate()
            Me.PlanesBindingSource.CancelEdit()
            Me.PlanesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Planes)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(Id_planTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.PlanesTableAdapter.eliminar(Convert.ToInt32(Id_planTextBox.Text))
            Me.PlanesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Planes)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Seguro que desea salir?", vbOKCancel, "Aceptar") = vbOK Then
            If estado <> 0 Then
                Me.Validate()
                Me.PlanesBindingSource.CancelEdit()
                Me.PlanesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Planes)
            End If
            frmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmPlanes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub limpiar()
        Me.PlanesBindingSource.MoveFirst()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String = txtBuscar.Text.Trim()
        If String.IsNullOrWhiteSpace(valor) Then
            PlanesBindingSource.Filter = Nothing
            Exit Sub
        End If

        Dim filtro As String = ""
        Dim texto As String = valor.Replace("'", "''")

        Select Case cmbBuscarPor.Text
            Case "Precio"
                filtro = "precio_mensual LIKE '%" & texto & "%'"
            Case Else
                filtro = "nombre LIKE '%" & texto & "%'"
        End Select

        PlanesBindingSource.Filter = filtro
    End Sub
End Class
