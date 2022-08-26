Public Class frmPjmldanSejenisnya

    Sub loadData()
        Dim myQuery As String = "select c.Nama,p.* from pjmlsejenis p INNER JOIN customer c on(c.noAccount=p.noAccount)"
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
        lblNoAcc.Text = ""
        txtCust.Clear()
        txtHargaKali.Clear()
        txtHargaKurang.Clear()
        btnCariCust.Enabled = True
    End Sub

    Private Sub frmPjmldanSejenisnya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If lblNoAcc.Text = "" Or txtHargaKali.Text = "" Or txtHargaKurang.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select noAccount from pjmlsejenis where"
            Dim namaKolom As String() = {"ID"}
            Dim isiKolom As Object() = {lblNoAcc.Text}
            myQuery = myQuery & " noAccount=@ID"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO pjmlsejenis "
            Dim namaKolom1 As String() = {"noAccount", "hargakali", "hargakurang"}
            Dim isiKolom1 As Object() = {lblNoAcc.Text, CDbl(txtHargaKali.Text), CDbl(txtHargaKurang.Text)}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            loadData()
            bersih()
        End If
    End Sub

    Private Sub btnCariCust_Click(sender As Object, e As EventArgs) Handles btnCariCust.Click
        frmCustomerCari.pilihan = "pjml"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub txtHargaKali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaKali.KeyPress
        clsKoneksi.OnlyNumber(e, txtHargaKali)
    End Sub

    Private Sub txtHargaKurang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaKurang.KeyPress
        clsKoneksi.OnlyNumber(e, txtHargaKurang)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If lblNoAcc.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double click pada data")
        Else
            If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
                Dim myQuery2 As String = "delete from pjmlsejenis where noAccount=@noAccount"
                Dim namaKolom2 As String() = {"noAccount"}
                Dim isiKolom2 As Object() = {lblNoAcc.Text}
                clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
                loadData()
                bersih()
            End If
        End If
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        btnCariCust.Enabled = False
        Dim i As Integer = dgvData.CurrentRow.Index
        lblNoAcc.Text = dgvData.Item(2, i).Value
        txtCust.Text = dgvData.Item(0, i).Value
        txtHargaKali.Text = dgvData.Item(3, i).Value
        txtHargaKurang.Text = dgvData.Item(4, i).Value
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        loadData()
        bersih()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If lblNoAcc.Text = "" Then
            MsgBox("Belum ada data yang dipilih, silahkan pilih data dengan double clik pada pada")
        Else
            Dim myQuery1 As String = "UPDATE pjmlsejenis Set "
            Dim namaKolom1 As String() = {"hargakali", "hargakurang"}
            Dim isiKolom1 As Object() = {CDbl(txtHargaKali.Text), CDbl(txtHargaKurang.Text)}

            Dim kondisiWhere As String = " where noAccount =@noAccount"
            Dim namaKolom2 As String() = {"noAccount"}
            Dim isiKolom2 As Object() = {lblNoAcc.Text}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            loadData()
            bersih()
        End If
    End Sub
End Class