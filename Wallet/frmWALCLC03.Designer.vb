<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALCLC03
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
        Dim INF_CODIGOLabel As System.Windows.Forms.Label
        Dim CLC_MONTOINVLabel As System.Windows.Forms.Label
        Dim CLC_TASAESPLabel As System.Windows.Forms.Label
        Dim CLC_TIPOTASALabel As System.Windows.Forms.Label
        Dim ENT_CODIGOLabel As System.Windows.Forms.Label
        Dim FON_CODIGOLabel As System.Windows.Forms.Label
        Dim CLC_FECHAVENLabel As System.Windows.Forms.Label
        Dim CLC_FECHAINVLabel As System.Windows.Forms.Label
        Dim CLC_FECHARESCLabel As System.Windows.Forms.Label
        Dim CLC_RESCATELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALCLC03))
        Me.DsWALCLC = New Wallet.dsWALCLC()
        Me.TESCLCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESCLCTableAdapter = New Wallet.dsWALCLCTableAdapters.TESCLCTableAdapter()
        Me.TESENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESENTTableAdapter = New Wallet.dsWALCLCTableAdapters.TESENTTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaColocacion = New System.Windows.Forms.DateTimePicker()
        Me.dgvColocaciones = New System.Windows.Forms.DataGridView()
        Me.CLCFECHAINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FONCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TESFONComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLCMONTOINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLC_FECHAVEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLCCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.CLC_RESCATETextBox = New System.Windows.Forms.TextBox()
        Me.TESCLCDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLC_FECHARESCDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.rbNominal = New System.Windows.Forms.RadioButton()
        Me.rbReal = New System.Windows.Forms.RadioButton()
        Me.INF_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.TESINFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLC_MONTOINVTextBox = New System.Windows.Forms.TextBox()
        Me.CLC_TASAESPTextBox = New System.Windows.Forms.TextBox()
        Me.ENT_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.TESENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FON_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.TESFONComboDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLC_FECHAVENDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CLC_FECHAINVDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.TESCLCDetalleTableAdapter = New Wallet.dsWALCLCTableAdapters.TESCLCDetalleTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALCLCTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DsWALENT = New Wallet.dsWALENT()
        Me.DsWALENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESFONComboDetalleTableAdapter = New Wallet.dsWALCLCTableAdapters.TESFONComboDetalleTableAdapter()
        Me.TESINFTableAdapter = New Wallet.dsWALCLCTableAdapters.TESINFTableAdapter()
        Me.TESFONComboTableAdapter = New Wallet.dsWALCLCTableAdapters.TESFONComboTableAdapter()
        Me.rbtColocacion = New System.Windows.Forms.RadioButton()
        Me.rbtVencimiento = New System.Windows.Forms.RadioButton()
        INF_CODIGOLabel = New System.Windows.Forms.Label()
        CLC_MONTOINVLabel = New System.Windows.Forms.Label()
        CLC_TASAESPLabel = New System.Windows.Forms.Label()
        CLC_TIPOTASALabel = New System.Windows.Forms.Label()
        ENT_CODIGOLabel = New System.Windows.Forms.Label()
        FON_CODIGOLabel = New System.Windows.Forms.Label()
        CLC_FECHAVENLabel = New System.Windows.Forms.Label()
        CLC_FECHAINVLabel = New System.Windows.Forms.Label()
        CLC_FECHARESCLabel = New System.Windows.Forms.Label()
        CLC_RESCATELabel = New System.Windows.Forms.Label()
        CType(Me.DsWALCLC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESCLCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvColocaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESFONComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.TESCLCDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESFONComboDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALENT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'INF_CODIGOLabel
        '
        INF_CODIGOLabel.AutoSize = True
        INF_CODIGOLabel.Location = New System.Drawing.Point(80, 160)
        INF_CODIGOLabel.Name = "INF_CODIGOLabel"
        INF_CODIGOLabel.Size = New System.Drawing.Size(40, 13)
        INF_CODIGOLabel.TabIndex = 17
        INF_CODIGOLabel.Text = "Papel :"
        '
        'CLC_MONTOINVLabel
        '
        CLC_MONTOINVLabel.AutoSize = True
        CLC_MONTOINVLabel.Location = New System.Drawing.Point(33, 244)
        CLC_MONTOINVLabel.Name = "CLC_MONTOINVLabel"
        CLC_MONTOINVLabel.Size = New System.Drawing.Size(87, 13)
        CLC_MONTOINVLabel.TabIndex = 16
        CLC_MONTOINVLabel.Text = "Monto Invertido :"
        '
        'CLC_TASAESPLabel
        '
        CLC_TASAESPLabel.AutoSize = True
        CLC_TASAESPLabel.Location = New System.Drawing.Point(83, 216)
        CLC_TASAESPLabel.Name = "CLC_TASAESPLabel"
        CLC_TASAESPLabel.Size = New System.Drawing.Size(37, 13)
        CLC_TASAESPLabel.TabIndex = 12
        CLC_TASAESPLabel.Text = "Tasa :"
        '
        'CLC_TIPOTASALabel
        '
        CLC_TIPOTASALabel.AutoSize = True
        CLC_TIPOTASALabel.Location = New System.Drawing.Point(44, 188)
        CLC_TIPOTASALabel.Name = "CLC_TIPOTASALabel"
        CLC_TIPOTASALabel.Size = New System.Drawing.Size(76, 13)
        CLC_TIPOTASALabel.TabIndex = 10
        CLC_TIPOTASALabel.Text = "Tipo de Tasa :"
        '
        'ENT_CODIGOLabel
        '
        ENT_CODIGOLabel.AutoSize = True
        ENT_CODIGOLabel.Location = New System.Drawing.Point(71, 104)
        ENT_CODIGOLabel.Name = "ENT_CODIGOLabel"
        ENT_CODIGOLabel.Size = New System.Drawing.Size(49, 13)
        ENT_CODIGOLabel.TabIndex = 6
        ENT_CODIGOLabel.Text = "Entidad :"
        '
        'FON_CODIGOLabel
        '
        FON_CODIGOLabel.AutoSize = True
        FON_CODIGOLabel.Location = New System.Drawing.Point(77, 132)
        FON_CODIGOLabel.Name = "FON_CODIGOLabel"
        FON_CODIGOLabel.Size = New System.Drawing.Size(43, 13)
        FON_CODIGOLabel.TabIndex = 4
        FON_CODIGOLabel.Text = "Fondo :"
        '
        'CLC_FECHAVENLabel
        '
        CLC_FECHAVENLabel.AutoSize = True
        CLC_FECHAVENLabel.Location = New System.Drawing.Point(16, 76)
        CLC_FECHAVENLabel.Name = "CLC_FECHAVENLabel"
        CLC_FECHAVENLabel.Size = New System.Drawing.Size(104, 13)
        CLC_FECHAVENLabel.TabIndex = 2
        CLC_FECHAVENLabel.Text = "Fecha Vencimiento :"
        '
        'CLC_FECHAINVLabel
        '
        CLC_FECHAINVLabel.AutoSize = True
        CLC_FECHAINVLabel.Location = New System.Drawing.Point(31, 48)
        CLC_FECHAINVLabel.Name = "CLC_FECHAINVLabel"
        CLC_FECHAINVLabel.Size = New System.Drawing.Size(89, 13)
        CLC_FECHAINVLabel.TabIndex = 0
        CLC_FECHAINVLabel.Text = "Fecha Inversión :"
        '
        'CLC_FECHARESCLabel
        '
        CLC_FECHARESCLabel.AutoSize = True
        CLC_FECHARESCLabel.Location = New System.Drawing.Point(34, 272)
        CLC_FECHARESCLabel.Name = "CLC_FECHARESCLabel"
        CLC_FECHARESCLabel.Size = New System.Drawing.Size(86, 13)
        CLC_FECHARESCLabel.TabIndex = 20
        CLC_FECHARESCLabel.Text = "Fecha Rescate :"
        '
        'CLC_RESCATELabel
        '
        CLC_RESCATELabel.AutoSize = True
        CLC_RESCATELabel.Location = New System.Drawing.Point(34, 300)
        CLC_RESCATELabel.Name = "CLC_RESCATELabel"
        CLC_RESCATELabel.Size = New System.Drawing.Size(86, 13)
        CLC_RESCATELabel.TabIndex = 21
        CLC_RESCATELabel.Text = "Monto Rescate :"
        '
        'DsWALCLC
        '
        Me.DsWALCLC.DataSetName = "dsWALCLC"
        Me.DsWALCLC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESCLCBindingSource
        '
        Me.TESCLCBindingSource.DataMember = "TESCLC"
        Me.TESCLCBindingSource.DataSource = Me.DsWALCLC
        '
        'TESCLCTableAdapter
        '
        Me.TESCLCTableAdapter.ClearBeforeFill = True
        '
        'TESENTBindingSource
        '
        Me.TESENTBindingSource.DataMember = "TESENT"
        Me.TESENTBindingSource.DataSource = Me.DsWALCLC
        '
        'TESENTTableAdapter
        '
        Me.TESENTTableAdapter.ClearBeforeFill = True
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
        Me.SplitContainer1.Size = New System.Drawing.Size(887, 506)
        Me.SplitContainer1.SplitterDistance = 518
        Me.SplitContainer1.TabIndex = 0
        '
        'gbGeneral
        '
        Me.gbGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGeneral.Controls.Add(Me.rbtVencimiento)
        Me.gbGeneral.Controls.Add(Me.rbtColocacion)
        Me.gbGeneral.Controls.Add(Me.Label1)
        Me.gbGeneral.Controls.Add(Me.dtpFechaColocacion)
        Me.gbGeneral.Controls.Add(Me.dgvColocaciones)
        Me.gbGeneral.Location = New System.Drawing.Point(8, 27)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(503, 475)
        Me.gbGeneral.TabIndex = 3
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Colocaciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha :"
        '
        'dtpFechaColocacion
        '
        Me.dtpFechaColocacion.Location = New System.Drawing.Point(70, 21)
        Me.dtpFechaColocacion.Name = "dtpFechaColocacion"
        Me.dtpFechaColocacion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaColocacion.TabIndex = 5
        '
        'dgvColocaciones
        '
        Me.dgvColocaciones.AllowUserToAddRows = False
        Me.dgvColocaciones.AllowUserToDeleteRows = False
        Me.dgvColocaciones.AllowUserToOrderColumns = True
        Me.dgvColocaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvColocaciones.AutoGenerateColumns = False
        Me.dgvColocaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvColocaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvColocaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvColocaciones.ColumnHeadersHeight = 50
        Me.dgvColocaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLCFECHAINVDataGridViewTextBoxColumn, Me.ENTCODIGODataGridViewTextBoxColumn, Me.FONCODIGODataGridViewTextBoxColumn, Me.CLCMONTOINVDataGridViewTextBoxColumn, Me.CLC_FECHAVEN, Me.CLCCODIGODataGridViewTextBoxColumn})
        Me.dgvColocaciones.DataSource = Me.TESCLCBindingSource
        Me.dgvColocaciones.Location = New System.Drawing.Point(0, 48)
        Me.dgvColocaciones.Name = "dgvColocaciones"
        Me.dgvColocaciones.ReadOnly = True
        Me.dgvColocaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvColocaciones.RowHeadersVisible = False
        Me.dgvColocaciones.RowHeadersWidth = 20
        Me.dgvColocaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColocaciones.Size = New System.Drawing.Size(497, 418)
        Me.dgvColocaciones.TabIndex = 3
        '
        'CLCFECHAINVDataGridViewTextBoxColumn
        '
        Me.CLCFECHAINVDataGridViewTextBoxColumn.DataPropertyName = "CLC_FECHAINV"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CLCFECHAINVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CLCFECHAINVDataGridViewTextBoxColumn.HeaderText = "Fecha Coloc."
        Me.CLCFECHAINVDataGridViewTextBoxColumn.Name = "CLCFECHAINVDataGridViewTextBoxColumn"
        Me.CLCFECHAINVDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLCFECHAINVDataGridViewTextBoxColumn.Width = 87
        '
        'ENTCODIGODataGridViewTextBoxColumn
        '
        Me.ENTCODIGODataGridViewTextBoxColumn.DataPropertyName = "ENT_CODIGO"
        Me.ENTCODIGODataGridViewTextBoxColumn.DataSource = Me.TESENTBindingSource
        Me.ENTCODIGODataGridViewTextBoxColumn.DisplayMember = "ENT_RAZON"
        Me.ENTCODIGODataGridViewTextBoxColumn.HeaderText = "Entidad"
        Me.ENTCODIGODataGridViewTextBoxColumn.Name = "ENTCODIGODataGridViewTextBoxColumn"
        Me.ENTCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.ENTCODIGODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENTCODIGODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ENTCODIGODataGridViewTextBoxColumn.ValueMember = "ENT_CODIGO"
        Me.ENTCODIGODataGridViewTextBoxColumn.Width = 68
        '
        'FONCODIGODataGridViewTextBoxColumn
        '
        Me.FONCODIGODataGridViewTextBoxColumn.DataPropertyName = "FON_CODIGO"
        Me.FONCODIGODataGridViewTextBoxColumn.DataSource = Me.TESFONComboBindingSource
        Me.FONCODIGODataGridViewTextBoxColumn.DisplayMember = "FON_FONDO"
        Me.FONCODIGODataGridViewTextBoxColumn.HeaderText = "Fondo"
        Me.FONCODIGODataGridViewTextBoxColumn.Name = "FONCODIGODataGridViewTextBoxColumn"
        Me.FONCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FONCODIGODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FONCODIGODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FONCODIGODataGridViewTextBoxColumn.ValueMember = "FON_CODIGO"
        Me.FONCODIGODataGridViewTextBoxColumn.Width = 62
        '
        'TESFONComboBindingSource
        '
        Me.TESFONComboBindingSource.DataMember = "TESFONCombo"
        Me.TESFONComboBindingSource.DataSource = Me.DsWALCLC
        '
        'CLCMONTOINVDataGridViewTextBoxColumn
        '
        Me.CLCMONTOINVDataGridViewTextBoxColumn.DataPropertyName = "CLC_MONTOINV"
        DataGridViewCellStyle2.Format = "C0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CLCMONTOINVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CLCMONTOINVDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.CLCMONTOINVDataGridViewTextBoxColumn.Name = "CLCMONTOINVDataGridViewTextBoxColumn"
        Me.CLCMONTOINVDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLCMONTOINVDataGridViewTextBoxColumn.Width = 62
        '
        'CLC_FECHAVEN
        '
        Me.CLC_FECHAVEN.DataPropertyName = "CLC_FECHAVEN"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CLC_FECHAVEN.DefaultCellStyle = DataGridViewCellStyle3
        Me.CLC_FECHAVEN.HeaderText = "Fecha Venc."
        Me.CLC_FECHAVEN.Name = "CLC_FECHAVEN"
        Me.CLC_FECHAVEN.ReadOnly = True
        Me.CLC_FECHAVEN.Width = 86
        '
        'CLCCODIGODataGridViewTextBoxColumn
        '
        Me.CLCCODIGODataGridViewTextBoxColumn.DataPropertyName = "CLC_CODIGO"
        Me.CLCCODIGODataGridViewTextBoxColumn.HeaderText = "CLC_CODIGO"
        Me.CLCCODIGODataGridViewTextBoxColumn.Name = "CLCCODIGODataGridViewTextBoxColumn"
        Me.CLCCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CLCCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbEditar, Me.tsbRefrescar, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(518, 25)
        Me.ToolStripGeneral.TabIndex = 2
        Me.ToolStripGeneral.Text = "ToolStrip1"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Usuario"
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
        Me.gbDetalle.Controls.Add(CLC_RESCATELabel)
        Me.gbDetalle.Controls.Add(Me.CLC_RESCATETextBox)
        Me.gbDetalle.Controls.Add(CLC_FECHARESCLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_FECHARESCDateTimePicker)
        Me.gbDetalle.Controls.Add(Me.rbNominal)
        Me.gbDetalle.Controls.Add(Me.rbReal)
        Me.gbDetalle.Controls.Add(INF_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.INF_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(CLC_MONTOINVLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_MONTOINVTextBox)
        Me.gbDetalle.Controls.Add(CLC_TASAESPLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_TASAESPTextBox)
        Me.gbDetalle.Controls.Add(CLC_TIPOTASALabel)
        Me.gbDetalle.Controls.Add(ENT_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.ENT_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(FON_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.FON_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(CLC_FECHAVENLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_FECHAVENDateTimePicker)
        Me.gbDetalle.Controls.Add(CLC_FECHAINVLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_FECHAINVDateTimePicker)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(4, 24)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(361, 479)
        Me.gbDetalle.TabIndex = 3
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'CLC_RESCATETextBox
        '
        Me.CLC_RESCATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCDetalleBindingSource, "CLC_RESCATE", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.CLC_RESCATETextBox.Location = New System.Drawing.Point(135, 297)
        Me.CLC_RESCATETextBox.Name = "CLC_RESCATETextBox"
        Me.CLC_RESCATETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CLC_RESCATETextBox.TabIndex = 22
        '
        'TESCLCDetalleBindingSource
        '
        Me.TESCLCDetalleBindingSource.DataMember = "TESCLCDetalle"
        Me.TESCLCDetalleBindingSource.DataSource = Me.DsWALCLC
        '
        'CLC_FECHARESCDateTimePicker
        '
        Me.CLC_FECHARESCDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TESCLCDetalleBindingSource, "CLC_FECHARESC", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.CLC_FECHARESCDateTimePicker.Location = New System.Drawing.Point(135, 266)
        Me.CLC_FECHARESCDateTimePicker.Name = "CLC_FECHARESCDateTimePicker"
        Me.CLC_FECHARESCDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CLC_FECHARESCDateTimePicker.TabIndex = 21
        '
        'rbNominal
        '
        Me.rbNominal.AutoSize = True
        Me.rbNominal.Enabled = False
        Me.rbNominal.Location = New System.Drawing.Point(193, 186)
        Me.rbNominal.Name = "rbNominal"
        Me.rbNominal.Size = New System.Drawing.Size(63, 17)
        Me.rbNominal.TabIndex = 20
        Me.rbNominal.TabStop = True
        Me.rbNominal.Text = "Nominal"
        Me.rbNominal.UseVisualStyleBackColor = True
        '
        'rbReal
        '
        Me.rbReal.AutoSize = True
        Me.rbReal.Enabled = False
        Me.rbReal.Location = New System.Drawing.Point(135, 186)
        Me.rbReal.Name = "rbReal"
        Me.rbReal.Size = New System.Drawing.Size(47, 17)
        Me.rbReal.TabIndex = 19
        Me.rbReal.TabStop = True
        Me.rbReal.Text = "Real"
        Me.rbReal.UseVisualStyleBackColor = True
        '
        'INF_CODIGOComboBox
        '
        Me.INF_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESCLCDetalleBindingSource, "INF_CODIGO", True))
        Me.INF_CODIGOComboBox.DataSource = Me.TESINFBindingSource
        Me.INF_CODIGOComboBox.DisplayMember = "INF_NOMBRE"
        Me.INF_CODIGOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.INF_CODIGOComboBox.Enabled = False
        Me.INF_CODIGOComboBox.FormattingEnabled = True
        Me.INF_CODIGOComboBox.Location = New System.Drawing.Point(135, 157)
        Me.INF_CODIGOComboBox.Name = "INF_CODIGOComboBox"
        Me.INF_CODIGOComboBox.Size = New System.Drawing.Size(121, 21)
        Me.INF_CODIGOComboBox.TabIndex = 18
        Me.INF_CODIGOComboBox.ValueMember = "INF_CODIGO"
        '
        'TESINFBindingSource
        '
        Me.TESINFBindingSource.DataMember = "TESINF"
        Me.TESINFBindingSource.DataSource = Me.DsWALCLC
        '
        'CLC_MONTOINVTextBox
        '
        Me.CLC_MONTOINVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCDetalleBindingSource, "CLC_MONTOINV", True))
        Me.CLC_MONTOINVTextBox.Enabled = False
        Me.CLC_MONTOINVTextBox.Location = New System.Drawing.Point(135, 241)
        Me.CLC_MONTOINVTextBox.Name = "CLC_MONTOINVTextBox"
        Me.CLC_MONTOINVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CLC_MONTOINVTextBox.TabIndex = 17
        '
        'CLC_TASAESPTextBox
        '
        Me.CLC_TASAESPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCDetalleBindingSource, "CLC_TASAESP", True))
        Me.CLC_TASAESPTextBox.Enabled = False
        Me.CLC_TASAESPTextBox.Location = New System.Drawing.Point(135, 213)
        Me.CLC_TASAESPTextBox.Name = "CLC_TASAESPTextBox"
        Me.CLC_TASAESPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CLC_TASAESPTextBox.TabIndex = 13
        '
        'ENT_CODIGOComboBox
        '
        Me.ENT_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESCLCDetalleBindingSource, "ENT_CODIGO", True))
        Me.ENT_CODIGOComboBox.DataSource = Me.TESENTBindingSource1
        Me.ENT_CODIGOComboBox.DisplayMember = "ENT_RAZON"
        Me.ENT_CODIGOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ENT_CODIGOComboBox.Enabled = False
        Me.ENT_CODIGOComboBox.FormattingEnabled = True
        Me.ENT_CODIGOComboBox.Location = New System.Drawing.Point(135, 101)
        Me.ENT_CODIGOComboBox.Name = "ENT_CODIGOComboBox"
        Me.ENT_CODIGOComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ENT_CODIGOComboBox.TabIndex = 7
        Me.ENT_CODIGOComboBox.ValueMember = "ENT_CODIGO"
        '
        'TESENTBindingSource1
        '
        Me.TESENTBindingSource1.DataMember = "TESENT"
        Me.TESENTBindingSource1.DataSource = Me.DsWALCLC
        '
        'FON_CODIGOComboBox
        '
        Me.FON_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESCLCDetalleBindingSource, "FON_CODIGO", True))
        Me.FON_CODIGOComboBox.DataSource = Me.TESFONComboDetalleBindingSource
        Me.FON_CODIGOComboBox.DisplayMember = "FON_FONDO"
        Me.FON_CODIGOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FON_CODIGOComboBox.Enabled = False
        Me.FON_CODIGOComboBox.FormattingEnabled = True
        Me.FON_CODIGOComboBox.Location = New System.Drawing.Point(135, 129)
        Me.FON_CODIGOComboBox.Name = "FON_CODIGOComboBox"
        Me.FON_CODIGOComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FON_CODIGOComboBox.TabIndex = 5
        Me.FON_CODIGOComboBox.ValueMember = "FON_CODIGO"
        '
        'TESFONComboDetalleBindingSource
        '
        Me.TESFONComboDetalleBindingSource.DataMember = "TESFONComboDetalle"
        Me.TESFONComboDetalleBindingSource.DataSource = Me.DsWALCLC
        '
        'CLC_FECHAVENDateTimePicker
        '
        Me.CLC_FECHAVENDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TESCLCDetalleBindingSource, "CLC_FECHAVEN", True))
        Me.CLC_FECHAVENDateTimePicker.Enabled = False
        Me.CLC_FECHAVENDateTimePicker.Location = New System.Drawing.Point(135, 70)
        Me.CLC_FECHAVENDateTimePicker.Name = "CLC_FECHAVENDateTimePicker"
        Me.CLC_FECHAVENDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CLC_FECHAVENDateTimePicker.TabIndex = 3
        '
        'CLC_FECHAINVDateTimePicker
        '
        Me.CLC_FECHAINVDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TESCLCDetalleBindingSource, "CLC_FECHAINV", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.CLC_FECHAINVDateTimePicker.Enabled = False
        Me.CLC_FECHAINVDateTimePicker.Location = New System.Drawing.Point(135, 42)
        Me.CLC_FECHAINVDateTimePicker.Name = "CLC_FECHAINVDateTimePicker"
        Me.CLC_FECHAINVDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CLC_FECHAINVDateTimePicker.TabIndex = 1
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(365, 25)
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
        'TESCLCDetalleTableAdapter
        '
        Me.TESCLCDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESCLCDetalleTableAdapter = Me.TESCLCDetalleTableAdapter
        Me.TableAdapterManager.TESCLCTableAdapter = Me.TESCLCTableAdapter
        Me.TableAdapterManager.TESENTTableAdapter = Me.TESENTTableAdapter
        Me.TableAdapterManager.TESFONTableAdapter = Nothing
        Me.TableAdapterManager.TESINFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALCLCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DsWALENT
        '
        Me.DsWALENT.DataSetName = "dsWALENT"
        Me.DsWALENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsWALENTBindingSource
        '
        Me.DsWALENTBindingSource.DataSource = Me.DsWALENT
        Me.DsWALENTBindingSource.Position = 0
        '
        'TESFONComboDetalleTableAdapter
        '
        Me.TESFONComboDetalleTableAdapter.ClearBeforeFill = True
        '
        'TESINFTableAdapter
        '
        Me.TESINFTableAdapter.ClearBeforeFill = True
        '
        'TESFONComboTableAdapter
        '
        Me.TESFONComboTableAdapter.ClearBeforeFill = True
        '
        'rbtColocacion
        '
        Me.rbtColocacion.AutoSize = True
        Me.rbtColocacion.Checked = True
        Me.rbtColocacion.Location = New System.Drawing.Point(288, 23)
        Me.rbtColocacion.Name = "rbtColocacion"
        Me.rbtColocacion.Size = New System.Drawing.Size(78, 17)
        Me.rbtColocacion.TabIndex = 8
        Me.rbtColocacion.TabStop = True
        Me.rbtColocacion.Text = "Colocación"
        Me.rbtColocacion.UseVisualStyleBackColor = True
        '
        'rbtVencimiento
        '
        Me.rbtVencimiento.AutoSize = True
        Me.rbtVencimiento.Location = New System.Drawing.Point(395, 23)
        Me.rbtVencimiento.Name = "rbtVencimiento"
        Me.rbtVencimiento.Size = New System.Drawing.Size(83, 17)
        Me.rbtVencimiento.TabIndex = 9
        Me.rbtVencimiento.Text = "Vencimiento"
        Me.rbtVencimiento.UseVisualStyleBackColor = True
        '
        'frmWALCLC03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALCLC03"
        Me.Text = "Rescate"
        CType(Me.DsWALCLC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESCLCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        CType(Me.dgvColocaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESFONComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.TESCLCDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESFONComboDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALENT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsWALCLC As dsWALCLC
    Friend WithEvents TESCLCBindingSource As BindingSource
    Friend WithEvents TESCLCTableAdapter As dsWALCLCTableAdapters.TESCLCTableAdapter
    Friend WithEvents TESENTBindingSource As BindingSource
    Friend WithEvents TESENTTableAdapter As dsWALCLCTableAdapters.TESENTTableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStripGeneral As ToolStrip
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents dtpFechaColocacion As DateTimePicker
    Friend WithEvents dgvColocaciones As DataGridView
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents rbNominal As RadioButton
    Friend WithEvents rbReal As RadioButton
    Friend WithEvents INF_CODIGOComboBox As ComboBox
    Friend WithEvents CLC_MONTOINVTextBox As TextBox
    Friend WithEvents CLC_TASAESPTextBox As TextBox
    Friend WithEvents ENT_CODIGOComboBox As ComboBox
    Friend WithEvents FON_CODIGOComboBox As ComboBox
    Friend WithEvents CLC_FECHAVENDateTimePicker As DateTimePicker
    Friend WithEvents CLC_FECHAINVDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TESCLCDetalleBindingSource As BindingSource
    Friend WithEvents TESCLCDetalleTableAdapter As dsWALCLCTableAdapters.TESCLCDetalleTableAdapter
    Friend WithEvents TableAdapterManager As dsWALCLCTableAdapters.TableAdapterManager
    Friend WithEvents CLC_RESCATETextBox As TextBox
    Friend WithEvents CLC_FECHARESCDateTimePicker As DateTimePicker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TESENTBindingSource1 As BindingSource
    Friend WithEvents DsWALENT As dsWALENT
    Friend WithEvents DsWALENTBindingSource As BindingSource
    Friend WithEvents TESFONComboDetalleBindingSource As BindingSource
    Friend WithEvents TESFONComboDetalleTableAdapter As dsWALCLCTableAdapters.TESFONComboDetalleTableAdapter
    Friend WithEvents TESINFBindingSource As BindingSource
    Friend WithEvents TESINFTableAdapter As dsWALCLCTableAdapters.TESINFTableAdapter
    Friend WithEvents TESFONComboBindingSource As BindingSource
    Friend WithEvents TESFONComboTableAdapter As dsWALCLCTableAdapters.TESFONComboTableAdapter
    Friend WithEvents CLCFECHAINVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENTCODIGODataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents FONCODIGODataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents CLCMONTOINVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLC_FECHAVEN As DataGridViewTextBoxColumn
    Friend WithEvents CLCCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents rbtVencimiento As RadioButton
    Friend WithEvents rbtColocacion As RadioButton
End Class
