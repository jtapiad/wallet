Public Class frmWALEST00
    ''' <summary>
    ''' Nombre Programa : frmWALEST00
    ''' Descripción     : Mantención Estados
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion
    Dim taEST As New dsWALESTTableAdapters.TESESTTableAdapter
    Dim FilaEst As dsWALEST.TESESTRow
    Dim dtEST As New dsWALEST.TESESTDataTable
    Dim RegistroEst As System.Data.DataRowView
    Dim CodigoEst As Long = 0
    Dim Colocaciones As Integer = 0
    Private Sub frmWALEST00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESESTTableAdapter.Fill(Me.DsWALEST.TESEST)
        Me.TESESTDatagridTableAdapter.Fill(Me.DsWALEST.TESESTDatagrid)

    End Sub

    ''' <summary>
    ''' Agrega un nuevo estado de Instrumentos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Estado"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de estado"
        tsbCancela.ToolTipText = "Cancela creación de estado"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.EST_ESTADOTextBox.Focus()
        Accion.Accion = 1
        Me.TESESTTableAdapter.Fill(Me.DsWALEST.TESEST)
        Me.TESESTBindingSource.AddNew()
        RegistroEst = Me.TESESTBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub
    ''' <summary>
    ''' Edita un estado ya creado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Estado"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de estado"
        tsbCancela.ToolTipText = "Cancela modificación de estado"
        Dim Texto As String
        Texto = Me.EST_ESTADOTextBox.Text
        Me.EST_ESTADOTextBox.Text = RTrim(Texto)
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.EST_ESTADOTextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroEst = Me.TESESTBindingSource.Current
    End Sub
    ''' <summary>
    ''' Vuelvo a cargar la grilla para reflejar cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESESTDatagridTableAdapter.Fill(Me.DsWALEST.TESESTDatagrid)
    End Sub
    ''' <summary>
    ''' Cargo informe resumen con los datos de la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptEstados00.rpt"
        InfoTag.Numero = 4
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
                    Me.TESESTBindingSource.EndEdit()
                    Me.TESESTTableAdapter.Update(Me.DsWALEST.TESEST)
                    HabilitaIzquierdo()
                Case 2 'editar
                    'Actualizo binding
                    Me.TESESTBindingSource.EndEdit()
                    Me.TESESTTableAdapter.Update(Me.DsWALEST.TESEST)
                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESESTDatagridTableAdapter.Fill(Me.DsWALEST.TESESTDatagrid)
        End If
    End Sub
    ''' <summary>
    ''' Cancela la adición o edición del registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESESTBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub
    ''' <summary>
    ''' Determina el código de custodia seleccionado en la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvEstados_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstados.RowEnter
        CodigoEst = dgvEstados.Rows(e.RowIndex).Cells(1).Value
        Me.TESESTTableAdapter.FillByEST_CODIGO(Me.DsWALEST.TESEST, CodigoEst)
    End Sub
    ''' <summary>
    ''' Habilita el grupo de detalle y deshabilita el grupo general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvEstados.Focus()
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
    ''' Limpia los campos preparando para adición
    ''' </summary>
    Private Sub LimpiaCampos()
        Me.EST_ESTADOTextBox.Text = ""
    End Sub

    ''' <summary>
    ''' Valida que los campos obligatorios se encuentren presente
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False
        If Me.EST_ESTADOTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.EST_ESTADOTextBox, "El nombre del estado no puede ser nulo")
            Return False
        End If
        Return True
    End Function

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará el estado " & EST_ESTADOTextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroEST As dsWALEST.TESESTRow = Me.DsWALEST.TESEST.Item(0)
                    RegistroEST.Delete()
                    Me.TESESTTableAdapter.Update(Me.DsWALEST.TESEST)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESESTDatagridTableAdapter.Fill(Me.DsWALEST.TESESTDatagrid)

            Else
                MsgBox("El registro no puede ser eliminado, tiene " & Colocaciones & " colocaciones asociadas", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub
    Private Function DeterminaRelacion() As Boolean


        Dim dtCLC As New dsWALEST.CLCCuentaDataTable
        Dim taCLC As New dsWALESTTableAdapters.CLCCuentaTableAdapter
        Dim RegistroCLC As dsWALEST.CLCCuentaRow
        taCLC.FillByEST_CODIGO(dtCLC, CodigoEst)
        RegistroCLC = dtCLC.Item(0)
        Dim Respuesta As Boolean = True

        If RegistroCLC.Cuenta > 0 Then
            Colocaciones = RegistroCLC.Cuenta
            Respuesta = False
        End If


        Return Respuesta
    End Function
End Class