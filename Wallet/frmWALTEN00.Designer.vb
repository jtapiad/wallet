<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALTEN00
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
        Dim TEN_TIPOLabel As System.Windows.Forms.Label
        Dim TEN_CODIGOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALTEN00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvTiposEntidades = New System.Windows.Forms.DataGridView()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.chkFondo = New System.Windows.Forms.CheckBox()
        Me.TEN_CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.TEN_TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TENTIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TENCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESTENDataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALTEN = New Wallet.dsWALTEN()
        Me.TESTENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESTENDataGridTableAdapter = New Wallet.dsWALTENTableAdapters.TESTENDataGridTableAdapter()
        Me.TESTENTableAdapter = New Wallet.dsWALTENTableAdapters.TESTENTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALTENTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        TEN_TIPOLabel = New System.Windows.Forms.Label()
        TEN_CODIGOLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvTiposEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTENDataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALTEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TEN_TIPOLabel
        '
        TEN_TIPOLabel.AutoSize = True
        TEN_TIPOLabel.Location = New System.Drawing.Point(19, 77)
        TEN_TIPOLabel.Name = "TEN_TIPOLabel"
        TEN_TIPOLabel.Size = New System.Drawing.Size(34, 13)
        TEN_TIPOLabel.TabIndex = 0
        TEN_TIPOLabel.Text = "Tipo :"
        '
        'TEN_CODIGOLabel
        '
        TEN_CODIGOLabel.AutoSize = True
        TEN_CODIGOLabel.Location = New System.Drawing.Point(19, 36)
        TEN_CODIGOLabel.Name = "TEN_CODIGOLabel"
        TEN_CODIGOLabel.Size = New System.Drawing.Size(46, 13)
        TEN_CODIGOLabel.TabIndex = 4
        TEN_CODIGOLabel.Text = "Código :"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(697, 443)
        Me.SplitContainer1.SplitterDistance = 286
        Me.SplitContainer1.TabIndex = 0
        '
        'gbGeneral
        '
        Me.gbGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGeneral.Controls.Add(Me.dgvTiposEntidades)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 412)
        Me.gbGeneral.TabIndex = 3
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Tipo Entidades"
        '
        'dgvTiposEntidades
        '
        Me.dgvTiposEntidades.AllowUserToAddRows = False
        Me.dgvTiposEntidades.AllowUserToDeleteRows = False
        Me.dgvTiposEntidades.AllowUserToOrderColumns = True
        Me.dgvTiposEntidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTiposEntidades.AutoGenerateColumns = False
        Me.dgvTiposEntidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTiposEntidades.BackgroundColor = System.Drawing.Color.White
        Me.dgvTiposEntidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TENTIPODataGridViewTextBoxColumn, Me.TENCODIGODataGridViewTextBoxColumn})
        Me.dgvTiposEntidades.DataSource = Me.TESTENDataGridBindingSource
        Me.dgvTiposEntidades.Location = New System.Drawing.Point(0, 19)
        Me.dgvTiposEntidades.Name = "dgvTiposEntidades"
        Me.dgvTiposEntidades.ReadOnly = True
        Me.dgvTiposEntidades.RowHeadersWidth = 20
        Me.dgvTiposEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiposEntidades.Size = New System.Drawing.Size(263, 384)
        Me.dgvTiposEntidades.TabIndex = 3
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(286, 25)
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
        Me.tsbAgregar.ToolTipText = "Agrega Tipo Entidad"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Tipo Entidad"
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
        Me.gbDetalle.Controls.Add(Me.Label1)
        Me.gbDetalle.Controls.Add(Me.chkFondo)
        Me.gbDetalle.Controls.Add(TEN_CODIGOLabel)
        Me.gbDetalle.Controls.Add(Me.TEN_CODIGOTextBox)
        Me.gbDetalle.Controls.Add(TEN_TIPOLabel)
        Me.gbDetalle.Controls.Add(Me.TEN_TIPOTextBox)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(11, 144)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(393, 154)
        Me.gbDetalle.TabIndex = 3
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'chkFondo
        '
        Me.chkFondo.AutoSize = True
        Me.chkFondo.Location = New System.Drawing.Point(102, 114)
        Me.chkFondo.Name = "chkFondo"
        Me.chkFondo.Size = New System.Drawing.Size(101, 17)
        Me.chkFondo.TabIndex = 6
        Me.chkFondo.Text = "¿Fondo Mutuo?"
        Me.chkFondo.UseVisualStyleBackColor = True
        '
        'TEN_CODIGOTextBox
        '
        Me.TEN_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESTENBindingSource, "TEN_CODIGO", True))
        Me.TEN_CODIGOTextBox.Location = New System.Drawing.Point(102, 33)
        Me.TEN_CODIGOTextBox.MaxLength = 4
        Me.TEN_CODIGOTextBox.Name = "TEN_CODIGOTextBox"
        Me.TEN_CODIGOTextBox.Size = New System.Drawing.Size(168, 20)
        Me.TEN_CODIGOTextBox.TabIndex = 5
        '
        'TEN_TIPOTextBox
        '
        Me.TEN_TIPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESTENBindingSource, "TEN_TIPO", True))
        Me.TEN_TIPOTextBox.Location = New System.Drawing.Point(102, 74)
        Me.TEN_TIPOTextBox.MaxLength = 20
        Me.TEN_TIPOTextBox.Name = "TEN_TIPOTextBox"
        Me.TEN_TIPOTextBox.Size = New System.Drawing.Size(266, 20)
        Me.TEN_TIPOTextBox.TabIndex = 1
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(407, 25)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TENTIPODataGridViewTextBoxColumn
        '
        Me.TENTIPODataGridViewTextBoxColumn.DataPropertyName = "TEN_TIPO"
        Me.TENTIPODataGridViewTextBoxColumn.HeaderText = "Tipo Entidad"
        Me.TENTIPODataGridViewTextBoxColumn.Name = "TENTIPODataGridViewTextBoxColumn"
        Me.TENTIPODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TENCODIGODataGridViewTextBoxColumn
        '
        Me.TENCODIGODataGridViewTextBoxColumn.DataPropertyName = "TEN_CODIGO"
        Me.TENCODIGODataGridViewTextBoxColumn.HeaderText = "TEN_CODIGO"
        Me.TENCODIGODataGridViewTextBoxColumn.Name = "TENCODIGODataGridViewTextBoxColumn"
        Me.TENCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.TENCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESTENDataGridBindingSource
        '
        Me.TESTENDataGridBindingSource.DataMember = "TESTENDataGrid"
        Me.TESTENDataGridBindingSource.DataSource = Me.DsWALTEN
        '
        'DsWALTEN
        '
        Me.DsWALTEN.DataSetName = "dsWALTEN"
        Me.DsWALTEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESTENBindingSource
        '
        Me.TESTENBindingSource.DataMember = "TESTEN"
        Me.TESTENBindingSource.DataSource = Me.DsWALTEN
        '
        'TESTENDataGridTableAdapter
        '
        Me.TESTENDataGridTableAdapter.ClearBeforeFill = True
        '
        'TESTENTableAdapter
        '
        Me.TESTENTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESTENDataGridTableAdapter = Me.TESTENDataGridTableAdapter
        Me.TableAdapterManager.TESTENTableAdapter = Me.TESTENTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALTENTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "(Numérico)"
        '
        'frmWALTEN00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 443)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALTEN00"
        Me.Text = "Tipo de Entidades"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvTiposEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTENDataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALTEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvTiposEntidades As DataGridView
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents DsWALTEN As dsWALTEN
    Friend WithEvents TESTENDataGridBindingSource As BindingSource
    Friend WithEvents TESTENDataGridTableAdapter As dsWALTENTableAdapters.TESTENDataGridTableAdapter
    Friend WithEvents TENTIPODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TENCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TESTENBindingSource As BindingSource
    Friend WithEvents TESTENTableAdapter As dsWALTENTableAdapters.TESTENTableAdapter
    Friend WithEvents TableAdapterManager As dsWALTENTableAdapters.TableAdapterManager
    Friend WithEvents TEN_TIPOTextBox As TextBox
    Friend WithEvents chkFondo As CheckBox
    Friend WithEvents TEN_CODIGOTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents Label1 As Label
End Class
