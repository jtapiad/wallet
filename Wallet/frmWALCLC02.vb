Public Class frmWALCLC02

    Dim Accion As New Accion
    Dim taCLC As New dsWALCLCTableAdapters.TESCLCTableAdapter
    Dim FilaCLC As dsWALCLC.TESCLCRow
    Dim dtCLC As New dsWALCLC.TESCLCDataTable
    Dim RegistroCLC As System.Data.DataRowView
    Dim CodigoCLC As Long = 0
    Dim SeleccionGrilla As Integer

    ''' <summary>
    ''' Al crear el formulario
    ''' </summary>
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.TESFONComboTableAdapter.Fill(Me.DsWALCLC.TESFONCombo)
        Me.TESINFTableAdapter.Fill(Me.DsWALCLC.TESINF)
        Me.TESENTTableAdapter.Fill(Me.DsWALCLC.TESENT)
        Me.TESFONComboDetalleTableAdapter.Fill(Me.DsWALCLC.TESFONComboDetalle)
        Me.dtpFechaColocacion.Value = Now.Date
        Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)

    End Sub

    ''' <summary>
    ''' En la carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALCLC02_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HabilitaIzquierdo()

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

    ''' <summary>
    ''' Vuelve a cargar la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs)
        If rbtColocacion.Checked = True Then
            Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        Else
            Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        End If
    End Sub

    ''' <summary>
    ''' Cambios en el valor del DateTimePicker
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dtpFechaColocacion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaColocacion.ValueChanged
        If rbtColocacion.Checked = True Then
            Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        Else
            Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        End If
    End Sub

    ''' <summary>
    ''' Graba cambios o agrega registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click

        If RevisaError() Then
            'Entrego Valores
            Dim RegistroDetalle As System.Data.DataRowView
            If Me.TESCLCDetalleBindingSource.Current IsNot Nothing Then
                RegistroDetalle = Me.TESCLCDetalleBindingSource.Current
                If Me.rbNominal.Checked Then
                    RegistroDetalle.Item("CLC_TIPOTASA") = "N"
                Else
                    RegistroDetalle.Item("CLC_TIPOTASA") = "R"
                End If
                RegistroDetalle.Item("MON_CODIGO") = "905"
                RegistroDetalle.Item("EST_CODIGO") = 1
                RegistroDetalle.Item("CLC_FECHAPRO") = Now.Date
            End If

            'Actualizo binding
            Me.TESCLCDetalleBindingSource.EndEdit()
            Me.TESCLCDetalleTableAdapter.Update(Me.DsWALCLC.TESCLCDetalle)

            'Habilito lado izquierdo
            HabilitaIzquierdo()
            'Refresco la grilla
            If rbtColocacion.Checked = True Then
                Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
            Else
                Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
            End If
            Me.dgvColocaciones.CurrentCell = Me.dgvColocaciones.Item(0, SeleccionGrilla)

        End If
    End Sub

    ''' <summary>
    ''' Valida que la inversión no haya quedado en nulo
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        If Me.CLC_MONTOINVTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.CLC_MONTOINVTextBox, "El monto de la inversión no puede ser cero")
            Me.CLC_MONTOINVTextBox.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Sale de la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Cancela la edición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESCLCBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    ''' <summary>
    ''' Cambia los datos del lado derecho cuando cambio la selección en la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TESCLCBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles TESCLCBindingSource.CurrentItemChanged
        If Me.TESCLCBindingSource.Current IsNot Nothing Then
            RegistroCLC = Me.TESCLCBindingSource.Current
            Dim Codigo As Object = RegistroCLC.Item("CLC_CODIGO")
            Me.TESCLCDetalleTableAdapter.FillByCLC_CODIGO(Me.DsWALCLC.TESCLCDetalle, Codigo)

            If RegistroCLC.Item("CLC_TIPOTASA") = "R" Then
                Me.rbReal.Checked = True
            Else
                Me.rbNominal.Checked = True
            End If
            Me.TESFONComboDetalleTableAdapter.Fill(Me.DsWALCLC.TESFONComboDetalle)
            Me.FON_CODIGOComboBox.SelectedValue = RegistroCLC.Item("FON_CODIGO")
        End If

    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará la colocación " & CLC_FECHAINVDateTimePicker.Value.Date & " - " & ENT_CODIGOComboBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            Try
                Dim RegistroCLCEli As dsWALCLC.TESCLCDetalleRow = Me.DsWALCLC.TESCLCDetalle.Item(0)
                RegistroCLCEli.Delete()
                Me.TESCLCDetalleTableAdapter.Update(Me.DsWALCLC.TESCLCDetalle)

            Catch ex As Exception
                MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
            End Try
            Me.TESCLCTableAdapter.Fill(Me.DsWALCLC.TESCLC)

        End If
    End Sub

    ''' <summary>
    ''' Agrega nueva colocación
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Colocación"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de colocación"
        tsbCancela.ToolTipText = "Cancela creación de colocación"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.CLC_FECHAINVDateTimePicker.Enabled = True
        Me.CLC_FECHAINVDateTimePicker.Focus()
        Accion.Accion = 1
        Me.TESCLCDetalleTableAdapter.Fill(Me.DsWALCLC.TESCLCDetalle)
        Me.TESCLCDetalleBindingSource.AddNew()
        RegistroCLC = Me.TESCLCDetalleBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub

    Private Sub LimpiaCampos()
        Me.CLC_FECHAINVDateTimePicker.Value = Now.Date
        Me.CLC_FECHAVENDateTimePicker.Value = Now.Date
        Me.rbReal.Checked = True
        Me.CLC_TASAESPTextBox.Text = ""
        Me.CLC_MONTOINVTextBox.Text = ""
    End Sub

    ''' <summary>
    ''' Habilita el lado derecho y permite editar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Colocación"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta edición de colocación"
        tsbCancela.ToolTipText = "Cancela edición de colocación"
        SeleccionGrilla = Me.dgvColocaciones.CurrentCell.RowIndex
        HabilitaDerecho()
        tsbAcepta.ToolTipText = "Acepta modificación de colocación"
        tsbCancela.ToolTipText = "Cancela modificación de colocación"

        Accion.Accion = 2
        Dim CodigoFon As Long
        If Me.TESCLCBindingSource.Current.Item("FON_CODIGO") IsNot DBNull.Value Then
            CodigoFon = Me.TESCLCBindingSource.Current.Item("FON_CODIGO")
        Else

        End If
        Me.TESFONComboDetalleTableAdapter.FillByENT_CODIGO(Me.DsWALCLC.TESFONComboDetalle, Me.ENT_CODIGOComboBox.SelectedValue)
        If CodigoFon <> 0 Then
            Me.FON_CODIGOComboBox.SelectedValue = CodigoFon
        End If

    End Sub

    Private Sub ENT_CODIGOComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ENT_CODIGOComboBox.SelectedIndexChanged
        If Me.ENT_CODIGOComboBox.SelectedValue IsNot Nothing Then
            Me.TESFONComboDetalleTableAdapter.FillByENT_CODIGO(Me.DsWALCLC.TESFONComboDetalle, Me.ENT_CODIGOComboBox.SelectedValue)
        End If

    End Sub
    Private Sub rbtColocacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbtColocacion.CheckedChanged
        If rbtColocacion.Checked = True Then
            Me.TESCLCTableAdapter.FillByColocación(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        Else
            Me.TESCLCTableAdapter.FillByVencimiento(Me.DsWALCLC.TESCLC, Me.dtpFechaColocacion.Value.Date)
        End If
    End Sub


End Class