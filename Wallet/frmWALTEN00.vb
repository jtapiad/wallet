Public Class frmWALTEN00
    ''' <summary>
    ''' Nombre Programa : frmWALTEN00
    ''' Descripción     : Mantención de Tipo de Entidad
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion
    Dim taTEN As New dsWALTENTableAdapters.TESTENTableAdapter
    Dim FilaTEN As dsWALTEN.TESTENRow
    Dim dtTEN As New dsWALTEN.TESTENDataTable
    Dim RegistroTEN As System.Data.DataRowView
    Dim CodigoTEN As Long = 0
    Dim Entidades As Integer = 0


    ''' <summary>
    ''' Carga la pantalla inicial con todos los tipos de entidades
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALTEN00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESTENTableAdapter.Fill(Me.DsWALTEN.TESTEN)
        'Carga los datos de la grilla
        Me.TESTENDataGridTableAdapter.Fill(Me.DsWALTEN.TESTENDataGrid)

    End Sub

    ''' <summary>
    ''' Agrega nuevo tipo de entidad
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Tipo de Entidad"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de tipo de entidad"
        tsbCancela.ToolTipText = "Cancela creación de tipo de entidad"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.TEN_TIPOTextBox.Focus()
        Accion.Accion = 1
        Me.TESTENTableAdapter.Fill(Me.DsWALTEN.TESTEN)
        Me.TESTENBindingSource.AddNew()
        RegistroTEN = Me.TESTENBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub

    ''' <summary>
    ''' Cambia valores de un tipo de entidad ya creado.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Tipo de Entidad"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de tipo de entidad"
        tsbCancela.ToolTipText = "Cancela modificación de tipo de entidad"

        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.TEN_CODIGOTextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroTEN = Me.TESTENBindingSource.Current
        Me.TEN_CODIGOTextBox.Enabled = False
    End Sub

    ''' <summary>
    ''' Vuelvo a cargar la grilla para reflejar cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESTENDataGridTableAdapter.Fill(Me.DsWALTEN.TESTENDataGrid)

    End Sub

    ''' <summary>
    ''' Cargo informe resumen con los datos de la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptTiposEntidades00.rpt"
        InfoTag.Numero = 11
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
            Dim StrAuditoria As String
            StrAuditoria = Me.RegistroTEN.Item("TEN_AUDITORIA").ToString
            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego valores
                    If Me.chkFondo.Checked Then
                        Me.RegistroTEN.Item("TEN_FONDO") = 1
                    Else
                        Me.RegistroTEN.Item("TEN_FONDO") = 0
                    End If
                    Me.RegistroTEN.Item("TEN_AUDITORIA") = Auditoria("")
                    'Actualizo Binding
                    Try
                        Me.TESTENBindingSource.EndEdit()
                        Me.TESTENTableAdapter.Update(Me.DsWALTEN.TESTEN)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, NombreSistema)
                    End Try

                    HabilitaIzquierdo()

                Case 2 'editar
                    If Me.chkFondo.Checked Then
                        Me.RegistroTEN.Item("TEN_FONDO") = 1
                    Else
                        Me.RegistroTEN.Item("TEN_FONDO") = 0
                    End If
                    Me.RegistroTEN.Item("TEN_AUDITORIA") = Auditoria(Me.RegistroTEN.Item("TEN_AUDITORIA"))
                    'Actualizo binding
                    Me.TESTENBindingSource.EndEdit()
                    Me.TESTENTableAdapter.Update(Me.DsWALTEN.TESTEN)

                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESTENDataGridTableAdapter.Fill(Me.DsWALTEN.TESTENDataGrid)
        End If
    End Sub

    ''' <summary>
    ''' Cancela la adición o edición del registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESTENBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    Private Sub dgvTiposEntidades_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiposEntidades.RowEnter
        CodigoTEN = dgvTiposEntidades.Rows(e.RowIndex).Cells(1).Value
        Me.TESTENTableAdapter.FillByTEN_CODIGO(Me.DsWALTEN.TESTEN, CodigoTEN)
        RegistroTEN = Me.TESTENBindingSource.Current
        If RegistroTEN.Item("TEN_FONDO") = 1 Then
            Me.chkFondo.Checked = True
        Else
            Me.chkFondo.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvTiposEntidades.Focus()
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
        Me.TEN_CODIGOTextBox.Text = ""
        Me.TEN_TIPOTextBox.Text = ""
        Me.TEN_CODIGOTextBox.Focus()
        Me.chkFondo.Checked = False
    End Sub

    ''' <summary>
    ''' Valida que el campo Código contenga texto, que no haya sido usado y que le campo tipo tenga texto
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False

        If Me.TEN_CODIGOTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TEN_CODIGOTextBox, "El código del Tipo de Entidad no puede ser nulo")
            Return False
            If PrimerError = False Then
                Me.TEN_CODIGOTextBox.Focus()
            End If
        Else
            If Accion.Accion = 1 Then
                Dim dt As New dsWALTEN.TESTENDataTable
                Dim ta As New dsWALTENTableAdapters.TESTENTableAdapter
                ta.FillByTEN_CODIGO(dt, Me.TEN_CODIGOTextBox.Text)
                If dt.Count = 0 Then
                Else
                    Me.ErrorProvider1.SetError(Me.TEN_CODIGOTextBox, "Ese código ya existe, use otro")
                    Return False
                    If PrimerError = False Then
                        Me.TEN_CODIGOTextBox.Focus()
                    End If
                End If
            End If

        End If
        If Me.TEN_TIPOTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TEN_TIPOTextBox, "El nombre del Tipo de Entidad no puede ser nulo")
            Return False
            If PrimerError = False Then
                Me.TEN_CODIGOTextBox.Focus()
            End If
        End If
        Return True
    End Function

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará el tipo de entidad " & TEN_TIPOTextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroTEN As dsWALTEN.TESTENRow = Me.DsWALTEN.TESTEN.Item(0)
                    RegistroTEN.Delete()
                    Me.TESTENTableAdapter.Update(Me.DsWALTEN.TESTEN)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESTENDataGridTableAdapter.Fill(Me.DsWALTEN.TESTENDataGrid)
            Else
                MsgBox("El registro no puede ser eliminado, tiene " & Entidades & " entidades asociadas. ", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub

    Private Function DeterminaRelacion() As Boolean
        Dim dtENT As New dsWALTEN.ENTCuentaDataTable
        Dim taENT As New dsWALTENTableAdapters.ENTCuentaTableAdapter
        Dim RegistroENT As dsWALTEN.ENTCuentaRow
        taENT.FillByTEN_CODIGO(dtENT, CodigoTEN)
        RegistroENT = dtENT.Item(0)

        Dim Respuesta As Boolean = True

        If RegistroENT.Cuenta > 0 Then
            Entidades = RegistroENT.Cuenta
            Respuesta = False
        End If

        Return Respuesta
    End Function
End Class