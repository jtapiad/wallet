Public Class frmWALDET01
    Dim Total1 As Double
    Dim Total2 As Double
    Dim Columna As Integer
    Dim taAJM As New dsWALCUATableAdapters.AjustesManualesTableAdapter
    Dim dtAJM As New dsWALCUA.AjustesManualesDataTable
    Dim filaAJM As dsWALCUA.AjustesManualesRow
    Dim taDAZ As New dsWALCUATableAdapters.TESDAZTableAdapter
    Dim dtDAZ As New dsWALCUA.TESDAZDataTable
    Dim filaDAZ As dsWALCUA.TESDAZRow
    Dim Masivo As Boolean
    Dim sortColumn As Integer = -1
    Private Sub frmWALDET01_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Planilla As Long
        Dim Cuenta As Long
        Columna = Glo_Columna_Det
        ' Ajustes manuales de la Planilla de operaciones
        Planilla = DetallePla.Planilla
        Cuenta = Glo_Cuenta
        taAJM.FillTraeAjustesManuales(dtAJM, Planilla, Cuenta)
        ' desplegar datos
        Total1 = 0
        Total2 = 0
        For i = 0 To dtAJM.Count - 1

            filaAJM = dtAJM.Item(i)
            Dim Item As ListViewItem = New ListViewItem("Manual")
            If Not filaAJM.IsDAZ_CODIGONull Then
                Item.Checked = True
                Total1 = Total1 + filaAJM.DOP_MONTO
                Item.ForeColor = Control.DefaultForeColor
            Else
                Item.Checked = False
                Total2 = Total2 + filaAJM.DOP_MONTO
            End If
            Item.SubItems.Add(Format(filaAJM.DOP_MONTO, "#,##0"))
            Item.SubItems.Add("PO")
            Item.SubItems.Add("CA")
            Item.SubItems.Add(filaAJM.DOP_GLOSAADIC)
            Item.SubItems.Add(filaAJM.DOP_CODIGO)
            ListView1.Items.Add(Item)
        Next
        Me.Label1.Text = Format(Total1, "#,##0")
        Me.Label2.Text = Format(Total2, "#,##0")
        Me.Label3.Text = Format(Total1 + Total2, "#,##0")
        Me.GroupBox1.Text = "Detalle de Ajustes Manuales del Banco " & DetallePla.Banco & " (" & DetallePla.CuentaSAP & ") Columna : " & DetallePla.NombreColumna
    End Sub
    Private Sub frmWALDET01_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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

    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click
        Dim Actualiza As New dsWALCUATableAdapters.QueriesTableAdapter
        Total1 = 0
        Total2 = 0
        For i = 0 To dtAJM.Count - 1
            If Me.ListView1.Items(i).Checked = True Then
                filaAJM = dtAJM.Item(i)
                filaDAZ = dtDAZ.NewTESDAZRow
                filaDAZ.DAZ_MANDANTE = parametros.Mandante
                filaDAZ.DAZ_SOCIEDAD = 1000 ' COPEC
                filaDAZ.DAZ_CLASEDOC = "PO"
                filaDAZ.DAZ_CUENTABANCO = DetallePla.CuentaSAP
                filaDAZ.DAZ_MONTO = filaAJM.DOP_MONTO
                filaDAZ.DAZ_MONTOMON = filaAJM.DOP_MONTO
                filaDAZ.DAZ_MONEDA = "CLP"
                filaDAZ.DAZ_CONCEPTO = "CA"
                filaDAZ.DAZ_TEXTOPOS = filaAJM.DOP_GLOSAADIC
                filaDAZ.DAZ_FECHADOC = parametros.FechaPro
                filaDAZ.DAZ_FECHAz = parametros.FechaPro
                filaDAZ.DAZ_GLOSA = filaAJM.DOP_CODIGO.ToString
                filaDAZ.DAZ_ESTADO = "C"
                filaDAZ.DAZ_POSICION = "001"
                filaDAZ.DAZ_CAJA = " "
                filaDAZ.DAZ_DIAS = 0
                filaDAZ.DAZ_UNIDAD = " "
                filaDAZ.DAZ_EJERCICIO = Year(parametros.FechaPro)
                filaDAZ.DAZ_ANULADO = " "
                filaDAZ.DAZ_COLUMNA = DetallePla.Columna
                dtDAZ.AddTESDAZRow(filaDAZ)
                ' Se actualiza TESDAZ
                taDAZ.Update(dtDAZ)
                filaAJM.DAZ_CODIGO = filaDAZ.DAZ_CODIGO
                ' Actualiza tabla TESDOP y coloca el DAZ_CODIGO de la relación
                Actualiza.ActualizaDAZCodigo(filaDAZ.DAZ_CODIGO, filaAJM.DOP_CODIGO)
            End If
        Next
        DetallePla.Grabar = True
        Me.Close()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        DetallePla.Grabar = False
        Me.Close()
    End Sub

    Private Sub TSBTodos_Click(sender As Object, e As EventArgs) Handles TSBTodos.Click
        'Marcar todo
        For i = 0 To dtDAZ.Count - 1
            If Not Me.ListView1.Items(i).Checked Then
                Me.ListView1.Items(i).Checked = True
            End If
        Next
        masivo = True
        totales()
        masivo = False
        Me.Label1.Text = Format(Total1, "#,##0")
        Me.Label2.Text = Format(Total2, "#,##0")
        Me.Label3.Text = Format(Total1 + Total2, "#,##0")

    End Sub

    Private Sub tsbNinguno_Click(sender As Object, e As EventArgs) Handles tsbNinguno.Click
        'DesMarcar todo
        For i = 0 To dtDAZ.Count - 1
            If Me.ListView1.Items(i).Checked Then
                Me.ListView1.Items(i).Checked = False
            End If
        Next
        masivo = True
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

    Private Sub ListView1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListView1.ItemCheck
        If Masivo = False Then
            If e.NewValue = False Then
                Total1 = Total1 - CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
                Total2 = Total2 + CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
            Else
                Total1 = Total1 + CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
                Total2 = Total2 - CDbl(Me.ListView1.Items(e.Index).SubItems(1).Text)
            End If
            Me.Label1.Text = Format(Total1, "#,##0")
            Me.Label2.Text = Format(Total2, "#,##0")
            Me.Label3.Text = Format(Total1 + Total2, "#,##0")
        End If

    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        Masivo = True
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
        Masivo = False
    End Sub
End Class