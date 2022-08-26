Public Class frmPinjaman

    Sub tampilData()
        Dim myQuery As String = "select P.IDPinjaman,P.kodePinjaman,P.NoAccount,C.Nama,C.KodeKelompok,P.TanggalPinjaman,P.JumlahPinjaman,P.CetakTagihan,P.JumlahLunas,P.SisaPinjaman,P.Keterangan from Pinjaman as P inner join Customer as C on(C.NoAccount=P.NoAccount)"
        Dim intT As Integer = cmbPilih.SelectedIndex
        Select Case intT

            Case 0
                myQuery = myQuery & "Where P.NoAccount like '%" & txtCari.Text & "%' and "
            Case 1
                myQuery = myQuery & "Where C.Nama like '%" & txtCari.Text & "%' and "
            Case 2
                myQuery = myQuery & "Where C.KodeKelompok like '%" & txtCari.Text & "%' and "
        End Select


        myQuery = myQuery & " (datevalue(P.TanggalPinjaman)>=#" & Format(dtpDari.Value, "MM/dd/yyyy") & "#  and datevalue(P.TanggalPinjaman)<=#" & Format(dtpSampai.Value, "MM/dd/yyyy") & "#) and C.KodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
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
        Next
    End Sub

    Private Sub frmPinjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = Date.Now
        dtpSampai.Value = Date.Now
        cmbPilih.SelectedIndex = 0
    End Sub

    Private Sub btnTambahData_Click(sender As Object, e As EventArgs) Handles btnTambahData.Click
        frmInputPinjaman.ShowDialog()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        tampilData()
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Dim i As Integer = dgvData.CurrentRow.Index
        frmInputPinjaman.edit = True
        frmInputPinjaman.idEdit = dgvData.Item(1, i).Value
        frmInputPinjaman.jumlahPinjaman = dgvData.Item(6, i).Value
        frmInputPinjaman.sisaPinjaman = dgvData.Item(9, i).Value
        frmInputPinjaman.txtCustomer.Text = dgvData.Item(3, i).Value
        frmInputPinjaman.dtpTanggal.Value = dgvData.Item(5, i).Value
        frmInputPinjaman.txtJumlah.Text = dgvData.Item(6, i).Value
        frmInputPinjaman.txtKeterangan.Text = dgvData.Item(10, i).Value

        frmInputPinjaman.ShowDialog()
    End Sub


    Private Sub dgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvData.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(1)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuTagihanSPSI_Click(sender As Object, e As EventArgs) Handles mnuTagihanSPSI.Click
        Dim i As Integer = dgvData.CurrentRow.Index
        frmPinjamanTagihan.txtKodePinjaman.Text = dgvData.Item(1, i).Value
        frmPinjamanTagihan.txtNoAccount.Text = dgvData.Item(2, i).Value
        frmPinjamanTagihan.txtNama.Text = dgvData.Item(3, i).Value
        frmPinjamanTagihan.txtSisaPinjaman.Text = FormatNumber(dgvData.Item(9, i).Value)
        frmPinjamanTagihan.txtJumlahPinjaman.Text = FormatNumber(dgvData.Item(6, i).Value)
        frmPinjamanTagihan.txtTotalTagihan.Text = FormatNumber(dgvData.Item(7, i).Value)
        frmPinjamanTagihan.txtJumlahLunas.Text = FormatNumber(dgvData.Item(8, i).Value)

        frmPinjamanTagihan.ShowDialog()
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus pinjaman ini?", vbQuestion + vbYesNo) = vbYes Then

            Dim myQuery As String = "delete from PinjamanTagihan where kodePinjaman=@kodePinjaman"
            Dim namaKolom As String() = {"kodePinjaman"}
            Dim isiKolom As Object() = {dgvData.SelectedCells(1).Value}
            clsKoneksi.deleteCommand(1, myQuery, namaKolom, isiKolom, 1)

            Dim myQuery2 As String = "delete from Pinjaman where kodePinjaman=@kodePinjaman"
            Dim namaKolom2 As String() = {"kodePinjaman"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(1).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)

            MsgBox("Data berhasil dihapus")
            tampilData()

        End If

      
    End Sub
End Class