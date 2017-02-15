Imports System.Data.OleDb
Imports Microsoft.Win32
Imports Syncfusion.Grouping

Public Class frmWALCOT00
    Dim yaPaso As Boolean = False
    Dim taENT As New dsWALCOTTableAdapters.TESENTTableAdapter
    Dim dtENT As New dsWALCOT.TESENTDataTable
    Dim FilaENT As dsWALCOT.TESENTRow
    Dim taFON As New dsWALCOTTableAdapters.FondosTableAdapter
    Dim dtFON As New dsWALCOT.FondosDataTable
    Dim FilaFON As dsWALCOT.FondosRow
    Friend taTAS As New dsWALCOTTableAdapters.TasasTableAdapter
    Dim dtTAS As New dsWALCOT.TasasDataTable
    Dim FilaTAS As dsWALCOT.TasasRow
    ' entidad seleccionada
    Dim ENTSel As Long
    Dim FONSel As Long

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtpaInicio.Value = DetallePla.Fecha
        dtpaTermino.Value = DetallePla.Fecha
        dtpaTermino.MinValue = DetallePla.Fecha
        mcaCalendario.MinValue = DetallePla.Fecha
        tscbTemas.SelectedIndex = Temas.Calendario

    End Sub

    Private Sub frmWALCOT00_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaBancos()
        tsrbBancos.Checked = True
        tbExterno.Text = ""
        tbPropio.Text = ""
        Limpiar()

    End Sub

    Private Sub nudeDias_ValueChanged(sender As Object, e As EventArgs) Handles nudeDias.ValueChanged
        Dim Fechas() As Date = Nothing
        dtpaTermino.Value = dtpaInicio.Value.AddDays(nudeDias.Value)
        mcaCalendario.Value = dtpaTermino.Value
        Dim dias As Integer
        dias = DateDiff(DateInterval.Day, dtpaInicio.Value, dtpaTermino.Value)
        ReDim Fechas(dias)
        For i = 0 To dias
            Fechas(i) = dtpaInicio.Value.AddDays(i)
        Next
        mcaCalendario.SelectedDates = Fechas
        dtpaTermino.Value = Fechas(Fechas.Length - 1)
    End Sub


    Private Sub tscbTemas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTemas.SelectedIndexChanged
        CambioPiel(tscbTemas.SelectedItem)
        Registry.SetValue(keyName, "Calendario", Me.tscbTemas.SelectedIndex)
        Temas.Calendario = Me.tscbTemas.SelectedIndex

    End Sub
    Private Sub CambioPiel(Tema As String)
        Select Case Tema
            Case "Por Defecto"
                mcaCalendario.Style = VisualStyle.Default
            Case "OfficeXP"
                mcaCalendario.Style = VisualStyle.OfficeXP
            Case "Office2003"
                mcaCalendario.Style = VisualStyle.Office2003
            Case "VS2005"
                mcaCalendario.Style = VisualStyle.VS2005
            Case "Office2007 Black"
                mcaCalendario.Style = VisualStyle.Office2007
                mcaCalendario.Office2007Theme = Office2007Theme.Black
                mcaCalendario.Office2007Theme = Office2010Theme.Black
            Case "Office2007 Blue"
                mcaCalendario.Style = VisualStyle.Office2007
                mcaCalendario.Office2007Theme = Office2007Theme.Blue
                mcaCalendario.Office2007Theme = Office2010Theme.Blue
            Case "Office2007 Silver"
                mcaCalendario.Style = VisualStyle.Office2007
                mcaCalendario.Office2007Theme = Office2007Theme.Silver
                mcaCalendario.Office2007Theme = Office2010Theme.Silver
            Case "Office2007Outlook"
                mcaCalendario.Style = VisualStyle.Office2007Outlook
            Case "Metro"
                mcaCalendario.Style = VisualStyle.Metro
            Case "VS2010"
                mcaCalendario.Style = VisualStyle.VS2010
            Case "Office2010"
                mcaCalendario.Style = VisualStyle.Office2010
        End Select

    End Sub



    Private Sub mcaCalendario_Click(sender As Object, e As EventArgs) Handles mcaCalendario.Click
        yaPaso = True
    End Sub

    Private Sub mcaCalendario_DateChanged(sender As Object, e As EventArgs) Handles mcaCalendario.DateChanged
        If yaPaso = True Then
            dtpaTermino.Value = mcaCalendario.Value
            Dim dias As Integer
            dias = DateDiff(DateInterval.Day, dtpaInicio.Value, dtpaTermino.Value)
            nudeDias.Value = dias
            yaPaso = False
        End If
        'Dim fechas() As Date
        'Dim dias As Integer
        'dias = DateDiff(DateInterval.Day, dtpaInicio.Value, dtpaTermino.Value)
        'ReDim fechas(dias)
        'For i = 0 To dias
        '    fechas(i) = dtpaInicio.Value.AddDays(i)
        'Next
        'nudeDias.Value = dias
        'mcaCalendario.SelectedDates = fechas
        'dtpaTermino.Value = fechas(fechas.Length - 1)
    End Sub

    Private Sub dtpaTermino_ValueChanged(sender As Object, e As EventArgs) Handles dtpaTermino.ValueChanged
        If yaPaso = True Then
            Dim dias As Integer
            dias = DateDiff(DateInterval.Day, dtpaInicio.Value, dtpaTermino.Value)
            nudeDias.Value = dias
            yaPaso = False
        End If
        dtpInicio.Value = dtpaInicio.Value
        dtpTermino.Value = dtpaTermino.Value
        If tscbAbajo.Checked = True Then
            dtpaTermino.Value = CorrigeFeriado(dtpaTermino.Value, 2)
        Else
            dtpaTermino.Value = CorrigeFeriado(dtpaTermino.Value, 1)
        End If
        nudeDias.Value = DateDiff(DateInterval.Day, dtpaInicio.Value, dtpaTermino.Value)
    End Sub


    Private Sub dtpaTermino_MouseClick(sender As Object, e As MouseEventArgs) Handles dtpaTermino.MouseClick
        yaPaso = True

    End Sub

    'Private Sub tsrdTodos_Click(sender As Object, e As EventArgs)
    '    If tsrdTodos.Checked = True Then
    '        cargaEntidades()
    '    End If
    'End Sub

    'Private Sub tsrbAdministradoras_Click(sender As Object, e As EventArgs)
    '    If tsrbAdministradoras.Checked = True Then
    '        cargaAdmFondos()
    '    End If
    'End Sub

    Private Sub tsrbBancos_Click(sender As Object, e As EventArgs) Handles tsrbBancos.Click
        If tsrbBancos.Checked = True Then
            cargaBancos()
            tbExterno.Text = ""
            tbPropio.Text = ""
            tbEntidad.Text = ""

        End If
    End Sub

    Private Sub ToolStripRadioButton1_Click(sender As Object, e As EventArgs) Handles tsrbFondos.Click
        If tsrbFondos.Checked = True Then
            cargaFondos()
            tbExterno.Text = ""
            tbPropio.Text = ""
            tbEntidad.Text = ""
        End If
    End Sub
    Public Sub cargaBancos()
        taENT.FillByBancos(dtENT)
        lvEntidades.Clear()
        lvEntidades.CheckBoxes = True
        Dim columna As New ColumnHeader("Bancos")
        columna.Text = "Bancos"
        columna.Width = lvEntidades.Width - 30
        lvEntidades.Columns.Add(columna)
        columna = New ColumnHeader("Clave")
        columna.Text = "Clave"
        columna.Width = 0
        lvEntidades.Columns.Add(columna)
        For i = 0 To dtENT.Count - 1
            FilaENT = dtENT.Item(i)
            Dim Item As ListViewItem = New ListViewItem(FilaENT.ENT_RAZON)
            Item.SubItems.Add(FilaENT.ENT_CODIGO.ToString)
            Item.SubItems.Add("")
            lvEntidades.Items.Add(Item)
        Next
        lvEntidades.Refresh()
        tscbSelTodos.Checked = False
        ENTSel = 0
        FONSel = 0
    End Sub
    Public Sub cargaFondos()
        taFON.Fill(dtFON)
        lvEntidades.Clear()
        lvEntidades.CheckBoxes = True
        Dim columna As New ColumnHeader("Fondos")
        columna.Text = "Fondos Mutuos"
        columna.Width = lvEntidades.Width - 30
        lvEntidades.Columns.Add(columna)
        For i = 0 To dtFON.Count - 1
            FilaFON = dtFON.Item(i)
            Dim Item As ListViewItem = New ListViewItem(Trim(FilaFON.FON_FONDO) & Space(1) & "(" & Trim(FilaFON.ENT_ABREVIATURA) & ")")
            Item.SubItems.Add(FilaFON.ENT_CODIGO.ToString)
            Item.SubItems.Add(FilaFON.FON_CODIGO.ToString)
            lvEntidades.Items.Add(Item)
        Next
        lvEntidades.Refresh()
        tscbSelTodos.Checked = False
        ENTSel = 0
        FONSel = 0
    End Sub


    Private Sub tscbSelTodos_CheckedChanged(sender As Object, e As EventArgs) Handles tscbSelTodos.CheckedChanged
        Dim indice As Integer

        If tscbSelTodos.Checked = True Then
            If lvEntidades.Items.Count > 0 Then
                For indice = 0 To Me.lvEntidades.Items.Count - 1
                    Me.lvEntidades.Items.Item(indice).Checked = True
                Next
            End If
        Else
            If lvEntidades.Items.Count > 0 Then
                For indice = 0 To Me.lvEntidades.Items.Count - 1
                    Me.lvEntidades.Items.Item(indice).Checked = False
                Next
            End If
        End If

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbBuscarEnt_Click(sender As Object, e As EventArgs) Handles tsbBuscarEnt.Click
        ' Mostrar tasas acordadas
        ' Armar lista de codigos marcados
        Dim Claves As String = ""
        For i = 0 To lvEntidades.Items.Count - 1
            If lvEntidades.Items(i).Checked = True Then
                ' Buscar Código
                If tsrbFondos.Checked = True Then
                    FilaFON = dtFON.Item(i)
                    Claves = Claves & FilaFON.FON_CODIGO & ", "
                Else
                    FilaENT = dtENT.Item(i)
                    Claves = Claves & FilaENT.ENT_CODIGO & ", "
                End If
            End If
        Next
        ' verifcar si se selecciono alguna entidad
        If Claves = "" Then
            MsgBox("Debe escoger al menos una Entidad Financiera para desplegar sus tasas!")
            Exit Sub
        End If
        ' Generar Filtro
        Dim com As String
        Claves = Claves.Substring(0, Claves.Length - 2)
        If tsrbFondos.Checked = True Then
            com = "SELECT        TESENT.ENT_ABREVIATURA AS ENTIDAD, TESCOT.ent_codigo, TESFON.FON_FONDO AS FONDO, TESFON.FON_CODIGO, DATEDIFF(DAY, TESCOT.desde, TESCOT.hasta) AS DIAS, TESCOT.fondos_propios AS [F.P.], TESCOT.fondos_externos AS [F.E.], TESCOT.desde AS INICIO, TESCOT.hasta AS TERMINO, TESCOT.fecha_ingreso AS INGRESO, coalesce(TESENT.ENT_ABREVIATURA + ' (' + rtrim(TESFON.FON_FONDO) + ')', TESENT.ENT_ABREVIATURA) as Nombre FROM            TESCOT INNER JOIN TESENT ON TESENT.ENT_CODIGO = TESCOT.ent_codigo LEFT OUTER JOIN TESFON ON TESFON.FON_CODIGO = TESCOT.fon_codigo WHERE TESFON.FON_CODIGO IN  (" & Claves & ") AND TESCOT.DESDE >= CONVERT(date,'" & Format(dtpaInicio.Value, "dd/MM/yyyy") & "',103)"

        Else
            com = "SELECT        TESENT.ENT_ABREVIATURA AS ENTIDAD, TESCOT.ent_codigo, TESFON.FON_FONDO AS FONDO, TESFON.FON_CODIGO, DATEDIFF(DAY, TESCOT.desde, TESCOT.hasta) AS DIAS, TESCOT.fondos_propios AS [F.P.], TESCOT.fondos_externos AS [F.E.], TESCOT.desde AS INICIO, TESCOT.hasta AS TERMINO, TESCOT.fecha_ingreso AS INGRESO, coalesce(TESENT.ENT_ABREVIATURA + ' (' + rtrim(TESFON.FON_FONDO) + ')', TESENT.ENT_ABREVIATURA) as Nombre FROM            TESCOT INNER JOIN TESENT ON TESENT.ENT_CODIGO = TESCOT.ent_codigo LEFT OUTER JOIN TESFON ON TESFON.FON_CODIGO = TESCOT.fon_codigo WHERE TESENT.ENT_CODIGO IN  (" & Claves & ") AND TESCOT.DESDE >= CONVERT(date,'" & Format(dtpaInicio.Value, "dd/MM/yyyy") & "',103)"
        End If
        taTAS.SelectCommand(0).CommandText = com
        Me.TasasTableAdapter.SelectCommand(0).CommandText = com
        Me.TasasTableAdapter.Fill(Me.DsWALCOT.Tasas)

    End Sub
    Private Sub CargarTasas()
        Dim Claves As String = ""

        ' Generar Filtro
        Dim com As String
        If tsrbFondos.Checked = True Then
            FilaFON = dtFON.Item(lvEntidades.SelectedIndices(0))
            Claves = FilaFON.FON_CODIGO
            com = "SELECT        TESENT.ENT_ABREVIATURA AS ENTIDAD, TESCOT.ent_codigo, TESFON.FON_FONDO AS FONDO, TESFON.FON_CODIGO, DATEDIFF(DAY, TESCOT.desde, TESCOT.hasta) AS DIAS, TESCOT.fondos_propios AS [F.P.], TESCOT.fondos_externos AS [F.E.], TESCOT.desde AS INICIO, TESCOT.hasta AS TERMINO, TESCOT.fecha_ingreso AS INGRESO, coalesce(TESENT.ENT_ABREVIATURA + ' (' + rtrim(TESFON.FON_FONDO) + ')', TESENT.ENT_ABREVIATURA) as Nombre FROM            TESCOT INNER JOIN TESENT ON TESENT.ENT_CODIGO = TESCOT.ent_codigo LEFT OUTER JOIN TESFON ON TESFON.FON_CODIGO = TESCOT.fon_codigo WHERE TESFON.FON_CODIGO IN  (" & Claves & ") AND TESCOT.DESDE >= CONVERT(date,'" & Format(dtpaInicio.Value, "dd/MM/yyyy") & "',103)"

        Else
            FilaENT = dtENT.Item(lvEntidades.SelectedIndices(0))
            Claves = FilaENT.ENT_CODIGO
            com = "SELECT        TESENT.ENT_ABREVIATURA AS ENTIDAD, TESCOT.ent_codigo, TESFON.FON_FONDO AS FONDO, TESFON.FON_CODIGO, DATEDIFF(DAY, TESCOT.desde, TESCOT.hasta) AS DIAS, TESCOT.fondos_propios AS [F.P.], TESCOT.fondos_externos AS [F.E.], TESCOT.desde AS INICIO, TESCOT.hasta AS TERMINO, TESCOT.fecha_ingreso AS INGRESO, coalesce(TESENT.ENT_ABREVIATURA + ' (' + rtrim(TESFON.FON_FONDO) + ')', TESENT.ENT_ABREVIATURA) as Nombre FROM            TESCOT INNER JOIN TESENT ON TESENT.ENT_CODIGO = TESCOT.ent_codigo LEFT OUTER JOIN TESFON ON TESFON.FON_CODIGO = TESCOT.fon_codigo WHERE TESENT.ENT_CODIGO IN  (" & Claves & ") AND TESCOT.DESDE >= CONVERT(date,'" & Format(dtpaInicio.Value, "dd/MM/yyyy") & "',103)"
        End If
        taTAS.SelectCommand(0).CommandText = com
        Me.TasasTableAdapter.SelectCommand(0).CommandText = com
        Me.TasasTableAdapter.Fill(Me.DsWALCOT.Tasas)

    End Sub

    Private Sub tsbListar_Click(sender As Object, e As EventArgs) Handles tsbListar.Click
        If tsrbBancos.Checked = True Then
            ' Reporte de Tasas de bancos
            Dim InfoTag As New Informes
            Me.Cursor = Cursors.WaitCursor
            InfoTag.Reporte = "reportes\rptTasasBancos00.rpt"
            InfoTag.Numero = 14
            InfoTag.DatasTableImp = TryCast(Me.DsWALCOT.Tasas, DataTable)
            Dim Informe As New frmWALREP00
            Informe.Tag = InfoTag
            Informe.MdiParent = Me.MdiParent
            Informe.Show()
            Me.Cursor = Cursors.Default
        Else
            ' Reporte de tasas de Fondos
            Dim InfoTag As New Informes
            Me.Cursor = Cursors.WaitCursor
            InfoTag.Reporte = "reportes\rptTasasFondos00.rpt"
            InfoTag.Numero = 15
            InfoTag.DatasTableImp = TryCast(Me.DsWALCOT.Tasas, DataTable)
            Dim Informe As New frmWALREP00
            Informe.Tag = InfoTag
            Informe.MdiParent = Me.MdiParent
            Informe.Show()
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub tsbVerPizarra_Click(sender As Object, e As EventArgs) Handles tsbVerPizarra.Click
        ' Verificar si existen Tasas cotizadas
        Dim taPIZ As New dsWALCOTTableAdapters.PizarraTableAdapter
        Dim dtPIZ As New dsWALCOT.PizarraDataTable
        taPIZ.FillbyInicio(dtPIZ, DetallePla.Fecha)
        If dtPIZ.Count = 0 Then
            MsgBox("No existen tasas cotizadas el dia de hoy.", MsgBoxStyle.Information, NombreSistema)
            Exit Sub
        End If
        Dim Formulario As New frmWALCOT02
        Formulario.MdiParent = MDIPrincipal
        Me.Cursor = Cursors.WaitCursor
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub lvEntidades_ItemActivate(sender As Object, e As EventArgs) Handles lvEntidades.ItemActivate
        If lvEntidades.SelectedItems.Count > 0 Then
            CargarTasas()

        End If
    End Sub

    Private Sub dtpaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpaInicio.ValueChanged
        dtpInicio.Value = dtpaInicio.Value
        dtpTermino.Value = dtpaTermino.Value
    End Sub

    Private Sub lvEntidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEntidades.SelectedIndexChanged
        If lvEntidades.SelectedItems.Count > 0 Then
            tbEntidad.Text = lvEntidades.SelectedItems(0).Text
            ENTSel = CLng(lvEntidades.SelectedItems(0).SubItems(1).Text)
            If tsrbFondos.Checked = True Then
                FONSel = CLng(lvEntidades.SelectedItems(0).SubItems(2).Text)
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbLimpiar.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        rb15.Checked = False
        rb30.Checked = False
        rb60.Checked = False
        rb90.Checked = False
        nudeDias.Value = 0
        dtpaTermino.Value = dtpaInicio.Value
        tbPropio.Text = ""
        tbExterno.Text = ""
        ENTSel = 0
        FONSel = 0
    End Sub

    Private Sub rb15_Click(sender As Object, e As EventArgs) Handles rb15.Click
        ' Calcula 15 Días
        If rb15.Checked = True Then
            nudeDias.Value = 15
            dtpaTermino.Value = dtpaInicio.Value.AddDays(15)
        End If
    End Sub

    Private Sub rb30_Click(sender As Object, e As EventArgs) Handles rb30.Click
        ' Calcula 30 dias
        If rb30.Checked = True Then
            nudeDias.Value = 30
            dtpaTermino.Value = dtpaInicio.Value.AddDays(30)
        End If

    End Sub

    Private Sub rb60_Click(sender As Object, e As EventArgs) Handles rb60.Click
        ' Calcula 60 dias
        If rb60.Checked = True Then
            nudeDias.Value = 60
            dtpaTermino.Value = dtpaInicio.Value.AddDays(60)
        End If
    End Sub

    Private Sub rb90_Click(sender As Object, e As EventArgs) Handles rb90.Click
        ' Calcula 90 dias
        If rb90.Checked = True Then
            nudeDias.Value = 90
            dtpaTermino.Value = dtpaInicio.Value.AddDays(90)
        End If

    End Sub

    Private Sub tbPropio_GotFocus(sender As Object, e As EventArgs) Handles tbPropio.GotFocus
        If tbPropio.Text <> "" Then
            tbPropio.Text = CDbl(tbPropio.Text)
        End If
    End Sub

    Private Sub tbPropio_LostFocus(sender As Object, e As EventArgs) Handles tbPropio.LostFocus
        ErrorProvider1.Clear()

        If tbPropio.Text <> "" Then
            Try
                tbPropio.Text = FormatNumber(CDbl(tbPropio.Text), 3)
            Catch ex As Exception
                ErrorProvider1.SetError(tbPropio, "El campo debe ser numérico")
                tbPropio.Focus()
            End Try
        End If
    End Sub

    Private Sub tbExterno_LostFocus(sender As Object, e As EventArgs) Handles tbExterno.LostFocus
        ErrorProvider1.Clear()
        If tbExterno.Text <> "" Then
            Try
                tbExterno.Text = FormatNumber(CDbl(tbExterno.Text), 3)
            Catch ex As Exception
                ErrorProvider1.SetError(tbExterno, "El campo debe ser numérico")
                tbExterno.Focus()
            End Try
        End If
    End Sub
    Private Sub grabaTasa()
        'agrega o midifica la tasa ingresada para la entidad financiera
        Dim taCOT As New dsWALCOTTableAdapters.TESCOTTableAdapter
        Dim dtCOT As New dsWALCOT.TESCOTDataTable
        Dim filaCOt As dsWALCOT.TESCOTRow

        taCOT.FillByEntFonDesdeHasta(dtCOT, ENTSel, FONSel, dtpInicio.Value, dtpTermino.Value)
        If dtCOT.Count = 0 Then
            ' se agrega
            filaCOt = dtCOT.NewTESCOTRow
            filaCOt.ent_codigo = ENTSel
            filaCOt.fon_codigo = FONSel
            filaCOt.desde = dtpInicio.Value
            filaCOt.hasta = dtpTermino.Value
            If tbPropio.Text = "" Then
                filaCOt.fondos_propios = 0
            Else
                filaCOt.fondos_propios = CDbl(tbPropio.Text)
            End If
            If tbExterno.Text = "" Then
                filaCOt.fondos_externos = 0
            Else
                filaCOt.fondos_externos = CDbl(tbExterno.Text)
            End If

            filaCOt.fecha_ingreso = Now
            dtCOT.AddTESCOTRow(filaCOt)
            taCOT.Update(dtCOT)
        Else
            filaCOt = dtCOT.Item(0)
            If tbPropio.Text = "" Then
                filaCOt.fondos_propios = 0
            Else
                filaCOt.fondos_propios = CDbl(tbPropio.Text)
            End If
            If tbExterno.Text = "" Then
                filaCOt.fondos_externos = 0
            Else
                filaCOt.fondos_externos = CDbl(tbExterno.Text)
            End If
            filaCOt.fecha_ingreso = Now
            taCOT.Update(dtCOT)
        End If
    End Sub

    Private Function ValidaTasa() As Boolean
        ErrorProvider1.Clear()
        Dim errores = False
        'valida datos para ingreso o modificación de tasa...
        If tbEntidad.Text = "" Then
            ErrorProvider1.SetError(tbEntidad, "¡No ha escogido una Entidad o Fondo!")
            errores = True
        End If
        If nudeDias.Value = 0 Then
            ErrorProvider1.SetError(nudeDias, "¡No se ha definido un periodo para la inversión!")
            errores = True
        End If
        'If tsrbBancos.Checked = True And tbPropio.Text = "" Then
        '    ErrorProvider1.SetError(tbPropio, "¡No se ha ingresado la tasa para el Fondo Propio!")
        '    errores = True
        'End If

        'If tsrbFondos.Checked = True And tbExterno.Text = "" Then
        '    ErrorProvider1.SetError(tbExterno, "¡No se ha ingresado la tasa para el Fondo Externo!")
        '    errores = True
        'End If
        If tbPropio.Text = "" And tbExterno.Text = "" Then
            ErrorProvider1.SetError(tbPropio, "¡Debe ingresar al menos una Tasa!")
            ErrorProvider1.SetError(tbExterno, "¡Debe ingresar al menos una Tasa!")
            errores = True
        End If
        If errores = True Then
            Return False
        Else
            Return True

        End If
    End Function

    Private Sub tsbGrabarTasa_Click(sender As Object, e As EventArgs) Handles tsbGrabarTasa.Click
        If ValidaTasa() Then
            grabaTasa()
            'Limpiar()
            CargarTasas()
        End If
    End Sub

    Private Sub GridGroupingControl1_SelectedRecordsChanged(sender As Object, e As SelectedRecordsChangedEventArgs) Handles GridGroupingControl1.SelectedRecordsChanged
        Dim fila As DataRowView
        fila = TasasBindingSource.Current
        dtpaTermino.Value = fila.Item("TERMINO")
        nudeDias.Value = DateDiff(DateInterval.Day, dtpaInicio.Value, dtpaTermino.Value)
        If tsrbBancos.Checked = True Then
            tbPropio.Text = FormatNumber(fila.Item("F_P_"), 3)
        Else
            tbExterno.Text = FormatNumber(fila.Item("F_E_"), 3)
        End If
        tbEntidad.Text = fila.Item("Nombre")
    End Sub

    Private Sub lvEntidades_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvEntidades.ItemCheck
        If e.NewValue = CheckState.Checked Then
            lvEntidades.Items(e.Index).Selected = True
        End If
    End Sub
End Class
