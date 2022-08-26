Imports System.Data.OleDb
Public Class frmPembayaranBPTDetailEdit
    Public noBPT As String = ""
    Public noTBS As String = ""
    Public KodeParam As Integer
    Public noTicket As String = ""
    Public totalLama As Double = 0
    Public sisaSekarang As Double = 0
    Public hasilPengurangan As Double = 0
    Public dibayarSekarang As Double = 0

    Sub tampilData()
        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,Harga,Total,KodeKota FROM PembayaranDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {noTBS}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and NoTicket in(" & noTicket & ") and KodeParam=" & KodeParam & " and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(8) As Object
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

    Sub tampilBPTDetail()
        Dim myQuery As String = "select * FROM PembayaranBPTDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {noBPT}
        myQuery = myQuery & "where KodePembayaranBPT"
        myQuery = myQuery & " =@Cari and KodeParam=" & KodeParam & ""
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgvdata.Rows.Clear()
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
            dgvdata.Rows.Add(isiView)
        Next
    End Sub

    Sub hitungTotal()
        Dim tTotal As Double = 0
        Dim tBayar As Double = 0
        For i As Integer = 0 To dgView.Rows.Count - 1
            tTotal += CDbl(dgView.Rows(i).Cells(7).Value)
        Next
        txtTotal.Text = FormatNumber(tTotal, 2)

        For i As Integer = 0 To dgvdata.Rows.Count - 1
            tBayar += CDbl(dgvdata.Rows(i).Cells(4).Value)
        Next

        txtDibayar.Text = FormatNumber(tBayar, 2)

        If tTotal < totalLama Then
            hasilPengurangan = totalLama - tTotal
        ElseIf tTotal > totalLama Then
            hasilPengurangan = tTotal - totalLama
        End If

        txtSisa.Text = FormatNumber(tTotal - CDbl(txtDibayar.Text))

    End Sub

    Private Sub btnDropDown_Click(sender As Object, e As EventArgs) Handles btnDropDown.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            Me.Height = 340
            lblCapt.Text = "Lihat TBS terpilih"
        Else
            Panel1.Visible = True
            Me.Height = 520
            lblCapt.Text = "Sembunyikan TBS terpilih"
        End If

    End Sub

    Private Sub frmPembayaranBPTDetailEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Me.Height = 340
        tampilData()
        tampilBPTDetail()
    End Sub


    Private Sub dgView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuKlikKanan1.Show(dgView, e.Location)
        End If
    End Sub

    Private Sub mnuHapus1_Click(sender As Object, e As EventArgs) Handles mnuHapus1.Click
        If dgView.Rows.Count > 0 Then
            If dgView.SelectedRows.Item(0).Index >= 0 Then
                dgView.Rows.Remove(dgView.SelectedRows.Item(0))
                hitungTotal()
            End If
        End If
    End Sub

    Private Sub mnuTambah1_Click(sender As Object, e As EventArgs) Handles mnuTambah1.Click
        frmInputPembayaranBTPDetailCari.noPembayaran = noTBS
        frmInputPembayaranBTPDetailCari.KodeParam = KodeParam
        frmInputPembayaranBTPDetailCari.noTicketShow = "''"
        frmInputPembayaranBTPDetailCari.modeTampil = "B"

        If dgView.Rows.Count > 0 Then
            For i As Integer = 0 To dgView.Rows.Count - 1
                If i = 0 Then
                    frmInputPembayaranBTPDetailCari.noTicketShow = "'" & dgView.Rows(i).Cells(1).Value & "'"
                Else
                    frmInputPembayaranBTPDetailCari.noTicketShow = frmInputPembayaranBTPDetailCari.noTicketShow & ",'" & dgView.Rows(i).Cells(1).Value & "'"
                End If
            Next
        End If
        frmInputPembayaranBTPDetailCari.ShowDialog()
    End Sub

    Private Sub dgvdata_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvdata.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuKlikKanan2.Show(dgvdata, e.Location)
        End If
    End Sub

    Private Sub mnuHapus2_Click(sender As Object, e As EventArgs) Handles mnuHapus2.Click
        If dgvdata.Rows.Count > 0 Then
            If dgvdata.SelectedRows.Item(0).Index >= 0 Then
                dgvdata.Rows.Remove(dgvdata.SelectedRows.Item(0))
                hitungTotal()
            End If
        End If
    End Sub

    Private Sub mnuRefresh_Click(sender As Object, e As EventArgs) Handles mnuRefresh1.Click
        tampilData()
        hitungTotal()
    End Sub

    Private Sub mnuRefresh2_Click(sender As Object, e As EventArgs) Handles mnuRefresh2.Click
        tampilBPTDetail()
        hitungTotal()
    End Sub

    Private Sub mnuTambah2_Click(sender As Object, e As EventArgs) Handles mnuTambah2.Click
        frmInputPembayaranBPTDetailEdit.ShowDialog()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim noTicket As String = ""
        Dim myQuery As String = ""
        Dim dibayar As Double = 0
        Dim sisa As Double = 0
        If dgvdata.Rows.Count < 1 Then
            MsgBox("Harap tambah terlebih dahulu pembayaran", vbCritical)
            Return
        End If

        If CDbl(txtSisa.Text) < 0 Then
            MsgBox("Sisa tidak boleh minus atau kurang dari 0, mohon periksa kembali", vbCritical)
            Return
        End If

        If CDbl(txtDibayar.Text) > CDbl(txtTotal.Text) Then
            MsgBox("Jumlah dibayar melebihi jumlah total, mohon periksa kembali", vbCritical)
            Return
        End If


        If dgView.Rows.Count > 0 Then
            For i As Integer = 0 To dgView.Rows.Count - 1
                If i = 0 Then
                    noTicket = "'" & dgView.Rows(i).Cells(1).Value & "'"
                Else
                    noTicket = noTicket & ",'" & dgView.Rows(i).Cells(1).Value & "'"
                End If
            Next
        End If

        'cek No Ticket
        Dim noTicketAwal As String = ""
        myQuery = "select NoTicket FROM PembayaranBPT where KodePembayaranBPT='" & noBPT & "' and KodeParam=" & KodeParam & ""
        Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, myQuery)
        Dim isiView1(0) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            noTicketAwal = isiView1(0)
        Next

        myQuery = "Update PembayaranDetail SET Keterangan='',StatusBayar='' where KodePembayaran='" & noTBS & "' and KodeParam=" & KodeParam & " and NoTicket in(" & noTicketAwal & ")"
        Dim cmd2 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd2.Connection.Open()
        cmd2.ExecuteNonQuery()
        cmd2.Connection.Close()

        myQuery = "Update Pembelian SET BukaPembayaran='N' where NoTicket in(" & noTicketAwal & ")"
        Dim cmd6 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd6.Connection.Open()
        cmd6.ExecuteNonQuery()
        cmd6.Connection.Close()

        myQuery = "Update Pembelian2 SET BukaPembayaran='N' where NoTicket in(" & noTicketAwal & ")"
        Dim cmd7 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd7.Connection.Open()
        cmd7.ExecuteNonQuery()
        cmd7.Connection.Close()

        myQuery = "Update PembayaranBPT SET "
        Dim namaKolom1 As String() = {"NoTicket", "Jumlah", "Dibayar", "Sisa"}
        Dim isiKolom1 As Object() = {noTicket, CDbl(txtTotal.Text), CDbl(txtDibayar.Text), CDbl(txtSisa.Text)}
        Dim kondisiWhere1 As String = " where KodePembayaranBPT=@KodePembayaranBPT and KodeParam=@KodeParam"
        Dim namaKolom3 As String() = {"KodePembayaranBPT", "KodeParam"}
        Dim isiKolom3 As Object() = {noBPT, KodeParam}
        clsKoneksi.updateCommand(1, myQuery, namaKolom1, isiKolom1, kondisiWhere1, namaKolom3, isiKolom3, 1)

        myQuery = "delete from PembayaranBPTDetail where KodePembayaranBPT='" & noBPT & "' and KodeParam=" & KodeParam & ""
        Dim cmd1 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd1.Connection.Open()
        cmd1.ExecuteNonQuery()
        cmd1.Connection.Close()

        myQuery = "INSERT INTO PembayaranBPTDetail "
        Dim namaKolom4 As String() = {"KodePembayaranBPT", "KodePembayaran", "Tanggal", "Jumlah", "KodeParam"}
        Dim isiKolom4(5) As Object
        ReDim isiKolom4((namaKolom4.Length * dgvdata.Rows.Count) - 1)
        Dim cntT As Integer = 0
        If dgvdata.Rows.Count = 1 Then
            For i = 0 To dgvdata.Rows.Count - 1
                Dim edate As String = dgvdata.Rows(i).Cells(3).Value
                Dim edate1 As String = edate.Replace(vbLf, "")
                Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                Dim expenddt As Date
                Date.TryParseExact(edate1, format,
                    System.Globalization.CultureInfo.CurrentCulture,
                    Globalization.DateTimeStyles.None, expenddt)
                isiKolom4(cntT + 0) = dgvdata.Rows(i).Cells(1).Value
                isiKolom4(cntT + 1) = dgvdata.Rows(i).Cells(2).Value
                isiKolom4(cntT + 2) = expenddt
                isiKolom4(cntT + 3) = CDbl(dgvdata.Rows(i).Cells(4).Value)
                isiKolom4(cntT + 4) = KodeParam
                cntT += 5
            Next
            clsKoneksi.insertCommand(1, myQuery, namaKolom4, isiKolom4)
        Else

            For i = 0 To dgvdata.Rows.Count - 1
                Dim edate As String = dgvdata.Rows(i).Cells(3).Value
                Dim edate1 As String = edate.Replace(vbLf, "")
                Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                Dim expenddt As Date
                Date.TryParseExact(edate1, format,
                    System.Globalization.CultureInfo.CurrentCulture,
                    Globalization.DateTimeStyles.None, expenddt)
                isiKolom4(cntT + 0) = "'" & dgvdata.Rows(i).Cells(1).Value & "'"
                isiKolom4(cntT + 1) = "'" & dgvdata.Rows(i).Cells(2).Value & "'"
                isiKolom4(cntT + 2) = "'" & expenddt & "'"
                If decimalSeparator = "," Then
                    isiKolom4(cntT + 3) = CDec(dgvdata.Rows(i).Cells(4).Value).ToString.Replace(",", ".")
                Else
                    isiKolom4(cntT + 3) = CDec(dgvdata.Rows(i).Cells(4).Value)
                End If
                isiKolom4(cntT + 4) = CDbl(KodeParam)
                cntT += 5

            Next
            clsKoneksi.insertCommand2(1, myQuery, namaKolom4, isiKolom4)

        End If

        'sum bayar dan sisa
        myQuery = "select iif(IsNull(SUM(Dibayar)),0,SUM(Dibayar)),iif(IsNull(SUM(Sisa)),0,SUM(Sisa)) from PembayaranBPT where KodePembayaran='" & noTBS & "' and KodeParam=" & KodeParam & ""
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        Dim isiView(1) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dibayar = isiView(0)
            sisa = isiView(1)
        Next

        myQuery = "Update Pembayaran SET Dibayar=" & CDbl(dibayar) & ",Sisa=Total-" & CDbl(dibayar) & " where KodePembayaran='" & noTBS & "' and KodeParam=" & KodeParam & ""
        Dim cmd As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()

        myQuery = "Update PembayaranDetail SET Keterangan='Dalam Pembayaran',StatusBayar='B' where NoTicket in(" & noTicket & ")"
        Dim cmd3 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        myQuery = "Update Pembelian SET BukaPembayaran='Y' where NoTicket in(" & noTicket & ")"
        Dim cmd5 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd5.Connection.Open()
        cmd5.ExecuteNonQuery()
        cmd5.Connection.Close()

        myQuery = "Update Pembelian2 SET BukaPembayaran='Y' where NoTicket in(" & noTicket & ")"
        Dim cmd8 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd8.Connection.Open()
        cmd8.ExecuteNonQuery()
        cmd8.Connection.Close()

        If CDbl(txtSisa.Text) = 0 Then
            myQuery = "Update PembayaranDetail SET Keterangan='Lunas',StatusBayar='Y' where NoTicket in(" & noTicket & ")"
            Dim cmd4 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

        End If

        frmPembayaranBPTDetail.hitungBayarSisa()
        frmPembayaranBPTDetail.tampilData()
        frmPembayaranBPT.tampilData()

        If frmPembayaran.txtNoPembayaran.Text <> "" Then
            frmPembayaran.loadDetail()
        End If

        MsgBox("Berhasil diedit")
        Me.Close()

    End Sub
End Class