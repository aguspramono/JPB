Imports System.Data.OleDb
Public Class frmInputPembayaranBTPBertahap
    Public noPembayaran As String = ""
    Public nettoDibayar As Double = 0
    Public idEdit As String = ""
    Public noAcc As String = ""
    Public idParam As Double
    Public edit As Boolean = False
    Public jumlahBayar As Double = 0
    Public dibayar As Double = 0
    Public nettoPertahapDibayar As Double = 0


    Sub bersih()
        txtKodePembayaranBertahap.Clear()
        txtSisaBayar.Text = 0
        txtJumlahBayar.Text = 0
        txtKeterangan.Clear()
        txtNettoDibayar.Text = 0
        txtSisaNetto.Text = 0
        lblPembayaranBertahaplama.Text = ""
        noPembayaran = ""
        nettoDibayar = 0
        idEdit = ""
        noAcc = ""
        idParam = 0
        edit = False
        jumlahBayar = 0
        dibayar = 0
        nettoPertahapDibayar = 0
    End Sub
    Sub JumlahNettoTotal()
        Dim nettoTotaldiBayar As Double = 0
        Dim totalSeluruhNetto As Double = 0
        Dim query As String = ""
        query = "select iiF(IsNull(sum(netto)),0,sum(netto)) as nettoA from PembayaranDetail where KodePembayaran='" & noPembayaran & "' and statusBayar='Y'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, query)
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
            nettoTotaldiBayar = isiView(0)
        Next


        query = "select iiF(IsNull(sum(netto)),0,sum(netto)) as nettoA from PembayaranDetail where KodePembayaran='" & noPembayaran & "'"
        Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, query)
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
            totalSeluruhNetto = isiView1(0)
        Next
        txtSisaNetto.Text = FormatNumber(CDbl(totalSeluruhNetto) - CDbl(nettoDibayar))
    End Sub

    Private Sub frmInputPembayaranBTPBertahap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub

    Private Sub frmInputPembayaranBTPBertahap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = Date.Now
        JumlahNettoTotal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kodeParam As Double = 1
        Dim sisaBayar As Double = 0
        Dim cmd As OleDbCommand
        Dim query As String = ""

        If txtNettoDibayar.Text = "" Then
            txtNettoDibayar.Text = 0
        End If
        If txtJumlahBayar.Text = "" Then
            txtJumlahBayar.Text = 0
        End If

        If txtKodePembayaranBertahap.Text = "" Then
            MsgBox("No Pembayaran Masih Kosong")
            Return
        End If

        query = "select KodePembayaran from PembayaranBPT where KodePembayaran='" & noPembayaran & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, query)
        If tDs.Tables(0).Rows.Count > 0 Then
            MsgBox("Data sudah ada didalam pembayaran penuh, mohon cek kembali")
            Return
        End If

        If txtSisaNetto.Text = 0 Then
            MsgBox("Sisa Netto Sudah 0")
            Return
        End If

        If txtSisaBayar.Text = 0 Then
            MsgBox("Sisa Bayar Sudah 0")
            Return
        End If


        If txtKeterangan.Text = "" Then
            MsgBox("Keterangan harus diisi")
            Return
        End If

        

        If edit = False Then

            query = "select KodePembayaranBertahap from PembayaranBertahap where KodePembayaranBertahap='" & txtKodePembayaranBertahap.Text & "'"
            Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, query)
            If tDs1.Tables(0).Rows.Count > 0 Then
                If MsgBox("Kode pembayaran ini sudah ada dalam database, apakah anda ingin melanjutkan?", vbQuestion + vbYesNo) = vbNo Then
                    Return
                Else
                    kodeParam = kodeParam + 1
                End If
            End If

            If CDbl(txtNettoDibayar.Text) > CDbl(txtSisaNetto.Text) Then
                MsgBox("Netto dibayar tidak boleh lebih besar dari sisa netto")
                Return
            End If

            If CDbl(txtJumlahBayar.Text) > CDbl(txtSisaBayar.Text) Then
                MsgBox("Jumlah dibayar tidak boleh lebih besar dari sisa bayar")
                Return
            End If

            Dim myQuery As String = "INSERT INTO PembayaranBertahap "
            Dim namaKolom As String() = {"KodePembayaran", "KodePembayaranBertahap", "NoAccount", "TglBertahap", "NettoDibayar", "Jumlah", "Keterangan", "KodeParamBertahap"}
            Dim isiKolom As Object() = {noPembayaran, txtKodePembayaranBertahap.Text, noAcc, dtpTanggal.Value.Date, CDbl(txtNettoDibayar.Text), CDbl(txtJumlahBayar.Text), txtKeterangan.Text, CDbl(kodeParam)}
            clsKoneksi.insertCommand(1, myQuery, namaKolom, isiKolom)

            sisaBayar = CDbl(txtSisaBayar.Text) - CDbl(txtJumlahBayar.Text)

            query = "Update Pembayaran set Dibayar=Dibayar+" & CDbl(txtJumlahBayar.Text) & ",Sisa=" & sisaBayar & " where KodePembayaran='" & noPembayaran & "'"
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            If sisaBayar = 0 Then
                query = "Update PembayaranDetail set StatusBayar='Y',Keterangan='Lunas' where KodePembayaran='" & noPembayaran & "'"
            Else
                query = "Update PembayaranDetail set StatusBayar='B',Keterangan='Bayar Bertahap' where KodePembayaran='" & noPembayaran & "'"
            End If

            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
        Else
            If txtKodePembayaranBertahap.Text <> lblPembayaranBertahaplama.Text Then
                query = "select KodePembayaranBertahap from PembayaranBertahap where KodePembayaranBertahap='" & txtKodePembayaranBertahap.Text & "'"
                Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, query)
                If tDs1.Tables(0).Rows.Count > 0 Then
                    If MsgBox("Kode pembayaran ini sudah ada dalam database, apakah anda ingin melanjutkan?", vbQuestion + vbYesNo) = vbNo Then
                        Return
                    Else
                        kodeParam = kodeParam + 1
                    End If
                End If
            End If

            Dim sisaPenguranganBayar As Double = 0
            Dim sisaPenguranganNetto As Double = 0
            Dim bayarSekarang As Double = 0
            Dim sisaBayarsekarang As Double = 0

            If CDbl(txtJumlahBayar.Text) >= jumlahBayar Then
                sisaPenguranganBayar = CDbl(txtJumlahBayar.Text) - jumlahBayar
                bayarSekarang = dibayar + sisaPenguranganBayar
                sisaBayarsekarang = CDbl(txtSisaBayar.Text) - sisaPenguranganBayar
            Else
                sisaPenguranganBayar = jumlahBayar - CDbl(txtJumlahBayar.Text)
                bayarSekarang = dibayar - sisaPenguranganBayar
                sisaBayarsekarang = CDbl(txtSisaBayar.Text) + sisaPenguranganBayar
            End If

            If CDbl(txtNettoDibayar.Text) >= nettoPertahapDibayar Then
                sisaPenguranganNetto = CDbl(txtNettoDibayar.Text) - nettoPertahapDibayar
            Else
                sisaPenguranganNetto = nettoPertahapDibayar - CDbl(txtNettoDibayar.Text)
            End If

            If sisaPenguranganNetto > CDbl(txtSisaNetto.Text) Then
                MsgBox("Sisa Netto dibayar tidak boleh lebih besar dari sisa netto saat ini")
                Return
            End If

            If sisaPenguranganBayar > CDbl(txtSisaBayar.Text) Then
                MsgBox("Jumlah dibayar tidak boleh lebih besar dari sisa bayar saat ini")
                Return
            End If


            Dim myQuery1 As String = "UPDATE PembayaranBertahap Set "
            Dim namaKolom1 As String() = {"KodePembayaran", "KodePembayaranBertahap", "NoAccount", "TglBertahap", "NettoDibayar", "Jumlah", "Keterangan", "KodeParamBertahap"}
            Dim isiKolom1 As Object() = {noPembayaran, txtKodePembayaranBertahap.Text, noAcc, dtpTanggal.Value.Date, CDbl(txtNettoDibayar.Text), CDbl(txtJumlahBayar.Text), txtKeterangan.Text, CDbl(kodeParam)}

            Dim kondisiWhere As String = " where KodePembayaran =@KodePembayaran and KodePembayaranBertahap=@KodePembayaranBertahap and KodeParamBertahap=@KodeParamBertahap "
            Dim namaKolom2 As String() = {"KodePembayaran", "KodePembayaranBertahap", "KodeParamBertahap"}
            Dim isiKolom2 As Object() = {noPembayaran, lblPembayaranBertahaplama.Text, CDbl(idParam)}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)

            query = "Update Pembayaran set Dibayar=" & bayarSekarang & ",Sisa=" & sisaBayarsekarang & " where KodePembayaran='" & noPembayaran & "'"
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            If sisaBayarsekarang = 0 Then
                query = "Update PembayaranDetail set StatusBayar='Y',Keterangan='Lunas' where KodePembayaran='" & noPembayaran & "'"
            Else
                query = "Update PembayaranDetail set StatusBayar='B',Keterangan='Bayar Bertahap' where KodePembayaran='" & noPembayaran & "'"
            End If

            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        End If

        frmPembayaranBPTDetail.hitungBayarSisa()
        frmPembayaranBPTBertahap.tampilData()
        frmPembayaran.loadDetail()
        MsgBox("Proses Berhasil")
        bersih()
        Me.Close()

    End Sub
End Class