Public Class frmCustomerCari
    Public pilihan As String

    Private Sub frmCustomerCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub loadCari()
        If cmbCari.SelectedIndex = 10 Then
            If chkCheck.Checked Then
                txtCari.Text = "Y"
            Else
                txtCari.Text = "N"
            End If
        End If

        Dim myQuery As String = "select NoAccount,Nama,Telp,Alamat,Grade,Kota,Keterangan,KodeKelompok,SPSI,Fee,KodeKota,PPN,PPH,bosTemp from customer "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}
        'NoAccount
        'Nama
        'Telp
        'Alamat
        'Grade
        'Kota
        'Keterangan
        'KodeKelompok
        'SPSI
        'Fee
        'KodeKota
        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where NoAccount"
            Case 1
                myQuery = myQuery & "where Nama"
            Case 2
                myQuery = myQuery & "where Telp"
            Case 3
                myQuery = myQuery & "where Alamat"
            Case 4
                myQuery = myQuery & "where Grade"
            Case 5
                myQuery = myQuery & "where Kota"
            Case 6
                myQuery = myQuery & "where Keterangan"
            Case 7
                myQuery = myQuery & "where KodeKelompok"
            Case 8
                myQuery = myQuery & "where SPSI"
            Case 9
                myQuery = myQuery & "where Fee"
            Case 10
                myQuery = myQuery & "where PPN"
            Case 11
                myQuery = myQuery & "where PPH"
        End Select
        If intT = 10 Then
            txtCari.Text = ""
        End If
        myQuery = myQuery & " LIKE '%' + @Cari + '%' and KodeKota='" & clsKoneksi.kotaOn & "' order by len(noaccount),noaccount"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
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

                If j = 11 Then
                    If tDs.Tables(0).Rows(i).Item(j) = "Y" Then
                        isiView(j) = True
                    Else
                        isiView(j) = False
                    End If
                End If

                If j = 13 Then
                    If tDs.Tables(0).Rows(i).Item(j) = "Y" Then
                        isiView(j) = True
                    Else
                        isiView(j) = False
                    End If
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

    Private Sub frmCustomerCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cmbCari.SelectedIndex = 0
        chkCheck.Visible = False
        txtCari.Visible = True
    End Sub

    Private Sub cmbCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadCari()
        End If
    End Sub

    Private Sub cmbCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCari.SelectedIndexChanged
        If cmbCari.SelectedIndex = 10 Then
            chkCheck.Visible = True
            txtCari.Visible = False
        Else
            chkCheck.Visible = False
            txtCari.Visible = True
        End If
    End Sub

    Private Sub dgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim tInt As Integer = 2
            Select Case dgView.Item(4, e.RowIndex).Value
                Case "A"
                    tInt = 0
                Case "B"
                    tInt = 1
                Case "C"
                    tInt = 2
                Case "P"
                    tInt = 3
            End Select

            If pilihan = "cariAcc" Then
                'NoAccount      0
                'Nama           1
                'Telp           2
                'Alamat         3
                'Grade          4
                'Kota           5
                'Keterangan     6
                'KodeKelompok   7
                'SPSI           8
                'Fee            9
                'KodeKota       10

                frmCustomer.txtNoAcc.Text = dgView.Item(0, e.RowIndex).Value
                frmCustomer.txtNoAccLama.Text = dgView.Item(0, e.RowIndex).Value
                frmCustomer.txtNama.Text = dgView.Item(1, e.RowIndex).Value
                frmCustomer.txtNotelp.Text = dgView.Item(2, e.RowIndex).Value
                frmCustomer.txtAlamat.Text = dgView.Item(3, e.RowIndex).Value
                frmCustomer.cboGrade.SelectedIndex = tInt
                frmCustomer.txtKota.Text = dgView.Item(5, e.RowIndex).Value
                frmCustomer.txtKeterangan.Text = dgView.Item(6, e.RowIndex).Value
                frmCustomer.txtKodeKelompok.Text = dgView.Item(7, e.RowIndex).Value
                frmCustomer.txtSPSI.Text = dgView.Item(8, e.RowIndex).Value
                frmCustomer.txtFee.Text = dgView.Item(9, e.RowIndex).Value
                frmCustomer.lblFee.Text = dgView.Item(9, e.RowIndex).Value
                frmCustomer.chkPPN.Checked = dgView.Item(11, e.RowIndex).Value
                frmCustomer.txtPPH.Text = dgView.Item(12, e.RowIndex).Value

                If dgView.Item(13, e.RowIndex).Value = True Then
                    frmCustomer.ckGradeA.Checked = True
                Else
                    frmCustomer.ckGradeA.Checked = False
                End If

            ElseIf pilihan = "cariKepala" Then
                frmCustomer.txtKodeKelompok.Text = dgView.Item(0, e.RowIndex).Value
            ElseIf pilihan = "cariCustomerKomplain" Then
                frmCustomerKomplain.txtNoAccountKomplain.Text = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "cariNamaBos" Then
                frmSettingNamaBos.txtCustomer.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmSettingNamaBos.lblID.Text = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "kelompokplat" Then
                frmCustomerBerdasarkanPlat.lblAccount.Text = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "kelompoktbs" Then
                frmCustomerBerdasarkanTBS.txtCustomer.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmCustomerBerdasarkanTBS.lblAccount.Text = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "pengecualianbb" Then
                frmBBPengecualian.txtCustomer.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmBBPengecualian.lblNoAccount.Text = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "pjml" Then
                frmPjmldanSejenisnya.txtCust.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmPjmldanSejenisnya.lblNoAcc.Text = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "atmp" Then
                frmAtmpdanSejenisnya.txtCust.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmAtmpdanSejenisnya.lblNoAccount.Text = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "SPSIJumlah" Then
                frmInputSettingSPSIJumlahSPSI.txtCustomer.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmInputSettingSPSIJumlahSPSI.noAccount = dgView.SelectedRows.Item(0).Cells(0).Value
            ElseIf pilihan = "SPSIDikalinetto" Then


                Dim isiView(1) As Object
                isiView(0) = dgView.SelectedCells(0).Value
                isiView(1) = dgView.SelectedCells(1).Value
                frmInputSPSIDikaliNetto.dgvData.Rows.Add(isiView)

                MsgBox("Customer telah dipilih")

            ElseIf pilihan = "LaporanHutangPembantu" Then
                frmLaporanHutangPembantu.noAccount = dgView.SelectedRows.Item(0).Cells(0).Value
                frmLaporanHutangPembantu.txtCustomer.Text = dgView.SelectedRows.Item(0).Cells(1).Value

            ElseIf pilihan = "Pinjaman" Then
                frmInputPinjaman.noAccount = dgView.SelectedRows.Item(0).Cells(0).Value
                frmInputPinjaman.txtCustomer.Text = dgView.SelectedRows.Item(0).Cells(1).Value
            ElseIf pilihan = "hargaBrondolan" Then
                frmInputHargaBrondolan.noAcc = dgView.SelectedRows.Item(0).Cells(0).Value
                frmInputHargaBrondolan.txtCustomer.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                frmInputHargaBrondolan.txtKelompok.Text = dgView.SelectedRows.Item(0).Cells(7).Value
            ElseIf pilihan = "marsada" Then
                frmSettingMarsada.noAcc = dgView.SelectedRows.Item(0).Cells(0).Value
                frmSettingMarsada.txtNoAcc.Text = dgView.SelectedRows.Item(0).Cells(1).Value

            ElseIf pilihan = "multiedit" Then
                frmMultipleEditPotongan.noAcc = dgView.SelectedRows.Item(0).Cells(0).Value
                frmMultipleEditPotongan.txtCust.Text = dgView.SelectedRows.Item(0).Cells(1).Value
            End If

            If pilihan <> "SPSIDikalinetto" Then
                Me.Close()
            End If

        End If

    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    Dim tInt As Integer = 2
                    Select Case dgView.SelectedRows.Item(0).Cells(4).Value
                        Case "A"
                            tInt = 0
                        Case "B"
                            tInt = 1
                        Case "C"
                            tInt = 2
                        Case "P"
                            tInt = 3
                    End Select
                    If pilihan = "cariAcc" Then
                        frmCustomer.txtNoAcc.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmCustomer.txtNoAccLama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                        frmCustomer.txtNama.Text = dgView.SelectedRows.Item(0).Cells(1).Value
                        frmCustomer.txtNotelp.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                        frmCustomer.txtAlamat.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                        frmCustomer.cboGrade.SelectedIndex = tInt
                        frmCustomer.txtKota.Text = dgView.SelectedRows.Item(0).Cells(5).Value
                        frmCustomer.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(6).Value
                        frmCustomer.txtKodeKelompok.Text = dgView.SelectedRows.Item(0).Cells(7).Value
                        frmCustomer.txtSPSI.Text = dgView.SelectedRows.Item(0).Cells(8).Value
                        frmCustomer.txtFee.Text = dgView.SelectedRows.Item(0).Cells(9).Value
                        frmCustomer.chkPPN.Checked = dgView.SelectedRows.Item(0).Cells(11).Value
                        frmCustomer.txtPPH.Text = dgView.SelectedRows.Item(0).Cells(12).Value

                        If dgView.SelectedRows.Item(0).Cells(13).Value = True Then
                            frmCustomer.ckGradeA.Checked = True
                        Else
                            frmCustomer.ckGradeA.Checked = False
                        End If


                    ElseIf pilihan = "cariKepala" Then
                        frmCustomer.txtKodeKelompok.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    ElseIf pilihan = "cariCustomerKomplain" Then
                        frmCustomerKomplain.txtNoAccountKomplain.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    End If
                    Me.Visible = False
                    Me.Close()
                End If
            End If

        End If
    End Sub
End Class