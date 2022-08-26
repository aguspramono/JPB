Public Class frmInvoiceCari

    Private Sub frmInvoiceCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub loadCari()
        Dim myQuery As String = "select*from Invoice "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where NoInvoice"
            Case 1
                myQuery = myQuery & "where KodePembayaran"
            Case 2
                myQuery = myQuery & "where NoAccount"
            Case 3
                myQuery = myQuery & "where Nama"
            Case 4
                myQuery = myQuery & "where Keterangan"
            Case 5
                myQuery = myQuery & "where TotalHarusDiBayar"
            Case 6
                myQuery = myQuery & "where TotalSudahDiBayar"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%' and kodekota='" & clsKoneksi.kotaOn & "'"
        If chkSisa.Checked Then
            myQuery = myQuery & " and sisa<>0 "
        End If
        myQuery = myQuery & " and (Tgl>=#" & dtTglAwal.Value.ToString("MM/dd/yyyy") & "#" & " and Tgl<=#" & dtTglAkhir.Value.ToString("MM/dd/yyyy") & "#)"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(10) As Object
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

    Private Sub frmInvoiceCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
            frmInvoice.txtNoInvoice.Text = dgView.Item(0, e.RowIndex).Value
            frmInvoice.txtNoInvoiceLama.Text = dgView.Item(0, e.RowIndex).Value
            frmInvoice.dtTanggal.Value = dgView.Item(1, e.RowIndex).Value
            frmInvoice.txtNoPembayaran.Text = dgView.Item(2, e.RowIndex).Value
            frmInvoice.txtNoAccount.Text = dgView.Item(3, e.RowIndex).Value
            frmInvoice.txtNama.Text = dgView.Item(4, e.RowIndex).Value
            frmInvoice.txtKeterangan.Text = dgView.Item(5, e.RowIndex).Value
            frmInvoice.txtTotal2.Text = Format(dgView.Item(7, e.RowIndex).Value, "#,###")
            frmInvoice.txtTotal2.Text = Format(dgView.Item(7, e.RowIndex).Value, "N")
            frmInvoice.txtTotal.Text = dgView.Item(7, e.RowIndex).Value
            frmInvoice.txtTipe.Text = dgView.Item(9, e.RowIndex).Value
            



            'cekPembayaranPerubahan
            Dim cekTambahan As Double = 0
            Dim cekSebelumTambahan As Double = dgView.Item(7, e.RowIndex).Value
            Dim harusBayar As Double = dgView.Item(6, e.RowIndex).Value
            Dim myQuery As String = "select IIF(IsNull(sum(Total)),0,sum(Total)) from PembayaranDetail "
            Dim namaKolom As String() = {"Cari"}
            Dim isiKolom As Object() = {dgView.Item(2, e.RowIndex).Value}

            myQuery = myQuery & "Where KodePembayaran='' + @Cari + ''"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            dgView.Rows.Clear()
            Dim isiView(0) As Object
            'isiView(0) = ""
            For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                For j As Integer = 0 To isiView.Length - 1
                    If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                        isiView(j) = ""
                    Else
                        isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                    End If
                Next
                cekTambahan = isiView(0)
            Next

            If cekTambahan = 0 Then
                cekTambahan = harusBayar
            End If


            frmInvoice.txtTotalH2.Text = Format(cekTambahan, "#,###")
            frmInvoice.txtTotalH2.Text = Format(cekTambahan, "N")
            frmInvoice.txtTotalH.Text = CDec(cekTambahan)

            frmInvoice.txtTotalS2.Text = Format(cekTambahan - cekSebelumTambahan, "#,###")
            frmInvoice.txtTotalS2.Text = Format(cekTambahan - cekSebelumTambahan, "N")
            frmInvoice.txtTotalS.Text = CDec(cekTambahan - cekSebelumTambahan)



            frmInvoice.loadDetail()
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then
                    frmInvoice.txtNoInvoice.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmInvoice.txtNoInvoiceLama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmInvoice.dtTanggal.Value = dgView.SelectedRows.Item(0).Cells(1).Value
                    frmInvoice.txtNoPembayaran.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                    frmInvoice.txtNoAccount.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                    frmInvoice.txtNama.Text = dgView.SelectedRows.Item(0).Cells(4).Value
                    frmInvoice.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(5).Value

                    frmInvoice.txtTotal2.Text = Format(dgView.SelectedRows.Item(0).Cells(7).Value, "#,###")
                    frmInvoice.txtTotal2.Text = Format(dgView.SelectedRows.Item(0).Cells(7).Value, "N")
                    frmInvoice.txtTotal.Text = dgView.SelectedRows.Item(0).Cells(7).Value
                    frmInvoice.txtTipe.Text = dgView.SelectedRows.Item(0).Cells(9).Value

                    'cekPembayaranPerubahan
                    Dim cekTambahan As Double = 0
                    Dim cekSebelumTambahan As Double = dgView.SelectedRows.Item(0).Cells(7).Value
                    Dim harusBayar As Double = dgView.SelectedRows.Item(0).Cells(6).Value
                    Dim myQuery As String = "select IIF(IsNull(sum(Total)),0,sum(Total)) from PembayaranDetail "
                    Dim namaKolom As String() = {"Cari"}
                    Dim isiKolom As Object() = {dgView.SelectedRows.Item(0).Cells(2).Value}

                    myQuery = myQuery & "Where KodePembayaran='' + @Cari + ''"
                    Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
                    dgView.Rows.Clear()
                    Dim isiView(0) As Object
                    'isiView(0) = ""
                    For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                        For j As Integer = 0 To isiView.Length - 1
                            If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                                isiView(j) = ""
                            Else
                                isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                            End If
                        Next
                        cekTambahan = isiView(0)
                    Next

                    If cekTambahan = 0 Then
                        cekTambahan = harusBayar
                    End If


                    frmInvoice.txtTotalH2.Text = Format(cekTambahan, "#,###")
                    frmInvoice.txtTotalH2.Text = Format(cekTambahan, "N")
                    frmInvoice.txtTotalH.Text = CDec(cekTambahan)

                    frmInvoice.txtTotalS2.Text = Format(cekTambahan - cekSebelumTambahan, "#,###")
                    frmInvoice.txtTotalS2.Text = Format(cekTambahan - cekSebelumTambahan, "N")
                    frmInvoice.txtTotalS.Text = CDec(cekTambahan - cekSebelumTambahan)


                    frmInvoice.loadDetail()
                    Me.Visible = False
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class