Public Class frmWALSAP06
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
    Dim taREZ As New dsWALSAPTableAdapters.TESREZTableAdapter
    Dim dtREZ As New dsWALSAP.TESREZDataTable
    Dim filaREZ As dsWALSAP.TESREZRow
    Dim taDAZ As New dsWALSAPTableAdapters.TESDAZTableAdapter
    Dim dtDAZ As New dsWALSAP.TESDAZDataTable
    Dim filaDAZ As dsWALSAP.TESDAZRow
    Dim taFER As New dsWALSAPTableAdapters.TESFERTableAdapter
    Dim dtFER As New dsWALSAP.TESFERDataTable
    Dim filaFER As dsWALSAP.TESFERRow


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
            Exit Function
        Else
            ConectarSAP = True
        End If
    End Function

    Private Sub tsbProcesar_Click(sender As Object, e As EventArgs) Handles tsbProcesar.Click
        Dim Mensaje As String
        Dim Superposicion As Boolean
        Dim Registros As String = ""
        Dim filas() As DataRow
        Cursor = Cursors.WaitCursor
        'taREZ.Fill(dtREZ)
        Cursor = Cursors.Default
        Dim iLinea As Integer
        Dim iRows As Integer

        If Not ConectarSAP() Then
            ' No Conecto
            Me.Close()
            Exit Sub
        Else
            ' Establecer contacto con la funcion.

            SAPFunctions1.Connection = R3
            MyFunc = SAPFunctions1.Add("RFC_READ_TABLE")

            TablasEnviadas = MyFunc.Tables("OPTIONS")
            MyFunc.Exports("QUERY_TABLE") = "ZFT_POPERACIONES"

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
                Superposicion = False

                If iRows = 0 Then
                    MsgBox("No se han encontrado registros de Transacciones.")
                    Me.Close()
                    Exit Sub
                Else
                    ' se encontraron registra actualizar
                    Do While Not (iLinea = iRows)
                        iLinea = iLinea + 1
                        Registro = TablasRecibidas.Value(iLinea, "WA")
                        Registros = Registros & Registro & vbCrLf
                        taREZ.FillByRegistro(dtREZ, Registro)
                        If dtREZ.Count > 0 Then
                            ' SE ENCONTRO REGISTROS
                            Superposicion = True
                        Else
                            ' No se encontraron registros, se crean
                            filaREZ = dtREZ.NewTESREZRow
                            filaREZ.Registro = Registro
                            filaREZ.REZ_CAPTURADO = Now
                            dtREZ.AddTESREZRow(filaREZ)
                            taREZ.Update(dtREZ)
                        End If
                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop
                    If Not Superposicion Then
                        Beep()
                        Beep()
                        MsgBox("Las Fechas no se superposicionaron." & vbCrLf & "Existe la posibilidad que no se hayan cargados todos los datos." & vbCrLf & "Vuelva a generar la TablaZ con mas días de historia.", vbCritical, "Mensaje del Sistema")

                    End If

                End If
            End If
            ' Terminar la sesion.
            R3.Logoff
            On Error GoTo 0

        End If

        ' Generar detalles
        taFER.Fill(dtFER)
        taREZ.FillByPorProcesar(dtREZ)
        Mensaje = ""
        For i = 0 To dtREZ.Count - 1
            filaREZ = dtREZ.Item(i)
            taDAZ.FillByDoccontPosicionEjercicio(dtDAZ, Mid(filaREZ.Registro, 8, 10), Mid(filaREZ.Registro, 26, 3), Mid(filaREZ.Registro, 18, 4))
            If dtDAZ.Count = 0 Then
                filaDAZ = dtDAZ.NewTESDAZRow
                filaDAZ.DAZ_MANDANTE = Mid(filaREZ.Registro, 1, 3)
                filaDAZ.DAZ_SOCIEDAD = Mid(filaREZ.Registro, 4, 4)
                filaDAZ.DAZ_DOCCONT = Mid(filaREZ.Registro, 8, 10)
                filaDAZ.DAZ_EJERCICIO = Mid(filaREZ.Registro, 18, 4)
                filaDAZ.DAZ_CLASEDOC = Mid(filaREZ.Registro, 22, 2)
                filaDAZ.DAZ_CONCEPTO = Mid(filaREZ.Registro, 24, 2)
                filaDAZ.DAZ_POSICION = Mid(filaREZ.Registro, 26, 3)
                filaDAZ.DAZ_CAJA = Mid(filaREZ.Registro, 29, 16)
                filaDAZ.DAZ_CUENTABANCO = Mid(filaREZ.Registro, 45, 10)
                filaDAZ.DAZ_MONTO = Replace(Mid(filaREZ.Registro, 55, 15), "*", "0")
                filaDAZ.DAZ_MONTOMON = Replace(Mid(filaREZ.Registro, 70, 15), "*", "0")
                filaDAZ.DAZ_MONEDA = Mid(filaREZ.Registro, 85, 5)
                If Mid(filaREZ.Registro, 90, 4) <> "0000" Then
                    'filaDAZ.DAZ_FECHADOC = DateSerial(Mid(filaREZ.Registro, 90, 4), Mid(filaREZ.Registro, 94, 2), Mid(filaREZ.Registro, 96, 2))
                    filaDAZ.DAZ_FECHADOC = DateTime.ParseExact(Mid(filaREZ.Registro, 90, 8), "yyyyMMdd", Nothing)
                End If
                filaDAZ.DAZ_TEXTOPOS = Mid(filaREZ.Registro, 98, 50)
                If Mid(filaREZ.Registro, 148, 4) <> "    " Then
                    'filaDAZ.DAZ_FECHAz = CDate(Format(DateSerial(Mid(filaREZ.Registro, 148, 4), Mid(filaREZ.Registro, 152, 2), Mid(filaREZ.Registro, 154, 2)), "dd/MM/yyyy") & " " & Format(TimeSerial(Mid(filaREZ.Registro, 156, 2), Mid(filaREZ.Registro, 158, 2), Mid(filaREZ.Registro, 160, 2)), "hh:mm:ss"))
                    filaDAZ.DAZ_FECHAz = DateTime.ParseExact(Mid(filaREZ.Registro, 148, 14), "yyyyMMddHHmmss", Nothing)
                Else
                    filaDAZ.SetDAZ_FECHAzNull()
                End If
                filaDAZ.DAZ_MEDIOPAGO = Mid(filaREZ.Registro, 162, 12)
                filaDAZ.DAZ_RETENCION = Mid(filaREZ.Registro, 174, 30)
                If Mid(filaREZ.Registro, 204, 4) <> "0000" Then
                    'filaDAZ.DAZ_FECHADEP = DateSerial(Mid(filaREZ.Registro, 204, 4), Mid(filaREZ.Registro, 208, 2), Mid(filaREZ.Registro, 210, 2))
                    filaDAZ.DAZ_FECHADEP = DateTime.ParseExact(Mid(filaREZ.Registro, 204, 8), "yyyyMMdd", Nothing)
                Else
                    filaDAZ.SetDAZ_FECHADEPNull()
                End If
                filaDAZ.DAZ_DIAS = Mid(filaREZ.Registro, 212, 1)
                filaDAZ.DAZ_UNIDAD = Mid(filaREZ.Registro, 213, 20)
                filaDAZ.DAZ_VIA = Mid(filaREZ.Registro, 233, 1)
                filaDAZ.DAZ_CLAVEBANCO = Mid(filaREZ.Registro, 234, 5)
                filaDAZ.DAZ_ESTATUS = Mid(filaREZ.Registro, 239, 2)
                filaDAZ.DAZ_ENVIADOBANCO = Mid(filaREZ.Registro, 241, 1)
                filaDAZ.DAZ_ANULADO = Mid(filaREZ.Registro, 242, 1)
                If Mid(filaREZ.Registro, 243, 4) <> "0000" Then
                    '2SYS:  cambiar funcion por una que pueda ingresar los valores de fecha y hora
                    'filaDAZ.DAZ_FECHAANU = DateSerial(Mid(filaREZ.Registro, 243, 4), Mid(filaREZ.Registro, 247, 2), Mid(filaREZ.Registro, 249, 2)) + TimeSerial(Mid(filaREZ.Registro, 251, 2), Mid(filaREZ.Registro, 253, 2), Mid(filaREZ.Registro, 255, 2))
                    Dim fec As String = Mid(filaREZ.Registro, 243, 12)
                    filaDAZ.DAZ_FECHAANU = DateTime.ParseExact(fec, "yyyyMMddHHmm", Nothing)
                End If
                filaDAZ.DAZ_ESTADO = "C"
                If Mid(filaREZ.Registro, 204, 4) <> "0000" Then
                    filaDAZ.DAZ_FECHADIS = FechaDis(filaDAZ.DAZ_FECHADEP, filaDAZ.DAZ_DIAS)
                End If
                filaDAZ.DAZ_GLOSA = Mid(filaREZ.Registro, 257, 25)
                dtDAZ.AddTESDAZRow(filaDAZ)
                taDAZ.Update(dtDAZ)
                filaREZ.REZ_PROCESADO = Now
                taREZ.Update(dtREZ)
            Else
                filaDAZ = dtDAZ.Item(0)
                ' verificar si se esta cambiando de banco los depositos
                If filaDAZ.DAZ_CONCEPTO = "DE" Then
                    If filaDAZ.DAZ_CUENTABANCO <> Mid(filaREZ.Registro, 45, 10) Then
                        ' se esta grabando en un distinto banco al existente
                        Mensaje = Mensaje & "Doc: " & filaDAZ.DAZ_DOCCONT & " de Cuenta: " & filaDAZ.DAZ_CUENTABANCO & " a Cuenta: " & Mid(filaREZ.Registro, 45, 10) & " Monto: " & Format(filaDAZ.DAZ_MONTOMON, "#,##0") & vbCrLf
                    End If
                End If
                filaDAZ.DAZ_MANDANTE = Mid(filaREZ.Registro, 1, 3)
                filaDAZ.DAZ_SOCIEDAD = Mid(filaREZ.Registro, 4, 4)
                filaDAZ.DAZ_DOCCONT = Mid(filaREZ.Registro, 8, 10)
                filaDAZ.DAZ_EJERCICIO = Mid(filaREZ.Registro, 18, 4)
                filaDAZ.DAZ_CLASEDOC = Mid(filaREZ.Registro, 22, 2)
                filaDAZ.DAZ_CONCEPTO = Mid(filaREZ.Registro, 24, 2)
                filaDAZ.DAZ_POSICION = Mid(filaREZ.Registro, 26, 3)
                filaDAZ.DAZ_CAJA = Mid(filaREZ.Registro, 29, 16)
                filaDAZ.DAZ_CUENTABANCO = Mid(filaREZ.Registro, 45, 10)
                filaDAZ.DAZ_MONTO = Replace(Mid(filaREZ.Registro, 55, 15), "*", "0")
                filaDAZ.DAZ_MONTOMON = Replace(Mid(filaREZ.Registro, 70, 15), "*", "0")
                filaDAZ.DAZ_MONEDA = Mid(filaREZ.Registro, 85, 5)
                If Mid(filaREZ.Registro, 90, 4) <> "0000" Then
                    'filaDAZ.DAZ_FECHADOC = DateSerial(Mid(filaREZ.Registro, 90, 4), Mid(filaREZ.Registro, 94, 2), Mid(filaREZ.Registro, 96, 2))
                    filaDAZ.DAZ_FECHADOC = DateTime.ParseExact(Mid(filaREZ.Registro, 90, 8), "yyyyMMdd", Nothing)
                End If
                filaDAZ.DAZ_TEXTOPOS = Mid(filaREZ.Registro, 98, 50)
                If Mid(filaREZ.Registro, 148, 4) <> "0000" Then
                    'filaDAZ.DAZ_FECHAz = CDate(Format(DateSerial(Mid(filaREZ.Registro, 148, 4), Mid(filaREZ.Registro, 152, 2), Mid(filaREZ.Registro, 154, 2)), "dd/MM/yyyy") & " " & Format(TimeSerial(Mid(filaREZ.Registro, 156, 2), Mid(filaREZ.Registro, 158, 2), Mid(filaREZ.Registro, 160, 2)), "hh:mm:ss"))
                    filaDAZ.DAZ_FECHAz = DateTime.ParseExact(Mid(filaREZ.Registro, 148, 8), "yyyyMMdd", Nothing)
                Else
                    filaDAZ.SetDAZ_FECHAzNull()
                End If
                filaDAZ.DAZ_MEDIOPAGO = Mid(filaREZ.Registro, 162, 12)
                filaDAZ.DAZ_RETENCION = Mid(filaREZ.Registro, 174, 30)
                If Mid(filaREZ.Registro, 204, 4) <> "0000" Then
                    'filaDAZ.DAZ_FECHADEP = DateSerial(Mid(filaREZ.Registro, 204, 4), Mid(filaREZ.Registro, 208, 2), Mid(filaREZ.Registro, 210, 2))
                    filaDAZ.DAZ_FECHADEP = DateTime.ParseExact(Mid(filaREZ.Registro, 204, 8), "yyyyMMdd", Nothing)
                Else
                    filaDAZ.SetDAZ_FECHADEPNull()
                End If
                filaDAZ.DAZ_DIAS = Mid(filaREZ.Registro, 212, 1)
                filaDAZ.DAZ_UNIDAD = Mid(filaREZ.Registro, 213, 20)
                filaDAZ.DAZ_VIA = Mid(filaREZ.Registro, 233, 1)
                filaDAZ.DAZ_CLAVEBANCO = Mid(filaREZ.Registro, 234, 5)
                filaDAZ.DAZ_ESTATUS = Mid(filaREZ.Registro, 239, 2)
                filaDAZ.DAZ_ENVIADOBANCO = Mid(filaREZ.Registro, 241, 1)
                filaDAZ.DAZ_ANULADO = Mid(filaREZ.Registro, 242, 1)
                If Mid(filaREZ.Registro, 243, 4) <> "0000" Then
                    'filaDAZ.DAZ_FECHAANU = DateSerial(Mid(filaREZ.Registro, 243, 4), Mid(filaREZ.Registro, 247, 2), Mid(filaREZ.Registro, 249, 2)) + TimeSerial(Mid(filaREZ.Registro, 251, 2), Mid(filaREZ.Registro, 253, 2), Mid(filaREZ.Registro, 255, 2))
                    Dim fec As String = Mid(filaREZ.Registro, 243, 12)
                    filaDAZ.DAZ_FECHAANU = DateTime.ParseExact(fec, "yyyyMMddHHmm", Nothing)
                End If
                filaDAZ.DAZ_ESTADO = "C"
                If Mid(filaREZ.Registro, 204, 4) <> "0000" Then
                    filaDAZ.DAZ_FECHADIS = FechaDis(filaDAZ.DAZ_FECHADEP, filaDAZ.DAZ_DIAS)
                End If
                filaDAZ.DAZ_GLOSA = Mid(filaREZ.Registro, 257, 25)
                taDAZ.Update(dtDAZ)
                filaREZ.REZ_PROCESADO = Now
                taREZ.Update(dtREZ)
            End If
        Next
        If Mensaje <> "" Then
            MsgBox(Mensaje, vbInformation, "Depositos Cambiados de Banco")
        End If

        Me.Close()
        Exit Sub

    End Sub
    Private Function FechaDis(FechaDep As Date, dias As Integer) As Date
        ' determinación de fecha disponible
        ' DIS=DEP+Dias Habiles
        Dim Fecha As Date
        Dim Habil As Integer
        Habil = 0
        Fecha = FechaDep
        Dim filas() As DataRow
        Do
            Criterio = "FER_FERIADO=#" & Format(Fecha, "MM/dd/yyyy") & "#"
            filas = dtFER.Select(Criterio)
            If filas.Length = 0 Then
                If Habil = dias Then
                    Exit Do
                End If
                Habil = Habil + 1
            End If
            Fecha = Fecha.AddDays(1)
        Loop
        FechaDis = Fecha
    End Function


    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

End Class