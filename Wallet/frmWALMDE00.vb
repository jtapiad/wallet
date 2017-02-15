Public Class frmWALMDE00
    Dim Items As ListViewItem
    Dim Clave As String
    Dim Monto As Double
    Dim taDOP As New dsWALPLATableAdapters.Trae_Detalle_OperacionesTableAdapter
    Dim dtDOP As New dsWALPLA.Trae_Detalle_OperacionesDataTable
    Dim FilaDOP As dsWALPLA.Trae_Detalle_OperacionesRow
    Dim sortColumn As Integer = -1
    Dim Masivo As Integer = -1
    Private Sub frmWALMDE00_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        CargarLista()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CargarLista()
        Cursor = Cursors.WaitCursor
        Dim Total As Double
        Me.ListView1.Items.Clear()
        Glo_Cambio = 0
        Clave = ""
        Me.Text = Glo_Caption
        taDOP.FillByColumnaPlanillaCuenta(dtDOP, Glo_Columna, Planilla, Glo_Cuenta)
        If dtDOP.Count > 0 Then

            Total = 0
            For i = 0 To dtDOP.Count - 1
                FilaDOP = dtDOP.Item(i)
                Dim Item As ListViewItem = New ListViewItem(Trim(FilaDOP.DOP_GLOSAADIC))
                Clave = "K" + Format(FilaDOP.DOP_CODIGO, "0000000")
                Item.SubItems.Add(Format(FilaDOP.DOP_MONTO, "$##,##0"))
                If FilaDOP.IsDOP_NUMERONull Then
                    Item.SubItems.Add("")
                Else
                    Item.SubItems.Add(FilaDOP.DOP_NUMERO)
                End If
                Item.SubItems.Add(Clave)
                ListView1.Items.Add(Item)
                Total = Total + FilaDOP.DOP_MONTO
            Next
        End If
        tslTotal.Text = Format(Total, "$##,##0")
        Cursor = Cursors.Default

    End Sub
    Private Sub NuevosTotales()

    End Sub
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
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
        ' Call the sort method to manually sort.
        ListView1.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting)
        Masivo = False
    End Sub

    Private Sub tsbModificar_Click(sender As Object, e As EventArgs) Handles tsbModificar.Click
        ' Modificar el registro seleccionado
        Try
            Clave = ListView1.SelectedItems(0).SubItems(3).Text.Substring(1)
            Dim accion As New Acciones
            accion.accion = 1
            accion.clave = Clave
            Dim formulario As New frmWALMMO00
            formulario.Tag = accion

            formulario.ShowDialog()

            CargarLista()
        Catch ex As Exception
            MsgBox("Debe seleccionar un registro previamente", MsgBoxStyle.Information, NombreSistema)
            Exit Sub
        End Try
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        Try
            Clave = ListView1.SelectedItems(0).SubItems(3).Text.Substring(1)
            Dim accion As New Acciones
            accion.accion = 3
            accion.clave = Clave
            Dim formulario As New frmWALMMO00
            formulario.Tag = accion
            formulario.ShowDialog()
            CargarLista()
        Catch ex As Exception
            If ex.HResult = -2146233086 Then
                MsgBox("Debe seleccionar un registro previamente", MsgBoxStyle.Information, NombreSistema)
            Else
                MsgBox("Este registro no puede ser borrar ya que tiene registros asociados.", MsgBoxStyle.Information, NombreSistema)
            End If

            Exit Sub
        End Try
    End Sub

    Private Sub tsbListar_Click(sender As Object, e As EventArgs) Handles tsbListar.Click
        ' Listar Movimientos
        '2SYS: Agregar listado

        Dim Informe As New frmWALLIS00(Glo_Columna, Glo_Cuenta, Glo_Banco)
        'Informe.MdiParent = MDIPrincipal
        Informe.ShowDialog()
    End Sub

    Private Sub tsbListarCaja_Click(sender As Object, e As EventArgs) Handles tsbListarCaja.Click
        Dim Informe As New frmWALLIS99(Glo_Columna, Glo_Cuenta, Glo_Banco)
        'Informe.MdiParent = MDIPrincipal
        Informe.ShowDialog()
    End Sub
End Class
Public Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private _sort As Integer

    Public Sub New()
        col = 0
        _sort = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, sort As Integer)
        col = column
        _sort = sort
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        If IsDate(CType(x, ListViewItem).SubItems(col).Text) And IsDate(CType(y, ListViewItem).SubItems(col).Text) Then
            Dim fecha1 As System.DateTime = DateTime.Parse(CType(x, ListViewItem).SubItems(col).Text)
            Dim fecha2 As System.DateTime = DateTime.Parse(CType(y, ListViewItem).SubItems(col).Text)
            returnVal = fecha1.CompareTo(fecha2)
        ElseIf IsNumeric(CType(x, ListViewItem).SubItems(col).Text) And IsNumeric(CType(y, ListViewItem).SubItems(col).Text) Then
            Dim Numero1 As System.Double = Double.Parse(CType(x, ListViewItem).SubItems(col).Text)
            Dim numero2 As System.Double = Double.Parse(CType(y, ListViewItem).SubItems(col).Text)
            returnVal = Numero1.CompareTo(numero2)
        Else
            returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        End If

        If _sort = SortOrder.Descending Then
            returnVal *= -1
        End If
        Return returnVal
    End Function
End Class