<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALRDE00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALRDE00))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCuentasCorrientes = New System.Windows.Forms.ComboBox()
        Me.CuentasUnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALPLA = New Wallet.dsWALPLA()
        Me.cbColumnas = New System.Windows.Forms.ComboBox()
        Me.TESCOLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbTodasCta = New System.Windows.Forms.CheckBox()
        Me.cbTodasCol = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbImprimir1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir2 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TESCOLTableAdapter = New Wallet.dsWALPLATableAdapters.TESCOLTableAdapter()
        Me.CuentasUnoTableAdapter = New Wallet.dsWALPLATableAdapters.CuentasUnoTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CuentasUnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESCOLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCuentasCorrientes)
        Me.GroupBox1.Controls.Add(Me.cbColumnas)
        Me.GroupBox1.Controls.Add(Me.cbTodasCta)
        Me.GroupBox1.Controls.Add(Me.cbTodasCol)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'cbCuentasCorrientes
        '
        Me.cbCuentasCorrientes.DataSource = Me.CuentasUnoBindingSource
        Me.cbCuentasCorrientes.DisplayMember = "largo"
        Me.cbCuentasCorrientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentasCorrientes.FormattingEnabled = True
        Me.cbCuentasCorrientes.Location = New System.Drawing.Point(110, 69)
        Me.cbCuentasCorrientes.Name = "cbCuentasCorrientes"
        Me.cbCuentasCorrientes.Size = New System.Drawing.Size(248, 21)
        Me.cbCuentasCorrientes.TabIndex = 7
        Me.cbCuentasCorrientes.ValueMember = "CTE_CODIGO"
        '
        'CuentasUnoBindingSource
        '
        Me.CuentasUnoBindingSource.DataMember = "CuentasUno"
        Me.CuentasUnoBindingSource.DataSource = Me.DsWALPLA
        '
        'DsWALPLA
        '
        Me.DsWALPLA.DataSetName = "dsWALPLA"
        Me.DsWALPLA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbColumnas
        '
        Me.cbColumnas.DataSource = Me.TESCOLBindingSource
        Me.cbColumnas.DisplayMember = "COL_NOMBRE"
        Me.cbColumnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColumnas.FormattingEnabled = True
        Me.cbColumnas.Location = New System.Drawing.Point(110, 42)
        Me.cbColumnas.Name = "cbColumnas"
        Me.cbColumnas.Size = New System.Drawing.Size(248, 21)
        Me.cbColumnas.TabIndex = 6
        Me.cbColumnas.ValueMember = "COL_CODIGO"
        '
        'TESCOLBindingSource
        '
        Me.TESCOLBindingSource.DataMember = "TESCOL"
        Me.TESCOLBindingSource.DataSource = Me.DsWALPLA
        '
        'cbTodasCta
        '
        Me.cbTodasCta.AutoSize = True
        Me.cbTodasCta.Location = New System.Drawing.Point(191, 108)
        Me.cbTodasCta.Name = "cbTodasCta"
        Me.cbTodasCta.Size = New System.Drawing.Size(164, 17)
        Me.cbTodasCta.TabIndex = 5
        Me.cbTodasCta.Text = "Todas las Cuentas Corrientes"
        Me.cbTodasCta.UseVisualStyleBackColor = True
        '
        'cbTodasCol
        '
        Me.cbTodasCol.AutoSize = True
        Me.cbTodasCol.Location = New System.Drawing.Point(14, 108)
        Me.cbTodasCol.Name = "cbTodasCol"
        Me.cbTodasCol.Size = New System.Drawing.Size(121, 17)
        Me.cbTodasCol.TabIndex = 4
        Me.cbTodasCol.Text = "Todas las Columnas"
        Me.cbTodasCol.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cuentas Corrientes :"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(110, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(248, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Columna :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Planilla :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbImprimir1, Me.tsbImprimir2, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(397, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbImprimir1
        '
        Me.tsbImprimir1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir1.Image = Global.Wallet.My.Resources.Resources.Print
        Me.tsbImprimir1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir1.Name = "tsbImprimir1"
        Me.tsbImprimir1.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir1.Text = "Imprimir detalles de movimientos"
        '
        'tsbImprimir2
        '
        Me.tsbImprimir2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir2.Image = Global.Wallet.My.Resources.Resources.Print_preview
        Me.tsbImprimir2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir2.Name = "tsbImprimir2"
        Me.tsbImprimir2.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir2.Text = "Imprimir detalles de movimientos por Caja"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir de la Funcionalidad"
        '
        'TESCOLTableAdapter
        '
        Me.TESCOLTableAdapter.ClearBeforeFill = True
        '
        'CuentasUnoTableAdapter
        '
        Me.CuentasUnoTableAdapter.ClearBeforeFill = True
        '
        'frmWALRDE00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 194)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALRDE00"
        Me.Text = "Detalle de Movimientos de Planillas de Otros días"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CuentasUnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPLA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESCOLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbCuentasCorrientes As ComboBox
    Friend WithEvents cbColumnas As ComboBox
    Friend WithEvents cbTodasCta As CheckBox
    Friend WithEvents cbTodasCol As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbImprimir1 As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents DsWALPLA As dsWALPLA
    Friend WithEvents TESCOLBindingSource As BindingSource
    Friend WithEvents TESCOLTableAdapter As dsWALPLATableAdapters.TESCOLTableAdapter
    Friend WithEvents CuentasUnoBindingSource As BindingSource
    Friend WithEvents CuentasUnoTableAdapter As dsWALPLATableAdapters.CuentasUnoTableAdapter
    Friend WithEvents tsbImprimir2 As ToolStripButton
End Class
