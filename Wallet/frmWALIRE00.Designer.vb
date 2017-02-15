<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALIRE00
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
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsbOtro = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckbMillones = New System.Windows.Forms.CheckBox()
        Me.ckbPermanente = New System.Windows.Forms.CheckBox()
        Me.tbGlosa = New System.Windows.Forms.TextBox()
        Me.tbMonto = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabar, Me.tsbSalir, Me.tsbOtro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(296, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabar.Image = Global.Wallet.My.Resources.Resources.Accept
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabar.Text = "Actualiza el Movimiento"
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
        'tsbOtro
        '
        Me.tsbOtro.Name = "tsbOtro"
        Me.tsbOtro.Size = New System.Drawing.Size(50, 22)
        Me.tsbOtro.Text = "Otro"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ckbMillones)
        Me.GroupBox1.Controls.Add(Me.ckbPermanente)
        Me.GroupBox1.Controls.Add(Me.tbGlosa)
        Me.GroupBox1.Controls.Add(Me.tbMonto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 118)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Glosa :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Monto :"
        '
        'ckbMillones
        '
        Me.ckbMillones.AutoSize = True
        Me.ckbMillones.Checked = True
        Me.ckbMillones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbMillones.Location = New System.Drawing.Point(168, 28)
        Me.ckbMillones.Name = "ckbMillones"
        Me.ckbMillones.Size = New System.Drawing.Size(64, 17)
        Me.ckbMillones.TabIndex = 3
        Me.ckbMillones.Text = "Millones"
        Me.ckbMillones.UseVisualStyleBackColor = True
        '
        'ckbPermanente
        '
        Me.ckbPermanente.AutoSize = True
        Me.ckbPermanente.Location = New System.Drawing.Point(168, 10)
        Me.ckbPermanente.Name = "ckbPermanente"
        Me.ckbPermanente.Size = New System.Drawing.Size(83, 17)
        Me.ckbPermanente.TabIndex = 2
        Me.ckbPermanente.Text = "Permanente"
        Me.ckbPermanente.UseVisualStyleBackColor = True
        '
        'tbGlosa
        '
        Me.tbGlosa.Location = New System.Drawing.Point(62, 59)
        Me.tbGlosa.Multiline = True
        Me.tbGlosa.Name = "tbGlosa"
        Me.tbGlosa.Size = New System.Drawing.Size(204, 48)
        Me.tbGlosa.TabIndex = 1
        '
        'tbMonto
        '
        Me.tbMonto.Location = New System.Drawing.Point(62, 26)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Size = New System.Drawing.Size(100, 20)
        Me.tbMonto.TabIndex = 0
        Me.tbMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmWALIRE00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(296, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmWALIRE00"
        Me.Text = "Ingreso de Rescates"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ckbMillones As CheckBox
    Friend WithEvents ckbPermanente As CheckBox
    Friend WithEvents tbGlosa As TextBox
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents tsbGrabar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents tsbOtro As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
