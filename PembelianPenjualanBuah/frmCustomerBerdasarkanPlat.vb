Public Class frmCustomerBerdasarkanPlat

    Sub LoadData()
        Dim myQuery As String = "select a.id,a.kodeKelompok,a.plat,a.master from kelompokplat as a"
        myQuery = myQuery
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
            Next
            dgvData.Rows.Add(isiView)

            If dgvData.Rows(i).Cells(3).Value.ToString() = "D" Then
                dgvData.Rows(dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Sub loadCari()
        Dim myQuery As String = "select a.id,a.kodeKelompok,a.plat,a.master from kelompokplat as a where a.plat like '%" & txtPlat.Text & "%'"
        myQuery = myQuery
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
            Next
            dgvData.Rows.Add(isiView)
            If dgvData.Rows(i).Cells(3).Value.ToString() = "D" Then
                dgvData.Rows(dgvData.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Sub bersih()
        lblID.Text = ""
        lblAccount.Text = ""
        txtKodeKelompok.Clear()
        txtPlat.Clear()
    End Sub

    Private Sub frmCustomerBerdasarkanPlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        bersih()
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim akses As String = ""
        If txtKodeKelompok.Text = "" Or txtPlat.Text = "" Then
            MsgBox("Masih ada data yang kosong")
        Else
            Dim myQuery As String = "select * from kelompokplat where"
            Dim namaKolom As String() = {"kodeKelompok", "plat"}
            Dim isiKolom As Object() = {txtKodeKelompok.Text, txtPlat.Text}
            myQuery = myQuery & " kodeKelompok=@kodeKelompok and plat=@plat"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            If ckDefault.Checked = True Then
                akses = "D"
            Else
                akses = ""
            End If

            Dim myQuery1 As String = "INSERT INTO kelompokplat "
            Dim namaKolom1 As String() = {"kodeKelompok", "plat", "master"}
            Dim isiKolom1 As Object() = {txtKodeKelompok.Text, txtPlat.Text, akses}
            clsKoneksi.insertCommand(1, myQuery1, namaKolom1, isiKolom1)
            LoadData()
            bersih()
        End If
    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lblID.Text = "" Then
            MsgBox("Pilih data terlebih dahulu. Double klik pada data")
        Else
            Dim akses As String = ""
            If ckDefault.Checked = True Then
                akses = "D"
            Else
                akses = ""
            End If
            Dim myQuery As String = "select * from kelompokplat where"
            Dim namaKolom As String() = {"kodeKelompok", "plat", "master"}
            Dim isiKolom As Object() = {txtKodeKelompok.Text, txtPlat.Text, akses}
            myQuery = myQuery & " kodeKelompok=@kodeKelompok and plat=@plat and master=@master"
            Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
            If tDs.Tables(0).Rows.Count > 0 Then
                MsgBox("Data ini sudah ada")
                Return
            End If

            Dim myQuery1 As String = "UPDATE kelompokplat Set "
            Dim namaKolom1 As String() = {"kodeKelompok", "plat", "master"}
            Dim isiKolom1 As Object() = {txtKodeKelompok.Text, txtPlat.Text, akses}

            Dim kondisiWhere As String = " where id=@id"
            Dim namaKolom2 As String() = {"id"}
            Dim isiKolom2 As Object() = {lblID.Text}
            clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere, namaKolom2, isiKolom2, 1)
            LoadData()
            bersih()
        End If
    End Sub

    Private Sub btnCariKelompok_Click(sender As Object, e As EventArgs) Handles btnCariKelompok.Click
        frmKelompokCari.pilihanT = "kelompokplat"
        frmKelompokCari.ShowDialog()
    End Sub

    Private Sub btnCariCustomer_Click(sender As Object, e As EventArgs)
        frmCustomerCari.pilihan = "kelompokplat"
        frmCustomerCari.ShowDialog()
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Dim i As Integer = dgvData.CurrentRow.Index
        lblID.Text = dgvData.Item(0, i).Value
        txtKodeKelompok.Text = dgvData.Item(1, i).Value
        txtPlat.Text = dgvData.Item(2, i).Value

        If dgvData.Item(3, i).Value = "D" Then
            ckDefault.Checked = True
        Else
            ckDefault.Checked = False
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
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
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from kelompokplat where id=@id"
            Dim namaKolom2 As String() = {"id"}
            Dim isiKolom2 As Object() = {dgvData.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            LoadData()
            bersih()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        loadCari()
    End Sub

    Private Sub txtPlat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPlat.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            loadCari()
        End If
    End Sub
End Class