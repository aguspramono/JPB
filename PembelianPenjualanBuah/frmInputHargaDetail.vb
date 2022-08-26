Imports System.Data.OleDb
Public Class frmInputHargaDetail

    Private Sub cboGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrade.SelectedIndexChanged
        If cboGrade.SelectedIndex = 0 Then
            frmInputHargaGradeA.ShowDialog()
        Else
            dtTglGrade.Visible = False
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If cboGrade.SelectedIndex = 0 Then
            MsgBox("Harap Pilih Grade Kembali", vbCritical)
            Return
        End If
        'hargaJam12()
        Dim query As String = ""
        Dim query2 As String = ""
        Dim cmd As OleDbCommand

        'harga 00:00:00
        'Update data pembelian ke 1 
        query = "update (Pembelian p LEFT JOIN Customer c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga h ON c.KodeKelompok = H.KodeKelompok set p.HargaAkhir=h.harga "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and h.Jam=#00:00:00# and p.kodeKota='" & clsKoneksi.kotaOn & "' and h.kodeKota='" & clsKoneksi.kotaOn & "' and IIF(h.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) and (p.manualedit is null or p.manualedit='') and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'Update data pembelian ke 2
        query = "update (Pembelian2 p LEFT JOIN Customer c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga h ON c.KodeKelompok = H.KodeKelompok set p.HargaAkhir=h.harga "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and h.Jam=#00:00:00# and p.kodeKota='" & clsKoneksi.kotaOn & "' and h.kodeKota='" & clsKoneksi.kotaOn & "' and IIF(h.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) and  (p.manualedit is null or p.manualedit='') and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'harga 12:00:00
        'Update data pembelian ke 1
        query = "Update (SELECT C.KodeKelompok, P.NoTicket,P.NoAccount, P.Tgl2, format(P.Jam1,""Long Time"") as jamMasuk,IIF(P.Jam1>=#12:00:00#,#12:00:00#,#00:00:00#) as JamHarga,P.hargaAkhir FROM Pembelian P LEFT JOIN Customer C ON P.NoAccount = C.NoAccount WHERE P.KodeKota='" & clsKoneksi.kotaOn & "' and (p.manualedit is null or p.manualedit='') and P.Tgl1=P.Tgl2 and P.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and P.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) as TB1 LEFT JOIN Harga H on TB1.kodeKelompok=H.kodeKelompok set TB1.HargaAkhir=H.Harga "
        query = query & "where (TB1.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and TB1.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and TB1.Tgl2=H.Tgl and TB1.JamHarga=H.Jam and TB1.JamHarga>=#12:00:00# and h.kodeKota='" & clsKoneksi.kotaOn & "'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'Update data pembelian ke 2
        query = "Update (SELECT C.KodeKelompok, P.NoTicket,P.NoAccount, P.Tgl2, format(P.Jam1,""Long Time"") as jamMasuk,IIF(P.Jam1>=#12:00:00#,#12:00:00#,#00:00:00#) as JamHarga,P.hargaAkhir FROM Pembelian2 P LEFT JOIN Customer C ON P.NoAccount = C.NoAccount WHERE P.KodeKota='" & clsKoneksi.kotaOn & "' and (p.manualedit is null or p.manualedit='') and P.Tgl1=P.Tgl2 and  P.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and P.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) as TB1 LEFT JOIN Harga H on TB1.kodeKelompok=H.kodeKelompok set TB1.HargaAkhir=H.Harga "
        query = query & "where (TB1.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and TB1.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and TB1.Tgl2=H.Tgl and TB1.JamHarga=H.Jam and TB1.JamHarga>=#12:00:00# and h.kodeKota='" & clsKoneksi.kotaOn & "'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()


        'Update Plat Pembelian1 
        query = "update ((SELECT c.KodeKelompok, p.manualedit,P.NoTicket,P.NoAccount, P.Tgl2,P.Tgl1, format(P.Jam1,""Long Time"") as jamMasuk,IIF(P.Jam1>=#12:00:00#,#12:00:00#,#00:00:00#) as JamHarga,P.hargaAkhir,p.Vehicle FROM Pembelian P "
        query = query & "LEFT JOIN Customer C ON P.NoAccount = C.NoAccount WHERE P.KodeKota='" & clsKoneksi.kotaOn & "' and (p.manualedit is null or p.manualedit='') and P.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and P.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) as TB1 "
        query = query & "inner join Kelompokplat as kpt on kpt.plat=TB1.Vehicle) inner join harga as h on kpt.KodeKelompok=h.KodeKelompok set TB1.hargaAkhir=h.Harga where IIF(h.kodeKota='2',TB1.Tgl1=h.Tgl,TB1.Tgl2=h.Tgl) AND (kpt.kodeKelompok<>TB1.kodeKelompok OR TB1.kodeKelompok is null OR TB1.kodeKelompok='') "
        query = query & "AND (kpt.master is null or kpt.master='') AND (TB1.manualedit is null or TB1.manualedit='')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        query = "update ((SELECT c.KodeKelompok, p.manualedit,P.NoTicket,P.NoAccount, P.Tgl2,P.Tgl1, format(P.Jam1,""Long Time"") as jamMasuk,IIF(P.Jam1>=#12:00:00#,#12:00:00#,#00:00:00#) as JamHarga,P.hargaAkhir,p.Vehicle FROM Pembelian P "
        query = query & "LEFT JOIN Customer C ON P.NoAccount = C.NoAccount WHERE P.KodeKota='" & clsKoneksi.kotaOn & "' and (p.manualedit is null or p.manualedit='') and P.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and P.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) as TB1 "
        query = query & "inner join Kelompokplat as kpt on kpt.plat=TB1.Vehicle) inner join harga as h on kpt.KodeKelompok=h.KodeKelompok set TB1.hargaAkhir=h.Harga where IIF(h.kodeKota='2',TB1.Tgl1=h.Tgl,TB1.Tgl2=h.Tgl) AND (TB1.manualedit is null or TB1.manualedit='')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()


        'Update Plat Pembelian2
        query = "update ((SELECT c.KodeKelompok, p.manualedit,P.NoTicket,P.NoAccount, P.Tgl2,P.Tgl1, format(P.Jam1,""Long Time"") as jamMasuk,IIF(P.Jam1>=#12:00:00#,#12:00:00#,#00:00:00#) as JamHarga,P.hargaAkhir,p.Vehicle FROM Pembelian2 P "
        query = query & "LEFT JOIN Customer C ON P.NoAccount = C.NoAccount WHERE P.KodeKota='" & clsKoneksi.kotaOn & "' and (p.manualedit is null or p.manualedit='') and P.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and P.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) as TB1 "
        query = query & "inner join Kelompokplat as kpt on kpt.plat=TB1.Vehicle) inner join harga as h on kpt.KodeKelompok=h.KodeKelompok set TB1.hargaAkhir=h.Harga where IIF(h.kodeKota='2',TB1.Tgl1=h.Tgl,TB1.Tgl2=h.Tgl) AND (kpt.kodeKelompok<>TB1.kodeKelompok OR TB1.kodeKelompok is null OR TB1.kodeKelompok='') "
        query = query & "AND (kpt.master is null or kpt.master='') AND (TB1.manualedit is null or TB1.manualedit='')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        query = "update ((SELECT c.KodeKelompok, p.manualedit,P.NoTicket,P.NoAccount, P.Tgl2,P.Tgl1, format(P.Jam1,""Long Time"") as jamMasuk,IIF(P.Jam1>=#12:00:00#,#12:00:00#,#00:00:00#) as JamHarga,P.hargaAkhir,p.Vehicle FROM Pembelian2 P "
        query = query & "LEFT JOIN Customer C ON P.NoAccount = C.NoAccount WHERE P.KodeKota='" & clsKoneksi.kotaOn & "' and (p.manualedit is null or p.manualedit='') and P.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and P.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) as TB1 "
        query = query & "inner join Kelompokplat as kpt on kpt.plat=TB1.Vehicle) inner join harga as h on kpt.KodeKelompok=h.KodeKelompok set TB1.hargaAkhir=h.Harga where IIF(h.kodeKota='2',TB1.Tgl1=h.Tgl,TB1.Tgl2=h.Tgl) AND (TB1.manualedit is null or TB1.manualedit='')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        '-------

        'Update spsi dan fee data pembelian ke 1
        query = "update ((Pembelian AS p LEFT JOIN Customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga AS h ON c.KodeKelompok = h.KodeKelompok) LEFT JOIN Kelompok k ON c.KodeKelompok = k.KodeKelompok set p.FEE=k.Fee,p.SPSI=k.SPSI,p.HargaAsli=p.HargaAkhir-k.Fee-K.SPSI,p.Total = p.HargaAkhir * p.Netto "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and p.kodeKota='" & clsKoneksi.kotaOn & "' and IIF(p.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) and (p.manualedit is null or p.manualedit='') and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'Update spsi dan fee data pembelian ke 2
        query = "update ((Pembelian2 AS p LEFT JOIN Customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga AS h ON c.KodeKelompok = h.KodeKelompok) LEFT JOIN Kelompok k ON c.KodeKelompok = k.KodeKelompok set p.FEE=k.Fee,p.SPSI=k.SPSI,p.HargaAsli=p.HargaAkhir-k.Fee-K.SPSI,p.Total = p.HargaAkhir * p.Netto "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and p.kodeKota='" & clsKoneksi.kotaOn & "' and IIF(p.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) and  (p.manualedit is null or p.manualedit='') and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'update fee spsi  plat pembelian 1
        query = "update (Pembelian AS p LEFT JOIN (kelompokplat AS kp LEFT JOIN harga AS h ON kp.kodeKelompok = h.kodeKelompok) ON p.Vehicle = kp.plat) LEFT JOIN Kelompok k ON kp.kodeKelompok = k.KodeKelompok set p.FEE=k.Fee, p.SPSI=k.SPSI, p.HargaAsli=p.HargaAkhir-k.Fee-k.SPSI,p.Total = p.HargaAkhir * p.Netto "
        query = query & "WHERE ((h.Tgl>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# And h.Tgl<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) AND h.kodeKota='" & clsKoneksi.kotaOn & "' and IIF(h.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) AND  (p.manualedit is null or p.manualedit=''))"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'update fee spsi  plat pembelian 2
        query = "update (Pembelian2 AS p LEFT JOIN (kelompokplat AS kp LEFT JOIN harga AS h ON kp.kodeKelompok = h.kodeKelompok) ON p.Vehicle = kp.plat) LEFT JOIN Kelompok k ON kp.kodeKelompok = k.KodeKelompok set p.FEE=k.Fee, p.SPSI=k.SPSI, p.HargaAsli=p.HargaAkhir-k.Fee-k.SPSI,p.Total = p.HargaAkhir * p.Netto "
        query = query & "WHERE ((h.Tgl>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# And h.Tgl<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) AND h.kodeKota='" & clsKoneksi.kotaOn & "' and IIF(h.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) AND  (p.manualedit is null or p.manualedit=''))"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        '00:00:00
        'buah berondolan pembelian 1
        query = "update ((Pembelian as p inner join customer as c on(c.NoAccount=p.NoAccount))  inner join harga as h on(h.KodeKelompok=c.KodeKelompok)) inner join hargaBrondolan as hb on(hb.NoAccount=p.NoAccount) set p.HargaAkhir=h.harga+iif(isnull(hb.Harga),0,hb.Harga),p.Total=p.HargaAkhir*p.Netto,p.ManualEdit='1',p.Keterangan='Buah berondolan' "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and h.Jam=#00:00:00# and p.JumlahJanjang='0' and p.KodeKota='" & clsKoneksi.kotaOn & "' and IIF(p.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) and IIF(p.kodeKota='2',p.Vehicle=hb.PlatBrond,p.Vehicle<>'')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'buah berondolan pembelian 2
        query = "update ((Pembelian2 as p inner join customer as c on(c.NoAccount=p.NoAccount))  inner join harga as h on(h.KodeKelompok=c.KodeKelompok)) inner join hargaBrondolan as hb on(hb.NoAccount=p.NoAccount) set p.HargaAkhir=h.harga+iif(isnull(hb.Harga),0,hb.Harga),p.Total=p.HargaAkhir*p.Netto,p.ManualEdit='1',p.Keterangan='Buah berondolan' "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and h.Jam=#00:00:00# and p.JumlahJanjang='0' and p.KodeKota='" & clsKoneksi.kotaOn & "' and IIF(p.kodeKota='2',p.Tgl1=h.Tgl,p.Tgl2=h.Tgl) and IIF(p.kodeKota='2',p.Vehicle=hb.PlatBrond,p.Vehicle<>'')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        '12:00:00
        'buah berondolan pembelian 1
        query = "update ((Pembelian as p inner join customer as c on(c.NoAccount=p.NoAccount))  inner join harga as h on(h.KodeKelompok=c.KodeKelompok)) inner join hargaBrondolan as hb on(hb.NoAccount=p.NoAccount) set p.HargaAkhir=h.harga+iif(isnull(hb.Harga),0,hb.Harga),p.Total=p.HargaAkhir*p.Netto,p.ManualEdit='1',p.Keterangan='Buah berondolan' "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and h.Tgl=p.Tgl2 and p.Tgl1=p.Tgl2 and p.Jam1>=#12:00:00# and p.JumlahJanjang='0' and p.KodeKota='" & clsKoneksi.kotaOn & "' and IIF(p.kodeKota='2',p.Vehicle=hb.PlatBrond,p.Vehicle<>'')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'buah berondolan pembelian 2
        query = "update ((Pembelian2 as p inner join customer as c on(c.NoAccount=p.NoAccount))  inner join harga as h on(h.KodeKelompok=c.KodeKelompok)) inner join hargaBrondolan as hb on(hb.NoAccount=p.NoAccount) set p.HargaAkhir=h.harga+iif(isnull(hb.Harga),0,hb.Harga),p.Total=p.HargaAkhir*p.Netto,p.ManualEdit='1',p.Keterangan='Buah berondolan' "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and h.Tgl=p.Tgl2 and p.Tgl1=p.Tgl2 and p.Jam1>=#12:00:00# and p.JumlahJanjang='0' and p.KodeKota='" & clsKoneksi.kotaOn & "' and IIF(p.kodeKota='2',p.Vehicle=hb.PlatBrond,p.Vehicle<>'')"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'Update tambahan plat pembelian 1
        query = "update (((Pembelian AS p LEFT JOIN Customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga AS h ON c.KodeKelompok = h.KodeKelompok) LEFT JOIN Kelompok k ON c.KodeKelompok = k.KodeKelompok) LEFT JOIN hargaTambahanPlat as htp on htp.KodePlat=p.vehicle set p.HargaAkhir = p.HargaAkhir +  IIF(htp.hargaTambahan is null,0,htp.hargaTambahan),p.Total=p.HargaAkhir*p.Netto "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and p.Tgl2=h.Tgl and p.kodeKota='" & clsKoneksi.kotaOn & "' and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        'Update tambahan plat pembelian 2
        query = "update (((Pembelian2 AS p LEFT JOIN Customer AS c ON p.NoAccount = c.NoAccount) LEFT JOIN Harga AS h ON c.KodeKelompok = h.KodeKelompok) LEFT JOIN Kelompok k ON c.KodeKelompok = k.KodeKelompok) LEFT JOIN hargaTambahanPlat as htp on htp.KodePlat=p.vehicle set p.HargaAkhir = p.HargaAkhir +  IIF(htp.hargaTambahan is null,0,htp.hargaTambahan),p.Total=p.HargaAkhir*p.Netto "
        query = query & "where (p.Tgl2>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "# and p.Tgl2<=#" & Format(dtTanggalAkhir.Value.Date, "MM/dd/yyyy") & "#) and p.Tgl2=h.Tgl and p.kodeKota='" & clsKoneksi.kotaOn & "' and c.Grade<>'A'"
        cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()

        dgvHarga2.Rows.Clear()
        frmInputHarga.loadCari()
        MessageBox.Show("Update Selesai", "warning")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class