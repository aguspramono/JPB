Public Class frmPotongan
    Sub LoadData()
        Dim myQuery As String = "select kodeKelompok,potongan from Potongan where kodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvView.Rows.Clear()
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
            dgvView.Rows.Add(isiView)
        Next
    End Sub

    Sub bersih()
        txtBesarPotongan.Clear()
        txtKodeKelompok.Clear()
        btnCariKelompok.Enabled = True
    End Sub

    Private Sub frmPotongan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeKelompok.Text = "" Or txtBesarPotongan.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select kodeKelompok from Potongan where"
            Dim namaKolom As String() = {"ID", "kodeKota"}
            Dim isiKolom As Object() = {txtKodeKelompok.Text, clsKoneksi.kotaOn}
            myQuery = myQuery & " kodeKelompok=@ID and kodeKota=@kodeKota"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO Potongan "
            Dim namaKolom1 As String() = {"kodeKelompok", "potongan", "kodeKota"}
            Dim isiKolom1 As Object() = {txtKodeKelompok.Text, txtBesarPotongan.Text, clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            LoadData()

            bersih()
        End If
    End Sub

    Private Sub btnCariKelompok_Click(sender As Object, e As EventArgs) Handles btnCariKelompok.Click
        frmKelompokCari.pilihanT = "Potongan"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtKodeKelompok.Text = "" Or txtBesarPotongan.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double clik pada pada")
        Else
            Dim myQuery1 As String = "UPDATE Potongan Set "
            Dim namaKolom1 As String() = {"potongan"}
            Dim isiKolom1 As Object() = {txtBesarPotongan.Text}

            Dim kondisiWhere As String = " where KodeKelompok =@KodeKelompok2 and kodeKota=@kodeKota"
            Dim namaKolom2 As String() = {"KodeKelompok2", "kodeKota"}
            Dim isiKolom2 As Object() = {txtKodeKelompok.Text, clsKoneksi.kotaOn}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            LoadData()
            bersih()
        End If
    End Sub

    Private Sub dgvView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellDoubleClick
        Dim i As Integer = dgvView.CurrentRow.Index
        txtKodeKelompok.Text = dgvView.Item(0, i).Value
        txtBesarPotongan.Text = dgvView.Item(1, i).Value

        btnCariKelompok.Enabled = False
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeKelompok.Text = "" Or txtBesarPotongan.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double click pada data")
        Else
            If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
                Dim myQuery2 As String = "delete from Potongan where KodeKelompok=@KodeKelompok"
                Dim namaKolom2 As String() = {"KodeKelompok"}
                Dim isiKolom2 As Object() = {txtKodeKelompok.Text}
                clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
                LoadData()
                bersih()
            End If
        End If
    End Sub

    Private Sub txtBesarPotongan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBesarPotongan.KeyPress
        clsKoneksi.OnlyNumber(e, txtBesarPotongan)
    End Sub

End Class