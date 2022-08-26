Public Class frmKelompokPapan

    Sub LoadData()
        Dim myQuery As String = "select * from Papan where kodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvKelompok.Rows.Clear()
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
            dgvKelompok.Rows.Add(isiView)
        Next
    End Sub

    Sub bersih()
        txtKelompok.Clear()
        LoadData()
        btnCari.Enabled = True
        txtPenambahanHarga.Enabled = False
        txtPenambahanHarga.Text = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKelompok.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select kodeKelompok from Papan where"
            Dim namaKolom As String() = {"kodeKelompok", "kodeKota"}
            Dim isiKolom As Object() = {txtKelompok.Text, clsKoneksi.kotaOn}
            myQuery = myQuery & " kodeKelompok=@kodeKelompok and kodeKota=@kodeKota"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO Papan "
            Dim namaKolom1 As String() = {"kodeKelompok", "penambahanHarga", "kodeKota"}
            Dim isiKolom1 As Object() = {txtKelompok.Text, CDbl(txtPenambahanHarga.Text), clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            LoadData()

            bersih()
        End If
    End Sub

    Private Sub frmKelompokPapan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmKelompokCari.pilihanT = "Papan"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub dgvKelompok_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelompok.CellDoubleClick
        Dim i As Integer = dgvKelompok.CurrentRow.Index
        txtKelompok.Text = dgvKelompok.Item(0, i).Value
        txtPenambahanHarga.Text = dgvKelompok.Item(1, i).Value
        btnCari.Enabled = False
        txtPenambahanHarga.Enabled = True
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKelompok.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double click pada data")
        Else
            If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
                Dim myQuery2 As String = "delete from Papan where KodeKelompok=@KodeKelompok"
                Dim namaKolom2 As String() = {"KodeKelompok"}
                Dim isiKolom2 As Object() = {txtKelompok.Text}
                clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
                LoadData()
                bersih()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim myQuery1 As String = "UPDATE Papan Set "
        Dim namaKolom1 As String() = {"penambahanHarga"}
        Dim isiKolom1 As Object() = {CDbl(txtPenambahanHarga.Text)}

        Dim kondisiWhere As String = " where kodeKelompok=@kodeKelompok and kodeKota=@kodeKota"
        Dim namaKolom2 As String() = {"kodeKelompok", "kodeKota"}
        Dim isiKolom2 As Object() = {txtKelompok.Text, clsKoneksi.kotaOn}
        clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
        LoadData()
        bersih()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub
End Class