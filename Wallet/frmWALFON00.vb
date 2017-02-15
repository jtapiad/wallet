Public Class frmWALFON00
    ''' <summary>
    ''' Nombre Programa : frmWALFON00
    ''' Descripción     : Mantención de Fondos de Fondos Mutuos
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion
    Dim taFON As New dsWALFONTableAdapters.TESFONTableAdapter
    Dim FilaFON As dsWALFON.TESFONRow
    Dim dtFON As New dsWALFON.TESFONDataTable
    Dim RegistroFON As System.Data.DataRowView
    Dim CodigoFON As Long = 0
    Dim Colocaciones As Integer = 0
    Dim Cuotas As Integer = 0

    ''' <summary>
    ''' Carga de la Pantalla inicial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWALFON00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TESFONDatagridTableAdapter.Fill(Me.DsWALFON.TESFONDatagrid)
        Me.TESTFDTableAdapter.Fill(Me.DsWALFON.TESTFD)
        Me.TESENTTableAdapter.Fill(Me.DsWALFON.TESENT)
        Me.TESFONTableAdapter.Fill(Me.DsWALFON.TESFON)

    End Sub
    ''' <summary>
    ''' Agrega un nuevo fondo.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Fondo"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de Fondo"
        tsbCancela.ToolTipText = "Cancela creación de Fondo"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Entrego el Foco al primer campo
        Me.FON_FONDOTextBox.Focus()
        Accion.Accion = 1
        Me.TESFONTableAdapter.Fill(Me.DsWALFON.TESFON)
        Me.TESFONBindingSource.AddNew()
        RegistroFON = Me.TESFONBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.gbDetalle.Text = "Edita Fondo"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación del fondo"
        tsbCancela.ToolTipText = "Cancela modificación del fondo"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        'Entrego Foco al primer campo
        Me.FON_FONDOTextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroFON = Me.TESFONBindingSource.Current
    End Sub
    ''' <summary>
    ''' Vuelve a cargar la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.TESFONDatagridTableAdapter.Fill(Me.DsWALFON.TESFONDatagrid)

    End Sub
    ''' <summary>
    ''' Genera informe con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptFondos00.rpt"
        InfoTag.Numero = 9
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
        If RevisaError() Then

            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego Datos
                    RegistroFON.Item("FON_IDENTIFICACION") = Me.FON_RUNTextBox.Text & "/" & Me.FON_FONDOTextBox.Text
                    'Actualizo Binding
                    Me.TESFONBindingSource.EndEdit()
                    Me.TESFONTableAdapter.Update(Me.DsWALFON.TESFON)
                    ' Habilito lado izquierdo
                    HabilitaIzquierdo()

                Case 2 'editar
                    ''Entrego valores
                    RegistroFON.Item("FON_IDENTIFICACION") = Me.FON_RUNTextBox.Text & "/" & Me.FON_FONDOTextBox.Text
                    'Actualizo binding
                    Me.TESFONBindingSource.EndEdit()
                    Me.TESFONTableAdapter.Update(Me.DsWALFON.TESFON)
                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.TESFONDatagridTableAdapter.Fill(Me.DsWALFON.TESFONDatagrid)
        End If
    End Sub

    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.TESFONBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    Private Sub dgvFondos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFondos.RowEnter
        Dim Codigo As Object = dgvFondos.Rows(e.RowIndex).Cells(1).Value
        Me.TESFONTableAdapter.FillByFON_CODIGO(Me.DsWALFON.TESFON, Codigo)
        RegistroFON = Me.TESFONBindingSource.Current
        CodigoFON = Codigo

        If Me.FON_LIMITETextBox.Text = "" Then
        Else
            Me.FON_LIMITETextBox.Text = FormatCurrency(Me.FON_LIMITETextBox.Text, 0, TriState.True, TriState.True, TriState.True)
        End If
    End Sub

    ''' <summary>
    ''' Habilita el lado detalle y deshabilita el general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvFondos.Focus()
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
    ''' Valida campos obligatorios
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False
        If Me.FON_FONDOTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.FON_FONDOTextBox, "El nombre del fondo no puede ser nulo")
            If PrimerError = False Then
                PrimerError = True
                Me.FON_FONDOTextBox.Focus()
            End If
            Return False
        End If
        If Me.FON_RUNTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.FON_RUNTextBox, "El RUN del fondo no puede estar nulo")
            If PrimerError = False Then
                PrimerError = True
                Me.FON_RUNTextBox.Focus()
            End If
            Return False
        End If
        If Me.FON_LIMITETextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.FON_LIMITETextBox, "El límite del fondo no puede estar nulo")
            If PrimerError = False Then
                PrimerError = True
                Me.FON_LIMITETextBox.Focus()
            End If
            Return False
        End If
        Return True
    End Function
    ''' <summary>
    ''' Limpia los campos en el caso de que se trate de una segunda pasada.
    ''' </summary>
    Private Sub LimpiaCampos()
        Me.ErrorProvider1.Clear()
        Me.FON_FONDOTextBox.Text = ""
        Me.FON_LIMITETextBox.Text = ""
        Me.FON_RUNTextBox.Text = ""
        Me.ComboBox1.SelectedIndex = 1
        Me.ComboBox2.SelectedIndex = 1
    End Sub

    Private Sub FON_LIMITETextBox_Leave(sender As Object, e As EventArgs) Handles FON_LIMITETextBox.Leave
        Me.ErrorProvider1.Clear()
        If Not IsNumeric(Me.FON_LIMITETextBox.Text) And Me.FON_LIMITETextBox.Text <> "" Then
            Me.ErrorProvider1.SetError(Me.FON_LIMITETextBox, "El valor debe ser numérico")
            Me.FON_LIMITETextBox.Focus()
        Else
            Me.FON_LIMITETextBox.Text = FormatCurrency(Me.FON_LIMITETextBox.Text, 0, TriState.True, TriState.True, TriState.True)
        End If
    End Sub
    ''' <summary>
    ''' Saca los blancos de la derecha para facilitar edición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FON_FONDOTextBox_Enter(sender As Object, e As EventArgs)
        Me.FON_FONDOTextBox.Text = RTrim(FON_FONDOTextBox.Text)
    End Sub
    ''' <summary>
    ''' Saca los blancos de la derecha para facilitar edición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FON_RUNTextBox_Enter(sender As Object, e As EventArgs)
        Me.FON_RUNTextBox.Text = RTrim(Me.FON_RUNTextBox.Text)
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará el fondo " & FON_FONDOTextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroFON As dsWALFON.TESFONRow = Me.DsWALFON.TESFON.Item(0)
                    RegistroFON.Delete()
                    Me.TESFONTableAdapter.Update(Me.DsWALFON.TESFON)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.TESFONDatagridTableAdapter.Fill(Me.DsWALFON.TESFONDatagrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & Cuotas & " cuotas asociadas y " & Colocaciones & " colocaciones asociadas", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub

    Private Function DeterminaRelacion() As Boolean
        Dim dtCUO As New dsWALFON.CUOCuentaDataTable
        Dim taCUO As New dsWALFONTableAdapters.CUOCuentaTableAdapter
        Dim RegistroCUO As dsWALFON.CUOCuentaRow
        taCUO.FillByFON_CODIGO(dtCUO, CodigoFON)
        RegistroCUO = dtCUO.Item(0)

        Dim dtCLC As New dsWALFON.CLCCuentaDataTable
        Dim taCLC As New dsWALFONTableAdapters.CLCCuentaTableAdapter
        Dim RegistroCLC As dsWALFON.CLCCuentaRow
        taCLC.FillByFON_CODIGO(dtCLC, CodigoFON)
        RegistroCLC = dtCLC.Item(0)

        Dim Respuesta As Boolean = True

        If RegistroCUO.Cuenta > 0 Then
            Cuotas = RegistroCUO.Cuenta
            Respuesta = False
        End If

        If RegistroCLC.Cuenta > 0 Then
            Colocaciones = RegistroCLC.Cuenta
            Respuesta = False
        End If
        Return Respuesta
    End Function

End Class