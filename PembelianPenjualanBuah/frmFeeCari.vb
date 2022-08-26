Public Class frmFeeCari
    Public kodeKelompok As String
    Sub tampilData()
        Dim myQuery As String = "select KodeFee,Fee from Fee where KodeKelompok='" & kodeKelompok & "' "
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
    Private Sub frmFeeCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim KodeFee As String = "''"
        Dim Fee As String = ""
        Dim jumlahDataCeklis As Integer = 0
        If dgvData.Rows.Count > 0 Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                If dgvData.Rows(i).Cells(2).Value = True Then

                    If i = 0 Then
                        If dgvData.Rows(i).Cells(2).Value = True Then
                            KodeFee = "'" & dgvData.Rows(i).Cells(0).Value & "'"
                            Fee = "" & dgvData.Rows(i).Cells(1).Value & ""
                        End If

                    Else
                        If dgvData.Rows(i).Cells(2).Value = True Then
                            KodeFee = KodeFee & ",'" & dgvData.Rows(i).Cells(0).Value & "'"
                            Fee = Fee & "," & dgvData.Rows(i).Cells(1).Value & ""
                        End If
                    End If
                End If  
            Next
        End If
        frmPembayaranFeeDetail.txtKodeFee.Text = KodeFee
        frmPembayaranFeeDetail.txtFee.Text = Fee
        Me.Close()
    End Sub
End Class