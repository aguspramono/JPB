Public Class frmPembayaranFeeCari

    Sub loadCari()
        Dim myQuery As String = "select KodePembayaran,Tgl,KodeKelompok,Kelompok,Fee,Keterangan,Total,KodeFee,KodeKota,Dibayar,Sisa FROM PembayaranFee "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where KodePembayaran"
            Case 1
                myQuery = myQuery & "where KodeKelompok"
            Case 2
                myQuery = myQuery & "where Kelompok"
            Case 3
                myQuery = myQuery & "where Fee"
            Case 4
                myQuery = myQuery & "where Keterangan"
            Case 5
                myQuery = myQuery & "where Total"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%' and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery & " and (Tgl>=#" & dtTglAwal.Value.ToString("MM/dd/yyyy") & "#" & " and Tgl<=#" & dtTglAkhir.Value.ToString("MM/dd/yyyy") & "#)"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(10) As Object
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

    End Sub

    Private Sub frmPembayaranFeeCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cmbCari.SelectedIndex = 0
        dtTglAwal.Value = clsKoneksi.tglAwalBulan(Now)
        dtTglAkhir.Value = clsKoneksi.tglAkhirBulan(Now)
    End Sub

    Private Sub txtCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCari()
        End If
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub cmbCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCari()
        End If
    End Sub
    Private Sub dgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If e.RowIndex >= 0 Then
            'KodePembayaran,Tgl,KodeKelompok,Kelompok,Fee,Keterangan,Total,KodeKota
            frmPembayaranFee.txtNoPembayaran.Text = dgView.Item(0, e.RowIndex).Value
            frmPembayaranFee.txtNoPembayaranlama.Text = dgView.Item(0, e.RowIndex).Value
            frmPembayaranFee.dtTanggal.Value = dgView.Item(1, e.RowIndex).Value
            frmPembayaranFee.txtKodeKelompok.Text = dgView.Item(2, e.RowIndex).Value
            frmPembayaranFee.txtKelompok.Text = dgView.Item(3, e.RowIndex).Value
            frmPembayaranFee.txtFee.Text = dgView.Item(4, e.RowIndex).Value
            frmPembayaranFee.txtKeterangan.Text = dgView.Item(5, e.RowIndex).Value
            frmPembayaranFee.txtTotal.Text = dgView.Item(6, e.RowIndex).Value
            frmPembayaranFee.txtTotal2.Text = Format(dgView.Item(6, e.RowIndex).Value, "#,###")
            frmPembayaranFee.txtKodeFee.Text = dgView.Item(7, e.RowIndex).Value
            frmPembayaranFee.txtDibayar.Text = FormatNumber(CDbl(dgView.Item(9, e.RowIndex).Value))
            frmPembayaranFee.txtSisaBayar.Text = FormatNumber(CDbl(dgView.Item(10, e.RowIndex).Value))
            frmPembayaranFee.loadDetail()
            dgView.Rows.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    frmPembayaranFee.txtNoPembayaran.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmPembayaranFee.txtNoPembayaranlama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmPembayaranFee.dtTanggal.Value = dgView.SelectedRows.Item(0).Cells(1).Value
                    frmPembayaranFee.txtKodeKelompok.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                    frmPembayaranFee.txtKelompok.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                    frmPembayaranFee.txtFee.Text = dgView.SelectedRows.Item(0).Cells(4).Value
                    frmPembayaranFee.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(5).Value
                    frmPembayaranFee.txtTotal.Text = dgView.SelectedRows.Item(0).Cells(6).Value
                    frmPembayaranFee.txtTotal2.Text = Format(dgView.SelectedRows.Item(0).Cells(6).Value, "#,###")
                    frmPembayaranFee.txtKodeFee.Text = dgView.SelectedRows.Item(0).Cells(7).Value
                    frmPembayaranFee.txtDibayar.Text = FormatNumber(CDbl(dgView.SelectedRows.Item(0).Cells(9).Value))
                    frmPembayaranFee.txtSisaBayar.Text = FormatNumber(CDbl(dgView.SelectedRows.Item(0).Cells(10).Value))
                    frmPembayaranFee.loadDetail()
                    dgView.Rows.Clear()
                    Me.Visible = False
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class