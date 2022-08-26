Imports System.Data.OleDb
Public Class frmUpdateHargaCoba
    Sub tampilHeader()
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim ds As DataSet
        Dim dr As OleDbDataReader
        Dim cmd As OleDbCommand = New OleDbCommand("select kodeKelompok,urutanHarga from Kelompok order by urutanHarga asc", clsKoneksi.getConnection(1))
        cmd.Connection.Close()
        cmd.Connection.Open()

        dr = cmd.ExecuteReader
        Dim i As Integer
        Do While dr.Read
            With dgvData.ColumnHeadersDefaultCellStyle
                dgvData.Columns(i).HeaderText = dr.Item(0)
            End With
            i += 1
        Loop

    End Sub

    Private Sub frmUpdateHargaCoba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHeader()
    End Sub
End Class