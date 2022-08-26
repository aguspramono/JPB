Public Class frmProduct
    Dim pilihanBtn As String

    Sub clearisi()
        txtKodeProduct.Text = ""
        txtKodeProductLama.Text = ""
        txtNama.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtKodeProduct.ReadOnly = x
        txtNama.Enabled = x
        txtKeterangan.Enabled = x

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

        frmProductCari.dgView.Rows.Clear()
        frmProductCari.cmbCari.SelectedIndex = 0
        frmProductCari.txtCari.Text = ""
        frmProductCari.txtCari.Focus()
        If txtKodeProduct.Text <> "" Then
            frmProductCari.txtCari.Text = txtKodeProduct.Text
            frmProductCari.loadCari()
        End If

        frmProductCari.ShowDialog()

    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        lockButton(True)
        txtKodeProduct.ReadOnly = False
        txtKodeProduct.Focus()
        clearisi()
        pilihanBtn = "Baru"
    End Sub

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmProduct_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtKodeProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeProduct.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCari()
        End If
    End Sub

    Private Sub txtKodeProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeProduct.TextChanged

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtKodeProductLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        lockButton(True)
        pilihanBtn = "Edit"
        txtKodeProduct.Text = txtKodeProductLama.Text
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtKodeProductLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        If MessageBox.Show("Anda Yakin ingin menghapus Product " & txtNama.Text & " dengan KodeProduct " & txtKodeProduct.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from Product where KodeProduct=@KodeProduct"
            Dim namaKolom As String() = {"KodeProduct"}
            Dim isiKolom As Object() = {txtKodeProduct.Text}
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
            Dim myQueryC As String = "select*from Product where KodeProduct=@Cari"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtKodeProduct.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("KodeProduct Sudah Ada.")
                    Exit Sub
                End If
            Next

            Dim myQuery As String = "INSERT INTO Product "
            Dim namaKolom As String() = {"KodeProduct", "NamaProduct", "Keterangan"}
            Dim isiKolom As Object() = {txtKodeProduct.Text, txtNama.Text, txtKeterangan.Text}
            clsKoneksi.insertCommand(1,myQuery, namaKolom, isiKolom)
            txtKodeProductLama.Text = txtKodeProduct.Text
        Else
            If txtKodeProduct.Text = txtKodeProductLama.Text Then
            Else
                If MessageBox.Show("Kode Product Lama :" & txtKodeProductLama.Text & " tidak sama dengan KodeProduct Baru :" & txtKodeProduct.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If


            Dim myQuery As String = "Update Product SET "
            Dim namaKolom As String() = {"KodeProduct", "NamaProduct", "Keterangan"}
            Dim isiKolom As Object() = {txtKodeProduct.Text, txtNama.Text, txtKeterangan.Text}
            Dim kondisiWhere As String = " where KodeProduct =@KodeProduct2"
            Dim namaKolom2 As String() = {"KodeProduct2"}
            Dim isiKolom2 As Object() = {txtKodeProductLama.Text}
            clsKoneksi.updateCommand(1,myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
            txtKodeProductLama.Text = txtKodeProduct.Text
        End If

        lockButton(False)
    End Sub

    Function cekIsi() As Boolean
        If txtKodeProduct.Text = "" Then
            MessageBox.Show("Harap Isi Kode Product ", "warning")
            txtKodeProduct.Focus()
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