Public Class frmInvoiceDetail
    Public pilihanT As String

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        clsKoneksi.textBoxOnlyNumber(e)
    End Sub


    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text <> "" Then
            Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
            'If decimalSeparator = "," Then
            '    lblTotal.Text = Format(CDbl(txtTotal.Text), "#,###.##")
            'Else
            '    lblTotal.Text = Format(CDbl(txtTotal.Text), "#,###.##")
            'End If
            Try
                lblTotal.Text = Format(CDbl(txtTotal.Text), "N")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtTotal.Text = "" Then
            txtTotal.Text = "0"
        End If
        If pilihanT = "Baru" Then
            Dim isiView(4) As Object
            isiView(0) = ""
            isiView(1) = dtTgl.Value
            isiView(2) = txtKeterangan.Text
            isiView(3) = txtTotal.Text
            isiView(4) = clsKoneksi.kotaOn
            frmInvoice.dgView.Rows.Add(isiView)
        Else
            frmInvoice.dgView.SelectedRows.Item(0).Cells(1).Value = dtTgl.Value
            frmInvoice.dgView.SelectedRows.Item(0).Cells(2).Value = txtKeterangan.Text
            frmInvoice.dgView.SelectedRows.Item(0).Cells(3).Value = txtTotal.Text
        End If
        frmInvoice.loadHitungTotal()
        Me.Close()
    End Sub

    Private Sub frmInvoiceDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class