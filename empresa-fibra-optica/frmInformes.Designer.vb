<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInformes
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
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblFormularioTitulo = New System.Windows.Forms.Label()
        Me.lblInforme = New System.Windows.Forms.Label()
        Me.cmbInforme = New System.Windows.Forms.ComboBox()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.phPrincipal.SuspendLayout()
        Me.SuspendLayout()
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
        Me.phPrincipal.TabIndex = 23
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
        Me.lblSubtitulo.Text = "Panel Informes"
        '
        'lblFormularioTitulo
        '
        Me.lblFormularioTitulo.AutoSize = True
        Me.lblFormularioTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormularioTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblFormularioTitulo.Location = New System.Drawing.Point(30, 150)
        Me.lblFormularioTitulo.Name = "lblFormularioTitulo"
        Me.lblFormularioTitulo.Size = New System.Drawing.Size(216, 32)
        Me.lblFormularioTitulo.TabIndex = 2
        Me.lblFormularioTitulo.Text = "Listados informes"
        '
        'lblInforme
        '
        Me.lblInforme.AutoSize = True
        Me.lblInforme.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInforme.Location = New System.Drawing.Point(30, 210)
        Me.lblInforme.Name = "lblInforme"
        Me.lblInforme.Size = New System.Drawing.Size(116, 20)
        Me.lblInforme.TabIndex = 3
        Me.lblInforme.Text = "tipo de informe:"
        '
        'cmbInforme
        '
        Me.cmbInforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInforme.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInforme.Items.AddRange(New Object() {"Clientes activos", "Planes contratados", "Instalaciones pendientes", "Pagos por período"})
        Me.cmbInforme.Location = New System.Drawing.Point(180, 210)
        Me.cmbInforme.Name = "cmbInforme"
        Me.cmbInforme.Size = New System.Drawing.Size(260, 25)
        Me.cmbInforme.TabIndex = 4
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(533, 212)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(60, 20)
        Me.lblPeriodo.TabIndex = 5
        Me.lblPeriodo.Text = "Periodo"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.White
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(955, 202)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(120, 40)
        Me.btnGenerar.TabIndex = 9
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(1090, 202)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "empresa_fibra_optica.rptClientesActivos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(30, 270)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1280, 430)
        Me.ReportViewer1.TabIndex = 11
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPeriodo.Location = New System.Drawing.Point(599, 210)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(184, 25)
        Me.txtPeriodo.TabIndex = 24
        '
        'frmInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.lblFormularioTitulo)
        Me.Controls.Add(Me.lblInforme)
        Me.Controls.Add(Me.cmbInforme)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.phPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInformes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema T1 Token Ring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents phPrincipal As Panel
    Private WithEvents lblTitulo As Label
    Private WithEvents lblSubtitulo As Label
    Private WithEvents lblFormularioTitulo As Label
    Private WithEvents lblInforme As Label
    Private WithEvents cmbInforme As ComboBox
    Private WithEvents lblPeriodo As Label
    Private WithEvents btnGenerar As Button
    Private WithEvents btnSalir As Button
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtPeriodo As TextBox
End Class
