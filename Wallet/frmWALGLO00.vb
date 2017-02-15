Public Class frmWALGLO00
    ''' <summary>
    ''' Nombre Programa : frmWALGLO00
    ''' Descripción     : Mantención de Glosas y Columnas
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Private Sub frmWALGLO00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESCOLTableAdapter.Fill(Me.DsWALGLO.TESCOL)
        Me.TESGLOTableAdapter.Fill(Me.DsWALGLO.TESGLO)

    End Sub

    Private Sub btnAcepta_Click(sender As Object, e As EventArgs) Handles btnAcepta.Click

        Me.TESGLOBindingSource.EndEdit()
        Me.TESGLOTableAdapter.Update(Me.DsWALGLO.TESGLO)
        Me.Close()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.TESGLOBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub dgvGlosas_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvGlosas.CurrentCellDirtyStateChanged
        If dgvGlosas.IsCurrentCellDirty Then
            dgvGlosas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class