<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALTII00
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
        Dim TII_TIPOLabel As System.Windows.Forms.Label
        Dim TII_ABREVIATURALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALTII00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvTiposInstrumento = New System.Windows.Forms.DataGridView()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.TII_TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.TII_ABREVIATURATextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TIITIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIICODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESTIIDataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALTII = New Wallet.dsWALTII()
        Me.TESTIIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESTIIDataGridTableAdapter = New Wallet.dsWALTIITableAdapters.TESTIIDataGridTableAdapter()
        Me.TESTIITableAdapter = New Wallet.dsWALTIITableAdapters.TESTIITableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALTIITableAdapters.TableAdapterManager()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        TII_TIPOLabel = New System.Windows.Forms.Label()
        TII_ABREVIATURALabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvTiposInstrumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTIIDataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALTII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTIIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TII_TIPOLabel
        '
        TII_TIPOLabel.AutoSize = True
        TII_TIPOLabel.Location = New System.Drawing.Point(19, 62)
        TII_TIPOLabel.Name = "TII_TIPOLabel"
        TII_TIPOLabel.Size = New System.Drawing.Size(89, 13)
        TII_TIPOLabel.TabIndex = 2
        TII_TIPOLabel.Text = "Tipo Instrumento:"
        '
        'TII_ABREVIATURALabel
        '
        TII_ABREVIATURALabel.AutoSize = True
        TII_ABREVIATURALabel.Location = New System.Drawing.Point(19, 88)
        TII_ABREVIATURALabel.Name = "TII_ABREVIATURALabel"
        TII_ABREVIATURALabel.Size = New System.Drawing.Size(67, 13)
        TII_ABREVIATURALabel.TabIndex = 4
        TII_ABREVIATURALabel.Text = "Abreviatura :"
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
        Me.gbGeneral.Controls.Add(Me.dgvTiposInstrumento)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 412)
        Me.gbGeneral.TabIndex = 4
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Tipo Instrumento Financiero"
        '
        'dgvTiposInstrumento
        '
        Me.dgvTiposInstrumento.AllowUserToAddRows = False
        Me.dgvTiposInstrumento.AllowUserToDeleteRows = False
        Me.dgvTiposInstrumento.AllowUserToOrderColumns = True
        Me.dgvTiposInstrumento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTiposInstrumento.AutoGenerateColumns = False
        Me.dgvTiposInstrumento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTiposInstrumento.BackgroundColor = System.Drawing.Color.White
        Me.dgvTiposInstrumento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIITIPODataGridViewTextBoxColumn, Me.TIICODIGODataGridViewTextBoxColumn})
        Me.dgvTiposInstrumento.DataSource = Me.TESTIIDataGridBindingSource
        Me.dgvTiposInstrumento.Location = New System.Drawing.Point(0, 19)
        Me.dgvTiposInstrumento.Name = "dgvTiposInstrumento"
        Me.dgvTiposInstrumento.ReadOnly = True
        Me.dgvTiposInstrumento.RowHeadersWidth = 20
        Me.dgvTiposInstrumento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiposInstrumento.Size = New System.Drawing.Size(263, 384)
        Me.dgvTiposInstrumento.TabIndex = 3
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
        Me.tsbAgregar.ToolTipText = "Agrega Tipo Instrumento"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Tipo Instrumento"
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
        Me.gbDetalle.Controls.Add(TII_TIPOLabel)
        Me.gbDetalle.Controls.Add(Me.TII_TIPOTextBox)
        Me.gbDetalle.Controls.Add(TII_ABREVIATURALabel)
        Me.gbDetalle.Controls.Add(Me.TII_ABREVIATURATextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(7, 144)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(393, 162)
        Me.gbDetalle.TabIndex = 4
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'TII_TIPOTextBox
        '
        Me.TII_TIPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESTIIBindingSource, "TII_TIPO", True))
        Me.TII_TIPOTextBox.Location = New System.Drawing.Point(127, 59)
        Me.TII_TIPOTextBox.MaxLength = 25
        Me.TII_TIPOTextBox.Name = "TII_TIPOTextBox"
        Me.TII_TIPOTextBox.Size = New System.Drawing.Size(251, 20)
        Me.TII_TIPOTextBox.TabIndex = 3
        '
        'TII_ABREVIATURATextBox
        '
        Me.TII_ABREVIATURATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESTIIBindingSource, "TII_ABREVIATURA", True))
        Me.TII_ABREVIATURATextBox.Location = New System.Drawing.Point(127, 85)
        Me.TII_ABREVIATURATextBox.MaxLength = 10
        Me.TII_ABREVIATURATextBox.Name = "TII_ABREVIATURATextBox"
        Me.TII_ABREVIATURATextBox.Size = New System.Drawing.Size(251, 20)
        Me.TII_ABREVIATURATextBox.TabIndex = 5
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
        'TIITIPODataGridViewTextBoxColumn
        '
        Me.TIITIPODataGridViewTextBoxColumn.DataPropertyName = "TII_TIPO"
        Me.TIITIPODataGridViewTextBoxColumn.HeaderText = "Tipo Instrumento Financiero"
        Me.TIITIPODataGridViewTextBoxColumn.Name = "TIITIPODataGridViewTextBoxColumn"
        Me.TIITIPODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIICODIGODataGridViewTextBoxColumn
        '
        Me.TIICODIGODataGridViewTextBoxColumn.DataPropertyName = "TII_CODIGO"
        Me.TIICODIGODataGridViewTextBoxColumn.HeaderText = "TII_CODIGO"
        Me.TIICODIGODataGridViewTextBoxColumn.Name = "TIICODIGODataGridViewTextBoxColumn"
        Me.TIICODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.TIICODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESTIIDataGridBindingSource
        '
        Me.TESTIIDataGridBindingSource.DataMember = "TESTIIDataGrid"
        Me.TESTIIDataGridBindingSource.DataSource = Me.DsWALTII
        '
        'DsWALTII
        '
        Me.DsWALTII.DataSetName = "dsWALTII"
        Me.DsWALTII.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESTIIBindingSource
        '
        Me.TESTIIBindingSource.DataMember = "TESTII"
        Me.TESTIIBindingSource.DataSource = Me.DsWALTII
        '
        'TESTIIDataGridTableAdapter
        '
        Me.TESTIIDataGridTableAdapter.ClearBeforeFill = True
        '
        'TESTIITableAdapter
        '
        Me.TESTIITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESTIIDataGridTableAdapter = Me.TESTIIDataGridTableAdapter
        Me.TableAdapterManager.TESTIITableAdapter = Me.TESTIITableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALTIITableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'frmWALTII00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 443)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALTII00"
        Me.Text = "Tipo Instrumento Financiero"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvTiposInstrumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTIIDataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALTII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTIIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvTiposInstrumento As DataGridView
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents DsWALTII As dsWALTII
    Friend WithEvents TESTIIDataGridBindingSource As BindingSource
    Friend WithEvents TESTIIDataGridTableAdapter As dsWALTIITableAdapters.TESTIIDataGridTableAdapter
    Friend WithEvents TESTIIBindingSource As BindingSource
    Friend WithEvents TESTIITableAdapter As dsWALTIITableAdapters.TESTIITableAdapter
    Friend WithEvents TableAdapterManager As dsWALTIITableAdapters.TableAdapterManager
    Friend WithEvents TII_TIPOTextBox As TextBox
    Friend WithEvents TII_ABREVIATURATextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TIITIPODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIICODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tsbEliminar As ToolStripButton
End Class
