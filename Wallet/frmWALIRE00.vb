Public Class frmWALIRE00
    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click


        Dim taDetPla As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
        Dim dtDetPla As New dsWALPLA.DetallePlanillaDataTable
        Dim filaDetPla As dsWALPLA.DetallePlanillaRow
        taDetPla.FillByPlanillaCuenta(dtDetPla, Planilla, Glo_Cuenta)
        filaDetPla = dtDetPla.Item(0)
        'DE1.Trae_Planilla Planilla        
        Dim taTraePla As New dsWALPLATableAdapters.TESPLATableAdapter
        Dim dtTraePla As New dsWALPLA.TESPLADataTable
        Dim filaTraePla As dsWALPLA.TESPLARow
        taTraePla.FillByPlanilla(dtTraePla, Planilla)
        filaTraePla = dtTraePla.Item(0)
        'DE1.rsDetalle_Operaciones.AddNew
        Dim taDetOpe As New dsWALPLATableAdapters.TESDOPTableAdapter
        Dim dtDetOpe As New dsWALPLA.TESDOPDataTable
        Dim filaDetOpe As dsWALPLA.TESDOPRow

        filaDetOpe = dtDetOpe.NewTESDOPRow
        Nuevo = True


        filaDetOpe.DPL_CODIGO = filaDetPla.DPL_CODIGO
        ' MODIFICACIÓN POR ERROR EL BLOQUEO
        dtDetPla.Dispose
        Select Case Glo_Ingreso
            Case 1      ' Rescates
                filaDetOpe.COL_CODIGO = 3
                filaDetOpe.DOP_TIPO = "D"
            Case 2      ' Cheques devueltos
                filaDetOpe.COL_CODIGO = 5
                filaDetOpe.DOP_TIPO = "D"
            Case 3      ' Aportes
                filaDetOpe.COL_CODIGO = 6
                filaDetOpe.DOP_TIPO = "D"
            Case 4      ' Otros Ingresoso
                filaDetOpe.COL_CODIGO = 7
                filaDetOpe.DOP_TIPO = "D"
            Case 5      ' Pagos con Cheques
                filaDetOpe.COL_CODIGO = 8
                filaDetOpe.DOP_TIPO = "D"
            Case 6      ' Pagos con cargos
                filaDetOpe.COL_CODIGO = 10
                filaDetOpe.DOP_TIPO = "D"
            Case 7      ' Transferencias positivas
                filaDetOpe.COL_CODIGO = 11
                filaDetOpe.DOP_TIPO = "D"
            Case 8      ' Transferencias negativas
                filaDetOpe.COL_CODIGO = 12
                filaDetOpe.DOP_TIPO = "D"
            Case 9      ' Recaudaciones
                filaDetOpe.COL_CODIGO = 4
                If Me.ckbPermanente.Checked = True Then
                    filaDetOpe.DOP_TIPO = "M"
                Else
                    filaDetOpe.DOP_TIPO = "D"
                End If
            Case 10      ' Cheques en Cartera
                filaDetOpe.COL_CODIGO = 9
                filaDetOpe.DOP_TIPO = "D"
        End Select
        If Me.ckbMillones.Checked = True Then
            filaDetOpe.DOP_MONTO = CDbl(tbMonto.Text) * 1000000
        Else
            filaDetOpe.DOP_MONTO = CDbl(tbMonto.Text)
        End If
        If tbGlosa.Text.Length > 50 Then
            tbGlosa.Text = tbGlosa.Text.Substring(0, 50)
        End If
                filaDetOpe.DOP_GLOSAADIC = Me.tbGlosa.Text
        filaDetOpe.DOP_AUDITORIA = Auditoria("")
        dtDetOpe.AddTESDOPRow(filaDetOpe)
        taDetOpe.Update(dtDetOpe)
        Select Case Glo_Ingreso
            Case 1      ' Rescates
                TotalporColumna(Planilla, 3)
            Case 2      ' Cheques devueltos
                TotalporColumna(Planilla, 5)
            Case 3      ' Aportes
                TotalporColumna(Planilla, 6)
            Case 4      ' Otros Ingresos
                TotalporColumna(Planilla, 7)
            Case 5      ' Pagos con Cheque
                TotalporColumna(Planilla, 8)
            Case 6      ' Pagos con Cargos
                TotalporColumna(Planilla, 10)
            Case 7      ' Transferencias positivas
                TotalporColumna(Planilla, 11)
            Case 8      ' Transferencias negativas
                TotalporColumna(Planilla, 12)
            Case 9      ' Recaudaciones
                TotalporColumna(Planilla, 4)
            Case 10      ' Cheques en Cartera
                TotalporColumna(Planilla, 9)
        End Select
        If tsbOtro.Checked = True Then
            Limpiar
            tbMonto.Focus()
            Exit Sub
        Else
            Me.Close()
        End If

    End Sub
    Private Sub Limpiar()
        Me.tbMonto.Text = ""
        Me.tbGlosa.Text = ""
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub frmWALIRE00_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ckbPermanente.Visible = False
        Me.ckbMillones.Checked = True
        Select Case Glo_Ingreso
            Case 1
                Me.Text = "Ingreso de Rescates - " & Glo_Banco
            Case 2
                Me.Text = "Ingreso de Cheques Devueltos - " & Glo_Banco
            Case 3
                Me.Text = "Ingreso de Aportes - " & Glo_Banco
            Case 4
                Me.Text = "Ingreso de Otros Ingresoso - " & Glo_Banco
            Case 5
                Me.Text = "Ingreso de Pagos con Cheque - " & Glo_Banco
            Case 6
                Me.Text = "Ingreso de Pagos con Cargo - " & Glo_Banco
            Case 7
                Me.Text = "Ingreso de Transferencias Positivas - " & Glo_Banco
            Case 8
                Me.Text = "Ingreso de Transferencias Negativas - " & Glo_Banco
            Case 9
                Me.Text = "Ingreso de Recaudaciones - " & Glo_Banco
                Me.ckbPermanente.Visible = True
                Me.ckbPermanente.Checked = True
            Case 10
                Me.Text = "Ingreso de Cheques en Cartera - " & Glo_Banco
        End Select
    End Sub
    'Private Sub tbMOnto_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMonto.KeyDown
    '    ' Inicializa indicador
    '    Dim Numerico As Boolean = True
    '    Me.ErrorProvider.Clear()

    '    ' determina que tecla se presiona
    '    If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
    '        ' determina si la tecla es del pad numérico
    '        If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
    '            ' determina se la tecla BackSpace se presionó
    '            If e.KeyCode <> Keys.Back Then
    '                If e.KeyCode <> Keys.OemMinus Then
    '                    If e.KeyCode <> Keys.Subtract Then
    '                        If e.KeyCode <> Keys.OemMinus Then
    '                            If e.KeyCode <> Keys.Subtract Then
    '                                If e.KeyCode <> Keys.Tab Then
    '                                    If e.KeyCode <> Keys.Delete Then
    '                                        If e.KeyCode <> Keys.Oemcomma Then
    '                                            If e.KeyCode <> Keys.OemPeriod Then
    '                                                If e.KeyCode <> Keys.Decimal Then
    '                                                    ' determina se la tecla delete se presionó
    '                                                    If e.KeyCode <> Keys.Delete Then
    '                                                        ' Se indica que es falso
    '                                                        Numerico = False
    '                                                    End If
    '                                                End If
    '                                            End If
    '                                        End If
    '                                    End If
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    '    If e.KeyCode = Keys.OemPeriod Or e.KeyCode = Keys.Decimal Then
    '        e.SuppressKeyPress = True
    '        tbMonto.Text = tbMonto.Text & ","
    '        tbMonto.SelectionStart = tbMonto.TextLength
    '    End If

    '    'si se presiona mayúsculas no es numérico
    '    If Control.ModifierKeys = Keys.Shift Then
    '        Numerico = False
    '    End If
    '    If Numerico = False Then
    '        e.SuppressKeyPress = True
    '        Me.ErrorProvider.SetError(Me.tbMonto, "Este campo debe ser numérico")
    '    End If
    'End Sub

    Private Sub tbMonto_LostFocus(sender As Object, e As EventArgs) Handles tbMonto.LostFocus
        Me.ErrorProvider.Clear()
        Try
            Dim Monto As Double
            If tbMonto.Text <> "" Then
                Monto = CDbl(tbMonto.Text)
                If ckbMillones.Checked = True Then
                    tbMonto.Text = FormatNumber(Monto, 1)
                    If Monto > 999999.9 Then
                        Me.ErrorProvider.SetError(Me.tbMonto, "Este Monto del campo excede el Monto máximo permitido")
                    End If
                Else
                    tbMonto.Text = FormatNumber(Monto, 0)
                    If Monto > 999999999999 Then
                        Me.ErrorProvider.SetError(Me.tbMonto, "Este Monto del campo excede el Monto máximo permitido")
                    End If
                End If

            End If
        Catch ex As Exception
            Me.ErrorProvider.SetError(Me.tbMonto, "Este campo debe ser numérico")
            tbMonto.Text = ""
            tbMonto.Focus()
        End Try
    End Sub

    Private Sub tbMonto_GotFocus(sender As Object, e As EventArgs) Handles tbMonto.GotFocus
        If tbMonto.Text <> "" Then
            Try
                tbMonto.Text = CStr(CDbl(tbMonto.Text))
            Catch ex As Exception
                tbMonto.Text = ""
            End Try
        End If
    End Sub

    Private Sub ckbMillones_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMillones.CheckedChanged
        If tbMonto.Text <> "" Then

            If ckbMillones.Checked = True Then
                tbMonto.Text = CDbl(tbMonto.Text) / 1000000
            Else
                If CDbl(tbMonto.Text) > 99999 Then
                    ckbMillones.Checked = True
                    MsgBox("Monto muy alto para convertirlo en pesos", MsgBoxStyle.Information, "Mensajes de Wallet")
                    Exit Sub
                Else
                    tbMonto.Text = CDbl(tbMonto.Text) * 1000000
                End If
            End If
            tbMonto.Focus()
        End If
    End Sub

    Private Sub tbMonto_TextChanged(sender As Object, e As EventArgs) Handles tbMonto.TextChanged

    End Sub
End Class