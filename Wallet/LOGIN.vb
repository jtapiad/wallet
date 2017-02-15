Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml
Imports Microsoft.Win32
Imports System.Environment

Public Class LOGIN
    ''' <summary>
    ''' Nombre Programa : LOGIN
    ''' Descripción     : Conexión al Sistema
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudio González Vache
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim taPAR As New dsWALPLATableAdapters.TESPARTableAdapter
    Dim dtPAR As New dsWALPLA.TESPARDataTable
    Dim filaPAR As dsWALPLA.TESPARRow
    ''' <summary>
    ''' Pantalla de conexión al sistema
    ''' </summary>
    ''' <remarks> Determina la validez de la contraseña a través de un procedimiento de almacenado.</remarks>
    Private Sub BtnAcepta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAcepta.Click
        'limpio error provider en caso de que haya algo de la conexión
        Me.ErrorProvider.Clear()

        'Para leer la contraseña
        Dim daContraseña As New dsSEGUSU._SEGUSU_LeeContraseñaDataTable
        Dim dtContraseña As New dsSEGUSUTableAdapters.SEGUSU_LeeContraseñaTableAdapter

        'Para traer los datos del usuario
        Dim daDatos As New dsSEGUSU.SEGUSUDataTable
        Dim dtDatos As New dsSEGUSUTableAdapters.SEGUSUTableAdapter

        'Traigo los datos del usuario para determinar el código
        Try
            dtDatos.FillBySEGUSU_USERNAME(daDatos, Me.SEGUSU_USERNAMETextBox.Text)
        Catch ex As Exception
            MsgBox("Se detectó un problema en la conexión con la Base de Datos, por favor avise al administrador del Sistema", MsgBoxStyle.Critical, NombreSistema)
            Me.Close()
        End Try

        If daDatos.Count <> 0 Then
            Dim FilaDatos As dsSEGUSU.SEGUSURow
            FilaDatos = daDatos.Item(0)
            'verificación de Finiquito
            If FilaDatos.SEGUSU_FINIQUITO = True Then
                Me.ErrorProvider.SetError(Me.SEGUSU_USERNAMETextBox, "Usuario Finiquitado")
                Exit Sub
            End If
            'Verificacion de Bloqueo
            If FilaDatos.SEGUSU_BLOQUEADO = True Then
                If FilaDatos.SEGUSU_FECHABLO.Date <= Today And FilaDatos.SEGUSU_FECHAFIN.Date >= Today Then
                    Me.ErrorProvider.SetError(Me.SEGUSU_USERNAMETextBox, "Usuario Bloqueado del " & FormatDateTime(FilaDatos.SEGUSU_FECHABLO, DateFormat.ShortDate) & " hasta el " & FormatDateTime(FilaDatos.SEGUSU_FECHAFIN, DateFormat.ShortDate))
                    Exit Sub
                End If
            End If


            'Los datos del usuario se guardan en variable global "Usuario" con estructura USU

            Usuario.Codigo = FilaDatos.SEGUSU_CODIGO
            Usuario.Perfil = FilaDatos.SEGPER_CODIGO
            Usuario.NombreCompleto = FilaDatos.SEGUSU_COMPLETO
            Usuario.Saludos = FilaDatos.SEGUSU_SALUDOS
            Usuario.Nombre = FilaDatos.SEGUSU_NOMBRES
            Usuario.Usuario = FilaDatos.SEGUSU_USERNAME
            Usuario.CodEmpresa = 1  ' Solo COPEC
            CargarParámetros()
            'Reviso si el usuario puede conectarse a este programa
            If RevisoPerfil() Then
                'leo la contraseña para ver si está correcta
                dtContraseña.Fill(daContraseña, Usuario.Codigo, Me.SEGUSU_PASSWORDTextBox.Text)
                Dim FilaContraseña As dsSEGUSU._SEGUSU_LeeContraseñaRow
                FilaContraseña = daContraseña.Item(0)

                Me.ErrorProvider.Clear()

                Select Case FilaContraseña.Respuesta
                    Case 0 'Contraseña Incorrecta
                        Me.ErrorProvider.SetError(Me.SEGUSU_PASSWORDTextBox, "Contraseña incorrecta")
                    Case 1 'Contraseña Correcta
                        MDIPrincipal.Show()
                        Me.Close()
                    Case 2 'No existe
                        Me.ErrorProvider.SetError(Me.SEGUSU_USERNAMETextBox, "Usuario no existe")
                End Select
            Else
                Me.ErrorProvider.SetError(Me.SEGUSU_USERNAMETextBox, "Este usuario no tiene autorización para ingresar a este sistema")
            End If

        Else

            'El usuario no existe
            Me.ErrorProvider.SetError(Me.SEGUSU_USERNAMETextBox, "Usuario no existe")

        End If
    End Sub

    Private Function RevisoPerfil() As Boolean
        'Determino que OPC trae el programa que estoy abriendo
        Dim daOPC As New dsSEGPER.SEGOPCDataTable
        Dim dtOPC As New dsSEGPERTableAdapters.SEGOPCTableAdapter
        dtOPC.FillBySEGOPC_MENU(daOPC, "Wallet")

        If daOPC.Count = 0 Then
            'El programa que no está dentro de las opciones de los perfiles.
            Return False
        Else
            Dim RegistroOPC As dsSEGPER.SEGOPCRow
            RegistroOPC = daOPC.Item(0)
            Dim OPC As Long
            OPC = RegistroOPC.SEGOPC_CODIGO
            'Determino si la OPC está en la OPP del perfil del usuario
            Dim daPerfil As New dsSEGPER.SEGOPPDataTable
            Dim dtPerfil As New dsSEGPERTableAdapters.SEGOPPTableAdapter
            dtPerfil.FillByDuo(daPerfil, Usuario.Perfil, OPC)
            If daPerfil.Count = 0 Then
                'No tiene autorización para ingresar a este programa
                Return False
            Else
                Return True
            End If
        End If

    End Function

    ''' <summary>
    ''' Cancela la conexión al sistema
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnCancela_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancela.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' Carga el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Despliega el nombre del módulo y la versión que se está ejecutando.</remarks>
    Private Sub LOGIN_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.pbLogo.Image = LogoSistema
        Me.VersionLabel.Text = "Versión " & My.Application.Info.Version.ToString

        TraeDatosConexionEncriptado()

        Try
            taPAR.Fill(dtPAR)
            filaPAR = dtPAR.Item(0)

        Catch ex As Exception
            MsgBox("Usted no se encuentra conectado a la Base de datos." & vbCrLf & "Revise sus datos de conexión o llame a Soporte", MsgBoxStyle.Critical, "Mensajes de Wallet")
            End
        End Try
    End Sub

    Private Sub TraeDatosConexionEncriptado()
        'Definiciones del Descifrador
        Dim FraseClave As String = "2sysCipherWallet"

        Dim key As Byte() = Encoding.UTF8.GetBytes(FraseClave)
        Dim IV As Byte() = Encoding.UTF8.GetBytes(Mid(FraseClave, 1, 16))
        Dim cryptObj As New RijndaelManaged

        cryptObj = New RijndaelManaged()
        cryptObj.BlockSize = 128
        cryptObj.KeySize = 128
        cryptObj.Mode = CipherMode.ECB
        cryptObj.Padding = PaddingMode.PKCS7
        cryptObj.Key = key
        cryptObj.IV = IV

        Dim ArchivoDescifrar As String = String.Empty

        Try
            Dim ms As New MemoryStream
            Dim ArchivoClave As String = GetFolderPath(SpecialFolder.MyDocuments) & "\Wallet\WalletCrip.config"
            Dim FileReadStream As FileStream = New FileStream(ArchivoClave, FileMode.Open)
            Dim cs As New CryptoStream(FileReadStream, cryptObj.CreateDecryptor(), CryptoStreamMode.Read)

            Dim MyStreamReader As New StreamReader(cs)




            Dim Datos As String = MyStreamReader.ReadToEnd
            ms.Close()
            Dim Documento As New XmlDocument
            Documento.LoadXml(Datos)

            ConServidor = Documento.Item("CONF").Item("Servidor").InnerText
            ConUsuario = Documento.Item("CONF").Item("Usuario").InnerText
            ConClave = Documento.Item("CONF").Item("Password").InnerText
            ConBaseDatos = Documento.Item("CONF").Item("Base").InnerText

            Dim StringConexion As String = My.Settings.WalletConnectionString1
            StringConexion = StringConexion.Replace("#Servidor#", ConServidor)
            StringConexion = StringConexion.Replace("#Usuario#", ConUsuario)
            StringConexion = StringConexion.Replace("#Password#", ConClave)
            StringConexion = StringConexion.Replace("#Base#", ConBaseDatos)

            My.Settings.Item("WalletConnectionString1") = StringConexion

        Catch ex As Exception

        End Try




    End Sub


    Private Sub CargarParámetros()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(subkey, True) ' True indica que se abre para escritura
        If key Is Nothing Then ' Si key es Nothing significa que no se encontró
            Registry.CurrentUser.CreateSubKey(subkey)
        End If
        Temas.Planilla = Registry.GetValue(keyName, "Planilla", "7")
        Temas.Cierre = Registry.GetValue(keyName, "Cierre", "7")
        Temas.Calendario = Registry.GetValue(keyName, "Calendario", "1")
        parametros.Planilla = filaPAR.PAR_PLANILLA
        parametros.FechaPro = filaPAR.PAR_FECHAPRO
        parametros.Mandante = filaPAR.PAR_MANDANTE
    End Sub
End Class