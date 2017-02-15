<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALDRE00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALDRE00))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCajas = New System.Windows.Forms.ComboBox()
        Me.TraeCajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALREP = New Wallet.dsWALREP()
        Me.cbTodas = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Trae_CajasTableAdapter = New Wallet.dsWALREPTableAdapters.Trae_CajasTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TraeCajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALREP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Wallet.My.Resources.Resources.Print
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 221)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cbCajas)
        Me.GroupBox4.Controls.Add(Me.cbTodas)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 82)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cajas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione Caja a Listar :"
        '
        'cbCajas
        '
        Me.cbCajas.DataSource = Me.TraeCajasBindingSource
        Me.cbCajas.DisplayMember = "DAZ_CAJA"
        Me.cbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCajas.Enabled = False
        Me.cbCajas.FormattingEnabled = True
        Me.cbCajas.Location = New System.Drawing.Point(140, 42)
        Me.cbCajas.Name = "cbCajas"
        Me.cbCajas.Size = New System.Drawing.Size(102, 21)
        Me.cbCajas.TabIndex = 1
        Me.cbCajas.ValueMember = "DAZ_CAJA"
        '
        'TraeCajasBindingSource
        '
        Me.TraeCajasBindingSource.DataMember = "Trae_Cajas"
        Me.TraeCajasBindingSource.DataSource = Me.DsWALREP
        '
        'DsWALREP
        '
        Me.DsWALREP.DataSetName = "dsWALREP"
        Me.DsWALREP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbTodas
        '
        Me.cbTodas.AutoSize = True
        Me.cbTodas.Checked = True
        Me.cbTodas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTodas.Location = New System.Drawing.Point(52, 19)
        Me.cbTodas.Name = "cbTodas"
        Me.cbTodas.Size = New System.Drawing.Size(101, 17)
        Me.cbTodas.TabIndex = 0
        Me.cbTodas.Text = "Todas las Cajas"
        Me.cbTodas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpFinal)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 55)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha Final"
        '
        'dtpFinal
        '
        Me.dtpFinal.Location = New System.Drawing.Point(25, 21)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(200, 20)
        Me.dtpFinal.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpInicio)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 55)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Inicial"
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(25, 23)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpInicio.TabIndex = 1
        '
        'Trae_CajasTableAdapter
        '
        Me.Trae_CajasTableAdapter.ClearBeforeFill = True
        '
        'frmWALDRE00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWALDRE00"
        Me.Text = "Distribución Recaudación"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TraeCajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALREP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCajas As ComboBox
    Friend WithEvents cbTodas As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents TraeCajasBindingSource As BindingSource
    Friend WithEvents DsWALREP As dsWALREP
    Friend WithEvents Trae_CajasTableAdapter As dsWALREPTableAdapters.Trae_CajasTableAdapter
End Class
