Imports System.Data.SqlClient
Public Class frmGantiPassword

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        gantiPassword()
    End Sub

    Sub gantiPassword()
        If txtPasswordLama.Text = "" Then
            MessageBox.Show("Harap isi Password Lama.", "warning")
            txtPasswordLama.Focus()
            Exit Sub
        End If
        If txtPasswordBaru.Text = "" Then
            MessageBox.Show("Harap isi Password Baru.", "warning")
            txtPasswordBaru.Focus()
            Exit Sub
        End If
        If txtKonfirmasiPassword.Text = "" Then
            MessageBox.Show("Harap isi Konfirmasi Password.", "warning")
            txtKonfirmasiPassword.Focus()
            Exit Sub
        End If
        If txtPasswordBaru.Text = txtKonfirmasiPassword.Text Then
        Else
            MessageBox.Show("Password Baru dan Konfirmasi Password, Tidak Sama", "warning")
            txtPasswordBaru.Focus()
            Exit Sub
        End If
        If clsKoneksi.loginAccount(1, frmMainMenu.lblStatusUserOn.Text, clsKoneksi.Encrypt(txtPasswordLama.Text)) Then
        Else
            MessageBox.Show("Password Lama Salah.", "warning")
            txtPasswordLama.Focus()
            Exit Sub
        End If
        Dim myQuery As String = "Update UserAccount SET "
        Dim namaKolom As String() = {"NamaPengguna", "KataSandi"}
        Dim isiKolom As Object() = {frmMainMenu.lblStatusUserOn.Text, clsKoneksi.Encrypt(txtPasswordBaru.Text)}
        Dim kondisiWhere As String = " where NamaPengguna =@Username2"
        Dim namaKolom2 As String() = {"Username2"}
        Dim isiKolom2 As Object() = {frmMainMenu.lblStatusUserOn.Text}
        clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
        MessageBox.Show("Berhasil diubah", "Warning")
        clearAll()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmGantiPassword_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        clearAll()
    End Sub

    Sub clearAll()
        txtPasswordLama.Text = ""
        txtPasswordBaru.Text = ""
        txtKonfirmasiPassword.Text = ""
        txtPasswordLama.Focus()

    End Sub

    Private Sub txtPasswordLama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasswordLama.KeyDown
        If e.KeyCode = Keys.Enter Then
            gantiPassword()
        End If
    End Sub

    Private Sub txtPasswordBaru_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasswordBaru.KeyDown
        If e.KeyCode = Keys.Enter Then
            gantiPassword()
        End If
    End Sub

    Private Sub txtKonfirmasiPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKonfirmasiPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            gantiPassword()
        End If
    End Sub
End Class