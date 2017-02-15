Public Class frmSEGACE

    
    Private Sub frmSEGACE_ClientSizeChanged(sender As Object, e As System.EventArgs) Handles Me.ClientSizeChanged
        Me.NombreSistemaLabel.Text = NombreSistema & " es otro software de 2sys s.a."
        Me.NombreSistemaLabel.Left = (Me.Width - Me.NombreSistemaLabel.Width) / 2
        Me.LogoSistemaPictureBox.Image = LogoSistema
        Me.VersionLabel.Text = "Versión " & My.Application.Info.Version.ToString
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("www.2sys.com")
    End Sub
End Class