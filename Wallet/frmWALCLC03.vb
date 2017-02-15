Public Class frmWALCLC03
    Dim Accion As New Accion

    Dim taCLC As New dsWALCLCTableAdapters.TESCLCTableAdapter
    Dim FilaCLC As dsWALCLC.TESCLCRow
    Dim dtCLC As New dsWALCLC.TESCLCDataTable
    Dim RegistroCLC As System.Data.DataRowView
    Dim CodigoCLC As Long = 0

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.TESFONComboTableAdapter.Fill(Me.DsWALCLC.TESFONCombo)
        Me.TESINFTableAdapter.Fill(Me.DsWALCLC.TESINF)
        Me.TESENTTableAdapter.Fill(Me.DsWALCLC.TESENT)
        Me.TESFONComboDetalleTableAdapter.Fill(Me.DsWALCLC.TESFONComboDetalle)
        Me.dtpFechaColocacion.Value = Now.Date
        Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)

    End Sub

    Private Sub frmWALCLC03_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HabilitaIzquierdo()

    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        HabilitaDerecho()
        tsbAcepta.ToolTipText = "Acepta ingreso de rescate"
        tsbCancela.ToolTipText = "Cancela ingreso de rescate"
        Accion.Accion = 2
        RegistroCLC = Me.TESCLCDetalleBindingSource.Current

    End Sub
    ''' <summary>
    ''' Vuelve a cargar la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        If rbtColocacion.Checked = True Then
            Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        Else
            Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        End If

    End Sub

    ''' <summary>
    ''' Cierra la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' Habilita el lado general y deshabilita el detalle
    ''' </summary>
    Private Sub HabilitaIzquierdo()
        Me.gbDetalle.Enabled = False
        Me.ToolStripDetalle.Enabled = False
        Me.gbGeneral.Enabled = True
        Me.ToolStripGeneral.Enabled = True
    End Sub
    ''' <summary>
    ''' Habilita el lado detalle y deshabilita el general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvColocaciones.Focus()
    End Sub

    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click

        'Entrego valores
        If Me.CLC_RESCATETextBox.Text = "" Or Me.CLC_RESCATETextBox.Text = "0" Then
            RegistroCLC.Item("CLC_RESCATE") = DBNull.Value
        End If

        'Actualizo binding
        Me.TESCLCDetalleBindingSource.EndEdit()
        Me.TESCLCDetalleTableAdapter.Update(Me.DsWALCLC.TESCLCDetalle)
        'Habilito lado izquierdo
        HabilitaIzquierdo()
        'Refresco la grilla
        'Refresco la grilla
        If rbtColocacion.Checked = True Then
            Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        Else
            Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        End If

    End Sub

    Private Sub dtpFechaColocacion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaColocacion.ValueChanged
        If rbtColocacion.Checked = True Then
            Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        Else
            Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        End If

    End Sub

    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESCLCBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    Private Sub TESCLCBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles TESCLCBindingSource.CurrentItemChanged
        'Dim Codigo As Object = dgvColocaciones.Rows(e.RowIndex).Cells(5).Value
        If Me.TESCLCBindingSource.Current IsNot Nothing Then
            RegistroCLC = Me.TESCLCBindingSource.Current

            Dim codigo As Long = RegistroCLC.Item("CLC_CODIGO")
            Me.TESCLCDetalleTableAdapter.FillByCLC_CODIGO(Me.DsWALCLC.TESCLCDetalle, codigo)
            If RegistroCLC.Item("CLC_TIPOTASA") = "R" Then
                Me.rbReal.Checked = True
            Else
                Me.rbNominal.Checked = True
            End If
        Else
            If rbtColocacion.Checked = True Then
                Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
            Else
                Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
            End If

        End If

    End Sub

End Class