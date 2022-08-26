Imports System.Data.OleDb
Public Class frmPembayaranFee
    Dim pilihanBtn As String
    Dim totallama As Double = 0
    Dim selisihtotal As Double = 0
    Dim sisaPembayaran As Double = 0

    Sub clearisi()
        txtNoPembayaran.Text = ""
        txtNoPembayaranlama.Text = ""
        dtTanggal.Value = Now
        txtKeterangan.Text = ""
        txtTotal.Text = "0"
        txtTotal2.Text = "0"
        txtKodeKelompok.Text = ""
        txtKelompok.Text = ""
        txtFee.Text = ""
        txtKodeFee.Text = ""

        dgView.Rows.Clear()
    End Sub

    Sub lockButton(ByVal x As Boolean)
        txtNoPembayaran.ReadOnly = Not x
        txtKeterangan.Enabled = x
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
            tTotal += dgView.Rows(i).Cells(8).Value
        Next
        txtTotal.Text = tTotal
        txtTotal2.Text = Format(tTotal, "#,###")
    End Sub

    Private Sub btnCari2_Click(sender As Object, e As EventArgs) Handles btnCari2.Click
        If dgView.Rows.Count > 0 Then
            MessageBox.Show("Pembayaran Fee Sudah terisi, hapus detail untuk menganti Kode Kelompok", "warning")
            Exit Sub
        End If
        frmPembayaranFeeKelompokCari.txtCari.Text = ""
        frmPembayaranFeeKelompokCari.cmbCari.SelectedIndex = 0
        frmPembayaranFeeKelompokCari.loadCari()
        frmPembayaranFeeKelompokCari.ShowDialog(Me)
    End Sub


    Private Sub dgView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            klikKananMenu.Show(dgView, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        If txtKodeKelompok.Text = "" Then
            MessageBox.Show("Harap isi Kode Kelompok", "warning")
            Exit Sub
        End If
        frmPembayaranFeeDetail.kodeFee = "''"
        frmPembayaranFeeDetail.kodeKelompok = txtKodeKelompok.Text
        frmPembayaranFeeDetail.noTicketFeeShow = "''"

        If dgView.Rows.Count > 0 Then
            For i As Integer = 0 To dgView.Rows.Count - 1
                If i = 0 Then
                    frmPembayaranFeeDetail.noTicketFeeShow = "'" & dgView.Rows(i).Cells(1).Value & "'"
                    frmPembayaranFeeDetail.kodeFee = "'" & dgView.Rows(i).Cells(6).Value & "'"
                Else
                    frmPembayaranFeeDetail.noTicketFeeShow = frmPembayaranFeeDetail.noTicketFeeShow & ",'" & dgView.Rows(i).Cells(1).Value & "'"
                    frmPembayaranFeeDetail.kodeFee = frmPembayaranFeeDetail.kodeFee & ",'" & dgView.Rows(i).Cells(6).Value & "'"
                End If
            Next
        End If
        frmPembayaranFeeDetail.ShowDialog(Me)
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        lockButton(True)
        txtNoPembayaran.ReadOnly = False
        txtNoPembayaran.Focus()
        clearisi()
        pilihanBtn = "Baru"
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If dgView.Rows.Count > 0 Then
            If dgView.SelectedRows.Item(0).Index >= 0 Then
                If dgView.SelectedCells(11).Value = "Y" Then
                    MsgBox("Data ini tidak dapat dihapus karena sudah ada didalam pembayaran, silahkan edit di pembayaran terlebih dahulu", vbCritical)
                    Return
                End If
                dgView.Rows.Remove(dgView.SelectedRows.Item(0))
                loadHitungTotal()
            End If
        End If
    End Sub


    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        loadCari()
    End Sub
    Sub loadCari()

        frmPembayaranFeeCari.dgView.Rows.Clear()
        frmPembayaranFeeCari.cmbCari.SelectedIndex = 0
        frmPembayaranFeeCari.txtCari.Text = ""
        frmPembayaranFeeCari.txtCari.Focus()
        If txtNoPembayaran.Text <> "" Then
            frmPembayaranFeeCari.txtCari.Text = txtNoPembayaran.Text
            frmPembayaranFeeCari.loadCari()
        End If

        frmPembayaranFeeCari.ShowDialog()

    End Sub

    Sub loadDetail()
        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,KodeFee,Fee,Total,KodeKota,Keterangan,StatusBayar,FeeParam FROM PembayaranFeeDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtNoPembayaran.Text}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and kodekota='" & clsKoneksi.kotaOn & "' order by KodeFee"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(12) As Object
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

            If isiView(11) = "Y" Then
                dgView.Rows(dgView.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtNoPembayaranlama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        lockButton(True)
        pilihanBtn = "Edit"
        txtNoPembayaran.Text = txtNoPembayaranlama.Text
        totallama = txtTotal.Text
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNoPembayaranlama.Text = "" Then
            MessageBox.Show("Tidak ada Data terpilih", "warning")
            Exit Sub
        End If
        If MessageBox.Show("Anda Yakin ingin menghapus Pembayaran Fee " & txtNoPembayaran.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from PembayaranFee where KodePembayaran=@KodePembayaran"
            Dim namaKolom As String() = {"KodePembayaran"}
            Dim isiKolom As Object() = {txtNoPembayaran.Text}
            clsKoneksi.deleteCommand(1, myQuery, namaKolom, isiKolom, 1)
            Dim myQuery2 As String = "delete from PembayaranFeeDetail where KodePembayaran=@KodePembayaran"
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom, isiKolom, 1)

            Dim myQuery3 As String = "delete from PembayaranBPF where KodePembayaran=@KodePembayaran"
            clsKoneksi.deleteCommand(1, myQuery3, namaKolom, isiKolom, 1)

            Dim myQuery4 As String = "delete from PembayaranBPFDetail where KodePembayaran=@KodePembayaran"
            clsKoneksi.deleteCommand(1, myQuery4, namaKolom, isiKolom, 1)

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
            Dim myQueryC As String = "select*from PembayaranFee where KodePembayaran=@Cari"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtNoPembayaran.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC, namaKolomC, isiKolomC, 1)
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                Else
                    MessageBox.Show("NoPembayaran Sudah Ada.")
                    Exit Sub
                End If
            Next

            Dim myQuery As String = "INSERT INTO PembayaranFee "
            Dim namaKolom As String() = {"KodePembayaran", "Tgl", "KodeKelompok", "Kelompok", "Keterangan", "Total", "KodeKota", "Sisa"}
            Dim isiKolom As Object() = {txtNoPembayaran.Text, dtTanggal.Value.Date, txtKodeKelompok.Text, txtKelompok.Text, txtKeterangan.Text, CDec(txtTotal.Text), clsKoneksi.kotaOn, CDec(txtTotal.Text)}
            clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)

            Dim myQuery4 As String = "delete from PembayaranFeeDetail where KodePembayaran=@KodePembayaran and KodeKota=@KodeKota"
            Dim namaKolom4 As String() = {"KodePembayaran", "KodeKota"}
            Dim isiKolom4 As Object() = {txtNoPembayaran.Text, clsKoneksi.kotaOn}
            clsKoneksi.deleteCommand(1, myQuery4, namaKolom4, isiKolom4, 1)

            Dim myQuery2 As String = "INSERT INTO PembayaranFeeDetail "
            Dim namaKolom2 As String() = {"KodePembayaran", "NoTicket", "Tgl", "KodeProduct", "Product", "Netto", "KodeFee", "Fee", "Total", "KodeKota", "Keterangan", "StatusBayar", "FeeParam"}

            Dim isiKolom2(13) As Object
            ReDim isiKolom2((namaKolom2.Length * dgView.Rows.Count) - 1)
            Dim cntT As Integer = 0
            If dgView.Rows.Count = 1 Then
                For i = 0 To dgView.Rows.Count - 1
                    Dim edate As String = dgView.Rows(i).Cells(2).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom2(cntT + 0) = txtNoPembayaran.Text
                    isiKolom2(cntT + 1) = dgView.Rows(i).Cells(1).Value
                    isiKolom2(cntT + 2) = expenddt
                    isiKolom2(cntT + 3) = dgView.Rows(i).Cells(3).Value
                    isiKolom2(cntT + 4) = dgView.Rows(i).Cells(4).Value
                    isiKolom2(cntT + 5) = CInt(dgView.Rows(i).Cells(5).Value)
                    isiKolom2(cntT + 6) = dgView.Rows(i).Cells(6).Value
                    isiKolom2(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value)
                    isiKolom2(cntT + 8) = CDec(dgView.Rows(i).Cells(8).Value)
                    isiKolom2(cntT + 9) = clsKoneksi.kotaOn
                    isiKolom2(cntT + 10) = dgView.Rows(i).Cells(10).Value
                    isiKolom2(cntT + 11) = dgView.Rows(i).Cells(11).Value
                    isiKolom2(cntT + 12) = CInt(dgView.Rows(i).Cells(12).Value)
                    cntT += 13
                Next
                clsKoneksi.insertCommand(1, myQuery2, namaKolom2, isiKolom2)
            Else
                For i = 0 To dgView.Rows.Count - 1
                    Dim edate As String = dgView.Rows(i).Cells(2).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom2(cntT + 0) = "'" & txtNoPembayaran.Text & "'"
                    isiKolom2(cntT + 1) = "'" & dgView.Rows(i).Cells(1).Value & "'"
                    isiKolom2(cntT + 2) = "'" & expenddt & "'"
                    isiKolom2(cntT + 3) = "'" & dgView.Rows(i).Cells(3).Value & "'"
                    isiKolom2(cntT + 4) = "'" & dgView.Rows(i).Cells(4).Value & "'"
                    isiKolom2(cntT + 5) = CInt(dgView.Rows(i).Cells(5).Value)
                    isiKolom2(cntT + 6) = "'" & dgView.Rows(i).Cells(6).Value & "'"
                    If decimalSeparator = "," Then
                        isiKolom2(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                        isiKolom2(cntT + 8) = CDec(dgView.Rows(i).Cells(8).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom2(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value)
                        isiKolom2(cntT + 8) = CDec(dgView.Rows(i).Cells(8).Value)
                    End If
                    isiKolom2(cntT + 9) = "'" & clsKoneksi.kotaOn & "'"
                    isiKolom2(cntT + 10) = "'" & dgView.Rows(i).Cells(10).Value & "'"
                    isiKolom2(cntT + 11) = "'" & dgView.Rows(i).Cells(11).Value & "'"
                    isiKolom2(cntT + 12) = CInt(dgView.Rows(i).Cells(12).Value)
                    cntT += 13
                Next
                clsKoneksi.insertCommand2(1, myQuery2, namaKolom2, isiKolom2)
            End If
            txtNoPembayaranlama.Text = txtNoPembayaran.Text
            txtSisaBayar.Text = FormatNumber(CDbl(txtTotal.Text))
        Else
            If txtNoPembayaran.Text = txtNoPembayaranlama.Text Then
            Else
                If MessageBox.Show("No Pembayaran Lama :" & txtNoPembayaranlama.Text & " tidak sama dengan No Pembayaran Baru :" & txtNoPembayaran.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If

            If txtNoPembayaran.Text <> txtNoPembayaranlama.Text Then
                Dim myQueryC As String = "select*from PembayaranFee where KodePembayaran=@Cari"
                Dim namaKolomC As String() = {"Cari"}
                Dim isiKolomC As Object() = {txtNoPembayaran.Text}

                Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC, namaKolomC, isiKolomC, 1)
                For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                    If tDs.Tables(0).Rows(i).Item(0) Is DBNull.Value Then
                    Else
                        MessageBox.Show("NoPembayaran Sudah Ada.")
                        Exit Sub
                    End If
                Next
            End If

            If CDbl(txtTotal2.Text) > totallama Then
                selisihtotal = CDbl(txtTotal2.Text) - totallama
                sisaPembayaran = CDbl(txtSisaBayar.Text) + selisihtotal
            ElseIf CDbl(txtTotal2.Text) < totallama Then
                selisihtotal = totallama - CDbl(txtTotal2.Text)
                sisaPembayaran = CDbl(txtSisaBayar.Text) - selisihtotal
            Else
                selisihtotal = 0
                sisaPembayaran = CDbl(txtSisaBayar.Text)
            End If


            Dim myQuery As String = "Update PembayaranFee SET "
            Dim namaKolom As String() = {"KodePembayaran", "Tgl", "KodeKelompok", "Kelompok", "Keterangan", "Total", "KodeKota", "Sisa"}
            Dim isiKolom As Object() = {txtNoPembayaran.Text, dtTanggal.Value.Date, txtKodeKelompok.Text, txtKelompok.Text, txtKeterangan.Text, CDec(txtTotal.Text), clsKoneksi.kotaOn, CDbl(sisaPembayaran)}
            Dim kondisiWhere As String = " where KodePembayaran=@KodePembayaran2 and KodeKota=@KodeKota2"
            Dim namaKolom2 As String() = {"KodePembayaran2", "KodeKota2"}
            Dim isiKolom2 As Object() = {txtNoPembayaranlama.Text, clsKoneksi.kotaOn}
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)

            Dim myQuery4 As String = "delete from PembayaranFeeDetail where KodePembayaran=@KodePembayaran and KodeKota=@KodeKota"
            Dim namaKolom4 As String() = {"KodePembayaran", "KodeKota"}
            Dim isiKolom4 As Object() = {txtNoPembayaranlama.Text, clsKoneksi.kotaOn}
            clsKoneksi.deleteCommand(1, myQuery4, namaKolom4, isiKolom4, 1)

            Dim myQuery3 As String = "INSERT INTO PembayaranFeeDetail "
            Dim namaKolom3 As String() = {"KodePembayaran", "NoTicket", "Tgl", "KodeProduct", "Product", "Netto", "KodeFee", "Fee", "Total", "KodeKota", "Keterangan", "StatusBayar", "FeeParam"}

            Dim isiKolom3(13) As Object
            ReDim isiKolom3((namaKolom3.Length * dgView.Rows.Count) - 1)
            Dim cntT As Integer = 0
            If dgView.Rows.Count = 1 Then
                For i = 0 To dgView.Rows.Count - 1
                    Dim edate As String = dgView.Rows(i).Cells(2).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom3(cntT + 0) = txtNoPembayaran.Text
                    isiKolom3(cntT + 1) = dgView.Rows(i).Cells(1).Value
                    isiKolom3(cntT + 2) = expenddt
                    isiKolom3(cntT + 3) = dgView.Rows(i).Cells(3).Value
                    isiKolom3(cntT + 4) = dgView.Rows(i).Cells(4).Value
                    isiKolom3(cntT + 5) = CInt(dgView.Rows(i).Cells(5).Value)
                    isiKolom3(cntT + 6) = dgView.Rows(i).Cells(6).Value
                    isiKolom3(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value)
                    isiKolom3(cntT + 8) = CDec(dgView.Rows(i).Cells(8).Value)
                    isiKolom3(cntT + 9) = clsKoneksi.kotaOn
                    isiKolom3(cntT + 10) = dgView.Rows(i).Cells(10).Value
                    isiKolom3(cntT + 11) = dgView.Rows(i).Cells(11).Value
                    isiKolom3(cntT + 12) = CInt(dgView.Rows(i).Cells(12).Value)
                    cntT += 13
                Next
                clsKoneksi.insertCommand(1, myQuery3, namaKolom3, isiKolom3)
            Else
                For i = 0 To dgView.Rows.Count - 1
                    Dim edate As String = dgView.Rows(i).Cells(2).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.CultureInfo.CurrentCulture,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom3(cntT + 0) = "'" & txtNoPembayaran.Text & "'"
                    isiKolom3(cntT + 1) = "'" & dgView.Rows(i).Cells(1).Value & "'"
                    isiKolom3(cntT + 2) = "'" & expenddt & "'"
                    isiKolom3(cntT + 3) = "'" & dgView.Rows(i).Cells(3).Value & "'"
                    isiKolom3(cntT + 4) = "'" & dgView.Rows(i).Cells(4).Value & "'"
                    isiKolom3(cntT + 5) = CInt(dgView.Rows(i).Cells(5).Value)
                    isiKolom3(cntT + 6) = "'" & dgView.Rows(i).Cells(6).Value & "'"
                    If decimalSeparator = "," Then
                        isiKolom3(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                        isiKolom3(cntT + 8) = CDec(dgView.Rows(i).Cells(8).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom3(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value)
                        isiKolom3(cntT + 8) = CDec(dgView.Rows(i).Cells(8).Value)
                    End If
                    isiKolom3(cntT + 9) = "'" & clsKoneksi.kotaOn & "'"
                    isiKolom3(cntT + 10) = "'" & dgView.Rows(i).Cells(10).Value & "'"
                    isiKolom3(cntT + 11) = "'" & dgView.Rows(i).Cells(11).Value & "'"
                    isiKolom3(cntT + 12) = CInt(dgView.Rows(i).Cells(12).Value)
                    cntT += 13
                Next
                clsKoneksi.insertCommand2(1, myQuery3, namaKolom3, isiKolom3)
            End If

            Dim myQuery11 As String = "Update PembayaranBPF SET KodePembayaran='" & txtNoPembayaran.Text & "' where KodePembayaran='" & txtNoPembayaranlama.Text & "'"
            Dim cmd3 As New OleDbCommand(myQuery11, clsKoneksi.getConnection(1))
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()


            Dim myQuery12 As String = "Update PembayaranBPFDetail SET KodePembayaran='" & txtNoPembayaran.Text & "' where KodePembayaran='" & txtNoPembayaranlama.Text & "'"
            Dim cmd4 As New OleDbCommand(myQuery12, clsKoneksi.getConnection(1))
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Dim kodeBPF As String = ""
            Dim myQuery10 As String = "select * FROM PembayaranBPFDetail "
            Dim namaKolom10 As String() = {"Cari"}
            Dim isiKolom10 As Object() = {txtNoPembayaran.Text}
            myQuery10 = myQuery10 & "where KodePembayaran=@Cari"
            Dim tDs2 As DataSet = clsKoneksi.selectCommand(1, myQuery10, namaKolom10, isiKolom10, 1)
            dgvData2.Rows.Clear()
            Dim isiView(4) As Object
            'isiView(0) = ""
            For i As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView.Length - 1
                    If tDs2.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView(j) = ""
                    Else
                        isiView(j) = tDs2.Tables(0).Rows(i).Item(j)
                    End If
                Next
                dgvData2.Rows.Add(isiView)
                kodeBPF = isiView(0)
                kodeBPF = kodeBPF.Replace(txtNoPembayaranlama.Text, txtNoPembayaran.Text)
                dgvData2.Rows(i).Cells(1).Value = kodeBPF
            Next
          

            Dim myQuery14 As String = "select * FROM PembayaranBPF "
            Dim namaKolom14 As String() = {"Cari"}
            Dim isiKolom14 As Object() = {txtNoPembayaran.Text}
            myQuery14 = myQuery14 & "where KodePembayaran=@Cari"
            Dim tDs3 As DataSet = clsKoneksi.selectCommand(1, myQuery14, namaKolom14, isiKolom14, 1)
            dgvData3.Rows.Clear()
            Dim isiView1(0) As Object
            'isiView(0) = ""
            For i As Integer = 0 To tDs3.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView1.Length - 1
                    If tDs3.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView1(j) = ""
                    Else
                        isiView1(j) = tDs3.Tables(0).Rows(i).Item(j)
                    End If
                Next
                dgvData3.Rows.Add(isiView1)
                kodeBPF = isiView1(0)
                kodeBPF = kodeBPF.Replace(txtNoPembayaranlama.Text, txtNoPembayaran.Text)
                dgvData3.Rows(i).Cells(1).Value = kodeBPF

            Next

            Dim myQuery16 As String = "delete from PembayaranBPF where KodePembayaran=@KodePembayaran"
            Dim namaKolom7 As String() = {"KodePembayaran"}
            Dim isiKolom7 As Object() = {txtNoPembayaran.Text}
            clsKoneksi.deleteCommand(1, myQuery16, namaKolom7, isiKolom7, 1)

            Dim myQuery17 As String = "delete from PembayaranBPFDetail where KodePembayaran=@KodePembayaran"
            Dim namaKolom8 As String() = {"KodePembayaran"}
            Dim isiKolom8 As Object() = {txtNoPembayaran.Text}
            clsKoneksi.deleteCommand(1, myQuery17, namaKolom8, isiKolom8, 1)


            Dim myQuery18 As String = "INSERT INTO PembayaranBPF "
            Dim namaKolom9 As String() = {"KodePembayaranBPF", "KodePembayaran", "NoTicket", "Jumlah", "Dibayar", "Sisa"}
            Dim isiKolom9(6) As Object
            ReDim isiKolom9((namaKolom9.Length * dgvData3.Rows.Count) - 1)
            Dim cntK As Integer = 0
            If dgvData3.Rows.Count = 1 Then
                For i = 0 To dgvData3.Rows.Count - 1
                    isiKolom9(cntK + 0) = dgvData3.Rows(i).Cells(1).Value
                    isiKolom9(cntK + 1) = txtNoPembayaran.Text
                    isiKolom9(cntK + 2) = "" & dgvData3.Rows(i).Cells(3).Value & ""
                    isiKolom9(cntK + 3) = CDbl(dgvData3.Rows(i).Cells(4).Value)
                    isiKolom9(cntK + 4) = CDbl(dgvData3.Rows(i).Cells(5).Value)
                    isiKolom9(cntK + 5) = CDbl(dgvData3.Rows(i).Cells(6).Value)
                    cntK += 6
                Next
                clsKoneksi.insertCommand(1, myQuery18, namaKolom9, isiKolom9)
            Else
                For i = 0 To dgvData3.Rows.Count - 1
                    isiKolom9(cntK + 0) = "'" & dgvData3.Rows(i).Cells(1).Value & "'"
                    isiKolom9(cntK + 1) = "'" & txtNoPembayaran.Text & "'"
                    isiKolom9(cntK + 2) = """" & dgvData3.Rows(i).Cells(3).Value & """"

                    If decimalSeparator = "," Then
                        isiKolom9(cntK + 3) = CDec(dgvData3.Rows(i).Cells(4).Value).ToString.Replace(",", ".")
                        isiKolom9(cntK + 4) = CDec(dgvData3.Rows(i).Cells(5).Value).ToString.Replace(",", ".")
                        isiKolom9(cntK + 5) = CDec(dgvData3.Rows(i).Cells(6).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom9(cntK + 3) = CDbl(dgvData3.Rows(i).Cells(4).Value)
                        isiKolom9(cntK + 4) = CDbl(dgvData3.Rows(i).Cells(5).Value)
                        isiKolom9(cntK + 5) = CDbl(dgvData3.Rows(i).Cells(6).Value)
                    End If

                    cntK += 6
                Next
                clsKoneksi.insertCommand2(1, myQuery18, namaKolom9, isiKolom9)
            End If

            Dim myQuery19 As String = "INSERT INTO PembayaranBPFDetail "
            Dim namaKolom20 As String() = {"KodePembayaranBPF", "KodePembayaran", "Tanggal", "Jumlah"}
            Dim isiKolom20(4) As Object
            ReDim isiKolom20((namaKolom20.Length * dgvData2.Rows.Count) - 1)
            Dim cntJ As Integer = 0
            If dgvData2.Rows.Count = 1 Then
                For i = 0 To dgvData2.Rows.Count - 1
                    Dim edate As String = dgvData2.Rows(i).Cells(3).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.DateTimeFormatInfo.InvariantInfo,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom20(cntJ + 0) = dgvData2.Rows(i).Cells(1).Value
                    isiKolom20(cntJ + 1) = txtNoPembayaran.Text
                    isiKolom20(cntJ + 2) = expenddt
                    isiKolom20(cntJ + 3) = CDbl(dgvData2.Rows(i).Cells(4).Value)
                    cntJ += 4
                Next
                clsKoneksi.insertCommand(1, myQuery19, namaKolom20, isiKolom20)
            Else
                For i = 0 To dgvData2.Rows.Count - 1
                    Dim edate As String = dgvData2.Rows(i).Cells(3).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.DateTimeFormatInfo.InvariantInfo,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom20(cntJ + 0) = "'" & dgvData2.Rows(i).Cells(1).Value & "'"
                    isiKolom20(cntJ + 1) = "'" & txtNoPembayaran.Text & "'"
                    isiKolom20(cntJ + 2) = "'" & expenddt & "'"

                    If decimalSeparator = "," Then
                        isiKolom20(cntJ + 3) = CDbl(dgvData2.Rows(i).Cells(4).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom20(cntJ + 3) = CDbl(dgvData2.Rows(i).Cells(4).Value)
                    End If

                    cntJ += 4
                Next
                clsKoneksi.insertCommand2(1, myQuery19, namaKolom20, isiKolom20)
            End If
            
            dgvData2.Rows.Clear()
            dgvData3.Rows.Clear()
            txtNoPembayaranlama.Text = txtNoPembayaran.Text
            txtSisaBayar.Text = FormatNumber(sisaPembayaran)
        End If

        lockButton(False)
    End Sub
    Function cekIsi() As Boolean
        If txtNoPembayaran.Text = "" Then
            MessageBox.Show("Harap Isi No Pembayaran", "warning")
            txtNoPembayaran.Focus()
            GoTo salah
        End If
        If txtKodeKelompok.Text = "" Then
            MessageBox.Show("Harap Isi Nama", "warning")
            txtKodeKelompok.Focus()
            GoTo salah
        End If
        If dgView.Rows.Count = 0 Then
            MessageBox.Show("Harap Isi Pembayaran Fee", "warning")
            dgView.Focus()
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

    Private Sub frmPembayaranFee_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtNoPembayaran_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoPembayaran.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCari()
        End If
    End Sub

    Private Sub btnPembayaranFee_Click(sender As Object, e As EventArgs) Handles btnPembayaranFee.Click
        frmPembayaranBPF.ShowDialog()
    End Sub

End Class