Imports System.Data.OleDb
Public Class frmPJMLdanSejenis

    Sub loadJPB()
        Dim myQuery As String = ""
        myQuery = "SELECT Pembelian2.NoAccount,Pembelian2.Tgl2,Pembelian2.vehicle, Pembelian2.Product, Pembelian2.Netto, Harga.Harga, ROUND(Harga.Harga*Pjmlsejenis.hargakali/100,0) AS RoundValue,Harga.harga+RoundValue as Hargakurang1,Pembelian2.Netto*Hargakurang1 FROM"
        myQuery = myQuery & " ((Pembelian2 INNER JOIN Pjmlsejenis ON Pembelian2.NoAccount = Pjmlsejenis.NoAccount) INNER JOIN Customer ON Pembelian2.NoAccount = Customer.NoAccount) LEFT JOIN Harga ON Customer.KodeKelompok = Harga.KodeKelompok"
        myQuery = myQuery & " WHERE (((Pembelian2.Tgl2)>=#" & dtpDari.Value.ToString("MM/dd/yyyy") & "# And (Pembelian2.Tgl2)<=#" & dtpSampai.Value.ToString("MM/dd/yyyy") & "#)) AND ((Harga.Tgl)=[Pembelian2].[Tgl2]);"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvHitung.Rows.Clear()
        Dim isiView(8) As Object
        'isiView(0) = ""
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView.Length - 1
                If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView(j) = ""
                Else
                    isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgvHitung.Rows.Add(isiView)
            dgvHitung.Rows(i).Cells(9).Value = True
        Next

        Console.WriteLine(myQuery)
    End Sub

    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga.Click
        loadJPB()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If dgvHitung.Rows.Count < 1 Then
            MsgBox("Data Masih Kosong, Klik cek data terlebih dahulu", vbCritical)
        Else
            Dim query As String = ""
            Dim query2 As String = ""
            Dim spsi As Double = 0
            Dim fee As Double = 0

            'pembelian 2
            query = "Update pembelian2 p set p.hargaAsli=@hargaAsli, p.hargaakhir=@hargaAkhir, p.Fee=@fee,p.spsi=@spsi,p.total=@total where p.NoAccount=@noAccount and p.vehicle=@vehicle and p.Tgl2>=@tglDari and p.Tgl2<=@tglSampai and p.Tgl2=@tgl2"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
            cmd1.Parameters.Add("@hargaAsli", OleDbType.Double)
            cmd1.Parameters.Add("@hargaakhir", OleDbType.Double)
            cmd1.Parameters.Add("@fee", OleDbType.Double)
            cmd1.Parameters.Add("@spsi", OleDbType.Double)
            cmd1.Parameters.Add("@total", OleDbType.VarChar)
            cmd1.Parameters.Add("@noAccount", OleDbType.VarChar)
            cmd1.Parameters.Add("@vehicle", OleDbType.VarChar)
            cmd1.Parameters.Add("@tglDari", OleDbType.DBDate)
            cmd1.Parameters.Add("@tglSampai", OleDbType.DBDate)
            cmd1.Parameters.Add("@tgl2", OleDbType.DBDate)
            cmd1.Connection.Close()
            cmd1.Connection.Open()
            For Each row As DataGridViewRow In dgvHitung.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb").Value)
                If isSelected = True Then
                    cmd1.Parameters(0).Value = row.Cells("hargaAkhir").Value.ToString()
                    cmd1.Parameters(1).Value = row.Cells("hargaAkhir").Value.ToString()
                    cmd1.Parameters(2).Value = fee
                    cmd1.Parameters(3).Value = spsi
                    cmd1.Parameters(4).Value = row.Cells("total").Value.ToString()
                    cmd1.Parameters(5).Value = row.Cells("NoAcc").Value.ToString()
                    cmd1.Parameters(6).Value = row.Cells("vehicle").Value.ToString()
                    cmd1.Parameters(7).Value = dtpDari.Value.Date
                    cmd1.Parameters(8).Value = dtpSampai.Value.Date
                    cmd1.Parameters(9).Value = row.Cells("tanggal").Value
                    cmd1.ExecuteNonQuery()
                End If
            Next
            MsgBox("Berhasil Update")
        End If
    End Sub
End Class