Public Class frmWALDRE00
    Dim taCAJ As New dsWALREPTableAdapters.TESDAZTableAdapter
    Dim dtCAJ As New dsWALREP.TESDAZDataTable
    Dim filaCAJ As dsWALREP.TESDAZRow
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtpInicio.Value = DetallePla.Fecha
        dtpFinal.Value = DetallePla.Fecha
        Trae_CajasTableAdapter.FillByPeriodo(DsWALREP.Trae_Cajas, dtpInicio.Value, dtpFinal.Value)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub dtpFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFinal.ValueChanged
        Trae_CajasTableAdapter.FillByPeriodo(DsWALREP.Trae_Cajas, dtpInicio.Value, dtpFinal.Value)
    End Sub

    Private Sub dtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicio.ValueChanged
        Trae_CajasTableAdapter.FillByPeriodo(DsWALREP.Trae_Cajas, dtpInicio.Value, dtpFinal.Value)
    End Sub

    Private Sub cbTodas_CheckedChanged(sender As Object, e As EventArgs) Handles cbTodas.CheckedChanged
        If cbTodas.Checked = True Then
            cbCajas.Enabled = False
        Else
            cbCajas.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' Generar Listado
        Me.Cursor = Cursors.WaitCursor
        If cbTodas.Checked = True Then
            taCAJ.FillByPeriodo(dtCAJ, dtpInicio.Value, dtpFinal.Value)
        Else
            taCAJ.FillByPeriodoCaja(dtCAJ, dtpInicio.Value, dtpFinal.Value, cbCajas.SelectedValue)
        End If
        Dim InfoTag As New Informes
        InfoTag.DatasTableImp = dtCAJ
        InfoTag.Reporte = "reportes\rptRecaudacion01.rpt"
        InfoTag.Numero = 18
        InfoTag.FechaIni = dtpInicio.Value
        InfoTag.FechaFin = dtpFinal.Value
        If cbTodas.Checked = True Then
            InfoTag.Argumento1lng = 0
        Else
            InfoTag.Argumento1lng = cbCajas.SelectedValue
        End If
        If cbTodas.Checked = True Then
            InfoTag.Argumento1lng = 0
        Else
            InfoTag.Argumento1lng = cbCajas.SelectedValue
        End If
        Dim Informe As New frmWALREP00
        Informe.WindowState = FormWindowState.Maximized
        Informe.Text = "Reporte - Distribución de Recaudación"
        Informe.Tag = InfoTag
        Informe.MdiParent = MDIPrincipal
        Informe.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class