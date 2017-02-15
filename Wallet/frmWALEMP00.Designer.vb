<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWALEMP00
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
        Dim EMP_EMPRESALabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALEMP00))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvEmpresas = New System.Windows.Forms.DataGridView()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.EMP_EMPRESATextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EMPEMPRESADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPAUDITORIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESEMPDataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALEMP = New Wallet.dsWALEMP()
        Me.TESEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESEMPTableAdapter = New Wallet.dsWALEMPTableAdapters.TESEMPTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALEMPTableAdapters.TableAdapterManager()
        Me.TESEMPDataGridTableAdapter = New Wallet.dsWALEMPTableAdapters.TESEMPDataGridTableAdapter()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        EMP_EMPRESALabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESEMPDataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMP_EMPRESALabel
        '
        EMP_EMPRESALabel.AutoSize = True
        EMP_EMPRESALabel.Location = New System.Drawing.Point(33, 99)
        EMP_EMPRESALabel.Name = "EMP_EMPRESALabel"
        EMP_EMPRESALabel.Size = New System.Drawing.Size(51, 13)
        EMP_EMPRESALabel.TabIndex = 2
        EMP_EMPRESALabel.Text = "Empresa:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(33, 60)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(43, 13)
        Label1.TabIndex = 5
        Label1.Text = "Código:"
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
        Me.gbGeneral.Controls.Add(Me.dgvEmpresas)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 28)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(269, 412)
        Me.gbGeneral.TabIndex = 2
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Empresas"
        '
        'dgvEmpresas
        '
        Me.dgvEmpresas.AllowUserToAddRows = False
        Me.dgvEmpresas.AllowUserToDeleteRows = False
        Me.dgvEmpresas.AllowUserToOrderColumns = True
        Me.dgvEmpresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpresas.AutoGenerateColumns = False
        Me.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpresas.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPEMPRESADataGridViewTextBoxColumn, Me.EMPAUDITORIADataGridViewTextBoxColumn, Me.EMPCODIGODataGridViewTextBoxColumn})
        Me.dgvEmpresas.DataSource = Me.TESEMPDataGridBindingSource
        Me.dgvEmpresas.Location = New System.Drawing.Point(0, 19)
        Me.dgvEmpresas.Name = "dgvEmpresas"
        Me.dgvEmpresas.ReadOnly = True
        Me.dgvEmpresas.RowHeadersWidth = 20
        Me.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpresas.Size = New System.Drawing.Size(263, 384)
        Me.dgvEmpresas.TabIndex = 3
        '
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStripGeneral.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneral.Name = "ToolStripGeneral"
        Me.ToolStripGeneral.Size = New System.Drawing.Size(286, 25)
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
        Me.tsbAgregar.ToolTipText = "Agrega Empresa"
        '
        'tsbEditar
        '
        Me.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditar.Text = "ToolStripButton2"
        Me.tsbEditar.ToolTipText = "Edita Empresa"
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
        Me.gbDetalle.Controls.Add(Me.lblCodigo)
        Me.gbDetalle.Controls.Add(Label1)
        Me.gbDetalle.Controls.Add(Me.EMP_EMPRESATextBox)
        Me.gbDetalle.Controls.Add(EMP_EMPRESALabel)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(11, 115)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(393, 154)
        Me.gbDetalle.TabIndex = 2
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(90, 60)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(39, 13)
        Me.lblCodigo.TabIndex = 6
        Me.lblCodigo.Text = "Label2"
        '
        'EMP_EMPRESATextBox
        '
        Me.EMP_EMPRESATextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EMP_EMPRESATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESEMPBindingSource, "EMP_EMPRESA", True))
        Me.EMP_EMPRESATextBox.Location = New System.Drawing.Point(93, 96)
        Me.EMP_EMPRESATextBox.MaxLength = 30
        Me.EMP_EMPRESATextBox.Name = "EMP_EMPRESATextBox"
        Me.EMP_EMPRESATextBox.Size = New System.Drawing.Size(245, 20)
        Me.EMP_EMPRESATextBox.TabIndex = 4
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Enabled = False
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(407, 25)
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
        'EMPEMPRESADataGridViewTextBoxColumn
        '
        Me.EMPEMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMP_EMPRESA"
        Me.EMPEMPRESADataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EMPEMPRESADataGridViewTextBoxColumn.Name = "EMPEMPRESADataGridViewTextBoxColumn"
        Me.EMPEMPRESADataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPAUDITORIADataGridViewTextBoxColumn
        '
        Me.EMPAUDITORIADataGridViewTextBoxColumn.DataPropertyName = "EMP_AUDITORIA"
        Me.EMPAUDITORIADataGridViewTextBoxColumn.HeaderText = "EMP_AUDITORIA"
        Me.EMPAUDITORIADataGridViewTextBoxColumn.Name = "EMPAUDITORIADataGridViewTextBoxColumn"
        Me.EMPAUDITORIADataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPAUDITORIADataGridViewTextBoxColumn.Visible = False
        '
        'EMPCODIGODataGridViewTextBoxColumn
        '
        Me.EMPCODIGODataGridViewTextBoxColumn.DataPropertyName = "EMP_CODIGO"
        Me.EMPCODIGODataGridViewTextBoxColumn.HeaderText = "EMP_CODIGO"
        Me.EMPCODIGODataGridViewTextBoxColumn.Name = "EMPCODIGODataGridViewTextBoxColumn"
        Me.EMPCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'TESEMPDataGridBindingSource
        '
        Me.TESEMPDataGridBindingSource.DataMember = "TESEMPDataGrid"
        Me.TESEMPDataGridBindingSource.DataSource = Me.DsWALEMP
        '
        'DsWALEMP
        '
        Me.DsWALEMP.DataSetName = "dsWALEMP"
        Me.DsWALEMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESEMPBindingSource
        '
        Me.TESEMPBindingSource.DataMember = "TESEMP"
        Me.TESEMPBindingSource.DataSource = Me.DsWALEMP
        '
        'TESEMPTableAdapter
        '
        Me.TESEMPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESCTETableAdapter = Nothing
        Me.TableAdapterManager.TESEMPDataGridTableAdapter = Me.TESEMPDataGridTableAdapter
        Me.TableAdapterManager.TESEMPTableAdapter = Me.TESEMPTableAdapter
        Me.TableAdapterManager.TESPLATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALEMPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TESEMPDataGridTableAdapter
        '
        Me.TESEMPDataGridTableAdapter.ClearBeforeFill = True
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
        'frmWALEMP00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 443)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALEMP00"
        Me.Text = "Mantención de Empresas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESEMPDataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALEMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvEmpresas As DataGridView
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents DsWALEMP As dsWALEMP
    Friend WithEvents TESEMPBindingSource As BindingSource
    Friend WithEvents TESEMPTableAdapter As dsWALEMPTableAdapters.TESEMPTableAdapter
    Friend WithEvents TableAdapterManager As dsWALEMPTableAdapters.TableAdapterManager
    Friend WithEvents TESEMPDataGridTableAdapter As dsWALEMPTableAdapters.TESEMPDataGridTableAdapter
    Friend WithEvents TESEMPDataGridBindingSource As BindingSource
    Friend WithEvents EMPEMPRESADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPAUDITORIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents EMP_EMPRESATextBox As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents tsbEliminar As ToolStripButton
End Class
