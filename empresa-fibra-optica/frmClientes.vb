Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmClientes

    Dim estado As Integer = 0 '0=visor, 1=nuevo, 2=editar
    Dim colId As DataColumn

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._empresa_servicio_internetDataSet)

    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colId = Me._empresa_servicio_internetDataSet.Clientes.id_clienteColumn
        colId.AutoIncrement = False
        'TODO: esta línea de código carga datos en la tabla '_empresa_servicio_internetDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Clientes)

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
            Dim resultado As Object = Me.ClientesTableAdapter.getCantidad()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                Dim cantidadFilas As Integer = Convert.ToInt32(resultado)
                siguienteId = cantidadFilas + 1
            Else
                siguienteId = 1
            End If

            Me.ClientesBindingSource.AddNew()
            estadoNuevo()
            Id_clienteTextBox.Text = siguienteId.ToString()

            Nombre_apellidoTextBox.Focus()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If estado = 0 Then
            estadoEditar()
            Nombre_apellidoTextBox.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado <> 0 Then
            Me.ClientesBindingSource.EndEdit()
            Me.Validate()

            Me.TableAdapterManager.UpdateAll(Me._empresa_servicio_internetDataSet)
            Me.ClientesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Clientes)
            MsgBox("Se han guardado los datos correctamente", vbOKOnly, "Actualizacion")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If estado <> 0 Then
            Me.Validate()
            Me.ClientesBindingSource.CancelEdit()
            Me.ClientesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Clientes)
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(Id_clienteTextBox.Text) Then
            MsgBox("Debe seleccionar un registro de la lista antes de eliminar.", vbExclamation, "Atención")
            Exit Sub
        End If

        Dim mensaje As Object = MsgBox("¿Seguro que desea eliminar el registro seleccionado?", vbOKCancel, "Confirmar eliminación")
        If mensaje = vbOK Then
            Me.ClientesTableAdapter.Eliminar(Convert.ToInt32(Id_clienteTextBox.Text))
            Me.ClientesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Clientes)
            MsgBox("Registro eliminado correctamente.", vbInformation, "Éxito")
            estadoVisor()
            limpiar()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Seguro que desea salir?", vbOKCancel, "Aceptar") = vbOK Then
            If estado <> 0 Then
                Me.Validate()
                Me.ClientesBindingSource.CancelEdit()
                Me.ClientesTableAdapter.Fill(Me._empresa_servicio_internetDataSet.Clientes)
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
        Me.ClientesBindingSource.MoveFirst()
    End Sub
End Class