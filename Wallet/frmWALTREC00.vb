Imports System.Diagnostics
Public Class frmWALTREC00
    Dim NoMostrar As Boolean = False
    ' Detalles Operacionales del Cierre
    Dim taDOP As New dsWALCUATableAdapters.TESDOPTableAdapter
    Dim dtDOP As New dsWALCUA.TESDOPDataTable
    Dim filaDOP As dsWALCUA.TESDOPRow
    Dim taDAZ As New dsWALPLATableAdapters.TraeDetalleMovimientosTableAdapter
    Dim dtDAZ As New dsWALPLA.TraeDetalleMovimientosDataTable
    Dim filaDAZ As dsWALPLA.TraeDetalleMovimientosRow
    Dim taCTE As New dsWALPLATableAdapters.CuentasUnoTableAdapter
    Dim dtCTE As New dsWALPLA.CuentasUnoDataTable
    Dim filaCTE As dsWALPLA.CuentasUnoRow
    Dim taDPL As New dsWALPLATableAdapters.TESDPLTableAdapter
    Dim dtDPL As New dsWALPLA.TESDPLDataTable
    Dim filaDPL As dsWALPLA.TESDPLRow
    Dim Consulta As New dsWALPLATableAdapters.QueriesTableAdapter
    Dim Fecha As String

    Private Sub frmWALTREC00_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub frmWALTREC00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fecha = Format(parametros.FechaPro, "dd/MM/yyyy")
        Fecha = Replace(Fecha, "-", "/")
        Me.TraeMovimientosTableAdapter.FillByFechaMandante(Me.DsWALPLA.TraeMovimientos, Fecha, parametros.Mandante)
        Totalizar()
    End Sub
    Private Sub Totalizar()
        Dim Total As Double = 0
        Dim fila As DataRowView
        If TraeMovimientosBindingSource.Count > 0 Then
            For i = 0 To TraeMovimientosBindingSource.Count - 1
                fila = TraeMovimientosBindingSource.Item(i)
                Total = Total + fila.Item("Total")
            Next
        Else
            MsgBox("No hay recaudaciones pendientes que mostrar", MsgBoxStyle.Information, NombreSistema)
            Glo_NoMostrar = True
        End If
        tstbTotal.Text = FormatCurrency(Total, 0)
    End Sub
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub





    Private Sub tsbActualiza_Click(sender As Object, e As EventArgs) Handles tsbActualiza.Click
        Me.Cursor = Cursors.WaitCursor

        'My.Application.Log.WriteEntry("Inicio del Proceso de incorporación de Recaudaciones : ")

        'tslbActualizando.Visible = True
        'tspbProceso.Visible = True
        Nuevo = True
        Dim FilasCTE() As DataRow
        Dim FilasDPL() As DataRow
        ' se generan los movimientos de recaudación
        taDAZ.FillByMandanteFecha(dtDAZ, Fecha, parametros.Mandante)
        taCTE.Fill(dtCTE)
        taDPL.FillByPlanilla(dtDPL, parametros.Planilla)
        Dim Glo As String
        If dtDAZ.Count > 0 Then
            For i = 0 To dtDAZ.Count - 1
                filaDAZ = dtDAZ.Item(i)
                ' Busca cuenta
                Dim Cuenta As String
                Cuenta = filaDAZ.DAZ_CUENTABANCO
                Cuenta = RTrim(Cuenta)
                Cuenta = Mid(Cuenta, 1, Len(Cuenta) - 1) & "2"
                Criterio = "CTE_CONTABLE = '" & Format(CLng(Cuenta), "0000000000") & "'"
                FilasCTE = dtCTE.Select(Criterio)
                filaCTE = TryCast(FilasCTE(0), dsWALPLA.CuentasUnoRow)
                ' Busca Detalle Planilla
                FilasDPL = dtDPL.Select("CTE_CODIGO=" & filaCTE.CTE_CODIGO.ToString.Trim)
                filaDPL = TryCast(FilasDPL(0), dsWALPLA.TESDPLRow)
                ' Verrifica posibles duplicaciones
                Dim Cantidad As Integer = Consulta.VerificaDuplicaciones(filaDAZ.DAZ_CODIGO)
                If Cantidad > 0 Then
                    MsgBox("Se detecto un registro duplicado:" & RTrim(filaDAZ.DAZ_DOCCONT) & " Pos: " & filaDAZ.DAZ_TEXTOPOS & " Monto : " & FormatNumber(filaDAZ.DAZ_MONTO, 0), MsgBoxStyle.Information, "Mensaje de Wallet")
                    'My.Application.Log.WriteEntry("Se detecto un registro duplicado y no se proceso:" & RTrim(filaDAZ.DAZ_DOCCONT) & " Pos: " & filaDAZ.DAZ_TEXTOPOS & " Monto : " & FormatNumber(filaDAZ.DAZ_MONTO, 0), MsgBoxStyle.Information, "Mensaje de Wallet" & " Fecha : " & Now & " Usuario : " & Usuario.Usuario)
                    Continue For
                    ' No se procesa y se continua
                End If

                ' Crea Registro

                filaDOP = dtDOP.NewTESDOPRow
                filaDOP.DPL_CODIGO = filaDPL.DPL_CODIGO
                filaDOP.COL_CODIGO = 4
                filaDOP.DOP_MONTO = filaDAZ.DAZ_MONTO
                filaDOP.DOP_TIPO = "D"
                filaDOP.DOP_TIPOREC = "S"
                Glo = "Caja:" & RTrim(filaDAZ.DAZ_CAJA) & " Doc.:" & RTrim(filaDAZ.DAZ_DOCCONT) & filaDAZ.DAZ_TEXTOPOS
                If Len(Glo) > 50 Then
                    Glo = Mid(Glo, 1, 50)
                End If
                filaDOP.DOP_GLOSAADIC = Glo
                filaDOP.DOP_NUMERO = RTrim(filaDAZ.DAZ_CAJA)
                filaDOP.DAZ_CODIGO = filaDAZ.DAZ_CODIGO
                filaDOP.DOP_AUDITORIA = Auditoria("")
                dtDOP.AddTESDOPRow(filaDOP)
                taDOP.Update(dtDOP)
                filaDAZ.PLA_CODIGO = parametros.Planilla
                taDAZ.Update(dtDAZ)
            Next
        End If
        TotalporColumna(parametros.Planilla, 4)
        Me.Cursor = Cursors.Default

        Me.Close()
    End Sub
End Class