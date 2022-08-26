Public Class frmCustomerBerdasarkanTBS
    Sub LoadData()
        Dim myQuery As String = "select a.id,b.Nama,a.kodeKelompok from kelompoktbs as a inner join customer as b on b.noAccount=a.noAccount"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
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
            dgvData.Rows.Add(isiView)
        Next
    End Sub

    Sub bersih()
        lblID.Text = ""
        lblAccount.Text = ""
        txtCustomer.Clear()
        txtKodeKelompok.Clear()
        btnCariCustomer.Enabled = True
    End Sub

    Private Sub frmCustomerBerdasarkanTBS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        bersih()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeKelompok.Text = "" Or txtCustomer.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select * from kelompoktbs where"
            Dim namaKolom As String() = {"noAccount", "kodeKelompok"}
            Dim isiKolom As Object() = {lblAccount.Text, txtKodeKelompok.Text}
            myQuery = myQuery & " kodeKelompok=@kodeKelompok and noAccount=@noAccount"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO kelompoktbs "
            Dim namaKolom1 As String() = {"noAccount", "kodeKelompok"}
            Dim isiKolom1 As Object() = {lblAccount.Text, txtKodeKelompok.Text}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            LoadData()
            bersih()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lblID.Text = "" Then
            MsgBox("Pilih data terlebih dahulu. Double klik pada data")
        Else
            Dim myQuery As String = "select * from kelompoktbs where"
            Dim namaKolom As String() = {"noAccount", "kodeKelompok"}
            Dim isiKolom As Object() = {lblAccount.Text, txtKodeKelompok.Text}
            myQuery = myQuery & " kodeKelompok=@kodeKelompok and noAccount=@noAccount"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "UPDATE kelompoktbs Set "
            Dim namaKolom1 As String() = {"kodeKelompok"}
            Dim isiKolom1 As Object() = {txtKodeKelompok.Text}

            Dim kondisiWhere As String = " where id=@id"
            Dim namaKolom2 As String() = {"id"}
            Dim isiKolom2 As Object() = {lblID.Text}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            LoadData()
            bersih()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
    End Sub

    Private Sub btnCariKelompok_Click(sender As Object, e As EventArgs) Handles btnCariKelompok.Click
        frmKelompokCari.pilihanT = "kelompoktbs"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnCariCustomer_Click(sender As Object, e As EventArgs) Handles btnCariCustomer.Click
        frmCustomerCari.pilihan = "kelompoktbs"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim i As Integer = dgvData.CurrentRow.Index

        lblID.Text = dgvData.Item(0, i).Value
        txtCustomer.Text = dgvData.Item(1, i).Value
        txtKodeKelompok.Text = dgvData.Item(2, i).Value
        btnCariCustomer.Enabled = False
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

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from kelompoktbs where id=@id"
            Dim namaKolom2 As String() = {"id"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            LoadData()
            bersih()
        End If
    End Sub
End Class