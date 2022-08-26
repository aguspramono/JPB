Public Class frmPlat

    Sub tampil()
        Dim myQuery As String = "select kodeKelompok,plat,kodeKota from Plat"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvView.Rows.Clear()
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
            dgvView.Rows.Add(isiView)
            If dgvView.Rows(i).Cells(2).Value = "1" Then
                dgvView.Rows(i).Cells(2).Value = "Libo"
            Else
                dgvView.Rows(i).Cells(2).Value = "BinaBaru"
            End If
        Next
    End Sub

    Sub bersih()
        txtKelompok.Clear()
        txtPlat.Clear()
        btnCariKelompok.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = True
    End Sub

    Private Sub frmPlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btnCariKelompok_Click(sender As Object, e As EventArgs) Handles btnCariKelompok.Click
        frmKelompokCari.pilihanT = "Plat"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKelompok.Text = "" Or txtPlat.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select kodeKelompok,Plat,kodeKota from Plat where"
            Dim namaKolom As String() = {"ID", "PLAT", "Kota"}
            Dim isiKolom As Object() = {txtKelompok.Text, txtPlat.Text, clsKoneksi.kotaOn}
            myQuery = myQuery & " kodeKelompok=@ID and Plat=@PLAT and kodeKota=@Kota"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO Plat "
            Dim namaKolom1 As String() = {"KodeKelompok", "Plat", "kodeKota"}
            Dim isiKolom1 As Object() = {txtKelompok.Text, txtPlat.Text, clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            tampil()
            bersih()
        End If
    End Sub


    Private Sub dgvView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellDoubleClick
        Dim i As Integer = dgvView.CurrentRow.Index
        txtKelompok.Text = dgvView.Item(0, i).Value
        txtPlat.Text = dgvView.Item(1, i).Value
        btnCariKelompok.Enabled = False
        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtKelompok.Text = "" Or txtPlat.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double click pada data")
        Else
            Dim myQuery1 As String = "UPDATE Plat Set "
            Dim namaKolom1 As String() = {"Plat"}
            Dim isiKolom1 As Object() = {txtPlat.Text}

            Dim kondisiWhere As String = " where KodeKelompok =@KodeKelompok"
            Dim namaKolom2 As String() = {"KodeKelompok"}
            Dim isiKolom2 As Object() = {txtKelompok.Text}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            tampil()
            bersih()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKelompok.Text = "" Or txtPlat.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double click pada data")
        Else
            If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
                Dim myQuery2 As String = "delete from Plat where KodeKelompok=@KodeKelompok"
                Dim namaKolom2 As String() = {"KodeKelompok"}
                Dim isiKolom2 As Object() = {txtKelompok.Text}
                clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
                tampil()
                bersih()
            End If
        End If
    End Sub
End Class