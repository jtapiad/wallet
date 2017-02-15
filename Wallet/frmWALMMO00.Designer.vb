<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALMMO00
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
        Dim DOP_GLOSAADICLabel As System.Windows.Forms.Label
        Dim DOP_MONTOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALMMO00))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DOP_MONTOTextBox = New System.Windows.Forms.TextBox()
        Me.TESDOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALPLA1 = New Wallet.dsWALPLA()
        Me.DOP_GLOSAADICTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TESDOPTableAdapter = New Wallet.dsWALPLATableAdapters.TESDOPTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALPLATableAdapters.TableAdapterManager()
        DOP_GLOSAADICLabel = New System.Windows.Forms.Label()
        DOP_MONTOLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TESDOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALPLA1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DOP_GLOSAADICLabel
        '
        DOP_GLOSAADICLabel.AutoSize = True
        DOP_GLOSAADICLabel.Location = New System.Drawing.Point(6, 28)
        DOP_GLOSAADICLabel.Name = "DOP_GLOSAADICLabel"
        DOP_GLOSAADICLabel.Size = New System.Drawing.Size(86, 13)
        DOP_GLOSAADICLabel.TabIndex = 0
        DOP_GLOSAADICLabel.Text = "Glosa Adicional :"
        '
        'DOP_MONTOLabel
        '
        DOP_MONTOLabel.AutoSize = True
        DOP_MONTOLabel.Location = New System.Drawing.Point(49, 61)
        DOP_MONTOLabel.Name = "DOP_MONTOLabel"
        DOP_MONTOLabel.Size = New System.Drawing.Size(43, 13)
        DOP_MONTOLabel.TabIndex = 2
        DOP_MONTOLabel.Text = "Monto :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DOP_MONTOLabel)
        Me.GroupBox1.Controls.Add(Me.DOP_MONTOTextBox)
        Me.GroupBox1.Controls.Add(DOP_GLOSAADICLabel)
        Me.GroupBox1.Controls.Add(Me.DOP_GLOSAADICTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'DOP_MONTOTextBox
        '
        Me.DOP_MONTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESDOPBindingSource, "DOP_MONTO", True))
        Me.DOP_MONTOTextBox.Location = New System.Drawing.Point(102, 58)
        Me.DOP_MONTOTextBox.Name = "DOP_MONTOTextBox"
        Me.DOP_MONTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DOP_MONTOTextBox.TabIndex = 3
        '
        'TESDOPBindingSource
        '
        Me.TESDOPBindingSource.DataMember = "TESDOP"
        Me.TESDOPBindingSource.DataSource = Me.DsWALPLA1
        '
        'DsWALPLA1
        '
        Me.DsWALPLA1.DataSetName = "dsWALPLA"
        Me.DsWALPLA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DOP_GLOSAADICTextBox
        '
        Me.DOP_GLOSAADICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TESDOPBindingSource, "DOP_GLOSAADIC", True))
        Me.DOP_GLOSAADICTextBox.Location = New System.Drawing.Point(102, 25)
        Me.DOP_GLOSAADICTextBox.MaxLength = 50
        Me.DOP_GLOSAADICTextBox.Name = "DOP_GLOSAADICTextBox"
        Me.DOP_GLOSAADICTextBox.Size = New System.Drawing.Size(164, 20)
        Me.DOP_GLOSAADICTextBox.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(296, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = Global.Wallet.My.Resources.Resources.Accept
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Text = "Grabar"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "ToolStripButton2"
        '
        'TESDOPTableAdapter
        '
        Me.TESDOPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetallePlanillaTableAdapter = Nothing
        Me.TableAdapterManager.TESCHATableAdapter = Nothing
        Me.TableAdapterManager.TESCLCTableAdapter = Nothing
        Me.TableAdapterManager.TESCTETableAdapter = Nothing
        Me.TableAdapterManager.TESDCLTableAdapter = Nothing
        Me.TableAdapterManager.TESDOPTableAdapter = Me.TESDOPTableAdapter
        Me.TableAdapterManager.TESENTTableAdapter = Nothing
        Me.TableAdapterManager.TESFONTableAdapter = Nothing
        Me.TableAdapterManager.TESGLOTableAdapter = Nothing
        Me.TableAdapterManager.TESINFTableAdapter = Nothing
        Me.TableAdapterManager.TESPARTableAdapter = Nothing
        Me.TableAdapterManager.TESPLATableAdapter = Nothing
        Me.TableAdapterManager.TESUPATableAdapter = Nothing
        Me.TableAdapterManager.TraeDetalleMovimientosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALPLATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmWALMMO00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(296, 148)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWALMMO00"
        Me.Text = "Mantención de Movimentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TESDOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALPLA1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents DsWALPLA1 As dsWALPLA
    Friend WithEvents TESDOPBindingSource As BindingSource
    Friend WithEvents TESDOPTableAdapter As dsWALPLATableAdapters.TESDOPTableAdapter
    Friend WithEvents TableAdapterManager As dsWALPLATableAdapters.TableAdapterManager
    Friend WithEvents DOP_MONTOTextBox As TextBox
    Friend WithEvents DOP_GLOSAADICTextBox As TextBox
End Class
