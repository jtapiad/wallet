Public Class frmWALCTE00
    ''' <summary>
    ''' Nombre Programa : frmWALCTE00
    ''' Descripción     : Mantención Cuentas Corrientes Bancarias
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim CodigoCTE As Integer = 0
    Dim taTESCTE As New dsWALCTETableAdapters.TESCTETableAdapter
    Dim dtTESCTE As New dsWALCTE.TESCTEDataTable
    Dim RegistroCTE As dsWALCTE.TESCTERow

    Private Sub frmWALCTE00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESCTECompletoTableAdapter.Fill(Me.DsWALCTE.TESCTECompleto)
        With Me.dgvCuentasCorrientes
            .Columns(4).DefaultCellStyle.Format = "c"
            .Columns(5).DefaultCellStyle.Format = "c"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        End With

    End Sub



    Private Sub dgvCuentasCorrientes_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvCuentasCorrientes.CellValidating
        Dim Valida As Boolean = False

        Dim headerText As String = dgvCuentasCorrientes.Columns(e.ColumnIndex).HeaderText
        If headerText.Equals("Ubicación") Then
            Valida = True
        End If

        If headerText.Equals("Colchón 1") Then
            Valida = True
        End If

        If headerText.Equals("Colchón 2") Then
            Valida = True
        End If

        If Valida Then
            If e.FormattedValue.ToString <> "" AndAlso Not IsNumeric(e.FormattedValue.ToString()) Then
                dgvCuentasCorrientes.Rows(e.RowIndex).ErrorText = "El valor debe ser numérico"
                e.Cancel = True
            End If
        End If


    End Sub

    Private Sub dgvCuentasCorrientes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentasCorrientes.CellEndEdit
        ' Clear the row error in case the user presses ESC.   
        dgvCuentasCorrientes.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Actualiza()
        Me.Close()
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptCtaCte00.rpt"
        InfoTag.Numero = 7
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Actualiza()
        For Each fila As DataGridViewRow In dgvCuentasCorrientes.Rows()
            Dim da As New dsWALCTE.TESCTEDataTable
            Dim dt As New dsWALCTETableAdapters.TESCTETableAdapter
            dt.FillByCTE_CODIGO(da, fila.Cells(6).Value)

            Dim Registro As dsWALCTE.TESCTERow = da.Item(0)

            If fila.Cells(3).Value Is DBNull.Value Then
                Registro.SetCTE_SECUENCIANull()
            Else
                Registro.CTE_SECUENCIA = fila.Cells(3).Value
            End If

            If fila.Cells(4).Value Is DBNull.Value Then
                Registro.SetCTE_COLCHON1Null()
            Else
                Registro.CTE_COLCHON1 = fila.Cells(4).Value
            End If

            If fila.Cells(5).Value Is DBNull.Value Then
                Registro.SetCTE_COLCHON2Null()
            Else
                Registro.CTE_COLCHON2 = fila.Cells(5).Value
            End If

            dt.Update(da)
        Next
    End Sub

End Class