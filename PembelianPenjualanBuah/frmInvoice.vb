Public Class frmInvoice
    Dim pilihanBtn As String

    Sub clearisi()
        txtNoInvoice.Text = ""
        txtNoInvoiceLama.Text = ""
        dtTanggal.Value = Now
        txtKeterangan.Text = ""
        txtTotal.Text = "0"
        txtTotal2.Text = "0"
        txtTotalH.Text = "0"
        txtTotalH2.Text = "0"
        txtTotalS.Text = "0"
        txtTotalS2.Text = "0"
        txtTipe.Text = "0"
        txtNoPembayaran.Text = ""
        txtNoAccount.Text = ""
        txtNama.Text = ""

        dgView.Rows.Clear()
    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtNoInvoice.ReadOnly = x
        txtKeterangan.Enabled = x
        txtNama.Enabled = x
        btnCari2.Enabled = x
        klikKananMenu.Enabled = x

        btnCari.Enabled = Not x

        btnBaru.Enabled = Not x
        btnEdit.Enabled = Not x
        btnHapus.Enabled = Not x
        btnOk.Enabled = x
        btnCancel.Enabled = x
    End Sub

    Public Sub loadHitungTotal()
        Dim tTotal As Double = 0
        For i As Integer = 0 To dgView.Rows.Count - 1
            tTotal += dgView.Rows(i).Cells(3).Value
        Next
        txtTotal.Text = tTotal
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'If decimalSeparator = "," Then
        '    txtTotal2.Text = Format(tTotal, "#.###,##")
        '    txtTotalS.Text = Format(CDbl(txtTotalH.Text) - tTotal, "#.###,##")
        '    txtTotalS2.Text = Format(CDbl(txtTotalS.Text), "#.###,##")
        'Else
        '    txtTotal2.Text = Format(tTotal, "#,###.##")
        '    txtTotalS.Text = Format(CDbl(txtTotalH.Text) - tTotal, "#,###.##")
        '    txtTotalS2.Text = Format(CDbl(txtTotalS.Text), "#,###.##")
        'End If
        txtTotal2.Text = Format(tTotal, "N")
        txtTotalS.Text = CDbl(txtTotalH.Text) - tTotal
        txtTotalS2.Text = Format(CDbl(txtTotalS.Text), "N")
    End Sub

    Private Sub btnCari2_Click(sender As Object, e As EventArgs) Handles btnCari2.Click
        frmInvoicePembayaranCari.txtCari.Text = ""
        frmInvoicePembayaranCari.cmbCari.SelectedIndex = 0
        frmInvoicePembayaranCari.loadCari()
        frmInvoicePembayaranCari.ShowDialog(Me)
    End Sub

    Private Sub frmPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgView.KeyPress

    End Sub

    Private Sub dgView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            klikKananMenu.Show(dgView, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmInvoiceDetail.pilihanT = "Baru"
        frmInvoiceDetail.dtTgl.Value = Now
        frmInvoiceDetail.txtKeterangan.Text = ""
        frmInvoiceDetail.txtTotal.Text = "0"
        frmInvoiceDetail.lblTotal.Text = "0"
        frmInvoiceDetail.ShowDialog(Me)
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        If dgView.Rows.Count > 0 Then
            If dgView.SelectedRows.Item(0).Index >= 0 Then
                frmInvoiceDetail.pilihanT = "Edit"
                frmInvoiceDetail.dtTgl.Value = dgView.SelectedRows.Item(0).Cells(1).Value
                frmInvoiceDetail.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                frmInvoiceDetail.txtTotal.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                frmInvoiceDetail.lblTotal.Text = Format(CDbl(dgView.SelectedRows.Item(0).Cells(3).Value), "#,###")
                frmInvoiceDetail.ShowDialog(Me)
            End If
        End If
        
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If dgView.Rows.Count > 0 Then
            If dgView.SelectedRows.Item(0).Index >= 0 Then
                dgView.Rows.Remove(dgView.SelectedRows.Item(0))
                loadHitungTotal()
            End If
        End If
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        lockButton(True)
        txtNoInvoice.ReadOnly = False
        txtNoInvoice.Focus()
        clearisi()
        pilihanBtn = "Baru"
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        loadCari()
    End Sub
    Sub loadCari()
        frmInvoiceCari.dgView.Rows.Clear()
        frmInvoiceCari.cmbCari.SelectedIndex = 0
        frmInvoiceCari.txtCari.Text = ""
        frmInvoiceCari.txtCari.Focus()
        If txtNoInvoice.Text <> "" Then
            frmInvoiceCari.txtCari.Text = txtNoInvoice.Text
            frmInvoiceCari.loadCari()
        End If

        frmInvoiceCari.ShowDialog()
    End Sub

    Sub loadDetail()
        Dim myQuery As String = "select NoInvoice,Tgl,Keterangan,Total,KodeKota FROM InvoiceDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtNoInvoice.Text}
        myQuery = myQuery & "where NoInvoice"
        myQuery = myQuery & " =@Cari and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(4) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgView.Rows.Add(isiView)
        Next

    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtNoInvoiceLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If

        lockButton(True)
        pilihanBtn = "Edit"
        txtNoInvoice.Text = txtNoInvoiceLama.Text
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNoInvoiceLama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        If MessageBox.Show("Anda Yakin ingin menghapus Invoice " & txtNoInvoice.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from Invoice where NoInvoice=@NoInvoice"
            Dim namaKolom As String() = {"NoInvoice"}
            Dim isiKolom As Object() = {txtNoInvoice.Text}
            clsKoneksi.deleteCommand(1,myQuery, namaKolom, isiKolom, 1)
            Dim myQuery2 As String = "delete from InvoiceDetail where NoInvoice=@NoInvoice"
            clsKoneksi.deleteCommand(1,myQuery2, namaKolom, isiKolom, 1)
            'lockButton(True)
            clearisi()
        Else
            MessageBox.Show("Data Tidak Jadi di Hapus", "warning")
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cekIsi() = False Then Exit Sub
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'Dim tNumber As Integer
        'If decimalSeparator = "," Then
        '    tNumber = 44
        'Else
        '    tNumber = 46
        'End If
        If pilihanBtn = "Baru" Then
            Dim myQueryC As String = "select*from Invoice where NoInvoice=@Cari"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtNoInvoice.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("NoInvoice Sudah Ada.")
                    Exit Sub
                End If
            Next

            Dim myQuery As String = "INSERT INTO Invoice "
            Dim namaKolom As String() = {"NoInvoice", "Tgl", "KodePembayaran", "NoAccount", "Nama", "Keterangan", "TotalHarusDiBayar", "TotalSudahDiBayar", "Sisa", "Tipe", "KodeKota"}
            Dim isiKolom As Object() = {txtNoInvoice.Text, dtTanggal.Value.Date, txtNoPembayaran.Text, txtNoAccount.Text, txtNama.Text, txtKeterangan.Text, CDbl(txtTotalH.Text), CDec(txtTotal.Text), CDec(txtTotalS.Text), CInt(txtTipe.Text), clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1,myQuery, namaKolom, isiKolom)

            Dim myQuery4 As String = "delete from InvoiceDetail where NoInvoice=@NoInvoice and KodeKota=@KodeKota"
            Dim namaKolom4 As String() = {"NoInvoice", "KodeKota"}
            Dim isiKolom4 As Object() = {txtNoInvoice.Text, clsKoneksi.kotaOn}
            clsKoneksi.deleteCommand(1,myQuery4, namaKolom4, isiKolom4, 1)

            Dim myQuery2 As String = "INSERT INTO InvoiceDetail "
            Dim namaKolom2 As String() = {"NoInvoice", "Tgl", "Keterangan", "Total", "KodeKota", "NoTemp"}

            Dim isiKolom2(9) As Object
            ReDim isiKolom2((namaKolom2.Length * dgView.Rows.Count) - 1)
            Dim cntT As Integer = 0
            If dgView.Rows.Count = 1 Then
                For i = 0 To dgView.Rows.Count - 1
                    isiKolom2(cntT + 0) = txtNoInvoice.Text
                    isiKolom2(cntT + 1) = Format(dgView.Rows(i).Cells(1).Value, "MM/dd/yyyy")
                    isiKolom2(cntT + 2) = dgView.Rows(i).Cells(2).Value
                    isiKolom2(cntT + 3) = CDec(dgView.Rows(i).Cells(3).Value)
                    isiKolom2(cntT + 4) = clsKoneksi.kotaOn
                    isiKolom2(cntT + 5) = CInt(i)
                    cntT += 6
                Next
                clsKoneksi.insertCommand(1,myQuery2, namaKolom2, isiKolom2)
            Else
                For i = 0 To dgView.Rows.Count - 1
                    isiKolom2(cntT + 0) = "'" & txtNoInvoice.Text & "'"
                    isiKolom2(cntT + 1) = "'" & dgView.Rows(i).Cells(1).Value.Date.Month & "/" & dgView.Rows(i).Cells(1).Value.Date.Day & "/" & dgView.Rows(i).Cells(1).Value.Date.Year & "'"
                    isiKolom2(cntT + 2) = "'" & dgView.Rows(i).Cells(2).Value & "'"
                    If decimalSeparator = "," Then
                        isiKolom2(cntT + 3) = CDec(dgView.Rows(i).Cells(3).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom2(cntT + 3) = CDec(dgView.Rows(i).Cells(3).Value)
                    End If
                    isiKolom2(cntT + 4) = "'" & clsKoneksi.kotaOn & "'"
                    isiKolom2(cntT + 5) = CInt(i)
                    cntT += 6
                Next
                clsKoneksi.insertCommand2(1,myQuery2, namaKolom2, isiKolom2)
            End If
            txtNoInvoiceLama.Text = txtNoInvoice.Text
        Else
            If txtNoInvoice.Text = txtNoInvoiceLama.Text Then
            Else
                If MessageBox.Show("No Invoice Lama :" & txtNoInvoiceLama.Text & " tidak sama dengan No Invoice Baru :" & txtNoInvoice.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If


            Dim myQuery As String = "Update Invoice SET "
            Dim namaKolom As String() = {"NoInvoice", "Tgl", "KodePembayaran", "NoAccount", "Nama", "Keterangan", "TotalHarusDiBayar", "TotalSudahDiBayar", "Sisa", "Tipe", "KodeKota"}
            Dim isiKolom As Object() = {txtNoInvoice.Text, dtTanggal.Value.Date, txtNoPembayaran.Text, txtNoAccount.Text, txtNama.Text, txtKeterangan.Text, CDec(txtTotalH.Text), CDec(txtTotal.Text), CDec(txtTotalS.Text), CInt(txtTipe.Text), clsKoneksi.kotaOn}
            Dim kondisiWhere As String = " where NoInvoice=@NoInvoice2 and KodeKota=@KodeKota2"
            Dim namaKolom2 As String() = {"NoInvoice2", "KodeKota2"}
            Dim isiKolom2 As Object() = {txtNoInvoiceLama.Text, clsKoneksi.kotaOn}
            clsKoneksi.updateCommand(1,myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)

            Dim myQuery4 As String = "delete from InvoiceDetail where NoInvoice=@NoInvoice and KodeKota=@KodeKota"
            Dim namaKolom4 As String() = {"NoInvoice", "KodeKota"}
            Dim isiKolom4 As Object() = {txtNoInvoice.Text, clsKoneksi.kotaOn}
            clsKoneksi.deleteCommand(1,myQuery4, namaKolom4, isiKolom4, 1)

            Dim myQuery3 As String = "INSERT INTO InvoiceDetail "
            Dim namaKolom3 As String() = {"NoInvoice", "Tgl", "Keterangan", "Total", "KodeKota", "NoTemp"}

            Dim isiKolom3(9) As Object
            ReDim isiKolom3((namaKolom3.Length * dgView.Rows.Count) - 1)
            Dim cntT As Integer = 0
            If dgView.Rows.Count = 1 Then
                For i = 0 To dgView.Rows.Count - 1
                    isiKolom3(cntT + 0) = txtNoInvoice.Text
                    isiKolom3(cntT + 1) = Format(dgView.Rows(i).Cells(1).Value, "MM/dd/yyyy")
                    isiKolom3(cntT + 2) = dgView.Rows(i).Cells(2).Value
                    isiKolom3(cntT + 3) = CDec(dgView.Rows(i).Cells(3).Value)
                    isiKolom3(cntT + 4) = clsKoneksi.kotaOn
                    isiKolom3(cntT + 5) = CInt(i)
                    cntT += 6
                Next
                clsKoneksi.insertCommand(1,myQuery3, namaKolom3, isiKolom3)
            Else
                For i = 0 To dgView.Rows.Count - 1
                    isiKolom3(cntT + 0) = "'" & txtNoInvoice.Text & "'"
                    isiKolom3(cntT + 1) = "'" & dgView.Rows(i).Cells(1).Value.Date.Month & "/" & dgView.Rows(i).Cells(1).Value.Date.Day & "/" & dgView.Rows(i).Cells(1).Value.Date.Year & "'"
                    isiKolom3(cntT + 2) = "'" & dgView.Rows(i).Cells(2).Value & "'"
                    If decimalSeparator = "," Then
                        isiKolom3(cntT + 3) = CDec(dgView.Rows(i).Cells(3).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom3(cntT + 3) = CDec(dgView.Rows(i).Cells(3).Value)
                    End If
                    isiKolom3(cntT + 4) = "'" & clsKoneksi.kotaOn & "'"
                    isiKolom3(cntT + 5) = CInt(i)
                    cntT += 6
                Next
                clsKoneksi.insertCommand2(1,myQuery3, namaKolom3, isiKolom3)
            End If
            txtNoInvoiceLama.Text = txtNoInvoice.Text
        End If

        lockButton(False)
    End Sub

    Function cekIsi() As Boolean
        If txtNoInvoice.Text = "" Then
            MessageBox.Show("Harap Isi No Invoice", "warning")
            txtNoInvoice.Focus()
            GoTo salah
        End If
        If dgView.Rows.Count = 0 Then
            MessageBox.Show("Harap Isi Detail Invoice", "warning")
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

    Private Sub frmPembayaran_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtNoInvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCari()
        End If
    End Sub

    Private Sub txtNoInvoice_TextChanged(sender As Object, e As EventArgs) Handles txtNoInvoice.TextChanged

    End Sub

    Private Sub txtTotalH_TextChanged(sender As Object, e As EventArgs) Handles txtTotalH.TextChanged

    End Sub
End Class