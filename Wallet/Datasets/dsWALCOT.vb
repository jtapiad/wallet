

Partial Public Class dsWALCOT
End Class

Namespace dsWALCOTTableAdapters
    Partial Public Class FondosTableAdapter
    End Class

    Partial Public Class TasasTableAdapter
        Public Property SelectCommand() As SqlClient.SqlCommand()

            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection
            End Get

            Set(ByVal value As SqlClient.SqlCommand())
                Me._commandCollection = value
            End Set

        End Property

    End Class
End Namespace
