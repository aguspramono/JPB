Imports System.Data.OleDb
Public Class frmKelompok
    Dim pilihanBtn As String

    Sub loadFee()
        Dim myQuery As String = "select KodeFee,Fee,Keterangan,StatusFee from Fee "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtKodeKelompok.Text}

        myQuery = myQuery & "where KodeKelompok=@Cari"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(3) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If

                If j = 3 Then
                    If isiView(j) = "Y" Then
                        isiView(j) = True
                    Else
                        isiView(j) = False
                    End If
                End If
            Next
            dgView.Rows.Add(isiView)
        Next
    End Sub

    Sub loadTotalFee()
        Dim tTotalFee As Integer = 0
        For i As Integer = 0 To dgView.Rows.Count - 1
            If dgView.Rows(i).Cells(3).Value = True Then
                tTotalFee += dgView.Rows(i).Cells(1).Value
            End If

        Next
        txtFee.Text = tTotalFee
    End Sub

    Sub clearisi()
        txtKodeKelompok.Text = ""
        txtKodeKelompokLama.Text = ""
        txtNama.Text = ""
        txtKeterangan.Text = ""
        dgView.Rows.Clear()
        txtFee.Text = "0"
        txtSPSI.Text = "0"
        cboGrade.SelectedIndex = 2
        chkHideKelompok.Checked = False
        txtUrutanHarga.Text = "0"
        txtKodeKelompok.Focus()
    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtKodeKelompok.ReadOnly = x
        txtNama.Enabled = x
        txtKeterangan.Enabled = x
        txtSPSI.Enabled = x
        cboGrade.Enabled = x
        chkHideKelompok.Enabled = x
        klikKananMenu.Enabled = x

        txtUrutanHarga.Enabled = x

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
        frmKelompokCari.pilihanT = "kelompok"
        frmKelompokCari.dgView.Rows.Clear()
        frmKelompokCari.cmbCari.SelectedIndex = 0
        frmKelompokCari.txtCari.Text = ""
        frmKelompokCari.txtCari.Focus()
        If txtKodeKelompok.Text <> "" Then
            frmKelompokCari.txtCari.Text = txtKodeKelompok.Text
            frmKelompokCari.loadCari()
        End If

        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        lockButton(True)
        txtKodeKelompok.ReadOnly = False
        txtKodeKelompok.Focus()
        clearisi()
        pilihanBtn = "Baru"
    End Sub

    Private Sub dgView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            klikKananMenu.Show(dgView, e.Location)
        End If
    End Sub

    Private Sub frmKelompok_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtKodeKelompok_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeKelompok.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCari()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtKodeKelompokLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        lockButton(True)
        pilihanBtn = "Edit"
        txtKodeKelompok.Text = txtKodeKelompokLama.Text
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtKodeKelompokLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        If MessageBox.Show("Anda Yakin ingin menghapus Kelompok " & txtNama.Text & " dengan Kode Kelompok " & txtKodeKelompok.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from Kelompok where KodeKelompok=@KodeKelompok"
            Dim namaKolom As String() = {"KodeKelompok"}
            Dim isiKolom As Object() = {txtKodeKelompok.Text}
            clsKoneksi.deleteCommand(1, myQuery, namaKolom, isiKolom, 1)

            Dim myQuery2 As String = "delete from Fee where KodeKelompok=@KodeKelompok"
            Dim namaKolom2 As String() = {"KodeKelompok"}
            Dim isiKolom2 As Object() = {txtKodeKelompok.Text}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            'lockButton(True)
            clearisi()
        Else
            MessageBox.Show("Data Tidak Jadi di Hapus", "warning")
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cekIsi() = False Then Exit Sub
        Dim hideKelompok As String = "N"
        Dim hargaRata As String = "N"
        If chkHideKelompok.Checked Then
            hideKelompok = "Y"
        Else
            hideKelompok = "N"
        End If

        If ckrataRata.Checked Then
            hargaRata = "Y"
        Else
            hargaRata = "N"
        End If

        If pilihanBtn = "Baru" Then
            Dim myQueryC As String = "select*from Kelompok where KodeKelompok=@Cari and KodeKota='" & clsKoneksi.kotaOn & "'"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtKodeKelompok.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("KodeKelompok Sudah Ada.")
                    Exit Sub
                End If
            Next

            Dim myQuery As String = "INSERT INTO Kelompok "
            Dim namaKolom As String() = {"KodeKelompok", "Kelompok", "Keterangan", "Fee", "SPSI", "Grade", "KodeKota", "UrutanHarga", "hideKelompok", "bulananHarga"}
            Dim isiKolom As Object() = {txtKodeKelompok.Text, txtNama.Text, txtKeterangan.Text, txtFee.Text, CDec(txtSPSI.Text), cboGrade.SelectedItem.ToString, clsKoneksi.kotaOn, txtUrutanHarga.Text, hideKelompok, hargaRata}
            clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)
            updateFee()
            txtKodeKelompokLama.Text = txtKodeKelompok.Text
        Else
            If txtKodeKelompok.Text = txtKodeKelompokLama.Text Then
            Else
                If MessageBox.Show("KodeKelompok Lama :" & txtKodeKelompokLama.Text & " tidak sama dengan KodeKelompok Baru :" & txtKodeKelompok.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If


            Dim myQuery As String = "Update Kelompok SET "
            Dim namaKolom As String() = {"KodeKelompok", "Kelompok", "Keterangan", "Fee", "SPSI", "Grade", "KodeKota", "UrutanHarga", "hideKelompok", "bulananHarga"}
            Dim isiKolom As Object() = {txtKodeKelompok.Text, txtNama.Text, txtKeterangan.Text, txtFee.Text, CDec(txtSPSI.Text), cboGrade.SelectedItem.ToString, clsKoneksi.kotaOn, txtUrutanHarga.Text, hideKelompok, hargaRata}
            Dim kondisiWhere As String = " where KodeKelompok =@KodeKelompok2 and kodekota='" & clsKoneksi.kotaOn & "'"
            Dim namaKolom2 As String() = {"KodeKelompok2"}
            Dim isiKolom2 As Object() = {txtKodeKelompokLama.Text}
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
            updateFee()
            txtKodeKelompokLama.Text = txtKodeKelompok.Text
        End If

        lockButton(False)
    End Sub
    Function cekIsi() As Boolean
        If txtKodeKelompok.Text = "" Then
            MessageBox.Show("Harap Isi Kode Kelompok", "warning")
            txtKodeKelompok.Focus()
            GoTo salah
        End If
        If txtNama.Text = "" Then
            MessageBox.Show("Harap Isi Nama", "warning")
            txtNama.Focus()
            GoTo salah
        End If

        If txtUrutanHarga.Text = "" Then
            txtUrutanHarga.Text = "0"
        End If

        Return True
salah:
        Return False
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If pilihanBtn = "Baru" Then clearisi()
        lockButton(False)
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmKelompokFeeEdit.txtKodeFee.Text = ""
        frmKelompokFeeEdit.txtFee.Text = 0
        frmKelompokFeeEdit.txtKeterangan.Text = ""
        frmKelompokFeeEdit.ckAktif.Checked = False
        frmKelompokFeeEdit.ShowDialog(Me)
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If dgView.Rows.Count > 0 Then
            If dgView.SelectedRows.Item(0).Index >= 0 Then
                dgView.Rows.Remove(dgView.SelectedRows.Item(0))
                loadTotalFee()
            End If
        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        If dgView.Rows.Count > 0 Then
            If dgView.SelectedRows.Item(0).Index >= 0 Then
                frmKelompokFeeEdit.txtKodeFee.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                frmKelompokFeeEdit.txtFee.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmKelompokFeeEdit.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(2).Value

                If dgView.SelectedRows.Item(0).Cells(3).Value = True Then
                    frmKelompokFeeEdit.ckAktif.Checked = True
                Else
                    frmKelompokFeeEdit.ckAktif.Checked = False
                End If

                frmKelompokFeeEdit.ShowDialog(Me)
            End If
        End If
    End Sub

    Sub updateFee()

        Dim myQuery4 As String = "Update Customer SET Fee=0 where kodeKelompok ='" & txtKodeKelompokLama.Text & "' and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim cmd As New OleDbCommand(myQuery4, clsKoneksi.getConnection(1))
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()

        Dim myQuery2 As String = "delete from Fee where KodeKelompok=@KodeKelompok and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim namaKolom2 As String() = {"KodeKelompok"}
        Dim isiKolom2 As Object() = {txtKodeKelompokLama.Text}
        clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
        Dim j As Integer = 1
        For i As Integer = 0 To dgView.Rows.Count - 1
            Dim statusFee As String = "N"
            Dim tKodeFee As String = dgView.Rows(i).Cells(0).Value
            If tKodeFee = "" Then
                tKodeFee = clsKoneksi.GetCounter("KodeFee")
            End If
            If dgView.Rows(i).Cells(3).Value = True Then
                statusFee = "Y"
            End If
            Dim myQuery As String = "INSERT INTO Fee "
            Dim namaKolom As String() = {"KodeFee", "KodeKelompok", "Fee", "Keterangan", "KodeKota", "KodeParamFee", "StatusFee"}
            Dim isiKolom As Object() = {tKodeFee, txtKodeKelompok.Text, dgView.Rows(i).Cells(1).Value, dgView.Rows(i).Cells(2).Value, clsKoneksi.kotaOn, j, statusFee}
            clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)
            j = j + 1
        Next

        If ckPengecualianBB.Checked = True Then

            Dim myQuery5 As String = "Update Customer SET KodeKelompok='" & txtKodeKelompok.Text & "',Fee=" & CDbl(txtFee.Text) & ",SPSI=" & CDec(txtSPSI.Text) & ",Grade='" & cboGrade.SelectedItem.ToString & "' where NoAccount in(select noAccount from pengecualianbb where kodeKelompok ='" & txtKodeKelompokLama.Text & "') and kodekota='" & clsKoneksi.kotaOn & "'"
            Dim cmd1 As New OleDbCommand(myQuery5, clsKoneksi.getConnection(1))
            cmd1.Connection.Open()
            cmd1.ExecuteNonQuery()
            cmd1.Connection.Close()

        Else

            Dim myQuery3 As String = "Update Customer SET "
            Dim namaKolom3 As String() = {"KodeKelompok", "Fee", "SPSI", "Grade"}
            Dim isiKolom3 As Object() = {txtKodeKelompok.Text, txtFee.Text, CDec(txtSPSI.Text), cboGrade.SelectedItem.ToString}
            Dim kondisiWhere As String = " where KodeKelompok =@KodeKelompok2 and kodekota='" & clsKoneksi.kotaOn & "'"
            Dim namaKolom4 As String() = {"KodeKelompok2"}
            Dim isiKolom4 As Object() = {txtKodeKelompokLama.Text}
            clsKoneksi.updateCommand(1, myQuery3, namaKolom3, isiKolom3, kondisiWhere, namaKolom4, isiKolom4, 1)

        End If

    End Sub

    Private Sub txtSPSI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSPSI.KeyPress
        clsKoneksi.textBoxOnlyNumber(e)
    End Sub

    Private Sub txtUrutanHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUrutanHarga.KeyPress
        clsKoneksi.textBoxOnlyNumber(e)
    End Sub

End Class