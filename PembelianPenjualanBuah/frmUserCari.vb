Public Class frmUserCari

    Private Sub frmProductCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub loadCari()
        Dim myQuery As String = "select*from UserAccount "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where NamaPengguna"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(1) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    If j = 1 Then
                        isiView(j) = "*****"
                    Else
                        isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                    End If
                End If
            Next
            dgView.Rows.Add(isiView)
        Next

    End Sub

    Private Sub frmProductCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
            frmUser.txtUsername.Text = dgView.Item(0, e.RowIndex).Value
            frmUser.txtUsernamelama.Text = dgView.Item(0, e.RowIndex).Value
            frmUser.txtPassword.Text = ""
            frmUser.txtKonfirmasiPassword.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    frmUser.txtUsername.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmUser.txtUsernamelama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmUser.txtPassword.Text = ""
                    frmUser.txtKonfirmasiPassword.Text = ""
                    Me.Visible = False
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class