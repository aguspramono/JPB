Public Class frmSettingCustomerGrossUpCariCustomer

    Sub tampil()
        Dim myQuery As String = "select NoAccount,Nama from customer "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbPilih.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where NoAccount"
            Case 1
                myQuery = myQuery & "where Nama"
        End Select
        myQuery = myQuery & " LIKE '%' + @Cari + '%' and KodeKota='" & clsKoneksi.kotaOn & "' and GrossUp=0 order by len(noaccount),noaccount"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        dgvCustomer.Rows.Clear()
        Dim isiView(1) As Object

        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If

            Next
            dgvCustomer.Rows.Add(isiView)
        Next
    End Sub

    Private Sub frmSettingCustomerGrossUpCariCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dgvCustomerTerpilih.Rows.Clear()
    End Sub

    Private Sub frmSettingCustomerGrossUpCariCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPilih.SelectedIndex = 0
        tampil()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        tampil()
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        If e.ColumnIndex = 2 Then
            dgvCustomer.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not dgvCustomer.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End If

        For i As Integer = 0 To dgvCustomer.Rows.Count() - 1
            Dim rowAlReadyExist As Boolean = False
            Dim check As Boolean = dgvCustomer.Rows(i).Cells(2).Value
            Dim row As DataGridViewRow = dgvCustomer.Rows(i)
            If check = True Then
                If dgvCustomerTerpilih.Rows.Count() = 0 Then
                    For j As Integer = 0 To dgvCustomerTerpilih.Rows.Count() - 1
                        If row.Cells(0).Value.ToString() = dgvCustomerTerpilih.Rows(j).Cells(0).Value.ToString() Then
                            rowAlReadyExist = True
                            Exit For
                        End If
                    Next

                    If rowAlReadyExist = False Then
                        dgvCustomerTerpilih.Rows.Add(row.Cells(0).Value.ToString(),
                                             row.Cells(1).Value.ToString())
                    End If
                Else
                    dgvCustomerTerpilih.Rows.Add(row.Cells(0).Value.ToString(),
                                         row.Cells(1).Value.ToString())
                End If
            Else

                For intJ = dgvCustomerTerpilih.Rows.Count - 1 To 0 Step -1
                    If row.Cells(0).Value.ToString() = dgvCustomerTerpilih.Rows(intJ).Cells(0).Value Then
                        dgvCustomerTerpilih.Rows.RemoveAt(intJ)
                        Exit For
                    End If
                Next


            End If
        Next
        For intI = dgvCustomerTerpilih.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If dgvCustomerTerpilih.Rows(intI).Cells(0).Value = dgvCustomerTerpilih.Rows(intJ).Cells(0).Value Then
                    dgvCustomerTerpilih.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
    End Sub


    Private Sub dgvCustomerTerpilih_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomerTerpilih.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgvCustomerTerpilih.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgvCustomerTerpilih.CurrentCell = Me.dgvCustomerTerpilih.Rows(e.RowIndex).Cells(1)
                Me.mnuKlikkanan.Show(Me.dgvCustomerTerpilih, e.Location)
                Me.mnuKlikkanan.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik data", vbExclamation)
        End Try
    End Sub

    Private Sub mnuHapus_Click(sender As Object, e As EventArgs) Handles mnuHapus.Click
        For i As Integer = 0 To dgvCustomer.Rows.Count - 1
            If dgvCustomer.Rows(i).Cells(0).Value = dgvCustomerTerpilih.SelectedCells(0).Value Then
                dgvCustomer.Rows(i).Cells(2).Value = False
            End If
        Next

        For Each row As DataGridViewRow In dgvCustomerTerpilih.SelectedRows
            dgvCustomerTerpilih.Rows.Remove(row)
        Next

    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        If dgvCustomerTerpilih.Rows.Count() < 1 Then
            MsgBox("Belum ada customer dipilih")
            Return
        End If


        If MsgBox("Yakin customer yang dipilih sudah benar?", vbQuestion + vbYesNo) = vbYes Then

            For i As Integer = 0 To dgvCustomerTerpilih.Rows.Count - 1

                Dim isiView(2) As Object
                isiView(0) = dgvCustomerTerpilih.Rows(i).Cells(0).Value
                isiView(1) = dgvCustomerTerpilih.Rows(i).Cells(1).Value
                frmSettingCustomerGrossUpTambah.dgvView.Rows.Add(isiView)
            Next


            For intI = frmSettingCustomerGrossUpTambah.dgvView.Rows.Count - 1 To 0 Step -1
                For intJ = intI - 1 To 0 Step -1
                    If frmSettingCustomerGrossUpTambah.dgvView.Rows(intI).Cells(0).Value = frmSettingCustomerGrossUpTambah.dgvView.Rows(intJ).Cells(0).Value Then
                        frmSettingCustomerGrossUpTambah.dgvView.Rows.RemoveAt(intI)
                        Exit For
                    End If
                Next
            Next
            Me.Close()

        End If


    End Sub
End Class