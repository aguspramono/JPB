Public Class frmInvoicePembayaranCari
    Dim tTipe As String

    Private Sub frmInvoicePembayaranCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Sub loadCari()
        Dim myQuery As String = "select KodePembayaran,Tgl,NoAccount,Nama,keterangan,Total,KodeKota FROM Pembayaran "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}
        If opt1.Checked Then
            'pembayaran
            myQuery = "select KodePembayaran,Tgl,NoAccount,Nama,keterangan,Total,KodeKota FROM Pembayaran "
            myQuery = myQuery & "where KodePembayaran not in(select KodePembayaran from invoice where kodekota='" & clsKoneksi.kotaOn & "') "
            Dim intT As Integer = cmbCari.SelectedIndex
            Select Case intT
                Case 0
                    myQuery = myQuery & "and KodePembayaran"
                Case 1
                    myQuery = myQuery & "and NoAccount"
                Case 2
                    myQuery = myQuery & "and Nama"
                Case 3
                    myQuery = myQuery & "where Keterangan"
                Case 4
                    myQuery = myQuery & "where Total"
            End Select
            tTipe = "1"
        Else
            'fee
            myQuery = "SELECT KodePembayaran,Tgl,KodeKelompok,Kelompok,Keterangan,Total,KodeKota FROM PembayaranFee "
            myQuery = myQuery & "where KodePembayaran not in(select KodePembayaran from invoice where kodekota='" & clsKoneksi.kotaOn & "') "
            Dim intT As Integer = cmbCari.SelectedIndex
            Select Case intT
                Case 0
                    myQuery = myQuery & "and KodePembayaran"
                Case 1
                    myQuery = myQuery & "and KodeKelompok"
                Case 2
                    myQuery = myQuery & "and Kelompok"
                Case 3
                    myQuery = myQuery & "and Keterangan"
                Case 4
                    myQuery = myQuery & "and Total"
            End Select
            tTipe = "2"
        End If


        myQuery = myQuery & " LIKE '%' + @Cari + '%' and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery & " and (Tgl>=#" & Format(dtTglAwal.Value.Date, "MM/dd/yyyy") & "#" & " and Tgl<=#" & Format(dtTglAkhir.Value.Date, "MM/dd/yyyy") & "#)"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(6) As Object
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

    Private Sub frmInvoicePembayaranCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

    Private Sub cmbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCari.SelectedIndexChanged

    End Sub

    Private Sub dgView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub

    Private Sub dgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If e.RowIndex >= 0 Then
            'KodePembayaran,Tgl,KodeKelompok,Kelompok,Fee,Keterangan,Total,KodeKota
            frmInvoice.txtNoPembayaran.Text = dgView.Item(0, e.RowIndex).Value
            frmInvoice.txtNoAccount.Text = dgView.Item(2, e.RowIndex).Value
            frmInvoice.txtNama.Text = dgView.Item(3, e.RowIndex).Value
            frmInvoice.txtTotalH.Text = dgView.Item(5, e.RowIndex).Value
            frmInvoice.txtTotalH2.Text = Format(dgView.Item(5, e.RowIndex).Value, "#,###")
            frmInvoice.txtTipe.Text = tTipe
            frmInvoice.loadHitungTotal()
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    frmInvoice.txtNoPembayaran.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmInvoice.txtNoAccount.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                    frmInvoice.txtNama.Text = dgView.SelectedRows.Item(0).Cells(3).Value.Value
                    frmInvoice.txtTotalH.Text = dgView.SelectedRows.Item(0).Cells(5).Value
                    frmInvoice.txtTotalH2.Text = Format(dgView.SelectedRows.Item(0).Cells(5).Value, "#,###")
                    frmInvoice.txtTipe.Text = tTipe
                    frmInvoice.loadHitungTotal()
                    Me.Visible = False
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class