<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALCTE00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALCTE00))
        Me.dgvCuentasCorrientes = New System.Windows.Forms.DataGridView()
        Me.TESCTECompletoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.CTE_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTRAZONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTENUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTECUENTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTESECUENCIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTECOLCHON1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTECOLCHON2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsWALCTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALCTE = New Wallet.dsWALCTE()
        Me.TESCTECompletoTableAdapter = New Wallet.dsWALCTETableAdapters.TESCTECompletoTableAdapter()
        CType(Me.dgvCuentasCorrientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESCTECompletoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DsWALCTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALCTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCuentasCorrientes
        '
        Me.dgvCuentasCorrientes.AllowUserToAddRows = False
        Me.dgvCuentasCorrientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCuentasCorrientes.AutoGenerateColumns = False
        Me.dgvCuentasCorrientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCuentasCorrientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvCuentasCorrientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentasCorrientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ENTRAZONDataGridViewTextBoxColumn, Me.CTENUMERODataGridViewTextBoxColumn, Me.CTECUENTADataGridViewTextBoxColumn, Me.CTESECUENCIADataGridViewTextBoxColumn, Me.CTECOLCHON1DataGridViewTextBoxColumn, Me.CTECOLCHON2DataGridViewTextBoxColumn, Me.CTE_CODIGO})
        Me.dgvCuentasCorrientes.DataSource = Me.TESCTECompletoBindingSource
        Me.dgvCuentasCorrientes.Location = New System.Drawing.Point(12, 58)
        Me.dgvCuentasCorrientes.Name = "dgvCuentasCorrientes"
        Me.dgvCuentasCorrientes.RowHeadersWidth = 50
        Me.dgvCuentasCorrientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCuentasCorrientes.Size = New System.Drawing.Size(735, 381)
        Me.dgvCuentasCorrientes.TabIndex = 0
        '
        'TESCTECompletoBindingSource
        '
        Me.TESCTECompletoBindingSource.DataMember = "TESCTECompleto"
        Me.TESCTECompletoBindingSource.DataSource = Me.DsWALCTEBindingSource
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(759, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir.Image = Global.Wallet.My.Resources.Resources.Print
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir.Text = "Imprimir Nómina de Cuentas Corrientes"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir de la Funcionalidad"
        '
        'CTE_CODIGO
        '
        Me.CTE_CODIGO.DataPropertyName = "CTE_CODIGO"
        Me.CTE_CODIGO.HeaderText = "CTE_CODIGO"
        Me.CTE_CODIGO.Name = "CTE_CODIGO"
        Me.CTE_CODIGO.ReadOnly = True
        Me.CTE_CODIGO.Visible = False
        '
        'ENTRAZONDataGridViewTextBoxColumn
        '
        Me.ENTRAZONDataGridViewTextBoxColumn.DataPropertyName = "ENT_RAZON"
        Me.ENTRAZONDataGridViewTextBoxColumn.HeaderText = "Razón Entidad"
        Me.ENTRAZONDataGridViewTextBoxColumn.Name = "ENTRAZONDataGridViewTextBoxColumn"
        Me.ENTRAZONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CTENUMERODataGridViewTextBoxColumn
        '
        Me.CTENUMERODataGridViewTextBoxColumn.DataPropertyName = "CTE_NUMERO"
        Me.CTENUMERODataGridViewTextBoxColumn.HeaderText = "Cuenta Corriente"
        Me.CTENUMERODataGridViewTextBoxColumn.Name = "CTENUMERODataGridViewTextBoxColumn"
        Me.CTENUMERODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CTECUENTADataGridViewTextBoxColumn
        '
        Me.CTECUENTADataGridViewTextBoxColumn.DataPropertyName = "CTE_CUENTA"
        Me.CTECUENTADataGridViewTextBoxColumn.HeaderText = "Código Copec"
        Me.CTECUENTADataGridViewTextBoxColumn.Name = "CTECUENTADataGridViewTextBoxColumn"
        Me.CTECUENTADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CTESECUENCIADataGridViewTextBoxColumn
        '
        Me.CTESECUENCIADataGridViewTextBoxColumn.DataPropertyName = "CTE_SECUENCIA"
        Me.CTESECUENCIADataGridViewTextBoxColumn.HeaderText = "Ubicación"
        Me.CTESECUENCIADataGridViewTextBoxColumn.Name = "CTESECUENCIADataGridViewTextBoxColumn"
        '
        'CTECOLCHON1DataGridViewTextBoxColumn
        '
        Me.CTECOLCHON1DataGridViewTextBoxColumn.DataPropertyName = "CTE_COLCHON1"
        Me.CTECOLCHON1DataGridViewTextBoxColumn.HeaderText = "Colchón 1"
        Me.CTECOLCHON1DataGridViewTextBoxColumn.Name = "CTECOLCHON1DataGridViewTextBoxColumn"
        '
        'CTECOLCHON2DataGridViewTextBoxColumn
        '
        Me.CTECOLCHON2DataGridViewTextBoxColumn.DataPropertyName = "CTE_COLCHON2"
        Me.CTECOLCHON2DataGridViewTextBoxColumn.HeaderText = "Colchón 2"
        Me.CTECOLCHON2DataGridViewTextBoxColumn.Name = "CTECOLCHON2DataGridViewTextBoxColumn"
        '
        'DsWALCTEBindingSource
        '
        Me.DsWALCTEBindingSource.DataSource = Me.DsWALCTE
        Me.DsWALCTEBindingSource.Position = 0
        '
        'DsWALCTE
        '
        Me.DsWALCTE.DataSetName = "dsWALCTE"
        Me.DsWALCTE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESCTECompletoTableAdapter
        '
        Me.TESCTECompletoTableAdapter.ClearBeforeFill = True
        '
        'frmWALCTE00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 452)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvCuentasCorrientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALCTE00"
        Me.Text = "Cuentas Corrientes"
        CType(Me.dgvCuentasCorrientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESCTECompletoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DsWALCTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALCTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCuentasCorrientes As DataGridView
    Friend WithEvents DsWALCTEBindingSource As BindingSource
    Friend WithEvents DsWALCTE As dsWALCTE
    Friend WithEvents TESCTECompletoBindingSource As BindingSource
    Friend WithEvents TESCTECompletoTableAdapter As dsWALCTETableAdapters.TESCTECompletoTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbImprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ENTRAZONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTENUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTECUENTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTESECUENCIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTECOLCHON1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTECOLCHON2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CTE_CODIGO As DataGridViewTextBoxColumn
End Class
