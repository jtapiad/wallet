Imports System.Text.RegularExpressions
Module SeguridadModulo1
    Public Const userRoot As String = "HKEY_CURRENT_USER"
    Public Const subkey As String = "Wallet"
    Public Const keyName As String = userRoot & "\" & subkey
    Public EstPantallaPlanilla As Integer
    Public Nuevo As Boolean = False
    Public Structure Acciones
        Public accion As Integer
        Public clave As Long
        Public Texto As String
        Public Planilla As Long
    End Structure
    Public ConServidor As String
    Public ConUsuario As String
    Public ConClave As String
    Public ConBaseDatos As String

    Public Structure Usuari
        Public Codigo As Long
        Public Perfil As Long
        Public NombreCompleto As String
        Public Saludos As Boolean
        Public Nombre As String
        Public ParORD01 As Integer ' Cantidad de Ordenes a mostrar
        Public ParORD02 As Integer ' Digitos del Número de Orden
        Public ParORD03 As Integer ' Digitos del Número de la Invoice
        Public ParORD04 As String  ' Muestra lista de Ordenes Recientes
        Public ParORD05 As String  ' Proxima Orden a Imprimir
        Public ParORD06 As String  ' Firma 1
        Public ParORD07 As String  ' Firma 2
        Public ParORD08 As String  ' Forma 3
        Public BotonPoder As Boolean ' Autorización para ingresar fecha de Poder
        Public Reimpresión As Boolean ' Autorización para imprimir
        Public BotonSII As Boolean ' Activa o desactiva boton SII en el ord02
        Public Usuario As String
        Public CodEmpresa As Long
    End Structure
    Public Usuario As Usuari
    Public Structure Cierre

        Public Cuenta As Long
        Public Mayor As Long
        Public SaldoIni As Double
        Public ChequesDev As Double
        Public ChequesGir As Double
        Public ChequesPla As Double
        Public ChequesCar As Double
        Public RecaudacionT3 As Double
        Public RecaudacionT1 As Double
        Public RecaudacionNO As Double
        Public Rescates As Double
        Public OtrosIngresos As Double
        Public TrasfPositivas As Double
        Public TranfNegativas As Double
        Public SaldoManana As Double
    End Structure
    Public Structure Tema
        Public Planilla As Integer
        Public Cierre As Integer
        Public Calendario As Integer
    End Structure
    Public Temas As Tema
    Public Structure Filtros
        Public Orden As Long
        Public Invoice As Long
        Public Factura As Long
        Public AgenteNavesCod As Long
        Public AgenteNavesNom As String
        Public ArmadorCod As Long
        Public ArmadorNom As String
        Public OperadorCod As Long
        Public OperadorNom As String
        Public FechaIni As Date
        Public FechaFin As Date
        Public NaveCod As Long
        Public NaveNom As String
        Public Bloqueada As Boolean
        Public Incompletas As Boolean
        Public NoBloqueada As Boolean
        Public Completas As Boolean
    End Structure
    Public Structure ParametrosGenerales  ' Estructura de parámetros Generales
        Public Planilla As Long    ' Número de Planilla
        Public FechaPro As Date   ' Fecha de Proceso 
        Public Mandante As Integer ' Mandante
    End Structure
    Public parametros As ParametrosGenerales
    Public Structure Accion ' Estructura para guardar los datos en los tag de los formularios.
        Public Accion As Integer
        Public Codigo As String
        Public PRV_CODIGO As Long
        Public PRO_CODIGO As Long
        Public PRP_FECHAPRE As DateTime
    End Structure

    Public HayParametros As Boolean = True
    Public Structure DetaPla
        Public Cuenta As Long
        Public CuentaSAP As String
        Public CuentaSAP2 As String
        Public Planilla As Long
        Public Columna As Integer
        Public NombreColumna As String
        Public Fecha As Date
        Public Banco As String
        Public Grabar As Boolean
    End Structure
    Public DetallePla As DetaPla

    Public Structure CreaOrden
        Public CodAgeNaves As Long
        Public NomAgeNaves As String
        Public Tipo As String
        Public CodTipo As Long
        Public Producto As String
        Public Moneda As String
        Public Accion As Integer
        Public Orden As Long
    End Structure
    Public Structure ImprimirOrden
        Public Accion As Integer
        Public Código As Long
        Public Numero As Long
        Public Armador As String
        Public Nave As String
        Public Puerto As String
        Public FormaPago As String
        Public FechaOrden As Date
        Public Tipo As String
        Public TotalOrden As Double
        Public TotalProductos As Double
        Public Barcaza As Long
        Public FechaIni As Date
        Public FechaFin As Date
        Public NombreBarcaza As String
        Public Cantidad As Double
        Public NombreProducto As String
        Public Aprobado As Boolean
        Public CodFactura As Long
    End Structure
    Public Structure CodigosSAP
        Public Producto As String
        Public CodProducto As Long
        Public CodProductoNuevo As Long
        Public CodMCA As Long
        Public Barcaza As String
        Public Inicio As Date
        Public termino As Date
    End Structure
    Public Structure Carta
        Public CodigoArm As Long
        Public NombreArm As String
        Public Fecha As Date
        Public Inicio As Date
        Public Vencimiento As Date
    End Structure
    Public NombreSistema As String = "Wallet"
    Public LogoSistema As Image = My.Resources.Logo_Wallet
    Public IconoSistema As Icon = My.Resources.IconoWallet
    Public Structure Reportes
        Public Fecha1 As Date
        Public Fecha2 As Date
        Public Codigo1 As Long
        Public Texto1 As String
        Public Codigo2 As Long
        Public Texto2 As String
        Public Codigo3 As Long
        Public Texto3 As String
        Public Codigo4 As Long
        Public Texto4 As String
        Public Codigo5 As Long
        Public Texto5 As String
    End Structure
    Public Structure structMesAno
        Public Mes As Integer
        Public Ano As Integer
    End Structure
    Public MesAno As structMesAno
    Public NumCarta As Long
    Public Alineamiento As String = ""
    Public TipoCelda As String = ""
    Public Function Validar_eMail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Public Structure Action ' Estructura para guardar los datos en los tag de los formularios.
        Public Accion As Integer
        Public Codigo As String
    End Structure
    Public Structure Informes
        Public Reporte As String
        Public Numero As Integer
        Public FechaIni As Date
        Public FechaFin As Date
        Public Argumento1lng As Long
        Public Argumento2lng As Long
        Public Argumento3str As String
        Public Argumento4str As String
        Public DatasTableImp As DataTable
    End Structure
    ' Variables Publices sistema antiguo
    Public DiaSemana(7) As String
    Public Operacion As String
    Public Glo_Banco As String
    Public Glo_Cuenta As Long
    Public Glo_CodCuenta As Long
    Public Glo_Columna_Det As Integer
    Public Glo_Caption As String
    Public Glo_Cambio As Integer
    Public Planilla As Long
    Public PlanillaFondo As Long
    Public Glo_Ingreso As Integer
    Public Glo_Cierre As Integer
    Public Aut_Usuario As String
    Public Aut_Secreta As String

    Public Glo_Argumento As String
    Public Criterio As String
    Public Glo_Producto As String
    Public Glo_RUT As String
    Public Glo_Error As Integer
    Public Glo_Monto As Double
    Public Glo_Glosa As String
    Public Glo_Detalle As Integer
    Public Glo_Accion As Integer
    Public TipoPlanilla As String
    Public DBUsuario As String
    Public DBBase As String
    Public DBServidor As String
    Public DBPassword As String
    Public Mandante As String
    Public Glo_Columna As Integer
    Public Glo_NombreCol As String
    Public Glo_Clave As Long
    Public Glo_NoMostrar As Boolean = False



    Public Function Validar_RUT(ByVal sRut As String) As String
        Dim sRut9 As String '* 13
        Dim sRut8 As String '* 13
        Dim sFinal As String '* 13
        Dim Digito As String '* 1
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim acum As Integer
        Dim Resto As Integer
        Dim Numero As Long
        ' validar Caracteres
        sRut = Trim(sRut)
        sRut9 = UCase(sRut)
        sRut9 = RSet(sRut9, 13)
        sRut9 = Replace(sRut9, ",", ".")
        For i = 1 To 13
            If InStr(1, "1234567890 .-K", Mid(sRut9, i, 1)) = 0 Then
                MsgBox("Se detectó un carácter invalido", MsgBoxStyle.Critical, NombreSistema)
                Validar_RUT = ""
                Exit Function
            End If
            If Mid(sRut9, i, 1) = "K" And i <> 13 Then
                MsgBox("Se detectó una 'K' fuera de posición", MsgBoxStyle.Critical, NombreSistema)
                Validar_RUT = ""
                Exit Function
            End If
        Next i
        ' Limpiar RUT
        sRut8 = Space(13)
        j = 13
        For i = 13 To 1 Step -1
            If InStr(1, " .-", Mid(sRut9, i, 1)) = 0 Then
                Mid(sRut8, j, 1) = Mid(sRut9, i, 1)
                j = j - 1
            End If
        Next i
        sRut9 = sRut8
        If Mid(sRut9, 1, 3) <> "   " Then
            MsgBox("Se detectó un número demasiado grande", MsgBoxStyle.Critical, NombreSistema)
            Validar_RUT = ""
            Exit Function
        End If
        ' Acumular numeros
        j = 2
        acum = 0
        For i = 12 To 1 Step -1
            If Mid(sRut9, i, 1) <> " " Then
                k = Mid(sRut9, i, 1)
                acum = acum + k * j
                j = j + 1
                If j > 7 Then
                    j = 2
                End If
            End If
        Next i
        ' Determinar Resto
        Resto = acum Mod 11

        ' Determinar Digito Verificador
        If Resto = 0 Then
            Digito = "0"
        Else
            If Resto = 1 Then
                Digito = "K"
            Else
                Digito = 11 - Resto
            End If
        End If
        ' verificar si corresponde
        If Digito <> Mid(sRut9, 13, 1) Then
            MsgBox("Dígito Verificador Incorrecto", MsgBoxStyle.Critical, NombreSistema)
            Validar_RUT = ""
            Exit Function
        Else
            Numero = Mid(sRut9, 1, 12)
            sFinal = Format(Numero, "###,###,###") & "-" & Mid(sRut9, 13, 1)
            RSet(sFinal, 13)
            sFinal = Replace(sFinal, ",", ".")
            Validar_RUT = sFinal
            Exit Function
        End If
    End Function
    Public Function Validar_RUT_Masivo(ByVal sRut As String) As String
        Dim sRut9 As String '* 13
        Dim sRut8 As String '* 13
        Dim sFinal As String '* 13
        Dim Digito As String '* 1
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim acum As Integer
        Dim Resto As Integer
        Dim Numero As Long
        ' validar Caracteres
        sRut = Trim(sRut)
        sRut9 = UCase(sRut)
        sRut9 = RSet(sRut9, 13)
        sRut9 = Replace(sRut9, ",", ".")
        For i = 1 To 13
            If InStr(1, "1234567890 .-K", Mid(sRut9, i, 1)) = 0 Then
                Validar_RUT_Masivo = ""
                Exit Function
            End If
            If Mid(sRut9, i, 1) = "K" And i <> 13 Then
                Validar_RUT_Masivo = ""
                Exit Function
            End If
        Next i
        ' Limpiar RUT
        sRut8 = Space(13)
        j = 13
        For i = 13 To 1 Step -1
            If InStr(1, " .-", Mid(sRut9, i, 1)) = 0 Then
                Mid(sRut8, j, 1) = Mid(sRut9, i, 1)
                j = j - 1
            End If
        Next i
        sRut9 = sRut8
        If Mid(sRut9, 1, 3) <> "   " Then
            Validar_RUT_Masivo = ""
            Exit Function
        End If
        ' Acumular numeros
        j = 2
        acum = 0
        For i = 12 To 1 Step -1
            If Mid(sRut9, i, 1) <> " " Then
                k = Mid(sRut9, i, 1)
                acum = acum + k * j
                j = j + 1
                If j > 7 Then
                    j = 2
                End If
            End If
        Next i
        ' Determinar Resto
        Resto = acum Mod 11

        ' Determinar Digito Verificador
        If Resto = 0 Then
            Digito = "0"
        Else
            If Resto = 1 Then
                Digito = "K"
            Else
                Digito = 11 - Resto
            End If
        End If
        ' verificar si corresponde
        If Digito <> Mid(sRut9, 13, 1) Then
            Validar_RUT_Masivo = ""
            Exit Function
        Else
            Numero = Mid(sRut9, 1, 12)
            sFinal = Format(Numero, "###,###,###") & "-" & Mid(sRut9, 13, 1)
            RSet(sFinal, 13)
            sFinal = Replace(sFinal, ",", ".")
            Validar_RUT_Masivo = sFinal
            Exit Function
        End If
    End Function
    Public Function Auditoria(Campos As String) As String
        If Campos = "" Then
            Campos = Space(44)
            Mid(Campos, 1, 10) = Usuario.Usuario
            Mid(Campos, 11, 8) = Format(Now, "yyyyMMdd")
            Mid(Campos, 19, 4) = Format(Now, "hhmm")
        Else
            Mid(Campos, 23, 10) = Usuario.Usuario
            Mid(Campos, 33, 8) = Format(Now, "yyyyMMdd")
            Mid(Campos, 41, 4) = Format(Now, "hhmm")
        End If
        Auditoria = Campos
    End Function

    Public Function Generacion_Detalles(Cuenta As Integer, Monto As Double, Glosa As String, Columna As Integer) As Double
        'On Error Resume Next
        'DE1.rsTrae_DetallePlanilla.Close
        'DE1.Detalle_Operaciones
        'DE1.ChequesEmitidos
        'DE1.rsTrae_Planilla.Close
        'DE1.Lee_Ultimo_Detalle
        'DE1.rsLee_Ultimo_Detalle.Close
        'On Error GoTo 0

        'DE1.Trae_DetallePlanilla Planilla, Cuenta



        Dim taDetPla As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
        Dim dtDetPla As New dsWALPLA.DetallePlanillaDataTable
        Dim filaDetPla As dsWALPLA.DetallePlanillaRow
        taDetPla.FillByPlanillaCuenta(dtDetPla, Planilla, Cuenta)
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



        filaDetOpe.DPL_CODIGO = filaDetPla.DPL_CODIGO
        filaDetOpe.COL_CODIGO = Columna
        filaDetOpe.DOP_MONTO = Monto
        filaDetOpe.DOP_TIPO = "D"
        If Len(Glosa) > 50 Then Glosa = Mid(Glosa, 1, 50)
        filaDetOpe.DOP_GLOSAADIC = Replace(Glosa, "°", " ")
        filaDetOpe.DOP_AUDITORIA = ""
        filaDetOpe.DOP_AUDITORIA = Auditoria(filaDetOpe.DOP_AUDITORIA)
        dtDetOpe.AddTESDOPRow(filaDetOpe)
        taDetOpe.Update(dtDetOpe)
        'DE1.rsDetalle_Operaciones.Update
        'DE1.rsDetalle_Operaciones.Resync adAffectCurrent

        'recupera el último DOP_CODIGO
        Dim ultimoDOP_CODIGO As Double
        'DE1.Lee_Ultimo_Detalle
        ultimoDOP_CODIGO = filaDetOpe.DOP_CODIGO

        Dim taCheEmi As New dsWALPLATableAdapters.TESCHATableAdapter
        Dim dtCheEmi As New dsWALPLA.TESCHADataTable
        Dim filaCheEmi As dsWALPLA.TESCHARow

        filaCheEmi = dtCheEmi.NewTESCHARow

        filaCheEmi.dop_codigo = filaDetOpe.DOP_CODIGO
        filaCheEmi.CTE_CODIGO = Cuenta
        filaCheEmi.CH2_FECHA = filaTraePla.PLA_FECHA
        filaCheEmi.CH2_MONTO = Monto
        filaCheEmi.CH2_MARCA = "N"
        dtCheEmi.AddTESCHARow(filaCheEmi)
        taCheEmi.Update(dtCheEmi)
        'DE1.rsChequesEmitidos.Update

        TotalporColumna(Planilla, Columna)

        'retorna código
        Generacion_Detalles = ultimoDOP_CODIGO

    End Function
    Public Sub Generacion_Detalles2(CuentaOrigen As Integer, CuentaDestino As Integer, Monto As Double, Glosa As String, Adicional As String)
        ' generación de transferencias

        '    On Error Resume Next
        '    DE1.rsTrae_DetallePlanilla.Close
        '    DE1.Detalle_Operaciones
        '    DE1.ChequesEmitidos
        '    DE1.rsTrae_Planilla.Close
        '    On Error GoTo 0

        '    DE1.Trae_Planilla Planilla

        '' graba operación de Origen
        '    DE1.Trae_DetallePlanilla Planilla, CuentaOrigen

        Dim taDetPla As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
        Dim dtDetPla As New dsWALPLA.DetallePlanillaDataTable
        Dim filaDetPla As dsWALPLA.DetallePlanillaRow
        Dim taTraePla As New dsWALPLATableAdapters.TESPLATableAdapter
        Dim dtTraePla As New dsWALPLA.TESPLADataTable
        Dim filaTraePla As dsWALPLA.TESPLARow
        Dim taDetOpe As New dsWALPLATableAdapters.TESDOPTableAdapter
        Dim dtDetOpe As New dsWALPLA.TESDOPDataTable
        Dim filaDetOpe As dsWALPLA.TESDOPRow


        taDetPla.FillByPlanillaCuenta(dtDetPla, Planilla, CuentaOrigen)
        filaDetPla = dtDetPla.Item(0)
        taTraePla.FillByPlanilla(dtTraePla, Planilla)
        filaTraePla = dtTraePla.Item(0)


        filaDetOpe = dtDetOpe.NewTESDOPRow



        filaDetOpe.DPL_CODIGO = filaDetPla.DPL_CODIGO
        filaDetOpe.COL_CODIGO = 12
        filaDetOpe.DOP_MONTO = Monto
        filaDetOpe.DOP_TIPO = "D"
        filaDetOpe.DOP_GLOSAADIC = "Transferencia a cuenta " & CuentaDestino
        filaDetOpe.DOP_AUDITORIA = ""
        filaDetOpe.DOP_AUDITORIA = Auditoria(filaDetOpe.DOP_AUDITORIA)
        dtDetOpe.AddTESDOPRow(filaDetOpe)
        taDetOpe.Update(dtDetOpe)



        'recupera el último DOP_CODIGO
        Dim ultimoDOP_CODIGO As Double
        'DE1.Lee_Ultimo_Detalle
        ultimoDOP_CODIGO = filaDetOpe.DOP_CODIGO

        Dim taCheEmi As New dsWALPLATableAdapters.TESCHATableAdapter
        Dim dtCheEmi As New dsWALPLA.TESCHADataTable
        Dim filaCheEmi As dsWALPLA.TESCHARow

        filaCheEmi = dtCheEmi.NewTESCHARow

        filaCheEmi.DOP_CODIGO = filaDetOpe.DOP_CODIGO
        filaCheEmi.CTE_CODIGO = CuentaOrigen
        filaCheEmi.CH2_FECHA = filaTraePla.PLA_FECHA
        filaCheEmi.CH2_MONTO = Monto
        filaCheEmi.CH2_MARCA = "N"
        dtCheEmi.AddTESCHARow(filaCheEmi)
        taCheEmi.Update(dtCheEmi)

        TotalporColumna(Planilla, 12)


        filaDetOpe = dtDetOpe.NewTESDOPRow



        filaDetOpe.DPL_CODIGO = filaDetPla.DPL_CODIGO
        filaDetOpe.COL_CODIGO = 11
        filaDetOpe.DOP_MONTO = Monto
        filaDetOpe.DOP_TIPO = "D"
        filaDetOpe.DOP_GLOSAADIC = "Transferencia desde cuenta " & CuentaOrigen
        filaDetOpe.DOP_AUDITORIA = ""
        filaDetOpe.DOP_AUDITORIA = Auditoria(filaDetOpe.DOP_AUDITORIA)
        dtDetOpe.AddTESDOPRow(filaDetOpe)
        taDetOpe.Update(dtDetOpe)
        TotalporColumna(Planilla, 11)
        Exit Sub
    End Sub
    Public Sub TotalporColumna(Plamilla As Long, Columna As Integer)
        Dim TotalLinea As Double
        Dim Total As Double
        Dim z As Integer
        Dim n As Double

        'DE1.TotalesCol Planilla, Columna
        Dim taTotCol As New dsWALPLATableAdapters.TotalesColTableAdapter
        Dim dtTotCol As New dsWALPLA.TotalesColDataTable
        Dim filaTotCol As dsWALPLA.TotalesColRow
        Dim taDetPla As New dsWALPLATableAdapters.DetallePlanillaTableAdapter
        Dim dtDetPla As New dsWALPLA.DetallePlanillaDataTable
        Dim filaDetPla As dsWALPLA.DetallePlanillaRow
        Dim taTraeColchon As New dsWALPLATableAdapters.TraeColchonTableAdapter
        Dim dtTraeColchon As New dsWALPLA.TraeColchonDataTable
        Dim filaTraeColchon As dsWALPLA.TraeColchonRow

        taTotCol.FillbyPlanillaColumna(dtTotCol, Planilla, Columna)

        z = 0
        taDetPla.FillByPlanilla(dtDetPla, Planilla)
        'For i = 0 To dtTotCol.Count - 1
        For i = 0 To dtDetPla.Count - 1
            filaDetPla = dtDetPla.Item(i)
            Dim Filas() As DataRow = dtTotCol.Select("cuenta=" & filaDetPla.CTE_CODIGO.ToString)
            If Filas.Length = 0 Then
                Total = 0
            Else
                filaTotCol = TryCast(Filas(0), dsWALPLA.TotalesColRow)
                Total = filaTotCol.Total
            End If
            'filaTotCol = dtTotCol.Item(i)
            'DE1.Trae_DetallePlanilla Planilla, DE1.rsTotalesCol!Cuenta
            'taDetPla.FillByPlanillaCuenta(dtDetPla, Planilla, filaTotCol.Cuenta)
            'filaDetPla = dtDetPla.Item(0)
            Select Case Columna
                Case 2
                    filaDetPla.DPL_SALDOINI = Total
                Case 3
                    filaDetPla.DPL_RESCATES = Total
                Case 4
                    filaDetPla.DPL_RECAUDACION = Total
                Case 5
                    filaDetPla.DPL_CHEQUESDEV = Total
                Case 6
                    filaDetPla.DPL_APORTES = Total
                Case 7
                    filaDetPla.DPL_OTROSINGRESOS = Total
                Case 8
                    filaDetPla.DPL_PAGOSCHE = Total
                Case 9
                    filaDetPla.DPL_CHEQUESCAR = Total
                Case 10
                    filaDetPla.DPL_PAGOSCAR = Total
                Case 11
                    filaDetPla.DPL_TRANSFERENCIASPOS = Total
                Case 12
                    filaDetPla.DPL_TRANSFERENCIASNEG = Total
                Case 14
                    filaDetPla.DPL_COLOCACIONES = Total
            End Select

            ' Calculo del Saldo
            TotalLinea = filaDetPla.DPL_SALDOINI +
            filaDetPla.DPL_RESCATES +
            filaDetPla.DPL_RECAUDACION -
            filaDetPla.DPL_CHEQUESDEV +
            filaDetPla.DPL_CHEQUESCAR +
            filaDetPla.DPL_APORTES +
            filaDetPla.DPL_OTROSINGRESOS -
            filaDetPla.DPL_PAGOSCHE -
            filaDetPla.DPL_PAGOSCAR +
            filaDetPla.DPL_TRANSFERENCIASPOS -
            filaDetPla.DPL_TRANSFERENCIASNEG -
            filaDetPla.DPL_COLOCACIONES

            filaDetPla.DPL_SALDO = TotalLinea


            'DE1.Trae_Colchon DE1.rsTotalesCol!Cuenta          
            taTraeColchon.FillByCteCodigo(dtTraeColchon, filaDetPla.CTE_CODIGO)
            filaTraeColchon = dtTraeColchon.Item(0)

            If IsNumeric(filaTraeColchon.CTE_COLCHON1) Then
                If TotalLinea > filaTraeColchon.CTE_COLCHON1 Then
                    filaDetPla.DPL_PORCOLOCAR = TotalLinea - filaTraeColchon.CTE_COLCHON1
                Else
                    filaDetPla.DPL_PORCOLOCAR = 0
                End If
            Else
                filaDetPla.DPL_PORCOLOCAR = TotalLinea
            End If

            If filaDetPla.DPL_PORCOLOCAR < 1000000 Then
                filaDetPla.DPL_PORCOLOCAR = 0
            Else
                n = Int(filaDetPla.DPL_PORCOLOCAR / 500000)
                filaDetPla.DPL_PORCOLOCAR = (500000 * n)
            End If
            taDetPla.Update(dtDetPla)
        Next
    End Sub

    Public Function Validar_RUTEP(ByVal sRut As String, EP As ErrorProvider, tb As TextBox) As String
        Dim sRut9 As String '* 13
        Dim sRut8 As String '* 13
        Dim sFinal As String '* 13
        Dim Digito As String '* 1
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim acum As Integer
        Dim Resto As Integer
        Dim Numero As Long
        ' validar Caracteres

        sRut9 = UCase(sRut)
        sRut9 = RSet(sRut9, 13)
        sRut9 = Replace(sRut9, ",", ".")
        For i = 1 To 13
            If InStr(1, "1234567890 .-K", Mid(sRut9, i, 1)) = 0 Then
                'MsgBox("Se detectó un carácter invalido", MsgBoxStyle.Critical, NombreSistema)
                EP.SetError(tb, "Se detectó un carácter inválido")
                Validar_RUTEP = ""
                Exit Function
            End If
            If Mid(sRut9, i, 1) = "K" And i <> 13 Then
                'MsgBox("Se detectó una 'K' fuera de posición", MsgBoxStyle.Critical, NombreSistema)
                EP.SetError(tb, "Se detectó una 'K' fuera de posición")
                Validar_RUTEP = ""
                Exit Function
            End If
        Next i
        ' Limpiar RUT
        sRut8 = Space(13)
        j = 13
        For i = 13 To 1 Step -1
            If InStr(1, " .-", Mid(sRut9, i, 1)) = 0 Then
                Mid(sRut8, j, 1) = Mid(sRut9, i, 1)
                j = j - 1
            End If
        Next i
        sRut9 = sRut8
        If Mid(sRut9, 1, 3) <> "   " Then
            'MsgBox("Se detectó un número demasiado grande", MsgBoxStyle.Critical, NombreSistema)
            EP.SetError(tb, "Se detectó un número demasiado grande")
            Validar_RUTEP = ""
            Exit Function
        End If
        ' Acumular numeros
        j = 2
        acum = 0
        For i = 12 To 1 Step -1
            If Mid(sRut9, i, 1) <> " " Then
                k = Mid(sRut9, i, 1)
                acum = acum + k * j
                j = j + 1
                If j > 7 Then
                    j = 2
                End If
            End If
        Next i
        ' Determinar Resto
        Resto = acum Mod 11

        ' Determinar Digito Verificador
        If Resto = 0 Then
            Digito = "0"
        Else
            If Resto = 1 Then
                Digito = "K"
            Else
                Digito = 11 - Resto
            End If
        End If
        ' verificar si corresponde
        If Digito <> Mid(sRut9, 13, 1) Then
            'MsgBox("Dígito Verificador Incorrecto", MsgBoxStyle.Critical, NombreSistema)
            EP.SetError(tb, "Dígito Verificador Incorrecto")
            Validar_RUTEP = ""
            Exit Function
        Else
            Numero = Mid(sRut9, 1, 12)
            sFinal = Format(Numero, "###,###,###") & "-" & Mid(sRut9, 13, 1)
            RSet(sFinal, 13)
            sFinal = Replace(sFinal, ",", ".")
            Validar_RUTEP = sFinal
            Exit Function
        End If
    End Function
    Function CorrigeFeriado(parFecha As Date, sentidoCorreccion As Integer)
        'el sentido de correcion indica si avanza o retrocede en los días para encontrar el día hábil no feriado
        'más próximo se toma el metodo sumar 1 dia y restar 2, hasta encontrar dicha fecha

        Dim parFechaFormato As String
        Dim taFer As New dsWALCOTTableAdapters.TESFERTableAdapter
        Dim dtFER As New dsWALCOT.TESFERDataTable
        Dim fileFER As dsWALCOT.TESFERRow
        On Error Resume Next
        taFer.FillByFecha(dtFER, parFecha)
        If dtFER.Count > 0 Then
            Select Case sentidoCorreccion
                Case 1
                    parFecha = parFecha.AddDays(1)
                    CorrigeFeriado(parFecha, 1)
                Case 2
                    parFecha = parFecha.AddDays(-1)
                    CorrigeFeriado(parFecha, 2)
            End Select
        End If
        CorrigeFeriado = parFecha
    End Function
End Module
