Public Class frmWALENT01
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Impresión de Entidades Financieras
        Me.Cursor = Cursors.WaitCursor
        Dim InfoTag As New Informes
        InfoTag.Reporte = "reportes\rptEntidades00.rpt"
        InfoTag.Numero = 5
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Entidades Financieras"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class