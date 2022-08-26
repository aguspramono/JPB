Public Class frmSettingPerhitunganGrossup

    Dim idgross As Double = 0

    Sub tampil()
        Dim myQuery As String = "select * from grossup "
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
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

                If j = 1 Then
                    If tDs.Tables(0).Rows(i).Item(j) = 100 Then
                        isiView(j) = "Ditanggung 100%"
                    ElseIf tDs.Tables(0).Rows(i).Item(j) = 50 Then
                        isiView(j) = "Ditanggung 50%"
                    End If
                End If


                If j = 3 Then
                    If tDs.Tables(0).Rows(i).Item(j) = 1 Then
                        isiView(j) = "NPWP 100/99.75"
                    ElseIf tDs.Tables(0).Rows(i).Item(j) = 2 Then
                        isiView(j) = "NPWP 50% 100/99.875"
                    ElseIf tDs.Tables(0).Rows(i).Item(j) = 3 Then
                        isiView(j) = "Non NPWP 100/99.5"
                    ElseIf tDs.Tables(0).Rows(i).Item(j) = 4 Then
                        isiView(j) = "Non NPWP 50% 100/99.75"
                    End If
                End If

            Next
            dgvData.Rows.Add(isiView)
        Next
    End Sub

    Sub bersih()
        idgross = 0
        cmbJenis.SelectedIndex = 0
        txtangkaGross.Text = 0
        cmbTipe.SelectedIndex = 0
    End Sub


    Private Sub frmSettingPerhitunganGrossup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipe.SelectedIndex = 0
        cmbJenis.SelectedIndex = 0
        tampil()
    End Sub

    Private Sub txtangkaGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtangkaGross.KeyPress
        clsKoneksi.OnlyNumber(e, txtangkaGross)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim jenis As Double = 0
        Dim tipe As Double = 0

        If idgross <> 0 Then
            MsgBox("Tidak bisa menyimpan data, klik batal untuk membatalkan pengeditan data")
            Return
        End If

        If txtangkaGross.Text = "0" Or txtangkaGross.Text = "" Then
            MsgBox("Angka gross up tidak boleh kosong")
            Return
        End If

        Dim intT As Integer = cmbJenis.SelectedIndex
        Select Case intT
            Case 0
                jenis = 100
            Case 1
                jenis = 50
        End Select

        Dim intJ As Integer = cmbTipe.SelectedIndex
        Select Case intJ
            Case 0
                tipe = 1
            Case 1
                tipe = 2
            Case 2
                tipe = 3
            Case 3
                tipe = 4
        End Select

        Dim myQuery1 As String = "INSERT INTO grossup "
        Dim namaKolom1 As String() = {"jenisDitanggung", "angkaBagi", "tipeGrossup"}
        Dim isiKolom1 As Object() = {jenis, CDbl(txtangkaGross.Text), tipe}
        clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)

        MsgBox("Berhasil Disimpan")
        tampil()
        bersih()

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
            MsgBox("Klik data", vbExclamation)
        End Try
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then

            Dim myQuery2 As String = "delete from grossup where idGrossup=@idGrossup"
            Dim namaKolom2 As String() = {"idGrossup"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            MsgBox("Berhasil Hapus")
            tampil()
            bersih()

        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Dim jenis As Integer
        Dim tipe As Integer
        idgross = dgvData.SelectedCells(0).Value

        If dgvData.SelectedCells(1).Value = "Ditanggung 100%" Then
            jenis = 0
        ElseIf dgvData.SelectedCells(1).Value = "Ditanggung 50%" Then
            jenis = 1
        End If


        If dgvData.SelectedCells(3).Value = "NPWP 100/99.75" Then
            tipe = 0
        ElseIf dgvData.SelectedCells(3).Value = "NPWP 50% 100/99.875" Then
            tipe = 1
        ElseIf dgvData.SelectedCells(3).Value = "Non NPWP 100/99.5" Then
            tipe = 2
        ElseIf dgvData.SelectedCells(3).Value = "Non NPWP 50% 100/99.75" Then
            tipe = 3
        End If

        cmbJenis.SelectedIndex = jenis
        txtangkaGross.Text = dgvData.SelectedCells(2).Value
        cmbTipe.SelectedIndex = tipe

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idgross = 0 Then
            MsgBox("Pilih data terlebih dahulu dengan klik kanan pada data lalu pilih edit")
            Return
        End If

        Dim jenis As Double = 0
        Dim tipe As Double = 0

        Dim intT As Integer = cmbJenis.SelectedIndex
        Select Case intT
            Case 0
                jenis = 100
            Case 1
                jenis = 50
        End Select

        Dim intJ As Integer = cmbTipe.SelectedIndex
        Select Case intJ
            Case 0
                tipe = 1
            Case 1
                tipe = 2
            Case 2
                tipe = 3
            Case 3
                tipe = 4
        End Select

        Dim myQuery1 As String = "UPDATE grossup Set "
        Dim namaKolom1 As String() = {"jenisDitanggung", "angkaBagi", "tipeGrossup"}
        Dim isiKolom1 As Object() = {jenis, CDbl(txtangkaGross.Text), tipe}

        Dim kondisiWhere As String = " where idGrossup =@idGrossup"
        Dim namaKolom2 As String() = {"idGrossup"}
        Dim isiKolom2 As Object() = {idgross}
        clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
        MsgBox("Berhasil Edit")
        tampil()
        bersih()
    End Sub
End Class