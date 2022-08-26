Public Class frmGantiKota

    Private Sub cboKota_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKota.KeyDown
        If e.KeyCode = Keys.Enter Then
            clsKoneksi.kotaOn = cboKota.SelectedItem.ToString
            frmMainMenu.lblKota.Text = clsKoneksi.kotaOn & "-" & lblKota.Text
            Me.Close()
        End If
    End Sub

    Private Sub cboKota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKota.SelectedIndexChanged
        If cboKota.SelectedIndex = 0 Then
            lblKota.Text = "Libo"
        Else
            lblKota.Text = "BinaBaru"
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        clsKoneksi.kotaOn = cboKota.SelectedItem.ToString
        frmMainMenu.lblKota.Text = clsKoneksi.kotaOn & "-" & lblKota.Text
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMainMenu.lblKota.Text = clsKoneksi.kotaOn & "-" & lblKota.Text
        Me.Close()
    End Sub

    Private Sub frmGantiKota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If clsKoneksi.kotaOn = "1" Then
            cboKota.SelectedIndex = 0
        Else
            cboKota.SelectedIndex = 1
        End If
    End Sub
End Class