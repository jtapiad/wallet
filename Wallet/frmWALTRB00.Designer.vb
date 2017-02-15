<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALTRB00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALTRB00))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TESINFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALPLA = New Wallet.dsWALPLA()
        Me.DsWALPLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TESBENTableAdapter = New Wallet.dsWALBENTableAdapters.TESBENTableAdapter()
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
        Me.TESENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESUPATableAdapter = New Wallet.dsWALPLATableAdapters.TESUPATableAdapter()
        Me.TESGLOTableAdapter = New Wallet.dsWALPLATableAdapters.TESGLOTableAdapter()
        Me.TESDPLTableAdapter = New Wallet.dsWALPLATableAdapters.TESDPLTableAdapter()
        Me.TESENTTableAdapter = New Wallet.dsWALPLATableAdapters.TESENTTableAdapter()
        Me.TESFONTableAdapter = New Wallet.dsWALPLATableAdapters.TESFONTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.tbNota = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.tbGlosaEditada = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbGlosas = New System.Windows.Forms.ComboBox()
        Me.TESGLOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbCuentaDestino = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbUnidadPagadora = New System.Windows.Forms.ComboBox()
        Me.TESUPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESBENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALBEN = New Wallet.dsWALBEN()
        Me.TESFONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESINFTableAdapter = New Wallet.dsWALPLATableAdapters.TESINFTableAdapter()
        Me.DsWALTRB = New Wallet.dsWALTRB()
        Me.CuentasDestinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cuentas_DestinoTableAdapter = New Wallet.dsWALTRBTableAdapters.Cuentas_DestinoTableAdapter()
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.AxSAPLogonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMontos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESDPLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TESGLOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TESUPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALTRB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasDestinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TESINFBindingSource
        '
        Me.TESINFBindingSource.DataMember = "TESINF"
        Me.TESINFBindingSource.DataSource = Me.DsWALPLA
        '
        'DsWALPLA
        '
        Me.DsWALPLA.DataSetName = "dsWALPLA"
        Me.DsWALPLA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsWALPLABindingSource
        '
        Me.DsWALPLABindingSource.DataSource = Me.DsWALPLA
        Me.DsWALPLABindingSource.Position = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(853, 25)
        Me.ToolStrip1.TabIndex = 6
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
        'TESBENTableAdapter
        '
        Me.TESBENTableAdapter.ClearBeforeFill = True
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
        Me.GroupBox9.Location = New System.Drawing.Point(404, 34)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(437, 388)
        Me.GroupBox9.TabIndex = 7
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
        Me.Label6.Location = New System.Drawing.Point(93, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Totales"
        '
        'tbCheques
        '
        Me.tbCheques.Location = New System.Drawing.Point(256, 352)
        Me.tbCheques.Name = "tbCheques"
        Me.tbCheques.Size = New System.Drawing.Size(153, 20)
        Me.tbCheques.TabIndex = 2
        Me.tbCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(148, 352)
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
        Me.dgvMontos.Size = New System.Drawing.Size(425, 326)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N1"
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.HeaderText = "Saldo Disponible"
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.Name = "DPLPORCOLOCARDataGridViewTextBoxColumn"
        Me.DPLPORCOLOCARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoCheque
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.MontoCheque.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontoCheque.HeaderText = "Monto Cheque"
        Me.MontoCheque.Name = "MontoCheque"
        Me.MontoCheque.Width = 160
        '
        'TESDPLBindingSource
        '
        Me.TESDPLBindingSource.DataMember = "TESDPL"
        Me.TESDPLBindingSource.DataSource = Me.DsWALPLABindingSource
        '
        'TESENTBindingSource
        '
        Me.TESENTBindingSource.DataMember = "TESENT"
        Me.TESENTBindingSource.DataSource = Me.DsWALPLABindingSource
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
        'TESFONTableAdapter
        '
        Me.TESFONTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 388)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Todos los Cheques se generarán a nombre de Compañía de Petróleos de Chile COPEC S" &
    ".A."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbNota)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 297)
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
        Me.GroupBox7.Location = New System.Drawing.Point(10, 227)
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
        Me.GroupBox6.Location = New System.Drawing.Point(10, 177)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(358, 49)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Glosa"
        '
        'cbGlosas
        '
        Me.cbGlosas.DataSource = Me.TESGLOBindingSource
        Me.cbGlosas.DisplayMember = "GLO_GLOSA"
        Me.cbGlosas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.GroupBox5.Controls.Add(Me.cbCuentaDestino)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 127)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(358, 49)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cuenta Destino"
        '
        'cbCuentaDestino
        '
        Me.cbCuentaDestino.DataSource = Me.CuentasDestinoBindingSource
        Me.cbCuentaDestino.DisplayMember = "largo"
        Me.cbCuentaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaDestino.FormattingEnabled = True
        Me.cbCuentaDestino.Location = New System.Drawing.Point(9, 17)
        Me.cbCuentaDestino.Name = "cbCuentaDestino"
        Me.cbCuentaDestino.Size = New System.Drawing.Size(343, 21)
        Me.cbCuentaDestino.TabIndex = 0
        Me.cbCuentaDestino.ValueMember = "Clave"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbMonto)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 82)
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
        'TESFONBindingSource
        '
        Me.TESFONBindingSource.DataMember = "TESFON"
        Me.TESFONBindingSource.DataSource = Me.DsWALPLA
        '
        'TESINFTableAdapter
        '
        Me.TESINFTableAdapter.ClearBeforeFill = True
        '
        'DsWALTRB
        '
        Me.DsWALTRB.DataSetName = "dsWALTRB"
        Me.DsWALTRB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuentasDestinoBindingSource
        '
        Me.CuentasDestinoBindingSource.DataMember = "Cuentas_Destino"
        Me.CuentasDestinoBindingSource.DataSource = Me.DsWALTRB
        '
        'Cuentas_DestinoTableAdapter
        '
        Me.Cuentas_DestinoTableAdapter.ClearBeforeFill = True
        '
        'frmWALTRB00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 434)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmWALTRB00"
        Me.Text = "Transferencias Bancarias"
        CType(Me.TESINFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.AxSAPLogonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMontos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESDPLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.TESGLOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TESUPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESFONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALTRB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasDestinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TESINFBindingSource As BindingSource
    Friend WithEvents DsWALPLA As dsWALPLA
    Friend WithEvents DsWALPLABindingSource As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents TESBENTableAdapter As dsWALBENTableAdapters.TESBENTableAdapter
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents AxSAPLogonControl1 As AxSAPLogonCtrl.AxSAPLogonControl
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCheques As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents dgvMontos As DataGridView
    Friend WithEvents CTE_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents ENTABREVIATURADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DPLPORCOLOCARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoCheque As DataGridViewTextBoxColumn
    Friend WithEvents TESDPLBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TESFONBindingSource As BindingSource
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents tbNota As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents tbGlosaEditada As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cbGlosas As ComboBox
    Friend WithEvents TESGLOBindingSource As BindingSource
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TESBENBindingSource As BindingSource
    Friend WithEvents DsWALBEN As dsWALBEN
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbUnidadPagadora As ComboBox
    Friend WithEvents TESUPABindingSource As BindingSource
    Friend WithEvents TESENTBindingSource As BindingSource
    Friend WithEvents TESUPATableAdapter As dsWALPLATableAdapters.TESUPATableAdapter
    Friend WithEvents TESGLOTableAdapter As dsWALPLATableAdapters.TESGLOTableAdapter
    Friend WithEvents TESDPLTableAdapter As dsWALPLATableAdapters.TESDPLTableAdapter
    Friend WithEvents TESENTTableAdapter As dsWALPLATableAdapters.TESENTTableAdapter
    Friend WithEvents TESFONTableAdapter As dsWALPLATableAdapters.TESFONTableAdapter
    Friend WithEvents TESINFTableAdapter As dsWALPLATableAdapters.TESINFTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCuentaDestino As ComboBox
    Friend WithEvents DsWALTRB As dsWALTRB
    Friend WithEvents CuentasDestinoBindingSource As BindingSource
    Friend WithEvents Cuentas_DestinoTableAdapter As dsWALTRBTableAdapters.Cuentas_DestinoTableAdapter
End Class
