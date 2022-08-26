Public Class frmBBPengecualian

    Sub loadData()
        Dim myQuery As String = "select a.id,b.Nama,a.kodeKelompok,a.harga from pengecualianbb as a inner join customer as b on b.noAccount=a.noAccount"
        myQuery = myQuery
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

    Sub bersih()
        txtKelompok.Clear()
        txtHarga.Clear()
        txtCustomer.Clear()
        lblNoAccount.Text = ""
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKelompok.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select kodeKelompok from pengecualianbb where"
            Dim namaKolom As String() = {"noAccount", "kodeKelompok"}
            Dim isiKolom As Object() = {lblNoAccount.Text, txtKelompok.Text}
            myQuery = myQuery & " kodeKelompok=@kodeKelompok and noAccount=@noAccount"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO pengecualianbb "
            Dim namaKolom1 As String() = {"noAccount", "kodeKelompok", "harga"}
            Dim isiKolom1 As Object() = {lblNoAccount.Text, txtKelompok.Text, txtHarga.Text}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            loadData()

            bersih()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmKelompokCari.pilihanT = "pengecualianBB"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub frmBBPengecualian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtKelompok.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double clik pada pada")
        Else
            Dim myQuery1 As String = "UPDATE pengecualianbb Set "
            Dim namaKolom1 As String() = {"harga"}
            Dim isiKolom1 As Object() = {txtHarga.Text}

            Dim kondisiWhere As String = " where KodeKelompok =@KodeKelompok2"
            Dim namaKolom2 As String() = {"KodeKelompok2"}
            Dim isiKolom2 As Object() = {txtKelompok.Text}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            loadData()
            bersih()
        End If
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim i As Integer = dgvData.CurrentRow.Index
        txtCustomer.Text = dgvData.Item(1, i).Value
        txtKelompok.Text = dgvData.Item(2, i).Value
        txtHarga.Text = dgvData.Item(3, i).Value
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from pengecualianbb where id=@id"
            Dim namaKolom2 As String() = {"id"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            loadData()
            bersih()
        End If
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

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        clsKoneksi.OnlyNumber(e, txtHarga)
    End Sub

    Private Sub btnCariCustomer_Click(sender As Object, e As EventArgs) Handles btnCariCustomer.Click
        frmCustomerCari.pilihan = "pengecualianbb"
        frmCustomerCari.ShowDialog()
    End Sub
End Class