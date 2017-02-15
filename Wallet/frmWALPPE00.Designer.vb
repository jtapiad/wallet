<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALPPE00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALPPE00))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbUtilizar = New System.Windows.Forms.ToolStripButton()
        Me.tsbNOUtilizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Tipo_Movimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Monto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Columna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Key = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbCartola = New System.Windows.Forms.RadioButton()
        Me.rbCaja = New System.Windows.Forms.RadioButton()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.CuentasPlanillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALPPE = New Wallet.dsWALPPE()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cuentas_PlanillaTableAdapter = New Wallet.dsWALPPETableAdapters.Cuentas_PlanillaTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        CType(Me.CuentasPlanillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPPE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbUtilizar, Me.tsbNOUtilizar, Me.ToolStripSeparator2, Me.tsbSalir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(476, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbUtilizar
        '
        Me.tsbUtilizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbUtilizar.Image = Global.Wallet.My.Resources.Resources.Accept
        Me.tsbUtilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUtilizar.Name = "tsbUtilizar"
        Me.tsbUtilizar.Size = New System.Drawing.Size(23, 22)
        Me.tsbUtilizar.Text = "Utilizar las Partidas Pendientes"
        '
        'tsbNOUtilizar
        '
        Me.tsbNOUtilizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNOUtilizar.Image = Global.Wallet.My.Resources.Resources.Delete
        Me.tsbNOUtilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNOUtilizar.Name = "tsbNOUtilizar"
        Me.tsbNOUtilizar.Size = New System.Drawing.Size(23, 22)
        Me.tsbNOUtilizar.Text = "NO Utilizar las Partidas Pendientes"
        Me.tsbNOUtilizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir sin generar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 335)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Partidas Pendientes"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Tipo_Movimiento, Me.Monto, Me.Columna, Me.Key})
        Me.ListView1.Location = New System.Drawing.Point(3, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(443, 313)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Tipo_Movimiento
        '
        Me.Tipo_Movimiento.Text = "Tipo de Movimientor"
        Me.Tipo_Movimiento.Width = 200
        '
        'Monto
        '
        Me.Monto.Text = "Monto"
        Me.Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Monto.Width = 100
        '
        'Columna
        '
        Me.Columna.Text = "Columna"
        Me.Columna.Width = 150
        '
        'Key
        '
        Me.Key.Text = "Clave"
        Me.Key.Width = 0
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbCartola)
        Me.gbTipo.Controls.Add(Me.rbCaja)
        Me.gbTipo.Location = New System.Drawing.Point(319, 28)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(145, 42)
        Me.gbTipo.TabIndex = 2
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo"
        '
        'rbCartola
        '
        Me.rbCartola.AutoSize = True
        Me.rbCartola.Checked = True
        Me.rbCartola.Location = New System.Drawing.Point(77, 16)
        Me.rbCartola.Name = "rbCartola"
        Me.rbCartola.Size = New System.Drawing.Size(58, 17)
        Me.rbCartola.TabIndex = 1
        Me.rbCartola.TabStop = True
        Me.rbCartola.Text = "Cartola"
        Me.rbCartola.UseVisualStyleBackColor = True
        '
        'rbCaja
        '
        Me.rbCaja.AutoSize = True
        Me.rbCaja.Location = New System.Drawing.Point(14, 16)
        Me.rbCaja.Name = "rbCaja"
        Me.rbCaja.Size = New System.Drawing.Size(46, 17)
        Me.rbCaja.TabIndex = 0
        Me.rbCaja.Text = "Caja"
        Me.rbCaja.UseVisualStyleBackColor = True
        '
        'cbBancos
        '
        Me.cbBancos.DataSource = Me.CuentasPlanillaBindingSource
        Me.cbBancos.DisplayMember = "ENT_ABREVIATURA"
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(118, 39)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(179, 21)
        Me.cbBancos.TabIndex = 3
        Me.cbBancos.ValueMember = "CTE_CONTABLE"
        '
        'CuentasPlanillaBindingSource
        '
        Me.CuentasPlanillaBindingSource.DataMember = "Cuentas_Planilla"
        Me.CuentasPlanillaBindingSource.DataSource = Me.DsWALPPE
        '
        'DsWALPPE
        '
        Me.DsWALPPE.DataSetName = "dsWALPPE"
        Me.DsWALPPE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione Cuenta :"
        '
        'Cuentas_PlanillaTableAdapter
        '
        Me.Cuentas_PlanillaTableAdapter.ClearBeforeFill = True
        '
        'frmWALPPE00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(476, 423)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALPPE00"
        Me.Text = "Proceso de Partidas Pendientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        CType(Me.CuentasPlanillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPPE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tsbUtilizar As ToolStripButton
    Friend WithEvents tsbNOUtilizar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents gbTipo As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents rbCartola As RadioButton
    Friend WithEvents rbCaja As RadioButton
    Friend WithEvents cbBancos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DsWALPPE As dsWALPPE
    Friend WithEvents CuentasPlanillaBindingSource As BindingSource
    Friend WithEvents Cuentas_PlanillaTableAdapter As dsWALPPETableAdapters.Cuentas_PlanillaTableAdapter
    Friend WithEvents Tipo_Movimiento As ColumnHeader
    Friend WithEvents Monto As ColumnHeader
    Friend WithEvents Columna As ColumnHeader
    Friend WithEvents Key As ColumnHeader
End Class
