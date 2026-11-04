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
        Me.flowModules = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpPrincipal = New System.Windows.Forms.FlowLayoutPanel()
        Me.phPrincipal = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.phPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowModules
        '
        Me.flowModules.AutoScroll = True
        Me.flowModules.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.flowModules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowModules.Location = New System.Drawing.Point(0, 0)
        Me.flowModules.Name = "flowModules"
        Me.flowModules.Padding = New System.Windows.Forms.Padding(28)
        Me.flowModules.Size = New System.Drawing.Size(1120, 700)
        Me.flowModules.TabIndex = 4
        '
        'flpPrincipal
        '
        Me.flpPrincipal.AutoScroll = True
        Me.flpPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.flpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpPrincipal.Location = New System.Drawing.Point(0, 135)
        Me.flpPrincipal.Name = "flpPrincipal"
        Me.flpPrincipal.Padding = New System.Windows.Forms.Padding(28)
        Me.flpPrincipal.Size = New System.Drawing.Size(1120, 565)
        Me.flpPrincipal.TabIndex = 6
        '
        'phPrincipal
        '
        Me.phPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.phPrincipal.Controls.Add(Me.lblTitulo)
        Me.phPrincipal.Controls.Add(Me.lblSubtitulo)
        Me.phPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.phPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.phPrincipal.Name = "phPrincipal"
        Me.phPrincipal.Size = New System.Drawing.Size(1120, 135)
        Me.phPrincipal.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(28, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(253, 45)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Empresa Pepito"
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
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 700)
        Me.Controls.Add(Me.flpPrincipal)
        Me.Controls.Add(Me.phPrincipal)
        Me.Controls.Add(Me.flowModules)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de gestion - Empresa Pepito"
        Me.phPrincipal.ResumeLayout(False)
        Me.phPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents flowModules As FlowLayoutPanel
    Private WithEvents flpPrincipal As FlowLayoutPanel
    Private WithEvents phPrincipal As Panel
    Private WithEvents lblTitulo As Label
    Private WithEvents lblSubtitulo As Label
End Class
