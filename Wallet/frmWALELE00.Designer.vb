<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALELE00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALELE00))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DsWALELE = New Wallet.dsWALELE()
        Me.DsWALELEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESBENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESBENTableAdapter = New Wallet.dsWALELETableAdapters.TESBENTableAdapter()
        Me.BENRUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENNOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALELE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALELEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(488, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = Global.Wallet.My.Resources.Resources.Delete
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Text = "Efectuar la eliminación"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir sin Eliminar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BENRUTDataGridViewTextBoxColumn, Me.BENNOMBREDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TESBENBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(464, 408)
        Me.DataGridView1.TabIndex = 1
        '
        'DsWALELE
        '
        Me.DsWALELE.DataSetName = "dsWALELE"
        Me.DsWALELE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsWALELEBindingSource
        '
        Me.DsWALELEBindingSource.DataSource = Me.DsWALELE
        Me.DsWALELEBindingSource.Position = 0
        '
        'TESBENBindingSource
        '
        Me.TESBENBindingSource.DataMember = "TESBEN"
        Me.TESBENBindingSource.DataSource = Me.DsWALELEBindingSource
        '
        'TESBENTableAdapter
        '
        Me.TESBENTableAdapter.ClearBeforeFill = True
        '
        'BENRUTDataGridViewTextBoxColumn
        '
        Me.BENRUTDataGridViewTextBoxColumn.DataPropertyName = "BEN_RUT"
        Me.BENRUTDataGridViewTextBoxColumn.HeaderText = "RUT"
        Me.BENRUTDataGridViewTextBoxColumn.Name = "BENRUTDataGridViewTextBoxColumn"
        Me.BENRUTDataGridViewTextBoxColumn.ReadOnly = True
        Me.BENRUTDataGridViewTextBoxColumn.Visible = False
        '
        'BENNOMBREDataGridViewTextBoxColumn
        '
        Me.BENNOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BENNOMBREDataGridViewTextBoxColumn.DataPropertyName = "BEN_NOMBRE"
        Me.BENNOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.BENNOMBREDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.BENNOMBREDataGridViewTextBoxColumn.Name = "BENNOMBREDataGridViewTextBoxColumn"
        Me.BENNOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione la entidad a eliminar y presione la tecla Supr/Del"
        '
        'frmWALELE00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(488, 458)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALELE00"
        Me.Text = "Eliminación de entidades habituales"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALELE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALELEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsWALELEBindingSource As BindingSource
    Friend WithEvents DsWALELE As dsWALELE
    Friend WithEvents TESBENBindingSource As BindingSource
    Friend WithEvents TESBENTableAdapter As dsWALELETableAdapters.TESBENTableAdapter
    Friend WithEvents BENRUTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BENNOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
