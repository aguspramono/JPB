Public Class frmCariJumlahSpsi

    Public noBukti As String

    Sub loadData()
        Dim whereOption As String = ""
        Dim jumlahSPSI As Double = 0
        If cmbPilih.SelectedIndex = 0 Then
            whereOption = " and NoAcc like '%" & txtCari.Text & "%' and NoBukti not in (" & noBukti & ") and KodeKota='" & clsKoneksi.kotaOn & "' "
        ElseIf cmbPilih.SelectedIndex = 1 Then
            whereOption = " and NoBukti like '%" & txtCari.Text & "%' and NoBukti not in (" & noBukti & ")  and KodeKota='" & clsKoneksi.kotaOn & "' "
        ElseIf cmbPilih.SelectedIndex = 2 Then
            whereOption = " and Nama like '%" & txtCari.Text & "%' and NoBukti not in (" & noBukti & ")  and KodeKota='" & clsKoneksi.kotaOn & "' "
        ElseIf cmbPilih.SelectedIndex = 3 Then
            whereOption = " and SPSI like '%" & txtCari.Text & "%' and NoBukti not in (" & noBukti & ")  and KodeKota='" & clsKoneksi.kotaOn & "' "
        End If
        Dim myQuery As String = "select * from SpsiPenjumlahan where (datevalue(Tanggal)>=#" & Format(dtpDari.Value, "MM/dd/yyyy") & "# and datevalue(Tanggal)<=#" & Format(dtpSampai.Value, "MM/dd/yyyy") & "#) " & whereOption & ""
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(7) As Object
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

            dgvData.Rows(i).Cells(8).Value = True
            jumlahSPSI += isiView(7)

        Next

        txtSPSI.Text = FormatNumber(jumlahSPSI, 2)

        ckPilihSemua.Checked = True
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        loadData()
    End Sub

    Private Sub frmCariJumlahSpsi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPilih.SelectedIndex = 0
    End Sub

    Private Sub dgvData_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellValueChanged
        Dim jumlahSPSI As Double = 0
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If dgvData.Rows(i).Cells(8).Value = True Then
                jumlahSPSI += dgvData.Rows(i).Cells(7).Value
            End If
        Next
        txtSPSI.Text = FormatNumber(jumlahSPSI, 2)
    End Sub

    Private Sub ckPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles ckPilihSemua.CheckedChanged
        If ckPilihSemua.Checked = True Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                dgvData.Rows(i).Cells(8).Value = True
            Next
        Else
            For i As Integer = 0 To dgvData.Rows.Count - 1
                dgvData.Rows(i).Cells(8).Value = False
            Next
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        For i As Integer = 0 To dgvData.Rows.Count - 1
            If dgvData.Rows(i).Cells(8).Value = True Then
                Dim isiView(8) As Object
                isiView(0) = ""
                isiView(1) = dgvData.Rows(i).Cells(1).Value
                isiView(2) = dgvData.Rows(i).Cells(2).Value
                isiView(3) = dgvData.Rows(i).Cells(3).Value
                isiView(4) = dgvData.Rows(i).Cells(4).Value
                isiView(5) = dgvData.Rows(i).Cells(5).Value
                isiView(6) = dgvData.Rows(i).Cells(6).Value
                isiView(7) = dgvData.Rows(i).Cells(7).Value
                frmInputSettingSPSIJumlahSPSI.dgvData.Rows.Add(isiView)
            End If
        Next
        frmInputSettingSPSIJumlahSPSI.hitungTotal()
        dgvData.Rows.Clear()
        Me.Close()
    End Sub
End Class