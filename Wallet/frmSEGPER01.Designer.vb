<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEGPER01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSEGPER01))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAcepta = New System.Windows.Forms.ToolStripButton()
        Me.btnCancela = New System.Windows.Forms.ToolStripButton()
        Me.OPPTreeView = New System.Windows.Forms.TreeView()
        Me.pnlSEGPER = New System.Windows.Forms.Panel()
        Me.SEGPER_PERFILTextBox = New System.Windows.Forms.TextBox()
        Me.SEGPERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSEGPER = New Wallet.dsSEGPER()
        Me.SEGPER_DESCRIPCIONTextBox = New System.Windows.Forms.TextBox()
        Me.pnlSEGOPC = New System.Windows.Forms.Panel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SEGPERTableAdapter = New Wallet.dsSEGPERTableAdapters.SEGPERTableAdapter()
        Me.TableAdapterManager = New Wallet.dsSEGPERTableAdapters.TableAdapterManager()
        SEGPER_PERFILLabel = New System.Windows.Forms.Label()
        SEGPER_DESCRIPCIONLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlSEGPER.SuspendLayout()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSEGOPC.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEGPER_PERFILLabel
        '
        SEGPER_PERFILLabel.AutoSize = True
        SEGPER_PERFILLabel.Location = New System.Drawing.Point(21, 20)
        SEGPER_PERFILLabel.Name = "SEGPER_PERFILLabel"
        SEGPER_PERFILLabel.Size = New System.Drawing.Size(125, 17)
        SEGPER_PERFILLabel.TabIndex = 0
        SEGPER_PERFILLabel.Text = "Nombre del Perfil :"
        '
        'SEGPER_DESCRIPCIONLabel
        '
        SEGPER_DESCRIPCIONLabel.AutoSize = True
        SEGPER_DESCRIPCIONLabel.Location = New System.Drawing.Point(56, 48)
        SEGPER_DESCRIPCIONLabel.Name = "SEGPER_DESCRIPCIONLabel"
        SEGPER_DESCRIPCIONLabel.Size = New System.Drawing.Size(90, 17)
        SEGPER_DESCRIPCIONLabel.TabIndex = 1
        SEGPER_DESCRIPCIONLabel.Text = "Descripción :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAcepta, Me.btnCancela})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(403, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAcepta
        '
        Me.btnAcepta.Image = CType(resources.GetObject("btnAcepta.Image"), System.Drawing.Image)
        Me.btnAcepta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAcepta.Name = "btnAcepta"
        Me.btnAcepta.Size = New System.Drawing.Size(79, 22)
        Me.btnAcepta.Text = "Acepta"
        '
        'btnCancela
        '
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(85, 22)
        Me.btnCancela.Text = "Cancela"
        '
        'OPPTreeView
        '
        Me.OPPTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OPPTreeView.CheckBoxes = True
        Me.OPPTreeView.Location = New System.Drawing.Point(3, 3)
        Me.OPPTreeView.Name = "OPPTreeView"
        Me.OPPTreeView.Size = New System.Drawing.Size(372, 320)
        Me.OPPTreeView.TabIndex = 0
        '
        'pnlSEGPER
        '
        Me.pnlSEGPER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSEGPER.Controls.Add(SEGPER_PERFILLabel)
        Me.pnlSEGPER.Controls.Add(Me.SEGPER_PERFILTextBox)
        Me.pnlSEGPER.Controls.Add(SEGPER_DESCRIPCIONLabel)
        Me.pnlSEGPER.Controls.Add(Me.SEGPER_DESCRIPCIONTextBox)
        Me.pnlSEGPER.Location = New System.Drawing.Point(13, 29)
        Me.pnlSEGPER.Name = "pnlSEGPER"
        Me.pnlSEGPER.Size = New System.Drawing.Size(378, 128)
        Me.pnlSEGPER.TabIndex = 0
        '
        'SEGPER_PERFILTextBox
        '
        Me.SEGPER_PERFILTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGPER_PERFILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGPERBindingSource, "SEGPER_PERFIL", True))
        Me.SEGPER_PERFILTextBox.Location = New System.Drawing.Point(152, 17)
        Me.SEGPER_PERFILTextBox.MaxLength = 30
        Me.SEGPER_PERFILTextBox.Name = "SEGPER_PERFILTextBox"
        Me.SEGPER_PERFILTextBox.Size = New System.Drawing.Size(208, 22)
        Me.SEGPER_PERFILTextBox.TabIndex = 0
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
        'SEGPER_DESCRIPCIONTextBox
        '
        Me.SEGPER_DESCRIPCIONTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEGPER_DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SEGPERBindingSource, "SEGPER_DESCRIPCION", True))
        Me.SEGPER_DESCRIPCIONTextBox.Location = New System.Drawing.Point(152, 45)
        Me.SEGPER_DESCRIPCIONTextBox.MaxLength = 100
        Me.SEGPER_DESCRIPCIONTextBox.Multiline = True
        Me.SEGPER_DESCRIPCIONTextBox.Name = "SEGPER_DESCRIPCIONTextBox"
        Me.SEGPER_DESCRIPCIONTextBox.Size = New System.Drawing.Size(208, 65)
        Me.SEGPER_DESCRIPCIONTextBox.TabIndex = 1
        '
        'pnlSEGOPC
        '
        Me.pnlSEGOPC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSEGOPC.Controls.Add(Me.OPPTreeView)
        Me.pnlSEGOPC.Location = New System.Drawing.Point(13, 173)
        Me.pnlSEGOPC.Name = "pnlSEGOPC"
        Me.pnlSEGOPC.Size = New System.Drawing.Size(378, 326)
        Me.pnlSEGOPC.TabIndex = 1
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'SEGPERTableAdapter
        '
        Me.SEGPERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SEGOPC1TableAdapter = Nothing
        Me.TableAdapterManager.SEGOPCTableAdapter = Nothing
        Me.TableAdapterManager.SEGOPPTableAdapter = Nothing
        Me.TableAdapterManager.SEGPERTableAdapter = Me.SEGPERTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsSEGPERTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmSEGPER01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(403, 512)
        Me.Controls.Add(Me.pnlSEGOPC)
        Me.Controls.Add(Me.pnlSEGPER)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSEGPER01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfiles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlSEGPER.ResumeLayout(False)
        Me.pnlSEGPER.PerformLayout()
        CType(Me.SEGPERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSEGPER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSEGOPC.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAcepta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancela As System.Windows.Forms.ToolStripButton
    Friend WithEvents OPPTreeView As System.Windows.Forms.TreeView
    Friend WithEvents pnlSEGPER As System.Windows.Forms.Panel
    Friend WithEvents DsSEGPER As Wallet.dsSEGPER
    Friend WithEvents SEGPERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SEGPERTableAdapter As Wallet.dsSEGPERTableAdapters.SEGPERTableAdapter
    Friend WithEvents TableAdapterManager As Wallet.dsSEGPERTableAdapters.TableAdapterManager
    Friend WithEvents SEGPER_PERFILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SEGPER_DESCRIPCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlSEGOPC As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
