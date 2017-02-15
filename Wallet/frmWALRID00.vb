Public Class frmWALRID00
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    Private Sub frmWALCLC11_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpFecha.Value = Now.Date
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.ResumenOperacionesTableAdapter
        Dim dtCLC As New dsWALREP.ResumenOperacionesDataTable
        taCLC.FillByFecha(dtCLC, dtpFecha.Value.Date)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptResumen00.rpt"
        InfoTag.Numero = 32
        InfoTag.FechaIni = dtpFecha.Value.Date
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Resumen de Operaciones del Día"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

End Class