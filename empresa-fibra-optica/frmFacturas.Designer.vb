<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_facturaLabel As System.Windows.Forms.Label
        Dim Id_servicioLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim Fecha_vencimientoLabel As System.Windows.Forms.Label
        Dim PeriodoLabel As System.Windows.Forms.Label
        Dim Estado_facturaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblBandera = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me._empresa_servicio_internetDataSet = New empresa_fibra_optica._empresa_servicio_internetDataSet()
        Me.lblFormularioTitulo = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdfacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdservicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechavencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadofacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager()
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.FacturasTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.FacturasTableAdapter()
        Me.Id_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.ImporteTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_vencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PeriodoTextBox = New System.Windows.Forms.TextBox()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.ServiciosTableAdapter()
        Me.cmbEstadoFact = New System.Windows.Forms.ComboBox()
        Me.FacturasestadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Facturas_estadoTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.Facturas_estadoTableAdapter()
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox()
        Id_facturaLabel = New System.Windows.Forms.Label()
        Id_servicioLabel = New System.Windows.Forms.Label()
        ImporteLabel = New System.Windows.Forms.Label()
        Fecha_vencimientoLabel = New System.Windows.Forms.Label()
        PeriodoLabel = New System.Windows.Forms.Label()
        Estado_facturaLabel = New System.Windows.Forms.Label()
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.phPrincipal.SuspendLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasestadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_facturaLabel
        '
        Id_facturaLabel.AutoSize = True
        Id_facturaLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_facturaLabel.Location = New System.Drawing.Point(30, 205)
        Id_facturaLabel.Name = "Id_facturaLabel"
        Id_facturaLabel.Size = New System.Drawing.Size(75, 20)
        Id_facturaLabel.TabIndex = 59
        Id_facturaLabel.Text = "id factura:"
        '
        'Id_servicioLabel
        '
        Id_servicioLabel.AutoSize = True
        Id_servicioLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_servicioLabel.Location = New System.Drawing.Point(30, 265)
        Id_servicioLabel.Name = "Id_servicioLabel"
        Id_servicioLabel.Size = New System.Drawing.Size(79, 20)
        Id_servicioLabel.TabIndex = 61
        Id_servicioLabel.Text = "id servicio:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImporteLabel.Location = New System.Drawing.Point(30, 325)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(65, 20)
        ImporteLabel.TabIndex = 63
        ImporteLabel.Text = "importe:"
        '
        'Fecha_vencimientoLabel
        '
        Fecha_vencimientoLabel.AutoSize = True
        Fecha_vencimientoLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_vencimientoLabel.Location = New System.Drawing.Point(30, 385)
        Fecha_vencimientoLabel.Name = "Fecha_vencimientoLabel"
        Fecha_vencimientoLabel.Size = New System.Drawing.Size(133, 20)
        Fecha_vencimientoLabel.TabIndex = 65
        Fecha_vencimientoLabel.Text = "fecha vencimiento:"
        '
        'PeriodoLabel
        '
        PeriodoLabel.AutoSize = True
        PeriodoLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PeriodoLabel.Location = New System.Drawing.Point(30, 445)
        PeriodoLabel.Name = "PeriodoLabel"
        PeriodoLabel.Size = New System.Drawing.Size(65, 20)
        PeriodoLabel.TabIndex = 67
        PeriodoLabel.Text = "periodo:"
        '
        'Estado_facturaLabel
        '
        Estado_facturaLabel.AutoSize = True
        Estado_facturaLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Estado_facturaLabel.Location = New System.Drawing.Point(30, 505)
        Estado_facturaLabel.Name = "Estado_facturaLabel"
        Estado_facturaLabel.Size = New System.Drawing.Size(107, 20)
        Estado_facturaLabel.TabIndex = 69
        Estado_facturaLabel.Text = "estado factura:"
        '
        'lblBandera
        '
        Me.lblBandera.AutoSize = True
        Me.lblBandera.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBandera.Location = New System.Drawing.Point(1120, 150)
        Me.lblBandera.Name = "lblBandera"
        Me.lblBandera.Size = New System.Drawing.Size(91, 32)
        Me.lblBandera.TabIndex = 59
        Me.lblBandera.Text = "MODO"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(1125, 210)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 58
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        '_empresa_servicio_internetDataSet
        '
        Me._empresa_servicio_internetDataSet.DataSetName = "_empresa_servicio_internetDataSet"
        Me._empresa_servicio_internetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblFormularioTitulo
        '
        Me.lblFormularioTitulo.AutoSize = True
        Me.lblFormularioTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormularioTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblFormularioTitulo.Location = New System.Drawing.Point(30, 150)
        Me.lblFormularioTitulo.Name = "lblFormularioTitulo"
        Me.lblFormularioTitulo.Size = New System.Drawing.Size(230, 32)
        Me.lblFormularioTitulo.TabIndex = 33
        Me.lblFormularioTitulo.Text = "Datos de la factura"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(430, 161)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(110, 19)
        Me.lblBuscar.TabIndex = 50
        Me.lblBuscar.Text = "Buscar facturas"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(546, 157)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(224, 25)
        Me.txtBuscar.TabIndex = 52
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(985, 148)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 40)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(425, 210)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(120, 40)
        Me.btnNuevo.TabIndex = 51
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(705, 210)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 53
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.White
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(565, 210)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(120, 40)
        Me.btnEditar.TabIndex = 54
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(985, 210)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 40)
        Me.btnEliminar.TabIndex = 56
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(845, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 40)
        Me.btnCancelar.TabIndex = 57
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdfacturaDataGridViewTextBoxColumn, Me.IdservicioDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.FechavencimientoDataGridViewTextBoxColumn, Me.PeriodoDataGridViewTextBoxColumn, Me.EstadofacturaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FacturasBindingSource
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(425, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(900, 400)
        Me.DataGridView1.TabIndex = 49
        '
        'IdfacturaDataGridViewTextBoxColumn
        '
        Me.IdfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura"
        Me.IdfacturaDataGridViewTextBoxColumn.FillWeight = 18.0!
        Me.IdfacturaDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdfacturaDataGridViewTextBoxColumn.Name = "IdfacturaDataGridViewTextBoxColumn"
        Me.IdfacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdfacturaDataGridViewTextBoxColumn.Width = 50
        '
        'IdservicioDataGridViewTextBoxColumn
        '
        Me.IdservicioDataGridViewTextBoxColumn.DataPropertyName = "id_servicio"
        Me.IdservicioDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.IdservicioDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.IdservicioDataGridViewTextBoxColumn.Name = "IdservicioDataGridViewTextBoxColumn"
        Me.IdservicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdservicioDataGridViewTextBoxColumn.Width = 340
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "importe"
        Me.ImporteDataGridViewTextBoxColumn.FillWeight = 16.0!
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 95
        '
        'FechavencimientoDataGridViewTextBoxColumn
        '
        Me.FechavencimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_vencimiento"
        Me.FechavencimientoDataGridViewTextBoxColumn.FillWeight = 24.0!
        Me.FechavencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento"
        Me.FechavencimientoDataGridViewTextBoxColumn.Name = "FechavencimientoDataGridViewTextBoxColumn"
        Me.FechavencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechavencimientoDataGridViewTextBoxColumn.Width = 170
        '
        'PeriodoDataGridViewTextBoxColumn
        '
        Me.PeriodoDataGridViewTextBoxColumn.DataPropertyName = "periodo"
        Me.PeriodoDataGridViewTextBoxColumn.FillWeight = 18.0!
        Me.PeriodoDataGridViewTextBoxColumn.HeaderText = "Periodo"
        Me.PeriodoDataGridViewTextBoxColumn.Name = "PeriodoDataGridViewTextBoxColumn"
        Me.PeriodoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeriodoDataGridViewTextBoxColumn.Width = 120
        '
        'EstadofacturaDataGridViewTextBoxColumn
        '
        Me.EstadofacturaDataGridViewTextBoxColumn.DataPropertyName = "estado_factura"
        Me.EstadofacturaDataGridViewTextBoxColumn.FillWeight = 22.0!
        Me.EstadofacturaDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadofacturaDataGridViewTextBoxColumn.Name = "EstadofacturaDataGridViewTextBoxColumn"
        Me.EstadofacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadofacturaDataGridViewTextBoxColumn.Width = 140
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Facturas_estadoTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.Instalaciones_estadoTableAdapter = Nothing
        Me.TableAdapterManager.InstalacionesTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanesTableAdapter = Nothing
        Me.TableAdapterManager.Servicios_estadoTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'phPrincipal
        '
        Me.phPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.phPrincipal.Controls.Add(Me.lblTitulo)
        Me.phPrincipal.Controls.Add(Me.lblSubtitulo)
        Me.phPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.phPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.phPrincipal.Name = "phPrincipal"
        Me.phPrincipal.Size = New System.Drawing.Size(1366, 130)
        Me.phPrincipal.TabIndex = 32
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(28, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(370, 45)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Empresa T1 Token Ring"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblSubtitulo.Location = New System.Drawing.Point(32, 82)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(105, 20)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = " Panel Facturas"
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'Id_facturaTextBox
        '
        Me.Id_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "id_factura", True))
        Me.Id_facturaTextBox.Enabled = False
        Me.Id_facturaTextBox.Location = New System.Drawing.Point(30, 230)
        Me.Id_facturaTextBox.Name = "Id_facturaTextBox"
        Me.Id_facturaTextBox.Size = New System.Drawing.Size(350, 20)
        Me.Id_facturaTextBox.TabIndex = 60
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "importe", True))
        Me.ImporteTextBox.Location = New System.Drawing.Point(30, 350)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(350, 20)
        Me.ImporteTextBox.TabIndex = 64
        '
        'Fecha_vencimientoDateTimePicker
        '
        Me.Fecha_vencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturasBindingSource, "fecha_vencimiento", True))
        Me.Fecha_vencimientoDateTimePicker.Location = New System.Drawing.Point(30, 410)
        Me.Fecha_vencimientoDateTimePicker.Name = "Fecha_vencimientoDateTimePicker"
        Me.Fecha_vencimientoDateTimePicker.Size = New System.Drawing.Size(350, 20)
        Me.Fecha_vencimientoDateTimePicker.TabIndex = 66
        '
        'PeriodoTextBox
        '
        Me.PeriodoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "periodo", True))
        Me.PeriodoTextBox.Location = New System.Drawing.Point(30, 470)
        Me.PeriodoTextBox.Name = "PeriodoTextBox"
        Me.PeriodoTextBox.Size = New System.Drawing.Size(350, 20)
        Me.PeriodoTextBox.TabIndex = 68
        '
        'cmbServicio
        '
        Me.cmbServicio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FacturasBindingSource, "id_servicio", True))
        Me.cmbServicio.DataSource = Me.ServiciosBindingSource
        Me.cmbServicio.DisplayMember = "id_servicio"
        Me.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(30, 290)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(350, 21)
        Me.cmbServicio.TabIndex = 71
        Me.cmbServicio.ValueMember = "id_servicio"
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'cmbEstadoFact
        '
        Me.cmbEstadoFact.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FacturasBindingSource, "estado_factura", True))
        Me.cmbEstadoFact.DataSource = Me.FacturasestadoBindingSource
        Me.cmbEstadoFact.DisplayMember = "nombre"
        Me.cmbEstadoFact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoFact.FormattingEnabled = True
        Me.cmbEstadoFact.Location = New System.Drawing.Point(30, 530)
        Me.cmbEstadoFact.Name = "cmbEstadoFact"
        Me.cmbEstadoFact.Size = New System.Drawing.Size(350, 21)
        Me.cmbEstadoFact.TabIndex = 72
        Me.cmbEstadoFact.ValueMember = "id_factura_estado"
        '
        'FacturasestadoBindingSource
        '
        Me.FacturasestadoBindingSource.DataMember = "Facturas_estado"
        Me.FacturasestadoBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'Facturas_estadoTableAdapter
        '
        Me.Facturas_estadoTableAdapter.ClearBeforeFill = True
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarPor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Importe", "Periodo", "Estado", "FechaVencimiento"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(792, 157)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(173, 25)
        Me.cmbBuscarPor.TabIndex = 73
        '
        'frmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.Controls.Add(Me.cmbEstadoFact)
        Me.Controls.Add(Me.cmbServicio)
        Me.Controls.Add(Id_facturaLabel)
        Me.Controls.Add(Me.Id_facturaTextBox)
        Me.Controls.Add(Id_servicioLabel)
        Me.Controls.Add(ImporteLabel)
        Me.Controls.Add(Me.ImporteTextBox)
        Me.Controls.Add(Fecha_vencimientoLabel)
        Me.Controls.Add(Me.Fecha_vencimientoDateTimePicker)
        Me.Controls.Add(PeriodoLabel)
        Me.Controls.Add(Me.PeriodoTextBox)
        Me.Controls.Add(Estado_facturaLabel)
        Me.Controls.Add(Me.lblBandera)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblFormularioTitulo)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.phPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema T1 Token Ring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasestadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBandera As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents _empresa_servicio_internetDataSet As _empresa_servicio_internetDataSet
    Friend WithEvents lblFormularioTitulo As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableAdapterManager As _empresa_servicio_internetDataSetTableAdapters.TableAdapterManager
    Private WithEvents phPrincipal As Panel
    Private WithEvents lblTitulo As Label
    Private WithEvents lblSubtitulo As Label
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As _empresa_servicio_internetDataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents IdfacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdservicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechavencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadofacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Id_facturaTextBox As TextBox
    Friend WithEvents ImporteTextBox As TextBox
    Friend WithEvents Fecha_vencimientoDateTimePicker As DateTimePicker
    Friend WithEvents PeriodoTextBox As TextBox
    Friend WithEvents cmbServicio As ComboBox
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As _empresa_servicio_internetDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents cmbEstadoFact As ComboBox
    Friend WithEvents FacturasestadoBindingSource As BindingSource
    Friend WithEvents Facturas_estadoTableAdapter As _empresa_servicio_internetDataSetTableAdapters.Facturas_estadoTableAdapter
    Friend WithEvents cmbBuscarPor As ComboBox
End Class
