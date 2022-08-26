Public Class frmBukaPembayaranTBScari
    Sub tampilData()
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
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
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

    Private Sub frmBukaPembayaranTBScari_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dgView.Rows.Clear()
    End Sub
    Private Sub frmBukaPembayaranTBScari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCari.SelectedIndex = 0
        dtTglAwal.Value = clsKoneksi.tglAwalBulan(dtTglAwal.Value)
        dtTglAkhir.Value = clsKoneksi.tglAkhirBulan(dtTglAkhir.Value)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        tampilData()
    End Sub


    Private Sub dgView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        frmPembayaranBPT.txtNoBukti.Text = dgView.SelectedCells(0).Value
        frmPembayaranBPT.txtNoAcc.Text = dgView.SelectedCells(2).Value
        frmPembayaranBPT.txtNama.Text = dgView.SelectedCells(3).Value
        frmPembayaranBPT.txtTotal.Text = FormatNumber(dgView.SelectedCells(5).Value)
        frmPembayaranBPT.txtDibayar.Text = FormatNumber(dgView.SelectedCells(7).Value)
        frmPembayaranBPT.txtSisa.Text = FormatNumber(dgView.SelectedCells(8).Value)
        frmPembayaranBPT.txtKodeParam.Text = dgView.SelectedCells(9).Value

        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,Product,Netto,Harga,Total,KodeKota,Keterangan,StatusBayar FROM PembayaranDetail "
        Dim namaKolom As String() = {"Cari", "Kode"}
        Dim isiKolom As Object() = {dgView.SelectedCells(0).Value, dgView.SelectedCells(9).Value}
        myQuery = myQuery & "where KodePembayaran=@Cari and KodeParam=@Kode and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        frmPembayaranBPT.dgvData.Rows.Clear()
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
            frmPembayaranBPT.dgvData.Rows.Add(isiView)
            If isiView(9) = "Y" Then
                frmPembayaranBPT.dgvData.Rows(frmPembayaranBPT.dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
            If isiView(9) = "B" Then
                frmPembayaranBPT.dgvData.Rows(frmPembayaranBPT.dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightPink
            End If
        Next

        'Dim myQuery1 As String = "select IIF(IsNull(Sisa), 0, Sisa) as JumlahTotal,IIF(IsNull(Dibayar), 0, Dibayar) as JumlahBayar from Pembayaran where KodePembayaran='" & dgView.SelectedCells(0).Value & "' and kodekota='" & clsKoneksi.kotaOn & "'"
        'myQuery1 = myQuery1
        'Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, myQuery1)
        'Dim isiView1(1) As Object
        ''isiView(0) = ""
        'For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
        '    For j As Integer = 0 To isiView1.Length - 1
        '        If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
        '            isiView1(j) = ""
        '        Else
        '            isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
        '        End If
        '    Next
        '    frmPembayaranBPT.txtSisa.Text = FormatNumber(isiView1(0))
        '    frmPembayaranBPT.txtDibayar.Text = FormatNumber(isiView1(1))
        'Next
        Me.Close()
    End Sub
End Class