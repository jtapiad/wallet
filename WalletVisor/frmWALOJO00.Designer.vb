<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALOJO00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALOJO00))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbMover = New System.Windows.Forms.PictureBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.lbAviso = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbMover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pbMover)
        Me.Panel1.Controls.Add(Me.btSalir)
        Me.Panel1.Controls.Add(Me.lbAviso)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 70)
        Me.Panel1.TabIndex = 1
        '
        'pbMover
        '
        Me.pbMover.Image = Global.WalletVisor.My.Resources.Resources.Resize_Four_Directions_24
        Me.pbMover.Location = New System.Drawing.Point(4, 3)
        Me.pbMover.Name = "pbMover"
        Me.pbMover.Size = New System.Drawing.Size(21, 22)
        Me.pbMover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMover.TabIndex = 3
        Me.pbMover.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbMover, "Drag para mover la barra")
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(377, 43)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(14, 20)
        Me.btSalir.TabIndex = 2
        Me.btSalir.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btSalir, "Salir del Visor")
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'lbAviso
        '
        Me.lbAviso.BackColor = System.Drawing.Color.LightYellow
        Me.lbAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAviso.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbAviso.Location = New System.Drawing.Point(-2, 0)
        Me.lbAviso.Name = "lbAviso"
        Me.lbAviso.Size = New System.Drawing.Size(397, 65)
        Me.lbAviso.TabIndex = 1
        Me.lbAviso.Text = "Tienes n Cheques por Emitir"
        Me.lbAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'frmWALOJO00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 70)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWALOJO00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWALOJO00"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbMover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbAviso As Label
    Friend WithEvents btSalir As Button
    Friend WithEvents pbMover As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
End Class
