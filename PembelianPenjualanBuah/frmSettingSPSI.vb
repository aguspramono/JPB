Imports System.Data.OleDb
Public Class frmSettingSPSI

    Sub loadDataKaliAccount()
        Dim myQuery As String = "select s.idSPSIKaliAccount,k.KodeKelompok,s.SPSI from SPSIKaliAccount s INNER JOIN Kelompok k on(k.KodeKelompok=s.KodeKelompok) where s.KodeKelompok like '%" & txtCari.Text & "%' and k.KodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvDikaliAccount.Rows.Clear()
        Dim isiView(2) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvDikaliAccount.Rows.Add(isiView)
        Next
    End Sub

    Sub loadDataJumlahAccount()
        Dim myQuery As String = "select s.idSpsiPenjumlahanPerAccount,s.kodePenjumlahanSpsi,s.NoAccount,c.Nama,s.SPSI,s.Utama,s.SPSI2 from SPSIPenjumlahanPerAccount s INNER JOIN customer c on(c.noAccount=s.noAccount) where (c.Nama like '%" & txtCariJumlahSPSI.Text & "%' or s.NoAccount like '%" & txtCariJumlahSPSI.Text & "%') and c.KodeKota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvDataJumlahSPSI.Rows.Clear()
        Dim isiView(6) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvDataJumlahSPSI.Rows.Add(isiView)


            If isiView(5) = "Y" Then
                dgvDataJumlahSPSI.Rows(dgvDataJumlahSPSI.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen
            End If

        Next
    End Sub


    Private Sub btnTambahData_Click(sender As Object, e As EventArgs) Handles btnTambahData.Click
        frmInputSettingSPSIDikaliAccount.modeEdit = False
        frmInputSettingSPSIDikaliAccount.ShowDialog()
    End Sub

    Private Sub frmSettingSPSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataKaliAccount()
        loadDataJumlahAccount()
    End Sub

    Private Sub mnuHapusKaliAccount_Click(sender As Object, e As EventArgs) Handles mnuHapusKaliAccount.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from SPSIKaliAccount where idSPSIKaliAccount=@idSPSIKaliAccount"
            Dim namaKolom2 As String() = {"idSPSIKaliAccount"}
            Dim isiKolom2 As Object() = {dgvDikaliAccount.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            loadDataKaliAccount()
        End If
    End Sub

    Private Sub mnuEditKaliAccount_Click(sender As Object, e As EventArgs) Handles mnuEditKaliAccount.Click
        frmInputSettingSPSIDikaliAccount.modeEdit = True
        frmInputSettingSPSIDikaliAccount.IDEdit = dgvDikaliAccount.SelectedCells(0).Value
        frmInputSettingSPSIDikaliAccount.txtKelompok.Text = dgvDikaliAccount.SelectedCells(1).Value
        frmInputSettingSPSIDikaliAccount.txtSPSI.Text = dgvDikaliAccount.SelectedCells(2).Value
        frmInputSettingSPSIDikaliAccount.btnCariKelompok.Enabled = False
        frmInputSettingSPSIDikaliAccount.ShowDialog()
    End Sub


    Private Sub dgvDikaliAccount_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDikaliAccount.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvDikaliAccount.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvDikaliAccount.CurrentCell = Me.dgvDikaliAccount.Rows(e.RowIndex).Cells(1)
                Me.mnuKlikKananKaliAccount.Show(Me.dgvDikaliAccount, e.Location)
                Me.mnuKlikKananKaliAccount.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loadDataKaliAccount()
    End Sub

    Private Sub btnTambahJumlahSPSI_Click(sender As Object, e As EventArgs) Handles btnTambahJumlahSPSI.Click
        frmInputSettingSPSIJumlahSPSI.ShowDialog()
    End Sub

    Private Sub txtCariJumlahSPSI_TextChanged(sender As Object, e As EventArgs) Handles txtCariJumlahSPSI.TextChanged
        loadDataJumlahAccount()
    End Sub


    Private Sub dgvDataJumlahSPSI_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDataJumlahSPSI.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvDataJumlahSPSI.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvDataJumlahSPSI.CurrentCell = Me.dgvDataJumlahSPSI.Rows(e.RowIndex).Cells(2)
                Me.mnuKlikKananJumlahAccount.Show(Me.dgvDataJumlahSPSI, e.Location)
                Me.mnuKlikKananJumlahAccount.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik bagian data", vbInformation)
        End Try
    End Sub

    Private Sub mnuHapusJumlahAccount_Click(sender As Object, e As EventArgs) Handles mnuHapusJumlahAccount.Click
        If MsgBox("Yakin ingin menghapus data ini ?", vbQuestion + vbYesNo) = vbYes Then

            Dim myQuery2 As String = "delete from detailSPSIPenjumlahanPerAccount where kodePenjumlahanSpsi=@kodePenjumlahanSpsi"
            Dim namaKolom2 As String() = {"kodePenjumlahanSpsi"}
            Dim isiKolom2 As Object() = {dgvDataJumlahSPSI.SelectedCells(1).Value}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)


            Dim myQuery3 As String = "delete from  SPSIPenjumlahanPerAccount where idSpsiPenjumlahanPerAccount=@idSpsiPenjumlahanPerAccount"
            Dim namaKolom3 As String() = {"idSpsiPenjumlahanPerAccount"}
            Dim isiKolom3 As Object() = {dgvDataJumlahSPSI.SelectedCells(0).Value}
            clsKoneksi.deleteCommand(1, myQuery3, namaKolom3, isiKolom3, 1)
            loadDataJumlahAccount()
        End If
    End Sub

    Private Sub mnuJadikanDefaultJumlahAccount_Click(sender As Object, e As EventArgs) Handles mnuJadikanDefaultJumlahAccount.Click
        If MsgBox("Yakin ingin membuat data ini sebagai default?", vbQuestion + vbYesNo) = vbYes Then

            Dim myQuery8 As String = "Update SPSIPenjumlahanPerAccount SET Utama='N' where NoAccount='" & dgvDataJumlahSPSI.SelectedCells(2).Value & "'"
            Dim cmd As New OleDbCommand(myQuery8, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            Dim myQuery9 As String = "Update SPSIPenjumlahanPerAccount SET Utama='Y' where idSpsiPenjumlahanPerAccount=" & dgvDataJumlahSPSI.SelectedCells(0).Value & ""
            Dim cmd1 As New OleDbCommand(myQuery9, clsKoneksi.getConnection(1))
            cmd1.Connection.Open()
            cmd1.ExecuteNonQuery()
            cmd1.Connection.Close()

            loadDataJumlahAccount()
        End If
    End Sub

    Private Sub mnuEditJumlahAccount_Click(sender As Object, e As EventArgs) Handles mnuEditJumlahAccount.Click
        frmInputSettingSPSIJumlahSPSI.modeEdit = True

        Dim myQuery As String = "select * from detailSPSIPenjumlahanPerAccount where kodePenjumlahanSpsi=" & dgvDataJumlahSPSI.SelectedCells(1).Value & ""
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        frmInputSettingSPSIJumlahSPSI.dgvData.Rows.Clear()
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
            frmInputSettingSPSIJumlahSPSI.dgvData.Rows.Add(isiView)
        Next

        frmInputSettingSPSIJumlahSPSI.hitungTotal()

        frmInputSettingSPSIJumlahSPSI.idEdit = dgvDataJumlahSPSI.SelectedCells(0).Value
        frmInputSettingSPSIJumlahSPSI.kodeJumlah = dgvDataJumlahSPSI.SelectedCells(1).Value
        frmInputSettingSPSIJumlahSPSI.noAccount = dgvDataJumlahSPSI.SelectedCells(2).Value

        frmInputSettingSPSIJumlahSPSI.txtCustomer.Text = dgvDataJumlahSPSI.SelectedCells(3).Value
        frmInputSettingSPSIJumlahSPSI.txtSPSI.Text = dgvDataJumlahSPSI.SelectedCells(6).Value
        frmInputSettingSPSIJumlahSPSI.lblSPSI.Text = dgvDataJumlahSPSI.SelectedCells(4).Value
        frmInputSettingSPSIJumlahSPSI.lblSPSI2.Text = FormatNumber(dgvDataJumlahSPSI.SelectedCells(4).Value)

        frmInputSettingSPSIJumlahSPSI.ShowDialog()
    End Sub

    Private Sub btnDikaliNetto_Click(sender As Object, e As EventArgs) Handles btnDikaliNetto.Click
        frmInputSPSIDikaliNetto.ShowDialog()
    End Sub

    Private Sub mnuNormal_Click(sender As Object, e As EventArgs) Handles mnuNormal.Click
        If MsgBox("Yakin ingin membuat data ini normal?", vbQuestion + vbYesNo) = vbYes Then

            Dim myQuery8 As String = "Update SPSIPenjumlahanPerAccount SET Utama='N' where idSpsiPenjumlahanPerAccount=" & dgvDataJumlahSPSI.SelectedCells(0).Value & ""
            Dim cmd As New OleDbCommand(myQuery8, clsKoneksi.getConnection(1))
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            loadDataJumlahAccount()
        End If
    End Sub
End Class