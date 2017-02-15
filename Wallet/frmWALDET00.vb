Public Class frmWALDET00
    Dim Total1 As Double
    Dim Total2 As Double
    Dim taDAZ As New dsWALCUATableAdapters.TESDAZTableAdapter
    Dim dtDAZ As New dsWALCUA.TESDAZDataTable
    Dim filaDAZ As dsWALCUA.TESDAZRow
    Dim masivo As Boolean = False
    Dim Carga As Boolean = False
    Dim sortColumn As Integer = -1


    Private Sub TSBTodos_Click(sender As Object, e As EventArgs) Handles TSBTodos.Click
        'Marcar todo
        masivo = True
        For i = 0 To ListView1.Items.Count - 1
            If Me.ListView1.Items(i).SubItems(10).Text = 0 Then
                If Not Me.ListView1.Items(i).Checked Then
                    Me.ListView1.Items(i).Checked = True
                End If
            End If
        Next
        totales()
        masivo = False
        Me.Label1.Text = Format(Total1, "#,##0")
        Me.Label2.Text = Format(Total2, "#,##0")
        Me.Label3.Text = Format(Total1 + Total2, "#,##0")

    End Sub

    Private Sub tsbNinguno_Click(sender As Object, e As EventArgs) Handles tsbNinguno.Click
        'DesMarcar todo
        masivo = True
        For i = 0 To ListView1.Items.Count - 1
            If Me.ListView1.Items(i).SubItems(10).Text = 0 Then
                If Me.ListView1.Items(i).Checked Then
                    Me.ListView1.Items(i).Checked = False
                End If
            End If
        Next
        totales()
        masivo = False
        Me.Label1.Text = Format(Total1, "#,##0")
        Me.Label2.Text = Format(Total2, "#,##0")
        Me.Label3.Text = Format(Total1 + Total2, "#,##0")
    End Sub
    Private Sub totales()
        Total1 = 0
        Total2 = 0
        For i = 0 To ListView1.Items.Count - 1
            If Me.ListView1.Items(i).Checked Then
                Total1 = Total1 + CDbl(Me.ListView1.Items(i).SubItems(1).Text)
            Else
                Total2 = Total2 + CDbl(Me.ListView1.Items(i).SubItems(1).Text)
            End If
        Next

    End Sub
    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click
        'Grabar todo
        Total1 = 0
        Total2 = 0
        For i = 0 To dtDAZ.Count - 1
            If IsNumeric(ListView1.Items(i).SubItems(7).Text) Then
                filaDAZ = dtDAZ.FindByDAZ_CODIGO(CLng(ListView1.Items(i).SubItems(7).Text))
                If filaDAZ IsNot Nothing Then
                    If Me.ListView1.Items(i).Checked = True Then
                        filaDAZ.PLA_CODIGO = DetallePla.Planilla
                    Else
                        filaDAZ.SetPLA_CODIGONull()
                    End If
                    taDAZ.Update(dtDAZ)
                End If
            End If
        Next
        Me.Close()
    End Sub

    Private Sub frmWALDET00_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cursor = Cursors.WaitCursor
        MostrarDatos()
        Cursor = Cursors.Default
    End Sub
    Private Sub MostrarDatos()
        Me.Width = Me.Width + 10
        ListView1.CheckBoxes = True
        Dim NombreColumna As String = ""
        Select Case DetallePla.Columna
            Case 5
                NombreColumna = "Rescates"
                taDAZ.FillByRescates(dtDAZ, DetallePla.CuentaSAP)
            Case 7
                ' Recaudación
                NombreColumna = "Recaudacion"
                taDAZ.FillByRecaudacion(dtDAZ, DetallePla.CuentaSAP, DetallePla.Fecha)
            Case 9
                NombreColumna = "Cheques Devueltos"
                taDAZ.FillByChequesDev(dtDAZ, DetallePla.CuentaSAP)
            Case 11
                NombreColumna = "Aportes"
                Exit Sub
            Case 13
                NombreColumna = "Otros Ingresos"
                taDAZ.FillByOtrosIngresos(dtDAZ, DetallePla.CuentaSAP2, DetallePla.Fecha)
            Case 15
                NombreColumna = "Pagos con Cheques"
                taDAZ.FillByPagosCheques(dtDAZ, DetallePla.CuentaSAP2, DetallePla.Fecha)
            Case 19
                NombreColumna = "Cheques Cartera"
                Exit Sub
            Case 17
                NombreColumna = "Otros Cargos"
                taDAZ.FillByOtrosCargos(dtDAZ, DetallePla.CuentaSAP2, DetallePla.Fecha)
                Exit Sub
            Case 21
                NombreColumna = "Transferencias Positivas"
                Exit Sub
            Case 23
                NombreColumna = "Transferencias Negativas"
                ' Transferencias Negativas
                taDAZ.FillByTransferenciasNeg(dtDAZ, DetallePla.CuentaSAP2, DetallePla.Fecha)
            Case 25
                NombreColumna = "Colocaciones"
                ' Colocaciones
                taDAZ.FillByColocaciones(dtDAZ, DetallePla.CuentaSAP2, DetallePla.Fecha)
                'Case 28
            Case 28
                NombreColumna = "Pagos con Cheques"
                ' Pagsos con Cheques
                taDAZ.FillByPagoCheques2(dtDAZ, DetallePla.CuentaSAP2, DetallePla.Fecha)
        End Select
        DetallePla.NombreColumna = NombreColumna
        ' desplegar datos
        Carga = True
        Total1 = 0
        Total2 = 0
        Dim Bloqueo As Integer
        For i = 0 To dtDAZ.Count - 1
            filaDAZ = dtDAZ.Item(i)
            Dim Item As ListViewItem = New ListViewItem(filaDAZ.DAZ_CAJA)
            If filaDAZ.DAZ_CONCEPTO = "DE" And filaDAZ.DAZ_CLASEDOC <> "pl" Then
                Bloqueo = 1
            Else
                Bloqueo = 0
            End If
            '2sys:Revisar logica de esta linea
            If filaDAZ.IsPLA_CODIGONull Then
                Item.Checked = False
            Else

                If filaDAZ.PLA_CODIGO = DetallePla.Planilla Then
                    Item.Checked = True
                    Item.ForeColor = Control.DefaultForeColor
                End If

            End If
            Item.SubItems.Add(Format(filaDAZ.DAZ_MONTOMON, "#,##0"))
            Item.SubItems.Add(filaDAZ.DAZ_CLASEDOC)
            Item.SubItems.Add(filaDAZ.DAZ_CONCEPTO)
            Item.SubItems.Add(Trim(filaDAZ.DAZ_TEXTOPOS))
            Item.SubItems.Add(IIf(filaDAZ.IsDAZ_GLOSANull, "", Trim(filaDAZ.DAZ_GLOSA)))
            Item.SubItems.Add(Format(filaDAZ.DAZ_MONTOMON, "000000000000"))
            Item.SubItems.Add(filaDAZ.DAZ_CODIGO)
            Item.SubItems.Add(Format(filaDAZ.DAZ_FECHADOC, "dd/MM/yyyy"))
            If filaDAZ.IsDAZ_FECHADEPNull Then
                Item.SubItems.Add("S/D")
            Else
                Item.SubItems.Add(Format(filaDAZ.DAZ_FECHADEP, "dd/MM/yyyy"))
            End If
            Item.SubItems.Add(Bloqueo)
            ListView1.Items.Add(Item)
        Next
        totales()
        Me.Label1.Text = Format(Total1, "#,##0")
        Me.Label2.Text = Format(Total2, "#,##0")
        Me.Label3.Text = Format(Total1 + Total2, "#,##0")
        Me.GroupBox1.Text = "Detalle del Banco " & DetallePla.Banco & " (" & DetallePla.CuentaSAP & ") Columna : " & NombreColumna
        '
        Carga = False
    End Sub
    Private Sub frmWALDET00_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim factor As Integer
        Me.GroupBox2.Left = (Me.GroupBox1.Width / 4) - (Me.GroupBox2.Width / 2)
        Me.GroupBox3.Left = (Me.GroupBox1.Width / 4) * 2 - (Me.GroupBox2.Width / 2)
        Me.GroupBox4.Left = (Me.GroupBox1.Width / 4) * 3 - (Me.GroupBox2.Width / 2)
        factor = (Me.ListView1.Width - 15) / 23
        Me.ListView1.Columns(0).Width = factor * 2
        Me.ListView1.Columns(1).Width = factor * 3
        Me.ListView1.Columns(2).Width = factor * 2
        Me.ListView1.Columns(3).Width = factor * 2
        Me.ListView1.Columns(4).Width = factor * 5
        Me.ListView1.Columns(5).Width = factor * 5
        Me.ListView1.Columns(8).Width = factor * 2
        Me.ListView1.Columns(9).Width = factor * 2
    End Sub

    Private Sub ListView1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListView1.ItemCheck
        If Carga Then
            Exit Sub
        End If
        If masivo Then
            Exit Sub
        End If
        If Me.ListView1.Items(e.Index).SubItems(10).Text = 1 Then
            If e.NewValue = CheckState.Checked Then
                e.NewValue = CheckState.Unchecked
            Else
                e.NewValue = CheckState.Checked
            End If
            Exit Sub
        End If
        If e.NewValue = CheckState.Checked Then
            Total1 = Total1 + CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
            Total2 = Total2 - CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
        Else
            Total2 = Total2 + CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
            Total1 = Total1 - CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
        End If
        Me.Label1.Text = Format(Total1, "#,##0")
        Me.Label2.Text = Format(Total2, "#,##0")
        Me.Label3.Text = Format(Total1 + Total2, "#,##0")

    End Sub



    Private Sub tsbAjustes_Click(sender As Object, e As EventArgs) Handles tsbAjustes.Click
        Dim FORMULARIO As New frmWALDET01
        FORMULARIO.ShowDialog()
        Me.ListView1.Items.Clear()
        MostrarDatos()
    End Sub
    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        If masivo = False Then
            totales()
            Me.Label1.Text = Format(Total1, "#,##0")
            Me.Label2.Text = Format(Total2, "#,##0")
            Me.Label3.Text = Format(Total1 + Total2, "#,##0")
        End If
        'Dim Expresion As String = "DAZ_CODIGO=" & ListView1.Items(e.Index).SubItems(7).Text.ToString
        'Dim Fila() As DataRow = dtDAZ.Select(Expresion)
        'filaDAZ = TryCast(Fila(0), dsWALCUA.TESDAZRow)
        'If filaDAZ.DAZ_CONCEPTO = "DE" And filaDAZ.DAZ_CLASEDOC <> "pl" Then
        '    e.NewValue = e.CurrentValue
        'End If

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        masivo = True
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ListView1.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If
        Me.ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting)
        masivo = False
    End Sub
End Class
