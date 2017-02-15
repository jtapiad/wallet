Public Class frmSEGMEN01
    ''' <summary>
    ''' Nombre Programa : frmSEGMEN01
    ''' Descripción     : Mensajes de Saludo
    ''' Fecha Entrega   : 10 de Agosto 2016
    ''' Programador     : Claudio González Vache
    ''' copyright (c) 2016, 2SYS s.a., todos los derechos se encuentran reservados
    ''' www.2sys.com
    ''' </summary>
    Private Sub frmSEGMEN01_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Mensaje As String = ""
        Dim dt As New dsSEGMENTableAdapters.SEGMEN_MensajeAleatorioTableAdapter
        Dim da As New dsSEGMEN._SEGMEN_MensajeAleatorioDataTable
        Dim Registro As dsSEGMEN._SEGMEN_MensajeAleatorioRow
        Try
            dt.Fill(da)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, NombreSistema)
        End Try

        Registro = da.Item(0)
        Mensaje = Registro.Item("SEGMEN_MENSAJE")


        Me.lblMensaje.Text = Mensaje
        Timer1.Start()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class