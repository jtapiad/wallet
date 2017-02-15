<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim USU_SCREENLabel As System.Windows.Forms.Label
        Dim USU_PASSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SEGUSU_USERNAMETextBox = New System.Windows.Forms.TextBox()
        Me.SEGUSU_PASSWORDTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAcepta = New System.Windows.Forms.Button()
        Me.BtnCancela = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        USU_SCREENLabel = New System.Windows.Forms.Label()
        USU_PASSLabel = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USU_SCREENLabel
        '
        USU_SCREENLabel.AutoSize = True
        USU_SCREENLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        USU_SCREENLabel.Location = New System.Drawing.Point(29, 202)
        USU_SCREENLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        USU_SCREENLabel.Name = "USU_SCREENLabel"
        USU_SCREENLabel.Size = New System.Drawing.Size(64, 15)
        USU_SCREENLabel.TabIndex = 24
        USU_SCREENLabel.Text = "Usuario :"
        '
        'USU_PASSLabel
        '
        USU_PASSLabel.AutoSize = True
        USU_PASSLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        USU_PASSLabel.Location = New System.Drawing.Point(192, 202)
        USU_PASSLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        USU_PASSLabel.Name = "USU_PASSLabel"
        USU_PASSLabel.Size = New System.Drawing.Size(87, 15)
        USU_PASSLabel.TabIndex = 26
        USU_PASSLabel.Text = "Contraseña :"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'SEGUSU_USERNAMETextBox
        '
        Me.SEGUSU_USERNAMETextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SEGUSU_USERNAMETextBox.Location = New System.Drawing.Point(93, 199)
        Me.SEGUSU_USERNAMETextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SEGUSU_USERNAMETextBox.MaxLength = 32
        Me.SEGUSU_USERNAMETextBox.Name = "SEGUSU_USERNAMETextBox"
        Me.SEGUSU_USERNAMETextBox.Size = New System.Drawing.Size(80, 20)
        Me.SEGUSU_USERNAMETextBox.TabIndex = 0
        '
        'SEGUSU_PASSWORDTextBox
        '
        Me.SEGUSU_PASSWORDTextBox.Location = New System.Drawing.Point(283, 199)
        Me.SEGUSU_PASSWORDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SEGUSU_PASSWORDTextBox.MaxLength = 15
        Me.SEGUSU_PASSWORDTextBox.Name = "SEGUSU_PASSWORDTextBox"
        Me.SEGUSU_PASSWORDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SEGUSU_PASSWORDTextBox.Size = New System.Drawing.Size(80, 20)
        Me.SEGUSU_PASSWORDTextBox.TabIndex = 1
        '
        'BtnAcepta
        '
        Me.BtnAcepta.Image = CType(resources.GetObject("BtnAcepta.Image"), System.Drawing.Image)
        Me.BtnAcepta.Location = New System.Drawing.Point(394, 195)
        Me.BtnAcepta.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAcepta.Name = "BtnAcepta"
        Me.BtnAcepta.Size = New System.Drawing.Size(30, 30)
        Me.BtnAcepta.TabIndex = 2
        Me.BtnAcepta.UseVisualStyleBackColor = True
        '
        'BtnCancela
        '
        Me.BtnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancela.Image = Global.Wallet.My.Resources.Resources.No
        Me.BtnCancela.Location = New System.Drawing.Point(442, 195)
        Me.BtnCancela.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancela.Name = "BtnCancela"
        Me.BtnCancela.Size = New System.Drawing.Size(30, 30)
        Me.BtnCancela.TabIndex = 3
        Me.BtnCancela.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.ErrorImage = Nothing
        Me.pbLogo.InitialImage = Nothing
        Me.pbLogo.Location = New System.Drawing.Point(67, 40)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(393, 103)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 30
        Me.pbLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wallet.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(419, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(260, 151)
        Me.VersionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(39, 13)
        Me.VersionLabel.TabIndex = 37
        Me.VersionLabel.Text = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Wallet.My.Resources.Resources.Totem_Copec
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 194)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Wallet.My.Resources.Resources.Logo_02_Logo_Copec_Solo
        Me.PictureBox3.Location = New System.Drawing.Point(250, 118)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'LOGIN
        '
        Me.AcceptButton = Me.BtnAcepta
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnCancela
        Me.ClientSize = New System.Drawing.Size(505, 239)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.BtnCancela)
        Me.Controls.Add(Me.BtnAcepta)
        Me.Controls.Add(USU_PASSLabel)
        Me.Controls.Add(Me.SEGUSU_PASSWORDTextBox)
        Me.Controls.Add(USU_SCREENLabel)
        Me.Controls.Add(Me.SEGUSU_USERNAMETextBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnAcepta As System.Windows.Forms.Button
    Friend WithEvents BtnCancela As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents SEGUSU_PASSWORDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SEGUSU_USERNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
