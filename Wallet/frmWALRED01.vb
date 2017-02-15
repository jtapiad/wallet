Public Class frmWALRED01
    Dim taREC As New dsWALREPTableAdapters.TESREC02TableAdapter
    Dim dtREC As New dsWALREP.TESREC02DataTable
    Dim filaREC As dsWALREP.TESREC02Row
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbListar_Click(sender As Object, e As EventArgs) Handles tsbListar.Click
        ' Generar Listado
        Me.Cursor = Cursors.WaitCursor
        taREC.FillByFecha(dtREC, dtpFecha.Value.Date)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtREC
        If dtREC.Count = 0 Then
            MsgBox("No hay nada que listar en el día ingresado", MsgBoxStyle.Information, "Mensajes de Wallet")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        InfoTag.Reporte = "reportes\rptWALREC02.rpt"
        InfoTag.Numero = 22
        InfoTag.FechaIni = dtpFecha.Value
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Totales de Recaudación Disponible"
        Informe.WindowState = FormWindowState.Maximized
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Close()
    End Sub
End Class