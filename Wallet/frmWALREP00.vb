Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmWALREP00
    Dim Conexion1 As New SqlClient.SqlConnection(My.Settings.WalletConnectionString1)
    Dim InfoTag2 As New Informes
        Dim dataTable14 As New dsWALCOT.TasasDataTable

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub frmRFINF00_Load(sender As Object, e As EventArgs) Handles Me.Load
        InfoTag2 = Me.Tag
        SeleccionaRutina()
    End Sub
    Private Sub SeleccionaRutina()
        Select Case InfoTag2.Numero
            Case 1
                ' Usuarios
                imprimir1()
            Case 2
                ' Custodias
                imprimir2()
            Case 3
                ' Empresas
                imprimir3()
            Case 4
                ' Estados
                imprimir4()
            Case 5
                imprimir5()
            Case 6
                ' Planilla
                imprimir6()
            Case 7
                ' Cuentas Corrientes
                imprimir7()
            Case 8
                ' Feriados
                imprimir8()
            Case 9
                ' Fondos
                imprimir9()
            Case 10
                ' Instrumentos
                imprimir10()
            Case 11
                ' Tipos de Entidad
                imprimir11()
            Case 12
                ' Tipos de Fondo
                imprimir12()
            Case 13
                ' Tipos de Fondo
                imprimir13()
            Case 14
                ' Tasas por Banco
                imprimir14()
            Case 15
                ' Tasas por Fondo
                imprimir15()
            Case 16
                ' Resumen de Saldo Inicial
                imprimir16()
            Case 17
                ' Evolución de Variables
                imprimir17()
            Case 18
                ' Evolución de Variables
                imprimir18()
            Case 19
                ' Detalle de Transacciones
                imprimir19()
            Case 20
                ' Detalle de Transacciones por Caja
                imprimir20()
            Case 21
                ' Detalle de Recaudación Disponible
                imprimir21()
            Case 22
                ' Totales Recaudación Disponible
                imprimir22()
            Case 23
                ' Totales Recaudación Depositada
                imprimir23()
            Case 26
                ' Listado de Colocaciones en Fondos Mutuos
                imprimir26()
            Case 27
                ' Listado de Colocaciones en Fondos Mutuos 2
                imprimir27()
            Case 28
                ' Listado de Colocaciones en Bancos
                imprimir28()

            Case 29
                ' Listado de Colocaciones en Pesos
                imprimir29()
            Case 30
                ' Listado de Rescates por Periodo
                imprimir30()
            Case 31
                ' Listado de Resumen de Inversiones
                imprimir31()
            Case 32
                ' Listado de Resumen de Operaciones Diarias
                imprimir32()
            Case 33
                ' Listado de Boletas por Cajas (Dia/Banco)
                imprimir33()
            Case 34
                ' Listado de Boletas por Cajas  (Banco/Día)
                imprimir34()

        End Select

    End Sub

    Private Sub imprimir1()
        Dim report As New ReportDocument
        Dim taTAC As New dsSEGUSUTableAdapters.UsuariosTableAdapter
        Dim dtTAC As New dsSEGUSU.UsuariosDataTable
        Dim Datos As DataTable
        taTAC.Fill(dtTAC)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtTAC, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report

    End Sub
    Private Sub imprimir2()
        Dim report As New ReportDocument
        Dim taCUS As New dsWALCUSTableAdapters.TESCUSTableAdapter
        Dim dtCUS As New dsWALCUS.TESCUSDataTable
        Dim Datos As DataTable
        taCUS.Fill(dtCUS)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtCUS, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub imprimir3()
        Dim report As New ReportDocument
        Dim taEMP As New dsWALEMPTableAdapters.TESEMPTableAdapter
        Dim dtEMP As New dsWALEMP.TESEMPDataTable
        Dim Datos As DataTable
        taEMP.Fill(dtEMP)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtEMP, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir4()
        Dim report As New ReportDocument
        Dim taEST As New dsWALESTTableAdapters.TESESTTableAdapter
        Dim dtEST As New dsWALEST.TESESTDataTable
        Dim Datos As DataTable
        taEST.Fill(dtEST)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtEST, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir5()
        Dim report As New ReportDocument
        Dim taENT As New dsWALENTTableAdapters.EntidadesTableAdapter
        Dim dtENT As New dsWALENT.EntidadesDataTable
        Dim Datos As DataTable
        taENT.Fill(dtENT)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtENT, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir6()
        Dim report As New ReportDocument
        Dim taPLA As New dsWALPLATableAdapters.TESDPLTableAdapter
        Dim dtPLA As New dsWALPLA.TESDPLDataTable
        Dim Datos As DataTable
        taPLA.FillByPlanilla(dtPLA, InfoTag2.Argumento1lng)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtPLA, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("FechaPlanilla").Text = """Planilla de Operaciones del " & InfoTag2.Argumento3str & """"
        report.Refresh()
        'Try
        '    For Each DSC As CrystalDecisions.Shared.IConnectionInfo In report.DataSourceConnections
        '        DSC.SetLogon(ConUsuario, ConClave)
        '        DSC.SetConnection(ConServidor, ConBaseDatos, False)
        '    Next
        '    report.SetDatabaseLogon(ConUsuario, ConClave)

        '    For Each Table As Table In report.Database.Tables
        '        Table.LogOnInfo.ConnectionInfo.UserID = ConUsuario
        '        Table.LogOnInfo.ConnectionInfo.Password = ConClave
        '    Next
        report.SetDataSource(Datos)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir7()
        Dim report As New ReportDocument
        Dim taCTE As New dsWALCTETableAdapters.TESCTECompletoTableAdapter
        Dim dtCTE As New dsWALCTE.TESCTECompletoDataTable
        Dim Datos As DataTable
        taCTE.Fill(dtCTE)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtCTE, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub imprimir8()
        ' Feriados
        Dim report As New ReportDocument
        Dim taFER As New dsWALFERTableAdapters.TESFER1TableAdapter
        Dim dtFER As New dsWALFER.TESFER1DataTable
        Dim Datos As DataTable
        taFER.FillByAño(dtFER, InfoTag2.Argumento1lng)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtFER, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir9()
        Dim report As New ReportDocument
        Dim taFON1 As New dsWALFONTableAdapters.TESFON1TableAdapter
        Dim dtFON1 As New dsWALFON.TESFON1DataTable
        Dim Datos As DataTable
        taFON1.Fill(dtFON1)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtFON1, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir10()
        Dim report As New ReportDocument
        Dim taINS As New dsWALINFTableAdapters.InstrumentosTableAdapter
        Dim dtINS As New dsWALINF.InstrumentosDataTable
        Dim Datos As DataTable
        taINS.Fill(dtINS)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtINS, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir11()
        Dim report As New ReportDocument
        Dim taTEN As New dsWALTENTableAdapters.TESTENTableAdapter
        Dim dtTEN As New dsWALTEN.TESTENDataTable
        Dim Datos As DataTable
        taTEN.Fill(dtTEN)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtTEN, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir12()
        Dim report As New ReportDocument
        Dim taTFD As New dsWALTFDTableAdapters.TESTFDTableAdapter
        Dim dtTFD As New dsWALTFD.TESTFDDataTable
        Dim Datos As DataTable
        taTFD.Fill(dtTFD)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtTFD, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir13()
        Dim report As New ReportDocument
        Dim taTII As New dsWALTIITableAdapters.TESTIITableAdapter
        Dim dtTII As New dsWALTII.TESTIIDataTable
        Dim Datos As DataTable
        taTII.Fill(dtTII)
        ' Se carga el Reporte a utilizar
        Datos = TryCast(dtTII, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir14()
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir15()
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir16()
        ' Resumen de Saldos Iniciales
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        report.Load(InfoTag2.Reporte)
        ' Se transfieren las Formulas
        Dim tit As String = "Resumen Saldos Iniciales del " & FormatDateTime(DetallePla.Fecha, DateFormat.ShortDate)
        report.DataDefinition.FormulaFields("Titulo").Text = """" & tit & """"
        report.Refresh()
        ' Se transfieren los datos
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir17()
        ' Grafico de Evoluciones de Variables
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir18()
        ' Distribucoión de Recaudación
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        If InfoTag2.Argumento1lng = 0 Then
            report.DataDefinition.FormulaFields("Subtitulo").Text = "'Periodo del " & FormatDateTime(InfoTag2.FechaIni, DateFormat.ShortDate) & " al " & FormatDateTime(InfoTag2.FechaFin, DateFormat.ShortDate) & ", todas las Cajas'"
        Else
            report.DataDefinition.FormulaFields("Subtitulo").Text = "'Periodo del " & FormatDateTime(InfoTag2.FechaIni, DateFormat.ShortDate) & " al " & FormatDateTime(InfoTag2.FechaFin, DateFormat.ShortDate) & ", solo la Caja " & InfoTag2.Argumento1lng.ToString & "'"
        End If
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir19()
        ' Detalle de Transacciones
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Columna").Text = InfoTag2.Argumento1lng.ToString
        report.DataDefinition.FormulaFields("Cuenta").Text = InfoTag2.Argumento2lng.ToString
        report.DataDefinition.FormulaFields("Planilla").Text = InfoTag2.Numero.ToString
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir20()
        ' Detalle de Transacciones
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Columna").Text = InfoTag2.Argumento1lng.ToString
        report.DataDefinition.FormulaFields("Cuenta").Text = InfoTag2.Argumento2lng.ToString
        report.DataDefinition.FormulaFields("Planilla").Text = InfoTag2.Numero.ToString
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir21()
        ' Recaudación Disponible
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir22()
        ' Recaudación Disponible
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Subtitulo").Text = "'Totales Disponibles del día " & FormatDateTime(InfoTag2.FechaIni, DateFormat.LongDate) & "'"
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir23()
        ' Recaudación Disponible
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Subtitulo").Text = "'Recaudación Depositada el " & FormatDateTime(InfoTag2.FechaIni, DateFormat.ShortDate) & "'"
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir26()
        ' Stock de Colocaciones de Fondos Mutuos
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Subtitulo").Text = "'Stock de Colocaciones en Fondos Mutuos al " & FormatDateTime(InfoTag2.FechaIni, DateFormat.LongDate) & "'"
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir27()
        ' Stock de Colocaciones de Fondos Mutuos 2
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Fecha").Text = "'" & FormatDateTime(InfoTag2.FechaIni, DateFormat.ShortDate) & "'"
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir28()
        ' Stock de Colocaciones de Fondos Mutuos 2
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir29()
        ' Listado de Colocaciones en Pesos
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Orden").Text = "'" & InfoTag2.Argumento3str & "'"
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir30()
        ' Listado de Rescates por Periodo
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Periodo").Text = "'Desde el " & FormatDateTime(InfoTag2.FechaIni, DateFormat.ShortDate) & " al " & FormatDateTime(InfoTag2.FechaFin, DateFormat.ShortDate) & "'"
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor 
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir31()
        ' Listado de Rescates por Periodo
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir32()
        ' Listado de Rescates por Periodo
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.DataDefinition.FormulaFields("Subtitulo").Text = "'" & FormatDateTime(InfoTag2.FechaIni, DateFormat.LongDate) & "'"
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir33()
        ' Listado de Boletas por Cajas
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub imprimir34()
        ' Listado de Boletas por Cajas
        Dim report As New ReportDocument
        Dim Datos As DataTable
        ' Se carga el Reporte a utilizar
        Datos = TryCast(InfoTag2.DatasTableImp, DataTable)
        ' Se transfieren los datos
        report.Load(InfoTag2.Reporte)
        report.Refresh()
        report.SetDataSource(Datos)
        ' Se muestra en el Visor
        CrystalReportViewer1.ReportSource = report
    End Sub

End Class