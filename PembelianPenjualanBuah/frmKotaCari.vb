Public Class frmKotaCari
    Public pilihanT As String
    Sub loadCari()
        Dim myQuery As String = "select*from Kota "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where KodeKota"
            Case 1
                myQuery = myQuery & "where Kota"
            Case 2
                myQuery = myQuery & "where Keterangan"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(2) As Object
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

    Private Sub frmKotaCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

    Private Sub dgView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub

    Private Sub dgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If e.RowIndex >= 0 Then
            If pilihanT = "kota" Then
                frmKota.txtKodeKota.Text = dgView.Item(0, e.RowIndex).Value
                frmKota.txtKodeKotaLama.Text = dgView.Item(0, e.RowIndex).Value
                frmKota.txtNama.Text = dgView.Item(1, e.RowIndex).Value
                frmKota.txtKeterangan.Text = dgView.Item(2, e.RowIndex).Value
            ElseIf pilihanT = "customer" Then
                frmCustomer.txtKodeKota.Text = dgView.Item(0, e.RowIndex).Value
                frmCustomer.txtKota.Text = dgView.Item(1, e.RowIndex).Value
            End If
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    If pilihanT = "kota" Then
                        frmKota.txtKodeKota.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmKota.txtKodeKotaLama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmKota.txtNama.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                        frmKota.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                    ElseIf pilihanT = "customer" Then
                        frmCustomer.txtKodeKota.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmCustomer.txtKota.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                    End If
                    Me.Visible = False
                    Me.Close()
                    'e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub frmKotaCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class