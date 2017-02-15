<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALINF00
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
        Dim TII_CODIGOLabel As System.Windows.Forms.Label
        Dim INF_NOMBRELabel As System.Windows.Forms.Label
        Dim INF_ABREVIATURALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALINF00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvInstrumentos = New System.Windows.Forms.DataGridView()
        Me.INFNOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INFCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESINFDatagridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALINF = New Wallet.dsWALINF()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.TII_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.TESINFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESTIIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALINF1 = New Wallet.dsWALINF()
        Me.INF_NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.INF_ABREVIATURATextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.TESINFTableAdapter = New Wallet.dsWALINFTableAdapters.TESINFTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALINFTableAdapters.TableAdapterManager()
        Me.TESTIITableAdapter = New Wallet.dsWALINFTableAdapters.TESTIITableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TESINFDatagridTableAdapter = New Wallet.dsWALINFTableAdapters.TESINFDataGridTableAdapter()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        TII_CODIGOLabel = New System.Windows.Forms.Label()
        INF_NOMBRELabel = New System.Windows.Forms.Label()
        INF_ABREVIATURALabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvInstrumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESINFDatagridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALINF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTIIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALINF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TII_CODIGOLabel
        '
        TII_CODIGOLabel.AutoSize = True
        TII_CODIGOLabel.Location = New System.Drawing.Point(20, 41)
        TII_CODIGOLabel.Name = "TII_CODIGOLabel"
        TII_CODIGOLabel.Size = New System.Drawing.Size(92, 13)
        TII_CODIGOLabel.TabIndex = 2
        TII_CODIGOLabel.Text = "Tipo Instrumento :"
        '
        'INF_NOMBRELabel
        '
        INF_NOMBRELabel.AutoSize = True
        INF_NOMBRELabel.Location = New System.Drawing.Point(20, 78)
        INF_NOMBRELabel.Name = "INF_NOMBRELabel"
        INF_NOMBRELabel.Size = New System.Drawing.Size(108, 13)
        INF_NOMBRELabel.TabIndex = 4
        INF_NOMBRELabel.Text = "Nombre Instrumento :"
        '
        'INF_ABREVIATURALabel
        '
        INF_ABREVIATURALabel.AutoSize = True
        INF_ABREVIATURALabel.Location = New System.Drawing.Point(20, 115)
        INF_ABREVIATURALabel.Name = "INF_ABREVIATURALabel"
        INF_ABREVIATURALabel.Size = New System.Drawing.Size(67, 13)
        INF_ABREVIATURALabel.TabIndex = 6
        INF_ABREVIATURALabel.Text = "Abreviatura :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbGeneral)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripGeneral)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbDetalle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripDetalle)
        Me.SplitContainer1.Size = New System.Drawing.Size(697, 443)
        Me.SplitContainer1.SplitterDistance = 286
        Me.SplitContainer1.TabIndex = 0
        '
        'gbGeneral
        '
        Me.gbGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGeneral.Controls.Add(Me.dgvInstrumentos)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 412)
        Me.gbGeneral.TabIndex = 3
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Instrumentos"
        '
        'dgvInstrumentos
        '
        Me.dgvInstrumentos.AllowUserToAddRows = False
        Me.dgvInstrumentos.AllowUserToDeleteRows = False
        Me.dgvInstrumentos.AllowUserToOrderColumns = True
        Me.dgvInstrumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInstrumentos.AutoGenerateColumns = False
        Me.dgvInstrumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInstrumentos.BackgroundColor = System.Drawing.Color.White
        Me.dgvInstrumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INFNOMBREDataGridViewTextBoxColumn, Me.INFCODIGODataGridViewTextBoxColumn})
        Me.dgvInstrumentos.DataSource = Me.TESINFDatagridBindingSource
        Me.dgvInstrumentos.Location = New System.Drawing.Point(0, 19)
        Me.dgvInstrumentos.Name = "dgvInstrumentos"
        Me.dgvInstrumentos.ReadOnly = True
        Me.dgvInstrumentos.RowHeadersWidth = 20
        Me.dgvInstrumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInstrumentos.Size = New System.Drawing.Size(263, 384)
        Me.dgvInstrumentos.TabIndex = 3
        '
        'INFNOMBREDataGridViewTextBoxColumn
        '
        Me.INFNOMBREDataGridViewTextBoxColumn.DataPropertyName = "INF_NOMBRE"
        Me.INFNOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.INFNOMBREDataGridViewTextBoxColumn.Name = "INFNOMBREDataGridViewTextBoxColumn"
        Me.INFNOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INFCODIGODataGridViewTextBoxColumn
        '
        Me.INFCODIGODataGridViewTextBoxColumn.DataPropertyName = "INF_CODIGO"
        Me.INFCODIGODataGridViewTextBoxColumn.HeaderText = "INF_CODIGO"
        Me.INFCODIGODataGridViewTextBoxColumn.Name = "INFCODIGODataGridViewTextBoxColumn"
        Me.INFCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.INFCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESINFDatagridBindingSource
        '
        Me.TESINFDatagridBindingSource.DataMember = "TESINFDatagrid"
        Me.TESINFDatagridBindingSource.DataSource = Me.DsWALINF
        '
        'DsWALINF
        '
        Me.DsWALINF.DataSetName = "dsWALINF"
        Me.DsWALINF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(286, 25)
        Me.ToolStripGeneral.TabIndex = 2
        Me.ToolStripGeneral.Text = "ToolStrip1"
        '
        'tsbAgregar
        '
        Me.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregar.Image = CType(resources.GetObject("tsbAgregar.Image"), System.Drawing.Image)
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(23, 22)
        Me.tsbAgregar.Text = "ToolStripButton1"
        Me.tsbAgregar.ToolTipText = "Agrega Instrumento"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Instrumento"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(23, 22)
        Me.tsbRefrescar.Text = "ToolStripButton4"
        Me.tsbRefrescar.ToolTipText = "Refresca Grilla de Datos"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir.Text = "ToolStripButton5"
        Me.tsbImprimir.ToolTipText = "Genera Informe"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "ToolStripButton6"
        Me.tsbSalir.ToolTipText = "Cierra Ventana"
        '
        'gbDetalle
        '
        Me.gbDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalle.Controls.Add(TII_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.TII_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(INF_NOMBRELabel)
        Me.gbDetalle.Controls.Add(Me.INF_NOMBRETextBox)
        Me.gbDetalle.Controls.Add(INF_ABREVIATURALabel)
        Me.gbDetalle.Controls.Add(Me.INF_ABREVIATURATextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(7, 122)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(388, 157)
        Me.gbDetalle.TabIndex = 3
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'TII_CODIGOComboBox
        '
        Me.TII_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESINFBindingSource, "TII_CODIGO", True))
        Me.TII_CODIGOComboBox.DataSource = Me.TESTIIBindingSource
        Me.TII_CODIGOComboBox.DisplayMember = "TII_TIPO"
        Me.TII_CODIGOComboBox.FormattingEnabled = True
        Me.TII_CODIGOComboBox.Location = New System.Drawing.Point(145, 38)
        Me.TII_CODIGOComboBox.Name = "TII_CODIGOComboBox"
        Me.TII_CODIGOComboBox.Size = New System.Drawing.Size(208, 21)
        Me.TII_CODIGOComboBox.TabIndex = 3
        Me.TII_CODIGOComboBox.ValueMember = "TII_CODIGO"
        '
        'TESINFBindingSource
        '
        Me.TESINFBindingSource.DataMember = "TESINF"
        Me.TESINFBindingSource.DataSource = Me.DsWALINF
        '
        'TESTIIBindingSource
        '
        Me.TESTIIBindingSource.DataMember = "TESTII"
        Me.TESTIIBindingSource.DataSource = Me.DsWALINF1
        '
        'DsWALINF1
        '
        Me.DsWALINF1.DataSetName = "dsWALINF"
        Me.DsWALINF1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INF_NOMBRETextBox
        '
        Me.INF_NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESINFBindingSource, "INF_NOMBRE", True))
        Me.INF_NOMBRETextBox.Location = New System.Drawing.Point(145, 75)
        Me.INF_NOMBRETextBox.MaxLength = 25
        Me.INF_NOMBRETextBox.Name = "INF_NOMBRETextBox"
        Me.INF_NOMBRETextBox.Size = New System.Drawing.Size(208, 20)
        Me.INF_NOMBRETextBox.TabIndex = 5
        '
        'INF_ABREVIATURATextBox
        '
        Me.INF_ABREVIATURATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESINFBindingSource, "INF_ABREVIATURA", True))
        Me.INF_ABREVIATURATextBox.Location = New System.Drawing.Point(145, 112)
        Me.INF_ABREVIATURATextBox.MaxLength = 10
        Me.INF_ABREVIATURATextBox.Name = "INF_ABREVIATURATextBox"
        Me.INF_ABREVIATURATextBox.Size = New System.Drawing.Size(208, 20)
        Me.INF_ABREVIATURATextBox.TabIndex = 7
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(407, 25)
        Me.ToolStripDetalle.TabIndex = 2
        Me.ToolStripDetalle.Text = "ToolStrip2"
        '
        'tsbAcepta
        '
        Me.tsbAcepta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAcepta.Image = CType(resources.GetObject("tsbAcepta.Image"), System.Drawing.Image)
        Me.tsbAcepta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAcepta.Name = "tsbAcepta"
        Me.tsbAcepta.Size = New System.Drawing.Size(23, 22)
        Me.tsbAcepta.Text = "ToolStripButton1"
        '
        'tsbCancela
        '
        Me.tsbCancela.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancela.Image = CType(resources.GetObject("tsbCancela.Image"), System.Drawing.Image)
        Me.tsbCancela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancela.Name = "tsbCancela"
        Me.tsbCancela.Size = New System.Drawing.Size(23, 22)
        Me.tsbCancela.Text = "ToolStripButton2"
        '
        'TESINFTableAdapter
        '
        Me.TESINFTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESINFDataGridTableAdapter = Nothing
        Me.TableAdapterManager.TESINFTableAdapter = Me.TESINFTableAdapter
        Me.TableAdapterManager.TESTIITableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALINFTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TESTIITableAdapter
        '
        Me.TESTIITableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TESINFDatagridTableAdapter
        '
        Me.TESINFDatagridTableAdapter.ClearBeforeFill = True
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEliminar.Image = Global.Wallet.My.Resources.Resources.Delete
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEliminar.Text = "ToolStripButton1"
        '
        'frmWALINF00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 443)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALINF00"
        Me.Text = "Instrumentos Financieros"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvInstrumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESINFDatagridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALINF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTIIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALINF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStripGeneral As ToolStrip
    Friend WithEvents tsbAgregar As ToolStripButton
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents tsbImprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents dgvInstrumentos As DataGridView
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents DsWALINF As dsWALINF
    Friend WithEvents TESINFBindingSource As BindingSource
    Friend WithEvents TESINFTableAdapter As dsWALINFTableAdapters.TESINFTableAdapter
    Friend WithEvents TableAdapterManager As dsWALINFTableAdapters.TableAdapterManager
    Friend WithEvents TII_CODIGOComboBox As ComboBox
    Friend WithEvents INF_NOMBRETextBox As TextBox
    Friend WithEvents INF_ABREVIATURATextBox As TextBox
    Friend WithEvents DsWALINF1 As dsWALINF
    Friend WithEvents TESTIIBindingSource As BindingSource
    Friend WithEvents TESTIITableAdapter As dsWALINFTableAdapters.TESTIITableAdapter
    Friend WithEvents INFNOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INFCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TESINFDatagridBindingSource As BindingSource
    Friend WithEvents TESINFDatagridTableAdapter As dsWALINFTableAdapters.TESINFDataGridTableAdapter
    Friend WithEvents tsbEliminar As ToolStripButton
End Class
