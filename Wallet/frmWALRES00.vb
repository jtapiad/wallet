Public Class frmWALRES00

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.RescatesTableAdapter
        Dim dtCLC As New dsWALREP.RescatesDataTable
        Dim FechaDesde As String = Replace(Format(dtpFechadesde.Value, "yyyy/MM/dd"), "-", "/")
        Dim FechaHasta As String = Replace(Format(dtpFechaHasta.Value, "yyyy/MM/dd"), "-", "/")
        taCLC.FillByPeriodo(dtCLC, dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date)
        If dtCLC.Count = 0 Then
            MsgBox("No hay Rescates que Listar", MsgBoxStyle.Information, "Mensajes del Sistema")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptExtInvRes.rpt"
        InfoTag.Numero = 30
        InfoTag.FechaIni = dtpFechaDesde.Value
        InfoTag.FechaFin = dtpFechaHasta.Value
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Stock de Colocaciones - Fondos Mutuos2"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class