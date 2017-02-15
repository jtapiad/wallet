Public Class frmWALTFD00
    ''' <summary>
    ''' Nombre Programa : frmWALTFD00
    ''' Descripción     : Mantención Cuentas Corrientes Bancarias
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion
    Dim taTFD As New dsWALTFDTableAdapters.TESTFDTableAdapter
    Dim FilaTFD As dsWALTFD.TESTFDRow
    Dim dtTFD As New dsWALTFD.TESTFDDataTable
    Dim RegistroTFD As System.Data.DataRowView
    Dim CodigoTFD As Long = 0
    Dim Fondos As Integer = 0

    ''' <summary>
    ''' Carga la pantalla inicial con todos los tipos de Fondos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALTFD00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga los datos de la grilla
        Me.TESTFDDataGridTableAdapter.Fill(Me.DsWALTFD.TESTFDDataGrid)

        Me.TESTFDTableAdapter.Fill(Me.DsWALTFD.TESTFD)

    End Sub
    ''' <summary>
    ''' Agrega nuevo tipo de fondo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Tipo de Fondo"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de tipo de Fondo"
        tsbCancela.ToolTipText = "Cancela creación de tipo de Fondo"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.TFD_TIPOTextBox.Focus()
        Accion.Accion = 1
        LimpiaCampos()
        Me.TESTFDTableAdapter.Fill(Me.DsWALTFD.TESTFD)
        Me.TESTFDBindingSource.AddNew()
        RegistroTFD = Me.TESTFDBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.

    End Sub

    ''' <summary>
    ''' Cambia valores de un tipo de entidad ya creado.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Tipo de Fondo"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de tipo de Fondo"
        tsbCancela.ToolTipText = "Cancela modificación de tipo de Fondo"

        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.TFD_TIPOTextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroTFD = Me.TESTFDBindingSource.Current
    End Sub

    ''' <summary>
    ''' Vuelvo a cargar la grilla para reflejar cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESTFDDataGridTableAdapter.Fill(Me.DsWALTFD.TESTFDDataGrid)

    End Sub

    ''' <summary>
    ''' Cargo informe resumen con los datos de la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptTiposFondos00.rpt"
        InfoTag.Numero = 12
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Sale de la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()

    End Sub
    ''' <summary>
    ''' Acepta los datos de la empresa creada, o las modificaciones en el caso de edición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click
        If RevisaError() Then

            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego valores
                    If Me.RbCorto.Checked Then
                        Me.RegistroTFD.Item("TFD_CATEGIRIA") = "C"
                    End If
                    If Me.rbMediano.Checked Then
                        Me.RegistroTFD.Item("TFD_CATEGIRIA") = "M"
                    End If
                    If Me.rbLargo.Checked Then
                        Me.RegistroTFD.Item("TFD_CATEGIRIA") = "L"
                    End If


                    'Actualizo Binding
                    Try
                        Me.TESTFDBindingSource.EndEdit()
                        Me.TESTFDTableAdapter.Update(Me.DsWALTFD.TESTFD)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, NombreSistema)
                    End Try

                    HabilitaIzquierdo()

                Case 2 'editar
                    If Me.RbCorto.Checked Then
                        Me.RegistroTFD.Item("TFD_CATEGIRIA") = "C"
                    End If
                    If Me.rbMediano.Checked Then
                        Me.RegistroTFD.Item("TFD_CATEGIRIA") = "M"
                    End If
                    If Me.rbLargo.Checked Then
                        Me.RegistroTFD.Item("TFD_CATEGIRIA") = "L"
                    End If

                    'Actualizo binding
                    Me.TESTFDBindingSource.EndEdit()
                    Me.TESTFDTableAdapter.Update(Me.DsWALTFD.TESTFD)

                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESTFDDataGridTableAdapter.Fill(Me.DsWALTFD.TESTFDDataGrid)
        End If
    End Sub

    ''' <summary>
    ''' Cancela la adición o edición del registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESTFDBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub
    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub dgvTiposFondos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiposFondos.RowEnter
        CodigoTFD = dgvTiposFondos.Rows(e.RowIndex).Cells(1).Value
        Me.TESTFDTableAdapter.FillByTFD_CODIGO(Me.DsWALTFD.TESTFD, CodigoTFD)
        RegistroTFD = Me.TESTFDBindingSource.Current
        Select Case RegistroTFD.Item("TFD_CATEGIRIA")
            Case "C"
                Me.RbCorto.Checked = True
            Case "M"
                Me.rbMediano.Checked = True
            Case "L"
                Me.rbLargo.Checked = True
        End Select
    End Sub

    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvTiposFondos.Focus()
    End Sub
    ''' <summary>
    ''' Habilita el grupo general y deshabilita el detalle
    ''' </summary>
    Private Sub HabilitaIzquierdo()
        Me.gbDetalle.Enabled = False
        Me.ToolStripDetalle.Enabled = False
        Me.gbGeneral.Enabled = True
        Me.ToolStripGeneral.Enabled = True

    End Sub
    ''' <summary>
    ''' Limpia los campos preparando para una adición, en el caso del código, este no se asigna hasta después de presionado el botón Aceptar.
    ''' </summary>
    Private Sub LimpiaCampos()
        Me.TFD_TIPOTextBox.Text = ""
        Me.TFD_DIASINITextBox.Text = ""
        Me.TFD_DIASFINTextBox.Text = ""
        Me.TFD_TIPOTextBox.Focus()
        Me.RbCorto.Checked = True
    End Sub

    ''' <summary>
    ''' Valida que el campo Código contenga texto, que no haya sido usado y que le campo tipo tenga texto
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False

        If Me.TFD_TIPOTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TFD_TIPOTextBox, "El nombre del Tipo de Fondos no puede ser nulo")
            Return False
            If PrimerError = False Then
                Me.TFD_TIPOTextBox.Focus()
            End If

        End If
        If Me.TFD_DIASINITextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TFD_DIASINITextBox, "Los días de inicio no pueden ser nulos")
            Return False
            If PrimerError = False Then
                Me.TFD_DIASINITextBox.Focus()
            End If
        End If
        If Me.TFD_DIASFINTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TFD_DIASFINTextBox, "Los días de término no pueden ser nulos")
            Return False
            If PrimerError = False Then
                Me.TFD_DIASFINTextBox.Focus()
            End If
        End If
        Return True
    End Function

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará el tipo de fondo " & TFD_TIPOTextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroTFD As dsWALTFD.TESTFDRow = Me.DsWALTFD.TESTFD.Item(0)
                    RegistroTFD.Delete()
                    Me.TESTFDTableAdapter.Update(Me.DsWALTFD.TESTFD)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESTFDDataGridTableAdapter.Fill(Me.DsWALTFD.TESTFDDataGrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & Fondos & " fondos asociados.", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub

    Private Function DeterminaRelacion() As Boolean
        Dim dtFON As New dsWALTFD.FONCuentaDataTable
        Dim taFON As New dsWALTFDTableAdapters.FONCuentaTableAdapter
        Dim RegistroFON As dsWALTFD.FONCuentaRow
        taFON.FillByTFD_CODIGO(dtFON, CodigoTFD)
        RegistroFON = dtFON.Item(0)

        Dim Respuesta As Boolean = True

        If RegistroFON.Cuenta > 0 Then
            Fondos = RegistroFON.Cuenta
            Respuesta = False
        End If

        Return Respuesta
    End Function
End Class