Public Class frmWALCLC10
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.SP_STOCK_FONDOS_WALLETTableAdapter
        Dim dtCLC As New dsWALREP.SP_STOCK_FONDOS_WALLETDataTable
        Dim Fecha As String = Replace(Format(dtpFecha.Value, "yyyy/MM/dd"), "-", "/")
        Dim InfoTag As New Informes
        taCLC.Fill(dtCLC, dtpFecha.Value)
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptExtInvFon.rpt"
        InfoTag.Numero = 26
        InfoTag.FechaIni = dtpFecha.Value
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Stock de Colocaciones - Fondos Mutuos"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub frmWALCLC10_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpFecha.Value = Now.Date
    End Sub
End Class