Public Class frmPembayaranBPFCari
    Sub loadCari()
        Dim myQuery As String = "select KodePembayaran,Tgl,KodeKelompok,Kelompok,Fee,Keterangan,Total,KodeFee,KodeKota,Dibayar,Sisa FROM PembayaranFee "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbCari.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where KodePembayaran"
            Case 1
                myQuery = myQuery & "where KodeKelompok"
            Case 2
                myQuery = myQuery & "where Kelompok"
            Case 3
                myQuery = myQuery & "where Fee"
            Case 4
                myQuery = myQuery & "where Keterangan"
            Case 5
                myQuery = myQuery & "where Total"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%' and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery & " and (Tgl>=#" & dtTglAwal.Value.ToString("MM/dd/yyyy") & "#" & " and Tgl<=#" & dtTglAkhir.Value.ToString("MM/dd/yyyy") & "#)"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
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

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        loadCari()
    End Sub

    Private Sub frmPembayaranBPFCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCari.SelectedIndex = 0
        dtTglAwal.Value = clsKoneksi.tglAwalBulan(Now)
        dtTglAkhir.Value = clsKoneksi.tglAkhirBulan(Now)
    End Sub


    Private Sub dgView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        Dim k As Integer = dgView.CurrentRow.Index
        frmPembayaranBPF.txtPembayaranFee.Text = dgView.Item(0, k).Value
        frmPembayaranBPF.txtKodeKelompok.Text = dgView.Item(2, k).Value
        frmPembayaranBPF.txtKelompok.Text = dgView.Item(3, k).Value
        frmPembayaranBPF.txtTotal.Text = FormatNumber(CDbl(dgView.Item(6, k).Value))
        frmPembayaranBPF.txtDibayar.Text = FormatNumber(CDbl(dgView.Item(9, k).Value))
        frmPembayaranBPF.txtSisa.Text = FormatNumber(CDbl(dgView.Item(10, k).Value))

        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,KodeFee,Fee,Total,KodeKota,StatusBayar FROM PembayaranFeeDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {dgView.Item(0, k).Value}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and kodekota='" & clsKoneksi.kotaOn & "' order by KodeFee"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        frmPembayaranBPF.dgvData.Rows.Clear()
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
            frmPembayaranBPF.dgvData.Rows.Add(isiView)

            If isiView(10) = "Y" Then
                frmPembayaranBPF.dgvData.Rows(frmPembayaranBPF.dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
        Me.Close()
    End Sub
End Class