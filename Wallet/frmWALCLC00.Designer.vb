<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALCLC00
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
        Dim CLC_MONTOINVLabel As System.Windows.Forms.Label
        Dim CLC_TIPOTASALabel As System.Windows.Forms.Label
        Dim CLC_TASAEFELabel As System.Windows.Forms.Label
        Dim CLC_TASAESPLabel As System.Windows.Forms.Label
        Dim CLC_FECHAVENLabel As System.Windows.Forms.Label
        Dim CLC_FECHAINVLabel As System.Windows.Forms.Label
        Dim FON_CODIGOLabel As System.Windows.Forms.Label
        Dim ENT_CODIGOLabel As System.Windows.Forms.Label
        Dim INF_CODIGOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALCLC00))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dtpFechaColocación = New System.Windows.Forms.DateTimePicker()
        Me.chkPorFecha = New System.Windows.Forms.CheckBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.TESCLCBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALCLC = New Wallet.dsWALCLC()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.INF_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.TESCLCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESINFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENT_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TESFONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLC_FECHAINVDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CLC_FECHAVENDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CLC_TASAESPTextBox = New System.Windows.Forms.TextBox()
        Me.CLC_TASAEFETextBox = New System.Windows.Forms.TextBox()
        Me.CLC_TIPOTASATextBox = New System.Windows.Forms.TextBox()
        Me.CLC_MONTOINVTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.tsbContraseña = New System.Windows.Forms.ToolStripButton()
        Me.TESCLCTableAdapter = New Wallet.dsWALCLCTableAdapters.TESCLCTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALCLCTableAdapters.TableAdapterManager()
        Me.TESFONTableAdapter = New Wallet.dsWALCLCTableAdapters.TESFONTableAdapter()
        Me.TESINFTableAdapter = New Wallet.dsWALCLCTableAdapters.TESINFTableAdapter()
        Me.DsWALCLCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESENTTableAdapter = New Wallet.dsWALCLCTableAdapters.TESENTTableAdapter()
        Me.TESENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESFONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLC_FECHAINV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FONCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CLCMONTOINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLCFECHAVENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLCCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CLC_MONTOINVLabel = New System.Windows.Forms.Label()
        CLC_TIPOTASALabel = New System.Windows.Forms.Label()
        CLC_TASAEFELabel = New System.Windows.Forms.Label()
        CLC_TASAESPLabel = New System.Windows.Forms.Label()
        CLC_FECHAVENLabel = New System.Windows.Forms.Label()
        CLC_FECHAINVLabel = New System.Windows.Forms.Label()
        FON_CODIGOLabel = New System.Windows.Forms.Label()
        ENT_CODIGOLabel = New System.Windows.Forms.Label()
        INF_CODIGOLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESCLCBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALCLC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.TESCLCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.DsWALCLCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESFONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLC_MONTOINVLabel
        '
        CLC_MONTOINVLabel.AutoSize = True
        CLC_MONTOINVLabel.Location = New System.Drawing.Point(32, 254)
        CLC_MONTOINVLabel.Name = "CLC_MONTOINVLabel"
        CLC_MONTOINVLabel.Size = New System.Drawing.Size(86, 13)
        CLC_MONTOINVLabel.TabIndex = 26
        CLC_MONTOINVLabel.Text = "Monto Inversión:"
        '
        'CLC_TIPOTASALabel
        '
        CLC_TIPOTASALabel.AutoSize = True
        CLC_TIPOTASALabel.Location = New System.Drawing.Point(32, 228)
        CLC_TIPOTASALabel.Name = "CLC_TIPOTASALabel"
        CLC_TIPOTASALabel.Size = New System.Drawing.Size(58, 13)
        CLC_TIPOTASALabel.TabIndex = 24
        CLC_TIPOTASALabel.Text = "Tipo Tasa:"
        '
        'CLC_TASAEFELabel
        '
        CLC_TASAEFELabel.AutoSize = True
        CLC_TASAEFELabel.Location = New System.Drawing.Point(32, 202)
        CLC_TASAEFELabel.Name = "CLC_TASAEFELabel"
        CLC_TASAEFELabel.Size = New System.Drawing.Size(81, 13)
        CLC_TASAEFELabel.TabIndex = 22
        CLC_TASAEFELabel.Text = "CLC TASAEFE:"
        '
        'CLC_TASAESPLabel
        '
        CLC_TASAESPLabel.AutoSize = True
        CLC_TASAESPLabel.Location = New System.Drawing.Point(32, 176)
        CLC_TASAESPLabel.Name = "CLC_TASAESPLabel"
        CLC_TASAESPLabel.Size = New System.Drawing.Size(82, 13)
        CLC_TASAESPLabel.TabIndex = 20
        CLC_TASAESPLabel.Text = "CLC TASAESP:"
        '
        'CLC_FECHAVENLabel
        '
        CLC_FECHAVENLabel.AutoSize = True
        CLC_FECHAVENLabel.Location = New System.Drawing.Point(32, 153)
        CLC_FECHAVENLabel.Name = "CLC_FECHAVENLabel"
        CLC_FECHAVENLabel.Size = New System.Drawing.Size(101, 13)
        CLC_FECHAVENLabel.TabIndex = 18
        CLC_FECHAVENLabel.Text = "Fecha Vencimiento:"
        '
        'CLC_FECHAINVLabel
        '
        CLC_FECHAINVLabel.AutoSize = True
        CLC_FECHAINVLabel.Location = New System.Drawing.Point(32, 127)
        CLC_FECHAINVLabel.Name = "CLC_FECHAINVLabel"
        CLC_FECHAINVLabel.Size = New System.Drawing.Size(86, 13)
        CLC_FECHAINVLabel.TabIndex = 16
        CLC_FECHAINVLabel.Text = "Fecha Inversión:"
        '
        'FON_CODIGOLabel
        '
        FON_CODIGOLabel.AutoSize = True
        FON_CODIGOLabel.Location = New System.Drawing.Point(32, 71)
        FON_CODIGOLabel.Name = "FON_CODIGOLabel"
        FON_CODIGOLabel.Size = New System.Drawing.Size(40, 13)
        FON_CODIGOLabel.TabIndex = 4
        FON_CODIGOLabel.Text = "Fondo:"
        '
        'ENT_CODIGOLabel
        '
        ENT_CODIGOLabel.AutoSize = True
        ENT_CODIGOLabel.Location = New System.Drawing.Point(32, 42)
        ENT_CODIGOLabel.Name = "ENT_CODIGOLabel"
        ENT_CODIGOLabel.Size = New System.Drawing.Size(46, 13)
        ENT_CODIGOLabel.TabIndex = 62
        ENT_CODIGOLabel.Text = "Entidad:"
        '
        'INF_CODIGOLabel
        '
        INF_CODIGOLabel.AutoSize = True
        INF_CODIGOLabel.Location = New System.Drawing.Point(32, 97)
        INF_CODIGOLabel.Name = "INF_CODIGOLabel"
        INF_CODIGOLabel.Size = New System.Drawing.Size(65, 13)
        INF_CODIGOLabel.TabIndex = 63
        INF_CODIGOLabel.Text = "Instrumento:"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(802, 506)
        Me.SplitContainer1.SplitterDistance = 400
        Me.SplitContainer1.TabIndex = 0
        '
        'gbGeneral
        '
        Me.gbGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGeneral.Controls.Add(Me.dtpFechaColocación)
        Me.gbGeneral.Controls.Add(Me.chkPorFecha)
        Me.gbGeneral.Controls.Add(Me.dgvUsuarios)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(385, 475)
        Me.gbGeneral.TabIndex = 2
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Usuarios"
        '
        'dtpFechaColocación
        '
        Me.dtpFechaColocación.Enabled = False
        Me.dtpFechaColocación.Location = New System.Drawing.Point(7, 44)
        Me.dtpFechaColocación.Name = "dtpFechaColocación"
        Me.dtpFechaColocación.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaColocación.TabIndex = 5
        '
        'chkPorFecha
        '
        Me.chkPorFecha.AutoSize = True
        Me.chkPorFecha.Location = New System.Drawing.Point(7, 20)
        Me.chkPorFecha.Name = "chkPorFecha"
        Me.chkPorFecha.Size = New System.Drawing.Size(178, 17)
        Me.chkPorFecha.TabIndex = 4
        Me.chkPorFecha.Text = "Buscar por fecha de Colocación"
        Me.chkPorFecha.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToOrderColumns = True
        Me.dgvUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsuarios.AutoGenerateColumns = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuarios.ColumnHeadersHeight = 50
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLC_FECHAINV, Me.ENTCODIGODataGridViewTextBoxColumn, Me.FONCODIGODataGridViewTextBoxColumn, Me.CLCMONTOINVDataGridViewTextBoxColumn, Me.CLCFECHAVENDataGridViewTextBoxColumn, Me.CLCCODIGODataGridViewTextBoxColumn})
        Me.dgvUsuarios.DataSource = Me.TESCLCBindingSource1
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 68)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidth = 20
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(379, 396)
        Me.dgvUsuarios.TabIndex = 3
        '
        'TESCLCBindingSource1
        '
        Me.TESCLCBindingSource1.DataMember = "TESCLC"
        Me.TESCLCBindingSource1.DataSource = Me.DsWALCLC
        '
        'DsWALCLC
        '
        Me.DsWALCLC.DataSetName = "dsWALCLC"
        Me.DsWALCLC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(400, 25)
        Me.ToolStripGeneral.TabIndex = 1
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
        Me.tsbAgregar.ToolTipText = "Agrega Usuario"
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
        Me.gbDetalle.Controls.Add(INF_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.INF_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(ENT_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.ENT_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(Me.ComboBox1)
        Me.gbDetalle.Controls.Add(FON_CODIGOLabel)
        Me.gbDetalle.Controls.Add(CLC_FECHAINVLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_FECHAINVDateTimePicker)
        Me.gbDetalle.Controls.Add(CLC_FECHAVENLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_FECHAVENDateTimePicker)
        Me.gbDetalle.Controls.Add(CLC_TASAESPLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_TASAESPTextBox)
        Me.gbDetalle.Controls.Add(CLC_TASAEFELabel)
        Me.gbDetalle.Controls.Add(Me.CLC_TASAEFETextBox)
        Me.gbDetalle.Controls.Add(CLC_TIPOTASALabel)
        Me.gbDetalle.Controls.Add(Me.CLC_TIPOTASATextBox)
        Me.gbDetalle.Controls.Add(CLC_MONTOINVLabel)
        Me.gbDetalle.Controls.Add(Me.CLC_MONTOINVTextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(4, 28)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(394, 478)
        Me.gbDetalle.TabIndex = 2
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'INF_CODIGOComboBox
        '
        Me.INF_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCBindingSource, "INF_CODIGO", True))
        Me.INF_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESCLCBindingSource, "INF_CODIGO", True))
        Me.INF_CODIGOComboBox.DataSource = Me.TESINFBindingSource
        Me.INF_CODIGOComboBox.DisplayMember = "INF_NOMBRE"
        Me.INF_CODIGOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.INF_CODIGOComboBox.FormattingEnabled = True
        Me.INF_CODIGOComboBox.Location = New System.Drawing.Point(145, 94)
        Me.INF_CODIGOComboBox.Name = "INF_CODIGOComboBox"
        Me.INF_CODIGOComboBox.Size = New System.Drawing.Size(200, 21)
        Me.INF_CODIGOComboBox.TabIndex = 64
        Me.INF_CODIGOComboBox.ValueMember = "INF_CODIGO"
        '
        'TESCLCBindingSource
        '
        Me.TESCLCBindingSource.DataMember = "TESCLC"
        Me.TESCLCBindingSource.DataSource = Me.DsWALCLC
        '
        'TESINFBindingSource
        '
        Me.TESINFBindingSource.DataMember = "TESINF"
        Me.TESINFBindingSource.DataSource = Me.DsWALCLC
        '
        'ENT_CODIGOComboBox
        '
        Me.ENT_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCBindingSource, "ENT_CODIGO", True))
        Me.ENT_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESCLCBindingSource, "ENT_CODIGO", True))
        Me.ENT_CODIGOComboBox.DataSource = Me.TESENTBindingSource
        Me.ENT_CODIGOComboBox.DisplayMember = "ENT_RAZON"
        Me.ENT_CODIGOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ENT_CODIGOComboBox.Enabled = False
        Me.ENT_CODIGOComboBox.FormattingEnabled = True
        Me.ENT_CODIGOComboBox.Location = New System.Drawing.Point(145, 39)
        Me.ENT_CODIGOComboBox.Name = "ENT_CODIGOComboBox"
        Me.ENT_CODIGOComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ENT_CODIGOComboBox.TabIndex = 63
        Me.ENT_CODIGOComboBox.ValueMember = "ENT_CODIGO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESCLCBindingSource, "FON_CODIGO", True))
        Me.ComboBox1.DataSource = Me.TESFONBindingSource
        Me.ComboBox1.DisplayMember = "FON_FONDO"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(145, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 62
        Me.ComboBox1.ValueMember = "FON_CODIGO"
        '
        'TESFONBindingSource
        '
        Me.TESFONBindingSource.DataMember = "TESFON"
        Me.TESFONBindingSource.DataSource = Me.DsWALCLC
        '
        'CLC_FECHAINVDateTimePicker
        '
        Me.CLC_FECHAINVDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TESCLCBindingSource, "CLC_FECHAINV", True))
        Me.CLC_FECHAINVDateTimePicker.Enabled = False
        Me.CLC_FECHAINVDateTimePicker.Location = New System.Drawing.Point(145, 121)
        Me.CLC_FECHAINVDateTimePicker.Name = "CLC_FECHAINVDateTimePicker"
        Me.CLC_FECHAINVDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CLC_FECHAINVDateTimePicker.TabIndex = 17
        '
        'CLC_FECHAVENDateTimePicker
        '
        Me.CLC_FECHAVENDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TESCLCBindingSource, "CLC_FECHAVEN", True))
        Me.CLC_FECHAVENDateTimePicker.Location = New System.Drawing.Point(145, 147)
        Me.CLC_FECHAVENDateTimePicker.Name = "CLC_FECHAVENDateTimePicker"
        Me.CLC_FECHAVENDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CLC_FECHAVENDateTimePicker.TabIndex = 19
        '
        'CLC_TASAESPTextBox
        '
        Me.CLC_TASAESPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCBindingSource, "CLC_TASAESP", True))
        Me.CLC_TASAESPTextBox.Location = New System.Drawing.Point(145, 173)
        Me.CLC_TASAESPTextBox.Name = "CLC_TASAESPTextBox"
        Me.CLC_TASAESPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CLC_TASAESPTextBox.TabIndex = 21
        '
        'CLC_TASAEFETextBox
        '
        Me.CLC_TASAEFETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCBindingSource, "CLC_TASAEFE", True))
        Me.CLC_TASAEFETextBox.Location = New System.Drawing.Point(145, 199)
        Me.CLC_TASAEFETextBox.Name = "CLC_TASAEFETextBox"
        Me.CLC_TASAEFETextBox.Size = New System.Drawing.Size(200, 20)
        Me.CLC_TASAEFETextBox.TabIndex = 23
        '
        'CLC_TIPOTASATextBox
        '
        Me.CLC_TIPOTASATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCBindingSource, "CLC_TIPOTASA", True))
        Me.CLC_TIPOTASATextBox.Location = New System.Drawing.Point(145, 225)
        Me.CLC_TIPOTASATextBox.Name = "CLC_TIPOTASATextBox"
        Me.CLC_TIPOTASATextBox.Size = New System.Drawing.Size(200, 20)
        Me.CLC_TIPOTASATextBox.TabIndex = 25
        '
        'CLC_MONTOINVTextBox
        '
        Me.CLC_MONTOINVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCLCBindingSource, "CLC_MONTOINV", True))
        Me.CLC_MONTOINVTextBox.Location = New System.Drawing.Point(145, 251)
        Me.CLC_MONTOINVTextBox.Name = "CLC_MONTOINVTextBox"
        Me.CLC_MONTOINVTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CLC_MONTOINVTextBox.TabIndex = 27
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela, Me.tsbContraseña})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(398, 25)
        Me.ToolStripDetalle.TabIndex = 1
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
        'tsbContraseña
        '
        Me.tsbContraseña.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbContraseña.Image = CType(resources.GetObject("tsbContraseña.Image"), System.Drawing.Image)
        Me.tsbContraseña.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbContraseña.Name = "tsbContraseña"
        Me.tsbContraseña.Size = New System.Drawing.Size(23, 22)
        Me.tsbContraseña.Text = "ToolStripButton1"
        Me.tsbContraseña.ToolTipText = "Cambia Contraseña"
        '
        'TESCLCTableAdapter
        '
        Me.TESCLCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESCLCTableAdapter = Me.TESCLCTableAdapter
        Me.TableAdapterManager.TESENTTableAdapter = Nothing
        Me.TableAdapterManager.TESFONTableAdapter = Nothing
        Me.TableAdapterManager.TESINFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALCLCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TESFONTableAdapter
        '
        Me.TESFONTableAdapter.ClearBeforeFill = True
        '
        'TESINFTableAdapter
        '
        Me.TESINFTableAdapter.ClearBeforeFill = True
        '
        'DsWALCLCBindingSource
        '
        Me.DsWALCLCBindingSource.DataSource = Me.DsWALCLC
        Me.DsWALCLCBindingSource.Position = 0
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
        'TESENTBindingSource1
        '
        Me.TESENTBindingSource1.DataMember = "TESENT"
        Me.TESENTBindingSource1.DataSource = Me.DsWALCLC
        '
        'TESFONBindingSource1
        '
        Me.TESFONBindingSource1.DataMember = "TESFON"
        Me.TESFONBindingSource1.DataSource = Me.DsWALCLC
        '
        'CLC_FECHAINV
        '
        Me.CLC_FECHAINV.DataPropertyName = "CLC_FECHAINV"
        Me.CLC_FECHAINV.HeaderText = "Fecha Colocación"
        Me.CLC_FECHAINV.Name = "CLC_FECHAINV"
        Me.CLC_FECHAINV.ReadOnly = True
        '
        'ENTCODIGODataGridViewTextBoxColumn
        '
        Me.ENTCODIGODataGridViewTextBoxColumn.DataPropertyName = "ENT_CODIGO"
        Me.ENTCODIGODataGridViewTextBoxColumn.DataSource = Me.TESENTBindingSource1
        Me.ENTCODIGODataGridViewTextBoxColumn.DisplayMember = "ENT_RAZON"
        Me.ENTCODIGODataGridViewTextBoxColumn.HeaderText = "Entidad"
        Me.ENTCODIGODataGridViewTextBoxColumn.Name = "ENTCODIGODataGridViewTextBoxColumn"
        Me.ENTCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.ENTCODIGODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENTCODIGODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ENTCODIGODataGridViewTextBoxColumn.ValueMember = "ENT_CODIGO"
        '
        'FONCODIGODataGridViewTextBoxColumn
        '
        Me.FONCODIGODataGridViewTextBoxColumn.DataPropertyName = "FON_CODIGO"
        Me.FONCODIGODataGridViewTextBoxColumn.DataSource = Me.TESFONBindingSource1
        Me.FONCODIGODataGridViewTextBoxColumn.DisplayMember = "FON_FONDO"
        Me.FONCODIGODataGridViewTextBoxColumn.HeaderText = "Fondo"
        Me.FONCODIGODataGridViewTextBoxColumn.Name = "FONCODIGODataGridViewTextBoxColumn"
        Me.FONCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FONCODIGODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FONCODIGODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FONCODIGODataGridViewTextBoxColumn.ValueMember = "FON_CODIGO"
        '
        'CLCMONTOINVDataGridViewTextBoxColumn
        '
        Me.CLCMONTOINVDataGridViewTextBoxColumn.DataPropertyName = "CLC_MONTOINV"
        DataGridViewCellStyle1.Format = "C0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CLCMONTOINVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CLCMONTOINVDataGridViewTextBoxColumn.HeaderText = "Monto Inversión"
        Me.CLCMONTOINVDataGridViewTextBoxColumn.Name = "CLCMONTOINVDataGridViewTextBoxColumn"
        Me.CLCMONTOINVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLCFECHAVENDataGridViewTextBoxColumn
        '
        Me.CLCFECHAVENDataGridViewTextBoxColumn.DataPropertyName = "CLC_FECHAVEN"
        Me.CLCFECHAVENDataGridViewTextBoxColumn.HeaderText = "Fecha Vencimiento"
        Me.CLCFECHAVENDataGridViewTextBoxColumn.Name = "CLCFECHAVENDataGridViewTextBoxColumn"
        Me.CLCFECHAVENDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLCCODIGODataGridViewTextBoxColumn
        '
        Me.CLCCODIGODataGridViewTextBoxColumn.DataPropertyName = "CLC_CODIGO"
        Me.CLCCODIGODataGridViewTextBoxColumn.HeaderText = "CLC_CODIGO"
        Me.CLCCODIGODataGridViewTextBoxColumn.Name = "CLCCODIGODataGridViewTextBoxColumn"
        Me.CLCCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CLCCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'frmWALCLC00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALCLC00"
        Me.Text = "frmWALCLC00"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESCLCBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALCLC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.TESCLCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.DsWALCLCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESFONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStripGeneral As ToolStrip
    Friend WithEvents tsbAgregar As ToolStripButton
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents tsbImprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents tsbContraseña As ToolStripButton
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents chkPorFecha As CheckBox
    Friend WithEvents dtpFechaColocación As DateTimePicker
    Friend WithEvents DsWALCLC As dsWALCLC
    Friend WithEvents TESCLCBindingSource As BindingSource
    Friend WithEvents TESCLCTableAdapter As dsWALCLCTableAdapters.TESCLCTableAdapter
    Friend WithEvents TableAdapterManager As dsWALCLCTableAdapters.TableAdapterManager
    Friend WithEvents TESFONBindingSource As BindingSource
    Friend WithEvents TESFONTableAdapter As dsWALCLCTableAdapters.TESFONTableAdapter
    Friend WithEvents TESCLCBindingSource1 As BindingSource
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CLC_FECHAINVDateTimePicker As DateTimePicker
    Friend WithEvents CLC_FECHAVENDateTimePicker As DateTimePicker
    Friend WithEvents CLC_TASAESPTextBox As TextBox
    Friend WithEvents CLC_TASAEFETextBox As TextBox
    Friend WithEvents CLC_TIPOTASATextBox As TextBox
    Friend WithEvents CLC_MONTOINVTextBox As TextBox
    Friend WithEvents ENT_CODIGOComboBox As ComboBox
    Friend WithEvents INF_CODIGOComboBox As ComboBox
    Friend WithEvents TESINFBindingSource As BindingSource
    Friend WithEvents TESINFTableAdapter As dsWALCLCTableAdapters.TESINFTableAdapter
    Friend WithEvents DsWALCLCBindingSource As BindingSource
    Friend WithEvents TESENTBindingSource As BindingSource
    Friend WithEvents TESENTTableAdapter As dsWALCLCTableAdapters.TESENTTableAdapter
    Friend WithEvents CLC_FECHAINV As DataGridViewTextBoxColumn
    Friend WithEvents ENTCODIGODataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents TESENTBindingSource1 As BindingSource
    Friend WithEvents FONCODIGODataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents TESFONBindingSource1 As BindingSource
    Friend WithEvents CLCMONTOINVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLCFECHAVENDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLCCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
