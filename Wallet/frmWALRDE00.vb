Public Class frmWALRDE00
    Dim Banco As String
    Dim taDOP As New dsWALREPTableAdapters.TESDOPTableAdapter
    Dim dtDOP As New dsWALREP.TESDOPDataTable
    Dim taPLA As New dsWALPLATableAdapters.TESPLATableAdapter
    Dim dtPLA As New dsWALPLA.TESPLADataTable
    Dim filaPLA As dsWALPLA.TESPLARow
    Dim taPAR As New dsWALPLATableAdapters.TESPARTableAdapter
    Dim dtPAR As New dsWALPLA.TESPARDataTable
    Dim filaPAR As dsWALPLA.TESPARRow
    Dim Planilla As Long


    Private Sub frmWALRDE00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CuentasUnoTableAdapter.FillByNombre(Me.DsWALPLA.CuentasUno)
        Me.TESCOLTableAdapter.FillByConDetalle(Me.DsWALPLA.TESCOL)
        taPAR.Fill(dtPAR)
        filaPAR = dtPAR.Item(0)
        taPLA.FillByPlanilla(dtPLA, filaPAR.PAR_PLANILLA)
        filaPLA = dtPLA.Item(0)
        dtpFecha.MaxDate = filaPLA.PLA_FECHA
        dtpFecha.Value = filaPLA.PLA_FECHA

    End Sub
    Private Sub tsbImprimir_Sin_Cajask(sender As Object, e As EventArgs) Handles tsbImprimir1.Click
        'Imprimir sin Caja
        Dim InfoTag As New Informes
        InfoTag.Argumento1lng = 0
        InfoTag.Argumento2lng = 0
        InfoTag.Numero = parametros.Planilla
        If cbTodasCol.Checked = False And cbTodasCta.Checked = False Then
            taDOP.FillByPlanillaColumnaCuenta(dtDOP, Planilla, cbColumnas.SelectedValue, cbCuentasCorrientes.SelectedValue)
            InfoTag.Argumento1lng = cbColumnas.SelectedValue
            InfoTag.Argumento2lng = cbCuentasCorrientes.SelectedValue
        ElseIf cbTodasCol.Checked = True And cbTodasCta.Checked = False Then
            taDOP.FillByPlanillaCuenta(dtDOP, Planilla, cbCuentasCorrientes.SelectedValue)
            InfoTag.Argumento2lng = cbCuentasCorrientes.SelectedValue
        ElseIf cbTodasCol.Checked = False And cbTodasCta.Checked = True Then
            taDOP.FillByPlanillaColumna(dtDOP, Planilla, cbColumnas.SelectedValue)
            InfoTag.Argumento1lng = cbColumnas.SelectedValue
        Else
            taDOP.FillByPlanilla(dtDOP, Planilla)
        End If
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptDetalles00.rpt"
        InfoTag.Numero = 19
        InfoTag.DatasTableImp = dtDOP
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub tsbImprimir_Con_Cajas(sender As Object, e As EventArgs) Handles tsbImprimir2.Click
        'Imprimir Con Caja
        Dim InfoTag As New Informes
        InfoTag.Argumento1lng = 0
        InfoTag.Argumento2lng = 0
        InfoTag.Numero = parametros.Planilla
        If cbTodasCol.Checked = False And cbTodasCta.Checked = False Then
            taDOP.FillByPlanillaColumnaCuenta(dtDOP, Planilla, cbColumnas.SelectedValue, cbCuentasCorrientes.SelectedValue)
            InfoTag.Argumento1lng = cbColumnas.SelectedValue
            InfoTag.Argumento2lng = cbCuentasCorrientes.SelectedValue
        ElseIf cbTodasCol.Checked = True And cbTodasCta.Checked = False Then
            taDOP.FillByPlanillaCuenta(dtDOP, Planilla, cbCuentasCorrientes.SelectedValue)
            InfoTag.Argumento2lng = cbCuentasCorrientes.SelectedValue
        ElseIf cbTodasCol.Checked = False And cbTodasCta.Checked = True Then
            taDOP.FillByPlanillaColumna(dtDOP, Planilla, cbColumnas.SelectedValue)
            InfoTag.Argumento1lng = cbColumnas.SelectedValue
        Else
            taDOP.FillByPlanilla(dtDOP, Planilla)
        End If
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptDetalles99.rpt"
        InfoTag.Numero = 20
        InfoTag.DatasTableImp = dtDOP
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        taPLA.FillByFecha(dtPLA, dtpFecha.Value.Date)
        If dtPLA.Count = 0 Then
            MsgBox("Ese día no se generó Planilla. Ingrese una nueva Fecha", MsgBoxStyle.Critical, "Mensajes de Wallet")
            Exit Sub
        End If
        filaPLA = dtPLA.Item(0)
        Planilla = filaPLA.PLA_CODIGO
    End Sub
End Class