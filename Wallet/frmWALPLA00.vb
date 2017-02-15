Imports ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Microsoft.Win32
Imports System.ComponentModel

Public Class frmWALPLA00
    Dim Bloqueo As Boolean
    Dim fecha As Date
    Dim taPAR As New dsWALPLATableAdapters.TESPARTableAdapter
    Dim dtPAR As New dsWALPLA.TESPARDataTable
    Dim filaPAR As dsWALPLA.TESPARRow
    Dim taREC As New dsWALPLATableAdapters.TotalesRECTableAdapter
    Dim dtREC As New dsWALPLA.TotalesRECDataTable
    Dim filaREC As dsWALPLA.TotalesRECRow
    Dim taPLA As New dsWALPLATableAdapters.TESPLATableAdapter
    Dim dtPLA As New dsWALPLA.TESPLADataTable
    Dim filaPLA As dsWALPLA.TESPLARow
    Dim taDPLA As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
    Dim dtDPLA As New dsWALPLA.DetallePlanillaDataTable
    Dim filaDPLA As dsWALPLA.DetallePlanillaRow
    Dim taSALDOPLA As New dsWALPLATableAdapters.TESPLATableAdapter
    Dim dtSALDOPLA As New dsWALPLA.TESPLADataTable
    Dim filaSALDOPLA As dsWALPLA.TESPLARow
    Dim taCTE As New dsWALPLATableAdapters.TESCTETableAdapter
    Dim dtCTE As New dsWALPLA.TESCTEDataTable
    Dim filaCTE As dsWALPLA.TESCTERow
    Dim taCTEPLA As New dsWALPLATableAdapters.TESCTETableAdapter
    Dim dtCTEPLA As New dsWALPLA.TESCTEDataTable
    Dim filaCTEPLA As dsWALPLA.TESCTERow
    Dim consulta As New dsWALPLATableAdapters.QueriesTableAdapter
    Dim taPLATOT As New dsWALPLATableAdapters.TESDPLTableAdapter
    Dim dtPLATOT As New dsWALPLA.TESDPLDataTable
    Dim filaPLATOT As dsWALPLA.TESDPLRow


    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.WindowState = FormWindowState.Maximized

        Bloqueo = False
        taPAR.Fill(dtPAR)
        If dtPAR.Count <> 1 Then
            MsgBox("Se detecto un problema en el archivo de Parámetros." & vbCrLf & "Favor comunicarse con soporte", MsgBoxStyle.Critical, NombreSistema)
        Else
            filaPAR = dtPAR.Item(0)

            Titulo.Text = "Planilla de Operaciones del " & Format(filaPAR.PAR_FECHAPRO, "dddd dd/MM/yyyy")
            If filaPAR.PAR_ACTUALIZA Then
                Me.Imagen1.Visible = True
                Me.Imagen1.Image = My.Resources.FACE01
            Else
                '        Me.Image1.Picture = LoadPicture("Ubicacion.ico")
                Me.Imagen1.Visible = False
            End If
            fecha = filaPAR.PAR_FECHAPRO
            If filaPAR.PAR_ESTADOPLA = "A" Then
                ' PLANILLA ACTIVA
                Planilla = filaPAR.PAR_PLANILLA


            ElseIf filaPAR.PAR_ESTADOPLA = "B" Then
                ' PLANILLA BLOQUEDA
                MsgBox("La Planilla se encuentra Bloqueada", vbCritical, "Mensaje del Sistema")
                Bloqueo = True
            End If
            '    Cargar_Cuentas
            TotalRecaudacion()
            Cargar_planilla()
            tscbTemas.SelectedIndex = Temas.Planilla
            TipoPlanilla = "C"
            GridGroupingControl1.ShowRowHeaders = False
            GridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 60
            'GridGroupingControl1.TableModel.Options.SelectCellsMouseButtonsMask = MouseButtons.Left
        End If
    End Sub
    Private Sub TotalRecaudacion()
        Dim TotalLinea As Double
        Dim n As Double
        ' totaliza recaudación por cuenta

        If dtREC.Count = 0 Then
            Exit Sub
        Else
            taREC.FillByPlanilla(dtREC, Planilla)
            For i = 0 To dtREC.Count - 1
                filaREC = dtREC.Item(i)
                taDPLA.FillByPlanillaCuenta(dtDPLA, Planilla, filaREC.Cuenta)
                filaDPLA = dtDPLA.Item(0)
                filaDPLA.DPL_RECAUDACION = filaREC.Total

                ' Calculo del Saldo
                TotalLinea = filaDPLA.DPL_SALDOINI +
                        filaDPLA.DPL_RESCATES +
                        filaDPLA.DPL_RECAUDACION -
                        filaDPLA.DPL_CHEQUESDEV +
                        filaDPLA.DPL_CHEQUESCAR +
                        filaDPLA.DPL_APORTES +
                        filaDPLA.DPL_OTROSINGRESOS -
                        filaDPLA.DPL_PAGOSCHE -
                        filaDPLA.DPL_PAGOSCAR +
                        filaDPLA.DPL_TRANSFERENCIASPOS -
                        filaDPLA.DPL_TRANSFERENCIASNEG -
                        filaDPLA.DPL_COLOCACIONES

                filaDPLA.DPL_SALDO = TotalLinea

                taCTE.FillByCuenta(dtCTE, filaREC.Cuenta)
                filaCTE = dtCTE.Item(0)
                If IsNumeric(filaCTE.CTE_COLCHON1) Then
                    If TotalLinea > filaCTE.CTE_COLCHON1 Then
                        filaDPLA.DPL_PORCOLOCAR = TotalLinea - filaCTE.CTE_COLCHON1
                    Else
                        filaDPLA.DPL_PORCOLOCAR = 0
                    End If
                Else
                    filaDPLA.DPL_PORCOLOCAR = TotalLinea
                End If
                If filaDPLA.DPL_PORCOLOCAR < 1000000 Then
                    filaDPLA.DPL_PORCOLOCAR = 0
                Else
                    n = Int(filaDPLA.DPL_PORCOLOCAR / 500000)
                    filaDPLA.DPL_PORCOLOCAR = 500000 * n
                End If


                taDPLA.Update(dtDPLA)
            Next
        End If


    End Sub

    Private Sub Cargar_planilla()
        Me.GridGroupingControl1.GetTableDescriptor("Cuentas").FrozenColumn = "CTE_CUENTA"

        Dim Codigo As Long
        Dim strAuditoria As String
        Dim Largo As Integer
        Dim posicion As Integer
        'Dim Total As Double
        taPLA.FillByPlanilla(dtPLA, Planilla)
        If dtPLA.Count = 0 Then
            ' no existe planilla, se crea
            filaPLA = dtPLA.NewTESPLARow
            filaPLA.PLA_CODIGO = Planilla
            filaPLA.EMP_CODIGO = Usuario.CodEmpresa
            filaPLA.PLA_FECHA = filaPAR.PAR_FECHAPRO
            taSALDOPLA.FillByPlanillaEmpresa(dtSALDOPLA, Planilla, Usuario.CodEmpresa)
            If dtSALDOPLA.Count = 0 Then
                filaPLA.PLA_SALDOINI = 0
            Else
                filaPLA.PLA_SALDOINI = filaSALDOPLA.PLA_SALDO
            End If
            filaPLA.PLA_RESCATE = 0
            filaPLA.PLA_RECAUDACION = 0
            filaPLA.PLA_CHEQUESDEV = 0
            filaPLA.PLA_CHEQUESCAR = 0
            filaPLA.PLA_APORTES = 0
            filaPLA.PLA_OTROS = 0
            filaPLA.PLA_PAGOSCHE = 0
            filaPLA.PLA_PAGOSCAR = 0
            filaPLA.PLA_TRANSFERPOS = 0
            filaPLA.PLA_TRANSFERNEG = 0
            filaPLA.PLA_PORCOLOCAR = 0
            filaPLA.PLA_COLOCACIONES = 0
            filaPLA.PLA_SALDO = filaPLA.PLA_SALDOINI
            strAuditoria = ""
            filaPLA.PLA_AUDITORIA = Auditoria(strAuditoria)
            dtPLA.AddTESPLARow(filaPLA)
            taPLA.Update(dtPLA)

        End If
        taCTEPLA.FillByMinimoMaximo(dtCTEPLA, 101, 999)
        Largo = 0
        posicion = 2
        ' limpia planilla
        ''If Me.DataGridView1.Rows > 3 Then
        ''    Me.DataGridView1.Clear
        ''    For i = Me.DataGridView1.Rows - 1 To 3 Step -1
        ''        Me.DataGridView1.RemoveItem i
        ''Next
        ''End If

        For i = 0 To dtCTEPLA.Count - 1
            filaCTEPLA = dtCTEPLA.Item(i)
            taDPLA.FillByPlanillaCuenta(dtDPLA, Planilla, filaCTEPLA.CTE_CODIGO)
            If dtDPLA.Count = 0 Then
                ' ERROR NO HAY Detalle de Planilla, SE CREA VACIA
                Codigo = consulta.Codigo_TesDPL
                ''If IsNull(DE1.rsCodigo_TesDPL!Codigo) Then
                ''    Codigo = 1
                ''Else
                ''    Codigo = DE1.rsCodigo_TesDPL!Codigo
                ''End If
                filaDPLA = dtDPLA.NewDetallePlanillaRow
                filaDPLA.DPL_CODIGO = Codigo
                filaDPLA.PLA_CODIGO = Planilla
                filaDPLA.CTE_CODIGO = filaCTEPLA.CTE_CODIGO
                Dim SaldoAnt As Double = Nothing
                SaldoAnt = consulta.SaldoAnterior(filaCTEPLA.CTE_CODIGO, Planilla)
                If SaldoAnt = Nothing Then
                    filaDPLA.DPL_SALDOINI = 0
                Else
                    filaDPLA.DPL_SALDOINI = SaldoAnt
                End If
                filaDPLA.DPL_RESCATES = 0
                filaDPLA.DPL_RECAUDACION = 0
                filaDPLA.DPL_CHEQUESDEV = 0
                filaDPLA.DPL_CHEQUESCAR = 0
                filaDPLA.DPL_APORTES = 0
                filaDPLA.DPL_OTROSINGRESOS = 0
                filaDPLA.DPL_PAGOSCHE = 0
                filaDPLA.DPL_PAGOSCAR = 0
                filaDPLA.DPL_TRANSFERENCIASPOS = 0
                filaDPLA.DPL_TRANSFERENCIASNEG = 0
                filaDPLA.DPL_PORCOLOCAR = 0
                filaDPLA.DPL_COLOCACIONES = 0
                filaDPLA.DPL_SALDO = filaDPLA.DPL_SALDOINI
                strAuditoria = ""
                filaDPLA.DPL_AUDITORIA = Auditoria(strAuditoria)
                dtDPLA.AddDetallePlanillaRow(filaDPLA)
                taDPLA.Update(dtDPLA)
            End If
        Next
        MostrarPlanilla()
    End Sub
    Private Sub MostrarPlanilla()
        Me.GridGroupingControl1.Reinitialize()
        Me.TESDPLTableAdapter.FillByPlanilla(Me.DsWALPLA.TESDPL, Planilla)
        ' Se eliminan los columnas sin valores
        Dim GrupoSumarias As ISummary
        Dim Info As String
        Dim sumas As String()
        Dim Min As Double
        Dim Max As Double
        Dim n As Integer = 0
        For i = 0 To GridGroupingControl1.TableDescriptor.SummaryRows(0).SummaryColumns.Count - 3
            GrupoSumarias = GridGroupingControl1.Table.TopLevelGroup.GetSummary(i)
            Info = GrupoSumarias.ToString
            sumas = Split(Info, ", ")
            Min = CDbl(sumas(1).Substring(5, Len(sumas(1)) - 5))
            Max = CDbl(sumas(2).Substring(5, Len(sumas(2)) - 5))
            If Min = 0 And Max = 0 Then
                'Se borra
                Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove(Me.GridGroupingControl1.TableDescriptor.ColumnSets.TableDescriptor.VisibleColumns(i + 3 - n).Name)
                Me.GridGroupingControl1.Refresh()
                Me.GridGroupingControl1.Invalidate()
                Me.GridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Table())
                n = n + 1
            End If
        Next
        Colores()

    End Sub


    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        ' Impresión de la Planilla de Operaciones
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptPlanilla00.rpt"
        InfoTag.Numero = 6
        InfoTag.Argumento1lng = Planilla
        InfoTag.Argumento3str = Format(filaPAR.PAR_FECHAPRO, "dddd dd/MM/yyyy")
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent

        Informe.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub frmWALPLA00_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim GrupoSumarias As ISummary
        Dim Info As String
        Dim sumas As String()
        Dim Min As Double
        Dim Max As Double
        Dim n As Integer
        For i = 0 To GridGroupingControl1.TableDescriptor.SummaryRows(0).SummaryColumns.Count - 3
            GrupoSumarias = GridGroupingControl1.Table.TopLevelGroup.GetSummary(i)
            Info = GrupoSumarias.ToString
            sumas = Split(Info, ", ")
            Min = CDbl(sumas(1).Substring(5, Len(sumas(1)) - 5))
            Max = CDbl(sumas(2).Substring(5, Len(sumas(2)) - 5))
            If Min = 0 And Max = 0 Then
                'Se borra

                Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove(Me.GridGroupingControl1.TableDescriptor.ColumnSets.TableDescriptor.VisibleColumns(i + 3 - n).Name)
                Me.GridGroupingControl1.Refresh()
                Me.GridGroupingControl1.Invalidate()
                Me.GridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Table())
                n = n + 1
            End If


        Next
    End Sub
    Private Sub CambioDePiel(piel As Integer)
        Select Case piel
            Case 0
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
            Case 1
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Blue
                GridGroupingControl1.Office2007ScrollBars = True
                GridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
            Case 2
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Black
                GridGroupingControl1.Office2007ScrollBars = True
                GridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
            Case 3
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Silver
                GridGroupingControl1.Office2007ScrollBars = True
                GridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
            Case 4
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Blue
                GridGroupingControl1.Office2007ScrollBars = False
                GridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue
            Case 5
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Black
                GridGroupingControl1.Office2007ScrollBars = False
                GridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
            Case 6
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Silver
                GridGroupingControl1.Office2007ScrollBars = False
                GridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver
            Case 7
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.SystemTheme

        End Select
        GridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 60

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTemas.SelectedIndexChanged
        CambioDePiel(Me.tscbTemas.SelectedIndex)
        Registry.SetValue(keyName, "Planilla", Me.tscbTemas.SelectedIndex)
        Temas.Planilla = Me.tscbTemas.SelectedIndex
    End Sub




    Private Sub DetallesSaldoInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesSaldoInicialToolStripMenuItem.Click
        ' Muestra detalles de Saldo Inicial
        Dim formulario As New frmWALMDE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()
    End Sub

    Private Sub GridGroupingControl1_TableControlCurrentCellControlDoubleClick(sender As Object, e As GridTableControlControlEventArgs) Handles GridGroupingControl1.TableControlCurrentCellControlDoubleClick
        Dim Fila As System.Data.DataRowView
        Fila = TESDPLBindingSource.Current
        Dim campo As String = ""
        Dim celda As GridCurrentCell
        celda = GridGroupingControl1.TableControl.CurrentCell
        Dim estilo As GridTableCellStyleInfo
        estilo = celda.Renderer.CurrentStyle
        Dim NombreColumna As String = estilo.TableCellIdentity.Column.Name

        ' variables Globales
        Glo_Columna = estilo.TableCellIdentity.ColIndex
        Glo_NombreCol = NombreColumna
        Glo_Banco = Fila.Item("ENT_ABREVIATURA").TRIM
        Glo_Cuenta = Fila.Item("CTE_CODIGO")

        Select Case NombreColumna
            Case "DPL_SALDOINI"
                Glo_Caption = "Detalles (Saldo Inicial - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 2
            Case "DPL_RESCATES"
                Glo_Caption = "Detalles (Rescates - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 3
            Case "DPL_RECAUDACION"
                Glo_Caption = "Detalles (Recaudaciones - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 4
            Case "DPL_CHEQUESDEV"
                Glo_Caption = "Detalles (Cheques Devueltos - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 5
            Case "DPL_OTROSINGRESOS"
                Glo_Caption = "Detalles (Otros - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 7
            Case "DPL_PAGOSCHE"
                Glo_Caption = "Detalles (Pagos Con Cheque - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 8
            Case "DPL_CHEQUESCAR"
                Glo_Caption = "Detalles (Cheques en Cartera - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 9
            Case "DPL_PAGOSCAR"
                Glo_Caption = "Detalles (Pagos Con Cargos - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 10
            Case "DPL_TRANSFERENCIASPOS"
                Glo_Caption = "Detalles (Transferencias Positivas - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 11
            Case "DPL_TRANSFERENCIASNEG"
                Glo_Caption = "Detalles (Transferencias Negativas - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 12
            Case "DPL_PORCOLOCAR"
                Glo_Caption = "Detalles (Por Colocar - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 13
            Case "DPL_COLOCACIONES"
                Glo_Caption = "Detalles (Colocaciones- " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 14
            Case "DPL_SALDO"
                Glo_Caption = "Detalles (Saldo Final - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                Glo_Columna = 15
        End Select
        ' Muestra detalles de Saldo Inicial
        If Glo_Columna = 13 Or Glo_Columna = 15 Then
            MsgBox("No existen detalles que desplegar", MsgBoxStyle.Information, NombreSistema)
            Exit Sub
        End If
        Dim formulario As New frmWALMDE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()
    End Sub

    Private Sub tsbCheques_Click(sender As Object, e As EventArgs) Handles tsbCheques.Click
        Me.Cursor = Cursors.WaitCursor
        ' Generación de Cheques
        Dim formulario As New frmWALGMO00
        Dim datos As New Acciones
        datos.accion = 1
        datos.Planilla = Planilla
        formulario.Tag = datos
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        VolverAMostrar()
        'formulario.WindowState = FormWindowState.Normal
        formulario.StartPosition = FormStartPosition.CenterScreen
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tsbRecalcular_Click(sender As Object, e As EventArgs) Handles tsbRecalcular.Click
        VolverAMostrar()

    End Sub
    Private Sub VolverAMostrar()
        GridGroupingControl1.Visible = False
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_SALDOINI") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_SALDOINI")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_RESCATES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_RESCATES")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_RECAUDACION") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_RECAUDACION")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_CHEQUESDEV") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_CHEQUESDEV")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_OTROSINGRESOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_OTROSINGRESOS")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_PAGOSCHE") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_PAGOSCHE")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_CHEQUESCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_CHEQUESCAR")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_PAGOSCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_PAGOSCAR")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_TRANSFERENCIASPOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_TRANSFERENCIASPOS")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_TRANSFERENCIASNEG") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_TRANSFERENCIASNEG")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_PORCOLOCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_PORCOLOCAR")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_COLOCACIONES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_COLOCACIONES")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_SALDO") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("DPL_SALDO")
        End If

        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_SALDOINI") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_SALDOINI")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_RESCATES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_RESCATES")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_RECAUDACION") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_RECAUDACION")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_CHEQUESDEV") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_CHEQUESDEV")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_OTROSINGRESOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_OTROSINGRESOS")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_PAGOSCHE") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_PAGOSCHE")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_CHEQUESCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_CHEQUESCAR")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_PAGOSCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_PAGOSCAR")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_TRANSFERENCIASPOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_TRANSFERENCIASPOS")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_TRANSFERENCIASNEG") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_TRANSFERENCIASNEG")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_PORCOLOCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_PORCOLOCAR")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_COLOCACIONES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_COLOCACIONES")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("DPL_SALDO") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("DPL_SALDO")
        End If
        'For i = 3 To 14
        '    TotalporColumna(parametros.Planilla, i)
        'Next

        'Me.GridGroupingControl1.Refresh()
        'Me.GridGroupingControl1.Invalidate()
        'Me.GridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Table())
        TotalRecaudacion()
        Cargar_planilla()
        tscbTemas.SelectedIndex = Temas.Planilla
        GridGroupingControl1.Visible = True


    End Sub
    Private Sub Colores()
        ' Colorea las columnas
        Dim color1 As Color = Color.FromArgb(255, 42, 77, 105)
        Dim color2 As Color = Color.FromArgb(255, 75, 134, 180)
        Dim color3 As Color = Color.FromArgb(255, 173, 203, 227)
        Dim color4 As Color = Color.FromArgb(255, 231, 239, 246)
        Dim color5 As Color = Color.FromArgb(255, 99, 172, 229)



        For i = 0 To GridGroupingControl1.TableDescriptor.Columns.Count - 1
            If i < 3 Then
                GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.RecordFieldCell.BackColor = color1
                GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.AlternateRecordFieldCell.BackColor = color1
                GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.RecordFieldCell.TextColor = Color.White
                GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.AlternateRecordFieldCell.TextColor = Color.White
            Else
                If i = 3 Then
                    GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.RecordFieldCell.BackColor = color5
                    GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.AlternateRecordFieldCell.BackColor = color5
                Else
                    If i > 3 And i Mod 2 = 0 Then
                        GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.RecordFieldCell.BackColor = color3
                        GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.AlternateRecordFieldCell.BackColor = color3
                    Else
                        GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.RecordFieldCell.BackColor = color4
                        GridGroupingControl1.TableDescriptor.Columns.Item(i).Appearance.AlternateRecordFieldCell.BackColor = color4
                    End If
                End If

            End If
        Next
    End Sub

    Private Sub frmWALPLA00_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Nuevo Then
            VolverAMostrar()
        End If
        Nuevo = False
    End Sub

    Private Sub GridGroupingControl1_TableControlCellMouseUp(sender As Object, e As GridTableControlCellMouseEventArgs) Handles GridGroupingControl1.TableControlCellMouseUp
        Dim col As Integer = e.Inner.ColIndex
        Dim fil As Integer = e.Inner.RowIndex

        Dim boton As Integer = e.Inner.MouseEventArgs.Button
        GridGroupingControl1.Focus()

        If boton = MouseButtons.Right Then
            'If MouseButtons.Right Then
            Dim Fila As System.Data.DataRowView
            Fila = TESDPLBindingSource.Current
            Dim campo As String = ""
            Dim celda As GridCurrentCell
            celda = GridGroupingControl1.TableControl.CurrentCell
            Dim estilo As GridTableCellStyleInfo
            estilo = celda.Renderer.CurrentStyle
            Dim NombreColumna As String = estilo.TableCellIdentity.Column.Name

            ' variables Globales
            Glo_Columna = estilo.TableCellIdentity.ColIndex
            Glo_NombreCol = NombreColumna
            Glo_Banco = Fila.Item("ENT_ABREVIATURA").TRIM
            Glo_Cuenta = Fila.Item("CTE_CODIGO")
            cmsPlanilla.Items(4).Text = "Ingreso de Rescates (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(5).Text = "Ingreso de Recaudaciones (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(6).Text = "Ingreso de Cheques Devueltos (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(8).Text = "Ingreso de Otros Ingresos (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(9).Text = "Ingreso de Pagos Con Cheque (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(7).Text = "Ingreso de Cheques en Cartera (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(10).Text = "Ingreso de Pagos Con Cargo (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(11).Text = "Ingreso de Transferencias Positivas (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
            cmsPlanilla.Items(12).Text = "Ingreso de Transferencias Negativas (" & Fila.Item("ENT_ABREVIATURA").TRIM & ")"

            Select Case NombreColumna

                Case "DPL_SALDOINI"
                    cmsPlanilla.Items(0).Text = "Detalles (Saldo Inicial - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Saldo Inicial - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 2
                Case "DPL_RESCATES"
                    cmsPlanilla.Items(0).Text = "Detalles (Rescates - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Rescates - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 3
                    cmsPlanilla.Items(3).Visible = True

                Case "DPL_RECAUDACION"
                    cmsPlanilla.Items(0).Text = "Detalles (Recaudaciones - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Recaudaciones - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 4
                    cmsPlanilla.Items(4).Visible = True
                Case "DPL_CHEQUESDEV"
                    cmsPlanilla.Items(0).Text = "Detalles (Cheques Devueltos - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Cheques Devueltos - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 5
                    cmsPlanilla.Items(5).Visible = True
                Case "DPL_OTROSINGRESOS"
                    cmsPlanilla.Items(0).Text = "Detalles (Otros - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Otros - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 7
                    cmsPlanilla.Items(7).Visible = True
                Case "DPL_PAGOSCHE"
                    cmsPlanilla.Items(0).Text = "Detalles (Pagos Con Cheque - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Pagos Con Cheque - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 8
                    cmsPlanilla.Items(8).Visible = True
                Case "DPL_CHEQUESCAR"
                    cmsPlanilla.Items(0).Text = "Detalles (Cheques en Cartera - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Cheques en Cartera - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 9
                    cmsPlanilla.Items(6).Visible = True
                Case "DPL_PAGOSCAR"
                    cmsPlanilla.Items(0).Text = "Detalles (Pagos Con Cargos - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Pagos Con Cargos - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 10
                    cmsPlanilla.Items(9).Visible = True
                Case "DPL_TRANSFERENCIASPOS"
                    cmsPlanilla.Items(0).Text = "Detalles (Transferencias Positivas - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Transferencias Positivas - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 11
                    cmsPlanilla.Items(10).Visible = True
                Case "DPL_TRANSFERENCIASNEG"
                    cmsPlanilla.Items(0).Text = "Detalles (Transferencias Negativas - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Transferencias Negativas - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 12
                    cmsPlanilla.Items(11).Visible = True
                Case "DPL_PORCOLOCAR"
                    cmsPlanilla.Items(0).Text = "Detalles (Por Colocar - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Por Colocar - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 13
                Case "DPL_COLOCACIONES"
                    cmsPlanilla.Items(0).Text = "Detalles (Colocaciones- " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Colocaciones- " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 14
                Case "DPL_SALDO"
                    cmsPlanilla.Items(0).Text = "Detalles (Saldo Final - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Caption = "Detalles (Saldo Final - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 15
            End Select

            GridGroupingControl1.ContextMenuStrip = cmsPlanilla
            GridGroupingControl1.ContextMenuStrip.Show(GridGroupingControl1, e.Inner.MouseEventArgs.Location)

            'End If
        Else
        End If
    End Sub

    Private Sub TransferenciasBancariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferenciasBancariasToolStripMenuItem.Click
        ' Generación de Cheques
        Dim formulario As New frmWALTRB00
        Dim datos As New Acciones
        datos.accion = 1
        datos.Planilla = Planilla
        formulario.Tag = datos
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub IngresoDeRescatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeRescatesToolStripMenuItem.Click
        ' Ingreso de Rescates
        Glo_Ingreso = 1
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub
    Private Sub IngresoDeChequesDevueltosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeChequesDevueltosToolStripMenuItem.Click
        ' Ingreso de Cheques Devueltos
        Glo_Ingreso = 2
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub
    Private Sub IngresoDeOtrosIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeOtrosIngresosToolStripMenuItem.Click
        ' Ingreso de Otros Ingresos
        Glo_Ingreso = 4
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub

    Private Sub IngresoDePagosDeChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDePagosDeChequesToolStripMenuItem.Click
        ' Ingreso de Pagos con Cheques
        Glo_Ingreso = 5
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub
    Private Sub IngresoDePagosConCargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDePagosConCargosToolStripMenuItem.Click
        ' Ingreso de Pagos con Cargo
        Glo_Ingreso = 6
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub
    Private Sub IngresoDeTransferenciasPositivasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeTransferenciasPositivasToolStripMenuItem.Click
        ' Ingreso de Transferencias Positivas
        Glo_Ingreso = 7
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub

    Private Sub IngresoDeTransferenciasNegativasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeTransferenciasNegativasToolStripMenuItem.Click
        ' Ingreso de Transferencias Negativas
        Glo_Ingreso = 8
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub
    Private Sub IngresoDeRecaudacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeRecaudacionesToolStripMenuItem.Click
        ' Ingreso de Recaudaciones
        Glo_Ingreso = 9
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub


    Private Sub IngresoDeChequesEnCarteraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeChequesEnCarteraToolStripMenuItem.Click
        ' Ingreso de Cheques en Cartera
        Glo_Ingreso = 10
        Dim formulario As New frmWALIRE00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

    End Sub

    Private Sub tsbRecaudación_Click(sender As Object, e As EventArgs) Handles tsbRecaudación.Click
        Dim formulario As New frmWALTREC00
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()

        If Glo_NoMostrar Then
            formulario.Close()
            Glo_NoMostrar = False
        End If
    End Sub

    Private Sub GeneraciónDeChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciónDeChequesToolStripMenuItem.Click
        ' Generación de Cheques
        Me.Cursor = Cursors.WaitCursor
        Dim formulario As New frmWALGMO00
        Dim datos As New Acciones
        datos.accion = 1
        datos.Planilla = Planilla
        formulario.Tag = datos
        'formulario.MdiParent = MDIPrincipal
        formulario.ShowDialog()
        'formulario.WindowState = FormWindowState.Normal
        VolverAMostrar()
        Me.Cursor = Cursors.Default
    End Sub

End Class