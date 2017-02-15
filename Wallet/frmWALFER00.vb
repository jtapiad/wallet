Imports Syncfusion.Schedule
Imports Syncfusion.Windows.Forms.Schedule

Public Class frmWALFER00
    ''' <summary>
    ''' Nombre Programa : frmWALFER00
    ''' Descripción     : Mantención de feriados
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim dt As New dsWALFER.TESFERDataTable
    Dim ta As New dsWALFERTableAdapters.TESFERTableAdapter

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    ''' <summary>
    ''' Carga los feriados y luego actualiza
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALFER00_Load(sender As Object, e As EventArgs) Handles Me.Load

        CargaFeriados()
        Me.mcFeriados.UpdateBoldedDates()


    End Sub
    ''' <summary>
    ''' Agrega cada uno de los feriados para luego actualizar
    ''' </summary>
    Private Sub CargaFeriados()
        ta.Fill(dt)
        Dim Fechas(dt.Count - 1) As Date
        Dim i As Integer = 0
        For Each Fila As dsWALFER.TESFERRow In dt
            Fechas(i) = Fila.FER_FERIADO
            Me.mcFeriados.AddBoldedDate(Fechas(i))
            i = +1
        Next
    End Sub
    ''' <summary>
    ''' Sale del programa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptFeriados00.rpt"
        InfoTag.Numero = 8
        InfoTag.Argumento1lng = mcFeriados.SelectionStart.Year
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default

    End Sub
End Class