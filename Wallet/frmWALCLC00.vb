Public Class frmWALCLC00
    Private Sub chkPorFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkPorFecha.CheckedChanged
        If Me.chkPorFecha.Checked Then
            Me.dtpFechaColocación.Enabled = True
        Else
            Me.dtpFechaColocación.Enabled = False
        End If
    End Sub

    Private Sub TESCLCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TESCLCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsWALCLC)

    End Sub

    Private Sub frmWALCLC00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESENTTableAdapter.Fill(Me.DsWALCLC.TESENT)
        Me.TESINFTableAdapter.Fill(Me.DsWALCLC.TESINF)
        Me.TESFONTableAdapter.Fill(Me.DsWALCLC.TESFON)
        ' Poner fill por la entidad seleccionada en el datagrid
        Me.TESCLCTableAdapter.FillByFecha(Me.DsWALCLC.TESCLC, Now.Date)

    End Sub
End Class