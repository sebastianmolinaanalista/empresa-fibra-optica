<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServicios
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
        Dim Id_servicioLabel As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim Id_planLabel As System.Windows.Forms.Label
        Dim Fecha_altaLabel As System.Windows.Forms.Label
        Dim Fecha_bajaLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim Id_estado_servicioLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicios))
        Me.Id_facturaLabel = New System.Windows.Forms.Label()
        Me._empresa_servicio_internetDataSet = New empresa_fibra_optica._empresa_servicio_internetDataSet()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.lblBandera = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
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
        Me.IdservicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdplanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechabajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdestadoservicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.ServiciosTableAdapter()
        Me.TableAdapterManager = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.ClientesTableAdapter()
        Me.PlanesTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.PlanesTableAdapter()
        Me.Servicios_estadoTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.Servicios_estadoTableAdapter()
        Me.ServiciosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ServiciosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_servicioTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_altaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_bajaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbPlan = New System.Windows.Forms.ComboBox()
        Me.PlanesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbEstadoServ = New System.Windows.Forms.ComboBox()
        Me.ServiciosestadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Id_servicioLabel = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        Id_planLabel = New System.Windows.Forms.Label()
        Fecha_altaLabel = New System.Windows.Forms.Label()
        Fecha_bajaLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        Id_estado_servicioLabel = New System.Windows.Forms.Label()
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.phPrincipal.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServiciosBindingNavigator.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosestadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_facturaLabel
        '
        Me.Id_facturaLabel.AutoSize = True
        Me.Id_facturaLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_facturaLabel.Location = New System.Drawing.Point(30, 205)
        Me.Id_facturaLabel.Name = "Id_facturaLabel"
        Me.Id_facturaLabel.Size = New System.Drawing.Size(75, 20)
        Me.Id_facturaLabel.TabIndex = 86
        Me.Id_facturaLabel.Text = "id factura:"
        '
        'Id_servicioLabel
        '
        Id_servicioLabel.AutoSize = True
        Id_servicioLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_servicioLabel.Location = New System.Drawing.Point(30, 205)
        Id_servicioLabel.Name = "Id_servicioLabel"
        Id_servicioLabel.Size = New System.Drawing.Size(79, 20)
        Id_servicioLabel.TabIndex = 100
        Id_servicioLabel.Text = "id servicio:"
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_clienteLabel.Location = New System.Drawing.Point(30, 265)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(56, 20)
        Id_clienteLabel.TabIndex = 102
        Id_clienteLabel.Text = "cliente:"
        '
        'Id_planLabel
        '
        Id_planLabel.AutoSize = True
        Id_planLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_planLabel.Location = New System.Drawing.Point(30, 325)
        Id_planLabel.Name = "Id_planLabel"
        Id_planLabel.Size = New System.Drawing.Size(41, 20)
        Id_planLabel.TabIndex = 104
        Id_planLabel.Text = "plan:"
        '
        'Fecha_altaLabel
        '
        Fecha_altaLabel.AutoSize = True
        Fecha_altaLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_altaLabel.Location = New System.Drawing.Point(30, 385)
        Fecha_altaLabel.Name = "Fecha_altaLabel"
        Fecha_altaLabel.Size = New System.Drawing.Size(77, 20)
        Fecha_altaLabel.TabIndex = 106
        Fecha_altaLabel.Text = "fecha alta:"
        '
        'Fecha_bajaLabel
        '
        Fecha_bajaLabel.AutoSize = True
        Fecha_bajaLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_bajaLabel.Location = New System.Drawing.Point(30, 445)
        Fecha_bajaLabel.Name = "Fecha_bajaLabel"
        Fecha_bajaLabel.Size = New System.Drawing.Size(81, 20)
        Fecha_bajaLabel.TabIndex = 108
        Fecha_bajaLabel.Text = "fecha baja:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(30, 505)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(73, 20)
        DireccionLabel.TabIndex = 110
        DireccionLabel.Text = "dirección:"
        '
        'Id_estado_servicioLabel
        '
        Id_estado_servicioLabel.AutoSize = True
        Id_estado_servicioLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_estado_servicioLabel.Location = New System.Drawing.Point(30, 605)
        Id_estado_servicioLabel.Name = "Id_estado_servicioLabel"
        Id_estado_servicioLabel.Size = New System.Drawing.Size(111, 20)
        Id_estado_servicioLabel.TabIndex = 112
        Id_estado_servicioLabel.Text = "estado servicio:"
        '
        '_empresa_servicio_internetDataSet
        '
        Me._empresa_servicio_internetDataSet.DataSetName = "_empresa_servicio_internetDataSet"
        Me._empresa_servicio_internetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.lblSubtitulo.Size = New System.Drawing.Size(110, 20)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = " Panel Servicios"
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarPor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Cliente", "Plan", "Fecha alta", "Fecha baja", "Dirección"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(792, 157)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(173, 25)
        Me.cmbBuscarPor.TabIndex = 99
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
        Me.phPrincipal.TabIndex = 74
        '
        'lblBandera
        '
        Me.lblBandera.AutoSize = True
        Me.lblBandera.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBandera.Location = New System.Drawing.Point(1120, 150)
        Me.lblBandera.Name = "lblBandera"
        Me.lblBandera.Size = New System.Drawing.Size(91, 32)
        Me.lblBandera.TabIndex = 87
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
        Me.btnSalir.TabIndex = 85
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblFormularioTitulo
        '
        Me.lblFormularioTitulo.AutoSize = True
        Me.lblFormularioTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormularioTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblFormularioTitulo.Location = New System.Drawing.Point(30, 150)
        Me.lblFormularioTitulo.Name = "lblFormularioTitulo"
        Me.lblFormularioTitulo.Size = New System.Drawing.Size(218, 32)
        Me.lblFormularioTitulo.TabIndex = 75
        Me.lblFormularioTitulo.Text = "Datos del servicio"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(430, 161)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(110, 19)
        Me.lblBuscar.TabIndex = 77
        Me.lblBuscar.Text = "Buscar servicio"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(546, 157)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(224, 25)
        Me.txtBuscar.TabIndex = 79
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(985, 148)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 40)
        Me.btnBuscar.TabIndex = 82
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
        Me.btnNuevo.TabIndex = 78
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
        Me.btnGuardar.TabIndex = 80
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
        Me.btnEditar.TabIndex = 81
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
        Me.btnEliminar.TabIndex = 83
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
        Me.btnCancelar.TabIndex = 84
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdservicioDataGridViewTextBoxColumn, Me.IdclienteDataGridViewTextBoxColumn, Me.IdplanDataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn, Me.FechabajaDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.IdestadoservicioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiciosBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(425, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(900, 400)
        Me.DataGridView1.TabIndex = 76
        '
        'IdservicioDataGridViewTextBoxColumn
        '
        Me.IdservicioDataGridViewTextBoxColumn.DataPropertyName = "id_servicio"
        Me.IdservicioDataGridViewTextBoxColumn.FillWeight = 18.0!
        Me.IdservicioDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdservicioDataGridViewTextBoxColumn.Name = "IdservicioDataGridViewTextBoxColumn"
        Me.IdservicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdservicioDataGridViewTextBoxColumn.Width = 70
        '
        'IdclienteDataGridViewTextBoxColumn
        '
        Me.IdclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente"
        Me.IdclienteDataGridViewTextBoxColumn.FillWeight = 18.0!
        Me.IdclienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.IdclienteDataGridViewTextBoxColumn.Name = "IdclienteDataGridViewTextBoxColumn"
        Me.IdclienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdplanDataGridViewTextBoxColumn
        '
        Me.IdplanDataGridViewTextBoxColumn.DataPropertyName = "id_plan"
        Me.IdplanDataGridViewTextBoxColumn.FillWeight = 18.0!
        Me.IdplanDataGridViewTextBoxColumn.HeaderText = "Plan"
        Me.IdplanDataGridViewTextBoxColumn.Name = "IdplanDataGridViewTextBoxColumn"
        Me.IdplanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fecha_alta"
        Me.FechaaltaDataGridViewTextBoxColumn.FillWeight = 24.0!
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "Alta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        Me.FechaaltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaaltaDataGridViewTextBoxColumn.Width = 140
        '
        'FechabajaDataGridViewTextBoxColumn
        '
        Me.FechabajaDataGridViewTextBoxColumn.DataPropertyName = "fecha_baja"
        Me.FechabajaDataGridViewTextBoxColumn.FillWeight = 24.0!
        Me.FechabajaDataGridViewTextBoxColumn.HeaderText = "Baja"
        Me.FechabajaDataGridViewTextBoxColumn.Name = "FechabajaDataGridViewTextBoxColumn"
        Me.FechabajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechabajaDataGridViewTextBoxColumn.Width = 140
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 220
        '
        'IdestadoservicioDataGridViewTextBoxColumn
        '
        Me.IdestadoservicioDataGridViewTextBoxColumn.DataPropertyName = "id_estado_servicio"
        Me.IdestadoservicioDataGridViewTextBoxColumn.FillWeight = 24.0!
        Me.IdestadoservicioDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.IdestadoservicioDataGridViewTextBoxColumn.Name = "IdestadoservicioDataGridViewTextBoxColumn"
        Me.IdestadoservicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdestadoservicioDataGridViewTextBoxColumn.Width = 130
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.Facturas_estadoTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.Instalaciones_estadoTableAdapter = Nothing
        Me.TableAdapterManager.InstalacionesTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanesTableAdapter = Me.PlanesTableAdapter
        Me.TableAdapterManager.Servicios_estadoTableAdapter = Me.Servicios_estadoTableAdapter
        Me.TableAdapterManager.ServiciosTableAdapter = Me.ServiciosTableAdapter
        Me.TableAdapterManager.UpdateOrder = empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'PlanesTableAdapter
        '
        Me.PlanesTableAdapter.ClearBeforeFill = True
        '
        'Servicios_estadoTableAdapter
        '
        Me.Servicios_estadoTableAdapter.ClearBeforeFill = True
        '
        'ServiciosBindingNavigator
        '
        Me.ServiciosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ServiciosBindingNavigator.BindingSource = Me.ServiciosBindingSource
        Me.ServiciosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ServiciosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ServiciosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ServiciosBindingNavigator.Enabled = False
        Me.ServiciosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ServiciosBindingNavigatorSaveItem})
        Me.ServiciosBindingNavigator.Location = New System.Drawing.Point(0, 130)
        Me.ServiciosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ServiciosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ServiciosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ServiciosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ServiciosBindingNavigator.Name = "ServiciosBindingNavigator"
        Me.ServiciosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ServiciosBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.ServiciosBindingNavigator.TabIndex = 100
        Me.ServiciosBindingNavigator.Text = "BindingNavigator1"
        Me.ServiciosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ServiciosBindingNavigatorSaveItem
        '
        Me.ServiciosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ServiciosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ServiciosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ServiciosBindingNavigatorSaveItem.Name = "ServiciosBindingNavigatorSaveItem"
        Me.ServiciosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ServiciosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_servicioTextBox
        '
        Me.Id_servicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "id_servicio", True))
        Me.Id_servicioTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_servicioTextBox.Location = New System.Drawing.Point(30, 228)
        Me.Id_servicioTextBox.Name = "Id_servicioTextBox"
        Me.Id_servicioTextBox.ReadOnly = True
        Me.Id_servicioTextBox.Size = New System.Drawing.Size(350, 25)
        Me.Id_servicioTextBox.TabIndex = 101
        '
        'Fecha_altaDateTimePicker
        '
        Me.Fecha_altaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ServiciosBindingSource, "fecha_alta", True))
        Me.Fecha_altaDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_altaDateTimePicker.Location = New System.Drawing.Point(30, 408)
        Me.Fecha_altaDateTimePicker.Name = "Fecha_altaDateTimePicker"
        Me.Fecha_altaDateTimePicker.Size = New System.Drawing.Size(350, 25)
        Me.Fecha_altaDateTimePicker.TabIndex = 107
        '
        'Fecha_bajaDateTimePicker
        '
        Me.Fecha_bajaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ServiciosBindingSource, "fecha_baja", True))
        Me.Fecha_bajaDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_bajaDateTimePicker.Location = New System.Drawing.Point(30, 468)
        Me.Fecha_bajaDateTimePicker.Name = "Fecha_bajaDateTimePicker"
        Me.Fecha_bajaDateTimePicker.Size = New System.Drawing.Size(350, 25)
        Me.Fecha_bajaDateTimePicker.TabIndex = 109
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(30, 528)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(350, 60)
        Me.DireccionTextBox.TabIndex = 111
        '
        'cmbCliente
        '
        Me.cmbCliente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiciosBindingSource, "id_cliente", True))
        Me.cmbCliente.DataSource = Me.ClientesBindingSource
        Me.cmbCliente.DisplayMember = "nombre_apellido"
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(30, 288)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(350, 25)
        Me.cmbCliente.TabIndex = 113
        Me.cmbCliente.ValueMember = "id_cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'cmbPlan
        '
        Me.cmbPlan.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiciosBindingSource, "id_plan", True))
        Me.cmbPlan.DataSource = Me.PlanesBindingSource
        Me.cmbPlan.DisplayMember = "nombre"
        Me.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlan.FormattingEnabled = True
        Me.cmbPlan.Location = New System.Drawing.Point(30, 348)
        Me.cmbPlan.Name = "cmbPlan"
        Me.cmbPlan.Size = New System.Drawing.Size(350, 25)
        Me.cmbPlan.TabIndex = 114
        Me.cmbPlan.ValueMember = "id_plan"
        '
        'PlanesBindingSource
        '
        Me.PlanesBindingSource.DataMember = "Planes"
        Me.PlanesBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'cmbEstadoServ
        '
        Me.cmbEstadoServ.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServiciosBindingSource, "id_estado_servicio", True))
        Me.cmbEstadoServ.DataSource = Me.ServiciosestadoBindingSource
        Me.cmbEstadoServ.DisplayMember = "nombre"
        Me.cmbEstadoServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoServ.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoServ.FormattingEnabled = True
        Me.cmbEstadoServ.Location = New System.Drawing.Point(30, 628)
        Me.cmbEstadoServ.Name = "cmbEstadoServ"
        Me.cmbEstadoServ.Size = New System.Drawing.Size(350, 25)
        Me.cmbEstadoServ.TabIndex = 115
        Me.cmbEstadoServ.ValueMember = "id_servicio_estado"
        '
        'ServiciosestadoBindingSource
        '
        Me.ServiciosestadoBindingSource.DataMember = "Servicios_estado"
        Me.ServiciosestadoBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.cmbEstadoServ)
        Me.Controls.Add(Me.cmbPlan)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Id_servicioLabel)
        Me.Controls.Add(Me.Id_servicioTextBox)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Id_planLabel)
        Me.Controls.Add(Fecha_altaLabel)
        Me.Controls.Add(Me.Fecha_altaDateTimePicker)
        Me.Controls.Add(Fecha_bajaLabel)
        Me.Controls.Add(Me.Fecha_bajaDateTimePicker)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Id_estado_servicioLabel)
        Me.Controls.Add(Me.ServiciosBindingNavigator)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.Controls.Add(Me.phPrincipal)
        Me.Controls.Add(Me.Id_facturaLabel)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmServicios"
        Me.Text = "Sistema T1 Token Ring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServiciosBindingNavigator.ResumeLayout(False)
        Me.ServiciosBindingNavigator.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosestadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _empresa_servicio_internetDataSet As _empresa_servicio_internetDataSet
    Private WithEvents lblTitulo As Label
    Private WithEvents lblSubtitulo As Label
    Friend WithEvents cmbBuscarPor As ComboBox
    Private WithEvents phPrincipal As Panel
    Friend WithEvents lblBandera As Label
    Friend WithEvents btnSalir As Button
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
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As _empresa_servicio_internetDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents TableAdapterManager As _empresa_servicio_internetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServiciosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ServiciosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdservicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdplanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechabajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdestadoservicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientesTableAdapter As _empresa_servicio_internetDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents Id_servicioTextBox As TextBox
    Friend WithEvents Fecha_altaDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_bajaDateTimePicker As DateTimePicker
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbPlan As ComboBox
    Friend WithEvents cmbEstadoServ As ComboBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents PlanesTableAdapter As _empresa_servicio_internetDataSetTableAdapters.PlanesTableAdapter
    Friend WithEvents PlanesBindingSource As BindingSource
    Friend WithEvents Servicios_estadoTableAdapter As _empresa_servicio_internetDataSetTableAdapters.Servicios_estadoTableAdapter
    Friend WithEvents ServiciosestadoBindingSource As BindingSource
    Friend WithEvents Id_facturaLabel As Label
End Class
