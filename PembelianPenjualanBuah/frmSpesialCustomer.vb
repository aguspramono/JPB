Imports System.Data.OleDb
Public Class frmSpesialCustomer

    Sub tampilData()
        Dim myQuery As String = "select NoAccount,Nama,KodeKelompok from customer "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {txtCari.Text}

        Dim intT As Integer = cmbPilih.SelectedIndex
        Select Case intT
            Case 0
                myQuery = myQuery & "where NoAccount"
            Case 1
                myQuery = myQuery & "where Nama"
            Case 2
                myQuery = myQuery & "where KodeKelompok"
        End Select


        myQuery = myQuery & " LIKE '%' + @Cari + '%'  and  SpesialCustomer='Y' and KodeKota='" & clsKoneksi.kotaOn & "' order by len(noaccount),noaccount"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        'Console.WriteLine(myQuery)
        dgvData.Rows.Clear()
        Dim isiView(2) As Object
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
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmInputSpesialCustomer.ShowDialog()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        tampilData()
    End Sub

    Private Sub frmSpesialCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPilih.SelectedIndex = 0
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

    Private Sub mnuHilangkan_Click(sender As Object, e As EventArgs) Handles mnuHilangkan.Click
        Dim query As String = "UPDATE Customer SET SpesialCustomer='' where NoAccount='" & dgvData.SelectedCells(0).Value & "'"
        Dim cmd As New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        MsgBox("Data berhasil dihilangkan dari daftar spesial")
        tampilData()
    End Sub
End Class