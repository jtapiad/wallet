Public Class frmWALDEV01
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' Impresión de Evolución de Variables
        Me.Cursor = Cursors.WaitCursor
        Dim taPLA As New dsWALREPTableAdapters.TESPLATableAdapter
        Dim dtPLA As New dsWALREP.TESPLADataTable
        taPLA.FillByFechaPla(dtPLA, DetallePla.Fecha)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtPLA
        InfoTag.Reporte = "reportes\rptGrafico01.rpt"
        InfoTag.Numero = 17
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Evolución de Variables"
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class