Public Class frmSEGUSU05
    Private Sub frmSEGUSU05_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.tbPassActual.Text = ""
        Me.tbPass1.Text = ""
        Me.TbPass2.Text = ""
        Me.tbPassActual.Focus()
        Me.gbPassNueva.Enabled = False
        Me.tsPass.Enabled = False
    End Sub

    Private Sub tbPassActual_Leave(sender As Object, e As EventArgs) Handles tbPassActual.Leave
        RevisaContraseña()
    End Sub
    Private Sub tbPass1_Leave(sender As Object, e As EventArgs) Handles tbPass1.Leave
        Me.ErrorProvider1.Clear()
        If Me.tbPass1.Text.Length < 5 Then
            Me.ErrorProvider1.SetError(Me.tbPass1, "La contraseña debe tener al menos 5 caracteres")
            Me.tbPass1.Focus()
        End If
    End Sub

    Private Sub TbPass2_Leave(sender As Object, e As EventArgs) Handles TbPass2.Leave
        Me.ErrorProvider1.Clear()
        If Me.TbPass2.Text <> "" Then
            If Me.tbPass1.Text <> Me.TbPass2.Text Then
                Me.ErrorProvider1.SetError(Me.TbPass2, "Las contraseñas no son iguales, reintente")
                Me.TbPass2.Focus()
            End If
        End If
    End Sub

    Private Sub tsbAcepta_Click(sender As Object, e As EventArgs) Handles tsbAcepta.Click
        If Me.tbPass1.Text = Me.TbPass2.Text Then
            Dim da As New dsSEGUSUTableAdapters.QueriesTableAdapter
            da.SEGUSU_GrabaContraseña(Me.tbPass1.Text, Me.Tag)
            Me.Close()
        Else
            Me.ErrorProvider1.SetError(Me.TbPass2, "Las contraseñas deben ser iguales")

        End If
    End Sub

    Private Sub tsbCancela_Click(sender As Object, e As EventArgs) Handles tsbCancela.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RevisaContraseña()

    End Sub
    Private Sub RevisaContraseña()
        Dim daContraseña As New dsSEGUSU._SEGUSU_LeeContraseñaDataTable
        Dim dtContraseña As New dsSEGUSUTableAdapters.SEGUSU_LeeContraseñaTableAdapter
        dtContraseña.Fill(daContraseña, Usuario.Codigo, Me.tbPassActual.Text)
        Dim FilaContraseña As dsSEGUSU._SEGUSU_LeeContraseñaRow
        FilaContraseña = daContraseña.Item(0)
        Me.ErrorProvider1.Clear()
        If FilaContraseña.Respuesta = 1 Then
            Me.gbPassNueva.Enabled = True
            Me.tsPass.Enabled = True
            Me.gbPassActual.Enabled = False
        Else
            Me.ErrorProvider1.SetError(Me.tbPassActual, "La contraseña actual está incorrecta")
            Me.tbPassActual.Focus()

        End If
    End Sub

End Class