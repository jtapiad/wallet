Imports System.ComponentModel

Public Class frmWALPPE00
    Dim taPPE As New dsWALPPETableAdapters.PartidasPendientesSAPTableAdapter
    Dim dtPPE As New dsWALPPE.PartidasPendientesSAPDataTable
    Dim filaPPE As dsWALPPE.PartidasPendientesSAPRow
    Dim k As Integer
    Private mItem As ListViewItem
    Dim Clave As String
    Dim sortColumn As Integer = -1
    Dim Fin As Integer
    Dim Masivo As Integer


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gbTipo.Enter

    End Sub

    Private Sub rbCaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbCaja.CheckedChanged
        Me.Cursor = Cursors.WaitCursor

        llenar()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmWALPPE00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cuentas_PlanillaTableAdapter.Fill(Me.DsWALPPE.Cuentas_Planilla)
        Me.Cursor = Cursors.WaitCursor
        llenar()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub llenar()


        ' seleccionar Bancos de la lista a procesar
        Dim Bancos As String = ""
        ListView1.Clear()
        ListView1.Columns.Add("Tipo de Movimiento", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Monto", 150, HorizontalAlignment.Right)
        ListView1.Columns.Add("Columna", 150, HorizontalAlignment.Right)
        ListView1.Columns.Add("Key", 0, HorizontalAlignment.Right)
        ListView1.View = View.Details
        If Me.cbBancos.Text = "" Then
            MsgBox("Debe seleccional un Banco", vbInformation, "Mensaje del Sistema")
            Exit Sub
        End If

        Bancos = Mid(cbBancos.SelectedValue, 4, 6) & "1"
        On Error GoTo 0
        Dim CodDocto As String
        If rbCaja.Checked = True Then
            CodDocto = "FU"
        Else
            CodDocto = "ZR"
        End If

        taPPE.FillbyClasedocBancoMandante(dtPPE, CodDocto, Trim(Bancos), Mandante)
        ' En sistema AS/400 se cargaban Recaudación, Cheques Devueltos y Otros Ingresos
        'k = 0
        If dtPPE.Count > 0 Then
            k = dtPPE.Count - 1
            For i = 0 To dtPPE.Count - 1
                'k = k + 1
                filaPPE = dtPPE.Item(i)
                Clave = CStr(i) & " K"
                Dim Item As ListViewItem = New ListViewItem(filaPPE.DAZ_DOCCONT & "|" & Format(filaPPE.DAZ_FECHADOC, "dd/MM/yyyy") & " " & filaPPE.DAZ_TEXTOPOS.Trim)
                Item.SubItems.Add(Format(filaPPE.DAZ_MONTO, "##,##0"))
                Item.SubItems.Add("P.Pendientes")
                Item.SubItems.Add(Clave)
                ListView1.Items.Add(Item)
            Next
        Else
            MsgBox("No hay Partidas pendientes que procesar", vbInformation, "Mensaje del Sistema")
        End If
    End Sub


    Private Sub cbBancos_TextChanged(sender As Object, e As EventArgs) Handles cbBancos.TextChanged
        If Fin <> 9 Then

            Me.Cursor = Cursors.WaitCursor

            llenar()
            Me.Cursor = Cursors.Default
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
        ' Call the sort method to manually sort.
        ListView1.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting)
        Masivo = False
    End Sub

    Private Sub frmWALPPE00_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Fin = 9
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbUtilizar_Click(sender As Object, e As EventArgs) Handles tsbUtilizar.Click
        ' generar movimientos

        For i = 0 To ListView1.Items.Count - 1

            If Me.ListView1.Items(i).Checked Then

                Generar(CLng(cbBancos.SelectedValue), CDbl(Me.ListView1.Items(i).SubItems(1).Text), Me.ListView1.Items(i).Text)
                Exit For
            End If
        Next
        Me.Close()
    End Sub
    Private Sub Generar(Cuenta As Long, Monto As Double, Tipo As String)
        Dim taDPL As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
        Dim dtDPL As New dsWALPLA.DetallePlanillaDataTable
        Dim filaDPL As dsWALPLA.DetallePlanillaRow
        Dim taDOP As New dsWALPPETableAdapters.TESDOPTableAdapter
        Dim dtDOP As New dsWALPPE.TESDOPDataTable
        Dim filaDOP As dsWALPPE.TESDOPRow
        Dim filaCuenta As DataRowView = CuentasPlanillaBindingSource.Current
        taDPL.FillByPlanillaCuenta(dtDPL, Planilla, filaCuenta.Item("CTE_CODIGO"))
        filaDPL = dtDPL.Item(0)

        'DE1.rsDetalle_Operaciones.AddNew
        filaDOP = dtDOP.NewTESDOPRow()



        filaDOP.DPL_CODIGO = filaDPL.DPL_CODIGO
        Select Case Tipo
            Case "RECAUD"      ' Recaudaciones
                filaDOP.COL_CODIGO = 4
                filaDOP.DOP_TIPO = "M"
            Case "CZ1101"     ' Cheques devueltos
                filaDOP.COL_CODIGO = 5
                filaDOP.DOP_TIPO = "D"
            Case Else
                filaDOP.COL_CODIGO = 10
                filaDOP.DOP_TIPO = "D"
        End Select
        filaDOP.DOP_MONTO = Monto
        filaDOP.DOP_GLOSAADIC = Tipo
        filaDOP.DOP_AUDITORIA = ""
        filaDOP.DOP_AUDITORIA = Auditoria(filaDOP.DOP_AUDITORIA)
        dtDOP.AddTESDOPRow(filaDOP)
        taDOP.Update(dtDOP)
        'DE1.rsDetalle_Operaciones.Update
        Select Case Tipo
            Case "CZ1101"      ' Cheques devueltos
                TotalporColumna(Planilla, 5)
            Case "RECAUD"      ' Recaudaciones
                TotalporColumna(Planilla, 4)
            Case Else      ' Pagos con Cargos
                TotalporColumna(Planilla, 10)
        End Select
        Me.Close()
    End Sub
End Class