<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWALFON00
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
        Dim ENT_CODIGOLabel As System.Windows.Forms.Label
        Dim FON_FONDOLabel As System.Windows.Forms.Label
        Dim FON_RUNLabel As System.Windows.Forms.Label
        Dim TFD_CODIGOLabel As System.Windows.Forms.Label
        Dim FON_LIMITELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALFON00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvFondos = New System.Windows.Forms.DataGridView()
        Me.FONFONDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FONCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESFONDatagridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALFON = New Wallet.dsWALFON()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.FON_RUNTextBox = New System.Windows.Forms.TextBox()
        Me.TESFONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FON_FONDOTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TESTFDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TESENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FON_LIMITETextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.TESFONTableAdapter = New Wallet.dsWALFONTableAdapters.TESFONTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALFONTableAdapters.TableAdapterManager()
        Me.TESENTTableAdapter = New Wallet.dsWALFONTableAdapters.TESENTTableAdapter()
        Me.TESTFDTableAdapter = New Wallet.dsWALFONTableAdapters.TESTFDTableAdapter()
        Me.TESFONDatagridTableAdapter = New Wallet.dsWALFONTableAdapters.TESFONDatagridTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        ENT_CODIGOLabel = New System.Windows.Forms.Label()
        FON_FONDOLabel = New System.Windows.Forms.Label()
        FON_RUNLabel = New System.Windows.Forms.Label()
        TFD_CODIGOLabel = New System.Windows.Forms.Label()
        FON_LIMITELabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvFondos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESFONDatagridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALFON, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTFDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ENT_CODIGOLabel
        '
        ENT_CODIGOLabel.AutoSize = True
        ENT_CODIGOLabel.Location = New System.Drawing.Point(27, 37)
        ENT_CODIGOLabel.Name = "ENT_CODIGOLabel"
        ENT_CODIGOLabel.Size = New System.Drawing.Size(46, 13)
        ENT_CODIGOLabel.TabIndex = 2
        ENT_CODIGOLabel.Text = "Entidad:"
        '
        'FON_FONDOLabel
        '
        FON_FONDOLabel.AutoSize = True
        FON_FONDOLabel.Location = New System.Drawing.Point(27, 113)
        FON_FONDOLabel.Name = "FON_FONDOLabel"
        FON_FONDOLabel.Size = New System.Drawing.Size(95, 13)
        FON_FONDOLabel.TabIndex = 4
        FON_FONDOLabel.Text = "Nombre de Fondo:"
        '
        'FON_RUNLabel
        '
        FON_RUNLabel.AutoSize = True
        FON_RUNLabel.Location = New System.Drawing.Point(27, 189)
        FON_RUNLabel.Name = "FON_RUNLabel"
        FON_RUNLabel.Size = New System.Drawing.Size(63, 13)
        FON_RUNLabel.TabIndex = 6
        FON_RUNLabel.Text = "Run Fondo:"
        '
        'TFD_CODIGOLabel
        '
        TFD_CODIGOLabel.AutoSize = True
        TFD_CODIGOLabel.Location = New System.Drawing.Point(27, 265)
        TFD_CODIGOLabel.Name = "TFD_CODIGOLabel"
        TFD_CODIGOLabel.Size = New System.Drawing.Size(82, 13)
        TFD_CODIGOLabel.TabIndex = 8
        TFD_CODIGOLabel.Text = "Tipo de Fondo: "
        '
        'FON_LIMITELabel
        '
        FON_LIMITELabel.AutoSize = True
        FON_LIMITELabel.Location = New System.Drawing.Point(27, 341)
        FON_LIMITELabel.Name = "FON_LIMITELabel"
        FON_LIMITELabel.Size = New System.Drawing.Size(39, 13)
        FON_LIMITELabel.TabIndex = 12
        FON_LIMITELabel.Text = "Límite:"
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
        Me.gbGeneral.Controls.Add(Me.dgvFondos)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 475)
        Me.gbGeneral.TabIndex = 3
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Entidades"
        '
        'dgvFondos
        '
        Me.dgvFondos.AllowUserToAddRows = False
        Me.dgvFondos.AllowUserToDeleteRows = False
        Me.dgvFondos.AllowUserToOrderColumns = True
        Me.dgvFondos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFondos.AutoGenerateColumns = False
        Me.dgvFondos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFondos.BackgroundColor = System.Drawing.Color.White
        Me.dgvFondos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FONFONDODataGridViewTextBoxColumn, Me.FONCODIGODataGridViewTextBoxColumn})
        Me.dgvFondos.DataSource = Me.TESFONDatagridBindingSource
        Me.dgvFondos.Location = New System.Drawing.Point(0, 19)
        Me.dgvFondos.MultiSelect = False
        Me.dgvFondos.Name = "dgvFondos"
        Me.dgvFondos.ReadOnly = True
        Me.dgvFondos.RowHeadersWidth = 20
        Me.dgvFondos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFondos.Size = New System.Drawing.Size(263, 447)
        Me.dgvFondos.TabIndex = 3
        '
        'FONFONDODataGridViewTextBoxColumn
        '
        Me.FONFONDODataGridViewTextBoxColumn.DataPropertyName = "FON_FONDO"
        Me.FONFONDODataGridViewTextBoxColumn.HeaderText = "Fondo"
        Me.FONFONDODataGridViewTextBoxColumn.Name = "FONFONDODataGridViewTextBoxColumn"
        Me.FONFONDODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FONCODIGODataGridViewTextBoxColumn
        '
        Me.FONCODIGODataGridViewTextBoxColumn.DataPropertyName = "FON_CODIGO"
        Me.FONCODIGODataGridViewTextBoxColumn.HeaderText = "FON_CODIGO"
        Me.FONCODIGODataGridViewTextBoxColumn.Name = "FONCODIGODataGridViewTextBoxColumn"
        Me.FONCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.FONCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESFONDatagridBindingSource
        '
        Me.TESFONDatagridBindingSource.DataMember = "TESFONDatagrid"
        Me.TESFONDatagridBindingSource.DataSource = Me.DsWALFON
        '
        'DsWALFON
        '
        Me.DsWALFON.DataSetName = "dsWALFON"
        Me.DsWALFON.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(284, 25)
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
        Me.tsbAgregar.ToolTipText = "Agrega Fondo"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Fondo"
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
        Me.gbDetalle.Controls.Add(Me.FON_RUNTextBox)
        Me.gbDetalle.Controls.Add(Me.FON_FONDOTextBox)
        Me.gbDetalle.Controls.Add(Me.ComboBox2)
        Me.gbDetalle.Controls.Add(Me.ComboBox1)
        Me.gbDetalle.Controls.Add(ENT_CODIGOLabel)
        Me.gbDetalle.Controls.Add(FON_FONDOLabel)
        Me.gbDetalle.Controls.Add(FON_RUNLabel)
        Me.gbDetalle.Controls.Add(TFD_CODIGOLabel)
        Me.gbDetalle.Controls.Add(FON_LIMITELabel)
        Me.gbDetalle.Controls.Add(Me.FON_LIMITETextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(10, 25)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(396, 478)
        Me.gbDetalle.TabIndex = 3
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'FON_RUNTextBox
        '
        Me.FON_RUNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESFONBindingSource, "FON_RUN", True))
        Me.FON_RUNTextBox.Location = New System.Drawing.Point(153, 186)
        Me.FON_RUNTextBox.Name = "FON_RUNTextBox"
        Me.FON_RUNTextBox.Size = New System.Drawing.Size(203, 20)
        Me.FON_RUNTextBox.TabIndex = 17
        '
        'TESFONBindingSource
        '
        Me.TESFONBindingSource.DataMember = "TESFON"
        Me.TESFONBindingSource.DataSource = Me.DsWALFON
        '
        'FON_FONDOTextBox
        '
        Me.FON_FONDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESFONBindingSource, "FON_FONDO", True))
        Me.FON_FONDOTextBox.Location = New System.Drawing.Point(153, 110)
        Me.FON_FONDOTextBox.Name = "FON_FONDOTextBox"
        Me.FON_FONDOTextBox.Size = New System.Drawing.Size(203, 20)
        Me.FON_FONDOTextBox.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESFONBindingSource, "TFD_CODIGO", True))
        Me.ComboBox2.DataSource = Me.TESTFDBindingSource
        Me.ComboBox2.DisplayMember = "TFD_TIPO"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(153, 262)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox2.TabIndex = 15
        Me.ComboBox2.ValueMember = "TFD_CODIGO"
        '
        'TESTFDBindingSource
        '
        Me.TESTFDBindingSource.DataMember = "TESTFD"
        Me.TESTFDBindingSource.DataSource = Me.DsWALFON
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TESFONBindingSource, "ENT_CODIGO", True))
        Me.ComboBox1.DataSource = Me.TESENTBindingSource
        Me.ComboBox1.DisplayMember = "ENT_RAZON"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(153, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "ENT_CODIGO"
        '
        'TESENTBindingSource
        '
        Me.TESENTBindingSource.DataMember = "TESENT"
        Me.TESENTBindingSource.DataSource = Me.DsWALFON
        '
        'FON_LIMITETextBox
        '
        Me.FON_LIMITETextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FON_LIMITETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESFONBindingSource, "FON_LIMITE", True))
        Me.FON_LIMITETextBox.Location = New System.Drawing.Point(153, 338)
        Me.FON_LIMITETextBox.Name = "FON_LIMITETextBox"
        Me.FON_LIMITETextBox.Size = New System.Drawing.Size(203, 20)
        Me.FON_LIMITETextBox.TabIndex = 13
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(409, 25)
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
        'TESFONTableAdapter
        '
        Me.TESFONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESENTTableAdapter = Me.TESENTTableAdapter
        Me.TableAdapterManager.TESFONDatagridTableAdapter = Nothing
        Me.TableAdapterManager.TESFONTableAdapter = Me.TESFONTableAdapter
        Me.TableAdapterManager.TESTFDTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALFONTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TESENTTableAdapter
        '
        Me.TESENTTableAdapter.ClearBeforeFill = True
        '
        'TESTFDTableAdapter
        '
        Me.TESTFDTableAdapter.ClearBeforeFill = True
        '
        'TESFONDatagridTableAdapter
        '
        Me.TESFONDatagridTableAdapter.ClearBeforeFill = True
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
        'frmWALFON00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALFON00"
        Me.Text = "Fondos de Fondos de Inversiones"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvFondos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESFONDatagridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALFON, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTFDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvFondos As DataGridView
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents DsWALFON As dsWALFON
    Friend WithEvents TESFONBindingSource As BindingSource
    Friend WithEvents TESFONTableAdapter As dsWALFONTableAdapters.TESFONTableAdapter
    Friend WithEvents TableAdapterManager As dsWALFONTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FON_LIMITETextBox As TextBox
    Friend WithEvents TESENTTableAdapter As dsWALFONTableAdapters.TESENTTableAdapter
    Friend WithEvents TESENTBindingSource As BindingSource
    Friend WithEvents TESTFDBindingSource As BindingSource
    Friend WithEvents TESTFDTableAdapter As dsWALFONTableAdapters.TESTFDTableAdapter
    Friend WithEvents TESFONDatagridBindingSource As BindingSource
    Friend WithEvents TESFONDatagridTableAdapter As dsWALFONTableAdapters.TESFONDatagridTableAdapter
    Friend WithEvents FONFONDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FONCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents FON_RUNTextBox As TextBox
    Friend WithEvents FON_FONDOTextBox As TextBox
    Friend WithEvents tsbEliminar As ToolStripButton
End Class
