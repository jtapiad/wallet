Public Class frmWALSAP02
    Dim R3 As Object
    Dim SAPFunctions1 As Object = CreateObject("SAP.Functions")
    Dim MyFunc As Object
    ' Resultado de la llamada a SAP.
    Dim Resultado As Boolean
    ' Tablas a ser recibidas por la funcion
    Dim TablasRecibidas As Object
    ' Tablas a ser enviadas a la funcion
    Dim TablasEnviadas As Object
    Dim objSAPLogonCtrl As Object
    ' Tabla de Proveedores
    Dim taMON As New dsWALSAPTableAdapters.TESMONTableAdapter
    Dim dtMON As New dsWALSAP.TESMONDataTable
    Dim filaMON As dsWALSAP.TESMONRow


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

    Private Sub tsbProcesar_Click(sender As Object, e As EventArgs) Handles tsbProcesar.Click
        Dim filas() As DataRow
        Cursor = Cursors.WaitCursor
        taMON.Fill(dtMON)
        Cursor = Cursors.Default
        Dim iLinea As Integer
        Dim iRows As Integer

        If Not ConectarSAP() Then
            ' No Conecto
            Me.Close()
        Else
            ' Establecer contacto con la funcion.

            SAPFunctions1.Connection = R3
            MyFunc = SAPFunctions1.Add("BAPI_CURRENCY_GETLIST")
            ' Llamar a la funcion de SAP.
            Resultado = MyFunc.Call
            ' Analizar el resultado de la llamada.
            If Resultado = False Then
                MsgBox("Error en el llamado a la funcion BAPI_CURRENCY_GETLIST")
                Exit Sub
            Else
                ' Recoger los parametros devueltos por la funcion - IMPORTING
                ' Recoger los parametros devueltos por la funcion - TABLES
                TablasRecibidas = MyFunc.Tables("CURRENCY_LIST")
                iLinea = 0
                iRows = TablasRecibidas.RowCount
                Me.ProgressBar1.Maximum = iRows + 1
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Value = 0
                Dim CodigoSAP As String
                Dim CodigoISO As String
                Dim CodigoAlt As String
                Dim NombreLargo As String
                Dim Valido As Date
                Dim Act As Long
                Dim RUTEditado                'If DE1.Fondo.State = adStateClosed Then
                '    DE1.Fondo.Open
                'End If
                If iRows = 0 Then
                    MsgBox("No se han encontrado registros de Monedas.")
                    Me.Close()
                Else
                    ' se encontraron registra actualizar
                    Do While Not (iLinea = iRows)
                        iLinea = iLinea + 1
                        CodigoSAP = TablasRecibidas.Value(iLinea, "CURRENCY")
                        CodigoISO = TablasRecibidas.Value(iLinea, "CURRENCY_ISO")
                        CodigoAlt = TablasRecibidas.Value(iLinea, "ALT_CURR")
                        NombreLargo = TablasRecibidas.Value(iLinea, "LONG_TEXT")
                        Valido = TablasRecibidas.Value(iLinea, "VALID_TO")

                        filas = dtMON.Select("MON_CODIGO= '" & CodigoSAP & "'")
                        If filas.Length > 0 Then
                            ' SE ENCONTRO REGISTROS, SE ACTUALIZAN
                            For i = 0 To filas.Length - 1
                                filaMON = TryCast(filas(i), dsWALSAP.TESMONRow)
                                filaMON.MON_CODIGOISO = CodigoISO
                                filaMON.MON_CODIGOALT = CodigoAlt
                                filaMON.MON_MONEDA = NombreLargo
                                filaMON.MON_VALIDO = Valido
                            Next
                        Else
                            ' No se encontraron registros, se crean
                            filaMON = dtMON.NewTESMONRow
                            filaMON.MON_CODIGO = CodigoSAP
                            filaMON.MON_CODIGOISO = CodigoISO
                            filaMON.MON_CODIGOALT = CodigoAlt
                            filaMON.MON_MONEDA = NombreLargo
                            filaMON.MON_VALIDO = Valido
                            dtMON.AddTESMONRow(filaMON)
                        End If
                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop
                    taMON.Update(dtMON)
                End If
            End If
            ' Terminar la sesion.
            R3.Logoff
            On Error GoTo 0

        End If
        Me.Close()
        Exit Sub

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()

    End Sub
End Class