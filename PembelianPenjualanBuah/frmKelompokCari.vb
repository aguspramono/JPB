Public Class frmKelompokCari
    Public pilihanT As String
    Private Sub frmKelompokCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub loadCari()
        Dim myQuery As String = "select KodeKelompok,Kelompok,Grade,Fee,SPSI,Keterangan,urutanharga,hideKelompok,bulananHarga from Kelompok "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where KodeKelompok"
            Case 1
                myQuery = myQuery & "where Kelompok"
            Case 2
                myQuery = myQuery & "where Grade"
            Case 3
                myQuery = myQuery & "where Fee"
            Case 4
                myQuery = myQuery & "where SPSI"
            Case 5
                myQuery = myQuery & "where Keterangan"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%'"
        myQuery = myQuery & " and KodeKota='" & clsKoneksi.kotaOn & "' order by KodeKelompok"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(8) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
                If j = 7 Then
                    If isiView(j) = "N" Or isiView(j) = "" Then
                        isiView(j) = False
                    Else
                        isiView(j) = True
                    End If
                End If

                If j = 8 Then
                    If isiView(j) = "N" Or isiView(j) = "" Then
                        isiView(j) = False
                    Else
                        isiView(j) = True
                    End If
                End If
            Next
            dgView.Rows.Add(isiView)
        Next

    End Sub

    Private Sub frmKelompokCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
            Dim tInt As Integer = 2
            Select Case dgView.Item(2, e.RowIndex).Value
                Case "A"
                    tInt = 0
                Case "B"
                    tInt = 1
                Case "C"
                    tInt = 2
                Case "P"
                    tInt = 3
            End Select

            If pilihanT = "kelompok" Then
                frmKelompok.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
                frmKelompok.txtKodeKelompokLama.Text = dgView.Item(0, e.RowIndex).Value
                frmKelompok.txtNama.Text = dgView.Item(1, e.RowIndex).Value
                frmKelompok.cboGrade.SelectedIndex = tInt
                frmKelompok.txtFee.Text = dgView.Item(3, e.RowIndex).Value
                frmKelompok.txtSPSI.Text = dgView.Item(4, e.RowIndex).Value
                frmKelompok.txtKeterangan.Text = dgView.Item(5, e.RowIndex).Value
                frmKelompok.txtUrutanHarga.Text = dgView.Item(6, e.RowIndex).Value
                frmKelompok.txtUrutanHarga2.Text = dgView.Item(6, e.RowIndex).Value
                frmKelompok.chkHideKelompok.Checked = dgView.Item(7, e.RowIndex).Value
                frmKelompok.ckrataRata.Checked = dgView.Item(8, e.RowIndex).Value
                frmKelompok.loadFee()
            ElseIf pilihanT = "customer" Then
                frmCustomer.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
                frmCustomer.cboGrade.SelectedIndex = tInt
                frmCustomer.txtFee.Text = dgView.Item(3, e.RowIndex).Value
                frmCustomer.txtSPSI.Text = dgView.Item(4, e.RowIndex).Value
            ElseIf pilihanT = "Potongan" Then
                frmPotongan.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "Plat" Then
                frmPlat.txtKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "Pengecualian" Then
                frmPengecualianHarga.txtKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "Papan" Then
                frmKelompokPapan.txtKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "kelompokplat" Then
                frmCustomerBerdasarkanPlat.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "kelompoktbs" Then
                frmCustomerBerdasarkanTBS.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "pengecualianBB" Then
                frmBBPengecualian.txtKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "TanggalFee" Then
                frmSettingTanggalFee.txtKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "SPSIKaliAccount" Then
                frmInputSettingSPSIDikaliAccount.txtKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihanT = "PotonganPlat" Then
                frmPotonganPlat.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
            End If
            Me.Close()

        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    Dim tInt As Integer = 2
                    Select Case dgView.SelectedRows.Item(0).Cells(2).Value
                        Case "A"
                            tInt = 0
                        Case "B"
                            tInt = 1
                        Case "C"
                            tInt = 2
                        Case "P"
                            tInt = 3
                    End Select
                    If pilihanT = "kelompok" Then
                        frmKelompok.txtKodeKelompok.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmKelompok.txtKodeKelompokLama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmKelompok.txtNama.Text = dgView.SelectedRows.Item(0).Cells(1).Value

                        frmKelompok.cboGrade.SelectedIndex = tInt
                        frmKelompok.txtFee.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                        frmKelompok.txtSPSI.Text = dgView.SelectedRows.Item(0).Cells(4).Value
                        frmKelompok.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(5).Value
                        frmKelompok.txtUrutanHarga.Text = dgView.SelectedRows.Item(0).Cells(6).Value
                        frmKelompok.txtUrutanHarga2.Text = dgView.SelectedRows.Item(0).Cells(6).Value
                        frmKelompok.chkHideKelompok.Checked = dgView.SelectedRows.Item(0).Cells(7).Value
                        frmKelompok.loadFee()
                    ElseIf pilihanT = "customer" Then
                        frmCustomer.txtKodeKelompok.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmCustomer.cboGrade.SelectedIndex = tInt
                        frmCustomer.txtFee.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                        frmCustomer.txtSPSI.Text = dgView.SelectedRows.Item(0).Cells(4).Value
                    End If
                    Me.Visible = False
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub
End Class