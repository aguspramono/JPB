Public Class frmPotonganPlat
    Dim idUpdate As Integer = 0
    Sub tampil()
        Dim myQuery As String = "select * from PotonganPlat where KodeKota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(4) As Object
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
        txtKodeKelompok.Clear()
        txtKodePlat.Clear()
        txtJumlah.Text = 0
    End Sub
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        clsKoneksi.OnlyNumber(e, txtJumlah)
    End Sub

    Private Sub frmPotonganPlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btnCariKelompok_Click(sender As Object, e As EventArgs) Handles btnCariKelompok.Click
        frmKelompokCari.pilihanT = "PotonganPlat"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeKelompok.Text = "" Or txtKodePlat.Text = "" Or txtJumlah.Text = "" Or txtJumlah.Text = 0 Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select * from Plat where"
            Dim namaKolom As String() = {"KodeKelompok", "Plat", "KodeKota"}
            Dim isiKolom As Object() = {txtKodeKelompok.Text, txtKodePlat.Text, clsKoneksi.kotaOn}
            myQuery = myQuery & " KodeKelompok=@KodeKelompok and Plat=@Plat and KodeKota=@KodeKota"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO PotonganPlat "
            Dim namaKolom1 As String() = {"KodeKelompok", "Plat", "PotonganHarga", "KodeKota"}
            Dim isiKolom1 As Object() = {txtKodeKelompok.Text, txtKodePlat.Text, CDbl(txtJumlah.Text), clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            MsgBox("Berhasil Simpan")
            tampil()
            bersih()
        End If
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from PotonganPlat where IDPotonganPlat=@IDPotonganPlat"
            Dim namaKolom2 As String() = {"IDPotonganPlat"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            MsgBox("Berhasil Hapus")
            tampil()
            bersih()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idUpdate = 0 Then
            MsgBox("Pilih data terlebih dahulu")
            Return
        End If
        Dim myQuery1 As String = "UPDATE PotonganPlat Set "
        Dim namaKolom1 As String() = {"Plat", "PotonganHarga"}
        Dim isiKolom1 As Object() = {txtKodePlat.Text, CDbl(txtJumlah.Text)}

        Dim kondisiWhere As String = " where IDPotonganPlat =@IDPotonganPlat"
        Dim namaKolom2 As String() = {"IDPotonganPlat"}
        Dim isiKolom2 As Object() = {idUpdate}
        clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
        MsgBox("Berhasil Edit")
        idUpdate = 0
        tampil()
        bersih()
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        idUpdate = dgvData.SelectedCells(0).Value
        txtKodeKelompok.Text = dgvData.SelectedCells(1).Value
        txtKodePlat.Text = dgvData.SelectedCells(2).Value
        txtJumlah.Text = dgvData.SelectedCells(3).Value
    End Sub

    Private Sub dgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvData.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(1)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
        tampil()
    End Sub
End Class