Public Class frmWALREC01
    Dim taREC As New dsWALREPTableAdapters.Recaudación_DepositadaTableAdapter
    Dim dtREC As New dsWALREP.Recaudación_DepositadaDataTable
    Dim filaREC As dsWALREP.Recaudación_DepositadaRow
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
        InfoTag.Reporte = "reportes\rptWALREC01.rpt"
        InfoTag.Numero = 23
        InfoTag.FechaIni = dtpFecha.Value
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Recaudación Depositada"
        Informe.WindowState = FormWindowState.Maximized
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class