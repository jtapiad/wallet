Imports ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Microsoft.Win32
Imports Syncfusion.Grouping
Imports System.ComponentModel

Public Class frmWALCUA00
    Dim Bloqueo As Boolean
    Dim fecha As Date
    Dim taPAR As New dsWALCUATableAdapters.TESPARTableAdapter
    Dim dtPAR As New dsWALCUA.TESPARDataTable
    Dim filaPAR As dsWALCUA.TESPARRow
    Dim taREC As New dsWALPLATableAdapters.TotalesRECTableAdapter
    Dim dtREC As New dsWALPLA.TotalesRECDataTable
    Dim filaREC As dsWALPLA.TotalesRECRow
    Dim taPLA As New dsWALPLATableAdapters.TESPLATableAdapter
    Dim dtPLA As New dsWALPLA.TESPLADataTable
    Dim filaPLA As dsWALPLA.TESPLARow
    Dim taDPLA As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
    Dim dtDPLA As New dsWALPLA.DetallePlanillaDataTable
    Dim filaDPLA As dsWALPLA.DetallePlanillaRow
    Dim taDPLA2 As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
    Dim dtDPLA2 As New dsWALPLA.DetallePlanillaDataTable
    Dim filaDPLA2 As dsWALPLA.DetallePlanillaRow
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
    Dim taPLATOT As New dsWALCUATableAdapters.TESDPLTableAdapter
    Dim dtPLATOT As New dsWALCUA.TESDPLDataTable
    Dim filaPLATOT As dsWALCUA.TESDPLRow

    Dim taCUA As New dsWALCUATableAdapters.TESCUATableAdapter
    Dim dtCUA As New dsWALCUA.TESCUADataTable
    Dim filaCUA As dsWALCUA.TESCUARow


    Dim TotalSaldo As Double
    Dim Cierres() As Cierre
    Dim Registros As Integer
    Dim estado As String
    ' Rescates
    Dim taRESC As New dsWALCUATableAdapters.OP_Trae2RescatesTableAdapter
    Dim dtRESC As New dsWALCUA.OP_Trae2RescatesDataTable
    Dim filaRESC As dsWALCUA.OP_Trae2RescatesRow
    ' Recaudación
    Dim taRECA As New dsWALCUATableAdapters.OP_TraeRecaudacionTableAdapter
    Dim dtRECA As New dsWALCUA.OP_TraeRecaudacionDataTable
    Dim filaRECA As dsWALCUA.OP_TraeRecaudacionRow
    ' Cheques Devueltos
    Dim taCHDV As New dsWALCUATableAdapters.OP_Trae2ChequesDevueltosTableAdapter
    Dim dtCHDV As New dsWALCUA.OP_Trae2ChequesDevueltosDataTable
    Dim filaCHDV As dsWALCUA.OP_Trae2ChequesDevueltosRow
    ' Otros Ingresoso
    Dim taOTIN As New dsWALCUATableAdapters.OP_Trae2OtrosIngresosTableAdapter
    Dim dtOTIN As New dsWALCUA.OP_Trae2OtrosIngresosDataTable
    Dim filaOTIN As dsWALCUA.OP_Trae2OtrosIngresosRow
    ' Otros Ingresoso
    Dim taPACH As New dsWALCUATableAdapters.OP_TraePagosConChequeTableAdapter
    Dim dtPACH As New dsWALCUA.OP_TraePagosConChequeDataTable
    Dim filaPACH As dsWALCUA.OP_TraePagosConChequeRow
    ' Otros Cargos
    Dim taOTCA As New dsWALCUATableAdapters.OP_TraeOtrosCargosTableAdapter
    Dim dtOTCA As New dsWALCUA.OP_TraeOtrosCargosDataTable
    Dim filaOTCA As dsWALCUA.OP_TraeOtrosCargosRow
    ' Transferencia Positiva
    Dim taTRPO As New dsWALCUATableAdapters.OP_TraeTransferenciasPosTableAdapter
    Dim dtTRPO As New dsWALCUA.OP_TraeTransferenciasPosDataTable
    Dim filaTRPO As dsWALCUA.OP_TraeTransferenciasPosRow
    ' Transferencia Negativa
    Dim taTRNE As New dsWALCUATableAdapters.OP_TraeTransferenciasNegTableAdapter
    Dim dtTRNE As New dsWALCUA.OP_TraeTransferenciasNegDataTable
    Dim filaTRNE As dsWALCUA.OP_TraeTransferenciasNegRow
    ' Colocaciones
    Dim taCOLO As New dsWALCUATableAdapters.OP_TraeColocacionesTableAdapter
    Dim dtCOLO As New dsWALCUA.OP_TraeColocacionesDataTable
    Dim filaCOLO As dsWALCUA.OP_TraeColocacionesRow
    ' Feriados
    Dim taFER As New dsWALFERTableAdapters.TESFERTableAdapter
    Dim dtFER As New dsWALFER.TESFERDataTable
    ' Totales por planilla, actualiza Planilla
    Dim taACP As New dsWALCUATableAdapters.Actualiza_PlanillaTableAdapter
    Dim dtACP As New dsWALCUA.Actualiza_PlanillaDataTable
    Dim filaACP As dsWALCUA.Actualiza_PlanillaRow
    ' Detalles Operacionales del Cierre
    Dim taDOP As New dsWALCUATableAdapters.TESDOPTableAdapter
    Dim dtDOP As New dsWALCUA.TESDOPDataTable
    Dim filaDOP As dsWALCUA.TESDOPRow
    Dim taDOP2 As New dsWALCUATableAdapters.TESDOPTableAdapter
    Dim dtDOP2 As New dsWALCUA.TESDOPDataTable
    Dim filaDOP2 As dsWALCUA.TESDOPRow
    ' Tabla de Diferencias
    Dim dtDIF As New dsWALCUA.DiferenciasDataTable
    Dim FilaDIF As dsWALCUA.DiferenciasRow




    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        'AddHandler GridGroupingControl1.QueryCustomSummary, AddressOf gridGroupingControl1_QueryCustomSummary

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.WindowState = FormWindowState.Maximized

        Bloqueo = False
        taPAR.Fill(dtPAR)
        If dtPAR.Count <> 1 Then
            MsgBox("Se detecto un problema en el archivo de Parámetros." & vbCrLf & "Favor comunicarse con soporte", MsgBoxStyle.Critical, NombreSistema)
        Else
            filaPAR = dtPAR.Item(0)
        End If
        'Titulo.Text = "Verificación de Planilla de Operaciones del " & Format(filaPAR.PAR_FECHAPRO, "dddd dd/MM/yyyy")
        'If filaPAR.PAR_ACTUALIZA Then
        '    Me.Imagen1.Visible = True
        '    Me.Imagen1.Image = My.Resources.FACE01
        'Else
        '    Me.Imagen1.Visible = False
        'End If
        fecha = filaPAR.PAR_FECHAPRO
        ' Verifica estados
        Planilla = filaPAR.PAR_PLANILLA
        If filaPAR.PAR_ESTADOPLA = "A" Then
            ' PLANILLA ACTIVA
            estado = "OK"
            tsbEstadoOK.Visible = True

        ElseIf filaPAR.PAR_ESTADOPLA = "B" Then
            ' PLANILLA BLOQUEDA
            estado = "KO"
            tsbEstadoKO.Visible = True
            Bloqueo = True
        End If
        ' Verifica Saldos
        If filaPAR.PAR_ESTADOPLA = "A" Then


            taPLATOT.FillByPlanilla(dtPLATOT, Planilla)
            TotalSaldo = 0
            If dtPLATOT.Count > 0 Then
                For i = 0 To dtPLATOT.Count - 1
                    filaPLATOT = dtPLATOT.Item(i)
                    TotalSaldo = TotalSaldo + filaPLATOT.DPL_SALDO
                Next
                If TotalSaldo <= filaPAR.PAR_LIMITECIERRE Then
                    estado = "OK"
                    tsbEstadoOK.Visible = True
                    tsbEstadoKO.Visible = False
                Else
                    estado = "KO"
                    tsbEstadoKO.Visible = True
                    tsbEstadoKO.Text = "Planilla se encuentra sobre el limite de cierre"
                    tsbEstadoOK.Visible = False
                    Bloqueo = True
                    'MsgBox("Planilla se encuentra sobre el limite de cierre, se suspende el proceso.", MsgBoxStyle.Exclamation, NombreSistema)
                    'Me.Close()
                    'Exit Sub
                End If
            Else
                estado = "KO"
                tsbEstadoKO.Visible = True
                tsbEstadoOK.Visible = False
                MsgBox("Planilla no se encuentra activa, se suspende el proceso.", MsgBoxStyle.Exclamation, NombreSistema)
                Me.Close()
                Exit Sub
            End If
        Else
            MsgBox("Planilla no se encuentra activa, se suspende el proceso.", MsgBoxStyle.Exclamation, NombreSistema)
            Me.Close()
            Exit Sub
        End If
        ' inicializa tabla de Cuadratura
        tscbTemas.SelectedIndex = Temas.Cierre

        GridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 35




    End Sub

    Private Sub frmWALCUA00_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DsWALCUA.TraeCuadratura' Puede moverla o quitarla según sea necesario.
        Me.TraeCuadraturaTableAdapter.Fill(Me.DsWALCUA.TraeCuadratura)
        CargarDatos()

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
    Private Sub CargarDatos()
        GridGroupingControl1.Refresh()
        Me.GridGroupingControl1.GetTableDescriptor("TraeCuadratura").FrozenColumn = "CTE_CUENTA"
        taPLATOT.FillByPlanilla(dtPLATOT, Planilla)
        dtCUA.Clear()
        Dim borrador As New dsWALCUATableAdapters.QueriesTableAdapter
        borrador.BorraCuadratura()
        For i = 0 To dtPLATOT.Count - 1
            filaPLATOT = dtPLATOT.Item(i)
            filaCUA = dtCUA.NewTESCUARow
            filaCUA.CTE_CODIGO = filaPLATOT.CTE_CODCTE
            filaCUA.PLA_CODIGO = filaPLATOT.PLA_CODIGO
            filaCUA.CUA_APORTES = filaPLATOT.DPL_APORTES
            filaCUA.CUA_COLOCACIONES = filaPLATOT.DPL_COLOCACIONES
            filaCUA.CUA_CHEQUESDEV = filaPLATOT.DPL_CHEQUESDEV
            filaCUA.CUA_CHEQUESCAR = filaPLATOT.DPL_CHEQUESCAR
            filaCUA.CUA_OTROSINGRESOS = filaPLATOT.DPL_OTROSINGRESOS
            filaCUA.CUA_PAGOSCAR = filaPLATOT.DPL_PAGOSCAR
            filaCUA.CUA_PAGOSCHE = filaPLATOT.DPL_PAGOSCHE
            filaCUA.CUA_PORCOLOCAR = filaPLATOT.DPL_PORCOLOCAR
            filaCUA.CUA_RECAUDACION = filaPLATOT.DPL_RECAUDACION
            filaCUA.CUA_RESCATES = filaPLATOT.DPL_RESCATES
            filaCUA.CUA_SALDO = filaPLATOT.DPL_SALDO
            filaCUA.CUA_SALDOINI = filaPLATOT.DPL_SALDOINI
            filaCUA.CUA_TRANSFERENCIASNEG = filaPLATOT.DPL_TRANSFERENCIASNEG
            filaCUA.CUA_TRANSFERENCIASPOS = filaPLATOT.DPL_TRANSFERENCIASPOS
            dtCUA.AddTESCUARow(filaCUA)
        Next
        taCUA.Update(dtCUA)
        TraeRescates()
        TraeRecaudacion()
        TraeChequesDevueltos()
        TraeOtrosIngresos()
        TraePagosConCheques()
        TraeOtrosCargos()
        TraeTransferenciasPos()
        TraeTransferenciasNeg()
        TraeColocaciones()
        TotalesH()
        MostrarPlanilla()
    End Sub
    Private Sub MostrarPlanilla()
        Me.TraeCuadraturaTableAdapter.Fill(Me.DsWALCUA.TraeCuadratura)

        ' Se eliminan los columnas sin valores
        Dim GrupoSumarias As ISummary
        Dim Info As String
        Dim sumas As String()
        Dim Min As Double
        Dim Max As Double
        Dim Min1 As Double
        Dim Max1 As Double
        Dim n As Integer = 0
        For i = 0 To GridGroupingControl1.TableDescriptor.SummaryRows(0).SummaryColumns.Count - 1
            GrupoSumarias = GridGroupingControl1.Table.TopLevelGroup.GetSummary(i)
            Info = GrupoSumarias.ToString
            sumas = Split(Info, ", ")
            Min = CDbl(sumas(1).Substring(5, Len(sumas(1)) - 5))
            Max = CDbl(sumas(2).Substring(5, Len(sumas(2)) - 5))
            If i > 0 And i < 22 Then

                If i Mod 2 = 1 Then
                    Min1 = Min
                    Max1 = Max
                Else
                    If Min1 = 0 And Min = 0 And Max1 = 0 And Max = 0 Then
                        Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove(Me.GridGroupingControl1.TableDescriptor.ColumnSets.TableDescriptor.VisibleColumns(i + 3 - n).Name)
                        Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove(Me.GridGroupingControl1.TableDescriptor.ColumnSets.TableDescriptor.VisibleColumns(i + 2 - n).Name)
                        Me.GridGroupingControl1.Refresh()
                        Me.GridGroupingControl1.Invalidate()
                        Me.GridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Table())
                        n = n + 2
                    End If
                End If

            End If
        Next
        Colores()
    End Sub
    Private Sub TraeRescates()
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taRESC.Fill(dtRESC)
        If dtRESC.Count > 0 Then
            For i = 0 To dtRESC.Count - 1
                filaRESC = dtRESC.Item(i)
                Cuenta = CLng(Mid(filaRESC.daz_cuentabanco, 1, Len(Trim(filaRESC.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                If dtCTE.Count > 0 Then
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_RESCATES2 = filaRESC.totales
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Private Sub TraeRecaudacion()
        Dim fECHA As String = Format(filaPAR.PAR_FECHAPRO, "dd/MM/yyyy")
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taRECA.Fill(dtRECA, fECHA)
        If dtRECA.Count > 0 Then
            For i = 0 To dtRECA.Count - 1
                filaRECA = dtRECA.Item(i)
                Cuenta = CLng(Mid(filaRECA.daz_cuentabanco, 1, Len(Trim(filaRECA.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                If dtCTE.Count > 0 Then
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_RECAUDACION2 = filaRECA.totales
                        End If
                    Next
                End If
            Next
            taCUA.Update(dtCUA)
        End If
    End Sub
    Private Sub TraeChequesDevueltos()
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taCHDV.Fill(dtCHDV)
        If dtCHDV.Count > 0 Then
            For i = 0 To dtCHDV.Count - 1
                filaCHDV = dtCHDV.Item(i)
                Cuenta = CLng(Mid(filaCHDV.daz_cuentabanco, 1, Len(Trim(filaCHDV.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                If dtCTE.Count > 0 Then
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_CHEQUESDEV2 = filaCHDV.totales
                        End If
                    Next
                End If
            Next
            taCUA.Update(dtCUA)
        End If

    End Sub
    Private Sub TraeOtrosIngresos()
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taOTIN.Fill(dtOTIN)
        If dtOTIN.Count > 0 Then
            For i = 0 To dtOTIN.Count - 1
                filaOTIN = dtOTIN.Item(i)
                Cuenta = CLng(Mid(filaOTIN.daz_cuentabanco, 1, Len(Trim(filaOTIN.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                If dtCTE.Count > 0 Then
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_OTROSINGRESOS2 = filaOTIN.totales
                        End If
                    Next
                End If
            Next
            taCUA.Update(dtCUA)
        End If
    End Sub
    Private Sub TraePagosConCheques()
        Dim Fecha As String = Format(filaPAR.PAR_FECHAPRO, "dd/MM/yyyy")
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taPACH.Fill(dtPACH, Fecha)
        If dtPACH.Count > 0 Then
            For i = 0 To dtPACH.Count - 1
                filaPACH = dtPACH.Item(i)
                Cuenta = CLng(Mid(filaPACH.daz_cuentabanco, 1, Len(Trim(filaPACH.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                If dtCTE.Count > 0 Then
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_PAGOSCHE2 = filaPACH.totales
                        End If
                    Next
                End If
            Next
            taCUA.Update(dtCUA)
        End If
    End Sub

    'Private Sub CargarColumna(c As Integer, Registros As Recordset)
    '    ' Cargar Columna en la Planilla
    '    Do Until Registros.EOF
    '        Cuenta = CLng(Mid(Registros!daz_cuentabanco, 1, Len(Trim(Registros!daz_cuentabanco)) - 1) & "2")
    '        Clave = Format(Cuenta, "0000000000")
    '        On Error Resume Next
    '        DE1.rsTraeCuenta.Close
    '        On Error GoTo 0
    '        DE1.TraeCuenta Clave
    '    If Not DE1.rsTraeCuenta.EOF Then
    '            Me.MSFlexGrid1.Col = 2
    '            For i = 2 To Me.MSFlexGrid1.Rows - 3
    '                Me.MSFlexGrid1.Row = i
    '                If Me.MSFlexGrid1.Text = DE1.rsTraeCuenta!cte_cuenta Then
    '                    Me.MSFlexGrid1.Col = c
    '                    Me.MSFlexGrid1.CellAlignment = flexAlignRightCenter
    '                    Me.MSFlexGrid1.Text = Registros!Totales
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '        Registros.MoveNext
    '    Loop
    'End Sub



    Private Sub TraeOtrosCargos()
        Dim Fecha As String = Format(filaPAR.PAR_FECHAPRO, "dd/MM/yyyy")
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taOTCA.Fill(dtOTCA, Fecha)
        If dtOTCA.Count > 0 Then
            For i = 0 To dtOTCA.Count - 1
                filaOTCA = dtOTCA.Item(i)
                Cuenta = CLng(Mid(filaOTCA.daz_cuentabanco, 1, Len(Trim(filaOTCA.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                If dtCTE.Count > 0 Then
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_PAGOSCAR2 = filaOTCA.totales
                        End If
                    Next
                End If
            Next
            taCUA.Update(dtCUA)
        End If
    End Sub
    Private Sub TraeTransferenciasPos()
        Dim Fecha As String = Format(filaPAR.PAR_FECHAPRO, "dd/MM/yyyy")
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taTRPO.Fill(dtTRPO, Fecha)
        If dtTRPO.Count > 0 Then
            For i = 0 To dtTRPO.Count - 1
                filaTRPO = dtTRPO.Item(i)
                Cuenta = CLng(Mid(filaTRPO.daz_cuentabanco, 1, Len(Trim(filaTRPO.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                If dtCTE.Count > 0 Then
                    filaCTE = dtCTE.Item(0)
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_TRANSFERENCIASPOS2 = filaTRPO.totales
                        End If
                    Next
                End If
            Next
            taCUA.Update(dtCUA)
        End If
    End Sub
    Private Sub TraeTransferenciasNeg()
        Dim Fecha As String = Format(filaPAR.PAR_FECHAPRO, "dd/MM/yyyy")
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taTRNE.Fill(dtTRNE, Fecha)
        If dtTRNE.Count > 0 Then
            For i = 0 To dtTRNE.Count - 1
                filaTRNE = dtTRNE.Item(i)
                Cuenta = CLng(Mid(filaTRNE.daz_cuentabanco, 1, Len(Trim(filaTRNE.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                If dtCTE.Count > 0 Then
                    For j = 0 To dtCUA.Count - 1
                        filaCUA = dtCUA.Item(j)
                        If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                            filaCUA.CUA_TRANSFERENCIASNEG2 = filaTRNE.totales
                        End If
                    Next
                End If
            Next
            taCUA.Update(dtCUA)
        End If
    End Sub
    Private Sub TraeColocaciones()
        Dim Fecha As String = Format(filaPAR.PAR_FECHAPRO, "dd/MM/yyyy")
        Dim Cuenta As Long
        Dim Clave As String
        Dim taCTE As New dsWALCUATableAdapters.TESCTETableAdapter
        Dim dtCTE As New dsWALCUA.TESCTEDataTable
        Dim filaCTE As dsWALCUA.TESCTERow
        taCOLO.Fill(dtCOLO, Fecha)
        If dtCOLO.Count > 0 Then
            For i = 0 To dtCOLO.Count - 1
                filaCOLO = dtCOLO.Item(i)
                Cuenta = CLng(Mid(filaCOLO.daz_cuentabanco, 1, Len(Trim(filaCOLO.daz_cuentabanco)) - 1) & "2")
                Clave = Format(Cuenta, "0000000000")
                taCTE.FillByCuenta(dtCTE, Clave)
                filaCTE = dtCTE.Item(0)
                For j = 0 To dtCUA.Count - 1
                    filaCUA = dtCUA.Item(j)
                    If filaCUA.CTE_CODIGO = filaCTE.CTE_CODCTE Then
                        filaCUA.CUA_COLOCACIONES2 = filaCOLO.totales
                    End If
                Next
            Next
            taCUA.Update(dtCUA)
        End If

    End Sub
    Private Sub TotalesH()
        taCUA.Fill(dtCUA)
        For i = 0 To dtCUA.Count - 1
            filaCUA = dtCUA.Item(i)
            Dim dblSaldoIni As Double = 0
            Dim dblRescate2 As Double = 0
            Dim dblRecaudacion2 As Double = 0
            Dim dblChequesDev2 As Double = 0
            Dim dblOtrosIngresos2 As Double = 0
            Dim dblPagosChe2 As Double = 0
            Dim dblPagosCar2 As Double = 0
            Dim dblChequesCar2 As Double = 0
            Dim dblSaldoIni2 As Double = 0
            Dim dblTransferenciaPos2 As Double = 0
            Dim dblTransferenciaNeg2 As Double = 0
            Dim dblColocaciones2 As Double = 0
            Dim dblRescate As Double = 0
            Dim dblRecaudacion As Double = 0
            Dim dblChequesDev As Double = 0
            Dim dblOtrosIngresos As Double = 0
            Dim dblPagosChe As Double = 0
            Dim dblPagosCar As Double = 0
            Dim dblChequesCar As Double = 0
            Dim dblTransferenciaPos As Double = 0
            Dim dblTransferenciaNeg As Double = 0
            Dim dblColocaciones As Double = 0
            If Not filaCUA.IsCUA_SALDOININull Then
                dblSaldoIni = filaCUA.CUA_SALDOINI
            End If
            If Not filaCUA.IsCUA_RESCATES2Null Then
                dblRescate2 = filaCUA.CUA_RESCATES2
            End If
            If Not filaCUA.IsCUA_RECAUDACION2Null Then
                dblRecaudacion2 = filaCUA.CUA_RECAUDACION2
            End If
            If Not filaCUA.IsCUA_CHEQUESDEV2Null Then
                dblChequesDev2 = filaCUA.CUA_CHEQUESDEV2
            End If
            If Not filaCUA.IsCUA_OTROSINGRESOS2Null Then
                dblOtrosIngresos2 = filaCUA.CUA_OTROSINGRESOS2
            End If
            If Not filaCUA.IsCUA_PAGOSCHE2Null Then
                dblPagosChe2 = filaCUA.CUA_PAGOSCHE2
            End If
            If Not filaCUA.IsCUA_PAGOSCAR2Null Then
                dblPagosCar2 = filaCUA.CUA_PAGOSCAR2
            End If
            If Not filaCUA.IsCUA_CHEQUESCAR2Null Then
                dblChequesCar2 = filaCUA.CUA_CHEQUESCAR2
            End If
            If Not filaCUA.IsCUA_TRANSFERENCIASPOS2Null Then
                dblTransferenciaPos2 = filaCUA.CUA_TRANSFERENCIASPOS2
            End If
            If Not filaCUA.IsCUA_TRANSFERENCIASNEG2Null Then
                dblTransferenciaNeg2 = filaCUA.CUA_TRANSFERENCIASNEG2
            End If
            If Not filaCUA.IsCUA_COLOCACIONES2Null Then
                dblColocaciones2 = filaCUA.CUA_COLOCACIONES2
            End If
            If Not filaCUA.IsCUA_RESCATESNull Then
                dblRescate = filaCUA.CUA_RESCATES
            End If
            If Not filaCUA.IsCUA_RECAUDACIONNull Then
                dblRecaudacion = filaCUA.CUA_RECAUDACION
            End If
            If Not filaCUA.IsCUA_CHEQUESDEVNull Then
                dblChequesDev = filaCUA.CUA_CHEQUESDEV
            End If
            If Not filaCUA.IsCUA_OTROSINGRESOSNull Then
                dblOtrosIngresos = filaCUA.CUA_OTROSINGRESOS
            End If
            If Not filaCUA.IsCUA_PAGOSCHENull Then
                dblPagosChe = filaCUA.CUA_PAGOSCHE
            End If
            If Not filaCUA.IsCUA_PAGOSCARNull Then
                dblPagosCar = filaCUA.CUA_PAGOSCAR
            End If
            If Not filaCUA.IsCUA_CHEQUESCARNull Then
                dblChequesCar = filaCUA.CUA_CHEQUESCAR
            End If
            If Not filaCUA.IsCUA_TRANSFERENCIASPOSNull Then
                dblTransferenciaPos = filaCUA.CUA_TRANSFERENCIASPOS
            End If
            If Not filaCUA.IsCUA_TRANSFERENCIASNEGNull Then
                dblTransferenciaNeg = filaCUA.CUA_TRANSFERENCIASNEG
            End If
            If Not filaCUA.IsCUA_COLOCACIONESNull Then
                dblColocaciones = filaCUA.CUA_COLOCACIONES
            End If
            filaCUA.CUA_SALDO2 = dblSaldoIni + dblRescate2 + dblRecaudacion2 - dblChequesDev2 + dblOtrosIngresos2 - dblPagosChe2 - dblPagosCar2 + dblChequesCar2 + dblTransferenciaPos2 - dblTransferenciaNeg2 - dblColocaciones2
            filaCUA.CUA_PROXIMOSALDO = filaCUA.CUA_SALDO2
            taCUA.Update(dtCUA)
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
        GridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 35

    End Sub

    Private Sub tscbTemas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTemas.SelectedIndexChanged
        CambioDePiel(Me.tscbTemas.SelectedIndex)
        Registry.SetValue(keyName, "Cierre", Me.tscbTemas.SelectedIndex)
        Temas.Cierre = Me.tscbTemas.SelectedIndex

    End Sub



    Private Sub gridGroupingControl1_QueryCustomSummary(ByVal sender As Object, ByVal e As GridQueryCustomSummaryEventArgs) Handles GridGroupingControl1.QueryCustomSummary
        If e.SummaryColumn.Name = "DifRescates" Then
            'e.SummaryDescriptor.CreateSummaryMethod = New CreateSummaryDelegate(Diferencia.CreateSummaryMethod)
        End If
    End Sub

    Private Sub tsbCierra_Click(sender As Object, e As EventArgs) Handles tsbCierra.Click
        TraeCuadraturaBindingSource.EndEdit()
        ' cerrar el día
        ' determinar proximo día habil
        ' generar registros
        ' cerrar planilla actual
        ' grabar totales
        'Dim numFecha As Double
        Dim datFecha As Date
        Dim Colchon As Double
        Dim Codigo As Long
        Dim Cartera As Integer
        datFecha = filaPAR.PAR_FECHAPRO
        For i = 1 To 7
            datFecha = datFecha.AddDays(1)
            taFER.FillByFecha(dtFER, datFecha)
            If dtFER.Count = 0 Then
                Exit For
            End If
        Next





        ' se cierra el día
        ' proximo dia habil
        ' datfecha=fecha proximo día habil
        If MsgBox("El proximo día habíl a procesar es el " & Format(datFecha, "dddd dd/MMMM/yyyy"), vbInformation + vbYesNo, "Mensaje del Sistema") = MsgBoxResult.No Then
            Exit Sub
        End If

        taPLA.FillByPlanilla(dtPLA, filaPAR.PAR_PLANILLA)
        taACP.FillByPlanilla(dtACP, filaPAR.PAR_PLANILLA)
        filaACP = dtACP.Item(0)

        filaPLA = dtPLA.Item(0)
        filaPLA.PLA_SALDOINI = filaACP.Total1
        filaPLA.PLA_RESCATE = filaACP.Total2
        filaPLA.PLA_RECAUDACION = filaACP.Total3
        filaPLA.PLA_CHEQUESDEV = filaACP.Total4
        filaPLA.PLA_CHEQUESCAR = filaACP.Total8
        filaPLA.PLA_APORTES = filaACP.Total5
        filaPLA.PLA_OTROS = filaACP.Total6
        filaPLA.PLA_PAGOSCHE = filaACP.Total7
        filaPLA.PLA_PAGOSCAR = filaACP.total14
        filaPLA.PLA_TRANSFERPOS = filaACP.Total9
        filaPLA.PLA_TRANSFERNEG = filaACP.Total10
        filaPLA.PLA_PORCOLOCAR = filaACP.Total11
        filaPLA.PLA_COLOCACIONES = filaACP.Total12
        filaPLA.PLA_SALDO = filaACP.total13
        filaPLA.PLA_AUDITORIA = Auditoria(filaPLA.PLA_AUDITORIA)
        taPLA.Update(dtPLA)


        ' se Inicializa nueva planilla
        filaPAR.PAR_PLANILLA = filaPAR.PAR_PLANILLA + 1
        filaPAR.PAR_FECHAPRO = datFecha
        Try
            filaPAR.PAR_AUDITORIA = Auditoria(filaPAR.PAR_AUDITORIA)

        Catch ex As Exception
            filaPAR.PAR_AUDITORIA = Auditoria("")
        End Try
        taPAR.Update(dtPAR)
        DetallePla.Fecha = datFecha
        DetallePla.Planilla = filaPAR.PAR_PLANILLA
        parametros.Planilla = filaPAR.PAR_PLANILLA
        parametros.FechaPro = filaPAR.PAR_FECHAPRO
        MDIPrincipal.tslFechaActiva.Text = FormatDateTime(datFecha, DateFormat.LongDate)
        ' Se crea Nueva Planilla
        filaPLA = dtPLA.NewTESPLARow
        filaPLA.PLA_CODIGO = filaPAR.PAR_PLANILLA
        filaPLA.EMP_CODIGO = Usuario.CodEmpresa
        filaPLA.PLA_FECHA = filaPAR.PAR_FECHAPRO
        filaPLA.PLA_SALDOINI = 0
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
        filaPLA.PLA_SALDO = 0
        filaPLA.PLA_AUDITORIA = Auditoria("")
        dtPLA.AddTESPLARow(filaPLA)
        taPLA.Update(dtPLA)


        If filaACP.total14 <> 0 Then
            Cartera = MsgBox("La planilla tiene cheques en cartera. " & Chr(13) & "¿Desea traspasarlos a la planilla nueva?", vbInformation + vbYesNo, "Mensaje del Sistema")
        End If
        Dim Cod As New dsWALCUATableAdapters.QueriesTableAdapter
        Codigo = Cod.TraeCodigoDPL



        Dim PorDepositar As Double
        Dim fila As DataRowView
        Dim SaldoMañana As Double
        Dim ChequesCar As Double
        For i = 0 To TraeCuadraturaBindingSource.Count - 1
            fila = TraeCuadraturaBindingSource.Item(i)
            Dim Cuenta As Long
            Cuenta = fila.Item("CODIGO")
            taCTE.FillByCuenta(dtCTE, Cuenta)
            filaCTE = dtCTE.Item(0)
            If filaCTE.IsCTE_COLCHON1Null Then
                Colchon = 0
            Else
                Colchon = filaCTE.CTE_COLCHON1
            End If
            If fila.Item("CUA_CHEQUESCAR") Is DBNull.Value Then
                ChequesCar = 0
            Else
                ChequesCar = fila.Item("CUA_CHEQUESCAR")
            End If
            SaldoMañana = fila.Item("CUA_PROXIMOSALDO")
            filaDPLA = dtDPLA.NewDetallePlanillaRow
            filaDPLA.DPL_CODIGO = Codigo
            filaDPLA.PLA_CODIGO = filaPAR.PAR_PLANILLA
            filaDPLA.CTE_CODIGO = Cuenta
            filaDPLA.DPL_SALDOINI = SaldoMañana
            If Cartera = MsgBoxResult.No Then
                If SaldoMañana > Colchon Then
                    PorDepositar = SaldoMañana - Colchon
                Else
                    PorDepositar = 0
                End If
                filaDPLA.DPL_CHEQUESCAR = 0
            Else
                If SaldoMañana + ChequesCar > Colchon Then
                    PorDepositar = SaldoMañana - Colchon + ChequesCar
                Else
                    PorDepositar = 0
                End If
                filaDPLA.DPL_CHEQUESCAR = ChequesCar
            End If
            filaDPLA.DPL_PORCOLOCAR = PorDepositar
            filaDPLA.DPL_SALDO = SaldoMañana
            filaDPLA.DPL_APORTES = 0
            filaDPLA.DPL_CHEQUESDEV = 0
            filaDPLA.DPL_COLOCACIONES = 0
            filaDPLA.DPL_OTROSINGRESOS = 0
            filaDPLA.DPL_PAGOSCAR = 0
            filaDPLA.DPL_PAGOSCHE = 0
            filaDPLA.DPL_RECAUDACION = 0
            filaDPLA.DPL_RESCATES = 0
            filaDPLA.DPL_TRANSFERENCIASNEG = 0
            filaDPLA.DPL_TRANSFERENCIASPOS = 0
            dtDPLA.AddDetallePlanillaRow(filaDPLA)
            taDPLA.Update(dtDPLA)
            Codigo = Codigo + 1
        Next


        ' Se generan los detalles del saldo inicial


        For i = 0 To TraeCuadraturaBindingSource.Count - 1
            fila = TraeCuadraturaBindingSource.Item(i)
            Dim filaC As dsWALCUA.TraeCuadraturaRow = fila.Row

            Dim Cuenta As Long
            Cuenta = fila.Item("CODIGO")
            taCTE.FillByCuenta(dtCTE, Cuenta)
            filaCTE = dtCTE.Item(0)
            taDPLA.FillByPlanillaCuenta(dtDPLA, filaPAR.PAR_PLANILLA, Cuenta)
            If dtDPLA.Count = 0 Then
                MsgBox("Se detecto un error catastrófico, el proceso se detiene." & vbCrLf & "Favor comunicarse con 2SYS s.a. y reportar error: 999999", MsgBoxStyle.Critical, "Error Catastrófico")
                Me.Close()
            End If
            filaDPLA = dtDPLA.Item(0)

            ' Saldo Inicial día anterior
            If (Not filaC.IsCUA_SALDOININull) AndAlso filaC.CUA_SALDOINI <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_SALDOINI")
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "01 Saldo Inicial del día anterior"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Cheques Devueltos
            If (Not filaC.IsCUA_CHEQUESDEV2Null) AndAlso filaC.CUA_CHEQUESDEV2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_CHEQUESDEV2") * -1
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "05 Cheques Devueltos"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Cheques Girados
            If (Not filaC.IsCUA_PAGOSCHE2Null) AndAlso filaC.CUA_PAGOSCHE2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_PAGOSCHE2") * -1
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "06 Cheques Girados"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Cheques en Cartera
            If (Not filaC.IsCUA_CHEQUESCAR2Null) AndAlso filaC.CUA_CHEQUESCAR2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_CHEQUESCAR2")
                filaDOP.DOP_TIPO = "P"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "08 Cheques en Cartera del día anterior"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Otros Ingresos
            If (Not filaC.IsCUA_OTROSINGRESOS2Null) AndAlso filaC.CUA_OTROSINGRESOS2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_OTROSINGRESOS2")
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "07 Otros Ingresos"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Recaudación
            If (Not filaC.IsCUA_RECAUDACION2Null) AndAlso filaC.CUA_RECAUDACION2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_RECAUDACION2")
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "03 Recaudación"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Rescates
            If (Not filaC.IsCUA_RESCATES2Null) AndAlso filaC.CUA_RESCATES2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_RESCATES2")
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "02 Rescates"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Otros Cargos
            If (Not filaC.IsCUA_PAGOSCAR2Null) AndAlso filaC.CUA_PAGOSCAR2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_PAGOSCAR2") * -1
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "05 Otros Cargos"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Cheques de la Tarde
            If (Not filaC.IsCUA_EGRESOSCHENull) AndAlso filaC.CUA_EGRESOSCHE <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_EGRESOSCHE") * -1
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "12 Cheques de la Tarde"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Transferencias Positivas
            If (Not filaC.IsCUA_TRANSFERENCIASPOS2Null) AndAlso filaC.CUA_TRANSFERENCIASPOS2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_TRANSFERENCIASPOS2")
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "09 Transferencias Positivas"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If

            ' Transferencias Negativas
            If (Not filaC.IsCUA_TRANSFERENCIASNEG2Null) AndAlso filaC.CUA_TRANSFERENCIASNEG2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_TRANSFERENCIASNEG2") * -1
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "10 Transferencias Negativas"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If
            ' Colocaciones
            If (Not filaC.IsCUA_COLOCACIONES2Null) AndAlso filaC.CUA_COLOCACIONES2 <> 0 Then
                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                filaDOP.DOP_MONTO = fila.Item("CUA_COLOCACIONES2") * -1
                filaDOP.DOP_TIPO = "D"
                filaDOP.COL_CODIGO = 2
                filaDOP.DOP_GLOSAADIC = "11 Colocaciones"
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
            End If
        Next
        If Cartera = MsgBoxResult.Yes Then
            ' se deben generar los detalles de los Cheques en Cartera (Columna 9)
            ' 1° recorrer la nueva planilla buscando las cuentas con cheques en cartera

            ' 2° copiar los registros de esa cuenta de la planilla anterior (Planilla-1)
            ' 2.1 determinar cual es el DPL que corresponde
            ' 2.2 copiar todos los detalles al DOP con el Nuevo DPL
            For i = 0 To TraeCuadraturaBindingSource.Count - 1
                fila = TraeCuadraturaBindingSource.Item(i)
                Dim filaC As dsWALCUA.TraeCuadraturaRow = fila.Row

                Dim Cuenta As Long
                Cuenta = fila.Item("CODIGO")
                taCTE.FillByCuenta(dtCTE, Cuenta)
                filaCTE = dtCTE.Item(0)
                taDPLA.FillByPlanillaCuenta(dtDPLA, filaPAR.PAR_PLANILLA, Cuenta)
                If dtDPLA.Count = 0 Then
                    MsgBox("Se detecto un error catastrófico, el proceso se detiene." & vbCrLf & "Favor comunicarse con 2SYS s.a. y reportar error: 999997", MsgBoxStyle.Critical, "Error Catastrófico")
                    Me.Close()
                End If
                filaDPLA = dtDPLA.Item(0)

                ' Cheques en Cartera
                If (Not filaC.IsCUA_CHEQUESCARNull) AndAlso filaC.CUA_CHEQUESCAR > 0 Then
                    taDPLA2.FillByPlanillaCuenta(dtDPLA2, filaPAR.PAR_PLANILLA - 1, Cuenta)
                    If dtDPLA2.Count = 0 Then
                        MsgBox("Se detecto un error catastrófico, el proceso se detiene." & vbCrLf & "Favor comunicarse con 2SYS s.a. y reportar error: 999996", MsgBoxStyle.Critical, "Error Catastrófico")
                        Me.Close()
                    End If
                    filaDPLA2 = dtDPLA2.Item(0)
                    taDOP2.FillByDPL(dtDOP2, filaDPLA2.DPL_CODIGO)
                    For J = 0 To dtDOP2.Count - 1
                        filaDOP2 = dtDOP2.Item(J)
                        'Se detectaron cheques en cartera
                        filaDOP = dtDOP.NewTESDOPRow
                        filaDOP.DPL_CODIGO = filaDPLA.DPL_CODIGO
                        filaDOP.DOP_MONTO = filaDOP2.DOP_MONTO
                        filaDOP.DOP_TIPO = filaDOP2.DOP_TIPO
                        filaDOP.COL_CODIGO = filaDOP2.COL_CODIGO
                        filaDOP.DOP_GLOSAADIC = filaDOP2.DOP_GLOSAADIC
                        filaDOP.DOP_AUDITORIA = Auditoria("")
                        dtDOP.AddTESDOPRow(filaDOP)
                        taDOP.Update(dtDOP)
                    Next
                End If
            Next
        End If
        Me.Close()

    End Sub
    Private Sub GridGroupingControl1_TableControlCellMouseUp(sender As Object, e As GridTableControlCellMouseEventArgs) Handles GridGroupingControl1.TableControlCellMouseUp
        Dim col As Integer = e.Inner.ColIndex
        Dim fil As Integer = e.Inner.RowIndex
        If fil > TraeCuadraturaBindingSource.Count + 3 Then
            Exit Sub
        End If
        If fil < 4 Then
            Exit Sub
        End If

        Dim boton As Integer = e.Inner.MouseEventArgs.Button
        GridGroupingControl1.Focus()

        'If MouseButtons.Right Then
        Dim Fila As System.Data.DataRowView
        Fila = TraeCuadraturaBindingSource.Item(fil - 4)
        Dim campo As String = ""
        Dim celda As GridCurrentCell
        celda = GridGroupingControl1.TableControl.CurrentCell
        Dim estilo As GridTableCellStyleInfo
        Dim NombreColumna As String = ""
        Try
            estilo = celda.Renderer.CurrentStyle
            NombreColumna = estilo.TableCellIdentity.Column.Name
        Catch ex As Exception

        End Try

        ' variables Globales
        Glo_Columna = 0
        Glo_NombreCol = NombreColumna
        If e.Inner.MouseEventArgs.Button = MouseButtons.Right Then
            Select Case NombreColumna
                Case "CUA_SALDOINI"
                    Glo_Caption = "Detalles (Saldo Inicial - " & Fila.Item("ENT_ABREVIATURA").TRIM & ")"
                    Glo_Columna = 0
                Case "CUA_RESCATES", "CUA_RESCATES2"
                    Glo_Caption = "Analisis de Diferencias de Rescates"
                    Glo_Columna = 4
                Case "CUA_RECAUDACION", "CUA_RECAUDACION2"
                    Glo_Caption = "Analisis de Diferencias de Recaudaciones"
                    Glo_Columna = 6
                Case "CUA_CHEQUESDEV", "CUA_CHEQUESDEV2"
                    Glo_Caption = "Analisis de Diferencias de Cheques Devueltos"
                    Glo_Columna = 8
                Case "CUA_OTROSINGRESOS", "CUA_OTROSINGRESOS2"
                    Glo_Caption = "Analisis de Diferencias de Otros Ingresos"
                    Glo_Columna = 12
                Case "CUA_PAGOSCHE", "CUA_PAGOSCHE2"
                    Glo_Caption = "Analisis de Diferencias de Pagos Con Cheque"
                    Glo_Columna = 14
                Case "CUA_PAGOSCAR", "CUA_PAGOSCAR2"
                    Glo_Caption = "Analisis de Diferencias de Pagos Con Cargos"
                    Glo_Columna = 16
                Case "CUA_CHEQUESCAR", "CUA_CHEQUESCAR2"
                    Glo_Caption = "Analisis de Diferencias de Cheques en Cartera"
                    Glo_Columna = 18
                Case "CUA_TRANSFERENCIASPOS", "CUA_TRANSFERENCIASPOS2"
                    Glo_Caption = "Analisis de Diferencias de Transferencias Positivas"
                    Glo_Columna = 20
                Case "CUA_TRANSFERENCIASNEG", "CUA_TRANSFERENCIASNEG2"
                    Glo_Caption = "Analisis de Diferencias de Transferencias Negativas"
                    Glo_Columna = 22
                Case "CUA_PORCOLOCAR", "CUA_PORCOLOCAR2"
                    Glo_Caption = "Analisis de Diferencias de Por Colocar"
                    Glo_Columna = 24
                Case "CUA_COLOCACIONES", "CUA_COLOCACIONES2"
                    Glo_Caption = "Analisis de Diferencias de Colocaciones"
                    Glo_Columna = 26
                Case "CUA_SALDO", "CUA_SALDO2"
                    Glo_Caption = "Analisis de Diferencias de Saldo Planilla"
                    Glo_Columna = 28
            End Select
            If Glo_Columna > 0 Then
                CargaDiferencias()
                For Each frmPla As Form In MDIPrincipal.MdiChildren
                    If frmPla.WindowState = FormWindowState.Maximized Then
                        frmPla.WindowState = FormWindowState.Normal
                        Exit For
                    End If
                Next

                Dim formulario As New frmWALDIF00(dtDIF, Glo_Caption)
                formulario.MdiParent = MDIPrincipal
                Me.Cursor = Cursors.WaitCursor
                formulario.Show()
                Me.Cursor = Cursors.Default
                formulario.WindowState = FormWindowState.Normal
            End If
        Else
            Select Case NombreColumna
                Case "CUA_RESCATES2"
                    Glo_Caption = "Analisis de Diferencias de Rescates"
                    Glo_Columna = 5
                Case "CUA_RECAUDACION2"
                    Glo_Caption = "Analisis de Diferencias de Recaudaciones"
                    Glo_Columna = 7
                Case "CUA_CHEQUESDEV2"
                    Glo_Caption = "Analisis de Diferencias de Cheques Devueltos"
                    Glo_Columna = 9
                Case "CUA_OTROSINGRESOS2"
                    Glo_Caption = "Analisis de Diferencias de Otros Ingresos"
                    Glo_Columna = 13
                Case "CUA_PAGOSCHE2"
                    Glo_Caption = "Analisis de Diferencias de Pagos Con Cheque"
                    Glo_Columna = 15
                Case "CUA_PAGOSCAR2"
                    Glo_Caption = "Analisis de Diferencias de Pagos Con Cargos"
                    Glo_Columna = 17
                Case "CUA_CHEQUESCAR2"
                    Glo_Caption = "Analisis de Diferencias de Cheques en Cartera"
                    Glo_Columna = 19
                Case "CUA_TRANSFERENCIASPOS2"
                    Glo_Caption = "Analisis de Diferencias de Transferencias Positivas"
                    Glo_Columna = 21
                Case "CUA_TRANSFERENCIASNEG2"
                    Glo_Caption = "Analisis de Diferencias de Transferencias Negativas"
                    Glo_Columna = 23
                'Case "CUA_PORCOLOCAR2"
                '    Glo_Caption = "Analisis de Diferencias de Por Colocar"
                '    Glo_Columna = 25
                Case "CUA_COLOCACIONES2"
                    Glo_Caption = "Analisis de Diferencias de Colocaciones"
                    Glo_Columna = 25
                Case "CUA_PROXIMOSALDO"
                    Exit Sub
                Case "CUA_SALDOINI"
                    Exit Sub
                Case "CUA_EGRESOSCHE"
                    Exit Sub
                Case "CUA_SALDO2"
                    Exit Sub
                Case "CUA_SALDO"
                    Exit Sub
            End Select
            If col < 4 Then Exit Sub
            If fil < 4 Or fil > TraeCuadraturaBindingSource.Count + 3 Then Exit Sub
            ' analisar solo columnas del sistema o imparest
            taCTE.FillByCodigo(dtCTE, Fila.Item("CTE_CODIGO"))

            If dtCTE.Count = 0 Then
                MsgBox("Se detecto un error catastrófico, el proceso se detiene." & vbCrLf & "Favor comunicarse con 2SYS s.a. y reportar error: 999998", MsgBoxStyle.Critical, "Error Catastrófico")
                Me.Close()
            End If
            filaCTE = dtCTE.Item(0)
            DetallePla.Cuenta = filaCTE.CTE_CODIGO
            DetallePla.Columna = Glo_Columna
            DetallePla.Planilla = filaPAR.PAR_PLANILLA
            DetallePla.Fecha = filaPAR.PAR_FECHAPRO
            DetallePla.CuentaSAP = CStr(CDbl(Mid(RTrim(filaCTE.CTE_CONTABLE), 1, Len(RTrim(filaCTE.CTE_CONTABLE)) - 1) & "1"))
            DetallePla.CuentaSAP2 = CStr(CDbl(Mid(RTrim(filaCTE.CTE_CONTABLE), 1, Len(RTrim(filaCTE.CTE_CONTABLE)) - 1) & "2"))
            DetallePla.Banco = filaCTE.CTE_CODBANCO
            Glo_Cuenta = filaCTE.CTE_CODIGO
            Glo_Columna_Det = Glo_Columna
            TraeCuadraturaBindingSource.EndEdit()
            TraeCuadraturaTableAdapter.Adapter.Update(DsWALCUA.TraeCuadratura)
            Dim FORMULARIO As New frmWALDET00
            FORMULARIO.ShowDialog()
            Me.TraeCuadraturaTableAdapter.Fill(Me.DsWALCUA.TraeCuadratura)
            RefrescarPlanilla()

            If DetallePla.Grabar Then
                Cursor = Cursors.WaitCursor
                Select Case DetallePla.Columna
                    Case 5
                        TraeRescates()
                    Case 7
                        TraeRecaudacion()
                    Case 9
                        TraeChequesDevueltos()
                    Case 11
                        TraeOtrosIngresos()
                    Case 15
                        TraePagosConCheques()
                    Case 17
                        TraeOtrosCargos()
                    Case 21
                        TraeTransferenciasPos()
                    Case 23
                        TraeTransferenciasNeg()
                    Case 25
                        TraeColocaciones()
                End Select
                Cursor = Cursors.Default
            End If
            DetallePla.Grabar = True
        End If
    End Sub
    Private Sub Colores()
        ' Colorea las columnas
        Dim color1 As Color = Color.FromArgb(255, 42, 77, 105)
        Dim color2 As Color = Color.FromArgb(255, 75, 134, 180)
        Dim color3 As Color = Color.FromArgb(255, 173, 203, 227)
        Dim color4 As Color = Color.FromArgb(255, 231, 239, 246)
        Dim color5 As Color = Color.FromArgb(255, 99, 172, 229)



        For i = 0 To GridGroupingControl1.TableDescriptor.Columns.Count - 1
            If i = 0 Or i = 1 Or i = 2 Then
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
    Private Sub CargaDiferencias()
        Dim fila As DataRowView
        dtDIF.Clear()

        For i = 0 To TraeCuadraturaBindingSource.Count - 1
            fila = TraeCuadraturaBindingSource.Item(i)
            FilaDIF = dtDIF.NewDiferenciasRow
            FilaDIF.Secuencia = fila.Item("CTE_SECUENCIA")
            FilaDIF.Banco = fila.Item("ENT_ABREVIATURA")
            FilaDIF.Cuenta = fila.Item("CTE_CUENTA")
            If Not fila.Item(Glo_Columna) Is DBNull.Value Then
                FilaDIF.Dato1 = fila.Item(Glo_Columna)
            Else
                FilaDIF.Dato1 = 0
            End If
            If Not fila.Item(Glo_Columna + 1) Is DBNull.Value Then
                FilaDIF.Dato2 = fila.Item(Glo_Columna + 1)
            Else
                FilaDIF.Dato2 = 0
            End If
            FilaDIF.Diferencia = FilaDIF.Dato1 - FilaDIF.Dato2
            dtDIF.AddDiferenciasRow(FilaDIF)
        Next
    End Sub
    Private Sub RefrescarPlanilla()
        GridGroupingControl1.Visible = False
        '****************  Desaparecen **************************************
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_SALDOINI") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_SALDOINI")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RESCATES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_RESCATES")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RESCATES2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_RESCATES2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RECAUDACION") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_RECAUDACION")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RECAUDACION2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_RECAUDACION2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESDEV") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_CHEQUESDEV")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESDEV2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_CHEQUESDEV2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_OTROSINGRESOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_OTROSINGRESOS")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_OTROSINGRESOS2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_OTROSINGRESOS2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCHE") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_PAGOSCHE")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCHE2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_PAGOSCHE2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_PAGOSCAR")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCAR2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_PAGOSCAR2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_CHEQUESCAR")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESCAR2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_CHEQUESCAR2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASPOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_TRANSFERENCIASPOS")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASPOS2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_TRANSFERENCIASPOS2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASNEG") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_TRANSFERENCIASNEG")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASNEG2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_TRANSFERENCIASNEG2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_COLOCACIONES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_COLOCACIONES")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_COLOCACIONES2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_COLOCACIONES2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_SALDO") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_SALDO")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_SALDO2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_SALDO2")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_EGRESOSCHE") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_EGRESOSCHE")
        End If
        If GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PROXIMOSALDO") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Remove("CUA_PROXIMOSALDO")
        End If
        ' **********  Aparecen  ********************
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_SALDOINI") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_SALDOINI")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RESCATES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_RESCATES")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RESCATES2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_RESCATES2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RECAUDACION") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_RECAUDACION")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_RECAUDACION2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_RECAUDACION2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESDEV") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_CHEQUESDEV")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESDEV2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_CHEQUESDEV2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_OTROSINGRESOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_OTROSINGRESOS")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_OTROSINGRESOS2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_OTROSINGRESOS2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCHE") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_PAGOSCHE")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCHE2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_PAGOSCHE2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_PAGOSCAR")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PAGOSCAR2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_PAGOSCAR2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESCAR") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_CHEQUESCAR")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_CHEQUESCAR2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_CHEQUESCAR2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASPOS") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_TRANSFERENCIASPOS")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASPOS2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_TRANSFERENCIASPOS2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASNEG") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_TRANSFERENCIASNEG")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_TRANSFERENCIASNEG2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_TRANSFERENCIASNEG2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_COLOCACIONES") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_COLOCACIONES")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_COLOCACIONES2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_COLOCACIONES2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_SALDO") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_SALDO")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_SALDO2") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_SALDO2")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_EGRESOSCHE") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_EGRESOSCHE")
        End If
        If Not GridGroupingControl1.TableDescriptor.VisibleColumns.Contains("CUA_PROXIMOSALDO") Then
            'For unhide the parentID column
            Me.GridGroupingControl1.TableDescriptor.VisibleColumns.Add("CUA_PROXIMOSALDO")
        End If

        Me.GridGroupingControl1.Refresh()
        Me.GridGroupingControl1.Invalidate()
        Me.GridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Table())
        CargarDatos()
        GridGroupingControl1.Visible = True

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim pdfConvertor As New Syncfusion.GridHelperClasses.GridPDFConverter()

        pdfConvertor.ShowHeader = True
        pdfConvertor.Margins.All = 10
        pdfConvertor.ExportToPdf("Sample.pdf", GridGroupingControl1.TableControl)
        'Launching the PDF file using the default Application.[Acrobat Reader]
        System.Diagnostics.Process.Start("Sample.pdf")
    End Sub



    Private Sub GridGroupingControl1_RecordValueChanging(sender As Object, e As RecordValueChangingEventArgs) Handles GridGroupingControl1.RecordValueChanging
        If e.Column = "CUA_EGRESOSCHE" Then
            Try
                Dim MONTO As Long = CLng(e.NewValue)
                Dim Saldo As Double = GridGroupingControl1.Table.CurrentRecord.GetValue("CUA_SALDO2")
                Saldo = Saldo - MONTO
                GridGroupingControl1.Table.CurrentRecord.SetValue("CUA_PROXIMOSALDO", Saldo)
                Me.GridGroupingControl1.TableControl.CurrentCell.EndEdit()
            Catch ex As Exception
                e.NewValue = ""
            End Try
        End If

    End Sub
End Class