<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParametros
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
        Dim Id_instalacion_estadoLabel As System.Windows.Forms.Label
        Dim Id_servicio_estadoLabel As System.Windows.Forms.Label
        Dim Id_factura_estadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim NombreLabel2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.tabParametros = New System.Windows.Forms.TabControl()
        Me.tpInstalacionesEstado = New System.Windows.Forms.TabPage()
        Me.lblBandera1 = New System.Windows.Forms.Label()
        Me.btnNuevo1 = New System.Windows.Forms.Button()
        Me.Id_instalacion_estadoTextBox = New System.Windows.Forms.TextBox()
        Me.Instalaciones_estadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._empresa_servicio_internetDataSet = New empresa_fibra_optica._empresa_servicio_internetDataSet()
        Me.NombreTextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdinstalacionestadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar1 = New System.Windows.Forms.Button()
        Me.btnEditar1 = New System.Windows.Forms.Button()
        Me.btnEliminar1 = New System.Windows.Forms.Button()
        Me.btnCancelar1 = New System.Windows.Forms.Button()
        Me.lblInstalaciones = New System.Windows.Forms.Label()
        Me.tpServiciosEstado = New System.Windows.Forms.TabPage()
        Me.lblBandera2 = New System.Windows.Forms.Label()
        Me.Id_servicio_estadoTextBox = New System.Windows.Forms.TextBox()
        Me.Servicios_estadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNuevo2 = New System.Windows.Forms.Button()
        Me.btnGuardar2 = New System.Windows.Forms.Button()
        Me.btnEditar2 = New System.Windows.Forms.Button()
        Me.btnEliminar2 = New System.Windows.Forms.Button()
        Me.btnCancelar2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdservicioestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblServicios = New System.Windows.Forms.Label()
        Me.tpFacturasEstado = New System.Windows.Forms.TabPage()
        Me.lblBandera3 = New System.Windows.Forms.Label()
        Me.Id_factura_estadoTextBox = New System.Windows.Forms.TextBox()
        Me.Facturas_estadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.btnNuevo3 = New System.Windows.Forms.Button()
        Me.btnGuardar3 = New System.Windows.Forms.Button()
        Me.btnEditar3 = New System.Windows.Forms.Button()
        Me.btnEliminar3 = New System.Windows.Forms.Button()
        Me.btnCancelar3 = New System.Windows.Forms.Button()
        Me.lblFacturas = New System.Windows.Forms.Label()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.IdfacturaestadoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdinstalacionestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdfacturaestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdfacturaestadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Facturas_estadoTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.Facturas_estadoTableAdapter()
        Me.TableAdapterManager = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager()
        Me.Instalaciones_estadoTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.Instalaciones_estadoTableAdapter()
        Me.Servicios_estadoTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.Servicios_estadoTableAdapter()
        Me.Facturas_estadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Facturas_estadoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Id_instalacion_estadoLabel = New System.Windows.Forms.Label()
        Id_servicio_estadoLabel = New System.Windows.Forms.Label()
        Id_factura_estadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        NombreLabel2 = New System.Windows.Forms.Label()
        Me.phPrincipal.SuspendLayout()
        Me.tabParametros.SuspendLayout()
        Me.tpInstalacionesEstado.SuspendLayout()
        CType(Me.Instalaciones_estadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpServiciosEstado.SuspendLayout()
        CType(Me.Servicios_estadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFacturasEstado.SuspendLayout()
        CType(Me.Facturas_estadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Facturas_estadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Facturas_estadoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_instalacion_estadoLabel
        '
        Id_instalacion_estadoLabel.AutoSize = True
        Id_instalacion_estadoLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Id_instalacion_estadoLabel.Location = New System.Drawing.Point(20, 65)
        Id_instalacion_estadoLabel.Name = "Id_instalacion_estadoLabel"
        Id_instalacion_estadoLabel.Size = New System.Drawing.Size(27, 20)
        Id_instalacion_estadoLabel.TabIndex = 48
        Id_instalacion_estadoLabel.Text = "ID:"
        '
        'Id_servicio_estadoLabel
        '
        Id_servicio_estadoLabel.AutoSize = True
        Id_servicio_estadoLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Id_servicio_estadoLabel.Location = New System.Drawing.Point(20, 65)
        Id_servicio_estadoLabel.Name = "Id_servicio_estadoLabel"
        Id_servicio_estadoLabel.Size = New System.Drawing.Size(27, 20)
        Id_servicio_estadoLabel.TabIndex = 58
        Id_servicio_estadoLabel.Text = "ID:"
        '
        'Id_factura_estadoLabel
        '
        Id_factura_estadoLabel.AutoSize = True
        Id_factura_estadoLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Id_factura_estadoLabel.Location = New System.Drawing.Point(22, 65)
        Id_factura_estadoLabel.Name = "Id_factura_estadoLabel"
        Id_factura_estadoLabel.Size = New System.Drawing.Size(27, 20)
        Id_factura_estadoLabel.TabIndex = 62
        Id_factura_estadoLabel.Text = "ID:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        NombreLabel.Location = New System.Drawing.Point(190, 66)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(64, 20)
        NombreLabel.TabIndex = 64
        NombreLabel.Text = "nombre:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        NombreLabel1.Location = New System.Drawing.Point(190, 65)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(64, 20)
        NombreLabel1.TabIndex = 60
        NombreLabel1.Text = "nombre:"
        '
        'NombreLabel2
        '
        NombreLabel2.AutoSize = True
        NombreLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        NombreLabel2.Location = New System.Drawing.Point(190, 67)
        NombreLabel2.Name = "NombreLabel2"
        NombreLabel2.Size = New System.Drawing.Size(64, 20)
        NombreLabel2.TabIndex = 50
        NombreLabel2.Text = "nombre:"
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
        Me.lblSubtitulo.Size = New System.Drawing.Size(122, 20)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Panel Parametros"
        '
        'phPrincipal
        '
        Me.phPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.phPrincipal.Controls.Add(Me.lblTitulo)
        Me.phPrincipal.Controls.Add(Me.lblSubtitulo)
        Me.phPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.phPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.phPrincipal.Name = "phPrincipal"
        Me.phPrincipal.Size = New System.Drawing.Size(539, 130)
        Me.phPrincipal.TabIndex = 18
        '
        'tabParametros
        '
        Me.tabParametros.Controls.Add(Me.tpInstalacionesEstado)
        Me.tabParametros.Controls.Add(Me.tpServiciosEstado)
        Me.tabParametros.Controls.Add(Me.tpFacturasEstado)
        Me.tabParametros.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabParametros.Location = New System.Drawing.Point(30, 155)
        Me.tabParametros.Name = "tabParametros"
        Me.tabParametros.SelectedIndex = 0
        Me.tabParametros.Size = New System.Drawing.Size(482, 520)
        Me.tabParametros.TabIndex = 2
        '
        'tpInstalacionesEstado
        '
        Me.tpInstalacionesEstado.AutoScroll = True
        Me.tpInstalacionesEstado.Controls.Add(Me.lblBandera1)
        Me.tpInstalacionesEstado.Controls.Add(Me.btnNuevo1)
        Me.tpInstalacionesEstado.Controls.Add(Me.Id_instalacion_estadoTextBox)
        Me.tpInstalacionesEstado.Controls.Add(NombreLabel2)
        Me.tpInstalacionesEstado.Controls.Add(Me.NombreTextBox2)
        Me.tpInstalacionesEstado.Controls.Add(Id_instalacion_estadoLabel)
        Me.tpInstalacionesEstado.Controls.Add(Me.DataGridView2)
        Me.tpInstalacionesEstado.Controls.Add(Me.btnGuardar1)
        Me.tpInstalacionesEstado.Controls.Add(Me.btnEditar1)
        Me.tpInstalacionesEstado.Controls.Add(Me.btnEliminar1)
        Me.tpInstalacionesEstado.Controls.Add(Me.btnCancelar1)
        Me.tpInstalacionesEstado.Controls.Add(Me.lblInstalaciones)
        Me.tpInstalacionesEstado.Location = New System.Drawing.Point(4, 26)
        Me.tpInstalacionesEstado.Name = "tpInstalacionesEstado"
        Me.tpInstalacionesEstado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInstalacionesEstado.Size = New System.Drawing.Size(568, 490)
        Me.tpInstalacionesEstado.TabIndex = 0
        Me.tpInstalacionesEstado.Text = "Instalaciones"
        Me.tpInstalacionesEstado.UseVisualStyleBackColor = True
        '
        'lblBandera1
        '
        Me.lblBandera1.AutoSize = True
        Me.lblBandera1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandera1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBandera1.Location = New System.Drawing.Point(355, 20)
        Me.lblBandera1.Name = "lblBandera1"
        Me.lblBandera1.Size = New System.Drawing.Size(91, 32)
        Me.lblBandera1.TabIndex = 53
        Me.lblBandera1.Text = "MODO"
        '
        'btnNuevo1
        '
        Me.btnNuevo1.BackColor = System.Drawing.Color.White
        Me.btnNuevo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo1.Location = New System.Drawing.Point(22, 100)
        Me.btnNuevo1.Name = "btnNuevo1"
        Me.btnNuevo1.Size = New System.Drawing.Size(80, 40)
        Me.btnNuevo1.TabIndex = 52
        Me.btnNuevo1.Text = "Nuevo"
        Me.btnNuevo1.UseVisualStyleBackColor = False
        '
        'Id_instalacion_estadoTextBox
        '
        Me.Id_instalacion_estadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Instalaciones_estadoBindingSource, "id_instalacion_estado", True))
        Me.Id_instalacion_estadoTextBox.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Id_instalacion_estadoTextBox.Location = New System.Drawing.Point(53, 63)
        Me.Id_instalacion_estadoTextBox.Name = "Id_instalacion_estadoTextBox"
        Me.Id_instalacion_estadoTextBox.Size = New System.Drawing.Size(100, 27)
        Me.Id_instalacion_estadoTextBox.TabIndex = 49
        '
        'Instalaciones_estadoBindingSource
        '
        Me.Instalaciones_estadoBindingSource.DataMember = "Instalaciones_estado"
        Me.Instalaciones_estadoBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        '_empresa_servicio_internetDataSet
        '
        Me._empresa_servicio_internetDataSet.DataSetName = "_empresa_servicio_internetDataSet"
        Me._empresa_servicio_internetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox2
        '
        Me.NombreTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Instalaciones_estadoBindingSource, "nombre", True))
        Me.NombreTextBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.NombreTextBox2.Location = New System.Drawing.Point(256, 63)
        Me.NombreTextBox2.Name = "NombreTextBox2"
        Me.NombreTextBox2.Size = New System.Drawing.Size(190, 27)
        Me.NombreTextBox2.TabIndex = 51
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdinstalacionestadoDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn2})
        Me.DataGridView2.DataSource = Me.Instalaciones_estadoBindingSource
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(22, 160)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(424, 300)
        Me.DataGridView2.TabIndex = 48
        '
        'IdinstalacionestadoDataGridViewTextBoxColumn1
        '
        Me.IdinstalacionestadoDataGridViewTextBoxColumn1.DataPropertyName = "id_instalacion_estado"
        Me.IdinstalacionestadoDataGridViewTextBoxColumn1.HeaderText = "id_instalacion_estado"
        Me.IdinstalacionestadoDataGridViewTextBoxColumn1.Name = "IdinstalacionestadoDataGridViewTextBoxColumn1"
        Me.IdinstalacionestadoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        Me.NombreDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.BackColor = System.Drawing.Color.White
        Me.btnGuardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar1.Location = New System.Drawing.Point(194, 100)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(80, 40)
        Me.btnGuardar1.TabIndex = 42
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseVisualStyleBackColor = False
        '
        'btnEditar1
        '
        Me.btnEditar1.BackColor = System.Drawing.Color.White
        Me.btnEditar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar1.Location = New System.Drawing.Point(108, 100)
        Me.btnEditar1.Name = "btnEditar1"
        Me.btnEditar1.Size = New System.Drawing.Size(80, 40)
        Me.btnEditar1.TabIndex = 43
        Me.btnEditar1.Text = "Editar"
        Me.btnEditar1.UseVisualStyleBackColor = False
        '
        'btnEliminar1
        '
        Me.btnEliminar1.BackColor = System.Drawing.Color.White
        Me.btnEliminar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar1.Location = New System.Drawing.Point(366, 100)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(80, 40)
        Me.btnEliminar1.TabIndex = 44
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseVisualStyleBackColor = False
        '
        'btnCancelar1
        '
        Me.btnCancelar1.BackColor = System.Drawing.Color.White
        Me.btnCancelar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar1.Location = New System.Drawing.Point(280, 100)
        Me.btnCancelar1.Name = "btnCancelar1"
        Me.btnCancelar1.Size = New System.Drawing.Size(80, 40)
        Me.btnCancelar1.TabIndex = 45
        Me.btnCancelar1.Text = "Cancelar"
        Me.btnCancelar1.UseVisualStyleBackColor = False
        '
        'lblInstalaciones
        '
        Me.lblInstalaciones.AutoSize = True
        Me.lblInstalaciones.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstalaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblInstalaciones.Location = New System.Drawing.Point(20, 20)
        Me.lblInstalaciones.Name = "lblInstalaciones"
        Me.lblInstalaciones.Size = New System.Drawing.Size(246, 32)
        Me.lblInstalaciones.TabIndex = 0
        Me.lblInstalaciones.Text = "Instalaciones estado"
        '
        'tpServiciosEstado
        '
        Me.tpServiciosEstado.AutoScroll = True
        Me.tpServiciosEstado.Controls.Add(Me.lblBandera2)
        Me.tpServiciosEstado.Controls.Add(Me.Id_servicio_estadoTextBox)
        Me.tpServiciosEstado.Controls.Add(NombreLabel1)
        Me.tpServiciosEstado.Controls.Add(Me.NombreTextBox1)
        Me.tpServiciosEstado.Controls.Add(Id_servicio_estadoLabel)
        Me.tpServiciosEstado.Controls.Add(Me.btnNuevo2)
        Me.tpServiciosEstado.Controls.Add(Me.btnGuardar2)
        Me.tpServiciosEstado.Controls.Add(Me.btnEditar2)
        Me.tpServiciosEstado.Controls.Add(Me.btnEliminar2)
        Me.tpServiciosEstado.Controls.Add(Me.btnCancelar2)
        Me.tpServiciosEstado.Controls.Add(Me.DataGridView1)
        Me.tpServiciosEstado.Controls.Add(Me.lblServicios)
        Me.tpServiciosEstado.Location = New System.Drawing.Point(4, 26)
        Me.tpServiciosEstado.Name = "tpServiciosEstado"
        Me.tpServiciosEstado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpServiciosEstado.Size = New System.Drawing.Size(568, 490)
        Me.tpServiciosEstado.TabIndex = 1
        Me.tpServiciosEstado.Text = "Servicios"
        Me.tpServiciosEstado.UseVisualStyleBackColor = True
        '
        'lblBandera2
        '
        Me.lblBandera2.AutoSize = True
        Me.lblBandera2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandera2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBandera2.Location = New System.Drawing.Point(355, 20)
        Me.lblBandera2.Name = "lblBandera2"
        Me.lblBandera2.Size = New System.Drawing.Size(91, 32)
        Me.lblBandera2.TabIndex = 62
        Me.lblBandera2.Text = "MODO"
        '
        'Id_servicio_estadoTextBox
        '
        Me.Id_servicio_estadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Servicios_estadoBindingSource, "id_servicio_estado", True))
        Me.Id_servicio_estadoTextBox.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Id_servicio_estadoTextBox.Location = New System.Drawing.Point(53, 62)
        Me.Id_servicio_estadoTextBox.Name = "Id_servicio_estadoTextBox"
        Me.Id_servicio_estadoTextBox.Size = New System.Drawing.Size(100, 27)
        Me.Id_servicio_estadoTextBox.TabIndex = 59
        '
        'Servicios_estadoBindingSource
        '
        Me.Servicios_estadoBindingSource.DataMember = "Servicios_estado"
        Me.Servicios_estadoBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Servicios_estadoBindingSource, "nombre", True))
        Me.NombreTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.NombreTextBox1.Location = New System.Drawing.Point(260, 62)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(186, 27)
        Me.NombreTextBox1.TabIndex = 61
        '
        'btnNuevo2
        '
        Me.btnNuevo2.BackColor = System.Drawing.Color.White
        Me.btnNuevo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo2.Location = New System.Drawing.Point(22, 100)
        Me.btnNuevo2.Name = "btnNuevo2"
        Me.btnNuevo2.Size = New System.Drawing.Size(80, 40)
        Me.btnNuevo2.TabIndex = 52
        Me.btnNuevo2.Text = "Nuevo"
        Me.btnNuevo2.UseVisualStyleBackColor = False
        '
        'btnGuardar2
        '
        Me.btnGuardar2.BackColor = System.Drawing.Color.White
        Me.btnGuardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar2.Location = New System.Drawing.Point(194, 100)
        Me.btnGuardar2.Name = "btnGuardar2"
        Me.btnGuardar2.Size = New System.Drawing.Size(80, 40)
        Me.btnGuardar2.TabIndex = 53
        Me.btnGuardar2.Text = "Guardar"
        Me.btnGuardar2.UseVisualStyleBackColor = False
        '
        'btnEditar2
        '
        Me.btnEditar2.BackColor = System.Drawing.Color.White
        Me.btnEditar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar2.Location = New System.Drawing.Point(108, 100)
        Me.btnEditar2.Name = "btnEditar2"
        Me.btnEditar2.Size = New System.Drawing.Size(80, 40)
        Me.btnEditar2.TabIndex = 54
        Me.btnEditar2.Text = "Editar"
        Me.btnEditar2.UseVisualStyleBackColor = False
        '
        'btnEliminar2
        '
        Me.btnEliminar2.BackColor = System.Drawing.Color.White
        Me.btnEliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar2.Location = New System.Drawing.Point(366, 100)
        Me.btnEliminar2.Name = "btnEliminar2"
        Me.btnEliminar2.Size = New System.Drawing.Size(80, 40)
        Me.btnEliminar2.TabIndex = 55
        Me.btnEliminar2.Text = "Eliminar"
        Me.btnEliminar2.UseVisualStyleBackColor = False
        '
        'btnCancelar2
        '
        Me.btnCancelar2.BackColor = System.Drawing.Color.White
        Me.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar2.Location = New System.Drawing.Point(280, 100)
        Me.btnCancelar2.Name = "btnCancelar2"
        Me.btnCancelar2.Size = New System.Drawing.Size(80, 40)
        Me.btnCancelar2.TabIndex = 56
        Me.btnCancelar2.Text = "Cancelar"
        Me.btnCancelar2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdservicioestadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn4})
        Me.DataGridView1.DataSource = Me.Servicios_estadoBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(22, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(424, 300)
        Me.DataGridView1.TabIndex = 47
        '
        'IdservicioestadoDataGridViewTextBoxColumn
        '
        Me.IdservicioestadoDataGridViewTextBoxColumn.DataPropertyName = "id_servicio_estado"
        Me.IdservicioestadoDataGridViewTextBoxColumn.HeaderText = "id_servicio_estado"
        Me.IdservicioestadoDataGridViewTextBoxColumn.Name = "IdservicioestadoDataGridViewTextBoxColumn"
        Me.IdservicioestadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn4
        '
        Me.NombreDataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn4.Name = "NombreDataGridViewTextBoxColumn4"
        Me.NombreDataGridViewTextBoxColumn4.ReadOnly = True
        '
        'lblServicios
        '
        Me.lblServicios.AutoSize = True
        Me.lblServicios.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblServicios.Location = New System.Drawing.Point(20, 20)
        Me.lblServicios.Name = "lblServicios"
        Me.lblServicios.Size = New System.Drawing.Size(199, 32)
        Me.lblServicios.TabIndex = 0
        Me.lblServicios.Text = "Servicios estado"
        '
        'tpFacturasEstado
        '
        Me.tpFacturasEstado.AutoScroll = True
        Me.tpFacturasEstado.Controls.Add(Me.lblBandera3)
        Me.tpFacturasEstado.Controls.Add(Me.Id_factura_estadoTextBox)
        Me.tpFacturasEstado.Controls.Add(NombreLabel)
        Me.tpFacturasEstado.Controls.Add(Me.NombreTextBox)
        Me.tpFacturasEstado.Controls.Add(Id_factura_estadoLabel)
        Me.tpFacturasEstado.Controls.Add(Me.btnNuevo3)
        Me.tpFacturasEstado.Controls.Add(Me.btnGuardar3)
        Me.tpFacturasEstado.Controls.Add(Me.btnEditar3)
        Me.tpFacturasEstado.Controls.Add(Me.btnEliminar3)
        Me.tpFacturasEstado.Controls.Add(Me.btnCancelar3)
        Me.tpFacturasEstado.Controls.Add(Me.lblFacturas)
        Me.tpFacturasEstado.Controls.Add(Me.dgvFacturas)
        Me.tpFacturasEstado.Location = New System.Drawing.Point(4, 26)
        Me.tpFacturasEstado.Name = "tpFacturasEstado"
        Me.tpFacturasEstado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFacturasEstado.Size = New System.Drawing.Size(474, 490)
        Me.tpFacturasEstado.TabIndex = 2
        Me.tpFacturasEstado.Text = "Facturas"
        Me.tpFacturasEstado.UseVisualStyleBackColor = True
        '
        'lblBandera3
        '
        Me.lblBandera3.AutoSize = True
        Me.lblBandera3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandera3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBandera3.Location = New System.Drawing.Point(355, 20)
        Me.lblBandera3.Name = "lblBandera3"
        Me.lblBandera3.Size = New System.Drawing.Size(91, 32)
        Me.lblBandera3.TabIndex = 32
        Me.lblBandera3.Text = "MODO"
        '
        'Id_factura_estadoTextBox
        '
        Me.Id_factura_estadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Facturas_estadoBindingSource, "id_factura_estado", True))
        Me.Id_factura_estadoTextBox.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Id_factura_estadoTextBox.Location = New System.Drawing.Point(55, 64)
        Me.Id_factura_estadoTextBox.Name = "Id_factura_estadoTextBox"
        Me.Id_factura_estadoTextBox.Size = New System.Drawing.Size(100, 27)
        Me.Id_factura_estadoTextBox.TabIndex = 63
        '
        'Facturas_estadoBindingSource
        '
        Me.Facturas_estadoBindingSource.DataMember = "Facturas_estado"
        Me.Facturas_estadoBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Facturas_estadoBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(256, 64)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(190, 27)
        Me.NombreTextBox.TabIndex = 65
        '
        'btnNuevo3
        '
        Me.btnNuevo3.BackColor = System.Drawing.Color.White
        Me.btnNuevo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo3.Location = New System.Drawing.Point(22, 100)
        Me.btnNuevo3.Name = "btnNuevo3"
        Me.btnNuevo3.Size = New System.Drawing.Size(80, 40)
        Me.btnNuevo3.TabIndex = 31
        Me.btnNuevo3.Text = "Nuevo"
        Me.btnNuevo3.UseVisualStyleBackColor = False
        '
        'btnGuardar3
        '
        Me.btnGuardar3.BackColor = System.Drawing.Color.White
        Me.btnGuardar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar3.Location = New System.Drawing.Point(194, 100)
        Me.btnGuardar3.Name = "btnGuardar3"
        Me.btnGuardar3.Size = New System.Drawing.Size(80, 40)
        Me.btnGuardar3.TabIndex = 32
        Me.btnGuardar3.Text = "Guardar"
        Me.btnGuardar3.UseVisualStyleBackColor = False
        '
        'btnEditar3
        '
        Me.btnEditar3.BackColor = System.Drawing.Color.White
        Me.btnEditar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar3.Location = New System.Drawing.Point(108, 100)
        Me.btnEditar3.Name = "btnEditar3"
        Me.btnEditar3.Size = New System.Drawing.Size(80, 40)
        Me.btnEditar3.TabIndex = 33
        Me.btnEditar3.Text = "Editar"
        Me.btnEditar3.UseVisualStyleBackColor = False
        '
        'btnEliminar3
        '
        Me.btnEliminar3.BackColor = System.Drawing.Color.White
        Me.btnEliminar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar3.Location = New System.Drawing.Point(366, 100)
        Me.btnEliminar3.Name = "btnEliminar3"
        Me.btnEliminar3.Size = New System.Drawing.Size(80, 40)
        Me.btnEliminar3.TabIndex = 34
        Me.btnEliminar3.Text = "Eliminar"
        Me.btnEliminar3.UseVisualStyleBackColor = False
        '
        'btnCancelar3
        '
        Me.btnCancelar3.BackColor = System.Drawing.Color.White
        Me.btnCancelar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar3.Location = New System.Drawing.Point(280, 100)
        Me.btnCancelar3.Name = "btnCancelar3"
        Me.btnCancelar3.Size = New System.Drawing.Size(80, 40)
        Me.btnCancelar3.TabIndex = 35
        Me.btnCancelar3.Text = "Cancelar"
        Me.btnCancelar3.UseVisualStyleBackColor = False
        '
        'lblFacturas
        '
        Me.lblFacturas.AutoSize = True
        Me.lblFacturas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblFacturas.Location = New System.Drawing.Point(20, 20)
        Me.lblFacturas.Name = "lblFacturas"
        Me.lblFacturas.Size = New System.Drawing.Size(191, 32)
        Me.lblFacturas.TabIndex = 0
        Me.lblFacturas.Text = "Facturas estado"
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dgvFacturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvFacturas.AutoGenerateColumns = False
        Me.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdfacturaestadoDataGridViewTextBoxColumn2, Me.NombreDataGridViewTextBoxColumn5})
        Me.dgvFacturas.DataSource = Me.Facturas_estadoBindingSource
        Me.dgvFacturas.EnableHeadersVisualStyles = False
        Me.dgvFacturas.Location = New System.Drawing.Point(22, 160)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.ReadOnly = True
        Me.dgvFacturas.RowHeadersVisible = False
        Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturas.Size = New System.Drawing.Size(424, 300)
        Me.dgvFacturas.TabIndex = 10
        '
        'IdfacturaestadoDataGridViewTextBoxColumn2
        '
        Me.IdfacturaestadoDataGridViewTextBoxColumn2.DataPropertyName = "id_factura_estado"
        Me.IdfacturaestadoDataGridViewTextBoxColumn2.HeaderText = "id_factura_estado"
        Me.IdfacturaestadoDataGridViewTextBoxColumn2.Name = "IdfacturaestadoDataGridViewTextBoxColumn2"
        Me.IdfacturaestadoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn5
        '
        Me.NombreDataGridViewTextBoxColumn5.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn5.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn5.Name = "NombreDataGridViewTextBoxColumn5"
        Me.NombreDataGridViewTextBoxColumn5.ReadOnly = True
        '
        'IdinstalacionestadoDataGridViewTextBoxColumn
        '
        Me.IdinstalacionestadoDataGridViewTextBoxColumn.DataPropertyName = "id_instalacion_estado"
        Me.IdinstalacionestadoDataGridViewTextBoxColumn.HeaderText = "id_instalacion_estado"
        Me.IdinstalacionestadoDataGridViewTextBoxColumn.Name = "IdinstalacionestadoDataGridViewTextBoxColumn"
        Me.IdinstalacionestadoDataGridViewTextBoxColumn.Width = 254
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.Width = 507
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 507
        '
        'IdfacturaestadoDataGridViewTextBoxColumn
        '
        Me.IdfacturaestadoDataGridViewTextBoxColumn.DataPropertyName = "id_factura_estado"
        Me.IdfacturaestadoDataGridViewTextBoxColumn.HeaderText = "id_factura_estado"
        Me.IdfacturaestadoDataGridViewTextBoxColumn.Name = "IdfacturaestadoDataGridViewTextBoxColumn"
        Me.IdfacturaestadoDataGridViewTextBoxColumn.Width = 254
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 253
        '
        'IdfacturaestadoDataGridViewTextBoxColumn1
        '
        Me.IdfacturaestadoDataGridViewTextBoxColumn1.DataPropertyName = "id_factura_estado"
        Me.IdfacturaestadoDataGridViewTextBoxColumn1.HeaderText = "id_factura_estado"
        Me.IdfacturaestadoDataGridViewTextBoxColumn1.Name = "IdfacturaestadoDataGridViewTextBoxColumn1"
        Me.IdfacturaestadoDataGridViewTextBoxColumn1.Width = 254
        '
        'NombreDataGridViewTextBoxColumn3
        '
        Me.NombreDataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn3.Name = "NombreDataGridViewTextBoxColumn3"
        Me.NombreDataGridViewTextBoxColumn3.Width = 253
        '
        'Facturas_estadoTableAdapter
        '
        Me.Facturas_estadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Facturas_estadoTableAdapter = Me.Facturas_estadoTableAdapter
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.Instalaciones_estadoTableAdapter = Me.Instalaciones_estadoTableAdapter
        Me.TableAdapterManager.InstalacionesTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanesTableAdapter = Nothing
        Me.TableAdapterManager.Servicios_estadoTableAdapter = Me.Servicios_estadoTableAdapter
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Instalaciones_estadoTableAdapter
        '
        Me.Instalaciones_estadoTableAdapter.ClearBeforeFill = True
        '
        'Servicios_estadoTableAdapter
        '
        Me.Servicios_estadoTableAdapter.ClearBeforeFill = True
        '
        'Facturas_estadoBindingNavigator
        '
        Me.Facturas_estadoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Facturas_estadoBindingNavigator.BindingSource = Me.Facturas_estadoBindingSource
        Me.Facturas_estadoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Facturas_estadoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Facturas_estadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Facturas_estadoBindingNavigatorSaveItem})
        Me.Facturas_estadoBindingNavigator.Location = New System.Drawing.Point(0, 130)
        Me.Facturas_estadoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Facturas_estadoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Facturas_estadoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Facturas_estadoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Facturas_estadoBindingNavigator.Name = "Facturas_estadoBindingNavigator"
        Me.Facturas_estadoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Facturas_estadoBindingNavigator.Size = New System.Drawing.Size(641, 25)
        Me.Facturas_estadoBindingNavigator.TabIndex = 19
        Me.Facturas_estadoBindingNavigator.Text = "BindingNavigator1"
        Me.Facturas_estadoBindingNavigator.Visible = False
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
        'Facturas_estadoBindingNavigatorSaveItem
        '
        Me.Facturas_estadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Facturas_estadoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Facturas_estadoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Facturas_estadoBindingNavigatorSaveItem.Name = "Facturas_estadoBindingNavigatorSaveItem"
        Me.Facturas_estadoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Facturas_estadoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 684)
        Me.Controls.Add(Me.Facturas_estadoBindingNavigator)
        Me.Controls.Add(Me.tabParametros)
        Me.Controls.Add(Me.phPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema T1 Token Ring"
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        Me.tabParametros.ResumeLayout(False)
        Me.tpInstalacionesEstado.ResumeLayout(False)
        Me.tpInstalacionesEstado.PerformLayout()
        CType(Me.Instalaciones_estadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpServiciosEstado.ResumeLayout(False)
        Me.tpServiciosEstado.PerformLayout()
        CType(Me.Servicios_estadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFacturasEstado.ResumeLayout(False)
        Me.tpFacturasEstado.PerformLayout()
        CType(Me.Facturas_estadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Facturas_estadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Facturas_estadoBindingNavigator.ResumeLayout(False)
        Me.Facturas_estadoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitulo As Label
    Private WithEvents lblSubtitulo As Label
    Private WithEvents phPrincipal As Panel
    Private WithEvents tabParametros As TabControl
    Private WithEvents tpInstalacionesEstado As TabPage
    Private WithEvents tpServiciosEstado As TabPage
    Private WithEvents tpFacturasEstado As TabPage
    Private WithEvents lblInstalaciones As Label
    Private WithEvents lblServicios As Label
    Private WithEvents lblFacturas As Label
    Private WithEvents dgvFacturas As DataGridView
    Friend WithEvents _empresa_servicio_internetDataSet As _empresa_servicio_internetDataSet
    Friend WithEvents IdfacturaestadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo3 As Button
    Friend WithEvents btnGuardar3 As Button
    Friend WithEvents btnEditar3 As Button
    Friend WithEvents btnEliminar3 As Button
    Friend WithEvents btnCancelar3 As Button
    Private WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Private WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnGuardar1 As Button
    Friend WithEvents btnEditar1 As Button
    Friend WithEvents btnEliminar1 As Button
    Friend WithEvents btnCancelar1 As Button
    Friend WithEvents btnNuevo2 As Button
    Friend WithEvents btnGuardar2 As Button
    Friend WithEvents btnEditar2 As Button
    Friend WithEvents btnEliminar2 As Button
    Friend WithEvents btnCancelar2 As Button
    Friend WithEvents IdinstalacionestadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdfacturaestadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Facturas_estadoBindingSource As BindingSource
    Friend WithEvents Facturas_estadoTableAdapter As _empresa_servicio_internetDataSetTableAdapters.Facturas_estadoTableAdapter
    Friend WithEvents TableAdapterManager As _empresa_servicio_internetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Facturas_estadoBindingNavigator As BindingNavigator
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
    Friend WithEvents Facturas_estadoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_factura_estadoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Servicios_estadoTableAdapter As _empresa_servicio_internetDataSetTableAdapters.Servicios_estadoTableAdapter
    Friend WithEvents Servicios_estadoBindingSource As BindingSource
    Friend WithEvents Id_servicio_estadoTextBox As TextBox
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents Instalaciones_estadoTableAdapter As _empresa_servicio_internetDataSetTableAdapters.Instalaciones_estadoTableAdapter
    Friend WithEvents Instalaciones_estadoBindingSource As BindingSource
    Friend WithEvents Id_instalacion_estadoTextBox As TextBox
    Friend WithEvents NombreTextBox2 As TextBox
    Friend WithEvents btnNuevo1 As Button
    Friend WithEvents lblBandera1 As Label
    Friend WithEvents lblBandera2 As Label
    Friend WithEvents lblBandera3 As Label
    Friend WithEvents IdinstalacionestadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdservicioestadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IdfacturaestadoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
