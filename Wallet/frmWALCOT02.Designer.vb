<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALCOT02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALCOT02))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbExporta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.lvPizarra = New System.Windows.Forms.ListView()
        Me.Clave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Entidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fondo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExporta, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(708, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbExporta
        '
        Me.tsbExporta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExporta.Image = Global.Wallet.My.Resources.Resources.Excel
        Me.tsbExporta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExporta.Name = "tsbExporta"
        Me.tsbExporta.Size = New System.Drawing.Size(23, 22)
        Me.tsbExporta.Text = "Exportación a Excel"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'lvPizarra
        '
        Me.lvPizarra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clave, Me.Entidad, Me.Fondo})
        Me.lvPizarra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPizarra.Location = New System.Drawing.Point(0, 25)
        Me.lvPizarra.Name = "lvPizarra"
        Me.lvPizarra.Size = New System.Drawing.Size(708, 349)
        Me.lvPizarra.TabIndex = 1
        Me.lvPizarra.UseCompatibleStateImageBehavior = False
        Me.lvPizarra.View = System.Windows.Forms.View.Details
        '
        'Clave
        '
        Me.Clave.Width = 0
        '
        'Entidad
        '
        Me.Entidad.Text = "Entidad"
        Me.Entidad.Width = 150
        '
        'Fondo
        '
        Me.Fondo.Text = "Fondo"
        Me.Fondo.Width = 150
        '
        'frmWALCOT02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(708, 374)
        Me.Controls.Add(Me.lvPizarra)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALCOT02"
        Me.Text = "Evaluación de Tasas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lvPizarra As ListView
    Friend WithEvents Clave As ColumnHeader
    Friend WithEvents Entidad As ColumnHeader
    Friend WithEvents Fondo As ColumnHeader
    Friend WithEvents tsbExporta As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
