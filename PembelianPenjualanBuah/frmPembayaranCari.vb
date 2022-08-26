Public Class frmPembayaranCari

    Private Sub frmPembayaranCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Sub loadCari()
        Dim myQuery As String = "select KodePembayaran,Tgl,NoAccount,Nama,keterangan,Total,KodeKota,Dibayar,Sisa,KodeParam FROM Pembayaran "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where KodePembayaran"
            Case 1
                myQuery = myQuery & "where NoAccount"
            Case 2
                myQuery = myQuery & "where Nama"
            Case 3
                myQuery = myQuery & "where Keterangan"
            Case 4
                myQuery = myQuery & "where Total"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%' and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery & " and (Tgl>=#" & dtTglAwal.Value.ToString("MM/dd/yyyy") & "#" & " and Tgl<=#" & dtTglAkhir.Value.ToString("MM/dd/yyyy") & "#)"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        dgView.Rows.Clear()
        Dim isiView(9) As Object
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

    Private Sub frmPembayaranCari_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

    Private Sub dgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim myQuery As String = ""
            Dim tDs As DataSet
            Dim spsi As String = "0"
            Dim pph As String = "0"

            'KodePembayaran,Tgl,KodeKelompok,Kelompok,Fee,Keterangan,Total,KodeKota
            frmPembayaran.txtNoPembayaran.Text = dgView.Item(0, e.RowIndex).Value
            frmPembayaran.KodePembayaranTemp = dgView.Item(0, e.RowIndex).Value
            frmPembayaran.txtNoPembayaranlama.Text = dgView.Item(0, e.RowIndex).Value
            frmPembayaran.dtTanggal.Value = dgView.Item(1, e.RowIndex).Value
            frmPembayaran.txtNoAccount.Text = dgView.Item(2, e.RowIndex).Value
            frmPembayaran.txtNama.Text = dgView.Item(3, e.RowIndex).Value
            frmPembayaran.txtKeterangan.Text = dgView.Item(4, e.RowIndex).Value
            frmPembayaran.txtTotal.Text = dgView.Item(5, e.RowIndex).Value
            frmPembayaran.txtTotal2.Text = Format(dgView.Item(5, e.RowIndex).Value, "#,###")
            frmPembayaran.txtTotalLast.Text = Format(dgView.Item(5, e.RowIndex).Value, "#,###")
            frmPembayaran.txtDibayar.Text = FormatNumber(CDbl(dgView.Item(7, e.RowIndex).Value))
            frmPembayaran.txtSisa.Text = FormatNumber(CDbl(dgView.Item(8, e.RowIndex).Value))
            frmPembayaran.txtKodeParam.Text = dgView.Item(9, e.RowIndex).Value
            frmPembayaran.loadDetail()

            'cek spsi dan pph
            myQuery = "select * from pembayaran where KodePembayaran='" & dgView.Item(0, e.RowIndex).Value & "'"
            tDs = clsKoneksi.selectCommand(1, myQuery)
            If tDs.Tables(0).Rows.Count > 0 Then
                pph = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("PPH")), 0, tDs.Tables(0).Rows(0).Item("PPH"))
                spsi = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("SPSI")), 0, tDs.Tables(0).Rows(0).Item("SPSI"))
            End If

            If pph = "1" Then
                frmPembayaran.ckPPH.Checked = True
            Else
                frmPembayaran.ckPPH.Checked = False
            End If

            If spsi = "1" Then
                frmPembayaran.ckSPSI.Checked = True
            Else
                frmPembayaran.ckSPSI.Checked = False
            End If


            frmPembayaran.loadPPH()
            frmPembayaran.loadSPSI()
            'dgView.Rows.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub dgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgView.RowCount > 0 Then
                If dgView.SelectedRows.Item(0).Index >= 0 Then

                    Dim myQuery As String = ""
                    Dim tDs As DataSet
                    Dim spsi As String = "0"
                    Dim pph As String = "0"

                    frmPembayaran.txtNoPembayaran.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmPembayaran.KodePembayaranTemp = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmPembayaran.txtNoPembayaranlama.Text = dgView.SelectedRows.Item(0).Cells(0).Value
                    frmPembayaran.dtTanggal.Value = dgView.SelectedRows.Item(0).Cells(1).Value
                    frmPembayaran.txtNoAccount.Text = dgView.SelectedRows.Item(0).Cells(2).Value
                    frmPembayaran.txtNama.Text = dgView.SelectedRows.Item(0).Cells(3).Value
                    frmPembayaran.txtKeterangan.Text = dgView.SelectedRows.Item(0).Cells(4).Value
                    frmPembayaran.txtTotal.Text = dgView.SelectedRows.Item(0).Cells(5).Value
                    frmPembayaran.txtTotal2.Text = Format(dgView.SelectedRows.Item(0).Cells(5).Value, "#,###")
                    frmPembayaran.txtTotalLast.Text = Format(dgView.SelectedRows.Item(0).Cells(5).Value, "#,###")
                    frmPembayaran.txtDibayar.Text = FormatNumber(CDbl(dgView.SelectedRows.Item(0).Cells(7).Value))
                    frmPembayaran.txtSisa.Text = FormatNumber(CDbl(dgView.SelectedRows.Item(0).Cells(8).Value))
                    frmPembayaran.txtKodeParam.Text = dgView.SelectedRows.Item(0).Cells(9).Value
                    frmPembayaran.loadDetail()

                    'cek spsi dan pph
                    myQuery = "select * from pembayaran where KodePembayaran='" & dgView.SelectedRows.Item(0).Cells(0).Value & "'"
                    tDs = clsKoneksi.selectCommand(1, myQuery)
                    If tDs.Tables(0).Rows.Count > 0 Then
                        pph = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("PPH")), 0, tDs.Tables(0).Rows(0).Item("PPH"))
                        spsi = IIf(IsDBNull(tDs.Tables(0).Rows(0).Item("SPSI")), 0, tDs.Tables(0).Rows(0).Item("SPSI"))
                    End If

                    If pph = "1" Then
                        frmPembayaran.ckPPH.Checked = True
                    Else
                        frmPembayaran.ckPPH.Checked = False
                    End If

                    If spsi = "1" Then
                        frmPembayaran.ckSPSI.Checked = True
                    Else
                        frmPembayaran.ckSPSI.Checked = False
                    End If


                    frmPembayaran.loadPPH()
                    frmPembayaran.loadSPSI()
                    'dgView.Rows.Clear()
                    Me.Visible = False
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class