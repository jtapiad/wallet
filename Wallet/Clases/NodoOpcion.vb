Public Class NodoOpcion

    Dim varEstructura As String
    Dim varEstructuraPadre As String
    Dim varNombre As String
    Dim varCodigo As Long


    Public Property Estructura() As String
        Get
            Return Me.varEstructura
        End Get
        Set(ByVal Value As String)
            Me.varEstructura = Value
        End Set
    End Property

    Public Property EstructuraPadre() As String
        Get
            Return Me.varEstructuraPadre
        End Get
        Set(ByVal Value As String)
            Me.varEstructuraPadre = Value
        End Set
    End Property

    Public Property Codigo() As Long
        Get
            Return Me.varCodigo
        End Get
        Set(ByVal Value As Long)
            Me.varCodigo = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me.varNombre
        End Get
        Set(ByVal Value As String)
            Me.varNombre = Value
        End Set
    End Property

    Public Sub New(ByVal Estructura As String, ByVal EstructuraPadre As String, ByVal Codigo As Long, ByVal Nombre As String)
        Me.varEstructura = Estructura
        Me.varEstructuraPadre = EstructuraPadre
        Me.varNombre = Nombre
        Me.varCodigo = Codigo
    End Sub

    Public Overrides Function ToString() As String
        Return varNombre
    End Function


End Class
