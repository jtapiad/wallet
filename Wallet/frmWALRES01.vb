Public Class frmWALRES01
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Resumen de Saldo Incial
        Me.Cursor = Cursors.WaitCursor
        Dim taRES As New dsWALREPTableAdapters.ResumenSaldoIniTableAdapter
        Dim dtRES As New dsWALREP.ResumenSaldoIniDataTable
        taRES.FillByPlanilla(dtRES, DetallePla.Planilla)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtRES
        InfoTag.Reporte = "reportes\rptResumenIni01.rpt"
        InfoTag.Numero = 16
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Resumen de Saldo Inicial"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()

    End Sub
End Class