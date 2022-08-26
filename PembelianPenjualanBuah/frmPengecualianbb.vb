Imports System.Data.OleDb
Public Class frmPengecualianbb
    Sub loadData()
        Dim myQuery As String = "select a.id,a.noAccount,b.Nama,a.kodeKelompok,a.harga from pengecualianbb as a inner join customer as b on b.noAccount=a.noAccount"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvData.Rows.Clear()
        Dim isiView(4) As Object
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
    Private Sub frmPengecualianbb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub ckPilihan_CheckedChanged(sender As Object, e As EventArgs) Handles ckPilihan.CheckedChanged
        If ckPilihan.Checked = True Then
            For i As Integer = 0 To dgvData.Rows.Count() - 1
                dgvData.Rows(i).Cells(5).Value = True
            Next
        Else
            For i As Integer = 0 To dgvData.Rows.Count() - 1
                dgvData.Rows(i).Cells(5).Value = False
            Next
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim query As String = ""
        'pembelian 2
        query = "Update pembelian2 p left join customer c on c.noAccount=p.noAccount set p.hargaakhir=p.hargaakhir-@harga,p.total=p.hargaakhir*netto where c.kodeKelompok=@kodeKelompok and p.noAccount=@noAccount and p.Tgl1>=@tglDari and p.Tgl1<=@tglSampai"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd1.Parameters.Add("@harga", OleDbType.Double)
        cmd1.Parameters.Add("@kodeKelompok", OleDbType.VarChar)
        cmd1.Parameters.Add("@noAccount", OleDbType.VarChar)
        cmd1.Parameters.Add("@tglDari", OleDbType.DBDate)
        cmd1.Parameters.Add("@tglSampai", OleDbType.DBDate)
        cmd1.Connection.Close()
        cmd1.Connection.Open()
        For Each row As DataGridViewRow In dgvData.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb1").Value)
            If isSelected = True Then
                cmd1.Parameters(0).Value = row.Cells("harga").Value.ToString()
                cmd1.Parameters(1).Value = row.Cells("kodeKelompok").Value.ToString()
                cmd1.Parameters(2).Value = row.Cells("noAcc").Value.ToString()
                cmd1.Parameters(3).Value = dtpAwal.Value.Date
                cmd1.Parameters(4).Value = dtpAkhir.Value.Date
                cmd1.ExecuteNonQuery()
            End If
        Next
        frmInputHarga.loadCari()
        MsgBox("Berhasil Update")
    End Sub
End Class