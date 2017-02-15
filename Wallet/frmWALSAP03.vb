Public Class frmWALSAP03
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
        Else
            ConectarSAP = True
        End If
    End Function

    Private Sub tsbProcesar_Click(sender As Object, e As EventArgs) Handles tsbProcesar.Click
        Dim filas() As DataRow
        Cursor = Cursors.WaitCursor
        taFER.Fill(dtFER)
        Cursor = Cursors.Default
        Dim iLinea As Integer
        Dim iRows As Integer

        If Not ConectarSAP() Then
            ' No Conecto
            Me.Close()
        Else
            ' Establecer contacto con la funcion.

            SAPFunctions1.Connection = R3
            MyFunc = SAPFunctions1.Add("HOLIDAY_GET")
            MyFunc.Exports("HOLIDAY_CALENDAR") = "  "
            MyFunc.Exports("FACTORY_CALENDAR") = "Z5"
            MyFunc.Exports("DATE_FROM") = Me.DateTimePicker1.Value
            MyFunc.Exports("DATE_TO") = Me.DateTimePicker2.Value


            ' Llamar a la funcion de SAP.
            Resultado = MyFunc.Call
            ' Analizar el resultado de la llamada.
            If Resultado = False Then
                MsgBox("Error en el llamado a la funcion HOLIDAY_GET.")
                Exit Sub
            Else
                ' Recoger los parametros devueltos por la funcion - IMPORTING
                ' Recoger los parametros devueltos por la funcion - TABLES
                TablasRecibidas = MyFunc.Tables("HOLIDAYS")
                iLinea = 0
                iRows = TablasRecibidas.RowCount
                Me.ProgressBar1.Maximum = iRows + 1
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Value = 0
                Dim Feriado As String
                Dim Act As Long
                'If DE1.Fondo.State = adStateClosed Then
                '    DE1.Fondo.Open
                'End If
                If iRows = 0 Then
                    MsgBox("No se han encontrado registros de Feriados.")
                    Me.Close()
                Else
                    ' se encontraron registra actualizar
                    ' borrar los feriados del periodo
                    Dim Ejecutar As New dsWALSAPTableAdapters.QueriesTableAdapter
                    Ejecutar.BorrarFeriados(DateTimePicker1.Value, DateTimePicker2.Value)
                    Do While Not (iLinea = iRows)
                        iLinea = iLinea + 1
                        Feriado = TablasRecibidas.Value(iLinea, "DATE")

                        ' No se encontraron registros, se crean
                        filaFER = dtFER.NewTESFERRow
                        filaFER.FER_FERIADO = Feriado
                        dtFER.AddTESFERRow(filaFER)
                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop
                    taFER.Update(dtFER)
                End If
            End If
            ' Terminar la sesion.
            R3.Logoff
            On Error GoTo 0

        End If
        Me.Close()
        Exit Sub

    End Sub

    Private Sub frmWALSAP03_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DateTimePicker1.Value = Today
        Me.DateTimePicker2.Value = Today

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
End Class