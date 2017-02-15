<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALGMO00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALGMO00))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbFondo = New System.Windows.Forms.GroupBox()
        Me.cbFondo = New System.Windows.Forms.ComboBox()
        Me.TESFONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALPLA = New Wallet.dsWALPLA()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbNota = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.tbGlosaEditada = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbGlosas = New System.Windows.Forms.ComboBox()
        Me.TESGLOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btBuscaBeneficiario = New System.Windows.Forms.Button()
        Me.cbBeneficiarios = New System.Windows.Forms.ComboBox()
        Me.TESBENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALBEN = New Wallet.dsWALBEN()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbUnidadPagadora = New System.Windows.Forms.ComboBox()
        Me.TESUPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbInversion = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbNominal = New System.Windows.Forms.RadioButton()
        Me.rbReal = New System.Windows.Forms.RadioButton()
        Me.tbTasa = New System.Windows.Forms.TextBox()
        Me.cbComprometida = New System.Windows.Forms.CheckBox()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbPapel = New System.Windows.Forms.ComboBox()
        Me.TESINFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbEntidad = New System.Windows.Forms.ComboBox()
        Me.TESENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALPLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbEntidad = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.AxSAPLogonControl1 = New AxSAPLogonCtrl.AxSAPLogonControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCheques = New System.Windows.Forms.TextBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.dgvMontos = New System.Windows.Forms.DataGridView()
        Me.CTE_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTABREVIATURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESDPLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbInversion = New System.Windows.Forms.RadioButton()
        Me.rbPago = New System.Windows.Forms.RadioButton()
        Me.TESBENTableAdapter = New Wallet.dsWALBENTableAdapters.TESBENTableAdapter()
        Me.TESUPATableAdapter = New Wallet.dsWALPLATableAdapters.TESUPATableAdapter()
        Me.TESGLOTableAdapter = New Wallet.dsWALPLATableAdapters.TESGLOTableAdapter()
        Me.TESDPLTableAdapter = New Wallet.dsWALPLATableAdapters.TESDPLTableAdapter()
        Me.TESENTTableAdapter = New Wallet.dsWALPLATableAdapters.TESENTTableAdapter()
        Me.TESINFTableAdapter = New Wallet.dsWALPLATableAdapters.TESINFTableAdapter()
        Me.TESFONTableAdapter = New Wallet.dsWALPLATableAdapters.TESFONTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.gbFondo.SuspendLayout()
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TESGLOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TESUPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInversion.SuspendLayout()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.AxSAPLogonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMontos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESDPLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbFondo)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.gbInversion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 423)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'gbFondo
        '
        Me.gbFondo.Controls.Add(Me.cbFondo)
        Me.gbFondo.Location = New System.Drawing.Point(264, 73)
        Me.gbFondo.Name = "gbFondo"
        Me.gbFondo.Size = New System.Drawing.Size(113, 68)
        Me.gbFondo.TabIndex = 6
        Me.gbFondo.TabStop = False
        Me.gbFondo.Text = "Fondo"
        '
        'cbFondo
        '
        Me.cbFondo.DataSource = Me.TESFONBindingSource
        Me.cbFondo.DisplayMember = "FON_FONDO"
        Me.cbFondo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFondo.FormattingEnabled = True
        Me.cbFondo.Location = New System.Drawing.Point(9, 28)
        Me.cbFondo.Name = "cbFondo"
        Me.cbFondo.Size = New System.Drawing.Size(92, 21)
        Me.cbFondo.TabIndex = 0
        Me.cbFondo.ValueMember = "FON_CODIGO"
        '
        'TESFONBindingSource
        '
        Me.TESFONBindingSource.DataMember = "TESFON"
        Me.TESFONBindingSource.DataSource = Me.DsWALPLA
        '
        'DsWALPLA
        '
        Me.DsWALPLA.DataSetName = "dsWALPLA"
        Me.DsWALPLA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbNota)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 362)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(355, 45)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Notas Adicionales"
        '
        'tbNota
        '
        Me.tbNota.Location = New System.Drawing.Point(6, 16)
        Me.tbNota.Name = "tbNota"
        Me.tbNota.Size = New System.Drawing.Size(343, 20)
        Me.tbNota.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.tbGlosaEditada)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 292)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(358, 68)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Glosa Editada"
        '
        'tbGlosaEditada
        '
        Me.tbGlosaEditada.Location = New System.Drawing.Point(9, 16)
        Me.tbGlosaEditada.Multiline = True
        Me.tbGlosaEditada.Name = "tbGlosaEditada"
        Me.tbGlosaEditada.Size = New System.Drawing.Size(343, 46)
        Me.tbGlosaEditada.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cbGlosas)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 242)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(358, 49)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Glosa"
        '
        'cbGlosas
        '
        Me.cbGlosas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbGlosas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGlosas.DataSource = Me.TESGLOBindingSource
        Me.cbGlosas.DisplayMember = "GLO_GLOSA"
        Me.cbGlosas.FormattingEnabled = True
        Me.cbGlosas.Location = New System.Drawing.Point(9, 16)
        Me.cbGlosas.Name = "cbGlosas"
        Me.cbGlosas.Size = New System.Drawing.Size(343, 21)
        Me.cbGlosas.TabIndex = 0
        Me.cbGlosas.ValueMember = "GLO_CODIGO"
        '
        'TESGLOBindingSource
        '
        Me.TESGLOBindingSource.DataMember = "TESGLO"
        Me.TESGLOBindingSource.DataSource = Me.DsWALPLA
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btBuscaBeneficiario)
        Me.GroupBox5.Controls.Add(Me.cbBeneficiarios)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 192)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(358, 49)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Beneficiario"
        '
        'btBuscaBeneficiario
        '
        Me.btBuscaBeneficiario.Location = New System.Drawing.Point(317, 16)
        Me.btBuscaBeneficiario.Name = "btBuscaBeneficiario"
        Me.btBuscaBeneficiario.Size = New System.Drawing.Size(32, 23)
        Me.btBuscaBeneficiario.TabIndex = 1
        Me.btBuscaBeneficiario.Text = "..."
        Me.btBuscaBeneficiario.UseVisualStyleBackColor = True
        '
        'cbBeneficiarios
        '
        Me.cbBeneficiarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbBeneficiarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBeneficiarios.DataSource = Me.TESBENBindingSource
        Me.cbBeneficiarios.DisplayMember = "BEN_NOMBRE"
        Me.cbBeneficiarios.FormattingEnabled = True
        Me.cbBeneficiarios.Location = New System.Drawing.Point(9, 17)
        Me.cbBeneficiarios.Name = "cbBeneficiarios"
        Me.cbBeneficiarios.Size = New System.Drawing.Size(302, 21)
        Me.cbBeneficiarios.TabIndex = 0
        Me.cbBeneficiarios.ValueMember = "BEN_RUT"
        '
        'TESBENBindingSource
        '
        Me.TESBENBindingSource.DataMember = "TESBEN"
        Me.TESBENBindingSource.DataSource = Me.DsWALBEN
        '
        'DsWALBEN
        '
        Me.DsWALBEN.DataSetName = "dsWALBEN"
        Me.DsWALBEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbMonto)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 147)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(358, 44)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Montos"
        '
        'tbMonto
        '
        Me.tbMonto.AcceptsReturn = True
        Me.tbMonto.Location = New System.Drawing.Point(124, 15)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Size = New System.Drawing.Size(225, 20)
        Me.tbMonto.TabIndex = 1
        Me.tbMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monto del Documento :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbUnidadPagadora)
        Me.GroupBox3.Location = New System.Drawing.Point(264, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(104, 48)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Unidad Pagadora"
        '
        'cbUnidadPagadora
        '
        Me.cbUnidadPagadora.DataSource = Me.TESUPABindingSource
        Me.cbUnidadPagadora.DisplayMember = "UPA_CODIGO"
        Me.cbUnidadPagadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadPagadora.FormattingEnabled = True
        Me.cbUnidadPagadora.Location = New System.Drawing.Point(18, 19)
        Me.cbUnidadPagadora.Name = "cbUnidadPagadora"
        Me.cbUnidadPagadora.Size = New System.Drawing.Size(62, 21)
        Me.cbUnidadPagadora.TabIndex = 0
        Me.cbUnidadPagadora.ValueMember = "UPA_CODIGO"
        '
        'TESUPABindingSource
        '
        Me.TESUPABindingSource.DataMember = "TESUPA"
        Me.TESUPABindingSource.DataSource = Me.DsWALPLA
        '
        'gbInversion
        '
        Me.gbInversion.Controls.Add(Me.Label5)
        Me.gbInversion.Controls.Add(Me.Label4)
        Me.gbInversion.Controls.Add(Me.Label3)
        Me.gbInversion.Controls.Add(Me.Label1)
        Me.gbInversion.Controls.Add(Me.rbNominal)
        Me.gbInversion.Controls.Add(Me.rbReal)
        Me.gbInversion.Controls.Add(Me.tbTasa)
        Me.gbInversion.Controls.Add(Me.cbComprometida)
        Me.gbInversion.Controls.Add(Me.dtpVencimiento)
        Me.gbInversion.Controls.Add(Me.cbPapel)
        Me.gbInversion.Controls.Add(Me.cbEntidad)
        Me.gbInversion.Controls.Add(Me.lbEntidad)
        Me.gbInversion.Location = New System.Drawing.Point(6, 19)
        Me.gbInversion.Name = "gbInversion"
        Me.gbInversion.Size = New System.Drawing.Size(252, 123)
        Me.gbInversion.TabIndex = 0
        Me.gbInversion.TabStop = False
        Me.gbInversion.Text = "Inversión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tasa :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Vence :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Papel :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Entidad :"
        '
        'rbNominal
        '
        Me.rbNominal.AutoSize = True
        Me.rbNominal.Location = New System.Drawing.Point(182, 92)
        Me.rbNominal.Name = "rbNominal"
        Me.rbNominal.Size = New System.Drawing.Size(63, 17)
        Me.rbNominal.TabIndex = 7
        Me.rbNominal.Text = "Nominal"
        Me.rbNominal.UseVisualStyleBackColor = True
        '
        'rbReal
        '
        Me.rbReal.AutoSize = True
        Me.rbReal.Checked = True
        Me.rbReal.Location = New System.Drawing.Point(129, 92)
        Me.rbReal.Name = "rbReal"
        Me.rbReal.Size = New System.Drawing.Size(47, 17)
        Me.rbReal.TabIndex = 6
        Me.rbReal.TabStop = True
        Me.rbReal.Text = "Real"
        Me.rbReal.UseVisualStyleBackColor = True
        '
        'tbTasa
        '
        Me.tbTasa.Location = New System.Drawing.Point(57, 90)
        Me.tbTasa.Name = "tbTasa"
        Me.tbTasa.Size = New System.Drawing.Size(59, 20)
        Me.tbTasa.TabIndex = 5
        Me.tbTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbComprometida
        '
        Me.cbComprometida.AutoSize = True
        Me.cbComprometida.Location = New System.Drawing.Point(153, 66)
        Me.cbComprometida.Name = "cbComprometida"
        Me.cbComprometida.Size = New System.Drawing.Size(93, 17)
        Me.cbComprometida.TabIndex = 4
        Me.cbComprometida.Text = "Comprometida"
        Me.cbComprometida.UseVisualStyleBackColor = True
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(57, 64)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(78, 20)
        Me.dtpVencimiento.TabIndex = 3
        '
        'cbPapel
        '
        Me.cbPapel.DataSource = Me.TESINFBindingSource
        Me.cbPapel.DisplayMember = "INF_NOMBRE"
        Me.cbPapel.FormattingEnabled = True
        Me.cbPapel.Location = New System.Drawing.Point(57, 39)
        Me.cbPapel.Name = "cbPapel"
        Me.cbPapel.Size = New System.Drawing.Size(176, 21)
        Me.cbPapel.TabIndex = 2
        Me.cbPapel.ValueMember = "INF_CODIGO"
        '
        'TESINFBindingSource
        '
        Me.TESINFBindingSource.DataMember = "TESINF"
        Me.TESINFBindingSource.DataSource = Me.DsWALPLA
        '
        'cbEntidad
        '
        Me.cbEntidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbEntidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEntidad.DataSource = Me.TESENTBindingSource
        Me.cbEntidad.DisplayMember = "ENT_RAZON"
        Me.cbEntidad.DropDownWidth = 176
        Me.cbEntidad.FormattingEnabled = True
        Me.cbEntidad.Location = New System.Drawing.Point(57, 14)
        Me.cbEntidad.Name = "cbEntidad"
        Me.cbEntidad.Size = New System.Drawing.Size(176, 21)
        Me.cbEntidad.TabIndex = 1
        Me.cbEntidad.ValueMember = "ENT_CODIGO"
        '
        'TESENTBindingSource
        '
        Me.TESENTBindingSource.DataMember = "TESENT"
        Me.TESENTBindingSource.DataSource = Me.DsWALPLABindingSource
        '
        'DsWALPLABindingSource
        '
        Me.DsWALPLABindingSource.DataSource = Me.DsWALPLA
        Me.DsWALPLABindingSource.Position = 0
        '
        'lbEntidad
        '
        Me.lbEntidad.AutoSize = True
        Me.lbEntidad.Location = New System.Drawing.Point(6, 22)
        Me.lbEntidad.Name = "lbEntidad"
        Me.lbEntidad.Size = New System.Drawing.Size(0, 13)
        Me.lbEntidad.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(853, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = Global.Wallet.My.Resources.Resources.Accept
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Text = "Grabar el Cheque"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir sin Grabar"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.AxSAPLogonControl1)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.tbCheques)
        Me.GroupBox9.Controls.Add(Me.tbTotal)
        Me.GroupBox9.Controls.Add(Me.dgvMontos)
        Me.GroupBox9.Location = New System.Drawing.Point(404, 60)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(437, 423)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Detalle de los Cheques"
        '
        'AxSAPLogonControl1
        '
        Me.AxSAPLogonControl1.Location = New System.Drawing.Point(256, 310)
        Me.AxSAPLogonControl1.Name = "AxSAPLogonControl1"
        Me.AxSAPLogonControl1.OcxState = CType(resources.GetObject("AxSAPLogonControl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSAPLogonControl1.Size = New System.Drawing.Size(100, 50)
        Me.AxSAPLogonControl1.TabIndex = 4
        Me.AxSAPLogonControl1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Totales"
        '
        'tbCheques
        '
        Me.tbCheques.Location = New System.Drawing.Point(256, 391)
        Me.tbCheques.Name = "tbCheques"
        Me.tbCheques.Size = New System.Drawing.Size(153, 20)
        Me.tbCheques.TabIndex = 2
        Me.tbCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(148, 391)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbTotal.TabIndex = 1
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvMontos
        '
        Me.dgvMontos.AllowUserToAddRows = False
        Me.dgvMontos.AllowUserToDeleteRows = False
        Me.dgvMontos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMontos.AutoGenerateColumns = False
        Me.dgvMontos.BackgroundColor = System.Drawing.Color.White
        Me.dgvMontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMontos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTE_CODIGO, Me.ENTABREVIATURADataGridViewTextBoxColumn, Me.DPLPORCOLOCARDataGridViewTextBoxColumn, Me.MontoCheque})
        Me.dgvMontos.DataSource = Me.TESDPLBindingSource
        Me.dgvMontos.Location = New System.Drawing.Point(6, 16)
        Me.dgvMontos.Name = "dgvMontos"
        Me.dgvMontos.RowHeadersWidth = 40
        Me.dgvMontos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMontos.Size = New System.Drawing.Size(425, 364)
        Me.dgvMontos.TabIndex = 0
        '
        'CTE_CODIGO
        '
        Me.CTE_CODIGO.DataPropertyName = "CTE_CODIGO"
        Me.CTE_CODIGO.HeaderText = "CTE_CODIGO"
        Me.CTE_CODIGO.Name = "CTE_CODIGO"
        Me.CTE_CODIGO.Visible = False
        '
        'ENTABREVIATURADataGridViewTextBoxColumn
        '
        Me.ENTABREVIATURADataGridViewTextBoxColumn.DataPropertyName = "ENT_ABREVIATURA"
        Me.ENTABREVIATURADataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.ENTABREVIATURADataGridViewTextBoxColumn.Name = "ENTABREVIATURADataGridViewTextBoxColumn"
        Me.ENTABREVIATURADataGridViewTextBoxColumn.ReadOnly = True
        '
        'DPLPORCOLOCARDataGridViewTextBoxColumn
        '
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.DataPropertyName = "DPL_PORCOLOCAR"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N1"
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.HeaderText = "Saldo Disponible"
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.Name = "DPLPORCOLOCARDataGridViewTextBoxColumn"
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoCheque
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.MontoCheque.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoCheque.HeaderText = "Monto Cheque"
        Me.MontoCheque.Name = "MontoCheque"
        Me.MontoCheque.Width = 160
        '
        'TESDPLBindingSource
        '
        Me.TESDPLBindingSource.DataMember = "TESDPL"
        Me.TESDPLBindingSource.DataSource = Me.DsWALPLABindingSource
        '
        'rbInversion
        '
        Me.rbInversion.AutoSize = True
        Me.rbInversion.Checked = True
        Me.rbInversion.Location = New System.Drawing.Point(28, 37)
        Me.rbInversion.Name = "rbInversion"
        Me.rbInversion.Size = New System.Drawing.Size(68, 17)
        Me.rbInversion.TabIndex = 3
        Me.rbInversion.TabStop = True
        Me.rbInversion.Text = "Inversión"
        Me.rbInversion.UseVisualStyleBackColor = True
        '
        'rbPago
        '
        Me.rbPago.AutoSize = True
        Me.rbPago.Location = New System.Drawing.Point(112, 37)
        Me.rbPago.Name = "rbPago"
        Me.rbPago.Size = New System.Drawing.Size(50, 17)
        Me.rbPago.TabIndex = 4
        Me.rbPago.Text = "Pago"
        Me.rbPago.UseVisualStyleBackColor = True
        '
        'TESBENTableAdapter
        '
        Me.TESBENTableAdapter.ClearBeforeFill = True
        '
        'TESUPATableAdapter
        '
        Me.TESUPATableAdapter.ClearBeforeFill = True
        '
        'TESGLOTableAdapter
        '
        Me.TESGLOTableAdapter.ClearBeforeFill = True
        '
        'TESDPLTableAdapter
        '
        Me.TESDPLTableAdapter.ClearBeforeFill = True
        '
        'TESENTTableAdapter
        '
        Me.TESENTTableAdapter.ClearBeforeFill = True
        '
        'TESINFTableAdapter
        '
        Me.TESINFTableAdapter.ClearBeforeFill = True
        '
        'TESFONTableAdapter
        '
        Me.TESFONTableAdapter.ClearBeforeFill = True
        '
        'frmWALGMO00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 494)
        Me.Controls.Add(Me.rbPago)
        Me.Controls.Add(Me.rbInversion)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWALGMO00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de Cheques"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbFondo.ResumeLayout(False)
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.TESGLOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TESUPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInversion.ResumeLayout(False)
        Me.gbInversion.PerformLayout()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.AxSAPLogonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMontos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESDPLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbUnidadPagadora As ComboBox
    Friend WithEvents gbInversion As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents tbNota As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents tbGlosaEditada As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cbGlosas As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btBuscaBeneficiario As Button
    Friend WithEvents cbBeneficiarios As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbEntidad As Label
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents DsWALPLA As dsWALPLA
    Friend WithEvents TESUPABindingSource As BindingSource
    Friend WithEvents TESUPATableAdapter As dsWALPLATableAdapters.TESUPATableAdapter
    Friend WithEvents DsWALBEN As dsWALBEN
    Friend WithEvents TESBENBindingSource As BindingSource
    Friend WithEvents TESBENTableAdapter As dsWALBENTableAdapters.TESBENTableAdapter
    Friend WithEvents TESGLOBindingSource As BindingSource
    Friend WithEvents TESGLOTableAdapter As dsWALPLATableAdapters.TESGLOTableAdapter
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents cbComprometida As CheckBox
    Friend WithEvents dtpVencimiento As DateTimePicker
    Friend WithEvents cbPapel As ComboBox
    Friend WithEvents cbEntidad As ComboBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents dgvMontos As DataGridView
    Friend WithEvents DsWALPLABindingSource As BindingSource
    Friend WithEvents TESDPLBindingSource As BindingSource
    Friend WithEvents TESDPLTableAdapter As dsWALPLATableAdapters.TESDPLTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbNominal As RadioButton
    Friend WithEvents rbReal As RadioButton
    Friend WithEvents tbTasa As TextBox
    Friend WithEvents gbFondo As GroupBox
    Friend WithEvents cbFondo As ComboBox
    Friend WithEvents TESENTBindingSource As BindingSource
    Friend WithEvents TESENTTableAdapter As dsWALPLATableAdapters.TESENTTableAdapter
    Friend WithEvents TESINFBindingSource As BindingSource
    Friend WithEvents TESINFTableAdapter As dsWALPLATableAdapters.TESINFTableAdapter
    Friend WithEvents TESFONBindingSource As BindingSource
    Friend WithEvents TESFONTableAdapter As dsWALPLATableAdapters.TESFONTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCheques As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents rbPago As RadioButton
    Friend WithEvents rbInversion As RadioButton
    Friend WithEvents AxSAPLogonControl1 As AxSAPLogonCtrl.AxSAPLogonControl
    Friend WithEvents CTE_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents ENTABREVIATURADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DPLPORCOLOCARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoCheque As DataGridViewTextBoxColumn
End Class
