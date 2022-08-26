Public Class frmSPSI

    Sub loadData()
        Dim whereOption As String = ""

        If cmbPilih.SelectedIndex = 0 Then
            whereOption = " and NoAcc like '%" & txtCari.Text & "%' and KodeKota='" & clsKoneksi.kotaOn & "' "
        ElseIf cmbPilih.SelectedIndex = 1 Then
            whereOption = " and NoBukti like '%" & txtCari.Text & "%' and KodeKota='" & clsKoneksi.kotaOn & "'"
        ElseIf cmbPilih.SelectedIndex = 2 Then
            whereOption = " and Nama like '%" & txtCari.Text & "%' and KodeKota='" & clsKoneksi.kotaOn & "' "
        ElseIf cmbPilih.SelectedIndex = 3 Then
            whereOption = " and SPSI like '%" & txtCari.Text & "%' and KodeKota='" & clsKoneksi.kotaOn & "' "
        End If


        Dim myQuery As String = "select * from SpsiPenjumlahan where (datevalue(Tanggal)>=#" & Format(dtpDari.Value, "MM/dd/yyyy") & "# and datevalue(Tanggal)<=#" & Format(dtpSampai.Value, "MM/dd/yyyy") & "#) " & whereOption & ""
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(7) As Object
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
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        'frmInputJumlahSPSI.modeEdit = False
        frmInputMultiJumlahSPSI.ShowDialog()
    End Sub

    Private Sub frmSPSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = Date.Now
        dtpSampai.Value = Date.Now
        cmbPilih.SelectedIndex = 0
        loadData()
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

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from SpsiPenjumlahan where idSpsiPenjumlahan=@idSpsiPenjumlahan"
            Dim namaKolom2 As String() = {"idSpsiPenjumlahan"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            loadData()
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        loadData()
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        frmInputJumlahSPSI.modeEdit = True
        frmInputJumlahSPSI.idEdit = dgvData.SelectedCells(0).Value
        frmInputJumlahSPSI.dtpTanggal.Value = dgvData.SelectedCells(1).Value
        frmInputJumlahSPSI.txtNoAcc.Text = dgvData.SelectedCells(2).Value
        frmInputJumlahSPSI.txtNoBukti.Text = dgvData.SelectedCells(3).Value
        frmInputJumlahSPSI.txtNama.Text = dgvData.SelectedCells(4).Value
        frmInputJumlahSPSI.txtSPSI.Text = dgvData.SelectedCells(5).Value
        frmInputJumlahSPSI.txtKeterangan.Text = dgvData.SelectedCells(6).Value
        frmInputJumlahSPSI.txtNilai.Text = dgvData.SelectedCells(7).Value

        frmInputJumlahSPSI.ShowDialog()
    End Sub

    Private Sub btnBuatTagihanSPSI_Click(sender As Object, e As EventArgs) Handles btnBuatTagihanSPSI.Click
        frmSettingSPSI.ShowDialog()
    End Sub
End Class