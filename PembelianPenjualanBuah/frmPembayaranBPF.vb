Public Class frmPembayaranBPF

    Sub hitungBayarSisa()
        Dim myQuery As String = "select Dibayar,Sisa FROM PembayaranFee where KodePembayaran='" & txtPembayaranFee.Text & "' "
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
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
            txtDibayar.Text = FormatNumber(CDbl(isiView(0)))
            txtSisa.Text = FormatNumber(CDbl(isiView(1)))
            frmPembayaranBPFDetail.txtDibayar.Text = FormatNumber(CDbl(isiView(0)))
            frmPembayaranBPFDetail.txtSisa.Text = FormatNumber(CDbl(isiView(1)))

            If frmPembayaranFee.txtNoPembayaran.Text <> "" Then
                If txtPembayaranFee.Text = frmPembayaranFee.txtNoPembayaran.Text Then
                    frmPembayaranFee.txtSisaBayar.Text = FormatNumber(CDbl(isiView(1)))
                    frmPembayaranFee.txtDibayar.Text = FormatNumber(CDbl(isiView(0)))
                End If
            End If


        Next
    End Sub

    Sub tampilData()
        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,KodeProduct,Product,Netto,KodeFee,Fee,Total,KodeKota,StatusBayar FROM PembayaranFeeDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtPembayaranFee.Text}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgvData.Rows.Clear()
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
            dgvData.Rows.Add(isiView)

            If isiView(10) = "Y" Then
                dgvData.Rows(dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub btnCariPembayaranBPF_Click(sender As Object, e As EventArgs) Handles btnCariPembayaranBPF.Click
        frmPembayaranBPFCari.ShowDialog()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        If txtPembayaranFee.Text = "" Then
            MsgBox("Belum ada data terpilih")
            Return
        End If
        frmPembayaranBPFDetail.txtPembayaranFee.Text = txtPembayaranFee.Text
        frmPembayaranBPFDetail.txtKodeKelompok.Text = txtKodeKelompok.Text
        frmPembayaranBPFDetail.txtKelompok.Text = txtKelompok.Text
        frmPembayaranBPFDetail.txtTotal.Text = FormatNumber(CDbl(txtTotal.Text))
        frmPembayaranBPFDetail.txtDibayar.Text = FormatNumber(CDbl(txtDibayar.Text))
        frmPembayaranBPFDetail.txtSisa.Text = FormatNumber(CDbl(txtSisa.Text))
        frmPembayaranBPFDetail.ShowDialog()
    End Sub

    Private Sub frmPembayaranBPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class