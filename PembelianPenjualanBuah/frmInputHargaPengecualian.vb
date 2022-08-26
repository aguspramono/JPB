Imports System.Data.OleDb
Public Class frmInputHargaPengecualian
    Sub loadData()
        Dim myQuery As String = "select kodeKelompok,harga from Pengecualian"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvHarga.Rows.Clear()
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
            dgvHarga.Rows.Add(isiView)
        Next
    End Sub
    Private Sub frmInputHargaPengecualian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub ckPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles ckPilihSemua.CheckedChanged
        If ckPilihSemua.Checked = True Then
            For i As Integer = 0 To dgvHarga.Rows.Count() - 1
                dgvHarga.Rows(i).Cells(2).Value = True
            Next
        Else
            For i As Integer = 0 To dgvHarga.Rows.Count() - 1
                dgvHarga.Rows(i).Cells(2).Value = False
            Next
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = ""
        Dim spsi As Double = 0
        Dim fee As Double = 0
        'pembelian 2
        query = "Update pembelian2 p left join customer c on c.noAccount=p.noAccount set p.hargaAsli=@hargaasli,p.hargaakhir=@hargaAkhir, p.Fee=@fee,p.spsi=@spsi,p.total=@hargaakhir*netto where c.kodeKelompok=@kodeKelompok and p.Tgl1>=@tglDari and p.Tgl1<=@tglSampai"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd1.Parameters.Add("@hargaasli", OleDbType.Double)
        cmd1.Parameters.Add("@hargaakhir", OleDbType.Double)
        cmd1.Parameters.Add("@fee", OleDbType.Double)
        cmd1.Parameters.Add("@spsi", OleDbType.Double)
        cmd1.Parameters.Add("@kodeKelompok", OleDbType.VarChar)
        cmd1.Parameters.Add("@tglDari", OleDbType.DBDate)
        cmd1.Parameters.Add("@tglSampai", OleDbType.DBDate)
        cmd1.Connection.Close()
        cmd1.Connection.Open()
        For Each row As DataGridViewRow In dgvHarga.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb").Value)
            If isSelected = True Then
                cmd1.Parameters(0).Value = row.Cells("harga").Value.ToString()
                cmd1.Parameters(1).Value = row.Cells("harga").Value.ToString()
                cmd1.Parameters(2).Value = fee
                cmd1.Parameters(3).Value = spsi
                cmd1.Parameters(4).Value = row.Cells("kdKelompok").Value.ToString()
                cmd1.Parameters(5).Value = dtTglAwal.Value.Date
                cmd1.Parameters(6).Value = dtTanggalAkhir.Value.Date
                cmd1.ExecuteNonQuery()
            End If
        Next
        frmInputHarga.loadCari()
        MsgBox("Berhasil Update")
    End Sub
End Class