<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALINV00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALINV00))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbDesc = New System.Windows.Forms.CheckBox()
        Me.rbFechaVen = New System.Windows.Forms.RadioButton()
        Me.rbInstFin = New System.Windows.Forms.RadioButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbImprimir, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(281, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir.Image = Global.Wallet.My.Resources.Resources.Print
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir.Text = "Emitir el Reporte"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(265, 146)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha a Listar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbDesc)
        Me.GroupBox2.Controls.Add(Me.rbFechaVen)
        Me.GroupBox2.Controls.Add(Me.rbInstFin)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 50)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(229, 80)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenado Por"
        '
        'cbDesc
        '
        Me.cbDesc.AutoSize = True
        Me.cbDesc.Location = New System.Drawing.Point(24, 58)
        Me.cbDesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbDesc.Name = "cbDesc"
        Me.cbDesc.Size = New System.Drawing.Size(90, 17)
        Me.cbDesc.TabIndex = 2
        Me.cbDesc.Text = "Descendente"
        Me.cbDesc.UseVisualStyleBackColor = True
        '
        'rbFechaVen
        '
        Me.rbFechaVen.AutoSize = True
        Me.rbFechaVen.Location = New System.Drawing.Point(24, 38)
        Me.rbFechaVen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbFechaVen.Name = "rbFechaVen"
        Me.rbFechaVen.Size = New System.Drawing.Size(131, 17)
        Me.rbFechaVen.TabIndex = 1
        Me.rbFechaVen.Text = "Fecha de Vencimiento"
        Me.rbFechaVen.UseVisualStyleBackColor = True
        '
        'rbInstFin
        '
        Me.rbInstFin.AutoSize = True
        Me.rbInstFin.Checked = True
        Me.rbInstFin.Location = New System.Drawing.Point(24, 17)
        Me.rbInstFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbInstFin.Name = "rbInstFin"
        Me.rbInstFin.Size = New System.Drawing.Size(125, 17)
        Me.rbInstFin.TabIndex = 0
        Me.rbInstFin.TabStop = True
        Me.rbInstFin.Text = "Institución Financiera"
        Me.rbInstFin.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(16, 27)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(230, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'frmWALINV00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 185)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWALINV00"
        Me.Text = "Listado de Inversiones en Pesos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbImprimir As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbDesc As CheckBox
    Friend WithEvents rbFechaVen As RadioButton
    Friend WithEvents rbInstFin As RadioButton
End Class
