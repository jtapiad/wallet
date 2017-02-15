Public Class frmWALCTE01

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' Cuentas Corrientes Bancarias
        Me.Cursor = Cursors.WaitCursor
        Dim InfoTag As New Informes
        InfoTag.Reporte = "reportes\rptCtaCte00.rpt"
        InfoTag.Numero = 7
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Cuentas Corrientes Bancarias"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()

    End Sub
End Class