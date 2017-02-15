<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWALBEN00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALBEN00))
        Me.tbBuscaBeneficiario = New System.Windows.Forms.TextBox()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.dgvBeneficiarios = New System.Windows.Forms.DataGridView()
        Me.BE2RUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BE2RAZONSOCIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BE2CODIGOSAPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TESBE2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALBEN = New Wallet.dsWALBEN()
        Me.TESBE2TableAdapter = New Wallet.dsWALBENTableAdapters.TESBE2TableAdapter()
        Me.TESBENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESBENTableAdapter = New Wallet.dsWALBENTableAdapters.TESBENTableAdapter()
        Me.TableAdapterManager = New Wallet.dsWALBENTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESBE2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbBuscaBeneficiario
        '
        Me.tbBuscaBeneficiario.Location = New System.Drawing.Point(12, 43)
        Me.tbBuscaBeneficiario.Name = "tbBuscaBeneficiario"
        Me.tbBuscaBeneficiario.Size = New System.Drawing.Size(320, 20)
        Me.tbBuscaBeneficiario.TabIndex = 0
        '
        'btnBusca
        '
        Me.btnBusca.BackgroundImage = Global.Wallet.My.Resources.Resources.Search1
        Me.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBusca.Location = New System.Drawing.Point(343, 40)
        Me.btnBusca.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(24, 24)
        Me.btnBusca.TabIndex = 3
        Me.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnBusca, "Busca")
        Me.btnBusca.UseVisualStyleBackColor = True
        '
        'dgvBeneficiarios
        '
        Me.dgvBeneficiarios.AllowUserToAddRows = False
        Me.dgvBeneficiarios.AllowUserToDeleteRows = False
        Me.dgvBeneficiarios.AllowUserToOrderColumns = True
        Me.dgvBeneficiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBeneficiarios.AutoGenerateColumns = False
        Me.dgvBeneficiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBeneficiarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeneficiarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BE2RUTDataGridViewTextBoxColumn, Me.BE2RAZONSOCIALDataGridViewTextBoxColumn, Me.BE2CODIGOSAPDataGridViewTextBoxColumn})
        Me.dgvBeneficiarios.DataSource = Me.TESBE2BindingSource
        Me.dgvBeneficiarios.Location = New System.Drawing.Point(13, 78)
        Me.dgvBeneficiarios.Name = "dgvBeneficiarios"
        Me.dgvBeneficiarios.ReadOnly = True
        Me.dgvBeneficiarios.RowHeadersWidth = 20
        Me.dgvBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBeneficiarios.Size = New System.Drawing.Size(354, 424)
        Me.dgvBeneficiarios.TabIndex = 4
        '
        'BE2RUTDataGridViewTextBoxColumn
        '
        Me.BE2RUTDataGridViewTextBoxColumn.DataPropertyName = "BE2_RUT"
        Me.BE2RUTDataGridViewTextBoxColumn.HeaderText = "RUT"
        Me.BE2RUTDataGridViewTextBoxColumn.Name = "BE2RUTDataGridViewTextBoxColumn"
        Me.BE2RUTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BE2RAZONSOCIALDataGridViewTextBoxColumn
        '
        Me.BE2RAZONSOCIALDataGridViewTextBoxColumn.DataPropertyName = "BE2_RAZONSOCIAL"
        Me.BE2RAZONSOCIALDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.BE2RAZONSOCIALDataGridViewTextBoxColumn.Name = "BE2RAZONSOCIALDataGridViewTextBoxColumn"
        Me.BE2RAZONSOCIALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BE2CODIGOSAPDataGridViewTextBoxColumn
        '
        Me.BE2CODIGOSAPDataGridViewTextBoxColumn.DataPropertyName = "BE2_CODIGOSAP"
        Me.BE2CODIGOSAPDataGridViewTextBoxColumn.HeaderText = "Código SAP"
        Me.BE2CODIGOSAPDataGridViewTextBoxColumn.Name = "BE2CODIGOSAPDataGridViewTextBoxColumn"
        Me.BE2CODIGOSAPDataGridViewTextBoxColumn.ReadOnly = True
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
        'TESBENBindingSource
        '
        Me.TESBENBindingSource.DataMember = "TESBEN"
        Me.TESBENBindingSource.DataSource = Me.DsWALBEN
        '
        'TESBENTableAdapter
        '
        Me.TESBENTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TESBE2TableAdapter = Me.TESBE2TableAdapter
        Me.TableAdapterManager.TESBENTableAdapter = Me.TESBENTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wallet.dsWALBENTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Haga doble clic sobre el beneficiario que desea agregar a su lista"
        '
        'frmWALBEN00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 514)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBeneficiarios)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.tbBuscaBeneficiario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALBEN00"
        Me.Text = "Mantención de Beneficiarios"
        CType(Me.dgvBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESBE2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALBEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESBENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbBuscaBeneficiario As TextBox
    Friend WithEvents btnBusca As Button
    Friend WithEvents dgvBeneficiarios As DataGridView
    Friend WithEvents DsWALBEN As dsWALBEN
    Friend WithEvents TESBE2BindingSource As BindingSource
    Friend WithEvents TESBE2TableAdapter As dsWALBENTableAdapters.TESBE2TableAdapter
    Friend WithEvents BE2RUTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BE2RAZONSOCIALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BE2CODIGOSAPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TESBENBindingSource As BindingSource
    Friend WithEvents TESBENTableAdapter As dsWALBENTableAdapters.TESBENTableAdapter
    Friend WithEvents TableAdapterManager As dsWALBENTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
