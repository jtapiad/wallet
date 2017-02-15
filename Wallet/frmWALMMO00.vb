Public Class frmWALMMO00
    Dim accion As Acciones
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        TESDOPBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub frmWALMMO00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accion = Me.Tag
        Me.TESDOPTableAdapter.FillByClave(Me.DsWALPLA1.TESDOP, accion.clave)
        If accion.accion = 1 Then
            Me.Text = "Mantención de Movimientos"
            Me.DOP_GLOSAADICTextBox.Enabled = True
            Me.DOP_MONTOTextBox.Enabled = True

        Else
            Me.Text = "Eliminación de Movimientos"
            Me.DOP_GLOSAADICTextBox.Enabled = False
            Me.DOP_MONTOTextBox.Enabled = False
        End If

    End Sub

    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click
        Dim col_codigo As Integer = TESDOPBindingSource.Current.item("COL_CODIGO")
        Dim taDCL As New dsWALPLATableAdapters.TESDCLTableAdapter
        Dim dtDCL As New dsWALPLA.TESDCLDataTable
        Dim filaDCL As dsWALPLA.TESDCLRow
        If accion.accion = 3 Then
            Dim respuesta As Integer
            respuesta = MsgBox("¿Esta seguro que desea eliminar este registro?", vbYesNo, NombreSistema)
            If respuesta = vbNo Then
                Exit Sub
            End If
            ' Se elimina
            ' si columna es de colocaciones(14), se debe borrar los cheques generados
            If col_codigo = 14 Then
                Dim taCHA As New dsWALPLATableAdapters.QueriesTableAdapter
                taCHA.BorraCHA(TESDOPBindingSource.Current.item("DOP_CODIGO"))
                ' se deben borrar ademas las colocaciones
                taDCL.FillByDOPCodigo(dtDCL, TESDOPBindingSource.Current.item("DOP_CODIGO"))
                If dtDCL.Count > 0 Then
                    filaDCL = dtDCL.Item(0)
                    taCHA.BorraCLC(filaDCL.CLC_CODIGO)
                End If
            End If

            TESDOPBindingSource.RemoveCurrent()
        End If
        TESDOPBindingSource.EndEdit()
        TESDOPTableAdapter.Update(Me.DsWALPLA1.TESDOP)
        TotalporColumna(parametros.Planilla, col_codigo)
        Nuevo = True
        Me.Close()
    End Sub
End Class