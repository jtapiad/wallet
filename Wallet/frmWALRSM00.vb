Public Class frmWALRSM00
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.SP_STOCK_RESUMENTableAdapter
        Dim dtCLC As New dsWALREP.SP_STOCK_RESUMENDataTable
        Dim Fecha As String = Replace(Format(dtpFecha.Value, "yyyy/MM/dd"), "-", "/")
        taCLC.Fill(dtCLC, Fecha)
        If dtCLC.Count = 0 Then
            MsgBox("No hay Datos que Listar", MsgBoxStyle.Information, "Mensajes del Sistema")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptExtInvRsm.rpt"
        InfoTag.Numero = 31
        InfoTag.FechaIni = dtpFecha.Value
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Resumen de Colocaciones"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class