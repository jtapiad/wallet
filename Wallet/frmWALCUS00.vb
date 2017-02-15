Public Class frmWALCUS00
    ''' <summary>
    ''' Nombre Programa : frmWALCUS00
    ''' Descripción     : Mantención de Custodias
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>
    Dim Accion As New Accion
    Dim taCUS As New dsWALCUSTableAdapters.TESCUSTableAdapter
    Dim FilaCus As dsWALCUS.TESCUSRow
    Dim dtCus As New dsWALCUS.TESCUSDataTable
    Dim RegistroCus As System.Data.DataRowView
    Dim CodigoCus As Long = 0
    Dim Colocacion As Integer

    ''' <summary>
    ''' Cargo la pantalla inicial, con todas las custodias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALCUS00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lleno la grilla con todas las custodias.
        Me.TESCUSDataGridTableAdapter.Fill(Me.DsWALCUS.TESCUSDataGrid)
        'dependiendo de lo seleccionado en la grilla, despliego datos en la parte derecha
        Me.TESCUSTableAdapter.FillByCUS_CODIGO(Me.DsWALCUS.TESCUS, CodigoCus)

    End Sub

    ''' <summary>
    ''' Agrega nueva custodia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Custodia"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de custodia"
        tsbCancela.ToolTipText = "Cancela creación de custodia"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.CUS_CUSTODIATextBox.Focus()
        Accion.Accion = 1
        Me.TESCUSTableAdapter.Fill(Me.DsWALCUS.TESCUS)
        Me.TESCUSBindingSource.AddNew()
        RegistroCus = Me.TESCUSBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub

    ''' <summary>
    ''' Edita una custodia ya creada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Custodia"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de custodia"
        tsbCancela.ToolTipText = "Cancela modificación de custodia"
        Dim Texto As String
        Texto = Me.CUS_CUSTODIATextBox.Text
        Me.CUS_CUSTODIATextBox.Text = RTrim(Texto)
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.CUS_CUSTODIATextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroCus = Me.TESCUSBindingSource.Current
    End Sub

    ''' <summary>
    ''' Acepta los datos de la custodia creada, o las modificaciones en el caso de edición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click
        If RevisaError() Then
            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego valores
                    'Actualizo Binding
                    Me.TESCUSBindingSource.EndEdit()
                    Me.TESCUSTableAdapter.Update(Me.DsWALCUS.TESCUS)
                    HabilitaIzquierdo()


                Case 2 'editar
                    'Actualizo binding
                    Me.TESCUSBindingSource.EndEdit()
                    Me.TESCUSTableAdapter.Update(Me.DsWALCUS.TESCUS)
                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESCUSDataGridTableAdapter.Fill(Me.DsWALCUS.TESCUSDataGrid)
        End If
    End Sub
    ''' <summary>
    ''' Vuelvo a cargar la grilla para reflejar cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESCUSDataGridTableAdapter.Fill(Me.DsWALCUS.TESCUSDataGrid)
    End Sub
    ''' <summary>
    ''' Cancela la adición o edición del registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESCUSBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub
    ''' <summary>
    ''' Cargo informe resumen con los datos de la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptCustodias00.rpt"
        InfoTag.Numero = 2
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Limpia los campos preparando para adición
    ''' </summary>
    Private Sub LimpiaCampos()
        Me.CUS_CUSTODIATextBox.Text = ""
    End Sub
    ''' <summary>
    ''' Valida que los campos obligatorios se encuentren presente
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False
        If Me.CUS_CUSTODIATextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.CUS_CUSTODIATextBox, "El nombre de la custodia no puede ser nulo")
            Return False
        End If
        Return True
    End Function
    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvCustodias.Focus()
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
    ''' Determina el código de custodia seleccionado en la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvCustodias_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustodias.RowEnter
        CodigoCus = dgvCustodias.Rows(e.RowIndex).Cells(1).Value
        Me.TESCUSTableAdapter.FillByCUS_CODIGO(Me.DsWALCUS.TESCUS, CodigoCus)

    End Sub
    ''' <summary>
    ''' Sale de la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará la custodia " & CUS_CUSTODIATextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaColocacion() Then
                Try
                    Dim RegistroCUS As dsWALCUS.TESCUSRow = Me.DsWALCUS.TESCUS.Item(0)
                    RegistroCUS.Delete()

                    Me.TESCUSTableAdapter.Update(Me.DsWALCUS.TESCUS)

                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESCUSDataGridTableAdapter.Fill(Me.DsWALCUS.TESCUSDataGrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & Colocacion & " colocaciones asociadas", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub

    Private Function DeterminaColocacion() As Boolean
        Dim dtCLC As New dsWALCUS.TESCLCDataTable
        Dim taCLC As New dsWALCUSTableAdapters.TESCLCTableAdapter

        taCLC.FillByCUS_CODIGO(dtCLC, CodigoCus)
        If dtCLC.Count > 0 Then
            Colocacion = dtCLC.Count
            Return False
        Else
            Return True
        End If

    End Function
End Class