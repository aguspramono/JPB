Imports System.Data.OleDb
Public Class frmInputSpesialCustomer
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


        myQuery = myQuery & " LIKE '%' + @Cari + '%'  and  (SpesialCustomer<>'Y' or IsNull(SpesialCustomer) or SpesialCustomer='N') and KodeKota='" & clsKoneksi.kotaOn & "' order by len(noaccount),noaccount"
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

        For i As Integer = 0 To dgvData.Rows.Count - 1
            dgvData.Rows(i).Cells(3).Value = True
        Next

    End Sub

    Private Sub frmInputSpesialCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPilih.SelectedIndex = 0
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        tampilData()
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As Object, e As EventArgs) Handles ckPilih.CheckedChanged
        If ckPilih.Checked = True Then
            For i As Integer = 0 To dgvData.Rows.Count - 1
                dgvData.Rows(i).Cells(3).Value = True
            Next
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        dgvData.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim noAccount As String = String.Empty
        Dim dataCek As Double = 0

        For i As Integer = 0 To dgvData.Rows.Count - 1
            If i = 0 Then
                If dgvData.Rows(i).Cells(3).Value = True Then
                    noAccount = "'" & dgvData.Rows(i).Cells(0).Value & "'"
                    dataCek = 1
                End If
            Else
                If dgvData.Rows(i).Cells(3).Value = True Then
                    noAccount = noAccount & ",'" & dgvData.Rows(i).Cells(0).Value & "'"
                    dataCek += 1
                End If
            End If
        Next

        If dataCek = 0 Then
            MsgBox("Tidak ada data terpilih", vbCritical)
            Return
        End If

        If noAccount.Substring(0, 1) = "," Then
            noAccount = "" + noAccount.Substring(1)
        End If

        Dim query As String = "UPDATE Customer SET SpesialCustomer='Y' where NoAccount in(" & noAccount & ")"
        Dim cmd As New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()

        dataCek = 0

        MsgBox("Data berhasil dimasukkan kedalam tagihan spesial")
        tampilData()

    End Sub

End Class