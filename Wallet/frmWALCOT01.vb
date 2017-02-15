Imports Syncfusion.Grouping

Public Class frmWALCOT01
    Dim taPIZ As New dsWALCOTTableAdapters.PizarraTableAdapter
    Dim dtPIZ As New dsWALCOT.PizarraDataTable
    Dim FilaPIZ As dsWALCOT.PizarraRow
    Dim taHAS As New dsWALCOTTableAdapters.HastasTableAdapter
    Dim dtHAS As New dsWALCOT.HastasDataTable
    Dim FilaHAS As dsWALCOT.HastasRow


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
        EntidadesTableAdapter.FillbyInicio(DsWALCOT.entidades, DetallePla.Fecha)
    End Sub
    Private Sub CargarTasas()
        CargarColumnasFechas()
        taPIZ.FillbyInicio(dtPIZ, DetallePla.Fecha)
        For i = 0 To dtPIZ.Count - 1
            FilaPIZ = dtPIZ.Item(i)
            Dim texto As String
            texto = FormatNumber(FilaPIZ.F_P_, 3) & " - " & FormatNumber(FilaPIZ.F_E_, 3)
            Dim fila As dsWALCOT.entidadesRow
            Dim agregar As Boolean = False
            For j = 0 To DsWALCOT.entidades.Count - 1
                fila = DsWALCOT.entidades.Item(j)
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
                    ' se encontro igualdad en la fila j
                    Dim detalle As New DataGridViewRow
                    detalle = dgvPizarra.Rows(j)
                    detalle.Cells(Format(FilaHAS.hasta, "dd/MM/yyyy")).Value = FormatNumber(FilaPIZ.F_P_, 3) & " - " & FormatNumber(FilaPIZ.F_E_, 3)
                End If
            Next

        Next
    End Sub


    Private Sub CargarColumnasFechas()


        taHAS.Fill(dtHAS, DetallePla.Fecha)
        For i = 0 To dtHAS.Count - 1
            FilaHAS = dtHAS.Item(i)
            Dim columna As New DataGridViewTextBoxColumn
            columna.HeaderText = Format(FilaHAS.hasta, "dd/MM/yyyy")
            columna.Name = Format(FilaHAS.hasta, "dd/MM/yyyy")
            columna.Width = 100
            columna.DataPropertyName = Nothing
            dgvPizarra.Columns.Add(columna)
        Next


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class