Public Class frmWalVisor
    Dim taCH2 As New dsVisorTableAdapters.ChequesPlanillaTableAdapter
    Dim dtCH2 As New dsVisor.ChequesPlanillaDataTable
    Dim FilaCH2 As dsVisor.ChequesPlanillaRow
    Dim taCHA As New dsVisorTableAdapters.TESCHATableAdapter
    Dim dtCHA As New dsVisor.TESCHADataTable
    Dim FilaCHA As dsVisor.TESCHARow
    Private Sub LLenar()
        Dim Total1 As Double
        Dim Total2 As Double
        Dim Total3 As Double
        Dim Total4 As Double
        Dim Total5 As Double
        Dim Total6 As Double
        Application.DoEvents()
        Me.ListView1.Items.Clear()
        taCH2.Fill(dtCH2)
        Total1 = 0
        Total2 = 0
        Total3 = 0
        Total4 = 0
        Total5 = 0
        Total6 = 0
        For i = 0 To dtCH2.Count - 1
            FilaCH2 = dtCH2.Item(i)
            Application.DoEvents()
            Dim Item As ListViewItem = New ListViewItem(FilaCH2.CTE_CUENTA)
            Item.SubItems.Add(FilaCH2.ENT_RAZON)
            Item.SubItems.Add(Format(FilaCH2.CH2_MONTO, "#,##0"))
            Item.SubItems.Add(FilaCH2.CH2_CODIGO)
            If FilaCH2.CH2_MARCA = "S" Then
                Item.Checked = True
            Else
                Item.Checked = False
            End If
            Total1 = Total1 + FilaCH2.CH2_MONTO
            Total4 = Total4 + 1
            If Item.Checked Then
                Total2 = Total2 + FilaCH2.CH2_MONTO
                Total5 = Total5 + 1
            Else
                Total3 = Total3 + FilaCH2.CH2_MONTO
                Total6 = Total6 + 1
            End If
            ListView1.Items.Add(Item)

        Next
        Me.Label7.Text = Format(Total1, "#,##0")
        Me.Label6.Text = Format(Total2, "#,##0")
        Me.Label5.Text = Format(Total3, "#,##0")
        Me.Label8.Text = Format(Total4, "#,##0")
        Me.Label9.Text = Format(Total5, "#,##0")
        Me.Label10.Text = Format(Total6, "#,##0")
        Application.DoEvents()
    End Sub
    Private Sub Sumar()
        Dim Total1 As Double
        Dim Total2 As Double
        Dim Total3 As Double
        Dim Total4 As Double
        Dim Total5 As Double
        Dim Total6 As Double
        Application.DoEvents()
        On Error Resume Next
        Total1 = 0
        Total2 = 0
        Total3 = 0
        Total4 = 0
        Total5 = 0
        Total6 = 0
        For i = 0 To dtCHA.Count - 1
            Application.DoEvents()
            FilaCHA = dtCHA.Item(i)
            If FilaCHA.CH2_MARCA = "S" Then
                Total2 = Total2 + FilaCHA.CH2_MONTO
                Total5 = Total5 + 1
            Else
                Total3 = Total3 + FilaCHA.CH2_MONTO
                Total6 = Total6 + 1
            End If
            Total1 = Total1 + FilaCHA.CH2_MONTO
            Total4 = Total4 + 1
        Next
        Me.Label7.Text = Format(Total1, "#,##0")
        Me.Label6.Text = Format(Total2, "#,##0")
        Me.Label5.Text = Format(Total3, "#,##0")
        Me.Label8.Text = Format(Total4, "#,##0")
        Me.Label9.Text = Format(Total5, "#,##0")
        Me.Label10.Text = Format(Total6, "#,##0")
        Application.DoEvents()
    End Sub

    Private Sub frmWalVisor_Load(sender As Object, e As EventArgs) Handles Me.Load
        LLenar()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        LLenar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LLenar()
    End Sub

    Private Sub ListView1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListView1.ItemCheck
        Dim clave As Long
        clave = CDbl(ListView1.Items(e.Index).SubItems(3).Text)
        taCHA.FillByCheque(dtCHA, clave)
        If dtCHA.Count > 0 Then

            FilaCHA = dtCHA.Item(0)

            If e.NewValue = CheckState.Checked Then
                FilaCHA.CH2_MARCA = "S"
            Else
                FilaCHA.CH2_MARCA = "N"
            End If
            taCHA.Update(dtCHA)
        Else
            Stop
        End If

        Sumar()

    End Sub
End Class
