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
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelSubtitle = New System.Windows.Forms.Label()
        Me.flowModules = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.labelTitle)
        Me.panelHeader.Controls.Add(Me.labelSubtitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1120, 135)
        Me.panelHeader.TabIndex = 3
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.White
        Me.labelTitle.Location = New System.Drawing.Point(28, 30)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(253, 45)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Empresa Pepito"
        '
        'labelSubtitle
        '
        Me.labelSubtitle.AutoSize = True
        Me.labelSubtitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.labelSubtitle.Location = New System.Drawing.Point(32, 82)
        Me.labelSubtitle.Name = "labelSubtitle"
        Me.labelSubtitle.Size = New System.Drawing.Size(106, 20)
        Me.labelSubtitle.TabIndex = 1
        Me.labelSubtitle.Text = "Panel principal"
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
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 700)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.flowModules)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de gestion - Empresa Pepito"
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelHeader As Panel
    Private WithEvents labelTitle As Label
    Private WithEvents labelSubtitle As Label
    Private WithEvents flowModules As FlowLayoutPanel
End Class
