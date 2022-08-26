Public Class frmKota
    Dim pilihanBtn As String

    Sub clearisi()
        txtKodeKota.Text = ""
        txtKodeKotaLama.Text = ""
        txtNama.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtKodeKota.ReadOnly = x
        txtNama.Enabled = x
        txtKeterangan.Enabled = x
        btnCari.Enabled = Not x
        btnBaru.Enabled = Not x
        btnEdit.Enabled = Not x
        btnHapus.Enabled = Not x
        btnOk.Enabled = x
        btnCancel.Enabled = x
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        loadCari()
    End Sub
    Sub loadCari()
        frmKotaCari.pilihanT = "kota"
        frmKotaCari.dgView.Rows.Clear()
        frmKotaCari.cmbCari.SelectedIndex = 0
        frmKotaCari.txtCari.Text = ""
        frmKotaCari.txtCari.Focus()
        If txtKodeKota.Text <> "" Then
            frmKotaCari.txtCari.Text = txtKodeKota.Text
            frmKotaCari.loadCari()
        End If
        frmKotaCari.ShowDialog()
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        lockButton(True)
        txtKodeKota.ReadOnly = False
        txtKodeKota.Focus()
        clearisi()
        pilihanBtn = "Baru"
    End Sub

    Private Sub frmKota_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtKodeKota_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeKota.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCari()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtKodeKotaLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        lockButton(True)
        pilihanBtn = "Edit"
        txtKodeKota.Text = txtKodeKotaLama.Text
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeKotaLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        If MessageBox.Show("Anda Yakin ingin menghapus Kota " & txtNama.Text & " dengan Kodekota " & txtKodeKota.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from Kota where KodeKota=@KodeKota"
            Dim namaKolom As String() = {"KodeKota"}
            Dim isiKolom As Object() = {txtKodeKota.Text}
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
            Dim myQueryC As String = "select*from Kota where KodeKota=@Cari"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtKodeKota.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("KodeKota Sudah Ada.")
                    Exit Sub
                End If
            Next
            Dim myQuery As String = "INSERT INTO Kota "
            Dim namaKolom As String() = {"KodeKota", "Kota", "Keterangan"}
            Dim isiKolom As Object() = {txtKodeKota.Text, txtNama.Text, txtKeterangan.Text}
            clsKoneksi.insertCommand(1,myQuery, namaKolom, isiKolom)
            txtKodeKotaLama.Text = txtKodeKota.Text
        Else
            If txtKodeKota.Text = txtKodeKotaLama.Text Then
            Else
                If MessageBox.Show("Kode Kota Lama :" & txtKodeKotaLama.Text & " tidak sama dengan KodeKota Baru :" & txtKodeKota.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If


            Dim myQuery As String = "Update Kota SET "
            Dim namaKolom As String() = {"KodeKota", "Kota", "Keterangan"}
            Dim isiKolom As Object() = {txtKodeKota.Text, txtNama.Text, txtKeterangan.Text}
            Dim kondisiWhere As String = " where KodeKota =@KodeKota2"
            Dim namaKolom2 As String() = {"KodeKota2"}
            Dim isiKolom2 As Object() = {txtKodeKotaLama.Text}
            clsKoneksi.updateCommand(1,myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
            txtKodeKotaLama.Text = txtKodeKota.Text
        End If

        lockButton(False)
    End Sub

    Function cekIsi() As Boolean
        If txtKodeKota.Text = "" Then
            MessageBox.Show("Harap Isi Kode Kota", "warning")
            txtKodeKota.Focus()
            GoTo salah
        End If
        If txtNama.Text = "" Then
            MessageBox.Show("Harap Isi Nama", "warning")
            txtNama.Focus()
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