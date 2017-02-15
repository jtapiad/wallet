Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml
Imports System.Environment

Public Class frmWALOJO00
    Dim taVisor As New dsVisorTableAdapters.ChequesPlanillaTableAdapter
    Dim dtVisor As New dsVisor.ChequesPlanillaDataTable
    Dim filaVisor As dsVisor.ChequesPlanillaRow
    Dim xIni As Integer
    Dim yIni As Integer
    Dim xFin As Integer
    Dim yFin As Integer
    Dim Color1 As Color = Color.LightSalmon
    Dim Color2 As Color = Color.LightGreen

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub frmWALOJO00_DragLeave(sender As Object, e As EventArgs) Handles Me.DragLeave
        yFin = MousePosition.Y
        xFin = MousePosition.X
        Me.Left = Me.Left + (xFin - yIni)
        Me.Top = Me.Top + (yFin - yIni)
    End Sub

    Private Sub frmWALOJO00_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        yIni = e.Y
        xIni = e.X
    End Sub

    Private Sub frmWALOJO00_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop

    End Sub






    Private Sub pbMover_MouseUp(sender As Object, e As MouseEventArgs) Handles pbMover.MouseUp
        yFin = MousePosition.Y
        xFin = MousePosition.X
        Me.Left = xFin
        Me.Top = yFin

    End Sub

    Private Sub lbAviso_DoubleClick(sender As Object, e As EventArgs) Handles lbAviso.DoubleClick
        Dim formulario As New frmWalVisor
        formulario.Show()
    End Sub

    Private Sub frmWALOJO00_Load(sender As Object, e As EventArgs) Handles Me.Load
        TraeDatosConexionEncriptado()
        Contar()
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

            Dim Servidor As String = Documento.Item("CONF").Item("Servidor").InnerText
            Dim Usuario As String = Documento.Item("CONF").Item("Usuario").InnerText
            Dim Clave As String = Documento.Item("CONF").Item("Password").InnerText
            Dim BaseDatos As String = Documento.Item("CONF").Item("Base").InnerText

            Dim StringConexion As String = My.Settings.Setting
            StringConexion = StringConexion.Replace("#Servidor#", Servidor)
            StringConexion = StringConexion.Replace("#Usuario#", Usuario)
            StringConexion = StringConexion.Replace("#Password#", Clave)
            StringConexion = StringConexion.Replace("#Base#", BaseDatos)


            My.Settings.Item("Setting") = StringConexion

        Catch ex As Exception
        End Try




    End Sub
    Private Sub Contar()
        taVisor.Fill(dtVisor)
        Dim n As Integer
        If dtVisor.Count = 0 Then
            lbAviso.Text = "No tenemos Cheques Pendientes"
            lbAviso.BackColor = Color2
            pbMover.BackColor = Color2
        Else
            For i = 0 To dtVisor.Count - 1
                filaVisor = dtVisor.Item(i)
                If filaVisor.CH2_MARCA <> "S" Then
                    n = n + 1
                End If
            Next
            If n > 0 Then
                lbAviso.Text = "Tenemos " & n & " Cheques por Imprimir"
                lbAviso.BackColor = Color1
                pbMover.BackColor = Color1
            Else
                lbAviso.Text = "No tenemos Cheques Pendientes"
                lbAviso.BackColor = Color2
                pbMover.BackColor = Color2
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Contar()
    End Sub
End Class