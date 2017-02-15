<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALTFD00
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
        Dim TFD_TIPOLabel As System.Windows.Forms.Label
        Dim TFD_DIASINILabel As System.Windows.Forms.Label
        Dim TFD_DIASFINLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALTFD00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvTiposFondos = New System.Windows.Forms.DataGridView()
        Me.TESTFDDataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbLargo = New System.Windows.Forms.RadioButton()
        Me.RbCorto = New System.Windows.Forms.RadioButton()
        Me.rbMediano = New System.Windows.Forms.RadioButton()
        Me.TFD_TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.TFD_DIASINITextBox = New System.Windows.Forms.TextBox()
        Me.TFD_DIASFINTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TFDTIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFDCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsWALTFDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALTFD = New Wallet.dsWALTFD()
        Me.TESTFDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESTFDTableAdapter = New Wallet.dsWALTFDTableAdapters.TESTFDTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALTFDTableAdapters.TableAdapterManager()
        Me.TESTFDDataGridTableAdapter = New Wallet.dsWALTFDTableAdapters.TESTFDDataGridTableAdapter()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        TFD_TIPOLabel = New System.Windows.Forms.Label()
        TFD_DIASINILabel = New System.Windows.Forms.Label()
        TFD_DIASFINLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvTiposFondos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTFDDataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALTFDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALTFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTFDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TFD_TIPOLabel
        '
        TFD_TIPOLabel.AutoSize = True
        TFD_TIPOLabel.Location = New System.Drawing.Point(30, 43)
        TFD_TIPOLabel.Name = "TFD_TIPOLabel"
        TFD_TIPOLabel.Size = New System.Drawing.Size(82, 13)
        TFD_TIPOLabel.TabIndex = 0
        TFD_TIPOLabel.Text = "Tipo de Fondo :"
        '
        'TFD_DIASINILabel
        '
        TFD_DIASINILabel.AutoSize = True
        TFD_DIASINILabel.Location = New System.Drawing.Point(30, 69)
        TFD_DIASINILabel.Name = "TFD_DIASINILabel"
        TFD_DIASINILabel.Size = New System.Drawing.Size(62, 13)
        TFD_DIASINILabel.TabIndex = 2
        TFD_DIASINILabel.Text = "Dias Inicio :"
        '
        'TFD_DIASFINLabel
        '
        TFD_DIASFINLabel.AutoSize = True
        TFD_DIASFINLabel.Location = New System.Drawing.Point(30, 95)
        TFD_DIASFINLabel.Name = "TFD_DIASFINLabel"
        TFD_DIASFINLabel.Size = New System.Drawing.Size(75, 13)
        TFD_DIASFINLabel.TabIndex = 4
        TFD_DIASFINLabel.Text = "Dias Término :"
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
        Me.gbGeneral.Controls.Add(Me.dgvTiposFondos)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 412)
        Me.gbGeneral.TabIndex = 4
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Tipo Fondos :"
        '
        'dgvTiposFondos
        '
        Me.dgvTiposFondos.AllowUserToAddRows = False
        Me.dgvTiposFondos.AllowUserToDeleteRows = False
        Me.dgvTiposFondos.AllowUserToOrderColumns = True
        Me.dgvTiposFondos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTiposFondos.AutoGenerateColumns = False
        Me.dgvTiposFondos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTiposFondos.BackgroundColor = System.Drawing.Color.White
        Me.dgvTiposFondos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TFDTIPODataGridViewTextBoxColumn, Me.TFDCODIGODataGridViewTextBoxColumn})
        Me.dgvTiposFondos.DataSource = Me.TESTFDDataGridBindingSource
        Me.dgvTiposFondos.Location = New System.Drawing.Point(0, 19)
        Me.dgvTiposFondos.Name = "dgvTiposFondos"
        Me.dgvTiposFondos.ReadOnly = True
        Me.dgvTiposFondos.RowHeadersWidth = 20
        Me.dgvTiposFondos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiposFondos.Size = New System.Drawing.Size(263, 384)
        Me.dgvTiposFondos.TabIndex = 3
        '
        'TESTFDDataGridBindingSource
        '
        Me.TESTFDDataGridBindingSource.DataMember = "TESTFDDataGrid"
        Me.TESTFDDataGridBindingSource.DataSource = Me.DsWALTFDBindingSource
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(286, 25)
        Me.ToolStripGeneral.TabIndex = 3
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
        Me.tsbAgregar.ToolTipText = "Agrega Tipo Fondos"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Tipo Fondos"
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
        Me.gbDetalle.Controls.Add(Me.GroupBox1)
        Me.gbDetalle.Controls.Add(TFD_TIPOLabel)
        Me.gbDetalle.Controls.Add(Me.TFD_TIPOTextBox)
        Me.gbDetalle.Controls.Add(TFD_DIASINILabel)
        Me.gbDetalle.Controls.Add(Me.TFD_DIASINITextBox)
        Me.gbDetalle.Controls.Add(TFD_DIASFINLabel)
        Me.gbDetalle.Controls.Add(Me.TFD_DIASFINTextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(11, 104)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(393, 228)
        Me.gbDetalle.TabIndex = 4
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbLargo)
        Me.GroupBox1.Controls.Add(Me.RbCorto)
        Me.GroupBox1.Controls.Add(Me.rbMediano)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 69)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plazos"
        '
        'rbLargo
        '
        Me.rbLargo.AutoSize = True
        Me.rbLargo.Location = New System.Drawing.Point(163, 33)
        Me.rbLargo.Name = "rbLargo"
        Me.rbLargo.Size = New System.Drawing.Size(52, 17)
        Me.rbLargo.TabIndex = 9
        Me.rbLargo.TabStop = True
        Me.rbLargo.Text = "Largo"
        Me.rbLargo.UseVisualStyleBackColor = True
        '
        'RbCorto
        '
        Me.RbCorto.AutoSize = True
        Me.RbCorto.Location = New System.Drawing.Point(18, 33)
        Me.RbCorto.Name = "RbCorto"
        Me.RbCorto.Size = New System.Drawing.Size(50, 17)
        Me.RbCorto.TabIndex = 7
        Me.RbCorto.TabStop = True
        Me.RbCorto.Text = "Corto"
        Me.RbCorto.UseVisualStyleBackColor = True
        '
        'rbMediano
        '
        Me.rbMediano.AutoSize = True
        Me.rbMediano.Location = New System.Drawing.Point(91, 33)
        Me.rbMediano.Name = "rbMediano"
        Me.rbMediano.Size = New System.Drawing.Size(66, 17)
        Me.rbMediano.TabIndex = 8
        Me.rbMediano.TabStop = True
        Me.rbMediano.Text = "Mediano"
        Me.rbMediano.UseVisualStyleBackColor = True
        '
        'TFD_TIPOTextBox
        '
        Me.TFD_TIPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESTFDBindingSource, "TFD_TIPO", True))
        Me.TFD_TIPOTextBox.Location = New System.Drawing.Point(127, 40)
        Me.TFD_TIPOTextBox.MaxLength = 30
        Me.TFD_TIPOTextBox.Name = "TFD_TIPOTextBox"
        Me.TFD_TIPOTextBox.Size = New System.Drawing.Size(245, 20)
        Me.TFD_TIPOTextBox.TabIndex = 1
        '
        'TFD_DIASINITextBox
        '
        Me.TFD_DIASINITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESTFDBindingSource, "TFD_DIASINI", True))
        Me.TFD_DIASINITextBox.Location = New System.Drawing.Point(127, 66)
        Me.TFD_DIASINITextBox.MaxLength = 4
        Me.TFD_DIASINITextBox.Name = "TFD_DIASINITextBox"
        Me.TFD_DIASINITextBox.Size = New System.Drawing.Size(137, 20)
        Me.TFD_DIASINITextBox.TabIndex = 3
        '
        'TFD_DIASFINTextBox
        '
        Me.TFD_DIASFINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESTFDBindingSource, "TFD_DIASFIN", True))
        Me.TFD_DIASFINTextBox.Location = New System.Drawing.Point(127, 92)
        Me.TFD_DIASFINTextBox.MaxLength = 4
        Me.TFD_DIASFINTextBox.Name = "TFD_DIASFINTextBox"
        Me.TFD_DIASFINTextBox.Size = New System.Drawing.Size(137, 20)
        Me.TFD_DIASFINTextBox.TabIndex = 5
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(407, 25)
        Me.ToolStripDetalle.TabIndex = 3
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TFDTIPODataGridViewTextBoxColumn
        '
        Me.TFDTIPODataGridViewTextBoxColumn.DataPropertyName = "TFD_TIPO"
        Me.TFDTIPODataGridViewTextBoxColumn.HeaderText = "Tipo de Fondo"
        Me.TFDTIPODataGridViewTextBoxColumn.Name = "TFDTIPODataGridViewTextBoxColumn"
        Me.TFDTIPODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TFDCODIGODataGridViewTextBoxColumn
        '
        Me.TFDCODIGODataGridViewTextBoxColumn.DataPropertyName = "TFD_CODIGO"
        Me.TFDCODIGODataGridViewTextBoxColumn.HeaderText = "TFD_CODIGO"
        Me.TFDCODIGODataGridViewTextBoxColumn.Name = "TFDCODIGODataGridViewTextBoxColumn"
        Me.TFDCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.TFDCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'DsWALTFDBindingSource
        '
        Me.DsWALTFDBindingSource.DataSource = Me.DsWALTFD
        Me.DsWALTFDBindingSource.Position = 0
        '
        'DsWALTFD
        '
        Me.DsWALTFD.DataSetName = "dsWALTFD"
        Me.DsWALTFD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESTFDBindingSource
        '
        Me.TESTFDBindingSource.DataMember = "TESTFD"
        Me.TESTFDBindingSource.DataSource = Me.DsWALTFD
        '
        'TESTFDTableAdapter
        '
        Me.TESTFDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESTFDDataGridTableAdapter = Me.TESTFDDataGridTableAdapter
        Me.TableAdapterManager.TESTFDTableAdapter = Me.TESTFDTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALTFDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TESTFDDataGridTableAdapter
        '
        Me.TESTFDDataGridTableAdapter.ClearBeforeFill = True
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
        'frmWALTFD00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 443)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALTFD00"
        Me.Text = "Tipos de Fondos de Fondos Mutuos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvTiposFondos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTFDDataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALTFDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALTFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTFDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvTiposFondos As DataGridView
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents DsWALTFD As dsWALTFD
    Friend WithEvents TESTFDBindingSource As BindingSource
    Friend WithEvents TESTFDTableAdapter As dsWALTFDTableAdapters.TESTFDTableAdapter
    Friend WithEvents TableAdapterManager As dsWALTFDTableAdapters.TableAdapterManager
    Friend WithEvents DsWALTFDBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbLargo As RadioButton
    Friend WithEvents RbCorto As RadioButton
    Friend WithEvents rbMediano As RadioButton
    Friend WithEvents TFD_TIPOTextBox As TextBox
    Friend WithEvents TFD_DIASINITextBox As TextBox
    Friend WithEvents TFD_DIASFINTextBox As TextBox
    Friend WithEvents TESTFDDataGridTableAdapter As dsWALTFDTableAdapters.TESTFDDataGridTableAdapter
    Friend WithEvents TESTFDDataGridBindingSource As BindingSource
    Friend WithEvents TFDTIPODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TFDCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tsbEliminar As ToolStripButton
End Class
