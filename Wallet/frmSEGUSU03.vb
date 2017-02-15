Imports System.Data

Public Class frmSEGUSU03
    Dim Accion As New Accion

    Dim taUSU As New dsSEGUSUTableAdapters.SEGUSUTableAdapter
    Dim FilaUsu As dsSEGUSU.SEGUSURow
    Dim dtUsu As New dsSEGUSU.SEGUSUDataTable
    Dim RegistroUSU As System.Data.DataRowView
    Dim CodigoUsu As Long = 0
    Dim UsernameActual As String = ""

#Region "Eventos"

    ''' <summary>
    ''' Carga de la Pantalla inicial, la pantalla parte con chkBloqueados sin marca y texto de tbBuscaUsu Vacio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmSEGUSU03_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiaCampos()

        'Lleno la grilla con todos los usuarios. Al partir chkBloqueados se encuentra Unchecked
        Me.SEGUSUDataGridTableAdapter.FillByVigentes(Me.DsSEGUSU.SEGUSUDataGrid)
        'Muestra todos los usuarios vigentes.
        'Lleno los datos de los usuarios
        Me.SEGUSUTableAdapter.Fill(Me.DsSEGUSU.SEGUSU)
        'Lleno los datos de los perfiles
        Me.SEGPERTableAdapter.Fill(Me.DsSEGPER.SEGPER)

    End Sub
