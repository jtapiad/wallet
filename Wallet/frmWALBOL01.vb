Public Class frmWALBOL01
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' Impresión
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.BoletasTableAdapter
        Dim dtCLC As New dsWALREP.BoletasDataTable
        taCLC.Fill(dtCLC)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptPOPBOL01.rpt"
        InfoTag.Numero = 33
        'InfoTag.FechaIni = dtpFecha.Value.Date
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Boletas por Día/Banco"
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class