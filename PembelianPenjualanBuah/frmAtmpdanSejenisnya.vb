Public Class frmAtmpdanSejenisnya

    Sub loadData()
        Dim myQuery As String = "select c.Nama,a.* from atmpsejenis a INNER JOIN customer c on(c.noAccount=a.noAccount) where a.kodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
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
        btnCariCust.Enabled = True
        txtCust.Clear()
        lblNoAccount.Text = ""
        txtFee.Clear()
        txtHargaKali.Clear()
    End Sub


    Private Sub btnCariCust_Click(sender As Object, e As EventArgs) Handles btnCariCust.Click
        frmCustomerCari.pilihan = "atmp"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub txtFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFee.KeyPress
        clsKoneksi.OnlyNumber(e, txtFee)
    End Sub

    Private Sub txtHargaKali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaKali.KeyPress
        clsKoneksi.OnlyNumber(e, txtHargaKali)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If lblNoAccount.Text = "" Or txtHargaKali.Text = "" Or txtFee.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select noAccount from Atmpsejenis where"
            Dim namaKolom As String() = {"ID"}
            Dim isiKolom As Object() = {lblNoAccount.Text}
            myQuery = myQuery & " noAccount=@ID"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO Atmpsejenis "
            Dim namaKolom1 As String() = {"NoAccount", "fee", "hargaKali", "kodeKota"}
            Dim isiKolom1 As Object() = {lblNoAccount.Text, CDbl(txtFee.Text), CDbl(txtHargaKali.Text), clsKoneksi.kotaOn}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            loadData()
            bersih()
        End If
    End Sub

    Private Sub frmAtmpdanSejenisnya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click

        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from atmpsejenis where noAccount=@noAccount"
            Dim namaKolom2 As String() = {"noAccount"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(1).Value}
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
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(0)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        btnCariCust.Enabled = False
        Dim i As Integer = dgvData.CurrentRow.Index
        lblNoAccount.Text = dgvData.Item(1, i).Value
        txtCust.Text = dgvData.Item(0, i).Value
        txtFee.Text = dgvData.Item(2, i).Value
        txtHargaKali.Text = dgvData.Item(3, i).Value
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
        loadData()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If lblNoAccount.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan klik kanan pada data")
        Else
            Dim myQuery1 As String = "UPDATE Atmpsejenis Set "
            Dim namaKolom1 As String() = {"fee", "hargaKali"}
            Dim isiKolom1 As Object() = {CDbl(txtFee.Text), CDbl(txtHargaKali.Text)}

            Dim kondisiWhere As String = " where noAccount =@noAccount"
            Dim namaKolom2 As String() = {"noAccount"}
            Dim isiKolom2 As Object() = {lblNoAccount.Text}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            loadData()
            bersih()
        End If
    End Sub
End Class