Public Class frmWALSAP01
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
    Dim taENT As New dsWALSAPTableAdapters.TESENTTableAdapter
    Dim dtENT As New dsWALSAP.TESENTDataTable
    Dim filaENT As dsWALSAP.TESENTRow

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
        taENT.Fill(dtENT)
        Cursor = Cursors.Default
        Dim iLinea As Integer
        Dim iRows As Integer
        Dim Act As Long
        Dim RUTEditado As String

        Dim Pais As String
        Dim Clave As String
        Dim Nombre As String
        Dim Ciudad As String

        If Not ConectarSAP() Then
            ' No Conecto
            Me.Close()
        Else
            ' Establecer contacto con la funcion.

            SAPFunctions1.Connection = R3
            MyFunc = SAPFunctions1.Add("BAPI_BANK_GETLIST")
            MyFunc.Exports("BANK_CTRY") = "CL"

            TablasEnviadas = MyFunc.Tables("ITAB_ID_LIST")

            ' Llamar a la funcion de SAP.
            Resultado = MyFunc.Call
            ' Analizar el resultado de la llamada.
            If Resultado = False Then
                MsgBox("Error en el llamado a la funcion BAPI_BANK_GETLIST.")
                Exit Sub
            Else
                ' Recoger los parametros devueltos por la funcion - IMPORTING
                ' Recoger los parametros devueltos por la funcion - TABLES
                TablasRecibidas = MyFunc.Tables("BANK_LIST")
                iLinea = 0
                iRows = TablasRecibidas.RowCount
                Me.ProgressBar1.Maximum = iRows + 1
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Value = 0
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
                        Pais = TablasRecibidas.Value(iLinea, "bank_ctry")       'pais
                        Clave = TablasRecibidas.Value(iLinea, "bank_key")       'clave
                        Nombre = TablasRecibidas.Value(iLinea, "bank_name")     'Nombre Banco
                        Ciudad = TablasRecibidas.Value(iLinea, "city")          'ciudad

                        On Error Resume Next
                        filas = dtENT.Select("ENT_CODIGO=" & Clave.ToString)
                        If filas.Length > 0 Then
                            ' SE ENCONTRO REGISTROS, SE ACTUALIZAN
                            For i = 0 To filas.Length - 1
                                filaENT = TryCast(filas(i), dsWALSAP.TESENTRow)
                                filaENT.ENT_RAZON = Trim(Nombre)
                            Next
                        Else
                            ' No se encontraron registros, se crean
                            filaENT = dtENT.NewTESENTRow
                            filaENT.ENT_RAZON = Trim(Nombre)
                            filaENT.TEN_CODIGO = 1
                            filaENT.ENT_CODIGO = Clave
                            dtENT.AddTESENTRow(filaENT)
                        End If
                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop
                End If
            End If


            ' Capturar el RUT


            MyFunc = SAPFunctions1.Add("RFC_READ_TABLE")
            TablasEnviadas = MyFunc.Tables("OPTIONS")
            TablasEnviadas.Rows.Add
            TablasEnviadas.Value(1, "TEXT") = "BANKS = 'CL'"         ' Filtro

            ' Llamar a la funcion de SAP.
            MyFunc.Exports("QUERY_TABLE") = "T012"

            Resultado = MyFunc.Call
            ' Analizar el resultado de la llamada.
            If Resultado = False Then
                MsgBox("Error en el llamado a la funcion RFC_READ_TABLE.", MsgBoxStyle.Critical, "Mensajes de Wallet")
                Me.Close()
            Else
                ' Recoger los parametros devueltos por la funcion - IMPORTING
                ' Recoger los parametros devueltos por la funcion - TABLES
                TablasRecibidas = MyFunc.Tables("DATA")
                iLinea = 0
                iRows = TablasRecibidas.RowCount
                Me.ProgressBar1.Maximum = iRows + 1
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Value = 0
                Dim Registro As String
                Dim RUT As String
                If iRows = 0 Then
                    MsgBox("No se han encontrado registros de RUT/BANCOS.", MsgBoxStyle.Information, "Mensajes de Wallet")
                    Me.Close()
                Else
                    ' se encontraron registra actualizar
                    Do While Not (iLinea = iRows)
                        iLinea = iLinea + 1
                        Registro = TablasRecibidas.Value(iLinea, "WA")
                        Clave = Trim(Mid(Registro, 15, 15))    'Código
                        RUT = Trim(Mid(Registro, 46, 16))   'RUT
                        If RUT <> "" Then
                            RUTEditado = Validar_RUT(RUT)
                            filas = dtENT.Select("ENT_CODIGO=" & Clave.ToString)
                            If filas.Length > 0 Then
                                ' SE ENCONTRO REGISTROS, SE ACTUALIZAN
                                For i = 0 To filas.Length - 1
                                    filaENT = TryCast(filaENT(i), dsWALSAP.TESENTRow)
                                    filaENT.ENT_RUT = RUTEditado
                                Next
                            End If
                        End If

                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop

                End If
            End If

            taENT.Update(dtENT)

            ' Terminar la sesion.
            R3.Logoff



        End If



        Me.Close()
        Exit Sub

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
End Class