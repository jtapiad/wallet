<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEGPER00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSEGPER00))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnFiniquitar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.lstPerfiles = New System.Windows.Forms.ListBox()
        Me.SEGPERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSEGPER = New Wallet.dsSEGPER()
        Me.SEGPERTableAdapter = New Wallet.dsSEGPERTableAdapters.SEGPERTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar, Me.btnModificar, Me.btnFiniquitar, Me.btnExcel, Me.btnRefrescar, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(530, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 22)
        Me.btnModificar.Text = "&Modificar"
        '
        'btnFiniquitar
        '
        Me.btnFiniquitar.Image = CType(resources.GetObject("btnFiniquitar.Image"), System.Drawing.Image)
        Me.btnFiniquitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFiniquitar.Name = "btnFiniquitar"
        Me.btnFiniquitar.Size = New System.Drawing.Size(73, 22)
        Me.btnFiniquitar.Text = "Borrar"
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(92, 22)
        Me.btnExcel.Text = "Exportar"
        Me.btnExcel.ToolTipText = "Exportar a Excel"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(96, 22)
        Me.btnRefrescar.Text = "Refrescar"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(58, 22)
        Me.btnSalir.Text = "Salir"
        '
        'lstPerfiles
        '
        Me.lstPerfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPerfiles.DataSource = Me.SEGPERBindingSource
        Me.lstPerfiles.DisplayMember = "SEGPER_PERFIL"
        Me.lstPerfiles.FormattingEnabled = True
        Me.lstPerfiles.ItemHeight = 16
        Me.lstPerfiles.Location = New System.Drawing.Point(12, 45)
        Me.lstPerfiles.Name = "lstPerfiles"
        Me.lstPerfiles.Size = New System.Drawing.Size(506, 324)
        Me.lstPerfiles.TabIndex = 0
        Me.lstPerfiles.ValueMember = "SEGPER_CODIGO"
        '
        'SEGPERBindingSource
        '
        Me.SEGPERBindingSource.DataMember = "SEGPER"
        Me.SEGPERBindingSource.DataSource = Me.DsSEGPER
        '
        'DsSEGPER
        '
        Me.DsSEGPER.DataSetName = "dsSEGPER"
        Me.DsSEGPER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SEGPERTableAdapter
        '
        Me.SEGPERTableAdapter.ClearBeforeFill = True
        '
        'frmSEGPER00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(530, 387)
        Me.Controls.Add(Me.lstPerfiles)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(548, 374)
        Me.Name = "frmSEGPER00"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfiles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFiniquitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkBorrados As System.Windows.Forms.CheckBox
    Friend WithEvents lstPerfiles As System.Windows.Forms.ListBox
    Friend WithEvents DsSEGPER As Wallet.dsSEGPER
    Friend WithEvents SEGPERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEGPERTableAdapter As Wallet.dsSEGPERTableAdapters.SEGPERTableAdapter
End Class
