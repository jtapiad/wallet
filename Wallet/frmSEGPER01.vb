Public Class frmSEGPER01
    Dim TagPER As Accion
    Dim RegistroPER As System.Data.DataRowView

    ''' <summary>
    ''' Carga el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Dependiendo de la acción que venga en la tag, determino como se verá la pantalla</remarks>
    Private Sub frmSEGPER01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SEGPERTableAdapter.Fill(Me.DsSEGPER.SEGPER)
        TagPER = Me.Tag

        CargaArbol()

        ' activo todos los textbox
        Me.pnlSEGPER.Enabled = True
        Me.pnlSEGOPC.Enabled = True
        Select Case TagPER.Accion
            Case 1
                'Agregar
                CargaNuevo()
            Case 2
                'Modificar
                CargaModifica()
            Case 3
                'Eliminar
                Me.pnlSEGPER.Enabled = False
                Me.pnlSEGOPC.Enabled = False
                CargaElimina()
            
        End Select
    End Sub

    ''' <summary>
    ''' Carga el árbol con las opciones disponibles para definir el perfil de usuario.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaArbol()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer

        Dim da1 As New dsSEGPER._SEGOPC_LeeOpcionesPadreDataTable
        Dim dt1 As New dsSEGPERTableAdapters.SEGOPC_LeeOpcionesPadreTableAdapter

        Dim daDuo As New dsSEGPER.SEGOPPDataTable
        Dim dtDuo As New dsSEGPERTableAdapters.SEGOPPTableAdapter

        dt1.Fill(da1, "")

        'Nodos sin padre
        For a = 0 To da1.Count - 1
            Dim Registro1 As dsSEGPER._SEGOPC_LeeOpcionesPadreRow
            Registro1 = da1.Item(a)
            Dim Nodo1 As New NodoOpcion(Registro1.SEGOPC_ESTRUCTURA, "", Registro1.SEGOPC_CODIGO, Registro1.SEGOPC_OPCION)
            Dim NodoArbol1 As New TreeNode(Nodo1.ToString)
            NodoArbol1.Tag = Nodo1
            If TagPER.Codigo <> Nothing Then
                dtDuo.FillByDuo(daDuo, TagPER.Codigo, Nodo1.Codigo)
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
                If TagPER.Codigo <> Nothing Then
                    dtDuo.FillByDuo(daDuo, TagPER.Codigo, Nodo2.Codigo)
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
                    If TagPER.Codigo <> Nothing Then
                        dtDuo.FillByDuo(daDuo, TagPER.Codigo, Nodo3.Codigo)
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
                        If TagPER.Codigo <> Nothing Then
                            dtDuo.FillByDuo(daDuo, TagPER.Codigo, Nodo4.Codigo)
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
                            If TagPER.Codigo <> Nothing Then
                                dtDuo.FillByDuo(daDuo, TagPER.Codigo, Nodo5.Codigo)
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
    ''' Carga el formulario para crear un nuevo perfil
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaNuevo()

        Me.Text = "Agregar Perfil"
        Me.btnAcepta.Text = "Agregar"
        Me.SEGPERTableAdapter.Fill(Me.DsSEGPER.SEGPER)
        Me.SEGPERBindingSource.AddNew()
        RegistroPER = Me.SEGPERBindingSource.Current

        'Borro los posibles de datos de ciclos de modificación anteriores
        Me.SEGPER_DESCRIPCIONTextBox.Text = ""
        Me.SEGPER_PERFILTextBox.Text = ""

        'Desmarco todos los check que puedan estar marcados

    End Sub

    ''' <summary>
    ''' Carga el formulario para modificar un perfil ya existente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaModifica()

        Me.Text = "Modificar Perfil"
        Me.btnAcepta.Text = "Modificar"
        Me.SEGPERTableAdapter.FillBySEGPER_CODIGO(Me.DsSEGPER.SEGPER, TagPER.Codigo)

        If Not Me.SEGPERBindingSource.Count = 0 Then
            RegistroPER = Me.SEGPERBindingSource.Current
        Else
            'En caso de haber error, se lo comunica al usuario
            MsgBox("Ha ocurrido un error inesperado" & vbCrLf & "Error: " & ErrorToString(), MsgBoxStyle.Exclamation, NombreSistema)
            Me.Close()
            Exit Sub
        End If

    End Sub

    ''' <summary>
    ''' Carga el fomulario para eliminar un perfil y existente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaElimina()

        Me.Text = "Eliminar Perfil"
        Me.btnAcepta.Text = "Eliminar"
        Me.SEGPERTableAdapter.FillBySEGPER_CODIGO(Me.DsSEGPER.SEGPER, TagPER.Codigo)

        If Not Me.SEGPERBindingSource.Count = 0 Then
            RegistroPER = Me.SEGPERBindingSource.Current
        Else
            'En caso de haber error, se lo comunica al usuario
            MsgBox("Ha ocurrido un error inesperado" & vbCrLf & "Error: " & ErrorToString(), MsgBoxStyle.Exclamation, NombreSistema)
            Me.Close()
            Exit Sub
        End If

    End Sub

    ''' <summary>
    ''' Revisa que no existan errores
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Campo obligatorio: Nombre del perfil</remarks>
    Private Function RevisaError() As Boolean

        Me.ErrorProvider.Clear()
        If Me.SEGPER_PERFILTextBox.Text = "" Then
            Me.ErrorProvider.SetError(Me.SEGPER_PERFILTextBox, "Debe ingresar un nombre de perfil")
            Return False
        End If
        Return (True)

    End Function

    ''' <summary>
    ''' Cierra el formulario sin guardar los cambios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancela_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        Me.SEGPERBindingSource.CancelEdit()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Graba los cambios y cierra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAcepta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcepta.Click
        If RevisaError() Then
            If TagPER.Accion = 1 Then
                'Agrega               
                Me.SEGPERBindingSource.EndEdit()
                Me.SEGPERTableAdapter.Update(Me.DsSEGPER.SEGPER)
                TagPER.Codigo = RegistroPER.Item("SEGPER_CODIGO")

                GrabaOPPPadre()
            ElseIf TagPER.Accion = 2 Then
                'Modifica
                BorraOPP()
                GrabaOPPPadre()
                Me.SEGPERBindingSource.EndEdit()
                Me.SEGPERTableAdapter.Update(Me.DsSEGPER.SEGPER)
            ElseIf TagPER.Accion = 3 Then
                'Elimina
                BorraOPP()
                RegistroPER.Delete()
                Me.SEGPERBindingSource.EndEdit()
                Me.SEGPERTableAdapter.Update(Me.DsSEGPER.SEGPER)
            End If
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Graba los nodos padres
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GrabaOPPPadre()
        Dim TagNodo As NodoOpcion

        For Each Nodo As TreeNode In Me.OPPTreeView.Nodes
            If Nodo.Checked Then
                Dim dt As New dsSEGPERTableAdapters.SEGOPPTableAdapter
                TagNodo = Nodo.Tag
                dt.InsertQuery(TagPER.Codigo, TagNodo.Codigo)
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
                dt.InsertQuery(TagPER.Codigo, TagNodo.Codigo)
            End If


            tmpNode = GrabaHijos(Hijo.Nodes)
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
    Private Sub BorraOPP()

        Dim dt As New dsSEGPERTableAdapters.SEGOPPTableAdapter
        dt.DeleteBySEGPER_CODIGO(TagPER.Codigo)

    End Sub

End Class