Public Class frmSettingNamaBos
    Sub LoadData()
        Dim myQuery As String = "select Customer.NoAccount,Customer.Nama from Customer inner join NamaBos on NamaBos.NoAccount=Customer.NoAccount"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvView.Rows.Clear()
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
            dgvView.Rows.Add(isiView)
        Next
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmCustomerCari.pilihan = "cariNamaBos"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim myQuery As String = "select NoAccount from NamaBos where"
        Dim namaKolom As String() = {"ID"}
        Dim isiKolom As Object() = {lblID.Text}
        myQuery = myQuery & " NoAccount=@ID"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        If tDs.Tables(0).Rows.Count > 0 Then
            MsgBox("Data ini sudah ada")
            Return
        End If

        Dim myQuery1 As String = "INSERT INTO NamaBos "
        Dim namaKolom1 As String() = {"NoAccount"}
        Dim isiKolom1 As Object() = {lblID.Text}
        clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
        LoadData()
    End Sub

    Private Sub frmSettingNamaBos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class