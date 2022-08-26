Public Class frmPembayaranFeeKelompokCari

    Sub loadCari()
        Dim myQuery As String = "SELECT k.KodeKelompok,k.Kelompok " & _
                                "FROM Kelompok as k where"

        myQuery = myQuery & " k.KodeKota='" & clsKoneksi.kotaOn & "'"

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & " and k.KodeKelompok"
            Case 1
                myQuery = myQuery & " and k.Kelompok"
        End Select
        myQuery = myQuery & " LIKE '%" & txtCari.Text & "%'" & " order by k.KodeKelompok "
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgView.Rows.Clear()
        Dim isiView(1) As Object
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

    Private Sub frmPembayaranFeeKelompokCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cmbCari.SelectedIndex = 0
    End Sub

    Private Sub txtCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCari()
        End If
    End Sub


    Private Sub cmbCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCari()
        End If
    End Sub

    Private Sub dgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If e.RowIndex >= 0 Then
            frmPembayaranFee.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
            frmPembayaranFee.txtKelompok.Text = dgView.Item(1, e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    frmPembayaranFee.txtKodeKelompok.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmPembayaranFee.txtKelompok.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                    Me.Visible = False
                    Me.Close()
                End If
            End If

        End If
    End Sub
End Class