Public Class frmTambahanHargaPlat
    Public ketEdit As String
    Public idEdit As String

    Sub bersih()
        txtKodePlat.Clear()
        txtHarga.Clear()
        idEdit = ""
    End Sub
    Sub tampil()
        Dim myQuery As String = "select * from hargaTambahanPlat where KodeKota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(3) As Object
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
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodePlat.Text = "" Or txtHarga.Text = "" Or txtHarga.Text = 0 Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select * from hargaTambahanPlat where"
            Dim namaKolom As String() = {"KodePlat", "KodeKota"}
            Dim isiKolom As Object() = {txtKodePlat.Text, clsKoneksi.kotaOn}
            myQuery = myQuery & " KodePlat=@KodePlat and KodeKota=@KodeKota"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO hargaTambahanPlat "
            Dim namaKolom1 As String() = {"KodePlat", "HargaTambahan", "KodeKota"}
            Dim isiKolom1 As Object() = {txtKodePlat.Text, CDbl(txtHarga.Text), clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            MsgBox("Berhasil Simpan")
            tampil()
            bersih()
        End If
    End Sub

    Private Sub frmTambahanHargaPlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub dgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseUp
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

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        idEdit = dgvData.SelectedCells(0).Value
        txtKodePlat.Text = dgvData.SelectedCells(1).Value
        txtHarga.Text = dgvData.SelectedCells(2).Value
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from hargaTambahanPlat where IDhargaTambahanPlat=@IDhargaTambahanPlat"
            Dim namaKolom2 As String() = {"IDhargaTambahanPlat"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            MsgBox("Berhasil Hapus")
            tampil()
            bersih()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idEdit = "" Then
            MsgBox("Pilih data terlebih dahulu")
            Return
        End If
        Dim myQuery1 As String = "UPDATE hargaTambahanPlat Set "
        Dim namaKolom1 As String() = {"KodePlat", "HargaTambahan"}
        Dim isiKolom1 As Object() = {txtKodePlat.Text, CDbl(txtHarga.Text)}

        Dim kondisiWhere As String = " where IDhargaTambahanPlat =@IDhargaTambahanPlat"
        Dim namaKolom2 As String() = {"IDhargaTambahanPlat"}
        Dim isiKolom2 As Object() = {idEdit}
        clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
        MsgBox("Berhasil Edit")
        tampil()
        bersih()
    End Sub
End Class