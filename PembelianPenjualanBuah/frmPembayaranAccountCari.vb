Public Class frmPembayaranAccountCari

    Sub loadCari()
        'Dim namaKolom As String() = {"KodeKotaA"}
        'Dim isiKolom As Object() = {clsKoneksi.kotaOn}
        Dim myQuery As String = "SELECT NoAccount,Nama,KodeKelompok,Keterangan " & _
                                "FROM Customer "
        myQuery = myQuery & " where KodeKota='" & clsKoneksi.kotaOn & "' "

        Dim intT As Integer = cmbCari.SelectedIndex
        Console.WriteLine(intT)
        Select Case intT
            Case 0
                myQuery = myQuery & "and NoAccount"
            Case 1
                myQuery = myQuery & "and Nama"
            Case 2
                myQuery = myQuery & "and KodeKelompok"
            Case 3
                myQuery = myQuery & "and keterangan"
        End Select
        myQuery = myQuery & " LIKE '%" & txtCari.Text & "%'" & " order by KodeKelompok,NoAccount,Nama  "
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        Console.WriteLine(myQuery)
        dgView.Rows.Clear()
        Dim isiView(3) As Object
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

    Private Sub frmPembayaranAccountCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
            frmPembayaran.txtNoAccount.Text = dgView.Item(0, e.RowIndex).Value
            frmPembayaran.txtNama.Text = dgView.Item(1, e.RowIndex).Value
            dgView.Rows.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    frmPembayaran.txtNoAccount.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmPembayaran.txtNama.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                    dgView.Rows.Clear()
                    Me.Visible = False
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub frmPembayaranAccountCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class