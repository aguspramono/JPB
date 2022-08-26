Imports System.Data.OleDb
Public Class frmMultipleEditPotongan
    Public noAcc As String = ""
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmCustomerCari.pilihan = "multiedit"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim cmd As OleDbCommand
        Dim myQuery As String

        If noAcc = "" Then
            MsgBox("Customer belum dipilih")
            Return
        End If

        myQuery = "update pembelian2 as p inner join pembelian as p2 on (p2.NoTicket=p.NoTicket) set p.HargaAkhir=p2.HargaAkhir where "
        myQuery = myQuery & " p.NoAccount='" & noAcc & "' and (p.tgl2>=#" & dtpDari.Value.ToString("MM/dd/yyyy") & "# and p.tgl2<=#" & dtpSampai.Value.ToString("MM/dd/yyyy") & "#)"
        cmd = New OleDbCommand(myQuery, clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        frmInputHargaPotongan.loadCari()
        noAcc = ""
        txtCust.Clear()
        MessageBox.Show("Harga berhasil diperbaharui", "Warning")
    End Sub
End Class