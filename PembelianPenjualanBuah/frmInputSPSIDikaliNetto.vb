Public Class frmInputSPSIDikaliNetto

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub DataGridViewX1_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvData.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            mnuKlikKanan.Show(dgvData, e.Location)
        End If
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmCustomerCari.pilihan = "SPSIDikalinetto"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub frmInputSPSIDikaliNetto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class