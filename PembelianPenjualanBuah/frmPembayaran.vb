Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class frmPembayaran
    Dim pilihanBtn As String
    Dim totallama As Double = 0
    Dim selisihtotal As Double = 0
    Dim sisaPembayaran As Double = 0
    Public KodePembayaranTemp As String = ""

    Sub clearisi()
        txtNoPembayaran.Text = ""
        txtNoPembayaranlama.Text = ""
        dtTanggal.Value = Now
        txtKeterangan.Text = ""
        txtTotal.Text = "0"
        txtTotal2.Text = "0"
        txtNoAccount.Text = ""
        txtNama.Text = ""
        txtDibayar.Text = "0"
        txtSisa.Text = "0"
        txtTotalLast.Text = 0
        txtPPH.Text = 0
        txtSPSI.Text = 0
        dgView.Rows.Clear()
        txtKodeParam.Text = ""
        ckPPH.Checked = False
        ckSPSI.Checked = False
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
            tTotal += dgView.Rows(i).Cells(7).Value
        Next
        txtTotal.Text = tTotal
        txtTotal2.Text = Format(tTotal, "#,###")
        txtTotalLast.Text = Format(tTotal, "#,###")
    End Sub

    Public Sub loadPPH()
        Dim PPH As Double = 0
        Dim tPPH As Double = 0
        Dim tBagi As Double = 0
        Dim myQuery As String = ""
        Dim tDs As DataSet
        If ckPPH.Checked = True Then

            If txtNoAccount.Text = "" Then
                tPPH = 0
                Return
            End If

            If txtTotal.Text = 0 Or txtTotal.Text = "" Then
                tPPH = 0
                Return
            End If

            myQuery = "select g.*,c.* from customer as c left join grossup as g on(g.tipeGrossup=c.GrossUp) where c.NoAccount='" & txtNoAccount.Text & "'"
            tDs = clsKoneksi.selectCommand(1, myQuery)
            If tDs.Tables(0).Rows.Count > 0 Then
                PPH = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("PPH")), 0, tDs.Tables(0).Rows(0).Item("PPH"))
                tBagi = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("jenisDitanggung")), 0, tDs.Tables(0).Rows(0).Item("jenisDitanggung"))
            End If

            If tBagi = 50 Then
                tPPH = ((PPH / 100) * txtTotal.Text) / 2
            Else
                tPPH = (PPH / 100) * txtTotal.Text
            End If

            txtPPH.Text = Format(tPPH, "#,###")

        Else
            txtPPH.Text = 0
        End If

        If txtTotal.Text = "" Then
            txtTotalLast.Text = 0
        Else
            txtTotalLast.Text = Format(txtTotal.Text - txtPPH.Text - txtSPSI.Text, "#,###")
        End If

    End Sub

    Public Sub loadSPSI()
        Dim HargaPinjaman As Double = 0
        Dim HargaSPSIKaliDenganNetto As Double = 0
        Dim HargaSPSIPenjumlahanPerAccount As Double = 0
        Dim hargaSPSItotalKaliAkun As Double = 0
        Dim TotalhargaSPSItotalKaliAkun As Double = 0

        Dim totalNetto As Double = 0
        Dim totalCountNetto As Double = 0
        Dim spsicust As Double = 0

        Dim totalspsicust As Double = 0

        Dim myQuery As String = ""
        Dim tDs As DataSet

        If ckSPSI.Checked = True Then


            If txtNoAccount.Text = "" Then
                txtSPSI.Text = 0
                Return
            End If

            If txtTotal.Text = 0 Or txtTotal.Text = "" Then
                txtSPSI.Text = 0
                Return
            End If

            myQuery = "select c.* from customer as c where NoAccount='" & txtNoAccount.Text & "'"
            tDs = clsKoneksi.selectCommand(1, myQuery)
            If tDs.Tables(0).Rows.Count > 0 Then
                spsicust = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("SPSI")), 0, tDs.Tables(0).Rows(0).Item("SPSI"))
            End If

            'pinjaman
            myQuery = "select p.*,pt.* from Pinjaman as p left join PinjamanTagihan as pt on(pt.kodePinjaman=p.kodePinjaman) where p.NoAccount='" & txtNoAccount.Text & "'"
            tDs = clsKoneksi.selectCommand(1, myQuery)
            If tDs.Tables(0).Rows.Count > 0 Then
                HargaPinjaman = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("JumlahPinjamanTagihan")), 0, tDs.Tables(0).Rows(0).Item("JumlahPinjamanTagihan"))
            End If

            'netto*spsi
            For i As Integer = 0 To dgView.Rows.Count - 1
                totalNetto += dgView.Rows(i).Cells(5).Value
            Next

            HargaSPSIKaliDenganNetto = IIf(totalNetto > 0, -1 * (totalNetto * (-1 * spsicust)), 0)

            'spsi penjumlahan per account
            myQuery = "select p.* from SPSIPenjumlahanPerAccount as p where p.NoAccount='" & txtNoAccount.Text & "'"
            tDs = clsKoneksi.selectCommand(1, myQuery)
            If tDs.Tables(0).Rows.Count > 0 Then
                HargaSPSIPenjumlahanPerAccount = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("SPSI2")), 0, tDs.Tables(0).Rows(0).Item("SPSI2"))
            End If

            'TotalhargaSPSItotalKaliAkun
            For i As Integer = 0 To dgView.Rows.Count - 1
                totalCountNetto += 1
            Next

            myQuery = "select c.*,sp.* from customer as c left join SPSIKaliAccount as sp on(sp.KodeKelompok=c.KodeKelompok) where c.NoAccount='" & txtNoAccount.Text & "'"
            tDs = clsKoneksi.selectCommand(1, myQuery)
            If tDs.Tables(0).Rows.Count > 0 Then
                hargaSPSItotalKaliAkun = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("sp.SPSI")), 0, tDs.Tables(0).Rows(0).Item("sp.SPSI"))
            End If

            TotalhargaSPSItotalKaliAkun = IIf(totalCountNetto > 0, totalCountNetto * hargaSPSItotalKaliAkun, 0)

            totalspsicust = HargaPinjaman + HargaSPSIKaliDenganNetto + HargaSPSIPenjumlahanPerAccount + TotalhargaSPSItotalKaliAkun

            If totalspsicust > 0 Then
                txtSPSI.Text = Format(totalspsicust, "#,###")
            Else
                txtSPSI.Text = 0
            End If


        Else
            txtSPSI.Text = 0
        End If

        If txtTotal.Text = "" Then
            txtTotalLast.Text = 0
        Else
            If txtSPSI.Text = "" Then
                totalspsicust = 0
            Else
                totalspsicust = txtSPSI.Text
            End If
            txtTotalLast.Text = Format(txtTotal.Text - txtPPH.Text - totalspsicust, "#,###")
        End If

    End Sub

    Private Sub btnCari2_Click(sender As Object, e As EventArgs) Handles btnCari2.Click
        If dgView.Rows.Count > 0 Then
            MessageBox.Show("Pembayaran Sudah terisi, hapus detail untuk menganti No Account", "warning")
            Exit Sub
        End If

        frmPembayaranAccountCari.txtCari.Text = ""
        frmPembayaranAccountCari.cmbCari.SelectedIndex = 0
        frmPembayaranAccountCari.loadCari()
        frmPembayaranAccountCari.ShowDialog(Me)
    End Sub

    Private Sub dgView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            klikKananMenu.Show(dgView, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        If txtNoAccount.Text = "" Then
            MessageBox.Show("Harap Pilih No Account", "warning")
            Exit Sub
        End If
        frmPembayaranDetail.noAccount = txtNoAccount.Text
        frmPembayaranDetail.noTicketShow = "''"
        frmPembayaranDetail.kodePembayaran = txtNoPembayaranlama.Text

        If dgView.Rows.Count > 0 Then
            For i As Integer = 0 To dgView.Rows.Count - 1
                If i = 0 Then
                    frmPembayaranDetail.noTicketShow = "'" & dgView.Rows(i).Cells(1).Value & "'"
                Else
                    frmPembayaranDetail.noTicketShow = frmPembayaranDetail.noTicketShow & ",'" & dgView.Rows(i).Cells(1).Value & "'"
                End If
            Next
        End If
        frmPembayaranDetail.ShowDialog(Me)
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
                If dgView.SelectedCells(10).Value = "Y" Or dgView.SelectedCells(10).Value = "B" Then
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
        frmPembayaranCari.dgView.Rows.Clear()
        frmPembayaranCari.cmbCari.SelectedIndex = 0
        frmPembayaranCari.txtCari.Text = ""
        frmPembayaranCari.txtCari.Focus()
        If txtNoPembayaran.Text <> "" Then
            frmPembayaranCari.txtCari.Text = txtNoPembayaran.Text
            frmPembayaranCari.loadCari()
        End If
        frmPembayaranCari.ShowDialog()
    End Sub

    Sub loadDetail()
        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,Harga,Total,KodeKota,keterangan,StatusBayar FROM PembayaranDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtNoPembayaran.Text}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and KodeParam=" & txtKodeParam.Text & " and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(10) As Object
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
            If isiView(10) = "Y" Then
                dgView.Rows(dgView.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If

            If isiView(10) = "B" Then
                dgView.Rows(dgView.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightPink
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
        If MessageBox.Show("Anda Yakin ingin menghapus Pembayaran " & txtNoPembayaran.Text & " ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim myQuery As String = "delete from Pembayaran where KodePembayaran=@KodePembayaran"
            Dim namaKolom As String() = {"KodePembayaran"}
            Dim isiKolom As Object() = {txtNoPembayaran.Text}
            clsKoneksi.deleteCommand(1, myQuery, namaKolom, isiKolom, 1)

            Dim myQuery2 As String = "delete from PembayaranDetail where KodePembayaran=@KodePembayaran"
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom, isiKolom, 1)

            Dim myQuery6 As String = "delete from PembayaranBPT where KodePembayaran=@KodePembayaran"
            clsKoneksi.deleteCommand(1, myQuery6, namaKolom, isiKolom, 1)

            Dim myQuery4 As String = "delete from PembayaranBPTDetail where KodePembayaran=@KodePembayaran"
            clsKoneksi.deleteCommand(1, myQuery4, namaKolom, isiKolom, 1)

            For i As Integer = 0 To dgView.Rows.Count - 1
                Dim myQuery3 As String = "Update Pembelian SET "
                Dim myQuery5 As String = "Update Pembelian2 SET "
                Dim namaKolom3 As String() = {"BukaPembayaran"}
                Dim isiKolom3 As Object() = {"N"}
                Dim kondisiWhere As String = " where NoTicket=@NoTicket"
                Dim namaKolom5 As String() = {"NoTicket"}
                Dim isiKolom5 As Object() = {dgView.Rows(i).Cells(1).Value}
                clsKoneksi.updateCommand(1, myQuery3, namaKolom3, isiKolom3, kondisiWhere, namaKolom5, isiKolom5, 1)

                clsKoneksi.updateCommand(1, myQuery5, namaKolom3, isiKolom3, kondisiWhere, namaKolom5, isiKolom5, 1)

            Next

            Dim myQuery10 As String = "Delete from PembayaranNoTicket where NoTicket not in(select NoTicket from PembayaranDetail where KodeKota='" & clsKoneksi.kotaOn & "')"
            Dim cmd2 As New OleDbCommand(myQuery10, clsKoneksi.getConnection(1))
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()

            Dim myQuery11 As String = "Delete from PembayaranBertahap where KodePembayaran='" & txtNoPembayaran.Text & "'"
            Dim cmd3 As New OleDbCommand(myQuery11, clsKoneksi.getConnection(1))
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            clearisi()
        Else
            MessageBox.Show("Data Tidak Jadi di Hapus", "warning")
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cekIsi() = False Then Exit Sub
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim spsi As String = "0"
        Dim pph As String = "0"

        If ckPPH.Checked = True Then
            pph = "1"
        End If

        If ckSPSI.Checked = True Then
            spsi = "1"
        End If

        If pilihanBtn = "Baru" Then
            Dim kodeParam As Integer = 1
            Dim myQueryC As String = "select*from Pembayaran where KodePembayaran=@Cari"
            Dim namaKolomC As String() = {"Cari"}
            Dim isiKolomC As Object() = {txtNoPembayaran.Text}

            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC, namaKolomC, isiKolomC, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                If MsgBox("Nomor pembayaran sudah ada dalam database, ingin melanjutkan?", vbQuestion + vbYesNo) = vbNo Then
                    Return
                Else
                    kodeParam = CDbl(tDs.Tables(0).Rows.Count) + 1
                End If
            End If

            Dim myQuery As String = "INSERT INTO Pembayaran "
            Dim namaKolom As String() = {"KodePembayaran", "Tgl", "NoAccount", "Nama", "Keterangan", "Total", "KodeKota", "Sisa", "KodeParam", "PPH", "SPSI"}
            Dim isiKolom As Object() = {txtNoPembayaran.Text, dtTanggal.Value.Date, txtNoAccount.Text, txtNama.Text, txtKeterangan.Text, CDbl(txtTotal.Text), clsKoneksi.kotaOn, CDbl(txtTotal.Text), CDbl(kodeParam), pph, spsi}
            clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)

            Dim myQuery4 As String = "delete from PembayaranDetail where KodePembayaran=@KodePembayaran and KodeParam=@KodeParam and KodeKota=@KodeKota"
            Dim namaKolom4 As String() = {"KodePembayaran", "KodeParam", "KodeKota"}
            Dim isiKolom4 As Object() = {txtNoPembayaran.Text, kodeParam, clsKoneksi.kotaOn}
            clsKoneksi.deleteCommand(1, myQuery4, namaKolom4, isiKolom4, 1)

            Dim myQuery2 As String = "INSERT INTO PembayaranDetail "
            Dim namaKolom2 As String() = {"KodePembayaran", "NoTicket", "Tgl", "KodeProduct", "Product", "Netto", "Harga", "Total", "KodeKota", "SisaBayar", "KodeParam"}

            Dim isiKolom2(11) As Object
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
                    isiKolom2(cntT + 4) = Regex.Replace(dgView.Rows(i).Cells(4).Value, "[^A-Za-z0-9 \-/]", "")
                    isiKolom2(cntT + 5) = CDbl(dgView.Rows(i).Cells(5).Value)
                    isiKolom2(cntT + 6) = CDbl(dgView.Rows(i).Cells(6).Value)
                    isiKolom2(cntT + 7) = CDbl(dgView.Rows(i).Cells(7).Value)
                    isiKolom2(cntT + 8) = clsKoneksi.kotaOn
                    isiKolom2(cntT + 9) = CDbl(dgView.Rows(i).Cells(7).Value)
                    isiKolom2(cntT + 10) = CDbl(kodeParam)
                    cntT += 11
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
                    isiKolom2(cntT + 4) = "'" & Regex.Replace(dgView.Rows(i).Cells(4).Value, "[^A-Za-z0-9 \-/]", "") & "'"
                    isiKolom2(cntT + 5) = CDbl(dgView.Rows(i).Cells(5).Value)
                    If decimalSeparator = "," Then
                        isiKolom2(cntT + 6) = CDbl(dgView.Rows(i).Cells(6).Value).ToString.Replace(",", ".")
                        isiKolom2(cntT + 7) = CDbl(dgView.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom2(cntT + 6) = dgView.Rows(i).Cells(6).Value
                        isiKolom2(cntT + 7) = dgView.Rows(i).Cells(7).Value
                    End If
                    isiKolom2(cntT + 8) = "'" & clsKoneksi.kotaOn & "'"
                    If decimalSeparator = "," Then
                        isiKolom2(cntT + 9) = CDbl(dgView.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom2(cntT + 9) = dgView.Rows(i).Cells(7).Value
                    End If
                    isiKolom2(cntT + 10) = CDbl(kodeParam)
                    cntT += 11
                Next
                clsKoneksi.insertCommand2(1, myQuery2, namaKolom2, isiKolom2)
            End If
            txtNoPembayaranlama.Text = txtNoPembayaran.Text
            txtKodeParam.Text = kodeParam
            txtSisa.Text = FormatNumber(CDbl(txtTotal.Text))
            MsgBox("Berhasil disimpan")
        Else
            Dim kodeParam As Integer = txtKodeParam.Text
            If txtNoPembayaran.Text = txtNoPembayaranlama.Text Then
            Else
                If MessageBox.Show("No Pembayaran Lama :" & txtNoPembayaranlama.Text & " tidak sama dengan No Pembayaran Baru :" & txtNoPembayaran.Text & ", Anda yakin ingin melanjutkan Update ?", "warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    MessageBox.Show("Data Tidak jadi di update", "warning")
                    lockButton(False)
                    Exit Sub
                End If
            End If

            If txtNoPembayaran.Text <> txtNoPembayaranlama.Text Then
                Dim myQueryC As String = "select*from Pembayaran where KodePembayaran=@Cari and KodeParam=@Kode"
                Dim namaKolomC As String() = {"Cari", "Kode"}
                Dim isiKolomC As Object() = {txtNoPembayaran.Text, txtKodeParam.Text}

                Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQueryC, namaKolomC, isiKolomC, 1)
                If tDs.Tables(0).Rows.Count > 0 Then
                    If MsgBox("Nomor pembayaran sudah ada dalam database, ingin melanjutkan?", vbQuestion + vbYesNo) = vbNo Then
                        Return
                    Else
                        kodeParam = CDbl(txtKodeParam.Text) + 1
                    End If
                End If
            End If

            If CDbl(txtTotal.Text) > totallama Then
                selisihtotal = CDbl(txtTotal.Text) - totallama
                sisaPembayaran = (CDbl(totallama) - CDbl(txtDibayar.Text)) + selisihtotal
            ElseIf CDbl(txtTotal.Text) < totallama Then
                selisihtotal = totallama - CDbl(txtTotal.Text)
                sisaPembayaran = CDbl(txtSisa.Text) - selisihtotal
            Else
                selisihtotal = 0
                sisaPembayaran = CDbl(txtSisa.Text)
            End If

            Dim myQuery As String = "Update Pembayaran SET "
            Dim namaKolom As String() = {"KodePembayaran", "Tgl", "NoAccount", "Nama", "Keterangan", "Total", "KodeKota", "KodeParam", "PPH", "SPSI"}
            Dim isiKolom As Object() = {txtNoPembayaran.Text, dtTanggal.Value.Date, txtNoAccount.Text, txtNama.Text, txtKeterangan.Text, CDec(txtTotal.Text), clsKoneksi.kotaOn, CDbl(kodeParam), pph, spsi}
            Dim kondisiWhere As String = " where KodePembayaran=@KodePembayaran2 and KodeParam=@Kode and KodeKota=@KodeKota2"
            Dim namaKolom2 As String() = {"KodePembayaran2", "Kode", "KodeKota2"}
            Dim isiKolom2 As Object() = {txtNoPembayaranlama.Text, kodeParam, clsKoneksi.kotaOn}
            clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 1)

            Dim myQuery4 As String = "delete from PembayaranDetail where KodePembayaran=@KodePembayaran and KodeParam=@KodeParam and KodeKota=@KodeKota"
            Dim namaKolom4 As String() = {"KodePembayaran", "KodeParam", "KodeKota"}
            Dim isiKolom4 As Object() = {txtNoPembayaranlama.Text, kodeParam, clsKoneksi.kotaOn}
            clsKoneksi.deleteCommand(1, myQuery4, namaKolom4, isiKolom4, 1)

            Dim myQuery3 As String = "INSERT INTO PembayaranDetail "
            Dim namaKolom3 As String() = {"KodePembayaran", "NoTicket", "Tgl", "KodeProduct", "Product", "Netto", "Harga", "Total", "KodeKota", "SisaBayar", "Keterangan", "StatusBayar", "KodeParam"}

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
                        System.Globalization.DateTimeFormatInfo.InvariantInfo,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom3(cntT + 0) = txtNoPembayaran.Text
                    isiKolom3(cntT + 1) = dgView.Rows(i).Cells(1).Value
                    isiKolom3(cntT + 2) = expenddt
                    isiKolom3(cntT + 3) = dgView.Rows(i).Cells(3).Value
                    isiKolom3(cntT + 4) = Regex.Replace(dgView.Rows(i).Cells(4).Value, "[^A-Za-z0-9 \-/]", "")
                    isiKolom3(cntT + 5) = CDbl(dgView.Rows(i).Cells(5).Value)
                    isiKolom3(cntT + 6) = CDec(dgView.Rows(i).Cells(6).Value)
                    isiKolom3(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value)
                    isiKolom3(cntT + 8) = clsKoneksi.kotaOn
                    isiKolom3(cntT + 9) = CDec(dgView.Rows(i).Cells(7).Value)
                    isiKolom3(cntT + 10) = dgView.Rows(i).Cells(9).Value
                    isiKolom3(cntT + 11) = dgView.Rows(i).Cells(10).Value
                    isiKolom3(cntT + 12) = CDbl(kodeParam)
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
                        System.Globalization.DateTimeFormatInfo.InvariantInfo,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom3(cntT + 0) = "'" & txtNoPembayaran.Text & "'"
                    isiKolom3(cntT + 1) = "'" & dgView.Rows(i).Cells(1).Value & "'"
                    isiKolom3(cntT + 2) = "'" & expenddt & "'"
                    isiKolom3(cntT + 3) = "'" & dgView.Rows(i).Cells(3).Value & "'"
                    isiKolom3(cntT + 4) = "'" & Regex.Replace(dgView.Rows(i).Cells(4).Value, "[^A-Za-z0-9 \-/]", "") & "'"
                    isiKolom3(cntT + 5) = CDbl(dgView.Rows(i).Cells(5).Value)
                    If decimalSeparator = "," Then
                        isiKolom3(cntT + 6) = CDec(dgView.Rows(i).Cells(6).Value).ToString.Replace(",", ".")
                        isiKolom3(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom3(cntT + 6) = CDec(dgView.Rows(i).Cells(6).Value)
                        isiKolom3(cntT + 7) = CDec(dgView.Rows(i).Cells(7).Value)
                    End If
                    isiKolom3(cntT + 8) = "'" & clsKoneksi.kotaOn & "'"
                    If decimalSeparator = "," Then
                        isiKolom3(cntT + 9) = CDec(dgView.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom3(cntT + 9) = CDec(dgView.Rows(i).Cells(7).Value)
                    End If
                    isiKolom3(cntT + 10) = "'" & dgView.Rows(i).Cells(9).Value & "'"
                    isiKolom3(cntT + 11) = "'" & dgView.Rows(i).Cells(10).Value & "'"
                    isiKolom3(cntT + 12) = CDbl(kodeParam)
                    cntT += 13

                Next
                clsKoneksi.insertCommand2(1, myQuery3, namaKolom3, isiKolom3)
            End If

            Dim myQuery11 As String = "Update PembayaranBPT SET KodePembayaran='" & txtNoPembayaran.Text & "',KodeParam=" & kodeParam & " where KodePembayaran='" & txtNoPembayaranlama.Text & "' and KodeParam=" & txtKodeParam.Text & ""
            Dim cmd3 As New OleDbCommand(myQuery11, clsKoneksi.getConnection(1))
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            Dim myQuery12 As String = "Update PembayaranBPTDetail SET KodePembayaran='" & txtNoPembayaran.Text & "',KodeParam=" & kodeParam & " where KodePembayaran='" & txtNoPembayaranlama.Text & "' and KodeParam=" & txtKodeParam.Text & ""
            Dim cmd4 As New OleDbCommand(myQuery12, clsKoneksi.getConnection(1))
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Dim kodeBPT As String = ""
            Dim myQuery13 As String = "select * FROM PembayaranBPTDetail "
            Dim namaKolom13 As String() = {"Cari", "Kode"}
            Dim isiKolom13 As Object() = {txtNoPembayaran.Text, kodeParam}
            myQuery13 = myQuery13 & "where KodePembayaran=@Cari and KodeParam=@Kode"
            Dim tDs2 As DataSet = clsKoneksi.selectCommand(1, myQuery13, namaKolom13, isiKolom13, 1)
            dgvData2.Rows.Clear()
            Dim isiView(5) As Object
            For i As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView.Length - 1
                    If tDs2.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView(j) = ""
                    Else
                        isiView(j) = tDs2.Tables(0).Rows(i).Item(j)
                    End If
                Next
                dgvData2.Rows.Add(isiView)
                kodeBPT = isiView(1)
                kodeBPT = kodeBPT.Replace(txtNoPembayaranlama.Text, txtNoPembayaran.Text)
                dgvData2.Rows(i).Cells(1).Value = kodeBPT
            Next

            Dim myQuery15 As String = "select * FROM PembayaranBPT "
            Dim namaKolom15 As String() = {"Cari", "Kode"}
            Dim isiKolom15 As Object() = {txtNoPembayaran.Text, kodeParam}
            myQuery15 = myQuery15 & "where KodePembayaran=@Cari and KodeParam=@Kode"
            Dim tDs3 As DataSet = clsKoneksi.selectCommand(1, myQuery15, namaKolom15, isiKolom15, 1)
            dgvData3.Rows.Clear()
            Dim isiView1(8) As Object
            For i As Integer = 0 To tDs3.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView1.Length - 1
                    If tDs3.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView1(j) = ""
                    Else
                        isiView1(j) = tDs3.Tables(0).Rows(i).Item(j)
                    End If
                Next
                dgvData3.Rows.Add(isiView1)
                kodeBPT = isiView1(1)
                kodeBPT = kodeBPT.Replace(txtNoPembayaranlama.Text, txtNoPembayaran.Text)
                dgvData3.Rows(i).Cells(1).Value = kodeBPT
            Next

            Dim myQuery16 As String = "delete from PembayaranBPT where KodePembayaran=@KodePembayaran and KodeParam=@Kode"
            Dim namaKolom7 As String() = {"KodePembayaran", "Kode"}
            Dim isiKolom7 As Object() = {txtNoPembayaran.Text, kodeParam}
            clsKoneksi.deleteCommand(1, myQuery16, namaKolom7, isiKolom7, 1)

            Dim myQuery17 As String = "delete from PembayaranBPTDetail where KodePembayaran=@KodePembayaran and KodeParam=@Kode"
            Dim namaKolom8 As String() = {"KodePembayaran", "Kode"}
            Dim isiKolom8 As Object() = {txtNoPembayaran.Text, kodeParam}
            clsKoneksi.deleteCommand(1, myQuery17, namaKolom8, isiKolom8, 1)

            Dim myQuery18 As String = "INSERT INTO PembayaranBPT "
            Dim namaKolom9 As String() = {"KodePembayaranBPT", "KodePembayaran", "NoTicket", "Tanggal", "Jumlah", "Dibayar", "Sisa", "KodeParam"}
            Dim isiKolom9(8) As Object
            ReDim isiKolom9((namaKolom9.Length * dgvData3.Rows.Count) - 1)
            Dim cntK As Integer = 0
            If dgvData3.Rows.Count = 1 Then
                For i = 0 To dgvData3.Rows.Count - 1
                    Dim edate As String = dgvData3.Rows(i).Cells(4).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.DateTimeFormatInfo.InvariantInfo,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom9(cntK + 0) = dgvData3.Rows(i).Cells(1).Value
                    isiKolom9(cntK + 1) = txtNoPembayaran.Text
                    isiKolom9(cntK + 2) = "" & dgvData3.Rows(i).Cells(3).Value & ""
                    isiKolom9(cntK + 3) = expenddt
                    isiKolom9(cntK + 4) = CDbl(dgvData3.Rows(i).Cells(5).Value)
                    isiKolom9(cntK + 5) = CDbl(dgvData3.Rows(i).Cells(6).Value)
                    isiKolom9(cntK + 6) = CDbl(dgvData3.Rows(i).Cells(7).Value)
                    isiKolom9(cntK + 7) = CDec(dgvData3.Rows(i).Cells(8).Value)
                    cntK += 8
                Next
                clsKoneksi.insertCommand(1, myQuery18, namaKolom9, isiKolom9)
            Else
                For i = 0 To dgvData3.Rows.Count - 1
                    Dim edate As String = dgvData3.Rows(i).Cells(4).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.DateTimeFormatInfo.InvariantInfo,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom9(cntK + 0) = "'" & dgvData3.Rows(i).Cells(1).Value & "'"
                    isiKolom9(cntK + 1) = "'" & txtNoPembayaran.Text & "'"
                    isiKolom9(cntK + 2) = """" & dgvData3.Rows(i).Cells(3).Value & """"
                    isiKolom9(cntK + 3) = "'" & expenddt & "'"

                    If decimalSeparator = "," Then
                        isiKolom9(cntK + 4) = CDec(dgvData3.Rows(i).Cells(5).Value).ToString.Replace(",", ".")
                        isiKolom9(cntK + 5) = CDec(dgvData3.Rows(i).Cells(6).Value).ToString.Replace(",", ".")
                        isiKolom9(cntK + 6) = CDec(dgvData3.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom9(cntK + 4) = CDbl(dgvData3.Rows(i).Cells(5).Value)
                        isiKolom9(cntK + 5) = CDbl(dgvData3.Rows(i).Cells(6).Value)
                        isiKolom9(cntK + 6) = CDbl(dgvData3.Rows(i).Cells(7).Value)
                    End If
                    isiKolom9(cntK + 7) = CDbl(dgvData3.Rows(i).Cells(8).Value)
                    cntK += 8
                Next
                clsKoneksi.insertCommand2(1, myQuery18, namaKolom9, isiKolom9)
            End If

            Dim myQuery19 As String = "INSERT INTO PembayaranBPTDetail "
            Dim namaKolom10 As String() = {"KodePembayaranBPT", "KodePembayaran", "Tanggal", "Jumlah", "KodeParam"}
            Dim isiKolom10(5) As Object
            ReDim isiKolom10((namaKolom10.Length * dgvData2.Rows.Count) - 1)
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
                    isiKolom10(cntJ + 0) = dgvData2.Rows(i).Cells(1).Value
                    isiKolom10(cntJ + 1) = txtNoPembayaran.Text
                    isiKolom10(cntJ + 2) = expenddt
                    isiKolom10(cntJ + 3) = CDbl(dgvData2.Rows(i).Cells(4).Value)
                    isiKolom10(cntJ + 4) = CDec(dgvData2.Rows(i).Cells(5).Value)
                    cntJ += 5
                Next
                clsKoneksi.insertCommand(1, myQuery19, namaKolom10, isiKolom10)
            Else
                For i = 0 To dgvData2.Rows.Count - 1
                    Dim edate As String = dgvData2.Rows(i).Cells(3).Value
                    Dim edate1 As String = edate.Replace(vbLf, "")
                    Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                    Dim expenddt As Date
                    Date.TryParseExact(edate1, format,
                        System.Globalization.DateTimeFormatInfo.InvariantInfo,
                        Globalization.DateTimeStyles.None, expenddt)
                    isiKolom10(cntJ + 0) = "'" & dgvData2.Rows(i).Cells(1).Value & "'"
                    isiKolom10(cntJ + 1) = "'" & txtNoPembayaran.Text & "'"
                    isiKolom10(cntJ + 2) = "'" & expenddt & "'"

                    If decimalSeparator = "," Then
                        isiKolom10(cntJ + 3) = CDbl(dgvData2.Rows(i).Cells(4).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom10(cntJ + 3) = CDbl(dgvData2.Rows(i).Cells(4).Value)
                    End If

                    isiKolom10(cntJ + 4) = CDec(dgvData2.Rows(i).Cells(5).Value)
                    cntJ += 5
                Next
                clsKoneksi.insertCommand2(1, myQuery19, namaKolom10, isiKolom10)
            End If


            dgvData2.Rows.Clear()
            dgvData3.Rows.Clear()
            txtNoPembayaranlama.Text = txtNoPembayaran.Text
            txtKodeParam.Text = kodeParam
            txtSisa.Text = FormatNumber(sisaPembayaran)
            MsgBox("Berhasil Update")
        End If

        lockButton(False)
    End Sub

    Function cekIsi() As Boolean
        If txtNoPembayaran.Text = "" Then
            MessageBox.Show("Harap Isi No Pembayaran", "warning")
            txtNoPembayaran.Focus()
            GoTo salah
        End If
        If txtNoAccount.Text = "" Then
            MessageBox.Show("Harap Isi Nama", "warning")
            txtNoAccount.Focus()
            GoTo salah
        End If

        If dgView.Rows.Count = 0 Then
            MessageBox.Show("Harap Isi Pembayaran", "warning")
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

    Private Sub frmPembayaran_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lockButton(False)
    End Sub

    Private Sub txtNoPembayaran_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoPembayaran.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnCari.Enabled = False Then Return
            loadCari()
        End If
    End Sub

    Private Sub btnPembayaranTBS_Click(sender As Object, e As EventArgs) Handles btnPembayaranTBS.Click
        If txtNoPembayaran.Text = "" Then
            MsgBox("Pembayaran Belum Dipilih")
            Return
        End If

        If btnOk.Enabled = True Then
            MsgBox("Jika sedang mengedit, harap simpan data terlebih dahulu.")
            Return
        End If

        frmPembayaranBPTDetail.txtNoBukti.Text = txtNoPembayaran.Text
        frmPembayaranBPTDetail.txtNoAcc.Text = txtNoAccount.Text
        frmPembayaranBPTDetail.txtNama.Text = txtNama.Text
        frmPembayaranBPTDetail.txtTotal.Text = FormatNumber(CDbl(txtTotal.Text))
        frmPembayaranBPTDetail.txtTotal.Text = FormatNumber(CDbl(txtTotal.Text))
        frmPembayaranBPTDetail.txtDibayar.Text = FormatNumber(CDbl(txtDibayar.Text))
        frmPembayaranBPTDetail.txtSisa.Text = FormatNumber(CDbl(txtSisa.Text))
        frmPembayaranBPTDetail.txtKodeParam.Text = txtKodeParam.Text
        frmPembayaranBPTDetail.ShowDialog()
        'frmPembayaranBPT.ShowDialog()
    End Sub

    Private Sub ckPPH_CheckedChanged(sender As Object, e As EventArgs) Handles ckPPH.CheckedChanged
        loadPPH()
    End Sub

    Private Sub ckSPSI_CheckedChanged(sender As Object, e As EventArgs) Handles ckSPSI.CheckedChanged
        loadSPSI()
    End Sub
End Class