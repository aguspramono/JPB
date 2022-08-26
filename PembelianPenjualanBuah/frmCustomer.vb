Public Class frmCustomer
    Dim pilihanBtn As String

    Sub clearisi()
        txtNoAcc.Text = ""
        txtNoAccLama.Text = ""

        txtNama.Text = ""
        txtNotelp.Text = ""
        txtAlamat.Text = ""
        txtKota.Text = ""
        txtKodeKelompok.Text = ""
        txtFee.Text = "0"
        txtKeterangan.Text = ""

        txtKodeKota.Text = ""
        txtSPSI.Text = "0"
        chkPPN.Checked = False
        ckPrintTPPH.Checked = False
        txtPPH.Text = "0"
        cboGrade.SelectedIndex = 2

    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtNoAcc.ReadOnly = x
        txtNama.Enabled = x
        txtNotelp.Enabled = x
        txtAlamat.Enabled = x
        txtKota.Enabled = x
        txtKodeKelompok.Enabled = x
        txtKeterangan.Enabled = x
        txtKodeKota.Enabled = x
        txtSPSI.Enabled = x
        'cboGrade.Enabled = x
        btnCariKota.Enabled = x
        chkPPN.Enabled = x
        ckPrintTPPH.Enabled = x
        txtPPH.Enabled = x

        btnCari.Enabled = Not x
        btnCariKelompok.Enabled = x

        btnBaru.Enabled = Not x
        btnEdit.Enabled = Not x
        btnHapus.Enabled = Not x
        btnOk.Enabled = x
        btnCancel.Enabled = x
    End Sub


    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboGrade.SelectedIndex = 2
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        loadCustomerCari("cariAcc")
    End Sub

    Private Sub btnCariCustomerKepala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariKelompok.Click
        loadKelompokCari()
    End Sub
    Sub loadKelompokCari()
        frmKelompokCari.pilihanT = "customer"
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

    Sub loadCustomerCari(ByVal cariT As String)
        frmCustomerCari.pilihan = cariT
        frmCustomerCari.dgView.Rows.Clear()
        frmCustomerCari.cmbCari.SelectedIndex = 0
        frmCustomerCari.txtCari.Text = ""
        frmCustomerCari.txtCari.Focus()
        If cariT = "cariAcc" Then
            If txtNoAcc.Text <> "" Then
                frmCustomerCari.txtCari.Text = txtNoAcc.Text
                frmCustomerCari.loadCari()
            End If
        Else
            If txtNoAcc.Text <> "" Then
                frmCustomerCari.txtCari.Text = txtKodeKelompok.Text
                frmCustomerCari.loadCari()
            End If

        End If
        frmCustomerCari.ShowDialog()

    End Sub

    Private Sub txtNoAcc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoAcc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCustomerCari("cariAcc")
        End If
    End Sub

    Private Sub txtKodeKelompok_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeKelompok.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadKelompokCari()
        End If
    End Sub

    Private Sub frmCustomer_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        lockButton(True)
        txtNoAcc.ReadOnly = False
        txtNoAcc.Focus()
        clearisi()
        pilihanBtn = "Baru"
        If clsKoneksi.kotaOn = "1" Then
            txtFee.ReadOnly = False
        Else
            txtFee.ReadOnly = True
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNoAccLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        lockButton(True)
        pilihanBtn = "Edit"
        txtNoAcc.Text = txtNoAccLama.Text
        If clsKoneksi.kotaOn = "1" Then
            txtFee.ReadOnly = False
        Else
            txtFee.ReadOnly = True
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtNoAccLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        If MessageBox.Show("Anda Yakin ingin menghapus Customer " & txtNama.Text & " dengan NoAccount " & txtNoAcc.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from Customer where NoAccount=@NoAccount"
            Dim namaKolom As String() = {"NoAccount"}
            Dim isiKolom As Object() = {txtNoAcc.Text}
            clsKoneksi.deleteCommand(1, myQuery, namaKolom, isiKolom, 1)
            'lockButton(True)
            clearisi()
        Else
            MessageBox.Show("Data Tidak Jadi di Hapus", "warning")
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cekIsi() = False Then Exit Sub

        Dim termasukBos As String = "N"
        If ckGradeA.Checked = True Then
            termasukBos = "Y"
        End If


        If pilihanBtn = "Baru" Then
            Dim myQueryC As String = "select*from Customer where NoAccount=@Cari and KodeKota='" & clsKoneksi.kotaOn & "'"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtNoAcc.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("NoAccount Sudah Ada.")
                    Exit Sub
                End If
            Next

            Dim tPPN As String = "N"
            If chkPPN.Checked Then
                tPPN = "Y"
            Else
                tPPN = "N"
            End If

            Dim tPPH As String = "N"
            If ckPrintTPPH.Checked Then
                tPPH = "Y"
            Else
                tPPH = "N"
            End If


            Dim myQuery As String = "INSERT INTO Customer "
            Dim namaKolom As String() = {"NoAccount", "Nama", "Telp", "Alamat", "Grade", "KodeKota", "Kota", "Keterangan", "KodeKelompok", "SPSI", "Fee", "PPN", "PPH", "TPPH", "bosTemp"}
            Dim isiKolom As Object() = {txtNoAcc.Text, txtNama.Text, txtNotelp.Text, txtAlamat.Text, cboGrade.SelectedItem.ToString, clsKoneksi.kotaOn, txtKota.Text, txtKeterangan.Text, txtKodeKelompok.Text, CDbl(txtSPSI.Text), CDbl(txtFee.Text), tPPN, CDbl(txtPPH.Text), tPPH, termasukBos}
            clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)
            txtNoAccLama.Text = txtNoAcc.Text
            MessageBox.Show("Berhasil Disimpan", "Warning")
        Else
            If txtNoAcc.Text = txtNoAccLama.Text Then
            Else
                If MessageBox.Show("No Account Lama :" & txtNoAccLama.Text & " tidak sama dengan No Account Baru :" & txtNoAcc.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If

            Dim tPPN As String = "N"
            If chkPPN.Checked Then
                tPPN = "Y"
            Else
                tPPN = "N"
            End If

            Dim tPPH As String = "N"
            If ckPrintTPPH.Checked Then
                tPPH = "Y"
            Else
                tPPH = "N"
            End If

            Dim myQuery As String = "Update Customer SET "
            Dim namaKolom As String() = {"NoAccount", "Nama", "Telp", "Alamat", "Grade", "KodeKota", "Kota", "Keterangan", "KodeKelompok", "SPSI", "Fee", "PPN", "PPH", "TPPH", "bosTemp"}
            Dim isiKolom As Object() = {txtNoAcc.Text, txtNama.Text, txtNotelp.Text, txtAlamat.Text, cboGrade.SelectedItem.ToString, clsKoneksi.kotaOn, txtKota.Text, txtKeterangan.Text, txtKodeKelompok.Text, CDbl(txtSPSI.Text), CDbl(txtFee.Text), tPPN, CDbl(txtPPH.Text), tPPH, termasukBos}
            Dim kondisiWhere As String = " where NoAccount =@NoAccount2 and KodeKota='" & clsKoneksi.kotaOn & "'"
            Dim namaKolom2 As String() = {"NoAccount2"}
            Dim isiKolom2 As Object() = {txtNoAccLama.Text}
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)
            txtNoAccLama.Text = txtNoAcc.Text
            MessageBox.Show("Berhasil Diubah", "Warning")
        End If
        lockButton(False)
        lblFee.Text = txtFee.Text
        txtFee.ReadOnly = True
    End Sub
    Function cekIsi() As Boolean
        If txtNoAcc.Text = "" Then
            MessageBox.Show("Harap Isi No Account", "warning")
            txtNoAcc.Focus()
            GoTo salah
        End If
        If txtNama.Text = "" Then
            MessageBox.Show("Harap Isi Nama", "warning")
            txtNama.Focus()
            GoTo salah
        End If
        If txtPPH.Text = "" Then
            txtPPH.Text = "0"
        End If

        Return True
salah:
        Return False
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If pilihanBtn = "Baru" Then clearisi()
        lockButton(False)
        txtFee.ReadOnly = True
        txtFee.Text = lblFee.Text
    End Sub

    Private Sub txtSPSI_KeyPress(sender As Object, e As KeyPressEventArgs)
        clsKoneksi.textBoxOnlyNumber(e)
    End Sub

    Private Sub btnCariKota_Click(sender As Object, e As EventArgs) Handles btnCariKota.Click
        loadKotaCari()
    End Sub
    Sub loadKotaCari()
        frmKotaCari.pilihanT = "customer"
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

    Private Sub txtPPH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPPH.KeyPress
        clsKoneksi.OnlyNumber(e, txtPPH)
    End Sub

    Private Sub txtFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFee.KeyPress
        clsKoneksi.OnlyNumber(e, txtFee)
    End Sub

End Class