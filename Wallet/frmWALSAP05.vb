Public Class frmWALSAP05
    Dim R3 As Object
    Dim SAPFunctions1 As Object = CreateObject("SAP.Functions")
    Dim SAPFunctions2 As Object = CreateObject("SAP.Functions")
    Dim MyFunc As Object
    Dim MyFunc2 As Object
    ' Resultado de la llamada a SAP.
    Dim Resultado As Boolean
    ' Tablas a ser recibidas por la funcion
    Dim TablasRecibidas As Object
    ' Tablas a ser enCTEdas a la funcion
    Dim TablasEnviadas As Object
    Dim objSAPLogonCtrl As Object
    ' Tabla de Proveedores
    Dim taCTE As New dsWALSAPTableAdapters.TESCTETableAdapter
    Dim dtCTE As New dsWALSAP.TESCTEDataTable
    Dim filaCTE As dsWALSAP.TESCTERow
    Dim taMON As New dsWALSAPTableAdapters.TESMONTableAdapter
    Dim dtMON As New dsWALSAP.TESMONDataTable
    Dim filaMON As dsWALSAP.TESMONRow
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
        'Dim filas() As DataRow
        Cursor = Cursors.WaitCursor
        taCTE.Fill(dtCTE)
        Cursor = Cursors.Default
        Dim iLinea As Integer
        Dim iRows As Integer

        If Not ConectarSAP() Then
            ' No Conecto
            Me.Close()
        Else
            ' Establecer contacto con la funcion.

            SAPFunctions1.Connection = R3
            MyFunc = SAPFunctions1.Add("Z_F_VIAS_DE_PAGO ")

            MyFunc.Exports("P_LAND") = "CL"

            ' Llamar a la funcion de SAP.
            Resultado = MyFunc.Call
            ' Analizar el resultado de la llamada.
            If Resultado = False Then
                MsgBox("Error en el llamado a la funcion Z_F_CTES_DE_PAGO.")
                Exit Sub
            Else
                ' Recoger los parametros devueltos por la funcion - IMPORTING
                ' Recoger los parametros devueltos por la funcion - TABLES
                TablasRecibidas = MyFunc.Tables("S_TABLA_BANCOS")
                iLinea = 0
                iRows = TablasRecibidas.RowCount
                Me.ProgressBar1.Maximum = iRows + 1
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Value = 0
                Dim Sociedad As String
                Dim filtro As String
                filtro = "1000"
                Dim CodBanco As String
                Dim CuentaID As String
                Dim Glosa As String
                Dim Cuenta As String
                Dim CtaCble As String
                Dim Moneda As String
                Dim Via As String
                If iRows = 0 Then
                    MsgBox("No se han encontrado registros de Cuentas de Banco.")
                    Me.Close()
                Else
                    ' se encontraron registra actualizar
                    Do While Not (iLinea = iRows)
                        iLinea = iLinea + 1
                        Sociedad = TablasRecibidas.Value(iLinea, "BUKRS")           'Sociedad
                        If Sociedad <> filtro Then Continue Do
                        CodBanco = TablasRecibidas.Value(iLinea, "HBKID")          'Abreviatura
                        CuentaID = TablasRecibidas.Value(iLinea, "HKTID")         'Código Banco
                        Glosa = TablasRecibidas.Value(iLinea, "TEXT1")         'Glosa
                        Cuenta = TablasRecibidas.Value(iLinea, "BANKN")           'Numero de Cuenta
                        CtaCble = TablasRecibidas.Value(iLinea, "WEKON")          'Cuenta Contable
                        Moneda = TablasRecibidas.Value(iLinea, "WAERS")         'Moneda
                        Via = TablasRecibidas.Value(iLinea, "ZLSCH")         'Via de PAgo
                        If Sociedad <> "" Then
                            ' Actualización de TESCTE
                            taCTE.FillByContableVia(dtCTE, CtaCble, Via)
                            If dtCTE.Count = 0 Then
                                ' no existe se crea
                                filaCTE = dtCTE.NewTESCTERow
                                filaCTE.CTE_AUDITORIA = Auditoria("")
                                filaCTE.CTE_CODBANCO = CodBanco
                                filaCTE.CTE_CONTABLE = CtaCble
                                filaCTE.CTE_NUMERO = Cuenta
                                If Glosa.Length > 13 Then
                                    filaCTE.CTE_SIGLA = Glosa.Substring(0, 13)
                                Else
                                    filaCTE.CTE_SIGLA = Glosa

                                End If
                                filaCTE.CTE_SOCIEDAD = Sociedad
                                filaCTE.CTE_VIA = Via
                                filaCTE.CTE_MONEDASAP = Moneda
                                filaCTE.EMP_CODIGO = 1
                                filaCTE.CTE_TIPO = 1
                                filaCTE.CTE_GRUPO = "01"
                                filaCTE.CTE_PLAZA = "320"
                                ' actualiza Entidad
                                taENT.FillByEntSAP(dtENT, CodBanco)
                                If dtENT.Count = 0 Then
                                    MsgBox("Cuenta tiene asignada una Entidad desconocida para el Sistema: " & CodBanco, MsgBoxStyle.Critical, "Mensaje de Error")
                                    Continue Do
                                Else
                                    filaENT = dtENT.Item(0)
                                    filaCTE.ENT_CODIGO = filaENT.ENT_CODIGO
                                End If
                                ' Actualiza moneda
                                taMON.FillByCodISO(dtMON, Moneda)
                                If dtMON.Count = 0 Then
                                    MsgBox("Cuenta tiene asignada una Moneda desconocida para el Sistema", MsgBoxStyle.Critical, "Mensaje de Error")
                                Else
                                    filaMON = dtMON.Item(0)
                                    filaCTE.MON_CODIGO = filaMON.MON_CODIGO
                                End If

                                dtCTE.AddTESCTERow(filaCTE)
                                taCTE.Update(dtCTE)
                                filaCTE.CTE_MADRE = filaCTE.CTE_CODIGO
                                taCTE.Update(dtCTE)
                            End If


                        End If
                        Sociedad = ""
                        Me.ProgressBar1.Value = iLinea
                        Application.DoEvents()
                    Loop
                    taCTE.Update(dtCTE)
                End If
            End If
            ' Terminar la sesion.

        End If
        Me.Close()
        Exit Sub

    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
End Class