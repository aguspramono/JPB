Public Class frmPembayaranBPT

    Sub bersih()
        txtNoBukti.Clear()
        txtNama.Clear()
        txtNoAcc.Clear()
        txtTotal.Clear()
        txtKodeParam.Text = 0
        dgvData.Rows.Clear()
    End Sub

    Sub tampilData()
        Dim myQuery As String = "select KodePembayaran,NoTicket,Tgl,Product,Netto,Harga,Total,KodeKota,Keterangan,StatusBayar FROM PembayaranDetail "
        Dim namaKolom As String() = {"Cari", "KodeParam"}
        Dim isiKolom As Object() = {txtNoBukti.Text, CDbl(txtKodeParam.Text)}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and KodeParam=@KodeParam and kodekota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgvData.Rows.Clear()
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
            dgvData.Rows.Add(isiView)

            If isiView(9) = "Y" Then
                dgvData.Rows(dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If

            If isiView(9) = "B" Then
                dgvData.Rows(dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightPink
            End If
        Next
    End Sub


    Private Sub btnCariBukaPembayaran_Click(sender As Object, e As EventArgs) Handles btnCariBukaPembayaran.Click
        frmBukaPembayaranTBScari.ShowDialog()
    End Sub

    Private Sub frmPembayaranBPT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bersih()
    End Sub

    Private Sub mnuPembayaran_Click(sender As Object, e As EventArgs)
        Dim i As Integer = dgvData.CurrentRow.Index
        frmInputPembayaranBPT.txtNoTicket.Text = dgvData.Item(0, i).Value
        frmInputPembayaranBPT.txtProduct.Text = dgvData.Item(2, i).Value
        frmInputPembayaranBPT.txtTotal.Text = FormatNumber(CDbl(dgvData.Item(5, i).Value))
        frmInputPembayaranBPT.txtSisaBayar.Text = FormatNumber(CDbl(dgvData.Item(7, i).Value))
        frmInputPembayaranBPT.txtDibayar.Text = FormatNumber(CDbl(dgvData.Item(6, i).Value))
        frmInputPembayaranBPT.noBukti = txtNoBukti.Text
        frmInputPembayaranBPT.ShowDialog()
    End Sub

    Private Sub btnLakukanPembayaran_Click(sender As Object, e As EventArgs) Handles btnLakukanPembayaran.Click
        If txtNoBukti.Text = "" Then
            MsgBox("Belum ada data terpilih")
            Return
        End If
        frmPembayaranBPTDetail.txtNoBukti.Text = txtNoBukti.Text
        frmPembayaranBPTDetail.txtNoAcc.Text = txtNoAcc.Text
        frmPembayaranBPTDetail.txtNama.Text = txtNama.Text
        frmPembayaranBPTDetail.txtTotal.Text = FormatNumber(CDbl(txtTotal.Text))
        frmPembayaranBPTDetail.txtTotal.Text = FormatNumber(CDbl(txtTotal.Text))
        frmPembayaranBPTDetail.txtDibayar.Text = FormatNumber(CDbl(txtDibayar.Text))
        frmPembayaranBPTDetail.txtSisa.Text = FormatNumber(CDbl(txtSisa.Text))
        frmPembayaranBPTDetail.txtKodeParam.Text = txtKodeParam.Text
        frmPembayaranBPTDetail.ShowDialog()
    End Sub

    Private Sub frmPembayaranBPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub


    Private Sub dgvData_SelectionChanged(sender As Object, e As EventArgs) Handles dgvData.SelectionChanged
        lblJumlahNetto.Text = Format(CDbl((From row As DataGridViewRow In dgvData.Rows.Cast(Of DataGridViewRow)() _
              Where row.Cells(4).Selected = True _
              Select Convert.ToDouble(row.Cells(4).Value)).Sum.ToString), "N2")
    End Sub
End Class