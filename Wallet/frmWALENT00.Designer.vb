<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWALENT00
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
        Dim TEN_CODIGOLabel As System.Windows.Forms.Label
        Dim ENT_RAZONLabel As System.Windows.Forms.Label
        Dim ENT_ABREVIATURALabel As System.Windows.Forms.Label
        Dim ENT_RUTLabel As System.Windows.Forms.Label
        Dim ENT_LIMITELabel As System.Windows.Forms.Label
        Dim ENT_SITIOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALENT00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvEntidades = New System.Windows.Forms.DataGridView()
        Me.ENTRAZONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESENTDataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALENT = New Wallet.dsWALENT()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.rbCondicionada = New System.Windows.Forms.RadioButton()
        Me.rbBloqueada = New System.Windows.Forms.RadioButton()
        Me.rbActiva = New System.Windows.Forms.RadioButton()
        Me.TEN_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.TESENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESTENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENT_RAZONTextBox = New System.Windows.Forms.TextBox()
        Me.ENT_ABREVIATURATextBox = New System.Windows.Forms.TextBox()
        Me.ENT_RUTTextBox = New System.Windows.Forms.TextBox()
        Me.ENT_LIMITETextBox = New System.Windows.Forms.TextBox()
        Me.ENT_SITIOTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.TESENTDataGridTableAdapter = New Wallet.dsWALENTTableAdapters.TESENTDataGridTableAdapter()
        Me.TESENTTableAdapter = New Wallet.dsWALENTTableAdapters.TESENTTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALENTTableAdapters.TableAdapterManager()
        Me.TESTENTableAdapter = New Wallet.dsWALENTTableAdapters.TESTENTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        TEN_CODIGOLabel = New System.Windows.Forms.Label()
        ENT_RAZONLabel = New System.Windows.Forms.Label()
        ENT_ABREVIATURALabel = New System.Windows.Forms.Label()
        ENT_RUTLabel = New System.Windows.Forms.Label()
        ENT_LIMITELabel = New System.Windows.Forms.Label()
        ENT_SITIOLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTDataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALENT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TEN_CODIGOLabel
        '
        TEN_CODIGOLabel.AutoSize = True
        TEN_CODIGOLabel.Location = New System.Drawing.Point(21, 41)
        TEN_CODIGOLabel.Name = "TEN_CODIGOLabel"
        TEN_CODIGOLabel.Size = New System.Drawing.Size(70, 13)
        TEN_CODIGOLabel.TabIndex = 2
        TEN_CODIGOLabel.Text = "Tipo Entidad:"
        '
        'ENT_RAZONLabel
        '
        ENT_RAZONLabel.AutoSize = True
        ENT_RAZONLabel.Location = New System.Drawing.Point(21, 103)
        ENT_RAZONLabel.Name = "ENT_RAZONLabel"
        ENT_RAZONLabel.Size = New System.Drawing.Size(73, 13)
        ENT_RAZONLabel.TabIndex = 4
        ENT_RAZONLabel.Text = "Razón Social:"
        '
        'ENT_ABREVIATURALabel
        '
        ENT_ABREVIATURALabel.AutoSize = True
        ENT_ABREVIATURALabel.Location = New System.Drawing.Point(21, 165)
        ENT_ABREVIATURALabel.Name = "ENT_ABREVIATURALabel"
        ENT_ABREVIATURALabel.Size = New System.Drawing.Size(64, 13)
        ENT_ABREVIATURALabel.TabIndex = 6
        ENT_ABREVIATURALabel.Text = "Abreviatura:"
        '
        'ENT_RUTLabel
        '
        ENT_RUTLabel.AutoSize = True
        ENT_RUTLabel.Location = New System.Drawing.Point(21, 227)
        ENT_RUTLabel.Name = "ENT_RUTLabel"
        ENT_RUTLabel.Size = New System.Drawing.Size(33, 13)
        ENT_RUTLabel.TabIndex = 8
        ENT_RUTLabel.Text = "RUT:"
        '
        'ENT_LIMITELabel
        '
        ENT_LIMITELabel.AutoSize = True
        ENT_LIMITELabel.Location = New System.Drawing.Point(21, 289)
        ENT_LIMITELabel.Name = "ENT_LIMITELabel"
        ENT_LIMITELabel.Size = New System.Drawing.Size(39, 13)
        ENT_LIMITELabel.TabIndex = 10
        ENT_LIMITELabel.Text = "Límite:"
        '
        'ENT_SITIOLabel
        '
        ENT_SITIOLabel.AutoSize = True
        ENT_SITIOLabel.Location = New System.Drawing.Point(21, 351)
        ENT_SITIOLabel.Name = "ENT_SITIOLabel"
        ENT_SITIOLabel.Size = New System.Drawing.Size(56, 13)
        ENT_SITIOLabel.TabIndex = 14
        ENT_SITIOLabel.Text = "Sitio Web:"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(697, 506)
        Me.SplitContainer1.SplitterDistance = 284
        Me.SplitContainer1.TabIndex = 0
        '
        'gbGeneral
        '
        Me.gbGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGeneral.Controls.Add(Me.dgvEntidades)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 475)
        Me.gbGeneral.TabIndex = 2
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Entidades"
        '
        'dgvEntidades
        '
        Me.dgvEntidades.AllowUserToAddRows = False
        Me.dgvEntidades.AllowUserToDeleteRows = False
        Me.dgvEntidades.AllowUserToOrderColumns = True
        Me.dgvEntidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEntidades.AutoGenerateColumns = False
        Me.dgvEntidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEntidades.BackgroundColor = System.Drawing.Color.White
        Me.dgvEntidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ENTRAZONDataGridViewTextBoxColumn, Me.ENTCODIGODataGridViewTextBoxColumn})
        Me.dgvEntidades.DataSource = Me.TESENTDataGridBindingSource
        Me.dgvEntidades.Location = New System.Drawing.Point(0, 19)
        Me.dgvEntidades.Name = "dgvEntidades"
        Me.dgvEntidades.ReadOnly = True
        Me.dgvEntidades.RowHeadersWidth = 20
        Me.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntidades.Size = New System.Drawing.Size(263, 447)
        Me.dgvEntidades.TabIndex = 3
        '
        'ENTRAZONDataGridViewTextBoxColumn
        '
        Me.ENTRAZONDataGridViewTextBoxColumn.DataPropertyName = "ENT_RAZON"
        Me.ENTRAZONDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.ENTRAZONDataGridViewTextBoxColumn.Name = "ENTRAZONDataGridViewTextBoxColumn"
        Me.ENTRAZONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ENTCODIGODataGridViewTextBoxColumn
        '
        Me.ENTCODIGODataGridViewTextBoxColumn.DataPropertyName = "ENT_CODIGO"
        Me.ENTCODIGODataGridViewTextBoxColumn.HeaderText = "ENT_CODIGO"
        Me.ENTCODIGODataGridViewTextBoxColumn.Name = "ENTCODIGODataGridViewTextBoxColumn"
        Me.ENTCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.ENTCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESENTDataGridBindingSource
        '
        Me.TESENTDataGridBindingSource.DataMember = "TESENTDataGrid"
        Me.TESENTDataGridBindingSource.DataSource = Me.DsWALENT
        '
        'DsWALENT
        '
        Me.DsWALENT.DataSetName = "dsWALENT"
        Me.DsWALENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(284, 25)
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
        Me.tsbAgregar.ToolTipText = "Agrega Entidad"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Entidad"
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
        Me.gbDetalle.Controls.Add(Me.rbCondicionada)
        Me.gbDetalle.Controls.Add(Me.rbBloqueada)
        Me.gbDetalle.Controls.Add(Me.rbActiva)
        Me.gbDetalle.Controls.Add(TEN_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.TEN_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(ENT_RAZONLabel)
        Me.gbDetalle.Controls.Add(Me.ENT_RAZONTextBox)
        Me.gbDetalle.Controls.Add(ENT_ABREVIATURALabel)
        Me.gbDetalle.Controls.Add(Me.ENT_ABREVIATURATextBox)
        Me.gbDetalle.Controls.Add(ENT_RUTLabel)
        Me.gbDetalle.Controls.Add(Me.ENT_RUTTextBox)
        Me.gbDetalle.Controls.Add(ENT_LIMITELabel)
        Me.gbDetalle.Controls.Add(Me.ENT_LIMITETextBox)
        Me.gbDetalle.Controls.Add(ENT_SITIOLabel)
        Me.gbDetalle.Controls.Add(Me.ENT_SITIOTextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(13, 28)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(396, 478)
        Me.gbDetalle.TabIndex = 2
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'rbCondicionada
        '
        Me.rbCondicionada.AutoSize = True
        Me.rbCondicionada.Location = New System.Drawing.Point(263, 413)
        Me.rbCondicionada.Name = "rbCondicionada"
        Me.rbCondicionada.Size = New System.Drawing.Size(90, 17)
        Me.rbCondicionada.TabIndex = 18
        Me.rbCondicionada.TabStop = True
        Me.rbCondicionada.Text = "Condicionada"
        Me.rbCondicionada.UseVisualStyleBackColor = True
        '
        'rbBloqueada
        '
        Me.rbBloqueada.AutoSize = True
        Me.rbBloqueada.Location = New System.Drawing.Point(135, 413)
        Me.rbBloqueada.Name = "rbBloqueada"
        Me.rbBloqueada.Size = New System.Drawing.Size(76, 17)
        Me.rbBloqueada.TabIndex = 17
        Me.rbBloqueada.TabStop = True
        Me.rbBloqueada.Text = "Bloqueada"
        Me.rbBloqueada.UseVisualStyleBackColor = True
        '
        'rbActiva
        '
        Me.rbActiva.AutoSize = True
        Me.rbActiva.Location = New System.Drawing.Point(28, 413)
        Me.rbActiva.Name = "rbActiva"
        Me.rbActiva.Size = New System.Drawing.Size(55, 17)
        Me.rbActiva.TabIndex = 16
        Me.rbActiva.TabStop = True
        Me.rbActiva.Text = "Activa"
        Me.rbActiva.UseVisualStyleBackColor = True
        '
        'TEN_CODIGOComboBox
        '
        Me.TEN_CODIGOComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEN_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESENTBindingSource, "TEN_CODIGO", True))
        Me.TEN_CODIGOComboBox.DataSource = Me.TESTENBindingSource
        Me.TEN_CODIGOComboBox.DisplayMember = "TEN_TIPO"
        Me.TEN_CODIGOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TEN_CODIGOComboBox.FormattingEnabled = True
        Me.TEN_CODIGOComboBox.Location = New System.Drawing.Point(125, 38)
        Me.TEN_CODIGOComboBox.Name = "TEN_CODIGOComboBox"
        Me.TEN_CODIGOComboBox.Size = New System.Drawing.Size(228, 21)
        Me.TEN_CODIGOComboBox.TabIndex = 3
        Me.TEN_CODIGOComboBox.ValueMember = "TEN_CODIGO"
        '
        'TESENTBindingSource
        '
        Me.TESENTBindingSource.DataMember = "TESENT"
        Me.TESENTBindingSource.DataSource = Me.DsWALENT
        '
        'TESTENBindingSource
        '
        Me.TESTENBindingSource.DataMember = "TESTEN"
        Me.TESTENBindingSource.DataSource = Me.DsWALENT
        '
        'ENT_RAZONTextBox
        '
        Me.ENT_RAZONTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ENT_RAZONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESENTBindingSource, "ENT_RAZON", True))
        Me.ENT_RAZONTextBox.Location = New System.Drawing.Point(125, 100)
        Me.ENT_RAZONTextBox.Name = "ENT_RAZONTextBox"
        Me.ENT_RAZONTextBox.Size = New System.Drawing.Size(228, 20)
        Me.ENT_RAZONTextBox.TabIndex = 5
        '
        'ENT_ABREVIATURATextBox
        '
        Me.ENT_ABREVIATURATextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ENT_ABREVIATURATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESENTBindingSource, "ENT_ABREVIATURA", True))
        Me.ENT_ABREVIATURATextBox.Location = New System.Drawing.Point(125, 162)
        Me.ENT_ABREVIATURATextBox.Name = "ENT_ABREVIATURATextBox"
        Me.ENT_ABREVIATURATextBox.Size = New System.Drawing.Size(228, 20)
        Me.ENT_ABREVIATURATextBox.TabIndex = 7
        '
        'ENT_RUTTextBox
        '
        Me.ENT_RUTTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ENT_RUTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESENTBindingSource, "ENT_RUT", True))
        Me.ENT_RUTTextBox.Location = New System.Drawing.Point(125, 224)
        Me.ENT_RUTTextBox.Name = "ENT_RUTTextBox"
        Me.ENT_RUTTextBox.Size = New System.Drawing.Size(228, 20)
        Me.ENT_RUTTextBox.TabIndex = 9
        '
        'ENT_LIMITETextBox
        '
        Me.ENT_LIMITETextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ENT_LIMITETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESENTBindingSource, "ENT_LIMITE", True))
        Me.ENT_LIMITETextBox.Location = New System.Drawing.Point(125, 286)
        Me.ENT_LIMITETextBox.Name = "ENT_LIMITETextBox"
        Me.ENT_LIMITETextBox.Size = New System.Drawing.Size(228, 20)
        Me.ENT_LIMITETextBox.TabIndex = 11
        '
        'ENT_SITIOTextBox
        '
        Me.ENT_SITIOTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ENT_SITIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESENTBindingSource, "ENT_SITIO", True))
        Me.ENT_SITIOTextBox.Location = New System.Drawing.Point(125, 348)
        Me.ENT_SITIOTextBox.Name = "ENT_SITIOTextBox"
        Me.ENT_SITIOTextBox.Size = New System.Drawing.Size(228, 20)
        Me.ENT_SITIOTextBox.TabIndex = 15
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(409, 25)
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
        'TESENTDataGridTableAdapter
        '
        Me.TESENTDataGridTableAdapter.ClearBeforeFill = True
        '
        'TESENTTableAdapter
        '
        Me.TESENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESENTTableAdapter = Me.TESENTTableAdapter
        Me.TableAdapterManager.TESTENTableAdapter = Me.TESTENTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALENTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TESTENTableAdapter
        '
        Me.TESTENTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        'frmWALENT00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(697, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALENT00"
        Me.Text = "Entidades Financieras"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTDataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALENT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvEntidades As DataGridView
    Friend WithEvents DsWALENT As dsWALENT
    Friend WithEvents TESENTDataGridBindingSource As BindingSource
    Friend WithEvents TESENTDataGridTableAdapter As dsWALENTTableAdapters.TESENTDataGridTableAdapter
    Friend WithEvents ENTRAZONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENTCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents TESENTBindingSource As BindingSource
    Friend WithEvents TESENTTableAdapter As dsWALENTTableAdapters.TESENTTableAdapter
    Friend WithEvents TableAdapterManager As dsWALENTTableAdapters.TableAdapterManager
    Friend WithEvents rbCondicionada As RadioButton
    Friend WithEvents rbBloqueada As RadioButton
    Friend WithEvents rbActiva As RadioButton
    Friend WithEvents TEN_CODIGOComboBox As ComboBox
    Friend WithEvents ENT_RAZONTextBox As TextBox
    Friend WithEvents ENT_ABREVIATURATextBox As TextBox
    Friend WithEvents ENT_RUTTextBox As TextBox
    Friend WithEvents ENT_LIMITETextBox As TextBox
    Friend WithEvents ENT_SITIOTextBox As TextBox
    Friend WithEvents TESTENTableAdapter As dsWALENTTableAdapters.TESTENTableAdapter
    Friend WithEvents TESTENBindingSource As BindingSource
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tsbEliminar As ToolStripButton
End Class
