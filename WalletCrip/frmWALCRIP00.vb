Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml

Public Class frmWALCRIP00

    Dim varArchivoCertificado As String = String.Empty
    Private cryptObj As New RijndaelManaged

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btGenerar.Click


        If Me.FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            Dim Memoria As New MemoryStream
            Dim writer As New XmlTextWriter(Memoria, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("CONF")
            createNode("Servidor", Me.txtServidor.Text, writer)
            createNode("Usuario", Me.txtUsuario.Text, writer)
            createNode("Password", Me.txtPassword.Text, writer)
            createNode("Base", Me.txtBase.Text, writer)
            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()

            Dim ArchivoConfiguracion As Byte() = Memoria.ToArray


            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, cryptObj.CreateEncryptor(), CryptoStreamMode.Write)

            cs.Write(ArchivoConfiguracion, 0, ArchivoConfiguracion.Length)
            cs.FlushFinalBlock()


            Dim Grabador As FileStream = New FileStream(Me.FolderBrowserDialog1.SelectedPath & "\WalletCrip.config", FileMode.Create, FileAccess.Write)
            ms.WriteTo(Grabador)

            Grabador.Close()
            ms.Close()

            Me.Close()

        End If
    End Sub

    Private Sub createNode(ByVal NombreParametro As String, ByVal Valor As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement(NombreParametro)
        writer.WriteString(Valor)
        writer.WriteEndElement()
    End Sub

    Dim varArchivoDescifrar As String = String.Empty


    Private Sub GeneracionConf_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim FraseClave As String = "2sysCipherWallet"

        Dim key As Byte() = Encoding.UTF8.GetBytes(FraseClave)
        Dim IV As Byte() = Encoding.UTF8.GetBytes(Mid(FraseClave, 1, 16))


        Me.cryptObj = New RijndaelManaged()
        Me.cryptObj.BlockSize = 128
        Me.cryptObj.KeySize = 128
        Me.cryptObj.Mode = CipherMode.ECB
        Me.cryptObj.Padding = PaddingMode.PKCS7
        Me.cryptObj.Key = key
        Me.cryptObj.IV = IV

    End Sub
End Class
