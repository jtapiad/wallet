Public Class frmWALBAN00
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    Private Sub frmWALCLC11_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpFecha.Value = Now.Date
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.SP_STOCK_BANCOSTableAdapter
        Dim dtCLC As New dsWALREP.SP_STOCK_BANCOSDataTable
        Dim Fecha As String = Replace(Format(dtpFecha.Value, "yyyy/MM/dd"), "-", "/")
        taCLC.Fill(dtCLC, Fecha)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptExtInvBan.rpt"
        InfoTag.Numero = 28
        InfoTag.FechaIni = dtpFecha.Value
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Stock de Colocaciones - Bancos"
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class