Public Class frmInputPembayaranBPT
    Public noBukti As String = ""
    Sub tampilData()
        Dim myQuery As String = "select * FROM PembayaranNoTicket "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtNoTicket.Text}
        myQuery = myQuery & "where NoTicket"
        myQuery = myQuery & " =@Cari"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgvData.Rows.Clear()
        Dim isiView(3) As Object
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
        Next
    End Sub

    Sub tampilDetailPembayaran()
        Dim myQuery As String = "select NoTicket,Tgl,Product,Netto,Harga,Total,Dibayar,SisaBayar,Keterangan,KodeKota FROM PembayaranDetail "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {noBukti}
        myQuery = myQuery & "where KodePembayaran"
        myQuery = myQuery & " =@Cari and kodekota='" & clsKoneksi.kotaOn & "'"
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

            If isiView(8) = "Lunas" Then
                frmPembayaranBPT.dgvData.Rows(frmPembayaranBPT.dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Sub tampilSisaBayar()
        Dim myQuery1 As String = "select IIF(IsNull(SUM(SisaBayar)), 0, SUM(SisaBayar)) as JumlahTotal,IIF(IsNull(SUM(Dibayar)), 0, SUM(Dibayar)) as JumlahBayar from PembayaranDetail where KodePembayaran='" & noBukti & "' and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery1 = myQuery1
        Dim tDs1 As DataSet = clsKoneksi.selectCommand(1, myQuery1)
        Dim isiView1(1) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            frmPembayaranBPT.txtSisa.Text = FormatNumber(isiView1(0))
            frmPembayaranBPT.txtDibayar.Text = FormatNumber(isiView1(1))
        Next
    End Sub

    Private Sub btnTambahData_Click(sender As Object, e As EventArgs) Handles btnTambahData.Click
        frmInputPembayaranNoTicket.noBuktiTicket = noBukti
        frmInputPembayaranNoTicket.ShowDialog()
    End Sub

    Private Sub frmInputPembayaranBPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub dgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvData.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(2)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Dim i As Integer = dgvData.CurrentRow.Index
        frmInputPembayaranNoTicket.edit = True
        frmInputPembayaranNoTicket.idEdit = dgvData.Item(0, i).Value
        frmInputPembayaranNoTicket.noTicket = txtNoTicket.Text
        frmInputPembayaranNoTicket.noBuktiTicket = noBukti
        frmInputPembayaranNoTicket.total = txtTotal.Text
        frmInputPembayaranNoTicket.dibayar = txtDibayar.Text
        frmInputPembayaranNoTicket.sisaBayar = txtSisaBayar.Text

        frmInputPembayaranNoTicket.dtpTanggal.Value = dgvData.Item(2, i).Value
        frmInputPembayaranNoTicket.txtJumlah.Text = dgvData.Item(3, i).Value
        frmInputPembayaranNoTicket.jumlahLama = dgvData.Item(3, i).Value
        frmInputPembayaranNoTicket.ShowDialog()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then
            Dim keterangan As String = ""
            If CDbl(txtSisaBayar.Text) = 0 Then
                keterangan = ""
                Dim myQuery7 As String = "UPDATE Pembelian Set "
                Dim myQuery8 As String = "UPDATE Pembelian2 Set "
                Dim namaKolom7 As String() = {"BukaPembayaran"}
                Dim isiKolom7 As Object() = {"N"}

                Dim kondisiWhere As String = " where NoTicket =@NoTicket"
                Dim namaKolom8 As String() = {"NoTicket"}
                Dim isiKolom8 As Object() = {txtNoTicket.Text}
                clsKoneksi.updateCommand(1, myQuery7, namaKolom7, isiKolom7, kondisiWhere, namaKolom8, isiKolom8, 1)
                clsKoneksi.updateCommand(1, myQuery8, namaKolom7, isiKolom7, kondisiWhere, namaKolom8, isiKolom8, 1)
            End If


            txtSisaBayar.Text = FormatNumber(CDbl(txtSisaBayar.Text) + CDbl(dgvData.SelectedCells(3).Value))
            txtDibayar.Text = FormatNumber(CDbl(txtDibayar.Text) - CDbl(dgvData.SelectedCells(3).Value))

            Dim myQuery5 As String = "UPDATE PembayaranDetail Set "
            Dim namaKolom5 As String() = {"Dibayar", "SisaBayar", "keterangan"}
            Dim isiKolom5 As Object() = {CDbl(txtDibayar.Text), CDbl(txtSisaBayar.Text), keterangan}

            Dim kondisiWhere2 As String = " where NoTicket =@NoTicket"
            Dim namaKolom6 As String() = {"NoTicket"}
            Dim isiKolom6 As Object() = {txtNoTicket.Text}
            clsKoneksi.updateCommand(1, myQuery5, namaKolom5, isiKolom5, kondisiWhere2, namaKolom6, isiKolom6, 1)

            Dim myQuery As String = "delete from PembayaranNoTicket where IDPembayaranBPT=@IDPembayaranBPT"
            Dim namaKolom As String() = {"IDPembayaranBPT"}
            Dim isiKolom As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery, namaKolom, isiKolom, 1)


            MsgBox("Data Berhasil Dihapus")
            tampilData()

            tampilDetailPembayaran()
            tampilSisaBayar()

        End If
    End Sub
End Class