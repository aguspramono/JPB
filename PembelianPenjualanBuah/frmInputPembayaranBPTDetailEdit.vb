Public Class frmInputPembayaranBPTDetailEdit

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        clsKoneksi.OnlyNumber(e, txtJumlah)
    End Sub


    Private Sub frmInputPembayaranBPTDetailEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = Date.Now
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtJumlah.Text = "" Then
            txtJumlah.Text = 0
        End If
        If txtJumlah.Text = 0 Then
            MsgBox("Jumlah tidak boleh 0")
            Return
        End If
        Dim isiView(5) As Object
        isiView(0) = ""
        isiView(1) = frmPembayaranBPTDetailEdit.noBPT
        isiView(2) = frmPembayaranBPTDetailEdit.noTBS
        isiView(3) = dtpTanggal.Value.Date
        isiView(4) = CDbl(txtJumlah.Text)
        frmPembayaranBPTDetailEdit.dgvdata.Rows.Add(isiView)
        frmPembayaranBPTDetailEdit.hitungTotal()
        txtJumlah.Text = 0
        Me.Close()
    End Sub
End Class