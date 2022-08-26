Imports System.Data.OleDb
Public Class frmSettingCustomerGrossUp

    Sub tampil()

        Dim myQuery As String = "select NoAccount,Nama,KodeKelompok,GrossUp from customer "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbPilih.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where NoAccount"
            Case 1
                myQuery = myQuery & "where Nama"
        End Select

        myQuery = myQuery & " LIKE '%' + @Cari + '%' and KodeKota='" & clsKoneksi.kotaOn & "' and GrossUp<>0 order by len(noaccount),noaccount"
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

    Private Sub frmSettingCustomerGrossUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPilih.SelectedIndex = 0
        tampil()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        tampil()
    End Sub

    Private Sub btnTambahData_Click(sender As Object, e As EventArgs) Handles btnTambahData.Click
        frmSettingCustomerGrossUpTambah.ShowDialog()
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
        Dim query As String = ""
        Dim cmd As New OleDbCommand
        If MsgBox("Yakin ingin menghapus data ini?", vbQuestion + vbYesNo) = vbYes Then

            query = "UPDATE Customer set GrossUp=0 WHERE NoAccount='" & dgvData.SelectedCells(0).Value & "'"
            cmd = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd.Connection.Close()
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus")
            tampil()

        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Dim indexPilih As Double = 0
        frmSettingCustomerGrossUpEdit.txtNoAcc.Text = dgvData.SelectedCells(0).Value
        frmSettingCustomerGrossUpEdit.txtNamaCust.Text = dgvData.SelectedCells(1).Value
        frmSettingCustomerGrossUpEdit.txtKelompok.Text = dgvData.SelectedCells(2).Value
        If dgvData.SelectedCells(3).Value = "NPWP 100/99.75" Then
            indexPilih = 0
        ElseIf dgvData.SelectedCells(3).Value = "NPWP 50% 100/99.875" Then
            indexPilih = 1
        ElseIf dgvData.SelectedCells(3).Value = "Non NPWP 100/99.5" Then
            indexPilih = 2
        ElseIf dgvData.SelectedCells(3).Value = "Non NPWP 50% 100/99.75" Then
            indexPilih = 3
        End If
        frmSettingCustomerGrossUpEdit.cmbPilih.SelectedIndex = indexPilih
        frmSettingCustomerGrossUpEdit.ShowDialog()
    End Sub
End Class