<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanes
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
        Dim Id_planLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DescripcionLabel = New System.Windows.Forms.Label()
        Me.Precio_mensualLabel = New System.Windows.Forms.Label()
        Me.DisponibilidadLabel = New System.Windows.Forms.Label()
        Me.lblBandera = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblFormularioTitulo = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdplanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciomensualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisponibilidadDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PlanesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._empresa_servicio_internetDataSet = New empresa_fibra_optica._empresa_servicio_internetDataSet()
        Me.TableAdapterManager = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.TableAdapterManager()
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_mensualTextBox = New System.Windows.Forms.TextBox()
        Me.Id_planTextBox = New System.Windows.Forms.TextBox()
        Me.PlanesTableAdapter = New empresa_fibra_optica._empresa_servicio_internetDataSetTableAdapters.PlanesTableAdapter()
        Me.DisponibilidadCheckBox = New System.Windows.Forms.CheckBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Id_planLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.phPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_planLabel
        '
        Id_planLabel.AutoSize = True
        Id_planLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_planLabel.Location = New System.Drawing.Point(30, 205)
        Id_planLabel.Name = "Id_planLabel"
        Id_planLabel.Size = New System.Drawing.Size(55, 20)
        Id_planLabel.TabIndex = 34
        Id_planLabel.Text = "id plan"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(30, 265)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(64, 20)
        NombreLabel.TabIndex = 37
        NombreLabel.Text = "nombre:"
        '
        'DescripcionLabel
        '
        Me.DescripcionLabel.AutoSize = True
        Me.DescripcionLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLabel.Location = New System.Drawing.Point(30, 325)
        Me.DescripcionLabel.Name = "DescripcionLabel"
        Me.DescripcionLabel.Size = New System.Drawing.Size(88, 20)
        Me.DescripcionLabel.TabIndex = 39
        Me.DescripcionLabel.Text = "descripcion:"
        '
        'Precio_mensualLabel
        '
        Me.Precio_mensualLabel.AutoSize = True
        Me.Precio_mensualLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_mensualLabel.Location = New System.Drawing.Point(32, 442)
        Me.Precio_mensualLabel.Name = "Precio_mensualLabel"
        Me.Precio_mensualLabel.Size = New System.Drawing.Size(113, 20)
        Me.Precio_mensualLabel.TabIndex = 41
        Me.Precio_mensualLabel.Text = "precio mensual:"
        '
        'DisponibilidadLabel
        '
        Me.DisponibilidadLabel.AutoSize = True
        Me.DisponibilidadLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisponibilidadLabel.Location = New System.Drawing.Point(30, 488)
        Me.DisponibilidadLabel.Name = "DisponibilidadLabel"
        Me.DisponibilidadLabel.Size = New System.Drawing.Size(108, 20)
        Me.DisponibilidadLabel.TabIndex = 43
        Me.DisponibilidadLabel.Text = "disponibilidad:"
        '
        'lblBandera
        '
        Me.lblBandera.AutoSize = True
        Me.lblBandera.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBandera.Location = New System.Drawing.Point(1120, 150)
        Me.lblBandera.Name = "lblBandera"
        Me.lblBandera.Size = New System.Drawing.Size(91, 32)
        Me.lblBandera.TabIndex = 60
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
        Me.btnSalir.TabIndex = 59
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(430, 161)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(100, 19)
        Me.lblBuscar.TabIndex = 50
        Me.lblBuscar.Text = "Buscar planes"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(546, 157)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(240, 25)
        Me.txtBuscar.TabIndex = 52
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarPor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Nombre", "Precio"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(800, 158)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(150, 25)
        Me.cmbBuscarPor.TabIndex = 54
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(985, 148)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 40)
        Me.btnBuscar.TabIndex = 56
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblFormularioTitulo
        '
        Me.lblFormularioTitulo.AutoSize = True
        Me.lblFormularioTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormularioTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblFormularioTitulo.Location = New System.Drawing.Point(30, 150)
        Me.lblFormularioTitulo.Name = "lblFormularioTitulo"
        Me.lblFormularioTitulo.Size = New System.Drawing.Size(179, 32)
        Me.lblFormularioTitulo.TabIndex = 35
        Me.lblFormularioTitulo.Text = "Datos del plan"
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
        Me.btnEditar.TabIndex = 55
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
        Me.btnEliminar.TabIndex = 57
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
        Me.btnCancelar.TabIndex = 58
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdplanDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PreciomensualDataGridViewTextBoxColumn, Me.DisponibilidadDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.PlanesBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(425, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(900, 400)
        Me.DataGridView1.TabIndex = 49
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        '
        'IdplanDataGridViewTextBoxColumn
        '
        Me.IdplanDataGridViewTextBoxColumn.DataPropertyName = "id_plan"
        Me.IdplanDataGridViewTextBoxColumn.FillWeight = 25.0!
        Me.IdplanDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdplanDataGridViewTextBoxColumn.Name = "IdplanDataGridViewTextBoxColumn"
        Me.IdplanDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdplanDataGridViewTextBoxColumn.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.FillWeight = 35.0!
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 190
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.FillWeight = 45.0!
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 410
        '
        'PreciomensualDataGridViewTextBoxColumn
        '
        Me.PreciomensualDataGridViewTextBoxColumn.DataPropertyName = "precio_mensual"
        Me.PreciomensualDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.PreciomensualDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PreciomensualDataGridViewTextBoxColumn.Name = "PreciomensualDataGridViewTextBoxColumn"
        Me.PreciomensualDataGridViewTextBoxColumn.ReadOnly = True
        Me.PreciomensualDataGridViewTextBoxColumn.Width = 90
        '
        'DisponibilidadDataGridViewCheckBoxColumn
        '
        Me.DisponibilidadDataGridViewCheckBoxColumn.DataPropertyName = "disponibilidad"
        Me.DisponibilidadDataGridViewCheckBoxColumn.FillWeight = 20.0!
        Me.DisponibilidadDataGridViewCheckBoxColumn.HeaderText = "Disponible"
        Me.DisponibilidadDataGridViewCheckBoxColumn.Name = "DisponibilidadDataGridViewCheckBoxColumn"
        Me.DisponibilidadDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DisponibilidadDataGridViewCheckBoxColumn.Width = 90
        '
        'PlanesBindingSource
        '
        Me.PlanesBindingSource.DataMember = "Planes"
        Me.PlanesBindingSource.DataSource = Me._empresa_servicio_internetDataSet
        '
        '_empresa_servicio_internetDataSet
        '
        Me._empresa_servicio_internetDataSet.DataSetName = "_empresa_servicio_internetDataSet"
        Me._empresa_servicio_internetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.phPrincipal.Size = New System.Drawing.Size(1370, 130)
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
        Me.lblSubtitulo.Size = New System.Drawing.Size(90, 20)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Panel Planes"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(30, 350)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(350, 63)
        Me.DescripcionTextBox.TabIndex = 40
        '
        'Precio_mensualTextBox
        '
        Me.Precio_mensualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesBindingSource, "precio_mensual", True))
        Me.Precio_mensualTextBox.Location = New System.Drawing.Point(30, 465)
        Me.Precio_mensualTextBox.Name = "Precio_mensualTextBox"
        Me.Precio_mensualTextBox.Size = New System.Drawing.Size(350, 20)
        Me.Precio_mensualTextBox.TabIndex = 42
        '
        'Id_planTextBox
        '
        Me.Id_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesBindingSource, "id_plan", True))
        Me.Id_planTextBox.Enabled = False
        Me.Id_planTextBox.Location = New System.Drawing.Point(30, 230)
        Me.Id_planTextBox.Name = "Id_planTextBox"
        Me.Id_planTextBox.Size = New System.Drawing.Size(350, 20)
        Me.Id_planTextBox.TabIndex = 36
        '
        'PlanesTableAdapter
        '
        Me.PlanesTableAdapter.ClearBeforeFill = True
        '
        'DisponibilidadCheckBox
        '
        Me.DisponibilidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanesBindingSource, "disponibilidad", True))
        Me.DisponibilidadCheckBox.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DisponibilidadCheckBox.Location = New System.Drawing.Point(30, 511)
        Me.DisponibilidadCheckBox.Name = "DisponibilidadCheckBox"
        Me.DisponibilidadCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DisponibilidadCheckBox.TabIndex = 69
        Me.DisponibilidadCheckBox.Text = "Disponible"
        Me.DisponibilidadCheckBox.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(30, 290)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(350, 20)
        Me.NombreTextBox.TabIndex = 38
        '
        'frmPlanes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.DisponibilidadCheckBox)
        Me.Controls.Add(Me.lblBandera)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblFormularioTitulo)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Id_planLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.DescripcionLabel)
        Me.Controls.Add(Me.Precio_mensualLabel)
        Me.Controls.Add(Me.DisponibilidadLabel)
        Me.Controls.Add(Me.phPrincipal)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.Precio_mensualTextBox)
        Me.Controls.Add(Me.Id_planTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPlanes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema T1 Token Ring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._empresa_servicio_internetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBandera As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cmbBuscarPor As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblFormularioTitulo As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _empresa_servicio_internetDataSet As _empresa_servicio_internetDataSet
    Friend WithEvents TableAdapterManager As _empresa_servicio_internetDataSetTableAdapters.TableAdapterManager
    Private WithEvents phPrincipal As Panel
    Private WithEvents lblTitulo As Label
    Private WithEvents lblSubtitulo As Label
    Friend WithEvents Precio_mensualTextBox As TextBox
    Friend WithEvents Id_planTextBox As TextBox
    Friend WithEvents PlanesBindingSource As BindingSource
    Friend WithEvents PlanesTableAdapter As _empresa_servicio_internetDataSetTableAdapters.PlanesTableAdapter
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents DisponibilidadCheckBox As CheckBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DescripcionLabel As Label
    Friend WithEvents Precio_mensualLabel As Label
    Friend WithEvents DisponibilidadLabel As Label
    Friend WithEvents IdplanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciomensualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisponibilidadDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
