Public Class frmCustomerKomplain
    Dim pilihanBtn As String

    Sub clearisi()
        txtNoKomplain.Text = ""
        dtTanggal.Value = Now

        txtNoTicket.Text = ""
        txtNoAccountPembelian.Text = ""
        txtNoAccountKomplain.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtNoKomplain.Enabled = x
        dtTanggal.Enabled = x
        txtNoTicket.Enabled = x
        txtNoAccountPembelian.Enabled = x
        txtNoAccountKomplain.Enabled = x
        txtKeterangan.Enabled = x

        btnCari.Enabled = Not x
        btnCariPembelian.Enabled = x
        btnCariAccount2.Enabled = x

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
        frmCustomerKomplainCari.dgView.Rows.Clear()
        frmCustomerKomplainCari.cmbCari.SelectedIndex = 0
        frmCustomerKomplainCari.txtCari.Text = ""
        frmCustomerKomplainCari.txtCari.Focus()
        frmCustomerKomplainCari.txtCari.Text = txtNoKomplain.Text
        frmCustomerKomplainCari.loadCari()
        frmCustomerKomplainCari.ShowDialog()
    End Sub

    Private Sub frmCustomerKomplain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtNoKomplain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoKomplain.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCari()
        End If
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        lockButton(True)
        clearisi()
        pilihanBtn = "Baru"
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lockButton(True)
        pilihanBtn = "Edit"
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Anda Yakin ingin menghapus No Komplain " & txtNoKomplain.Text & " dengan NoAccount Komplain " & txtNoAccountKomplain.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from CustomerKomplain where NoKomplain=@NoKomplain"
            Dim namaKolom As String() = {"NoKomplain"}
            Dim isiKolom As Object() = {txtNoKomplain.Text}
            clsKoneksi.deleteCommand(1, myQuery, namaKolom, isiKolom, 1)
            'lockButton(True)
            clearisi()
        Else
            MessageBox.Show("Data Tidak Jadi di Hapus", "warning")
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If pilihanBtn = "Baru" Then
            Dim myQueryC As String = "select*from CustomerKomplain where NoKomplain=@Cari"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtNoKomplain.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("NoKomplain Sudah Ada.")
                    Exit Sub
                End If
            Next

            Dim myQuery As String = "INSERT INTO CustomerKomplain "
            Dim namaKolom As String() = {"NoKomplain", "NoTicket", "NoAccountPembelian", "NoAccount", "Tgl", "Keterangan"}
            Dim isiKolom As Object() = {txtNoKomplain.Text, txtNoTicket.Text, txtNoAccountPembelian.Text, txtNoAccountPembelian.Text, dtTanggal.Value, txtKeterangan.Text}
            clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)
        Else

            Dim myQuery As String = "Update CustomerKomplain SET "
            Dim namaKolom As String() = {"NoKomplain", "NoTicket", "NoAccountPembelian", "NoAccount", "Tgl", "Keterangan"}
            Dim isiKolom As Object() = {txtNoKomplain.Text, txtNoTicket.Text, txtNoAccountPembelian.Text, txtNoAccountPembelian.Text, dtTanggal.Value, txtKeterangan.Text}
            Dim kondisiWhere As String = " where NoKomplain =@NoKomplain"
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere)
        End If

        lockButton(False)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If pilihanBtn = "Baru" Then clearisi()
        lockButton(False)
    End Sub

    Private Sub btnCariAccount2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariAccount2.Click
        loadCustomerCari("cariCustomerKomplain")
    End Sub

    Sub loadCustomerCari(ByVal cariT As String)
        frmCustomerCari.pilihan = cariT
        frmCustomerCari.dgView.Rows.Clear()
        frmCustomerCari.cmbCari.SelectedIndex = 0
        frmCustomerCari.txtCari.Text = ""
        frmCustomerCari.txtCari.Focus()

        If txtNoAccountKomplain.Text <> "" Then
            frmCustomerCari.txtCari.Text = txtNoAccountKomplain.Text
            frmCustomerCari.loadCari()
        End If
        frmCustomerCari.ShowDialog()

    End Sub

End Class