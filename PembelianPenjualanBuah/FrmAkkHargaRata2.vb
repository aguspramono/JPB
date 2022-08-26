Public Class FrmAkkHargaRata2

    Sub Loadcari()
        Dim myQuery As String = "select * from KalkulasiHargaGradeA where month(Tanggal)='" & cmbBulan.Text & "' and year(Tanggal)='" & cmbTahun.Text & "' and kodeKota='" & clsKoneksi.kotaOn & "' order by tanggal asc"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(6) As Object
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


    Private Sub FrmAkkHargaRata2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTahun.Items.Clear()
        For i As Integer = 0 To 3
            cmbTahun.Items.Add(Year(Now) - i)
        Next i
        cmbBulan.Text = Month(Now)
        cmbTahun.Text = Year(Now)
        cmbTahun.SelectedIndex = 0
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Loadcari()
    End Sub
End Class