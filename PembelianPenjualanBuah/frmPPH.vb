Imports System.Data.OleDb
Public Class frmPPH

    Sub loadData()
        Dim myQuery As String = "select NoAccount,Nama from customer where"
        myQuery = myQuery & " Nama LIKE '%" & txtCustCari.Text & "%' and KodeKota='" & clsKoneksi.kotaOn & "' order by len(noaccount),noaccount"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(1) As Object

        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    If j = 11 Then
                        If tDs.Tables(0).Rows(i).Item(j) = "Y" Then
                            isiView(j) = True
                        Else
                            isiView(j) = False
                        End If
                    Else
                        isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                    End If
                End If
            Next
            dgvData.Rows.Add(isiView)
        Next
    End Sub

    Private Sub txtPPH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPPH.KeyPress
        clsKoneksi.OnlyNumber(e, txtPPH)
    End Sub

    Private Sub txtCustCari_TextChanged(sender As Object, e As EventArgs) Handles txtCustCari.TextChanged
        loadData()
    End Sub

    Private Sub frmPPH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.ColumnIndex = 2 Then
            dgvData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not dgvData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End If

        For i As Integer = 0 To dgvData.Rows.Count() - 1
            Dim rowAlReadyExist As Boolean = False
            Dim check As Boolean = dgvData.Rows(i).Cells(2).Value
            Dim row As DataGridViewRow = dgvData.Rows(i)
            If check = True Then
                If dgvTerpilih.Rows.Count() = 0 Then
                    For j As Integer = 0 To dgvTerpilih.Rows.Count() - 1
                        If row.Cells(0).Value.ToString() = dgvTerpilih.Rows(j).Cells(0).Value.ToString() Then
                            rowAlReadyExist = True
                            Exit For
                        End If
                    Next

                    If rowAlReadyExist = False Then
                        dgvTerpilih.Rows.Add(row.Cells(0).Value.ToString(),
                                             row.Cells(1).Value.ToString(),
                                             row.Cells(2).Value)

                    End If
                Else
                    dgvTerpilih.Rows.Add(row.Cells(0).Value.ToString(),
                                         row.Cells(1).Value.ToString(),
                                         row.Cells(2).Value)
                End If

            End If
        Next
        For intI = dgvTerpilih.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If dgvTerpilih.Rows(intI).Cells(0).Value = dgvTerpilih.Rows(intJ).Cells(0).Value Then
                    dgvTerpilih.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtPPH.Text = "" Then
            MsgBox("Data pph masih kosong", vbCritical)
            Return
        End If

        Dim query As String
        Dim noAccount As String = String.Empty
        For Each row As DataGridViewRow In dgvTerpilih.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("ck1").Value)
            If isSelected = True Then
                noAccount &= "'" & row.Cells("noAccount").Value.ToString() & "'" & ","
            End If
        Next
        If noAccount = "" Then
            MessageBox.Show("Belum ada data dipilih", "warning")
            Exit Sub
        End If
        noAccount = noAccount.Remove(noAccount.Length - 1, 1)

        query = "update Customer SET PPH=@pph "
        query = query & "WHERE NoAccount in (" & noAccount & ") and kodeKota='" & clsKoneksi.kotaOn & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Parameters.Add("@pph", OleDbType.Double)
        cmd.Connection.Close()
        cmd.Connection.Open()
        cmd.Parameters(0).Value = CDbl(txtPPH.Text)
        cmd.ExecuteNonQuery()

        query = "update Customer SET PPH=@pph2 "
        query = query & "WHERE NoAccount not in (" & noAccount & ") and kodeKota='" & clsKoneksi.kotaOn & "'"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd1.Parameters.Add("@pph2", OleDbType.Double)
        cmd1.Connection.Close()
        cmd1.Connection.Open()
        cmd1.Parameters(0).Value = CDbl(txtPPHDefault.Text)
        cmd1.ExecuteNonQuery()

        MsgBox("Data update")
        loadData()
        dgvTerpilih.Rows.Clear()
    End Sub

    Private Sub txtPPHDefault_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPPHDefault.KeyPress
        clsKoneksi.OnlyNumber(e, txtPPHDefault)
    End Sub

End Class