<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWALCOT01
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.EntidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALCOT = New Wallet.dsWALCOT()
        Me.EntidadesTableAdapter = New Wallet.dsWALCOTTableAdapters.entidadesTableAdapter()
        Me.dgvPizarra = New System.Windows.Forms.DataGridView()
        Me.ENTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FONDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FONCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.EntidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALCOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPizarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(769, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Wallet.My.Resources.Resources.Microsoft_Excel_icon_24
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
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
        'EntidadesBindingSource
        '
        Me.EntidadesBindingSource.DataMember = "entidades"
        Me.EntidadesBindingSource.DataSource = Me.DsWALCOT
        '
        'DsWALCOT
        '
        Me.DsWALCOT.DataSetName = "dsWALCOT"
        Me.DsWALCOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EntidadesTableAdapter
        '
        Me.EntidadesTableAdapter.ClearBeforeFill = True
        '
        'dgvPizarra
        '
        Me.dgvPizarra.AllowUserToAddRows = False
        Me.dgvPizarra.AllowUserToDeleteRows = False
        Me.dgvPizarra.AutoGenerateColumns = False
        Me.dgvPizarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPizarra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ENTIDADDataGridViewTextBoxColumn, Me.FONDODataGridViewTextBoxColumn, Me.ENTCODIGODataGridViewTextBoxColumn, Me.FONCODIGODataGridViewTextBoxColumn})
        Me.dgvPizarra.DataSource = Me.EntidadesBindingSource
        Me.dgvPizarra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPizarra.Location = New System.Drawing.Point(0, 25)
        Me.dgvPizarra.Name = "dgvPizarra"
        Me.dgvPizarra.Size = New System.Drawing.Size(769, 374)
        Me.dgvPizarra.TabIndex = 1
        '
        'ENTIDADDataGridViewTextBoxColumn
        '
        Me.ENTIDADDataGridViewTextBoxColumn.DataPropertyName = "ENTIDAD"
        Me.ENTIDADDataGridViewTextBoxColumn.HeaderText = "ENTIDAD"
        Me.ENTIDADDataGridViewTextBoxColumn.Name = "ENTIDADDataGridViewTextBoxColumn"
        '
        'FONDODataGridViewTextBoxColumn
        '
        Me.FONDODataGridViewTextBoxColumn.DataPropertyName = "FONDO"
        Me.FONDODataGridViewTextBoxColumn.HeaderText = "FONDO"
        Me.FONDODataGridViewTextBoxColumn.Name = "FONDODataGridViewTextBoxColumn"
        '
        'ENTCODIGODataGridViewTextBoxColumn
        '
        Me.ENTCODIGODataGridViewTextBoxColumn.DataPropertyName = "ENT_CODIGO"
        Me.ENTCODIGODataGridViewTextBoxColumn.HeaderText = "ENT_CODIGO"
        Me.ENTCODIGODataGridViewTextBoxColumn.Name = "ENTCODIGODataGridViewTextBoxColumn"
        Me.ENTCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.ENTCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'FONCODIGODataGridViewTextBoxColumn
        '
        Me.FONCODIGODataGridViewTextBoxColumn.DataPropertyName = "FON_CODIGO"
        Me.FONCODIGODataGridViewTextBoxColumn.HeaderText = "FON_CODIGO"
        Me.FONCODIGODataGridViewTextBoxColumn.Name = "FONCODIGODataGridViewTextBoxColumn"
        Me.FONCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FONCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'frmWALCOT01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 399)
        Me.Controls.Add(Me.dgvPizarra)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmWALCOT01"
        Me.Text = "Evaluación de Tasas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.EntidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALCOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPizarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents EntidadesBindingSource As BindingSource
    Friend WithEvents DsWALCOT As dsWALCOT
    Friend WithEvents EntidadesTableAdapter As dsWALCOTTableAdapters.entidadesTableAdapter
    Friend WithEvents dgvPizarra As DataGridView
    Friend WithEvents ENTIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FONDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENTCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FONCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
