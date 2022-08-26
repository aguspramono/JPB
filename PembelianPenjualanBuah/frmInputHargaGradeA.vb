Imports System.Data.OleDb
Public Class frmInputHargaGradeA

    Sub tampilJumlahNettodanTotal()
        Dim myQuery As String = "SELECT P.Tgl2,IIF(IsNull(SUM([p.Netto])),0,SUM([p.Netto])) as Netto,IIF(IsNull(SUM(p.netto*(p.hargaAkhir-p.potongan))),0,SUM(p.netto*(p.hargaAkhir-p.potongan))) as Total FROM Pembelian p Left Outer Join Customer c on p.noaccount=c.noaccount "
        myQuery = myQuery & " Where month(p.Tgl2)='" & dtpTanggal.Value.Month & "' and year(p.Tgl2)='" & dtpTanggal.Value.Year & "' and p.Tgl2 in (select Tanggal from KalkulasiHargaGradeA) and p.kodekota='" & clsKoneksi.kotaOn & "' group by p.Tgl2"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvTotalSekarang.Rows.Clear()
        Dim isiView(2) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvTotalSekarang.Rows.Add(isiView)

            dgvTotalSekarang.Rows(i).Cells(3).Value = True
        Next
    End Sub

    Sub tampilAkk()
        Dim AkkTBSMasuk As Double = 0
        Dim akkHargaRill As Double = 0
        Dim akkHarga As Double = 0
        Dim hargaRataBiasa As Double = 0
        Dim myQuery As String = "select * from  KalkulasiHargaGradeA as TB1"
        myQuery = myQuery & " Where  month(TB1.Tanggal)='" & dtpTanggal.Value.Month & "' and year(TB1.Tanggal)='" & dtpTanggal.Value.Year & "' and TB1.kodekota='" & clsKoneksi.kotaOn & "' order by TB1.Tanggal"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(6) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvData.Rows.Add(isiView)
            AkkTBSMasuk += CDbl(dgvData.Rows(i).Cells(1).Value)
            akkHargaRill += CDbl(dgvData.Rows(i).Cells(2).Value)

            'If (CDbl(dgvData.Rows(i).Cells(1).Value) = 0) Then
            '    AkkTBSMasuk = 0
            'End If

            'If (CDbl(dgvData.Rows(i).Cells(2).Value) = 0) Then
            '    akkHargaRill = 0
            'End If

            dgvData.Rows(i).Cells(3).Value = AkkTBSMasuk
            dgvData.Rows(i).Cells(4).Value = akkHargaRill

            akkHarga = akkHargaRill / AkkTBSMasuk
            hargaRataBiasa = CDbl(dgvData.Rows(i).Cells(2).Value) / CDbl(dgvData.Rows(i).Cells(1).Value)

            'If Double.IsNaN(akkHarga) Then
            '    akkHarga = 0
            'End If

            If Double.IsNaN(hargaRataBiasa) Then
                hargaRataBiasa = 0
            End If

            dgvData.Rows(i).Cells(5).Value = hargaRataBiasa

            dgvData.Rows(i).Cells(6).Value = akkHarga

            dgvData.Rows(i).Cells(7).Value = True
        Next
    End Sub


    Private Sub btnOke_Click(sender As Object, e As EventArgs) Handles btnOke.Click
        tampilJumlahNettodanTotal()
        tampilAkk()
        Dim cmd As New OleDbCommand
        Dim bulan As String = ""
        Dim query As String = ""
        Dim query2 As String = ""
        Dim tanggal As String = ""
        Dim harga As String = "0"
        Dim harga2 As Double = 0
        Dim kodeKelompok As String = ""

        Dim whereWaktu As String = ""

        Dim hargaHari As Double = 0
        Dim tbsMasuk As Double = 0
        Dim hargaRill As Double = 0
        Dim akkTbsMasuk As Double = 0
        Dim akkHargaRill As Double = 0
        Dim akkHargaHari As Double = 0
        Dim tbsMasukSemalam As Double = 0
        Dim hargaRillSemalam As Double = 0
        Dim spsi As Double = 0
        Dim fee As Double = 0
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator


        If dtpTanggal.Value.ToString("MM") = "01" Then
            bulan = "1"
        ElseIf dtpTanggal.Value.ToString("MM") = "02" Then
            bulan = "2"
        ElseIf dtpTanggal.Value.ToString("MM") = "03" Then
            bulan = "3"
        ElseIf dtpTanggal.Value.ToString("MM") = "04" Then
            bulan = "4"
        ElseIf dtpTanggal.Value.ToString("MM") = "05" Then
            bulan = "5"
        ElseIf dtpTanggal.Value.ToString("MM") = "06" Then
            bulan = "6"
        ElseIf dtpTanggal.Value.ToString("MM") = "07" Then
            bulan = "7"
        ElseIf dtpTanggal.Value.ToString("MM") = "08" Then
            bulan = "8"
        ElseIf dtpTanggal.Value.ToString("MM") = "09" Then
            bulan = "9"
        ElseIf dtpTanggal.Value.ToString("MM") = "10" Then
            bulan = "10"
        ElseIf dtpTanggal.Value.ToString("MM") = "11" Then
            bulan = "11"
        ElseIf dtpTanggal.Value.ToString("MM") = "12" Then
            bulan = "12"
        End If

        'Dim whereWaktu2 As String = ""

        'If clsKoneksi.kotaOn = "2" Then
        '    whereWaktu2 = "and p.tgl2=#" & dtpTanggal.Value.ToString("MM/dd/yyyy") & "#"
        'Else
        '    whereWaktu2 = "and month(p.tgl2)='" & bulan & "'"
        'End If

        'Ambil Data Harga y and (not y libo)
        Dim myQuery5 As String = "select ht.Harga from harga as ht left join kelompok as kt on kt.KodeKelompok=ht.KodeKelompok where ht.kodeKota='" & clsKoneksi.kotaOn & "' and kt.Grade='A' and ht.Tgl=#" & dtpTanggal.Value.ToString("MM/dd/yyyy") & "# order by ht.Tgl DESC"
        Dim tDs3 As DataSet = clsKoneksi.selectCommand(1, myQuery5)
        Dim isiView3(0) As Object

        For i As Integer = 0 To tDs3.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView3.Length - 1
                If tDs3.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView3(j) = ""
                Else
                    isiView3(j) = tDs3.Tables(0).Rows(i).Item(j)
                    End If
            Next
            harga = isiView3(0)
        Next

        If harga = "NaN" Then
            harga = "0"
        Else
            harga = harga.Replace(",", ".")
        End If

        'Pembelian 1
        query = "update ((Pembelian p LEFT JOIN Customer c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga h ON c.KodeKelompok = h.KodeKelompok) left join kelompok as k on k.KodeKelompok=h.KodeKelompok set p.HargaAkhir=" & harga & " where p.kodeKota='" & clsKoneksi.kotaOn & "' and month(p.Tgl2)='" & bulan & "' and c.Grade='A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'Pembelian 2
        query = "update ((Pembelian2 p LEFT JOIN Customer c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga h ON c.KodeKelompok = h.KodeKelompok) left join kelompok as k on k.KodeKelompok=h.KodeKelompok set p.HargaAkhir=" & harga & " where p.kodeKota='" & clsKoneksi.kotaOn & "' and month(p.Tgl2)='" & bulan & "' and c.Grade='A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'Update data spsi dan fee pembelian ke 1
        query = "Update ((pembelian p left join customer c on c.noAccount=p.noAccount) left join Kelompok as kl on kl.KodeKelompok=c.KodeKelompok) set p.FEE=@fee,p.SPSI=@spsi,p.HargaAsli=p.HargaAkhir-@fee-@spsi,p.Total = p.HargaAkhir * p.Netto where c.kodeKelompok=kl.KodeKelompok and c.grade='A' and month(p.tgl2)='" & bulan & "'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Parameters.Add("@fee", OleDbType.Double)
        cmd.Parameters.Add("@spsi", OleDbType.Double)
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.Parameters(0).Value = fee
        cmd.Parameters(1).Value = spsi
        cmd.ExecuteNonQuery()


        'Update data spsi dan fee pembelian ke 2
        query = "Update ((pembelian2 p left join customer c on c.noAccount=p.noAccount) left join Kelompok as kl on kl.KodeKelompok=c.KodeKelompok) set p.FEE=@fee,p.SPSI=@spsi,p.HargaAsli=p.HargaAkhir-@fee-@spsi,p.Total = p.HargaAkhir * p.Netto where c.kodeKelompok=kl.KodeKelompok and c.grade='A' and month(p.tgl2)='" & bulan & "'"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd1.Parameters.Add("@fee", OleDbType.Double)
        cmd1.Parameters.Add("@spsi", OleDbType.Double)
        cmd1.Connection.Close()
        cmd1.Connection.Open()
        cmd1.Parameters(0).Value = fee
        cmd1.Parameters(1).Value = spsi
        cmd1.ExecuteNonQuery()

        'Ambil Data Kelompok
        'Dim myQuery3 As String = "Select kodekelompok from kelompok where grade='A' and kodeKota='" & clsKoneksi.kotaOn & "'"
        'Dim tDs2 As DataSet = clsKoneksi.selectCommand(1, myQuery3)
        'Dim isiView2(0) As Object
        'For i As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
        '    For j As Integer = 0 To isiView2.Length - 1
        '        If tDs2.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
        '            isiView2(j) = ""
        '        Else
        '            isiView2(j) = isiView2(j) & "'" & tDs2.Tables(0).Rows(i).Item(j) & "',"
        '        End If
        '    Next
        '    kodeKelompok = isiView2(0)
        'Next

        'kodeKelompok = kodeKelompok.TrimEnd(CChar(","))

        'Console.WriteLine(kodeKelompok)
        'Return




        'Console.WriteLine(harga2)
        'Return

        'Ambil data FEE dan SPSI
        'Dim myQuery6 As String = "select k.fee,k.spsi from kelompok as k where k.kodeKelompok='" & kodeKelompok & "' and k.kodeKota='" & clsKoneksi.kotaOn & "'"
        'Dim tDs4 As DataSet = clsKoneksi.selectCommand(1, myQuery6)
        'Dim isiView4(1) As Object

        'For i As Integer = 0 To tDs4.Tables(0).Rows.Count - 1
        '    For j As Integer = 0 To isiView4.Length - 1
        '        If tDs4.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
        '            isiView4(j) = ""
        '        Else
        '            isiView4(j) = tDs4.Tables(0).Rows(i).Item(j)
        '        End If
        '    Next
        '    fee = isiView4(0)
        '    spsi = isiView4(1)
        'Next
        'harga = harga2.ToString(Globalization.CultureInfo.CreateSpecificCulture("en-US"))

        'Update Harga Pembelian1
        'query = "Update pembelian p left join customer c on c.noAccount=p.noAccount set p.HargaAkhir=" & harga & " where c.kodeKelompok='" & kodeKelompok & "' and c.grade='A' " & whereWaktu2 & " and p.KodeKota='" & clsKoneksi.kotaOn & "'"
        'cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        'cmd.Connection.Close()
        'cmd.Connection.Open()
        'cmd.ExecuteNonQuery()


        'Dim myQuery1 As String = "Update pembelian p left join customer c on c.noAccount=p.noAccount set "
        'Dim namaKolom1 As String() = {"p.HargaAkhir"}
        'Dim isiKolom1 As Object() = {CDbl(harga)}

        'Dim kondisiWhere As String = " where c.kodeKelompok=@kodeKelompok and c.grade=@grade " & whereWaktu & " and p.KodeKota=@kota"
        'Dim namaKolom2 As String() = {"kodeKelompok", "grade", "bulan", "kota"}
        'Dim isiKolom2 As Object() = {kodeKelompok, "A", IIf(clsKoneksi.kotaOn = "2", dtpTanggal.Value.Date.ToString("MM/dd/yyyy"), bulan), clsKoneksi.kotaOn}
        'clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)

        'Update Harga Pembelian2
        'query = "Update pembelian2 p left join customer c on c.noAccount=p.noAccount set p.HargaAkhir=" & harga & " where c.kodeKelompok='" & kodeKelompok & "' and c.grade='A' " & whereWaktu2 & " and p.KodeKota='" & clsKoneksi.kotaOn & "'"
        'cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        'cmd.Connection.Close()
        'cmd.Connection.Open()
        'cmd.ExecuteNonQuery()

        'Dim myQuery2 As String = "Update pembelian2 p left join customer c on c.noAccount=p.noAccount set "
        'Dim namaKolom3 As String() = {"p.HargaAkhir"}
        'Dim isiKolom3 As Object() = {CDbl(harga)}

        'Dim kondisiWhere1 As String = " where c.kodeKelompok=@kodeKelompok and c.grade=@grade " & whereWaktu & " and p.KodeKota=@kota"
        'Dim namaKolom4 As String() = {"kodeKelompok", "grade", "bulan", "kota"}
        'Dim isiKolom4 As Object() = {kodeKelompok, "A", IIf(clsKoneksi.kotaOn = "2", dtpTanggal.Value.Date.ToString("MM/dd/yyyy"), bulan), clsKoneksi.kotaOn}
        'clsKoneksi.updateCommand(1, myQuery2, namaKolom3, isiKolom3, kondisiWhere1, namaKolom4, isiKolom4, 1)




        '===========================================================================================================================


        'Update akumulasi

        Dim myQuery As String = "SELECT IIF(IsNull(SUM(p.netto*(p.hargaAkhir-p.potongan))),0,SUM(p.netto*(p.hargaAkhir-p.potongan))) as Total,IIF(IsNull(SUM([p.Netto])),0,SUM([p.Netto])) as Netto FROM Pembelian p Left Outer Join Customer c on p.noaccount=c.noaccount "
        myQuery = myQuery & " Where p.Tgl2=#" & dtpTanggal.Value.ToString("MM/dd/yyyy") & "# and p.kodekota='" & clsKoneksi.kotaOn & "'"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        Dim isiView(1) As Object

        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                    End If
            Next
            tbsMasuk = isiView(1)
            hargaRill = isiView(0)
        Next

        akkTbsMasuk = tbsMasuk + tbsMasukSemalam
        akkHargaRill = hargaRill + hargaRillSemalam
        hargaHari = clsKoneksi.Rounding(CDbl(hargaRill) / CDbl(tbsMasuk), 2)
        akkHargaHari = clsKoneksi.Rounding(CDbl(akkHargaRill) / CDbl(akkTbsMasuk), 2)


        If dtpTanggal.Value.ToString("dd") <> "01" Then


            Dim myQuery8 As String = "SELECT AkkTbsMasuk,AkkHargaRill from kalkulasiHargaGradeA "
            myQuery8 = myQuery8 & " Where (tanggal>=#" & dtpTanggal.Value.AddDays(-1).ToString("MM/dd/yyyy") & "#" & " and tanggal<=#" & dtpTanggal.Value.AddDays(-1).ToString("MM/dd/yyyy") & "#) and kodekota='" & clsKoneksi.kotaOn & "'"

            Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, myQuery8)
            Dim isiView1(1) As Object

            For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView1.Length - 1
                    If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView1(j) = ""
                    Else
                        isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                        End If
                Next
                tbsMasukSemalam = isiView1(0)
                hargaRillSemalam = isiView1(1)
            Next

            If Double.IsNaN(hargaHari) Then
                hargaHari = 0
                End If
            If Double.IsNaN(akkHargaHari) Then
                akkHargaHari = 0
                End If

            akkTbsMasuk = tbsMasuk + tbsMasukSemalam
            akkHargaRill = hargaRill + hargaRillSemalam
            hargaHari = clsKoneksi.Rounding(CDbl(hargaRill) / CDbl(tbsMasuk), 2)
            akkHargaHari = clsKoneksi.Rounding(CDbl(akkHargaRill) / CDbl(akkTbsMasuk), 2)

            End If

        Dim myQuery10 As String = "select AkkHargaHari from KalkulasiHargaGradeA where"
        Dim namaKolom As String() = {"Tanggal", "kodeKota"}
        Dim isiKolom As Object() = {dtpTanggal.Value.Date, clsKoneksi.kotaOn}
        myQuery10 = myQuery10 & " Tanggal=@Tanggal and kodeKota=@kodeKota"
        Dim tDs5 As DataSet = clsKoneksi.selectCommand(1, myQuery10, namaKolom, isiKolom, 1)
        If tDs5.Tables(0).Rows.Count > 0 Then

            Dim myQuery11 As String = "Update KalkulasiHargaGradeA set "
            Dim namaKolom10 As String() = {"tbsMasuk", "HargaRill", "AkkTbsMasuk", "AkkHargaRill", "HargaHari", "AkkHargaHari"}
            Dim isiKolom10 As Object() = {clsKoneksi.Rounding(CDbl(tbsMasuk), 0), clsKoneksi.Rounding(CDbl(hargaRill), 0), clsKoneksi.Rounding(CDbl(akkTbsMasuk), 0), clsKoneksi.Rounding(CDbl(akkHargaRill), 0), CDbl(hargaHari), CDbl(akkHargaHari)}

            Dim kondisiWhere4 As String = " where Tanggal=@Tanggal and kodeKota=@kodeKota"
            Dim namaKolom11 As String() = {"Tanggal", "kodeKota"}
            Dim isiKolom11 As Object() = {dtpTanggal.Value.Date, clsKoneksi.kotaOn}
            clsKoneksi.updateCommand(1, myQuery11, namaKolom10, isiKolom10, kondisiWhere4, namaKolom11, isiKolom11, 1)
        Else
            Dim myQuery9 As String = "Insert into KalkulasiHargaGradeA "
            Dim namaKolom9 As String() = {"Tanggal", "tbsMasuk", "HargaRill", "AkkTbsMasuk", "AkkHargaRill", "HargaHari", "AkkHargaHari", "KodeKota"}
            Dim isiKolom9 As Object() = {dtpTanggal.Value.Date, clsKoneksi.Rounding((tbsMasuk), 0), clsKoneksi.Rounding((hargaRill), 0), clsKoneksi.Rounding(CDbl(akkTbsMasuk), 0), clsKoneksi.Rounding(CDbl(akkHargaRill), 0), CDbl(hargaHari), CDbl(akkHargaHari), clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery9, namaKolom9, isiKolom9)
            End If

        tampilJumlahNettodanTotal()

        query = "Update KalkulasiHargaGradeA set HargaRill=@hargaRill, tbsMasuk=@netto where Tanggal=@Tanggal and kodeKota=@kodeKota"
        Dim cmd2 As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd2.Parameters.Add("@hargaRill", OleDbType.Double)
        cmd2.Parameters.Add("@netto", OleDbType.Double)
        cmd2.Parameters.Add("@Tanggal", OleDbType.Date)
        cmd2.Parameters.Add("@kodeKota", OleDbType.VarChar)
        cmd2.Connection.Close()
        cmd2.Connection.Open()

        For Each row As DataGridViewRow In dgvTotalSekarang.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb1").Value)
            If isSelected = True Then
                cmd2.Parameters(0).Value = row.Cells("total").Value.ToString()
                cmd2.Parameters(1).Value = row.Cells("netto").Value.ToString()
                cmd2.Parameters(2).Value = Convert.ToDateTime(row.Cells("tanggal").Value)
                cmd2.Parameters(3).Value = clsKoneksi.kotaOn
                cmd2.ExecuteNonQuery()
                End If
        Next

        tampilAkk()

        query = "Update KalkulasiHargaGradeA set AkkTbsMasuk=@AkkTbsMasuk, akkHargaRill=@akkHargaRill,HargaHari=@HargaHari,AkkHargaHari=@AkkHargaHari where Tanggal=@Tanggal and kodeKota=@kodeKota"
        Dim cmd3 As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd3.Parameters.Add("@AkkTbsMasuk", OleDbType.Double)
        cmd3.Parameters.Add("@akkHargaRill", OleDbType.Double)
        cmd3.Parameters.Add("@HargaHari", OleDbType.Double)
        cmd3.Parameters.Add("@AkkHargaHari", OleDbType.Double)
        cmd3.Parameters.Add("@Tanggal", OleDbType.Date)
        cmd3.Parameters.Add("@kodeKota", OleDbType.VarChar)
        cmd3.Connection.Close()
        cmd3.Connection.Open()

        For Each row As DataGridViewRow In dgvData.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb2").Value)
            If isSelected = True Then
                cmd3.Parameters(0).Value = row.Cells("akkTbsMasuk").Value.ToString()
                cmd3.Parameters(1).Value = row.Cells("akkHargaRill").Value.ToString()
                cmd3.Parameters(2).Value = row.Cells("Harga").Value.ToString()
                cmd3.Parameters(3).Value = row.Cells("AkkHarga").Value.ToString()
                cmd3.Parameters(4).Value = Convert.ToDateTime(row.Cells("Tgl").Value)
                cmd3.Parameters(5).Value = clsKoneksi.kotaOn
                cmd3.ExecuteNonQuery()
                End If
        Next

        MsgBox("Berhasil Update")

    End Sub

    Private Sub dtpTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggal.ValueChanged
        dtpTglAkhir.Value = clsKoneksi.tglAkhirBulan(dtpTanggal.Value.Date)
    End Sub

    Private Sub frmInputHargaGradeA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTglAkhir.Value = clsKoneksi.tglAkhirBulan(dtpTanggal.Value.Date)
    End Sub
End Class