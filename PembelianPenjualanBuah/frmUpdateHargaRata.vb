Imports System.Data.OleDb
Public Class frmUpdateHargaRata

    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga.Click

        Dim rataRata As Double = 0
        Dim tbsMasuk As Double = 0
        Dim totalNetto As Double = 0

        Dim query As String = ""
        Dim cmd As New OleDbCommand
        Dim tDs As DataSet

        'cek total dan rata
        'Dim myQuery As String = "SELECT IIF(IsNull(SUM(p.netto*(p.hargaAkhir-p.potongan))),0,SUM(p.netto*(p.hargaAkhir-p.potongan))) as Total,IIF(IsNull(SUM([p.Netto])),0,SUM([p.Netto])) as Netto,IIF(IsNull(SUM([p.Total])/SUM([p.Netto])),0,SUM([p.Total])/SUM([p.Netto])) as rata FROM (Pembelian p Left Join Customer c on p.noaccount=c.noaccount) left join kelompok as k on k.KodeKelompok=c.KodeKelompok "
        'myQuery = myQuery & " Where (p.Tgl2>=#" & dtpAwal.Value.ToString("MM/dd/yyyy") & "#" & " and p.Tgl2<=#" & dtpTanggal.Value.ToString("MM/dd/yyyy") & "#) and p.kodekota='" & clsKoneksi.kotaOn & "' and iif(p.kodekota='2',k.bulananHarga<>'Y',c.Grade <> 'A')"

        Dim myQuery As String = "SELECT IIF(IsNull(SUM(p.netto*(p.hargaAkhir-p.potongan))),0,SUM(p.netto*(p.hargaAkhir-p.potongan))) as Total,IIF(IsNull(SUM([p.Netto])),0,SUM([p.Netto])) as Netto,IIF(IsNull(SUM([p.Total])/SUM([p.Netto])),0,SUM([p.Total])/SUM([p.Netto])) as rata FROM Pembelian p Left Join Customer c on p.noaccount=c.noaccount "
        myQuery = myQuery & " Where (p.Tgl2>=#" & dtpAwal.Value.ToString("MM/dd/yyyy") & "#" & " and p.Tgl2<=#" & dtpTanggal.Value.ToString("MM/dd/yyyy") & "#) and p.kodekota='" & clsKoneksi.kotaOn & "' and c.Grade <> 'A'"

        tDs = clsKoneksi.selectCommand(1, myQuery)
        Dim isiView(2) As Object

        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            rataRata = isiView(0) / isiView(1)
            totalNetto = isiView(1)
            tbsMasuk = isiView(0)
        Next

        'cek jika hari ini tanggal 1, akumulasi
        If dtpTanggal.Value.ToString("dd") = "01" Then
            Dim myQuery10 As String = "select AkkHargaHari from KalkulasiHargaGradeA where"
            Dim namaKolom10 As String() = {"Tanggal", "kodeKota"}
            Dim isiKolom10 As Object() = {dtpTanggal.Value.Date, clsKoneksi.kotaOn}
            myQuery10 = myQuery10 & " Tanggal=@Tanggal and kodeKota=@kodeKota"
            Dim tDs5 As DataSet = clsKoneksi.selectCommand(1, myQuery10, namaKolom10, isiKolom10, 1)
            If tDs5.Tables(0).Rows.Count > 0 Then
                Dim myQuery11 As String = "Update KalkulasiHargaGradeA set "
                Dim namaKolom11 As String() = {"tbsMasuk", "HargaRill", "AkkTbsMasuk", "AkkHargaRill", "HargaHari", "AkkHargaHari"}
                Dim isiKolom11 As Object() = {CDbl(totalNetto), CDbl(tbsMasuk), CDbl(totalNetto), CDbl(tbsMasuk), CDbl(rataRata), CDbl(rataRata)}

                Dim kondisiWhere4 As String = " where Tanggal=@Tanggal and kodeKota=@kodeKota"
                Dim namaKolom12 As String() = {"Tanggal", "kodeKota"}
                Dim isiKolom12 As Object() = {dtpTanggal.Value.Date, clsKoneksi.kotaOn}
                clsKoneksi.updateCommand(1, myQuery11, namaKolom11, isiKolom11, kondisiWhere4, namaKolom12, isiKolom12, 1)
            Else
                Dim myQuery4 As String = "Insert into KalkulasiHargaGradeA "
                Dim namaKolom As String() = {"Tanggal", "tbsMasuk", "HargaRill", "AkkTbsMasuk", "AkkHargaRill", "HargaHari", "AkkHargaHari", "KodeKota"}
                Dim isiKolom As Object() = {dtpTanggal.Value.Date, CDbl(totalNetto), CDbl(tbsMasuk), CDbl(totalNetto), CDbl(tbsMasuk), CDbl(rataRata), CDbl(rataRata), clsKoneksi.kotaOn}
                clsKoneksi.insertCommand(1, myQuery4, namaKolom, isiKolom)
            End If
        End If

        'cek apakah hari ini tanggal terakhir, kalau iya maka dibulatkan
        If dtpTanggal.Value.Date = dtpAkhir.Value.Date Then
            rataRata = CInt(rataRata)
        End If

        Dim myQuery15 As String = "update (harga as h left join Kelompok as kl on kl.KodeKelompok=h.KodeKelompok) set "
        Dim namaKolom15 As String() = {"h.harga"}
        Dim isiKolom15 As Object() = {CDbl(rataRata)}
        Dim kondisiWhere5 As String = " where h.KodeKelompok=kl.KodeKelompok and h.Tgl=@Tgl and h.kodeKota=@kodeKota and kl.Grade='A'"
        Dim namaKolom13 As String() = {"Tgl", "kodeKota"}
        Dim isiKolom13 As Object() = {dtpTanggal.Value.Date, clsKoneksi.kotaOn}
        clsKoneksi.updateCommand(1, myQuery15, namaKolom15, isiKolom15, kondisiWhere5, namaKolom13, isiKolom13, 1)

        query = "Select kodekelompok from kelompok where grade='A' and kodeKota='" & clsKoneksi.kotaOn & "' and KodeKelompok not in(select h.KodeKelompok from (harga as h left join Kelompok as kl on kl.KodeKelompok=h.KodeKelompok) where h.Tgl=#" & dtpTanggal.Value.ToString("MM/dd/yyyy") & "# and h.kodeKota='" & clsKoneksi.kotaOn & "')"
        tDs = clsKoneksi.selectCommand(1, query)
        dgvKodeKelompok.Rows.Clear()
        Dim isiView1(0) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvKodeKelompok.Rows.Add(isiView1)
        Next


        Dim myQuery2 As String = "INSERT INTO harga "
        Dim namaKolom2 As String() = {"KodeKelompok", "[Tgl]", "[Jam]", "Harga", "Perubahan", "kodeKota"}

        Dim isiKolom2(13) As Object
        ReDim isiKolom2((namaKolom2.Length * dgvKodeKelompok.Rows.Count) - 1)
        Dim cntT As Integer = 0
        If dgvKodeKelompok.Rows.Count = 1 Then
            For i = 0 To dgvKodeKelompok.Rows.Count - 1
                isiKolom2(cntT + 0) = dgvKodeKelompok.Rows(i).Cells(0).Value
                isiKolom2(cntT + 1) = dtpTanggal.Value.Date
                isiKolom2(cntT + 2) = "00:00:00"
                isiKolom2(cntT + 3) = CDbl(rataRata)
                isiKolom2(cntT + 4) = CInt(0)
                isiKolom2(cntT + 5) = clsKoneksi.kotaOn
                cntT += 6
            Next
            clsKoneksi.insertCommand(1, myQuery2, namaKolom2, isiKolom2)
        Else
            For i = 0 To dgvKodeKelompok.Rows.Count - 1
                isiKolom2(cntT + 0) = "'" & dgvKodeKelompok.Rows(i).Cells(0).Value & "'"
                isiKolom2(cntT + 1) = "'" & dtpTanggal.Value.Date & "'"
                isiKolom2(cntT + 2) = "'00:00:00'"
                isiKolom2(cntT + 3) = CDbl(rataRata)
                isiKolom2(cntT + 4) = CInt(0)
                isiKolom2(cntT + 5) = "'" & clsKoneksi.kotaOn & "'"
                cntT += 6
            Next
            clsKoneksi.insertCommand2(1, myQuery2, namaKolom2, isiKolom2)
        End If
        MsgBox("Terupdate")
        Me.Close()

    End Sub

    Private Sub dtpTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggal.ValueChanged
        dtpAkhir.Value = clsKoneksi.tglAkhirBulan(dtpTanggal.Value.Date)
        dtpAwal.Value = clsKoneksi.tglAwalBulan(dtpTanggal.Value.Date)
    End Sub

    Private Sub frmUpdateHargaRata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpAkhir.Value = clsKoneksi.tglAkhirBulan(dtpTanggal.Value.Date)
        dtpAwal.Value = clsKoneksi.tglAwalBulan(dtpTanggal.Value.Date)
    End Sub
End Class