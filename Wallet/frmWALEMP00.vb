Public Class frmWALEMP00
    ''' <summary>
    ''' Nombre Programa : frmWALEMP00
    ''' Descripción     : Mantención Empresas
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion
    Dim taEMP As New dsWALEMPTableAdapters.TESEMPTableAdapter
    Dim FilaEMPs As dsWALEMP.TESEMPRow
    Dim dtEMP As New dsWALEMP.TESEMPDataTable
    Dim RegistroEMP As System.Data.DataRowView
    Dim CodigoEMP As Long = 0
    Dim Planillas As Integer = 0
    Dim Cuentas As Integer = 0

    ''' <summary>
    ''' Carga la pantalla inicial con todas las empresas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALEMP00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lleno la grilla de empresas
        Me.TESEMPDataGridTableAdapter.Fill(Me.DsWALEMP.TESEMPDataGrid)
        'Dependiendo de lo seleccionado en la grilla, despliego los datos en la parte derecha
        Me.TESEMPTableAdapter.FillByEMP_CODIGO(Me.DsWALEMP.TESEMP, CodigoEMP)
    End Sub

    ''' <summary>
    ''' Agrega nueva empresa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Empresa"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de empresa"
        tsbCancela.ToolTipText = "Cancela creación de empresa"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.EMP_EMPRESATextBox.Focus()
        Accion.Accion = 1
        Me.TESEMPTableAdapter.Fill(Me.DsWALEMP.TESEMP)
        Me.TESEMPBindingSource.AddNew()
        RegistroEMP = Me.TESEMPBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub

    ''' <summary>
    ''' Cambia valores de una empresa ya creada.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Empresa"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de empresa"
        tsbCancela.ToolTipText = "Cancela modificación de empresa"
        Dim Texto As String
        Texto = Me.EMP_EMPRESATextBox.Text
        Me.EMP_EMPRESATextBox.Text = RTrim(Texto)
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.EMP_EMPRESATextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroEMP = Me.TESEMPBindingSource.Current
    End Sub

    ''' <summary>
    ''' Vuelvo a cargar la grilla para reflejar cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESEMPDataGridTableAdapter.Fill(Me.DsWALEMP.TESEMPDataGrid)
    End Sub

    ''' <summary>
    ''' Cargo informe resumen con los datos de la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptEmpresas00.rpt"
        InfoTag.Numero = 3
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
            StrAuditoria = Me.RegistroEMP.Item("EMP_AUDITORIA").ToString
            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego valores

                    Me.RegistroEMP.Item("EMP_AUDITORIA") = Auditoria(StrAuditoria)
                    'Actualizo Binding
                    Try
                        Me.TESEMPBindingSource.EndEdit()
                        Me.TESEMPTableAdapter.Update(Me.DsWALEMP.TESEMP)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, NombreSistema)
                    End Try

                    HabilitaIzquierdo()

                Case 2 'editar
                    Me.RegistroEMP.Item("EMP_AUDITORIA") = Auditoria(Me.RegistroEMP.Item("EMP_AUDITORIA"))
                    'Actualizo binding
                    Me.TESEMPBindingSource.EndEdit()
                    Me.TESEMPTableAdapter.Update(Me.DsWALEMP.TESEMP)

                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESEMPDataGridTableAdapter.Fill(Me.DsWALEMP.TESEMPDataGrid)
        End If
    End Sub

    ''' <summary>
    ''' Cancela la adición o edición del registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESEMPBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    ''' <summary>
    ''' Determina el código de empresa que está seleccionado en el datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvEmpresas_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresas.RowEnter
        CodigoEMP = dgvEmpresas.Rows(e.RowIndex).Cells(2).Value
        Me.TESEMPTableAdapter.FillByEMP_CODIGO(Me.DsWALEMP.TESEMP, CodigoEMP)
        Me.lblCodigo.Text = CodigoEMP
    End Sub

    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvEmpresas.Focus()
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
        Me.EMP_EMPRESATextBox.Text = ""
        Me.lblCodigo.Text = "Por definir"
    End Sub

    ''' <summary>
    ''' Valida que el campo empresa contenga texto
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False
        If Me.EMP_EMPRESATextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.EMP_EMPRESATextBox, "El nombre de la empresa no puede ser nulo")
            Return False
        End If
        Return True
    End Function


    Private Function DeterminaRelacion() As Boolean
        Dim dtPLA As New dsWALEMP.TESPLADataTable
        Dim taPLA As New dsWALEMPTableAdapters.TESPLATableAdapter

        taPLA.FillByEMP_CODIGO(dtPLA, CodigoEMP)

        Dim dtCTE As New dsWALEMP.TESCTEDataTable
        Dim taCTE As New dsWALEMPTableAdapters.TESCTETableAdapter

        taCTE.FillByEMP_CODIGO(dtCTE, CodigoEMP)
        Dim Respuesta As Boolean = True

        If dtPLA.Count > 0 Then
            Planillas = dtPLA.Count
            Respuesta = False
        End If

        If dtCTE.Count > 0 Then
            Cuentas = dtCTE.Count
            Respuesta = False
        End If
        Return Respuesta
    End Function

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará la empresa " & EMP_EMPRESATextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroEMP As dsWALEMP.TESEMPRow = Me.DsWALEMP.TESEMP.Item(0)
                    RegistroEMP.Delete()
                    Me.TESEMPTableAdapter.Update(Me.DsWALEMP.TESEMP)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESEMPDataGridTableAdapter.Fill(Me.DsWALEMP.TESEMPDataGrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & Planillas & " planillas asociadas y " & Cuentas & " cuentas asociadas", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub
End Class