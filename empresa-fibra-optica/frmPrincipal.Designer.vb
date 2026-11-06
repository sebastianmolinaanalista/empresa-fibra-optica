<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnPlanes = New System.Windows.Forms.Button()
        Me.btnServicios = New System.Windows.Forms.Button()
        Me.btnInstalaciones = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.btnParametros = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.phPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.White
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnClientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(218, 210)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(250, 150)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnPlanes
        '
        Me.btnPlanes.BackColor = System.Drawing.Color.White
        Me.btnPlanes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnPlanes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanes.Location = New System.Drawing.Point(218, 430)
        Me.btnPlanes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnPlanes.Name = "btnPlanes"
        Me.btnPlanes.Size = New System.Drawing.Size(250, 150)
        Me.btnPlanes.TabIndex = 1
        Me.btnPlanes.Text = "Planes"
        Me.btnPlanes.UseVisualStyleBackColor = False
        '
        'btnServicios
        '
        Me.btnServicios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnServicios.BackColor = System.Drawing.Color.White
        Me.btnServicios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnServicios.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServicios.Location = New System.Drawing.Point(558, 210)
        Me.btnServicios.Margin = New System.Windows.Forms.Padding(10)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Size = New System.Drawing.Size(250, 150)
        Me.btnServicios.TabIndex = 2
        Me.btnServicios.Text = "Servicios"
        Me.btnServicios.UseVisualStyleBackColor = False
        '
        'btnInstalaciones
        '
        Me.btnInstalaciones.BackColor = System.Drawing.Color.White
        Me.btnInstalaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnInstalaciones.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstalaciones.Location = New System.Drawing.Point(558, 430)
        Me.btnInstalaciones.Margin = New System.Windows.Forms.Padding(10)
        Me.btnInstalaciones.Name = "btnInstalaciones"
        Me.btnInstalaciones.Size = New System.Drawing.Size(250, 150)
        Me.btnInstalaciones.TabIndex = 3
        Me.btnInstalaciones.Text = "Instalaciones"
        Me.btnInstalaciones.UseVisualStyleBackColor = False
        '
        'btnFacturas
        '
        Me.btnFacturas.BackColor = System.Drawing.Color.White
        Me.btnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnFacturas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.Location = New System.Drawing.Point(898, 210)
        Me.btnFacturas.Margin = New System.Windows.Forms.Padding(10)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(250, 150)
        Me.btnFacturas.TabIndex = 4
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'btnInformes
        '
        Me.btnInformes.BackColor = System.Drawing.Color.White
        Me.btnInformes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnInformes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformes.Location = New System.Drawing.Point(898, 430)
        Me.btnInformes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(250, 150)
        Me.btnInformes.TabIndex = 5
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 590)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 150)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "POR SI"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'phPrincipal
        '
        Me.phPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.phPrincipal.Controls.Add(Me.lblTitulo)
        Me.phPrincipal.Controls.Add(Me.lblSubtitulo)
        Me.phPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.phPrincipal.Name = "phPrincipal"
        Me.phPrincipal.Size = New System.Drawing.Size(1366, 130)
        Me.phPrincipal.TabIndex = 5
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
        Me.lblSubtitulo.Size = New System.Drawing.Size(106, 20)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Panel principal"
        '
        'btnParametros
        '
        Me.btnParametros.Location = New System.Drawing.Point(1157, 137)
        Me.btnParametros.Name = "btnParametros"
        Me.btnParametros.Size = New System.Drawing.Size(90, 34)
        Me.btnParametros.TabIndex = 7
        Me.btnParametros.Text = "Parametros"
        Me.btnParametros.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1264, 136)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 34)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnParametros)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnServicios)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.phPrincipal)
        Me.Controls.Add(Me.btnPlanes)
        Me.Controls.Add(Me.btnFacturas)
        Me.Controls.Add(Me.btnInstalaciones)
        Me.Controls.Add(Me.btnClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema T1 Token Ring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents phPrincipal As Panel
    Private WithEvents lblTitulo As Label
    Private WithEvents lblSubtitulo As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnPlanes As Button
    Friend WithEvents btnServicios As Button
    Friend WithEvents btnInstalaciones As Button
    Friend WithEvents btnFacturas As Button
    Friend WithEvents btnInformes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnParametros As Button
    Friend WithEvents btnSalir As Button
End Class
