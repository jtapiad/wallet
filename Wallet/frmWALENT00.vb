Imports System.ComponentModel
''' <summary>
''' Nombre Programa : frmWALENT00
''' Descripción     : Mantención Entidades Finanacieras
''' Programador     : Claudia González Cerda
''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
''' www.2sys.com
''' </summary>
Public Class frmWALENT00
    Dim Accion As New Accion
    Dim taENT As New dsWALENTTableAdapters.TESENTTableAdapter
    Dim FilaENT As dsWALENT.TESENTRow
    Dim dtENT As New dsWALENT.TESENTDataTable
    Dim RegistroENT As System.Data.DataRowView
    Dim CodigoENT As Long = 0
    Dim Sucursales As Integer = 0
    Dim Contactos As Integer = 0
    Dim Cuentas As Integer = 0
    Dim Fondos As Integer = 0
    Dim Colocaciones As Integer = 0

    ''' <summary>
    ''' Carga de la Pantalla inicial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALENT00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESTENTableAdapter.Fill(Me.DsWALENT.TESTEN)
        Me.TESENTTableAdapter.Fill(Me.DsWALENT.TESENT)
        Me.TESENTDataGridTableAdapter.Fill(Me.DsWALENT.TESENTDataGrid)

    End Sub

    ''' <summary>
    ''' Agrega una nueva entidad.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Entidad"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de Entidad"
        tsbCancela.ToolTipText = "Cancela creación de Entidad"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.ENT_RAZONTextBox.Focus()
        Accion.Accion = 1
        Me.TESENTTableAdapter.Fill(Me.DsWALENT.TESENT)
        Me.TESENTBindingSource.AddNew()
        RegistroENT = Me.TESENTBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub
    ''' <summary>
    ''' Cambia valores de un registro ya creado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Entidad"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de Entidad"
        tsbCancela.ToolTipText = "Cancela modificación de Entidad"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.ENT_RAZONTextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroENT = Me.TESENTBindingSource.Current
    End Sub
    ''' <summary>
    ''' Vuelve a cargar la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESENTDataGridTableAdapter.Fill(Me.DsWALENT.TESENTDataGrid)
    End Sub
    ''' <summary>
    ''' Genera informe con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptEntidades00.rpt"
        InfoTag.Numero = 5
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default
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
    ''' Graba el nuevo registro o confirma la edición de un registro ya existente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click


        Me.Validate()

        If RevisaError() Then
            Dim StrAuditoria As String
            StrAuditoria = Me.RegistroENT.Item("ENT_AUDITORIA").ToString
            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego valores
                    RegistroENT.Item("TEN_CODIGO") = Me.TEN_CODIGOComboBox.SelectedValue
                    RegistroENT.Item("ENT_AUDITORIA") = Auditoria("")
                    RegistroENT.Item("TEN_CODIGO") = Me.TEN_CODIGOComboBox.SelectedValue

                    Dim Estado As String = ""
                    If Me.rbActiva.Checked Then
                        Estado = "A"
                    ElseIf Me.rbBloqueada.Checked Then
                        Estado = "B"
                    Else
                        Estado = "C"
                    End If
                    RegistroENT.Item("ENT_ESTADO") = Estado
                    'Actualizo Binding
                    Me.TESENTBindingSource.EndEdit()
                    Me.TESENTTableAdapter.Update(Me.DsWALENT.TESENT)
                    ' Habilito lado izquierdo
                    HabilitaIzquierdo()

                Case 2 'editar
                    'Entrego valores
                    RegistroENT.Item("TEN_CODIGO") = Me.TEN_CODIGOComboBox.SelectedValue
                    RegistroENT.Item("ENT_AUDITORIA") = Auditoria(StrAuditoria)
                    RegistroENT.Item("TEN_CODIGO") = Me.TEN_CODIGOComboBox.SelectedValue

                    Dim Estado As String = ""
                    If Me.rbActiva.Checked Then
                        Estado = "A"
                    ElseIf Me.rbBloqueada.Checked Then
                        Estado = "B"
                    Else
                        Estado = "C"
                    End If
                    RegistroENT.Item("ENT_ESTADO") = Estado
                    'Actualizo binding
                    Me.TESENTBindingSource.EndEdit()
                    Me.TESENTTableAdapter.Update(Me.DsWALENT.TESENT)
                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESENTDataGridTableAdapter.Fill(Me.DsWALENT.TESENTDataGrid)

        End If
    End Sub

    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESENTBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    Private Sub dgvUsuarios_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntidades.RowEnter
        Dim Codigo As Object = dgvEntidades.Rows(e.RowIndex).Cells(1).Value
        Me.TESENTTableAdapter.FillByENT_CODIGO(Me.DsWALENT.TESENT, Codigo)
        CodigoENT = Codigo
        RegistroENT = Me.TESENTBindingSource.Current
        If Me.ENT_LIMITETextBox.Text = "" Then
        Else
            Me.ENT_LIMITETextBox.Text = FormatCurrency(Me.ENT_LIMITETextBox.Text, 0, TriState.True, TriState.True, TriState.True)
        End If
        Dim Tipo As Long = 0
        Tipo = RegistroENT.Item("TEN_CODIGO")
        Me.TEN_CODIGOComboBox.SelectedValue = Tipo
        Select Case RegistroENT.Item("ENT_ESTADO")
            Case "A"
                Me.rbActiva.Checked = True
            Case "B"
                Me.rbBloqueada.Checked = True
            Case "C"
                Me.rbCondicionada.Checked = True
        End Select
    End Sub
    ''' <summary>
    ''' Valida que el campo sea numérico
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ENT_LIMITETextBox_Leave(sender As Object, e As EventArgs) Handles ENT_LIMITETextBox.Leave
        Me.ErrorProvider1.Clear()
        If Not IsNumeric(Me.ENT_LIMITETextBox.Text) And Me.ENT_LIMITETextBox.Text <> "" Then
            Me.ErrorProvider1.SetError(Me.ENT_LIMITETextBox, "El valor debe ser numérico")
            Me.ENT_LIMITETextBox.Focus()
        Else
            Me.ENT_LIMITETextBox.Text = FormatCurrency(Me.ENT_LIMITETextBox.Text, 0, TriState.True, TriState.True, TriState.True)
        End If
    End Sub

    ''' <summary>
    ''' Limpia los campos en el caso de que se trate de una segunda pasada.
    ''' </summary>
    Private Sub LimpiaCampos()
        Me.ErrorProvider1.Clear()
        Me.ENT_ABREVIATURATextBox.Text = ""
        Me.ENT_LIMITETextBox.Text = ""
        Me.ENT_RAZONTextBox.Text = ""
        Me.ENT_RUTTextBox.Text = ""
        Me.ENT_SITIOTextBox.Text = ""
        Me.rbActiva.Checked = True
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
        Me.dgvEntidades.Focus()
    End Sub

    ''' <summary>
    ''' Valida campos obligatorios
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False
        If Me.ENT_RAZONTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.ENT_RAZONTextBox, "La razón de la entidad no puede ser nulo")
            If PrimerError = False Then
                PrimerError = True
                Me.ENT_RAZONTextBox.Focus()
            End If
            Return False
        End If
        If Me.ENT_ABREVIATURATextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.ENT_ABREVIATURATextBox, "La abreviatura de la entidad no puede estar nulo")
            If PrimerError = False Then
                PrimerError = True
                Me.ENT_ABREVIATURATextBox.Focus()
            End If
            Return False
        End If
        If Me.ENT_RUTTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.ENT_RUTTextBox, "El RUT de la entidad no puede estar nulo")
            If PrimerError = False Then
                PrimerError = True
                Me.ENT_RUTTextBox.Focus()
            End If
            Return False
        End If
        'If Me.ENT_RUTTextBox.Text <> "" Then
        '    ENT_RUTTextBox.Text = Validar_RUT(ENT_RUTTextBox.Text)
        '    If Me.ENT_RUTTextBox.Text = "" Then
        '        If PrimerError = False Then
        '            PrimerError = True
        '            Me.ENT_RUTTextBox.Focus()
        '        End If
        '        Return False

        '    End If
        'End If


        Return True
    End Function


    ''' <summary>
    ''' Valida que el RUT ingresado sea válido
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ENT_RUTTextBox_LostFocus(sender As Object, e As EventArgs) Handles ENT_RUTTextBox.LostFocus
        Me.Validate()
    End Sub

    Private Sub ENT_RUTTextBox_Leave(sender As Object, e As EventArgs) Handles ENT_RUTTextBox.Leave

    End Sub

    Private Sub ENT_RUTTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ENT_RUTTextBox.Validating
        If Me.ENT_RUTTextBox.Text <> "" Then
            ENT_RUTTextBox.Text = Validar_RUTEP(ENT_RUTTextBox.Text, ErrorProvider1, ENT_RUTTextBox)
            If Me.ENT_RUTTextBox.Text = "" Then
                Me.ENT_RUTTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub frmWALENT00_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará la Entidad " & ENT_RAZONTextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroENT As dsWALENT.TESENTRow = Me.DsWALENT.TESENT.Item(0)
                    RegistroENT.Delete()
                    Me.TESENTTableAdapter.Update(Me.DsWALENT.TESENT)
                Catch ex As Exception
                    MsgBox("No se puede eliimnar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESENTDataGridTableAdapter.Fill(Me.DsWALENT.TESENTDataGrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & Sucursales & " sucursales, " & Contactos & " contactos, " & Colocaciones & " colocaciones, " & Fondos & " fondos y " & Cuentas & " cuentas asociadas", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub

    Private Function DeterminaRelacion() As Boolean
        Dim dtSUC As New dsWALENT.SUCCuentaDataTable
        Dim taSUC As New dsWALENTTableAdapters.SUCCuentaTableAdapter
        Dim RegistroSUC As dsWALENT.SUCCuentaRow
        taSUC.FillByENT_CODIGO(dtSUC, CodigoENT)
        RegistroSUC = dtSUC.Item(0)

        Dim dtCTE As New dsWALENT.CTECuentaDataTable
        Dim taCTE As New dsWALENTTableAdapters.CTECuentaTableAdapter
        Dim RegistroCTE As dsWALENT.CTECuentaRow
        taCTE.FillByENT_CODIGO(dtCTE, CodigoENT)
        RegistroCTE = dtCTE.Item(0)

        Dim dtCON As New dsWALENT.CONCuentaDataTable
        Dim taCON As New dsWALENTTableAdapters.CONCuentaTableAdapter
        Dim RegistroCON As dsWALENT.CONCuentaRow
        taCON.FillByENT_CODIGO(dtCON, CodigoENT)
        RegistroCON = dtCON.Item(0)

        Dim dtFON As New dsWALENT.FONCuentaDataTable
        Dim taFON As New dsWALENTTableAdapters.FONCuentaTableAdapter
        Dim RegistroFON As dsWALENT.FONCuentaRow
        taFON.FillByENT_CODIGO(dtFON, CodigoENT)
        RegistroFON = dtFON.Item(0)

        Dim dtCLC As New dsWALENT.CLCCuentaDataTable
        Dim taCLC As New dsWALENTTableAdapters.CLCCuentaTableAdapter
        Dim RegistroCLC As dsWALENT.CLCCuentaRow
        taCLC.FillByENT_CODIGO(dtCLC, CodigoENT)
        RegistroCLC = dtCLC.Item(0)

        Dim Respuesta As Boolean = True

        If RegistroSUC.Cuenta > 0 Then
            Sucursales = RegistroSUC.Cuenta
            Respuesta = False
        End If

        If RegistroCTE.Cuenta > 0 Then
            Cuentas = RegistroCTE.Cuenta
            Respuesta = False
        End If

        If RegistroCON.Cuenta > 0 Then
            Contactos = RegistroCON.Cuenta
            Respuesta = False
        End If

        If RegistroFON.Cuenta > 0 Then
            Fondos = RegistroFON.Cuenta
            Respuesta = False
        End If

        If RegistroCLC.Cuenta > 0 Then
            Colocaciones = RegistroCLC.Cuenta
            Respuesta = False
        End If
        Return Respuesta
    End Function
End Class