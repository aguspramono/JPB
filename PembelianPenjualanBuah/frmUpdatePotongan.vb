Imports System.Data.OleDb
Public Class frmUpdatePotongan
    Sub loadData()
        Dim myQuery As String = "select kodeKelompok,potongan from Potongan where  kodeKota='" & clsKoneksi.kotaOn & "'"
        'Dim myQuery As String = "select C.kodeKelompok from pembelian P left join customer C on C.noAccount=P.noAccount"
        myQuery = myQuery
        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgvPotongan.Rows.Clear()
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
            dgvPotongan.Rows.Add(isiView)
        Next
    End Sub
    Private Sub frmUpdatePotongan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga.Click
        Dim query As String = ""
        query = "Update pembelian2 p left join customer c on c.noAccount=p.noAccount set p.potongan=@potongan where c.kodeKelompok=@kodeKelompok and Tgl1>=@tglDari and Tgl1<=@tglSampai"
        Dim cmd As OleDbCommand = New OleDbCommand(query, clsKoneksi.getConnection(1))
        cmd.Parameters.Add("@potongan", OleDbType.Double)
        cmd.Parameters.Add("@kodeKelompok", OleDbType.VarChar)
        cmd.Parameters.Add("@tglDari", OleDbType.DBDate)
        cmd.Parameters.Add("@tglSampai", OleDbType.DBDate)
        cmd.Connection.Close()
        cmd.Connection.Open()
        For Each row As DataGridViewRow In dgvPotongan.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb1").Value)
            If isSelected = True Then
                cmd.Parameters(0).Value = row.Cells("potongan").Value.ToString()
                cmd.Parameters(1).Value = row.Cells("kdKelompok").Value.ToString()
                cmd.Parameters(2).Value = dtpTanggalDari.Value.Date
                cmd.Parameters(3).Value = dtpTanggalSampai.Value.Date
                cmd.ExecuteNonQuery()
            End If
        Next
        MsgBox("Berhasil Update")
    End Sub

    Private Sub ckPilihSemua_CheckedChanged(sender As Object, e As EventArgs) Handles ckPilihSemua.CheckedChanged
        If ckPilihSemua.Checked = True Then
            For i As Integer = 0 To dgvPotongan.Rows.Count() - 1
                dgvPotongan.Rows(i).Cells(2).Value = True
            Next
        Else
            For i As Integer = 0 To dgvPotongan.Rows.Count() - 1
                dgvPotongan.Rows(i).Cells(2).Value = False
            Next
        End If
    End Sub
End Class