<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALCUS00
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
        Dim CUS_CUSTODIALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALCUS00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvCustodias = New System.Windows.Forms.DataGridView()
        Me.CUSCUSTODIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESCUSDataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALCUS = New Wallet.dsWALCUS()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.CUS_CUSTODIATextBox = New System.Windows.Forms.TextBox()
        Me.TESCUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TESCUSTableAdapter = New Wallet.dsWALCUSTableAdapters.TESCUSTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALCUSTableAdapters.TableAdapterManager()
        Me.TESCUSDataGridTableAdapter = New Wallet.dsWALCUSTableAdapters.TESCUSDataGridTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        CUS_CUSTODIALabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvCustodias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESCUSDataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALCUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.TESCUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CUS_CUSTODIALabel
        '
        CUS_CUSTODIALabel.AutoSize = True
        CUS_CUSTODIALabel.Location = New System.Drawing.Point(32, 60)
        CUS_CUSTODIALabel.Name = "CUS_CUSTODIALabel"
        CUS_CUSTODIALabel.Size = New System.Drawing.Size(54, 13)
        CUS_CUSTODIALabel.TabIndex = 0
        CUS_CUSTODIALabel.Text = "Custodia: "
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
        Me.SplitContainer1.Size = New System.Drawing.Size(697, 408)
        Me.SplitContainer1.SplitterDistance = 287
        Me.SplitContainer1.TabIndex = 0
        '
        'gbGeneral
        '
        Me.gbGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGeneral.Controls.Add(Me.dgvCustodias)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 368)
        Me.gbGeneral.TabIndex = 2
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Custodias"
        '
        'dgvCustodias
        '
        Me.dgvCustodias.AllowUserToAddRows = False
        Me.dgvCustodias.AllowUserToDeleteRows = False
        Me.dgvCustodias.AllowUserToOrderColumns = True
        Me.dgvCustodias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCustodias.AutoGenerateColumns = False
        Me.dgvCustodias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustodias.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustodias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSCUSTODIADataGridViewTextBoxColumn, Me.CUSCODIGODataGridViewTextBoxColumn})
        Me.dgvCustodias.DataSource = Me.TESCUSDataGridBindingSource
        Me.dgvCustodias.Location = New System.Drawing.Point(0, 19)
        Me.dgvCustodias.Name = "dgvCustodias"
        Me.dgvCustodias.ReadOnly = True
        Me.dgvCustodias.RowHeadersWidth = 20
        Me.dgvCustodias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustodias.Size = New System.Drawing.Size(263, 343)
        Me.dgvCustodias.TabIndex = 3
        '
        'CUSCUSTODIADataGridViewTextBoxColumn
        '
        Me.CUSCUSTODIADataGridViewTextBoxColumn.DataPropertyName = "CUS_CUSTODIA"
        Me.CUSCUSTODIADataGridViewTextBoxColumn.HeaderText = "Custodias"
        Me.CUSCUSTODIADataGridViewTextBoxColumn.Name = "CUSCUSTODIADataGridViewTextBoxColumn"
        Me.CUSCUSTODIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CUSCODIGODataGridViewTextBoxColumn
        '
        Me.CUSCODIGODataGridViewTextBoxColumn.DataPropertyName = "CUS_CODIGO"
        Me.CUSCODIGODataGridViewTextBoxColumn.HeaderText = "CUS_CODIGO"
        Me.CUSCODIGODataGridViewTextBoxColumn.Name = "CUSCODIGODataGridViewTextBoxColumn"
        Me.CUSCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CUSCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESCUSDataGridBindingSource
        '
        Me.TESCUSDataGridBindingSource.DataMember = "TESCUSDataGrid"
        Me.TESCUSDataGridBindingSource.DataSource = Me.DsWALCUS
        '
        'DsWALCUS
        '
        Me.DsWALCUS.DataSetName = "dsWALCUS"
        Me.DsWALCUS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(287, 25)
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
        Me.tsbAgregar.ToolTipText = "Agrega Custodia"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Custodia"
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
        Me.gbDetalle.Controls.Add(CUS_CUSTODIALabel)
        Me.gbDetalle.Controls.Add(Me.CUS_CUSTODIATextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(10, 115)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(393, 122)
        Me.gbDetalle.TabIndex = 2
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'CUS_CUSTODIATextBox
        '
        Me.CUS_CUSTODIATextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CUS_CUSTODIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESCUSBindingSource, "CUS_CUSTODIA", True))
        Me.CUS_CUSTODIATextBox.Location = New System.Drawing.Point(92, 57)
        Me.CUS_CUSTODIATextBox.MaxLength = 30
        Me.CUS_CUSTODIATextBox.Name = "CUS_CUSTODIATextBox"
        Me.CUS_CUSTODIATextBox.Size = New System.Drawing.Size(245, 20)
        Me.CUS_CUSTODIATextBox.TabIndex = 1
        '
        'TESCUSBindingSource
        '
        Me.TESCUSBindingSource.DataMember = "TESCUS"
        Me.TESCUSBindingSource.DataSource = Me.DsWALCUS
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(406, 25)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TESCUSTableAdapter
        '
        Me.TESCUSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESCUSDataGridTableAdapter = Nothing
        Me.TableAdapterManager.TESCUSTableAdapter = Me.TESCUSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALCUSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TESCUSDataGridTableAdapter
        '
        Me.TESCUSDataGridTableAdapter.ClearBeforeFill = True
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
        'frmWALCUS00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 408)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALCUS00"
        Me.Text = "Mantención de Custodias"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvCustodias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESCUSDataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALCUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.TESCUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvCustodias As DataGridView
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents DsWALCUS As dsWALCUS
    Friend WithEvents TESCUSBindingSource As BindingSource
    Friend WithEvents TESCUSTableAdapter As dsWALCUSTableAdapters.TESCUSTableAdapter
    Friend WithEvents TableAdapterManager As dsWALCUSTableAdapters.TableAdapterManager
    Friend WithEvents CUS_CUSTODIATextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TESCUSDataGridBindingSource As BindingSource
    Friend WithEvents TESCUSDataGridTableAdapter As dsWALCUSTableAdapters.TESCUSDataGridTableAdapter
    Friend WithEvents CUSCUSTODIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tsbEliminar As ToolStripButton
End Class
