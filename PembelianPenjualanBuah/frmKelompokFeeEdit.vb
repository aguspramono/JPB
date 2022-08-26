Public Class frmKelompokFeeEdit

    Private Sub txtFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFee.KeyPress
        clsKoneksi.textBoxOnlyNumber(e)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim isiView(3) As Object
        If txtFee.Text = "" Then txtFee.Text = "0"
        If txtKodeFee.Text = "" Then
            isiView(0) = txtKodeFee.Text
            isiView(1) = CInt(txtFee.Text)
            isiView(2) = txtKeterangan.Text
            isiView(3) = ckAktif.Checked
            frmKelompok.dgView.Rows.Add(isiView)
        Else
            frmKelompok.dgView.SelectedRows.Item(0).Cells(1).Value = CInt(txtFee.Text)
            frmKelompok.dgView.SelectedRows.Item(0).Cells(2).Value = txtKeterangan.Text
            frmKelompok.dgView.SelectedRows.Item(0).Cells(3).Value = ckAktif.Checked
        End If
        frmKelompok.loadTotalFee()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class