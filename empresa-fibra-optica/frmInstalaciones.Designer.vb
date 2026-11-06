<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInstalaciones
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Estado_instalacionLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Id_instalacionLabel = New System.Windows.Forms.Label()
        Me.Id_servicioLabel = New System.Windows.Forms.Label()
        Me.Fecha_programadaLabel = New System.Windows.Forms.Label()
        Me.ObservacionesLabel = New System.Windows.Forms.Label()
        Me._empresa_servicio_internetDataSet = New empresa_fibra_optica._empresa_servicio_internetDataSet()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblFormularioTitulo = New System.Windows.Forms.Label()
        Me.lblBandera = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.Id_instalacionTextBox = New System.Windows.Forms.TextBox()
        Me.InstalacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fecha_programadaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.cmbEstadoInstalacion = New System.Windows.Forms.ComboBox()
        Me.InstalacionesestadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdinstalacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdservicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaprogramadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoinstalacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstalacionesTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.InstalacionesTableAdapter()
        Me.Instalaciones_estadoTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.Instalaciones_estadoTableAdapter()
        Me.ServiciosTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.ServiciosTableAdapter()
        Me.TableAdapterManager = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager()
        Estado_instalacionLabel = New System.Windows.Forms.Label()
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.phPrincipal.SuspendLayout()
        CType(Me.InstalacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstalacionesestadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Estado_instalacionLabel
        '
        Estado_instalacionLabel.AutoSize = True
        Estado_instalacionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Estado_instalacionLabel.Location = New System.Drawing.Point(30, 385)
        Estado_instalacionLabel.Name = "Estado_instalacionLabel"
        Estado_instalacionLabel.Size = New System.Drawing.Size(132, 20)
        Estado_instalacionLabel.TabIndex = 65
        Estado_instalacionLabel.Text = "estado instalación:"
        '
        'Id_instalacionLabel
        '
        Me.Id_instalacionLabel.AutoSize = True
        Me.Id_instalacionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_instalacionLabel.Location = New System.Drawing.Point(30, 205)
        Me.Id_instalacionLabel.Name = "Id_instalacionLabel"
        Me.Id_instalacionLabel.Size = New System.Drawing.Size(100, 20)
        Me.Id_instalacionLabel.TabIndex = 59
        Me.Id_instalacionLabel.Text = "id instalación:"
        '
        'Id_servicioLabel
        '
        Me.Id_servicioLabel.AutoSize = True
        Me.Id_servicioLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_servicioLabel.Location = New System.Drawing.Point(30, 265)
        Me.Id_servicioLabel.Name = "Id_servicioLabel"
        Me.Id_servicioLabel.Size = New System.Drawing.Size(79, 20)
        Me.Id_servicioLabel.TabIndex = 61
        Me.Id_servicioLabel.Text = "id servicio:"
        '
        'Fecha_programadaLabel
        '
        Me.Fecha_programadaLabel.AutoSize = True
        Me.Fecha_programadaLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_programadaLabel.Location = New System.Drawing.Point(30, 325)
        Me.Fecha_programadaLabel.Name = "Fecha_programadaLabel"
        Me.Fecha_programadaLabel.Size = New System.Drawing.Size(135, 20)
        Me.Fecha_programadaLabel.TabIndex = 63
        Me.Fecha_programadaLabel.Text = "fecha programada:"
        '
        'ObservacionesLabel
        '
        Me.ObservacionesLabel.AutoSize = True
        Me.ObservacionesLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionesLabel.Location = New System.Drawing.Point(30, 445)
        Me.ObservacionesLabel.Name = "ObservacionesLabel"
        Me.ObservacionesLabel.Size = New System.Drawing.Size(106, 20)
        Me.ObservacionesLabel.TabIndex = 67
        Me.ObservacionesLabel.Text = "observaciones:"
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
        Me.lblSubtitulo.Size = New System.Drawing.Size(133, 20)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Panel Instalaciones"
        '
        'lblFormularioTitulo
        '
        Me.lblFormularioTitulo.AutoSize = True
        Me.lblFormularioTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormularioTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblFormularioTitulo.Location = New System.Drawing.Point(30, 150)
        Me.lblFormularioTitulo.Name = "lblFormularioTitulo"
        Me.lblFormularioTitulo.Size = New System.Drawing.Size(273, 32)
        Me.lblFormularioTitulo.TabIndex = 1
        Me.lblFormularioTitulo.Text = "Datos de la instalación"
        '
        'lblBandera
        '
        Me.lblBandera.AutoSize = True
        Me.lblBandera.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBandera.Location = New System.Drawing.Point(1120, 150)
        Me.lblBandera.Name = "lblBandera"
        Me.lblBandera.Size = New System.Drawing.Size(91, 32)
        Me.lblBandera.TabIndex = 2
        Me.lblBandera.Text = "MODO"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(430, 161)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(142, 19)
        Me.lblBuscar.TabIndex = 3
        Me.lblBuscar.Text = "Buscar instalaciones"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(575, 157)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(224, 25)
        Me.txtBuscar.TabIndex = 4
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarPor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Servicio", "Fecha programada", "Observaciones"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(812, 157)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(153, 25)
        Me.cmbBuscarPor.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(985, 148)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 40)
        Me.btnBuscar.TabIndex = 6
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
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.White
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(565, 210)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(120, 40)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(705, 210)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(845, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 40)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(985, 210)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 40)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(1125, 210)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
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
        Me.phPrincipal.TabIndex = 0
        '
        'Id_instalacionTextBox
        '
        Me.Id_instalacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstalacionesBindingSource, "id_instalacion", True))
        Me.Id_instalacionTextBox.Enabled = False
        Me.Id_instalacionTextBox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_instalacionTextBox.Location = New System.Drawing.Point(30, 230)
        Me.Id_instalacionTextBox.Name = "Id_instalacionTextBox"
        Me.Id_instalacionTextBox.Size = New System.Drawing.Size(350, 27)
        Me.Id_instalacionTextBox.TabIndex = 66
        '
        'InstalacionesBindingSource
        '
        Me.InstalacionesBindingSource.DataMember = "Instalaciones"
        Me.InstalacionesBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'cmbServicio
        '
        Me.cmbServicio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InstalacionesBindingSource, "id_servicio", True))
        Me.cmbServicio.DataSource = Me.ServiciosBindingSource
        Me.cmbServicio.DisplayMember = "id_servicio"
        Me.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicio.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(30, 290)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(350, 28)
        Me.cmbServicio.TabIndex = 67
        Me.cmbServicio.ValueMember = "id_servicio"
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'Fecha_programadaDateTimePicker
        '
        Me.Fecha_programadaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InstalacionesBindingSource, "fecha_programada", True))
        Me.Fecha_programadaDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_programadaDateTimePicker.Location = New System.Drawing.Point(30, 350)
        Me.Fecha_programadaDateTimePicker.Name = "Fecha_programadaDateTimePicker"
        Me.Fecha_programadaDateTimePicker.Size = New System.Drawing.Size(350, 27)
        Me.Fecha_programadaDateTimePicker.TabIndex = 68
        '
        'cmbEstadoInstalacion
        '
        Me.cmbEstadoInstalacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InstalacionesBindingSource, "estado_instalacion", True))
        Me.cmbEstadoInstalacion.DataSource = Me.InstalacionesestadoBindingSource
        Me.cmbEstadoInstalacion.DisplayMember = "nombre"
        Me.cmbEstadoInstalacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoInstalacion.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoInstalacion.FormattingEnabled = True
        Me.cmbEstadoInstalacion.Location = New System.Drawing.Point(30, 410)
        Me.cmbEstadoInstalacion.Name = "cmbEstadoInstalacion"
        Me.cmbEstadoInstalacion.Size = New System.Drawing.Size(350, 28)
        Me.cmbEstadoInstalacion.TabIndex = 69
        Me.cmbEstadoInstalacion.ValueMember = "id_instalacion_estado"
        '
        'InstalacionesestadoBindingSource
        '
        Me.InstalacionesestadoBindingSource.DataMember = "Instalaciones_estado"
        Me.InstalacionesestadoBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstalacionesBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(30, 470)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(350, 90)
        Me.ObservacionesTextBox.TabIndex = 70
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdinstalacionDataGridViewTextBoxColumn, Me.IdservicioDataGridViewTextBoxColumn, Me.FechaprogramadaDataGridViewTextBoxColumn, Me.EstadoinstalacionDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InstalacionesBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(425, 270)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(820, 430)
        Me.DataGridView1.TabIndex = 70
        '
        'IdinstalacionDataGridViewTextBoxColumn
        '
        Me.IdinstalacionDataGridViewTextBoxColumn.DataPropertyName = "id_instalacion"
        Me.IdinstalacionDataGridViewTextBoxColumn.FillWeight = 14.0!
        Me.IdinstalacionDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdinstalacionDataGridViewTextBoxColumn.Name = "IdinstalacionDataGridViewTextBoxColumn"
        Me.IdinstalacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdinstalacionDataGridViewTextBoxColumn.Width = 60
        '
        'IdservicioDataGridViewTextBoxColumn
        '
        Me.IdservicioDataGridViewTextBoxColumn.DataPropertyName = "id_servicio"
        Me.IdservicioDataGridViewTextBoxColumn.FillWeight = 24.0!
        Me.IdservicioDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.IdservicioDataGridViewTextBoxColumn.Name = "IdservicioDataGridViewTextBoxColumn"
        Me.IdservicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdservicioDataGridViewTextBoxColumn.Width = 170
        '
        'FechaprogramadaDataGridViewTextBoxColumn
        '
        Me.FechaprogramadaDataGridViewTextBoxColumn.DataPropertyName = "fecha_programada"
        Me.FechaprogramadaDataGridViewTextBoxColumn.FillWeight = 18.0!
        Me.FechaprogramadaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaprogramadaDataGridViewTextBoxColumn.Name = "FechaprogramadaDataGridViewTextBoxColumn"
        Me.FechaprogramadaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaprogramadaDataGridViewTextBoxColumn.Width = 160
        '
        'EstadoinstalacionDataGridViewTextBoxColumn
        '
        Me.EstadoinstalacionDataGridViewTextBoxColumn.DataPropertyName = "estado_instalacion"
        Me.EstadoinstalacionDataGridViewTextBoxColumn.FillWeight = 18.0!
        Me.EstadoinstalacionDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoinstalacionDataGridViewTextBoxColumn.Name = "EstadoinstalacionDataGridViewTextBoxColumn"
        Me.EstadoinstalacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoinstalacionDataGridViewTextBoxColumn.Width = 120
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 330
        '
        'InstalacionesTableAdapter
        '
        Me.InstalacionesTableAdapter.ClearBeforeFill = True
        '
        'Instalaciones_estadoTableAdapter
        '
        Me.Instalaciones_estadoTableAdapter.ClearBeforeFill = True
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Facturas_estadoTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.Instalaciones_estadoTableAdapter = Me.Instalaciones_estadoTableAdapter
        Me.TableAdapterManager.InstalacionesTableAdapter = Me.InstalacionesTableAdapter
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanesTableAdapter = Nothing
        Me.TableAdapterManager.Servicios_estadoTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Me.ServiciosTableAdapter
        Me.TableAdapterManager.UpdateOrder = empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmInstalaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.phPrincipal)
        Me.Controls.Add(Me.lblFormularioTitulo)
        Me.Controls.Add(Me.lblBandera)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Id_instalacionLabel)
        Me.Controls.Add(Me.Id_servicioLabel)
        Me.Controls.Add(Me.Fecha_programadaLabel)
        Me.Controls.Add(Estado_instalacionLabel)
        Me.Controls.Add(Me.ObservacionesLabel)
        Me.Controls.Add(Me.Id_instalacionTextBox)
        Me.Controls.Add(Me.cmbServicio)
        Me.Controls.Add(Me.Fecha_programadaDateTimePicker)
        Me.Controls.Add(Me.cmbEstadoInstalacion)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInstalaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema T1 Token Ring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        CType(Me.InstalacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstalacionesestadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private _empresa_servicio_internetDataSet As empresa_fibra_optica._empresa_servicio_internetDataSet
    Private WithEvents lblTitulo As System.Windows.Forms.Label
    Private WithEvents lblSubtitulo As System.Windows.Forms.Label
    Private WithEvents lblFormularioTitulo As System.Windows.Forms.Label
    Private WithEvents lblBandera As System.Windows.Forms.Label
    Private WithEvents lblBuscar As System.Windows.Forms.Label
    Private WithEvents txtBuscar As System.Windows.Forms.TextBox
    Private WithEvents cmbBuscarPor As System.Windows.Forms.ComboBox
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Private WithEvents btnNuevo As System.Windows.Forms.Button
    Private WithEvents btnEditar As System.Windows.Forms.Button
    Private WithEvents btnGuardar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents phPrincipal As System.Windows.Forms.Panel
    Private WithEvents Id_instalacionTextBox As System.Windows.Forms.TextBox
    Private WithEvents cmbServicio As System.Windows.Forms.ComboBox
    Private WithEvents Fecha_programadaDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents cmbEstadoInstalacion As System.Windows.Forms.ComboBox
    Private WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents InstalacionesBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ServiciosBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents InstalacionesTableAdapter As empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.InstalacionesTableAdapter
    Private WithEvents Instalaciones_estadoTableAdapter As empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.Instalaciones_estadoTableAdapter
    Private WithEvents ServiciosTableAdapter As empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents Id_instalacionLabel As Label
    Friend WithEvents Id_servicioLabel As Label
    Friend WithEvents Fecha_programadaLabel As Label
    Friend WithEvents ObservacionesLabel As Label
    Friend WithEvents IdinstalacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdservicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaprogramadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoinstalacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As _empresa_servicio_internetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InstalacionesestadoBindingSource As BindingSource
End Class