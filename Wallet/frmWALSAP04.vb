Public Class frmWALSAP04
    Dim R3 As Object
    Dim SAPFunctions1 As Object = CreateObject("SAP.Functions")
    Dim SAPFunctions2 As Object = CreateObject("SAP.Functions")
    Dim MyFunc As Object
    Dim MyFunc2 As Object
    ' Resultado de la llamada a SAP.
    Dim Resultado As Boolean
    ' Tablas a ser recibidas por la funcion
    Dim TablasRecibidas As Object
    ' Tablas a ser enviadas a la funcion
    Dim TablasEnviadas As Object
    Dim objSAPLogonCtrl As Object
    ' Tabla de Proveedores
    Dim taVIA As New dsWALSAPTableAdapters.TESVIATableAdapter
    Dim dtVIA As New dsWALSAP.TESVIADataTable
    Dim filaVIA As dsWALSAP.TESVIARow


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
        taVIA.Fill(dtVIA)
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
            TablasEnviadas.Rows.Add
            TablasEnviadas.Value(1, "TEXT") = "LAND1 = 'CL'"         ' Filtro

            MyFunc.Exports("QUERY_TABLE") = "T042Z"

            ' Llamar a la funcion de SAP.
            Resultado = MyFunc.Call
            ' Analizar el resultado de la llamada.
            If Resultado = False Then
                MsgBox("Error en el llamado a la funcion RFC_READ_TABLE.")
                Exit Sub
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
                If iRows = 0 Then
                    MsgBox("No se han encontrado registros de Proveedores.")
                    Me.Close()
                Else
                    ' se encontraron registra actualizar
                    Do While Not (iLinea = iRows)
                        iLinea = iLinea + 1
                        Registro = TablasRecibidas.Value(iLinea, "WA")

                        filas = dtVIA.Select("VIA_VIA='" & Mid(Registro, 7, 1) & "' and VIA_MANDANTE='" & Mid(Registro, 1, 3) & "'")
                        If filas.Length > 0 Then
                            ' SE ENCONTRO REGISTROS, SE ACTUALIZAN
                            For i = 0 To filas.Length - 1
                                filaVIA = TryCast(filas(i), dsWALSAP.TESVIARow)
                                filaVIA.VIA_MANDANTE = Mid(Registro, 1, 3)
                                filaVIA.VIA_VIA = Mid(Registro, 7, 1)
                                filaVIA.VIA_SIGNIFICADO = Mid(Registro, 8, 30)
                            Next
                        Else
                            ' No se encontraron registros, se crean
                            filaVIA = dtVIA.NewTESVIARow
                            filaVIA.VIA_MANDANTE = Mid(Registro, 1, 3)
                            filaVIA.VIA_VIA = Mid(Registro, 7, 1)
                            filaVIA.VIA_SIGNIFICADO = Mid(Registro, 8, 30)
                            dtVIA.AddTESVIARow(filaVIA)
                        End If
                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop
                    taVIA.Update(dtVIA)
                End If
            End If
            ' Terminar la sesion.

        End If


        ' Fase 2

        SAPFunctions2.Connection = R3
        MyFunc2 = SAPFunctions2.Add("RFC_READ_TABLE")

        TablasEnviadas = MyFunc2.Tables("OPTIONS")
        TablasEnviadas.Rows.Add
        TablasEnviadas.Value(1, "TEXT") = "ZBUKR = '1000'"         ' Filtro

        MyFunc2.Exports("QUERY_TABLE") = "T042I"

        ' Llamar a la funcion de SAP.
        Resultado = MyFunc2.Call
        ' Analizar el resultado de la llamada.
        If Resultado = False Then
            MsgBox("Error en el llamado a la funcion RFC_READ_TABLE.")
            Exit Sub
        Else
            ' Recoger los parametros devueltos por la funcion - IMPORTING
            ' Recoger los parametros devueltos por la funcion - TABLES
            TablasRecibidas = MyFunc2.Tables("DATA")
            iLinea = 0
            iRows = TablasRecibidas.RowCount
            Me.ProgressBar1.Maximum = iRows + 1
            Me.ProgressBar1.Minimum = 0
            Me.ProgressBar1.Value = 0
            Dim Registro As String
            If iRows = 0 Then
                MsgBox("No se han encontrado registros de Proveedores.")
                Me.Close()
            Else
                ' se encontraron registra actualizar
                Do While Not (iLinea = iRows)
                    iLinea = iLinea + 1
                    Registro = TablasRecibidas.Value(iLinea, "WA")

                    filas = dtVIA.Select("VIA_VIA='" & Mid(Registro, 13, 1) & "' and VIA_MANDANTE='" & Mid(Registro, 1, 3) & "'")
                    If filas.Length > 0 Then
                        ' SE ENCONTRO REGISTROS, SE ACTUALIZAN
                        For i = 0 To filas.Length - 1
                            filaVIA = TryCast(filas(i), dsWALSAP.TESVIARow)
                            filaVIA.VIA_SOCIEDAD = Mid(Registro, 4, 4)
                            filaVIA.VIA_BANCOPROPIO = Mid(Registro, 8, 5)
                            filaVIA.VIA_MONEDA = Mid(Registro, 14, 5)
                            filaVIA.VIA_CUENTA = Mid(Registro, 24, 10)
                        Next
                    Else
                        ' No se encontraron registros, se crean
                        filaVIA = dtVIA.NewTESVIARow
                        filaVIA.VIA_MANDANTE = Mid(Registro, 1, 3)
                        filaVIA.VIA_VIA = Mid(Registro, 13, 1)
                        filaVIA.VIA_SOCIEDAD = Mid(Registro, 4, 4)
                        filaVIA.VIA_BANCOPROPIO = Mid(Registro, 8, 5)
                        filaVIA.VIA_MONEDA = Mid(Registro, 14, 5)
                        filaVIA.VIA_CUENTA = Mid(Registro, 24, 10)
                        dtVIA.AddTESVIARow(filaVIA)
                    End If
                    Me.ProgressBar1.Value = iLinea
                    Application.DoEvents()
                Loop
                taVIA.Update(dtVIA)
            End If
        End If
        ' Terminar la sesion.
        R3.Logoff
        On Error GoTo 0








        Me.Close()
        Exit Sub

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.close
    End Sub
End Class