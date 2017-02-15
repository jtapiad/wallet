<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSEGUSU03
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
        Dim SEGUSU_EMAIL2Label As System.Windows.Forms.Label
        Dim SEGUSU_TELEFONOLabel As System.Windows.Forms.Label
        Dim SEGPER_CODIGOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSEGUSU03))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.SEGUSUUSERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGUSUCOMPLETODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGUSUDataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSEGUSU = New Wallet.dsSEGUSU()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.tbBuscaUsu = New System.Windows.Forms.TextBox()
        Me.chkBloqueados = New System.Windows.Forms.CheckBox()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.SEGUSU_RUTTextBox = New System.Windows.Forms.TextBox()
        Me.SEGUSUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEGPER_CODIGOComboBox = New System.Windows.Forms.ComboBox()
        Me.SEGPERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSEGPERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSEGPER = New Wallet.dsSEGPER()
        Me.SEGUSU_COMPLETOLabel1 = New System.Windows.Forms.Label()
        Me.SEGUSU_TELEFONOTextBox = New System.Windows.Forms.TextBox()
        Me.SEGUSU_EMAIL2TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SEGUSU_EMAIL1TextBox = New System.Windows.Forms.TextBox()
        Me.SEGUSU_SALUDOSCheckBox = New System.Windows.Forms.CheckBox()
        Me.SEGUSU_FINIQUITOCheckBox = New System.Windows.Forms.CheckBox()
        Me.SEGUSU_FECHAFINDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SEGUSU_FECHABLODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SEGUSU_MATERNOTextBox = New System.Windows.Forms.TextBox()
        Me.SEGUSU_PATERNOTextBox = New System.Windows.Forms.TextBox()
        Me.SEGUSU_NOMBRESTextBox = New System.Windows.Forms.TextBox()
        Me.SEGUSU_USERNAMETextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SEGUSU_BLOQUEADOCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.tsbContraseña = New System.Windows.Forms.ToolStripButton()
        Me.SEGUSUTableAdapter = New Wallet.dsSEGUSUTableAdapters.SEGUSUTableAdapter()
        Me.TableAdapterManager = New Wallet.dsSEGUSUTableAdapters.TableAdapterManager()
        Me.SEGPERTableAdapter = New Wallet.dsSEGPERTableAdapters.SEGPERTableAdapter()
        Me.SEGUSUDataGridTableAdapter = New Wallet.dsSEGUSUTableAdapters.SEGUSUDataGridTableAdapter()
        Me.ToolTipUsuarios = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        SEGUSU_EMAIL2Label = New System.Windows.Forms.Label()
        SEGUSU_TELEFONOLabel = New System.Windows.Forms.Label()
        SEGPER_CODIGOLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGUSUDataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSEGUSU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.SEGUSUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSEGPERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEGUSU_EMAIL2Label
        '
        SEGUSU_EMAIL2Label.AutoSize = True
        SEGUSU_EMAIL2Label.Location = New System.Drawing.Point(13, 240)
        SEGUSU_EMAIL2Label.Name = "SEGUSU_EMAIL2Label"
        SEGUSU_EMAIL2Label.Size = New System.Drawing.Size(50, 13)
        SEGUSU_EMAIL2Label.TabIndex = 25
        SEGUSU_EMAIL2Label.Text = "E mail 2 :"
        '
        'SEGUSU_TELEFONOLabel
        '
        SEGUSU_TELEFONOLabel.AutoSize = True
        SEGUSU_TELEFONOLabel.Location = New System.Drawing.Point(13, 270)
        SEGUSU_TELEFONOLabel.Name = "SEGUSU_TELEFONOLabel"
        SEGUSU_TELEFONOLabel.Size = New System.Drawing.Size(55, 13)
        SEGUSU_TELEFONOLabel.TabIndex = 26
        SEGUSU_TELEFONOLabel.Text = "Teléfono :"
        '
        'SEGPER_CODIGOLabel
        '
        SEGPER_CODIGOLabel.AutoSize = True
        SEGPER_CODIGOLabel.Location = New System.Drawing.Point(13, 300)
        SEGPER_CODIGOLabel.Name = "SEGPER_CODIGOLabel"
        SEGPER_CODIGOLabel.Size = New System.Drawing.Size(36, 13)
        SEGPER_CODIGOLabel.TabIndex = 27
        SEGPER_CODIGOLabel.Text = "Perfil :"
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
        Me.gbGeneral.Controls.Add(Me.dgvUsuarios)
        Me.gbGeneral.Controls.Add(Me.btnBusca)
        Me.gbGeneral.Controls.Add(Me.tbBuscaUsu)
        Me.gbGeneral.Controls.Add(Me.chkBloqueados)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 475)
        Me.gbGeneral.TabIndex = 1
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Usuarios"
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
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SEGUSUUSERNAMEDataGridViewTextBoxColumn, Me.SEGUSUCOMPLETODataGridViewTextBoxColumn, Me.Column1})
        Me.dgvUsuarios.DataSource = Me.SEGUSUDataGridBindingSource
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 70)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidth = 20
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(263, 396)
        Me.dgvUsuarios.TabIndex = 3
        '
        'SEGUSUUSERNAMEDataGridViewTextBoxColumn
        '
        Me.SEGUSUUSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "SEGUSU_USERNAME"
        Me.SEGUSUUSERNAMEDataGridViewTextBoxColumn.HeaderText = "Nombre de Usuario"
        Me.SEGUSUUSERNAMEDataGridViewTextBoxColumn.Name = "SEGUSUUSERNAMEDataGridViewTextBoxColumn"
        Me.SEGUSUUSERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SEGUSUCOMPLETODataGridViewTextBoxColumn
        '
        Me.SEGUSUCOMPLETODataGridViewTextBoxColumn.DataPropertyName = "SEGUSU_COMPLETO"
        Me.SEGUSUCOMPLETODataGridViewTextBoxColumn.HeaderText = "Nombre Completo"
        Me.SEGUSUCOMPLETODataGridViewTextBoxColumn.Name = "SEGUSUCOMPLETODataGridViewTextBoxColumn"
        Me.SEGUSUCOMPLETODataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "SEGUSU_CODIGO"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'SEGUSUDataGridBindingSource
        '
        Me.SEGUSUDataGridBindingSource.DataMember = "SEGUSUDataGrid"
        Me.SEGUSUDataGridBindingSource.DataSource = Me.DsSEGUSU
        '
        'DsSEGUSU
        '
        Me.DsSEGUSU.DataSetName = "dsSEGUSU"
        Me.DsSEGUSU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBusca
        '
        Me.btnBusca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBusca.BackgroundImage = Global.Wallet.My.Resources.Resources.Search1
        Me.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBusca.Location = New System.Drawing.Point(239, 41)
        Me.btnBusca.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(24, 24)
        Me.btnBusca.TabIndex = 2
        Me.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBusca.UseVisualStyleBackColor = True
        '
        'tbBuscaUsu
        '
        Me.tbBuscaUsu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBuscaUsu.Location = New System.Drawing.Point(0, 44)
        Me.tbBuscaUsu.Name = "tbBuscaUsu"
        Me.tbBuscaUsu.Size = New System.Drawing.Size(229, 20)
        Me.tbBuscaUsu.TabIndex = 1
        '
        'chkBloqueados
        '
        Me.chkBloqueados.AutoSize = True
        Me.chkBloqueados.Location = New System.Drawing.Point(7, 20)
        Me.chkBloqueados.Name = "chkBloqueados"
        Me.chkBloqueados.Size = New System.Drawing.Size(224, 17)
        Me.chkBloqueados.TabIndex = 0
        Me.chkBloqueados.Text = "Incluir Usuarios Bloqueados y Finiquitados"
        Me.ToolTipUsuarios.SetToolTip(Me.chkBloqueados, "Si está desmarcado, sólo mostrará los usuarios vigentes.")
        Me.chkBloqueados.UseVisualStyleBackColor = True
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(284, 25)
        Me.ToolStripGeneral.TabIndex = 0
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
        Me.gbDetalle.Controls.Add(Me.SEGUSU_RUTTextBox)
        Me.gbDetalle.Controls.Add(Me.SEGPER_CODIGOComboBox)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_COMPLETOLabel1)
        Me.gbDetalle.Controls.Add(SEGPER_CODIGOLabel)
        Me.gbDetalle.Controls.Add(SEGUSU_TELEFONOLabel)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_TELEFONOTextBox)
        Me.gbDetalle.Controls.Add(SEGUSU_EMAIL2Label)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_EMAIL2TextBox)
        Me.gbDetalle.Controls.Add(Me.Label9)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_EMAIL1TextBox)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_SALUDOSCheckBox)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_FINIQUITOCheckBox)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_FECHAFINDateTimePicker)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_FECHABLODateTimePicker)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_MATERNOTextBox)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_PATERNOTextBox)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_NOMBRESTextBox)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_USERNAMETextBox)
        Me.gbDetalle.Controls.Add(Me.Label8)
        Me.gbDetalle.Controls.Add(Me.Label7)
        Me.gbDetalle.Controls.Add(Me.Label6)
        Me.gbDetalle.Controls.Add(Me.Label5)
        Me.gbDetalle.Controls.Add(Me.Label4)
        Me.gbDetalle.Controls.Add(Me.Label3)
        Me.gbDetalle.Controls.Add(Me.Label2)
        Me.gbDetalle.Controls.Add(Me.Label1)
        Me.gbDetalle.Controls.Add(Me.SEGUSU_BLOQUEADOCheckBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(4, 28)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(393, 475)
        Me.gbDetalle.TabIndex = 0
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'SEGUSU_RUTTextBox
        '
        Me.SEGUSU_RUTTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_RUTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_RUT", True))
        Me.SEGUSU_RUTTextBox.Location = New System.Drawing.Point(123, 177)
        Me.SEGUSU_RUTTextBox.Name = "SEGUSU_RUTTextBox"
        Me.SEGUSU_RUTTextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_RUTTextBox.TabIndex = 4
        '
        'SEGUSUBindingSource
        '
        Me.SEGUSUBindingSource.DataMember = "SEGUSU"
        Me.SEGUSUBindingSource.DataSource = Me.DsSEGUSU
        '
        'SEGPER_CODIGOComboBox
        '
        Me.SEGPER_CODIGOComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGPER_CODIGOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SEGUSUBindingSource, "SEGPER_CODIGO", True))
        Me.SEGPER_CODIGOComboBox.DataSource = Me.SEGPERBindingSource
        Me.SEGPER_CODIGOComboBox.DisplayMember = "SEGPER_PERFIL"
        Me.SEGPER_CODIGOComboBox.FormattingEnabled = True
        Me.SEGPER_CODIGOComboBox.Location = New System.Drawing.Point(123, 297)
        Me.SEGPER_CODIGOComboBox.Name = "SEGPER_CODIGOComboBox"
        Me.SEGPER_CODIGOComboBox.Size = New System.Drawing.Size(234, 21)
        Me.SEGPER_CODIGOComboBox.TabIndex = 8
        Me.SEGPER_CODIGOComboBox.ValueMember = "SEGPER_CODIGO"
        '
        'SEGPERBindingSource
        '
        Me.SEGPERBindingSource.DataMember = "SEGPER"
        Me.SEGPERBindingSource.DataSource = Me.DsSEGPERBindingSource
        '
        'DsSEGPERBindingSource
        '
        Me.DsSEGPERBindingSource.DataSource = Me.DsSEGPER
        Me.DsSEGPERBindingSource.Position = 0
        '
        'DsSEGPER
        '
        Me.DsSEGPER.DataSetName = "dsSEGPER"
        Me.DsSEGPER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SEGUSU_COMPLETOLabel1
        '
        Me.SEGUSU_COMPLETOLabel1.AutoSize = True
        Me.SEGUSU_COMPLETOLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_COMPLETO", True))
        Me.SEGUSU_COMPLETOLabel1.Location = New System.Drawing.Point(120, 150)
        Me.SEGUSU_COMPLETOLabel1.Name = "SEGUSU_COMPLETOLabel1"
        Me.SEGUSU_COMPLETOLabel1.Size = New System.Drawing.Size(51, 13)
        Me.SEGUSU_COMPLETOLabel1.TabIndex = 29
        Me.SEGUSU_COMPLETOLabel1.Text = "Completo"
        '
        'SEGUSU_TELEFONOTextBox
        '
        Me.SEGUSU_TELEFONOTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_TELEFONO", True))
        Me.SEGUSU_TELEFONOTextBox.Location = New System.Drawing.Point(123, 267)
        Me.SEGUSU_TELEFONOTextBox.Name = "SEGUSU_TELEFONOTextBox"
        Me.SEGUSU_TELEFONOTextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_TELEFONOTextBox.TabIndex = 7
        '
        'SEGUSU_EMAIL2TextBox
        '
        Me.SEGUSU_EMAIL2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_EMAIL2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_EMAIL2", True))
        Me.SEGUSU_EMAIL2TextBox.Location = New System.Drawing.Point(123, 237)
        Me.SEGUSU_EMAIL2TextBox.Name = "SEGUSU_EMAIL2TextBox"
        Me.SEGUSU_EMAIL2TextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_EMAIL2TextBox.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "E-mail 1 :"
        '
        'SEGUSU_EMAIL1TextBox
        '
        Me.SEGUSU_EMAIL1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_EMAIL1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_EMAIL1", True))
        Me.SEGUSU_EMAIL1TextBox.Location = New System.Drawing.Point(123, 207)
        Me.SEGUSU_EMAIL1TextBox.Name = "SEGUSU_EMAIL1TextBox"
        Me.SEGUSU_EMAIL1TextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_EMAIL1TextBox.TabIndex = 5
        '
        'SEGUSU_SALUDOSCheckBox
        '
        Me.SEGUSU_SALUDOSCheckBox.AutoSize = True
        Me.SEGUSU_SALUDOSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SEGUSUBindingSource, "SEGUSU_SALUDOS", True))
        Me.SEGUSU_SALUDOSCheckBox.Location = New System.Drawing.Point(16, 428)
        Me.SEGUSU_SALUDOSCheckBox.Name = "SEGUSU_SALUDOSCheckBox"
        Me.SEGUSU_SALUDOSCheckBox.Size = New System.Drawing.Size(114, 17)
        Me.SEGUSU_SALUDOSCheckBox.TabIndex = 13
        Me.SEGUSU_SALUDOSCheckBox.Text = "¿Saludos al inicio?"
        Me.SEGUSU_SALUDOSCheckBox.UseVisualStyleBackColor = True
        '
        'SEGUSU_FINIQUITOCheckBox
        '
        Me.SEGUSU_FINIQUITOCheckBox.AutoSize = True
        Me.SEGUSU_FINIQUITOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SEGUSUBindingSource, "SEGUSU_FINIQUITO", True))
        Me.SEGUSU_FINIQUITOCheckBox.Location = New System.Drawing.Point(16, 394)
        Me.SEGUSU_FINIQUITOCheckBox.Name = "SEGUSU_FINIQUITOCheckBox"
        Me.SEGUSU_FINIQUITOCheckBox.Size = New System.Drawing.Size(89, 17)
        Me.SEGUSU_FINIQUITOCheckBox.TabIndex = 12
        Me.SEGUSU_FINIQUITOCheckBox.Text = "¿Finiquitado?"
        Me.SEGUSU_FINIQUITOCheckBox.UseVisualStyleBackColor = True
        '
        'SEGUSU_FECHAFINDateTimePicker
        '
        Me.SEGUSU_FECHAFINDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_FECHAFINDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SEGUSUBindingSource, "SEGUSU_FECHAFIN", True))
        Me.SEGUSU_FECHAFINDateTimePicker.Enabled = False
        Me.SEGUSU_FECHAFINDateTimePicker.Location = New System.Drawing.Point(159, 362)
        Me.SEGUSU_FECHAFINDateTimePicker.Name = "SEGUSU_FECHAFINDateTimePicker"
        Me.SEGUSU_FECHAFINDateTimePicker.Size = New System.Drawing.Size(214, 20)
        Me.SEGUSU_FECHAFINDateTimePicker.TabIndex = 11
        '
        'SEGUSU_FECHABLODateTimePicker
        '
        Me.SEGUSU_FECHABLODateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_FECHABLODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SEGUSUBindingSource, "SEGUSU_FECHABLO", True))
        Me.SEGUSU_FECHABLODateTimePicker.Enabled = False
        Me.SEGUSU_FECHABLODateTimePicker.Location = New System.Drawing.Point(159, 327)
        Me.SEGUSU_FECHABLODateTimePicker.Name = "SEGUSU_FECHABLODateTimePicker"
        Me.SEGUSU_FECHABLODateTimePicker.Size = New System.Drawing.Size(214, 20)
        Me.SEGUSU_FECHABLODateTimePicker.TabIndex = 10
        '
        'SEGUSU_MATERNOTextBox
        '
        Me.SEGUSU_MATERNOTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_MATERNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_MATERNO", True))
        Me.SEGUSU_MATERNOTextBox.Location = New System.Drawing.Point(123, 117)
        Me.SEGUSU_MATERNOTextBox.Name = "SEGUSU_MATERNOTextBox"
        Me.SEGUSU_MATERNOTextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_MATERNOTextBox.TabIndex = 3
        '
        'SEGUSU_PATERNOTextBox
        '
        Me.SEGUSU_PATERNOTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_PATERNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_PATERNO", True))
        Me.SEGUSU_PATERNOTextBox.Location = New System.Drawing.Point(123, 87)
        Me.SEGUSU_PATERNOTextBox.Name = "SEGUSU_PATERNOTextBox"
        Me.SEGUSU_PATERNOTextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_PATERNOTextBox.TabIndex = 2
        '
        'SEGUSU_NOMBRESTextBox
        '
        Me.SEGUSU_NOMBRESTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_NOMBRESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_NOMBRES", True))
        Me.SEGUSU_NOMBRESTextBox.Location = New System.Drawing.Point(123, 57)
        Me.SEGUSU_NOMBRESTextBox.Name = "SEGUSU_NOMBRESTextBox"
        Me.SEGUSU_NOMBRESTextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_NOMBRESTextBox.TabIndex = 1
        '
        'SEGUSU_USERNAMETextBox
        '
        Me.SEGUSU_USERNAMETextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGUSU_USERNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGUSUBindingSource, "SEGUSU_USERNAME", True))
        Me.SEGUSU_USERNAMETextBox.Location = New System.Drawing.Point(123, 27)
        Me.SEGUSU_USERNAMETextBox.Name = "SEGUSU_USERNAMETextBox"
        Me.SEGUSU_USERNAMETextBox.Size = New System.Drawing.Size(234, 20)
        Me.SEGUSU_USERNAMETextBox.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "hasta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "desde "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "RUT :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre Completo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Paterno :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Materno :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Usuario :"
        '
        'SEGUSU_BLOQUEADOCheckBox
        '
        Me.SEGUSU_BLOQUEADOCheckBox.AutoSize = True
        Me.SEGUSU_BLOQUEADOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SEGUSUBindingSource, "SEGUSU_BLOQUEADO", True))
        Me.SEGUSU_BLOQUEADOCheckBox.Location = New System.Drawing.Point(16, 330)
        Me.SEGUSU_BLOQUEADOCheckBox.Name = "SEGUSU_BLOQUEADOCheckBox"
        Me.SEGUSU_BLOQUEADOCheckBox.Size = New System.Drawing.Size(89, 17)
        Me.SEGUSU_BLOQUEADOCheckBox.TabIndex = 9
        Me.SEGUSU_BLOQUEADOCheckBox.Text = "¿Bloqueado?"
        Me.SEGUSU_BLOQUEADOCheckBox.UseVisualStyleBackColor = True
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela, Me.tsbContraseña})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(409, 25)
        Me.ToolStripDetalle.TabIndex = 0
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
        'SEGUSUTableAdapter
        '
        Me.SEGUSUTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SEGPERTableAdapter = Nothing
        Me.TableAdapterManager.SEGUSUDataGridTableAdapter = Nothing
        Me.TableAdapterManager.SEGUSUExcelTableAdapter = Nothing
        Me.TableAdapterManager.SEGUSUTableAdapter = Me.SEGUSUTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsSEGUSUTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SEGPERTableAdapter
        '
        Me.SEGPERTableAdapter.ClearBeforeFill = True
        '
        'SEGUSUDataGridTableAdapter
        '
        Me.SEGUSUDataGridTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSEGUSU03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSEGUSU03"
        Me.ShowInTaskbar = False
        Me.Text = "Mantención de Usuarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGUSUDataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSEGUSU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.SEGUSUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSEGPERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents btnBusca As Button
    Friend WithEvents tbBuscaUsu As TextBox
    Friend WithEvents chkBloqueados As CheckBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbContraseña As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DsSEGUSU As dsSEGUSU
    Friend WithEvents SEGUSUBindingSource As BindingSource
    Friend WithEvents SEGUSUTableAdapter As dsSEGUSUTableAdapters.SEGUSUTableAdapter
    Friend WithEvents TableAdapterManager As dsSEGUSUTableAdapters.TableAdapterManager
    Friend WithEvents SEGUSU_TELEFONOTextBox As TextBox
    Friend WithEvents SEGUSU_EMAIL2TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SEGUSU_EMAIL1TextBox As TextBox
    Friend WithEvents SEGUSU_SALUDOSCheckBox As CheckBox
    Friend WithEvents SEGUSU_FINIQUITOCheckBox As CheckBox
    Friend WithEvents SEGUSU_FECHAFINDateTimePicker As DateTimePicker
    Friend WithEvents SEGUSU_FECHABLODateTimePicker As DateTimePicker
    Friend WithEvents SEGUSU_MATERNOTextBox As TextBox
    Friend WithEvents SEGUSU_PATERNOTextBox As TextBox
    Friend WithEvents SEGUSU_NOMBRESTextBox As TextBox
    Friend WithEvents SEGUSU_USERNAMETextBox As TextBox
    Friend WithEvents SEGUSU_BLOQUEADOCheckBox As CheckBox
    Friend WithEvents DsSEGPERBindingSource As BindingSource
    Friend WithEvents DsSEGPER As dsSEGPER
    Friend WithEvents SEGPERBindingSource As BindingSource
    Friend WithEvents SEGPERTableAdapter As dsSEGPERTableAdapters.SEGPERTableAdapter
    Friend WithEvents SEGUSUDataGridBindingSource As BindingSource
    Friend WithEvents SEGUSUDataGridTableAdapter As dsSEGUSUTableAdapters.SEGUSUDataGridTableAdapter
    Friend WithEvents ToolTipUsuarios As ToolTip
    Friend WithEvents SEGUSU_COMPLETOLabel1 As Label
    Friend WithEvents SEGPER_CODIGOComboBox As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SEGUSU_RUTTextBox As TextBox
    Friend WithEvents SEGUSUUSERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEGUSUCOMPLETODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
