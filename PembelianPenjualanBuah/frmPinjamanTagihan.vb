Public Class frmPinjamanTagihan

    Sub tampilData()
        Dim myQuery As String = "select IDPinjamanTagihan, TanggalPinjamanTagihan, JumlahPinjamanTagihan,Keterangan,Status from PinjamanTagihan where kodePinjaman='" & txtKodePinjaman.Text & "'"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(4) As Object
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

            If isiView(4) = "Y" Then
                dgvData.Rows(dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub btnTambahData_Click(sender As Object, e As EventArgs) Handles btnTambahData.Click
        frmInputPinjamanTagihan.kodePinjaman = txtKodePinjaman.Text
        frmInputPinjamanTagihan.ShowDialog()
    End Sub

    Private Sub frmPinjamanTagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
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

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Dim i As Integer = dgvData.CurrentRow.Index

        frmInputPinjamanTagihan.edit = True
        frmInputPinjamanTagihan.kodePinjaman = txtKodePinjaman.Text
        frmInputPinjamanTagihan.idEdit = dgvData.Item(0, i).Value
        frmInputPinjamanTagihan.dtpTanggal.Value = dgvData.Item(1, i).Value
        frmInputPinjamanTagihan.txtJumlah.Text = dgvData.Item(2, i).Value

        If dgvData.Item(4, i).Value = "Y" Then
            frmInputPinjamanTagihan.ckDefault.Checked = True
        Else
            frmInputPinjamanTagihan.ckDefault.Checked = False
        End If

        frmInputPinjamanTagihan.ShowDialog()

    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        Dim sisaPinjaman As Double = 0
        Dim cetakTagihan As Double = 0
        Dim lunas As Double = 0
        If MsgBox("Apakah anda yakin ingin menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then
            sisaPinjaman = CDbl(txtSisaPinjaman.Text) + CDbl(dgvData.SelectedCells(2).Value)
            cetakTagihan = CDbl(txtTotalTagihan.Text) - CDbl(dgvData.SelectedCells(2).Value)

            If dgvData.SelectedCells(3).Value = "Lunas" Then
                lunas = CDbl(txtJumlahLunas.Text) - CDbl(dgvData.SelectedCells(2).Value)
            End If

            txtJumlahLunas.Text = FormatNumber(lunas)
            txtSisaPinjaman.Text = FormatNumber(sisaPinjaman)
            txtTotalTagihan.Text = FormatNumber(cetakTagihan)


            Dim myQuery7 As String = "UPDATE Pinjaman Set "
            Dim namaKolom7 As String() = {"CetakTagihan", "jumlahLunas", "SisaPinjaman"}
            Dim isiKolom7 As Object() = {CDbl(cetakTagihan), CDbl(lunas), CDbl(sisaPinjaman)}

            Dim kondisiWhere3 As String = " where KodePinjaman =@KodePinjaman"
            Dim namaKolom8 As String() = {"KodePinjaman"}
            Dim isiKolom8 As Object() = {txtKodePinjaman.Text}
            clsKoneksi.updateCommand(1, myQuery7, namaKolom7, isiKolom7, kondisiWhere3, namaKolom8, isiKolom8, 1)


            Dim myQuery2 As String = "delete from PinjamanTagihan where IDPinjamanTagihan=@IDPinjamanTagihan"
            Dim namaKolom2 As String() = {"IDPinjamanTagihan"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)

            frmPinjaman.tampilData()
            MsgBox("Data berhasil dihapus")
            tampilData()


        End If
    End Sub

    Private Sub mnuDefault_Click(sender As Object, e As EventArgs) Handles mnuDefault.Click
        If MsgBox("Apakah anda yakin ingin menjadikan default?", vbQuestion + vbYesNo) = vbYes Then

            Dim myQuery5 As String = "UPDATE PinjamanTagihan Set "
            Dim namaKolom5 As String() = {"Status"}
            Dim isiKolom5 As Object() = {"N"}

            Dim kondisiWhere As String = " where KodePinjaman =@KodePinjaman"
            Dim namaKolom6 As String() = {"KodePinjaman"}
            Dim isiKolom6 As Object() = {txtKodePinjaman.Text}
            clsKoneksi.updateCommand(1, myQuery5, namaKolom5, isiKolom5, kondisiWhere, namaKolom6, isiKolom6, 1)


            Dim myQuery7 As String = "UPDATE PinjamanTagihan Set "
            Dim namaKolom7 As String() = {"Status"}
            Dim isiKolom7 As Object() = {"Y"}

            Dim kondisiWhere3 As String = " where IDPinjamanTagihan =@IDPinjamanTagihan"
            Dim namaKolom8 As String() = {"IDPinjamanTagihan"}
            Dim isiKolom8 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.updateCommand(1, myQuery7, namaKolom7, isiKolom7, kondisiWhere3, namaKolom8, isiKolom8, 1)

            MsgBox("Data berhasil default")
            tampilData()

        End If
    End Sub

    Private Sub mnuLunas_Click(sender As Object, e As EventArgs) Handles mnuLunas.Click
        If MsgBox("Apakah anda yakin ingin menjadikan lunas?", vbQuestion + vbYesNo) = vbYes Then
            If dgvData.SelectedCells(3).Value = "Lunas" Then
                MsgBox("Data ini sudah lunas")
                Return
            End If
            Dim jumlahLunas As Double = 0
            jumlahLunas = CDbl(txtJumlahLunas.Text) + CDbl(dgvData.SelectedCells(2).Value)


            txtJumlahLunas.Text = FormatNumber(CDbl(txtJumlahLunas.Text) + CDbl(dgvData.SelectedCells(2).Value))

            Dim myQuery5 As String = "UPDATE Pinjaman Set "
            Dim namaKolom5 As String() = {"JumlahLunas"}
            Dim isiKolom5 As Object() = {CDbl(jumlahLunas)}

            Dim kondisiWhere As String = " where KodePinjaman =@KodePinjaman"
            Dim namaKolom6 As String() = {"KodePinjaman"}
            Dim isiKolom6 As Object() = {txtKodePinjaman.Text}
            clsKoneksi.updateCommand(1, myQuery5, namaKolom5, isiKolom5, kondisiWhere, namaKolom6, isiKolom6, 1)


            Dim myQuery7 As String = "UPDATE PinjamanTagihan Set "
            Dim namaKolom7 As String() = {"Keterangan"}
            Dim isiKolom7 As Object() = {"Lunas"}

            Dim kondisiWhere3 As String = " where IDPinjamanTagihan =@IDPinjamanTagihan"
            Dim namaKolom8 As String() = {"IDPinjamanTagihan"}
            Dim isiKolom8 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.updateCommand(1, myQuery7, namaKolom7, isiKolom7, kondisiWhere3, namaKolom8, isiKolom8, 1)

            MsgBox("Data berhasil lunas")
            frmPinjaman.tampilData()
            tampilData()


        End If
    End Sub
End Class