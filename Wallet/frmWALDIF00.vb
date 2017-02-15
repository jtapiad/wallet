Imports Syncfusion.Windows.Forms

Public Class frmWALDIF00
    Public Sub New(ByVal Tabla As dsWALCUA.DiferenciasDataTable, ByVal Titulo As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        GridGroupingControl1.DataSource = Tabla
        Me.Text = Titulo
        CambioDePiel(Temas.Cierre)
    End Sub
    Private Sub CambioDePiel(piel As Integer)
        Select Case piel
            Case 0
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
            Case 1
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Blue
                GridGroupingControl1.Office2007ScrollBars = True
                GridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
            Case 2
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Black
                GridGroupingControl1.Office2007ScrollBars = True
                GridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
            Case 3
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Silver
                GridGroupingControl1.Office2007ScrollBars = True
                GridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
            Case 4
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Blue
                GridGroupingControl1.Office2007ScrollBars = False
                GridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue
            Case 5
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Black
                GridGroupingControl1.Office2007ScrollBars = False
                GridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
            Case 6
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Silver
                GridGroupingControl1.Office2007ScrollBars = False
                GridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver
            Case 7
                GridGroupingControl1.GridVisualStyles = GridVisualStyles.SystemTheme

        End Select
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class