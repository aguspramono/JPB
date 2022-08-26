Imports System.Data.OleDb

Public Class frmUpdateHargaPlat
    Sub tampilKelompok()
        Dim myQuery2 As String = "select kodeKelompok,Plat from Plat where kodeKota='" & clsKoneksi.kotaOn & "' and kodeKelompok like '%" & txtCari.Text & "%'"
        Dim tDs As DataSet
        dgvViewPlat.Rows.Clear()
        tDs = clsKoneksi.selectCommand(1, myQuery2)
        Dim isiView1(1) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvViewPlat.Rows.Add(isiView1)
        Next
    End Sub

    Private Sub frmUpdateHargaPlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilKelompok()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim kodeKelompok As String = String.Empty
        Dim kodeKelompok2 As String = String.Empty
        Dim Plat As String = String.Empty
        Dim Plat2 As String = String.Empty
        For Each row As DataGridViewRow In dgvViewPlat.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb1").Value)
            If isSelected = True Then
                kodeKelompok &= row.Cells("kdKelompok").Value.ToString() & ","
                Plat &= row.Cells("Plat").Value.ToString() & ","
                kodeKelompok2 = kodeKelompok2 & "'" & row.Cells("kdKelompok").Value.ToString() & "',"
                Plat2 = Plat2 & "'" & row.Cells("Plat").Value.ToString() & "',"
            End If
        Next
        If kodeKelompok2 = "" Then
            MsgBox("Karyawan belum dipilih")
            Return
        End If
        kodeKelompok = kodeKelompok.Remove(kodeKelompok.Length - 1, 1)
        kodeKelompok2 = kodeKelompok2.Remove(kodeKelompok2.Length - 1, 1)
        Plat = Plat.Remove(Plat.Length - 1, 1)
        Plat2 = Plat2.Remove(Plat2.Length - 1, 1)


        Dim myQuery As String = "SELECT H.kodeKelompok,H.Plat, H.Tgl, H.Jam, H.Harga AS harga, H.Perubahan, H.kodeKota, H.autoUp FROM Harga AS H INNER JOIN (SELECT kodeKelompok,MAX(tgl) AS tglT FROM Harga where Plat<>'' GROUP BY kodeKelompok)  AS [max] ON (H.tgl=Max.tglT) AND (H.kodeKelompok = max.kodeKelompok)  where H.Plat<>'' and H.kodeKelompok in(" & kodeKelompok2 & ") and H.kodeKelompok not in(select KodeKelompok from harga where datevalue(tgl)=#" & dtpHelp2.Value.ToString("MM/dd/yyyy") & "# and timevalue(jam) =#" & dtpJam.Value.ToString("HH:mm:ss") & "# and kodeKota='" & clsKoneksi.kotaOn & "') ORDER BY H.KodeKelompok, H.tgl DESC,H.jam DESC"

        Dim tDs As DataSet
        DgvData.Rows.Clear()
        tDs = clsKoneksi.selectCommand(1, myQuery)
        Dim isiView1(7) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            DgvData.Rows.Add(isiView1)
            DgvData.Rows.Add(isiView1)
            DgvData.Rows(i).Cells(3).Value = dtpJam.Value.ToString("HH:mm:ss")
        Next

        Dim harga As Double
        Dim perubahan As Double
        Dim autoUp As Double

        Dim ts As New TimeSpan(dtpJam.Value.Ticks)

        Dim myQuery2 As String = "Select kodeKelompok,Plat from Plat where kodeKelompok in(" & kodeKelompok2 & ") and Plat in (" & Plat2 & ") and kodeKelompok not in(select kodeKelompok from harga where kodeKelompok in(" & kodeKelompok2 & ") and datevalue(Tgl)=#" & dtpHelp2.Value.ToString("MM/dd/yyyy") & "# and timevalue(Jam)=#" & dtpJam.Value.ToString("HH:mm:ss") & "# and Plat<>'')"
        Dim tDs2 As DataSet
        tDs2 = clsKoneksi.selectCommand(1, myQuery2)
        Dim isiView2(1) As Object
        'isiView(0) = ""
        For a As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
            For b As Integer = 0 To isiView2.Length - 1
                If tDs2.Tables(0).Rows(a).Item(b) Is DBNull.Value Then
                    isiView2(b) = ""
                Else
                    isiView2(b) = tDs2.Tables(0).Rows(a).Item(b)
                End If
            Next
            DgvData.Rows.Add(isiView2)
        Next

        For k As Integer = 0 To DgvData.Rows.Count() - 1
            If DgvData.Rows(k).Cells(2).Value Is Nothing Then
                DgvData.Rows(k).Cells(2).Value = dtpHelp2.Value.Date
            End If

            If DgvData.Rows(k).Cells(3).Value Is Nothing Then
                DgvData.Rows(k).Cells(3).Value = dtpJam.Value.ToString("HH:mm:ss")
            End If

            If DgvData.Rows(k).Cells(4).Value Is Nothing Then
                harga = 0
                DgvData.Rows(k).Cells(4).Value = harga
            End If

            If DgvData.Rows(k).Cells(5).Value Is Nothing Then
                perubahan = 0
                DgvData.Rows(k).Cells(5).Value = perubahan
            End If

            If DgvData.Rows(k).Cells(6).Value Is Nothing Then
                DgvData.Rows(k).Cells(6).Value = clsKoneksi.kotaOn
            End If

            If DgvData.Rows(k).Cells(7).Value Is Nothing Then
                autoUp = 0
                DgvData.Rows(k).Cells(7).Value = autoUp
            End If
        Next

        For intI = DgvData.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If DgvData.Rows(intI).Cells(0).Value = DgvData.Rows(intJ).Cells(0).Value And DgvData.Rows(intI).Cells(1).Value = DgvData.Rows(intJ).Cells(1).Value Then
                    DgvData.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next


        Dim myQuery67 As String = "INSERT INTO harga "
        Dim namaKolom67 As String() = {"KodeKelompok", "[Tgl]", "[Jam]", "Harga", "Plat", "Perubahan", "KodeKota", "autoUp"}


        'Dim query As String = "insert into harga(KodeKelompok,[Tgl],[Jam],Harga,Plat,Perubahan,KodeKota,autoUp)values(@KodeKelompok,@Tgl,@Jam,@Harga,@Plat,@Perubahan,@KodeKota,@autoUp)"
        'Dim cmd As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        'cmd.Parameters.Add("@KodeKelompok", OleDbType.VarChar)
        'cmd.Parameters.Add("@Tgl", OleDbType.Date)
        'cmd.Parameters.Add("@Jam", OleDbType.DBTimeStamp)
        'cmd.Parameters.Add("@Harga", OleDbType.Decimal)
        'cmd.Parameters.Add("@Plat", OleDbType.VarChar)
        'cmd.Parameters.Add("@Perubahan", OleDbType.Decimal)
        'cmd.Parameters.Add("@KodeKota", OleDbType.VarChar)
        'cmd.Parameters.Add("@autoUp", OleDbType.VarChar)
        'cmd.Connection.Close()
        'cmd.Connection.Open()
        For i As Integer = 0 To DgvData.Rows.Count - 1
            Dim isiKolom67 As Object() = {DgvData.Rows(i).Cells(0).Value, dtpHelp2.Value.Date, dtpJam.Value.ToString("HH:mm:ss"), DgvData.Rows(i).Cells(4).Value, DgvData.Rows(i).Cells(1).Value, DgvData.Rows(i).Cells(5).Value, DgvData.Rows(i).Cells(6).Value, DgvData.Rows(i).Cells(7).Value}
            clsKoneksi.insertCommand(1, myQuery67, namaKolom67, isiKolom67)

            'cmd.Parameters(0).Value = DgvData.Rows(i).Cells(0).Value
            'cmd.Parameters(1).Value = dtpHelp2.Value.Date
            'cmd.Parameters(2).Value = DgvData.Rows(i).Cells(3).Value
            'cmd.Parameters(3).Value = DgvData.Rows(i).Cells(4).Value
            'cmd.Parameters(4).Value = DgvData.Rows(i).Cells(1).Value
            'cmd.Parameters(5).Value = DgvData.Rows(i).Cells(5).Value
            'cmd.Parameters(6).Value = DgvData.Rows(i).Cells(6).Value
            'cmd.Parameters(7).Value = DgvData.Rows(i).Cells(7).Value
            'cmd.ExecuteNonQuery()
        Next
        MsgBox("Berhasil Update")
        DgvData.Rows.Clear()
    End Sub

    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        If ckAll.Checked = True Then
            For i As Integer = 0 To dgvViewPlat.Rows.Count() - 1
                dgvViewPlat.Rows(i).Cells(2).Value = True
            Next
        Else
            For i As Integer = 0 To dgvViewPlat.Rows.Count() - 1
                dgvViewPlat.Rows(i).Cells(2).Value = False
            Next
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        tampilKelompok()
    End Sub
End Class