Public Class frmWALPOD00
    Dim taPLA As New dsWALPLATableAdapters.TESPLATableAdapter
    Dim dtPLA As New dsWALPLA.TESPLADataTable
    Dim filaPLA As dsWALPLA.TESPLARow
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        ' Inicio de la Impresión
        taPLA.FillByFecha(dtPLA, dtpFecha.Value.Date)
        If dtPLA.Count = 0 Then
            MsgBox("No existe planilla para este día", MsgBoxStyle.Information, "Mensajes de Wallet")
            Exit Sub
        End If
        filaPLA = dtPLA.Item(0)
        ' Impresión de la Planilla de Operaciones
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptPlanilla00.rpt"
        InfoTag.Numero = 6
        InfoTag.Argumento1lng = filaPLA.PLA_CODIGO
        InfoTag.Argumento3str = Format(dtpFecha.Value, "dddd dd/MM/yyyy")
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Planillas de Otros Días"
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class