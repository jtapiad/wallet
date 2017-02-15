Public Class frmWALPER04
    ''' <summary>
    ''' Nombre Programa : frmWALPER04
    ''' Descripción     : Mantención de Perfiles
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudia González Cerda
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>

    Dim Accion As New Accion

    Dim taPER As New dsSEGPERTableAdapters.SEGPERTableAdapter
    Dim FilaPer As dsSEGPER.SEGPERRow
    Dim dtPer As New dsSEGPER.SEGPERDataTable
    Dim RegistroPER As System.Data.DataRowView
    Dim CodigoPER As Long = 0
    Dim Codigo As Object
    Dim CuentaUsuarios As Integer = 0

    Private Sub frmWALPER04_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SEGPERDatagridTableAdapter.Fill(Me.DsSEGPER.SEGPERDatagrid)
        Me.SEGPERTableAdapter.Fill(Me.DsSEGPER.SEGPER)
        HabilitaIzquierdo()
    End Sub
    ''' <summary>
    ''' Agrega un nuevo usuario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click
        'Cambio el título del panel
        Me.pnlSEGPER.Text = "Agrega Perfil"
        'Cambio los tooltip para que correspondan con la acción de agregar.
        tsbAcepta.ToolTipText = "Acepta creación de usuario"
        tsbCancela.ToolTipText = "Cancela creación de usuario"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho
        HabilitaDerecho()

        'Entrego el Foco al primer campo
        Me.SEGPER_PERFILTextBox.Focus()
        Accion.Accion = 1
        Me.SEGPERTableAdapter.Fill(Me.DsSEGPER.SEGPER)
        Me.SEGPERBindingSource.AddNew()
        RegistroPER = Me.SEGPERBindingSource.Current
        'Limpio los campos de los datos previamente desplegados.
        LimpiaCampos()
        CargaArbol(0)
    End Sub

    ''' <summary>
    ''' Cambia valores de un registro ya creado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Cambio el título del panel
        Me.pnlSEGPER.Text = "Edita Perfil"
        'Cambio los tooltip para editar
        tsbAcepta.ToolTipText = "Acepta modificación de perfil"
        tsbCancela.ToolTipText = "Cancela modificación de perfil"
        'Bloqueo el lado izquierdo de la pantalla y habilito el derecho.
        HabilitaDerecho()

        'Entrego Foco al primer campo
        Me.SEGPER_PERFILTextBox.Focus()
        'Defino Acción de Editar
        Accion.Accion = 2
        RegistroPER = Me.SEGPERBindingSource.Current
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Me.SEGPERDatagridTableAdapter.Fill(Me.DsSEGPER.SEGPERDatagrid)

    End Sub

    ''' <summary>
    ''' Sale de la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click
        If RevisaError() Then

            Select Case Accion.Accion
                Case 1 ' Agregar
                    'Entrego valores
                    'Actualizo Binding
                    Me.SEGPERBindingSource.EndEdit()
                    Me.SEGPERTableAdapter.Update(Me.DsSEGPER.SEGPER)
                    Codigo = RegistroPER.Item("SEGPER_CODIGO")
                    GrabaOPPPadre(RegistroPER.Item("SEGPER_CODIGO"))
                    ' Habilito lado izquierdo
                    HabilitaIzquierdo()

                Case 2 'editar
                    BorraOPP(Codigo)
                    GrabaOPPPadre(Codigo)
                    'Actualizo binding

                    Me.SEGPERBindingSource.EndEdit()
                    Me.SEGPERTableAdapter.Update(Me.DsSEGPER.SEGPER)
                    'Habilito lado izquierdo
                    HabilitaIzquierdo()
            End Select
            Me.SEGPERDatagridTableAdapter.Fill(DsSEGPER.SEGPERDatagrid)
        End If
    End Sub
    ''' <summary>
    ''' Cancela la edición y deshabilita lado derecho
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.ErrorProvider1.Clear()
        Me.SEGPERBindingSource.CancelEdit()
        Accion.Accion = 0
        HabilitaIzquierdo()
    End Sub

    Private Sub dgvPerfiles_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerfiles.RowEnter
        Codigo = dgvPerfiles.Rows(e.RowIndex).Cells(1).Value
        CodigoPER = Codigo
        Me.SEGPERTableAdapter.FillBySEGPER_CODIGO(Me.DsSEGPER.SEGPER, Codigo)
        CargaArbol(Codigo)
    End Sub

    ''' <summary>
    ''' Carga el árbol con las opciones disponibles para definir el perfil de usuario.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaArbol(CodigoArbol As Long)

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer

        Dim da1 As New dsSEGPER._SEGOPC_LeeOpcionesPadreDataTable
        Dim dt1 As New dsSEGPERTableAdapters.SEGOPC_LeeOpcionesPadreTableAdapter

        Dim daDuo As New dsSEGPER.SEGOPPDataTable
        Dim dtDuo As New dsSEGPERTableAdapters.SEGOPPTableAdapter

        Me.OPPTreeView.Nodes.Clear()


        dt1.Fill(da1, "")

        'Nodos sin padre
        For a = 0 To da1.Count - 1
            Dim Registro1 As dsSEGPER._SEGOPC_LeeOpcionesPadreRow
            Registro1 = da1.Item(a)
            Dim Nodo1 As New NodoOpcion(Registro1.SEGOPC_ESTRUCTURA, "", Registro1.SEGOPC_CODIGO, Registro1.SEGOPC_OPCION)
            Dim NodoArbol1 As New TreeNode(Nodo1.ToString)
            NodoArbol1.Tag = Nodo1
            If CodigoArbol <> Nothing Then
                dtDuo.FillByDuo(daDuo, CodigoArbol, Nodo1.Codigo)
                If daDuo.Count > 0 Then
                    NodoArbol1.Checked = True
                End If
            End If
            OPPTreeView.Nodes.Add(NodoArbol1)

            'los hijos
            Dim da2 As New dsSEGPER._SEGOPC_LeeOpcionesPadreDataTable
            Dim dt2 As New dsSEGPERTableAdapters.SEGOPC_LeeOpcionesPadreTableAdapter
            dt2.Fill(da2, Nodo1.Estructura)

            For b = 0 To da2.Count - 1
                Dim Registro2 As dsSEGPER._SEGOPC_LeeOpcionesPadreRow
                Registro2 = da2.Item(b)
                Dim Nodo2 As New NodoOpcion(Registro2.SEGOPC_ESTRUCTURA, Nodo1.Estructura, Registro2.SEGOPC_CODIGO, Registro2.SEGOPC_OPCION)
                Dim NodoArbol2 As New TreeNode(Nodo2.ToString)
                NodoArbol2.Tag = Nodo2
                If CodigoArbol <> Nothing Then
                    dtDuo.FillByDuo(daDuo, CodigoArbol, Nodo2.Codigo)
                    If daDuo.Count > 0 Then
                        NodoArbol2.Checked = True
                    End If
                End If
                OPPTreeView.Nodes(a).Nodes.Add(NodoArbol2)

                Dim da3 As New dsSEGPER._SEGOPC_LeeOpcionesPadreDataTable
                Dim dt3 As New dsSEGPERTableAdapters.SEGOPC_LeeOpcionesPadreTableAdapter
                dt3.Fill(da3, Nodo2.Estructura)

                For c = 0 To da3.Count - 1
                    Dim Registro3 As dsSEGPER._SEGOPC_LeeOpcionesPadreRow
                    Registro3 = da3.Item(c)
                    Dim Nodo3 As New NodoOpcion(Registro3.SEGOPC_ESTRUCTURA, Nodo2.Estructura, Registro3.SEGOPC_CODIGO, Registro3.SEGOPC_OPCION)
                    Dim NodoArbol3 As New TreeNode(Nodo3.ToString)
                    NodoArbol3.Tag = Nodo3
                    If CodigoArbol <> Nothing Then
                        dtDuo.FillByDuo(daDuo, CodigoArbol, Nodo3.Codigo)
                        If daDuo.Count > 0 Then
                            NodoArbol3.Checked = True
                        End If
                    End If
                    OPPTreeView.Nodes(a).Nodes(b).Nodes.Add(NodoArbol3)

                    Dim da4 As New dsSEGPER._SEGOPC_LeeOpcionesPadreDataTable
                    Dim dt4 As New dsSEGPERTableAdapters.SEGOPC_LeeOpcionesPadreTableAdapter
                    dt4.Fill(da4, Nodo3.Estructura)

                    For d = 0 To da4.Count - 1
                        Dim Registro4 As dsSEGPER._SEGOPC_LeeOpcionesPadreRow
                        Registro4 = da4.Item(d)
                        Dim Nodo4 As New NodoOpcion(Registro4.SEGOPC_ESTRUCTURA, Nodo3.Estructura, Registro4.SEGOPC_CODIGO, Registro4.SEGOPC_OPCION)
                        Dim NodoArbol4 As New TreeNode(Nodo4.ToString)
                        NodoArbol4.Tag = Nodo4
                        If CodigoArbol <> Nothing Then
                            dtDuo.FillByDuo(daDuo, CodigoArbol, Nodo4.Codigo)
                            If daDuo.Count > 0 Then
                                NodoArbol4.Checked = True
                            End If
                        End If
                        OPPTreeView.Nodes(a).Nodes(b).Nodes(c).Nodes.Add(NodoArbol4)

                        Dim da5 As New dsSEGPER._SEGOPC_LeeOpcionesPadreDataTable
                        Dim dt5 As New dsSEGPERTableAdapters.SEGOPC_LeeOpcionesPadreTableAdapter
                        dt5.Fill(da5, Nodo4.Estructura)

                        For e = 0 To da5.Count - 1
                            Dim Registro5 As dsSEGPER._SEGOPC_LeeOpcionesPadreRow
                            Registro5 = da5.Item(d)
                            Dim Nodo5 As New NodoOpcion(Registro5.SEGOPC_ESTRUCTURA, Nodo4.Estructura, Registro5.SEGOPC_CODIGO, Registro5.SEGOPC_OPCION)
                            Dim NodoArbol5 As New TreeNode(Nodo5.ToString)
                            NodoArbol5.Tag = Nodo5
                            If CodigoArbol <> Nothing Then
                                dtDuo.FillByDuo(daDuo, CodigoArbol, Nodo5.Codigo)
                                If daDuo.Count > 0 Then
                                    NodoArbol5.Checked = True
                                End If
                            End If
                            OPPTreeView.Nodes(a).Nodes(b).Nodes(c).Nodes(d).Nodes.Add(NodoArbol5)

                        Next
                    Next
                Next
            Next
        Next

    End Sub

    ''' <summary>
    ''' Limpia los campos en el caso de que se trate de una segunda pasada.
    ''' </summary>
    Private Sub LimpiaCampos()
        Me.ErrorProvider1.Clear()
        Me.SEGPER_PERFILTextBox.Text = ""
        Me.SEGPER_DESCRIPCIONTextBox.Text = ""

    End Sub

    ''' <summary>
    ''' Valida presencia de campos obligatorios y fechas
    ''' </summary>
    ''' <returns></returns>
    Private Function RevisaError() As Boolean
        Me.ErrorProvider1.Clear()
        Dim PrimerError As Boolean = False
        If Me.SEGPER_PERFILTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.SEGPER_PERFILTextBox, "El nombre de perfil no puede ser nulo")
            If PrimerError = False Then
                PrimerError = True
                Me.SEGPER_PERFILTextBox.Focus()
            End If
            Return False
        End If

        Return True

    End Function
    ''' <summary>
    ''' Habilita el lado general y deshabilita el detalle
    ''' </summary>
    Private Sub HabilitaIzquierdo()
        Me.pnlSEGPER.Enabled = False
        Me.ToolStripDetalle.Enabled = False
        Me.gbGeneral.Enabled = True
        Me.ToolStripGeneral.Enabled = True

    End Sub
    ''' <summary>
    ''' Habilita el lado detalle y deshabilita el general
    ''' </summary>
    Private Sub HabilitaDerecho()
        Me.pnlSEGPER.Enabled = True
        Me.ToolStripDetalle.Enabled = True
        Me.gbGeneral.Enabled = False
        Me.ToolStripGeneral.Enabled = False
        Me.dgvPerfiles.Focus()
    End Sub
    Dim Sentido As String = String.Empty
    ''' <summary>
    ''' Marca o desmarca hijos del nodo chequeado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub OPPTreeView_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles OPPTreeView.AfterCheck

        If Sentido = String.Empty Then
            Sentido = "H" 'SENTIDO HIJO
        End If

        If e.Node.Checked = True Then
            If Sentido = "H" Then
                MarcaHijos(e.Node.Nodes)
                Sentido = "P" ' Sentido hacia los padres
            End If
            If Sentido = "P" Then
                MarcaPadres(e.Node)
            End If
        Else
            DesmarcaHijos(e.Node.Nodes)
        End If
        Sentido = String.Empty
    End Sub
    ''' <summary>
    ''' Marca todos los hijos
    ''' </summary>
    ''' <param name="_nodeCollection"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MarcaHijos(ByVal _nodeCollection As TreeNodeCollection) As TreeNode
        Dim tmpNode As TreeNode
        For Each _child As TreeNode In _nodeCollection
            _child.Checked = True
            tmpNode = MarcaHijos(_child.Nodes)
            If Not tmpNode Is Nothing Then
                Return tmpNode
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Marca todos los Padres
    ''' </summary>
    ''' <param name="Nodo">Nodo al cual se le quiere marcar todos sus padres</param>
    ''' <remarks></remarks>
    Public Sub MarcaPadres(Nodo As TreeNode)
        Dim NodoPadre As TreeNode
        If Nodo.Checked = True Then
            If Nodo.Parent IsNot Nothing Then
                NodoPadre = Nodo.Parent
                NodoPadre.Checked = True
            End If
        End If
    End Sub


    ''' <summary>
    ''' Desmarca todos los hijos
    ''' </summary>
    ''' <param name="_nodeCollection"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DesmarcaHijos(ByVal _nodeCollection As TreeNodeCollection) As TreeNode
        Dim tmpNode As TreeNode
        For Each _child As TreeNode In _nodeCollection
            _child.Checked = False
            tmpNode = DesmarcaHijos(_child.Nodes)
            If Not tmpNode Is Nothing Then
                Return tmpNode
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Borra todas las opciones para dejar el campo limpio para las nuevas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BorraOPP(CodigoBorra As Long)

        Dim dt As New dsSEGPERTableAdapters.SEGOPPTableAdapter
        dt.DeleteBySEGPER_CODIGO(CodigoBorra)

    End Sub
    ''' <summary>
    ''' Graba los nodos padres
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GrabaOPPPadre(CodigoGrabaOpp As Long)
        Dim TagNodo As NodoOpcion

        For Each Nodo As TreeNode In Me.OPPTreeView.Nodes
            If Nodo.Checked Then
                Dim dt As New dsSEGPERTableAdapters.SEGOPPTableAdapter
                TagNodo = Nodo.Tag
                dt.InsertQuery(CodigoGrabaOpp, TagNodo.Codigo)
            End If
            GrabaHijos(Nodo.Nodes)
        Next


    End Sub

    ''' <summary>
    ''' Graba los nodos hijos
    ''' </summary>
    ''' <param name="ColeccionNodos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GrabaHijos(ByVal ColeccionNodos As TreeNodeCollection) As TreeNode

        Dim tmpNode As TreeNode
        Dim TagNodo As NodoOpcion


        For Each Hijo As TreeNode In ColeccionNodos
            If Hijo.Checked Then
                Dim dt As New dsSEGPERTableAdapters.SEGOPPTableAdapter
                TagNodo = Hijo.Tag
                dt.InsertQuery(Codigo, TagNodo.Codigo)
            End If


            tmpNode = GrabaHijos(Hijo.Nodes)
            If Not tmpNode Is Nothing Then
                Return tmpNode
            End If

        Next
        Return Nothing
    End Function

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If vbOK = MsgBox("Esto eliminará el perfil " & SEGPER_PERFILTextBox.Text, MsgBoxStyle.OkCancel, NombreSistema) Then
            If DeterminaRelacion() Then
                Try
                    Dim RegistroPER As dsSEGPER.SEGPERRow = Me.DsSEGPER.SEGPER.Item(0)
                    BorraOPP()
                    RegistroPER.Delete()
                    Me.SEGPERTableAdapter.Update(Me.DsSEGPER.SEGPER)
                Catch ex As Exception
                    MsgBox("No se puede eliminar el registro, está siendo utilizado", MsgBoxStyle.Information, NombreSistema)
                End Try
                Me.SEGPERDatagridTableAdapter.Fill(Me.DsSEGPER.SEGPERDatagrid)

            Else

                MsgBox("El registro no puede ser eliminado, tiene " & CuentaUsuarios & " Usuarios asociados.", MsgBoxStyle.Information, NombreSistema)
            End If
        End If
    End Sub
    Private Function DeterminaRelacion() As Boolean
        Dim dtUSU As New dsSEGPER.USUCuentaDataTable
        Dim taUSU As New dsSEGPERTableAdapters.USUCuentaTableAdapter
        Dim RegistroUSU As dsSEGPER.USUCuentaRow
        taUSU.FillBySEGPER_CODIGO(dtUSU, CodigoPER)
        RegistroUSU = dtUSU.Item(0)

        Dim Respuesta As Boolean = True

        If RegistroUSU.Cuenta > 0 Then
            CuentaUsuarios = RegistroUSU.Cuenta
            Respuesta = False
        End If

        Return Respuesta
    End Function

    Private Sub BorraOPP()
        Dim dt As New dsSEGPERTableAdapters.SEGOPPTableAdapter
        dt.DeleteBySEGPER_CODIGO(CodigoPER)
    End Sub
End Class