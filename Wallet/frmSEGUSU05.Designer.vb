<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEGUSU05
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSEGUSU05))
        Me.tsPass = New System.Windows.Forms.ToolStrip()
        Me.tsbAcepta = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancela = New System.Windows.Forms.ToolStripButton()
        Me.gbPassNueva = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbPass2 = New System.Windows.Forms.TextBox()
        Me.tbPass1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPassActual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbPassActual = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tsPass.SuspendLayout()
        Me.gbPassNueva.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPassActual.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsPass
        '
        Me.tsPass.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAcepta, Me.tsbCancela})
        Me.tsPass.Location = New System.Drawing.Point(0, 0)
        Me.tsPass.Name = "tsPass"
        Me.tsPass.Size = New System.Drawing.Size(349, 25)
        Me.tsPass.TabIndex = 6
        Me.tsPass.Text = "ToolStrip1"
        '
        'tsbAcepta
        '
        Me.tsbAcepta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAcepta.Image = CType(resources.GetObject("tsbAcepta.Image"), System.Drawing.Image)
        Me.tsbAcepta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAcepta.Name = "tsbAcepta"
        Me.tsbAcepta.Size = New System.Drawing.Size(23, 22)
        Me.tsbAcepta.Text = "ToolStripButton1"
        '
        'tsbCancela
        '
        Me.tsbCancela.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancela.Image = CType(resources.GetObject("tsbCancela.Image"), System.Drawing.Image)
        Me.tsbCancela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancela.Name = "tsbCancela"
        Me.tsbCancela.Size = New System.Drawing.Size(23, 22)
        Me.tsbCancela.Text = "ToolStripButton2"
        '
        'gbPassNueva
        '
        Me.gbPassNueva.Controls.Add(Me.Label3)
        Me.gbPassNueva.Controls.Add(Me.TbPass2)
        Me.gbPassNueva.Controls.Add(Me.tbPass1)
        Me.gbPassNueva.Controls.Add(Me.Label2)
        Me.gbPassNueva.Controls.Add(Me.Label1)
        Me.gbPassNueva.Enabled = False
        Me.gbPassNueva.Location = New System.Drawing.Point(12, 140)
        Me.gbPassNueva.Name = "gbPassNueva"
        Me.gbPassNueva.Size = New System.Drawing.Size(323, 143)
        Me.gbPassNueva.TabIndex = 7
        Me.gbPassNueva.TabStop = False
        Me.gbPassNueva.Text = "Nueva Contraseña"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 39)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ingrese una contaseña de al menos 5 caracteres. No la comparta ni la escriba dond" &
    "e pueda ser vista."
        '
        'TbPass2
        '
        Me.TbPass2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbPass2.Location = New System.Drawing.Point(177, 104)
        Me.TbPass2.Name = "TbPass2"
        Me.TbPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPass2.Size = New System.Drawing.Size(115, 20)
        Me.TbPass2.TabIndex = 8
        '
        'tbPass1
        '
        Me.tbPass1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPass1.Location = New System.Drawing.Point(177, 69)
        Me.tbPass1.Name = "tbPass1"
        Me.tbPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass1.Size = New System.Drawing.Size(115, 20)
        Me.tbPass1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Reingrese Nueva Contraseña :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese Nueva Contraseña :"
        '
        'tbPassActual
        '
        Me.tbPassActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPassActual.Location = New System.Drawing.Point(177, 57)
        Me.tbPassActual.Name = "tbPassActual"
        Me.tbPassActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassActual.Size = New System.Drawing.Size(94, 20)
        Me.tbPassActual.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ingrese Contraseña Actual:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'gbPassActual
        '
        Me.gbPassActual.Controls.Add(Me.Button1)
        Me.gbPassActual.Controls.Add(Me.Label5)
        Me.gbPassActual.Controls.Add(Me.Label4)
        Me.gbPassActual.Controls.Add(Me.tbPassActual)
        Me.gbPassActual.Location = New System.Drawing.Point(12, 28)
        Me.gbPassActual.Name = "gbPassActual"
        Me.gbPassActual.Size = New System.Drawing.Size(323, 106)
        Me.gbPassActual.TabIndex = 11
        Me.gbPassActual.TabStop = False
        Me.gbPassActual.Text = "Contraseña actual"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(283, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 22)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ingrese su contaseña actual y presione el botón para revisar"
        '
        'frmSEGUSU05
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 296)
        Me.Controls.Add(Me.gbPassActual)
        Me.Controls.Add(Me.gbPassNueva)
        Me.Controls.Add(Me.tsPass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSEGUSU05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambio Contraseña"
        Me.tsPass.ResumeLayout(False)
        Me.tsPass.PerformLayout()
        Me.gbPassNueva.ResumeLayout(False)
        Me.gbPassNueva.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPassActual.ResumeLayout(False)
        Me.gbPassActual.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsPass As ToolStrip
    Friend WithEvents tsbAcepta As ToolStripButton
    Friend WithEvents tsbCancela As ToolStripButton
    Friend WithEvents gbPassNueva As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbPass2 As TextBox
    Friend WithEvents tbPass1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPassActual As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents gbPassActual As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
