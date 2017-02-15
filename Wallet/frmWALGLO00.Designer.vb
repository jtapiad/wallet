<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALGLO00
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALGLO00))
        Me.dgvGlosas = New System.Windows.Forms.DataGridView()
        Me.GLOGLOSADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLOCOLUMNADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TESCOLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALGLOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALGLO = New Wallet.dsWALGLO()
        Me.GLOAUDITORIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLOCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESGLOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESGLOTableAdapter = New Wallet.dsWALGLOTableAdapters.TESGLOTableAdapter()
        Me.TESCOLTableAdapter = New Wallet.dsWALGLOTableAdapters.TESCOLTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAcepta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvGlosas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESCOLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALGLOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALGLO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESGLOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGlosas
        '
        Me.dgvGlosas.AllowUserToAddRows = False
        Me.dgvGlosas.AllowUserToDeleteRows = False
        Me.dgvGlosas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGlosas.AutoGenerateColumns = False
        Me.dgvGlosas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGlosas.BackgroundColor = System.Drawing.Color.White
        Me.dgvGlosas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGlosas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GLOGLOSADataGridViewTextBoxColumn, Me.GLOCOLUMNADataGridViewTextBoxColumn, Me.GLOAUDITORIADataGridViewTextBoxColumn, Me.GLOCODIGODataGridViewTextBoxColumn})
        Me.dgvGlosas.DataSource = Me.TESGLOBindingSource
        Me.dgvGlosas.GridColor = System.Drawing.Color.White
        Me.dgvGlosas.Location = New System.Drawing.Point(0, 28)
        Me.dgvGlosas.Name = "dgvGlosas"
        Me.dgvGlosas.RowHeadersVisible = False
        Me.dgvGlosas.Size = New System.Drawing.Size(448, 336)
        Me.dgvGlosas.TabIndex = 0
        '
        'GLOGLOSADataGridViewTextBoxColumn
        '
        Me.GLOGLOSADataGridViewTextBoxColumn.DataPropertyName = "GLO_GLOSA"
        Me.GLOGLOSADataGridViewTextBoxColumn.HeaderText = "Glosa"
        Me.GLOGLOSADataGridViewTextBoxColumn.Name = "GLOGLOSADataGridViewTextBoxColumn"
        Me.GLOGLOSADataGridViewTextBoxColumn.ReadOnly = True
        '
        'GLOCOLUMNADataGridViewTextBoxColumn
        '
        Me.GLOCOLUMNADataGridViewTextBoxColumn.DataPropertyName = "GLO_COLUMNA"
        Me.GLOCOLUMNADataGridViewTextBoxColumn.DataSource = Me.TESCOLBindingSource
        Me.GLOCOLUMNADataGridViewTextBoxColumn.DisplayMember = "COL_NOMBRE"
        Me.GLOCOLUMNADataGridViewTextBoxColumn.HeaderText = "Columna"
        Me.GLOCOLUMNADataGridViewTextBoxColumn.Name = "GLOCOLUMNADataGridViewTextBoxColumn"
        Me.GLOCOLUMNADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GLOCOLUMNADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.GLOCOLUMNADataGridViewTextBoxColumn.ValueMember = "COL_CODIGO"
        '
        'TESCOLBindingSource
        '
        Me.TESCOLBindingSource.DataMember = "TESCOL"
        Me.TESCOLBindingSource.DataSource = Me.DsWALGLOBindingSource
        '
        'DsWALGLOBindingSource
        '
        Me.DsWALGLOBindingSource.DataSource = Me.DsWALGLO
        Me.DsWALGLOBindingSource.Position = 0
        '
        'DsWALGLO
        '
        Me.DsWALGLO.DataSetName = "dsWALGLO"
        Me.DsWALGLO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GLOAUDITORIADataGridViewTextBoxColumn
        '
        Me.GLOAUDITORIADataGridViewTextBoxColumn.DataPropertyName = "GLO_AUDITORIA"
        Me.GLOAUDITORIADataGridViewTextBoxColumn.HeaderText = "GLO_AUDITORIA"
        Me.GLOAUDITORIADataGridViewTextBoxColumn.Name = "GLOAUDITORIADataGridViewTextBoxColumn"
        Me.GLOAUDITORIADataGridViewTextBoxColumn.Visible = False
        '
        'GLOCODIGODataGridViewTextBoxColumn
        '
        Me.GLOCODIGODataGridViewTextBoxColumn.DataPropertyName = "GLO_CODIGO"
        Me.GLOCODIGODataGridViewTextBoxColumn.HeaderText = "GLO_CODIGO"
        Me.GLOCODIGODataGridViewTextBoxColumn.Name = "GLOCODIGODataGridViewTextBoxColumn"
        Me.GLOCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESGLOBindingSource
        '
        Me.TESGLOBindingSource.DataMember = "TESGLO"
        Me.TESGLOBindingSource.DataSource = Me.DsWALGLOBindingSource
        '
        'TESGLOTableAdapter
        '
        Me.TESGLOTableAdapter.ClearBeforeFill = True
        '
        'TESCOLTableAdapter
        '
        Me.TESCOLTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAcepta, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(448, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAcepta
        '
        Me.btnAcepta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAcepta.Image = Global.Wallet.My.Resources.Resources.Accept
        Me.btnAcepta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAcepta.Name = "btnAcepta"
        Me.btnAcepta.Size = New System.Drawing.Size(23, 22)
        Me.btnAcepta.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Wallet.My.Resources.Resources.No
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'frmWALGLO00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 364)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvGlosas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALGLO00"
        Me.Text = "Relación entre Glosas y Columnas"
        CType(Me.dgvGlosas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESCOLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALGLOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALGLO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESGLOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGlosas As DataGridView
    Friend WithEvents DsWALGLOBindingSource As BindingSource
    Friend WithEvents DsWALGLO As dsWALGLO
    Friend WithEvents TESGLOBindingSource As BindingSource
    Friend WithEvents TESGLOTableAdapter As dsWALGLOTableAdapters.TESGLOTableAdapter
    Friend WithEvents TESCOLBindingSource As BindingSource
    Friend WithEvents TESCOLTableAdapter As dsWALGLOTableAdapters.TESCOLTableAdapter
    Friend WithEvents GLOGLOSADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GLOCOLUMNADataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents GLOAUDITORIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GLOCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAcepta As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