#End Region
#Region "Botones"
    ''' <summary>
    ''' Al presionar el botón buscar se selecciona el tipo de llenado dependiendo de las marcas de la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        BuscaUsuarios()

    End Sub

    ''' <summary>
    ''' Agrega un nuevo usuario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click

        'Cambio el título del panel
        Me.gbDetalle.Text = "Agrega Usuario"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de usuario"
        tsbCancela.ToolTipText = "Cancela creación de usuario"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()
        'Limpio UsernameActual
        UsernameActual = ""
        'Deshabilito botón de cambio de contraseña
        Me.tsbContraseña.Enabled = False
        'Entrego el Foco al primer campo
        Me.SEGUSU_USERNAMETextBox.Focus()
        Accion.Accion = 1
        Me.SEGUSUTableAdapter.Fill(Me.DsSEGUSU.SEGUSU)
        Me.SEGUSUBindingSource.AddNew()
        RegistroUSU = Me.SEGUSUBindingSource.Current
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
        Me.gbDetalle.Text = "Edita Usuario"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de usuario"
        tsbCancela.ToolTipText = "Cancela modificación de usuario"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()
        UsernameActual = Me.SEGUSU_USERNAMETextBox.Text
        'Entrego Foco al primer campo
        Me.SEGUSU_USERNAMETextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroUSU = Me.SEGUSUBindingSource.Current
    End Sub
    ''' <summary>
    ''' Graba cambios o agrega registro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click
        ArmaCompleto()
        If RevisaError() Then
            If RevisaUsername() Then
                Select Case Accion.Accion
                    Case 1 ' Agregar
                        'Entrego valores
                        RegistroUSU.Item("SEGPER_CODIGO") = Me.SEGPER_CODIGOComboBox.SelectedValue
                        If Me.SEGUSU_BLOQUEADOCheckBox.Checked Then
                            RegistroUSU.Item("SEGUSU_FECHABLO") = Me.SEGUSU_FECHABLODateTimePicker.Value
                            RegistroUSU.Item("SEGUSU_FECHAFIN") = Me.SEGUSU_FECHAFINDateTimePicker.Value
                        End If
                        'Actualizo Binding
                        Me.SEGUSUBindingSource.EndEdit()
                        Me.SEGUSUTableAdapter.Update(Me.DsSEGUSU.SEGUSU)
                        frmSEGUSU04.Tag = RegistroUSU.Item("SEGUSU_CODIGO")

                        frmSEGUSU04.ShowDialog()
                        Dim registro As DataRowView = Me.SEGUSUBindingSource.Current
                        If IsNothing(registro.Item("SEGUSU_PASSWORD")) = True Then
                            MsgBox("La contraseña no se grabó correctamente, intente nuevamente", MsgBoxStyle.OkOnly, NombreSistema)
                        Else
                            ' Habilito lado izquierdo
                            HabilitaIzquierdo()
                            'Refresco la grilla
                            BuscaUsuarios()
                        End If
                    Case 2 'editar
                        'Entrego valores
                        RegistroUSU.Item("SEGPER_CODIGO") = Me.SEGPER_CODIGOComboBox.SelectedValue
                        If Me.SEGUSU_BLOQUEADOCheckBox.Checked Then
                            RegistroUSU.Item("SEGUSU_FECHABLO") = Me.SEGUSU_FECHABLODateTimePicker.Value
                            RegistroUSU.Item("SEGUSU_FECHAFIN") = Me.SEGUSU_FECHAFINDateTimePicker.Value
                        Else
                            RegistroUSU.Item("SEGUSU_FECHABLO") = DBNull.Value
                            RegistroUSU.Item("SEGUSU_FECHAFIN") = DBNull.Value
                        End If
                        'Actualizo binding
                        Me.SEGUSUBindingSource.EndEdit()
                        Me.SEGUSUTableAdapter.Update(Me.DsSEGUSU.SEGUSU)
                        'Habilito lado izquierdo
                        HabilitaIzquierdo()
                        'Refresco la grilla
                        BuscaUsuarios()
                End Select
            Else
                MsgBox("Ese nombre de usuario ya ha sido utilizado, por favor ingrese otro", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub
    ''' <summary>
    ''' Cancela la edición y deshabilita lado derecho
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.SEGUSUBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub
    ''' <summary>
    ''' Genera informe con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        InfoTag.Reporte = "reportes\rptUsuarios00.rpt"
        InfoTag.Numero = 1
        Dim Informe As New frmWALREP00
        Informe.Tag = InfoTag
        Informe.MdiParent = Me.MdiParent
        Informe.Show()
        Me.Cursor = Cursors.Default

    End Sub
    ''' <summary>
    ''' Abre la pantalla de cambio de contraseña
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbContraseña_Click(sender As Object, e As EventArgs) Handles tsbContraseña.Click
        frmSEGUSU04.Tag = RegistroUSU.Item("SEGUSU_CODIGO")
        frmSEGUSU04.ShowDialog()
        HabilitaIzquierdo()
        BuscaUsuarios()
    End Sub
    ''' <summary>
    ''' Vuelve a cargar la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        BuscaUsuarios()
    End Sub
#End Region
    ''' <summary>
    ''' Valida que el username ya no exista
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaUsername() As Boolean
        'Veo cual si el username cambio
        If Me.SEGUSU_USERNAMETextBox.Text = UsernameActual Then
            Return True
        Else
            'si es distinto, veo si el username usado no está usado
            Dim dt As New dsSEGUSU.SEGUSUDataTable
            Dim ta As New dsSEGUSUTableAdapters.SEGUSUTableAdapter
            ta.FillBySEGUSU_USERNAME(dt, Me.SEGUSU_USERNAMETextBox.Text)
            If dt.Count = 0 Then
                Return True
            Else
                Return False
            End If
            ' hacer una busqueda de nombres de usuarios y comparar. Ver la cantidad no es busqueda, but how
        End If

    End Function

    ''' <summary>
    ''' Limpia los campos en el caso de que se trate de una segunda pasada.
    ''' </summary>
    Private Sub LimpiaCampos()
        Me.ErrorProvider1.Clear()
        Me.tbBuscaUsu.Text = ""
        Me.SEGUSU_USERNAMETextBox.Text = ""
        Me.SEGUSU_NOMBRESTextBox.Text = ""
        Me.SEGUSU_PATERNOTextBox.Text = ""
        Me.SEGUSU_MATERNOTextBox.Text = ""
        Me.SEGUSU_COMPLETOLabel1.Text = ""
        Me.SEGUSU_RUTTextBox.Text = ""
        Me.SEGUSU_EMAIL1TextBox.Text = ""
        Me.SEGUSU_EMAIL2TextBox.Text = ""
        Me.SEGUSU_TELEFONOTextBox.Text = ""
        Me.SEGUSU_BLOQUEADOCheckBox.Checked = False
        Me.SEGUSU_FINIQUITOCheckBox.Checked = False
        Me.SEGUSU_SALUDOSCheckBox.Checked = False
        Me.SEGPER_CODIGOComboBox.SelectedValue = 1
    End Sub


    ''' <summary>
    ''' Cambio de Estado del CheckBox chkBloqueados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkBloqueados_CheckedChanged(sender As Object, e As EventArgs) Handles chkBloqueados.CheckedChanged
        'Al cambiar el check, cambio la vista para incluir todos los usuarios, si hay texto en el tbBuscaUsu, incluyo la búsqueda.
        If Me.chkBloqueados.Checked Then
            If Me.tbBuscaUsu.Text = "" Then
                'Si esta marcado todos y no hay búsqueda
                Me.SEGUSUDataGridTableAdapter.Fill(Me.DsSEGUSU.SEGUSUDataGrid)
            Else
                'Si marca todos y hay búsqueda
                Me.SEGUSUDataGridTableAdapter.FillByBusqueda(Me.DsSEGUSU.SEGUSUDataGrid, Me.tbBuscaUsu.Text)
            End If
        Else
            'Se desmarca todos y no hay busqueda
            If Me.tbBuscaUsu.Text = "" Then
                'Si no esta marcado todos y no hay búsqueda
                Me.SEGUSUDataGridTableAdapter.FillByVigentes(Me.DsSEGUSU.SEGUSUDataGrid)
            Else
                'Si no marca todos y hay búsqueda
                Me.SEGUSUDataGridTableAdapter.FillByBusquedaVigente(Me.DsSEGUSU.SEGUSUDataGrid, Me.tbBuscaUsu.Text)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Actualiza la grilla con los nuevos criterios de búsqueda
    ''' </summary>
    Private Sub BuscaUsuarios()
        If Me.tbBuscaUsu.Text = "" Then
            'Si el campo Búsqueda está vacío, carga todo dependiendo del chkBloqueados.
            If Me.chkBloqueados.Checked Then
                Me.SEGUSUDataGridTableAdapter.Fill(Me.DsSEGUSU.SEGUSUDataGrid)
            Else
                Me.SEGUSUDataGridTableAdapter.FillByVigentes(Me.DsSEGUSU.SEGUSUDataGrid)
            End If
        Else
            'Si el campo búsqueda tiene texto, carga el resultado de la búsqueda dependiendo del chkBloqueados.
            If Me.chkBloqueados.Checked Then
                Me.SEGUSUDataGridTableAdapter.FillByBusqueda(Me.DsSEGUSU.SEGUSUDataGrid, Me.tbBuscaUsu.Text)
            Else
                Me.SEGUSUDataGridTableAdapter.FillByBusquedaVigente(Me.DsSEGUSU.SEGUSUDataGrid, Me.tbBuscaUsu.Text)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Al cambiar la selección de la grilla, cambian los datos seleccionados en el lado derecho de la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvUsuarios_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.RowEnter

        Dim Codigo As Object = dgvUsuarios.Rows(e.RowIndex).Cells(2).Value
        Me.SEGUSUTableAdapter.FillBySEGUSU_CODIGO(Me.DsSEGUSU.SEGUSU, Codigo)
        RegistroUSU = Me.SEGUSUBindingSource.Current
        If RegistroUSU.Item("SEGUSU_FECHABLO") Is DBNull.Value Then
            Me.SEGUSU_FECHABLODateTimePicker.Value = Now
        End If
        If RegistroUSU.Item("SEGUSU_FECHAFIN") Is DBNull.Value Then
            Me.SEGUSU_FECHAFINDateTimePicker.Value = Now
        End If
    End Sub

#Region "NombreCompleto"
    ''' <summary>
    ''' genera nombre completo
    ''' </summary>
    Private Sub ArmaCompleto()
        Me.SEGUSU_COMPLETOLabel1.Text = SEGUSU_NOMBRESTextBox.Text & " " & SEGUSU_PATERNOTextBox.Text & " " & SEGUSU_MATERNOTextBox.Text
    End Sub
    ''' <summary>
    ''' Actualiza nombre completo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_NOMBRESTextBox_LostFocus(sender As Object, e As EventArgs) Handles SEGUSU_NOMBRESTextBox.LostFocus
        ArmaCompleto()
    End Sub
    ''' <summary>
    ''' Actualiza nombre completo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_PATERNOTextBox_LostFocus(sender As Object, e As EventArgs) Handles SEGUSU_PATERNOTextBox.LostFocus
        ArmaCompleto()
    End Sub
    ''' <summary>
    ''' Actualiza nombre completo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_MATERNOTextBox_LostFocus(sender As Object, e As EventArgs) Handles SEGUSU_MATERNOTextBox.LostFocus
        ArmaCompleto()
    End Sub
#End Region

#Region "Validaciones"
    ''' <summary>
    ''' Valida dirección de correo de formato válido
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_EMAIL1TextBox_Leave(sender As Object, e As EventArgs) Handles SEGUSU_EMAIL1TextBox.Leave
        Me.ErrorProvider1.Clear()
        If Me.SEGUSU_EMAIL1TextBox.Text <> "" Then
            If Validar_eMail(Me.SEGUSU_EMAIL1TextBox.Text) = False Then
                Me.ErrorProvider1.SetError(SEGUSU_EMAIL1TextBox, "Debe ingresar un correo válido")
                Me.SEGUSU_EMAIL1TextBox.Focus()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Valida dirección de correo de formato válido
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_EMAIL2TextBox_Leave(sender As Object, e As EventArgs) Handles SEGUSU_EMAIL2TextBox.Leave
        Me.ErrorProvider1.Clear()
        If Me.SEGUSU_EMAIL2TextBox.Text <> "" Then
            If Validar_eMail(Me.SEGUSU_EMAIL2TextBox.Text) = False Then
                Me.ErrorProvider1.SetError(SEGUSU_EMAIL2TextBox, "Debe ingresar un correo válido")
                Me.SEGUSU_EMAIL2TextBox.Focus()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Valida Rut 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_RUTTextBox_LostFocus(sender As Object, e As EventArgs) Handles SEGUSU_RUTTextBox.LostFocus

        If Me.SEGUSU_RUTTextBox.Text <> "" Then
            SEGUSU_RUTTextBox.Text = Validar_RUT(SEGUSU_RUTTextBox.Text)
            If Me.SEGUSU_RUTTextBox.Text = "" Then
                Me.SEGUSU_RUTTextBox.Focus()
            End If
        End If

    End Sub

    ''' <summary>
    ''' Valida presencia de campos obligatorios y fechas
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        If Me.SEGUSU_USERNAMETextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.SEGUSU_USERNAMETextBox, "El nombre de usuario no puede ser nulo")
            Me.SEGUSU_USERNAMETextBox.Focus()
            Return False
        End If
        If Me.SEGUSU_NOMBRESTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.SEGUSU_NOMBRESTextBox, "Los nombres del usuario no pueden estar nulo")
            Me.SEGUSU_USERNAMETextBox.Focus()
            Return False
        End If
        If Me.SEGUSU_BLOQUEADOCheckBox.Checked Then
            If Me.SEGUSU_FECHABLODateTimePicker.Value > SEGUSU_FECHAFINDateTimePicker.Value Then
                Me.ErrorProvider1.SetError(Me.SEGUSU_FECHAFINDateTimePicker, "La fecha de inicio del bloqueo debe ser menor que la de término")
                Me.SEGUSU_FECHABLODateTimePicker.Focus()
                Return False
            End If
        End If
        Return True

    End Function
#End Region
    ''' <summary>
    ''' Habilita o deshabilita los selectores de fecha dependiendo de los checked en el bloqueo de usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_BLOQUEADOCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SEGUSU_BLOQUEADOCheckBox.CheckedChanged
        If Me.SEGUSU_BLOQUEADOCheckBox.Checked = True Then
            Me.SEGUSU_FECHABLODateTimePicker.Enabled = True
            Me.SEGUSU_FECHAFINDateTimePicker.Enabled = True
        Else
            Me.SEGUSU_FECHABLODateTimePicker.Enabled = False
            Me.SEGUSU_FECHAFINDateTimePicker.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Habilita el lado general y deshabilita el detalle
    ''' </summary>
    Private Sub HabilitaIzquierdo()
        Me.gbDetalle.Enabled = False
        Me.ToolStripDetalle.Enabled = False
        Me.gbGeneral.Enabled = True
        Me.ToolStripGeneral.Enabled = True
        Me.SEGUSU_FECHABLODateTimePicker.Value = Now
        Me.SEGUSU_FECHAFINDateTimePicker.Value = Now
    End Sub
    ''' <summary>
    ''' Habilita el lado detalle y deshabilita el general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.gbDetalle.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.tsbContraseña.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvUsuarios.Focus()
    End Sub
    ''' <summary>
    ''' Valida que el username no haya sido usado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SEGUSU_USERNAMETextBox_Leave(sender As Object, e As EventArgs) Handles SEGUSU_USERNAMETextBox.Leave
        If Accion.Accion = 1 Then
            If RevisaUsername() = False Then
                Me.ErrorProvider1.SetError(Me.SEGUSU_USERNAMETextBox, "Este nombre de usuario ya ha sido usado," & Environment.NewLine & "utilice otro")
            End If
        End If
    End Sub
    ''' <summary>
    ''' Sale de la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
End Class
