<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALTREC00
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALTREC00))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbActualiza = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstbTotal = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspbProceso = New System.Windows.Forms.ToolStripProgressBar()
        Me.tslbActualizando = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TraeMovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALPLA = New Wallet.dsWALPLA()
        Me.TraeMovimientosTableAdapter = New Wallet.dsWALPLATableAdapters.TraeMovimientosTableAdapter()
        Me.VIASIGNIFICADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAZCUENTABANCODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraeMovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbActualiza, Me.ToolStripSeparator1, Me.tsbSalir, Me.ToolStripSeparator2, Me.tstbTotal, Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.tspbProceso, Me.tslbActualizando})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(647, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbActualiza
        '
        Me.tsbActualiza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbActualiza.Image = Global.Wallet.My.Resources.Resources.Accept
        Me.tsbActualiza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActualiza.Name = "tsbActualiza"
        Me.tsbActualiza.Size = New System.Drawing.Size(23, 22)
        Me.tsbActualiza.Text = "ActualizaRecaudaciones"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir Funcionalidad"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tstbTotal
        '
        Me.tstbTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tstbTotal.Name = "tstbTotal"
        Me.tstbTotal.Size = New System.Drawing.Size(150, 25)
        Me.tstbTotal.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripLabel1.Text = "Total Recaudación :"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tspbProceso
        '
        Me.tspbProceso.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tspbProceso.Name = "tspbProceso"
        Me.tspbProceso.Size = New System.Drawing.Size(100, 22)
        Me.tspbProceso.Visible = False
        '
        'tslbActualizando
        '
        Me.tslbActualizando.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslbActualizando.Name = "tslbActualizando"
        Me.tslbActualizando.Size = New System.Drawing.Size(85, 22)
        Me.tslbActualizando.Text = "Actualizando..."
        Me.tslbActualizando.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VIASIGNIFICADODataGridViewTextBoxColumn, Me.DAZCUENTABANCODataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TraeMovimientosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(623, 474)
        Me.DataGridView1.TabIndex = 1
        '
        'TraeMovimientosBindingSource
        '
        Me.TraeMovimientosBindingSource.DataMember = "TraeMovimientos"
        Me.TraeMovimientosBindingSource.DataSource = Me.DsWALPLA
        '
        'DsWALPLA
        '
        Me.DsWALPLA.DataSetName = "dsWALPLA"
        Me.DsWALPLA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TraeMovimientosTableAdapter
        '
        Me.TraeMovimientosTableAdapter.ClearBeforeFill = True
        '
        'VIASIGNIFICADODataGridViewTextBoxColumn
        '
        Me.VIASIGNIFICADODataGridViewTextBoxColumn.DataPropertyName = "VIA_SIGNIFICADO"
        Me.VIASIGNIFICADODataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.VIASIGNIFICADODataGridViewTextBoxColumn.Name = "VIASIGNIFICADODataGridViewTextBoxColumn"
        Me.VIASIGNIFICADODataGridViewTextBoxColumn.ReadOnly = True
        Me.VIASIGNIFICADODataGridViewTextBoxColumn.Width = 200
        '
        'DAZCUENTABANCODataGridViewTextBoxColumn
        '
        Me.DAZCUENTABANCODataGridViewTextBoxColumn.DataPropertyName = "DAZ_CUENTABANCO"
        Me.DAZCUENTABANCODataGridViewTextBoxColumn.HeaderText = "Cuenta"
        Me.DAZCUENTABANCODataGridViewTextBoxColumn.Name = "DAZCUENTABANCODataGridViewTextBoxColumn"
        Me.DAZCUENTABANCODataGridViewTextBoxColumn.ReadOnly = True
        Me.DAZCUENTABANCODataGridViewTextBoxColumn.Width = 200
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 150
        '
        'frmWALTREC00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 514)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALTREC00"
        Me.Text = "Recaudación"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraeMovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbActualiza As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsWALPLA As dsWALPLA
    Friend WithEvents TraeMovimientosBindingSource As BindingSource
    Friend WithEvents TraeMovimientosTableAdapter As dsWALPLATableAdapters.TraeMovimientosTableAdapter
    Friend WithEvents tstbTotal As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tspbProceso As ToolStripProgressBar
    Friend WithEvents tslbActualizando As ToolStripLabel
    Friend WithEvents VIASIGNIFICADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DAZCUENTABANCODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
