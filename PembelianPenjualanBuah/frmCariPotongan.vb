Public Class frmCariPotongan
    Public kodeKelompokPotongan As String

    Sub loadCari()
        Dim tDs As DataSet
        Dim myQuery As String = "select*from Potongan "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}
        If txtCari.Text = "" Then
            myQuery = myQuery
            tDs = clsKoneksi.selectCommand(1, myQuery)
        Else
            myQuery = myQuery & "where kodeKelompok="
            myQuery = myQuery & "'' + @Cari + ''"
            tDs = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        End If


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
    Private Sub frmCariPotongan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loadCari()
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim i As Integer = dgvData.CurrentRow.Index
        frmInputHargaEditDetail.txtPotongan.Text = dgvData.Item(1, i).Value
        frmInputHargaEditDetail.txtTotal.Text = CDbl(frmInputHargaEditDetail.txtHargaAkhir.Text - dgvData.Item(1, i).Value) * CDbl(frmInputHargaEditDetail.txtNet.Text)
        Me.Close()
    End Sub
End Class