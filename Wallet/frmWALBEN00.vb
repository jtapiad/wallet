Public Class frmWALBEN00
    ''' <summary>
    ''' Nombre Programa : frmWALBEN00
    ''' Descripción     : Mantención de Beneficiarios
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudio González Vache
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Private Sub frmWALBEN00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESBENTableAdapter.Fill(Me.DsWALBEN.TESBEN)
        Me.TESBE2TableAdapter.Fill(Me.DsWALBEN.TESBE2)

    End Sub

    Private Sub dgvBeneficiarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBeneficiarios.CellContentDoubleClick
        Dim RUT As String = Me.dgvBeneficiarios.Rows(e.RowIndex).Cells(0).Value
        'Lleno el binding con la información del doble clic
        Me.TESBE2TableAdapter.FillByBE2_RUT(Me.DsWALBEN.TESBE2, RUT)
        'Defino el Registro para llenar con los datos a copiar
        Dim RegistroOrigen As DataRowView
        RegistroOrigen = Me.TESBE2BindingSource.Current

        'Veo si puedo llenar el Binding del BEN Para ver si existe el beneficiario
        Me.TESBENTableAdapter.FillByBEN_RUT(Me.DsWALBEN.TESBEN, RUT)
        'Si el beneficiario no existe grabo
        If Me.TESBENBindingSource.Count = 0 Then

            'Lleno el Table Adapter del BEN
            Me.TESBENTableAdapter.Fill(Me.DsWALBEN.TESBEN)
            Me.TESBENBindingSource.AddNew()
            Dim RegistroDestino As DataRowView
            RegistroDestino = Me.TESBENBindingSource.Current
            RegistroDestino.Item("BEN_RUT") = RegistroOrigen.Item("BE2_RUT")
            RegistroDestino.Item("BEN_NOMBRE") = RegistroOrigen.Item("BE2_RAZONSOCIAL")
            Me.TESBENBindingSource.EndEdit()
            Me.TESBENTableAdapter.Update(Me.DsWALBEN.TESBEN)
            Me.Close()

        Else
            'Si existe salgo
            MsgBox("El beneficiario ya existe", MsgBoxStyle.Information, NombreSistema)
            Me.Close()
        End If
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        If Me.tbBuscaBeneficiario.Text = "" Then
            Me.TESBE2TableAdapter.Fill(Me.DsWALBEN.TESBE2)
        Else
            Dim Busqueda As String = "%" & Me.tbBuscaBeneficiario.Text & "%"
            Me.Cursor = Cursors.WaitCursor
            Me.TESBE2TableAdapter.FillByBusqueda(Me.DsWALBEN.TESBE2, Busqueda)
            Me.Cursor = Cursors.Default
        End If

    End Sub
End Class