Public Class frmWALELE00
    Private Sub frmWALELE00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESBENTableAdapter.Fill(Me.DsWALELE.TESBEN)

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        TESBENBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click
        TESBENBindingSource.EndEdit()
        TESBENTableAdapter.Update(Me.DsWALELE.TESBEN)
        Me.Close()
    End Sub
End Class