Public Class frmWALRED00
    Dim taREC As New dsWALREPTableAdapters.RecaudaciónTableAdapter
    Dim dtREC As New dsWALREP.RecaudaciónDataTable
    Dim filaREC As dsWALREP.RecaudaciónRow
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbListar_Click(sender As Object, e As EventArgs) Handles tsbListar.Click
        ' Generar Listado
        Me.Cursor = Cursors.WaitCursor
        taREC.FillByPeriodo(dtREC, dtpFecha.Value.Date, dtpFecha.Value.Date)
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtREC
        If dtREC.Count = 0 Then
            MsgBox("No hay nada que listar en el día ingresado", MsgBoxStyle.Information, "Mensajes de Wallet")
            Exit Sub
        End If
        InfoTag.Reporte = "reportes\rptRecDisponible00.rpt"
        InfoTag.Numero = 21
        InfoTag.FechaIni = dtpFecha.Value
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class