Public Class frmInputPembayaranBTPDetailCari
    Public noPembayaran As String
    Public KodeParam As Integer
    Public noTicketShow As String
    Public modeTampil As String = "A"
    Private Sub frmInputPembayaranBTPDetailCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myQuery As String = " select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,Harga,Total,KodeKota from PembayaranDetail where KodePembayaran='" & noPembayaran & "' and KodeParam=" & KodeParam & " and NoTicket not in(" & noTicketShow & ") and (IsNull(StatusBayar) or StatusBayar='') and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgView.Rows.Clear()
        Dim isiView(8) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgView.Rows.Add(isiView)
        Next

        If dgView.Rows.Count > 0 Then
            For a As Integer = 0 To dgView.Rows.Count - 1
                dgView.Rows(a).Cells(9).Value = True
            Next
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        For i As Integer = 0 To dgView.Rows.Count - 1
            If dgView.Rows(i).Cells(9).Value = True Then
                Dim isiView(8) As Object
                isiView(0) = dgView.Rows(i).Cells(0).Value
                isiView(1) = dgView.Rows(i).Cells(1).Value
                isiView(2) = dgView.Rows(i).Cells(2).Value
                isiView(3) = dgView.Rows(i).Cells(3).Value
                isiView(4) = dgView.Rows(i).Cells(4).Value
                isiView(5) = dgView.Rows(i).Cells(5).Value
                isiView(6) = dgView.Rows(i).Cells(6).Value
                isiView(7) = dgView.Rows(i).Cells(7).Value
                If modeTampil = "A" Then
                    frmInputPembayaranBPTDetail.dgView.Rows.Add(isiView)
                Else
                    frmPembayaranBPTDetailEdit.dgView.Rows.Add(isiView)
                End If

            End If
        Next
        frmInputPembayaranBPTDetail.hitungTotal()
        frmPembayaranBPTDetailEdit.hitungTotal()
        Me.Close()
    End Sub
End Class