Imports System.Text

Public Class frmWALGMO00
    Dim taCTE As New dsWALPLATableAdapters.Trae_CuentaTableAdapter
    Dim dtCTE As New dsWALPLA.Trae_CuentaDataTable
    Dim filaCTE As dsWALPLA.Trae_CuentaRow
    Dim taCTE2 As New dsWALPLATableAdapters.TESCTETableAdapter
    Dim dtCTE2 As New dsWALPLA.TESCTEDataTable
    Dim filaCTE2 As dsWALPLA.TESCTERow
    Dim taPAR As New dsWALPLATableAdapters.TESPARTableAdapter
    Dim dtPAR As New dsWALPLA.TESPARDataTable
    Dim FilaPAR As dsWALPLA.TESPARRow
    Dim taCLC As New dsWALPLATableAdapters.TESCLCTableAdapter
    Dim dtCLC As New dsWALPLA.TESCLCDataTable
    Dim FilaCLC As dsWALPLA.TESCLCRow
    Dim taDCL As New dsWALPLATableAdapters.TESDCLTableAdapter
    Dim dtDCL As New dsWALPLA.TESDCLDataTable
    Dim FilaDCL As dsWALPLA.TESDCLRow
    Dim taDPLA As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
    Dim dtDPLA As New dsWALPLA.DetallePlanillaDataTable
    Dim filaDPLA As dsWALPLA.DetallePlanillaRow
    Dim consulta As New dsWALPLATableAdapters.QueriesTableAdapter
    Dim Total As Double
    Dim taREL As New dsWALPLATableAdapters.RELATION_1924TableAdapter
    Dim dtREL As New dsWALPLA.RELATION_1924DataTable
    Dim FilaREL As dsWALPLA.RELATION_1924Row
    Dim SAPFunctions1 As Object = CreateObject("SAP.Functions")
    Dim SAPFunctions2 As Object = CreateObject("SAP.Functions")
    Dim objSAPLogonCtrl As Object
    Dim MyFunc2 As Object ' Resultado de la llamada a SAP.



    Dim Mensaje As String
    Dim Respuesta As String
    Dim ErrorMonto As Integer
    Dim posicion As Integer
    Dim Suma As Integer = 0
    Dim Disponible() As Double
    Dim Pla As Long
    Dim r As Integer

    Dim R3 As Object

    Dim MyFunc As Object
    ' Resultado de la llamada a SAP.
    Dim Resultado As Boolean
    ' Tablas a ser recibidas por la funcion
    Dim TablasRecibidas As Object
    ' Tablas a ser enviadas a la funcion
    Dim TablasEnviadas As Object
    Dim Pago9 As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cbEntidad.DropDownWidth = 300

    End Sub

    Private Sub frmWALGMO00_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TESINFTableAdapter.Fill(Me.DsWALPLA.TESINF)
        Me.TESENTTableAdapter.Fill(Me.DsWALPLA.TESENT)
        Dim datos As Acciones
        datos = Me.Tag
        Me.TESDPLTableAdapter.FillByPlanilla(Me.DsWALPLA.TESDPL, datos.Planilla)

        Me.TESGLOTableAdapter.Fill(Me.DsWALPLA.TESGLO)
        Me.TESBENTableAdapter.Fill(Me.DsWALBEN.TESBEN)
        Me.TESUPATableAdapter.Fill(Me.DsWALPLA.TESUPA)
        taPAR.Fill(dtPAR)
        FilaPAR = dtPAR.Item(0)
        cbUnidadPagadora.SelectedValue = FilaPAR.PAR_UNIDADPA
        tbGlosaEditada.Text = cbGlosas.Text
        dtpVencimiento.Value = Today
        Total = consulta.TotalPorColocar(datos.Planilla)
        tbTotal.Text = Format(Total / 1000000, "M$#,##0.0")
        taPAR.Fill(dtPAR)
        FilaPAR = dtPAR.Item(0)
        parametros.Mandante = FilaPAR.PAR_MANDANTE
        Me.Top = 0
        limpiar
    End Sub

    Private Sub cbGlosas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGlosas.SelectedIndexChanged
        tbGlosaEditada.Text = cbGlosas.Text
    End Sub
    Private Sub Limpiar()
        cbEntidad.Text = ""
        cbFondo.Text = ""
        cbGlosas.Text = ""
        cbPapel.Text = ""
        cbBeneficiarios.Text = ""
        tbGlosaEditada.Text = ""
        tbNota.Text = ""
    End Sub


    Private Sub tbMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMonto.KeyDown
        ' Inicializa indicador
        Dim Numerico As Boolean = True
        Me.ErrorProvider.Clear()

        ' determina que tecla se presiona
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' determina si la tecla es del pad numérico
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' determina se la tecla BackSpace se presionó
                If e.KeyCode <> Keys.Back Then
                    If e.KeyCode <> Keys.OemMinus Then
                        If e.KeyCode <> Keys.Subtract Then
                            ' una tecla no numérica se presionó
                            If e.KeyCode <> Keys.Tab Then
                                If e.KeyCode <> Keys.Delete Then
                                    If e.KeyCode <> Keys.Oemcomma Then
                                        If e.KeyCode <> Keys.OemPeriod Then
                                            If e.KeyCode <> Keys.Decimal Then
                                                ' determina se la tecla delete se presionó
                                                If e.KeyCode <> Keys.Delete Then
                                                    ' Se indica que es falso
                                                    Numerico = False
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                    End If
                End If
        If e.KeyCode = Keys.OemPeriod Or e.KeyCode = Keys.Decimal Then
            e.SuppressKeyPress = True
            tbMonto.Text = tbMonto.Text & ","
            tbMonto.SelectionStart = tbMonto.TextLength
        End If

        'si se presiona mayúsculas no es numérico
        If Control.ModifierKeys = Keys.Shift Then
            Numerico = False
        End If
        If Numerico = False Then
            e.SuppressKeyPress = True
            Me.ErrorProvider.SetError(Me.tbMonto, "Este campo debe ser numérico")
        End If

    End Sub

    Private Sub tbMonto_GotFocus(sender As Object, e As EventArgs) Handles tbMonto.GotFocus
        If tbMonto.Text <> "" Then
            tbMonto.Text = CStr(CDbl(tbMonto.Text))
        End If

    End Sub

    Private Sub tbMonto_LostFocus(sender As Object, e As EventArgs) Handles tbMonto.LostFocus
        Me.ErrorProvider.Clear()
        Dim Monto As Double
        If tbMonto.Text <> "" Then
            Monto = CDbl(tbMonto.Text)

            If Monto > Total Then
                MsgBox("El monto a colocar es mayor que el Total disponible", vbExclamation, "Mensaje del Sistema")
            Else
                tbMonto.Text = FormatCurrency(Monto, 0)
            End If
        End If
    End Sub
    'Private Function HaceMensaje(Banco As Integer, Monto As Double, Transaccion1 As String, Transaccion2 As Long, Glosa As String, RUT As String, Unidad As Integer, Tipo As String, Adicional As String) As String
    '    Dim Men As String
    '    Dim Datos As String
    '    Dim strGlosa As String '* 301
    '    Dim strAdicional As String '* 100
    '    strGlosa = Glosa
    '    RUT = RutNumero(RUT)
    '    Datos = Format(Banco, "000") & Format(Monto, "000000000000000") & Transaccion1 & Format(Transaccion2, "0000") & strGlosa & RUT & Format(Unidad, "000") & Tipo & strAdicional
    '    Men = "TEXCB001" & Format(Len(Datos), "000000000") & Datos
    '    HaceMensaje = Men
    'End Function

    Private Sub tsbGrabar_Click(sender As Object, e As EventArgs) Handles tsbGrabar.Click
        Dim Errores As Integer
        Dim Code As Integer
        Dim Banco As Integer
        Dim Monto As Double
        Dim Tran As String
        Dim Glosa As String
        Dim RUT As String
        Dim Unidad As Integer
        Dim Tipo As String
        Dim Adicional As String
        Dim Columna As Integer
        'Dim CodGlosa As String
        Dim i As Integer
        Dim ch As Integer
        Dim ch9 As Integer
        Nuevo = True
        Pago9 = 0
        ' verificar totales iguales
        If tbTasa.Text = "" Then
            MsgBox("Tasa no puede estar en Blanco.", vbCritical, "Mensaje del Sistema")
            tbTasa.Focus()
            Exit Sub
        End If
        If tbMonto.Text = "" Then
            MsgBox("Monto no puede estar en Blanco.", vbCritical, "Mensaje del Sistema")
            tbMonto.Focus()
            Exit Sub
        End If
        If CDbl(tbMonto.Text) <> CDbl(tbCheques.Text) Then
            MsgBox("Cifras de Monto y Cheques Emitidos no cuadran.", vbCritical, "Mensaje del Sistema")
            Exit Sub
        End If
        ' Contar total de cheques
        ch = 0
        For i = 0 To dgvMontos.RowCount - 1
            If dgvMontos.Rows(i).Cells(3).FormattedValue.ToString <> "" AndAlso IsNumeric(dgvMontos.Rows(i).Cells(3).FormattedValue.ToString()) Then
                ch = ch + 1
            End If
        Next
        taREL.FillByCodGlosa(dtREL, cbGlosas.SelectedValue)
        If dtREL.Count = 0 Then
            MsgBox("Glosa definida en forma incorrecta, seleccione una por favor", vbCritical, "Mensaje del Sistema")
            Exit Sub
        End If
        FilaREL = dtREL.Item(0)
        Dim FilaGlosa As DataRowView = TESGLOBindingSource.Current()
        If rbInversion.Checked = True Then
            Columna = 14
        Else
            Columna = 8
        End If
        'Try
        '    Columna = FilaGlosa.Item("GLO_COLUMNA")
        'Catch ex As Exception
        '    Columna = 8
        'End Try
        'Me.MSFlexGrid1.Col = 2
        Suma = 9
        Errores = 0
        ch9 = 0

        If Not ConectarSAP() Then
            ' No Conecto
            MsgBox("No podemos conectarnos con SAP, informe a Soporte", MsgBoxStyle.Critical, NombreSistema)
            Exit Sub
        End If
        r = 1


        SAPFunctions1.Connection = R3
        MyFunc = SAPFunctions1.Add("ZF_PL_OPERACIONES")
        TablasEnviadas = MyFunc.Tables("ZITAB")

        ' Llamar a la funcion de SAP.


        Dim codigosDOP() As Double
        ReDim codigosDOP(100)

        For i = 0 To dgvMontos.RowCount - 1

            If dgvMontos.Rows(i).Cells(3).FormattedValue.ToString <> "" AndAlso IsNumeric(dgvMontos.Rows(i).Cells(3).FormattedValue.ToString()) Then
                Banco = dgvMontos.Rows(i).Cells(0).Value
                Monto = dgvMontos.Rows(i).Cells(3).Value
                Tran = FilaREL.TRA_CODIGO & Format(CLng(FilaREL.TR2_CODIGO), "0000")
                ch9 = ch9 + 1
                Glosa = Armar_Glosa(Me.tbGlosaEditada.Text, ch, ch9)
                RUT = Me.cbBeneficiarios.SelectedValue
                Unidad = cbUnidadPagadora.SelectedValue
                Tipo = "3"
                Adicional = ""
                Mensaje = HaceMensaje(CStr(Banco), Monto, Tran, Glosa, RUT, Unidad, Tipo, Adicional)

                codigosDOP(i) = Generacion_Detalles(Banco, Monto, Glosa, Columna)

                Respuesta = ""
                CargarTabla(Mensaje)
                r = r + 1
            End If
        Next


        ' Aqui se graba SAP
        ActivarSAP()
        If Not Resultado Then
            R3.Logoff
            Exit Sub
        End If

        R3.Logoff

        ReDim Preserve codigosDOP(i)

        If Errores = 0 Then
            '  OK
            MsgBox("Cheque generado correctamente", vbInformation, "Mensaje del Sistema")
        Else
            ' PROBLEMAS DE GRABACION
            MsgBox("Se detecto un problema al intentar grabar el Cheque." & Chr(13) & "Avise al administrador del Sistema que se detecto un código:  " & Code, vbCritical, "Mensaje del Sistema")
            Me.Close()

        End If
        Dim TipTas As String
        If Pago9 = 0 Then
            ' Grabar inversión
            If Me.rbReal.Checked Then
                TipTas = "R"
            Else
                TipTas = "N"
            End If
            ' se genera el registro CLC

            FilaCLC = dtCLC.NewTESCLCRow
            FilaCLC.ENT_CODIGO = cbEntidad.SelectedValue
            If cbFondo.Text <> "" Then
                FilaCLC.FON_CODIGO = cbFondo.SelectedValue
            Else
                FilaCLC.SetFON_CODIGONull()
            End If
            FilaCLC.INF_CODIGO = cbPapel.SelectedValue
            FilaCLC.EST_CODIGO = 1
            FilaCLC.MON_CODIGO = 905
            If TipoPlanilla = "C" Then
                FilaCLC.TFO_CODIGO = 1
            Else
                FilaCLC.TFO_CODIGO = 2
            End If
            FilaCLC.CLC_FECHAINV = FilaPAR.PAR_FECHAPRO
            FilaCLC.CLC_FECHAVEN = dtpVencimiento.Value
            FilaCLC.CLC_TASAESP = CDbl(tbTasa.Text)
            FilaCLC.CLC_TIPOTASA = TipTas
            FilaCLC.CLC_MONTOINV = CDbl(tbMonto.Text)
            FilaCLC.CLC_FECHAPRO = FilaPAR.PAR_FECHAPRO
            If TipoPlanilla = "C" Then
                FilaCLC.CLC_TIPOOPE = "C"
            Else
                FilaCLC.CLC_TIPOOPE = "F"
            End If
            FilaCLC.CLC_CUOTAINI = 0
            FilaCLC.CLC_CUOTAESP = 0
            dtCLC.AddTESCLCRow(FilaCLC)
            taCLC.Update(dtCLC)






            'Criterio = "insert into tesclc (" &
            '"ent_codigo, fon_codigo, inf_codigo, est_codigo, mon_codigo, tfo_codigo, " &
            '"clc_fechainv, clc_fechaven, clc_tasaesp, " &
            '"clc_tipotasa, clc_montoinv, clc_fechapro, " &
            '"clc_tipoope, clc_cuotaini, clc_cuotaesp) values (" &
            'Me.DataCombo5.BoundText & ", " & IIf(Me.DataCombo6.BoundText = "", "''", Me.DataCombo6.BoundText) & ", " & Me.DataCombo4.BoundText & ", " &
            '"'1', 905, " & IIf(TipoPlanilla = "C", 1, 2) & ", " &
            '"convert(datetime,'" & Format(Of Date, "dd/mm/yyyy")() & "', 103), " &
            '"convert(datetime,'" & Format(Me.DTPicker1.Value, "dd/mm/yyyy") & "', 103), " &
            'Replace(Me.MaskEdBox2.Text, ",", ".") & ", '" & TipTas & "', " & Replace(Me.MaskEdBox1.Text, ",", ".") & ", " &
            '"convert(datetime,'" & Format(Of Date, "dd/mm/yyyy")() & "', 103) "
            '    If TipoPlanilla = "C" Then
            '        Criterio = Criterio & ", 'C'"
            '    Else
            '        Criterio = Criterio & ", 'F'"
            '    End If
            '    Criterio = Criterio & ", 0"
            '    Criterio = Criterio & ", 0"
            '    Criterio = Criterio & ")"
            '    DE1.Fondo.Execute Criterio

            'recupera ultima colocación
            '    On Error Resume Next
            '    DE1.rsLee_Ultima_Colocacion.Close
            '    On Error GoTo 0
            '    DE1.Lee_Ultima_Colocacion
            'ultimaColocacion = DE1.rsLee_Ultima_Colocacion!clc_codigo
            Dim UltimaColocacion As Integer
            UltimaColocacion = FilaCLC.CLC_CODIGO

            'mensaje para validación de ingreso real, este mensaje es provisorio, para efectos
            'de puesta en marcha y depuración...
            'Dim stMiMsg As String
            'stMiMsg = "Colocación generada con N° " & CStr(ultimaColocacion)
            '    MsgBox stMiMsg, vbInformation, "Colocación Ingresada..."
            For i = 0 To codigosDOP.Count - 1
                If codigosDOP(i) > 0 Then
                    FilaDCL = dtDCL.NewTESDCLRow
                    FilaDCL.DOP_CODIGO = codigosDOP(i)
                    FilaDCL.CLC_CODIGO = UltimaColocacion
                    dtDCL.AddTESDCLRow(FilaDCL)
                    taDCL.Update(dtDCL)

                End If
            Next

            ''graba en tabla de cruce TESDCL
            'Dim stAddCruce As String
            '    Dim k As Integer
            '    For k = 1 To UBound(codigosDOP)
            '        If codigosDOP(k) > 0 Then
            '            stAddCruce = "INSERT INTO TESDCL (DOP_CODIGO, CLC_CODIGO) " &
            '                           "VALUES (" & CStr(codigosDOP(k)) & "," & CStr(ultimaColocacion) & ")"
            '            DE1.Fondo.Execute stAddCruce
            '            End If
            '    Next

        End If
        If rbInversion.Checked = True Then
            TotalporColumna(DetallePla.Planilla, 14)
        Else
            TotalporColumna(DetallePla.Planilla, 8)
        End If
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CargarTabla(Mensaje As String)

        TablasEnviadas.Rows.Add
        TablasEnviadas.Value(r, "REGISTRO") = Mensaje

    End Sub
    Private Sub ActivarSAP()
        Resultado = MyFunc.Call
        If Resultado = False Then
            MsgBox("Error al operar la funcion ZF_PL_OPERACIONES", vbInformation, "Mensaje de la Planilla de Operaciones")
        End If
    End Sub
    Private Function Armar_Glosa(Texto As String, Cheques As Integer, Cheque As Integer)
        Dim salida As String
        salida = Space(301)
        Dim arreglo As Object
        Dim Registros As Integer
        Dim i As Integer
        Dim j As Integer
        Dim Cheq As String
        Cheq = "(" & Cheque & " de " & Cheques & ")"
        salida = Space(301)
        Texto = Replace(Texto, Chr(13), " ")
        arreglo = Split(Texto, Chr(10))
        Registros = UBound(arreglo) + 1
        If Registros = 1 And Len(Texto) > 60 Then
            ReDim arreglo(Int(Len(Texto) / 60))
            j = 0
            For i = 1 To Len(Texto) Step 60
                arreglo(j) = Mid(Texto, i, 60)
                j = j + 1
            Next
        End If
        If Registros > 5 Then Registros = 5
        j = 0
        For i = 2 To Registros * 60 + 1 Step 60
            Mid(salida, i, 60) = arreglo(j)
            j = j + 1
        Next
        If Len(Trim(Me.tbNota.Text)) <> 0 Then
            If Registros < 5 Then Registros = Registros + 1
            Mid(salida, (Registros - 1) * 60 + 2, 60) = Me.tbNota.Text
        End If
        Mid(salida, (301 - Len(Cheq) + 1), Len(Cheq)) = Cheq
        Mid(salida, 1, 1) = "5"
        Armar_Glosa = salida

    End Function

    Private Function HaceMensaje(Banco As Integer, Monto As Double, Transaccion As String, Glosa As String, RUT As String, Unidad As Integer, Tipo As String, Adicional As String) As String
        ' Genera mensaje SAP
        'Dim Men As String
        Dim Datos As String
        Dim strGlosa As String
        strGlosa = Space(301)
        Dim strAdicional As String
        strAdicional = Space(100)
        Dim ClaseDoc As String
        ClaseDoc = Space(2)
        Dim Sociedad As String
        Sociedad = Space(4)
        Dim Moneda As String
        Moneda = Space(5)
        Dim CuentaContable1 As String
        CuentaContable1 = Space(10)
        Dim CuentaContable2 As String
        CuentaContable2 = Space(10)
        Dim CodGlosa As String
        CodGlosa = Space(6)
        Dim Importe As String
        Importe = Space(16)
        Dim Asignacion1 As String
        Asignacion1 = Space(18)
        Dim Acreedor As String
        Acreedor = Space(10)
        Dim Condicion As String
        Condicion = Space(4)
        Dim Via As String
        Via = Space(1)
        Dim Asignacion2 As String
        Asignacion2 = Space(18)
        Dim BancoPropio As String
        BancoPropio = Space(5)
        Dim IDCuenta As String
        IDCuenta = Space(5)
        Dim textoPosicion As String
        textoPosicion = Space(50)
        Dim Aprobador As String
        Aprobador = Space(20)
        Dim Pagadora As String
        Pagadora = Space(12)
        'Dim danny As StringBuilder
        ' Determinar Via de Pago
        taCTE2.FillByCuenta(dtCTE2, Banco)
        filaCTE2 = dtCTE2.Item(0)

        mid(strGlosa, 1, 301) = Glosa
        RUT = RutNumero(RUT)
        '***************************************************************************************************************************************
        '  determinar ClaseDoc a parir de la Transacción en tabla de Rodrigo
        '***************************************************************************************************************************************

        If Pago9 = 9 Then
            ClaseDoc = "KZ"
        Else
            ClaseDoc = "OC"
        End If
        mid(Sociedad, 1, 4) = FilaPAR.PAR_SOCIEDAD
        mid(Moneda, 1, 5) = filaCTE2.CTE_MONEDASAP
        If dtCTE2.Count = 0 Then
            mid(CuentaContable1, 1, 10) = "Sin Cuenta"
            mid(CuentaContable2, 1, 10) = "Sin Cuenta"
        Else
            If filaCTE2.IsCTE_CONTABLENull Then
                mid(CuentaContable1, 1, 10) = "Sin Cuenta"
                mid(CuentaContable2, 1, 10) = "Sin Cuenta"
            Else
                mid(CuentaContable1, 1, 10) = filaCTE2.CTE_CONTABLE
                mid(CuentaContable2, 1, 10) = Mid(RTrim(CuentaContable1), 1, Len(RTrim(CuentaContable1)) - 1) & "2"
            End If
        End If
        Mid(textoPosicion, 1, 50) = Mid(Glosa, 2)
        '    CodGlosa = "CF3103"
        mid(CodGlosa, 1, 6) = Transaccion
        Importe = Format(Monto, "0000000000000.00")
        mid(Acreedor, 1, 10) = RUT
        Condicion = "X001"
        mid(Pagadora, 1, 12) = cbUnidadPagadora.Text
        mid(Aprobador, 1, 20) = Usuario.Usuario
        mid(Via, 1, 1) = filaCTE2.CTE_VIA
        mid(BancoPropio, 1, 5) = filaCTE2.CTE_CODBANCO
        mid(IDCuenta, 1, 5) = filaCTE2.CTE_CUENTAID

        Datos = Format(Now, "ddMMyyyy") & Format(Now, "ddMMyyyy") & ClaseDoc & Sociedad & Moneda & CuentaContable1 & BancoPropio & IDCuenta & CodGlosa & textoPosicion & Importe & Acreedor & Condicion & Via & CuentaContable2 & Pagadora & Aprobador
        HaceMensaje = Datos
    End Function
    Private Function RutNumero(RUT As String) As String
        Dim numRut As Long
        Dim Digito As String
        Digito = Mid(RUT, Len(RTrim(RUT)), 1)
        RUT = Mid(RUT, 1, 11)
        numRut = CLng(SacaPunto(Replace(RUT, ",", ".")))
        RutNumero = Trim(Format(numRut, "#########")) & Digito
        Exit Function
    End Function
    Private Function SacaPunto(RUT As String) As String
        Dim i As Integer
        Dim salida As String
        salida = ""
        For i = 1 To Len(RUT)
            If Mid(RUT, i, 1) <> "." Then
                salida = salida + Mid(RUT, i, 1)
            End If
        Next i
        SacaPunto = salida
    End Function

    Private Sub cbEntidad_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEntidad.SelectedValueChanged
        Me.TESFONTableAdapter.FillByEntidad(Me.DsWALPLA.TESFON, cbEntidad.SelectedValue)
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    'Private Sub dgvMontos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMontos.CellValidating
    '    ErrorProvider.Clear()
    '    dgvMontos.Rows(e.RowIndex).ErrorText = ""
    '    If e.ColumnIndex = 3 Then
    '        If e.FormattedValue.ToString <> "" AndAlso Not IsNumeric(e.FormattedValue.ToString()) Then
    '            dgvMontos.Rows(e.RowIndex).ErrorText = "El valor debe ser numérico"
    '            e.Cancel = True
    '        End If
    '    End If


    'End Sub
    Private Sub TotalCheques()
        Dim Total As Double = 0
        Suma = 9
        For i = 0 To dgvMontos.Rows.Count - 1
            If dgvMontos.Rows(i).Cells(3).FormattedValue.ToString <> "" AndAlso IsNumeric(dgvMontos.Rows(i).Cells(3).FormattedValue.ToString()) Then
                Total = Total + CDbl(dgvMontos.Rows(i).Cells(3).Value)
            End If
        Next
        tbCheques.Text = FormatCurrency(Total, 0)
        Suma = 0
    End Sub

    Private Sub dgvMontos_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMontos.CellValidated
        TotalCheques()
    End Sub

    Private Sub dgvMontos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMontos.CellFormatting
        If e.ColumnIndex = 3 Then
            If Not (IsNothing(e.Value)) AndAlso IsNumeric(e.Value) Then
                e.Value = FormatCurrency(e.Value, 0)
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbPago.CheckedChanged
        If rbPago.Checked = True Then
            gbFondo.Enabled = False
            gbInversion.Enabled = False
            Pago9 = 9
            Me.DsWALPLA.TESINF.Clear()
            Me.DsWALPLA.TESENT.Clear()
        Else
            gbFondo.Enabled = True
            gbInversion.Enabled = True
            Pago9 = 0
            Me.TESINFTableAdapter.Fill(Me.DsWALPLA.TESINF)
            Me.TESENTTableAdapter.Fill(Me.DsWALPLA.TESENT)

        End If
    End Sub

    Private Function ConectarSAP() As Boolean
        Dim Respuesta As Long
        Dim Mensaje As String
        ' Cargar los parámetros de conexión QUE SE USARAN POR DEFECTO
        objSAPLogonCtrl = CreateObject("SAP.Logoncontrol.1")
        R3 = Me.AxSAPLogonControl1.NewConnection
        R3.Client = "400" 'parametros.parSAPMandante            ' Mandante
        R3.User = "" 'parametros.parSAPUsuario        ' Usuario
        R3.Language = "ES" ' parametros.parSAPIdioma          ' Idioma
        R3.Password = "" 'parametros.parSAPPassword
        R3.ApplicationServer = "INDICO.COPEC.CL" 'parametros.parSAPApplicationServer
        R3.SystemNumber = "02"  'parametros.parSAPSystemNumber

        ' Ejecutar la conexión en modo visible.
        'Respuesta = R3.Logon(0, True)
        Respuesta = R3.Logon(0, False)

        Mensaje = ""
        If Respuesta <> True Then
            'Mensaje = R3.message
            ConectarSAP = False
            MsgBox("Error de Conexión, verifique si tiene acceso a SAP", vbInformation, NombreSistema)
            R3 = Nothing
            objSAPLogonCtrl = Nothing
            Me.Close()
        Else
            ConectarSAP = True
        End If
    End Function

    Private Sub dgvMontos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvMontos.CurrentCellDirtyStateChanged
        If dgvMontos.IsCurrentCellDirty Then
            dgvMontos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub tbTasa_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTasa.KeyDown
        ' Inicializa indicador
        Dim Numerico As Boolean = True
        Me.ErrorProvider.Clear()

        ' determina que tecla se presiona
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' determina si la tecla es del pad numérico
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' determina se la tecla BackSpace se presionó
                If e.KeyCode <> Keys.Back Then
                    If e.KeyCode <> Keys.OemMinus Then
                        If e.KeyCode <> Keys.Subtract Then
                            ' una tecla no numérica se presionó
                            If e.KeyCode <> Keys.Tab Then
                                If e.KeyCode <> Keys.Delete Then
                                    If e.KeyCode <> Keys.Oemcomma Then
                                        If e.KeyCode <> Keys.OemPeriod Then
                                            If e.KeyCode <> Keys.Decimal Then
                                                ' determina se la tecla delete se presionó
                                                If e.KeyCode <> Keys.Delete Then
                                                    ' Se indica que es falso
                                                    Numerico = False
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                    End If
                End If
        If e.KeyCode = Keys.OemPeriod Or e.KeyCode = Keys.Decimal Then
            e.SuppressKeyPress = True
            tbTasa.Text = tbTasa.Text & ","
            tbTasa.SelectionStart = tbTasa.TextLength
        End If

        'si se presiona mayúsculas no es numérico
        If Control.ModifierKeys = Keys.Shift Then
            Numerico = False
        End If
        If Numerico = False Then
            e.SuppressKeyPress = True
            Me.ErrorProvider.SetError(Me.tbTasa, "Este campo debe ser numérico")
        End If
    End Sub

    Private Sub tbMonto_TextChanged(sender As Object, e As EventArgs) Handles tbMonto.TextChanged

    End Sub

    Private Sub dgvMontos_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMontos.CellLeave
        Dim Monto As Double

        If e.ColumnIndex = 3 AndAlso Len(dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value) > 0 And Suma = 0 Then
            Try
                Monto = CDbl(dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value)
            Catch ex As Exception
                MsgBox("Monto no es numérico, revise sus cifras", vbCritical, "Mensaje del Sistema")
                dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value = ""
                dgvMontos.CurrentCell = dgvMontos(e.ColumnIndex, e.RowIndex)
                Exit Sub
            End Try
            If Monto > dgvMontos.Item(e.ColumnIndex - 1, e.RowIndex).Value * 1000000 Then
                MsgBox("Monto exede lo disponible en la cuenta, revise sus cifras", vbCritical, "Mensaje del Sistema")
                dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value = ""
                dgvMontos.CurrentCell = dgvMontos(e.ColumnIndex, e.RowIndex)
                Exit Sub
            End If
            dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value = Format(CDbl(dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value), "#,###")
            TotalCheques()
            If tbMonto.Text = "" Then
                MsgBox("Monto de Inversión no definido, revise sus cifras", vbCritical, "Mensaje del Sistema")
                dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value = ""
                dgvMontos.CurrentCell = dgvMontos(e.ColumnIndex, e.RowIndex)
                Exit Sub
            End If
            If Len(dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value) > 0 Then
                If CDbl(tbCheques.Text) > CDbl(tbMonto.Text) Then
                    MsgBox("Monto exede el valor de la operación, revise sus cifras", vbCritical, "Mensaje del Sistema")
                    dgvMontos.Item(e.ColumnIndex, e.RowIndex).Value = ""
                    dgvMontos.CurrentCell = dgvMontos(e.ColumnIndex, e.RowIndex)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btBuscaBeneficiario_Click(sender As Object, e As EventArgs) Handles btBuscaBeneficiario.Click
        Dim formulario As New frmWALCBE00
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.ShowDialog()
        Me.TESBENTableAdapter.Fill(Me.DsWALBEN.TESBEN)

    End Sub
End Class