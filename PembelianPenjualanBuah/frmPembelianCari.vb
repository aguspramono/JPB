Public Class frmPembelianCari

    Private Sub frmPembelianCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cmbCari.
    End Sub


    Sub loadCari()
        Dim myQuery As String = "select p.NoTicket,p.Tgl2,p.Vehicle,p.NoAccount,p.DO,p.Keterangan,pd.Product,pd.Berat1Brutto,pd.Berat2Tarra,pd.ADJ,pd.ADJNumber,pd.Netto,pd.Harga,pd.BJR" & _
                                " from Pembelian p, PembelianDetail pd " & _
                                " where p.NoTicket = pd.NoTicket  "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "and p.NoTicket"
            Case 1
                myQuery = myQuery & "and p.Vehicle"
            Case 2
                myQuery = myQuery & "and p.NoAccount"
            Case 3
                myQuery = myQuery & "and p.DO"
            Case 4
                myQuery = myQuery & "and p.Keterangan"
            Case 5
                myQuery = myQuery & "and pd.Product"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%'"
        myQuery = myQuery & " and (p.Tgl2>=#" & dtTglAwal.Value.ToString("MM/dd/yyyy") & "#" & " and p.Tgl2<=#" & dtTglAkhir.Value.ToString("MM/dd/yyyy") & "#)"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(13) As Object

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

    Private Sub txtCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCari()
        End If
    End Sub


    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub frmPembelianCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cmbCari.SelectedIndex = 0
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
            'frmCustomer.txtNoAcc.Text = dgView.Item(0, e.RowIndex).Value
            'frmCustomer.txtNoAccLama.Text = dgView.Item(0, e.RowIndex).Value
            'frmCustomer.txtNama.Text = dgView.Item(1, e.RowIndex).Value
            'frmCustomer.txtNotelp.Text = dgView.Item(2, e.RowIndex).Value
            'frmCustomer.txtAlamat.Text = dgView.Item(3, e.RowIndex).Value
            'frmCustomer.txtKota.Text = dgView.Item(4, e.RowIndex).Value
            'frmCustomer.txtNoAccountKepala.Text = dgView.Item(5, e.RowIndex).Value
            'frmCustomer.txtKeterangan.Text = dgView.Item(6, e.RowIndex).Value

            'Me.Close()

        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    'frmCustomer.txtNoAcc.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    'frmCustomer.txtNoAccLama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    'frmCustomer.txtNama.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                    'frmCustomer.txtNotelp.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                    'frmCustomer.txtAlamat.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                    'frmCustomer.txtKota.Text = dgView.SelectedRows.Item(0).Cells(4).Value
                    'frmCustomer.txtNoAccountKepala.Text = dgView.SelectedRows.Item(0).Cells(5).Value
                    'frmCustomer.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(6).Value
                    Me.Visible = False
                    Me.Close()
                End If
            End If

        End If
    End Sub
End Class