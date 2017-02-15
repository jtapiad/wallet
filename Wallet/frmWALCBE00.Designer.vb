<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALCBE00
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TESBE2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALBEN = New Wallet.dsWALBEN()
        Me.TESBE2TableAdapter = New Wallet.dsWALBENTableAdapters.TESBE2TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TESBE2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(331, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Wallet.My.Resources.Resources._Exit
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Salir de la Funcionalidad"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.TESBE2BindingSource
        Me.ListBox1.DisplayMember = "BE2_RAZONSOCIAL"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(307, 316)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "BE2_RUT"
        '
        'TESBE2BindingSource
        '
        Me.TESBE2BindingSource.DataMember = "TESBE2"
        Me.TESBE2BindingSource.DataSource = Me.DsWALBEN
        '
        'DsWALBEN
        '
        Me.DsWALBEN.DataSetName = "dsWALBEN"
        Me.DsWALBEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESBE2TableAdapter
        '
        Me.TESBE2TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Haga doble click sobre el beneficiario que desea agregar a su lista"
        '
        'frmWALCBE00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(331, 384)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmWALCBE00"
        Me.Text = "Consulta Beneficiarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TESBE2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DsWALBEN As dsWALBEN
    Friend WithEvents TESBE2BindingSource As BindingSource
    Friend WithEvents TESBE2TableAdapter As dsWALBENTableAdapters.TESBE2TableAdapter
    Friend WithEvents Label1 As Label
End Class
