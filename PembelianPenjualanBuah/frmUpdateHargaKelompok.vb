Imports System.Data.OleDb
Public Class frmUpdateHargaKelompok

    Sub tampilKelompok()
        Dim myQuery2 As String = ""
        myQuery2 = "select kodeKelompok from kelompok where kodeKota='" & clsKoneksi.kotaOn & "' and IIF(kodeKota='2',Grade<>'Z',Grade<>'A') and kodeKelompok like '%" & txtCari.Text & "%' and kodeKelompok<>'hargaPapan'"
        Dim tDs As DataSet
        dgvKelompok.Rows.Clear()
        tDs = clsKoneksi.selectCommand(1, myQuery2)
        Dim isiView1(0) As Object
        'isiView(0) = ""
        isiView1(0) = "hargaPapan"
        dgvKelompok.Rows.Add(isiView1)
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvKelompok.Rows.Add(isiView1)
        Next

        For i As Integer = 0 To tDs.Tables(0).Rows.Count
            dgvKelompok.Rows(i).Cells(1).Value = True
        Next
        ckPilihSemua.Checked = True
    End Sub

    Sub tampilHargaData()
        Dim query As String = ""
        Dim kodeKelompok As String = String.Empty
        Dim kodeKelompok2 As String = String.Empty
        For Each row As DataGridViewRow In dgvKelompok.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CkPilih").Value)
            If isSelected = True Then
                kodeKelompok &= row.Cells("kdKelompok").Value.ToString() & ","
                kodeKelompok2 = kodeKelompok2 & "'" & row.Cells("kdKelompok").Value.ToString() & "',"
            End If
        Next

        If kodeKelompok2 = "" Then
            MsgBox("Karyawan belum dipilih")
            Return
        End If
        kodeKelompok = kodeKelompok.Remove(kodeKelompok.Length - 1, 1)
        kodeKelompok2 = kodeKelompok2.Remove(kodeKelompok2.Length - 1, 1)

        query = "select KodeKelompok,TglT,JamT,hargaT,PlatT,PerubahanT,KodeKotaT,autoUpT from(SELECT TOP 1 H.KodeKelompok,H.Tgl as TglT,H.Jam as JamT,H.harga as hargaT,H.Plat as PlatT,0 as PerubahanT,H.KodeKota as KodeKotaT,H.autoUp as autoUpT  FROM Harga H "
        query = query & "Where (H.Plat Is Null or H.Plat='') and H.kodeKota='" & clsKoneksi.kotaOn & "' and H.Tgl<=#" & dtpHelp2.Value.ToString("MM/dd/yyyy") & "# and H.kodeKelompok in(" & kodeKelompok2 & ") and H.kodeKelompok<>'hargaPapan' Order By H.Tgl desc) as tb1 order by tb1.KodeKelompok asc"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, query)
        dgvHarga.Rows.Clear()
        Dim isiView(7) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvHarga.Rows.Add(isiView)
        Next

        For intI = dgvHarga.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If dgvHarga.Rows(intI).Cells(0).Value = dgvHarga.Rows(intJ).Cells(0).Value Then
                    dgvHarga.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub frmUpdateHargaKelompok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilKelompok()
    End Sub
    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga.Click
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        tampilHargaData()

        Dim kodeKelompok As String = String.Empty
        Dim kodeKelompok2 As String = String.Empty
        For Each row As DataGridViewRow In dgvKelompok.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CkPilih").Value)
            If isSelected = True Then
                kodeKelompok &= row.Cells("kdKelompok").Value.ToString() & ","
                kodeKelompok2 = kodeKelompok2 & "'" & row.Cells("kdKelompok").Value.ToString() & "',"
            End If
        Next

        If kodeKelompok2 = "" Then
            MsgBox("Karyawan belum dipilih")
            Return
        End If
        kodeKelompok = kodeKelompok.Remove(kodeKelompok.Length - 1, 1)
        kodeKelompok2 = kodeKelompok2.Remove(kodeKelompok2.Length - 1, 1)

        Dim query As String = "delete from harga where Tgl=#" & dtpHelp2.Value.Date.ToString("MM/dd/yyyy") & "# and Jam=#" & dtpJam.Value.ToString("HH:mm:ss") & "# and KodeKota='" & clsKoneksi.kotaOn & "' and KodeKelompok in(" & kodeKelompok2 & ")"
        Dim cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()

        'Dim myQuery10 As String = "delete from harga where tgl=@tgl and Jam=@jam and KodeKota=@kodeKota and KodeKelompok in(@kelompok)"
        'Dim namaKolom10 As String() = {"tgl", "Jam", "kodeKota", "kelompok"}
        'Dim isiKolom10 As Object() = {dtpHelp2.Value.Date.ToString("MM/dd/yyyy"), dtpJam.Value.ToString("HH:mm:ss"), clsKoneksi.kotaOn, kodeKelompok2}
        'clsKoneksi.deleteCommand(1, myQuery10, namaKolom10, isiKolom10, 1)

        Dim myQuery2 As String = "INSERT INTO Harga "
        Dim namaKolom2 As String() = {"KodeKelompok", "Tgl", "Jam", "Harga", "Plat", "Perubahan", "KodeKota", "autoUP"}

        Dim isiKolom2(8) As Object
        ReDim isiKolom2((namaKolom2.Length * dgvHarga.Rows.Count) - 1)
        Dim cntT As Integer = 0
        If dgvHarga.Rows.Count = 1 Then
            For i = 0 To dgvHarga.Rows.Count - 1
                isiKolom2(cntT + 0) = dgvHarga.Rows(i).Cells(0).Value
                isiKolom2(cntT + 1) = dtpHelp2.Value.Date.ToString("MM/dd/yyyy")
                isiKolom2(cntT + 2) = dtpJam.Value.ToString("HH:mm:ss")
                isiKolom2(cntT + 3) = CDbl(dgvHarga.Rows(i).Cells(3).Value)
                isiKolom2(cntT + 4) = dgvHarga.Rows(i).Cells(4).Value
                isiKolom2(cntT + 5) = CDbl(dgvHarga.Rows(i).Cells(5).Value)
                isiKolom2(cntT + 6) = dgvHarga.Rows(i).Cells(6).Value
                isiKolom2(cntT + 7) = CDec(dgvHarga.Rows(i).Cells(7).Value)
                cntT += 8

            Next
            clsKoneksi.insertCommand(1, myQuery2, namaKolom2, isiKolom2)
        Else
            For i = 0 To dgvHarga.Rows.Count - 1
                isiKolom2(cntT + 0) = "'" & dgvHarga.Rows(i).Cells(0).Value & "'"
                isiKolom2(cntT + 1) = "#" & dtpHelp2.Value.Date.ToString("MM/dd/yyyy") & "#"
                isiKolom2(cntT + 2) = "#" & dtpJam.Value.ToString("HH:mm:ss") & "#"

                If decimalSeparator = "," Then
                    isiKolom2(cntT + 3) = CDec(dgvHarga.Rows(i).Cells(3).Value).ToString.Replace(",", ".")
                Else
                    isiKolom2(cntT + 3) = CDbl(dgvHarga.Rows(i).Cells(3).Value)
                End If

                isiKolom2(cntT + 4) = "'" & dgvHarga.Rows(i).Cells(4).Value & "'"

                If decimalSeparator = "," Then
                    isiKolom2(cntT + 5) = CDec(dgvHarga.Rows(i).Cells(5).Value).ToString.Replace(",", ".")
                Else
                    isiKolom2(cntT + 5) = CDbl(dgvHarga.Rows(i).Cells(5).Value)
                End If

                isiKolom2(cntT + 6) = "'" & dgvHarga.Rows(i).Cells(6).Value & "'"

                If decimalSeparator = "," Then
                    isiKolom2(cntT + 7) = CDec(dgvHarga.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                Else
                    isiKolom2(cntT + 7) = CDec(dgvHarga.Rows(i).Cells(7).Value)
                End If

                cntT += 8
            Next
            clsKoneksi.insertCommand2(1, myQuery2, namaKolom2, isiKolom2)
        End If

        dgvHarga.Rows.Clear()

        Dim tanggalAkhitHP As Date
        Dim myQuery5 As String = "select kodeKelompok from harga where"
        Dim namaKolom As String() = {"kodeKelompok", "kodeKota"}
        Dim isiKolom As Object() = {dgvKelompok.Rows(0).Cells(0).Value, clsKoneksi.kotaOn}
        myQuery5 = myQuery5 & " kodeKelompok=@kodeKelompok and kodeKota=@kodeKota"
        Dim tDs5 As DataSet = clsKoneksi.selectCommand(1, myQuery5, namaKolom, isiKolom, 1)
        If tDs5.Tables(0).Rows.Count > 0 Then

            Dim myQuery3 As String = "SELECT max(H.Tgl) FROM Harga H Where (H.Plat Is Null or H.Plat='') and H.KodeKota='" & clsKoneksi.kotaOn & "' and H.kodeKelompok='" & dgvKelompok.Rows(0).Cells(0).Value & "'"
            Dim tDs3 As DataSet
            dgvHarga.Rows.Clear()
            tDs3 = clsKoneksi.selectCommand(1, myQuery3)
            Dim isiView3(0) As Object
            'isiView(0) = ""
            For i As Integer = 0 To tDs3.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView3.Length - 1
                    If tDs3.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView3(j) = ""
                    Else
                        isiView3(j) = tDs3.Tables(0).Rows(i).Item(j)
                    End If
                Next
                tanggalAkhitHP = isiView3(0)
            Next


            Dim myQuery4 As String = "SELECT top 1 H.kodeKelompok, H.Tgl, H.Jam, H.Harga AS harga,H.Plat,0 as perubahan, H.kodeKota, H.autoUp FROM Harga H Where (H.Plat Is Null or H.Plat='') and H.KodeKota='" & clsKoneksi.kotaOn & "' and H.kodeKelompok='" & dgvKelompok.Rows(0).Cells(0).Value & "' and datevalue(H.tgl)>=#" & tanggalAkhitHP.ToString("MM/dd/yyyy") & "#"
            Dim tDs4 As DataSet
            dgvHarga.Rows.Clear()
            tDs4 = clsKoneksi.selectCommand(1, myQuery4)
            Dim isiView4(7) As Object
            'isiView(0) = ""
            For i As Integer = 0 To tDs4.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView4.Length - 1
                    If tDs4.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView4(j) = ""
                    Else
                        isiView4(j) = tDs4.Tables(0).Rows(i).Item(j)
                    End If
                Next
                dgvHarga.Rows.Add(isiView4)
            Next

            Dim myQuery20 As String = "INSERT INTO Harga "
            Dim namaKolom20 As String() = {"KodeKelompok", "Tgl", "Jam", "Harga", "Plat", "Perubahan", "KodeKota", "autoUP"}

            Dim isiKolom20(8) As Object
            ReDim isiKolom20((namaKolom20.Length * dgvHarga.Rows.Count) - 1)
            Dim cntA As Integer = 0
            If dgvHarga.Rows.Count = 1 Then
                For i = 0 To dgvHarga.Rows.Count - 1
                    isiKolom20(cntA + 0) = dgvHarga.Rows(i).Cells(0).Value
                    isiKolom20(cntA + 1) = dtpHelp2.Value.Date
                    isiKolom20(cntA + 2) = dtpJam.Value.ToString("HH:mm:ss")
                    isiKolom20(cntA + 3) = CDbl(dgvHarga.Rows(i).Cells(3).Value)
                    isiKolom20(cntA + 4) = dgvHarga.Rows(i).Cells(4).Value
                    isiKolom20(cntA + 5) = CDbl(dgvHarga.Rows(i).Cells(5).Value)
                    isiKolom20(cntA + 6) = dgvHarga.Rows(i).Cells(6).Value
                    isiKolom20(cntA + 7) = CDec(dgvHarga.Rows(i).Cells(7).Value)
                    cntA += 8

                Next
                clsKoneksi.insertCommand(1, myQuery20, namaKolom20, isiKolom20)
            Else
                For i = 0 To dgvHarga.Rows.Count - 1
                    isiKolom20(cntA + 0) = "'" & dgvHarga.Rows(i).Cells(0).Value & "'"
                    isiKolom20(cntA + 1) = "#" & dtpHelp2.Value.Date & "#"
                    isiKolom20(cntA + 2) = "#" & dtpJam.Value.ToString("HH:mm:ss") & "#"
                    If decimalSeparator = "," Then
                        isiKolom20(cntA + 3) = CDec(dgvHarga.Rows(i).Cells(3).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom20(cntA + 3) = CDbl(dgvHarga.Rows(i).Cells(3).Value)
                    End If

                    isiKolom20(cntA + 4) = "'" & dgvHarga.Rows(i).Cells(4).Value & "'"

                    If decimalSeparator = "," Then
                        isiKolom20(cntA + 5) = CDec(dgvHarga.Rows(i).Cells(5).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom20(cntA + 5) = CDbl(dgvHarga.Rows(i).Cells(5).Value)
                    End If

                    isiKolom20(cntA + 6) = "'" & dgvHarga.Rows(i).Cells(6).Value & "'"

                    If decimalSeparator = "," Then
                        isiKolom20(cntA + 7) = CDec(dgvHarga.Rows(i).Cells(7).Value).ToString.Replace(",", ".")
                    Else
                        isiKolom20(cntA + 7) = CDec(dgvHarga.Rows(i).Cells(7).Value)
                    End If
                    cntA += 8
                Next
                clsKoneksi.insertCommand2(1, myQuery20, namaKolom20, isiKolom20)
            End If

        Else
            Dim myQuery6 As String = "INSERT INTO harga "
            Dim namaKolom6 As String() = {"KodeKelompok", "[Tgl]", "[Jam]", "Harga", "Perubahan", "KodeKota", "autoUp"}
            Dim isiKolom6 As Object() = {dgvKelompok.Rows(0).Cells(0).Value, dtpHelp2.Value.Date, dtpJam.Value.ToString("HH:mm:ss"), "0", "0", clsKoneksi.kotaOn, "0"}
            clsKoneksi.insertCommand(1, myQuery6, namaKolom6, isiKolom6)
        End If
        MsgBox("Berhasil Update")
        dgvHarga.Rows.Clear()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        tampilKelompok()
    End Sub

    Private Sub ckPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles ckPilihSemua.CheckedChanged
        If ckPilihSemua.Checked = True Then
            For i As Integer = 0 To dgvKelompok.Rows.Count() - 1
                dgvKelompok.Rows(i).Cells(1).Value = True
            Next
        Else
            For i As Integer = 0 To dgvKelompok.Rows.Count() - 1
                dgvKelompok.Rows(i).Cells(1).Value = False
            Next
        End If
    End Sub

End Class