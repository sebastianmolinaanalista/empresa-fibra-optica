Imports Microsoft.Reporting.WinForms

Public Class frmInformes


    Private Sub frmInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbInforme.SelectedIndex = 0

    End Sub



    Private Sub CargarReporte(nombreArchivoRdlc As String, nombreDataSet As String, datos As DataTable)
        Try
            ' 1. Limpiar orígenes de datos anteriores
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            ' 2. Asignar la ruta del archivo .rdlc correspondiente
            Me.ReportViewer1.LocalReport.ReportPath = nombreArchivoRdlc

            ' 3. Crear el origen de datos con la tabla que le pases
            Dim rds As New ReportDataSource(nombreDataSet, datos)

            ' 4. Agregar la fuente y refrescar el visor
            Me.ReportViewer1.LocalReport.DataSources.Add(rds)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Select Case Me.cmbInforme.Text
            Case "Clientes activos"
                Try

                    Dim adaptador As New _empresa_servicio_internetDataSetTableAdapters.ClientesTableAdapter()
                    Dim tabla As New _empresa_servicio_internetDataSet.ClientesDataTable()

                    adaptador.Fill(tabla)

                    CargarReporte("ReportClientes.rdlc", "DataSet1", DirectCast(tabla, DataTable))

                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try

            Case "Planes contratados"
                Try

                    Dim adaptador As New _empresa_servicio_internetDataSetTableAdapters.PlanesTableAdapter()
                    Dim tabla As New _empresa_servicio_internetDataSet.PlanesDataTable()

                    adaptador.Fill(tabla)

                    CargarReporte("ReportPlanes.rdlc", "DataSet1", DirectCast(tabla, DataTable))

                Catch ex As Exception
                    MessageBox.Show("Error al cargar los planes: " & ex.Message)
                End Try
            Case "Instalaciones pendientes"
                Try
                    Dim adaptadorInstalaciones As New _empresa_servicio_internetDataSetTableAdapters.InstalacionesTableAdapter()
                    Dim tablaInstalaciones As New _empresa_servicio_internetDataSet.InstalacionesDataTable()

                    Dim adaptadorEstados As New _empresa_servicio_internetDataSetTableAdapters.Instalaciones_estadoTableAdapter()
                    Dim tablaEstados As New _empresa_servicio_internetDataSet.Instalaciones_estadoDataTable()

                    ' Llenar ambas tablas
                    adaptadorInstalaciones.Fill(tablaInstalaciones)
                    adaptadorEstados.Fill(tablaEstados)

                    ' Limpiar y configurar el visor con los dos datasets
                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.ReportPath = "ReportInstalaciones.rdlc"

                    Dim rds1 As New ReportDataSource("DataSet1", DirectCast(tablaInstalaciones, DataTable))
                    Dim rds2 As New ReportDataSource("DataSet2", DirectCast(tablaEstados, DataTable))

                    Me.ReportViewer1.LocalReport.DataSources.Add(rds1)
                    Me.ReportViewer1.LocalReport.DataSources.Add(rds2)
                    Me.ReportViewer1.RefreshReport()

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try

            'Case "Instalaciones pendientes"
            '    Try

            '        Dim adaptador As New _empresa_servicio_internetDataSetTableAdapters.InstalacionesTableAdapter()
            '        Dim tabla As New _empresa_servicio_internetDataSet.InstalacionesDataTable()

            '        adaptador.FillByEstado(tabla)

            '        CargarReporte("ReportInstalaciones.rdlc", "DataSet1", DirectCast(tabla, DataTable))

            '    Catch ex As Exception
            '        MessageBox.Show("Error al cargar las instalaciones: " & ex.Message)
            '    End Try

            Case "Pagos por período"
                Try

                    Dim adaptador As New _empresa_servicio_internetDataSetTableAdapters.FacturasTableAdapter()
                    Dim tabla As New _empresa_servicio_internetDataSet.FacturasDataTable()


                    Dim periodoBuscado As String = Me.txtPeriodo.Text


                    adaptador.FillByPeriodo(tabla, periodoBuscado)


                    CargarReporte("ReportFacturas.rdlc", "DataSet1", DirectCast(tabla, DataTable))

                Catch ex As Exception
                    MessageBox.Show("Error al filtrar por periodo: " & ex.Message)
                End Try

            Case Else
                MessageBox.Show("Por favor, seleccione un tipo de informe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        'MsgBox(titulo & vbCrLf & "Desde: " & Me.dtpDesde.Value.ToShortDateString() & vbCrLf & "Hasta: " & Me.dtpHasta.Value.ToShortDateString(), vbInformation, "Reporte")
    End Sub

End Class