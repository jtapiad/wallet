Public Class frmWALSAP00
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
    Dim taPRV As New dsWALSAPTableAdapters.TESBE2TableAdapter
    Dim dtPRV As New dsWALSAP.TESBE2DataTable
    Dim filaPRV As dsWALSAP.TESBE2Row
    Dim Campos As Object
    Dim Campos2 As Object



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
        taPRV.Fill(dtPRV)
        Cursor = Cursors.Default
        Dim iLinea As Integer
        Dim iRows As Integer

        If Not ConectarSAP() Then
            ' No Conecto
            Me.Close()
        Else
            ' Establecer contacto con la funcion.

            SAPFunctions1.Connection = R3

            MyFunc = SAPFunctions1.Add("RFC_READ_TABLE")
            TablasEnviadas = MyFunc.Tables("OPTIONS")
            TablasEnviadas.rows.Add()
            Campos = MyFunc.Tables("FIELDS")
            Campos.rows.Add()
            Campos.Value(1, "FIELDNAME") = "LIFNR"
            Campos.Value(1, "OFFSET") = "000000"
            Campos.Value(1, "LENGTH") = "000010"
            Campos.Value(1, "TYPE") = "C"
            Campos.rows.Add()
            Campos.Value(2, "FIELDNAME") = "NAME1"
            Campos.Value(1, "OFFSET") = "000001"
            Campos.Value(1, "LENGTH") = "000035"
            Campos.Value(1, "TYPE") = "C"
            Campos.rows.Add()
            Campos.Value(3, "FIELDNAME") = "NAME2"
            Campos.Value(1, "OFFSET") = "000002"
            Campos.Value(1, "LENGTH") = "000035"
            Campos.Value(1, "TYPE") = "C"
            Campos.rows.Add()
            Campos.Value(4, "FIELDNAME") = "STCD1"
            Campos.Value(1, "OFFSET") = "000003"
            Campos.Value(1, "LENGTH") = "000016"
            Campos.Value(1, "TYPE") = "C"
            Campos.rows.Add()
            Campos.Value(5, "FIELDNAME") = "STRAS"
            Campos.Value(1, "OFFSET") = "000004"
            Campos.Value(1, "LENGTH") = "000035"
            Campos.Value(1, "TYPE") = "C"


            TablasEnviadas.Value(1, "TEXT") = "MANDT EQ '400'"      ' Filtro
            'Dim valor As String = TablasEnviadas.Value(1, "TEXT").ToString
            MyFunc.Exports("QUERY_TABLE") = "LFA1"  'Tabla LFA1: pROVEEDORES
            Resultado = MyFunc.Call
            ' Analizar el resultado de la llamada.
            If Resultado = False Then
                    MsgBox("Error en el llamado a la funcion RFC_READ_TABLE.")
                Exit Sub
            Else

                ' Recoger los parametros devueltos por la funcion - IMPORTING
                ' Recoger los parametros devueltos por la funcion - TABLES
                ' tabla de Proveedores LFA1
                TablasRecibidas = MyFunc.Tables("DATA")
                iLinea = 0
                iRows = TablasRecibidas.RowCount
                Me.ProgressBar1.Maximum = iRows + 1
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Value = 0
                Dim registro As String
                Dim Proveedor As String
                Dim Nombre1 As String
                Dim Nombre2 As String
                Dim RUT As String
                Dim Calle As String
                Dim Act As Long
                Dim RUTEditado
                'If DE1.Fondo.State = adStateClosed Then
                '    DE1.Fondo.Open
                'End If
                If iRows = 0 Then
                    MsgBox("No se han encontrado registros de Proveedores.")
                    Me.Close()
                Else
                    ' se encontraron registra actualizar
                    Do While Not (iLinea = iRows)
                        iLinea = iLinea + 1
                        registro = TablasRecibidas.Value(iLinea, "WA")     'Registro
                        Proveedor = registro.Substring(0, 10)     'proveedor
                        Nombre1 = registro.Substring(10, 35)    'nombre1
                        Nombre2 = registro.Substring(45, 35)  'nombre2
                        RUT = registro.Substring(80, 10)   'rut
                        Calle = registro.Substring(90, 20)   'calle

                        On Error Resume Next
                        If Trim(RUT) = "" Then
                            Continue Do
                        End If
                        RUTEditado = Validar_RUT_Masivo(RUT)
                        If RUTEditado = "" And RUT <> "" Then
                            RUTEditado = RUT
                        End If
                        If RUTEditado = "" Then
                            Continue Do
                        End If
                        filas = dtPRV.Select("BE2_RUT='" & RUTEditado & "'")
                        If filas.Length > 0 Then
                            ' SE ENCONTRO REGISTROS, SE ACTUALIZAN
                            For i = 0 To filas.Length - 1
                                filaPRV = TryCast(filas(i), dsWALSAP.TESBE2Row)
                                filaPRV.BE2_CODIGOSAP = Proveedor
                                filaPRV.BE2_RAZONSOCIAL = Trim(Nombre1)
                            Next
                        Else
                            ' No se encontraron registros, se crean
                            filaPRV = dtPRV.NewTESBE2Row
                            filaPRV.BE2_RUT = RUTEditado
                            filaPRV.BE2_CODIGOSAP = Proveedor
                            filaPRV.BE2_RAZONSOCIAL = Trim(Nombre1)
                            dtPRV.AddTESBE2Row(filaPRV)
                        End If
                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop
                    taPRV.Update(dtPRV)
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class