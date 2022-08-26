Public Class frmInputNamaSPSI

    Public modeEdit As Boolean = False
    Public idEdit As Integer

    Sub tampil()
        Dim myQuery As String = "select * from NamaSpsi where Nama like '%" & txtCari.Text & "%'"
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
        txtInput.Clear()
        modeEdit = False
        btnOk.Text = "&Simpan"
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtInput.Text = "" Then
            MsgBox("Masih ada data yang kosong", vbCritical)
            Return
        End If

        If modeEdit = False Then
            Dim myQuery1 As String = "INSERT INTO NamaSpsi "
            Dim namaKolom1 As String() = {"Nama"}
            Dim isiKolom1 As Object() = {txtInput.Text}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            tampil()
            MsgBox("Berhasil Disimpan", vbInformation)
            bersih()

        Else

            Dim myQuery2 As String = "UPDATE SpsiPenjumlahan Set "
            Dim namaKolom2 As String() = {"Nama"}
            Dim isiKolom2 As Object() = {txtInput.Text}

            Dim kondisiWhere1 As String = " where idNamaSpsi =@idNamaSpsi"
            Dim namaKolom3 As String() = {"idNamaSpsi"}
            Dim isiKolom3 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery2, namaKolom2, isiKolom2, kondisiWhere1, namaKolom3, isiKolom3, 1)


            Dim myQuery1 As String = "UPDATE NamaSpsi Set "
            Dim namaKolom1 As String() = {"Nama"}
            Dim isiKolom1 As Object() = {txtInput.Text}

            Dim kondisiWhere As String = " where idNamaSpsi =@idNamaSpsi"
            Dim namaKolom4 As String() = {"idNamaSpsi"}
            Dim isiKolom4 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom4, isiKolom4, 1)


            tampil()
            MsgBox("Berhasil Diubah", vbInformation)
            bersih()
        End If

    End Sub

    Private Sub frmInputNamaSPSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim i As Integer = dgvData.CurrentRow.Index
        'frmInputJumlahSPSI.txtNama.Text = dgvData.Item(1, i).Value
        Me.Close()
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
        modeEdit = True
        idEdit = dgvData.SelectedCells(0).Value
        txtInput.Text = dgvData.SelectedCells(1).Value
        btnOk.Text = "&Edit"
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from NamaSpsi where idNamaSpsi=@idNamaSpsi"
            Dim namaKolom2 As String() = {"idNamaSpsi"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            tampil()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        tampil()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub
End Class