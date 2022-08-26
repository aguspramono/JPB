Public Class frmUser
    Dim pilihanBtn As String

    Sub clearisi()
        txtUsername.Text = ""
        txtUsernamelama.Text = ""
        txtPassword.Text = ""
        txtKonfirmasiPassword.Text = ""
    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtUsername.ReadOnly = x
        txtPassword.Enabled = x
        txtKonfirmasiPassword.Enabled = x

        btnCari.Enabled = Not x

        btnBaru.Enabled = Not x
        btnEdit.Enabled = Not x
        btnHapus.Enabled = Not x
        btnOk.Enabled = x
        btnCancel.Enabled = x
    End Sub


    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        loadCari()
    End Sub
    Sub loadCari()

        frmUserCari.dgView.Rows.Clear()
        frmUserCari.cmbCari.SelectedIndex = 0
        frmUserCari.txtCari.Text = ""
        frmUserCari.txtCari.Focus()
        If txtUsername.Text <> "" Then
            frmUserCari.txtCari.Text = txtUsername.Text
            frmUserCari.loadCari()
        End If

        frmUserCari.ShowDialog()
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        lockButton(True)
        txtUsername.ReadOnly = False
        txtUsername.Focus()
        clearisi()
        pilihanBtn = "Baru"
    End Sub

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmUser_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCari()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtUsernamelama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        lockButton(True)
        pilihanBtn = "Edit"
        txtUsername.Text = txtUsernamelama.Text
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtUsernamelama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        If MessageBox.Show("Anda Yakin ingin menghapus User " & txtUsername.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from UserAccount where NamaPengguna=@Username"
            Dim namaKolom As String() = {"Username"}
            Dim isiKolom As Object() = {txtUsername.Text}
            clsKoneksi.deleteCommand(1,myQuery, namaKolom, isiKolom, 1)
            'lockButton(True)
            clearisi()
        Else
            MessageBox.Show("Data Tidak Jadi di Hapus", "warning")
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cekIsi() = False Then Exit Sub
        If pilihanBtn = "Baru" Then
            Dim myQueryC As String = "select*from UserAccount where NamaPengguna=@Cari"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtUsername.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("Username Sudah Ada.")
                    Exit Sub
                End If
            Next

            Dim myQuery As String = "INSERT INTO UserAccount "
            Dim namaKolom As String() = {"NamaPengguna", "KataSandi"}
            Dim isiKolom As Object() = {txtUsername.Text, clsKoneksi.Encrypt(txtPassword.Text)}
            clsKoneksi.insertCommand(1,myQuery, namaKolom, isiKolom)
            txtUsernamelama.Text = txtUsername.Text
        Else
            If txtUsername.Text = txtUsernamelama.Text Then
            Else
                If MessageBox.Show("Username Lama :" & txtUsernamelama.Text & " tidak sama dengan Username Baru :" & txtUsername.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If


            Dim myQuery As String = "Update UserAccount SET "
            Dim namaKolom As String() = {"NamaPengguna", "KataSandi"}
            Dim isiKolom As Object() = {txtUsername.Text, clsKoneksi.Encrypt(txtPassword.Text)}
            Dim kondisiWhere As String = " where NamaPengguna =@Username2"
            Dim namaKolom2 As String() = {"Username2"}
            Dim isiKolom2 As Object() = {txtUsernamelama.Text}
            clsKoneksi.updateCommand(1,myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
            txtUsernamelama.Text = txtUsername.Text
            MessageBox.Show("Berhasil diubah", "Warning")
        End If

        lockButton(False)
    End Sub

    Function cekIsi() As Boolean
        If txtUsername.Text = "" Then
            MessageBox.Show("Harap Isi Username ", "warning")
            txtUsername.Focus()
            GoTo salah
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Harap Isi Password", "warning")
            txtPassword.Focus()
            GoTo salah
        End If

        If txtKonfirmasiPassword.Text = "" Then
            MessageBox.Show("Harap Isi KonfirmasiPassword", "warning")
            txtKonfirmasiPassword.Focus()
            GoTo salah
        End If
        If txtKonfirmasiPassword.Text <> txtPassword.Text Then
            MessageBox.Show("Password dan KonfirmasiPassword tidak sama", "warning")
            txtKonfirmasiPassword.Focus()
            GoTo salah
        End If
        Return True
salah:
        Return False
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If pilihanBtn = "Baru" Then clearisi()
        lockButton(False)
    End Sub
End Class