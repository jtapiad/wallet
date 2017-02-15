<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWALCOT00
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWALCOT00))
        Dim GridColumnDescriptor15 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim GridColumnDescriptor16 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim GridColumnDescriptor17 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim GridColumnDescriptor18 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim GridColumnDescriptor19 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim GridColumnDescriptor20 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim GridColumnDescriptor21 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbTasas = New System.Windows.Forms.GroupBox()
        Me.GridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.TasasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsWALCOT = New Wallet.dsWALCOT()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.tsbVerPizarra = New System.Windows.Forms.ToolStripButton()
        Me.tsbListar = New System.Windows.Forms.ToolStripButton()
        Me.gbEdicion = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTermino = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbExterno = New System.Windows.Forms.TextBox()
        Me.tbPropio = New System.Windows.Forms.TextBox()
        Me.tbEntidad = New System.Windows.Forms.TextBox()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.tsbGrabarTasa = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbFechas = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpaInicio = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpaTermino = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudeDias = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
        Me.mcaCalendario = New Syncfusion.Windows.Forms.Tools.MonthCalendarAdv()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.tscbTemas = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.rb15 = New Syncfusion.Windows.Forms.Tools.ToolStripRadioButton()
        Me.rb30 = New Syncfusion.Windows.Forms.Tools.ToolStripRadioButton()
        Me.rb60 = New Syncfusion.Windows.Forms.Tools.ToolStripRadioButton()
        Me.rb90 = New Syncfusion.Windows.Forms.Tools.ToolStripRadioButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tscbAbajo = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbEntidades = New System.Windows.Forms.GroupBox()
        Me.lvEntidades = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbBuscarEnt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsrbBancos = New Syncfusion.Windows.Forms.Tools.ToolStripRadioButton()
        Me.tsrbFondos = New Syncfusion.Windows.Forms.Tools.ToolStripRadioButton()
        Me.tscbSelTodos = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TasasTableAdapter = New Wallet.dsWALCOTTableAdapters.TasasTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.gbTasas.SuspendLayout()
        CType(Me.GridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsWALCOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        Me.gbEdicion.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gbFechas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaInicio.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtpaTermino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaTermino.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudeDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcaCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.gbEntidades.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1112, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir de la Funcionalidad"
        '
        'gbTasas
        '
        Me.gbTasas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTasas.Controls.Add(Me.GridGroupingControl1)
        Me.gbTasas.Controls.Add(Me.ToolStrip4)
        Me.gbTasas.Location = New System.Drawing.Point(3, 282)
        Me.gbTasas.Name = "gbTasas"
        Me.gbTasas.Size = New System.Drawing.Size(550, 273)
        Me.gbTasas.TabIndex = 6
        Me.gbTasas.TabStop = False
        Me.gbTasas.Text = "Tasas"
        '
        'GridGroupingControl1
        '
        Me.GridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.GridGroupingControl1.DataSource = Me.TasasBindingSource
        Me.GridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGroupingControl1.FreezeCaption = False
        Me.GridGroupingControl1.Location = New System.Drawing.Point(3, 41)
        Me.GridGroupingControl1.Name = "GridGroupingControl1"
        Me.GridGroupingControl1.Size = New System.Drawing.Size(544, 229)
        Me.GridGroupingControl1.TabIndex = 1
        Me.GridGroupingControl1.TableDescriptor.AllowEdit = False
        Me.GridGroupingControl1.TableDescriptor.AllowNew = False
        Me.GridGroupingControl1.TableDescriptor.AllowRemove = False
        GridColumnDescriptor15.HeaderImage = Nothing
        GridColumnDescriptor15.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left
        GridColumnDescriptor15.HeaderText = "Entidad"
        GridColumnDescriptor15.MappingName = "Nombre"
        GridColumnDescriptor15.SerializedImageArray = ""
        GridColumnDescriptor15.Width = 181
        GridColumnDescriptor16.HeaderImage = Nothing
        GridColumnDescriptor16.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left
        GridColumnDescriptor16.MappingName = "DIAS"
        GridColumnDescriptor16.SerializedImageArray = ""
        GridColumnDescriptor17.Appearance.AnyRecordFieldCell.Format = "N3"
        GridColumnDescriptor17.HeaderImage = Nothing
        GridColumnDescriptor17.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left
        GridColumnDescriptor17.MappingName = "F_P_"
        GridColumnDescriptor17.SerializedImageArray = ""
        GridColumnDescriptor17.Width = 59
        GridColumnDescriptor18.Appearance.AnyRecordFieldCell.Format = "N3"
        GridColumnDescriptor18.HeaderImage = Nothing
        GridColumnDescriptor18.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left
        GridColumnDescriptor18.MappingName = "F_E_"
        GridColumnDescriptor18.SerializedImageArray = ""
        GridColumnDescriptor19.Appearance.AnyRecordFieldCell.Format = "d"
        GridColumnDescriptor19.Appearance.AnyRecordFieldCell.MaskEdit.Mask = "ddd, dd/MMM/yyyy"
        GridColumnDescriptor19.Appearance.AnyRecordFieldCell.Text = ""
        GridColumnDescriptor19.HeaderImage = Nothing
        GridColumnDescriptor19.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left
        GridColumnDescriptor19.MappingName = "INICIO"
        GridColumnDescriptor19.SerializedImageArray = ""
        GridColumnDescriptor19.Width = 107
        GridColumnDescriptor20.Appearance.AnyRecordFieldCell.Format = "d"
        GridColumnDescriptor20.HeaderImage = Nothing
        GridColumnDescriptor20.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left
        GridColumnDescriptor20.MappingName = "TERMINO"
        GridColumnDescriptor20.SerializedImageArray = ""
        GridColumnDescriptor20.Width = 105
        GridColumnDescriptor21.HeaderImage = Nothing
        GridColumnDescriptor21.HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Left
        GridColumnDescriptor21.MappingName = "INGRESO"
        GridColumnDescriptor21.SerializedImageArray = ""
        Me.GridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {GridColumnDescriptor15, GridColumnDescriptor16, GridColumnDescriptor17, GridColumnDescriptor18, GridColumnDescriptor19, GridColumnDescriptor20, GridColumnDescriptor21})
        Me.GridGroupingControl1.TableDescriptor.SortedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("TERMINO", System.ComponentModel.ListSortDirection.Ascending)})
        Me.GridGroupingControl1.TableDescriptor.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One
        Me.GridGroupingControl1.Text = "GridGroupingControl1"
        Me.GridGroupingControl1.VersionInfo = "13.2451.0.29"
        '
        'TasasBindingSource
        '
        Me.TasasBindingSource.DataMember = "Tasas"
        Me.TasasBindingSource.DataSource = Me.DsWALCOT
        '
        'DsWALCOT
        '
        Me.DsWALCOT.DataSetName = "dsWALCOT"
        Me.DsWALCOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbVerPizarra, Me.tsbListar})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(544, 25)
        Me.ToolStrip4.TabIndex = 0
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'tsbVerPizarra
        '
        Me.tsbVerPizarra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbVerPizarra.Image = CType(resources.GetObject("tsbVerPizarra.Image"), System.Drawing.Image)
        Me.tsbVerPizarra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVerPizarra.Name = "tsbVerPizarra"
        Me.tsbVerPizarra.Size = New System.Drawing.Size(23, 22)
        Me.tsbVerPizarra.Text = "Visualizar Pizarra de Tasas Cotizadas"
        '
        'tsbListar
        '
        Me.tsbListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbListar.Image = CType(resources.GetObject("tsbListar.Image"), System.Drawing.Image)
        Me.tsbListar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbListar.Name = "tsbListar"
        Me.tsbListar.Size = New System.Drawing.Size(23, 22)
        Me.tsbListar.Text = "Listar Tasas"
        '
        'gbEdicion
        '
        Me.gbEdicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbEdicion.Controls.Add(Me.Label5)
        Me.gbEdicion.Controls.Add(Me.dtpTermino)
        Me.gbEdicion.Controls.Add(Me.dtpInicio)
        Me.gbEdicion.Controls.Add(Me.Label4)
        Me.gbEdicion.Controls.Add(Me.Label3)
        Me.gbEdicion.Controls.Add(Me.Label2)
        Me.gbEdicion.Controls.Add(Me.Label1)
        Me.gbEdicion.Controls.Add(Me.tbExterno)
        Me.gbEdicion.Controls.Add(Me.tbPropio)
        Me.gbEdicion.Controls.Add(Me.tbEntidad)
        Me.gbEdicion.Controls.Add(Me.ToolStrip5)
        Me.gbEdicion.Location = New System.Drawing.Point(559, 282)
        Me.gbEdicion.Name = "gbEdicion"
        Me.gbEdicion.Size = New System.Drawing.Size(550, 273)
        Me.gbEdicion.TabIndex = 7
        Me.gbEdicion.TabStop = False
        Me.gbEdicion.Text = "Edición de Tasas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fondo Externo"
        '
        'dtpTermino
        '
        Me.dtpTermino.Enabled = False
        Me.dtpTermino.Location = New System.Drawing.Point(121, 113)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(222, 20)
        Me.dtpTermino.TabIndex = 12
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Location = New System.Drawing.Point(121, 83)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(222, 20)
        Me.dtpInicio.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fondo Propio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha Término"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha de Inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Entidad/Fondo"
        '
        'tbExterno
        '
        Me.tbExterno.Location = New System.Drawing.Point(121, 173)
        Me.tbExterno.Name = "tbExterno"
        Me.tbExterno.Size = New System.Drawing.Size(63, 20)
        Me.tbExterno.TabIndex = 5
        Me.tbExterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPropio
        '
        Me.tbPropio.Location = New System.Drawing.Point(121, 143)
        Me.tbPropio.Name = "tbPropio"
        Me.tbPropio.Size = New System.Drawing.Size(63, 20)
        Me.tbPropio.TabIndex = 4
        Me.tbPropio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbEntidad
        '
        Me.tbEntidad.Enabled = False
        Me.tbEntidad.Location = New System.Drawing.Point(121, 53)
        Me.tbEntidad.Name = "tbEntidad"
        Me.tbEntidad.Size = New System.Drawing.Size(307, 20)
        Me.tbEntidad.TabIndex = 1
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGrabarTasa})
        Me.ToolStrip5.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(544, 25)
        Me.ToolStrip5.TabIndex = 0
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'tsbGrabarTasa
        '
        Me.tsbGrabarTasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGrabarTasa.Image = Global.Wallet.My.Resources.Resources.Save_as
        Me.tsbGrabarTasa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabarTasa.Name = "tsbGrabarTasa"
        Me.tsbGrabarTasa.Size = New System.Drawing.Size(23, 22)
        Me.tsbGrabarTasa.Text = "Graba la cotización de tasa"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.gbEdicion, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.gbTasas, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.gbFechas, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.gbEntidades, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1112, 558)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'gbFechas
        '
        Me.gbFechas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFechas.Controls.Add(Me.GroupBox2)
        Me.gbFechas.Controls.Add(Me.GroupBox3)
        Me.gbFechas.Controls.Add(Me.GroupBox1)
        Me.gbFechas.Controls.Add(Me.mcaCalendario)
        Me.gbFechas.Controls.Add(Me.ToolStrip3)
        Me.gbFechas.Location = New System.Drawing.Point(559, 3)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(550, 273)
        Me.gbFechas.TabIndex = 6
        Me.gbFechas.TabStop = False
        Me.gbFechas.Text = "Periodo de Inversión"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox2.Controls.Add(Me.dtpaInicio)
        Me.GroupBox2.Location = New System.Drawing.Point(-3, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 74)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inicio"
        '
        'dtpaInicio
        '
        Me.dtpaInicio.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtpaInicio.BorderColor = System.Drawing.Color.Empty
        Me.dtpaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpaInicio.Calendar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dtpaInicio.Calendar.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.dtpaInicio.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpaInicio.Calendar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtpaInicio.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
        Me.dtpaInicio.Calendar.Iso8601CalenderFormat = False
        Me.dtpaInicio.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.dtpaInicio.Calendar.Name = "monthCalendar"
        Me.dtpaInicio.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
        Me.dtpaInicio.Calendar.SelectedDates = New Date(-1) {}
        Me.dtpaInicio.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
        Me.dtpaInicio.Calendar.TabIndex = 0
        Me.dtpaInicio.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.dtpaInicio.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
        Me.dtpaInicio.Calendar.NoneButton.BackColor = System.Drawing.SystemColors.Window
        Me.dtpaInicio.Calendar.NoneButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.dtpaInicio.Calendar.NoneButton.IsBackStageButton = False
        Me.dtpaInicio.Calendar.NoneButton.Location = New System.Drawing.Point(78, 0)
        Me.dtpaInicio.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
        Me.dtpaInicio.Calendar.NoneButton.UseVisualStyle = True
        '
        '
        '
        Me.dtpaInicio.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
        Me.dtpaInicio.Calendar.TodayButton.BackColor = System.Drawing.SystemColors.Window
        Me.dtpaInicio.Calendar.TodayButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.dtpaInicio.Calendar.TodayButton.IsBackStageButton = False
        Me.dtpaInicio.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.dtpaInicio.Calendar.TodayButton.Size = New System.Drawing.Size(78, 20)
        Me.dtpaInicio.Calendar.TodayButton.UseVisualStyle = True
        Me.dtpaInicio.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpaInicio.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtpaInicio.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.dtpaInicio.CustomFormat = "dddd, dd-MMM-yyyy"
        Me.dtpaInicio.DropDownImage = Nothing
        Me.dtpaInicio.DropDownNormalColor = System.Drawing.SystemColors.Control
        Me.dtpaInicio.Enabled = False
        Me.dtpaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaInicio.Location = New System.Drawing.Point(12, 29)
        Me.dtpaInicio.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpaInicio.MinValue = New Date(CType(0, Long))
        Me.dtpaInicio.Name = "dtpaInicio"
        Me.dtpaInicio.ShowCheckBox = False
        Me.dtpaInicio.Size = New System.Drawing.Size(190, 20)
        Me.dtpaInicio.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
        Me.dtpaInicio.TabIndex = 3
        Me.dtpaInicio.Value = New Date(2016, 6, 2, 19, 57, 53, 469)
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox3.Controls.Add(Me.dtpaTermino)
        Me.GroupBox3.Location = New System.Drawing.Point(341, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 74)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Termino"
        '
        'dtpaTermino
        '
        Me.dtpaTermino.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtpaTermino.BorderColor = System.Drawing.Color.Empty
        Me.dtpaTermino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.dtpaTermino.Calendar.AllowMultipleSelection = False
        Me.dtpaTermino.Calendar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dtpaTermino.Calendar.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.dtpaTermino.Calendar.DaysFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.dtpaTermino.Calendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpaTermino.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpaTermino.Calendar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtpaTermino.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
        Me.dtpaTermino.Calendar.Iso8601CalenderFormat = False
        Me.dtpaTermino.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.dtpaTermino.Calendar.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpaTermino.Calendar.Name = "monthCalendar"
        Me.dtpaTermino.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
        Me.dtpaTermino.Calendar.SelectedDates = New Date(-1) {}
        Me.dtpaTermino.Calendar.Size = New System.Drawing.Size(185, 174)
        Me.dtpaTermino.Calendar.SizeToFit = True
        Me.dtpaTermino.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
        Me.dtpaTermino.Calendar.TabIndex = 0
        Me.dtpaTermino.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.dtpaTermino.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
        Me.dtpaTermino.Calendar.NoneButton.BackColor = System.Drawing.SystemColors.Window
        Me.dtpaTermino.Calendar.NoneButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.dtpaTermino.Calendar.NoneButton.IsBackStageButton = False
        Me.dtpaTermino.Calendar.NoneButton.Location = New System.Drawing.Point(113, 0)
        Me.dtpaTermino.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
        Me.dtpaTermino.Calendar.NoneButton.Text = "None"
        Me.dtpaTermino.Calendar.NoneButton.UseVisualStyle = True
        '
        '
        '
        Me.dtpaTermino.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.OfficeXP
        Me.dtpaTermino.Calendar.TodayButton.BackColor = System.Drawing.SystemColors.Window
        Me.dtpaTermino.Calendar.TodayButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.dtpaTermino.Calendar.TodayButton.IsBackStageButton = False
        Me.dtpaTermino.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.dtpaTermino.Calendar.TodayButton.Size = New System.Drawing.Size(113, 20)
        Me.dtpaTermino.Calendar.TodayButton.Text = "Today"
        Me.dtpaTermino.Calendar.TodayButton.UseVisualStyle = True
        Me.dtpaTermino.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpaTermino.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtpaTermino.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.dtpaTermino.CustomFormat = "dddd, dd-MMM-yyyy"
        Me.dtpaTermino.DropDownImage = Nothing
        Me.dtpaTermino.DropDownNormalColor = System.Drawing.SystemColors.Control
        Me.dtpaTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaTermino.Location = New System.Drawing.Point(7, 29)
        Me.dtpaTermino.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpaTermino.MinValue = New Date(CType(0, Long))
        Me.dtpaTermino.Name = "dtpaTermino"
        Me.dtpaTermino.ShowCheckBox = False
        Me.dtpaTermino.Size = New System.Drawing.Size(190, 20)
        Me.dtpaTermino.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
        Me.dtpaTermino.TabIndex = 4
        Me.dtpaTermino.Value = New Date(2016, 6, 2, 19, 57, 53, 469)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.Controls.Add(Me.nudeDias)
        Me.GroupBox1.Location = New System.Drawing.Point(215, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 74)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Días"
        '
        'nudeDias
        '
        Me.nudeDias.BeforeTouchSize = New System.Drawing.Size(79, 35)
        Me.nudeDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudeDias.Location = New System.Drawing.Point(19, 22)
        Me.nudeDias.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudeDias.MaxLength = 3
        Me.nudeDias.MetroColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.nudeDias.Name = "nudeDias"
        Me.nudeDias.Size = New System.Drawing.Size(79, 35)
        Me.nudeDias.TabIndex = 0
        '
        'mcaCalendario
        '
        Me.mcaCalendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcaCalendario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.mcaCalendario.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.mcaCalendario.DaysFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.mcaCalendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.mcaCalendario.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcaCalendario.HighlightColor = System.Drawing.Color.Black
        Me.mcaCalendario.Iso8601CalenderFormat = False
        Me.mcaCalendario.Location = New System.Drawing.Point(6, 44)
        Me.mcaCalendario.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.mcaCalendario.Name = "mcaCalendario"
        Me.mcaCalendario.SelectedDates = New Date() {New Date(2016, 7, 7, 0, 0, 0, 0)}
        Me.mcaCalendario.Size = New System.Drawing.Size(535, 143)
        Me.mcaCalendario.TabIndex = 1
        Me.mcaCalendario.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.mcaCalendario.NoneButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.mcaCalendario.NoneButton.IsBackStageButton = False
        Me.mcaCalendario.NoneButton.Location = New System.Drawing.Point(463, 0)
        Me.mcaCalendario.NoneButton.Size = New System.Drawing.Size(72, 20)
        Me.mcaCalendario.NoneButton.Text = "None"
        '
        '
        '
        Me.mcaCalendario.TodayButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.mcaCalendario.TodayButton.IsBackStageButton = False
        Me.mcaCalendario.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.mcaCalendario.TodayButton.Size = New System.Drawing.Size(463, 20)
        Me.mcaCalendario.TodayButton.Text = "Today"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscbTemas, Me.ToolStripLabel1, Me.rb15, Me.rb30, Me.rb60, Me.rb90, Me.ToolStripSeparator2, Me.tsbLimpiar, Me.ToolStripSeparator3, Me.tscbAbajo, Me.ToolStripSeparator4})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(544, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'tscbTemas
        '
        Me.tscbTemas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tscbTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbTemas.Items.AddRange(New Object() {"Por Defecto", "Metro", "OfficeXP", "Office2003", "Office2007 Black", "Office2007 Blue", "Office2007 Silver", "Office2007Outlook", "Office2010", "VS2005", "VS2010"})
        Me.tscbTemas.Name = "tscbTemas"
        Me.tscbTemas.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel1.Text = "Tema"
        '
        'rb15
        '
        Me.rb15.Checked = True
        Me.rb15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rb15.Name = "rb15"
        Me.rb15.Size = New System.Drawing.Size(37, 22)
        Me.rb15.Text = "15"
        Me.rb15.ToolTipText = "Calcula 15 Días"
        '
        'rb30
        '
        Me.rb30.Name = "rb30"
        Me.rb30.Size = New System.Drawing.Size(37, 22)
        Me.rb30.Text = "30"
        Me.rb30.ToolTipText = "Calcula 30 dias"
        '
        'rb60
        '
        Me.rb60.Name = "rb60"
        Me.rb60.Size = New System.Drawing.Size(37, 22)
        Me.rb60.Text = "60"
        Me.rb60.ToolTipText = "Calcula 60 días"
        '
        'rb90
        '
        Me.rb90.Name = "rb90"
        Me.rb90.Size = New System.Drawing.Size(37, 22)
        Me.rb90.Text = "90"
        Me.rb90.ToolTipText = "Calcula 90 días"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbLimpiar
        '
        Me.tsbLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
        Me.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLimpiar.Name = "tsbLimpiar"
        Me.tsbLimpiar.Size = New System.Drawing.Size(23, 22)
        Me.tsbLimpiar.Text = "Limpia los Radio Buttons"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tscbAbajo
        '
        Me.tscbAbajo.Name = "tscbAbajo"
        Me.tscbAbajo.Size = New System.Drawing.Size(124, 22)
        Me.tscbAbajo.Text = "Ajusta hacia Abajo"
        Me.tscbAbajo.ToolTipText = "Ajusta las fechas hacia abajo en los feriados"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'gbEntidades
        '
        Me.gbEntidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbEntidades.Controls.Add(Me.lvEntidades)
        Me.gbEntidades.Controls.Add(Me.ToolStrip2)
        Me.gbEntidades.Location = New System.Drawing.Point(3, 3)
        Me.gbEntidades.Name = "gbEntidades"
        Me.gbEntidades.Size = New System.Drawing.Size(550, 273)
        Me.gbEntidades.TabIndex = 5
        Me.gbEntidades.TabStop = False
        Me.gbEntidades.Text = "Entidades"
        '
        'lvEntidades
        '
        Me.lvEntidades.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvEntidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvEntidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvEntidades.FullRowSelect = True
        Me.lvEntidades.Location = New System.Drawing.Point(3, 41)
        Me.lvEntidades.MultiSelect = False
        Me.lvEntidades.Name = "lvEntidades"
        Me.lvEntidades.Size = New System.Drawing.Size(544, 229)
        Me.lvEntidades.TabIndex = 1
        Me.lvEntidades.UseCompatibleStateImageBehavior = False
        Me.lvEntidades.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Entidad"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscarEnt, Me.ToolStripSeparator1, Me.tsrbBancos, Me.tsrbFondos, Me.tscbSelTodos})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(544, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbBuscarEnt
        '
        Me.tsbBuscarEnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBuscarEnt.Image = CType(resources.GetObject("tsbBuscarEnt.Image"), System.Drawing.Image)
        Me.tsbBuscarEnt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscarEnt.Name = "tsbBuscarEnt"
        Me.tsbBuscarEnt.Size = New System.Drawing.Size(23, 22)
        Me.tsbBuscarEnt.Text = "Mostrar Tasas Cotizadas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsrbBancos
        '
        Me.tsrbBancos.Checked = True
        Me.tsrbBancos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsrbBancos.Name = "tsrbBancos"
        Me.tsrbBancos.Size = New System.Drawing.Size(63, 22)
        Me.tsrbBancos.Text = "Bancos"
        '
        'tsrbFondos
        '
        Me.tsrbFondos.Name = "tsrbFondos"
        Me.tsrbFondos.Size = New System.Drawing.Size(64, 22)
        Me.tsrbFondos.Text = "Fondos"
        '
        'tscbSelTodos
        '
        Me.tscbSelTodos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tscbSelTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tscbSelTodos.Name = "tscbSelTodos"
        Me.tscbSelTodos.Size = New System.Drawing.Size(121, 22)
        Me.tscbSelTodos.Text = "Seleccionar Todos"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TasasTableAdapter
        '
        Me.TasasTableAdapter.ClearBeforeFill = True
        '
        'frmWALCOT00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1112, 588)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWALCOT00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizador de Tasas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbTasas.ResumeLayout(False)
        Me.gbTasas.PerformLayout()
        CType(Me.GridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsWALCOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.gbEdicion.ResumeLayout(False)
        Me.gbEdicion.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtpaInicio.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtpaTermino.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaTermino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nudeDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcaCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.gbEntidades.ResumeLayout(False)
        Me.gbEntidades.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents gbTasas As GroupBox
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents tsbVerPizarra As ToolStripButton
    Friend WithEvents tsbListar As ToolStripButton
    Friend WithEvents gbEdicion As GroupBox
    Friend WithEvents ToolStrip5 As ToolStrip
    Friend WithEvents tsbGrabarTasa As ToolStripButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents gbFechas As GroupBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents gbEntidades As GroupBox
    Friend WithEvents lvEntidades As ListView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsbBuscarEnt As ToolStripButton
    Friend WithEvents GridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Friend WithEvents tsrbBancos As Syncfusion.Windows.Forms.Tools.ToolStripRadioButton
    Friend WithEvents tsrbFondos As Syncfusion.Windows.Forms.Tools.ToolStripRadioButton
    Friend WithEvents tscbSelTodos As Syncfusion.Windows.Forms.Tools.ToolStripCheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpaInicio As DateTimePickerAdv
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpaTermino As DateTimePickerAdv
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mcaCalendario As MonthCalendarAdv
    Friend WithEvents nudeDias As NumericUpDownExt
    Friend WithEvents tscbTemas As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DsWALCOT As dsWALCOT
    Friend WithEvents TasasBindingSource As BindingSource
    Friend WithEvents TasasTableAdapter As dsWALCOTTableAdapters.TasasTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbExterno As TextBox
    Friend WithEvents tbPropio As TextBox
    Friend WithEvents tbEntidad As TextBox
    Friend WithEvents dtpTermino As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents rb15 As ToolStripRadioButton
    Friend WithEvents rb30 As ToolStripRadioButton
    Friend WithEvents rb60 As ToolStripRadioButton
    Friend WithEvents rb90 As ToolStripRadioButton
    Friend WithEvents tsbLimpiar As ToolStripButton
    Friend WithEvents tscbAbajo As ToolStripCheckBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
