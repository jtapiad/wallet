Public Class frmWALCBE00
    Private Sub frmWALCBE00_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DsWALBEN.TESBE2' Puede moverla o quitarla según sea necesario.
        Cursor = Cursors.WaitCursor
        Me.TESBE2TableAdapter.Fill(Me.DsWALBEN.TESBE2)
        Cursor = Cursors.Default
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Dim nombre As String
        Dim rut As String = ""
        rut = Validar_RUT_Masivo(ListBox1.SelectedValue)
        Dim actualiza As New dsWALBENTableAdapters.QueriesTableAdapter
        nombre = ListBox1.Text

        Try
            actualiza.InsertaBeneficiario(rut, nombre)
        Catch ex As Exception
            MsgBox("El Beneficionario ya existe seleccionado", vbInformation, "Mensaje del Sistema")
        End Try

        Glo_RUT = rut
        Me.Close()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class