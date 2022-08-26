Public Class frmSettingMarsada
    Public idEdit As Double = 0
    Public noAcc As String

    Sub loadData()
        Dim myQuery As String = "select a.idPengecualianMarsada,c.Nama,a.nilaiKali,a.nilaiBagi from pengecualianMarsada a INNER JOIN customer c on(c.noAccount=a.NoAccount) where a.kodeKota='" & clsKoneksi.kotaOn & "'"
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
        btnCari.Enabled = True
        txtNoAcc.Clear()
        noAcc = ""
        idEdit = 0
        txtHargaBagi.Text = "0"
        txtHargaKali.Text = "0"
    End Sub
    Private Sub frmSettingMarsada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmCustomerCari.pilihan = "marsada"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub txtHargaKali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaKali.KeyPress
        clsKoneksi.OnlyNumber(e, txtHargaKali)
    End Sub

    Private Sub txtHargaBagi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBagi.KeyPress
        clsKoneksi.OnlyNumber(e, txtHargaBagi)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNoAcc.Text = "" Or txtHargaKali.Text = "" Or txtHargaBagi.Text = "" Or txtHargaKali.Text = "0" Or txtHargaBagi.Text = "0" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select NoAccount from PengecualianMarsada where"
            Dim namaKolom As String() = {"ID"}
            Dim isiKolom As Object() = {noAcc}
            myQuery = myQuery & " NoAccount=@ID"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data customer ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO PengecualianMarsada "
            Dim namaKolom1 As String() = {"NoAccount", "nilaiKali", "nilaiBagi", "kodeKota"}
            Dim isiKolom1 As Object() = {noAcc, CDbl(txtHargaKali.Text), CDbl(txtHargaBagi.Text), clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            loadData()
            bersih()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
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
            Dim myQuery2 As String = "delete from PengecualianMarsada where idPengecualianMarsada=@idPengecualianMarsada"
            Dim namaKolom2 As String() = {"idPengecualianMarsada"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            loadData()
            bersih()
        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        btnCari.Enabled = False
        Dim i As Integer = dgvData.CurrentRow.Index
        idEdit = dgvData.Item(0, i).Value
        txtNoAcc.Text = dgvData.Item(1, i).Value
        txtHargaKali.Text = dgvData.Item(2, i).Value
        txtHargaBagi.Text = dgvData.Item(3, i).Value
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idEdit = 0 Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan klik kanan pada data")
        Else

            Dim myQuery1 As String = "UPDATE PengecualianMarsada Set "
            Dim namaKolom1 As String() = {"nilaiKali", "nilaiBagi"}
            Dim isiKolom1 As Object() = {CDbl(txtHargaKali.Text), CDbl(txtHargaBagi.Text)}

            Dim kondisiWhere As String = " where idPengecualianMarsada =@idPengecualianMarsada"
            Dim namaKolom2 As String() = {"idPengecualianMarsada"}
            Dim isiKolom2 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            loadData()
            bersih()
        End If
    End Sub
End Class