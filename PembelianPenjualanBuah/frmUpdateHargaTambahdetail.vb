Public Class frmUpdateHargaTambahdetail

    Sub loadKelompok()
        Dim tDs1 As DataSet
        Dim myQuery1 As String = "select kodekelompok,kelompok from kelompok where hidekelompok='N' and kodekota='" & clsKoneksi.kotaOn & "' "
        dgvKelompok.Rows.Clear()
        tDs1 = clsKoneksi.selectCommand(1, myQuery1)
        Dim isiView1(1) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvKelompok.Rows.Add(isiView1)
        Next
    End Sub

    Private Sub frmUpdateHargaTambahdetail_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtHelp.Value = Now
        dthelp2.Format = DateTimePickerFormat.Time
        dthelp2.Value = Convert.ToDateTime(CDate(Now.Date.ToLongDateString & " " & "12:00:00"))
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim kodeKelompokA As String = ""
        For Each row As DataGridViewRow In dgvKelompok.Rows
            kodeKelompokA = kodeKelompokA & "'" & row.Cells("KodeKelompok").Value.ToString() & "',"
        Next
        kodeKelompokA = kodeKelompokA.Remove(kodeKelompokA.Length - 1, 1)
        Dim ts As TimeSpan = dthelp2.Value.TimeOfDay
        Dim myQuery As String = "INSERT INTO Harga (KodeKelompok,[Tgl],[Jam],Harga,Perubahan,KodeKota) select hargaT.KodeKelompok,@tglAA,@jamAA,hargaT.harga,hargaT.perubahan,hargaT.KodeKota from(SELECT h.KodeKelompok,h.Tgl,h.Jam,isnull((select top 1 harga from harga where KodeKelompok=h.KodeKelompok and ((tgl <=@tglAA and Jam<=@jamAA) or tgl <@TglAA) order by tgl desc,jam desc),0) as harga,0 as perubahan,h.KodeKota,h.autoUP,"

        Dim kondisiWhere As String = " where  hargaT.rowNumber2=1 "
        Dim namaKolom As String() = {""}
        Dim isiKolom As Object() = {""}
        Dim namaKolom2 As String() = {"tglAA", "jamAA"}
        Dim isiKolom2 As Object() = {dtHelp.Value, ts}
        Console.WriteLine(dthelp2.Value.ToString & " " & ts.ToString & " " & kodeKelompokA)
        clsKoneksi.updateCommand(1,myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 2)

        frmUpdateHarga.loadMain()
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub frmUpdateHargaTambahdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadKelompok()
    End Sub
End Class