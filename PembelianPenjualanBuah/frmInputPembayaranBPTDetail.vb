Imports System.Data.OleDb
Public Class frmInputPembayaranBPTDetail
    Public noPembayaran As String
    Public noPembayaranBPT As String
    Public kodeParam As Integer
    Private Sub frmInputPembayaranBPTDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = Date.Now
        dtpTanggal2.Value = Date.Now
    End Sub

    Sub hitungTotal()
        Dim tTotal As Double = 0
        For i As Integer = 0 To dgView.Rows.Count - 1
            tTotal += CDbl(dgView.Rows(i).Cells(7).Value)
        Next
        txtTotal.Text = tTotal
        txtJumlah.Text = tTotal
    End Sub

    Sub bersih()
        dgView.Rows.Clear()
        txtTotal.Text = 0
        txtJumlah.Text = 0
        noPembayaran = ""
        noPembayaranBPT = ""
    End Sub

    Private Sub dgView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuKlikKanan.Show(dgView, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmInputPembayaranBTPDetailCari.noPembayaran = noPembayaran
        frmInputPembayaranBTPDetailCari.KodeParam = kodeParam
        frmInputPembayaranBTPDetailCari.noTicketShow = "''"

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

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If dgView.Rows.Count > 0 Then
            If dgView.SelectedRows.Item(0).Index >= 0 Then
                dgView.Rows.Remove(dgView.SelectedRows.Item(0))
                hitungTotal()
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim noTicket As String = ""
        Dim sisaBayar As Double = 0
        Dim maxID As Double = 0
        Dim tanggalSekarang As DateTime = Date.Now
        Dim kodeBPT As String = ""
        Dim total As String = "0"
        Dim jumlah As String = "0"
        If dgView.Rows.Count < 1 Then
            MsgBox("Belum ada TBS dipilih")
            Return
        End If

        If txtJumlah.Text = "" Then
            txtJumlah.Text = 0
        End If

        If txtJumlah.Text = 0 Then
            MsgBox("Jumlah tidak boleh 0", vbCritical)
            Return
        End If

        If CDbl(txtJumlah.Text) > CDbl(txtTotal.Text) Then
            MsgBox("Jumlah melebihi total", vbCritical)
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

        If CDbl(txtJumlah.Text) < CDbl(txtTotal.Text) Then
            sisaBayar = CDbl(txtTotal.Text) - CDbl(txtJumlah.Text)
        End If

        'cek max id
        Dim myQuery As String = "select iif(IsNull(count(IDPembayaranBPT)),0,count(IDPembayaranBPT)) from PembayaranBPT where KodePembayaran='" & noPembayaran & "' and KodeParam=" & kodeParam & ""
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        Dim isiView(0) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            maxID = isiView(0) + 1
        Next

        kodeBPT = noPembayaran & maxID

        total = txtTotal.Text
        total = total.Replace(",", ".")

        jumlah = txtJumlah.Text
        jumlah = jumlah.Replace(",", ".")

        Dim myQuery1 As String = "INSERT INTO PembayaranBPT "
        Dim namaKolom As String() = {"KodePembayaranBPT", "KodePembayaran", "NoTicket", "Tanggal", "Jumlah", "Dibayar", "Sisa", "KodeParam"}
        Dim isiKolom As Object() = {kodeBPT, noPembayaran, noTicket, dtpTanggal.Value.Date, CDbl(txtTotal.Text), CDbl(txtJumlah.Text), CDbl(sisaBayar), CDbl(kodeParam)}
        clsKoneksi.insertCommand(1, myQuery1, namaKolom, isiKolom)

        Dim myQuery2 As String = "INSERT INTO PembayaranBPTDetail "
        Dim namaKolom1 As String() = {"KodePembayaranBPT", "KodePembayaran", "Tanggal", "Jumlah", "KodeParam"}
        Dim isiKolom1 As Object() = {kodeBPT, noPembayaran, dtpTanggal.Value.Date, CDbl(txtJumlah.Text), CDbl(kodeParam)}
        clsKoneksi.insertCommand(1, myQuery2, namaKolom1, isiKolom1)

        Dim myQuery4 As String = "Update Pembayaran SET Dibayar=Dibayar+" & jumlah & ",Sisa=Total-(Dibayar+" & jumlah & ") where KodePembayaran='" & noPembayaran & "' and KodeParam=" & kodeParam & ""
        Dim cmd As New OleDbCommand(myQuery4, clsKoneksi.getConnection(1))
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()

        Dim myQuery5 As String = "Update PembayaranDetail SET Keterangan='Dalam Pembayaran',StatusBayar='B' where NoTicket in(" & noTicket & ")"
        Dim cmd1 As New OleDbCommand(myQuery5, clsKoneksi.getConnection(1))
        cmd1.Connection.Open()
        cmd1.ExecuteNonQuery()
        cmd1.Connection.Close()

        myQuery = "Update Pembelian SET BukaPembayaran='Y' where NoTicket in(" & noTicket & ")"
        Dim cmd6 As New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd6.Connection.Open()
        cmd6.ExecuteNonQuery()
        cmd6.Connection.Close()

        If CDbl(txtJumlah.Text) = CDbl(txtTotal.Text) Then
            Dim myQuery6 As String = "Update PembayaranDetail SET Keterangan='Lunas',StatusBayar='Y' where NoTicket in(" & noTicket & ")"
            Dim cmd2 As New OleDbCommand(myQuery6, clsKoneksi.getConnection(1))
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()
        End If
        frmPembayaranBPTDetail.hitungBayarSisa()
        frmPembayaranBPTDetail.tampilData()
        frmPembayaranBPT.tampilData()

        If frmPembayaran.txtNoPembayaran.Text <> "" Then
            frmPembayaran.loadDetail()
        End If

        MsgBox("Berhasil disimpan")
        bersih()
        Me.Close()
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        clsKoneksi.OnlyNumber(e, txtJumlah)
    End Sub

End Class