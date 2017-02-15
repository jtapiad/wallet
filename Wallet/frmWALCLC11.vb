Public Class frmWALCLC11
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    Private Sub frmWALCLC11_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpFecha.Value = Now.Date
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.SP_STOCK_FONDOS_v3TableAdapter
        Dim dtCLC As New dsWALREP.SP_STOCK_FONDOS_v3DataTable
        Dim Fecha As String = Replace(Format(dtpFecha.Value, "yyyy/MM/dd"), "-", "/")
        taCLC.Fill(dtCLC, Fecha)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptTESFON01.rpt"
        InfoTag.Numero = 27
        InfoTag.FechaIni = dtpFecha.Value
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