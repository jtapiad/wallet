Imports System.Runtime.InteropServices
Imports System.Data.SqlClient


Public Class MDIPrincipal
    ''' <summary>
    ''' Nombre Programa : MDIPrincipal
    ''' Descripción     : Pantalla Principal
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudio González Vache
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>
    Dim taVAM As New dsWALMONTableAdapters.TESVAMTableAdapter
    Dim dtVAM As New dsWALMON.TESVAMDataTable
    Dim filaVAM As dsWALMON.TESVAMRow
    Dim taPAR As New dsWALPLATableAdapters.TESPARTableAdapter
    Dim dtPAR As New dsWALPLA.TESPARDataTable
    Dim filaPAR As dsWALPLA.TESPARRow
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub


    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaSegunPerfil()

        ' Parámetros del Sistema
        taPAR.Fill(dtPAR)
        filaPAR = dtPAR.Item(0)
        Mandante = filaPAR.PAR_MANDANTE
        Planilla = filaPAR.PAR_PLANILLA
        DetallePla.Planilla = Planilla
        DetallePla.Fecha = filaPAR.PAR_FECHAPRO

        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Wallet.My.Settings.ColorFondo

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
        Me.tsslEstado.Text = Usuario.Nombre & ", que tengas una buena jornada"
        Me.tsslUsuario.Text = Usuario.NombreCompleto
        Me.tsslHora.Text = FormatDateTime(Now, DateFormat.ShortTime)
        Me.tsslFecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
        Dim strConexion As String = My.MySettings.Default.WalletConnectionString1
        Dim strComponentesCon As String()
        strComponentesCon = Split(strConexion, ";")
        Dim strServidor As String = ""
        Dim strBaseDatos As String = ""
        Dim i As Integer
        For i = 0 To strComponentesCon.Count - 1
            If Mid(strComponentesCon(i), 1, 12) = "Data Source=" Then
                strServidor = "Servidor=" & Mid(strComponentesCon(i), 13)
            End If
            If Mid(strComponentesCon(i), 1, 16) = "Initial Catalog=" Then
                strBaseDatos = "Base de Datos=" & Mid(strComponentesCon(i), 17)
            End If

        Next
        ChequeaBase()

        Me.tsslServidor.Text = strServidor & "/" & strBaseDatos
        ' Cargar Dolar
        taVAM.FillByConsulta(dtVAM, 902)
        If dtVAM.Count <> 0 Then
            For i = 0 To dtVAM.Count - 1
                filaVAM = dtVAM.Item(i)
                Dim valor As String = FormatCurrency(filaVAM.VAM_VALOR, 2)
                tscbDolar.Items().Add(FormatDateTime(filaVAM.VAM_FECHA, DateFormat.ShortDate) & " " & valor.PadLeft(11, " "))
            Next
            tscbDolar.SelectedIndex = 0
        End If
        ' Cargar ENAP
        taVAM.FillByConsulta(dtVAM, 901)
        If dtVAM.Count <> 0 Then
            For i = 0 To dtVAM.Count - 1
                filaVAM = dtVAM.Item(i)
                Dim valor As String = FormatCurrency(filaVAM.VAM_VALOR, 2)
                tscbUF.Items().Add(FormatDateTime(filaVAM.VAM_FECHA, DateFormat.ShortDate) & " " & valor.PadLeft(11, " "))
            Next
            tscbUF.SelectedIndex = 0
        End If
        tslFechaActiva.Text = FormatDateTime(DetallePla.Fecha, DateFormat.LongDate)
        If Usuario.Saludos Then
            'si el usuario tiene marcado que quiere mensajes, los despliega.

            frmSEGMEN01.Show()
        End If
    End Sub
    Private Sub CargaSegunPerfil()
        'Determino que perfil tiene el usuario conectado
        Usuario.BotonPoder = False
        Usuario.Reimpresión = False
        Usuario.BotonSII = False

        'Determino cuáles son las OPC que tiene autorizado el perfil
        Dim daOPP As New dsSEGPER.SEGOPPDataTable
        Dim dtOPP As New dsSEGPERTableAdapters.SEGOPPTableAdapter
        dtOPP.FillBySEGPER_CODIGO(daOPP, Usuario.Perfil)

        'Primero determino con que número parte la estructura del programa

        Dim daOPCNombre As New dsSEGPER.SEGOPCDataTable
        Dim dtOPCNombre As New dsSEGPERTableAdapters.SEGOPCTableAdapter
        dtOPCNombre.FillBySEGOPC_MENU(daOPCNombre, NombreSistema)
        Dim RegistroOPCNombre As dsSEGPER.SEGOPCRow
        RegistroOPCNombre = daOPCNombre.Item(0)
        Dim OPCNombre As String = RegistroOPCNombre.SEGOPC_ESTRUCTURA


        'Sabiendo la estructura del programa, determino las OPC que están definidas para este programa en particular
        Dim daOPC1 As New dsSEGPER.SEGOPC1DataTable
        Dim dtOPC1 As New dsSEGPERTableAdapters.SEGOPC1TableAdapter
        dtOPC1.Fill(daOPC1, OPCNombre)
        Dim filaOPC1 As dsSEGPER.SEGOPC1Row
        Dim FilaOPC As dsSEGPER.SEGOPCRow
        'Recorro todos los items del MenuStrip y llamo a la rutina que va a ser el recorrido recursivo
        'Dejo como no visible todo lo que está definido para este programa
        Dim FilaOPP As dsSEGPER.SEGOPPRow
        Dim tsmi As ToolStripMenuItem
        For i = 0 To daOPC1.Count - 1
            filaOPC1 = daOPC1.Item(i)

            'Reviso todo el MenuStrip 
            For Each tsmi In MenuStrip.Items
                If filaOPC1.SEGOPC_ESTRUCTURA.Length > 2 Then
                    If tsmi.Name = filaOPC1.SEGOPC_MENU Then
                        tsmi.Visible = False
                    End If
                    If tsmi.GetType = GetType(ToolStripMenuItem) Then
                        ApagaNivelInferior(tsmi, filaOPC1.SEGOPC_MENU)
                    End If
                End If
            Next tsmi

            'Reviso todo el ToolStrip

            For Each ObjetoTool As Object In ToolStrip.Items
                If filaOPC1.SEGOPC_ESTRUCTURA.Length > 2 Then
                    If ObjetoTool.Name = filaOPC1.SEGOPC_MENU Then
                        ObjetoTool.Visible = False
                    End If
                    ApagaEnHijosTool(ObjetoTool, filaOPC1.SEGOPC_MENU)
                End If
            Next
        Next

        'Tomo los OPP del perfil y dejo visibles las partes del menú que están autorizadas
        For i = 0 To daOPP.Count - 1
            FilaOPP = daOPP.Item(i)

            Dim daOPC As New dsSEGPER.SEGOPCDataTable
            Dim dtOPC As New dsSEGPERTableAdapters.SEGOPCTableAdapter
            dtOPC.FillBySEGOPC_CODIGO(daOPC, FilaOPP.SEGOPC_CODIGO)
            If FilaOPP.SEGOPC_CODIGO = 21 Then
                Usuario.BotonPoder = True
            End If
            If FilaOPP.SEGOPC_CODIGO = 24 Then
                Usuario.Reimpresión = True
            End If
            If FilaOPP.SEGOPC_CODIGO = 62 Then
                Usuario.BotonSII = True
            End If
            FilaOPC = daOPC.Item(0)

            If FilaOPC.SEGOPC_ESTRUCTURA.Length > 2 Then
                'Reviso el Menu Strip
                For Each tsmi In Me.MenuStrip.Items.OfType(Of ToolStripMenuItem)()
                    If tsmi.Name = FilaOPC.SEGOPC_MENU Then
                        tsmi.Visible = True

                    End If
                    If tsmi.GetType = GetType(ToolStripMenuItem) Then
                        NivelInferior(tsmi, FilaOPC.SEGOPC_MENU)
                    End If
                Next tsmi

                'Reviso el Tool Strip
                For Each ObjetoTool As Object In Me.ToolStrip.Items
                    If ObjetoTool.Name = FilaOPC.SEGOPC_MENU Then
                        ObjetoTool.Visible = True
                    End If
                    PrendeEnHijosTool(ObjetoTool, FilaOPC.SEGOPC_MENU)
                Next
            End If
        Next

    End Sub

    Private Sub ApagaEnHijosTool(Donde As Object, Nombre As String)

        Dim Busca As Boolean = False

        If Donde.GetType = GetType(ToolStripDropDownButton) Then
            Busca = True
        End If
        If Donde.GetType = GetType(ToolStripSplitButton) Then
            Busca = True
        End If
        If Donde.GetType = GetType(ToolStripMenuItem) Then
            Busca = True
        End If

        If Busca = False Then Exit Sub

        For Each Hijos As Object In Donde.DropDownItems
            If Hijos.Name = Nombre Then
                Hijos.Visible = False
            End If
        Next
    End Sub

    Private Sub PrendeEnHijosTool(Donde As Object, Nombre As String)

        Dim Busca As Boolean = False

        If Donde.GetType = GetType(ToolStripDropDownButton) Then
            Busca = True
        End If
        If Donde.GetType = GetType(ToolStripSplitButton) Then
            Busca = True
        End If
        If Donde.GetType = GetType(ToolStripMenuItem) Then
            Busca = True
        End If

        If Busca = False Then Exit Sub

        For Each Hijos As Object In Donde.DropDownItems
            If Hijos.Name = Nombre Then
                Hijos.Visible = True
            End If
        Next
    End Sub

    ''' <summary>
    ''' Deja visible los items y subitems que se encuentran en el OPP
    ''' </summary>
    ''' <param name="It"></param>
    ''' <param name="nombre"></param>
    ''' <remarks></remarks>
    Private Sub NivelInferior(ByVal It As ToolStripMenuItem, ByVal nombre As String)
        Dim tsmii As ToolStripMenuItem
        For Each tsmii In It.DropDownItems.OfType(Of ToolStripMenuItem)()
            If tsmii.Name = nombre Then
                tsmii.Visible = True
            End If
        Next
    End Sub

    ''' <summary>
    ''' Deja no visible todos los items y subitems que se encuentran definidos en el OPC
    ''' </summary>
    ''' <param name="It"></param>
    ''' <param name="nombre"></param>
    ''' <remarks></remarks>
    Private Sub ApagaNivelInferior(ByVal It As ToolStripMenuItem, ByVal nombre As String)
        Dim tsmii As ToolStripMenuItem
        For Each tsmii In It.DropDownItems.OfType(Of ToolStripMenuItem)()
            If tsmii.Name = nombre Then
                tsmii.Visible = False
            End If
        Next
    End Sub


    ''' <summary>
    ''' Carga el mantenedor de usuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        
        Dim Formulario As New frmSEGUSU03
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub


    Private Sub PlanillaDeOperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillaDeOperacionesToolStripMenuItem.Click
        Dim Formulario As New frmWALPLA00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub tsbPlanilla_Click(sender As Object, e As EventArgs) Handles tsbPlanilla.Click
        Dim Formulario As New frmWALPLA00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub BeneficiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiariosToolStripMenuItem.Click

        Dim Formulario As New frmWALBEN00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    ''' <summary>
    ''' Revisa que la base de datos se encuentre el línea, formatea con color
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ChequeaBase()
        tsslEstadoBase.Text = TraeEstadoBaseDatos()
        If tsslEstadoBase.Text <> "Base de Datos En Línea" Then
            tsslEstadoBase.ForeColor = Color.Red
        Else
            tsslEstadoBase.ForeColor = Color.Green
        End If
    End Sub

    ''' <summary>
    ''' Revisa el estado de la base de datos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TraeEstadoBaseDatos() As String

        Dim oconn As New SqlConnection(My.Settings.WalletConnectionString1)
        Try
            oconn.Open()
        Catch ex As Exception
            Return "No hay conexión con el Servidor"
        End Try
        Dim ocmd As New SqlCommand
        'ocmd = New SqlCommand("exec Wallet_PruebaBaseDatos @Base='" & ConBaseDatos & "'", oconn)
        ocmd = New SqlCommand("exec Wallet_PruebaBaseDatos", oconn)
        Dim statusstring As String = ""

        Try
            statusstring = ocmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        oconn.Close()

        If statusstring = "ONLINE" Then
            Return "Base de Datos En Línea"
        ElseIf statusstring = "OFFLINE" Then
            Return "Base de Datos Fuera de Linea"
        ElseIf statusstring = "RESTORING" Then
            Return "Restaurando Base de Datos"
        ElseIf statusstring = "RECOVERING" Then
            Return "Recuperando Base de Datos"
        ElseIf statusstring = "SUSPECT" Then
            Return "Base de Datos Corrupta"
        Else
            Return "Error no Determinado"
        End If

    End Function

    Private Sub CuentasCorrientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasCorrientesToolStripMenuItem.Click

        Dim Formulario As New frmWALCTE00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub tsmiSalir_Click(sender As Object, e As EventArgs) Handles tsmiSalir.Click
        Me.Close()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CustodiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustodiasToolStripMenuItem.Click

        Dim Formulario As New frmWALCUS00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub CambioContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioContraseñaToolStripMenuItem.Click

        Dim Formulario As New frmSEGUSU05
        Formulario.Tag = Usuario.Codigo
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click

        Dim Formulario As New frmWALEMP00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click

        Dim Formulario As New frmWALEST00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub EntidadesFinancierasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntidadesFinancierasToolStripMenuItem.Click

        Dim Formulario As New frmWALENT00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub FondosDeFondosMutuosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FondosDeFondosMutuosToolStripMenuItem.Click

        Dim Formulario As New frmWALFON00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub EliminaciónDeEntidadesHabitualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminaciónDeEntidadesHabitualesToolStripMenuItem.Click

        Dim Formulario As New frmWALELE00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal


    End Sub

    Private Sub EmisiónDeChequesToolStripMenuItem_Click(sender As Object, e As EventArgs)

        ' Generación de Cheques
        Dim formulario As New frmWALGMO00
        Dim datos As New Acciones
        datos.accion = 1
        datos.Planilla = Planilla
        formulario.Tag = datos
        formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.Show()
        Me.Cursor = Cursors.Default
        formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub ProcesoPartidasPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesoPartidasPendientesToolStripMenuItem.Click

        ' Generación de Cheques
        Dim formulario As New frmWALPPE00
        Dim datos As New Acciones
        datos.accion = 1
        datos.Planilla = Planilla
        formulario.Tag = datos
        formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.Show()
        Me.Cursor = Cursors.Default
        formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FeriadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeriadosToolStripMenuItem.Click

        ' Generación de Cheques
        Dim formulario As New frmWALFER00
        Dim datos As New Acciones
        datos.accion = 1
        datos.Planilla = Planilla
        formulario.Tag = datos
        formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.Show()
        Me.Cursor = Cursors.Default
        formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub InstrumentosFinancierosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrumentosFinancierosToolStripMenuItem.Click

        ' Instrumentos Financieros
        Dim formulario As New frmWALINF00
        Dim datos As New Acciones
        datos.accion = 1
        datos.Planilla = Planilla
        formulario.Tag = datos
        formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.Show()
        Me.Cursor = Cursors.Default
        formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub RelacionesGlosasColumnasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionesGlosasColumnasToolStripMenuItem.Click

        Dim Formulario As New frmWALGLO00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim Formulario As New frmSEGACE
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesToolStripMenuItem.Click

        Dim Formulario As New frmWALPER04
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CierreDeDíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDeDíaToolStripMenuItem.Click

        Dim Formulario As New frmWALCUA01
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TipoDeEntidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeEntidadToolStripMenuItem.Click

        Dim Formulario As New frmWALTEN00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TipoDeInstrumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeInstrumentosToolStripMenuItem.Click

        Dim Formulario As New frmWALTII00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TiposDeFondosDeFondosMutuosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeFondosDeFondosMutuosToolStripMenuItem.Click

        Dim Formulario As New frmWALTFD00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click

        ' Captura de Proveedores
        Dim Formulario As New frmWALSAP00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click

        ' Captura de Bancos
        Dim Formulario As New frmWALSAP01
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click

        ' Captura de Monedas
        Dim Formulario As New frmWALSAP02
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FeriadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FeriadosToolStripMenuItem1.Click

        ' Captura de Feriados
        Dim Formulario As New frmWALSAP03
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ViasDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViasDePagoToolStripMenuItem.Click

        ' Captura de Vias de Pago
        Dim Formulario As New frmWALSAP04
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CuentasBancariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasBancariasToolStripMenuItem.Click

        ' Captura de Cuentas Bancarias
        Dim Formulario As New frmWALSAP05
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TransaccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionesToolStripMenuItem.Click

        ' Captura de Transacciones
        Dim Formulario As New frmWALSAP06
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CotizacónDeTasasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacónDeTasasToolStripMenuItem.Click

        ' Cotización de Tasas
        Dim Formulario As New frmWALCOT00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        ' Cotización de Tasas
        Dim Formulario As New frmWALCOT00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click

        ' Captura de Proveedores
        Dim Formulario As New frmWALSAP00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BancosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem1.Click

        ' Captura de Bancos
        Dim Formulario As New frmWALSAP01
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MonedasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem1.Click

        ' Captura de Monedas
        Dim Formulario As New frmWALSAP02
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FeriadosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FeriadosToolStripMenuItem2.Click

        ' Captura de Feriados
        Dim Formulario As New frmWALSAP03
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ViasDePagoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViasDePagoToolStripMenuItem1.Click

        ' Captura de Vias de Pago
        Dim Formulario As New frmWALSAP04
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CuentasBancariasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentasBancariasToolStripMenuItem1.Click
        ' Captura de Cuentas Bancarias
        Dim Formulario As New frmWALSAP05
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TransaccionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaccionesToolStripMenuItem1.Click
        ' Captura de Transacciones
        Dim Formulario As New frmWALSAP06
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CuentasCorrientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentasCorrientesToolStripMenuItem1.Click
        ' Cuentas Corrientes Bancarias
        Me.Cursor = Cursors.WaitCursor
        Dim Formulario As New frmWALCTE01
        Formulario.MdiParent = Me
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub EntidadesFinancierasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntidadesFinancierasToolStripMenuItem1.Click
        ' Entidades Financieras
        Me.Cursor = Cursors.WaitCursor
        Dim Formulario As New frmWALENT01
        Formulario.MdiParent = Me
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ResumenDeSaldoInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeSaldoInicialToolStripMenuItem.Click
        ' Resumen de Saldo Inicial
        Me.Cursor = Cursors.WaitCursor
        Dim Formulario As New frmWALRES01
        Formulario.MdiParent = Me
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub DiagramaDeEvoluciónDeVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagramaDeEvoluciónDeVariablesToolStripMenuItem.Click
        ' Resumen de Evolución de variables
        Me.Cursor = Cursors.WaitCursor
        Dim Formulario As New frmWALDEV01
        Formulario.MdiParent = Me
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal

    End Sub

    Private Sub DistribuciónDeRecaudaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribuciónDeRecaudaciónToolStripMenuItem.Click
        ' Reporte de Distribución de Recaudación
        Me.Cursor = Cursors.WaitCursor
        Dim Formulario As New frmWALDRE00
        Formulario.MdiParent = Me
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BoletasPorDíaBancoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BoletasPorBancoDíaToolStripMenuItem.Click
        ' Reporte de Boletas Ingresadas a Caja el Mismo Día Banco
        Dim Formulario As New frmWALBOL02
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PlanillasDeOtrosDíasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillasDeOtrosDíasToolStripMenuItem.Click
        ' POlanilla de Otros Días
        Dim Formulario As New frmWALPOD00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DetalleDeRecaudaciónDisponibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeRecaudaciónDisponibleToolStripMenuItem.Click
        ' Detalle de Recaudación Disponible
        Dim Formulario As New frmWALRED00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TotalesDeRecaudaciónDisponibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesDeRecaudaciónDisponibleToolStripMenuItem.Click
        ' Totales de Recaudación Disponible
        Dim Formulario As New frmWALRED01
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub StockDeColocacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeColocacionesToolStripMenuItem.Click
        ' Reporte de Stock de Colocaciones
        Dim Formulario As New frmWALCLC10
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub StockDeColocacionesFondosMutuos2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeColocacionesFondosMutuos2ToolStripMenuItem.Click
        ' Reporte de Stock de Colocaciones 2
        Dim Formulario As New frmWALCLC11
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub StockDeColocacionesBancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeColocacionesBancosToolStripMenuItem.Click
        ' Reporte de Stock de Colocaciones en Bancos
        Dim Formulario As New frmWALBAN00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub InversionesEnPesosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversionesEnPesosToolStripMenuItem.Click
        ' Reporte de Inversiones en Pesos
        Dim Formulario As New frmWALINV00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub RescatesDeInversionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RescatesDeInversionesToolStripMenuItem.Click
        ' Reporte de Rescate de Inversiones
        Dim Formulario As New frmWALRES00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub
    Private Sub ResuménDeColocacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResuménDeColocacionesToolStripMenuItem.Click
        ' Reporte de Resumen de Colocaciones
        Dim Formulario As New frmWALRSM00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TotalesDeRecaudaciónDepositadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesDeRecaudaciónDepositadaToolStripMenuItem.Click
        ' Reporte de Totales de recuadación Depositada
        Dim Formulario As New frmWALREC01
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ResumenDeOperacionesDelDíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeOperacionesDelDíaToolStripMenuItem.Click
        ' Reporte de Resumen de Operaciones del Día
        Dim Formulario As New frmWALRID00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BoletasPorDíaBancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoletasPorDíaBancoToolStripMenuItem.Click
        ' Reporte de Boletas Ingresadas a Caja el Mismo Día
        Dim Formulario As New frmWALBOL01
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub EdiciónColocacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdiciónColocacionesToolStripMenuItem.Click
        ' Edición de colocaciones
        Dim Formulario As New frmWALCLC02
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub IngresoDeRescateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeRescateToolStripMenuItem.Click
        ' Ingreso de Rescates
        Dim Formulario As New frmWALCLC04
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DetalleMovimientosPlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleMovimientosPlanillaToolStripMenuItem.Click
        ' Reporte de Detalle de Movimientos de Planilla de Otros Días
        Dim Formulario As New frmWALRDE00
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Dim Formulario As New frmWALCUA01
        Formulario.MdiParent = Me
        Me.Cursor = Cursors.WaitCursor
        Formulario.StartPosition = FormStartPosition.CenterScreen
        Formulario.Show()
        Me.Cursor = Cursors.Default
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub
End Class
