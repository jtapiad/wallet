Public Class frmWALTII00
    ''' <summary>
    ''' Nombre Programa : frmWALTII00
    ''' Descripción     : Mantención de Tipos de Instrumentos Financieros
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion
    Dim taTII As New dsWALTIITableAdapters.TESTIITableAdapter
    Dim FilaTII As dsWALTII.TESTIIRow
    Dim dtTII As New dsWALTII.TESTIIDataTable
    Dim RegistroTII As System.Data.DataRowView
    Dim CodigoTII As Long = 0
    Dim Instrumentos As Integer = 0

    ''' <summary>
    ''' Carga la pantalla inicial con todos los tipos de instrumentos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALTII00_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TESTIITableAdapter.Fill(Me.DsWALTII.TESTII)
        Me.TESTIIDataGridTableAdapter.Fill(Me.DsWALTII.TESTIIDataGrid)

    End Sub

    ''' <summary>
    ''' Agrega nuevo tipo de entidad
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Tipo de Instrumento"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de tipo de Instrumento"
        tsbCancela.ToolTipText = "Cancela creación de tipo de Instrumento"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.TII_TIPOTextBox.Focus()
        Accion.Accion = 1
        Me.TESTIITableAdapter.Fill(Me.DsWALTII.TESTII)
        Me.TESTIIBindingSource.AddNew()
        RegistroTII = Me.TESTIIBindingSource.Current
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
        Me.gbDetalle.Text = "Edita Tipo de Instrumento"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de tipo de Instrumento"
        tsbCancela.ToolTipText = "Cancela modificación de tipo de Instrumento"

        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.TII_TIPOTextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroTII = Me.TESTIIBindingSource.Current
    End Sub

    ''' <summary>
    ''' Vuelvo a cargar la grilla para reflejar cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESTIIDataGridTableAdapter.Fill(Me.DsWALTII.TESTIIDataGrid)

    End Sub


    ''' <summary>
    ''' Cargo informe resumen con los datos de la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptTiposInstrumentos00.rpt"
        InfoTag.Numero = 13
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

                    'Actualizo Binding
                    Try
                        Me.TESTIIBindingSource.EndEdit()
                        Me.TESTIITableAdapter.Update(Me.DsWALTII.TESTII)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, NombreSistema)
                    End Try

                    HabilitaIzquierdo()

                Case 2 'editar

                    'Actualizo binding
                    Me.TESTIIBindingSource.EndEdit()
                    Me.TESTIITableAdapter.Update(Me.DsWALTII.TESTII)

                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESTIIDataGridTableAdapter.Fill(Me.DsWALTII.TESTIIDataGrid)
        End If
    End Sub

    ''' <summary>
    ''' Cancela la adición o edición del registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESTIIBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub
    ''' <summary>
    ''' Determino lo seleccionado en la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvTiposInstituciones_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiposInstrumento.RowEnter
        CodigoTII = dgvTiposInstrumento.Rows(e.RowIndex).Cells(1).Value
        Me.TESTIITableAdapter.FillByTII_CODIGO(Me.DsWALTII.TESTII, CodigoTII)
        RegistroTII = Me.TESTIIBindingSource.Current

    End Sub


    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvTiposInstrumento.Focus()
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
        Me.TII_TIPOTextBox.Text = ""
        Me.TII_ABREVIATURATextBox.Text = ""
    End Sub

    ''' <summary>
    ''' Valida que el campo Código contenga texto, que no haya sido usado y que le campo tipo tenga texto
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False

        If Me.TII_TIPOTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TII_TIPOTextBox, "El Tipo de Instrumento no puede ser nulo")
            Return False
            If PrimerError = False Then
                Me.TII_TIPOTextBox.Focus()
            End If

        End If
        If Me.TII_ABREVIATURATextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TII_ABREVIATURATextBox, "La abreviatura del Tipo de Instrumento no puede ser nulo")
            Return False
            If PrimerError = False Then
                Me.TII_ABREVIATURATextBox.Focus()
            End If
        End If
        Return True
    End Function

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará el Tipo de Instrumento " & TII_TIPOTextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroINT As dsWALTII.TESTIIRow = Me.DsWALTII.TESTII.Item(0)
                    RegistroTII.Delete()
                    Me.TESTIITableAdapter.Update(Me.DsWALTII.TESTII)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESTIIDataGridTableAdapter.Fill(Me.DsWALTII.TESTIIDataGrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & Instrumentos & " Instrumentos asociados.", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub

    Private Function DeterminaRelacion() As Boolean
        Dim dtINF As New dsWALTII.INFCuentaDataTable
        Dim taINF As New dsWALTIITableAdapters.INFCuentaTableAdapter
        Dim RegistroINF As dsWALTII.INFCuentaRow
        taINF.FillByTII_CODIGO(dtINF, CodigoTII)
        RegistroINF = dtINF.Item(0)

        Dim Respuesta As Boolean = True

        If RegistroINF.Cuenta > 0 Then
            Instrumentos = RegistroINF.Cuenta
            Respuesta = False
        End If

        Return Respuesta
    End Function
End Class