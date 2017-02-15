<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALPER04
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
        Dim SEGPER_PERFILLabel As System.Windows.Forms.Label
        Dim SEGPER_DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALPER04))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.dgvPerfiles = New System.Windows.Forms.DataGridView()
        Me.SEGPERPERFILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGPERCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGPERDatagridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSEGPERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSEGPER = New Wallet.dsSEGPER()
        Me.ToolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.pnlSEGPER = New System.Windows.Forms.Panel()
        Me.OPPTreeView = New System.Windows.Forms.TreeView()
        Me.SEGPER_PERFILTextBox = New System.Windows.Forms.TextBox()
        Me.SEGPERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEGPER_DESCRIPCIONTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripDetalle = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.SEGPERTableAdapter = New Wallet.dsSEGPERTableAdapters.SEGPERTableAdapter()
        Me.SEGPERDatagridTableAdapter = New Wallet.dsSEGPERTableAdapters.SEGPERDatagridTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        SEGPER_PERFILLabel = New System.Windows.Forms.Label()
        SEGPER_DESCRIPCIONLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        CType(Me.dgvPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGPERDatagridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSEGPERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneral.SuspendLayout()
        Me.pnlSEGPER.SuspendLayout()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripDetalle.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEGPER_PERFILLabel
        '
        SEGPER_PERFILLabel.AutoSize = True
        SEGPER_PERFILLabel.Location = New System.Drawing.Point(16, 16)
        SEGPER_PERFILLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SEGPER_PERFILLabel.Name = "SEGPER_PERFILLabel"
        SEGPER_PERFILLabel.Size = New System.Drawing.Size(93, 13)
        SEGPER_PERFILLabel.TabIndex = 0
        SEGPER_PERFILLabel.Text = "Nombre del Perfil :"
        '
        'SEGPER_DESCRIPCIONLabel
        '
        SEGPER_DESCRIPCIONLabel.AutoSize = True
        SEGPER_DESCRIPCIONLabel.Location = New System.Drawing.Point(42, 39)
        SEGPER_DESCRIPCIONLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SEGPER_DESCRIPCIONLabel.Name = "SEGPER_DESCRIPCIONLabel"
        SEGPER_DESCRIPCIONLabel.Size = New System.Drawing.Size(69, 13)
        SEGPER_DESCRIPCIONLabel.TabIndex = 1
        SEGPER_DESCRIPCIONLabel.Text = "Descripción :"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlSEGPER)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripDetalle)
        Me.SplitContainer1.Size = New System.Drawing.Size(697, 506)
        Me.SplitContainer1.SplitterDistance = 284
        Me.SplitContainer1.TabIndex = 0
        '
        'gbGeneral
        '
        Me.gbGeneral.Controls.Add(Me.Label1)
        Me.gbGeneral.Controls.Add(Me.dgvPerfiles)
        Me.gbGeneral.Location = New System.Drawing.Point(13, 29)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(268, 465)
        Me.gbGeneral.TabIndex = 5
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "Perfiles"
        '
        'dgvPerfiles
        '
        Me.dgvPerfiles.AllowUserToAddRows = False
        Me.dgvPerfiles.AllowUserToDeleteRows = False
        Me.dgvPerfiles.AllowUserToOrderColumns = True
        Me.dgvPerfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPerfiles.AutoGenerateColumns = False
        Me.dgvPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPerfiles.BackgroundColor = System.Drawing.Color.White
        Me.dgvPerfiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SEGPERPERFILDataGridViewTextBoxColumn, Me.SEGPERCODIGODataGridViewTextBoxColumn})
        Me.dgvPerfiles.DataSource = Me.SEGPERDatagridBindingSource
        Me.dgvPerfiles.Location = New System.Drawing.Point(21, 19)
        Me.dgvPerfiles.Name = "dgvPerfiles"
        Me.dgvPerfiles.ReadOnly = True
        Me.dgvPerfiles.RowHeadersWidth = 20
        Me.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPerfiles.Size = New System.Drawing.Size(226, 381)
        Me.dgvPerfiles.TabIndex = 5
        '
        'SEGPERPERFILDataGridViewTextBoxColumn
        '
        Me.SEGPERPERFILDataGridViewTextBoxColumn.DataPropertyName = "SEGPER_PERFIL"
        Me.SEGPERPERFILDataGridViewTextBoxColumn.HeaderText = "Perfil"
        Me.SEGPERPERFILDataGridViewTextBoxColumn.Name = "SEGPERPERFILDataGridViewTextBoxColumn"
        Me.SEGPERPERFILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SEGPERCODIGODataGridViewTextBoxColumn
        '
        Me.SEGPERCODIGODataGridViewTextBoxColumn.DataPropertyName = "SEGPER_CODIGO"
        Me.SEGPERCODIGODataGridViewTextBoxColumn.HeaderText = "SEGPER_CODIGO"
        Me.SEGPERCODIGODataGridViewTextBoxColumn.Name = "SEGPERCODIGODataGridViewTextBoxColumn"
        Me.SEGPERCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.SEGPERCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'SEGPERDatagridBindingSource
        '
        Me.SEGPERDatagridBindingSource.DataMember = "SEGPERDatagrid"
        Me.SEGPERDatagridBindingSource.DataSource = Me.DsSEGPERBindingSource
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
        'ToolStripGeneral
        '
        Me.ToolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbEditar, Me.tsbEliminar, Me.tsbRefrescar, Me.tsbSalir})
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
        'pnlSEGPER
        '
        Me.pnlSEGPER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSEGPER.Controls.Add(Me.OPPTreeView)
        Me.pnlSEGPER.Controls.Add(SEGPER_PERFILLabel)
        Me.pnlSEGPER.Controls.Add(Me.SEGPER_PERFILTextBox)
        Me.pnlSEGPER.Controls.Add(SEGPER_DESCRIPCIONLabel)
        Me.pnlSEGPER.Controls.Add(Me.SEGPER_DESCRIPCIONTextBox)
        Me.pnlSEGPER.Location = New System.Drawing.Point(13, 44)
        Me.pnlSEGPER.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSEGPER.Name = "pnlSEGPER"
        Me.pnlSEGPER.Size = New System.Drawing.Size(385, 450)
        Me.pnlSEGPER.TabIndex = 4
        '
        'OPPTreeView
        '
        Me.OPPTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OPPTreeView.CheckBoxes = True
        Me.OPPTreeView.Location = New System.Drawing.Point(19, 102)
        Me.OPPTreeView.Margin = New System.Windows.Forms.Padding(2)
        Me.OPPTreeView.Name = "OPPTreeView"
        Me.OPPTreeView.Size = New System.Drawing.Size(353, 330)
        Me.OPPTreeView.TabIndex = 4
        '
        'SEGPER_PERFILTextBox
        '
        Me.SEGPER_PERFILTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGPER_PERFILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGPERBindingSource, "SEGPER_PERFIL", True))
        Me.SEGPER_PERFILTextBox.Location = New System.Drawing.Point(114, 14)
        Me.SEGPER_PERFILTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SEGPER_PERFILTextBox.MaxLength = 30
        Me.SEGPER_PERFILTextBox.Name = "SEGPER_PERFILTextBox"
        Me.SEGPER_PERFILTextBox.Size = New System.Drawing.Size(258, 20)
        Me.SEGPER_PERFILTextBox.TabIndex = 0
        '
        'SEGPERBindingSource
        '
        Me.SEGPERBindingSource.DataMember = "SEGPER"
        Me.SEGPERBindingSource.DataSource = Me.DsSEGPER
        '
        'SEGPER_DESCRIPCIONTextBox
        '
        Me.SEGPER_DESCRIPCIONTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGPER_DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGPERBindingSource, "SEGPER_DESCRIPCION", True))
        Me.SEGPER_DESCRIPCIONTextBox.Location = New System.Drawing.Point(114, 37)
        Me.SEGPER_DESCRIPCIONTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SEGPER_DESCRIPCIONTextBox.MaxLength = 100
        Me.SEGPER_DESCRIPCIONTextBox.Multiline = True
        Me.SEGPER_DESCRIPCIONTextBox.Name = "SEGPER_DESCRIPCIONTextBox"
        Me.SEGPER_DESCRIPCIONTextBox.Size = New System.Drawing.Size(258, 54)
        Me.SEGPER_DESCRIPCIONTextBox.TabIndex = 1
        '
        'ToolStripDetalle
        '
        Me.ToolStripDetalle.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.ToolStripDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripDetalle.Name = "ToolStripDetalle"
        Me.ToolStripDetalle.Size = New System.Drawing.Size(409, 25)
        Me.ToolStripDetalle.TabIndex = 5
        Me.ToolStripDetalle.TabStop = True
        Me.ToolStripDetalle.Text = "ToolStrip1"
        '
        'tsbAcepta
        '
        Me.tsbAcepta.Image = CType(resources.GetObject("tsbAcepta.Image"), System.Drawing.Image)
        Me.tsbAcepta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAcepta.Name = "tsbAcepta"
        Me.tsbAcepta.Size = New System.Drawing.Size(23, 22)
        '
        'tsbCancela
        '
        Me.tsbCancela.Image = CType(resources.GetObject("tsbCancela.Image"), System.Drawing.Image)
        Me.tsbCancela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancela.Name = "tsbCancela"
        Me.tsbCancela.Size = New System.Drawing.Size(23, 22)
        '
        'SEGPERTableAdapter
        '
        Me.SEGPERTableAdapter.ClearBeforeFill = True
        '
        'SEGPERDatagridTableAdapter
        '
        Me.SEGPERDatagridTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 407)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Los cambios realizados en los perfiles se evidenciarán en la próxima conexión del" &
    " usuario."
        '
        'frmWALPER04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALPER04"
        Me.Text = "Perfil"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        CType(Me.dgvPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGPERDatagridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSEGPERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneral.ResumeLayout(False)
        Me.ToolStripGeneral.PerformLayout()
        Me.pnlSEGPER.ResumeLayout(False)
        Me.pnlSEGPER.PerformLayout()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripDetalle.ResumeLayout(False)
        Me.ToolStripDetalle.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlSEGPER As Panel
    Friend WithEvents SEGPER_PERFILTextBox As TextBox
    Friend WithEvents SEGPER_DESCRIPCIONTextBox As TextBox
    Friend WithEvents ToolStripDetalle As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents ToolStripGeneral As ToolStrip
    Friend WithEvents tsbAgregar As ToolStripButton
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents DsSEGPERBindingSource As BindingSource
    Friend WithEvents DsSEGPER As dsSEGPER
    Friend WithEvents SEGPERBindingSource As BindingSource
    Friend WithEvents SEGPERTableAdapter As dsSEGPERTableAdapters.SEGPERTableAdapter
    Friend WithEvents SEGPERDatagridBindingSource As BindingSource
    Friend WithEvents SEGPERDatagridTableAdapter As dsSEGPERTableAdapters.SEGPERDatagridTableAdapter
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents dgvPerfiles As DataGridView
    Friend WithEvents SEGPERPERFILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEGPERCODIGODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPPTreeView As TreeView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents Label1 As Label
End Class
