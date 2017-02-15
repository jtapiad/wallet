Imports Microsoft.Office.Core
Imports Syncfusion.Grouping
Public Class frmWALCOT02

    Dim taPIZ As New dsWALCOTTableAdapters.PizarraTableAdapter
    Dim dtPIZ As New dsWALCOT.PizarraDataTable
    Dim FilaPIZ As dsWALCOT.PizarraRow
    Dim taHAS As New dsWALCOTTableAdapters.HastasTableAdapter
    Dim dtHAS As New dsWALCOT.HastasDataTable
    Dim FilaHAS As dsWALCOT.HastasRow
    Dim taENT As New dsWALCOTTableAdapters.entidadesTableAdapter
    Dim dtENT As New dsWALCOT.entidadesDataTable
    Dim FilaENT As dsWALCOT.entidadesRow
    Dim Fechas As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        taHAS.Fill(dtHAS, DetallePla.Fecha)
        'AddHandler GridGroupingControl1.TableDescriptor.QueryValue, AddressOf TableDescriptor_QueryValue
        'AddHandler GridGroupingControl1.TableDescriptor.SaveValue, AddressOf TableDescriptor_SaveValue


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub frmWALCOT01_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarEntidades()
        CargarTasas()
    End Sub
    Private Sub CargarEntidades()
        taENT.FillbyInicio(dtENT, DetallePla.Fecha)
        lvPizarra.Clear()
        Dim columna As New ColumnHeader("Entidad")
        columna.Text = "Entidades"
        columna.Name = "Entidades"
        columna.Width = 150
        lvPizarra.Columns.Add(columna)
        columna = New ColumnHeader("Fondo")
        columna.Text = "Fondo"
        columna.Name = "Fondo"
        columna.Width = 150
        lvPizarra.Columns.Add(columna)
        taHAS.Fill(dtHAS, DetallePla.Fecha)
        For i = 0 To dtHAS.Count - 1
            FilaHAS = dtHAS.Item(i)
            columna = New ColumnHeader(Format(FilaHAS.hasta, "dd/MM/yyyy"))
            columna.Text = Format(FilaHAS.hasta, "dd/MM/yyyy")
            columna.Name = Format(FilaHAS.hasta, "dd/MM/yyyy")
            columna.Width = 100
            columna.TextAlign = HorizontalAlignment.Center
            lvPizarra.Columns.Add(columna)
        Next
        Fechas = dtHAS.Count
        For i = 0 To dtENT.Count - 1
            FilaENT = dtENT.Item(i)
            Dim Item As ListViewItem = New ListViewItem(FilaENT.ENTIDAD.Trim)
            If FilaENT.IsFONDONull Then
                Item.SubItems.Add("")
            Else
                Item.SubItems.Add(FilaENT.FONDO.Trim)
            End If
            For j = 1 To Fechas
                Item.SubItems.Add("")
            Next
            lvPizarra.Items.Add(Item)
        Next
        lvPizarra.Refresh()
    End Sub
    Private Sub CargarTasas()
        taPIZ.FillbyInicio(dtPIZ, DetallePla.Fecha)
        For i = 0 To dtPIZ.Count - 1
            FilaPIZ = dtPIZ.Item(i)
            Dim texto As String
            texto = FormatNumber(FilaPIZ.F_P_, 3) & " - " & FormatNumber(FilaPIZ.F_E_, 3)
            Dim fila As dsWALCOT.entidadesRow
            Dim agregar As Boolean = False
            For j = 0 To dtENT.Count - 1
                fila = dtENT.Item(j)
                If fila.ENT_CODIGO = FilaPIZ.ent_codigo Then
                    If fila.IsFON_CODIGONull And FilaPIZ.IsFON_CODIGONull Then
                        agregar = True
                    Else
                        If Not fila.IsFON_CODIGONull And Not FilaPIZ.IsFON_CODIGONull AndAlso fila.FON_CODIGO = FilaPIZ.FON_CODIGO Then
                            agregar = True
                        End If
                    End If
                End If
                If agregar = True Then
                    agregar = False
                    ' se encontro igualdad en la fila j
                    Dim detalle As New ListViewItem
                    detalle = lvPizarra.Items(j)
                    Dim x As Integer
                    For x = 1 To Fechas
                        If lvPizarra.Columns(x).Name = Format(FilaPIZ.TERMINO, "dd/MM/yyyy") Then
                            Exit For
                        End If
                    Next
                    x = x
                    detalle.SubItems(x).Text = FormatNumber(FilaPIZ.F_P_, 3) & " - " & FormatNumber(FilaPIZ.F_E_, 3)
                End If
            Next

        Next
    End Sub

    Private Sub tsbExporta_Click(sender As Object, e As EventArgs) Handles tsbExporta.Click
        ' exportación a Excel
        Dim Ubicacion As String
        Dim Nombre As String
        Dim NoMostrar As String
        NoMostrar = ""
        Nombre = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        Ubicacion = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        'GuardarFoto()
        ' Exportar a Excel
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            Dim NCol As Integer = lvPizarra.Columns.Count
            Dim NRow As Integer = lvPizarra.Items.Count
            Dim Letras As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim Rango As String
            Rango = "A5:" & Mid(Letras, 2 + ((NCol - 2) * 2), 1) & "5"

            'Títulos
            exHoja.Range(Rango).Merge()
            exHoja.Range(Rango).HorizontalAlignment = XlHAlign.xlHAlignCenter
            exHoja.Range(Rango).Value = "Evaluación de Tasas del " & FormatDateTime(DetallePla.Fecha, DateFormat.ShortDate)
            exHoja.Range(Rango).Font.Bold = True
            exHoja.Range(Rango).Font.Size = 14
            Rango = "A6:" & Mid(Letras, 2 + ((NCol - 2) * 2), 1) & (6 + NRow + 1).ToString


            'exHoja.Shapes.AddPicture(Ubicacion & "\logo.jpg", MsoTriState.msoFalse, MsoTriState.msoCTrue, 0, 0, My.Resources.logo.Width / 24, My.Resources.logo.Height / 24)
            'exHoja.Shapes.AddPicture(Ubicacion & "\Logo Sistema.jpg", MsoTriState.msoFalse, MsoTriState.msoCTrue, 900, 0, My.Resources.Logo_Wallet.Width / 10, My.Resources.Logo_Wallet.Height / 10)

            ' ¿Cuantas columnas y cuantas filas?
            'recorremos todas las filas, y por cada fila todas las columnas
            'y vamos escribiendo.
            Dim j As Integer = 1
            For i As Integer = 1 To NCol
                If InStr(NoMostrar, Format(i, "000")) = 0 Then

                    If i > 2 Then
                        exHoja.Cells.Item(6, j).NumberFormat = ("dd/MM/yyyy;@")
                        Dim strFecha = Format(Convert.ToDateTime(lvPizarra.Columns(i - 1).Text.ToString), "MM/dd/yyyy")
                        exHoja.Cells.Item(6, j) = strFecha
                    Else
                        exHoja.Cells.Item(6, j) = lvPizarra.Columns(i - 1).Text.ToString
                    End If


                    exHoja.Cells.Item(6, j).Interior.ColorIndex = 35
                End If
                If i < 3 Then
                    j = j + 1
                Else
                    j = j + 2
                End If

            Next
            exHoja.Cells.Item(6, j - 1).Interior.ColorIndex = 35
            For Fila As Integer = 0 To NRow - 1
                j = 0
                For Col As Integer = 0 To NCol - 1
                    If InStr(NoMostrar, Format(Col + 1, "000")) = 0 Then

                        exHoja.Cells.Item(Fila + 7, j + 1) = lvPizarra.Items(Fila).SubItems(Col).Text
                        If Col + 1 < 3 Then
                            exHoja.Cells.Item(Fila + 7, j + 1).Interior.ColorIndex = 35
                            j = j + 1
                        Else
                            j = j + 2
                        End If
                    End If
                Next

            Next

            exHoja.Range(Rango).Borders.LineStyle = LineStyle.SingleLine
            exHoja.Range(Rango).EntireColumn.AutoFit()

            Rango = "A6:" & Mid(Letras, 2 + ((NCol - 2) * 2), 1) & "6"
            exHoja.Range(Rango).Interior.ColorIndex = 35
            exHoja.Range(Rango).HorizontalAlignment = XlHAlign.xlHAlignCenter


            exHoja.Name = "Pizarra desde Wallet"
            'For i = 0 To NCol - 1
            '    exHoja.Cells.Item(6, j) = lvPizarra.Columns(i - 1).Text.ToString
            'Next
            exHoja.Rows.Item(6).Font.Bold = 1
            exHoja.Columns.Item(1).Font.Bold = 1
            exHoja.Columns.Item(2).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'para visualizar el libro
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try


    End Sub


    'Private Sub CargarColumnasFechas()


    '    taHAS.Fill(dtHAS, DetallePla.Fecha)
    '    For i = 0 To dtHAS.Count - 1
    '        FilaHAS = dtHAS.Item(i)
    '        Dim columna As New DataGridViewTextBoxColumn
    '        columna.HeaderText = Format(FilaHAS.hasta, "dd/MM/yyyy")
    '        columna.Name = Format(FilaHAS.hasta, "dd/MM/yyyy")
    '        columna.Width = 100
    '        columna.DataPropertyName = Nothing
    '        dgvPizarra.Columns.Add(columna)
    '    Next


    'End Sub

End Class