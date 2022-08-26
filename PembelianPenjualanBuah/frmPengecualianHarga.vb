Public Class frmPengecualianHarga
    Sub LoadData()
        Dim myQuery As String = "select kodeKelompok,harga from Pengecualian"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
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
            dgvData.Rows.Add(isiView)
        Next
    End Sub

    Sub bersih()
        txtKelompok.Clear()
        txtHarga.Clear()
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmKelompokCari.pilihanT = "Pengecualian"
        frmKelompokCari.ShowDialog()
    End Sub


    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        'clsKoneksi.textBoxOnlyNumber(e)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKelompok.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select kodeKelompok from Pengecualian where"
            Dim namaKolom As String() = {"ID"}
            Dim isiKolom As Object() = {txtKelompok.Text}
            myQuery = myQuery & " kodeKelompok=@ID"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO Pengecualian "
            Dim namaKolom1 As String() = {"kodeKelompok", "harga"}
            Dim isiKolom1 As Object() = {txtKelompok.Text, txtHarga.Text}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            LoadData()

            bersih()
        End If
    End Sub


    Private Sub frmPengecualianHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim i As Integer = dgvData.CurrentRow.Index

        txtKelompok.Text = dgvData.Item(0, i).Value
        txtHarga.Text = dgvData.Item(1, i).Value
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtKelompok.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double clik pada pada")
        Else
            Dim myQuery1 As String = "UPDATE Pengecualian Set "
            Dim namaKolom1 As String() = {"harga"}
            Dim isiKolom1 As Object() = {txtHarga.Text}

            Dim kondisiWhere As String = " where KodeKelompok =@KodeKelompok2"
            Dim namaKolom2 As String() = {"KodeKelompok2"}
            Dim isiKolom2 As Object() = {txtKelompok.Text}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            LoadData()
            bersih()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKelompok.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double click pada data")
        Else
            If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
                Dim myQuery2 As String = "delete from Pengecualian where KodeKelompok=@KodeKelompok"
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
End Class