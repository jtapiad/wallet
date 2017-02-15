Public Class frmWALINV00
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    Private Sub frmWALCLC11_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpFecha.Value = Now.Date
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim taCLC As New dsWALREPTableAdapters.ColocacionesTableAdapter
        Dim dtCLC As New dsWALREP.ColocacionesDataTable
        Dim Fecha As String = Replace(Format(dtpFecha.Value, "yyyy/MM/dd"), "-", "/")
        Dim Orden As String
        taCLC.FillFecha(dtCLC, dtpFecha.Value)
        If dtCLC.Count = 0 Then
            MsgBox("No hay inversiones que Listar", MsgBoxStyle.Information, "Mensajes del Sistema")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim vista As New DataView(dtCLC)
        If rbInstFin.Checked = True Then
            If cbDesc.Checked = True Then
                vista.Sort = "ENT_ABREVIATURA DESC"
                Orden = "Ordenado por Institución financiera Descendente"
            Else
                vista.Sort = "ENT_ABREVIATURA"
                Orden = "Ordenado por Institución financiera"
            End If
        Else
            If cbDesc.Checked = True Then
                vista.Sort = "FECHA_VCTO_ORDEN DESC"
                Orden = "Ordenado por Fecha de Vencimiento Descendente"
            Else
                vista.Sort = "FECHA_VCTO_ORDEN"
                Orden = "Ordenado por Fecha de Vencimiento"
            End If
        End If
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = vista.ToTable
        InfoTag.Reporte = "reportes\rptExtInvPes.rpt"
        InfoTag.Numero = 29
        InfoTag.Argumento3str = Orden
        InfoTag.FechaIni = dtpFecha.Value
        Dim Informe As New frmWALREP00
        Informe.Text = "Reporte - Inversiones en Pesos"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.WindowState = FormWindowState.Maximized
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class