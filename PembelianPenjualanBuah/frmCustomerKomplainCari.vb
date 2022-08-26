Public Class frmCustomerKomplainCari

    Private Sub frmCustomerKomplainCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub loadCari()
        Dim myQuery As String = "select NoKomplain,Tgl,NoTicket,NoAccountPembelian,NoAccount,Keterangan from CustomerKomplain "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where NoKomplain"
            Case 1
                myQuery = myQuery & "where Tgl"
            Case 2
                myQuery = myQuery & "where NoTicket"
            Case 3
                myQuery = myQuery & "where NoAccountPembelian"
            Case 4
                myQuery = myQuery & "where NoAccount"
            Case 5
                myQuery = myQuery & "where Keterangan"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(5) As Object

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

    Private Sub frmCustomerKomplainCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cmbCari.SelectedIndex = 0
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

    Private Sub dgView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If e.RowIndex >= 0 Then
            frmCustomerKomplain.txtNoKomplain.Text = dgView.Item(0, e.RowIndex).Value
            frmCustomerKomplain.dtTanggal.Value = dgView.Item(1, e.RowIndex).Value
            frmCustomerKomplain.txtNoTicket.Text = dgView.Item(2, e.RowIndex).Value
            frmCustomerKomplain.txtNoAccountPembelian.Text = dgView.Item(3, e.RowIndex).Value
            frmCustomerKomplain.txtNoAccountKomplain.Text = dgView.Item(4, e.RowIndex).Value
            frmCustomerKomplain.txtKeterangan.Text = dgView.Item(5, e.RowIndex).Value
            Me.Close()

        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    frmCustomerKomplain.txtNoKomplain.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmCustomerKomplain.dtTanggal.Value = dgView.SelectedRows.Item(0).Cells(1).Value
                    frmCustomerKomplain.txtNoTicket.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                    frmCustomerKomplain.txtNoAccountPembelian.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                    frmCustomerKomplain.txtNoAccountKomplain.Text = dgView.SelectedRows.Item(0).Cells(4).Value
                    frmCustomerKomplain.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(5).Value
                    Me.Visible = False
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub dgView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub
End Class