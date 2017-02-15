Imports System.Text
Public Class frmWALTRB00

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
    Dim Suma As Integer
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


    Private Sub frmWALGMO00_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DsWALTRB.Cuentas_Destino' Puede moverla o quitarla según sea necesario.
        Me.Cuentas_DestinoTableAdapter.Fill(Me.DsWALTRB.Cuentas_Destino)
        'TODO: esta línea de código carga datos en la tabla 'DsWALTRB.Cuentas_Destino' Puede moverla o quitarla según sea necesario.
        Me.Cuentas_DestinoTableAdapter.Fill(Me.DsWALTRB.Cuentas_Destino)
        Me.Cuentas_DestinoTableAdapter.Fill(Me.DsWALTRB.Cuentas_Destino)
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
        Total = consulta.TotalPorColocar(datos.Planilla)
        tbTotal.Text = Format(Total / 1000000, "M$#,##0.0")
        taPAR.Fill(dtPAR)
        FilaPAR = dtPAR.Item(0)
        parametros.Mandante = FilaPAR.PAR_MANDANTE
    End Sub

    Private Sub cbGlosas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGlosas.SelectedIndexChanged
        tbGlosaEditada.Text = cbGlosas.Text
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
        Dim Clave As Object
        'Dim CodGlosa As String
        Dim Cuenta As String
        Dim i As Integer
        Dim ch As Integer
        Dim ch9 As Integer
        Nuevo = True
        Pago9 = 0
        ' verificar totales iguales
        If tbMonto.Text = "" Then
            MsgBox("Cifras de Monto y Cheques Emitidos no cuadran.", vbCritical, "Mensaje del Sistema")
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
        Try
            Columna = FilaGlosa.Item("GLO_COLUMNA")
        Catch ex As Exception
            Columna = 8
        End Try
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
                Clave = Split(cbCuentaDestino.SelectedValue, "|")
                RUT = " 99.520.000-7"
                Cuenta = Mid(Clave(1), 3)
                Unidad = cbUnidadPagadora.SelectedValue
                Tipo = "3"
                Adicional = Clave(1) & "+"
                Mensaje = HaceMensaje(CStr(Banco), Monto, Tran, Glosa, RUT, Unidad, Tipo, Adicional)
                Adicional = tbNota.Text
                Generacion_Detalles2(Banco, Cuenta, Monto, Glosa, Adicional)

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
        End If
        Me.Close()
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


    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvMontos_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvMontos.CellToolTipTextNeeded

    End Sub

    Private Sub dgvMontos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvMontos.CellValidating
        ErrorProvider.Clear()
        dgvMontos.Rows(e.RowIndex).ErrorText = ""
        If e.ColumnIndex = 3 Then
            If e.FormattedValue.ToString <> "" AndAlso Not IsNumeric(e.FormattedValue.ToString()) Then
                dgvMontos.Rows(e.RowIndex).ErrorText = "El valor debe ser numérico"
                e.Cancel = True

            End If
        End If


    End Sub
    Private Sub TotalCheques()
        Dim Total As Double = 0

        For i = 0 To dgvMontos.Rows.Count - 1
            If dgvMontos.Rows(i).Cells(3).FormattedValue.ToString <> "" AndAlso IsNumeric(dgvMontos.Rows(i).Cells(3).FormattedValue.ToString()) Then
                Total = Total + CDbl(dgvMontos.Rows(i).Cells(3).Value)
            End If
        Next
        tbCheques.Text = FormatCurrency(Total, 0)
    End Sub

    Private Sub dgvMontos_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMontos.CellValidated
        TotalCheques()
    End Sub

    Private Sub dgvMontos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMontos.CellFormatting
        If e.ColumnIndex = 3 Then
            If Not (IsNothing(e.Value)) AndAlso IsNumeric(e.Value) Then
                e.Value = FormatCurrency(e.Value)
                e.FormattingApplied = True
            End If
        End If
    End Sub


    Private Function ConectarSAP() As Boolean
        Dim Respuesta As Long
        Dim Mensaje As String
        ' Cargar los parámetros de conexión QUE SE USARAN POR DEFECTO
        objSAPLogonCtrl = CreateObject("SAP.Logoncontrol.1")
        R3 = Me.AxSAPLogonControl1.NewConnection
        R3.Client = "400" 'parametros.parSAPMandante            ' Mandante
        'R3.User = "CGONZALEZ" 'parametros.parSAPUsuario        ' Usuario
        R3.User = "" 'parametros.parSAPUsuario        ' Usuario
        R3.Language = "ES" ' parametros.parSAPIdioma          ' Idioma
        'R3.Password = "2sys451129" 'parametros.parSAPPassword
        R3.Password = "" 'parametros.parSAPPassword
        R3.ApplicationServer = "INDICO.COPEC.CL" 'parametros.parSAPApplicationServer
        R3.SystemNumber = "02"  'parametros.parSAPSystemNumber
        'R3.SystemID = "SCT"

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


End Class