Public Class frmWALLIS00
    Dim Columna As Integer
    Dim Cuenta As Long
    Dim Banco As String
    Dim taDOP As New dsWALREPTableAdapters.TESDOPTableAdapter
    Dim dtDOP As New dsWALREP.TESDOPDataTable


    Public Sub New(Col As Integer, Cta As Long, Ban As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Columna = Col
        Cuenta = Cta
        Banco = Ban
        Select Case Columna
            Case 2
                Me.Label3.Text = "Saldo Inicial"
            Case 3
                Me.Label3.Text = "Rescates"
            Case 4
                Me.Label3.Text = "Recaudación"
            Case 5
                Me.Label3.Text = "Cheques devueltos"
            Case 6
                Me.Label3.Text = "Aportes"
            Case 7
                Me.Label3.Text = "Otros"
            Case 8
                Me.Label3.Text = "Pagos con Cheque"
            Case 9
                Me.Label3.Text = "Cheques en Cartera"
            Case 10
                Me.Label3.Text = "Pagos con Cargo"
            Case 11
                Me.Label3.Text = "Transferencias Positivas"
            Case 12
                Me.Label3.Text = "Transferencias Negativas"
            Case 14
                Me.Label3.Text = "Colocaciones"
        End Select
        Me.Label4.Text = Banco
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        ' Salir
        Me.Close()
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        'Imprimir
        Dim InfoTag As New Informes
        InfoTag.Argumento1lng = 0
        InfoTag.Argumento2lng = 0
        InfoTag.Numero = parametros.Planilla
        If cbTodasCol.Checked = False And cbTodasCta.Checked = False Then
            taDOP.FillByPlanillaColumnaCuenta(dtDOP, parametros.Planilla, Columna, Cuenta)
            InfoTag.Argumento1lng = Columna
            InfoTag.Argumento2lng = Cuenta
        ElseIf cbTodasCol.Checked = True And cbTodasCta.Checked = False Then
            taDOP.FillByPlanillaCuenta(dtDOP, parametros.Planilla, Cuenta)
            InfoTag.Argumento2lng = Cuenta
        ElseIf cbTodasCol.Checked = False And cbTodasCta.Checked = True Then
            taDOP.FillByPlanillaColumna(dtDOP, parametros.Planilla, Columna)
            InfoTag.Argumento1lng = Columna
        Else
            taDOP.FillByPlanilla(dtDOP, parametros.Planilla)
        End If
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptDetalles00.rpt"
        InfoTag.Numero = 19
        InfoTag.DatasTableImp = dtDOP
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default

    End Sub
End Class