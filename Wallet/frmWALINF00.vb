Public Class frmWALINF00
    ''' <summary>
    ''' Nombre Programa : frmWALINF00
    ''' Descripción     : Mantención de Instrumentos Financieros
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion
    Dim taINF As New dsWALINFTableAdapters.TESINFTableAdapter
    Dim FilaINF As dsWALINF.TESINFRow
    Dim dtINF As New dsWALINF.TESINFDataTable
    Dim RegistroINF As System.Data.DataRowView
    Dim CodigoINF As Long = 0
    Dim Colocaciones As Integer = 0
    ''' <summary>
    ''' Carga la pantalla inicial con los instrumentos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALINF00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lleno la grilla de datos
        Me.TESINFDatagridTableAdapter.Fill(Me.DsWALINF.TESINFDataGrid)

        Me.TESINFTableAdapter.Fill(Me.DsWALINF.TESINF)
        'Lleno el combo de tipo de documento
        Me.TESTIITableAdapter.Fill(Me.DsWALINF1.TESTII)

    End Sub
    ''' <summary>
    ''' Agrega nuevo instrumento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Instrumento"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de insturmento"
        tsbCancela.ToolTipText = "Cancela creación de instrumento"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.INF_NOMBRETextBox.Focus()
        Accion.Accion = 1
        Me.TESINFTableAdapter.Fill(Me.DsWALINF.TESINF)
        Me.TESINFBindingSource.AddNew()
        RegistroINF = Me.TESINFBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub

    ''' <summary>
    ''' Cambia valores de un instrumento ya creado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Instrumento"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de instrumento"
        tsbCancela.ToolTipText = "Cancela modificación de instrumento"

        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.INF_NOMBRETextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroINF = Me.TESINFBindingSource.Current
    End Sub

    ''' <summary>
    ''' Vuelvo a cargar la grilla para reflejar cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESINFDatagridTableAdapter.Fill(Me.DsWALINF.TESINFDataGrid)

    End Sub

    ''' <summary>
    ''' Cargo informe resumen con los datos de la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptInstrumentos00.rpt"
        InfoTag.Numero = 10
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
    ''' <param name="e"></param>v
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Acepta los datos del instrumento creado, o las modificaciones en el caso de edición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click
        If RevisaError() Then
            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego valores
                    'Actualizo Binding
                    Try
                        Me.TESINFBindingSource.EndEdit()
                        Me.TESINFTableAdapter.Update(Me.DsWALINF.TESINF)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, NombreSistema)
                    End Try

                    HabilitaIzquierdo()

                Case 2 'editar
                    'Actualizo binding
                    Me.TESINFBindingSource.EndEdit()
                    Me.TESINFTableAdapter.Update(Me.DsWALINF.TESINF)

                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESINFDatagridTableAdapter.Fill(Me.DsWALINF.TESINFDataGrid)
        End If
    End Sub

    ''' <summary>
    ''' Cancela la adición o edición del registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESINFBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    ''' <summary>
    ''' Determina el código de instrumento que está seleccionado en el datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvInstrumentos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstrumentos.RowEnter
        CodigoINF = dgvInstrumentos.Rows(e.RowIndex).Cells(1).Value
        Me.TESINFTableAdapter.FillByINF_CODIGO(Me.DsWALINF.TESINF, CodigoINF)

    End Sub

    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvInstrumentos.Focus()
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
        Me.INF_NOMBRETextBox.Text = ""
        Me.INF_ABREVIATURATextBox.Text = ""
    End Sub

    ''' <summary>
    ''' Valida que el campo Instrumento y la abreviatura contenga texto
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False
        If Me.INF_NOMBRETextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.INF_NOMBRETextBox, "El nombre del instrumento no puede ser nulo")
            Return False
        End If
        If Me.INF_ABREVIATURATextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.INF_ABREVIATURATextBox, "La abreviatura del instrumento no puede ser nulo")
            Return False
        End If
        Return True
    End Function

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará el fondo " & INF_NOMBRETextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroINF As dsWALINF.TESINFRow = Me.DsWALINF.TESINF.Item(0)
                    RegistroINF.Delete()
                    Me.TESINFTableAdapter.Update(Me.DsWALINF.TESINF)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESINFDatagridTableAdapter.Fill(Me.DsWALINF.TESINFDataGrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & Colocaciones & " colocaciones asociadas", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub
    Private Function DeterminaRelacion() As Boolean


        Dim dtCLC As New dsWALINF.CLCCuentaDataTable
        Dim taCLC As New dsWALINFTableAdapters.CLCCuentaTableAdapter
        Dim RegistroCLC As dsWALINF.CLCCuentaRow
        taCLC.FillByINF_CODIGO(dtCLC, CodigoINF)
        RegistroCLC = dtCLC.Item(0)

        Dim Respuesta As Boolean = True

        If RegistroCLC.Cuenta > 0 Then
            Colocaciones = RegistroCLC.Cuenta
            Respuesta = False
        End If
        Return Respuesta
    End Function
End Class