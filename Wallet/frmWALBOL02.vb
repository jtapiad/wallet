Public Class frmWALBOL02
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' Impresión
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.BoletasTableAdapter
        Dim dtCLC As New dsWALREP.BoletasDataTable
        taCLC.FillByBanco(dtCLC)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCLC
        InfoTag.Reporte = "reportes\rptPOPBOL02.rpt"
        InfoTag.Numero = 34
        'InfoTag.FechaIni = dtpFecha.Value.Date
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Boletas por Banco/Día"
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()

    End Sub

    Private Sub frmWALBOL02_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class