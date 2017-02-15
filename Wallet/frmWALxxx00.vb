Public Class frmWALxxx00
    Dim Accion As New Action
    'Dim Registro As dsCMADET.CompañíasTablasRow
    'Dim taDAR As New dsCMADETTableAdapters.CMADARTableAdapter
    'Dim dtDAR As New dsCMADET.CMADARDataTable
    'Dim filaDAR As dsCMADET.CMADARRow
    'Dim taDAR2 As New dsCMADETTableAdapters.CMADARTableAdapter
    'Dim dtDAR2 As New dsCMADET.CMADARDataTable()

    'Dim filaDAR2 As dsCMADET.CMADARRow
    Dim CodigoDAR As Long = 0
    Private Sub frmCMADET00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CompañíasTablas1TableAdapter.Fill(Me.DsCMADET.CompañíasTablas1)
        'Me.CMATCATableAdapter.Fill(Me.DsCMADET.CMATCA)
        'Me.ColumnasTableAdapter.FillByTabla(Me.DsCMADET.Columnas, "")
        'Me.CMACOLTableAdapter.FillByDefinicion(Me.DsCMADET.CMACOL, 0)
        'Me.CompañíasTablasTableAdapter.FillByCompañia(Me.DsCMADET.CompañíasTablas, 0)
        'Me.HOLDING_EMPRESASTableAdapter.FillByCombo(Me.DsCMATAB.HOLDING_EMPRESAS)
        'Me.CMAENCTableAdapter.FillByCombo(Me.DsCMATAB.CMAENC)
        'Me.CMATACTableAdapter.FillByCombo(Me.DsCMATAB.CMATAC)
        Me.cbFormatos.SelectedIndex = 0
        Me.cbTipos.SelectedIndex = 0
        Me.SplitContainer1.Panel2.Enabled = False
        'CMATASTableAdapter.FillByTAC_CODIGO(Me.DsCMADET.CMATAS, 0)
        tsbModificar.Enabled = False
        tsbEliminar.Enabled = False
        tsbImprimir.Enabled = False

        ' Cargar Botones de grilla


    End Sub


    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        Agregar()
    End Sub
    Private Sub Agregar()
        ' Se agregan registros
        Me.SplitContainer1.Panel1.Enabled = False
        Me.SplitContainer1.Panel2.Enabled = True
        tsbAceptar.ToolTipText = "Aceptar Creación del Registro"
        tsbRechazar.ToolTipText = "Rechazar la Creación del registro"
        GroupBox2.Text = "Creación de Tabla"
        tbNombre.Text = ""
        cbTipos.SelectedIndex = 0
        cbFormatos.Enabled = False
        cbFormatos.SelectedIndex = 0
        cbEncodings.SelectedIndex = 0
        chbTab.Checked = False
        chbTab.Enabled = False
        tbSeparador.Text = ""
        tbSeparador.Enabled = False
        cbTablas.Focus()
        cbEncodings.Enabled = False
        Accion.Accion = 1
        'filaDAR2 = dtDAR2.NewCMADARRow
        'dtDAR2.AddCMADARRow(filaDAR2)
        'taDAR.Update(dtDAR2)
        'CodigoDAR = filaDAR2.DAR_CODIGO
        'dgvDetalles.Refresh()
        'Registro = Me.DsCMADET.CompañíasTablas.NewCompañíasTablasRow
        'Me.DsCMADET.CompañíasTablas.AddCompañíasTablasRow(Registro)
        Me.CompañíasTablasBindingSource.MoveLast()
    End Sub


    Private Sub tsbAceptar_Click(sender As Object, e As EventArgs) Handles tsbAceptar.Click
        ' Aceptar el proceso seleccionado
        ' Siempre que se llame desde un boton de una ToolStrip se debe ejecutar me.Validate()
        Me.Validate()
        If Validacion() Then
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.SplitterDistance = 290
            Select Case Accion.Accion
                Case 1   ' Agregar
                    '    With Registro
                    '        .DAR_FECHACRE = Now
                    '        .DAR_FECHAMOD = Now
                    '        .ID_USER_CREADOR = Usuario.Codigo
                    '        .ID_USER_MODIFICADOR = Usuario.Codigo
                    '    End With
                    '    Me.CMATACBindingSource.EndEdit()
                    '    Me.CMATACTableAdapter.Update(Me.DsCMATAB.CMATAC)
                    '    Me.CMACOLBindingSource.EndEdit()
                    '    Me.CMACOLTableAdapter.Update(Me.DsCMADET.CMACOL)
                    '    GroupBox2.Text = "Detalle"
                    '    Me.SplitContainer1.Panel2.Enabled = False
                    '    dgvDetalles.EndEdit()
                    '    filaDAR2.DAR_FECHACRE = Now
                    '    filaDAR2.ID_USER_CREADOR = Usuario.Codigo
                    '    filaDAR2.DAR_FECHAMOD = Now
                    '    filaDAR2.ID_USER_MODIFICADOR = Usuario.Codigo
                    '    filaDAR2.DAR_NOMBRE = tbNombre.Text
                    '    filaDAR2.DAR_SEPARADOR = tbSeparador.Text
                    '    filaDAR2.DAR_TABULADOR = chbTab.Checked
                    '    If Not cbEncodings.SelectedValue = Nothing Then
                    '        filaDAR2.ENC_CODIGO = cbEncodings.SelectedValue
                    '    End If
                    '    filaDAR2.FORMATO_TABLA = cbFormatos.SelectedIndex
                    '    filaDAR2.TAC_CODIGO = cbTablas.SelectedValue
                    '    filaDAR2.TIPO_DE_TABLA = cbTipos.SelectedIndex
                    '    filaDAR2.ID_EMPRESAS = cbCompañia.SelectedValue
                    '    taDAR2.Update(dtDAR2)
                    '    Me.CompañíasTablasTableAdapter.FillByCompañia(Me.DsCMADET.CompañíasTablas, cbCompañias.SelectedValue)
                    '    Accion.Accion = 0


                    'Case 2   ' Modificar
                    '    filaDAR.DAR_FECHAMOD = Now
                    '    filaDAR.ID_USER_MODIFICADOR = Usuario.Codigo
                    '    filaDAR.DAR_NOMBRE = tbNombre.Text
                    '    filaDAR.DAR_SEPARADOR = tbSeparador.Text
                    '    filaDAR.DAR_TABULADOR = chbTab.Checked
                    '    filaDAR.ENC_CODIGO = cbEncodings.SelectedValue
                    '    filaDAR.FORMATO_TABLA = cbFormatos.SelectedIndex
                    '    filaDAR.TAC_CODIGO = cbTablas.SelectedValue
                    '    filaDAR.TIPO_DE_TABLA = cbTipos.SelectedIndex
                    '    taDAR.Update(dtDAR)
                    '    dgvDetalles.EndEdit()
                    '    Me.CMACOLBindingSource.EndEdit()
                    '    Me.CMACOLTableAdapter.Update(DsCMADET.CMACOL)
                    '    GroupBox2.Text = "Detalle"
                    '    Me.SplitContainer1.Panel2.Enabled = False
                    '    Me.CompañíasTablasTableAdapter.FillByCompañia(Me.DsCMADET.CompañíasTablas, cbCompañias.SelectedValue)

                    '    Accion.Accion = 0

                    'Case 3   ' Eliminar
                    '    Borrar = 0
                    '    Dim confirma As New frmCMADET01
                    '    confirma.ShowDialog()
                    '    If Borrar = 1 Then
                    '        Dim taBorrado As New dsCMADETTableAdapters.QueriesTableAdapter
                    '        For Each Fila As DataGridViewRow In dgvDetalles.Rows
                    '            taBorrado.DeleteQueryCOL_CODIGO(Fila.Cells(0).Value)
                    '        Next

                    '        Dim REGISTRO As DataRowView = Me.CompañíasTablasBindingSource.Current
                    '        CodigoDAR = REGISTRO.Item("DAR_CODIGO")
                    '        taBorrado.DeleteQueryDAR_CODIGO(CodigoDAR)
                    '    End If
                    '    GroupBox2.Enabled = True
                    '    Me.SplitContainer1.Panel2.Enabled = False
                    '    'cbCompañias.SelectedValue = 0
                    '    Me.CompañíasTablasTableAdapter.FillByCompañia(Me.DsCMADET.CompañíasTablas, cbCompañias.SelectedValue)

                    Accion.Accion = 0
            End Select
            Me.SplitContainer1.Panel1.Enabled = True

        End If
    End Sub
    Private Function Validacion() As Boolean
        ' Encabezado
        Dim errores As Integer = 0
        Me.ErrorProvider1.Clear()
        If Accion.Accion = 3 Then
            Return True
        Else

            If cbCompañia.SelectedIndex = 0 Then
                ErrorProvider1.SetError(cbCompañia, "Campo Obligatorio")
                errores = 1
            End If
            If cbTablas.SelectedIndex = 0 Then
                ErrorProvider1.SetError(cbTablas, "Campo Obligatorio")
                errores = 2
            End If
            If cbTipos.SelectedIndex = 0 Then
                ErrorProvider1.SetError(cbTipos, "Campo Obligatorio")
                errores = 3
            End If
            If cbFormatos.SelectedIndex = 2 And chbTab.Checked = False And tbSeparador.Text = "" Then
                ErrorProvider1.SetError(cbEncodings, "Debe seleccionar un separador")
                errores = 4
            End If
            If tbNombre.Text = "" Then
                ErrorProvider1.SetError(tbNombre, "Campo Obligatorio")
                errores = 5
            End If
            If cbTipos.Text = "Texto Plano" And cbEncodings.SelectedValue = Nothing Then
                ErrorProvider1.SetError(cbEncodings, "Campo Obligatorio")
                errores = 6
            End If
            ' detalle
            Dim ErroresDetalle As String = ""
            For i = 0 To dgvDetalles.RowCount - 2

                ' Número de secuencia
                If Me.dgvDetalles.Item(3, i).Value Is Nothing Then
                    ErroresDetalle = ErroresDetalle + "fila" & (i + 1).ToString & ": secuencia es obligatoria." & vbCrLf
                End If
                If IsDBNull(dgvDetalles.Item(4, i).Value) Then
                    ErroresDetalle = ErroresDetalle + "fila" & (i + 1).ToString & ": Descripción es obligatoria." & vbCrLf
                End If
                If IsDBNull(dgvDetalles.Item(5, i).Value) And (cbTipos.Text = "Excel" Or cbTipos.Text = "Base de Datos") Then
                    ErroresDetalle = ErroresDetalle + "fila" & (i + 1).ToString & ": Nombre es obligatoria para Excel y Base de Datos." & vbCrLf
                End If
                If (dgvDetalles.Item(6, i).Value.ToString = "" Or dgvDetalles.Item(7, i).FormattedValue.ToString = "" Or dgvDetalles.Item(8, i).FormattedValue.ToString = "") And (cbFormatos.Text = "Posición Fija") Then
                    ErroresDetalle = ErroresDetalle + "fila" & (i + 1).ToString & ": Ini; Fin y Larg es obligatoria para Excel y Base de Datos." & vbCrLf
                End If
            Next
            If ErroresDetalle <> "" Then
                ErrorProvider1.SetError(dgvDetalles, ErroresDetalle)
                errores = 99
            End If
            If errores = 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub dgvTablas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTablas.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
        If dgvTablas.CurrentRow.Cells(1).Value = "" Then
            'dgvTablas.CurrentRow.Cells(1).Value = filaDAR.DAR_CODIGO
        End If
    End Sub

    Private Sub dgvTablas_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvTablas.KeyUp
        ' detectar teclas presionadas
        e.SuppressKeyPress = True
        Select Case e.KeyCode
            Case Keys.Insert
                Agregar()
            Case Keys.Delete
                Eliminar()
            Case Keys.Enter
                Modificar()
        End Select
    End Sub
    Private Sub tsbModificar_Click(sender As Object, e As EventArgs) Handles tsbModificar.Click
        Modificar()
    End Sub
    Private Sub Modificar()
        ' Se Modifican registros
        Me.SplitContainer1.Panel1.Enabled = False
        Me.SplitContainer1.Panel2.Enabled = True
        tsbAceptar.ToolTipText = "Aceptar Modificación del Registro"
        tsbRechazar.ToolTipText = "Rechazar la Modificación del registro"
        GroupBox2.Text = "Modificación de Tabla"
        'CMATASTableAdapter.FillByTAC_CODIGO(Me.DsCMADET.CMATAS, cbTablas.SelectedValue)
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.SplitterDistance = 100
        Accion.Accion = 2
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        Eliminar()
    End Sub
    Private Sub Eliminar()
        ' Se Eliminan registros
        Me.SplitContainer1.Panel1.Enabled = False
        Me.SplitContainer1.Panel2.Enabled = True
        tsbAceptar.ToolTipText = "Aceptar Eliminación de los Registro"
        tsbRechazar.ToolTipText = "Rechazar la Eliminación de los Registros"
        GroupBox2.Text = "Eliminación de Tabla"
        'CMATASTableAdapter.FillByTAC_CODIGO(Me.DsCMADET.CMATAS, cbTablas.SelectedValue)
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.SplitterDistance = 100
        GroupBox2.Enabled = False
        Accion.Accion = 3
        Me.ErrorProvider1.Clear()
    End Sub
    Private Sub tsbRechazar_Click(sender As Object, e As EventArgs) Handles tsbRechazar.Click
        GroupBox2.Text = "Detalle"
        Me.CMATACBindingSource.CancelEdit()
        Me.SplitContainer1.Panel1.Enabled = True
        Me.SplitContainer1.Panel2.Enabled = False
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.SplitterDistance = 290
        Accion.Accion = 0
        ' Refrescar
        'Me.CompañíasTablasTableAdapter.FillByCompañia(Me.DsCMADET.CompañíasTablas, cbCompañias.SelectedValue)

    End Sub

    Private Sub tsbReferescar_Click(sender As Object, e As EventArgs) Handles tsbReferescar.Click
        'Me.CompañíasTablasTableAdapter.FillByCompañia(Me.DsCMADET.CompañíasTablas, cbCompañias.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        'Me.CMATACTableAdapter.FillByConsulta(Me.DsCMATAB.CMATAC, Me.tbConsulta.Text)
        Me.tbConsulta.Text = ""
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        'Dim InfoTag As New Informes
        Me.Cursor = Cursors.WaitCursor
        'InfoTag.Reporte = "reportes\informe03.rpt"
        'Dim Fila As DataGridViewRow
        'Fila = dgvTablas.CurrentRow
        'InfoTag.Numero = 3
        'InfoTag.Argumento1lng = Fila.Cells(0).Value
        'Dim Informe As New frmCMAINF00
        'Informe.Tag = InfoTag
        'Informe.MdiParent = Me.MdiParent
        'Informe.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cbCompañias_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCompañias.SelectedValueChanged
        'Me.CompañíasTablasTableAdapter.FillByCompañia(Me.DsCMADET.CompañíasTablas, cbCompañias.SelectedValue)
    End Sub



    Private Sub dgvTablas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTablas.SelectionChanged
        Dim Fila As DataGridViewRow
        Fila = dgvTablas.CurrentRow
        If Not Fila Is Nothing AndAlso Fila.Cells(0).Value > -1 Then
            Dim Detalle As Long = Fila.Cells(0).Value
            'taDAR.FillByCodigo(dtDAR, Detalle)
            'filaDAR = dtDAR.Item(0)
            'cbTipos.SelectedIndex = filaDAR.TIPO_DE_TABLA
            'cbFormatos.SelectedIndex = filaDAR.FORMATO_TABLA
            'If Not filaDAR.IsDAR_TABULADORNull Then
            '    chbTab.Checked = filaDAR.DAR_TABULADOR
            'End If
            'If Not filaDAR.IsDAR_SEPARADORNull Then
            '    tbSeparador.Text = filaDAR.DAR_SEPARADOR
            'End If
            'Me.CMACOLTableAdapter.FillByDefinicion(Me.DsCMADET.CMACOL, Detalle)
            tsbModificar.Enabled = True
            tsbEliminar.Enabled = True
            tsbImprimir.Enabled = True
        Else
            tsbModificar.Enabled = False
            tsbEliminar.Enabled = False
            tsbImprimir.Enabled = False
            cbTipos.SelectedIndex = 0
            cbFormatos.SelectedIndex = 0
            chbTab.Checked = False
            tbSeparador.Text = ""
            'Me.CMACOLTableAdapter.FillByDefinicion(Me.DsCMADET.CMACOL, 0)
        End If

    End Sub

    Private Sub cbTablas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTablas.SelectedValueChanged
        If cbTablas.SelectedValue <> Nothing Then

            'CMATASTableAdapter.FillByTAC_CODIGO(Me.DsCMADET.CMATAS, cbTablas.SelectedValue)
        End If

    End Sub

    Private Sub dgvDetalles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 15 Then
                ' Se hizo click en el boton de limpiar Tablas
                Dim columnaValor As DataGridViewComboBoxCell = dgvDetalles.Item(14, e.RowIndex)
                columnaValor.Value = Nothing
            End If
            If TypeOf dgvDetalles.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso Not e.RowIndex = -1 And e.ColumnIndex = 16 Then
                dgvDetalles.EndEdit()
                Me.CMACOLBindingSource.EndEdit()
                'Me.CMACOLTableAdapter.Update(DsCMADET.CMACOL)

                'Dim DecoDif As New frmCMADET02
                'Dim tagdec As TagDeco
                'tagdec.CodColumna = dgvDetalles.Item(0, e.RowIndex).Value
                'tagdec.NombreColumna = dgvDetalles.Item(4, e.RowIndex).Value
                'DecoDif.Tag = tagdec
                'DecoDif.ShowDialog()

            End If
            If TypeOf dgvDetalles.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn AndAlso Not e.RowIndex = -1 And e.ColumnIndex = 17 Then
                If dgvDetalles.Rows(e.RowIndex).Cells(17).EditedFormattedValue = True Then
                    dgvDetalles.Item(e.ColumnIndex + 1, e.RowIndex).ReadOnly = False
                Else
                    dgvDetalles.Item(e.ColumnIndex + 1, e.RowIndex).Value = Nothing
                    dgvDetalles.Item(e.ColumnIndex + 1, e.RowIndex).ReadOnly = True
                End If
            End If

        End If

    End Sub

    Private Sub dgvDetalles_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellValueChanged
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 14 Then
                ' se modifico el combo de tablas
                ' determinar nombre tabla

                Dim columnaValor As DataGridViewComboBoxCell = dgvDetalles.Item(14, e.RowIndex)
                Dim Tabla As String = columnaValor.FormattedValue.ToString
                ' Genera una nueva instancia para el DataTable
                Dim Columna As DataGridViewComboBoxCell = dgvDetalles.Item(15, e.RowIndex)
                'Dim taCol As New dsCMADETTableAdapters.ColumnasTableAdapter
                'Dim dtCol As New dsCMADET.ColumnasDataTable
                'taCol.FillByTabla(dtCol, Tabla)
                '' Le asigna el DataTable a la celda
                'Columna.DataSource = dtCol
                Validate()
                dgvDetalles.Item(15, e.RowIndex).Value = Nothing
            End If

        End If

    End Sub

    Private Sub dgvDetalles_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvDetalles.CurrentCellChanged
    End Sub

    Private Sub dgvDetalles_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvDetalles.DataError
        e.Cancel = False
    End Sub


    Private Sub dgvDetalles_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvDetalles.RowsAdded
        If e.RowIndex >= 0 Then
            ' se modifico el combo de tablas
            ' determinar nombre tabla
            Dim columnaValor As DataGridViewComboBoxCell = dgvDetalles.Item(14, e.RowIndex)
            Dim Tabla As String = columnaValor.FormattedValue.ToString
            If Not Tabla = "" Then
                ' Genera una nueva instancia para el DataTable
                Dim Columna As DataGridViewComboBoxCell = dgvDetalles.Item(15, e.RowIndex)
                'Dim taCol As New dsCMADETTableAdapters.ColumnasTableAdapter
                'Dim dtCol As New dsCMADET.ColumnasDataTable
                'taCol.FillByTabla(dtCol, Tabla)
                '' Le asigna el DataTable a la celda
                'Columna.DataSource = dtCol
            End If
            'If e.RowIndex >= 0 Then
            '    dgvDetalles.Rows(e.RowIndex ).Cells(1).Value = CodigoDAR
            'End If

        End If

    End Sub

    Private Sub Boton1_Disposed(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbFormatos_TextChanged(sender As Object, e As EventArgs) Handles cbFormatos.TextChanged
        Select Case cbFormatos.Text
            Case "Posición Fija"
                chbTab.Checked = False
                chbTab.Enabled = False
                tbSeparador.Text = ""
                tbSeparador.Enabled = False
            Case "Separador de Campo"
                chbTab.Checked = False
                chbTab.Enabled = True
                tbSeparador.Text = ""
                tbSeparador.Enabled = True
            Case Else
        End Select
    End Sub

    Private Sub cbTipos_TextChanged(sender As Object, e As EventArgs) Handles cbTipos.TextChanged
        Select Case cbTipos.Text
            Case "Excel", "Base de Datos"
                cbFormatos.Text = "<Formatos>"
                cbFormatos.Enabled = False
                chbTab.Checked = False
                chbTab.Enabled = False
                tbSeparador.Text = ""
                tbSeparador.Enabled = False
                cbEncodings.Enabled = False

            Case Else
                cbFormatos.Enabled = True
                chbTab.Checked = False
                tbSeparador.Text = ""
                tbSeparador.Enabled = True
                cbEncodings.Enabled = True
                cbFormatos.Text = "<Formatos>"



        End Select
    End Sub

    Private Sub frmCMADET00_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        SplitContainer1.SplitterDistance = 290
        GroupBox1.Width = SplitContainer1.Panel1.Width - 2 * GroupBox1.Left
        dgvTablas.Width = GroupBox1.Width - 2 * dgvTablas.Left
        GroupBox5.Width = GroupBox1.Width - 2 * GroupBox5.Left
        cbCompañias.Width = GroupBox5.Width - 2 * cbCompañias.Left
        tbConsulta.Width = GroupBox1.Width - 3 * tbConsulta.Left - btBuscar.Width
        btBuscar.Left = tbConsulta.Width + 2 * tbConsulta.Left
    End Sub

    Private Sub dgvDetalles_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvDetalles.CellPainting
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            If dgvDetalles.Columns(e.ColumnIndex).Name = "btDecod" AndAlso e.RowIndex >= 0 Then
                e.Paint(e.CellBounds, DataGridViewPaintParts.All)
                Dim bc As DataGridViewButtonCell = TryCast(dgvDetalles(0, e.RowIndex), DataGridViewButtonCell)
                'Select Case bc.Tag
                '    Case "H"
                '        e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
                '    Case "E"
                '        e.Graphics.DrawImage(My.Resources.Add, CInt((e.CellBounds.Width / 2) - (My.Resources.Add.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Add.Height / 2)) + e.CellBounds.Y)
                '    Case "D"
                '        e.Graphics.DrawImage(My.Resources.Accept, CInt((e.CellBounds.Width / 2) - (My.Resources.Accept.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Accept.Height / 2)) + e.CellBounds.Y)
                'End Select
                'e.Graphics.DrawImage(My.Resources.Label, CInt((e.CellBounds.Width / 2) - (My.Resources.Label.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Label.Height / 2)) + e.CellBounds.Y)
                e.Handled = True
                ' cOLOCA cLAVE A CADA LINEA
                If Accion.Accion = 1 Then
                    dgvDetalles.Item(1, e.RowIndex).Value = CodigoDAR
                    e.Handled = True

                Else
                    Try
                        Dim REGISTRO As DataRowView = Me.CompañíasTablasBindingSource.Current

                        dgvDetalles.Item(1, e.RowIndex).Value = REGISTRO.Item("DAR_CODIGO")
                        e.Handled = True

                    Catch ex As Exception

                    End Try

                End If
            End If
        End If

    End Sub





    Private Sub dgvDetalles_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvDetalles.UserDeletingRow
        ' Se eliminan las posibles decdificaciones asignadas a la columna que se describe
        'Dim taBorrado As New dsCMADETTableAdapters.QueriesTableAdapter
        Try
            'taBorrado.DeleteQueryCOL_CODIGO(e.Row.Cells(0).Value)
        Catch ex As Exception

        End Try

    End Sub

End Class