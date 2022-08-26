Public Class frmInputPembayaranBPFDetailCari

    Public buktiPembayaranCari As String
    Public noTicket As String
    Private Sub frmInputPembayaranBPFDetailCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cari As String = " where NoTicket not in(" & noTicket & ") and KodePembayaran='" & buktiPembayaranCari & "' and (IsNull(StatusBayar) or StatusBayar<>'Y' or StatusBayar='') and kodekota='" & clsKoneksi.kotaOn & "' order by KodeFee"
        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,KodeFee,Fee,Total,KodeKota FROM PembayaranFeeDetail " & cari & ""
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        Console.WriteLine(myQuery)
        dgvData.Rows.Clear()
        Dim isiView(9) As Object
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
        If dgvData.Rows.Count > 0 Then
            For a As Integer = 0 To dgvData.Rows.Count - 1
                dgvData.Rows(a).Cells(10).Value = True
            Next
        End If
        

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If dgvData.Rows(i).Cells(10).Value = True Then
                Dim isiView(9) As Object
                isiView(0) = dgvData.Rows(i).Cells(0).Value
                isiView(1) = dgvData.Rows(i).Cells(1).Value
                isiView(2) = dgvData.Rows(i).Cells(2).Value
                isiView(3) = dgvData.Rows(i).Cells(3).Value
                isiView(4) = dgvData.Rows(i).Cells(4).Value
                isiView(5) = dgvData.Rows(i).Cells(5).Value
                isiView(6) = dgvData.Rows(i).Cells(6).Value
                isiView(7) = dgvData.Rows(i).Cells(7).Value
                isiView(8) = dgvData.Rows(i).Cells(8).Value
                frmInputPembayaranBPFDetail.dgvData.Rows.Add(isiView)
            End If
        Next
        frmInputPembayaranBPFDetail.hitungTotal()
        Me.Close()
    End Sub
End Class