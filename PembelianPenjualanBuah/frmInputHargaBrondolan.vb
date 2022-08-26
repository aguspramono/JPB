Public Class frmInputHargaBrondolan
    Public noAcc As String = ""
    Public idEdit As Double
    Public statusAct As Boolean = False

    Sub tampilData()
        Dim myQuery As String = "select hb.ID,hb.NoAccount,c.Nama,hb.PlatBrond,hb.KodeKelompok,hb.Harga,hb.KodeKota from hargaBrondolan as hb left join Customer as c on(c.NoAccount=hb.NoAccount) where hb.KodeKota='" & clsKoneksi.kotaOn & "'"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(5) As Object
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

    Sub bersih()
        noAcc = ""
        txtCustomer.Clear()
        txtKelompok.Clear()
        txtKodePlat.Clear()
        txtHarga.Text = 0
        statusAct = False
        lockButton(False)
    End Sub

    Sub lockButton(ByVal x As Boolean)
        btnCari.Enabled = x
        btnOk.Enabled = x
        btnBaru.Enabled = Not x
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtCustomer.Text = "" Then
            MsgBox("Customer belum dipilih")
            Return
        End If

        If txtHarga.Text = "" Or txtHarga.Text = 0 Then
            MsgBox("Harga belum diisi atau harga tidak boleh kurang dari 0")
            Return
        End If

        Dim kodePlat As String = txtKodePlat.Text

        Dim kondisiWhere1 As String = ""
        If clsKoneksi.kotaOn = "2" Then
            kondisiWhere1 = " NoAccount='" & noAcc & "' and KodeKelompok='" & txtKelompok.Text & "' and PlatBrond='" & txtKodePlat.Text & "' and KodeKota='" & clsKoneksi.kotaOn & "'"
        Else
            kondisiWhere1 = " NoAccount='" & noAcc & "' and KodeKelompok='" & txtKelompok.Text & "' and KodeKota='" & clsKoneksi.kotaOn & "'"
        End If

        If statusAct = False Then
            Dim myQuery As String = "select * from hargaBrondolan where " & kondisiWhere1 & ""
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
            'isiView(0) = ""
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Customer ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "INSERT INTO hargaBrondolan "
            Dim namaKolom1 As String() = {"NoAccount", "KodeKelompok", "Harga", "KodeKota", "PlatBrond"}
            Dim isiKolom1 As Object() = {noAcc, txtKelompok.Text, CDbl(txtHarga.Text), clsKoneksi.kotaOn, kodePlat.Replace(" ", "")}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            MsgBox("Data berhasil disimpan")
            tampilData()
            bersih()

        Else

            Dim myQuery1 As String = "UPDATE hargaBrondolan Set "
            Dim namaKolom1 As String() = {"Harga", "PlatBrond"}
            Dim isiKolom1 As Object() = {CDbl(txtHarga.Text), kodePlat.Replace(" ", "")}

            Dim kondisiWhere As String = " where ID =@ID"
            Dim namaKolom2 As String() = {"ID"}
            Dim isiKolom2 As Object() = {idEdit}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            MsgBox("Data Berhasil Diubah")

            tampilData()
            bersih()

        End If
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        lockButton(True)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        frmCustomerCari.pilihan = "hargaBrondolan"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub frmInputHargaBrondolan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub dgvData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvData.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvData.CurrentCell = Me.dgvData.Rows(e.RowIndex).Cells(3)
                Me.mnuKlikKanan.Show(Me.dgvData, e.Location)
                Me.mnuKlikKanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        statusAct = True
        Dim i As Integer = dgvData.CurrentRow.Index

        idEdit = dgvData.Item(0, i).Value
        noAcc = dgvData.Item(1, i).Value
        txtCustomer.Text = dgvData.Item(2, i).Value
        txtKodePlat.Text = dgvData.Item(3, i).Value
        txtKelompok.Text = dgvData.Item(4, i).Value
        txtHarga.Text = dgvData.Item(5, i).Value
        lockButton(True)
        btnCari.Enabled = False
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from hargaBrondolan where ID=@ID"
            Dim namaKolom2 As String() = {"ID"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            tampilData()
            bersih()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        clsKoneksi.OnlyNumber(e, txtHarga)
    End Sub
End Class